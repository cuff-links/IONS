namespace IONS
{
    partial class PendingOrdersReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingOrdersReport));
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.PendingOrdersDS = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.nAMECaptionTextBox = new Telerik.Reporting.TextBox();
            this.addressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.stateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.zipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.salesIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nAMECaptionTextBox1 = new Telerik.Reporting.TextBox();
            this.statusCaptionTextBox = new Telerik.Reporting.TextBox();
            this.groupHeaderSection1 = new Telerik.Reporting.GroupHeaderSection();
            this.groupFooterSection1 = new Telerik.Reporting.GroupFooterSection();
            this.group1 = new Telerik.Reporting.Group();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.nAMEDataTextBox = new Telerik.Reporting.TextBox();
            this.addressDataTextBox = new Telerik.Reporting.TextBox();
            this.cityDataTextBox = new Telerik.Reporting.TextBox();
            this.stateDataTextBox = new Telerik.Reporting.TextBox();
            this.zipDataTextBox = new Telerik.Reporting.TextBox();
            this.salesIDDataTextBox = new Telerik.Reporting.TextBox();
            this.nAMEDataTextBox1 = new Telerik.Reporting.TextBox();
            this.statusDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PendingOrdersDS
            // 
            this.PendingOrdersDS.ConnectionString = "ConnectionString";
            this.PendingOrdersDS.Name = "PendingOrdersDS";
            this.PendingOrdersDS.SelectCommand = resources.GetString("PendingOrdersDS.SelectCommand");
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.nAMECaptionTextBox,
            this.addressCaptionTextBox,
            this.cityCaptionTextBox,
            this.stateCaptionTextBox,
            this.zipCaptionTextBox,
            this.salesIDCaptionTextBox,
            this.nAMECaptionTextBox1,
            this.statusCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.67484253644943237D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Order#";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.69575458765029907D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7041667103767395D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Client#";
            // 
            // nAMECaptionTextBox
            // 
            this.nAMECaptionTextBox.CanGrow = true;
            this.nAMECaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.nAMECaptionTextBox.Name = "nAMECaptionTextBox";
            this.nAMECaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.91893929243087769D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nAMECaptionTextBox.Style.Font.Bold = true;
            this.nAMECaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.nAMECaptionTextBox.StyleName = "Caption";
            this.nAMECaptionTextBox.Value = "Client Name";
            // 
            // addressCaptionTextBox
            // 
            this.addressCaptionTextBox.CanGrow = true;
            this.addressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3190183639526367D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.addressCaptionTextBox.Name = "addressCaptionTextBox";
            this.addressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2809028625488281D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.addressCaptionTextBox.Style.Font.Bold = true;
            this.addressCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.addressCaptionTextBox.StyleName = "Caption";
            this.addressCaptionTextBox.Value = "Address";
            // 
            // cityCaptionTextBox
            // 
            this.cityCaptionTextBox.CanGrow = true;
            this.cityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.cityCaptionTextBox.Name = "cityCaptionTextBox";
            this.cityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7914307713508606D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.cityCaptionTextBox.Style.Font.Bold = true;
            this.cityCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.cityCaptionTextBox.StyleName = "Caption";
            this.cityCaptionTextBox.Value = "City";
            // 
            // stateCaptionTextBox
            // 
            this.stateCaptionTextBox.CanGrow = true;
            this.stateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3915095329284668D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.stateCaptionTextBox.Name = "stateCaptionTextBox";
            this.stateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60416662693023682D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stateCaptionTextBox.Style.Font.Bold = true;
            this.stateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.stateCaptionTextBox.StyleName = "Caption";
            this.stateCaptionTextBox.Value = "State";
            // 
            // zipCaptionTextBox
            // 
            this.zipCaptionTextBox.CanGrow = true;
            this.zipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9957551956176758D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.zipCaptionTextBox.Name = "zipCaptionTextBox";
            this.zipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60416662693023682D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.zipCaptionTextBox.Style.Font.Bold = true;
            this.zipCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.zipCaptionTextBox.StyleName = "Caption";
            this.zipCaptionTextBox.Value = "Zip";
            // 
            // salesIDCaptionTextBox
            // 
            this.salesIDCaptionTextBox.CanGrow = true;
            this.salesIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.salesIDCaptionTextBox.Name = "salesIDCaptionTextBox";
            this.salesIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69992130994796753D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.salesIDCaptionTextBox.Style.Font.Bold = true;
            this.salesIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.salesIDCaptionTextBox.StyleName = "Caption";
            this.salesIDCaptionTextBox.Value = "Sales ID";
            // 
            // nAMECaptionTextBox1
            // 
            this.nAMECaptionTextBox1.CanGrow = true;
            this.nAMECaptionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3000006675720215D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.nAMECaptionTextBox1.Name = "nAMECaptionTextBox1";
            this.nAMECaptionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999208688735962D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nAMECaptionTextBox1.Style.Font.Bold = true;
            this.nAMECaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.nAMECaptionTextBox1.StyleName = "Caption";
            this.nAMECaptionTextBox1.Value = "Product Name";
            // 
            // statusCaptionTextBox
            // 
            this.statusCaptionTextBox.CanGrow = true;
            this.statusCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.statusCaptionTextBox.Name = "statusCaptionTextBox";
            this.statusCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80412799119949341D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.statusCaptionTextBox.Style.Font.Bold = true;
            this.statusCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.statusCaptionTextBox.StyleName = "Caption";
            this.statusCaptionTextBox.Value = "Status";
            // 
            // groupHeaderSection1
            // 
            this.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.groupHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3});
            this.groupHeaderSection1.Name = "groupHeaderSection1";
            // 
            // groupFooterSection1
            // 
            this.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.groupFooterSection1.Name = "groupFooterSection1";
            // 
            // group1
            // 
            this.group1.GroupFooter = this.groupFooterSection1;
            this.group1.GroupHeader = this.groupHeaderSection1;
            this.group1.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.[Order#]")});
            this.group1.Name = "group1";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69567584991455078D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "=Fields.[Order#]";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.204167366027832D), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374D));
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Plumbob Communications Pending Orders Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.nAMEDataTextBox,
            this.addressDataTextBox,
            this.cityDataTextBox,
            this.stateDataTextBox,
            this.zipDataTextBox,
            this.salesIDDataTextBox,
            this.nAMEDataTextBox1,
            this.statusDataTextBox});
            this.detail.Name = "detail";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.69575458765029907D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70416641235351562D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "=Fields.[Client#]";
            // 
            // nAMEDataTextBox
            // 
            this.nAMEDataTextBox.CanGrow = true;
            this.nAMEDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.399999737739563D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.nAMEDataTextBox.Name = "nAMEDataTextBox";
            this.nAMEDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.91893941164016724D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nAMEDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.nAMEDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.nAMEDataTextBox.StyleName = "Data";
            this.nAMEDataTextBox.Value = "=Fields.NAME";
            // 
            // addressDataTextBox
            // 
            this.addressDataTextBox.CanGrow = true;
            this.addressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3190183639526367D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.addressDataTextBox.Name = "addressDataTextBox";
            this.addressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2809028625488281D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.addressDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.addressDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.addressDataTextBox.StyleName = "Data";
            this.addressDataTextBox.Value = "=Fields.Address";
            // 
            // cityDataTextBox
            // 
            this.cityDataTextBox.CanGrow = true;
            this.cityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.cityDataTextBox.Name = "cityDataTextBox";
            this.cityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7914307713508606D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.cityDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.cityDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.cityDataTextBox.StyleName = "Data";
            this.cityDataTextBox.Value = "=Fields.City";
            // 
            // stateDataTextBox
            // 
            this.stateDataTextBox.CanGrow = true;
            this.stateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3915095329284668D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.stateDataTextBox.Name = "stateDataTextBox";
            this.stateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60416597127914429D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.stateDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.stateDataTextBox.StyleName = "Data";
            this.stateDataTextBox.Value = "=Fields.State";
            // 
            // zipDataTextBox
            // 
            this.zipDataTextBox.CanGrow = true;
            this.zipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9957551956176758D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.zipDataTextBox.Name = "zipDataTextBox";
            this.zipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60416728258132935D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.zipDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.zipDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.zipDataTextBox.StyleName = "Data";
            this.zipDataTextBox.Value = "=Fields.Zip";
            // 
            // salesIDDataTextBox
            // 
            this.salesIDDataTextBox.CanGrow = true;
            this.salesIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.salesIDDataTextBox.Name = "salesIDDataTextBox";
            this.salesIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699920654296875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.salesIDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.salesIDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.salesIDDataTextBox.StyleName = "Data";
            this.salesIDDataTextBox.Value = "=Fields.SalesID";
            // 
            // nAMEDataTextBox1
            // 
            this.nAMEDataTextBox1.CanGrow = true;
            this.nAMEDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3000006675720215D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.nAMEDataTextBox1.Name = "nAMEDataTextBox1";
            this.nAMEDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999215841293335D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nAMEDataTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.nAMEDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.nAMEDataTextBox1.StyleName = "Data";
            this.nAMEDataTextBox1.Value = "=Fields.NAME";
            // 
            // statusDataTextBox
            // 
            this.statusDataTextBox.CanGrow = true;
            this.statusDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.statusDataTextBox.Name = "statusDataTextBox";
            this.statusDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80416679382324219D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.statusDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.statusDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.statusDataTextBox.StyleName = "Data";
            this.statusDataTextBox.Value = "=Fields.Status";
            // 
            // PendingOrdersReport
            // 
            this.DataSource = this.PendingOrdersDS;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup,
            this.group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.groupHeaderSection1,
            this.groupFooterSection1,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "PendingOrdersReport";
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule2.Style.Color = System.Drawing.Color.White;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(8.204167366027832D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PendingOrdersDS;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox nAMECaptionTextBox;
        private Telerik.Reporting.TextBox addressCaptionTextBox;
        private Telerik.Reporting.TextBox cityCaptionTextBox;
        private Telerik.Reporting.TextBox stateCaptionTextBox;
        private Telerik.Reporting.TextBox zipCaptionTextBox;
        private Telerik.Reporting.TextBox salesIDCaptionTextBox;
        private Telerik.Reporting.TextBox nAMECaptionTextBox1;
        private Telerik.Reporting.TextBox statusCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.GroupFooterSection groupFooterSection1;
        private Telerik.Reporting.Group group1;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox nAMEDataTextBox;
        private Telerik.Reporting.TextBox addressDataTextBox;
        private Telerik.Reporting.TextBox cityDataTextBox;
        private Telerik.Reporting.TextBox stateDataTextBox;
        private Telerik.Reporting.TextBox zipDataTextBox;
        private Telerik.Reporting.TextBox salesIDDataTextBox;
        private Telerik.Reporting.TextBox nAMEDataTextBox1;
        private Telerik.Reporting.TextBox statusDataTextBox;

    }
}