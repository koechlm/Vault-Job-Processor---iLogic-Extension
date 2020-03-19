namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    partial class SelectFromVault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFromVault));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lookIn_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vaultNavigationPathComboboxControl1 = new Autodesk.DataManagement.Client.Framework.Vault.Forms.Controls.VaultNavigationPathComboboxControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.navigateBack_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.navigateUp_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.switchView_toolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.vaultBrowserControl1 = new Autodesk.DataManagement.Client.Framework.Vault.Forms.Controls.VaultBrowserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName_multiPartTextBox = new Autodesk.DataManagement.Client.Framework.Forms.Controls.MultiPartTextBoxControl();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(713, 415);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Select.Enabled = false;
            this.btn_Select.Location = new System.Drawing.Point(632, 415);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // lookIn_label
            // 
            this.lookIn_label.AutoSize = true;
            this.lookIn_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookIn_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lookIn_label.Location = new System.Drawing.Point(2, 0);
            this.lookIn_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lookIn_label.Name = "lookIn_label";
            this.lookIn_label.Size = new System.Drawing.Size(84, 32);
            this.lookIn_label.TabIndex = 1;
            this.lookIn_label.Text = "Look in:";
            this.lookIn_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lookIn_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vaultNavigationPathComboboxControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.vaultBrowserControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileName_multiPartTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFileType, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // vaultNavigationPathComboboxControl1
            // 
            this.vaultNavigationPathComboboxControl1.AutoSize = true;
            this.vaultNavigationPathComboboxControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.vaultNavigationPathComboboxControl1, 2);
            this.vaultNavigationPathComboboxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultNavigationPathComboboxControl1.Location = new System.Drawing.Point(91, 3);
            this.vaultNavigationPathComboboxControl1.Name = "vaultNavigationPathComboboxControl1";
            this.vaultNavigationPathComboboxControl1.Size = new System.Drawing.Size(601, 26);
            this.vaultNavigationPathComboboxControl1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateBack_toolStripButton,
            this.navigateUp_toolStripButton,
            this.switchView_toolStripSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(695, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // navigateBack_toolStripButton
            // 
            this.navigateBack_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigateBack_toolStripButton.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.Back_16;
            this.navigateBack_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.navigateBack_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigateBack_toolStripButton.Name = "navigateBack_toolStripButton";
            this.navigateBack_toolStripButton.Size = new System.Drawing.Size(23, 29);
            this.navigateBack_toolStripButton.Text = "Back";
            this.navigateBack_toolStripButton.Click += new System.EventHandler(this.navigateBack_toolStripButton_Click);
            // 
            // navigateUp_toolStripButton
            // 
            this.navigateUp_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigateUp_toolStripButton.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.uplevel_16;
            this.navigateUp_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigateUp_toolStripButton.Name = "navigateUp_toolStripButton";
            this.navigateUp_toolStripButton.Size = new System.Drawing.Size(23, 29);
            this.navigateUp_toolStripButton.Text = "Up";
            this.navigateUp_toolStripButton.Click += new System.EventHandler(this.navigateUp_toolStripButton_Click);
            // 
            // switchView_toolStripSplitButton
            // 
            this.switchView_toolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.switchView_toolStripSplitButton.Image = global::Autodesk.VltInvSrv.iLogicSampleJob.Properties.Resources.ViewOptions_16;
            this.switchView_toolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switchView_toolStripSplitButton.Name = "switchView_toolStripSplitButton";
            this.switchView_toolStripSplitButton.Size = new System.Drawing.Size(32, 29);
            this.switchView_toolStripSplitButton.Text = "Switch View";
            this.switchView_toolStripSplitButton.ButtonClick += new System.EventHandler(this.switchView_toolStripSplitButton_ButtonClick);
            this.switchView_toolStripSplitButton.DropDownOpening += new System.EventHandler(this.switchView_toolStripSplitButton_DropDownOpening);
            // 
            // vaultBrowserControl1
            // 
            this.vaultBrowserControl1.AllowFindPanel = true;
            this.vaultBrowserControl1.AutoSize = true;
            this.vaultBrowserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.vaultBrowserControl1, 3);
            this.vaultBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultBrowserControl1.Location = new System.Drawing.Point(91, 35);
            this.vaultBrowserControl1.Name = "vaultBrowserControl1";
            this.vaultBrowserControl1.Size = new System.Drawing.Size(682, 270);
            this.vaultBrowserControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected File(s):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileName_multiPartTextBox
            // 
            this.fileName_multiPartTextBox.AutoSize = true;
            this.fileName_multiPartTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileName_multiPartTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileName_multiPartTextBox.EditMode = Autodesk.DataManagement.Client.Framework.Forms.Controls.MultiPartTextBoxControl.EditModeOption.FullEdit;
            this.fileName_multiPartTextBox.Location = new System.Drawing.Point(91, 311);
            this.fileName_multiPartTextBox.Name = "fileName_multiPartTextBox";
            this.fileName_multiPartTextBox.Parts = ((System.Collections.Generic.IEnumerable<string>)(resources.GetObject("fileName_multiPartTextBox.Parts")));
            this.fileName_multiPartTextBox.Size = new System.Drawing.Size(551, 22);
            this.fileName_multiPartTextBox.TabIndex = 6;
            // 
            // txtFileType
            // 
            this.txtFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtFileType, 2);
            this.txtFileType.Location = new System.Drawing.Point(648, 311);
            this.txtFileType.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.ReadOnly = true;
            this.txtFileType.Size = new System.Drawing.Size(125, 20);
            this.txtFileType.TabIndex = 7;
            // 
            // SelectFromVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SelectFromVault";
            this.Text = "Select From Vault...";
            this.Shown += new System.EventHandler(this.SelectFromVault_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label lookIn_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DataManagement.Client.Framework.Vault.Forms.Controls.VaultNavigationPathComboboxControl vaultNavigationPathComboboxControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton navigateBack_toolStripButton;
        private System.Windows.Forms.ToolStripButton navigateUp_toolStripButton;
        private System.Windows.Forms.ToolStripSplitButton switchView_toolStripSplitButton;
        private DataManagement.Client.Framework.Vault.Forms.Controls.VaultBrowserControl vaultBrowserControl1;
        private DataManagement.Client.Framework.Forms.Controls.MultiPartTextBoxControl fileName_multiPartTextBox;
        private System.Windows.Forms.TextBox txtFileType;
    }
}