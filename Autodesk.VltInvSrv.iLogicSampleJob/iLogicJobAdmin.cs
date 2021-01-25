/*=====================================================================
  
  This file is part of an Autodesk Vault API Code Sample.

  Copyright (C) Autodesk Inc.  All rights reserved.

THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
PARTICULAR PURPOSE.
=====================================================================*/

using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

using ACJE = Autodesk.Connectivity.JobProcessor.Extensibility;
using ACW = Autodesk.Connectivity.WebServices;
using ACWT = Autodesk.Connectivity.WebServicesTools;
using VDF = Autodesk.DataManagement.Client.Framework;
using Autodesk.Connectivity.Explorer.Extensibility;
using System.Collections.Generic;

namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    class iLogicJobAdmin : IExplorerExtension
    {
        public static VDF.Vault.Currency.Connections.Connection mConnection = null;
        public static Settings mSettings = null;

        public void mQueueiLogicJobCmdHndlr(object s, CommandItemEventArgs e)
        {
            // select job rule that should run on selected file(s)
            mSettings = Settings.LoadFromVault(mConnection);
            if (mSettings == null)
            {
                MessageBox.Show("iLogic Environment for Job Processor is not configured. \n\r Contact your Vault Administrator for Support.", "Submit iLogic Job to Job Queue.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //initiate user interaction to select rule to be applied to selected files
            iLogicSampleJob.SelectUserJob mUserJob = new SelectUserJob();

            var retval = mUserJob.ShowDialog();

            //get dialog return parameters
            string mRuleName = mUserJob.mJobFullFileName;
            string mResultCheckIn = mUserJob.mCreateNewIteration;
            string mInvApp = mUserJob.mRunInvApp;

            // Queue an iLogic job
            const string iLogicJobTypeName = "Autodesk.VltInvSrv.iLogicSampleJob";
            const string iLogicJob_FileId = "EntityId";
            const string iLogicJob_FileClassId = "EntityClassId";
            const string iLogicJob_Rule = "ExternalRule";
            const string iLogicJob_CheckIn = "CheckIn";
            const string iLogicJob_InvApp = "InvApplication";

            foreach (ISelection vaultObj in e.Context.CurrentSelectionSet)
            {
                ACW.File mFile = (ACW.File)e.Context.Application.Connection.WebServiceManager.DocumentService.GetLatestFileByMasterId(vaultObj.Id);
                ACW.JobParam[] mParamList = new ACW.JobParam[5];
                ACW.JobParam mMasterIdParam = new ACW.JobParam
                {
                    Name = iLogicJob_FileId,
                    Val = mFile.Id.ToString()
                };
                mParamList[0] = mMasterIdParam;

                ACW.JobParam mFileNameParam = new ACW.JobParam
                {
                    Name = iLogicJob_FileClassId,
                    Val = "FILE"
                };
                mParamList[1] = mFileNameParam;

                ACW.JobParam mRuleParam = new ACW.JobParam
                {
                    Name = iLogicJob_Rule,
                    Val = mRuleName
                };
                mParamList[2] = mRuleParam;

                ACW.JobParam mCheckInParam = new ACW.JobParam
                {
                    Name = iLogicJob_CheckIn,
                    Val = mResultCheckIn
                };
                mParamList[3] = mCheckInParam;

                ACW.JobParam mInvAppParam = new ACW.JobParam
                {
                    Name = iLogicJob_InvApp,
                    Val = mInvApp
                };
                mParamList[4] = mInvAppParam;

                // Add the job to the queue
                //
                string mRuleShortName = mRuleName.Split('/').Last();
                try
                {
                    e.Context.Application.Connection.WebServiceManager.JobService.AddJob(
                        iLogicJobTypeName, String.Format("Manually queued file {0} to run iLogic rule {1} on it.", vaultObj.Label, mRuleShortName),
                        mParamList, 1);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "237")
                    {
                        MessageBox.Show("You tried to queue a duplicate Job; resolve the existing job first.", "Queue iLogic Job...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        public void mJobAdminHndlr(object s, CommandItemEventArgs e)
        {
            iLogicJobAdminForm mAdminWindow = new iLogicJobAdminForm();
            mAdminWindow.ShowDialog();
        }

        public IEnumerable<CommandSite> CommandSites()
        {
            List<CommandSite> mJobSelectCmdSites = new List<CommandSite>();

            // Describe admin command item
            CommandItem mJobAdminCmdItem = new CommandItem("Command.JobAdmin", "iLogic Job Administration...")
            {
                Image = Properties.Resources.iLogicConfigurationImg
            };
            mJobAdminCmdItem.Execute += mJobAdminHndlr;

            // deploy admin on tools menu
            CommandSite mJobAdminCmdSite = new CommandSite("Menu.ToolsMenu", "iLogic Job Administration")
            {
                Location = CommandSiteLocation.ToolsMenu,
                DeployAsPulldownMenu = false
            };
            mJobAdminCmdSite.AddCommand(mJobAdminCmdItem);
            mJobSelectCmdSites.Add(mJobAdminCmdSite);


            CommandItem mQueuePublishJobCmdItem = new CommandItem("Command.iLogicJobAdd", "Queue iLogic Job")
            {
                NavigationTypes = new SelectionTypeId[] { SelectionTypeId.File },
                MultiSelectEnabled = true,
                Image = Properties.Resources.iLogic_Browser_transparent
            };
            mQueuePublishJobCmdItem.Execute += mQueueiLogicJobCmdHndlr;

            // deploy command on file context menu
            //
            CommandSite mQueuePublishContextMenu = new CommandSite("Menu.ActionMenu", "Queue iLogic Job")
            {
                Location = CommandSiteLocation.ActionsMenu,
                DeployAsPulldownMenu = false
            };
            mQueuePublishContextMenu.AddCommand(mQueuePublishJobCmdItem);
            mJobSelectCmdSites.Add(mQueuePublishContextMenu);

            return mJobSelectCmdSites;
        }

        public IEnumerable<CustomEntityHandler> CustomEntityHandlers()
        {
            return null;
        }

        public IEnumerable<DetailPaneTab> DetailTabs()
        {
            return null;
        }

        public IEnumerable<string> HiddenCommands()
        {
            return null;
        }

        public void OnLogOff(IApplication application)
        {
            //do nothing
        }

        public void OnLogOn(IApplication application)
        {
            mConnection = application.Connection;
        }

        public void OnShutdown(IApplication application)
        {
            //do nothing
        }

        public void OnStartup(IApplication application)
        {
            //do nothing
        }
    }
}
