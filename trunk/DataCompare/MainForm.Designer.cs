using System;
using System.ComponentModel;

namespace DataCompare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tctlCompare = new System.Windows.Forms.TabControl();
            this.tabpSource = new System.Windows.Forms.TabPage();
            this.lblSrcTableSelect = new System.Windows.Forms.Label();
            this.cboSrcTableSelect = new System.Windows.Forms.ComboBox();
            this.rbtnSrcNetezza = new System.Windows.Forms.RadioButton();
            this.btnSrcRfst = new System.Windows.Forms.Button();
            this.cboSrcTable = new System.Windows.Forms.ComboBox();
            this.btnSrcRfs = new System.Windows.Forms.Button();
            this.cboSrcDB = new System.Windows.Forms.ComboBox();
            this.txtSrcSID = new System.Windows.Forms.TextBox();
            this.txtSrcPwd = new System.Windows.Forms.TextBox();
            this.txtSrcUser = new System.Windows.Forms.TextBox();
            this.chkSrcWinAuth = new System.Windows.Forms.CheckBox();
            this.txtSrcServer = new System.Windows.Forms.TextBox();
            this.lblSrcTable = new System.Windows.Forms.Label();
            this.lblSrcDB = new System.Windows.Forms.Label();
            this.lblSrcPwd = new System.Windows.Forms.Label();
            this.lblSrcUser = new System.Windows.Forms.Label();
            this.lblSrcServer = new System.Windows.Forms.Label();
            this.rbtnSrcOracle = new System.Windows.Forms.RadioButton();
            this.rbtnSrcSql = new System.Windows.Forms.RadioButton();
            this.rbtnSrcGoogle = new System.Windows.Forms.RadioButton();
            this.tabpTarget = new System.Windows.Forms.TabPage();
            this.lblTrgTableSelect = new System.Windows.Forms.Label();
            this.cboTrgTableSelect = new System.Windows.Forms.ComboBox();
            this.rbtnTrgNetezza = new System.Windows.Forms.RadioButton();
            this.btnTrgRfst = new System.Windows.Forms.Button();
            this.cboTrgTable = new System.Windows.Forms.ComboBox();
            this.btnTrgRfs = new System.Windows.Forms.Button();
            this.cboTrgDB = new System.Windows.Forms.ComboBox();
            this.txtTrgSID = new System.Windows.Forms.TextBox();
            this.txtTrgPwd = new System.Windows.Forms.TextBox();
            this.txtTrgUser = new System.Windows.Forms.TextBox();
            this.chkTrgWinAuth = new System.Windows.Forms.CheckBox();
            this.txtTrgServer = new System.Windows.Forms.TextBox();
            this.lblTrgTable = new System.Windows.Forms.Label();
            this.lblTrgDB = new System.Windows.Forms.Label();
            this.lblTrgPwd = new System.Windows.Forms.Label();
            this.lblTrgUser = new System.Windows.Forms.Label();
            this.lblTrgServer = new System.Windows.Forms.Label();
            this.rbtnTrgOracle = new System.Windows.Forms.RadioButton();
            this.rbtnTrgSql = new System.Windows.Forms.RadioButton();
            this.rbtnTrgGoogle = new System.Windows.Forms.RadioButton();
            this.btnEditMapping = new System.Windows.Forms.Button();
            this.dgvMappings = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SelectedKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkShowDiff = new System.Windows.Forms.CheckBox();
            this.gbxCells = new System.Windows.Forms.GroupBox();
            this.lblRedDesc = new System.Windows.Forms.Label();
            this.lblRedColor = new System.Windows.Forms.Label();
            this.lblLightBlueDesc = new System.Windows.Forms.Label();
            this.lblLightBlueColor = new System.Windows.Forms.Label();
            this.lblWhiteDesc = new System.Windows.Forms.Label();
            this.lblWhiteColor = new System.Windows.Forms.Label();
            this.gbxRows = new System.Windows.Forms.GroupBox();
            this.lblLightGreenDesc = new System.Windows.Forms.Label();
            this.lblLightGreenColor = new System.Windows.Forms.Label();
            this.lblLightPinkDesc = new System.Windows.Forms.Label();
            this.lblLightPinkColor = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.bwDatabase = new System.ComponentModel.BackgroundWorker();
            this.bwTable = new System.ComponentModel.BackgroundWorker();
            this.bwTableSelect = new System.ComponentModel.BackgroundWorker();
            this.bwMapping = new System.ComponentModel.BackgroundWorker();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btnSrcUse = new System.Windows.Forms.Button();
            this.btnTrgUse = new System.Windows.Forms.Button();
            this.tctlCompare.SuspendLayout();
            this.tabpSource.SuspendLayout();
            this.tabpTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).BeginInit();
            this.gbxCells.SuspendLayout();
            this.gbxRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctlCompare
            // 
            this.tctlCompare.Controls.Add(this.tabpSource);
            this.tctlCompare.Controls.Add(this.tabpTarget);
            this.tctlCompare.ItemSize = new System.Drawing.Size(160, 18);
            this.tctlCompare.Location = new System.Drawing.Point(0, 0);
            this.tctlCompare.Name = "tctlCompare";
            this.tctlCompare.SelectedIndex = 0;
            this.tctlCompare.Size = new System.Drawing.Size(368, 243);
            this.tctlCompare.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctlCompare.TabIndex = 0;
            // 
            // tabpSource
            // 
            this.tabpSource.Controls.Add(this.btnSrcUse);
            this.tabpSource.Controls.Add(this.lblSrcTableSelect);
            this.tabpSource.Controls.Add(this.cboSrcTableSelect);
            this.tabpSource.Controls.Add(this.rbtnSrcNetezza);
            this.tabpSource.Controls.Add(this.btnSrcRfst);
            this.tabpSource.Controls.Add(this.cboSrcTable);
            this.tabpSource.Controls.Add(this.btnSrcRfs);
            this.tabpSource.Controls.Add(this.cboSrcDB);
            this.tabpSource.Controls.Add(this.txtSrcSID);
            this.tabpSource.Controls.Add(this.txtSrcPwd);
            this.tabpSource.Controls.Add(this.txtSrcUser);
            this.tabpSource.Controls.Add(this.chkSrcWinAuth);
            this.tabpSource.Controls.Add(this.txtSrcServer);
            this.tabpSource.Controls.Add(this.lblSrcTable);
            this.tabpSource.Controls.Add(this.lblSrcDB);
            this.tabpSource.Controls.Add(this.lblSrcPwd);
            this.tabpSource.Controls.Add(this.lblSrcUser);
            this.tabpSource.Controls.Add(this.lblSrcServer);
            this.tabpSource.Controls.Add(this.rbtnSrcOracle);
            this.tabpSource.Controls.Add(this.rbtnSrcSql);
            this.tabpSource.Controls.Add(this.rbtnSrcGoogle);
            this.tabpSource.Location = new System.Drawing.Point(4, 22);
            this.tabpSource.Name = "tabpSource";
            this.tabpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSource.Size = new System.Drawing.Size(360, 217);
            this.tabpSource.TabIndex = 0;
            this.tabpSource.Text = "Source";
            this.tabpSource.UseVisualStyleBackColor = true;
            // 
            // lblSrcTableSelect
            // 
            this.lblSrcTableSelect.AutoSize = true;
            this.lblSrcTableSelect.Location = new System.Drawing.Point(16, 183);
            this.lblSrcTableSelect.Name = "lblSrcTableSelect";
            this.lblSrcTableSelect.Size = new System.Drawing.Size(39, 13);
            this.lblSrcTableSelect.TabIndex = 21;
            this.lblSrcTableSelect.Text = "Tables";
            // 
            // cboSrcTableSelect
            // 
            this.cboSrcTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSrcTableSelect.FormattingEnabled = true;
            this.cboSrcTableSelect.Location = new System.Drawing.Point(85, 183);
            this.cboSrcTableSelect.Name = "cboSrcTableSelect";
            this.cboSrcTableSelect.Size = new System.Drawing.Size(196, 21);
            this.cboSrcTableSelect.TabIndex = 19;
            // 
            // rbtnSrcNetezza
            // 
            this.rbtnSrcNetezza.AutoSize = true;
            this.rbtnSrcNetezza.Location = new System.Drawing.Point(229, 6);
            this.rbtnSrcNetezza.Name = "rbtnSrcNetezza";
            this.rbtnSrcNetezza.Size = new System.Drawing.Size(64, 17);
            this.rbtnSrcNetezza.TabIndex = 18;
            this.rbtnSrcNetezza.Text = "Netezza";
            this.rbtnSrcNetezza.UseVisualStyleBackColor = true;
            this.rbtnSrcNetezza.CheckedChanged += new System.EventHandler(this.rbtnSrcDatabase_CheckedChanged);
            // 
            // btnSrcRfst
            // 
            this.btnSrcRfst.Location = new System.Drawing.Point(287, 156);
            this.btnSrcRfst.Name = "btnSrcRfst";
            this.btnSrcRfst.Size = new System.Drawing.Size(67, 23);
            this.btnSrcRfst.TabIndex = 16;
            this.btnSrcRfst.Text = "Select";
            this.btnSrcRfst.UseVisualStyleBackColor = true;
            this.btnSrcRfst.Click += new System.EventHandler(this.btnSrcRfst_Click);
            // 
            // cboSrcTable
            // 
            this.cboSrcTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSrcTable.FormattingEnabled = true;
            this.cboSrcTable.Location = new System.Drawing.Point(85, 156);
            this.cboSrcTable.Name = "cboSrcTable";
            this.cboSrcTable.Size = new System.Drawing.Size(196, 21);
            this.cboSrcTable.TabIndex = 15;
            // 
            // btnSrcRfs
            // 
            this.btnSrcRfs.Location = new System.Drawing.Point(287, 128);
            this.btnSrcRfs.Name = "btnSrcRfs";
            this.btnSrcRfs.Size = new System.Drawing.Size(67, 23);
            this.btnSrcRfs.TabIndex = 14;
            this.btnSrcRfs.Text = "Connect";
            this.btnSrcRfs.UseVisualStyleBackColor = true;
            this.btnSrcRfs.Click += new System.EventHandler(this.btnSrcRfs_Click);
            // 
            // cboSrcDB
            // 
            this.cboSrcDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSrcDB.FormattingEnabled = true;
            this.cboSrcDB.Location = new System.Drawing.Point(85, 129);
            this.cboSrcDB.Name = "cboSrcDB";
            this.cboSrcDB.Size = new System.Drawing.Size(196, 21);
            this.cboSrcDB.TabIndex = 13;
            // 
            // txtSrcSID
            // 
            this.txtSrcSID.Location = new System.Drawing.Point(85, 129);
            this.txtSrcSID.Name = "txtSrcSID";
            this.txtSrcSID.Size = new System.Drawing.Size(196, 20);
            this.txtSrcSID.TabIndex = 12;
            // 
            // txtSrcPwd
            // 
            this.txtSrcPwd.Location = new System.Drawing.Point(85, 103);
            this.txtSrcPwd.Name = "txtSrcPwd";
            this.txtSrcPwd.PasswordChar = '*';
            this.txtSrcPwd.Size = new System.Drawing.Size(269, 20);
            this.txtSrcPwd.TabIndex = 11;
            // 
            // txtSrcUser
            // 
            this.txtSrcUser.Location = new System.Drawing.Point(85, 77);
            this.txtSrcUser.Name = "txtSrcUser";
            this.txtSrcUser.Size = new System.Drawing.Size(269, 20);
            this.txtSrcUser.TabIndex = 10;
            // 
            // chkSrcWinAuth
            // 
            this.chkSrcWinAuth.AutoSize = true;
            this.chkSrcWinAuth.Location = new System.Drawing.Point(85, 54);
            this.chkSrcWinAuth.Name = "chkSrcWinAuth";
            this.chkSrcWinAuth.Size = new System.Drawing.Size(141, 17);
            this.chkSrcWinAuth.TabIndex = 9;
            this.chkSrcWinAuth.Text = "Windows Authentication";
            this.chkSrcWinAuth.UseVisualStyleBackColor = true;
            this.chkSrcWinAuth.CheckedChanged += new System.EventHandler(this.chkSrcWinAuth_CheckedChanged);
            // 
            // txtSrcServer
            // 
            this.txtSrcServer.Location = new System.Drawing.Point(85, 28);
            this.txtSrcServer.Name = "txtSrcServer";
            this.txtSrcServer.Size = new System.Drawing.Size(269, 20);
            this.txtSrcServer.TabIndex = 8;
            // 
            // lblSrcTable
            // 
            this.lblSrcTable.AutoSize = true;
            this.lblSrcTable.Location = new System.Drawing.Point(16, 156);
            this.lblSrcTable.Name = "lblSrcTable";
            this.lblSrcTable.Size = new System.Drawing.Size(62, 13);
            this.lblSrcTable.TabIndex = 6;
            this.lblSrcTable.Text = "Table/View";
            // 
            // lblSrcDB
            // 
            this.lblSrcDB.AutoSize = true;
            this.lblSrcDB.Location = new System.Drawing.Point(16, 129);
            this.lblSrcDB.Name = "lblSrcDB";
            this.lblSrcDB.Size = new System.Drawing.Size(53, 13);
            this.lblSrcDB.TabIndex = 5;
            this.lblSrcDB.Text = "Database";
            // 
            // lblSrcPwd
            // 
            this.lblSrcPwd.AutoSize = true;
            this.lblSrcPwd.Location = new System.Drawing.Point(16, 103);
            this.lblSrcPwd.Name = "lblSrcPwd";
            this.lblSrcPwd.Size = new System.Drawing.Size(53, 13);
            this.lblSrcPwd.TabIndex = 4;
            this.lblSrcPwd.Text = "Password";
            // 
            // lblSrcUser
            // 
            this.lblSrcUser.AutoSize = true;
            this.lblSrcUser.Location = new System.Drawing.Point(16, 77);
            this.lblSrcUser.Name = "lblSrcUser";
            this.lblSrcUser.Size = new System.Drawing.Size(29, 13);
            this.lblSrcUser.TabIndex = 3;
            this.lblSrcUser.Text = "User";
            // 
            // lblSrcServer
            // 
            this.lblSrcServer.AutoSize = true;
            this.lblSrcServer.Location = new System.Drawing.Point(16, 28);
            this.lblSrcServer.Name = "lblSrcServer";
            this.lblSrcServer.Size = new System.Drawing.Size(38, 13);
            this.lblSrcServer.TabIndex = 2;
            this.lblSrcServer.Text = "Server";
            // 
            // rbtnSrcOracle
            // 
            this.rbtnSrcOracle.AutoSize = true;
            this.rbtnSrcOracle.Location = new System.Drawing.Point(171, 6);
            this.rbtnSrcOracle.Name = "rbtnSrcOracle";
            this.rbtnSrcOracle.Size = new System.Drawing.Size(56, 17);
            this.rbtnSrcOracle.TabIndex = 1;
            this.rbtnSrcOracle.Text = "Oracle";
            this.rbtnSrcOracle.UseVisualStyleBackColor = true;
            this.rbtnSrcOracle.CheckedChanged += new System.EventHandler(this.rbtnSrcDatabase_CheckedChanged);
            // 
            // rbtnSrcSql
            // 
            this.rbtnSrcSql.AutoSize = true;
            this.rbtnSrcSql.Checked = true;
            this.rbtnSrcSql.Location = new System.Drawing.Point(85, 6);
            this.rbtnSrcSql.Name = "rbtnSrcSql";
            this.rbtnSrcSql.Size = new System.Drawing.Size(80, 17);
            this.rbtnSrcSql.TabIndex = 0;
            this.rbtnSrcSql.TabStop = true;
            this.rbtnSrcSql.Text = "SQL Server";
            this.rbtnSrcSql.UseVisualStyleBackColor = true;
            this.rbtnSrcSql.CheckedChanged += new System.EventHandler(this.rbtnSrcDatabase_CheckedChanged);
            // 
            // rbtnSrcGoogle
            // 
            this.rbtnSrcGoogle.AutoSize = true;
            this.rbtnSrcGoogle.Location = new System.Drawing.Point(295, 6);
            this.rbtnSrcGoogle.Name = "rbtnSrcGoogle";
            this.rbtnSrcGoogle.Size = new System.Drawing.Size(48, 17);
            this.rbtnSrcGoogle.TabIndex = 0;
            this.rbtnSrcGoogle.TabStop = true;
            this.rbtnSrcGoogle.Text = "GBQ";
            this.rbtnSrcGoogle.UseVisualStyleBackColor = true;
            this.rbtnSrcGoogle.CheckedChanged += new System.EventHandler(this.rbtnSrcDatabase_CheckedChanged);
            // 
            // tabpTarget
            // 
            this.tabpTarget.Controls.Add(this.btnTrgUse);
            this.tabpTarget.Controls.Add(this.lblTrgTableSelect);
            this.tabpTarget.Controls.Add(this.cboTrgTableSelect);
            this.tabpTarget.Controls.Add(this.rbtnTrgNetezza);
            this.tabpTarget.Controls.Add(this.btnTrgRfst);
            this.tabpTarget.Controls.Add(this.cboTrgTable);
            this.tabpTarget.Controls.Add(this.btnTrgRfs);
            this.tabpTarget.Controls.Add(this.cboTrgDB);
            this.tabpTarget.Controls.Add(this.txtTrgSID);
            this.tabpTarget.Controls.Add(this.txtTrgPwd);
            this.tabpTarget.Controls.Add(this.txtTrgUser);
            this.tabpTarget.Controls.Add(this.chkTrgWinAuth);
            this.tabpTarget.Controls.Add(this.txtTrgServer);
            this.tabpTarget.Controls.Add(this.lblTrgTable);
            this.tabpTarget.Controls.Add(this.lblTrgDB);
            this.tabpTarget.Controls.Add(this.lblTrgPwd);
            this.tabpTarget.Controls.Add(this.lblTrgUser);
            this.tabpTarget.Controls.Add(this.lblTrgServer);
            this.tabpTarget.Controls.Add(this.rbtnTrgOracle);
            this.tabpTarget.Controls.Add(this.rbtnTrgSql);
            this.tabpTarget.Controls.Add(this.rbtnTrgGoogle);
            this.tabpTarget.Location = new System.Drawing.Point(4, 22);
            this.tabpTarget.Name = "tabpTarget";
            this.tabpTarget.Padding = new System.Windows.Forms.Padding(3);
            this.tabpTarget.Size = new System.Drawing.Size(360, 217);
            this.tabpTarget.TabIndex = 1;
            this.tabpTarget.Text = "Target";
            this.tabpTarget.UseVisualStyleBackColor = true;
            // 
            // lblTrgTableSelect
            // 
            this.lblTrgTableSelect.AutoSize = true;
            this.lblTrgTableSelect.Location = new System.Drawing.Point(16, 183);
            this.lblTrgTableSelect.Name = "lblTrgTableSelect";
            this.lblTrgTableSelect.Size = new System.Drawing.Size(39, 13);
            this.lblTrgTableSelect.TabIndex = 21;
            this.lblTrgTableSelect.Text = "Tables";
            // 
            // cboTrgTableSelect
            // 
            this.cboTrgTableSelect.FormattingEnabled = true;
            this.cboTrgTableSelect.Location = new System.Drawing.Point(85, 183);
            this.cboTrgTableSelect.Name = "cboTrgTableSelect";
            this.cboTrgTableSelect.Size = new System.Drawing.Size(196, 21);
            this.cboTrgTableSelect.TabIndex = 19;
            // 
            // rbtnTrgNetezza
            // 
            this.rbtnTrgNetezza.AutoSize = true;
            this.rbtnTrgNetezza.Location = new System.Drawing.Point(229, 6);
            this.rbtnTrgNetezza.Name = "rbtnTrgNetezza";
            this.rbtnTrgNetezza.Size = new System.Drawing.Size(64, 17);
            this.rbtnTrgNetezza.TabIndex = 18;
            this.rbtnTrgNetezza.TabStop = true;
            this.rbtnTrgNetezza.Text = "Netezza";
            this.rbtnTrgNetezza.UseVisualStyleBackColor = true;
            this.rbtnTrgNetezza.CheckedChanged += new System.EventHandler(this.rbtnTrgDatabase_CheckedChanged);
            // 
            // btnTrgRfst
            // 
            this.btnTrgRfst.Location = new System.Drawing.Point(287, 156);
            this.btnTrgRfst.Name = "btnTrgRfst";
            this.btnTrgRfst.Size = new System.Drawing.Size(67, 23);
            this.btnTrgRfst.TabIndex = 16;
            this.btnTrgRfst.Text = "Select";
            this.btnTrgRfst.UseVisualStyleBackColor = true;
            this.btnTrgRfst.Click += new System.EventHandler(this.btnTrgRfst_Click);
            // 
            // cboTrgTable
            // 
            this.cboTrgTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrgTable.FormattingEnabled = true;
            this.cboTrgTable.Location = new System.Drawing.Point(85, 156);
            this.cboTrgTable.Name = "cboTrgTable";
            this.cboTrgTable.Size = new System.Drawing.Size(196, 21);
            this.cboTrgTable.TabIndex = 15;
            // 
            // btnTrgRfs
            // 
            this.btnTrgRfs.Location = new System.Drawing.Point(287, 128);
            this.btnTrgRfs.Name = "btnTrgRfs";
            this.btnTrgRfs.Size = new System.Drawing.Size(67, 23);
            this.btnTrgRfs.TabIndex = 14;
            this.btnTrgRfs.Text = "Connect";
            this.btnTrgRfs.UseVisualStyleBackColor = true;
            this.btnTrgRfs.Click += new System.EventHandler(this.btnTrgRfs_Click);
            // 
            // cboTrgDB
            // 
            this.cboTrgDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrgDB.FormattingEnabled = true;
            this.cboTrgDB.Location = new System.Drawing.Point(85, 129);
            this.cboTrgDB.Name = "cboTrgDB";
            this.cboTrgDB.Size = new System.Drawing.Size(196, 21);
            this.cboTrgDB.TabIndex = 13;
            // 
            // txtTrgSID
            // 
            this.txtTrgSID.Location = new System.Drawing.Point(85, 129);
            this.txtTrgSID.Name = "txtTrgSID";
            this.txtTrgSID.Size = new System.Drawing.Size(196, 20);
            this.txtTrgSID.TabIndex = 12;
            // 
            // txtTrgPwd
            // 
            this.txtTrgPwd.Location = new System.Drawing.Point(85, 103);
            this.txtTrgPwd.Name = "txtTrgPwd";
            this.txtTrgPwd.PasswordChar = '*';
            this.txtTrgPwd.Size = new System.Drawing.Size(269, 20);
            this.txtTrgPwd.TabIndex = 11;
            // 
            // txtTrgUser
            // 
            this.txtTrgUser.Location = new System.Drawing.Point(85, 77);
            this.txtTrgUser.Name = "txtTrgUser";
            this.txtTrgUser.Size = new System.Drawing.Size(269, 20);
            this.txtTrgUser.TabIndex = 10;
            // 
            // chkTrgWinAuth
            // 
            this.chkTrgWinAuth.AutoSize = true;
            this.chkTrgWinAuth.Location = new System.Drawing.Point(85, 54);
            this.chkTrgWinAuth.Name = "chkTrgWinAuth";
            this.chkTrgWinAuth.Size = new System.Drawing.Size(141, 17);
            this.chkTrgWinAuth.TabIndex = 9;
            this.chkTrgWinAuth.Text = "Windows Authentication";
            this.chkTrgWinAuth.UseVisualStyleBackColor = true;
            this.chkTrgWinAuth.CheckedChanged += new System.EventHandler(this.chkTrgWinAuth_CheckedChanged);
            // 
            // txtTrgServer
            // 
            this.txtTrgServer.Location = new System.Drawing.Point(85, 28);
            this.txtTrgServer.Name = "txtTrgServer";
            this.txtTrgServer.Size = new System.Drawing.Size(269, 20);
            this.txtTrgServer.TabIndex = 8;
            // 
            // lblTrgTable
            // 
            this.lblTrgTable.AutoSize = true;
            this.lblTrgTable.Location = new System.Drawing.Point(16, 156);
            this.lblTrgTable.Name = "lblTrgTable";
            this.lblTrgTable.Size = new System.Drawing.Size(62, 13);
            this.lblTrgTable.TabIndex = 6;
            this.lblTrgTable.Text = "Table/View";
            // 
            // lblTrgDB
            // 
            this.lblTrgDB.AutoSize = true;
            this.lblTrgDB.Location = new System.Drawing.Point(16, 129);
            this.lblTrgDB.Name = "lblTrgDB";
            this.lblTrgDB.Size = new System.Drawing.Size(53, 13);
            this.lblTrgDB.TabIndex = 5;
            this.lblTrgDB.Text = "Database";
            // 
            // lblTrgPwd
            // 
            this.lblTrgPwd.AutoSize = true;
            this.lblTrgPwd.Location = new System.Drawing.Point(16, 103);
            this.lblTrgPwd.Name = "lblTrgPwd";
            this.lblTrgPwd.Size = new System.Drawing.Size(53, 13);
            this.lblTrgPwd.TabIndex = 4;
            this.lblTrgPwd.Text = "Password";
            // 
            // lblTrgUser
            // 
            this.lblTrgUser.AutoSize = true;
            this.lblTrgUser.Location = new System.Drawing.Point(16, 77);
            this.lblTrgUser.Name = "lblTrgUser";
            this.lblTrgUser.Size = new System.Drawing.Size(29, 13);
            this.lblTrgUser.TabIndex = 3;
            this.lblTrgUser.Text = "User";
            // 
            // lblTrgServer
            // 
            this.lblTrgServer.AutoSize = true;
            this.lblTrgServer.Location = new System.Drawing.Point(16, 28);
            this.lblTrgServer.Name = "lblTrgServer";
            this.lblTrgServer.Size = new System.Drawing.Size(38, 13);
            this.lblTrgServer.TabIndex = 2;
            this.lblTrgServer.Text = "Server";
            // 
            // rbtnTrgOracle
            // 
            this.rbtnTrgOracle.AutoSize = true;
            this.rbtnTrgOracle.Location = new System.Drawing.Point(171, 6);
            this.rbtnTrgOracle.Name = "rbtnTrgOracle";
            this.rbtnTrgOracle.Size = new System.Drawing.Size(56, 17);
            this.rbtnTrgOracle.TabIndex = 1;
            this.rbtnTrgOracle.Text = "Oracle";
            this.rbtnTrgOracle.UseVisualStyleBackColor = true;
            this.rbtnTrgOracle.CheckedChanged += new System.EventHandler(this.rbtnTrgDatabase_CheckedChanged);
            // 
            // rbtnTrgSql
            // 
            this.rbtnTrgSql.AutoSize = true;
            this.rbtnTrgSql.Checked = true;
            this.rbtnTrgSql.Location = new System.Drawing.Point(85, 6);
            this.rbtnTrgSql.Name = "rbtnTrgSql";
            this.rbtnTrgSql.Size = new System.Drawing.Size(80, 17);
            this.rbtnTrgSql.TabIndex = 0;
            this.rbtnTrgSql.TabStop = true;
            this.rbtnTrgSql.Text = "SQL Server";
            this.rbtnTrgSql.UseVisualStyleBackColor = true;
            this.rbtnTrgSql.CheckedChanged += new System.EventHandler(this.rbtnTrgDatabase_CheckedChanged);
            // 
            // rbtnTrgGoogle
            // 
            this.rbtnTrgGoogle.AutoSize = true;
            this.rbtnTrgGoogle.Location = new System.Drawing.Point(295, 6);
            this.rbtnTrgGoogle.Name = "rbtnTrgGoogle";
            this.rbtnTrgGoogle.Size = new System.Drawing.Size(48, 17);
            this.rbtnTrgGoogle.TabIndex = 0;
            this.rbtnTrgGoogle.TabStop = true;
            this.rbtnTrgGoogle.Text = "GBQ";
            this.rbtnTrgGoogle.UseVisualStyleBackColor = true;
            this.rbtnTrgGoogle.CheckedChanged += new System.EventHandler(this.rbtnTrgDatabase_CheckedChanged);
            // 
            // btnEditMapping
            // 
            this.btnEditMapping.Enabled = false;
            this.btnEditMapping.Location = new System.Drawing.Point(386, 6);
            this.btnEditMapping.Name = "btnEditMapping";
            this.btnEditMapping.Size = new System.Drawing.Size(58, 244);
            this.btnEditMapping.TabIndex = 1;
            this.btnEditMapping.Text = "Edit Mapping";
            this.btnEditMapping.UseVisualStyleBackColor = true;
            this.btnEditMapping.Click += new System.EventHandler(this.btnEditMapping_Click);
            // 
            // dgvMappings
            // 
            this.dgvMappings.AllowUserToAddRows = false;
            this.dgvMappings.AllowUserToDeleteRows = false;
            this.dgvMappings.AllowUserToResizeRows = false;
            this.dgvMappings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMappings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMappings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.SourceColumn,
            this.TargetColumn,
            this.SelectedKey});
            this.dgvMappings.Location = new System.Drawing.Point(450, 7);
            this.dgvMappings.Name = "dgvMappings";
            this.dgvMappings.RowHeadersVisible = false;
            this.dgvMappings.RowHeadersWidth = 4;
            this.dgvMappings.Size = new System.Drawing.Size(522, 243);
            this.dgvMappings.TabIndex = 2;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.Width = 55;
            // 
            // SourceColumn
            // 
            this.SourceColumn.DataPropertyName = "SourceColumn";
            this.SourceColumn.HeaderText = "SourceColumn";
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            this.SourceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SourceColumn.Width = 82;
            // 
            // TargetColumn
            // 
            this.TargetColumn.DataPropertyName = "TargetColumn";
            this.TargetColumn.HeaderText = "TargetColumn";
            this.TargetColumn.Name = "TargetColumn";
            this.TargetColumn.Width = 79;
            // 
            // SelectedKey
            // 
            this.SelectedKey.DataPropertyName = "Key";
            this.SelectedKey.HeaderText = "Is Key?";
            this.SelectedKey.Name = "SelectedKey";
            this.SelectedKey.Width = 48;
            // 
            // btnCompare
            // 
            this.btnCompare.Enabled = false;
            this.btnCompare.Location = new System.Drawing.Point(12, 255);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(109, 31);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(130, 255);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkShowDiff
            // 
            this.chkShowDiff.AutoSize = true;
            this.chkShowDiff.Enabled = false;
            this.chkShowDiff.Location = new System.Drawing.Point(234, 263);
            this.chkShowDiff.Name = "chkShowDiff";
            this.chkShowDiff.Size = new System.Drawing.Size(139, 17);
            this.chkShowDiff.TabIndex = 5;
            this.chkShowDiff.Text = "Show Diff Columns Only";
            this.chkShowDiff.UseVisualStyleBackColor = true;
            this.chkShowDiff.CheckedChanged += new System.EventHandler(this.chkShowDiff_CheckedChanged);
            // 
            // gbxCells
            // 
            this.gbxCells.Controls.Add(this.lblRedDesc);
            this.gbxCells.Controls.Add(this.lblRedColor);
            this.gbxCells.Controls.Add(this.lblLightBlueDesc);
            this.gbxCells.Controls.Add(this.lblLightBlueColor);
            this.gbxCells.Controls.Add(this.lblWhiteDesc);
            this.gbxCells.Controls.Add(this.lblWhiteColor);
            this.gbxCells.Location = new System.Drawing.Point(386, 251);
            this.gbxCells.Name = "gbxCells";
            this.gbxCells.Size = new System.Drawing.Size(286, 36);
            this.gbxCells.TabIndex = 6;
            this.gbxCells.TabStop = false;
            this.gbxCells.Text = "Cells";
            // 
            // lblRedDesc
            // 
            this.lblRedDesc.AutoSize = true;
            this.lblRedDesc.Location = new System.Drawing.Point(235, 16);
            this.lblRedDesc.Name = "lblRedDesc";
            this.lblRedDesc.Size = new System.Drawing.Size(47, 13);
            this.lblRedDesc.TabIndex = 5;
            this.lblRedDesc.Text = "Different";
            // 
            // lblRedColor
            // 
            this.lblRedColor.BackColor = System.Drawing.Color.Red;
            this.lblRedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRedColor.Location = new System.Drawing.Point(222, 16);
            this.lblRedColor.Name = "lblRedColor";
            this.lblRedColor.Size = new System.Drawing.Size(13, 13);
            this.lblRedColor.TabIndex = 4;
            // 
            // lblLightBlueDesc
            // 
            this.lblLightBlueDesc.AutoSize = true;
            this.lblLightBlueDesc.Location = new System.Drawing.Point(66, 16);
            this.lblLightBlueDesc.Name = "lblLightBlueDesc";
            this.lblLightBlueDesc.Size = new System.Drawing.Size(156, 13);
            this.lblLightBlueDesc.TabIndex = 3;
            this.lblLightBlueDesc.Text = "Same Value, Different Datatype";
            // 
            // lblLightBlueColor
            // 
            this.lblLightBlueColor.BackColor = System.Drawing.Color.LightBlue;
            this.lblLightBlueColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightBlueColor.Location = new System.Drawing.Point(53, 16);
            this.lblLightBlueColor.Name = "lblLightBlueColor";
            this.lblLightBlueColor.Size = new System.Drawing.Size(13, 13);
            this.lblLightBlueColor.TabIndex = 2;
            // 
            // lblWhiteDesc
            // 
            this.lblWhiteDesc.AutoSize = true;
            this.lblWhiteDesc.Location = new System.Drawing.Point(19, 16);
            this.lblWhiteDesc.Name = "lblWhiteDesc";
            this.lblWhiteDesc.Size = new System.Drawing.Size(34, 13);
            this.lblWhiteDesc.TabIndex = 1;
            this.lblWhiteDesc.Text = "Same";
            // 
            // lblWhiteColor
            // 
            this.lblWhiteColor.BackColor = System.Drawing.Color.White;
            this.lblWhiteColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWhiteColor.Location = new System.Drawing.Point(6, 16);
            this.lblWhiteColor.Name = "lblWhiteColor";
            this.lblWhiteColor.Size = new System.Drawing.Size(13, 13);
            this.lblWhiteColor.TabIndex = 0;
            // 
            // gbxRows
            // 
            this.gbxRows.Controls.Add(this.lblLightGreenDesc);
            this.gbxRows.Controls.Add(this.lblLightGreenColor);
            this.gbxRows.Controls.Add(this.lblLightPinkDesc);
            this.gbxRows.Controls.Add(this.lblLightPinkColor);
            this.gbxRows.Location = new System.Drawing.Point(695, 251);
            this.gbxRows.Name = "gbxRows";
            this.gbxRows.Size = new System.Drawing.Size(179, 36);
            this.gbxRows.TabIndex = 0;
            this.gbxRows.TabStop = false;
            this.gbxRows.Text = "Rows";
            // 
            // lblLightGreenDesc
            // 
            this.lblLightGreenDesc.AutoSize = true;
            this.lblLightGreenDesc.Location = new System.Drawing.Point(102, 16);
            this.lblLightGreenDesc.Name = "lblLightGreenDesc";
            this.lblLightGreenDesc.Size = new System.Drawing.Size(73, 13);
            this.lblLightGreenDesc.TabIndex = 3;
            this.lblLightGreenDesc.Text = "Source Empty";
            // 
            // lblLightGreenColor
            // 
            this.lblLightGreenColor.BackColor = System.Drawing.Color.LightGreen;
            this.lblLightGreenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightGreenColor.Location = new System.Drawing.Point(89, 16);
            this.lblLightGreenColor.Name = "lblLightGreenColor";
            this.lblLightGreenColor.Size = new System.Drawing.Size(13, 13);
            this.lblLightGreenColor.TabIndex = 2;
            // 
            // lblLightPinkDesc
            // 
            this.lblLightPinkDesc.AutoSize = true;
            this.lblLightPinkDesc.Location = new System.Drawing.Point(19, 16);
            this.lblLightPinkDesc.Name = "lblLightPinkDesc";
            this.lblLightPinkDesc.Size = new System.Drawing.Size(70, 13);
            this.lblLightPinkDesc.TabIndex = 1;
            this.lblLightPinkDesc.Text = "Target Empty";
            // 
            // lblLightPinkColor
            // 
            this.lblLightPinkColor.BackColor = System.Drawing.Color.LightPink;
            this.lblLightPinkColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightPinkColor.Location = new System.Drawing.Point(6, 16);
            this.lblLightPinkColor.Name = "lblLightPinkColor";
            this.lblLightPinkColor.Size = new System.Drawing.Size(13, 13);
            this.lblLightPinkColor.TabIndex = 0;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 293);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(960, 307);
            this.dgvResult.TabIndex = 7;
            this.dgvResult.VirtualMode = true;
            // 
            // bwDatabase
            // 
            this.bwDatabase.WorkerReportsProgress = true;
            this.bwDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDatabase_DoWork);
            this.bwDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDatabase_RunWorkerCompleted);
            // 
            // bwTable
            // 
            this.bwTable.WorkerReportsProgress = true;
            this.bwTable.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTable_DoWork);
            this.bwTable.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwTable_RunWorkerCompleted);
            // 
            // bwTableSelect
            // 
            this.bwTableSelect.WorkerReportsProgress = true;
            this.bwTableSelect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTableSelect_DoWork);
            this.bwTableSelect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwTableSelect_RunWorkerCompleted);
            // 
            // bwMapping
            // 
            this.bwMapping.WorkerReportsProgress = true;
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.tctlCompare);
            this.panelConfig.Location = new System.Drawing.Point(12, 6);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(368, 243);
            this.panelConfig.TabIndex = 8;
            // 
            // btnSrcUse
            // 
            this.btnSrcUse.Location = new System.Drawing.Point(287, 183);
            this.btnSrcUse.Name = "btnSrcUse";
            this.btnSrcUse.Size = new System.Drawing.Size(67, 23);
            this.btnSrcUse.TabIndex = 22;
            this.btnSrcUse.Text = "Use";
            this.btnSrcUse.UseVisualStyleBackColor = true;
            this.btnSrcUse.Click += new System.EventHandler(this.btnSrcUse_Click);
            // 
            // btnTrgUse
            // 
            this.btnTrgUse.Location = new System.Drawing.Point(287, 183);
            this.btnTrgUse.Name = "btnTrgUse";
            this.btnTrgUse.Size = new System.Drawing.Size(67, 23);
            this.btnTrgUse.TabIndex = 22;
            this.btnTrgUse.Text = "Use";
            this.btnTrgUse.UseVisualStyleBackColor = true;
            this.btnTrgUse.Click += new System.EventHandler(this.btnTrgUse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.gbxRows);
            this.Controls.Add(this.gbxCells);
            this.Controls.Add(this.chkShowDiff);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dgvMappings);
            this.Controls.Add(this.btnEditMapping);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Testing Tool";
            this.tctlCompare.ResumeLayout(false);
            this.tabpSource.ResumeLayout(false);
            this.tabpSource.PerformLayout();
            this.tabpTarget.ResumeLayout(false);
            this.tabpTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMappings)).EndInit();
            this.gbxCells.ResumeLayout(false);
            this.gbxCells.PerformLayout();
            this.gbxRows.ResumeLayout(false);
            this.gbxRows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panelConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl tctlCompare;
        private System.Windows.Forms.TabPage tabpSource;
        private System.Windows.Forms.TabPage tabpTarget;
        private System.Windows.Forms.RadioButton rbtnSrcOracle;
        private System.Windows.Forms.RadioButton rbtnSrcSql;
        private System.Windows.Forms.RadioButton rbtnSrcGoogle;
        private System.Windows.Forms.Label lblSrcTable;
        private System.Windows.Forms.Label lblSrcDB;
        private System.Windows.Forms.Label lblSrcPwd;
        private System.Windows.Forms.Label lblSrcUser;
        private System.Windows.Forms.Label lblSrcServer;
        private System.Windows.Forms.ComboBox cboSrcDB;
        private System.Windows.Forms.TextBox txtSrcSID;
        private System.Windows.Forms.TextBox txtSrcPwd;
        private System.Windows.Forms.TextBox txtSrcUser;
        private System.Windows.Forms.CheckBox chkSrcWinAuth;
        private System.Windows.Forms.TextBox txtSrcServer;
        private System.Windows.Forms.Button btnSrcRfst;
        private System.Windows.Forms.ComboBox cboSrcTable;
        private System.Windows.Forms.Button btnSrcRfs;
        private System.Windows.Forms.RadioButton rbtnTrgOracle;
        private System.Windows.Forms.RadioButton rbtnTrgSql;
        private System.Windows.Forms.RadioButton rbtnTrgGoogle;
        private System.Windows.Forms.Label lblTrgTable;
        private System.Windows.Forms.Label lblTrgDB;
        private System.Windows.Forms.Label lblTrgPwd;
        private System.Windows.Forms.Label lblTrgUser;
        private System.Windows.Forms.Label lblTrgServer;
        private System.Windows.Forms.Button btnTrgRfst;
        private System.Windows.Forms.ComboBox cboTrgTable;
        private System.Windows.Forms.Button btnTrgRfs;
        private System.Windows.Forms.ComboBox cboTrgDB;
        private System.Windows.Forms.TextBox txtTrgSID;
        private System.Windows.Forms.TextBox txtTrgPwd;
        private System.Windows.Forms.TextBox txtTrgUser;
        private System.Windows.Forms.CheckBox chkTrgWinAuth;
        private System.Windows.Forms.TextBox txtTrgServer;
        private System.Windows.Forms.Button btnEditMapping;
        private System.Windows.Forms.DataGridView dgvMappings;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TargetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedKey;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkShowDiff;
        private System.Windows.Forms.GroupBox gbxCells;
        private System.Windows.Forms.GroupBox gbxRows;
        private System.Windows.Forms.Label lblWhiteDesc;
        private System.Windows.Forms.Label lblWhiteColor;
        private System.Windows.Forms.Label lblRedDesc;
        private System.Windows.Forms.Label lblRedColor;
        private System.Windows.Forms.Label lblLightBlueDesc;
        private System.Windows.Forms.Label lblLightBlueColor;
        private System.Windows.Forms.Label lblLightGreenDesc;
        private System.Windows.Forms.Label lblLightGreenColor;
        private System.Windows.Forms.Label lblLightPinkDesc;
        private System.Windows.Forms.Label lblLightPinkColor;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.RadioButton rbtnSrcNetezza;
        private System.Windows.Forms.RadioButton rbtnTrgNetezza;
        private System.ComponentModel.BackgroundWorker bwDatabase;
        private System.ComponentModel.BackgroundWorker bwTable;
        private System.ComponentModel.BackgroundWorker bwTableSelect;
        private System.ComponentModel.BackgroundWorker bwMapping;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label lblSrcTableSelect;
        private System.Windows.Forms.ComboBox cboSrcTableSelect;
        private System.Windows.Forms.Label lblTrgTableSelect;
        private System.Windows.Forms.ComboBox cboTrgTableSelect;
        private System.Windows.Forms.Button btnSrcUse;
        private System.Windows.Forms.Button btnTrgUse;
    }
}

