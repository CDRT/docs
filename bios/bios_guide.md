# Lenovo BIOS/UEFI Deployment Guide

## Introduction

This document will cover various topics on managing BIOS/UEFI for Lenovo Think PCs. As these products are aimed at commercial customers, there are unique scenarios which require special considerations to support large fleets of PCs in an enterprise environment. This document will focus on how to update and manage BIOS/UEFI settings using typical IT practices in such an environment. This document may contain references to Microsoft Deployment Toolkit [MDT] or System Center Configuration Manager [SCCM]; however, in general, the same principles will apply to other systems management solutions. 

## Updating BIOS

### Overview

Updating or installing a new version of the BIOS can be done two ways: by manual install or through automation. The BIOS can be updated through different methods: in the OS (Windows), in WinPE (Windows Pre-execution Environment), by an EFI-bootable USB drive, or a DOS-bootable USB drive. In some organizations other aspects are to be considered when updating the BIOS, such as performing an update when a Supervisor Password is present or even a fully automated PXE deployment that can, with some management, update the BIOS in your organization in a tightly controlled environment.

Updating the BIOS has to be done carefully to ensure that it is applied to the system without issue. BIOS updates for Lenovo Think brand devices are best applied from a local resource, such as the C:\ drive or the system drive in the full running Operating System, or from the X:\ drive in WinPE. Applying the update from a network resource is not advised. Were the connection to be lost in the middle of an update, irreparable damage could be done to the BIOS, potentially rendering the device unusable.

### OS

Updating the BIOS in the Operating System can be done a few different ways: manually, by script, by software deployment push, or by a task sequence. Currently, each of the three Think brands have their own BIOS installation process.

<details>
<summary>ThinkPad Manual Installation </Summary>

ThinkPad executes WINUPTP.exe or WINUPTP64.exe from the extracted files location, depending on the operating system architecture. To manually install a ThinkPad BIOS update, navigate to the Lenovo Support page, enter in the model of ThinkPad, and download the BIOS Update for Windows (BIOS Update Utility). After it is downloaded, run the downloaded program to begin the extraction process.

<div style="text-align:center;padding-top:10px;padding-bottom:10px;">

![](../img/guides/bios/bios1.png) <br/>
_**Step 1**: Accept the EULA and click **Next**._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios2.png) <br/>
_**Step 2**: Leave the default location selected for extraction and click **Next**._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios3.png) <br/>
_**Step 3**: Click **Install**. The program will extract to the default location on the hard drive._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios4.png) <br/>
_**Step 4**: Once completed, the installer should have a check mark on the page. Leave the check box checked and click **Finish**. This should immediately prompt to begin the BIOS Update._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios5.png)<br/>
_**Step 5**: Select Update ThinkPad BIOS if not already selected and click **Next**._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios6.png)<br/>
_**Step 6**: Follow the instructions on this screen and click **Next**._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios7.png)<br/>
_**Step 7**: Follow the instructions and click **Yes** to continue._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios8.png) </br>
_**Step 8**: Wait while it prestages the new ROM image file. **DO NOT POWER OFF THE SYSTEM** at this point._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios9.png) </br>
_**Step 9**: Click **OK** to reboot the system immediately._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios10.png) </br>
_**Step 10**: After it reboots, the laptop will begin to write the prestaged BIOS image to the chip. At this point, **DO NOT POWER OFF** the laptop!!!_
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios11.png) </br>
_**Step 11**: When the BIOS update completes, it will reboot the computer._
</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios12.png) </br>
_**Step 12**: If an update for the Embedded Controller firmware is included in the update, the system will show the splash screen with text stating “Flashing Embedded Controller.” Allow this process to complete and the system will reboot to the OS._
</div>
</details>

<details>
<summary>ThinkPad Automated Installation</summary>

To automate the ThinkPad BIOS update, the WINUPTP.exe and WINUPTP64.exe both have a –s command line parameter to suppress any prompts or message boxes from displaying during installation of the update. WINUPTP.exe and WINUPTP64.exe also supports a –r command line parameter to force a reboot after prestaging the new BIOS image file. During the reboot, the computer may boot three times, once to apply the BIOS update to the ROM, once to potentially install an embedded controller update, and a final time to boot back into the operating system.

