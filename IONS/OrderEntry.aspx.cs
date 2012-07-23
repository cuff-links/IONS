using System;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using IONS.ZipWebService;
using Telerik.Charting;
using Telerik.Web.UI;

namespace IONS
{
    public partial class OrderEntry : System.Web.UI.Page
    {
        //Create client object and string array for selectedproductIds.
        static Client client;

        static string[] currentSelectedProducts = new string[10];

        private static ChartSeries chartSeries = new ChartSeries
                                                {
                                                    Name = "Category",
                                                    Type = ChartSeriesType.Pie
                                                };

        protected void Page_Load(object sender, EventArgs e)
        {
            // add the RadChart to the page.
            //If the page is not a postback, hide the divs for the future steps.
            if (!Page.IsPostBack)
            {
                ajaxPanelPageScripts.ResponseScripts.Add("$('#step4').hide();");
                ajaxPanelPageScripts.ResponseScripts.Add("$('#step3').hide();");
                ajaxPanelPageScripts.ResponseScripts.Add("$('#step2').hide();");
            }
            //Set date of birth calendar, duedate calendar to default values.
            dateDob.MaxDate = DateTime.Now.AddYears(-18);
            dateDob.MinDate = DateTime.Now.AddYears(-100);
            calDueDate.RangeMinDate = DateTime.Now.AddDays(3);
            calDueDate.RangeMaxDate = DateTime.Now.AddMonths(3);
            calDueDate.ShowOtherMonthsDays = false;

            //If the user is not in sales or an administration, disable all controls.
            if (!Page.User.IsInRole("Admin") && !Page.User.IsInRole("Sales"))
            {
                txtSSN.ReadOnly = true;
                txtFirstName.ReadOnly = true;
                txtMiddleName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtZipCode.ReadOnly = true;
                dateDob.Enabled = false;
                txtContact.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cboReferred.Enabled = false;
                btnValidateZip.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        protected void BtnSubmitClick(object sender, EventArgs e)
        {
            //Gather variables from the fields that were filled out in the form.
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            int zipCode = Convert.ToInt32(txtZipCode.Text);
            string socialSecurity = txtSSN.Text;
            var dateOfBirth = Convert.ToDateTime(dateDob.SelectedDate);
            string contactNumber = txtContact.Text;
            string referralNumber = txtReferralNum.Text;
            string email = txtEmail.Text;
            var dateEst = DateTime.Today;

            //Create a new Client object and set the attributes to the received variables.
            client = new Client
                           {
                               FirstName = firstName,
                               LastName = lastName,
                               MiddleName = middleName,
                               Address = address,
                               Balance = 0,
                               City = city,
                               ContactNumber = contactNumber,
                               DateEstablished = dateEst,
                               ZipCode = zipCode,
                               State = state,
                               SocialSecurity = socialSecurity,
                               ReferralNumber = referralNumber,
                               Email = email,
                               DateOfBirth = dateOfBirth,
                               ReferredBit = cboReferred.SelectedIndex
                           };

            //If CheckIfCustomerExists method comes back false, this is a new client. Hide step 1, show step 2.
            if (!client.CheckIfCustomerExists())
            {
                windowManager.RadAlert("New client verification successful! Please move on to Step #2.",
                    250, 125, "New Client", "showStep2");
            }
            else
            {
                windowManager.RadAlert("Client already exists in the system. Please use client search to verify.",
                    250, 125, "Existing Client", "");
            }
        }

        protected void BtnResetClick(object sender, EventArgs e)
        {
            //Reset form to the default values.
            ClearCustomerInfo();
            txtFirstName.Focus();
            btnValidateZip.Enabled = true;
            btnSubmit.Enabled = false;
        }

        private void ClearCustomerInfo()
        {
            //Set all information in step one to default values.
            txtAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtZipCode.Text = "";
            txtContact.Text = "";
            txtSSN.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            dateDob.Clear();
            txtReferralNum.Text = "0";
            cboReferred.SelectedIndex = 0;
            txtReferralNum.ReadOnly = true;
        }

        private void GetCityState(string zip)
        {
            //Try to access web service and get the city and state from the supplied zipcode.
            try
            {
                var soapClient = new USZipSoapClient("USZipSoap");
                var allNodes = soapClient.GetInfoByZIP(zip);
                var x = XDocument.Parse(allNodes.InnerXml);
                var city = x.Descendants("CITY").Select(m => m.Value);
                var state = x.Descendants("STATE").Select(m => m.Value);
                txtCity.Text = city.First();
                txtState.Text = state.First();
                btnSubmit.Enabled = true;
            }
            catch (XmlException)
            {
                //The zip code given was invalid. Allow user to retry.
                txtCity.Text = "";
                txtState.Text = "";
                windowManager.RadAlert("Invalid Zip Code. Check zip code and validate again.", 250, 125, "Zip Code Invalid", "");
            }
            catch (EndpointNotFoundException)
            {
                //Web service not available. Allow user to manually enter information.
                windowManager.RadAlert("Zip Code Lookup is unavailable. Please enter city and state manually.", 250, 125, "Zip Look-up Unavailable", "");
                txtCity.Enabled = true;
                txtCity.ReadOnly = false;
                txtState.Enabled = true;
                txtState.ReadOnly = false;
                btnValidateZip.Enabled = false;
                btnSubmit.Enabled = true;
            }
        }

        protected void BtnValidateClick(object sender, EventArgs e)
        {
            //Call method to validate zip code.
            GetCityState(txtZipCode.Text);
        }

        protected void CboReferredSelectedIndexChanged(object sender, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            //Disable and enable referralNum textbox when selectedindex changed.
            switch (cboReferred.SelectedIndex)
            {
                case 1:
                    {
                        txtReferralNum.ReadOnly = false;
                        break;
                    }
                case 0:
                    {
                        txtReferralNum.ReadOnly = true;
                        txtReferralNum.Text = "0";
                        break;
                    }
            }
        }

        protected void GridViewProductSelectSelectedIndexChanged(object sender, EventArgs e)
        {
            double runningTotal = 0;
            //Add up all of the selected items' prices and set to the label.
            foreach (GridDataItem dataItem in gridViewProductSelect.SelectedItems)
            {
                runningTotal += Convert.ToDouble(dataItem["Price"].Text);
            }
            lblMonthlyTotal.Text = String.Format("{0:C}", runningTotal);
        }

        protected void BtnOrderProductsClick(object sender, EventArgs e)
        {
            //If at least one item was selected, build a message with the
            //summary of what is being ordered. It is up to the representative
            //to make sure valid products are being selected.
            if (gridViewProductSelect.SelectedItems.Count != 0)
            {
                //Only up to 10 items can be selected. If less, build message with the
                //details of the order including all selected products and the price.
                //Show in an alert.
                if (gridViewProductSelect.SelectedItems.Count <= 10)
                {
                    var orderMessage = new StringBuilder("<strong>Product Summary:</strong><br /><table>");
                    int i = 0;
                    foreach (GridDataItem dataItem in gridViewProductSelect.SelectedItems)
                    {
                        orderMessage.Append("<tr>");
                        orderMessage.Append("<td>" + dataItem["Category"].Text + "</td>");
                        orderMessage.Append("<td>" + dataItem["Name"].Text + "</td>");
                        orderMessage.Append("<td>" + String.Format("{0:C}", Convert.ToDouble(dataItem["Price"].Text)) +
                                            "</td>");
                        orderMessage.Append("</tr>");
                        currentSelectedProducts[i] = (string)dataItem.GetDataKeyValue("ProductID");
                        txtProductsOrderedFinal.Text += dataItem["Name"].Text + " " + dataItem["Price"].Text + Environment.NewLine;
                        i++;
                    }
                    orderMessage.Append("<tr><td><strong>" + "Monthly Total:</strong></td>" + "<td><strong>" +
                                        lblMonthlyTotal.Text + "</strong></td></tr></table>");
                    windowManager.RadConfirm(orderMessage.ToString(), "confirmCallBackFn", 400, 175, null,
                                             "Order These Products?");
                }
                else
                {
                    //If more than 10 products selected, alert user.
                    windowManager.RadAlert("Initial order can only contain up to 10 products", 250, 125, "Product Selection Error", "");
                }
            }
            else
            {
                //If no item is selected, display alert.
                windowManager.RadAlert("Please select at least one valid product", 250, 125, "No Product Selected", "");
            }
        }

        protected void BtnSubmitOrderDetailsClick(object sender, EventArgs e)
        {
            //Confirm that the user is ready to proceed.

            //Set the duedate , orderComments, selectedproducts, and salesId properties.
            client.DueDate = calDueDate.SelectedDate;
            client.OrderComments = txtOrderComments.Text;
            client.SelectedProducts = currentSelectedProducts;
            client.SalesId = client.RetrieveSalesId(Page.User.Identity.Name);

            txtNameFinal.Text = client.FirstName + " " + client.LastName;
            txtaddressFinal.Text = client.Address;
            txtCityStateFinal.Text = client.City + "/" + client.State + "/" + client.ZipCode;
            txtSSNFinal.Text = client.SocialSecurity.Insert(5, "-").Insert(3, "-");
            txtContactFinal.Text = client.ContactNumber.Insert(0, "(").Insert(4, ")").Insert(5, " ").Insert(
                        9, "-");
            txtReferralNumFinal.Text = client.ReferralNumber;
            txtSalesIdFinal.Text = client.RetrieveSalesId(Page.User.Identity.Name);
            txtCommentsFinal.Text = client.OrderComments;
            txtDueDateFinal.Text = client.DueDate.ToShortDateString();
            txtEmailFinal.Text = client.Email;
            txtDOBFinal.Text = client.DateOfBirth.ToShortDateString();
            switch (client.ReferredBit)
            {
                case (0):
                    {
                        txtReferredFianl.Text = "No";
                        break;
                    }
                case (1):
                    {
                        txtReferredFianl.Text = "Yes";
                        break;
                    }
            }
            windowManager.RadAlert("Details recorded. Please recap with client in step 4.", 250, 125, "Order Details Recorded", "showStep4");
        }

        protected void BtnFinalizeClick(object sender, EventArgs e)
        {
            //If the AddCustomer method returns true, Show alert and then redirect to the customer search page.
            if (client.AddCustomer())
            {
                windowManager.RadAlert("Congratulations! Client successfully added!", 250, 125, "Client Entry Success", "TransferToClientSearch");
            }
            else
            {
                windowManager.RadAlert("Client not successfully entered. Please try again.", 250, 125, "Client Entry Error", "");
            }
        }
    }
}