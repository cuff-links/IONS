using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace IONS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Call method to set cssclass for current menu. Show username on master page.
            //If the user is not an administrator, do not show linkAdmin.
            SetCssClassForCurrentMenuOption();
            lblLoggedUser.Text = "Welcome, " + Page.User.Identity.Name;
            if (!Page.User.IsInRole("Admin"))
            {
                linkAdmin.Visible = false;
            }
        }

        private void SetCssClassForCurrentMenuOption()
        {
            // compares the virtual filepath of the page being requested against the links in the
            // navigation menu, sets the class property to "current" when there is a match
            // Potential Problems: pages with same name in different folders being added to menu
            // note added runat="server" attribute to menu <ul> and <a> tags so they are accesible server-side

            string sRequestVirtualFilePath, sAnchorTargetFileName;
            HtmlAnchor ha;

            // get the url of the page being requested
            sRequestVirtualFilePath = Request.FilePath;

            foreach (Control ctrl in ulMenu.Controls)
            {
                if (ctrl is HtmlAnchor)
                {
                    ha = (HtmlAnchor)ctrl;
                    // want to extract /filename to compare with end of requested virtual URL

                    if (ha.HRef.Contains('/') == true)
                        sAnchorTargetFileName = ha.HRef.Remove(0, (ha.HRef.LastIndexOf('/')));
                    else if (ha.HRef.Contains('\\') == true) //incase used windows style \ sperator
                        sAnchorTargetFileName = '/' + ha.HRef.Remove(0, (ha.HRef.LastIndexOf('\\')) + 1);
                    else
                        // full Href given is filename, add / to avoid partial filename matches
                        sAnchorTargetFileName = "/" + ha.HRef;

                    if (sRequestVirtualFilePath.EndsWith(sAnchorTargetFileName))
                    {
                        ha.Attributes.Add("class", "current");
                        break; // breaks out of foreach loop
                    }
                }
            }
        }

        protected void LinkLogOutClick(object sender, EventArgs e)
        {
            //Log out of the system. Delete cookies, clear session, send to logout page.
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}