# ThinkPad BIOS Setup using WMI Deployment Guide 

## Introduction

IT administrators are always looking for easier ways to manage client computer BIOS settings, which include
passwords, settings, and the boot order. The Lenovo BIOS WMI interface provides a simplified way to change
these settings. Lenovo has developed a BIOS interface that can be manipulated through Windows Management
Instrumentation (WMI). The Lenovo BIOS WMI interface enables IT administrators to make queries on current
BIOS settings, restore settings to their factory defaults, change single settings, reset or change passwords, and
modify the boot order either at client computers or remotely. 

### Using Windows Management Instrumentation 

WMI is provided as a standard feature in most Windows® operating systems. It provides a powerful set of
functions, such as query-based information retrieval and event notification, which enables users to manage both
local and remote computers. The Lenovo BIOS WMI interface extends the capabilities of WMI to allow
management of BIOS settings.

The following illustration shows how WMI can be used to access Lenovo BIOS settings:

<img src="../img/guides/bios/biosWMI.png"
     alt=""
     style="text-align:center;" />


### Key Benefits 

The Lenovo BIOS WMI interface provides the following benefits: 

**Functions**
 + Flexible BIOS configuration, including the ability to change a single BIOS setting or all BIOS settings
 + BIOS password management, including updating supervisor passwords, power-on passwords, and hard
disk drive (HDD) passwords
 + No dependency on a specific BIOS level 
 
**Environment**
 + Remote or local capabilities
 + Support of unattended operations
 + No software installation, including managed object format (MOF), required
 + Replaces DOS-based BIOS configuration tools 

**Interface**
 + Easy to adopt for various management servers
 + Common interface for different products

### Supported Computers
 
BIOS setup through WMI is supported on the following ThinkPad products:
 + All ThinkPad models from 2018 or newer
 + Selected ThinkPad models from 2017 or older: 
   + ThinkPad L430, L530, L440, L540, L450, L460, L560, L470, L570
   + ThinkPad T430, T430s, T430u, T530, T440, T440p, T440s, T540p, T450, T450s, T550, W550s, T460, T460p, T460s, T560, T470, T470s, T470p, T570
   + ThinkPad X1 Carbon (all generations), X1 Yoga (all generations)
   + ThinkPad X1 Tablet (all generations)
   + ThinkPad X230, X230 Tablet, X240, X240s, X250, X260, X270
   + ThinkPad W530, W540, W541
   + ThinkPad P50, P50s, P70, P40 Yoga, P51, P51s, P71
   + ThinkPad Yoga 11e
   + ThinkPad 11e, 13e, 13
   + ThinkPad Helix (machine types: 20CG, 20CH)
   + ThinkPad 10 (all generations)
   + ThinkPad Yoga 260, Yoga 460, Yoga 370
   + ThinkPad E470, E570
   + ThinkPad S1, S2, S5


##  Script Classes and Parameters 

This section contains WMI implementation details for configuring BIOS settings. 

### Configuring BIOS Settings 

The following interface details can be used to access Lenovo BIOS settings.
 + Namespace: ```"\root\WMI"```
 + Base Class: "Lenovo_BIOSElement"
 + Interface details (see Table 1 Interface Details.) 

| Class Name                  	| Type   	| Parameter / Return                                             	| Example                             	|
|-----------------------------	|--------	|----------------------------------------------------------------	|-------------------------------------	|
| Lenovo_BiosSetting          	| Query  	| CurrentSetting: "Item,Value"                                   	| "WakeOnLAN,Enable"                  	|
| Lenovo_GetBiosSelections    	| Method 	| “Item”                                                         	| “WakeOnLAN”                         	|
| Lenovo_SetBiosSetting       	| Method 	| "Item,Value,Password,Encoding, KbdLang;"                       	| "WakeOnLAN,Disable,pswd, ascii,us;" 	|
| Lenovo_SaveBios Settings    	| Method 	| "Password,Encoding,KbdLang;"                                   	| "pswd,ascii,us;"                    	|
| Lenovo_DiscardBios Settings 	| Method 	| "Password,Encoding,KbdLang;"                                   	| "pswd,ascii,us;"                    	|
| Lenovo_LoadDefault Settings 	| Method 	| "Password,Encoding,KbdLang;"                                   	| "pswd,ascii,us;"                    	|
| Lenovo_SetBios Password     	| Method 	| "PasswordType,CurrentPassword, NewPassword, Encoding,KbdLang;" 	| "pop,oldpop,newpop,ascii,us;”       	|

<div style="text-align:center;">

