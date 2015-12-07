namespace ScrapyForm
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tblinfo = new System.Windows.Forms.TabControl();
            this.tblcofnig = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblhidconfigid = new System.Windows.Forms.Label();
            this.cbxspider = new System.Windows.Forms.ComboBox();
            this.lblspidername = new System.Windows.Forms.Label();
            this.btnselectpath = new System.Windows.Forms.Button();
            this.btnaddspdier = new System.Windows.Forms.Button();
            this.btnspiderinit = new System.Windows.Forms.Button();
            this.stpstatus = new System.Windows.Forms.StatusStrip();
            this.stglblprocess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stglblinfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnstartspider = new System.Windows.Forms.Button();
            this.grpspiders = new System.Windows.Forms.GroupBox();
            this.dgvconfigspider = new System.Windows.Forms.DataGridView();
            this.Sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderConfigID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.spiderconfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spidercenterDataSet = new ScrapyForm.spidercenterDataSet();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonsave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpconfig = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnconfigedit = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnconfigdelete = new System.Windows.Forms.Button();
            this.btnaddconfig = new System.Windows.Forms.Button();
            this.txtoutputname = new System.Windows.Forms.TextBox();
            this.txtlogname = new System.Windows.Forms.TextBox();
            this.cbxoutput = new System.Windows.Forms.ComboBox();
            this.cbxlog = new System.Windows.Forms.ComboBox();
            this.lblspiderpath = new System.Windows.Forms.Label();
            this.txtconfigname = new System.Windows.Forms.TextBox();
            this.txtautoparms = new System.Windows.Forms.TextBox();
            this.lblisfileoutput = new System.Windows.Forms.Label();
            this.lblisoutput = new System.Windows.Forms.Label();
            this.lblislogoutput = new System.Windows.Forms.Label();
            this.lblconfigname = new System.Windows.Forms.Label();
            this.lblautopamrs = new System.Windows.Forms.Label();
            this.txtselectpath = new System.Windows.Forms.TextBox();
            this.tblstate = new System.Windows.Forms.TabPage();
            this.dgvspider = new System.Windows.Forms.DataGridView();
            this.SpdierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpiderMod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbllog = new System.Windows.Forms.TabPage();
            this.fbdselectpath = new System.Windows.Forms.FolderBrowserDialog();
            this.spiderconfigTableAdapter = new ScrapyForm.spidercenterDataSetTableAdapters.spiderconfigTableAdapter();
            this.tblinfo.SuspendLayout();
            this.tblcofnig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stpstatus.SuspendLayout();
            this.grpspiders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconfigspider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiderconfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spidercenterDataSet)).BeginInit();
            this.grpconfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblstate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvspider)).BeginInit();
            this.SuspendLayout();
            // 
            // tblinfo
            // 
            this.tblinfo.Controls.Add(this.tblcofnig);
            this.tblinfo.Controls.Add(this.tblstate);
            this.tblinfo.Controls.Add(this.tbllog);
            this.tblinfo.Location = new System.Drawing.Point(12, 13);
            this.tblinfo.Name = "tblinfo";
            this.tblinfo.SelectedIndex = 0;
            this.tblinfo.Size = new System.Drawing.Size(895, 609);
            this.tblinfo.TabIndex = 0;
            // 
            // tblcofnig
            // 
            this.tblcofnig.Controls.Add(this.groupBox2);
            this.tblcofnig.Controls.Add(this.stpstatus);
            this.tblcofnig.Controls.Add(this.btnstartspider);
            this.tblcofnig.Controls.Add(this.grpspiders);
            this.tblcofnig.Controls.Add(this.grpconfig);
            this.tblcofnig.Location = new System.Drawing.Point(4, 22);
            this.tblcofnig.Name = "tblcofnig";
            this.tblcofnig.Padding = new System.Windows.Forms.Padding(3);
            this.tblcofnig.Size = new System.Drawing.Size(887, 583);
            this.tblcofnig.TabIndex = 0;
            this.tblcofnig.Text = "Config";
            this.tblcofnig.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblhidconfigid);
            this.groupBox2.Controls.Add(this.cbxspider);
            this.groupBox2.Controls.Add(this.lblspidername);
            this.groupBox2.Controls.Add(this.btnselectpath);
            this.groupBox2.Controls.Add(this.btnaddspdier);
            this.groupBox2.Controls.Add(this.btnspiderinit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "爬虫操作列表";
            // 
            // lblhidconfigid
            // 
            this.lblhidconfigid.AutoSize = true;
            this.lblhidconfigid.Location = new System.Drawing.Point(809, 20);
            this.lblhidconfigid.Name = "lblhidconfigid";
            this.lblhidconfigid.Size = new System.Drawing.Size(13, 13);
            this.lblhidconfigid.TabIndex = 5;
            this.lblhidconfigid.Text = "0";
            this.lblhidconfigid.Visible = false;
            // 
            // cbxspider
            // 
            this.cbxspider.FormattingEnabled = true;
            this.cbxspider.Location = new System.Drawing.Point(82, 20);
            this.cbxspider.Name = "cbxspider";
            this.cbxspider.Size = new System.Drawing.Size(201, 21);
            this.cbxspider.TabIndex = 2;
            // 
            // lblspidername
            // 
            this.lblspidername.AutoSize = true;
            this.lblspidername.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblspidername.Location = new System.Drawing.Point(8, 24);
            this.lblspidername.Name = "lblspidername";
            this.lblspidername.Size = new System.Drawing.Size(64, 12);
            this.lblspidername.TabIndex = 0;
            this.lblspidername.Text = "爬虫列表:";
            // 
            // btnselectpath
            // 
            this.btnselectpath.Location = new System.Drawing.Point(307, 18);
            this.btnselectpath.Name = "btnselectpath";
            this.btnselectpath.Size = new System.Drawing.Size(85, 25);
            this.btnselectpath.TabIndex = 3;
            this.btnselectpath.Text = "选择文件夹";
            this.btnselectpath.UseVisualStyleBackColor = true;
            this.btnselectpath.Click += new System.EventHandler(this.btnselectpath_Click);
            // 
            // btnaddspdier
            // 
            this.btnaddspdier.Location = new System.Drawing.Point(500, 17);
            this.btnaddspdier.Name = "btnaddspdier";
            this.btnaddspdier.Size = new System.Drawing.Size(83, 25);
            this.btnaddspdier.TabIndex = 4;
            this.btnaddspdier.Text = "添加当前";
            this.btnaddspdier.UseVisualStyleBackColor = true;
            this.btnaddspdier.Click += new System.EventHandler(this.btnaddspdier_Click);
            // 
            // btnspiderinit
            // 
            this.btnspiderinit.Location = new System.Drawing.Point(413, 18);
            this.btnspiderinit.Name = "btnspiderinit";
            this.btnspiderinit.Size = new System.Drawing.Size(81, 25);
            this.btnspiderinit.TabIndex = 4;
            this.btnspiderinit.Text = "初使化列表";
            this.btnspiderinit.UseVisualStyleBackColor = true;
            this.btnspiderinit.Click += new System.EventHandler(this.btnspiderinit_Click);
            // 
            // stpstatus
            // 
            this.stpstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stglblprocess,
            this.toolStripStatusLabel1,
            this.stglblinfo});
            this.stpstatus.Location = new System.Drawing.Point(3, 558);
            this.stpstatus.Name = "stpstatus";
            this.stpstatus.Size = new System.Drawing.Size(881, 22);
            this.stpstatus.TabIndex = 9;
            this.stpstatus.Text = "当前信息:";
            // 
            // stglblprocess
            // 
            this.stglblprocess.Image = global::ScrapyForm.Properties.Resources.Loading;
            this.stglblprocess.Name = "stglblprocess";
            this.stglblprocess.Size = new System.Drawing.Size(28, 17);
            this.stglblprocess.Text = " ";
            this.stglblprocess.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "当前状态:";
            // 
            // stglblinfo
            // 
            this.stglblinfo.Name = "stglblinfo";
            this.stglblinfo.Size = new System.Drawing.Size(56, 17);
            this.stglblinfo.Text = "操作信息";
            this.stglblinfo.Visible = false;
            // 
            // btnstartspider
            // 
            this.btnstartspider.Location = new System.Drawing.Point(6, 505);
            this.btnstartspider.Name = "btnstartspider";
            this.btnstartspider.Size = new System.Drawing.Size(124, 42);
            this.btnstartspider.TabIndex = 6;
            this.btnstartspider.Text = "启动";
            this.btnstartspider.UseVisualStyleBackColor = true;
            this.btnstartspider.Click += new System.EventHandler(this.btnstartspider_Click);
            // 
            // grpspiders
            // 
            this.grpspiders.Controls.Add(this.dgvconfigspider);
            this.grpspiders.Location = new System.Drawing.Point(6, 202);
            this.grpspiders.Name = "grpspiders";
            this.grpspiders.Size = new System.Drawing.Size(875, 300);
            this.grpspiders.TabIndex = 3;
            this.grpspiders.TabStop = false;
            this.grpspiders.Text = "爬虫列表";
            // 
            // dgvconfigspider
            // 
            this.dgvconfigspider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvconfigspider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconfigspider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sid,
            this.SpiderName,
            this.SpiderConfigID,
            this.CreateTime,
            this.IsDel,
            this.IsSelect,
            this.buttonsave});
            this.dgvconfigspider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvconfigspider.Location = new System.Drawing.Point(3, 16);
            this.dgvconfigspider.Name = "dgvconfigspider";
            this.dgvconfigspider.RowTemplate.Height = 23;
            this.dgvconfigspider.Size = new System.Drawing.Size(869, 281);
            this.dgvconfigspider.TabIndex = 0;
            this.dgvconfigspider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconfigspider_CellContentClick);
            this.dgvconfigspider.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconfigspider_ColumnHeaderMouseClick);
            this.dgvconfigspider.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconfigspider_ColumnHeaderMouseDoubleClick);
            this.dgvconfigspider.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvconfigspider_EditingControlShowing);
            this.dgvconfigspider.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconfigspider_RowHeaderMouseClick);
            // 
            // Sid
            // 
            this.Sid.DataPropertyName = "Sid";
            this.Sid.FillWeight = 50F;
            this.Sid.HeaderText = "爬虫ID";
            this.Sid.Name = "Sid";
            this.Sid.ReadOnly = true;
            // 
            // SpiderName
            // 
            this.SpiderName.DataPropertyName = "SpiderName";
            this.SpiderName.FillWeight = 100.6139F;
            this.SpiderName.HeaderText = "爬虫名字";
            this.SpiderName.Name = "SpiderName";
            // 
            // SpiderConfigID
            // 
            this.SpiderConfigID.DataPropertyName = "SpiderConfigID";
            this.SpiderConfigID.DataSource = this.spiderconfigBindingSource;
            this.SpiderConfigID.DisplayMember = "ConfigName";
            this.SpiderConfigID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SpiderConfigID.FillWeight = 76.61392F;
            this.SpiderConfigID.HeaderText = "配置方案";
            this.SpiderConfigID.Name = "SpiderConfigID";
            this.SpiderConfigID.ValueMember = "Cid";
            // 
            // spiderconfigBindingSource
            // 
            this.spiderconfigBindingSource.DataMember = "spiderconfig";
            this.spiderconfigBindingSource.DataSource = this.spidercenterDataSet;
            // 
            // spidercenterDataSet
            // 
            this.spidercenterDataSet.DataSetName = "spidercenterDataSet";
            this.spidercenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 76.61392F;
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.FalseValue = "0";
            this.IsDel.FillWeight = 76.61392F;
            this.IsDel.HeaderText = "是否启用";
            this.IsDel.Name = "IsDel";
            this.IsDel.TrueValue = "1";
            // 
            // IsSelect
            // 
            this.IsSelect.DataPropertyName = "IsSelect";
            this.IsSelect.FalseValue = "0";
            this.IsSelect.FillWeight = 76.61392F;
            this.IsSelect.HeaderText = "选择/全选";
            this.IsSelect.Name = "IsSelect";
            this.IsSelect.ToolTipText = "单击全选/双击清空";
            this.IsSelect.TrueValue = "1";
            // 
            // buttonsave
            // 
            this.buttonsave.FillWeight = 44.00275F;
            this.buttonsave.HeaderText = "保存";
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseColumnTextForButtonValue = true;
            // 
            // grpconfig
            // 
            this.grpconfig.Controls.Add(this.groupBox1);
            this.grpconfig.Controls.Add(this.txtoutputname);
            this.grpconfig.Controls.Add(this.txtlogname);
            this.grpconfig.Controls.Add(this.cbxoutput);
            this.grpconfig.Controls.Add(this.cbxlog);
            this.grpconfig.Controls.Add(this.lblspiderpath);
            this.grpconfig.Controls.Add(this.txtconfigname);
            this.grpconfig.Controls.Add(this.txtautoparms);
            this.grpconfig.Controls.Add(this.lblisfileoutput);
            this.grpconfig.Controls.Add(this.lblisoutput);
            this.grpconfig.Controls.Add(this.lblislogoutput);
            this.grpconfig.Controls.Add(this.lblconfigname);
            this.grpconfig.Controls.Add(this.lblautopamrs);
            this.grpconfig.Controls.Add(this.txtselectpath);
            this.grpconfig.Location = new System.Drawing.Point(9, 7);
            this.grpconfig.Name = "grpconfig";
            this.grpconfig.Size = new System.Drawing.Size(875, 134);
            this.grpconfig.TabIndex = 2;
            this.grpconfig.TabStop = false;
            this.grpconfig.Text = "配置列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnconfigedit);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnconfigdelete);
            this.groupBox1.Controls.Add(this.btnaddconfig);
            this.groupBox1.Location = new System.Drawing.Point(620, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // btnconfigedit
            // 
            this.btnconfigedit.Location = new System.Drawing.Point(15, 20);
            this.btnconfigedit.Name = "btnconfigedit";
            this.btnconfigedit.Size = new System.Drawing.Size(90, 35);
            this.btnconfigedit.TabIndex = 6;
            this.btnconfigedit.Text = "更新方案";
            this.btnconfigedit.UseVisualStyleBackColor = true;
            this.btnconfigedit.Click += new System.EventHandler(this.btnconfigedit_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(121, 73);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(101, 35);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "刷新列表";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnconfigdelete
            // 
            this.btnconfigdelete.Location = new System.Drawing.Point(121, 20);
            this.btnconfigdelete.Name = "btnconfigdelete";
            this.btnconfigdelete.Size = new System.Drawing.Size(101, 35);
            this.btnconfigdelete.TabIndex = 6;
            this.btnconfigdelete.Text = "删除方案";
            this.btnconfigdelete.UseVisualStyleBackColor = true;
            // 
            // btnaddconfig
            // 
            this.btnaddconfig.Location = new System.Drawing.Point(15, 73);
            this.btnaddconfig.Name = "btnaddconfig";
            this.btnaddconfig.Size = new System.Drawing.Size(90, 35);
            this.btnaddconfig.TabIndex = 6;
            this.btnaddconfig.Text = "添加方案";
            this.btnaddconfig.UseVisualStyleBackColor = true;
            this.btnaddconfig.Click += new System.EventHandler(this.btnaddconfig_Click);
            // 
            // txtoutputname
            // 
            this.txtoutputname.Location = new System.Drawing.Point(80, 103);
            this.txtoutputname.Name = "txtoutputname";
            this.txtoutputname.Size = new System.Drawing.Size(101, 20);
            this.txtoutputname.TabIndex = 5;
            this.txtoutputname.Visible = false;
            // 
            // txtlogname
            // 
            this.txtlogname.Location = new System.Drawing.Point(80, 65);
            this.txtlogname.Name = "txtlogname";
            this.txtlogname.Size = new System.Drawing.Size(101, 20);
            this.txtlogname.TabIndex = 5;
            this.txtlogname.Visible = false;
            // 
            // cbxoutput
            // 
            this.cbxoutput.FormattingEnabled = true;
            this.cbxoutput.Items.AddRange(new object[] {
            "无",
            ".xml",
            ".csv",
            ".json",
            ".jsonlines"});
            this.cbxoutput.Location = new System.Drawing.Point(190, 103);
            this.cbxoutput.Name = "cbxoutput";
            this.cbxoutput.Size = new System.Drawing.Size(87, 21);
            this.cbxoutput.TabIndex = 2;
            this.cbxoutput.SelectedIndexChanged += new System.EventHandler(this.cbxoutput_SelectedIndexChanged);
            // 
            // cbxlog
            // 
            this.cbxlog.FormattingEnabled = true;
            this.cbxlog.Items.AddRange(new object[] {
            "无",
            "--nolog",
            ".log",
            ".bat"});
            this.cbxlog.Location = new System.Drawing.Point(190, 65);
            this.cbxlog.Name = "cbxlog";
            this.cbxlog.Size = new System.Drawing.Size(87, 21);
            this.cbxlog.TabIndex = 2;
            this.cbxlog.SelectedIndexChanged += new System.EventHandler(this.cbxlog_SelectedIndexChanged);
            // 
            // lblspiderpath
            // 
            this.lblspiderpath.AutoSize = true;
            this.lblspiderpath.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblspiderpath.Location = new System.Drawing.Point(26, 27);
            this.lblspiderpath.Name = "lblspiderpath";
            this.lblspiderpath.Size = new System.Drawing.Size(38, 12);
            this.lblspiderpath.TabIndex = 0;
            this.lblspiderpath.Text = "路径:";
            // 
            // txtconfigname
            // 
            this.txtconfigname.Location = new System.Drawing.Point(391, 104);
            this.txtconfigname.Name = "txtconfigname";
            this.txtconfigname.Size = new System.Drawing.Size(190, 20);
            this.txtconfigname.TabIndex = 1;
            // 
            // txtautoparms
            // 
            this.txtautoparms.Location = new System.Drawing.Point(393, 65);
            this.txtautoparms.Name = "txtautoparms";
            this.txtautoparms.Size = new System.Drawing.Size(190, 20);
            this.txtautoparms.TabIndex = 1;
            // 
            // lblisfileoutput
            // 
            this.lblisfileoutput.AutoSize = true;
            this.lblisfileoutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblisfileoutput.Location = new System.Drawing.Point(6, 108);
            this.lblisfileoutput.Name = "lblisfileoutput";
            this.lblisfileoutput.Size = new System.Drawing.Size(64, 12);
            this.lblisfileoutput.TabIndex = 0;
            this.lblisfileoutput.Text = "是否输出:";
            // 
            // lblisoutput
            // 
            this.lblisoutput.AutoSize = true;
            this.lblisoutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblisoutput.Location = new System.Drawing.Point(6, 108);
            this.lblisoutput.Name = "lblisoutput";
            this.lblisoutput.Size = new System.Drawing.Size(64, 12);
            this.lblisoutput.TabIndex = 0;
            this.lblisoutput.Text = "是否日志:";
            // 
            // lblislogoutput
            // 
            this.lblislogoutput.AutoSize = true;
            this.lblislogoutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblislogoutput.Location = new System.Drawing.Point(6, 68);
            this.lblislogoutput.Name = "lblislogoutput";
            this.lblislogoutput.Size = new System.Drawing.Size(64, 12);
            this.lblislogoutput.TabIndex = 0;
            this.lblislogoutput.Text = "是否日志:";
            // 
            // lblconfigname
            // 
            this.lblconfigname.AutoSize = true;
            this.lblconfigname.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblconfigname.Location = new System.Drawing.Point(327, 108);
            this.lblconfigname.Name = "lblconfigname";
            this.lblconfigname.Size = new System.Drawing.Size(51, 12);
            this.lblconfigname.TabIndex = 0;
            this.lblconfigname.Text = "方案名:";
            // 
            // lblautopamrs
            // 
            this.lblautopamrs.AutoSize = true;
            this.lblautopamrs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblautopamrs.Location = new System.Drawing.Point(303, 68);
            this.lblautopamrs.Name = "lblautopamrs";
            this.lblautopamrs.Size = new System.Drawing.Size(77, 12);
            this.lblautopamrs.TabIndex = 0;
            this.lblautopamrs.Text = "自定义参数:";
            // 
            // txtselectpath
            // 
            this.txtselectpath.Location = new System.Drawing.Point(80, 23);
            this.txtselectpath.Name = "txtselectpath";
            this.txtselectpath.Size = new System.Drawing.Size(503, 20);
            this.txtselectpath.TabIndex = 1;
            // 
            // tblstate
            // 
            this.tblstate.Controls.Add(this.dgvspider);
            this.tblstate.Location = new System.Drawing.Point(4, 22);
            this.tblstate.Name = "tblstate";
            this.tblstate.Padding = new System.Windows.Forms.Padding(3);
            this.tblstate.Size = new System.Drawing.Size(887, 583);
            this.tblstate.TabIndex = 1;
            this.tblstate.Text = "State";
            this.tblstate.UseVisualStyleBackColor = true;
            // 
            // dgvspider
            // 
            this.dgvspider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvspider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpdierID,
            this.DgvName,
            this.SpiderState,
            this.SpiderMod});
            this.dgvspider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvspider.Location = new System.Drawing.Point(3, 3);
            this.dgvspider.Name = "dgvspider";
            this.dgvspider.RowTemplate.Height = 23;
            this.dgvspider.Size = new System.Drawing.Size(881, 577);
            this.dgvspider.TabIndex = 0;
            // 
            // SpdierID
            // 
            this.SpdierID.HeaderText = "SpdierID";
            this.SpdierID.Name = "SpdierID";
            // 
            // DgvName
            // 
            this.DgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvName.HeaderText = "SpiderName";
            this.DgvName.Name = "DgvName";
            this.DgvName.Width = 300;
            // 
            // SpiderState
            // 
            this.SpiderState.HeaderText = "SpiderState";
            this.SpiderState.Name = "SpiderState";
            // 
            // SpiderMod
            // 
            this.SpiderMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpiderMod.HeaderText = "Action";
            this.SpiderMod.Name = "SpiderMod";
            this.SpiderMod.Text = "Start";
            this.SpiderMod.ToolTipText = "Start";
            // 
            // tbllog
            // 
            this.tbllog.Location = new System.Drawing.Point(4, 22);
            this.tbllog.Name = "tbllog";
            this.tbllog.Padding = new System.Windows.Forms.Padding(3);
            this.tbllog.Size = new System.Drawing.Size(887, 583);
            this.tbllog.TabIndex = 2;
            this.tbllog.Text = "Log";
            this.tbllog.UseVisualStyleBackColor = true;
            // 
            // spiderconfigTableAdapter
            // 
            this.spiderconfigTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 625);
            this.Controls.Add(this.tblinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrapyForm";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tblinfo.ResumeLayout(false);
            this.tblcofnig.ResumeLayout(false);
            this.tblcofnig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stpstatus.ResumeLayout(false);
            this.stpstatus.PerformLayout();
            this.grpspiders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconfigspider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiderconfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spidercenterDataSet)).EndInit();
            this.grpconfig.ResumeLayout(false);
            this.grpconfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tblstate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvspider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblinfo;
        private System.Windows.Forms.TabPage tblcofnig;
        private System.Windows.Forms.TabPage tblstate;
        private System.Windows.Forms.TabPage tbllog;
        private System.Windows.Forms.DataGridView dgvspider;
        private System.Windows.Forms.TextBox txtautoparms;
        private System.Windows.Forms.TextBox txtselectpath;
        private System.Windows.Forms.Label lblautopamrs;
        private System.Windows.Forms.Label lblislogoutput;
        private System.Windows.Forms.Label lblspidername;
        private System.Windows.Forms.Label lblspiderpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpdierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpiderState;
        private System.Windows.Forms.DataGridViewButtonColumn SpiderMod;
        private System.Windows.Forms.GroupBox grpconfig;
        private System.Windows.Forms.ComboBox cbxlog;
        private System.Windows.Forms.Button btnselectpath;
        private System.Windows.Forms.FolderBrowserDialog fbdselectpath;
        private System.Windows.Forms.Button btnspiderinit;
        private System.Windows.Forms.ComboBox cbxspider;
        private System.Windows.Forms.TextBox txtlogname;
        private System.Windows.Forms.GroupBox grpspiders;
        private System.Windows.Forms.DataGridView dgvconfigspider;
        private System.Windows.Forms.TextBox txtoutputname;
        private System.Windows.Forms.ComboBox cbxoutput;
        private System.Windows.Forms.Label lblisfileoutput;
        private System.Windows.Forms.Label lblisoutput;
        private System.Windows.Forms.Button btnstartspider;
        private System.Windows.Forms.Button btnconfigedit;
        private System.Windows.Forms.Button btnaddconfig;
        private spidercenterDataSet spidercenterDataSet;
        private System.Windows.Forms.BindingSource spiderconfigBindingSource;
        private spidercenterDataSetTableAdapters.spiderconfigTableAdapter spiderconfigTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnconfigdelete;
        private System.Windows.Forms.TextBox txtconfigname;
        private System.Windows.Forms.Label lblconfigname;
        private System.Windows.Forms.StatusStrip stpstatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stglblprocess;
        private System.Windows.Forms.ToolStripStatusLabel stglblinfo;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblhidconfigid;
        private System.Windows.Forms.Button btnaddspdier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpiderName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SpiderConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelect;
        private System.Windows.Forms.DataGridViewButtonColumn buttonsave;
    }
}