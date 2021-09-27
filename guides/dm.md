# Dock Manager

## Preface

Lenovo Dock Manager is a new solution that reduces the effort that IT administrators spend on the large scale deployment of Lenovo dock firmware updates.  This solution runs on your PC and maintains a cache of the current firmware versions for supported Lenovo docks.  When a dock is attached that has down-level firmware, it is automatically updated by Dock Manager.  Video resources and links that may be helpful can be found below:

[Lenovo Dock Manager Overview](https://support.lenovo.com/videos/nvid500262)

[Firmware Updates and Information Queries](https://support.lenovo.com/videos/nvid500261)

[Configuration and Deployment](https://support.lenovo.com/videos/nvid500260)

Dock Manager and User Guide can be downloaded [here](https://support.lenovo.com/us/en/solutions/ht037099#dm)

Dock Manager can automatically download firmware updates from Lenovo Support directly over the Internet or from a local repository on your network that is created and maintained using Update Retriever. The four-character "machine type" for the supported docks listed below can be used in Update Retriever when searching for the latest firmware packages.

The application can also record data from docks into WMI (root\Lenovo\Dock_Manager) for administrators to query remotely for management purposes.  Such details can include:

* Dock Machine Type
* Firmware Version
* MAC Address
* Connected Devices - Monitors, USB Devices

## Supported Docks

* ThinkPad Universal Thunderbolt 4 Dock - [40B0](https://support.lenovo.com/solutions/pd500503)
* ThinkPad Universal USB-C Dock - [40AY](https://support.lenovo.com/solutions/pd500519)
* ThinkPad Thunderbolt 3 Essential Dock - [40AV](https://support.lenovo.com/solutions/PD500373)
* ThinkPad Thunderbolt 3 Dock Gen 1 [40AC](https://support.lenovo.com/solutions/ACC100356)
* ThinkPad Thunderbolt 3 Dock Gen 2 - [40AN](https://support.lenovo.com/solutions/PD500265)
* ThinkPad Thunderbolt 3 Workstation Dock Gen 2 - [40AN](https://support.lenovo.com/solutions/PD500333)
* ThinkPad USB-C Dock Gen 1 - [40A9](https://support.lenovo.com/solutions/ACC100348)
* ThinkPad USB-C Dock Gen 2 - [40AS](https://support.lenovo.com/solutions/ACC500106)
* ThinkPad USB-C with USB-A Dock - [40AF](https://support.lenovo.com/solutions/PD500180)

## Deploying with Microsoft Configuration Manager (MEMCM)

Dock Manager is provided as an executable.  Here's an example of how to deploy with Microsoft Endpoint Manager Configuration Manager (ConfigMgr) using the Application model.

In the console, navigate to the **Software > Application Management > Applications** node and click **Create Application** in the ribbon bar.

Tick the **Manually specify the application information** radio button, click Next

![1](../img/guides/dm/image1.png)

Specify information about the app, click **Next**

![2](../img/guides/dm/image2.png)

Enter Software Center details, click **Next**

![ ](../img/guides/dm/image3.png)

Set the deployment type to **Script Installer** and click **Next**

![](../img/guides/dm/image4.png)

Set the deployment type name and click **Next**

![](../img/guides/dm/image5.png)

Enter the content location path to the Dock Manager executable

Install command:
```
"dock_manager_setup.exe" /VERYSILENT
```
Uninstall command:
```
unins000.exe /SILENT
```
Uninstall start in:
```
%ProgramFiles%\Lenovo\Dock Manager
```
![](../img/guides/dm/image6.png)

Set the detection rule setting type to **Registry**

Hive: **HKLM**

Key:
```
SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\DockManager_is1
```
Value:
```
DisplayVersion
```
Data Type: **String**

Tick the radio button for **This registry setting must satisfy the following rule...**
Operator: **Equals**
Value:
```
1.0.0.125
```
![](../img/guides/dm/image7.png)

Set the installation behavior to **Install for system** and logon requirement to **Whether or not a user is logged on**

Add any installation requirements such as Operating system is One of Windows 10 (64-bit)

![](../img/guides/dm/image8.png)

Complete the deployment type and App wizards.  Deploy to a Device Collection.

## Deploying with Microsoft Intune

Using the Win32 Content Prep [Tool](https://github.com/Microsoft/Microsoft-Win32-Content-Prep-Tool), convert the Dock Manager installer to an .intunewin format.  A sample command would look like this:

```
IntuneWinAppUtil.exe -c "C:\IntuneWin\DM\" -s "dock_manager_setup.exe" -o "C:\IntuneWin\output\" -q
```

![](../img/guides/dm/image9.png)

Login to the Endpoint admin center [portal](https://endpoint.microsoft.com/#blade/Microsoft_Intune_DeviceSettings/AppsWindowsMenu/windowsApps) to create a new Windows app and select the **Windows app (Win32)** type.

Select the **dock_manager_setup.intunewin** app package file.

Enter required and optional information about the app

![](../img/guides/dm/image10.png)

Enter the Install command
```
dock_manager_setup.exe /VERYSILENT
```
and Uninstall command
```
%ProgramFiles%\Lenovo\Dock Manager\unins000.exe /SILENT
```
![](../img/guides/dm/image11.png)

Set the requirements.  You can take it a bit further with a detection script to check if a supported dock is currently connected to the system.  Here's a sample PowerShell script
```
# Check for Thunderbolt 3 Dock Gen 2
$dock = Get-WmiObject -Class Win32_PnPEntity | Where-Object { $_.DeviceID -like 'USB\VID_2109&PID_8887*' }
if ($dock) {
    Write-Output "Thunderbolt 3 Dock Detected!"
}
else {
    Exit 1
}
```
![](../img/guides/dm/image12.png)

Enter the detection rules to verify the current version of Dock Manager is installed

Key path:
```
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\DockManager_is1
```

Value name: **DisplayVersion**

Detection method: **String comparison**

Operator: **Equals**

Value: **1.0.0.125**

![](../img/guides/dm/image13.png)

Finish out the wizard and assign to a group.

## WMI Classes

You can [extend hardware inventory](https://docs.microsoft.com/en-us/mem/configmgr/core/clients/manage/inventory/extend-hardware-inventory) in Config Manager to collect the data written by Dock Manager on your clients by importing the provided .mof file below:

[Download](https://download.lenovo.com/cdrt/blog/ConfigMgr-MOF-DockManager.zip)

An example from Resource Explorer

![](../img/guides/dm/image14.png)

Sample report of what can be gathered using SSRS

![](../img/guides/dm/image15.png)