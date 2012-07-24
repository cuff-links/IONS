using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace IONS
{
    public partial class OrderSearch : Page
    {
        //Instantiate class variables. Create separate object for order that is being searched and
        //New order being placed so properties are maintained separately.
        private static string orderingClient;

        private static Order searchedOrder = new Order();
        private static Order placingOrder = new Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set range of calendar
            dateDueDateWindow.MaxDate = DateTime.Now.AddMonths(3);
            dateDueDateWindow.MinDate = DateTime.Now.AddDays(3);
            //Set orderingClient variable to session variable.
            if ((string)Session["OrderingClient"] == null)
            {
                windowPlaceOrder.VisibleOnPageLoad = false;
                windowExistingOrder.VisibleOnPageLoad = false;
            }
            else
            {
                //Check if there is a current order in the system, if not, show place order window
                //If so, show existing order window.
                orderingClient = (string)Session["OrderingClient"];
                Session["OrderingClient"] = null;
                placingOrder.ClientNumber = orderingClient;
                if (placingOrder.SearchExistingOrder())
                {
                    windowPlaceOrder.VisibleOnPageLoad = false;
                }
                else
                {
                    windowExistingOrder.VisibleOnPageLoad = false;
                    var lblClientNumber =
                        (Label)windowPlaceOrder.ContentContainer.FindControl("lblPlaceOrderWindow");
                    lblClientNumber.Text += placingOrder.ClientNumber;

                    if (placingOrder.PullOrderingClientDetails())
                    {
                        if (placingOrder.OrderingClient.HasRows)
                        {
                            FillOrderWindowTextboxes();
                        }
                        else
                        {
                            //Display error message.
                            windowPlaceOrder.VisibleOnPageLoad = false;
                            windowManager.RadAlert("There was an error retrieving the client's data." +
                                                   "Please try again.", 250, 125, "Client Data Error", "");
                        }
                    }
                }
            }
        }

        public void FillOrderWindowTextboxes()
        {
            //Fil textboxes with values from OrderingClient.
            var nameWindow =
                        (TextBox)windowPlaceOrder.ContentContainer.FindControl("txtNameWindow");
            var addressWindow =
                        (TextBox)windowPlaceOrder.ContentContainer.FindControl("txtAddressWindow");
            var cityStateWindow =
                        (TextBox)windowPlaceOrder.ContentContainer.FindControl("txtCityStateWindow");
            var contactNumWindow =
                        (TextBox)windowPlaceOrder.ContentContainer.FindControl("txtContactNumWindow");
            var clientData = new object[4];
            while (placingOrder.OrderingClient.Read())
            {
                placingOrder.OrderingClient.GetValues(clientData);
            }
            nameWindow.Text = clientData[0].ToString();
            addressWindow.Text = clientData[1].ToString();
            cityStateWindow.Text = clientData[2].ToString();
            contactNumWindow.Text = clientData[3].ToString().Insert(0, "(").Insert(4, ")"
                ).Insert(5, " ").Insert(9, "-");
        }

        protected void OrderSearchGridViewSelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset all buttons and hide validations
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            btnSave.Visible = false;
            btnEdit.Visible = true;
            btnCancelConfirm.Visible = false;
            txtComments.ReadOnly = true;
            txtContactNum.ReadOnly = true;
            txtDueDate.ReadOnly = true;
            cboStatus.Enabled = false;
            gridOrderedProducts.Visible = false;
            RadAjaxManager1.ResponseScripts.Add("HideValidationErrors();");

            //Search for order details after setting clientnumber and ordernumber
            foreach (GridDataItem dataItem in orderSearchGridView.SelectedItems)
            {
                searchedOrder.ClientNumber = dataItem["Client#"].Text;
                searchedOrder.OrderNumber = dataItem["Order#"].Text;
            }

            SearchForOrderDetails();
        }

        private void SearchForOrderDetails()
        {
            //Check if order exists and the order has products. If so, pull details.
            //If user is in service or admin role , then show cancel button
            if (searchedOrder.SearchOrderDetails() && searchedOrder.SearchProductDetails())
            {
                PopulateFields(searchedOrder.OrderSearch, searchedOrder.OrderedProductSearch);
                if ((Page.User.IsInRole("Admin") || Page.User.IsInRole("Service")
                    || Page.User.IsInRole("Provisioning")) && cboStatus.SelectedIndex == 0)
                {
                    btnEdit.Visible = true;
                    if ((Page.User.IsInRole("Admin") || Page.User.IsInRole("Service")) && cboStatus.SelectedIndex == 0)
                    {
                        btnCancel.Visible = true;
                    }
                    else
                    {
                        btnCancel.Visible = false;
                    }
                }
                else
                {
                    btnEdit.Visible = false;
                    btnCancel.Visible = false;
                }
            }
            else
            {
                windowManager.RadAlert("Error retrieving order data. Please try again.", 250, 125, "Client Order Error", "");
            }
        }

        private void PopulateFields(DataSet orderDetails, DataSet products)
        {
            //Populate all fields with information from dataset. Bind the data to the orderedproduct grid.
            var row = orderDetails.Tables["Order"].Rows[0];
            txtOrderNum.Text = row.ItemArray.GetValue(0).ToString();
            txtClientNum.Text = row.ItemArray.GetValue(1).ToString();
            txtName.Text = row.ItemArray.GetValue(2).ToString();
            txtContactNum.Text = row.ItemArray.GetValue(3).ToString().Insert(0, "(").Insert(4, ")"
                ).Insert(5, " ").Insert(9, "-"); ;
            txtAddress.Text = row.ItemArray.GetValue(4).ToString();
            txtCityState.Text = row.ItemArray.GetValue(5).ToString();
            txtDueDate.Text = String.Format("{0:MM/dd/yyyy}", row.ItemArray.GetValue(6));
            if (row.ItemArray.GetValue(7).ToString() == "Pending")
            {
                cboStatus.SelectedIndex = 0;
            }
            else
            {
                cboStatus.SelectedIndex = 1;
            }

            txtComments.Text = row.ItemArray.GetValue(8).ToString();
            txtCreatorID.Text = row.ItemArray.GetValue(9).ToString();

            gridOrderedProducts.DataSource = products.Tables["Products"];
            gridOrderedProducts.DataBind();
            gridOrderedProducts.Visible = true;
        }

        protected void OrderSearchGridViewItemDataBound(object sender, GridItemEventArgs e)
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

        protected void BtnCancelClick(object sender, EventArgs e)
        {
            //Show confirmation button
            btnCancel.Visible = false;
            btnCancelConfirm.Visible = true;
        }

        protected void BtnCancelConfirmClick(object sender, EventArgs e)
        {
            //Delete order if this button is pressed.
            searchedOrder.OrderNumber = txtOrderNum.Text;
            if (searchedOrder.CancelOrder())
            {
                windowManager.RadAlert("Order# " + searchedOrder.OrderNumber + " has been successfully cancelled.", 250, 125
                    , "Order Cancellation Successful", "TransferToOrderSearch");
            }
            else
            {
                windowManager.RadAlert("Order# " + searchedOrder.OrderNumber + " was not successfully cancelled. Please try again.", 250, 125
                    , "Order Cancellation Error", "TransferToOrderSearch");
            }
        }

        protected void BtnEditClick(object sender, EventArgs e)
        {
            //Make fields editable for order changes. If user is an admin or in provisioning,
            //enable the cboStatus
            btnCancel.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Enabled = false;
            btnSave.Visible = true;
            btnCancelConfirm.Visible = false;
            txtDueDate.ReadOnly = false;
            txtComments.ReadOnly = false;
            txtDueDate.Text = "";
            txtComments.Text = "";
            txtDueDate.Focus();
            if (Page.User.IsInRole("Admin") || Page.User.IsInRole("Provisioning"))
            {
                cboStatus.Enabled = true;
            }
        }

        protected void BtnSaveClick(object sender, EventArgs e)
        {
            //Save changes to order. if order set to complete but due date is not today,
            // give error.
            if (Convert.ToDateTime(txtDueDate.Text) >= DateTime.Now.Date &&
                Convert.ToDateTime(txtDueDate.Text) <= DateTime.Now.AddMonths(3).Date)
            {
                if (cboStatus.SelectedIndex == 0)
                {
                    searchedOrder.DueDate = Convert.ToDateTime(txtDueDate.Text);
                    searchedOrder.OrderNumber = txtOrderNum.Text;
                    searchedOrder.Comments = txtComments.Text;
                    searchedOrder.ClientNumber = txtClientNum.Text;

                    FinalizeOrderUpdate();
                }
                else if (cboStatus.SelectedIndex == 1 && Convert.ToDateTime(txtDueDate.Text) <= DateTime.Now.Date)
                {
                    FinalizeOrderUpdate();
                }
                else
                {
                    windowManager.RadAlert("Due date and order status combination invalid. ", 250, 125
                                                  , "Order Update Error", "");
                }
            }
            else
            {
                windowManager.RadAlert("Pending orders can only be placed between 3 and 90 days out. Enter a valid date. ", 250, 125
                    , "Out Of Range Error", "");
            }
        }

        private void FinalizeOrderUpdate()
        {
            //Set values for order update and call method for query.
            searchedOrder.ClientNumber = txtClientNum.Text;
            searchedOrder.OrderNumber = txtOrderNum.Text;
            switch (cboStatus.SelectedIndex)
            {
                case (0):
                    {
                        searchedOrder.Status = "P";
                        break;
                    }
                case (1):
                    {
                        searchedOrder.Status = "C";
                        break;
                    }
            }
            searchedOrder.Comments = txtComments.Text;
            searchedOrder.DueDate = Convert.ToDateTime(txtDueDate.Text);
            if (searchedOrder.UpdateOrderInfo())
            {
                if (cboStatus.SelectedIndex == 0)
                {
                    windowManager.RadAlert("Order information was updated successfully. ", 250, 125
                                           , "Order Update Success", "TransferToOrderSearch");
                }
                else
                {
                    if (searchedOrder.CompleteOrder())
                    {
                        windowManager.RadAlert("Order information was updated successfully and services were added to the account. ", 250, 125
                                               , "Order Completion Success", "TransferToOrderSearch");
                    }
                    else
                    {
                        windowManager.RadAlert("Order was updated but services were not added to the account. ", 250, 125
                                               , "Order Completion Error", "TransferToOrderSearch");
                    }
                }
            }
            else
            {
                windowManager.RadAlert("Order information was not updated successfully. ", 250, 125
                                       , "Order Update Error", "");
            }
        }

        protected void BtnSubmitWindowClick(object sender, EventArgs e)
        {
            if (gridPlaceOrder.SelectedItems.Count <= 5 && gridPlaceOrder.SelectedItems.Count > 0)
            {
                //Grab values from the selected grid and set all values to
                var currentSelectedProducts = new string[5];
                int i = 0;
                foreach (GridDataItem dataItem in gridPlaceOrder.SelectedItems)
                {
                    currentSelectedProducts[i] = (string)dataItem.GetDataKeyValue("ProductID");
                    i++;
                }
                var commentWindow =
                        (TextBox)windowPlaceOrder.ContentContainer.FindControl("txtCommentsWindow");
                var dueDateWindow =
                            (RadDatePicker)windowPlaceOrder.ContentContainer.FindControl("dateDueDateWindow");
                placingOrder.ClientNumber = orderingClient;
                placingOrder.Comments = commentWindow.Text;
                placingOrder.DueDate = Convert.ToDateTime(dueDateWindow.SelectedDate);
                placingOrder.SelectedProducts = currentSelectedProducts;
                placingOrder.EmployeeId = placingOrder.RetrieveSalesId(Page.User.Identity.Name);
                if (placingOrder.PlaceOrder())
                {
                    windowManager.RadAlert("Congratulations! Order successfully placed. The order# is " + placingOrder.RetrieveOrderNumber(),
                        250, 125, "Order Entry Success", "TransferToOrderSearch");
                }
                else
                {
                    windowManager.RadAlert("Order not successfully placed. Please try again.", 250, 125, "Order Entry Error", "");
                }
            }
            else if (gridPlaceOrder.SelectedItems.Count > 5)
            {
                windowManager.RadAlert("Order can only contain up to 5 products.", 250, 125
                                       , "Product Select Error", "");
            }
            else
            {
                //If no item is selected, display alert.
                windowManager.RadAlert("Please select at least one valid product", 250, 125, "No Product Selected", "");
            }
        }
    }
}