namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    partial class iLogicJobAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iLogicJobAdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdvancediLogicConfig = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDebugInfo = new System.Windows.Forms.Label();
            this.chckBoxBreak = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.lblLogLevel = new System.Windows.Forms.Label();
            this.btnSelectLogPath = new System.Windows.Forms.Button();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddInDirSearch = new System.Windows.Forms.Button();
            this.txtDLLsDir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdViewExtRls = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtRuleDirDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRuleDirAdd = new System.Windows.Forms.Button();
            this.btnRuleDirUp = new System.Windows.Forms.Button();
            this.btnRuleDirDown = new System.Windows.Forms.Button();
            this.tabLifecycleRules = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblInternalRuleText = new System.Windows.Forms.Label();
            this.txtInternalRuleText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRunInternal = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPrimaryRuleFile = new System.Windows.Forms.Label();
            this.btnOpenJobRuleVault = new System.Windows.Forms.Button();
            this.txtJobRuleVault = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabUserRules = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtGrdUsrRules = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRuleDispName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserRulePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUserRules = new System.Windows.Forms.Button();
            this.btnUserRuleUp = new System.Windows.Forms.Button();
            this.btnUserRuleDown = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblPropagateVltProps = new System.Windows.Forms.Label();
            this.chckBoxPropagateProps = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSaveToVlt = new System.Windows.Forms.Button();
            this.btnLoadFromVlt = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chckBoxPropagateItemProps = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAdvancediLogicConfig.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewExtRls)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabLifecycleRules.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabUserRules.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdUsrRules)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAdvancediLogicConfig);
            this.tabControl1.Controls.Add(this.tabLifecycleRules);
            this.tabControl1.Controls.Add(this.tabUserRules);
            this.tabControl1.Controls.Add(this.tabOptions);
            this.tabControl1.ItemSize = new System.Drawing.Size(105, 26);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAdvancediLogicConfig
            // 
            this.tabAdvancediLogicConfig.Controls.Add(this.groupBox4);
            this.tabAdvancediLogicConfig.Controls.Add(this.groupBox3);
            this.tabAdvancediLogicConfig.Controls.Add(this.groupBox2);
            this.tabAdvancediLogicConfig.Controls.Add(this.groupBox1);
            this.tabAdvancediLogicConfig.Location = new System.Drawing.Point(4, 30);
            this.tabAdvancediLogicConfig.Name = "tabAdvancediLogicConfig";
            this.tabAdvancediLogicConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancediLogicConfig.Size = new System.Drawing.Size(592, 418);
            this.tabAdvancediLogicConfig.TabIndex = 0;
            this.tabAdvancediLogicConfig.Text = "iLogic Configuration";
            this.toolTip1.SetToolTip(this.tabAdvancediLogicConfig, "iLogic Addin - Advanced Configuration Options");
            this.tabAdvancediLogicConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblDebugInfo);
            this.groupBox4.Controls.Add(this.chckBoxBreak);
            this.groupBox4.Location = new System.Drawing.Point(7, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 87);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Rule Debugging";
            this.toolTip1.SetToolTip(this.groupBox4, "Pauses Job execution to connect a Visual Studio debug-project \r\nto running instan" +
        "ce of VaultInventorServer.");
            // 
            // lblDebugInfo
            // 
            this.lblDebugInfo.AutoSize = true;
            this.lblDebugInfo.Location = new System.Drawing.Point(163, 20);
            this.lblDebugInfo.Name = "lblDebugInfo";
            this.lblDebugInfo.Size = new System.Drawing.Size(368, 39);
            this.lblDebugInfo.TabIndex = 2;
            this.lblDebugInfo.Text = "Advanced Rule Debugging stops the Job execution with a Message Box.\r\nUse Visual S" +
    "tudio and attach to the process \'VaultInventorServer.exe\' before\r\nconfirming the" +
    " message with OK.";
            this.lblDebugInfo.Click += new System.EventHandler(this.lblDebugInfo_Click);
            // 
            // chckBoxBreak
            // 
            this.chckBoxBreak.AutoSize = true;
            this.chckBoxBreak.Location = new System.Drawing.Point(8, 19);
            this.chckBoxBreak.Name = "chckBoxBreak";
            this.chckBoxBreak.Size = new System.Drawing.Size(125, 17);
            this.chckBoxBreak.TabIndex = 1;
            this.chckBoxBreak.Text = "Enable Debug Break";
            this.chckBoxBreak.UseVisualStyleBackColor = true;
            this.chckBoxBreak.CheckedChanged += new System.EventHandler(this.chckBoxBreak_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblLogPath);
            this.groupBox3.Controls.Add(this.lblLogLevel);
            this.groupBox3.Controls.Add(this.btnSelectLogPath);
            this.groupBox3.Controls.Add(this.cmbLogLevel);
            this.groupBox3.Controls.Add(this.txtLogPath);
            this.groupBox3.Location = new System.Drawing.Point(6, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(6, 49);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(50, 13);
            this.lblLogPath.TabIndex = 5;
            this.lblLogPath.Text = "Log Path";
            // 
            // lblLogLevel
            // 
            this.lblLogLevel.AutoSize = true;
            this.lblLogLevel.Location = new System.Drawing.Point(6, 22);
            this.lblLogLevel.Name = "lblLogLevel";
            this.lblLogLevel.Size = new System.Drawing.Size(54, 13);
            this.lblLogLevel.TabIndex = 4;
            this.lblLogLevel.Text = "Log Level";
            // 
            // btnSelectLogPath
            // 
            this.btnSelectLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLogPath.Location = new System.Drawing.Point(539, 42);
            this.btnSelectLogPath.Name = "btnSelectLogPath";
            this.btnSelectLogPath.Size = new System.Drawing.Size(33, 26);
            this.btnSelectLogPath.TabIndex = 3;
            this.btnSelectLogPath.Text = "...";
            this.btnSelectLogPath.UseVisualStyleBackColor = true;
            this.btnSelectLogPath.Click += new System.EventHandler(this.btnSelectLogPath_Click);
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Items.AddRange(new object[] {
            "None",
            "Trace",
            "Debug",
            "Info",
            "Warn",
            "Error",
            "Fatal"});
            this.cmbLogLevel.Location = new System.Drawing.Point(66, 19);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(133, 21);
            this.cmbLogLevel.TabIndex = 0;
            this.cmbLogLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLogLevel_SelectedIndexChanged);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogPath.Enabled = false;
            this.txtLogPath.Location = new System.Drawing.Point(66, 46);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(467, 20);
            this.txtLogPath.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddInDirSearch);
            this.groupBox2.Controls.Add(this.txtDLLsDir);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "iLogic Addin DLLs Directory";
            // 
            // btnAddInDirSearch
            // 
            this.btnAddInDirSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInDirSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInDirSearch.Location = new System.Drawing.Point(539, 19);
            this.btnAddInDirSearch.Name = "btnAddInDirSearch";
            this.btnAddInDirSearch.Size = new System.Drawing.Size(35, 26);
            this.btnAddInDirSearch.TabIndex = 1;
            this.btnAddInDirSearch.Text = "...";
            this.btnAddInDirSearch.UseVisualStyleBackColor = true;
            this.btnAddInDirSearch.Click += new System.EventHandler(this.btnAddInDirSearch_Click);
            // 
            // txtDLLsDir
            // 
            this.txtDLLsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDLLsDir.Location = new System.Drawing.Point(6, 23);
            this.txtDLLsDir.Name = "txtDLLsDir";
            this.txtDLLsDir.Size = new System.Drawing.Size(527, 20);
            this.txtDLLsDir.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgrdViewExtRls);
            this.groupBox1.Controls.Add(this.btnRuleDirAdd);
            this.groupBox1.Controls.Add(this.btnRuleDirUp);
            this.groupBox1.Controls.Add(this.btnRuleDirDown);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External Rule Directories";
            // 
            // dtgrdViewExtRls
            // 
            this.dtgrdViewExtRls.AllowUserToAddRows = false;
            this.dtgrdViewExtRls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdViewExtRls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdViewExtRls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2});
            this.dtgrdViewExtRls.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgrdViewExtRls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgrdViewExtRls.Location = new System.Drawing.Point(6, 19);
            this.dtgrdViewExtRls.Name = "dtgrdViewExtRls";
            this.dtgrdViewExtRls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdViewExtRls.Size = new System.Drawing.Size(536, 135);
            this.dtgrdViewExtRls.TabIndex = 0;
            // 
            // column1
            // 
            this.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.column1.FillWeight = 10F;
            this.column1.HeaderText = "Order";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column1.Width = 39;
            // 
            // column2
            // 
            this.column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column2.FillWeight = 190F;
            this.column2.HeaderText = "Path";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPathToolStripMenuItem,
            this.mnuExtRuleDirDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // addPathToolStripMenuItem
            // 
            this.addPathToolStripMenuItem.Name = "addPathToolStripMenuItem";
            this.addPathToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addPathToolStripMenuItem.Text = "Add Path";
            this.addPathToolStripMenuItem.ToolTipText = "Add a Directory to the list";
            this.addPathToolStripMenuItem.Click += new System.EventHandler(this.btnRuleDirAdd_Click);
            // 
            // mnuExtRuleDirDelete
            // 
            this.mnuExtRuleDirDelete.Name = "mnuExtRuleDirDelete";
            this.mnuExtRuleDirDelete.Size = new System.Drawing.Size(123, 22);
            this.mnuExtRuleDirDelete.Text = "Delete";
            this.mnuExtRuleDirDelete.ToolTipText = "Delete selected row(s).";
            this.mnuExtRuleDirDelete.Click += new System.EventHandler(this.mnuExtRuleDirDelete_Click);
            // 
            // btnRuleDirAdd
            // 
            this.btnRuleDirAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRuleDirAdd.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Plus;
            this.btnRuleDirAdd.Location = new System.Drawing.Point(548, 19);
            this.btnRuleDirAdd.Name = "btnRuleDirAdd";
            this.btnRuleDirAdd.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirAdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnRuleDirAdd, "Add a Directory to the list");
            this.btnRuleDirAdd.UseVisualStyleBackColor = true;
            this.btnRuleDirAdd.Click += new System.EventHandler(this.btnRuleDirAdd_Click);
            // 
            // btnRuleDirUp
            // 
            this.btnRuleDirUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRuleDirUp.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Up;
            this.btnRuleDirUp.Location = new System.Drawing.Point(548, 75);
            this.btnRuleDirUp.Name = "btnRuleDirUp";
            this.btnRuleDirUp.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirUp.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnRuleDirUp, "Move this directory up in the list (higher priority)");
            this.btnRuleDirUp.UseVisualStyleBackColor = true;
            this.btnRuleDirUp.Click += new System.EventHandler(this.btnRuleDirUp_Click);
            // 
            // btnRuleDirDown
            // 
            this.btnRuleDirDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRuleDirDown.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Down;
            this.btnRuleDirDown.Location = new System.Drawing.Point(548, 107);
            this.btnRuleDirDown.Name = "btnRuleDirDown";
            this.btnRuleDirDown.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirDown.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRuleDirDown, "Move this directory down in the list (lower priority)");
            this.btnRuleDirDown.UseVisualStyleBackColor = true;
            this.btnRuleDirDown.Click += new System.EventHandler(this.btnRuleDirDown_Click);
            // 
            // tabLifecycleRules
            // 
            this.tabLifecycleRules.Controls.Add(this.groupBox6);
            this.tabLifecycleRules.Controls.Add(this.groupBox5);
            this.tabLifecycleRules.Location = new System.Drawing.Point(4, 30);
            this.tabLifecycleRules.Name = "tabLifecycleRules";
            this.tabLifecycleRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabLifecycleRules.Size = new System.Drawing.Size(592, 418);
            this.tabLifecycleRules.TabIndex = 2;
            this.tabLifecycleRules.Text = "Lifecycle Rule(s)";
            this.tabLifecycleRules.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lblInternalRuleText);
            this.groupBox6.Controls.Add(this.txtInternalRuleText);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cmbRunInternal);
            this.groupBox6.Location = new System.Drawing.Point(6, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(579, 79);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Internal Rules";
            this.toolTip1.SetToolTip(this.groupBox6, "Internal rules are available rules stored within the Inventor file \r\nprocessed by" +
        " the job run at a lifecycle transition.");
            // 
            // lblInternalRuleText
            // 
            this.lblInternalRuleText.AutoSize = true;
            this.lblInternalRuleText.Enabled = false;
            this.lblInternalRuleText.Location = new System.Drawing.Point(7, 47);
            this.lblInternalRuleText.Name = "lblInternalRuleText";
            this.lblInternalRuleText.Size = new System.Drawing.Size(110, 13);
            this.lblInternalRuleText.TabIndex = 3;
            this.lblInternalRuleText.Text = "Rules containing Text";
            // 
            // txtInternalRuleText
            // 
            this.txtInternalRuleText.Enabled = false;
            this.txtInternalRuleText.Location = new System.Drawing.Point(123, 44);
            this.txtInternalRuleText.Name = "txtInternalRuleText";
            this.txtInternalRuleText.Size = new System.Drawing.Size(264, 20);
            this.txtInternalRuleText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Run internal Rules";
            // 
            // cmbRunInternal
            // 
            this.cmbRunInternal.FormattingEnabled = true;
            this.cmbRunInternal.Items.AddRange(new object[] {
            "None",
            "All",
            "Active only",
            "Containing Text..."});
            this.cmbRunInternal.Location = new System.Drawing.Point(123, 17);
            this.cmbRunInternal.Name = "cmbRunInternal";
            this.cmbRunInternal.Size = new System.Drawing.Size(121, 21);
            this.cmbRunInternal.TabIndex = 0;
            this.cmbRunInternal.SelectedIndexChanged += new System.EventHandler(this.cmbRunInternal_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblPrimaryRuleFile);
            this.groupBox5.Controls.Add(this.btnOpenJobRuleVault);
            this.groupBox5.Controls.Add(this.txtJobRuleVault);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(579, 125);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Primary Rule File";
            this.toolTip1.SetToolTip(this.groupBox5, "The primary rule runs on Lifecycle transitions, \r\nhaving added this sample as a c" +
        "ustom job.");
            // 
            // lblPrimaryRuleFile
            // 
            this.lblPrimaryRuleFile.AutoSize = true;
            this.lblPrimaryRuleFile.Location = new System.Drawing.Point(6, 20);
            this.lblPrimaryRuleFile.Name = "lblPrimaryRuleFile";
            this.lblPrimaryRuleFile.Size = new System.Drawing.Size(507, 26);
            this.lblPrimaryRuleFile.TabIndex = 4;
            this.lblPrimaryRuleFile.Text = "Jobs queued by lifecycle transitions run the external rule configured below. This" +
    " \"Primary\" rule may behave\r\nlike a master rule and run other rules based on the " +
    "given file type or context.";
            // 
            // btnOpenJobRuleVault
            // 
            this.btnOpenJobRuleVault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenJobRuleVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenJobRuleVault.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.OpenFromVault_16x16;
            this.btnOpenJobRuleVault.Location = new System.Drawing.Point(538, 73);
            this.btnOpenJobRuleVault.Name = "btnOpenJobRuleVault";
            this.btnOpenJobRuleVault.Size = new System.Drawing.Size(35, 26);
            this.btnOpenJobRuleVault.TabIndex = 3;
            this.btnOpenJobRuleVault.UseVisualStyleBackColor = true;
            this.btnOpenJobRuleVault.Click += new System.EventHandler(this.btnOpenJobRuleVault_Click);
            // 
            // txtJobRuleVault
            // 
            this.txtJobRuleVault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobRuleVault.Location = new System.Drawing.Point(6, 77);
            this.txtJobRuleVault.Name = "txtJobRuleVault";
            this.txtJobRuleVault.ReadOnly = true;
            this.txtJobRuleVault.Size = new System.Drawing.Size(526, 20);
            this.txtJobRuleVault.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vault Path";
            // 
            // tabUserRules
            // 
            this.tabUserRules.Controls.Add(this.groupBox7);
            this.tabUserRules.Location = new System.Drawing.Point(4, 30);
            this.tabUserRules.Name = "tabUserRules";
            this.tabUserRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserRules.Size = new System.Drawing.Size(592, 418);
            this.tabUserRules.TabIndex = 3;
            this.tabUserRules.Text = "User Rules";
            this.toolTip1.SetToolTip(this.tabUserRules, "Configure rules available for user interactive iLogic-Job submission.");
            this.tabUserRules.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dtGrdUsrRules);
            this.groupBox7.Controls.Add(this.btnAddUserRules);
            this.groupBox7.Controls.Add(this.btnUserRuleUp);
            this.groupBox7.Controls.Add(this.btnUserRuleDown);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(580, 406);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rules for Interactive Job Submission";
            // 
            // dtGrdUsrRules
            // 
            this.dtGrdUsrRules.AllowUserToAddRows = false;
            this.dtGrdUsrRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdUsrRules.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtGrdUsrRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdUsrRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.UserRuleDispName,
            this.Column3,
            this.UserRulePath});
            this.dtGrdUsrRules.ContextMenuStrip = this.contextMenuStrip2;
            this.dtGrdUsrRules.Location = new System.Drawing.Point(6, 19);
            this.dtGrdUsrRules.Name = "dtGrdUsrRules";
            this.dtGrdUsrRules.RowTemplate.Height = 26;
            this.dtGrdUsrRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdUsrRules.Size = new System.Drawing.Size(536, 381);
            this.dtGrdUsrRules.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.ToolTipText = "Row Order";
            this.Column4.Width = 22;
            // 
            // UserRuleDispName
            // 
            this.UserRuleDispName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UserRuleDispName.FillWeight = 50F;
            this.UserRuleDispName.HeaderText = "Display Name";
            this.UserRuleDispName.Name = "UserRuleDispName";
            this.UserRuleDispName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserRuleDispName.ToolTipText = "Descriptive Name for user selection.";
            this.UserRuleDispName.Width = 70;
            // 
            // Column3
            // 
            this.Column3.FalseValue = "false";
            this.Column3.FillWeight = 10F;
            this.Column3.HeaderText = "Create New File Version";
            this.Column3.Name = "Column3";
            this.Column3.ToolTipText = resources.GetString("Column3.ToolTipText");
            this.Column3.TrueValue = "true";
            // 
            // UserRulePath
            // 
            this.UserRulePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRulePath.FillWeight = 50F;
            this.UserRulePath.HeaderText = "Rule - Full Vault Path";
            this.UserRulePath.Name = "UserRulePath";
            this.UserRulePath.ReadOnly = true;
            this.UserRulePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserRulePath.ToolTipText = "Rule file name and path in Vault.";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "Add Rules...";
            this.toolStripMenuItem1.ToolTipText = "Add Rules for interactive Job selection.";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btnAddUserRules_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.ToolTipText = "Delete selected row(s).";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.mnuUserRulesDelete_Click);
            // 
            // btnAddUserRules
            // 
            this.btnAddUserRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUserRules.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Plus;
            this.btnAddUserRules.Location = new System.Drawing.Point(548, 19);
            this.btnAddUserRules.Name = "btnAddUserRules";
            this.btnAddUserRules.Size = new System.Drawing.Size(26, 26);
            this.btnAddUserRules.TabIndex = 5;
            this.btnAddUserRules.UseVisualStyleBackColor = true;
            this.btnAddUserRules.Click += new System.EventHandler(this.btnAddUserRules_Click);
            // 
            // btnUserRuleUp
            // 
            this.btnUserRuleUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserRuleUp.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Up;
            this.btnUserRuleUp.Location = new System.Drawing.Point(548, 75);
            this.btnUserRuleUp.Name = "btnUserRuleUp";
            this.btnUserRuleUp.Size = new System.Drawing.Size(26, 26);
            this.btnUserRuleUp.TabIndex = 6;
            this.btnUserRuleUp.UseVisualStyleBackColor = true;
            this.btnUserRuleUp.Click += new System.EventHandler(this.btnUserRuleUp_Click);
            // 
            // btnUserRuleDown
            // 
            this.btnUserRuleDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserRuleDown.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Down;
            this.btnUserRuleDown.Location = new System.Drawing.Point(548, 107);
            this.btnUserRuleDown.Name = "btnUserRuleDown";
            this.btnUserRuleDown.Size = new System.Drawing.Size(26, 26);
            this.btnUserRuleDown.TabIndex = 7;
            this.btnUserRuleDown.UseVisualStyleBackColor = true;
            this.btnUserRuleDown.Click += new System.EventHandler(this.btnUserRuleDown_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBox8);
            this.tabOptions.Location = new System.Drawing.Point(4, 30);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(592, 418);
            this.tabOptions.TabIndex = 4;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.chckBoxPropagateItemProps);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.lblPropagateVltProps);
            this.groupBox8.Controls.Add(this.chckBoxPropagateProps);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(586, 181);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Vault Properties";
            // 
            // lblPropagateVltProps
            // 
            this.lblPropagateVltProps.AutoSize = true;
            this.lblPropagateVltProps.Location = new System.Drawing.Point(190, 20);
            this.lblPropagateVltProps.Name = "lblPropagateVltProps";
            this.lblPropagateVltProps.Size = new System.Drawing.Size(367, 65);
            this.lblPropagateVltProps.TabIndex = 9;
            this.lblPropagateVltProps.Text = resources.GetString("lblPropagateVltProps.Text");
            // 
            // chckBoxPropagateProps
            // 
            this.chckBoxPropagateProps.AutoSize = true;
            this.chckBoxPropagateProps.Checked = true;
            this.chckBoxPropagateProps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBoxPropagateProps.Enabled = false;
            this.chckBoxPropagateProps.Location = new System.Drawing.Point(6, 19);
            this.chckBoxPropagateProps.Name = "chckBoxPropagateProps";
            this.chckBoxPropagateProps.Size = new System.Drawing.Size(171, 17);
            this.chckBoxPropagateProps.TabIndex = 8;
            this.chckBoxPropagateProps.Text = "Propagate Vault File Properties";
            this.toolTip1.SetToolTip(this.chckBoxPropagateProps, "Shares all Properties of the processed file as rule arguments.");
            this.chckBoxPropagateProps.UseVisualStyleBackColor = true;
            this.chckBoxPropagateProps.CheckedChanged += new System.EventHandler(this.chckBoxPropagateProps_CheckedChanged);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(12, 470);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 22);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Settings";
            this.toolTip1.SetToolTip(this.btnImport, "Imports the sample settings from [Application Path]\\iLogicJobSettings.xml.");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(12, 491);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 22);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Settings";
            this.toolTip1.SetToolTip(this.btnExport, "Exports the current settings to the file [Application Path]\\iLogicJobSettings.xml" +
        ".");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSaveToVlt
            // 
            this.btnSaveToVlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToVlt.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.CheckIn_32x32;
            this.btnSaveToVlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToVlt.Location = new System.Drawing.Point(492, 470);
            this.btnSaveToVlt.Name = "btnSaveToVlt";
            this.btnSaveToVlt.Size = new System.Drawing.Size(120, 43);
            this.btnSaveToVlt.TabIndex = 3;
            this.btnSaveToVlt.Text = "Save To Vault";
            this.btnSaveToVlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveToVlt.UseVisualStyleBackColor = true;
            this.btnSaveToVlt.Click += new System.EventHandler(this.btnSaveToVlt_Click);
            // 
            // btnLoadFromVlt
            // 
            this.btnLoadFromVlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFromVlt.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.CheckOut_32x32;
            this.btnLoadFromVlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadFromVlt.Location = new System.Drawing.Point(363, 470);
            this.btnLoadFromVlt.Name = "btnLoadFromVlt";
            this.btnLoadFromVlt.Size = new System.Drawing.Size(123, 43);
            this.btnLoadFromVlt.TabIndex = 4;
            this.btnLoadFromVlt.Text = "Load From Vault";
            this.btnLoadFromVlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadFromVlt.UseVisualStyleBackColor = true;
            this.btnLoadFromVlt.Click += new System.EventHandler(this.btnLoadFromVlt_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Folder";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // chckBoxPropagateItemProps
            // 
            this.chckBoxPropagateItemProps.AutoSize = true;
            this.chckBoxPropagateItemProps.Location = new System.Drawing.Point(6, 115);
            this.chckBoxPropagateItemProps.Name = "chckBoxPropagateItemProps";
            this.chckBoxPropagateItemProps.Size = new System.Drawing.Size(175, 17);
            this.chckBoxPropagateItemProps.TabIndex = 10;
            this.chckBoxPropagateItemProps.Text = "Propagate Vault Item Properties";
            this.chckBoxPropagateItemProps.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Option to share all the file\'s Item properties as additional Rule Arguments:\r\nNam" +
    "eValueMap = Item.<Vault Property Name> | <Vault Property Value>.";
            // 
            // iLogicJobAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 525);
            this.Controls.Add(this.btnLoadFromVlt);
            this.Controls.Add(this.btnSaveToVlt);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 564);
            this.Name = "iLogicJobAdminForm";
            this.ShowInTaskbar = false;
            this.Text = "iLogic Configuration";
            this.Load += new System.EventHandler(this.iLogicJobAdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAdvancediLogicConfig.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewExtRls)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabLifecycleRules.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabUserRules.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdUsrRules)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdvancediLogicConfig;
        private System.Windows.Forms.TabPage tabLifecycleRules;
        private System.Windows.Forms.TabPage tabUserRules;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSaveToVlt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLogLevel;
        private System.Windows.Forms.Button btnSelectLogPath;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddInDirSearch;
        private System.Windows.Forms.TextBox txtDLLsDir;
        private System.Windows.Forms.Button btnRuleDirDown;
        private System.Windows.Forms.Button btnRuleDirUp;
        private System.Windows.Forms.Button btnRuleDirAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdViewExtRls;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.CheckBox chckBoxBreak;
        private System.Windows.Forms.Button btnLoadFromVlt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenJobRuleVault;
        private System.Windows.Forms.TextBox txtJobRuleVault;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblInternalRuleText;
        private System.Windows.Forms.TextBox txtInternalRuleText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRunInternal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtGrdUsrRules;
        private System.Windows.Forms.Button btnUserRuleDown;
        private System.Windows.Forms.Button btnUserRuleUp;
        private System.Windows.Forms.Button btnAddUserRules;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExtRuleDirDelete;
        private System.Windows.Forms.Label lblDebugInfo;
        private System.Windows.Forms.ToolStripMenuItem addPathToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRuleDispName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRulePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.Label lblPrimaryRuleFile;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblPropagateVltProps;
        private System.Windows.Forms.CheckBox chckBoxPropagateProps;
        private System.Windows.Forms.CheckBox chckBoxPropagateItemProps;
        private System.Windows.Forms.Label label1;
    }
}