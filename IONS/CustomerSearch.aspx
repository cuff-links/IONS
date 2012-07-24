<%@ Page Title="" Language="C#" MasterPageFile="~/OrderEntry.master" AutoEventWireup="True"
    Inherits="IONS.CustomerSearch" EnableEventValidation="True" CodeBehind="CustomerSearch.aspx.cs" %>

<asp:Content runat="server" ID="content2" ContentPlaceHolderID="headOE">
    <title>I.O.N.S - Client Search</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphOrderEntry" runat="Server">
    <script type="text/javascript">
        function HideValidationErrors() {
            //Hide all validation errors
            if (window.Page_Validators)
                for (var vI = 0; vI < Page_Validators.length; vI++) {
                    var vValidator = Page_Validators[vI];
                    vValidator.isvalid = true;
                    ValidatorUpdateDisplay(vValidator);
                }
            //Hide all validaiton summaries
            if (typeof (Page_ValidationSummaries) != "undefined") { //hide the validation summaries
                for (sums = 0; sums < Page_ValidationSummaries.length; sums++) {
                    summary = Page_ValidationSummaries[sums];
                    summary.style.display = "none";
                }
            }
        }
    </script>
    <script type="text/javascript">
        function TransferToClientSearch() {
            window.location.href = "CustomerSearch.aspx";
        }
    </script>
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="Buttons, Textbox, Fieldset, Label, ValidationSummary, LoginControls"
        Skin="Office2010Blue" />
    <telerik:RadWindowManager ID="windowManager" runat="server" Modal="True" Skin="Outlook" />
    <div id="customerSearchGrid">
        <fieldset>
            <legend style="text-align: left">Client Search</legend>
            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Office2010Blue"
                MinDisplayTime="500" />
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="btnViewProducts">
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btnPlaceOrder">
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btnEdit">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="txtAddress" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtZip" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtCity" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtState" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnViewProducts" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnPlaceOrder" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteConfirm" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteClient" UpdatePanelRenderMode="Inline" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btnSave">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="txtAddress" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtZip" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtCity" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtState" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnViewProducts" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnPlaceOrder" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteClient" UpdatePanelRenderMode="Inline" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="customerSearchGridView">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="txtClientNum" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtAddress" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtZip" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtFirstName" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtCity" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtDOB" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtDateEst" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtLastName" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtState" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtSSN" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="txtBalance" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnViewProducts" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnPlaceOrder" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteClient" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteConfirm" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="customerSearchGridView" LoadingPanelID="RadAjaxLoadingPanel1"
                                UpdatePanelRenderMode="Inline" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btnDeleteClient">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteConfirm" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteClient" UpdatePanelRenderMode="Inline" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="btnDeleteConfirm">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteConfirm" UpdatePanelRenderMode="Inline" />
                            <telerik:AjaxUpdatedControl ControlID="btnDeleteClient" UpdatePanelRenderMode="Inline" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
            </telerik:RadAjaxManager>
            <telerik:RadGrid ID="customerSearchGridView" runat="server" AllowFilteringByColumn="True"
                AllowSorting="True" CellSpacing="0" DataSourceID="CustomerSearchDS" GridLines="None"
                Skin="Outlook" AllowPaging="True" OnItemDataBound="CustomerSearchGridViewItemDataBound"
                PageSize="6" OnSelectedIndexChanged="CustomerSearchGridViewSelectedIndexChanged">
                <MasterTableView DataKeyNames="Client#" DataSourceID="CustomerSearchDS">
                    <CommandItemSettings ExportToPdfText="Export to PDF" />
                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                        <HeaderStyle Width="20px" />
                    </RowIndicatorColumn>
                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                        <HeaderStyle Width="20px" />
                    </ExpandCollapseColumn>
                    <EditFormSettings>
                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                        </EditColumn>
                    </EditFormSettings>
                    <Columns>
                        <telerik:GridButtonColumn CommandName="Select" Text="Select" />
                    </Columns>
                </MasterTableView>
                <FilterItemStyle Width="100px" />
                <PagerStyle Mode="Advanced" />
                <FilterMenu EnableImageSprites="False">
                </FilterMenu>
            </telerik:RadGrid>
            <asp:SqlDataSource ID="CustomerSearchDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT Client#, FirstName + ' ' + LastName as 'Name', SSN as 'Social Security#' FROM CLIENT" />
        </fieldset>
    </div>
    <div id="customerOverview">
        <fieldset>
            <legend style="text-align: left">Client Overview</legend>
            <div id="overViewColumnLeft" class="overviewRow">
                <table>
                    <tr>
                        <td>
                            <label for="txtClientNum" class="alignRight">
                                Client#:</label>
                            <asp:TextBox ID="txtClientNum" runat="server" Width="135" ReadOnly="True" TabIndex="1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RequiredFieldValidator ForeColor="Red" Text="*" ControlToValidate="txtAddress"
                                ID="txtAddressRequired" runat="server" ErrorMessage="Enter an address" />
                            <label for="txtAddress" class="alignRight">
                                Address:</label>
                            <asp:TextBox ID="txtAddress" runat="server" Width="135" ReadOnly="True" TabIndex="4" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RequiredFieldValidator ControlToValidate="txtZip" ID="txtZipRequired" runat="server"
                                ErrorMessage="Enter valid zip code" Text="*" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="txtZipExpression" runat="server" ErrorMessage="Zip must be 5 digits"
                                ValidationExpression="[0-9]{5}" ForeColor="Red" ControlToValidate="txtZip" Text="*" />
                            <label for="txtZip" class="alignRight">
                                Zip Code:</label>
                            <asp:TextBox ID="txtZip" runat="server" MaxLength="5" Width="135" ReadOnly="True"
                                TabIndex="7" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtContactNum" ID="txtContactNumRequired"
                                runat="server" ErrorMessage="Enter 10 digit contact number" Text="*" />
                            <asp:RegularExpressionValidator ForeColor="Red" ID="txtContactNumExpression" runat="server"
                                ErrorMessage="Contact number must be 10 digits without characters" ValidationExpression="[0-9]{10}"
                                ControlToValidate="txtContactNum" Text="*" />
                            <label for="txtContactNum" class="alignRight">
                                Contact#</label>
                            <asp:TextBox ID="txtContactNum" MaxLength="10" runat="server" Width="135" ReadOnly="True"
                                TabIndex="10" />
                        </td>
                    </tr>
                </table>
            </div>
            <div id="overViewColumnMiddle" class="overviewRow">
                <table>
                    <tr>
                        <td>
                            <label for="txtFirstName" class="alignRight">
                                First Name:</label>
                            <asp:TextBox ID="txtFirstName" runat="server" Width="135" ReadOnly="True" TabIndex="2" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtCity" ID="txtCityRequired"
                                runat="server" ErrorMessage="Enter a city" Text="*" />
                            <label for="txtCity" class="alignRight">
                                City:</label>
                            <asp:TextBox ID="txtCity" runat="server" Width="135" ReadOnly="True" TabIndex="5"
                                CausesValidation="True" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="txtDOB" class="alignRight">
                                Date Of Birth:</label>
                            <asp:TextBox ID="txtDOB" runat="server" Width="135" InputType="Date" ReadOnly="True"
                                TabIndex="8" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="txtDateEst" class="alignRight">
                                Established:</label>
                            <asp:TextBox ID="txtDateEst" runat="server" Width="135" InputType="Date" ReadOnly="True"
                                TabIndex="11" />
                        </td>
                    </tr>
                </table>
            </div>
            <div id="overviewColumnRight" class="overviewRow">
                <table>
                    <tr>
                        <td>
                            <label for="txtLastName" class="alignRight">
                                Last Name:</label>
                            <asp:TextBox ID="txtLastName" runat="server" Width="135" ReadOnly="True" TabIndex="3" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtState" ID="txtStateRequired"
                                runat="server" ErrorMessage="Enter a state" Text="*" />
                            <label for="txtState" class="alignRight">
                                State:</label>
                            <asp:TextBox ID="txtState" MaxLength="2" runat="server" Width="135" ReadOnly="True"
                                TabIndex="6" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="txtSSN" class="alignRight">
                                Social Security#:</label>
                            <asp:TextBox ID="txtSSN" runat="server" Width="135" ReadOnly="True" Mask="###-##-####"
                                TabIndex="9" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label for="txtBalance" class="alignRight">
                                Balance</label>
                            <asp:TextBox ID="txtBalance" runat="server" Width="135" ReadOnly="True" TabIndex="12" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="btnViewProducts" runat="server" Text="Products" ToolTip="View Client's Products"
                                TabIndex="13" CausesValidation="False" Enabled="False" OnClick="BtnViewProductsClick" />
                            <asp:Button ID="btnPlaceOrder" runat="server" Text="Order" ToolTip="Place an order for the selected client"
                                TabIndex="14" CausesValidation="False" Enabled="False" OnClick="BtnPlaceOrderClick" />
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" Enabled="False" ToolTip="Edit Client Information"
                                OnClick="BtnEditClick" TabIndex="15" CausesValidation="False" />
                            <asp:Button ID="btnSave" runat="server" Text="Save" Visible="False" ToolTip="Save Client Information"
                                OnClick="BtnSaveClick" TabIndex="16" />
                            <asp:Button ID="btnDeleteClient" runat="server" Text="Delete" Visible="False" ToolTip="Delete Client From System"
                                TabIndex="17" OnClick="BtnDeleteClientClick" CausesValidation="False" />
                            <telerik:RadButton ID="btnDeleteConfirm" Visible="False" runat="server" Text="Delete!"
                                Skin="Black" OnClick="BtnDeleteConfirmClick" CausesValidation="False">
                            </telerik:RadButton>
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>
        <table style="text-align: left">
            <tr>
                <td>
                    <asp:ValidationSummary DisplayMode="BulletList" ID="ValidationSummary1" runat="server"
                        ForeColor="Red" />
                </td>
            </tr>
        </table>
    </div>
    <object data="sound.mp3" style="width: 1px; height: 1px">
        <param name="autoplay" value="true" />
        <param name="src" value="sound.mp3" />
    </object>
</asp:Content>