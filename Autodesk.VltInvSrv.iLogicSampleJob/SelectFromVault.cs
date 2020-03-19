using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ACW = Autodesk.Connectivity.WebServices;
using VDF = Autodesk.DataManagement.Client.Framework;
using Vault = Autodesk.DataManagement.Client.Framework.Vault;
using Forms = Autodesk.DataManagement.Client.Framework.Vault.Forms;

namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    public partial class SelectFromVault : Form
    {
        #region Member Variables
        public List<string> RetFullNames { get; set; } = new List<string>();
        public List<string> RetNames { get; set; } = new List<string>();

        private bool mMultiSelect = false;

        private Vault.Currency.Connections.Connection m_conn = iLogicJobAdmin.mConnection;
        private Vault.Forms.Models.BrowseVaultNavigationModel m_model = null;

        private List<VDF.Forms.Controls.GridLayout> m_availableLayouts = new List<VDF.Forms.Controls.GridLayout>();
        private List<ToolStripMenuItem> m_viewButtons = new List<ToolStripMenuItem>();

        private Func<Vault.Currency.Entities.IEntity, bool> m_filterCanDisplayEntity;

        #endregion

        public SelectFromVault(bool Multiselect = false)
        {
            mMultiSelect = Multiselect;

            InitializeComponent();

            fileName_multiPartTextBox.EditMode = VDF.Forms.Controls.MultiPartTextBoxControl.EditModeOption.ReadOnly;

            //create some filetype filters, borrowing from the Select Entity dialog
            Forms.Settings.SelectEntitySettings.EntityRegularExpressionFilter filter1 = new Forms.Settings.SelectEntitySettings.EntityRegularExpressionFilter("iLogic Rules (*.iLogicVb)", ".+iLogicVb", Vault.Currency.Entities.EntityClassIds.Files);
            txtFileType.Text = filter1.DisplayName;
            m_filterCanDisplayEntity = filter1.CanDisplayEntity;
        }

        /// <summary>
        /// Prepares the app to browse a vault by creating the inital set of columns, creating the browse model, connecting all the controls to it,
        /// and navigating to the root of the vault.
        /// </summary>
        private void initalizeGrid()
        {
            Vault.Currency.Properties.PropertyDefinitionDictionary propDefs = m_conn.PropertyManager.GetPropertyDefinitions(null, null, Vault.Currency.Properties.PropertyDefinitionFilter.IncludeAll);

            Vault.Forms.Controls.VaultBrowserControl.Configuration initialConfig = new Vault.Forms.Controls.VaultBrowserControl.Configuration(m_conn, "VaultBrowserSample", propDefs);

            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Client.EntityIcon);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Client.VaultStatus);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.EntityName);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Title);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Description);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.CheckInDate);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Comment);
            initialConfig.AddInitialColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.ThumbnailSystem);
            initialConfig.AddInitialSortCriteria(Vault.Currency.Properties.PropertyDefinitionIds.Server.EntityName, true);

            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Client.EntityIcon);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Client.VaultStatus);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.EntityName);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Title);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Description);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.CheckInDate);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.Comment);
            initialConfig.AddInitialQuickListColumn(Vault.Currency.Properties.PropertyDefinitionIds.Server.ThumbnailSystem);

            m_model = new Forms.Models.BrowseVaultNavigationModel(m_conn, true, true);

            m_model.ParentChanged += new EventHandler(m_model_ParentChanged);
            m_model.SelectedContentChanged += new EventHandler<Forms.Currency.SelectionChangedEventArgs>(m_model_SelectedContentChanged);

            vaultBrowserControl1.SetDataSource(initialConfig, m_model);
            vaultBrowserControl1.OptionsCustomizations.CanDisplayEntityHandler = canDisplayEntity;
            vaultBrowserControl1.OptionsBehavior.MultiSelect = mMultiSelect;
            vaultBrowserControl1.OptionsBehavior.AllowOverrideSelections = false;

            vaultNavigationPathComboboxControl1.SetDataSource(m_conn, m_model, null);

            m_model.Navigate(m_conn.FolderManager.RootFolder, Forms.Currency.NavigationContext.NewContext);
        }

        /// <summary>
        /// Wrapper between the filetype filters and the CanDisplayEntity deleagate on the Vault Browser control.
        /// </summary>
        /// <param name="entity">The entity to run the filter against.</param>
        /// <returns>True if the entity can be displayed.</returns>
        private bool canDisplayEntity(Vault.Currency.Entities.IEntity entity)
        {
            if (m_filterCanDisplayEntity != null)
            {
                if (!m_filterCanDisplayEntity(entity))
                {
                    return false;
                }
            }

            return true;
        }

        #region Form Events

        private void SelectFromVault_Shown(object sender, EventArgs e)
        {
            //save each available layout of the browser control as well as generate a button to use in the switch view dropdown
            foreach (VDF.Forms.Controls.GridLayout layout in vaultBrowserControl1.AvailableLayouts)
            {
                m_availableLayouts.Add(layout);
                ToolStripMenuItem item = new ToolStripMenuItem(layout.Name);
                item.Tag = layout;
                item.CheckOnClick = true;
                item.Click += new EventHandler(switchViewDropdown_itemClick);
                switchView_toolStripSplitButton.DropDownItems.Add(item);
                m_viewButtons.Add(item);
            }

            initalizeGrid();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //we need to be sure to release all our connections when the app closes
            //Vault.Library.ConnectionManager.CloseAllConnections();
        }

        #endregion

        #region BrowserVaultNavigationModel Events

        void m_model_SelectedContentChanged(object sender, Forms.Currency.SelectionChangedEventArgs e)
        {
            //when the selected content changes, we need to update the filename field to reflect the selected entities
            List<Vault.Currency.Entities.IEntity> selectedEntities = new List<Vault.Currency.Entities.IEntity>(e.SelectedEntities);

            bool fileSelected = false;
            List<string> selectedEntityNames = new List<string>();
            foreach (Vault.Currency.Entities.IEntity entity in selectedEntities)
            {
                if (entity is Vault.Currency.Entities.FileIteration)
                    fileSelected = true;
                selectedEntityNames.Add(entity.EntityName);
            }
            fileName_multiPartTextBox.Parts = selectedEntityNames;

            btn_Select.Enabled = fileSelected;

        }

        void m_model_ParentChanged(object sender, EventArgs e)
        {
            navigateBack_toolStripButton.Enabled = m_model.CanMoveBack;
            navigateUp_toolStripButton.Enabled = m_model.CanMoveUp;
        }

        #endregion

        #region ToolStripButton Events

        private void navigateBack_toolStripButton_Click(object sender, EventArgs e)
        {
            m_model.MoveBack();
        }

        private void navigateUp_toolStripButton_Click(object sender, EventArgs e)
        {
            m_model.MoveUp();
        }

        private void switchView_toolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            //cycle through the list of available layouts when the switch view button is pressed without using the dropdown
            int setIdx = (m_availableLayouts.IndexOf(vaultBrowserControl1.CurrentLayout) + 1) % m_availableLayouts.Count;
            vaultBrowserControl1.CurrentLayout = m_availableLayouts[setIdx];
        }

        private void switchView_toolStripSplitButton_DropDownOpening(object sender, EventArgs e)
        {
            //Check the currenly visible view in the menu
            foreach (ToolStripMenuItem button in m_viewButtons)
            {
                button.Checked = button.Tag.Equals(vaultBrowserControl1.CurrentLayout);
            }
        }

        #endregion

        void switchViewDropdown_itemClick(object sender, EventArgs e)
        {
            //switch to the exact layout that was chosen with the switch view dropdown menu
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            vaultBrowserControl1.CurrentLayout = item.Tag as VDF.Forms.Controls.GridLayout;
        }


        private void btn_Select_Click(object sender, EventArgs e)
        {
            string mNavPath = null;
            foreach (var item in m_model.NavigationPath)
            {
                mNavPath += item.EntityName + "/";
            }
            fileName_multiPartTextBox.Text = fileName_multiPartTextBox.Text.Replace("; ", ";");
            string[] mSelFiles = fileName_multiPartTextBox.Text.Split(';');
            foreach (string mFile in mSelFiles)
            {
                RetFullNames.Add(mNavPath + mFile);
                RetNames.Add(mFile);
            }

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
