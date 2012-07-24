<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Reports.aspx.cs" Inherits="IONS.Reports" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=6.1.12.611, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Charting" TagPrefix="telerik" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMaster" runat="server">
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="All"
        Skin="Office2010Blue" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('#referralReport').hide();
            $('#chartSalesDiv').hide();
            $('#salesReport').hide();
            $('#pendingReport').hide();
        });
    </script>
    <script type="text/javascript">
        function showPending() {
            $('#referralReport').hide();
            $('#chartSalesDiv').hide();
            $('#salesReport').hide();
            $('#pendingReport').show('slow');
        }
    </script>
    <script type="text/javascript">
        function showSalesChart() {
            $('#referralReport').hide();
            $('#chartSalesDiv').show('slow');
            $('#salesReport').hide();
            $('#pendingReport').hide();
        }
    </script>
    <script type="text/javascript">
        function showReferral() {
            $('#referralReport').show('slow');
            $('#chartSalesDiv').hide();
            $('#salesReport').hide();
            $('#pendingReport').hide();
        }
    </script>
    <script type="text/javascript">
        function showSalesReport() {
            $('#referralReport').hide();
            $('#chartSalesDiv').hide();
            $('#salesReport').show('slow');
            $('#pendingReport').hide();
        }
    </script>
    <h1 class="textAlignCenter" style="color: #45638B">
        IONS Reports</h1>
    <telerik:RadAjaxPanel runat="server" ID="reportPanel" RenderMode="Inline">
        <table style="width: 100%; text-align: center;">
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnPending" Text="Pending Orders Report" OnClick="BtnPendingClick" />
                </td>
                <td>
                    <asp:Button ID="btnReferral" runat="server" Text="Referral Report" OnClick="BtnReferralClick" />
                </td>
                <td>
                    <asp:Button ID="btnSalesReport" runat="server" Text="Sales Report" OnClick="BtnSalesReportClick" />
                </td>
                <td>
                    <asp:Button ID="btnSalesChart" runat="server" Text="SalesChart" OnClick="BtnSalesChartClick" />
                </td>
            </tr>
        </table>
    </telerik:RadAjaxPanel>
    <div id="referralReport" class="reportDiv">
        <telerik:ReportViewer ID="ReferralReportViewer" runat="server" Height="400px" Skin="WebBlue"
            Width="850px" ParametersAreaVisible="False">
                <typereportsource
                    typename="IONS.ReferralReport, IONS, Version=2012.1.419.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
        </telerik:ReportViewer>
    </div>
    <div id="salesReport" style="height: 400px" class="reportDiv">
        <telerik:ReportViewer Height="400px" ID="SalesReportViewer" Width="850px" runat="server"
            Skin="Office2007">
                <typereportsource
                    typename="IONS.SalesReport, IONS, Version=2012.1.419.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
        </telerik:ReportViewer>
        <asp:SqlDataSource ID="ChartDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT  SUM(p.Price) as 'Annual Total'  , DATEPART(YEAR, o.duedate) as 'Year Of Sale' FROM ORDERS o
INNER JOIN ORDEREDPRODUCT op on o.Order# = op.Order#
INNER JOIN PRODUCT p on op.ProductID = p.ProductID
group by DATEPART(YEAR, o.duedate)"></asp:SqlDataSource>
    </div>
    <div id="chartSalesDiv" style="margin-right: 25%; margin-left: 25%; margin-top: 50px;
        width: 100%">
        <telerik:RadChart ID="chartSales" runat="server" DataSourceID="ChartDS" Skin="BabyBlue"
            Width="450px">
            <Appearance Corners="Round, Round, Round, Round, 3">
                <FillStyle MainColor="239, 255, 254">
                </FillStyle>
                <Border Color="188, 229, 231" Width="8" />
            </Appearance>
            <Series>
                <telerik:ChartSeries Name="Total" DataYColumn="Annual Total">
                    <Appearance>
                        <FillStyle FillType="Solid" MainColor="194, 230, 252">
                        </FillStyle>
                        <TextAppearance TextProperties-Color="78, 168, 188">
                        </TextAppearance>
                        <Border Color="177, 215, 250" />
                    </Appearance>
                </telerik:ChartSeries>
            </Series>
            <Legend>
                <Appearance Corners="Round, Round, Round, Round, 6" Dimensions-Margins="20%, 3%, 1px, 1px">
                    <ItemTextAppearance TextProperties-Color="120, 162, 19">
                    </ItemTextAppearance>
                    <Border Color="194, 212, 109" />
                </Appearance>
            </Legend>
            <PlotArea>
                <XAxis AutoScale="False" DataLabelsColumn="Year Of Sale" MaxValue="6" MinValue="0"
                    Step="1">
                    <Appearance Color="226, 218, 202" MajorTick-Color="216, 184, 86">
                        <MajorGridLines Color="244, 227, 195" Width="0" />
                        <TextAppearance TextProperties-Color="78, 168, 188">
                        </TextAppearance>
                    </Appearance>
                    <AxisLabel>
                        <TextBlock>
                            <Appearance TextProperties-Color="78, 168, 188">
                            </Appearance>
                        </TextBlock>
                    </AxisLabel>
                    <Items>
                        <telerik:ChartAxisItem>
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="1">
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="2">
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="3">
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="4">
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="5">
                        </telerik:ChartAxisItem>
                        <telerik:ChartAxisItem Value="6">
                        </telerik:ChartAxisItem>
                    </Items>
                </XAxis>
                <YAxis>
                    <Appearance Color="226, 218, 202" MajorTick-Color="216, 184, 86" MinorTick-Color="216, 184, 86">
                        <MajorGridLines Color="244, 227, 195" />
                        <MinorGridLines Color="244, 227, 195" />
                        <TextAppearance TextProperties-Color="78, 168, 188">
                        </TextAppearance>
                    </Appearance>
                    <AxisLabel>
                        <TextBlock>
                            <Appearance TextProperties-Color="78, 168, 188">
                            </Appearance>
                        </TextBlock>
                    </AxisLabel>
                </YAxis>
                <Appearance Dimensions-Margins="20%, 24%, 12%, 10%">
                    <FillStyle MainColor="255, 249, 239" SecondColor="Transparent">
                    </FillStyle>
                    <Border Color="226, 201, 156" />
                </Appearance>
            </PlotArea>
            <ChartTitle>
                <Appearance Dimensions-Margins="4%, 10px, 10px, 7%">
                    <FillStyle MainColor="">
                    </FillStyle>
                </Appearance>
                <TextBlock Text="Annual Sales">
                    <Appearance TextProperties-Color="232, 140, 0" TextProperties-Font="Verdana, 20pt, style=Bold">
                    </Appearance>
                </TextBlock>
            </ChartTitle>
        </telerik:RadChart>
    </div>
    <div id="pendingReport" class="reportDiv">
        <telerik:ReportViewer Height="400px" ID="PendingReportViewer" Width="850px" runat="server"
            Skin="Office2007" ParametersAreaVisible="False">
                <typereportsource
                    typename="IONS.PendingOrdersReport, IONS, Version=2012.1.419.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
        </telerik:ReportViewer>
    </div>
</asp:Content>