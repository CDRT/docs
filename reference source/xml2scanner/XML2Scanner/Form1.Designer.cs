using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace XML2Scanner
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchCatalog = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.PkgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Released = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebootType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml2_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crcactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tp_status = new System.Windows.Forms.TabPage();
            this.Button3 = new System.Windows.Forms.Button();
            this.tp_packages = new System.Windows.Forms.TabPage();
            this.gbColumns = new System.Windows.Forms.GroupBox();
            this.cbBrand = new System.Windows.Forms.CheckBox();
            this.cbVersion = new System.Windows.Forms.CheckBox();
            this.cbSeverity = new System.Windows.Forms.CheckBox();
            this.cbReboot = new System.Windows.Forms.CheckBox();
            this.cbPackageType = new System.Windows.Forms.CheckBox();
            this.cbComment = new System.Windows.Forms.CheckBox();
            this.cbCRC_Actual = new System.Windows.Forms.CheckBox();
            this.cbCRC_Catalog = new System.Windows.Forms.CheckBox();
            this.cbXML2Path = new System.Windows.Forms.CheckBox();
            this.cbValid = new System.Windows.Forms.CheckBox();
            this.cbSetup = new System.Windows.Forms.CheckBox();
            this.cbCategory = new System.Windows.Forms.CheckBox();
            this.cbLanguage = new System.Windows.Forms.CheckBox();
            this.cbReleased = new System.Windows.Forms.CheckBox();
            this.cbPackageID = new System.Windows.Forms.CheckBox();
            this.cbTitle = new System.Windows.Forms.CheckBox();
            this.cbPackageName = new System.Windows.Forms.CheckBox();
            this.btnColumns = new System.Windows.Forms.Button();
            this.btnCheckCRC = new System.Windows.Forms.Button();
            this.cbWin10 = new System.Windows.Forms.CheckBox();
            this.cbWin8 = new System.Windows.Forms.CheckBox();
            this.linkTaxonomy = new System.Windows.Forms.LinkLabel();
            this.cbWin7 = new System.Windows.Forms.CheckBox();
            this.cbWinVista = new System.Windows.Forms.CheckBox();
            this.cbWinXP = new System.Windows.Forms.CheckBox();
            this.btnThink = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.linkDocks = new System.Windows.Forms.LinkLabel();
            this._rbWin10 = new System.Windows.Forms.RadioButton();
            this._rbWin81 = new System.Windows.Forms.RadioButton();
            this._rbWin7 = new System.Windows.Forms.RadioButton();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tp_status.SuspendLayout();
            this.tp_packages.SuspendLayout();
            this.gbColumns.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(17, 18);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(181, 30);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Machine Type:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(31, 32);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 30);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Package ID";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(90, 56);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 30);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "OS:";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(131, 15);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(106, 37);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(122, 30);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(142, 37);
            this.TextBox2.TabIndex = 5;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "WinXP",
            "WinVista",
            "Win7",
            "Win8",
            "Win10"});
            this.ComboBox1.Location = new System.Drawing.Point(807, 114);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(106, 38);
            this.ComboBox1.TabIndex = 6;
            this.ComboBox1.Visible = false;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnSearchCatalog
            // 
            this.btnSearchCatalog.Enabled = false;
            this.btnSearchCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCatalog.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCatalog.Location = new System.Drawing.Point(273, 48);
            this.btnSearchCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCatalog.Name = "btnSearchCatalog";
            this.btnSearchCatalog.Size = new System.Drawing.Size(96, 32);
            this.btnSearchCatalog.TabIndex = 7;
            this.btnSearchCatalog.Text = "Search";
            this.btnSearchCatalog.UseVisualStyleBackColor = true;
            this.btnSearchCatalog.Click += new System.EventHandler(this.btnSearchCatalog_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkgID,
            this.PackageName,
            this.Title,
            this.Version,
            this.Released,
            this.PackageType,
            this.category,
            this.RebootType,
            this.Severity,
            this.Brand,
            this.Setup,
            this.language,
            this.Valid,
            this.xml2_path,
            this.CRC,
            this.crcactual,
            this.Comment});
            this.DataGridView1.Location = new System.Drawing.Point(8, 88);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 82;
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(1171, 315);
            this.DataGridView1.TabIndex = 8;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.DataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseDoubleClick);
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // PkgID
            // 
            this.PkgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PkgID.HeaderText = "PackageID";
            this.PkgID.MinimumWidth = 10;
            this.PkgID.Name = "PkgID";
            this.PkgID.ReadOnly = true;
            this.PkgID.Width = 168;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.MinimumWidth = 10;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            this.PackageName.Width = 198;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 100;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 105;
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.MinimumWidth = 10;
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Width = 137;
            // 
            // Released
            // 
            this.Released.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Released.HeaderText = "Released";
            this.Released.MinimumWidth = 10;
            this.Released.Name = "Released";
            this.Released.ReadOnly = true;
            this.Released.Width = 153;
            // 
            // PackageType
            // 
            this.PackageType.HeaderText = "Package Type";
            this.PackageType.MinimumWidth = 10;
            this.PackageType.Name = "PackageType";
            this.PackageType.ReadOnly = true;
            this.PackageType.Width = 187;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 10;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 155;
            // 
            // RebootType
            // 
            this.RebootType.HeaderText = "Reboot Type";
            this.RebootType.MinimumWidth = 10;
            this.RebootType.Name = "RebootType";
            this.RebootType.ReadOnly = true;
            this.RebootType.Width = 178;
            // 
            // Severity
            // 
            this.Severity.HeaderText = "Severity";
            this.Severity.MinimumWidth = 10;
            this.Severity.Name = "Severity";
            this.Severity.ReadOnly = true;
            this.Severity.Width = 144;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 10;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 121;
            // 
            // Setup
            // 
            this.Setup.HeaderText = "Setup";
            this.Setup.MinimumWidth = 10;
            this.Setup.Name = "Setup";
            this.Setup.ReadOnly = true;
            this.Setup.Width = 121;
            // 
            // language
            // 
            this.language.HeaderText = "Language";
            this.language.MinimumWidth = 10;
            this.language.Name = "language";
            this.language.ReadOnly = true;
            this.language.Visible = false;
            this.language.Width = 103;
            // 
            // Valid
            // 
            this.Valid.HeaderText = "Valid";
            this.Valid.MinimumWidth = 10;
            this.Valid.Name = "Valid";
            this.Valid.ReadOnly = true;
            this.Valid.Width = 110;
            // 
            // xml2_path
            // 
            this.xml2_path.HeaderText = "XML2 Path";
            this.xml2_path.MinimumWidth = 10;
            this.xml2_path.Name = "xml2_path";
            this.xml2_path.ReadOnly = true;
            this.xml2_path.Width = 159;
            // 
            // CRC
            // 
            this.CRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CRC.HeaderText = "CRC from Catalog";
            this.CRC.MinimumWidth = 10;
            this.CRC.Name = "CRC";
            this.CRC.ReadOnly = true;
            this.CRC.Width = 228;
            // 
            // crcactual
            // 
            this.crcactual.HeaderText = "CRC Actual";
            this.crcactual.MinimumWidth = 10;
            this.crcactual.Name = "crcactual";
            this.crcactual.ReadOnly = true;
            this.crcactual.Width = 162;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 10;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 165;
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.BackColor = System.Drawing.Color.DimGray;
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox1.ForeColor = System.Drawing.Color.White;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 32;
            this.ListBox1.Location = new System.Drawing.Point(10, 138);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.ScrollAlwaysVisible = true;
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox1.Size = new System.Drawing.Size(1167, 96);
            this.ListBox1.TabIndex = 9;
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(272, 26);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(96, 32);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "Search";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.tp_status);
            this.TabControl1.Controls.Add(this.tp_packages);
            this.TabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(15, 149);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1197, 502);
            this.TabControl1.TabIndex = 12;
            // 
            // tp_status
            // 
            this.tp_status.Controls.Add(this.Button3);
            this.tp_status.Controls.Add(this.ListBox1);
            this.tp_status.Location = new System.Drawing.Point(8, 46);
            this.tp_status.Name = "tp_status";
            this.tp_status.Padding = new System.Windows.Forms.Padding(3);
            this.tp_status.Size = new System.Drawing.Size(1181, 448);
            this.tp_status.TabIndex = 2;
            this.tp_status.Text = "Status";
            this.tp_status.UseVisualStyleBackColor = true;
            this.tp_status.Click += new System.EventHandler(this.tp_status_Click);
            // 
            // Button3
            // 
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Location = new System.Drawing.Point(512, 6);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(157, 41);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "Copy";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tp_packages
            // 
            this.tp_packages.Controls.Add(this.gbColumns);
            this.tp_packages.Controls.Add(this.btnColumns);
            this.tp_packages.Controls.Add(this.btnCheckCRC);
            this.tp_packages.Controls.Add(this.DataGridView1);
            this.tp_packages.Location = new System.Drawing.Point(8, 46);
            this.tp_packages.Margin = new System.Windows.Forms.Padding(4);
            this.tp_packages.Name = "tp_packages";
            this.tp_packages.Padding = new System.Windows.Forms.Padding(4);
            this.tp_packages.Size = new System.Drawing.Size(1181, 448);
            this.tp_packages.TabIndex = 0;
            this.tp_packages.Text = "Package List";
            this.tp_packages.UseVisualStyleBackColor = true;
            // 
            // gbColumns
            // 
            this.gbColumns.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbColumns.Controls.Add(this.cbBrand);
            this.gbColumns.Controls.Add(this.cbVersion);
            this.gbColumns.Controls.Add(this.cbSeverity);
            this.gbColumns.Controls.Add(this.cbReboot);
            this.gbColumns.Controls.Add(this.cbPackageType);
            this.gbColumns.Controls.Add(this.cbComment);
            this.gbColumns.Controls.Add(this.cbCRC_Actual);
            this.gbColumns.Controls.Add(this.cbCRC_Catalog);
            this.gbColumns.Controls.Add(this.cbXML2Path);
            this.gbColumns.Controls.Add(this.cbValid);
            this.gbColumns.Controls.Add(this.cbSetup);
            this.gbColumns.Controls.Add(this.cbCategory);
            this.gbColumns.Controls.Add(this.cbLanguage);
            this.gbColumns.Controls.Add(this.cbReleased);
            this.gbColumns.Controls.Add(this.cbPackageID);
            this.gbColumns.Controls.Add(this.cbTitle);
            this.gbColumns.Controls.Add(this.cbPackageName);
            this.gbColumns.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColumns.ForeColor = System.Drawing.Color.Black;
            this.gbColumns.Location = new System.Drawing.Point(7, 7);
            this.gbColumns.Name = "gbColumns";
            this.gbColumns.Size = new System.Drawing.Size(1175, 74);
            this.gbColumns.TabIndex = 18;
            this.gbColumns.TabStop = false;
            this.gbColumns.Text = "Columns";
            this.gbColumns.Enter += new System.EventHandler(this.gbColumns_Enter);
            // 
            // cbBrand
            // 
            this.cbBrand.AutoSize = true;
            this.cbBrand.Checked = true;
            this.cbBrand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBrand.Location = new System.Drawing.Point(997, 25);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(102, 34);
            this.cbBrand.TabIndex = 16;
            this.cbBrand.Text = "Brand";
            this.cbBrand.UseVisualStyleBackColor = true;
            this.cbBrand.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbVersion
            // 
            this.cbVersion.AutoSize = true;
            this.cbVersion.Checked = true;
            this.cbVersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVersion.Location = new System.Drawing.Point(345, 25);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(117, 34);
            this.cbVersion.TabIndex = 15;
            this.cbVersion.Text = "Version";
            this.cbVersion.UseVisualStyleBackColor = true;
            this.cbVersion.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbSeverity
            // 
            this.cbSeverity.AutoSize = true;
            this.cbSeverity.Checked = true;
            this.cbSeverity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSeverity.Location = new System.Drawing.Point(900, 24);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(123, 34);
            this.cbSeverity.TabIndex = 14;
            this.cbSeverity.Text = "Severity";
            this.cbSeverity.UseVisualStyleBackColor = true;
            this.cbSeverity.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbReboot
            // 
            this.cbReboot.AutoSize = true;
            this.cbReboot.Checked = true;
            this.cbReboot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReboot.Location = new System.Drawing.Point(775, 24);
            this.cbReboot.Name = "cbReboot";
            this.cbReboot.Size = new System.Drawing.Size(168, 34);
            this.cbReboot.TabIndex = 13;
            this.cbReboot.Text = "Reboot Type";
            this.cbReboot.UseVisualStyleBackColor = true;
            this.cbReboot.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbPackageType
            // 
            this.cbPackageType.AutoSize = true;
            this.cbPackageType.Checked = true;
            this.cbPackageType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPackageType.Location = new System.Drawing.Point(539, 25);
            this.cbPackageType.Name = "cbPackageType";
            this.cbPackageType.Size = new System.Drawing.Size(177, 34);
            this.cbPackageType.TabIndex = 12;
            this.cbPackageType.Text = "Package Type";
            this.cbPackageType.UseVisualStyleBackColor = true;
            this.cbPackageType.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbComment
            // 
            this.cbComment.AutoSize = true;
            this.cbComment.Checked = true;
            this.cbComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbComment.Location = new System.Drawing.Point(519, 46);
            this.cbComment.Name = "cbComment";
            this.cbComment.Size = new System.Drawing.Size(141, 34);
            this.cbComment.TabIndex = 11;
            this.cbComment.Text = "Comment";
            this.cbComment.UseVisualStyleBackColor = true;
            this.cbComment.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbCRC_Actual
            // 
            this.cbCRC_Actual.AutoSize = true;
            this.cbCRC_Actual.Checked = true;
            this.cbCRC_Actual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCRC_Actual.Location = new System.Drawing.Point(404, 46);
            this.cbCRC_Actual.Name = "cbCRC_Actual";
            this.cbCRC_Actual.Size = new System.Drawing.Size(151, 34);
            this.cbCRC_Actual.TabIndex = 7;
            this.cbCRC_Actual.Text = "CRC Actual";
            this.cbCRC_Actual.UseVisualStyleBackColor = true;
            this.cbCRC_Actual.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbCRC_Catalog
            // 
            this.cbCRC_Catalog.AutoSize = true;
            this.cbCRC_Catalog.Checked = true;
            this.cbCRC_Catalog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCRC_Catalog.Location = new System.Drawing.Point(280, 46);
            this.cbCRC_Catalog.Name = "cbCRC_Catalog";
            this.cbCRC_Catalog.Size = new System.Drawing.Size(166, 34);
            this.cbCRC_Catalog.TabIndex = 6;
            this.cbCRC_Catalog.Text = "CRC Catalog";
            this.cbCRC_Catalog.UseVisualStyleBackColor = true;
            this.cbCRC_Catalog.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbXML2Path
            // 
            this.cbXML2Path.AutoSize = true;
            this.cbXML2Path.Checked = true;
            this.cbXML2Path.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbXML2Path.Location = new System.Drawing.Point(173, 46);
            this.cbXML2Path.Name = "cbXML2Path";
            this.cbXML2Path.Size = new System.Drawing.Size(135, 34);
            this.cbXML2Path.TabIndex = 5;
            this.cbXML2Path.Text = "XML Path";
            this.cbXML2Path.UseVisualStyleBackColor = true;
            this.cbXML2Path.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbValid
            // 
            this.cbValid.AutoSize = true;
            this.cbValid.Checked = true;
            this.cbValid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbValid.Location = new System.Drawing.Point(97, 46);
            this.cbValid.Name = "cbValid";
            this.cbValid.Size = new System.Drawing.Size(91, 34);
            this.cbValid.TabIndex = 4;
            this.cbValid.Text = "Valid";
            this.cbValid.UseVisualStyleBackColor = true;
            this.cbValid.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbSetup
            // 
            this.cbSetup.AutoSize = true;
            this.cbSetup.Checked = true;
            this.cbSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSetup.Location = new System.Drawing.Point(15, 46);
            this.cbSetup.Name = "cbSetup";
            this.cbSetup.Size = new System.Drawing.Size(101, 34);
            this.cbSetup.TabIndex = 2;
            this.cbSetup.Text = "Setup";
            this.cbSetup.UseVisualStyleBackColor = true;
            this.cbSetup.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoSize = true;
            this.cbCategory.Checked = true;
            this.cbCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCategory.Location = new System.Drawing.Point(670, 24);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 34);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "Category";
            this.cbCategory.UseVisualStyleBackColor = true;
            this.cbCategory.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbLanguage
            // 
            this.cbLanguage.AutoSize = true;
            this.cbLanguage.Location = new System.Drawing.Point(627, 46);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(139, 34);
            this.cbLanguage.TabIndex = 3;
            this.cbLanguage.Text = "Language";
            this.cbLanguage.UseVisualStyleBackColor = true;
            this.cbLanguage.Visible = false;
            // 
            // cbReleased
            // 
            this.cbReleased.AutoSize = true;
            this.cbReleased.Checked = true;
            this.cbReleased.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReleased.Location = new System.Drawing.Point(437, 25);
            this.cbReleased.Name = "cbReleased";
            this.cbReleased.Size = new System.Drawing.Size(131, 34);
            this.cbReleased.TabIndex = 0;
            this.cbReleased.Text = "Released";
            this.cbReleased.UseVisualStyleBackColor = true;
            this.cbReleased.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbPackageID
            // 
            this.cbPackageID.AutoSize = true;
            this.cbPackageID.Checked = true;
            this.cbPackageID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPackageID.Location = new System.Drawing.Point(15, 25);
            this.cbPackageID.Name = "cbPackageID";
            this.cbPackageID.Size = new System.Drawing.Size(151, 34);
            this.cbPackageID.TabIndex = 8;
            this.cbPackageID.Text = "Package ID";
            this.cbPackageID.UseVisualStyleBackColor = true;
            this.cbPackageID.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged_1);
            // 
            // cbTitle
            // 
            this.cbTitle.AutoSize = true;
            this.cbTitle.Checked = true;
            this.cbTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTitle.Location = new System.Drawing.Point(271, 24);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(86, 34);
            this.cbTitle.TabIndex = 10;
            this.cbTitle.Text = "Title";
            this.cbTitle.UseVisualStyleBackColor = true;
            this.cbTitle.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // cbPackageName
            // 
            this.cbPackageName.AutoSize = true;
            this.cbPackageName.Checked = true;
            this.cbPackageName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPackageName.Location = new System.Drawing.Point(132, 24);
            this.cbPackageName.Name = "cbPackageName";
            this.cbPackageName.Size = new System.Drawing.Size(188, 34);
            this.cbPackageName.TabIndex = 9;
            this.cbPackageName.Text = "Package Name";
            this.cbPackageName.UseVisualStyleBackColor = true;
            this.cbPackageName.CheckedChanged += new System.EventHandler(this.cbPackageID_CheckedChanged);
            // 
            // btnColumns
            // 
            this.btnColumns.Location = new System.Drawing.Point(992, 7);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(116, 34);
            this.btnColumns.TabIndex = 17;
            this.btnColumns.Text = "Columns...";
            this.btnColumns.UseVisualStyleBackColor = true;
            // 
            // btnCheckCRC
            // 
            this.btnCheckCRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckCRC.Enabled = false;
            this.btnCheckCRC.ForeColor = System.Drawing.Color.Black;
            this.btnCheckCRC.Location = new System.Drawing.Point(534, 413);
            this.btnCheckCRC.Name = "btnCheckCRC";
            this.btnCheckCRC.Size = new System.Drawing.Size(110, 28);
            this.btnCheckCRC.TabIndex = 16;
            this.btnCheckCRC.Text = "Check CRC";
            this.btnCheckCRC.UseVisualStyleBackColor = true;
            this.btnCheckCRC.Click += new System.EventHandler(this.btnCheckCRC_Click);
            // 
            // cbWin10
            // 
            this.cbWin10.AutoSize = true;
            this.cbWin10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWin10.Location = new System.Drawing.Point(174, 37);
            this.cbWin10.Name = "cbWin10";
            this.cbWin10.Size = new System.Drawing.Size(118, 34);
            this.cbWin10.TabIndex = 23;
            this.cbWin10.Text = "Win10";
            this.cbWin10.UseVisualStyleBackColor = true;
            this.cbWin10.CheckStateChanged += new System.EventHandler(this.cbWin7_CheckStateChanged);
            // 
            // cbWin8
            // 
            this.cbWin8.AutoSize = true;
            this.cbWin8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWin8.Location = new System.Drawing.Point(95, 37);
            this.cbWin8.Name = "cbWin8";
            this.cbWin8.Size = new System.Drawing.Size(104, 34);
            this.cbWin8.TabIndex = 22;
            this.cbWin8.Text = "Win8";
            this.cbWin8.UseVisualStyleBackColor = true;
            this.cbWin8.CheckStateChanged += new System.EventHandler(this.cbWin7_CheckStateChanged);
            // 
            // linkTaxonomy
            // 
            this.linkTaxonomy.AutoSize = true;
            this.linkTaxonomy.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkTaxonomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTaxonomy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(141)))), ((int)(((byte)(221)))));
            this.linkTaxonomy.Location = new System.Drawing.Point(284, 18);
            this.linkTaxonomy.Name = "linkTaxonomy";
            this.linkTaxonomy.Size = new System.Drawing.Size(130, 30);
            this.linkTaxonomy.TabIndex = 21;
            this.linkTaxonomy.TabStop = true;
            this.linkTaxonomy.Text = "Model List";
            this.linkTaxonomy.VisitedLinkColor = System.Drawing.Color.Gold;
            this.linkTaxonomy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTaxonomy_LinkClicked);
            // 
            // cbWin7
            // 
            this.cbWin7.AutoSize = true;
            this.cbWin7.Checked = true;
            this.cbWin7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWin7.Location = new System.Drawing.Point(20, 37);
            this.cbWin7.Name = "cbWin7";
            this.cbWin7.Size = new System.Drawing.Size(104, 34);
            this.cbWin7.TabIndex = 19;
            this.cbWin7.Text = "Win7";
            this.cbWin7.UseVisualStyleBackColor = true;
            this.cbWin7.CheckStateChanged += new System.EventHandler(this.cbWin7_CheckStateChanged);
            // 
            // cbWinVista
            // 
            this.cbWinVista.AutoSize = true;
            this.cbWinVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWinVista.Location = new System.Drawing.Point(95, 101);
            this.cbWinVista.Name = "cbWinVista";
            this.cbWinVista.Size = new System.Drawing.Size(147, 34);
            this.cbWinVista.TabIndex = 18;
            this.cbWinVista.Text = "WinVista";
            this.cbWinVista.UseVisualStyleBackColor = true;
            this.cbWinVista.Visible = false;
            this.cbWinVista.CheckStateChanged += new System.EventHandler(this.cbWin7_CheckStateChanged);
            // 
            // cbWinXP
            // 
            this.cbWinXP.AutoSize = true;
            this.cbWinXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWinXP.Location = new System.Drawing.Point(16, 101);
            this.cbWinXP.Name = "cbWinXP";
            this.cbWinXP.Size = new System.Drawing.Size(124, 34);
            this.cbWinXP.TabIndex = 17;
            this.cbWinXP.Text = "WinXP";
            this.cbWinXP.UseVisualStyleBackColor = true;
            this.cbWinXP.Visible = false;
            this.cbWinXP.CheckStateChanged += new System.EventHandler(this.cbWin7_CheckStateChanged);
            // 
            // btnThink
            // 
            this.btnThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThink.ForeColor = System.Drawing.Color.Black;
            this.btnThink.Location = new System.Drawing.Point(257, 17);
            this.btnThink.Name = "btnThink";
            this.btnThink.Size = new System.Drawing.Size(74, 58);
            this.btnThink.TabIndex = 16;
            this.btnThink.Text = "Scan Catalogs";
            this.btnThink.UseVisualStyleBackColor = true;
            this.btnThink.Click += new System.EventHandler(this.btnThink_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(376, 55);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(273, 34);
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.Text = "Search by HTTPS://";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(617, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 79);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Session Files";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage1);
            this.TabControl2.Controls.Add(this.TabPage2);
            this.TabControl2.Controls.Add(this.TabPage3);
            this.TabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl2.ItemSize = new System.Drawing.Size(400, 24);
            this.TabControl2.Location = new System.Drawing.Point(19, 16);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(565, 126);
            this.TabControl2.TabIndex = 15;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.linkDocks);
            this.TabPage1.Controls.Add(this._rbWin10);
            this.TabPage1.Controls.Add(this._rbWin81);
            this.TabPage1.Controls.Add(this._rbWin7);
            this.TabPage1.Controls.Add(this.CheckBox1);
            this.TabPage1.Controls.Add(this.linkTaxonomy);
            this.TabPage1.Controls.Add(this.btnSearchCatalog);
            this.TabPage1.Controls.Add(this.TextBox1);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new System.Drawing.Point(8, 32);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(549, 86);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "   Catalog Search   ";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // linkDocks
            // 
            this.linkDocks.AutoSize = true;
            this.linkDocks.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkDocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDocks.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(141)))), ((int)(((byte)(221)))));
            this.linkDocks.Location = new System.Drawing.Point(402, 18);
            this.linkDocks.Name = "linkDocks";
            this.linkDocks.Size = new System.Drawing.Size(132, 30);
            this.linkDocks.TabIndex = 25;
            this.linkDocks.TabStop = true;
            this.linkDocks.Text = "Docks List";
            this.linkDocks.VisitedLinkColor = System.Drawing.Color.Gold;
            this.linkDocks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDocks_LinkClicked);
            // 
            // _rbWin10
            // 
            this._rbWin10.AutoSize = true;
            this._rbWin10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rbWin10.Location = new System.Drawing.Point(220, 54);
            this._rbWin10.Name = "_rbWin10";
            this._rbWin10.Size = new System.Drawing.Size(72, 34);
            this._rbWin10.TabIndex = 24;
            this._rbWin10.TabStop = true;
            this._rbWin10.Tag = "Win10";
            this._rbWin10.Text = "10";
            this._rbWin10.UseVisualStyleBackColor = true;
            // 
            // _rbWin81
            // 
            this._rbWin81.AutoSize = true;
            this._rbWin81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rbWin81.Location = new System.Drawing.Point(173, 54);
            this._rbWin81.Name = "_rbWin81";
            this._rbWin81.Size = new System.Drawing.Size(79, 34);
            this._rbWin81.TabIndex = 23;
            this._rbWin81.TabStop = true;
            this._rbWin81.Tag = "Win8";
            this._rbWin81.Text = "8.1";
            this._rbWin81.UseVisualStyleBackColor = true;
            // 
            // _rbWin7
            // 
            this._rbWin7.AutoSize = true;
            this._rbWin7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rbWin7.Location = new System.Drawing.Point(133, 54);
            this._rbWin7.Name = "_rbWin7";
            this._rbWin7.Size = new System.Drawing.Size(58, 34);
            this._rbWin7.TabIndex = 22;
            this._rbWin7.TabStop = true;
            this._rbWin7.Tag = "Win7";
            this._rbWin7.Text = "7";
            this._rbWin7.UseVisualStyleBackColor = true;
            this._rbWin7.CheckedChanged += new System.EventHandler(this._rbWin7_CheckedChanged);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Button2);
            this.TabPage2.Controls.Add(this.TextBox2);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Location = new System.Drawing.Point(8, 32);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(549, 86);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "   Package Search   ";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.cbWin10);
            this.TabPage3.Controls.Add(this.cbWinXP);
            this.TabPage3.Controls.Add(this.cbWin8);
            this.TabPage3.Controls.Add(this.btnThink);
            this.TabPage3.Controls.Add(this.cbWinVista);
            this.TabPage3.Controls.Add(this.cbWin7);
            this.TabPage3.Location = new System.Drawing.Point(8, 32);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(549, 86);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "   Full Scan Catalogs   ";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(752, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(460, 66);
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::XML2Scanner.My.Resources.Resources.bg_gradient_blackblue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1228, 666);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TabControl2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.btnClear);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "XML2 Catalog Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tp_status.ResumeLayout(false);
            this.tp_packages.ResumeLayout(false);
            this.gbColumns.ResumeLayout(false);
            this.gbColumns.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal ComboBox ComboBox1;
        internal Button btnSearchCatalog;
        internal DataGridView DataGridView1;
        internal ListBox ListBox1;
        internal Button Button2;
        internal TabControl TabControl1;
        internal TabPage tp_packages;
        internal TabPage tp_status;
        internal Button Button3;
        internal Button btnClear;
        internal Button btnThink;
        internal CheckBox CheckBox1;
        internal CheckBox cbWinVista;
        internal CheckBox cbWinXP;
        internal CheckBox cbWin7;
        internal LinkLabel linkTaxonomy;
        internal CheckBox cbWin8;
        internal Button btnCheckCRC;
        internal CheckBox cbWin10;
        internal TabControl TabControl2;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal PictureBox PictureBox1;
        internal RadioButton _rbWin10;
        internal RadioButton _rbWin81;
        internal RadioButton _rbWin7;
        internal CheckBox cbPackageID;
        internal CheckBox cbReleased;
        internal CheckBox cbCategory;
        internal CheckBox cbSetup;
        internal CheckBox cbLanguage;
        internal CheckBox cbValid;
        internal CheckBox cbXML2Path;
        internal CheckBox cbCRC_Catalog;
        internal CheckBox cbCRC_Actual;
        internal CheckBox cbPackageName;
        internal CheckBox cbTitle;
        internal CheckBox cbComment;
        internal GroupBox gbColumns;
        internal Button btnColumns;
        internal DataGridViewTextBoxColumn PkgID;
        internal DataGridViewTextBoxColumn PackageName;
        internal DataGridViewTextBoxColumn Title;
        internal DataGridViewTextBoxColumn Version;
        internal DataGridViewTextBoxColumn Released;
        internal DataGridViewTextBoxColumn PackageType;
        internal DataGridViewTextBoxColumn category;
        internal DataGridViewTextBoxColumn RebootType;
        internal DataGridViewTextBoxColumn Severity;
        internal DataGridViewTextBoxColumn Brand;
        internal DataGridViewTextBoxColumn Setup;
        internal DataGridViewTextBoxColumn language;
        internal DataGridViewTextBoxColumn Valid;
        internal DataGridViewTextBoxColumn xml2_path;
        internal DataGridViewTextBoxColumn CRC;
        internal DataGridViewTextBoxColumn crcactual;
        internal DataGridViewTextBoxColumn Comment;
        internal CheckBox cbSeverity;
        internal CheckBox cbReboot;
        internal CheckBox cbPackageType;
        internal CheckBox cbVersion;
        internal CheckBox cbBrand;
        internal LinkLabel linkDocks;
    }
}