_**Table 1.** Interface Details_
</div>

**Notes**:
 + See Appendix A Sample Visual Basic scripts for configuring BIOS settings for Visual Basic sample scripts.
 + See Appendix B Sample PowerShell commands for remote BIOS management for PowerShell sample scripts.


### Return Types

You will receive one of the following return types after making changes to BIOS settings:

| Return Type       	| Description                                                                                                                                           	|   	|
|-------------------	|-------------------------------------------------------------------------------------------------------------------------------------------------------	|---	|
| Success           	| Operation completed successfully                                                                                                                      	|   	|
| Not Supported     	| The feature is not supported on this   system.                                                                                                        	|   	|
| Invalid Parameter 	| The item or value provided is not   valid.                                                                                                            	|   	|
| Access Denied     	| The change could not be made due to   an authentication problem. If a supervisor password exists, the correct   supervisor password must be provided. 	|   	|
| System Busy       	| BIOS changes have already been made   that need to be committed. Reboot the system and try again.                                                     	|   	|

<div style="text-align:center;">

_**Table 2.** Return Types_
</div>


### Password Authentication

If a supervisor password is already set, you must specify that supervisor password before you can change any
BIOS settings.

The format for password parameters is "abc,ascii,us" with descriptions in the following table

| Parameter   	| Description                                                      	| Possible Selections                                                                                                                                                                                                                                                                                                              	|
|-------------	|------------------------------------------------------------------	|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	|
| Parameter 1 	| Current Password                                                 	| • “abc” - raw ascii character   <br>     • “1e302e” - scancode                                                                                                                                                                                                                                                                   	|
| Parameter 2 	| Password encoding                                                	| • “ascii” <br>     • “scancode”                                                                                                                                                                                                                                                                                                  	|
| Parameter 3 	| Keyboard languages (valid only   if encoding is<br>     "ascii") 	| • "us" - English US,   English<br>     UK, Chinese-Traditional,<br>     Danish, Dutch, FrenchCanadian, Italian, Japanese,<br>     Korean, Norwegian, Polish,<br>     Portuguese, SpanishEuropean, Spanish-Latin<br>     American, Swiss, Turkish <br>     • "fr" - French-European,<br>     Belgian<br>     • "gr" - German, Cze 	|

<div style="text-align:center;">

_**Table 3.** Password parameters format, password authentication_
</div>


## Typical Usage

Through WMI, you can configure BIOS settings in the following ways:
 + List BIOS settings
 + Change BIOS settings
 + Change the boot order
 + Load default BIOS settings
 + Change a BIOS password 
 

### Listing Current BIOS Settings

For a list of all available BIOS settings that can be changed through WMI on a specific computer, use the Lenovo_BiosSetting class (see sample scripts)

### Changing BIOS Settings 

To change a BIOS setting, complete the following steps:
 1. Identify the BIOS setting you want to change using the Lenovo_BiosSetting class.
 2. Identify the value to which the setting will be changed, using the Lenovo_GetBiosSelections class.
 3. Change the BIOS setting to the desired value using the Lenovo_SetBiosSetting class, then use the Lenovo_SaveBiosSetting class to save the settings. **Note**: BIOS settings and values are case sensitive.

After making changes to the BIOS settings, you must reboot the computer before the changes will take effect.

### Changing the Boot Order 

To change the boot order, complete the following steps:
 + Determine the current setting for “BootOrder” by using the Lenovo_BiosSetting class.
 + Determine the available boot devices by using the Lenovo_GetBiosSelections class.
 + To set a new boot order, use the Lenovo_SetBiosSetting class, then use the Lenovo_SaveBiosSetting class to save the settings. In the following example, the CD drive 0 is the first boot device and hard disk drive 0 is the second startup device.
 
 ```ATAPICD0:HDD0```

### Restoring Default Settings 

To restore default BIOS settings, use the Lenovo_LoadDefaultSettings class, then use the Lenovo_SaveBiosSettings class to save the BIOS changes (see sample scripts). 

### Changing an Existing BIOS Password 

To update a password, specify a password type and format the password. The format for password parameters is "pop,abc,def,ascii,us" with descriptions in Table 4 (see sample scripts) 

