<%@ Page Title="" Language="C#" MasterPageFile="~/OrderEntry.master" AutoEventWireup="True"
    Inherits="IONS.OrderSearch" CodeBehind="OrderSearch.aspx.cs" %>

<%@ PreviousPageType VirtualPath="~/CustomerSearch.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headOE" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrderEntry" runat="Server">
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
        function TransferToOrderSearch() {
            window.location.href = "OrderSearch.aspx";
        }
    </script>
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="Default, Textbox, Textarea, Fieldset, Label, Select, Zone, GridFormDetailsViews, ValidationSummary, LoginControls"
        Skin="Office2010Blue" />
    <telerik:RadWindowManager ID="windowManager" runat="server" Skin="Outlook" Modal="True" />
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="orderSearchGridView">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="orderSearchGridView" UpdatePanelRenderMode="Inline"
                        LoadingPanelID="RadAjaxLoadingPanel" />
                    <telerik:AjaxUpdatedControl ControlID="txtOrderNum" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtClientNum" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtName" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtAddress" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtCityState" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtDueDate" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="cboStatus" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtCreatorID" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtComments" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="gridOrderedProducts" UpdatePanelRenderMode="Inline"
                        LoadingPanelID="RadAjaxLoadingPanel" />
                    <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancel" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancelConfirm" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnEdit">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtDueDate" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="cboStatus" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtComments" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancel" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancelConfirm" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnSave">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="txtContactNum" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtDueDate" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="cboStatus" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="txtComments" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnEdit" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnSave" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancel" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnCancel">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="btnCancel" UpdatePanelRenderMode="Inline" />
                    <telerik:AjaxUpdatedControl ControlID="btnCancelConfirm" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="gridPlaceOrder">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="gridPlaceOrder" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnSubmitWindow">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="btnSubmitWindow" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="gridPlaceOrder">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="gridPlaceOrder" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnSubmitWindow">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="btnSubmitWindow" UpdatePanelRenderMode="Inline" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div id="orderSearchGrid">
        <fieldset>
            <legend style="text-align: left">Order Search</legend>
            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel" runat="server" Skin="Office2010Blue"
                MinDisplayTime="500" />
            <telerik:RadGrid ID="orderSearchGridView" runat="server" AllowFilteringByColumn="True"
                AllowSorting="True" CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None"
                Skin="Outlook" AllowPaging="True" OnItemDataBound="OrderSearchGridViewItemDataBound"
                PageSize="4" OnSelectedIndexChanged="OrderSearchGridViewSelectedIndexChanged">
                <MasterTableView DataKeyNames="Order#" DataSourceID="SqlDataSource1">
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT ORDER# as Order#, c.CLIENT# as Client#, CASE Status WHEN 'P' THEN 'Pending' WHEN 'C' THEN 'Completed' END AS 'Status' FROM ORDERS O INNER JOIN CLIENT C ON o.client# = c.client#">
            </asp:SqlDataSource>
        </fieldset>
    </div>
    <div id="orderOverview">
        <fieldset>
            <legend style="text-align: left">Order Overview</legend>
            <div>
                <table style="width: 100%">
                    <tr>
                        <td class="orderDetails">
                            <label for="txtOrderNum">
                                Order#:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtOrderNum" runat="server" />
                        </td>
                        <td class="orderDetails">
                            <label for="txtClientNum">
                                Client#:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtClientNum" runat="server" />
                        </td>
                        <td class="orderDetails">
                            <label for="txtName">
                                Name:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtName" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="orderDetails">
                            <label for="txtContactNum">
                                Contact#:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtContactNum" runat="server" />
                        </td>
                        <td class="orderDetails">
                            <label for="txtAddress">
                                Address:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtAddress" runat="server" />
                        </td>
                        <td class="orderDetails">
                            <label for="txtCityState">
                                City/ST/Zip:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtCityState"
                                    runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="orderDetails">
                            <asp:RequiredFieldValidator ForeColor="Red" Text="*" ID="txtDueDateRequired" runat="server"
                                ErrorMessage="Enter a due date." ControlToValidate="txtDueDate" ValidationGroup="OrderSearch" />
                            <asp:RegularExpressionValidator ValidationExpression="^([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])[- / .](1[9][0-9][0-9]|2[0][0-9][0-9])$"
                                ForeColor="Red" ControlToValidate="txtDueDate" Text="*" ValidationGroup="OrderSearch"
                                ID="txtDueDateExpression" runat="server" ErrorMessage="Enter a valid date between today and 3 months from today in MM/DD/YYYY format." />
                            <label for="txtDueDate">
                                Due Date:</label>
                            <asp:TextBox Width="135px" ValidationGroup="OrderSearch" ReadOnly="True" ID="txtDueDate"
                                runat="server" />
                        </td>
                        <td class="orderDetails">
                            <label for="cboStatus">
                                Order Status:</label><telerik:RadComboBox Width="135px" Enabled="False" ID="cboStatus"
                                    runat="server" Skin="Office2010Blue">
                                    <Items>
                                        <telerik:RadComboBoxItem runat="server" Text="Pending" Value="Pending" />
                                        <telerik:RadComboBoxItem runat="server" Text="Completed" Value="Completed" />
                                    </Items>
                                </telerik:RadComboBox>
                        </td>
                        <td class="orderDetails">
                            <label for="txtCreatorID">
                                Creator ID:</label><asp:TextBox Width="135px" ReadOnly="True" ID="txtCreatorID" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 33%">
                            <label for="txtComments">
                                Order Comments:</label>
                            <telerik:RadTextBox ID="txtComments" ReadOnly="True" runat="server" TextMode="MultiLine"
                                Rows="5" Skin="" Width="100%" />
                        </td>
                        <td colspan="2" style="padding-left: 10px; width: 66%">
                            <label for="gridOrderedProducts">
                                Ordered Products:</label>
                            <telerik:RadGrid ID="gridOrderedProducts" Width="100%" runat="server" Skin="Outlook"
                                CellSpacing="0" GridLines="None" PageSize="3" Visible="False">
                                <ClientSettings>
                                    <Scrolling AllowScroll="True" ScrollHeight="50px" UseStaticHeaders="True" EnableVirtualScrollPaging="False" />
                                </ClientSettings>
                                <MasterTableView AutoGenerateColumns="True">
                                    <CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>
                                    <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                                    </RowIndicatorColumn>
                                    <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                                    </ExpandCollapseColumn>
                                    <EditFormSettings>
                                        <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                        </EditColumn>
                                    </EditFormSettings>
                                </MasterTableView>
                                <FilterMenu EnableImageSprites="False">
                                </FilterMenu>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: right">
                            <telerik:RadButton ID="btnEdit" runat="server" Visible="False" Text="Edit" Skin="Office2010Blue"
                                OnClick="BtnEditClick" CausesValidation="False" />
                            <telerik:RadButton ID="btnSave" ValidationGroup="OrderSearch" runat="server" Visible="False"
                                Text="Save" Skin="Office2010Blue" OnClick="BtnSaveClick" />
                            <telerik:RadButton ID="btnCancel" runat="server" Visible="False" Text="Cancel" Skin="Office2010Blue"
                                OnClick="BtnCancelClick" />
                            <telerik:RadButton ID="btnCancelConfirm" runat="server" Visible="False" Text="Cancel!"
                                Skin="Black" OnClick="BtnCancelConfirmClick" />
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>
        <table style="text-align: left">
            <tr>
                <td>
                    <asp:ValidationSummary HeaderText="Correct the following errors:" ValidationGroup="OrderSearch"
                        ForeColor="Red" Visible="True" Width="250px" DisplayMode="BulletList" ID="ValidationSummary1"
                        runat="server" />
                </td>
            </tr>
        </table>
    </div>
    <div id="restrictionZone" style="margin-left: 25%; margin-right: 25%; width: 50%;">
    </div>
    <telerik:RadWindow ID="windowPlaceOrder" MinWidth="800px" Width="800px" MaxWidth="800px"
        VisibleOnPageLoad="True" ShowContentDuringLoad="False" Height="500px" MaxHeight="500px"
        MinHeight="500px" runat="server" Modal="True" Skin="Office2010Blue">
        <ContentTemplate>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 100%; text-align: center;">
                        <asp:Label ID="lblPlaceOrderWindow" Text="Order Entry For Client# " Style="color: #45638B"
                            Width="50%" runat="server" Font-Size="Large" />
                    </td>
                </tr>
            </table>
            <table style="width: 100%; margin-bottom: 20px;">
                <tr>
                    <td style="text-align: right">
                        <label for="txtNameWindow">
                            Name:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNameWindow" ReadOnly="True" runat="server" />
                    </td>
                    <td style="text-align: right">
                        <label for="txtAddressWindow">
                            Address:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddressWindow" ReadOnly="True" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        <label for="txtCityStateWindow">
                            City/State/Zip:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCityStateWindow" ReadOnly="True" runat="server" />
                    </td>
                    <td style="text-align: right">
                        <label for="txtContactNumWindow">
                            Contact#:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContactNumWindow" ReadOnly="True" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; vertical-align: top">
                        <label for="dateDueDateWindow">
                            Due Date:</label>
                    </td>
                    <td style="vertical-align: top">
                        <telerik:RadDatePicker ID="dateDueDateWindow" runat="server" Skin="Office2010Blue" />
                    </td>
                    <td style="text-align: right; vertical-align: top">
                        <label for="txtCommentsWindow">
                            Comments:</label>
                    </td>
                    <td>
                        <asp:TextBox Rows="5" ID="txtCommentsWindow" TextMode="MultiLine" runat="server"
                            Width="160px" />
                    </td>
                </tr>
            </table>
            <telerik:RadGrid ID="gridPlaceOrder" Height="200px" DataSourceID="AvailableProductDS"
                runat="server" Skin="Outlook" CssClass="textAlignCenter" AllowMultiRowSelection="True">
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
                </MasterTableView>
            </telerik:RadGrid>
            <table style="width: 100%">
                <tr>
                    <td style="text-align: right">
                        <telerik:RadButton ID="btnSubmitWindow" OnClick="BtnSubmitWindowClick" runat="server"
                            Text="Submit" Skin="Office2010Blue" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </telerik:RadWindow>
    <asp:SqlDataSource ID="AvailableProductDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT [ProductID],  [Name],  [Category]
                                        = CASE WHEN Category = 'LD' THEN 'Long Distance'
                                        WHEN Category = 'TV' THEN 'Televison'
                                        ELSE Category END
                                        , [Price] FROM [PRODUCT] ORDER BY [Category], [Price]" />
    <telerik:RadWindow ID="windowExistingOrder" VisibleOnPageLoad="True" runat="server"
        Modal="True" Skin="Office2010Blue" Title="Pending Order Found">
        <ContentTemplate>
            <asp:Label ID="lblExistingOrder" ForeColor="#45638B" runat="server">
                             The selected client already has a pending order. Please
                             use "Order Search" to view their order's details. If the client
                             is looking to change products on their order, please cancel
                             the previous order and create a new one.
            </asp:Label>
        </ContentTemplate>
    </telerik:RadWindow>
</asp:Content>