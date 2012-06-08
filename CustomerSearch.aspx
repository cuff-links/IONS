<%@ Page Title="" Language="C#" MasterPageFile="~/OrderEntry.master" AutoEventWireup="true"
    CodeFile="CustomerSearch.aspx.cs" Inherits="CustomerSearch" %>

<asp:Content runat="server" ID="content2" ContentPlaceHolderID="headOE">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphOrderEntry" runat="Server">
    <div id="customerSearchGrid">
        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Office2010Blue"
            MinDisplayTime="500" />
        <telerik:RadAjaxPanel ID="ajaxPanelCustomerSearchGrid" runat="server" LoadingPanelID="RadAjaxLoadingPanel1">
            <telerik:RadGrid ID="customerSearchGridView" runat="server" AllowFilteringByColumn="True"
                AllowSorting="True" CellSpacing="0" DataSourceID="CustomerSearchDS" GridLines="None"
                Skin="Outlook" AllowPaging="True" OnItemDataBound="CustomerSearchGridViewItemDataBound"
                PageSize="5" OnSelectedIndexChanged="CustomerSearchGridViewSelectedIndexChanged">
                <MasterTableView DataKeyNames="Customer#" DataSourceID="CustomerSearchDS">
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
                <PagerStyle Mode="Advanced" />
                <FilterMenu EnableImageSprites="False">
                </FilterMenu>
            </telerik:RadGrid>
            <asp:SqlDataSource ID="CustomerSearchDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT Customer#, FirstName + LastName as 'Name', SSN as 'Social Security#', ContactNumber as 'Contact#' FROM Customer" />
        </telerik:RadAjaxPanel>
    </div>
    <div id="customerOverview">
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="CustomerSearchDS">
        </asp:DetailsView>
        <asp:SqlDataSource ID="CustomerOverviewDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" />
    </div>
</asp:Content>