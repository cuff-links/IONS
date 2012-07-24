using System;
using System.Data.Common;
using System.Text;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace IONS
{
    public partial class CustomerSearch : System.Web.UI.Page
    {
        //Instantiate client class variables and string for selectedCustomer
        private Client client = new Client();

        private string selectedCustomer;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.IsInRole("Sales") || Page.User.IsInRole("Billing") || Page.User.IsInRole("Provisioning"))
            {
                btnPlaceOrder.Visible = false;
                btnEdit.Visible = false;
            }
        }

        protected void CustomerSearchGridViewItemDataBound(object sender, GridItemEventArgs e)
        {
            //Remove resize textbox so gridview can only show a certain amount of results per page.
            if (e.Item is GridPagerItem)
            {
                var pageTextBox = (RadNumericTextBox)e.Item.FindControl("ChangePageSizeTextBox");
                var pageLabel = (Label)e.Item.FindControl("ChangePageSizeLabel");
                var pageButton = (Button)e.Item.FindControl("ChangePageSizeLinkButton");
                pageTextBox.Visible = false;
                pageLabel.Visible = false;
                pageButton.Visible = false;
            }
        }

        protected void CustomerSearchGridViewSelectedIndexChanged(object sender, EventArgs e)
        {
            //Create array of all textboxes that will need to be populated when Client is selected.
            //created array of objects that will be popualated by the datareader that is retrieved.
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtContactNum.ReadOnly = true;
            btnPlaceOrder.Enabled = true;
            btnViewProducts.Enabled = true;
            if (Page.User.IsInRole("Admin") || Page.User.IsInRole("Service"))
            {
                btnEdit.Enabled = true;
                btnEdit.Visible = true;
            }
            btnSave.Visible = false;
            RadAjaxManager1.ResponseScripts.Add("HideValidationErrors();");
            if (Page.User.IsInRole("Admin"))
            {
                btnDeleteClient.Visible = true;
                btnDeleteConfirm.Visible = false;
                btnDeleteClient.Enabled = true;
            }

            //created long for the Client number of the selected Client from the Gridview. Instantiate new
            //Client class and retrieve the data for that Client.
            foreach (GridDataItem dataItem in customerSearchGridView.SelectedItems)
            {
                selectedCustomer =
                dataItem["Client#"].Text;
            }
            client.ClientNumber = selectedCustomer;

            //Check if SearchCustomer is true (successful). If so, check if any rows were retrieved.
            //if so, get the values that are in the rows and put them in the values object.
            if (client.SearchCustomer())
            {
                //Call the fillCustomerInfo method passing the textboxes that need to be changed and
                //the received values from the datareader.
                PullCustomerData();

                //Close the open connection to the datareader.
                client.CloseConnection();
            }
            else
            {
                windowManager.RadAlert("Error retrieving client data. Please try again.", 250, 125, "Client Search Error", "");
            }
        }

        public void FillCustomerOverviewInfo(object[] customerInfo)
        {
            //Create array of textboxes from the UI.
            var customerOverviewTextBoxes = new TextBox[]
                                                {
                                                    txtClientNum, txtFirstName, txtLastName,
                                                    txtAddress, txtCity, txtState, txtZip, txtDOB, txtSSN, txtContactNum
                                                    , txtDateEst, txtBalance
                                                };

            //Populate textboxes with the data retrieved and format the appropriate the boxes.
            for (int i = 0; i < customerOverviewTextBoxes.Length; i++)
            {
                if (customerOverviewTextBoxes[i] == txtDOB || customerOverviewTextBoxes[i] == txtDateEst)
                {
                    customerOverviewTextBoxes[i].Text = String.Format("{0:MM/dd/yyyy}", customerInfo[i]);
                }
                else if (customerOverviewTextBoxes[i] == txtSSN)
                {
                    customerOverviewTextBoxes[i].Text = customerInfo[i].ToString().Insert(5, "-").Insert(3, "-");
                }
                else if (customerOverviewTextBoxes[i] == txtContactNum)
                {
                    customerOverviewTextBoxes[i].Text = customerInfo[i].ToString().Insert(0, "(").Insert(4, ")").Insert(5, " ").Insert(
                        9, "-");
                }
                else
                {
                    customerOverviewTextBoxes[i].Text = customerInfo[i].ToString();
                }
            }
        }

        protected void BtnEditClick(object sender, EventArgs e)
        {
            //Set the textboxes to be able to be edited and clear the appropriate the boxes.
            btnEdit.Visible = false;
            btnSave.Visible = true;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtZip.ReadOnly = false;
            txtState.ReadOnly = false;
            txtContactNum.ReadOnly = false;
            txtCity.Text = "";
            txtAddress.Text = "";
            txtContactNum.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtAddress.Focus();
            btnPlaceOrder.Enabled = false;
            btnViewProducts.Enabled = false;
            if (Page.User.IsInRole("Admin"))
            {
                btnDeleteClient.Visible = true;
                btnDeleteClient.Enabled = false;
                btnDeleteConfirm.Visible = false;
            }
        }

        protected void BtnSaveClick(object sender, EventArgs e)
        {
            //Set the properties to the text values.
            client.ClientNumber = txtClientNum.Text;
            client.Address = txtAddress.Text;
            client.ContactNumber = txtContactNum.Text;
            client.City = txtCity.Text;
            client.State = txtState.Text;
            client.ZipCode = Convert.ToInt32(txtZip.Text);

            //If updateClientinfo returns true go to SearchTheCustomer that was just updated.
            if (client.UpdateClientInfo())
            {
                //If searchCustomer is true the customer was positively inserted.
                if (client.SearchCustomer())
                {
                    //Pull the data for the customer and populate boxes again. Then notify user and close connection.
                    PullCustomerData();
                    windowManager.RadAlert("Client was updated successfully.", 250, 125, "Client Update Success", "");
                    client.CloseConnection();
                }
                else
                {
                    //Alert user that there was an error updating client.
                    windowManager.RadAlert("Error updating client data. Please try again.", 250, 125, "Client Update Error", "");
                }
            }
            //Set boxes to readonly again. Make the buttons enabled again.
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtContactNum.ReadOnly = true;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            btnPlaceOrder.Enabled = true;
            btnViewProducts.Enabled = true;
            if (Page.User.IsInRole("Admin"))
            {
                btnDeleteClient.Visible = true;
                btnDeleteConfirm.Visible = false;
                btnDeleteClient.Enabled = true;
            }
        }

        #region UnusedRemoveSpecialCharsMethod

        private string RemoveSpecialChars(string changeMe)
        {
            var invalidChars = new string[] { ",", "-", "(", ")" };
            for (int i = 0; i < invalidChars.Length; i++)
            {
                if (changeMe.Contains(invalidChars[i]))
                {
                    changeMe = changeMe.Replace(invalidChars[i], "");
                }
            }
            return changeMe;
        }

        #endregion UnusedRemoveSpecialCharsMethod

        //Method to pull the customer's data.
        private void PullCustomerData()
        {
            //Instantiate an array with for the customer's info. If CustomerSearch returns rows,
            //add the values to the array and then call the FillCustomerOverviewInfo method while
            //passing the array.
            var customerInfo = new object[12];
            if (client.CustomerSearch.HasRows)
            {
                while (client.CustomerSearch.Read())
                {
                    client.CustomerSearch.GetValues(customerInfo);
                }
                FillCustomerOverviewInfo(customerInfo);
            }
            else
            {
                //Alert user there was an error retrieving client data.
                windowManager.RadAlert("Error retrieving client data. Please try again.", 250, 125, "Client Search Error", "");
            }
        }

        protected void BtnPlaceOrderClick(object sender, EventArgs e)
        {
            //Store the selected client's Client# to be received on OrderSearch page. Then transfer.
            Session["OrderingClient"] = txtClientNum.Text;
            Response.Redirect("~/OrderSearch.aspx", true);
        }

        protected void BtnViewProductsClick(object sender, EventArgs e)
        {
            foreach (GridDataItem dataItem in customerSearchGridView.SelectedItems)
            {
                client.ClientNumber = dataItem["Client#"].Text;
            }
            if (client.ViewClientProducts())
            {
                var clientProduct = new StringBuilder("<strong>Selected Products:</strong><br /><table>");
                double runningTotal = 0;
                foreach (DbDataRecord dataItem in client.ViewCustomerProducts)
                {
                    clientProduct.Append("<tr>");
                    clientProduct.Append("<td>" + dataItem.GetString(0) + "</td>");
                    clientProduct.Append("<td>" + dataItem.GetString(1) + "</td>");
                    clientProduct.Append("<td>" + String.Format("{0:C}", dataItem.GetValue(2)) +
                                        "</td>");
                    clientProduct.Append("</tr>");
                    runningTotal += Convert.ToDouble(dataItem.GetValue(2));
                }
                clientProduct.Append("<tr><td><strong>" + "Monthly Total:</strong></td>" + "<td><strong>" +
                                    String.Format("{0:C}", runningTotal) + "</strong></td></tr></table>");

                windowManager.RadAlert(clientProduct.ToString(), 400, 200, "Selected Products", "");
                client.CloseConnection();
            }
            else
            {
                windowManager.RadAlert("Error retrieving selected products", 250, 125, "Product Retrieval Error", "");
                client.CloseConnection();
            }
        }

        protected void BtnDeleteClientClick(object sender, EventArgs e)
        {
            btnDeleteClient.Visible = false;
            btnDeleteConfirm.Visible = true;
        }

        protected void BtnDeleteConfirmClick(object sender, EventArgs e)
        {
            client.ClientNumber = txtClientNum.Text;
            if (client.DeleteClient())
            {
                windowManager.RadAlert("Client " + client.ClientNumber + " has been deleted successfully.", 250, 125
                    , "Client Delete Success", "TransferToClientSearch");
            }
            else
            {
                windowManager.RadAlert("Client " + client.ClientNumber + " was not successfully deleted. Please try again.", 250, 125
                    , "Client Delete Error", "TransferToClientSearch");
            }
        }
    }
}