# Lenovo Device Management Module <!-- {docsify-ignore} -->

## Overview

The Lenovo Device Management Module is a PowerShell Module containing numerous cmdlets which provide useful information or simplified actions that can be leveraged in day to day management of Lenovo commercial PCs (ThinkPad, ThinkCentre, ThinkStation).

The Lenovo Device Management Module requires 64-bit PowerShell v5.1 or higher and runs on Windows 10 and Windows 11.

The module folder, LnvDeviceManagement, consists of the LnvDeviceManagement.psm1 and LnvDeviceManagement.psd1 files plus the Public and Private subfolders containing individual PowerShell scripts for the various functions. To manually install the module, there are two locations that the module folder can be copied to:

1. Per User:  %UserProfile%\Documents\WindowsPowerShell\Modules
1. All Users:  %ProgramFiles%\WindowsPowerShell\Modules

To ensure the module is loaded you may need to Import it first:

``` PowerShell
PS C:\> Import-Module LnvDeviceManagement -Force

PS C:\> Get-Module LnvDeviceManagement

ModuleType Version    Name                                ExportedCommands                                                                                               
---------- -------    ----                                ----------------                                                                                               
Script     0.0.4      LnvDeviceManagement                 {Add-LnvSUCommandLine, Add-LnvSULogging, Add-LnvSUSchedule, Export-LnvUpdateRetrieverConfig...}   
```

The Lenovo Device Management Module will also be available in the PowerShell Gallery which enables the ability to use Install-Module command:

``` PowerShell
PS C:\> Install-Module LnvDeviceManagement
```

## Cmdlet Reference

### Add-LnvSUCommandLine

### Description <!-- {docsify-ignore} -->
Run Script to set Admin command line Windows Registry settings for Lenovo System Update.

### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Search | String | True |
| Action | String | True |
| Scheduler | Int | False |
| IncludeRebootPackages | String | False |
| PackageTypes | String | False |
| NoReboot | False | Switch |
| NoIcon | Switch | False |
| RebootPrompt | Switch | False |
| Repository | String | False |
| ExportToWmi | Switch | False |

#### Search <!-- {docsify-ignore} -->
Must be one of the following values [C, R, A].

#### Action <!-- {docsify-ignore} -->
Must be one of the following values [DOWNLOAD, LIST, INSTALL].

#### IncludereBootPackages  <!-- {docsify-ignore} -->
Must be one of the following values [1, 3, 4, 5], or multiple values separated with a comma.

#### PackageTypes   <!-- {docsify-ignore} -->
Must be one of the following values [0, 1, 2, 3, 4], or multiple values separated with a comma.If not specified, System Update will use the Lenovo Support servers.

#### Repository  <!-- {docsify-ignore} -->
Must be a local folder path, a UNC file share path, or a URL to a web-hosted repository.

#### ExportToWmi   <!-- {docsify-ignore} -->

	INPUTS:
	None.

	OUTPUTS:
	System.Int32. 0 - success
	System.Int32. 1 - unsuccess

	Messages:
	[LDA_INFORMATION_%TIMESTAMP%]:
	Script execution started.
	Script execution finished.

	[LDA_ERROR_%TIMESTAMP%]:
	%PARAMETERS_VALIDATION_ERROR_MESSAGE%
	Unexpected error occurred: %POWERSHELL_ERROR_MESSAGE%
	Lenovo System Update was not found at the default installation path.

?>Read messages to determine the result of the script working.

### Add-LnvSULogging

### Description <!-- {docsify-ignore} -->
This cmdlet sets the appropriate registry key to cause the System Update Add-in to perfrom logging during update sessions. If neither the -Enable or -Disable switches are specified, then logging will be ENABLED.

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Enable | Switch | False |
| Disable | Switch | False |

### Example <!-- {docsify-ignore} -->
```Add-LnvSULogging -Enable```

