<%@ Page Language="C#" AutoEventWireup="True" Inherits="IONS.Admin" CodeBehind="Admin.aspx.cs" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>I.O.N.S - Administrator</title>
    <link href="images/ions.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#createUser').hide();
        });
    </script>
    <script type="text/javascript">
        function showCreateUser() {
            $('#createUser').slideDown('slow');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server" />
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="All"
        Skin="Office2010Blue" />
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" />
    <asp:Image runat="server" ID="banner" ImageUrl="images/banner.png" CssClass="centerPicture" />
    <telerik:RadAjaxPanel ID="ajaxCreateUser" runat="server">
        <div id="adminButtons">
            <table style="width: 100%;">
                <tr>
                    <td style="width: 33%; text-align: left">
                        <input id="btnCreateUser" type="button" value="Create User" onclick="showCreateUser()" />
                    </td>
                    <td style="width: 33%; text-align: center">
                        <asp:Button ID="btnEnterSystem" CausesValidation="False" Text="Enter System" runat="server"
                            OnClick="BtnEnterSystemClick" />
                    </td>
                    <td style="width: 33%; text-align: right">
                        <asp:Button ID="btnLogOut" Text="Log Out" runat="server" OnClick="BtnLogOutClick"
                            CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </div>
        <div id="createUser" class="loginDiv">
            <asp:CreateUserWizard ID="createUserWizard" ContinueDestinationPageUrl="~/Admin.aspx"
                runat="server" LoginCreatedUser="False" OnCreatingUser="CreateUserWizardCreatingUser"
                UnknownErrorMessage="User account was not created. Please try again." MembershipProvider="AspNetSqlMembershipProvider">
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" Title="Create New User ">
                        <ContentTemplate>
                            <table>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            First Name:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" MaxLength="20" ID="txtFirstName" runat="server" CausesValidation="True" />
                                        <asp:RequiredFieldValidator ID="txtFirstNameRequired" Text="*" ControlToValidate="txtFirstName"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter first name" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Middle Initial:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="30px" MaxLength="1" ID="txtMiddle" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Last Name:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" MaxLength="20" ID="txtLastName" runat="server" />
                                        <asp:RequiredFieldValidator ID="txtLastNameRequired" Text="*" ControlToValidate="txtLastName"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter last name" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Role:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <telerik:RadComboBox Width="120px" Skin="Office2010Blue" ID="cboRoles" runat="server">
                                            <Items>
                                                <telerik:RadComboBoxItem runat="server" Text="Admin" Value="Admin" />
                                                <telerik:RadComboBoxItem runat="server" Text="Billing" Value="Billing" />
                                                <telerik:RadComboBoxItem runat="server" Text="Provisioning" Value="Provisioning" />
                                                <telerik:RadComboBoxItem runat="server" Text="Sales" Value="Sales" />
                                                <telerik:RadComboBoxItem runat="server" Text="Service" Value="Service" />
                                            </Items>
                                        </telerik:RadComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Email:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" MaxLength="100" ID="Email" CausesValidation="True" runat="server" />
                                        <asp:RequiredFieldValidator ID="EmailRequired" Text="*" ControlToValidate="Email"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter email address" />
                                        <asp:RegularExpressionValidator ID="EmailExpression" Text="*" ControlToValidate="Email"
                                            ValidationGroup="createUserWizard" ForeColor="Red" runat="server" ErrorMessage="Email format incorrect"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            User Name:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" MaxLength="10" ID="UserName" CausesValidation="True" runat="server" />
                                        <asp:RequiredFieldValidator ID="UserNameRequired" Text="*" ControlToValidate="UserName"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter username" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Password:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" ID="PassWord" CausesValidation="True" runat="server" TextMode="Password" />
                                        <asp:RequiredFieldValidator ID="PasswordRequired" Text="*" ControlToValidate="Password"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter password" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Confirm Password:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" ID="ConfirmPassword" CausesValidation="True" runat="server"
                                            TextMode="Password" />
                                        <asp:RequiredFieldValidator Text="*" ID="ConfirmPasswordRequired" ControlToValidate="ConfirmPassword"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter password again" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Security Question:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" ID="Question" CausesValidation="True" runat="server" />
                                        <asp:RequiredFieldValidator ID="QuestionRequired" Text="*" ControlToValidate="Question"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter security question" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="createUserTableLabel">
                                        <label>
                                            Security Answer:
                                        </label>
                                    </td>
                                    <td class="textAlignLeft">
                                        <asp:TextBox Width="120px" ID="Answer" CausesValidation="True" runat="server" />
                                        <asp:RequiredFieldValidator ID="AnswerRequired" Text="*" ControlToValidate="Answer"
                                            runat="server" ForeColor="Red" ValidationGroup="createUserWizard" ErrorMessage="Enter security answer" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:ValidationSummary HeaderText="Correct the following errors:" DisplayMode="BulletList"
                                            ValidationGroup="createUserWizard" ForeColor="Red" ID="ValidationSummary1" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                        <CustomNavigationTemplate>
                            <table border="0" cellspacing="5" style="width: 100%; height: 100%;">
                                <tr align="right">
                                    <td align="right" colspan="0">
                                        <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Create User"
                                            ValidationGroup="createUserWizard" />
                                    </td>
                                </tr>
                            </table>
                        </CustomNavigationTemplate>
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep runat="server" Title="User Created Successfully">
                        <ContentTemplate>
                            <table>
                                <tr>
                                    <td align="center">
                                        <label>
                                            User Created Successfully
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            Your account has been successfully created.
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="ContinueButton" runat="server" CausesValidation="True" CommandName="Continue"
                                            Text="Continue" ValidationGroup="createUserWizard" />
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:CompleteWizardStep>
                </WizardSteps>
            </asp:CreateUserWizard>
            <table>
            </table>
        </div>
    </telerik:RadAjaxPanel>
    </form>
</body>
</html>