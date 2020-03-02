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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.txtDLLsDir = new System.Windows.Forms.TextBox();
            this.btnRuleDirDown = new System.Windows.Forms.Button();
            this.btnRuleDirUp = new System.Windows.Forms.Button();
            this.btnRuleDirAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdExtRuleDirs = new System.Windows.Forms.DataGridView();
            this.tabJobRules = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpenJobRuleVault = new System.Windows.Forms.Button();
            this.txtJobRuleVault = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dirSearchLogPath = new System.DirectoryServices.DirectorySearcher();
            this.dirSearchAddinDir = new System.DirectoryServices.DirectorySearcher();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtJobRuleExtFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.UserRuleDispName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRulePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtRuleDirsOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtRuleDirsPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabAdvancediLogicConfig.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdExtRuleDirs)).BeginInit();
            this.tabJobRules.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdvancediLogicConfig);
            this.tabControl1.Controls.Add(this.tabJobRules);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabAdvancediLogicConfig.Controls.Add(this.btnRuleDirDown);
            this.tabAdvancediLogicConfig.Controls.Add(this.btnRuleDirUp);
            this.tabAdvancediLogicConfig.Controls.Add(this.btnRuleDirAdd);
            this.tabAdvancediLogicConfig.Controls.Add(this.groupBox1);
            this.tabAdvancediLogicConfig.Location = new System.Drawing.Point(4, 30);
            this.tabAdvancediLogicConfig.Name = "tabAdvancediLogicConfig";
            this.tabAdvancediLogicConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancediLogicConfig.Size = new System.Drawing.Size(592, 418);
            this.tabAdvancediLogicConfig.TabIndex = 0;
            this.tabAdvancediLogicConfig.Text = "iLogic Configuration";
            this.tabAdvancediLogicConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(7, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 87);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Rule Debugging";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Enable Debug Break";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log Level";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(397, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 26);
            this.button8.TabIndex = 3;
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Trace",
            "Debug",
            "Info",
            "Warn",
            "Error",
            "Fatal"});
            this.comboBox1.Location = new System.Drawing.Point(66, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.txtDLLsDir);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "iLogic Addin DLLs Directory";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(397, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 26);
            this.button7.TabIndex = 1;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtDLLsDir
            // 
            this.txtDLLsDir.Location = new System.Drawing.Point(6, 23);
            this.txtDLLsDir.Name = "txtDLLsDir";
            this.txtDLLsDir.Size = new System.Drawing.Size(381, 20);
            this.txtDLLsDir.TabIndex = 0;
            // 
            // btnRuleDirDown
            // 
            this.btnRuleDirDown.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Down;
            this.btnRuleDirDown.Location = new System.Drawing.Point(452, 113);
            this.btnRuleDirDown.Name = "btnRuleDirDown";
            this.btnRuleDirDown.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirDown.TabIndex = 3;
            this.btnRuleDirDown.UseVisualStyleBackColor = true;
            // 
            // btnRuleDirUp
            // 
            this.btnRuleDirUp.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Up;
            this.btnRuleDirUp.Location = new System.Drawing.Point(452, 81);
            this.btnRuleDirUp.Name = "btnRuleDirUp";
            this.btnRuleDirUp.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirUp.TabIndex = 2;
            this.btnRuleDirUp.UseVisualStyleBackColor = true;
            // 
            // btnRuleDirAdd
            // 
            this.btnRuleDirAdd.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Plus;
            this.btnRuleDirAdd.Location = new System.Drawing.Point(452, 25);
            this.btnRuleDirAdd.Name = "btnRuleDirAdd";
            this.btnRuleDirAdd.Size = new System.Drawing.Size(26, 26);
            this.btnRuleDirAdd.TabIndex = 1;
            this.btnRuleDirAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrdExtRuleDirs);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External Rule Directories";
            // 
            // dtgrdExtRuleDirs
            // 
            this.dtgrdExtRuleDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdExtRuleDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExtRuleDirsOrder,
            this.ExtRuleDirsPath});
            this.dtgrdExtRuleDirs.Location = new System.Drawing.Point(6, 19);
            this.dtgrdExtRuleDirs.Name = "dtgrdExtRuleDirs";
            this.dtgrdExtRuleDirs.Size = new System.Drawing.Size(432, 135);
            this.dtgrdExtRuleDirs.TabIndex = 0;
            // 
            // tabJobRules
            // 
            this.tabJobRules.Controls.Add(this.groupBox6);
            this.tabJobRules.Controls.Add(this.groupBox5);
            this.tabJobRules.Location = new System.Drawing.Point(4, 30);
            this.tabJobRules.Name = "tabJobRules";
            this.tabJobRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobRules.Size = new System.Drawing.Size(592, 418);
            this.tabJobRules.TabIndex = 2;
            this.tabJobRules.Text = "Job Rules Options";
            this.tabJobRules.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.txtJobRuleExtFile);
            this.groupBox5.Controls.Add(this.btnOpenJobRuleVault);
            this.groupBox5.Controls.Add(this.txtJobRuleVault);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(579, 172);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "External Job Rule";
            // 
            // btnOpenJobRuleVault
            // 
            this.btnOpenJobRuleVault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenJobRuleVault.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.OpenFromVault_16x16;
            this.btnOpenJobRuleVault.Location = new System.Drawing.Point(397, 40);
            this.btnOpenJobRuleVault.Name = "btnOpenJobRuleVault";
            this.btnOpenJobRuleVault.Size = new System.Drawing.Size(35, 26);
            this.btnOpenJobRuleVault.TabIndex = 3;
            this.btnOpenJobRuleVault.UseVisualStyleBackColor = true;
            // 
            // txtJobRuleVault
            // 
            this.txtJobRuleVault.Location = new System.Drawing.Point(6, 44);
            this.txtJobRuleVault.Name = "txtJobRuleVault";
            this.txtJobRuleVault.Size = new System.Drawing.Size(381, 20);
            this.txtJobRuleVault.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Primary Job Rule - Vault";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 418);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "User Rules Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import Settings...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export Settings...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.CheckIn_32x32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(492, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save To Vault";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dirSearchLogPath
            // 
            this.dirSearchLogPath.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.dirSearchLogPath.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dirSearchLogPath.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dirSearchAddinDir
            // 
            this.dirSearchAddinDir.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.dirSearchAddinDir.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dirSearchAddinDir.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button9
            // 
            this.button9.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.CheckOut_32x32;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(363, 470);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 43);
            this.button9.TabIndex = 4;
            this.button9.Text = "Load From Vault";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(397, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtJobRuleExtFile
            // 
            this.txtJobRuleExtFile.Location = new System.Drawing.Point(6, 99);
            this.txtJobRuleExtFile.Name = "txtJobRuleExtFile";
            this.txtJobRuleExtFile.Size = new System.Drawing.Size(381, 20);
            this.txtJobRuleExtFile.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alternate Job Rule - Rule Name, located in iLogic External Rule Directory or Job " +
    "Extension Folder";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(204, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Propagate properties of processed file";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Location = new System.Drawing.Point(7, 186);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(579, 79);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Internal Rules";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "All",
            "Active only",
            "Containing Text..."});
            this.comboBox2.Location = new System.Drawing.Point(123, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(123, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rules containing Text";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(580, 406);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Rules for Interactive Job Submission";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserRuleDispName,
            this.UserRulePath});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(536, 381);
            this.dataGridView1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Down;
            this.button5.Location = new System.Drawing.Point(548, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 26);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Up;
            this.button6.Location = new System.Drawing.Point(548, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 26);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.iLogic_Plus;
            this.button10.Location = new System.Drawing.Point(548, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 26);
            this.button10.TabIndex = 5;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // UserRuleDispName
            // 
            this.UserRuleDispName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserRuleDispName.HeaderText = "Display Name";
            this.UserRuleDispName.Name = "UserRuleDispName";
            this.UserRuleDispName.ToolTipText = "Descriptive Name for user selection.";
            this.UserRuleDispName.Width = 97;
            // 
            // UserRulePath
            // 
            this.UserRulePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRulePath.HeaderText = "Rule - Full Vault Path";
            this.UserRulePath.Name = "UserRulePath";
            this.UserRulePath.ReadOnly = true;
            this.UserRulePath.ToolTipText = "Rule file name and path in Vault.";
            // 
            // ExtRuleDirsOrder
            // 
            this.ExtRuleDirsOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExtRuleDirsOrder.HeaderText = "Order";
            this.ExtRuleDirsOrder.Name = "ExtRuleDirsOrder";
            this.ExtRuleDirsOrder.ReadOnly = true;
            this.ExtRuleDirsOrder.Width = 58;
            // 
            // ExtRuleDirsPath
            // 
            this.ExtRuleDirsPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExtRuleDirsPath.HeaderText = "Path";
            this.ExtRuleDirsPath.Name = "ExtRuleDirsPath";
            // 
            // iLogicJobAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 525);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iLogicJobAdminForm";
            this.ShowInTaskbar = false;
            this.Text = "iLogic Configuration";
            this.toolTip1.SetToolTip(this, "Select *.ilogicVb rule file from Vault");
            this.tabControl1.ResumeLayout(false);
            this.tabAdvancediLogicConfig.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdExtRuleDirs)).EndInit();
            this.tabJobRules.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdvancediLogicConfig;
        private System.Windows.Forms.TabPage tabJobRules;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtDLLsDir;
        private System.Windows.Forms.Button btnRuleDirDown;
        private System.Windows.Forms.Button btnRuleDirUp;
        private System.Windows.Forms.Button btnRuleDirAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrdExtRuleDirs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.DirectoryServices.DirectorySearcher dirSearchLogPath;
        private System.DirectoryServices.DirectorySearcher dirSearchAddinDir;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenJobRuleVault;
        private System.Windows.Forms.TextBox txtJobRuleVault;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtJobRuleExtFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtRuleDirsOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtRuleDirsPath;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRuleDispName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRulePath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
    }
}