Assuming that the BIOS update is to be applied during a task sequence, from either MDT or SCCM, in the full operating system, there are a few items that need to be touched on. First, installing the BIOS update from a local hard drive is the safest choice. Since that is a requirement, use a copy command to copy the BIOS installer from the network to the local hard drive. Second, in a step to run an executable, call the WINUPTP.exe or WINUPTP64.exe with the –s command line parameter. The final step is to initiate a system reboot through the task sequence.

?>NOTE: It is best practice to not use the –r command line parameter in a task sequence. When running task sequences, it is best practice to allow the task sequence to control the reboot and not allow the installing executable to do so. Allowing the task sequence to control the reboot will allow the task sequence to make all necessary changes to the computer, including setting up to resume the task sequence in the correct location after the reboot sequence has completed.

When updating a ThinkPad BIOS, if a Supervisor password is set and the “Flash BIOS Updating by End-Users” is set to factory default (Enabled), there are no additional steps to be taken to update the BIOS. If the “Flash BIOS Updating by End-Users” is not set to factory default (Enabled), then steps will need to be taken to switch the setting to Enabled using the Think BIOS Configuration Tool or the BIOS Settings VBScripts. After that is set to allow the update to be run, the BIOS can be updated. If needed, utilize the tools mentioned to change the setting back after applying the BIOS update. 
</details>

<details>
<summary>ThinkCentre Manual Installation</summary>

ThinkCentre executes Flash.cmd from the extracted files location. To manually install a ThinkCentre BIOS update, navigate to the Lenovo Support page, enter in the model of ThinkCentre, and download the “Flash UEFI BIOS update (Flash from operating system version)”. After it is downloaded, run the downloaded program to begin the extraction process.

<div style="text-align:center;padding-top:10px;padding-bottom:10px;">

![](../img/guides/bios/bios13.png) <br/>
_**Step 1**: Accept the EULA and click **Next**._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios14.png) <br/>
_**Step 2**: Leave the default location selected for extraction and click **Next**. This will extract the files and then automatically kick off the installation.._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios15.png) <br/>
_**Step 3**: Click **Yes** to continue with the BIOS update._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios16.png) <br/>
_**Step 4**: Press the “N” key and press._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios17.png) <br/>
_**Step 5**: Press the “N” key and press . Once is pressed, a command window will pop up with yellow writing. Wait while it loads the ROM file into the BIOS update inbox. **DO NOT POWER OFF THE SYSTEM** at this point. The system will reboot on its own._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios18.png) <br/>
_**Step 6**: Writing the new boot block._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios19.png) <br/>
_**Step 7**: Writing the new image._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios20.png) <br/>
_**Step 8**: Writing the new nvram block._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios21.png) <br/>
_**Step 9**: Writing the new main block. After writing the main block, the computer will reboot on its own. It may restart a second time if it needs to program the embedded controller._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios22.png) <br/>
_**Step 10**: Booting up._
</div>
</details>

<details>
<summary>ThinkCentre Automated Installation </summary>

To automate the ThinkCentre BIOS update, the FLASH.CMD file can be executed with the /quiet command line parameter. FLASH.CMD executes WFlash2.exe with predetermined command line parameters attached. FLASH.CMD is designed to pass any command line parameters to the WFlash2.exe in the command file.

To update the BIOS in an automated solution use the command line parameter /quiet. The /quiet command line parameter will allow the update of the BIOS through WFlash2.exe without physical presence or other interaction.

Some versions of WFlash2.exe support the /sccm parameter. The /sccm parameter is intended for use in a task sequence and will suppress the reboot until the administrator chooses to do so. Check the readme.txt in the extracted BIOS folder or run WFlash2.exe /? to verify that the version of WFlash2.exe you are using supports this option.

