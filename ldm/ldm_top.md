## Lenovo Device Management  <!-- {docsify-ignore} -->


**Key**|**Value**
---|---
---|---
Find-LnvBiosCode|Find-LnvBiosCode
Find-LnvDockModel|Find-LnvDockModel
Find-LnvDriverPack|Find-LnvDriverPack
Find-LnvMachineType|Find-LnvMachineType
Find-LnvModel|Find-LnvModel
Find-LnvUpdate|Find-LnvUpdate
Get-LnvAvailableBiosVersion|Get-LnvAvailableBiosVersion
Get-LnvBiosCode|Get-LnvBiosCode
Get-LnvBiosPasswordsSet|Get-LnvBiosPasswordsSet
Get-LnvBiosUpdateUrl|Get-LnvBiosUpdateUrl
Get-LnvBiosVersion|Get-LnvBiosVersion
Get-LnvCVE|Get-LnvCVE
Get-LnvDriverPack|Get-LnvDriverPack
Get-LnvMachineType|Get-LnvMachineType
Get-LnvModelName|Get-LnvModelName
Get-LnvProductNumber|Get-LnvProductNumber
Get-LnvSerial|Get-LnvSerial
Get-LnvUpdate|Get-LnvUpdate
Get-LnvUpdatesRepo|Get-LnvUpdatesRepo
Invoke-LnvDiagnostic|Invoke-LnvDiagnostic
Set-LnvSUCommandLine|Set-LnvSUCommandLine
Set-LnvSULogging|Set-LnvSULogging
Set-LnvSUSchedule|Set-LnvSUSchedule





## Find-LnvUpdate

### Description
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

### Parameters	

#### MachineType
Mandatory: True

#### PackageType
Mandatory: False

#### RebootType
Mandatory: False

#### Severity
Mandatory: False

#### WindowsVersion
Mandatory: False

#### PackageID
Mandatory: False

### Example
```Find-LnvUpdate -MachineType 20C1 -PackageType 2 -RebootType 1 -WindowsVersion 7```

```Find-LnvUpdates 20C1 2```

```Find-LnvUpdate 20C1 -PackageType 2```


## Get-LnvBiosUpdateUrl

### Description
This command will return the URL to the current BIOS update package for either the specified machine type or for the machine type of the device running the command. 

### Parameters

#### MachineType
Mandatory: False

### Example
	
```Get-LnvBiosUpdateUrl -MachineType '21AH'```

?> The device must be a Lenovo ThinkPad, ThinkCentre, or ThinkStation.


## Get-LnvCVE

### Description
Returns a list of the CVE identifiers that are listed as addressed 
vulnerabilities in the current BIOS update for the specified system. A machine
type can be passed as a parameter.  If no parameter is specified, the machine
type of the running system will be used. CVE Data may not be available for all 
machine types.

### Parameters

#### MachineType
The four-character machine type of the system to check for.

### Example
```Get-LnvCVE -MachineType 21DD```

```Get-LnvCVE```



## Get-LnvUpdate

### Description
This script allows users to search for updates that will be downloaded to a folder of their choice
- Defaults to Windows 10 updates and a repo folder in downloads if you do not specify
- Requires users to enter at least a machine type
- Can be called without identifiers so long as you use the right order 
- If a repositoryfolder is specified that doesn't exist the script will create it
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

### Parameters

#### MachineType

#### WindowsVersion

#### RepositoryFolder

#### PackageType
	
#### RebootType

### Example

```Get-LnvUpdate -MachineType 20E4 -WindowsVersion 10 -RepositoryFolder "C:\repository" -PackageType 1```

```Get-LnvUpdate 20E4 10 "C:\repository"```

```Get-LnvUpdate -MachineType "20E6" -RepositoryFolder "C:\repository"```


## Get-LnvUpdatesRepo

### Description
For instances where Update Retriever cannot be used to create the local repository or where full automation of the repository creation is desired. This PowerShell script can be customized and executed on a regular basis to get the latest update packages. 

### Parameters  
#### MachineTypes
Mandatory: False   
Data type: String  
Must be a string of machine type ids separated with comma and surrounded by single quotes. Although multiple machine types can be specified, it is recommended to keep the list small to reduce download times for all updates. If no value is specified, the machine type of the device running the script will be used.

#### OS
Mandatory: False   
Data type: String   
Must be a string of '10' or '11'. The default if no value is specified will
be determined by the OS of the device the script is running on.

#### PackageTypes  
Mandatory: False   
Data type: String   
Must be a string of Package Type integers separated by commas and surrounded by single quotes. The possible values are:<br>
&nbsp;&nbsp; 1: Application<br>
&nbsp;&nbsp; 2: Driver<br>
&nbsp;&nbsp; 3: BIOS<br>
&nbsp;&nbsp; 4: Firmware<br>
The default if no value is specified will be all package types.

