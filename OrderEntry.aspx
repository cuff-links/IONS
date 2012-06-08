<%@ Page Title="" Language="C#" MasterPageFile="OrderEntry.master" AutoEventWireup="true"
    CodeFile="OrderEntry.aspx.cs" Inherits="OrderEntry" %>

<asp:Content runat="server" ContentPlaceHolderID="headOE" ID="contentHeadOrderEntry">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrderEntry" runat="Server">
    <telerik:RadAjaxPanel ID="ajaxPanelPageScripts" runat="server" />
    <div id="step1">
        <asp:Image ID="imgStep1" runat="server" ImageUrl="images/step1.png" CssClass="centered" />
        <div id="customerInfo">
            <telerik:RadAjaxPanel ID="ajaxPanelCustInfo" runat="server" EnablePageHeadUpdate="False"
                HorizontalAlign="NotSet" LoadingPanelID="customerPanel">
                <asp:Label ID="lblInstructions" runat="server" Font-Size="X-Large" ForeColor="White"
                    CssClass="textAlignCenter">Please Enter The Customer's Information</asp:Label>
                <table class="marginTop50">
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblFName" runat="server" Text="First Name" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtFirstName" runat="server" MaxLength="20" Width="130px" />
                            <asp:RequiredFieldValidator ID="txtFirstNameRequired" runat="server" Text="*" ErrorMessage="First Name"
                                ControlToValidate="txtFirstName" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblMInit" runat="server" Text="Middle Name" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtMiddleName" runat="server" MaxLength="20" Width="130px" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblLName" runat="server" Text="Last Name" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtLastName" runat="server" MaxLength="20" Width="130px" />
                            <asp:RequiredFieldValidator ID="txtLastNameRequired" Text="*" ControlToValidate="txtLastName"
                                runat="server" ErrorMessage="Last Name" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblAddress" runat="server" Text="Physical Address" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtAddress" MaxLength="50" Width="130px" runat="server" />
                            <asp:RequiredFieldValidator ID="txtAddressRequired" Text="*" ControlToValidate="txtAddress"
                                runat="server" ErrorMessage="Address" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblZipCode" runat="server" Text="Enter ZipCode" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtZipCode" Width="50px" runat="server" Mask="#####" />
                            <asp:RequiredFieldValidator ID="txtZipRequired" Text="*" ControlToValidate="txtZipCode"
                                runat="server" ErrorMessage="Zip Code" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblCityState" runat="server" Text="City/State" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtCity" runat="server" Width="95px" ReadOnly="true" Enabled="False" />
                            <telerik:RadTextBox ID="txtState" runat="server" Width="35px" ReadOnly="True" Enabled="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblSSN" runat="server" Text="Social Security" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtSSN" runat="server" Skin="Vista" Mask="###-##-####"
                                Width="80px" DisplayMask="###-##-####" LabelWidth="32px" TextWithLiterals="--"
                                DisplayPromptChar="_" />
                            <asp:RequiredFieldValidator ID="txtSSNRequired" Text="*" ControlToValidate="txtSSN"
                                runat="server" ErrorMessage="Social Security Number" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadDatePicker ID="dateDob" runat="server" Skin="WebBlue" Width="130px" />
                            <asp:RequiredFieldValidator ID="dateDOBRequired" Text="*" ControlToValidate="dateDob"
                                runat="server" ErrorMessage="Date of Birth" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtContact" runat="server" Skin="Vista" Width="100px"
                                Mask="(###) ###-####" />
                            <asp:RequiredFieldValidator ID="txtContactNumberRequired" Text="*" ControlToValidate="txtContact"
                                runat="server" ErrorMessage="Contact Number" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblEmail" runat="server" Text="Email Address" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtEmail" runat="server" Skin="Vista" Width="130px" />
                            <asp:RegularExpressionValidator ID="regexEmail" Text="*" ControlToValidate="txtEmail"
                                runat="server" ErrorMessage="Email Format Incorrect" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblWasReferred" runat="server" Text="Was Referred?" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboReferred" runat="server" Skin="WebBlue" Width="130px"
                                OnSelectedIndexChanged="CboReferredSelectedIndexChanged" AutoPostBack="True"
                                CausesValidation="False">
                                <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="No" Value="No" />
                                    <telerik:RadComboBoxItem runat="server" Text="Yes" Value="Yes" />
                                </Items>
                            </telerik:RadComboBox>
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblReferralNum" runat="server" Text="Referral#" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadNumericTextBox ID="txtReferralNum" runat="server" Skin="Vista" Width="130px"
                                Enabled="False" DataType="System.Int64" Value="0" MaxLength="10" MaxValue="9999999999"
                                MinValue="0">
                                <NumberFormat DecimalDigits="0" GroupSeparator="" ZeroPattern="n" AllowRounding="False" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="txtReferralNumRequired" Text="*" ControlToValidate="txtReferralNum"
                                runat="server" ErrorMessage="Referral Number" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <telerik:RadButton ID="btnValidateZip" runat="server" OnClick="BtnValidateClick"
                                Text="Validate Zip" Skin="WebBlue" />
                        </td>
                        <td>
                            <br />
                            <telerik:RadButton ID="btnSubmit" runat="server" Text="Submit" Skin="WebBlue" OnClick="BtnSubmitClick"
                                Enabled="False" />
                            <telerik:RadButton ID="btnReset" CausesValidation="False" runat="server" Text="Reset"
                                Skin="WebBlue" OnClick="BtnResetClick" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="8">
                            <asp:ValidationSummary ID="customerValidationSummary" runat="server" HeaderText="Please fill out the following fields:"
                                DisplayMode="List" ForeColor="Red" ShowMessageBox="False" Visible="True" />
                        </td>
                    </tr>
                </table>
            </telerik:RadAjaxPanel>
            <telerik:RadAjaxLoadingPanel ID="customerPanel" runat="server" Skin="Office2010Blue" />
        </div>
    </div>
    <div id="step2">
        <asp:Image ID="imgStep2" runat="server" ImageUrl="images/step2.png" CssClass="centered" />
        <div id="productSelect">
            <telerik:RadAjaxPanel ID="ajaxProducts" runat="server">
                <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="White" CssClass="textAlignCenter">Please Select Customer's Products</asp:Label>
                <table class="marginTop50">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Phone Line Plan:" />
                        </td>
                        <td class="alignCenter">
                            <telerik:RadComboBox ID="RadComboBox1" runat="server" Width="375px" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="Label6" runat="server" Text="No Phone Line Plan Selected" Width="230px" />
                        </td>
                    </tr>
                </table>
                <telerik:RadListView ID="RadListView1" runat="server">
                </telerik:RadListView>
            </telerik:RadAjaxPanel>
        </div>
    </div>
    <div>
    </div>
</asp:Content>