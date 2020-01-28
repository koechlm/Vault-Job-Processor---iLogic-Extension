using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Autodesk.Connectivity.Extensibility.Framework;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Entities;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Connections;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Properties;
using Autodesk.Connectivity.JobProcessor.Extensibility;
using ACW = Autodesk.Connectivity.WebServices;
using VDF = Autodesk.DataManagement.Client.Framework;
using Inventor;
using iLogic = Autodesk.iLogic.Interfaces;

[assembly: ApiVersion("13.0")]
[assembly: ExtensionId("4d95a809-1c6a-4e1e-b885-7f5f69e94c7d")]


namespace Autodesk.VltInvSrv.iLogicSampleJob
{
    public class JobExtension : IJobHandler
    {
        private static string JOB_TYPE = "Autodesk.VltInvSrv.iLogicSampleJob";
        private static Settings mSettings = Settings.Load();
        private static string mAppPath = Util.GetAssemblyPath();
        private VDF.Vault.Currency.Connections.Connection mConnection;
        private Int32 mRuleSuccess = -1;

        #region IJobHandler Implementation
        public bool CanProcess(string jobType)
        {
            return jobType == JOB_TYPE;
        }

        public JobOutcome Execute(IJobProcessorServices context, IJob job)
        {
            try
            {
                Inventor.InventorServer mInv = context.InventorObject as InventorServer;

                #region validate execution rules

                //pick up this job's context
                mConnection = context.Connection;
                Autodesk.Connectivity.WebServicesTools.WebServiceManager mWsMgr = mConnection.WebServiceManager;
                long mEntId = Convert.ToInt64(job.Params["EntityId"]);
                string mEntClsId = job.Params["EntityClassId"];

                // only run the job for files; handle the scenario, that an item lifecycle transition accidently submitted the job
                if (mEntClsId != "FILE")
                {
                    context.Log(null, "This job type is for files only.");
                    return JobOutcome.Failure;
                }

                // only run the job for ipt and iam file types,
                List<string> mFileExtensions = new List<string> { ".ipt", ".iam", "idw", "dwg" };
                ACW.File mFile = mWsMgr.DocumentService.GetFileById(mEntId);
                if (!mFileExtensions.Any(n => mFile.Name.EndsWith(n)))
                {
                    context.Log(null, "Skipped Job execution as file type did not match iLogic enabled files (ipt, iam, idw/dwg");
                    return JobOutcome.Success;
                }
                //run iLogic for Inventor DWG file types/skip AutoCAD DWG files
                ACW.PropDef[] mPropDefs = mWsMgr.PropertyService.GetPropertyDefinitionsByEntityClassId("FILE");
                ACW.PropDef mPropDef = null;
                ACW.PropInst mPropInst = null;
                if (mFile.Name.EndsWith(".dwg"))
                {
                    mPropDef = mPropDefs.Where(n => n.SysName == "Provider").FirstOrDefault();
                    mPropInst = (mWsMgr.PropertyService.GetPropertiesByEntityIds("FILE", new long[] { mFile.Id })).Where(n => n.PropDefId == mPropDef.Id).FirstOrDefault();
                    if (mPropInst.Val.ToString() != "Inventor DWG")
                    {
                        context.Log(null, "Skipped Job execution as DWG type did not match Inventor DWG");
                        return JobOutcome.Success;
                    }
                }

                ApplicationAddIns mInvSrvAddIns = mInv.ApplicationAddIns;
                ApplicationAddIn iLogicAddIn = mInvSrvAddIns.ItemById["{3BDD8D79-2179-4B11-8A5A-257B1C0263AC}"];

                if (iLogicAddIn != null && iLogicAddIn.Activated != true)
                {
                    iLogicAddIn.Activate();
                }

                dynamic mAutomation = iLogicAddIn.Automation;

                if (mAutomation == null)
                {
                    Trace.WriteLine("iLogic-AddIn automation is not available; exiting job processing");
                    context.Log(null, "iLogic-AddIn automation is not available");
                    return JobOutcome.Failure;
                }

                #endregion validate execution rules

                #region VaultInventorServer IPJ activation

                //override InventorServer default project settings by your Vault specific ones
                Inventor.DesignProjectManager mInvIpjManager;
                Inventor.DesignProject mInvDfltProject, mInvVltProject;
                String mIpjPath = "";
                String mWfPath = "";
                String mIpjLocalPath = "";
                ACW.File mIpj;
                VDF.Vault.Currency.Entities.FileIteration mIpjFileIter = null;

                //validate ipj setting, a single, enforced ipj is expected 
                if (mWsMgr.DocumentService.GetEnforceWorkingFolder() && mWsMgr.DocumentService.GetEnforceInventorProjectFile())
                {
                    mIpjPath = mWsMgr.DocumentService.GetInventorProjectFileLocation();
                    mWfPath = mWsMgr.DocumentService.GetRequiredWorkingFolderLocation();
                    //Set mWfPath to alternate temporary working folder if needed, e.g. to delete all files after job execution
                }
                else
                {
                    context.Log(null, "Job requires both settings enabled: 'Enforce Workingfolder' and 'Enforce Inventor Project'.");
                    return JobOutcome.Failure;
                }
                //download and activate the Inventor Project file in VaultInventorServer
                mIpj = (mWsMgr.DocumentService.FindLatestFilesByPaths(new string[] { mIpjPath })).FirstOrDefault();

                try
                {
                    String[] mIpjFullFileName = mIpjPath.Split(new string[] { "/" }, StringSplitOptions.None);
                    String mIpjFileName = mIpjFullFileName.LastOrDefault();

                    //define download settings for the project file
                    VDF.Vault.Settings.AcquireFilesSettings mAcqrIpjSettings = new VDF.Vault.Settings.AcquireFilesSettings(mConnection);
                    mAcqrIpjSettings.LocalPath = new VDF.Currency.FolderPathAbsolute(mWfPath);
                    mIpjFileIter = new VDF.Vault.Currency.Entities.FileIteration(mConnection, mIpj);
                    mAcqrIpjSettings.AddFileToAcquire(mIpjFileIter, VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption.Download);

                    //download project file and get local path
                    VDF.Vault.Results.AcquireFilesResults mDownLoadResult;
                    VDF.Vault.Results.FileAcquisitionResult fileAcquisitionResult;
                    mDownLoadResult = mConnection.FileManager.AcquireFiles(mAcqrIpjSettings);
                    fileAcquisitionResult = mDownLoadResult.FileResults.FirstOrDefault();
                    mIpjLocalPath = fileAcquisitionResult.LocalPath.FullPath;

                    //activate this Vault's ipj   
                    mInvIpjManager = mInv.DesignProjectManager;
                    mInvDfltProject = mInvIpjManager.ActiveDesignProject;
                    mInvVltProject = mInvIpjManager.DesignProjects.AddExisting(mIpjLocalPath);
                    mInvVltProject.Activate();

                    //[Optionally:] get Inventor Design Data settings and download all related files ---------

                }
                catch
                {
                    context.Log(null, "Job was not able to activate Inventor project file. - Note: The ipj must not be checked out by another user.");
                    return JobOutcome.Failure;
                }
                #endregion VaultInventorServer IPJ activation


                #region download source file(s)

                //build download options including DefaultAcquisitionOptions
                VDF.Vault.Currency.Entities.FileIteration mFileIteration = new VDF.Vault.Currency.Entities.FileIteration(mConnection, mFile);
                VDF.Vault.Currency.Entities.FileIteration mNewFileIteration;
                VDF.Vault.Settings.AcquireFilesSettings mAcqrFlsSettings;
                if (mFileIteration.IsCheckedOut == true && mFileIteration.IsCheckedOutToCurrentUser == true)
                {
                    mAcqrFlsSettings = CreateAcquireSettings(false);
                }
                else
                {
                    mAcqrFlsSettings = CreateAcquireSettings(true);
                }

                mAcqrFlsSettings.AddFileToAcquire(mFileIteration, mAcqrFlsSettings.DefaultAcquisitionOption);

                //download
                VDF.Vault.Results.AcquireFilesResults mAcqrFlsResults2 = this.mConnection.FileManager.AcquireFiles(mAcqrFlsSettings);
                //pick-up the new file iteration in case of check-out
                VDF.Vault.Results.FileAcquisitionResult mFileAcqsResult2 = mAcqrFlsResults2.FileResults.Where(n => n.File.EntityName == mFileIteration.EntityName).FirstOrDefault();
                if (mAcqrFlsResults2 != null && mFileAcqsResult2.NewFileIteration != null)
                {
                    mNewFileIteration = mFileAcqsResult2.NewFileIteration;
                }
                else
                {
                    mNewFileIteration = mFileIteration;
                }

                if (mFileAcqsResult2 == null || (mNewFileIteration.IsCheckedOut != true && mNewFileIteration.IsCheckedOutToCurrentUser != true))
                {
                    mInvDfltProject.Activate();
                    context.Log(null, "Job stopped execution as the source file to process did not download or check-out.");
                    return JobOutcome.Failure;
                }
                string mDocPath = mFileAcqsResult2.LocalPath.FullPath;
                string mExt = System.IO.Path.GetExtension(mDocPath);

                #endregion download source file(s)


                #region iLogic Rule Execution
                //avoid unplanned rule execution triggered by the document itself
                mAutomation.RulesOnEventsEnabled = false;
                mAutomation.RulesEnabled = false;
                dynamic mFileOptions = mAutomation.FileOptions;
                mFileOptions.AddinDirectory = mSettings.iLogicAddinDLLs;
                List<string> mExtRlsDirs = new List<string>();
                mExtRlsDirs.Add(mAppPath);
                mFileOptions.ExternalRuleDirectories = mExtRlsDirs.ToArray();
                dynamic mLogCtrl = mAutomation.LogControl;
                string mLogFileFullName = mSettings.iLogicLogDir;

                switch (mSettings.iLogicLogLevel)
                {
                    case "None":
                        mLogCtrl.Level = 0;
                        break;
                    case "Trace":
                        mLogCtrl.Level = 1;
                        break;
                    case "Debug":
                        mLogCtrl.Level = 2;
                        break;
                    case "Info":
                        mLogCtrl.Level = 3;
                        break;
                    case "Warn":
                        mLogCtrl.Level = 4;
                        break;
                    case "Error":
                        mLogCtrl.Level = 5;
                        break;
                    case "Fatal":
                        mLogCtrl.Level = 6;
                        break;
                    default:
                        mLogCtrl.Level = 5;
                        break;
                }

                //enable iLogic to save a log file for each job Id.
                if (mSettings.iLogicLogLevel != "None")
                {
                    string mLogName = job.Id + "_iLogicSampleJob.log";
                    System.IO.DirectoryInfo mLogDirInfo = new System.IO.DirectoryInfo(mSettings.iLogicLogDir);
                    if (mLogDirInfo.Exists == false)
                    {
                        mLogDirInfo = System.IO.Directory.CreateDirectory(mSettings.iLogicLogDir);
                    }
                    mLogFileFullName = System.IO.Path.Combine(mLogDirInfo.FullName, mLogName);
                }

                //Open Inventor Document
                Document mDoc = mInv.Documents.Open(mDocPath);

                //read rule execution settings
                string mVaultRuleFullFileName = mSettings.VaultRuleFullFileName;
                String mExtRulePath = mSettings.ExternalRuleDirectory;
                String mExtRuleName = mSettings.ExternalRuleName;
                String mExtRuleFullName = null;
                String mIntRulesOption = mSettings.InternalRulesOption;
                if (mVaultRuleFullFileName != "")
                {
                    ACW.File mRuleFile = mWsMgr.DocumentService.FindLatestFilesByPaths(new string[] { mVaultRuleFullFileName }).FirstOrDefault();
                    //build download options including DefaultAcquisitionOptions
                    VDF.Vault.Currency.Entities.FileIteration mRuleFileIter = new VDF.Vault.Currency.Entities.FileIteration(mConnection, mRuleFile);

                    VDF.Vault.Settings.AcquireFilesSettings mAcqrRuleSettings = CreateAcquireSettings(false);

                    mAcqrRuleSettings.AddFileToAcquire(mRuleFileIter, mAcqrRuleSettings.DefaultAcquisitionOption);

                    //download
                    VDF.Vault.Results.AcquireFilesResults mAcqrRuleResults = this.mConnection.FileManager.AcquireFiles(mAcqrRuleSettings);
                    //pick-up the new file iteration in case of check-out
                    VDF.Vault.Results.FileAcquisitionResult mRuleAcqResult = mAcqrRuleResults.FileResults.Where(n => n.File.EntityName == mRuleFileIter.EntityName).FirstOrDefault();
                    if (mRuleAcqResult.LocalPath != null)
                    {
                        mExtRuleFullName = mRuleAcqResult.LocalPath.FullPath;
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(mExtRuleFullName);
                        if (fileInfo.Exists == false)
                        {
                            context.Log(null, "Job downloaded rule file but exited due to missing rule file " + mExtRuleFullName + ".");
                            mConnection.FileManager.UndoCheckoutFile(mNewFileIteration);
                            return JobOutcome.Failure;
                        }
                    }
                    else
                    {
                        context.Log(null, "Job could not download configured rule file and exited. Compare the 'VaultRuleFullFileName' setting and available rule in Vault.");
                        return JobOutcome.Failure;
                    }
                }
                if (mExtRuleName != "" && mVaultRuleFullFileName == "")
                {
                    if (mSettings.ExternalRuleDirectory == "")
                    {
                        mExtRuleFullName = System.IO.Path.Combine(mAppPath, mExtRuleName);
                    }
                    else
                    {
                        mExtRlsDirs.Add(mExtRulePath);
                        mFileOptions.ExternalRuleDirectories = mExtRlsDirs.ToArray();
                        //mExtRuleFullName = System.IO.Path.Combine(mExtRulePath, mExtRuleName);
                    }

                    //use case  - apply external rule with arguments; additional Vault UDP, status or any information might fill rule arguments
                    //validate required rule file first
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(mExtRuleFullName);
                    if (fileInfo.Exists == false)
                    {
                        context.Log(null, "Job exited due to missing rule file " + mExtRuleFullName + ".");
                        mConnection.FileManager.UndoCheckoutFile(mNewFileIteration);
                        return JobOutcome.Failure;
                    }
                }
                //an external rule is not mandatory.
                if (mExtRuleFullName != "")
                {
                    //required rule arguments to continue Vault interaction within the rule (iLogic-Vault library)
                    NameValueMap ruleArguments = mInv.TransientObjects.CreateNameValueMap();
                    ruleArguments.Add("ServerName", mConnection.Server);
                    ruleArguments.Add("VaultName", mConnection.Vault);
                    ruleArguments.Add("UserId", mConnection.UserID);
                    ruleArguments.Add("Ticket", mConnection.Ticket);

                    //additional rule arguments to build rule conditions evaluating Vault lifecycle information, properties, etc.
                    if (mSettings.PropagateProps == "True")
                    {
                        ACW.PropInst[] mSourcePropInsts = mWsMgr.PropertyService.GetPropertiesByEntityIds("FILE", new long[] { mFileIteration.EntityIterationId });
                        string mPropDispName;
                        foreach (ACW.PropInst item in mSourcePropInsts)
                        {
                            mPropDispName = mPropDefs.Where(n => n.Id == item.PropDefId).FirstOrDefault().DispName;
                            ruleArguments.Add(mPropDispName, item.Val);
                        }
                    }

                    //call external rule with arguments; return value = 0 in case of successful execution
                    mRuleSuccess = mAutomation.RunExternalRuleWithArguments(mDoc, mExtRuleFullName, ruleArguments);
                    if (mRuleSuccess != 0)
                    {
                        context.Log(null, "Job failed due to failure in external rule " + mExtRuleName + ".");
                        mDoc.Close(true);
                        mConnection.FileManager.UndoCheckoutFile(mNewFileIteration);
                        mLogCtrl.SaveLogAs(mLogFileFullName);
                        return JobOutcome.Failure;
                    }
                    mDoc.Save2(false);
                }


                //use case - open test file and execute all, all active or filtered document rules
                dynamic mDocRules = mAutomation.Rules(mDoc);
                List<dynamic> mRulesToExec = new List<dynamic>();

                switch (mSettings.InternalRulesOption)
                {
                    case "None":
                        break;

                    case "Active":
                        if (mDocRules != null)
                        {
                            foreach (dynamic rule in mDocRules)
                            {
                                if (rule.IsActive == true)
                                {
                                    mRulesToExec.Add(rule);
                                }
                            }
                        }
                        break;

                    case "All":
                        if (mDocRules != null)
                        {
                            foreach (dynamic rule in mDocRules)
                            {
                                mRulesToExec.Add(rule);
                            }
                        }
                        break;

                    default:
                        foreach (dynamic rule in mDocRules)
                        {
                            if (rule.Name.Contains(mSettings.InternalRulesOption))
                            {
                                mRulesToExec.Add(rule);
                            }
                        }
                        break;
                }
                if (mRulesToExec.Count >= 1)
                {
                    foreach (dynamic rule in mRulesToExec)
                    {
                        mRuleSuccess = mAutomation.RunRule(mDoc, rule.Name);
                        if (mRuleSuccess != 0)
                        {
                            context.Log(null, "Job failed due to failure in internal rule " + rule.Name + ".");
                            mDoc.Close(true);
                            mConnection.FileManager.UndoCheckoutFile(mNewFileIteration);
                            mLogCtrl.SaveLogAs(mLogFileFullName);
                            return JobOutcome.Failure;
                        }
                    }
                }

                mDoc.Save2(false);
                mDoc.Close(true);
                mLogCtrl.SaveLogAs(mLogFileFullName);

                #endregion iLogic Rule Execution


                #region Check-in result

                // checkin new file version
                VDF.Currency.FilePathAbsolute vdfPath = new VDF.Currency.FilePathAbsolute(mDocPath);
                FileIteration mUploadedFile = null;
                try
                {
                    mUploadedFile = mConnection.FileManager.CheckinFile(mNewFileIteration, "Created by Custom Job executing iLogic Rule(s)", false, null, null, false, null, mFileIteration.FileClassification, false, vdfPath);
                }
                catch
                {
                    context.Log(null, "Job could not check-in updated file " + mUploadedFile.EntityName + ".");
                    return JobOutcome.Failure;
                }
                #endregion check-in result

                #region reset 

                mInvDfltProject.Activate();
                //delete temporary working folder if imlemented here

                #endregion reset
                return JobOutcome.Success;
            }
            catch (Exception ex)
            {
                context.Log(ex, "Job failed by unhandled exception: " + ex.ToString() + " ");
                return JobOutcome.Failure;
            }

        }

