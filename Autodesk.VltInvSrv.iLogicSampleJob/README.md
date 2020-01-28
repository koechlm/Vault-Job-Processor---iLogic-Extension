# Vault-Inventor-Server Job Sample to run iLogic Rules

This custom job allows to run external and/or document rules using VaultInventorServer.

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
	
- To allow iLogic rules interacting with Vault during job execution requires the Job-Processor's log-in being re-used within the rule. Use the template VaultJobProcExecConnected.iLogicVb to build your rule.
	- the referenced iLogic-Vault Quickstart library is available on GitHub open source and in binary format.

TO CONFIGURE:
---------------------------------
1) Copy the folder Autodesk.VltInvSrv.iLogicSampleJob to %ProgramData%\Autodesk\Vault 2020\Extensions\.
2) Edit the settings.xml to configure the options
3) Add the job to the Job Queue activating job transitions. To achieve this, integrate this job into a custom lifecycle transition by adding the Job-Type name
"Autodesk.VltInvSrv.iLogicSampleJob" to the transition's 'Custom Job Types' tab.
4) To enable iLogic logging copy the file iLogicLogger.config to the C:\Program Files\Autodesk\Vault Professional 202x\Explorer\Inventor Server\Bin\

DISCLAIMER:
---------------------------------
In any case, all binaries, configuration code, templates and snippets of this solution are of "work in progress" character. This also applies to GitHub "Release" versions.
Neither Markus Koechl, nor Autodesk represents that these samples are reliable, accurate, complete, or otherwise valid. 
Accordingly, those configuration samples are provided “as is” with no warranty of any kind and you use the applications at your own risk.


NOTES/KNOWN ISSUES:
---------------------------------
The job expects that all library definition files configured in the Inventor project file are available in the file system. Otherwise, the job might fail with unhandled exception due to missing style library or other settings files.

VERSION HISTORY / RELEASE NOTES:
---------------------------------

2020.2.0.0 - Initial Version
 
---------------------------------

Thank you for your interest in Autodesk Vault solutions and API samples.

Sincerely,

Markus Koechl, Autodesk