If there is a Supervisor password controlling access to the BIOS and the Require Admin Pass when Flashing BIOS setting is set to NO, there is nothing to do to apply the BIOS update. In the event that there is a Supervisor password controlling access to the BIOS and the Require Admin Pass when Flashing BIOS setting is set to YES, WFlash2.exe has a command line parameter to allow input of the password for execution in an automated solution. The command line parameter is /pass:nnnnnn where nnnnnn is the password.

Example: 

	Flash.cmd /quiet /pass:Qwerty 

</details>

<details>
<summary>ThinkStation Manual Installation </summary>

ThinkStation executes Flash.cmd or Flashx64.cmd from the extracted files location, depending on the operating system architecture. To manually install a ThinkStation BIOS update, navigate to the Lenovo Support page, enter in the model of ThinkStation, and download the "Flash UEFI BIOS update (Flash from operating system version)". After the package is downloaded, execute it to begin the extraction process.

<div style="text-align:center;padding-top:10px;padding-bottom:10px;">

![](../img/guides/bios/bios23.png) <br/>
_**Step 1:** Click Next on the Welcome screen._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios24.png) <br/>
_**Step 2**: Accept the EULA and click **Next**._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios25.png) <br/>
_**Step 3**: Leave the default location selected for extraction and click **Next**._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios26.png) <br/>
_**Step 4**:  Click **Install**. The program will extract to the default location on the hard drive._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios27.png) <br/>
_**Step 5**: Click **Finish** to complete the extraction. Navigate to the folder where the BIOS update was extracted and execute Flash.cmd (If the account does not have administrator rights, right click on the .cmd file and select “Run as Administrator”)._

</div>
<div style="text-align:center;padding-bottom:10px;">

![](../img/guides/bios/bios28.png) <br/>
_While the update executes, the keyboard and mouse will be inaccessible. This is to prevent any actions from interfering with the execution. After the command window closes, manually restart the computer. The computer will then reboot to the Lenovo splash screen a few times and will boot back into the operating system._

</div>
</details>

<details>
<summary>ThinkStation Automated Installation </summary>

To automate the ThinkStation BIOS update, either AFUWIN.exe or AFUWINx64.exe can be executed with a set of command line parameters. Use the following command to perform the silent update:

	X86: AFUWIN.exe  /P /B /N /R /SP /RTB /FIT /Q
	OR
	X64: AFUWINx64.exe  /P /B /N /R /SP /RTB /FIT /Q

If there is a Supervisor password controlling access to the BIOS and the Require Admin Pass when Flashing BIOS setting is set to NO, there is nothing to do to apply the BIOS update. In the event that there is a Supervisor password controlling access to the BIOS and the Require Admin Pass when Flashing BIOS setting is set to YES, then steps will need to be taken to switch the setting to NO using the Think BIOS Configuration Tool or the BIOS Settings VBScripts. After that is set to allow the update to be run, the BIOS can be updated. If needed, utilize the tools mentioned to change the setting back after applying the BIOS update.
</details>

### WinPE

Besides a full Windows installation, the BIOS can be updated through WinPE as well. Updating the BIOS in WinPE would typically be completed by a task sequence in MDT or SCCM, but the updates can be applied by script as well. WinPE, while lightweight, has a couple of challenges when preparing to deploy a BIOS. WinPE requires optional components to create the underlying framework needed for the BIOS update installers to run. WinPE may also require network drivers be injected to make a connection to a centralized repository of BIOS updates for copying to a local drive.

When planning the build of the WinPE image, it is best to understand which Think branded product(s) will be updated, the method of getting BIOS updates to the local device, and the method of installing the update.

?>NOTE: The following examples will be using the Windows ADK for Windows 10, version 1607.

?>NOTE: The optional components can be found in the installation of the Windows ADK, (C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Windows Preinstallation Environment).

All of the Think branded products will require the following optional components to be installed in the WinPE boot image.

**Scripting:**

	\WinPE_OCs\WinPE-Scripting.cab
	\WinPE_OCs\<Language>\WinPE-Scripting_<Language>.cab
	
**WMI:**

	\WinPE_OCs\WinPE-WMI.cab
	\WinPE_OCs\<Language>\WinPE-WMI_<Language>.cab
	
