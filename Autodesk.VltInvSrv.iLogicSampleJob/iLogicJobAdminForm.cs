using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VDF = Autodesk.DataManagement.Client.Framework;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Entities;
using System.Collections;

namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    public partial class iLogicJobAdminForm : Form
    {
        int rowIndex;
        public string mVaultSelected
        {
            get;
            private set;
        }


        public iLogicJobAdminForm()
        {
            InitializeComponent();

            lblDebugInfo.Visible = false;
        }

        private void iLogicJobAdminForm_Load(object sender, EventArgs e)
        {
            //Read current configuration data from Vault or settings file
            bool success = mLoadFromVault();

            if (success)
            {
                //MessageBox.Show("Successfully loaded settings from Vault.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iLogicJobAdmin.mSettingsChanged = false;
                btnSaveToVlt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Could not load settings from Vault.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Settings mActiveSettings = new Settings();
            //iLogic options tab
            mActiveSettings.ExternalRuleDirectories = mGetExtRuleDirs();
            mActiveSettings.iLogicAddinDLLs = txtDLLsDir.Text;
            mActiveSettings.iLogicLogLevel = cmbLogLevel.Text;
            mActiveSettings.iLogicLogDir = txtLogPath.Text;
            mActiveSettings.ActivateDebugBreak = chckBoxBreak.Checked.ToString();
            //job rules options tab
            mActiveSettings.VaultRuleFullFileName = txtJobRuleVault.Text;
            mActiveSettings.PropagateProps = chckBoxPropagateProps.Checked.ToString();
            mActiveSettings.PropagateItemProps = chckBoxPropagateItemProps.Checked.ToString();
            mActiveSettings.InternalRulesOption = cmbRunInternal.Text;
            mActiveSettings.InternalRulesOptiontext = txtInternalRuleText.Text;
            mActiveSettings.UseInvApp = chckInvApp.Checked.ToString();
            //user rules tab
            mActiveSettings.UserRules = mGetUserRules();

            bool mExpSuccess = mActiveSettings.Save();
            if (mExpSuccess == true)
            {
                MessageBox.Show("Successfully exported settings to local file.", "Configuration Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Export settings to local file failed. Check the permissions Vault Extensions folder.", "Configuration Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string[] mGetExtRuleDirs()
        {
            string[] mDirs = new string[dtgrdViewExtRls.Rows.Count];

            for (int i = 0; i < dtgrdViewExtRls.Rows.Count; i++)
            {
                if (dtgrdViewExtRls.Rows[i].Cells[1].Value != null)
                {
                    mDirs[i] = dtgrdViewExtRls.Rows[i].Cells[1].Value.ToString();
                }
            }
            return mDirs;
        }

        private string[] mGetUserRules()
        {
            string[] mRules = new string[dtGrdUsrRules.RowCount];
            for (int i = 0; i < dtGrdUsrRules.Rows.Count; i++)
            {
                if (dtGrdUsrRules.Rows[i].Cells[1].Value != null)
                {
                    mRules[i] = dtGrdUsrRules.Rows[i].Cells[1].Value.ToString() + "|"
                        + dtGrdUsrRules.Rows[i].Cells[2].Value.ToString() + "|"
                        + dtGrdUsrRules.Rows[i].Cells[3].Value.ToString() + "|"
                        + dtGrdUsrRules.Rows[i].Cells[4].Value.ToString();
                }
            }
            return mRules;
        }

        private void cmbLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLogLevel.Text != "None")
            {
                lblLogPath.Enabled = true;
                txtLogPath.Enabled = true;
                btnSelectLogPath.Enabled = true;
            }
            else
            {
                lblLogPath.Enabled = false;
                txtLogPath.Enabled = false;
                btnSelectLogPath.Enabled = false;
            }
            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void cmbRunInternal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRunInternal.Text == "Containing Text...")
            {
                txtInternalRuleText.Enabled = true;
                lblInternalRuleText.Enabled = true;
            }
            else
            {
                txtInternalRuleText.Enabled = false;
                lblInternalRuleText.Enabled = false;
            }
            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void btnAddInDirSearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Directory for iLogic Extensions...";
            folderBrowserDialog1.ShowDialog();
            txtDLLsDir.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();

            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void btnSelectLogPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Directory for iLogic Log-Files...";
            folderBrowserDialog1.ShowDialog();
            txtLogPath.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();

            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void btnRuleDirAdd_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Directory for External iLogic-Rules...";
            folderBrowserDialog1.ShowDialog();

            dtgrdViewExtRls.Rows.Add(new string[] { dtgrdViewExtRls.Rows.Count.ToString(), folderBrowserDialog1.SelectedPath });

            mRenumber(dtgrdViewExtRls);

            folderBrowserDialog1.Dispose();

            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void mnuExtRuleDirDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedCellCollection mSelCells = dtgrdViewExtRls.SelectedCells;
                DataGridViewSelectedRowCollection mSelRows = dtgrdViewExtRls.SelectedRows;
                foreach (DataGridViewRow item in mSelRows)
                {
                    if (dtgrdViewExtRls.Rows.Count > 1 && item.IsNewRow != true)
                    {
                        dtgrdViewExtRls.Rows.Remove(item);
                    }
                }
                mRenumber(dtgrdViewExtRls);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            { }

        }

        private void btnRuleDirUp_Click(object sender, EventArgs e)
        {
            try
            {
                rowIndex = dtgrdViewExtRls.SelectedCells[0].OwningRow.Index;
                if (rowIndex > 0)
                {
                    DataGridViewRow mRow = (DataGridViewRow)dtgrdViewExtRls.Rows[rowIndex].Clone();
                    mRow.Cells[0].Value = dtgrdViewExtRls.Rows[rowIndex].Cells[0].Value.ToString();
                    mRow.Cells[1].Value = dtgrdViewExtRls.Rows[rowIndex].Cells[1].Value.ToString();
                    dtgrdViewExtRls.Rows.RemoveAt(rowIndex);
                    dtgrdViewExtRls.Rows.Insert(rowIndex - 1, mRow);
                    foreach (DataGridViewRow row in dtgrdViewExtRls.Rows)
                    {
                        row.Selected = false;
                    }
                    //dtgrdViewExtRls.Rows[rowIndex - 1].Selected = true;
                }
                mRenumber(dtgrdViewExtRls);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            {
                //the exception occurs, if the user did not select a cell or row; continue without message
            }
        }

        private void btnRuleDirDown_Click(object sender, EventArgs e)
        {
            try
            {
                rowIndex = dtgrdViewExtRls.SelectedCells[0].OwningRow.Index;
                if (rowIndex < dtgrdViewExtRls.Rows.Count - 1)
                {
                    DataGridViewRow mRow = (DataGridViewRow)dtgrdViewExtRls.Rows[rowIndex].Clone();
                    mRow.Cells[0].Value = dtgrdViewExtRls.Rows[rowIndex].Cells[0].Value.ToString();
                    mRow.Cells[1].Value = dtgrdViewExtRls.Rows[rowIndex].Cells[1].Value.ToString();
                    dtgrdViewExtRls.Rows.RemoveAt(rowIndex);
                    dtgrdViewExtRls.Rows.Insert(rowIndex + 1, mRow);
                    foreach (DataGridViewRow row in dtgrdViewExtRls.Rows)
                    {
                        row.Selected = false;
                    }
                    //dtgrdViewExtRls.Rows[rowIndex + 1].Selected = true;
                }
                mRenumber(dtgrdViewExtRls);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            {
                //the exception occurs, if the user did not select a cell or row; continue without message
            }

        }

        private void mRenumber(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                Settings mNewSettings = Settings.Load();

                //iLogic options tab
                mUpdateExtRlsGrid(mNewSettings.ExternalRuleDirectories);
                txtDLLsDir.Text = mNewSettings.iLogicAddinDLLs;
                cmbLogLevel.Text = mNewSettings.iLogicLogLevel;
                txtLogPath.Text = mNewSettings.iLogicLogDir;
                if (mNewSettings.ActivateDebugBreak == "True")
                {
                    chckBoxBreak.Checked = true;
                }
                else
                {
                    chckBoxBreak.Checked = false;
                }

                //job rules tab
                txtJobRuleVault.Text = mNewSettings.VaultRuleFullFileName;
                cmbRunInternal.Text = mNewSettings.InternalRulesOption;
                txtInternalRuleText.Text = mNewSettings.InternalRulesOptiontext;
                if (mNewSettings.UseInvApp == "True")
                {
                    chckInvApp.Checked = true;
                }
                else
                {
                    chckInvApp.Checked = false;
                }

                //user rules tab
                mUpdateUsrRlsGrid(mNewSettings.UserRules);

                //options tab
                if (mNewSettings.PropagateProps == "True")
                {
                    chckBoxPropagateProps.Checked = true;
                }
                else
                {
                    chckBoxPropagateProps.Checked = false;
                }

                if (mNewSettings.PropagateItemProps == "True")
                {
                    chckBoxPropagateItemProps.Checked = true;
                }
                else
                {
                    chckBoxPropagateItemProps.Checked = false;
                }

                MessageBox.Show("Successfully imported settings.", "Configuration Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not import settings. Check the permissions Vault Extensions folder.", "Configuration Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mUpdateExtRlsGrid(string[] mExtRls)
        {
            //clear existing Data
            dtgrdViewExtRls.Rows.Clear();
            //write settings
            for (int i = 0; i < mExtRls.Count(); i++)
            {
                dtgrdViewExtRls.Rows.Add(new string[] { (i + 1).ToString(), mExtRls[i] });
            }
        }

        private void mUpdateUsrRlsGrid(string[] mUsrRls)
        {
            //clear existing Data
            dtGrdUsrRules.Rows.Clear();
            //write settings
            string[] mRow = null;
            for (int i = 0; i < mUsrRls.Count(); i++)
            {
                mRow = mUsrRls[i].Split('|');
                dtGrdUsrRules.Rows.Add(new string[] { (i + 1).ToString(), mRow[0], mRow[1], mRow[2], mRow[3] });
            }
            mRenumber(dtGrdUsrRules);
        }

        private void btnOpenJobRuleVault_Click(object sender, EventArgs e)
        {
            SelectFromVault selectFromVault = new SelectFromVault(Multiselect: false);
            var returnval = selectFromVault.ShowDialog();
            if (selectFromVault.DialogResult == DialogResult.OK)
            {
                txtJobRuleVault.Text = selectFromVault.RetFullNames.FirstOrDefault();
                
                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
                
                selectFromVault.Dispose();
            }
        }

        private void btnAddUserRules_Click(object sender, EventArgs e)
        {
            List<string> mUserRules = new List<string>();
            SelectFromVault selectFromVault = new SelectFromVault(Multiselect: true);
            var returnval = selectFromVault.ShowDialog();
            if (selectFromVault.DialogResult == DialogResult.OK)
            {
                for (int i = 0; i < selectFromVault.RetFullNames.Count; i++)
                {
                    dtGrdUsrRules.Rows.Add(new string[] { "", selectFromVault.RetNames[i], "false", "false", selectFromVault.RetFullNames[i] });
                }
                mRenumber(dtGrdUsrRules);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;

                selectFromVault.Dispose();
            }
        }

        private void mnuUserRulesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedCellCollection mSelCells = dtGrdUsrRules.SelectedCells;
                DataGridViewSelectedRowCollection mSelRows = dtGrdUsrRules.SelectedRows;
                foreach (DataGridViewRow item in mSelRows)
                {
                    if (dtGrdUsrRules.Rows.Count > 1 && item.IsNewRow != true)
                    {
                        dtGrdUsrRules.Rows.Remove(item);
                    }
                }
                mRenumber(dtGrdUsrRules);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            { }
        }

        private void btnUserRuleUp_Click(object sender, EventArgs e)
        {
            try
            {
                rowIndex = dtGrdUsrRules.SelectedCells[0].OwningRow.Index;
                if (rowIndex > 0)
                {
                    dtGrdUsrRules.Rows[rowIndex].Selected = false;
                    DataGridViewRow mRow = (DataGridViewRow)dtGrdUsrRules.Rows[rowIndex].Clone();
                    mRow.Cells[0].Value = dtGrdUsrRules.Rows[rowIndex].Cells[0].Value.ToString();
                    mRow.Cells[1].Value = dtGrdUsrRules.Rows[rowIndex].Cells[1].Value.ToString();
                    mRow.Cells[2].Value = dtGrdUsrRules.Rows[rowIndex].Cells[2].Value.ToString();
                    mRow.Cells[3].Value = dtGrdUsrRules.Rows[rowIndex].Cells[3].Value.ToString();
                    mRow.Cells[4].Value = dtGrdUsrRules.Rows[rowIndex].Cells[4].Value.ToString();
                    dtGrdUsrRules.Rows.RemoveAt(rowIndex);
                    dtGrdUsrRules.Rows.Insert(rowIndex - 1, mRow);
                    foreach (DataGridViewRow row in dtGrdUsrRules.Rows)
                    {
                        row.Selected = false;
                    }
                    //dtGrdUsrRules.Rows[rowIndex - 1].Selected = true;
                }

                mRenumber(dtGrdUsrRules);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            { }

        }

        private void btnUserRuleDown_Click(object sender, EventArgs e)
        {
            try
            {
                rowIndex = dtGrdUsrRules.SelectedCells[0].OwningRow.Index;
                if (rowIndex < dtGrdUsrRules.Rows.Count - 1)
                {
                    DataGridViewRow mRow = (DataGridViewRow)dtGrdUsrRules.Rows[rowIndex].Clone();
                    mRow.Cells[0].Value = dtGrdUsrRules.Rows[rowIndex].Cells[0].Value.ToString();
                    mRow.Cells[1].Value = dtGrdUsrRules.Rows[rowIndex].Cells[1].Value.ToString();
                    mRow.Cells[2].Value = dtGrdUsrRules.Rows[rowIndex].Cells[2].Value.ToString();
                    mRow.Cells[3].Value = dtGrdUsrRules.Rows[rowIndex].Cells[3].Value.ToString();
                    mRow.Cells[4].Value = dtGrdUsrRules.Rows[rowIndex].Cells[4].Value.ToString();
                    dtGrdUsrRules.Rows.RemoveAt(rowIndex);
                    dtGrdUsrRules.Rows.Insert(rowIndex + 1, mRow);
                    foreach (DataGridViewRow row in dtGrdUsrRules.Rows)
                    {
                        row.Selected = false;
                    }
                }

                mRenumber(dtGrdUsrRules);

                iLogicJobAdmin.mSettingsChanged = true;
                btnSaveToVlt.Enabled = true;
            }
            catch (Exception)
            { }

        }

        private void chckBoxBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxBreak.Checked == true)
            {
                lblDebugInfo.Visible = true;
            }
            else
            {
                lblDebugInfo.Visible = false;
            }

            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void btnSaveToVlt_Click(object sender, EventArgs e)
        {
            mSaveToVault();
        }

        private void mSaveToVault()
        {
            Settings mActiveSettings = new Settings();
            //iLogic options tab
            mActiveSettings.ExternalRuleDirectories = mGetExtRuleDirs();
            mActiveSettings.iLogicAddinDLLs = txtDLLsDir.Text;
            mActiveSettings.iLogicLogLevel = cmbLogLevel.Text;
            mActiveSettings.iLogicLogDir = txtLogPath.Text;
            mActiveSettings.ActivateDebugBreak = chckBoxBreak.Checked.ToString();
            //job rules options tab
            mActiveSettings.VaultRuleFullFileName = txtJobRuleVault.Text;
            mActiveSettings.PropagateProps = chckBoxPropagateProps.Checked.ToString();
            mActiveSettings.InternalRulesOption = cmbRunInternal.Text;
            mActiveSettings.InternalRulesOptiontext = txtInternalRuleText.Text;
            mActiveSettings.UseInvApp = chckInvApp.Checked.ToString();
            //user rules tab
            mActiveSettings.UserRules = mGetUserRules();

            bool mExpSuccess = mActiveSettings.SaveToVault(iLogicJobAdmin.mConnection);
            if (mExpSuccess == true)
            {
                MessageBox.Show("Successfully saved settings to Vault.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                iLogicJobAdmin.mSettingsChanged = false;
                btnSaveToVlt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving settings to Vault failed.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromVlt_Click(object sender, EventArgs e)
        {

            var retval = MessageBox.Show("Loading settings from Vault will overwrite all current configuration settings.\n\r Press OK to load, press Cancel to keep current settings.", "iLogic Configuration", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (retval == DialogResult.Cancel)
            {
                return;
            }

            bool success = mLoadFromVault();

            if (success)
            {
                MessageBox.Show("Successfully loaded settings from Vault.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                iLogicJobAdmin.mSettingsChanged = false;
                btnSaveToVlt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Could not load settings from Vault.", "iLogic Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool mLoadFromVault()
        {
            try
            {
                Settings mNewSettings = Settings.LoadFromVault(iLogicJobAdmin.mConnection);

                //iLogic options tab
                mUpdateExtRlsGrid(mNewSettings.ExternalRuleDirectories);
                txtDLLsDir.Text = mNewSettings.iLogicAddinDLLs;
                cmbLogLevel.Text = mNewSettings.iLogicLogLevel;
                txtLogPath.Text = mNewSettings.iLogicLogDir;
                if (mNewSettings.ActivateDebugBreak == "True")
                {
                    chckBoxBreak.Checked = true;
                }
                else
                {
                    chckBoxBreak.Checked = false;
                }

                //job rules options tab
                txtJobRuleVault.Text = mNewSettings.VaultRuleFullFileName;
                cmbRunInternal.Text = mNewSettings.InternalRulesOption;
                txtInternalRuleText.Text = mNewSettings.InternalRulesOptiontext;
                if (mNewSettings.UseInvApp == "True")
                {
                    chckInvApp.Checked = true;
                }
                else
                {
                    chckInvApp.Checked = false;
                }

                //user rules tab
                mUpdateUsrRlsGrid(mNewSettings.UserRules);

                //options tab
                if (mNewSettings.PropagateProps == "True")
                {
                    chckBoxPropagateProps.Checked = true;
                }
                else
                {
                    chckBoxPropagateProps.Checked = false;
                }

                if (mNewSettings.PropagateItemProps == "True")
                {
                    chckBoxPropagateItemProps.Checked = true;
                }
                else
                {
                    chckBoxPropagateItemProps.Checked = false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void mConfigChanged(object sender, EventArgs e)
        {
            iLogicJobAdmin.mSettingsChanged = true;
            btnSaveToVlt.Enabled = true;
        }

        private void iLogicJobAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iLogicJobAdmin.mSettingsChanged == true)
            {
                
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes;\n\rDo you want to save them to Vault?", "iLogic Job Administration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    mSaveToVault();
                }
            }
        }
    }

}