?>If logging is enabled, log path is located at ```%ProgramData%\Lenovo\Vantage\AddinData\LenovoSystemUpdateAddin\logs```

### Add-LnvSUSchedule

### Description <!-- {docsify-ignore} -->
Script to schedule Lenovo System Update application via Task shceduler.

### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| RunAt | String | True |
| Frequency | String | True |
| WeeksInterval | String | False |
| DaysInterval | String | False |
| DaysOfWeek | String | False |

#### RunAt  <!-- {docsify-ignore} -->
Must correspond to the following formats:
yyyy-MM-ddTHH:mm:ss
yyyy-MM-dd
HH:mm:ss

#### Frequency  <!-- {docsify-ignore} -->
Must be one of the following values [Once, Daily, Weekly]

#### WeeksInterval  <!-- {docsify-ignore} -->
Must be a number greater than 0
Only when Frequency = "Weekly"

#### DaysInterval  <!-- {docsify-ignore} -->
Must be a number greater than 0
Only when Frequency = "Daily"

#### DaysOfWeek <!-- {docsify-ignore} -->
Only when $Frequency = "Weekly"
Must be one of the following values [Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday], or multiple values separated with a comma

?>Read messages to determine the result of the script working.

### Export-LnvUpdateRetrieverConfig

### Description <!-- {docsify-ignore} -->

Generates a .reg file containing an export of the Update Retriever settingsfound at:
```HKLM\Software\Wow6432Node\Lenovo\Update Retriever\Preferences\UserSetting\General```

These settings include the local repository path that was last used and the list of models in the Systems list that can be searched for in Update Retirever.

### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Outfile | String | True |

### Example <!-- {docsify-ignore} -->

```Export-LnvUpdateRetrieverConfig -Outfile C:\users\admin\Downloads\urconfig```

### Find-LnvBiosCode

#### Description <!-- {docsify-ignore} -->

Shows results for search string representing model friendly name or machine type. The BIOS code is the first four characters of the BIOS image name. It is a useful data point for uniquely targeting a model.

#### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| ModelName | String | True |

#### Example <!-- {docsify-ignore} -->

```Find-LnvBiosCode -ModelName 'ThinkPad X13 Yoga Gen 4'```

```Find-LnvBiosCode 'ThinkPad X13 Yoga Gen 4'```

### Find-LnvDockModel

#### Description <!-- {docsify-ignore} -->

- The first four characters of the dock product number is the machine type.
- This command returns the dock model name by searching for the machine type.
- The -Details switch controls whether the full dock details are displayed.
- If -Details is not specified then only the dock name will be returned.
- If -Details is provided then the PnP IDs for the USB Billboard device and the audio device will be shown. These can be used when targeting laptops that have this dock attached.

#### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |
| Details | Switch | False |

#### Example <!-- {docsify-ignore} -->

```Find-LnvDockModel -MachineType 40AN -Details```

### Find-LnvDriverPack

#### Description <!-- {docsify-ignore} -->

Returns a list of the available driver packs for the machine type specified which includes the OS and the OS build version, the CRC of the pack, and the URL to the package executable. The OS will be "win10" or "win11" and the OS build version will be the four character designator like "21H2" or "22H2".

#### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |

#### Example <!-- {docsify-ignore} -->

```Find-LnvDriverPack -MachineType 21DD```
```Find-LnvDriverPack 21DD```
``` $url = (Find-LnvDriverPack -MachineType 21DD | Where-Object { (($_.OS -eq 'win10')```
``` -and ($_.version -eq '21H2')) }).'#text'```

	OUTPUTS:
	An object consisting of "os", "version", "crc", "#text" elements where "#text" represents the URL to the package executable file.

?> The Where-Object cmdlet can be used to filter on OS and version to return just one URL.  The URL is in the '#text' field of the returned object.

### Find-LnvMachineType

#### Description <!-- {docsify-ignore} -->

