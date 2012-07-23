using System;

namespace IONS
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.IsInRole("Admin"))
            {
                btnSalesChart.Visible = false;
                btnSalesReport.Visible = false;
            }
        }

        protected void BtnPendingClick(object sender, EventArgs e)
        {
            reportPanel.ResponseScripts.Add("showPending();");
        }

        protected void BtnReferralClick(object sender, EventArgs e)
        {
            reportPanel.ResponseScripts.Add("showReferral();");
        }

        protected void BtnSalesReportClick(object sender, EventArgs e)
        {
            reportPanel.ResponseScripts.Add("showSalesReport();");
        }

        protected void BtnSalesChartClick(object sender, EventArgs e)
        {
            reportPanel.ResponseScripts.Add("showSalesChart();");
        }
    }
}