<%@ Page Title="" Language="C#" MasterPageFile="OrderEntry.master" AutoEventWireup="True"
    Inherits="IONS.OrderEntry" CodeBehind="OrderEntry.aspx.cs" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Charting" TagPrefix="telerik" %>
<asp:Content runat="server" ContentPlaceHolderID="headOE" ID="contentHeadOrderEntry">
    <title>I.O.N.S - New Client</title>
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
        .style2
        {
            width: 50%;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrderEntry" runat="Server">
    <script type="text/javascript">
        function confirmCallBackFn(arg) {
            if (arg === true) {
                showStep3();
            }
        }
    </script>
    <script type="text/javascript">
        function showStep3() {
            $('#step2').hide('slow');
            $('#step3').delay(500).show('slow');
        }
    </script>
    <script type="text/javascript">
        function showStep4() {
            $('#step3').hide('slow');
            $('#step4').delay(500).show('slow');
        }
    </script>
    <script type="text/javascript">
        function showStep2() {
            $('#step1').hide('slow');
            $('#step2').delay(500).show('slow');
        }
    </script>
    <script type="text/javascript">
        function TransferToClientSearch() {
            window.location.href = "CustomerSearch.aspx";
        }
    </script>
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="Buttons, Textbox, Textarea, Label, ValidationSummary"
        Skin="Office2010Blue" />
    <telerik:RadWindowManager ID="windowManager" runat="server" Skin="Outlook" Modal="True" />
    <telerik:RadAjaxPanel ID="ajaxPanelPageScripts" runat="server" />
    <div id="step1">
        <asp:Image ID="imgStep1" runat="server" ImageUrl="images/step1.png" CssClass="centered" />
        <div id="customerInfo">
            <telerik:RadAjaxPanel ID="ajaxPanelCustInfo" runat="server" EnablePageHeadUpdate="False"
                HorizontalAlign="NotSet" LoadingPanelID="customerPanel">
                <h2 class="orderEntryHeading">
                    Please Enter The Client's Information</h2>
                <table class="marginTop50">
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblFName" runat="server" Text="First Name" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtFirstName" runat="server" MaxLength="20" Width="130px"
                                EnableEmbeddedBaseStylesheet="False" Skin="" />
                            <asp:RequiredFieldValidator ID="txtFirstNameRequired" runat="server" Text="*" ErrorMessage="Enter first name"
                                ControlToValidate="txtFirstName" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblMInit" runat="server" Text="Middle Name" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtMiddleName" runat="server" MaxLength="20" Width="130px"
                                EnableEmbeddedBaseStylesheet="False" Skin="" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblLName" runat="server" Text="Last Name" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtLastName" runat="server" MaxLength="20" Width="130px"
                                EnableEmbeddedBaseStylesheet="False" Skin="" />
                            <asp:RequiredFieldValidator ID="txtLastNameRequired" Text="*" ControlToValidate="txtLastName"
                                runat="server" ErrorMessage="Enter last name" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblAddress" runat="server" Text="Physical Address" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtAddress" MaxLength="50" Width="130px" runat="server" EnableEmbeddedBaseStylesheet="False"
                                Skin="" />
                            <asp:RequiredFieldValidator ID="txtAddressRequired" Text="*" ControlToValidate="txtAddress"
                                runat="server" ErrorMessage="Enter address" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblZipCode" runat="server" Text="Enter Zip Code" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtZipCode" Width="50px" runat="server" Mask="#####"
                                EnableEmbeddedBaseStylesheet="False" Skin="" />
                            <asp:RequiredFieldValidator ID="txtZipRequired" Text="*" ControlToValidate="txtZipCode"
                                runat="server" ErrorMessage="Enter zip code" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblCityState" runat="server" Text="City/State" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtCity" runat="server" Width="95px" ReadOnly="true" Text="Enter Zip"
                                EnableEmbeddedBaseStylesheet="False" Skin="" />
                            <telerik:RadTextBox ID="txtState" runat="server" Width="35px" ReadOnly="True" EnableEmbeddedBaseStylesheet="False"
                                Skin="" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblSSN" runat="server" Text="Social Security" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtSSN" runat="server" Skin="" Mask="###-##-####" Width="80px"
                                DisplayMask="###-##-####" LabelWidth="32px" TextWithLiterals="--" DisplayPromptChar="_"
                                EnableEmbeddedBaseStylesheet="False" />
                            <asp:RequiredFieldValidator ID="txtSSNRequired" Text="*" ControlToValidate="txtSSN"
                                runat="server" ErrorMessage="Enter social security number" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="txtSSNMinLength" Text="*" runat="server" ErrorMessage="Enter social security number"
                                ControlToValidate="txtSSN" ForeColor="Red" ValidationExpression=".{11}.*" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth" ForeColor="#45638B" Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadDatePicker ID="dateDob" runat="server" Skin="Office2010Blue" Width="130px">
                                <Calendar runat="server" Skin="Office2010Blue" UseColumnHeadersAsSelectors="False"
                                    UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                                </Calendar>
                                <DateInput runat="server" DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy" LabelWidth="40%">
                                </DateInput>
                                <DatePopupButton HoverImageUrl="" ImageUrl="" />
                            </telerik:RadDatePicker>
                            <asp:RequiredFieldValidator ID="dateDOBRequired" Text="*" ControlToValidate="dateDob"
                                runat="server" ErrorMessage="Enter date of birth" ForeColor="Red" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadMaskedTextBox ID="txtContact" runat="server" Skin="" Width="90px" Mask="(###) ###-####"
                                EnableEmbeddedBaseStylesheet="False" />
                            <asp:RequiredFieldValidator ID="txtContactNumberRequired" Text="*" ControlToValidate="txtContact"
                                runat="server" ErrorMessage="Enter contact number" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="txtContactMinLength" ForeColor="Red" runat="server"
                                ErrorMessage="Enter valid 10 digit contact number" ValidationExpression=".{14}.*"
                                ControlToValidate="txtContact" Text="*" />
                        </td>
                    </tr>
                    <tr>
                        <td class="alignRight">
                            <asp:Label ID="lblEmail" runat="server" Text="Email Address" Width="90px" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadTextBox ID="txtEmail" runat="server" Skin="" Width="130px" EnableEmbeddedBaseStylesheet="False" />
                            <asp:RegularExpressionValidator ID="regexEmail" Text="*" ControlToValidate="txtEmail"
                                runat="server" ErrorMessage="Email format incorrect" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </td>
                        <td class="alignRight">
                            <asp:Label ID="lblWasReferred" runat="server" Text="Was Referred?" ForeColor="#45638B"
                                Font-Size="11pt" />
                        </td>
                        <td>
                            <telerik:RadComboBox ID="cboReferred" runat="server" Skin="Office2010Blue" Width="130px"
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
                            <telerik:RadNumericTextBox ID="txtReferralNum" runat="server" Skin="" Width="130px"
                                ReadOnly="True" DataType="System.Int64" Value="0" MaxLength="10" MaxValue="9999999999"
                                MinValue="0" EnableEmbeddedBaseStylesheet="False">
                                <NumberFormat DecimalDigits="0" GroupSeparator="" ZeroPattern="n" AllowRounding="False" />
                            </telerik:RadNumericTextBox>
                            <asp:RequiredFieldValidator ID="txtReferralNumRequired" Text="*" ControlToValidate="txtReferralNum"
                                runat="server" ErrorMessage="Enter referral number" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <telerik:RadButton ID="btnValidateZip" runat="server" OnClick="BtnValidateClick"
                                Text="Validate Zip" Skin="Office2010Blue" />
                        </td>
                        <td>
                            <br />
                            <telerik:RadButton ID="btnReset" CausesValidation="False" runat="server" Text="Reset"
                                Skin="Office2010Blue" OnClick="BtnResetClick" />
                        </td>
                        <td colspan="4" class="alignRight">
                            <br />
                            <telerik:RadButton ID="btnSubmit" runat="server" Text="Submit" Skin="Office2010Blue"
                                OnClick="BtnSubmitClick" Enabled="False" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:ValidationSummary ID="customerValidationSummary" runat="server" HeaderText="Correct the following errors:"
                                DisplayMode="BulletList" ShowMessageBox="False" Visible="True" ForeColor="Red" />
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
                <h2 class="orderEntryHeading">
                    Please Select The Client's Products</h2>
                <div class="selectProducts">
                    <telerik:RadGrid CssClass="textAlignCenter" ID="gridViewProductSelect" Height="200px"
                        runat="server" AllowSorting="True" CellSpacing="0" DataSourceID="AvailableProductDS"
                        GridLines="None" Skin="Outlook" AllowMultiRowSelection="True" OnSelectedIndexChanged="GridViewProductSelectSelectedIndexChanged">
                        <ClientSettings EnableRowHoverStyle="True">
                            <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                        </ClientSettings>
                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="AvailableProductDS">
                            <CommandItemSettings ExportToPdfText="Export to PDF" />
                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                                <HeaderStyle Width="20px" />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                                <HeaderStyle Width="20px" />
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="Category" FilterControlAltText="Filter Category column"
                                    HeaderText="Category" ReadOnly="True" SortExpression="Category" UniqueName="Category">
                                    <HeaderStyle HorizontalAlign="Center" Width="190px"></HeaderStyle>
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Name" FilterControlAltText="Filter Name column"
                                    HeaderText="Name" SortExpression="Name" UniqueName="Name">
                                    <HeaderStyle HorizontalAlign="Center" Width="190px"></HeaderStyle>
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Price" DataType="System.Decimal" FilterControlAltText="Filter Price column"
                                    HeaderText="Price" SortExpression="Price" UniqueName="Price">
                                    <HeaderStyle HorizontalAlign="Center" Width="200px"></HeaderStyle>
                                </telerik:GridBoundColumn>
                                <telerik:GridButtonColumn HeaderText="Action" CommandName="Select" ImageUrl="~/images/addIcon.png"
                                    ButtonType="ImageButton">
                                    <HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
                                </telerik:GridButtonColumn>
                                <telerik:GridButtonColumn HeaderText="Action" CommandName="Deselect" ImageUrl="~/images/deleteIcon.png"
                                    ButtonType="ImageButton">
                                    <HeaderStyle HorizontalAlign="Center" Width="49px"></HeaderStyle>
                                </telerik:GridButtonColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                    </telerik:RadGrid>
                    <br />
                    <table class="orderButtons" style="text-align: left; width: 100%">
                        <tr>
                            <td class="style1">
                                <label class="orderButtons" for="lblMonthlyTotal">
                                    <strong>Monthly Total:</strong>
                                </label>
                                <strong>
                                    <asp:Label ID="lblMonthlyTotal" ForeColor="#45638B" runat="server" Text="$0.00" /></strong>
                            </td>
                            <td style="text-align: right;" class="style2">
                                <telerik:RadButton ID="btnOrderProducts" Skin="Office2010Blue" runat="server" Text="Order"
                                    OnClick="BtnOrderProductsClick" CausesValidation="False" />
                            </td>
                        </tr>
                    </table>
                    <asp:SqlDataSource ID="AvailableProductDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                        SelectCommand="SELECT [ProductID],  [Name],  [Category]
                                        = CASE WHEN Category = 'LD' THEN 'Long Distance'
                                        WHEN Category = 'TV' THEN 'Televison'
                                        ELSE Category END
                                        , [Price] FROM [PRODUCT] ORDER BY [Category], [Price]" />
                </div>
            </telerik:RadAjaxPanel>
        </div>
    </div>
    <div id="step3">
        <asp:Image ID="imgStep3" runat="server" ImageUrl="images/step3.png" CssClass="centered" />
        <div id="orderDetails">
            <h2 class="orderEntryHeading">
                Please Enter Order Details</h2>
            <div>
                <telerik:RadAjaxLoadingPanel ID="orderPanel" runat="server" Skin="Office2010Blue"
                    MinDisplayTime="300" />
                <div class="halfWidth" style="float: left">
                    <h3 style="margin-left: 40px; color: #45638B">
                        Select Installation Date
                    </h3>
                    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" HorizontalAlign="Center"
                        LoadingPanelID="orderPanel" RenderMode="Inline">
                        <telerik:RadCalendar Width="100%" ID="calDueDate" runat="server" AutoPostBack="True"
                            EnableMultiSelect="False" SelectedDate="" Skin="Office2010Blue" ViewSelectorText="x">
                            <SpecialDays>
                                <telerik:RadCalendarDay Date="" Repeatable="Today">
                                    <ItemStyle CssClass="rcToday" />
                                </telerik:RadCalendarDay>
                            </SpecialDays>
                            <WeekendDayStyle CssClass="rcWeekend"></WeekendDayStyle>
                            <CalendarTableStyle CssClass="rcMainTable"></CalendarTableStyle>
                            <OtherMonthDayStyle CssClass="rcOtherMonth"></OtherMonthDayStyle>
                            <OutOfRangeDayStyle CssClass="rcOutOfRange"></OutOfRangeDayStyle>
                            <DisabledDayStyle CssClass="rcDisabled"></DisabledDayStyle>
                            <SelectedDayStyle CssClass="rcSelected"></SelectedDayStyle>
                            <DayOverStyle CssClass="rcHover"></DayOverStyle>
                            <FastNavigationStyle CssClass="RadCalendarMonthView RadCalendarMonthView_Default">
                            </FastNavigationStyle>
                            <ViewSelectorStyle CssClass="rcViewSel"></ViewSelectorStyle>
                        </telerik:RadCalendar>
                    </telerik:RadAjaxPanel>
                </div>
                <div class="halfWidth" style="float: right; margin-right: 40px">
                    <h3 style="text-align: center; color: #45638B">
                        Enter Order Comments
                    </h3>
                    <telerik:RadTextBox ID="txtOrderComments" runat="server" Width="100%" Rows="12" TextMode="MultiLine"
                        Skin="" />
                </div>
                <table style="width: 765px">
                    <tr>
                        <td style="text-align: right">
                            <telerik:RadButton ID="btnSubmitOrderDetails" runat="server" Text="Place Order" Skin="Office2010Blue"
                                OnClick="BtnSubmitOrderDetailsClick" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div id="step4">
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="btnSubmitOrderDetails">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="txtNameFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtaddressFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtCityStateFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtSSNFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtDOBFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtContactFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtEmailFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtReferredFianl" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtReferralNumFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtDueDateFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtSalesIdFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtCommentsFinal" UpdatePanelRenderMode="Inline" />
                        <telerik:AjaxUpdatedControl ControlID="txtProductsOrderedFinal" UpdatePanelRenderMode="Inline" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="btnFinalize">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="btnFinalize" UpdatePanelRenderMode="Inline" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <asp:Image ID="imsStep4" runat="server" ImageUrl="images/step4.png" CssClass="centered" />
        <div id="orderRecap">
            <h2 class="orderEntryHeading">
                Recap Order With The Client</h2>
            <table style="width: 95%; text-align: right; margin-right: 5%;">
                <tr>
                    <td>
                        <label for="txtNameFinal">
                            Name:</label>
                        <asp:TextBox ID="txtNameFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtAddressFinal">
                            Address:</label>
                        <asp:TextBox ID="txtaddressFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtCityStateFinal">
                            City/ST/Zip:</label>
                        <asp:TextBox ID="txtCityStateFinal" ReadOnly="True" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtSSNFinal">
                            Social Security:</label>
                        <asp:TextBox ID="txtSSNFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtDOBFinal">
                            Date of Birth:</label>
                        <asp:TextBox ID="txtDOBFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtContactFinal">
                            Contact#:</label>
                        <asp:TextBox ID="txtContactFinal" ReadOnly="True" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="txtEmailFinal">
                            Email:</label>
                        <asp:TextBox ID="txtEmailFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtReferralFinal">
                            Was Referred?:</label>
                        <asp:TextBox ID="txtReferredFianl" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtReferralNumFinal">
                            Referral#:</label>
                        <asp:TextBox ID="txtReferralNumFinal" ReadOnly="True" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top">
                        <label for="txtDueDateFinal">
                            Due Date:</label>
                        <asp:TextBox ID="txtDueDateFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td style="vertical-align: top">
                        <label for="txtSalesIdFinal">
                            Sales ID:</label>
                        <asp:TextBox ID="txtSalesIdFinal" ReadOnly="True" runat="server" />
                    </td>
                    <td>
                        <label for="txtCommentsFinal" style="vertical-align: top">
                            Order Comments:</label>
                        <asp:TextBox ID="txtCommentsFinal" ReadOnly="True" Width="160px" Rows="4" runat="server"
                            TextMode="MultiLine" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: left">
                        <label for="txtProductsOrderedFinal" style="vertical-align: top">
                            Products:</label>
                        <asp:TextBox ID="txtProductsOrderedFinal" ReadOnly="True" Width="435px" Rows="6"
                            runat="server" TextMode="MultiLine" />
                    </td>
                    <td style="text-align: right; vertical-align: bottom">
                        <asp:Button ID="btnFinalize" runat="server" Text="Finalize" OnClick="BtnFinalizeClick" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>