By specifying a search string representing model friendly name, this cmdlet will return the possible machine types that match. Most models have more than one possible machine type. Providing a more detailed model name to search for will help reduce the number of results returned.

#### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| ModelName | String | True |

#### Example <!-- {docsify-ignore} -->

```$ Find-LnvMachineType -ModelName 'ThinkPad P1 Gen 5'```
```$ Find-LnvMachineType -ModelName 'ThinkPad P1 '```

?> A space after the model name such as 'ThinkPad P1 ' will limit the search to ThinkPad P1 models and not include ThinkPad P15 or ThinkPad P16 models. Likewise, use 'ThinkPad X1 ' to search for ThinkPad X1 Carbon and Yoga models and exclude ThinkPad X13 models.

### Find-LnvModel

#### Description <!-- {docsify-ignore} -->

This cmdlet returns the friendly model name that will be found in WMI on a device with the specified machine type. This is useful in cases where a management portal may display the 10 character machine type model number and the user needs to know the model name of that device.

#### Parameter <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |

#### Example <!-- {docsify-ignore} -->

```Find-LnvModel -MachineType 21DD```
```Find-LnvModel 21DD```

?>The output will also show the other machine types associated with this model.

### Find-LnvUpdate

#### Description <!-- {docsify-ignore} -->

This script allows users to search for updates for a specified machine type.
- Defaults to Windows 10 updates
- Requires users to enter at least a machine type
- Can be called without identifiers so long as you use the right order
- PackageType can be:  <br>
 1: Application <br>
 2: Driver <br>
 3: Bios <br>
 4: Firmware <br>
- RebootType can be: <br>
 1: Forced reboot (update itself initiates the reboot)<br>
 3: Requires reboot (Thin Installer/System Update/CV initiates the reboot)<br>
 4: Forces shutdown (update itself initiates shutdown)<br>
 5: Delayed forced reboot (used for firmware, Thin Installer/System Update/CV will enforce reboot with
 dialog displaying count-down timer)<br>
- Severity can be: <br>
 1: Critical <br>
 2: Recommended <br>
 3: Optional <br>

?>9 can be used for these three parameters to represent 'All'. Multiples can be combined by seperating with comma, for example:  "2,3,4" or "1,5" or "1,2"

Find-LnvUpdate displays a grid-view of the results. A single selected update can be
returned when the grid-view is closed. Therefore, execute the following to display the
search results and then capture the selected update object:

	> $update = Find-LnvUpdate -MachineType 21DD -WindowsVersion 11

Then it is possible to view the attributes of the update like this:

	> $update

		ID          : n3jw603w
		Name        : Qualcomm Bluetooth Driver - 11 (21H2 or later)
		Category    : Bluetooth and Modem
		Version     : 2.0.0.488
		PackageType : 2
		Reboot      : 3
		Severity    : 1
		Descriptor  : https://download.lenovo.com/pccbbs/mobiles/n3jw603w_2_.xml
		PackageExe  : https://download.lenovo.com/pccbbs/mobiles/n3jw603w.exe

It is then possible to get the executable or the package descriptor like this:

	> start $update.Descriptor

#### Parameters	 <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |
| PackageType | String | False |
| RebootType | String | False |
| Severity | String | False |
| WindowsVersion | String | False |
| PackageID | String | False |

#### Example <!-- {docsify-ignore} -->

```Find-LnvUpdate -MachineType 20C1 -PackageType 2 -RebootType 1 -WindowsVersion 7```

```Find-LnvUpdates 20C1 2```

```Find-LnvUpdate 20C1 -PackageType 2```

### Get-LnvAvailableBiosVersion

#### Description <!-- {docsify-ignore} -->

If you specify a machine type, the cmdlet will return the version of the  currently available BIOS update. If no machine type is specified, the cmdlet will use the running system's machine type and will compare the version of the currently available update to the version of the system and return an alert if the update is newer. The -Download switch can be used to trigger the download of the current update in either case.

