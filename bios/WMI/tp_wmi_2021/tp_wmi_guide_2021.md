# ThinkPad BIOS Setup using WMIDeployment Guide 

Updates for 2020 and newer models


## Introduction

The purpose of this guide is to explain how to modify BIOS passwords, settings, and boot order using Windows
Management Instrumentation (WMI) in PowerShell. This guide is intended for skilled IT administrators who are
familiar with configuring BIOS settings on computers in their organizations.

If you have suggestions, comments, or questions, please talk to us on our forum! A team of deployment engineers
(including the author of this document) is standing by, ready to help with any deployment challenges you are facing:
https://forums.lenovo.com/t5/Enterprise-Client-Management/bd-p/sa01_eg

The latest version of this guide is always located at:
https://support.lenovo.com/us/en/documents/ht100612

## Overview of Changes

Recent ThinkPad models (2020 and newer) support complex BIOS passwords. Acceptable characters for BIOS
password are the following: 

The following illustration shows how WMI can be used to access Lenovo BIOS settings 

 + Alphabet (case sensitive) {‘A-Z‘, ‘a-z‘}
 + Number {‘0-9‘}
 + Space ! " # $ % & ' ( ) * + , - . / : ; < = > ? @ [ ¥ ] ^ _ ` { | } ~
 
To support these complex BIOS passwords, a new WMI class is required. If you don’t need complex passwords,
you can continue using the same WMI classes and methods that you have always used. You only need to change
WMI classes and methods if you want to use complex BIOS passwords

### Set/Save a Setting 

In previous ThinkPad models, it was required to specify the supervisor password in both Lenovo_SetBiosSetting
and Lenovo_SaveBiosSettings. This is no longer required. Instead, the supervisor password is specified using a
new class, Lenovo_WmiOpcodeInterface. The new process is: Lenovo_SetBiosSetting,
Lenovo_WmiOpcodeInterface, and then Lenovo_SaveBiosSettings. 

### Specifying the BIOS Supervisor Password 

In previous ThinkPad models, it was required to specify the BIOS supervisor password such as
“mypassword,ascii,us”. In new ThinkPad models, specify the BIOS supervisor password as
“WmiOpcodePasswordAdmin:MyPassword” using the Lenovo_WmiOpcodeInterface class. 

## Script Classes and Parameters

This chapter contains WMI implementation details for configuring BIOS settings and passwords.

### Configuring BIOS Settings

The following interface details can be used to access Lenovo BIOS settings.
 + Namespace: "root\WMI"
 + Base Class: "Lenovo_BIOSElement"
 + Interface details (see Table 1 Interface Details.)


| **Class Name**               	| **Type**   	| **Parameter**                                           	| **Example**                              	|
|----------------------------	|--------	|-----------------------------------------------------	|--------------------------------------	|
| Lenovo_BiosSetting         	| Query  	| CurrentSetting: "Item,Value"                        	| "WakeOnLANDock,Enable"               	|
| Lenovo_GetBiosSelections   	| Method 	| "Item"                                              	| “WakeOnLANDock”                      	|
| Lenovo_SetBiosSetting      	| Method 	| "Item,Value”                                        	| "WakeOnLANDock,Disable"              	|
| Lenovo_SaveBiosSettings    	| Method 	| (none)                                              	|                                      	|
| Lenovo_LoadDefaultSettings 	| Method 	| (none)                                              	|                                      	|
| Lenovo_SetBiosPassword     	| Method 	| Deprecated – use Lenovo_WmiOpcodeInterf ace instead 	|                                      	|
| Lenovo_WmiOpcodeInterface  	| Method 	| password                                            	| “WmiOpcodePasswordAdmin:MyPasswor d” 	|
<div style="text-align:center;">

_**Table 1.** Interface Details_
</div>

### Return Types

You will receive one of the following return types after making changes to BIOS settings:

| **Return Type**       	| **Description**                                                                                                                                           	|   	|
|-------------------	|-------------------------------------------------------------------------------------------------------------------------------------------------------	|---	|
| Success           	| Operation completed successfully                                                                                                                      	|   	|
| Not Supported     	| The feature is not supported on this   system.                                                                                                        	|   	|
| Invalid Parameter 	| The item or value provided is not   valid.                                                                                                            	|   	|
| Access Denied     	| The change could not be made due to   an authentication problem. If a supervisor password exists, the correct   supervisor password must be provided. 	|   	|
| System Busy       	| BIOS changes have already been made   that need to be committed. Reboot the system and try again.                                                     	|   	|
<div style="text-align:center;padding-top:0px;">

_**Table 2.** Return Types_
</div>

### Password Authentication 

If a supervisor password is already set, you must specify that supervisor password before you can save any changed BIOS settings.