| Parameter   	| Description             	| Possible Selections                                                                                                                                                                                                                                                                                         	|
|-------------	|-------------------------	|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	|
| Parameter 1 	| Password type string    	| • “pap": Supervisor <br>     • “POP": Power-on <br>     • "uhdp1": User HDP 1 <br>     • "mhdp1": Master HDP 1 <br>     • "uhdp2": User HDP 2 <br>     • "mhdp2": Master HDP 2 <br>     • "uhdp3": User HDP 3 <br>     • "mhdp3": Master HDP 3                                                              	|
| Parameter 2 	| Current password string 	| • “abc” - raw ascii   character<br>     • “1e302e” - scancode                                                                                                                                                                                                                                               	|
| Parameter 3 	| New password string     	| • Raw ascii "def"   <br>     • Scan code "201221"                                                                                                                                                                                                                                                           	|
| Parameter 4 	| Password encoding       	| • “ascii” <br>     • “scancode”                                                                                                                                                                                                                                                                             	|
| Parameter 5 	| Keyboard languages      	| • "us" - English US,   English UK, Chinese-Traditional, Danish, Dutch, French-Canadian, Italian,   Japanese, Korean, Norwegian, Polish, Portuguese, SpanishEuropean,   Spanish-Latin American, Swiss, Turkish <br>     • "fr" - French-European, Belgian <br>     • "gr" - German, Czech, Slovak, Slovenian 	|

<div style="text-align:center;">

_**Table 4.** Password parameters format, changing existing BIOS password_
</div>

### Limitations and Notes

 1. BIOS settings cannot be changed at the same boot as power-on passwords (POP) and hard disk passwords
(HDP). If you want to change BIOS settings and POP or HDP, you must reboot the system after changing one of them.
 2. A password cannot be set using this method when one does not already exist. Passwords can only be updated or cleared.
 3. To remove the power-on password when a supervisor password is set, it must be done in three steps total:
 <ol type="a">
   <li> Change the supervisor password. It’s OK to specify the same password as both the current and the new, in case you don’t really want to change it. But you must do this step.</li>
   <li> Change the power-on password by specifying the current password and a NULL string as the newpassword</li>
   <li> Reboot the system (do not reboot between steps A and B).</li>
   </ol>
 4. Some security-related settings cannot be disabled by WMI. For example, the following BIOS settings cannot be changed from Enable to Disable:
 <ol type="a">
   <li> SecureBoot</li>
   <li> SecureRollbackPrevention</li>
   <li> PhysicalPresneceForTpmClear </li>
   <li> PhysicalPresenceForTpmProvision</li>
   </ol>
 5. It is not possible to change the Security Chip Selection (e.g. Discrete TPM or Intel PTT)
 6. Note for Discrete TPM: the following values are supported for SecurityChip:
  <ol type="a">
   <li> Active</li>
   <li> Inactive</li>
   <li> Disable</li>
   </ol>
 7. Note for Intel PTT: the following values are supported for SecurityChip:
  <ol type="a">
   <li> Enable</li>
   <li> Disable</li>
   </ol>


## Security

WMI-based administration scripts operating over a remote connection send data over the network in clear text by
default. You can enhance security by modifying WMI-based administration scripts to establish an encrypted remote
connection as follows:

 1. Set an impersonation level of "impersonate"
 2. Set an authentication level of "pktPrivacy"
 
See Appendix A Sample Visual Basic scripts for configuring BIOS settings for sample scripts used to implement
WMI-based administration scripts that include these parameters for encryption. 

## Appendix A. Sample Visual Basic Scripts 

The Visual Basic command line scripts in the ZIP file are examples that you may find helpful when configuring
BIOS settings.

The scripts in the ZIP file can be used as-is on Windows 7, Windows 8, and Windows 10 to modify BIOS settings
on your Lenovo ThinkPad computer. The scripts can be executed on a command prompt using the cscript.exe utility. You must run the scripts from an administrator command prompt.

Sample scripts referenced below are provided on Lenovo’s support website:
https://support.lenovo.com/us/en/documents/ht100612

### Load BIOS Default Settings 

**Syntax**: cscript.exe LoadDefaults.vbs

**Example**: cscript.exe LoadDefaults.vbs

**Output**:
 ```
 Microsoft (R) Windows Script Host Version 5.812
 Copyright (C) Microsoft Corporation. All rights reserved.
  
   LoadDefaultSettings: Success
   SaveBiosSettings: Success 
   ```
### List all BIOS Setting Items and Values on the Local Computer 

**Syntax**: cscript.exe ListAll.vbs

**Example**: cscript.exe ListAll.vbs