#### Parameters	 <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | False |
| OS | String | False |
| Download | Switch | False |
| ReadMe | Switch | False |

?> OS is strictly optional as generally one BIOS update package is released for both Win10 and Win11.

### Get-LnvBiosCode

#### Description <!-- {docsify-ignore} -->

 This cmdlet will read the BIOS image name from the device and return the first four characters which can be used as the BIOS code in targeting actions to the model uniquely.

#### Example <!-- {docsify-ignore} -->

```Get-LnvBiosCode```

### Get-LnvBiosPasswordsSet

#### Description <!-- {docsify-ignore} -->

This cmdlet gets the BIOS password state of the system and interprets it to return the set of passwords set on the device. If the -Number switch is used, then the PasswordState number will be returned instead.

#### Parameters	 <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Number | Switch | False |

!>THIS CMDLET REQUIRES ADMIN RIGHTS TO EXECUTE. Make sure the PowerShell session is running with elevated privileges.

### Get-LnvBiosUpdateUrl

#### Description <!-- {docsify-ignore} -->

This command will return the URL to the current BIOS update package for either the specified machine type or for the machine type of the device running the command.

#### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | False |

#### Example <!-- {docsify-ignore} -->

```Get-LnvBiosUpdateUrl -MachineType '21AH'```
```Get-LnvBiosUpdateUrl```

?> The device must be a Lenovo ThinkPad, ThinkCentre, or ThinkStation.

### Get-LnvBiosVersion

#### Description <!-- {docsify-ignore} -->

Returns the BIOS version in the specified format.

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Format | String/Decimal | False |

?> String  : Returns the full string value of SMBIOSBIOSVersion
  Decimal : Returns a standard version string in the format of n.nn

#### Example <!-- {docsify-ignore} -->

```Get-LnvBiosVersion -Format 'decimal'```
```Get-LnvBiosVersion```

?>This function handles the different methods used to express the BIOS version
between ThinkPad and ThinkCentre/ThinkStation. Desktop BIOS will show build
number in hex and the 'decimal' format will convert to a standard version
string format.

?>If no Format is specified, the function will return the full string of the
SMBIOSBIOSVersion value.

### Get-LnvCVE

#### Description <!-- {docsify-ignore} -->

Returns a list of the CVE identifiers that are listed as addressed
vulnerabilities in the current BIOS update for the specified system. A machine
type can be passed as a parameter.  If no parameter is specified, the machine
type of the running system will be used. CVE Data may not be available for all
machine types.

#### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | False |

#### Example <!-- {docsify-ignore} -->

```Get-LnvCVE -MachineType 21DD```

```Get-LnvCVE```

### Get-LnvDriverPack

#### Description <!-- {docsify-ignore} -->

This cmdlet will download the SCCM Driver Pack based on the specified machine type, OS and OS build version. Tab completion can be used to select the OS build version in the correct format. The cmdlet will leverage the default browser for downloading the pack so the user can select the location to save the file to.

#### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |
| WindowsVersion | String | True |
| OSBuildVersion | String | True |

### Get-LnvMachineType

#### Description <!-- {docsify-ignore} -->
Returns the 4 character machinetype of the running device.

#### Parameters <!-- {docsify-ignore} -->
None

#### Example <!-- {docsify-ignore} -->
```Get-LnvMachineType```

### Get-LnvModelName

#### Description <!-- {docsify-ignore} -->
Returns the model name of the running device.

#### Parameters <!-- {docsify-ignore} -->
None

#### Example <!-- {docsify-ignore} -->
```Get-LnvModelName```

### Get-LnvProductNumber

#### Description <!-- {docsify-ignore} -->
Returns the full 10-character product number of the running device.

#### Parameters <!-- {docsify-ignore} -->
None

#### Example <!-- {docsify-ignore} -->
```Get-LnvProductNumber```

