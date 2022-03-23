---
Documentation file for LDA companion script
Script Name: Configure Dock Manager
upd.date: 03/21/2022
---

# Configure Dock Manager companion script

## SYNOPSIS

Configure Dock Manager run script

## SYNTAX
> [!NOTE]
> The script was developed for [using from Microsoft Endpoint Configuration Manager](https://docs.microsoft.com/en-us/mem/configmgr/apps/deploy-use/create-deploy-scripts) by Run Script feature. 
> You could run the script directly on the client machine using the PS console. However, it may require permissions of the administrator to run it.

```powershell
& '.\Configure Dock Manager.ps1 -AskBeforeFirmwareUpdate 1 -EnableNotifications 1 -LogfileAgeToCleanup 10 -LogfileMaxSize 3 -RepositoryLocation "C:\Repository"'
```

## DESCRIPTION
Script for configuration Lenovo Dock Manager application from registry.
The script is a part of the scripts package of the Lenovo Deployment Assistant application.

Dock Manager is designed for Lenovo Enterprise customers who are using Lenovo Dock Devices to: 
* aid with updating the firmware of their Lenovo Dock Devices, 
* run automatic firmware check and download, 
* provide user friendly prompts for update execution upon firmware download completion.  

## PARAMETERS
> [!NOTE]
> Refer to the [Lenovo documentation](https://support.lenovo.com/us/en/solutions/ht037099#dm) have additional information about parameters ​​and their role for the application.

### -AskBeforeFirmwareUpdate
The parameter enable or disable pop-up dialog message asking user to proceed to firmware update or not.
If  the parameters equals '0' Dock Manager will automatically proceed to firmware update after downloading firmware package without user confirmation.

if the parameter is specified, then the value will be set to the registry value:
 ```
HKLM:\SOFTWARE\WOW6432Node\Lenovo\Dock Manager\User Settings\General\AskBeforeFirmwareUpdate
```

```yaml
Type: String
Parameter Validation: Must be 1 or 0

Required: False
Position: Named
Default value: None
```

### -EnableNotifications
The parameter means tray message should display/not display desktop notification during firmware download and update.

if the parameter is specified, then the value will be set to the registry value:
 ```
HKLM:\SOFTWARE\WOW6432Node\Lenovo\Dock Manager\User Settings\General\EnableNotifications
```

```yaml
Type: String
Parameter Validation: Must be 1 or 0

Required: False
Position: Named
Default value: None
```

### -LogfileAgeToCleanup
The parameter sets age of logfile to delete in log directory in days unit. 
All the files in the directory "C:\ProgramData\Lenovo\DockManager\Logs\" which were modified before a number of days will be deleted. 
(E.g. All logs modified on 6/22/2020 or before will be deleted on 6/27/2020 when the days is set to 7.)

if the parameter is specified, then the value will be set to the registry value:
 ```
HKLM:\SOFTWARE\WOW6432Node\Lenovo\Dock Manager\User Settings\General\LogfileAgeToCleanup
```

```yaml
Type: String
Parameter Validation: Must be positive integer in range from 1 to 365

Required: False
Position: Named
Default value: None
```

### -LogfileMaxSize
The parameter sets log filesize in Kilobytes. In this case new log file will be created inside "C:\ProgramData\Lenovo\DockManager\Logs\" based on
the max file size set. Old log files will have their Log filenames appended with the current date and a new Log file will be created.

if the parameter is specified, then the value will be set to the registry value:
 ```
HKLM:\SOFTWARE\WOW6432Node\Lenovo\Dock Manager\User Settings\General\LogfileMaxSize
```

```yaml
Type: String
Parameter Validation: Must be positive integer

Required: False
Position: Named
Default value: None
```

### -RepositoryLocation
The parameter sets the Lenovo repository location from where the firmware updates will be downloaded.

if the parameter is specified, then the value will be set to the registry value:
 ```
HKLM:\SOFTWARE\WOW6432Node\Lenovo\Dock Manager\User Settings\General\RepositoryLocation
```

```yaml
Type: String
Parameter Validation: Must be a local folder path, a UNC file share path, or a URL to a web-hosted repository

Required: False
Position: Named
Default value: None
```

## MESSAGES
If the script executes from Microsoft Endpoint Configuration Manager it always returns 0 - Succeded.
The result of the work, errors and warnings that occurred during the execution of the script will be displayed as messages.
The messages could be of two types: *LDA_INFORMATION* and *LDA_ERROR* and also annotated with timestamp.

The following messages are possible:

### [LDA_INFORMATION_%TIMESTAMP%]:
* Script execution started.
* Script execution finished.

### [LDA_ERROR_%TIMESTAMP%]:
* %PARAMETERS_VALIDATION_ERROR_MESSAGE%
* Unexpected error occurred: %POWERSHELL_ERROR_MESSAGE%
* Lenovo Dock Manager was not found at the default installation path.

## REQUIREMENTS
* For the script working Lenovo Dock Manager must be installed on the client machine.

## RELATED LINKS

[Create and run PowerShell scripts from the Configuration Manager console](https://docs.microsoft.com/en-us/mem/configmgr/apps/deploy-use/create-deploy-scripts)

[Lenovo solutions How To's](https://support.lenovo.com/us/en/solutions/ht037099#dm)


