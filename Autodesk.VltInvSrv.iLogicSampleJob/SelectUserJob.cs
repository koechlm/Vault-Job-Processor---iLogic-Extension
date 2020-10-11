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

namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    public partial class SelectUserJob : Form
    {
        //input parameters
        private Vault.Currency.Connections.Connection m_conn = iLogicJobAdmin.mConnection;

        private Settings settings = iLogicJobAdmin.mSettings;

        //return parameters
        public string JobFullFileName { get; set; }

        public string CreateNewIteration { get; set; }

        public SelectUserJob()
        {
            InitializeComponent();

            mFillGrid(settings.UserRules);
        }

        private void mFillGrid(string[] mUsrRls)
        {
            string[] mRow = null;
            for (int i = 0; i < mUsrRls.Count(); i++)
            {
                mRow = mUsrRls[i].Split('|');
                dtGrdUsrRules.Rows.Add(new string[] { (i + 1).ToString(), mRow[0], mRow[1], mRow[2] });
            }
        }

        private void dtGrdUsrRules_SelectionChanged(object sender, EventArgs e)
        {
            btn_SelectUserJob_Submit.Enabled = true;
        }

        private void btn_SelectUserJob_Submit_Click(object sender, EventArgs e)
        {
            JobFullFileName = dtGrdUsrRules.SelectedRows[0].Cells[3].Value.ToString();
            CreateNewIteration = dtGrdUsrRules.SelectedRows[0].Cells[2].Value.ToString();
            this.Close();
        }

        private void btn_SelectUsrJob_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
