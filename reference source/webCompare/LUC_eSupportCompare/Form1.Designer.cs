namespace LUC_eSupportCompare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_family = new System.Windows.Forms.ComboBox();
            this.cb_os = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lucXML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excelWorker = new System.ComponentModel.BackgroundWorker();
            this.eSupportWorker = new System.ComponentModel.BackgroundWorker();
            this.suWorker = new System.ComponentModel.BackgroundWorker();
            this.issues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSupportVersion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.eSupportDSLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSupportExeLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSupportCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSupportRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suVersion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.suCatalogLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suExeLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucVersion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.eSupportHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suGivenEXEHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suComputedEXEHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suGivenXMLHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suComputedXMLHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(75, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 695);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(289, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-search Options";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(159, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 8;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(5, 82);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(148, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Hide issues with numbers:";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(123, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 6;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(5, 59);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(112, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Exclude columns: ";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(5, 105);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(179, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Only show packages with issues";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(184, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(5, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(176, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Exclude packages starting with:";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(164, 14);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 17);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "EXE CRC Checking";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 14);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "XML CRC Checking";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_family);
            this.groupBox3.Controls.Add(this.cb_os);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_model);
            this.groupBox3.Controls.Add(this.button_submit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(316, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 139);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Options";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Operating System:";
            // 
            // cb_family
            // 
            this.cb_family.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_family.FormattingEnabled = true;
            this.cb_family.Location = new System.Drawing.Point(112, 18);
            this.cb_family.Margin = new System.Windows.Forms.Padding(2);
            this.cb_family.Name = "cb_family";
            this.cb_family.Size = new System.Drawing.Size(174, 21);
            this.cb_family.TabIndex = 7;
            this.cb_family.SelectedIndexChanged += new System.EventHandler(this.cb_family_SelectedIndexChanged);
            // 
            // cb_os
            // 
            this.cb_os.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_os.FormattingEnabled = true;
            this.cb_os.Location = new System.Drawing.Point(112, 57);
            this.cb_os.Margin = new System.Windows.Forms.Padding(2);
            this.cb_os.Name = "cb_os";
            this.cb_os.Size = new System.Drawing.Size(174, 21);
            this.cb_os.TabIndex = 8;
            this.cb_os.SelectedIndexChanged += new System.EventHandler(this.cb_os_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model Name:";
            // 
            // cb_model
            // 
            this.cb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(112, 93);
            this.cb_model.Margin = new System.Windows.Forms.Padding(2);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(174, 21);
            this.cb_model.TabIndex = 9;
            this.cb_model.SelectedIndexChanged += new System.EventHandler(this.cb_model_SelectedIndexChanged);
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(295, 18);
            this.button_submit.Margin = new System.Windows.Forms.Padding(2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(117, 115);
            this.button_submit.TabIndex = 10;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Family:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(758, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 139);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post-search Options";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(176, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Show All";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Show Non-Matching";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "Show Matching";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "package",
            "name"});
            this.comboBox1.Location = new System.Drawing.Point(207, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search for: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(152, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 73);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Toggle Hash Columns";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export to Excel\\CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Load Configuration";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issues,
            this.name,
            this.package,
            this.eSupportVersion,
            this.eSupportDSLink,
            this.eSupportExeLink,
            this.eSupportCategory,
            this.eSupportRelease,
            this.suVersion,
            this.suCatalogLink,
            this.suExeLink,
            this.suCategory,
            this.suReleaseDate,
            this.lucVersion,
            this.eSupportHash,
            this.suGivenEXEHash,
            this.suComputedEXEHash,
            this.suGivenXMLHash,
            this.suComputedXMLHash,
            this.lucXML});
            this.dataGridView1.DataSource = this.dGRowBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 515);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // lucXML
            // 
            this.lucXML.DataPropertyName = "lucXML";
            this.lucXML.HeaderText = "lucXML";
            this.lucXML.Name = "lucXML";
            this.lucXML.ReadOnly = true;
            this.lucXML.Visible = false;
            // 
            // excelWorker
            // 
            this.excelWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.excelWorker_DoWork);
            this.excelWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.excelWorker_RunWorkerCompleted);
            // 
            // eSupportWorker
            // 
            this.eSupportWorker.WorkerReportsProgress = true;
            this.eSupportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.eSupportWorker_DoWork);
            this.eSupportWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.eSupportWorker_ProgressChanged);
            this.eSupportWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.eSupportWorker_RunWorkerCompleted);
            // 
            // suWorker
            // 
            this.suWorker.WorkerReportsProgress = true;
            this.suWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.suWorker_DoWork);
            this.suWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.suWorker_ProgressChanged);
            this.suWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.suWorker_RunWorkerCompleted);
            // 
            // issues
            // 
            this.issues.DataPropertyName = "Issues";
            this.issues.HeaderText = "Issues";
            this.issues.Name = "issues";
            this.issues.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // package
            // 
            this.package.DataPropertyName = "package";
            this.package.HeaderText = "package";
            this.package.Name = "package";
            this.package.ReadOnly = true;
            // 
            // eSupportVersion
            // 
            this.eSupportVersion.DataPropertyName = "eSupportVersion";
            this.eSupportVersion.HeaderText = "eSupportVersion";
            this.eSupportVersion.Name = "eSupportVersion";
            this.eSupportVersion.ReadOnly = true;
            this.eSupportVersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eSupportVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eSupportDSLink
            // 
            this.eSupportDSLink.DataPropertyName = "eSupportDSLink";
            this.eSupportDSLink.HeaderText = "eSupportDSLink";
            this.eSupportDSLink.Name = "eSupportDSLink";
            this.eSupportDSLink.ReadOnly = true;
            this.eSupportDSLink.Visible = false;
            // 
            // eSupportExeLink
            // 
            this.eSupportExeLink.DataPropertyName = "eSupportExeLink";
            this.eSupportExeLink.HeaderText = "eSupportExeLink";
            this.eSupportExeLink.Name = "eSupportExeLink";
            this.eSupportExeLink.ReadOnly = true;
            this.eSupportExeLink.Visible = false;
            // 
            // eSupportCategory
            // 
            this.eSupportCategory.DataPropertyName = "eSupportCategory";
            this.eSupportCategory.HeaderText = "eSupportCategory";
            this.eSupportCategory.Name = "eSupportCategory";
            this.eSupportCategory.ReadOnly = true;
            // 
            // eSupportRelease
            // 
            this.eSupportRelease.DataPropertyName = "eSupportReleaseDate";
            this.eSupportRelease.HeaderText = "eSupportReleaseDate";
            this.eSupportRelease.Name = "eSupportRelease";
            this.eSupportRelease.ReadOnly = true;
            // 
            // suVersion
            // 
            this.suVersion.DataPropertyName = "suVersion";
            this.suVersion.HeaderText = "suVersion";
            this.suVersion.Name = "suVersion";
            this.suVersion.ReadOnly = true;
            this.suVersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.suVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // suCatalogLink
            // 
            this.suCatalogLink.DataPropertyName = "suCatalogLink";
            this.suCatalogLink.HeaderText = "suCatalogLink";
            this.suCatalogLink.Name = "suCatalogLink";
            this.suCatalogLink.ReadOnly = true;
            this.suCatalogLink.Visible = false;
            // 
            // suExeLink
            // 
            this.suExeLink.DataPropertyName = "suExeLink";
            this.suExeLink.HeaderText = "suExeLink";
            this.suExeLink.Name = "suExeLink";
            this.suExeLink.ReadOnly = true;
            this.suExeLink.Visible = false;
            // 
            // suCategory
            // 
            this.suCategory.DataPropertyName = "suCategory";
            this.suCategory.HeaderText = "suCategory";
            this.suCategory.Name = "suCategory";
            this.suCategory.ReadOnly = true;
            // 
            // suReleaseDate
            // 
            this.suReleaseDate.DataPropertyName = "suReleaseDate";
            this.suReleaseDate.HeaderText = "suReleaseDate";
            this.suReleaseDate.Name = "suReleaseDate";
            this.suReleaseDate.ReadOnly = true;
            // 
            // lucVersion
            // 
            this.lucVersion.DataPropertyName = "lucVersion";
            this.lucVersion.HeaderText = "lucVersion";
            this.lucVersion.Name = "lucVersion";
            this.lucVersion.ReadOnly = true;
            this.lucVersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lucVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eSupportHash
            // 
            this.eSupportHash.DataPropertyName = "eSupportHash";
            this.eSupportHash.HeaderText = "eSupportHash";
            this.eSupportHash.Name = "eSupportHash";
            this.eSupportHash.ReadOnly = true;
            this.eSupportHash.Visible = false;
            // 
            // suGivenEXEHash
            // 
            this.suGivenEXEHash.DataPropertyName = "suGivenEXEHash";
            this.suGivenEXEHash.HeaderText = "suGivenEXEHash";
            this.suGivenEXEHash.Name = "suGivenEXEHash";
            this.suGivenEXEHash.ReadOnly = true;
            this.suGivenEXEHash.Visible = false;
            // 
            // suComputedEXEHash
            // 
            this.suComputedEXEHash.DataPropertyName = "suComputedEXEHash";
            this.suComputedEXEHash.HeaderText = "suComputedEXEHash";
            this.suComputedEXEHash.Name = "suComputedEXEHash";
            this.suComputedEXEHash.ReadOnly = true;
            this.suComputedEXEHash.Visible = false;
            // 
            // suGivenXMLHash
            // 
            this.suGivenXMLHash.DataPropertyName = "suGivenXMLHash";
            this.suGivenXMLHash.HeaderText = "suGivenXMLHash";
            this.suGivenXMLHash.Name = "suGivenXMLHash";
            this.suGivenXMLHash.ReadOnly = true;
            this.suGivenXMLHash.Visible = false;
            // 
            // suComputedXMLHash
            // 
            this.suComputedXMLHash.DataPropertyName = "suComputedXMLHash";
            this.suComputedXMLHash.HeaderText = "suComputedXMLHash";
            this.suComputedXMLHash.Name = "suComputedXMLHash";
            this.suComputedXMLHash.ReadOnly = true;
            this.suComputedXMLHash.Visible = false;
            // 
            // dGRowBindingSource
            // 
            this.dGRowBindingSource.DataSource = typeof(LUC_eSupportCompare.DGRow);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "LUC eSupport Compare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dGRowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn issues;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn package;
        private System.Windows.Forms.DataGridViewLinkColumn eSupportVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSupportDSLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSupportExeLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSupportCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSupportRelease;
        private System.Windows.Forms.DataGridViewLinkColumn suVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn suCatalogLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn suExeLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn suCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn suReleaseDate;
        private System.Windows.Forms.DataGridViewLinkColumn lucVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSupportHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn suGivenEXEHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn suComputedEXEHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn suGivenXMLHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn suComputedXMLHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucXML;
        private System.ComponentModel.BackgroundWorker excelWorker;
        private System.ComponentModel.BackgroundWorker eSupportWorker;
        private System.ComponentModel.BackgroundWorker suWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_family;
        private System.Windows.Forms.ComboBox cb_os;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
    }
}

