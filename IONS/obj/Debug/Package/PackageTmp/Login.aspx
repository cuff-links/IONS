<%@ Page Language="C#" AutoEventWireup="True" Inherits="IONS.Login" CodeBehind="Login.aspx.cs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>I.O.N.S - Login</title>
    <link href="images/ions.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <img class="centerPicture" id="imgBanner" src="images/banner.png" alt="I.O.N.S" />
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server" HttpHandlerUrl="~/Telerik.Web.UI.WebResource.axd" />
    <telerik:RadFormDecorator ID="RadFormDecorator1" ForeColor="" runat="server" Skin="Office2010Blue"
        DecoratedControls="Buttons, Textbox, LoginControls" />
    <div class="loginDiv" style="margin-top: 30px;">
        <asp:Login ID="loginIons" DestinationPageUrl="Admin.aspx" runat="server" FailureText="The username/password combination was invalid."
            TextBoxStyle-Width="90px" DisplayRememberMe="False" ForeColor="#45638B" UserNameRequiredErrorMessage="Username is required."
            UserNameLabelText="Username:">
            <TextBoxStyle Width="120px"></TextBoxStyle>
        </asp:Login>
    </div>
    </form>
</body>
</html>