### Get-LnvSerial

#### Description <!-- {docsify-ignore} -->
Returns the serial number of the running device.

#### Parameters <!-- {docsify-ignore} -->
None

#### Example <!-- {docsify-ignore} -->
```Get-LnvSerial```

### Get-LnvUpdate

#### Description <!-- {docsify-ignore} -->
This script allows users to search for updates that will be downloaded to a folder of their choice
- Defaults to Windows 10 updates and a repo folder in downloads if you do not specify
- Requires users to enter at least a machine type
- Can be called without identifiers so long as you use the right order
- If a repository folder is specified that doesn't exist the script will create it
- PackageType can be:  <br>
&nbsp;&nbsp; 1: Application <br>
&nbsp;&nbsp; 2: Driver <br>
&nbsp;&nbsp; 3: Bios <br>
&nbsp;&nbsp; 4: Firmware <br>
- RebootType can be: <br>
&nbsp;&nbsp; 1: Forced reboot (update itself initiates the reboot) <br>
&nbsp;&nbsp; 3: Requires reboot (Thin Installer/System Update/CV initiates the reboot) <br>
&nbsp;&nbsp; 4: Forces shutdown (update itself initiates shutdown) <br>
&nbsp;&nbsp; 5: Delayed forced reboot (used for firmware, Thin Installer/System Update/CV will enforce reboot with dialog displaying count-down timer)<br>
- Severity can be:<br>
&nbsp;&nbsp; 1: Critical <br>
&nbsp;&nbsp; 2: Recommended <br>
&nbsp;&nbsp; 3: Optional <br>

?>Note: 9 can be used for these three parameters to represent 'All'

#### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | True |
| WindowsVersion | String | False |
| RepositoryFolder | String | False |
| PackageType | String | False |
| RebootType | String | False |

#### Example <!-- {docsify-ignore} -->

```Get-LnvUpdate -MachineType 20E4 -WindowsVersion 10 -RepositoryFolder "C:\repository" -PackageStringType 1```

```Get-LnvUpdate 20E4 10 "C:\repository"```

```Get-LnvUpdate -MachineType "20E6" -RepositoryFolder "C:\repository"```

### Get-LnvUpdatesRepo

#### Description <!-- {docsify-ignore} -->
For instances where Update Retriever cannot be used to create the local repository or where full automation of the repository creation is desired. This PowerShell script can be customized and executed on a regular basis to get the latest update packages.

#### Parameters   <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| MachineType | String | False |
| OS | String | False |
| PackageTypes | String | False |
| RebootTypes | String | False |
| RepositoryPath | String | True |
| LogPath | String | False |
| RT5toRT3 | Switch | False |
| ScanOnly | Switch | False |

##### OS   <!-- {docsify-ignore} -->
Must be a string of '10' or '11'. The default if no value is specified will
be determined by the OS of the device the script is running on.

##### PackageTypes    <!-- {docsify-ignore} -->
Must be a string of Package Type integers separated by commas and surrounded by single quotes. The possible values are:<br>
&nbsp;&nbsp; 1: Application<br>
&nbsp;&nbsp; 2: Driver<br>
&nbsp;&nbsp; 3: BIOS<br>
&nbsp;&nbsp; 4: Firmware<br>
The default if no value is specified will be all package types.

##### RebootTypes   <!-- {docsify-ignore} -->
Must be a string of integers, separated by commas, representing the different boot types and surrounded by single quotes:<br>
&nbsp;&nbsp; 0: No reboot required<br>
&nbsp;&nbsp; 1: Forces a reboot (not recommended in a task sequence)<br>
&nbsp;&nbsp; 3: Requires a reboot (but does not initiate it)<br>
&nbsp;&nbsp; 4: Forces a shutdown (not used much anymore)<br>
&nbsp;&nbsp; 5: Delayed forced reboot (used by many firmware updates)<br>
The default if no value is specified will be all RebootTypes.

