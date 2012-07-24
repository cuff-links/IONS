using System;
using System.Xml;

namespace IONS
{
    public partial class OrderEntryMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Set data source to document returned from GetDocument method. Bind to radrotator.
            rotateFeed.DataSource = GetDocument().SelectNodes("feed/tips");
            rotateFeed.DataBind();
        }

        private XmlDocument GetDocument()
        {
            //Load the xml document for feed.
            var doc = new XmlDocument();
            var physicalPath = Server.MapPath("~/ionsMessages.xml");
            doc.Load(physicalPath);

            return doc;
        }
    }
}