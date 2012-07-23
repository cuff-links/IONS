namespace IONS
{
    partial class InvoiceReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.ClientNumberParameterDS = new Telerik.Reporting.SqlDataSource();
            this.InvoiceDateParameterDS = new Telerik.Reporting.SqlDataSource();
            this.InvoiceReportDS = new Telerik.Reporting.SqlDataSource();
            this.groupHeaderSection1 = new Telerik.Reporting.GroupHeaderSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.groupFooterSection1 = new Telerik.Reporting.GroupFooterSection();
            this.group1 = new Telerik.Reporting.Group();
            this.nameGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.nameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nameDataTextBox = new Telerik.Reporting.TextBox();
            this.nameGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.nameGroup = new Telerik.Reporting.Group();
            this.invoiceIDGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.invoiceIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.invoiceIDDataTextBox = new Telerik.Reporting.TextBox();
            this.invoiceIDGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.invoiceIDGroup = new Telerik.Reporting.Group();
            this.addressGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.addressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.addressDataTextBox = new Telerik.Reporting.TextBox();
            this.addressGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.addressGroup = new Telerik.Reporting.Group();
            this.cityGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.cityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cityDataTextBox = new Telerik.Reporting.TextBox();
            this.cityGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.cityGroup = new Telerik.Reporting.Group();
            this.stateGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.stateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.stateDataTextBox = new Telerik.Reporting.TextBox();
            this.stateGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.priceSumFunctionTextBox6 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.stateGroup = new Telerik.Reporting.Group();
            this.zipGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.zipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.zipDataTextBox = new Telerik.Reporting.TextBox();
            this.zipGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.zipGroup = new Telerik.Reporting.Group();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.categoryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.priceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateDataTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.categoryDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.priceDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ClientNumberParameterDS
            // 
            this.ClientNumberParameterDS.ConnectionString = "ConnectionString";
            this.ClientNumberParameterDS.Name = "ClientNumberParameterDS";
            this.ClientNumberParameterDS.SelectCommand = "SELECT i.Client#, c.LastName + \', \' + c.FirstName AS \'Name\'\r\nfrom INVOICE i INNER" +
    " JOIN CLIENT c on i.Client# = c.Client#\r\nORDER BY Name";
            // 
            // InvoiceDateParameterDS
            // 
            this.InvoiceDateParameterDS.ConnectionString = "ConnectionString";
            this.InvoiceDateParameterDS.Name = "InvoiceDateParameterDS";
            this.InvoiceDateParameterDS.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ClientNumber", System.Data.DbType.String, "=Parameters.Client.Value")});
            this.InvoiceDateParameterDS.SelectCommand = "SELECT CONVERT(VARCHAR,InvoiceDate)as invoiceDate FROM invoice WHERE Client# = @C" +
    "lientNumber\r\nORDER BY InvoiceDate";
            // 
            // InvoiceReportDS
            // 
            this.InvoiceReportDS.ConnectionString = "ConnectionString";
            this.InvoiceReportDS.Name = "InvoiceReportDS";
            this.InvoiceReportDS.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ClientNumber", System.Data.DbType.String, "=Parameters.Client.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@InvoiceDate", System.Data.DbType.DateTime, "=Parameters.InvoiceDate.Value")});
            this.InvoiceReportDS.SelectCommand = resources.GetString("InvoiceReportDS.SelectCommand");
            // 
            // groupHeaderSection1
            // 
            this.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.groupHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
            this.groupHeaderSection1.Name = "groupHeaderSection1";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Client:";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.258333683013916D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=Fields.[Client#]";
            // 
            // groupFooterSection1
            // 
            this.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30200448632240295D);
            this.groupFooterSection1.Name = "groupFooterSection1";
            // 
            // group1
            // 
            this.group1.GroupFooter = this.groupFooterSection1;
            this.group1.GroupHeader = this.groupHeaderSection1;
            this.group1.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.[Client#]")});
            this.group1.Name = "group1";
            // 
            // nameGroupHeader
            // 
            this.nameGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.nameGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nameCaptionTextBox,
            this.nameDataTextBox});
            this.nameGroupHeader.Name = "nameGroupHeader";
            // 
            // nameCaptionTextBox
            // 
            this.nameCaptionTextBox.CanGrow = true;
            this.nameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nameCaptionTextBox.Name = "nameCaptionTextBox";
            this.nameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nameCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.nameCaptionTextBox.StyleName = "Caption";
            this.nameCaptionTextBox.Value = "Name:";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = true;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.nameDataTextBox.StyleName = "Data";
            this.nameDataTextBox.Value = "=Fields.Name";
            // 
            // nameGroupFooter
            // 
            this.nameGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.nameGroupFooter.Name = "nameGroupFooter";
            // 
            // nameGroup
            // 
            this.nameGroup.GroupFooter = this.nameGroupFooter;
            this.nameGroup.GroupHeader = this.nameGroupHeader;
            this.nameGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.Name")});
            this.nameGroup.Name = "nameGroup";
            // 
            // invoiceIDGroupHeader
            // 
            this.invoiceIDGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.invoiceIDGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceIDCaptionTextBox,
            this.invoiceIDDataTextBox});
            this.invoiceIDGroupHeader.Name = "invoiceIDGroupHeader";
            // 
            // invoiceIDCaptionTextBox
            // 
            this.invoiceIDCaptionTextBox.CanGrow = true;
            this.invoiceIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.invoiceIDCaptionTextBox.Name = "invoiceIDCaptionTextBox";
            this.invoiceIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.invoiceIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceIDCaptionTextBox.StyleName = "Caption";
            this.invoiceIDCaptionTextBox.Value = "Invoice ID:";
            // 
            // invoiceIDDataTextBox
            // 
            this.invoiceIDDataTextBox.CanGrow = true;
            this.invoiceIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.invoiceIDDataTextBox.Name = "invoiceIDDataTextBox";
            this.invoiceIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.invoiceIDDataTextBox.StyleName = "Data";
            this.invoiceIDDataTextBox.Value = "=Fields.InvoiceID";
            // 
            // invoiceIDGroupFooter
            // 
            this.invoiceIDGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.invoiceIDGroupFooter.Name = "invoiceIDGroupFooter";
            // 
            // invoiceIDGroup
            // 
            this.invoiceIDGroup.GroupFooter = this.invoiceIDGroupFooter;
            this.invoiceIDGroup.GroupHeader = this.invoiceIDGroupHeader;
            this.invoiceIDGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.InvoiceID")});
            this.invoiceIDGroup.Name = "invoiceIDGroup";
            // 
            // addressGroupHeader
            // 
            this.addressGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.addressGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.addressCaptionTextBox,
            this.addressDataTextBox});
            this.addressGroupHeader.Name = "addressGroupHeader";
            // 
            // addressCaptionTextBox
            // 
            this.addressCaptionTextBox.CanGrow = true;
            this.addressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.addressCaptionTextBox.Name = "addressCaptionTextBox";
            this.addressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.addressCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.addressCaptionTextBox.StyleName = "Caption";
            this.addressCaptionTextBox.Value = "Address:";
            // 
            // addressDataTextBox
            // 
            this.addressDataTextBox.CanGrow = true;
            this.addressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.addressDataTextBox.Name = "addressDataTextBox";
            this.addressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.addressDataTextBox.StyleName = "Data";
            this.addressDataTextBox.Value = "=Fields.Address";
            // 
            // addressGroupFooter
            // 
            this.addressGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.addressGroupFooter.Name = "addressGroupFooter";
            // 
            // addressGroup
            // 
            this.addressGroup.GroupFooter = this.addressGroupFooter;
            this.addressGroup.GroupHeader = this.addressGroupHeader;
            this.addressGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.Address")});
            this.addressGroup.Name = "addressGroup";
            // 
            // cityGroupHeader
            // 
            this.cityGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.cityGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.cityCaptionTextBox,
            this.cityDataTextBox});
            this.cityGroupHeader.Name = "cityGroupHeader";
            // 
            // cityCaptionTextBox
            // 
            this.cityCaptionTextBox.CanGrow = true;
            this.cityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.cityCaptionTextBox.Name = "cityCaptionTextBox";
            this.cityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.cityCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.cityCaptionTextBox.StyleName = "Caption";
            this.cityCaptionTextBox.Value = "city:";
            // 
            // cityDataTextBox
            // 
            this.cityDataTextBox.CanGrow = true;
            this.cityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.cityDataTextBox.Name = "cityDataTextBox";
            this.cityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.cityDataTextBox.StyleName = "Data";
            this.cityDataTextBox.Value = "=Fields.city";
            // 
            // cityGroupFooter
            // 
            this.cityGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.cityGroupFooter.Name = "cityGroupFooter";
            // 
            // cityGroup
            // 
            this.cityGroup.GroupFooter = this.cityGroupFooter;
            this.cityGroup.GroupHeader = this.cityGroupHeader;
            this.cityGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.city")});
            this.cityGroup.Name = "cityGroup";
            // 
            // stateGroupHeader
            // 
            this.stateGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.stateGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.stateCaptionTextBox,
            this.stateDataTextBox});
            this.stateGroupHeader.Name = "stateGroupHeader";
            // 
            // stateCaptionTextBox
            // 
            this.stateCaptionTextBox.CanGrow = true;
            this.stateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.stateCaptionTextBox.Name = "stateCaptionTextBox";
            this.stateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.stateCaptionTextBox.StyleName = "Caption";
            this.stateCaptionTextBox.Value = "state:";
            // 
            // stateDataTextBox
            // 
            this.stateDataTextBox.CanGrow = true;
            this.stateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.stateDataTextBox.Name = "stateDataTextBox";
            this.stateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.stateDataTextBox.StyleName = "Data";
            this.stateDataTextBox.Value = "=Fields.state";
            // 
            // stateGroupFooter
            // 
            this.stateGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.stateGroupFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.priceSumFunctionTextBox6,
            this.textBox3});
            this.stateGroupFooter.Name = "stateGroupFooter";
            // 
            // priceSumFunctionTextBox6
            // 
            this.priceSumFunctionTextBox6.CanGrow = true;
            this.priceSumFunctionTextBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.priceSumFunctionTextBox6.Name = "priceSumFunctionTextBox6";
            this.priceSumFunctionTextBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.priceSumFunctionTextBox6.StyleName = "Data";
            this.priceSumFunctionTextBox6.Value = "=Sum(Fields.Price)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000005960464478D), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672D));
            this.textBox3.Value = "Monthly Total:";
            // 
            // stateGroup
            // 
            this.stateGroup.GroupFooter = this.stateGroupFooter;
            this.stateGroup.GroupHeader = this.stateGroupHeader;
            this.stateGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.state")});
            this.stateGroup.Name = "stateGroup";
            // 
            // zipGroupHeader
            // 
            this.zipGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.zipGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.zipCaptionTextBox,
            this.zipDataTextBox});
            this.zipGroupHeader.Name = "zipGroupHeader";
            // 
            // zipCaptionTextBox
            // 
            this.zipCaptionTextBox.CanGrow = true;
            this.zipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.zipCaptionTextBox.Name = "zipCaptionTextBox";
            this.zipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.zipCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.zipCaptionTextBox.StyleName = "Caption";
            this.zipCaptionTextBox.Value = "zip:";
            // 
            // zipDataTextBox
            // 
            this.zipDataTextBox.CanGrow = true;
            this.zipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84166669845581055D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.zipDataTextBox.Name = "zipDataTextBox";
            this.zipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.2582945823669434D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.zipDataTextBox.StyleName = "Data";
            this.zipDataTextBox.Value = "=Fields.zip";
            // 
            // zipGroupFooter
            // 
            this.zipGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.zipGroupFooter.Name = "zipGroupFooter";
            // 
            // zipGroup
            // 
            this.zipGroup.GroupFooter = this.zipGroupFooter;
            this.zipGroup.GroupHeader = this.zipGroupHeader;
            this.zipGroup.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("=Fields.zip")});
            this.zipGroup.Name = "zipGroup";
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3020043671131134D);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.categoryCaptionTextBox,
            this.textBox11,
            this.priceCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            // 
            // categoryCaptionTextBox
            // 
            this.categoryCaptionTextBox.CanGrow = true;
            this.categoryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.categoryCaptionTextBox.Name = "categoryCaptionTextBox";
            this.categoryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6790878772735596D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.categoryCaptionTextBox.StyleName = "Caption";
            this.categoryCaptionTextBox.Value = "Category";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.020931879058480263D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1999213695526123D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox11.StyleName = "Caption";
            this.textBox11.Value = "Product Name";
            // 
            // priceCaptionTextBox
            // 
            this.priceCaptionTextBox.CanGrow = true;
            this.priceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.020931879058480263D));
            this.priceCaptionTextBox.Name = "priceCaptionTextBox";
            this.priceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.priceCaptionTextBox.StyleName = "Caption";
            this.priceCaptionTextBox.Value = "Price";
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
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.079167366027832D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "=Fields.InvoiceID";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.66692352294921875D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox,
            this.textBox4,
            this.textBox5});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.46692338585853577D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.3790879249572754D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.46692338585853577D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.6999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.0999612808227539D), Telerik.Reporting.Drawing.Unit.Inch(0.26688385009765625D));
            this.textBox4.Value = "Please make checks payable to Plumbob Communications, LLC.  Send them to 19225 Fa" +
    "ke Address Road Fictional, FL 32708";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.26700210571289062D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.0999612808227539D), Telerik.Reporting.Drawing.Unit.Inch(0.19992129504680634D));
            this.textBox5.Value = "Be sure to include your account number on the check and to return the invoice wit" +
    "h your payment. Thank you for your business!";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0290683507919312D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.invoiceDateCaptionTextBox,
            this.invoiceDateDataTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.0999612808227539D), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374D));
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Plumbob Communications Monthly Statement ";
            // 
            // invoiceDateCaptionTextBox
            // 
            this.invoiceDateCaptionTextBox.CanGrow = true;
            this.invoiceDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.invoiceDateCaptionTextBox.Name = "invoiceDateCaptionTextBox";
            this.invoiceDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.invoiceDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceDateCaptionTextBox.StyleName = "Caption";
            this.invoiceDateCaptionTextBox.Value = "Invoice Date:";
            // 
            // invoiceDateDataTextBox
            // 
            this.invoiceDateDataTextBox.CanGrow = true;
            this.invoiceDateDataTextBox.Format = "{0:d}";
            this.invoiceDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.invoiceDateDataTextBox.Name = "invoiceDateDataTextBox";
            this.invoiceDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8603777885437012D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.invoiceDateDataTextBox.StyleName = "Data";
            this.invoiceDateDataTextBox.Value = "=Fields.InvoiceDate";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.categoryDataTextBox,
            this.textBox12,
            this.priceDataTextBox});
            this.detail.Name = "detail";
            // 
            // categoryDataTextBox
            // 
            this.categoryDataTextBox.CanGrow = true;
            this.categoryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.categoryDataTextBox.Name = "categoryDataTextBox";
            this.categoryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6790878772735596D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.categoryDataTextBox.StyleName = "Data";
            this.categoryDataTextBox.Value = "=Fields.Category";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1999213695526123D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox12.StyleName = "Data";
            this.textBox12.Value = "=Fields.[Product Name]";
            // 
            // priceDataTextBox
            // 
            this.priceDataTextBox.CanGrow = true;
            this.priceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.018927255645394325D));
            this.priceDataTextBox.Name = "priceDataTextBox";
            this.priceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.priceDataTextBox.StyleName = "Data";
            this.priceDataTextBox.Value = "=Fields.Price";
            // 
            // InvoiceReport
            // 
            this.DataSource = this.InvoiceReportDS;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.group1,
            this.nameGroup,
            this.invoiceIDGroup,
            this.addressGroup,
            this.cityGroup,
            this.stateGroup,
            this.zipGroup,
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection1,
            this.groupFooterSection1,
            this.nameGroupHeader,
            this.nameGroupFooter,
            this.invoiceIDGroupHeader,
            this.invoiceIDGroupFooter,
            this.addressGroupHeader,
            this.addressGroupFooter,
            this.cityGroupHeader,
            this.cityGroupFooter,
            this.stateGroupHeader,
            this.stateGroupFooter,
            this.zipGroupHeader,
            this.zipGroupFooter,
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "InvoiceReport";
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.AvailableValues.DataSource = this.ClientNumberParameterDS;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.Name";
            reportParameter1.AvailableValues.ValueMember = "= Fields.[Client#]";
            reportParameter1.Name = "Client";
            reportParameter1.Value = "= Parameters.Client.Value";
            reportParameter1.Visible = true;
            reportParameter2.AvailableValues.DataSource = this.InvoiceDateParameterDS;
            reportParameter2.AvailableValues.DisplayMember = "= Fields.invoiceDate";
            reportParameter2.AvailableValues.ValueMember = "= Fields.invoiceDate";
            reportParameter2.Name = "InvoiceDate";
            reportParameter2.Value = "= Fields.invoiceDate";
            reportParameter2.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(8.1000003814697266D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource InvoiceReportDS;
        private Telerik.Reporting.SqlDataSource ClientNumberParameterDS;
        private Telerik.Reporting.SqlDataSource InvoiceDateParameterDS;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection groupFooterSection1;
        private Telerik.Reporting.Group group1;
        private Telerik.Reporting.GroupHeaderSection nameGroupHeader;
        private Telerik.Reporting.TextBox nameCaptionTextBox;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.GroupFooterSection nameGroupFooter;
        private Telerik.Reporting.Group nameGroup;
        private Telerik.Reporting.GroupHeaderSection invoiceIDGroupHeader;
        private Telerik.Reporting.TextBox invoiceIDCaptionTextBox;
        private Telerik.Reporting.TextBox invoiceIDDataTextBox;
        private Telerik.Reporting.GroupFooterSection invoiceIDGroupFooter;
        private Telerik.Reporting.Group invoiceIDGroup;
        private Telerik.Reporting.GroupHeaderSection addressGroupHeader;
        private Telerik.Reporting.TextBox addressCaptionTextBox;
        private Telerik.Reporting.TextBox addressDataTextBox;
        private Telerik.Reporting.GroupFooterSection addressGroupFooter;
        private Telerik.Reporting.Group addressGroup;
        private Telerik.Reporting.GroupHeaderSection cityGroupHeader;
        private Telerik.Reporting.TextBox cityCaptionTextBox;
        private Telerik.Reporting.TextBox cityDataTextBox;
        private Telerik.Reporting.GroupFooterSection cityGroupFooter;
        private Telerik.Reporting.Group cityGroup;
        private Telerik.Reporting.GroupHeaderSection stateGroupHeader;
        private Telerik.Reporting.TextBox stateCaptionTextBox;
        private Telerik.Reporting.TextBox stateDataTextBox;
        private Telerik.Reporting.GroupFooterSection stateGroupFooter;
        private Telerik.Reporting.Group stateGroup;
        private Telerik.Reporting.GroupHeaderSection zipGroupHeader;
        private Telerik.Reporting.TextBox zipCaptionTextBox;
        private Telerik.Reporting.TextBox zipDataTextBox;
        private Telerik.Reporting.GroupFooterSection zipGroupFooter;
        private Telerik.Reporting.TextBox priceSumFunctionTextBox6;
        private Telerik.Reporting.Group zipGroup;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox categoryCaptionTextBox;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox priceCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox invoiceDateCaptionTextBox;
        private Telerik.Reporting.TextBox invoiceDateDataTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox categoryDataTextBox;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox priceDataTextBox;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;

    }
}