?>NOTE [WinPE: Add Packages (Optional Components Reference)](https://msdn.microsoft.com/en-us/windows/hardware/commercialize/manufacture/desktop/winpe-add-packages--optional-components-reference)

ThinkPad will require an additional optional component to be installed in the WinPE boot image. The ThinkPad BIOS Update tool runs some HTML components in the background, requiring the HTA Optional Component be installed.

**HTA:**

	\WinPE_OCs\WinPE-HTA.cab
	\WinPE_OCs\<Language>\WinPE-HTA_<Language>.cab

During testing, the order of installation was determined to be of importance. The order was found to be:

   1. HTA – If deploying ThinkPad systems
   2. Scripting
   3. WMI

The default configuration for MDT will install the required optional components. SCCM will need the HTA Optional Component added to the WinPE boot image. The others will already be in the WinPE image.

ThinkPad has one other requirement for installing the BIOS while in WinPE. It requires the battery.inf to be loaded. This enables the installers to verify there is a fully charged battery and ensure that the system meets the requirements of the installer. The battery.inf can be loaded from %systemroot%\INF\ using the command drvload.

**The command is as follows:**

	drvload %systemroot%\INF\Battery.inf
	


## Configuring BIOS

### BIOS Security Settings

With information security becoming a prime for organizations, Lenovo is actively and diligently working to protect customer data. One of the first layers of security we provide is within our hardware, specifically the BIOS. BIOS Security governs how accessible the operating system can be to users, administrators, and hackers. Lenovo currently stands on the premise that our BIOS should be highly secure, therefore we will err on the side of security over manageability. We strive to be more secure than other manufacturers while retaining a reasonable level of manageability.

Lenovo utilizes passwords to control access to different aspects of the computer. Passwords are not set from the factory unless requested by a customer and implemented for a specific custom model being ordered. Passwords can be utilized to protect the BIOS interface, power on of the computer, and hard disk.

The BIOS interface is protected by the Supervisor Password (SVP). The Supervisor password must be provided when any settings are changed via scripting. The Supervisor password must be entered when accessing the BIOS by physical means in order to provide access to various security settings.

The powering on of the device is protected by the Power-On Password (POP). This will allow the computer to power on directly to a password prompt but go no further until the correct password is entered. The computer will not prompt for any other type of boot via the F12 boot menu. This will limit the access to the OS and BIOS.

These passwords can be set manually through the BIOS interface itself or can be set/changed by script with the limitation of the Supervisor Password. Lenovo does not support the ability to set the initial password by script to limit the security exposure of locking both administrators and users out of a computer. Once the Supervisor password is set, it can be changed by script. Many customers opt to have Lenovo set the Supervisor password at the factory. Once the customer knows the preset password, they can change it during initial deployment of the computer in their environment.

For more information about BIOS Security around passwords, check [https:\\pcsupport.lenovo.com](https://pcsupport.lenovo.com/) and search for the specific model. The User Guide in the documentation area will contain specifics on these passwords.

Lenovo leverages WMI through scripting API’s to detect if any of the BIOS passwords are set. The script returns the state of the following passwords: Supervisor (SVP), Power on (POP), User HDD, and User HDD and Master HDD. Using this information, an administrator can determine if a computer has passwords set in their environment.

Using the following PowerShell script, running as administrator, the return code will range from 0 to 7.


	(gwmi -Class Lenovo_BIOSPasswordSettings -Namespace root\wmi).PasswordState

The result will map to one of the values in the table below:

| **0** | No password set                                                                            |
|---|--------------------------------------------------------------------------------------------|
| **1** | Power on password set                                                                      |
| **2** | Supervisor password set                                                                    |
| **3** | Power on password and Supervisor password set                                              |
| **4** | User HDD or User HDD and Master password set                                               |
| **5** | Power on password and (User HDD or User HDD and Master password) set                       |
| **6** | Supervisor password and (User HDD or User HDD and Master password) set                     |
| **7** | Power on password, Supervisor password, and (User HDD or User HDD and Master password) set |

?>NOTE: The information provided by the script will only return the state of the passwords, it will not return the actual passwords.

