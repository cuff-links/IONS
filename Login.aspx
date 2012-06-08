<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>I.O.N.S Login</title>
    <link href="ions.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <img class="centerPicture" id="imgBanner" src="images/banner.png" alt="I.O.N.S" />
    <form id="form1" runat="server">
    <div class="loginDiv">
        <asp:Login ID="loginIons" runat="server" ForeColor="#45638B" FailureText="The username/password combination was invalid."
            TextBoxStyle-Width="90px" DestinationPageUrl="~/CustomerSearch.aspx">
            <TextBoxStyle Width="120px"></TextBoxStyle>
        </asp:Login>
    </div>
    </form>
</body>
</html>