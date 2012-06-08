using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class CustomerSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ajaxPanelCustomerSearchGrid.ResponseScripts.Add("$('#customerSearchGrid').animate({opacity: 0.5}, 1);");
        ajaxPanelCustomerSearchGrid.ResponseScripts.Add("$('#customerSearchGrid').hover(function () {" +
                                                        "$('#customerSearchGrid').fadeTo(5, 1.0);" +
                                                        "}, function () {" +
                                                        "$('#customerSearchGrid').fadeTo(5, 0.5);" + "});");
    }

    protected void CustomerSearchGridViewItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
    {
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
        int selectedCustomer =
            Convert.ToInt32(
                customerSearchGridView.SelectedItems[0].OwnerTableView.DataKeyValues[
                    customerSearchGridView.SelectedItems[0].ItemIndex]["Customer#"].ToString());
        Console.WriteLine(selectedCustomer);
    }
}