**Output**:
 ```
 Microsoft (R) Windows Script Host Version 5.812
 Copyright (C) Microsoft Corporation. All rights reserved.

 WakeOnLAN
   current setting = ACOnly
   possible settings = Disable, ACOnly, ACandBattery, Enable
   
 EthernetLANOptionROM
   current setting = Enable
   possible settings = Disable, Enable
   
 IPv4NetworkStack
   current setting = Enable
   possible settings = Disable, Enable
   
 IPv6NetworkStack
   current setting = Enable
   possible settings = Disable, Enable
   
 (additional output omitted here) 
 ```

### Set a Single BIOS Setting on the Local Computer 

Use the sample scripts in the ZIP file as templates to set a single BIOS setting on the local computer.

**Syntax**: cscript.exe SetConfig.vbs [Item] [Value]

**Example**: cscript.exe SetConfig.vbs WakeOnLAN Disable

**Output**:
 ```
 Microsoft (R) Windows Script Host Version 5.812
 Copyright (C) Microsoft Corporation. All rights reserved.

 WakeOnLAN, Disable;
   SetBiosSetting: Success
 WakeOnLAN, Disable;
   SaveBiosSettings: Success
   ```

### Set a Single BIOS Setting on the Local Computer When a Supervisor Password Exists 

Use the sample scripts in the ZIP file as templates to set a single BIOS setting on the local computer when a
supervisor password exists.

**Syntax**: cscript.exe SetConfigPassword.vbs [Item] [Value] [Password + Encoding]

**Example**: cscript.exe SetConfigPassword.vbs WakeOnLAN Disable password, ascii, us

**Output**:
 ```
 Microsoft (R) Windows Script Host Version 5.812
 Copyright (C) Microsoft Corporation. All rights reserved.
 
 WakeOnLAN, Disable, password, ascii, us;
   SetBiosSetting: Success
 WakeOnLAN, Disable, password, ascii, us;
   SaveBiosSettings: Success
   ```

### Change a Supervisor Password on the Local Computer

Use the sample scripts in the ZIP file as templates to change a supervisor password on the local computer. Note:
You cannot set a supervisor password if one does not already exist.

**Syntax**: cscript.exe SetSupervisorPassword.vbs [Old Password] [New Password] [encoding]

**Example**: cscript.exe SetSupervisorPassword.vbs oldpass newpass ascii, us

**Output**:
 ```
 Microsoft (R) Windows Script Host Version 5.812
 Copyright (C) Microsoft Corporation. All rights reserved.
 
 SetBiosPassword: Success
 ```

## Appendix B. Sample PowerShell Commands

The following PowerShell commands are examples that can be used as-is or modified for your particular environment or requirements.

### Get all Current BIOS Settings 

Use the following command as a template to display all current BIOS settings:

 ```
 gwmi -class Lenovo_BiosSetting -namespace root\wmi |  ForEach-Object
 {if ($_.CurrentSetting -ne "") {Write-Host $_.CurrentSetting.replace(","," = ")}} 
 ```


### Show a Particular BIOS Setting
Use the following command as a template to display a particular BIOS setting:

 ```
 gwmi -class Lenovo_BiosSetting -namespace root\wmi | Where-Object
 {$_.CurrentSetting.split(",",[StringSplitOptions]::RemoveEmptyEntries) -eq
 "WakeOnLAN"} | Format-List CurrentSetting
 ```


### Get all Possible Values for a Particular BIOS Setting 

Use the following command as a template to display all possible values for a particular BIOS setting: 

 ```
 (gwmi –class Lenovo_GetBiosSelections –namespace root\wmi).GetBiosSelections("WakeOnLAN") |
 Format-List Selections
 ```


### Set a BIOS Setting 

Use the following command as a template to set the value of a setting. This is a two-step process: set and then
save. Note: The setting string is case sensitive and should be in the format "<item>,<value>".

 ```
 (gwmi -class Lenovo_SetBiosSetting –namespace root\wmi).SetBiosSetting("WakeOnLAN,Disable")
 ```

 ```
 (gwmi -class Lenovo_SaveBiosSettings -namespace root\wmi).SaveBiosSettings()
 ```


### Set a BIOS Setting When a Supervisor Password Exists 

Use the following command as a template to set the value of a setting when a supervisor password exists. This is
a two-step process: set and then save. Note: The setting string is case sensitive and should be in the format
"<item>,<value>,<password + encoding>". 

 ```
 (gwmi -class Lenovo_SetBiosSetting –namespace root\wmi).SetBiosSetting("WakeOnLAN,Disable,password,ascii,us")
 ```

 ```
 (gwmi -class Lenovo_SaveBiosSettings -namespace root\wmi).SaveBiosSettings("password,ascii,us”)
 ```
