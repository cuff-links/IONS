<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Invoices.aspx.cs" Inherits="IONS.Invoices" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=6.1.12.611, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMaster" runat="server">
    <h1 class="textAlignCenter" style="color: #45638B">
        IONS Invoices</h1>
    <table style="width: 100%">
        <tr>
            <td>
            </td>
        </tr>
    </table>
    <div class="reportDiv">
        <telerik:ReportViewer ID="InvoicesReportViewer" runat="server" Height="400px" Width="850px">
<typereportsource
              typename="IONS.InvoiceReport, IONS, Version=2012.1.419.0, Culture=neutral, PublicKeyToken=null"></typereportsource>
        </telerik:ReportViewer>
    </div>
</asp:Content>