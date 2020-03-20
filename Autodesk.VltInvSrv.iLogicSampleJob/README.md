# Vault-Inventor-Server Job Extension Sample to run iLogic Rules

The iLogic Extension for Vault Job Processor allows configuring the iLogic AddIn of Vault-Inventor-Server and provides a custom job as a framework. 
Administrators can configure which iLogic rules to run on Lifecycle State Transitions and which iLogic rules being available for interactive, 
manual job submission on selected files.

INTRODUCTION:
---------------------------------
This sample walks you through the basic concept handling Inventor part, assembly, or drawing files submitted to the job queue by VaultInventorServer.
To open any file maintaining all parent-child references, the job leverages Vault project file settings to initialize the job execution.
File download and running Inventor iLogic rules are the major execution step.
If rules updated documents the job checks-in the new file version. If rules failed, the job reverts to the initial file version state. 
Options allow to save iLogic logging per job.

REQUIREMENTS:
---------------------------------
Vault Workgroup, Vault Professional 2020.2 (Update 2 added the iLogic Automation Add-In to Vault Inventor Server).
This job leverages the Vault Inventor Server component and does not require Inventor installation or Inventor license.
The job is valid for any Vault configuration fulfilling these requirements:
- Enforce Workingfolder = Enabled
- Enforce Inventor Project File = Enabled
- Single project file in Vault.
- iLogic rules compatible for Inventor Server execution
	- ThisApplication object being replaced by ThisServer
	
- To allow iLogic rules interacting with Vault during job execution requires the Job-Processor's log-in being re-used within the rule. Use the template VaultJobRuleConnected.iLogicVb to build your rule.
	- the referenced iLogic-Vault Quickstart library is available on GitHub open source and in binary format. Minimum Version (binary) or branch is 2020.3.0

TO CONFIGURE:
---------------------------------
1) Copy the folder Autodesk.VltInvSrv.iLogicSampleJob to %ProgramData%\Autodesk\Vault 2020\Extensions\.
2) Start Vault Explorer and configure the iLogic Job environment: Tools -> iLogic Job Administration...; first time load will bring up an error message, that no configuration could be loaded.
3) Edit the configuration options and Save To Vault. Even if empty values are saved to Vault, the error mentioned before will no longer occure.
4) Manual Job Submission - To use the manual Job submission, you need to configure and save the Tab Manual User Job Options. A single external rule file is the minimum configuration.
	To submit a job, select a file (Inventor only ;)) go to Actions -> Queue iLogic Job and select the rule to be run against the selected file.
5) Automatic Job Submission. Configure the Tab "Job Rules Options" and save to Vault. Add the job name to the Job Queue activating job transitions. To achieve this, integrate this job into a custom lifecycle transition by adding the Job-Type name
"Autodesk.VltInvSrv.iLogicSampleJob" to the transition's 'Custom Job Types' tab.
6) To enable iLogic logging copy the file iLogicLogger.config to the C:\Program Files\Autodesk\Vault Professional 202x\Explorer\Inventor Server\Bin\. Enable iLogic Logging in the configuration
Tab "Advanced iLogic Configuration".

DISCLAIMER:
---------------------------------
In any case, all binaries, configuration code, templates and snippets of this solution are of "work in progress" character. This also applies to GitHub "Release" versions.
Neither Markus Koechl, nor Autodesk represents that these samples are reliable, accurate, complete, or otherwise valid. 
Accordingly, those configuration samples are provided “as is” with no warranty of any kind and you use the applications at your own risk.


NOTES/KNOWN ISSUES:
---------------------------------
The job expects that all library definition files configured in the Inventor project file are available in the file system. Otherwise, the job might fail with unhandled exception due to missing style library or other settings files.
Only iLogic rules updating existing files are allowed; component replacement, new component insertions or any other change impacting the referenced files and its parent-child
relationship are not supported.

VERSION HISTORY / RELEASE NOTES:
---------------------------------
2020.2.1.0 - Vault Extension with user interface for configuration and user interactive job submission
2020.2.0.1 - Option to break execution for iLogic Rule debugging added
2020.2.0.0 - Initial Version
 
---------------------------------

Thank you for your interest in Autodesk Vault solutions and API samples.

Sincerely,

Markus Koechl, Autodesk