The password is specified using the Lenovo_WmiOpcodeInterface class. A single parameter in the format of
“WmiOpcodePasswordAdmin:MyPassword” (where MyPassword is your actual password) is used.

## Sample PowerShell Scripts

The following PowerShell commands are examples that can be used as-is or modified for your specific requirements.

### Get All Current BIOS Settings 

Use the following command to display all current BIOS settings: 

	gwmi -class Lenovo_BiosSetting -namespace root\wmi | ForEach-Object {if ($_.CurrentSetting -ne"") {Write-Host $_.CurrentSetting.replace(","," = ")}}
	
### Get a Particular BIOS Setting 

Use the following command to display a particular BIOS setting; for example, WakeOnLANDock:

	gwmi -class Lenovo_BiosSetting -namespace root\wmi | Where-Object{$_.CurrentSetting.split(",",[StringSplitOptions]::RemoveEmptyEntries) -eq "WakeOnLANDock"} | Format-List CurrentSetting


### Set and Save a BIOS Setting 

Use the following commands to set the value of a BIOS setting. This is a multi-step process: (1) change the setting,
(2) specify the supervisor password (if it exists), and (3) save the new setting. Step 2 can be omitted if you don’t
have a supervisor password. 

**Note**: The setting string is case sensitive and should be in the format "<item>,<value>". 

	(gwmi -class Lenovo_SetBiosSetting –namespace root\wmi).SetBiosSetting("WakeOnLANDock,Disable")

	(gwmi -class Lenovo_WmiOpcodeInterface -namespace root\wmi).WmiOpcodeInterface("WmiOpcodePasswordAdmin:MyPassword")

	(gwmi -class Lenovo_SaveBiosSettings -namespace root\wmi).SaveBiosSettings()
	

### Change a BIOS Password

Use the following commands to change the BIOS supervisor password. Note that you cannot use this method to
set an initial password; it can only be used to change an existing password. This is a multi-step process: (1)
specify the password type, (2) specify the current password, (3) specify the new password, and (4) save the new
password. 

	(gwmi -class Lenovo_WmiOpcodeInterface -namespace root\wmi).WmiOpcodeInterface("WmiOpcodePasswordType:pap")

	(gwmi -class Lenovo_WmiOpcodeInterface -namespace root\wmi).WmiOpcodeInterface("WmiOpcodePasswordCurrent01:MyCurrentPassword")

	(gwmi -class Lenovo_WmiOpcodeInterface -namespace root\wmi).WmiOpcodeInterface("WmiOpcodePasswordNew01:MyNewPassword")
	
	(gwmi -class Lenovo_WmiOpcodeInterface -namespace root\wmi).WmiOpcodeInterface("WmiOpcodePasswordSetUpdate")
	
The password type can be one of the following values:
 + WmiOpcodePasswordType:pap - Supervisor
 + WmiOpcodePasswordType:pop - Power-on
 + WmiOpcodePasswordType:smp - System Management
 + WmiOpcodePasswordType:uhdp1 - User HDP 1
 + WmiOpcodePasswordType:mhdp1 - Master HDP 1
 + WmiOpcodePasswordType:uhdp2 - User HDP 2
 + WmiOpcodePasswordType:mhdp2 - Master HDP 2
 + WmiOpcodePasswordType:adrp1 - (NVMe only) Single Password or Dual Password Admin 1
 + WmiOpcodePasswordType:udrp1 - (NVMe only) Dual Password User 1
 + WmiOpcodePasswordType:adrp2 - (NVMe only) Single Password or Dual Password Admin 2
 + WmiOpcodePasswordType:udrp2 - (NVMe only) Dual Password User 2


### Limitations and Notes 
**1**. BIOS settings cannot be changed at the same boot as power-on passwords and hard disk passwords. If you
want to change BIOS settings and passwords, you must reboot the system after changing one of them.

**2**. A password cannot be set using this method when one does not already exist. Passwords can only be
changed or cleared.

**3**. To remove the power-on password when a supervisor password is set, it must be done in three steps total:
<ol type="a">
  <li> Change the supervisor password. It’s OK to specify the same password as both the current and the new, in case you don’t really want to change it. But you must do this step.</li>
  <li> Change the power-on password by specifying the current password and a NULL string as the new password</li>
  <li> Reboot (do not reboot between steps A and B) </li>
</ol>


**4**. Some security-related settings can only be disabled when a Supervisor password exists. For example, the following BIOS settings cannot be changed from Enable to Disable unless you have a Supervisor password:
 a. SecureBoot
 b. SecureRollbackPrevention
 c. PhysicalPresneceForTpmClear
 d. PhysicalPresenceForTpmProvision