##### RepositoryPath   <!-- {docsify-ignore} -->
Must be a fully qualified path to the folder where the local repository will be saved. Must be surrounded by single quotes.

##### LogPath   <!-- {docsify-ignore} -->
Must be a fully qualified path. If not specified, ti-auto-repo.log will be  stored in the repository folder.
Must be surrounded by single quotes.

##### RT5toRT3   <!-- {docsify-ignore} -->
Specify this parameter if you want to convert Reboot Type 5 (Delayed Forced Reboot) packages to be Reboot Type 3 (Requires Reboot). Only do this in task sequence scenarios where a Restart can be performed after the Thin Installer task. Use the -noreboot parameter on the Thin Installer command line to suppress reboot to allow the task sequence to control the restart.

?>This parameter can only be used when Thin Installer will be processing
the updates in the repository.

##### ScanOnly   <!-- {docsify-ignore} -->
Specify this parameter to create a repository that only contains the package
descriptor XML and external detection routine files to be used with Thin
Installer's SCAN action.

#### Example <!-- {docsify-ignore} -->
```Get-LnvUpdatesRepo.ps1 -RepositoryPath 'C:\Program Files (x86)\Lenovo\ThinInstaller\Repository'```
``` -PackageTypes '1,2' -RebootTypes '0,3'```

```Get-LnvUpdatesRepo.ps1 -RepositoryPath 'Z:\21DD' -PackageTypes '1,2,3' -RebootTypes '0,3,5' -RT5toRT3```

	INPUTS:
	None

	OUTPUTS:
	System.Int32. 0 - success
	System.Int32. 1 - fail

### Invoke-LnvDiagnostic

#### Description <!-- {docsify-ignore} -->
Script to run diagnostic test on Lenovo devices

#### Parameters <!-- {docsify-ignore} -->

| Parameter | Type | Mandatory |
| --- | --- | --- |
| RunAll | String | False |
| RunOnModules | String | False |

##### RunAll  <!-- {docsify-ignore} -->
Must be either "default" or one of the following modes [quick, extended, only-unattended], or a combination of the modes [quick, extended, only-unattended].

##### RunOnModules   <!-- {docsify-ignore} -->
Must be one of the following modules
[audio, audio_controller, battery, bluetooth, camera, cpu, display, display_interface, fan,
fingerprint, keyboard, memory, motherboard, mouse_devices, optical_drive, pci_express, raid,
sensors, storage, touchpad_devices, touchscreen, video_card, wired_ethernet, wireless], or a combination of comma-separated modules.

	INPUTS:
	None

	OUTPUTS:

	Messages:
	[LDMM_INFORMATION_%TIMESTAMP%]:
	Script execution started.
	Script execution finished.

	[LDMM_ERROR_%TIMESTAMP%]:
	%PARAMETERS_VALIDATION_ERROR_MESSAGE%
	Only one of the parameters must be specified.
	One of the parameters must be specified.
	Lenovo Diagnostics was not found at the default installation path.
	Unexpected error occurred: %POWERSHELL_ERROR_MESSAGE%

?>Read messages to determine the result of the script working.

### Show-LnvApplicableUpdate

#### Description <!-- {docsify-ignore} -->
Read an Update_ApplicabilityRulesTrace.txt from Thin Installer or ApplicabilityRulesTrace.txt from Lenovo System Update and show list of package IDs that are applicable.  This output string can be passed to the Get-LnvUpdatesRepo cmdlet in the -PackageList parameter to create a local repository of just the specified updates.

| Parameter | Type | Mandatory |
| --- | --- | --- |
| Path | String | True |

#### Example <!-- {docsify-ignore} -->
```Show-LnvApplicableUpdates -Path 'c:\Program Files (x86)\Lenovo\Thin Installer\logs\Update_ApplicabilityRulesTrace.txt'```
