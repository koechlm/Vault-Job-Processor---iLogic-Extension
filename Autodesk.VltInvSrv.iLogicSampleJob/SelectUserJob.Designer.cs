namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    partial class SelectUserJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUserJob));
            this.dtGrdUsrRules = new System.Windows.Forms.DataGridView();
            this.UserRuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRuleDispName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRuleNewFileIter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserRulePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SelectUsrJob_Cancel = new System.Windows.Forms.Button();
            this.btn_SelectUserJob_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdUsrRules)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdUsrRules
            // 
            this.dtGrdUsrRules.AllowUserToAddRows = false;
            this.dtGrdUsrRules.AllowUserToDeleteRows = false;
            this.dtGrdUsrRules.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtGrdUsrRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdUsrRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserRuleId,
            this.UserRuleDispName,
            this.UserRuleNewFileIter,
            this.UserRulePath});
            this.dtGrdUsrRules.Location = new System.Drawing.Point(12, 12);
            this.dtGrdUsrRules.MultiSelect = false;
            this.dtGrdUsrRules.Name = "dtGrdUsrRules";
            this.dtGrdUsrRules.RowTemplate.Height = 26;
            this.dtGrdUsrRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdUsrRules.Size = new System.Drawing.Size(776, 376);
            this.dtGrdUsrRules.TabIndex = 5;
            this.dtGrdUsrRules.SelectionChanged += new System.EventHandler(this.dtGrdUsrRules_SelectionChanged);
            // 
            // UserRuleId
            // 
            this.UserRuleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserRuleId.HeaderText = "Id";
            this.UserRuleId.Name = "UserRuleId";
            this.UserRuleId.ReadOnly = true;
            this.UserRuleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserRuleId.ToolTipText = "Row Order";
            this.UserRuleId.Width = 22;
            // 
            // UserRuleDispName
            // 
            this.UserRuleDispName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRuleDispName.FillWeight = 20.25F;
            this.UserRuleDispName.HeaderText = "Display Name";
            this.UserRuleDispName.Name = "UserRuleDispName";
            this.UserRuleDispName.ReadOnly = true;
            this.UserRuleDispName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserRuleDispName.ToolTipText = "Descriptive Name for user selection.";
            // 
            // UserRuleNewFileIter
            // 
            this.UserRuleNewFileIter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRuleNewFileIter.FalseValue = "false";
            this.UserRuleNewFileIter.FillWeight = 10F;
            this.UserRuleNewFileIter.HeaderText = "Create New File Version";
            this.UserRuleNewFileIter.Name = "UserRuleNewFileIter";
            this.UserRuleNewFileIter.ReadOnly = true;
            this.UserRuleNewFileIter.ToolTipText = resources.GetString("UserRuleNewFileIter.ToolTipText");
            this.UserRuleNewFileIter.TrueValue = "true";
            // 
            // UserRulePath
            // 
            this.UserRulePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRulePath.FillWeight = 60F;
            this.UserRulePath.HeaderText = "Rule - Full Vault Path";
            this.UserRulePath.Name = "UserRulePath";
            this.UserRulePath.ReadOnly = true;
            this.UserRulePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserRulePath.ToolTipText = "Rule file name and path in Vault.";
            // 
            // btn_SelectUsrJob_Cancel
            // 
            this.btn_SelectUsrJob_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SelectUsrJob_Cancel.Location = new System.Drawing.Point(713, 415);
            this.btn_SelectUsrJob_Cancel.Name = "btn_SelectUsrJob_Cancel";
            this.btn_SelectUsrJob_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectUsrJob_Cancel.TabIndex = 6;
            this.btn_SelectUsrJob_Cancel.Text = "Cancel";
            this.btn_SelectUsrJob_Cancel.UseVisualStyleBackColor = true;
            this.btn_SelectUsrJob_Cancel.Click += new System.EventHandler(this.btn_SelectUsrJob_Cancel_Click);
            // 
            // btn_SelectUserJob_Submit
            // 
            this.btn_SelectUserJob_Submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_SelectUserJob_Submit.Enabled = false;
            this.btn_SelectUserJob_Submit.Location = new System.Drawing.Point(599, 415);
            this.btn_SelectUserJob_Submit.Name = "btn_SelectUserJob_Submit";
            this.btn_SelectUserJob_Submit.Size = new System.Drawing.Size(108, 23);
            this.btn_SelectUserJob_Submit.TabIndex = 7;
            this.btn_SelectUserJob_Submit.Text = "Submit to Queue";
            this.btn_SelectUserJob_Submit.UseVisualStyleBackColor = true;
            this.btn_SelectUserJob_Submit.Click += new System.EventHandler(this.btn_SelectUserJob_Submit_Click);
            // 
            // SelectUserJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SelectUsrJob_Cancel);
            this.Controls.Add(this.btn_SelectUserJob_Submit);
            this.Controls.Add(this.dtGrdUsrRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SelectUserJob";
            this.Text = "Select Job...";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdUsrRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdUsrRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRuleDispName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UserRuleNewFileIter;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRulePath;
        private System.Windows.Forms.Button btn_SelectUsrJob_Cancel;
        private System.Windows.Forms.Button btn_SelectUserJob_Submit;
    }
}