        private VDF.Vault.Settings.AcquireFilesSettings CreateAcquireSettings(bool CheckOut)
        {
            VDF.Vault.Settings.AcquireFilesSettings settings = new VDF.Vault.Settings.AcquireFilesSettings(mConnection);
            if (CheckOut)
            {
                settings.DefaultAcquisitionOption = VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption.Checkout;
            }
            else
            {
                settings.DefaultAcquisitionOption = VDF.Vault.Settings.AcquireFilesSettings.AcquisitionOption.Download;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.IncludeChildren = true;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.RecurseChildren = true;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.IncludeAttachments = true;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.IncludeLibraryContents = true;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.ReleaseBiased = true;
                settings.OptionsRelationshipGathering.FileRelationshipSettings.VersionGatheringOption = VDF.Vault.Currency.VersionGatheringOption.Revision;
                settings.OptionsRelationshipGathering.IncludeLinksSettings.IncludeLinks = false;
                VDF.Vault.Settings.AcquireFilesSettings.AcquireFileResolutionOptions mResOpt = new VDF.Vault.Settings.AcquireFilesSettings.AcquireFileResolutionOptions();
                mResOpt.OverwriteOption = VDF.Vault.Settings.AcquireFilesSettings.AcquireFileResolutionOptions.OverwriteOptions.ForceOverwriteAll;
                mResOpt.SyncWithRemoteSiteSetting = VDF.Vault.Settings.AcquireFilesSettings.SyncWithRemoteSite.Always;
            }
            return settings;
        }

        public void OnJobProcessorShutdown(IJobProcessorServices context)
        {
            //throw new NotImplementedException();
        }

        public void OnJobProcessorSleep(IJobProcessorServices context)
        {
            //throw new NotImplementedException();
        }

        public void OnJobProcessorStartup(IJobProcessorServices context)
        {
            //throw new NotImplementedException();
        }

        public void OnJobProcessorWake(IJobProcessorServices context)
        {
            //throw new NotImplementedException();
        }
        #endregion IJobHandler Implementation
    }
}