#### RebootTypes
Mandatory: False   
Data type: String   
Must be a string of integers, separated by commas, representing the different boot types and surrounded by single quotes:<br>
&nbsp;&nbsp; 0: No reboot required<br>
&nbsp;&nbsp; 1: Forces a reboot (not recommended in a task sequence)<br>
&nbsp;&nbsp; 3: Requires a reboot (but does not initiate it)<br>
&nbsp;&nbsp; 4: Forces a shutdown (not used much anymore)<br>
&nbsp;&nbsp; 5: Delayed forced reboot (used by many firmware updates)<br>
The default if no value is specified will be all RebootTypes. 

#### RepositoryPath
Mandatory: True   
Data type: string   
Must be a fully qualified path to the folder where the local repository will be saved. Must be surrounded by single quotes.

#### LogPath
Mandatory: False    
Data type: String   
Must be a fully qualified path. If not specified, ti-auto-repo.log will be  stored in the repository folder.   
Must be surrounded by single quotes.

#### RT5toRT3
Mandatory: False   
Data type: Switch   
Specify this parameter if you want to convert Reboot Type 5 (Delayed Forced Reboot) packages to be Reboot Type 3 (Requires Reboot). Only do this in task sequence scenarios where a Restart can be performed after the Thin Installer task. Use the -noreboot parameter on the Thin Installer command line to suppress reboot to allow the task sequence to control the restart.

?>This parameter can only be used when Thin Installer will be processing
the updates in the repository.

#### ScanOnly
Mandatory: False   
Data type: Switch   
Specify this parameter to create a repository that only contains the package
descriptor XML and external detection routine files to be used with Thin 
Installer's SCAN action.

### Example
```Get-LnvUpdatesRepo.ps1 -RepositoryPath 'C:\Program Files (x86)\Lenovo\ThinInstaller\Repository' -PackageTypes '1,2' -RebootTypes '0,3'```
  
```Get-LnvUpdatesRepo.ps1 -RepositoryPath 'Z:\21DD' -PackageTypes '1,2,3' -RebootTypes '0,3,5' -RT5toRT3```
 
	INPUTS:
	None

	OUTPUTS:
	System.Int32. 0 - success
	System.Int32. 1 - fail
    

## Invoke-LnvDiagnostic

### Description
Script to run diagnostic test on Lenovo devices

###Parameters

#### RunAll
Data type: String  
Must be either "default" or one of the following modes [quick, extended, only-unattended], 
or a combination of the modes [quick, extended, only-unattended]

#### RunOnModules
Data type: String   
Must be one of the following modules   
[audio, audio_controller, battery, bluetooth, camera, cpu, display, display_interface, fan, 
fingerprint, keyboard, memory, motherboard, mouse_devices, optical_drive, pci_express, raid, 
sensors, storage, touchpad_devices, touchscreen, video_card, wired_ethernet, wireless], 
or a combination of comma-separated modules

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


## Set-LnvSUCommandLine

### Description
Run Script to set Admin command line Windows Registry settings for Lenovo System Update
  
### Parameters

#### Search
Mandatory: True  
Data type: String  
Must be one of the following values [C, R, A]

#### Action
Mandatory: True  
Data type: String  
Must be one of the following values [DOWNLOAD, LIST, INSTALL]

#### Scheduler
Data type: Int  
Must be 1 or 0

#### IncludereBootPackages
Data type: String   
Must be one of the following values [1, 3, 4, 5], or multiple values separated with a comma

#### PackageTypes
Data type: String  
Must be one of the following values [0, 1, 2, 3, 4], or multiple values separated with a comma

#### NoReboot
Data type: Int  
Must be 1 or 0  

#### NoIcon
Data type: Int  
Must be 1 or 0  

#### RebootPrompt
Data type: Int   
Must be 1 or 0   

#### Repository
Data type: String   
Must be a local folder path, a UNC file share path, or a URL to a web-hosted repository  

#### ExportToWmi
Data type: Int  
Must be 1 or 0  


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


## Set-LnvSULogging

### Description
Enable or disable logging for the System Update Addin for Commercial Vantage

### Parameters
#### Enable
Enables logging

#### Disable
Disables logging

### Example

```Set-LnvSULogging -Enable```

?>If logging is enabled, log path is located at %ProgramData%\Lenovo\Vantage\AddinData\LenovoSystemUpdateAddin\logs

## Set-LnvSUSchedule

### Description
Script to schedule Lenovo System Update application via Task shceduler

### Parameters

#### RunAt
Mandatory: True  
Data type: String  
Must correspond to the following formats:  
yyyy-MM-ddTHH:mm:ss  
yyyy-MM-dd  
HH:mm:ss  

#### Frequency
Mandatory: True   
Data type: String  
Must be one of the following values [Once, Daily, Weekly]

#### WeeksInterval
Data type: String  
Must be a number greater than 0   
Only when Frequency = "Weekly"  

#### DaysInterval
Data type: String   
Must be a number greater than 0  
Only when Frequency = "Daily"  

#### DaysOfWeek
Data type: String  
Only when $Frequency = "Weekly"   
Must be one of the following values [Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday], or multiple values separated with a comma

	INPUTS:
	None.

	OUTPUTS:

?>Read messages to determine the result of the script working.