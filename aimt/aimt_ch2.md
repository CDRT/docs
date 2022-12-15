# 2 Wireless and Wired AIM-T Setup

## 2.1 Prerequisites

A laptop or desktop system with OEM’s brand which supports AIM-T and Wired DASH function.
AIM-T requires Qualcomm WLAN (QCA6850) and wired DASH requires Realtek LAN 
(RTL8111E) in the system.
<div style="text-align:center;">

![](..\img\guides\aimt\software_requirement_for_wireless_aimt.png)</div>
<div style="text-align:center;">

![](..\img\guides\aimt\software_requirement_for_wired_dash.png)</div>

## 2.2 BIOS

OEMs have their own BIOS setup menu. You must contact OEM service or read manuals to find out how to turn on/off wireless AIM-T and wired DASH related functions in the BIOS setup menu. The following is an example showing AMD’s standard UI for enabling AIM-T and wired DASH: 
<div style="text-align:center;">

![](..\img\guides\aimt\aimt_options.jpg) </div>

<div style="text-align:center;">

![](..\img\guides\aimt\aimt_adv_options.jpg)</div>

## 2.3  Provisioning Console for Wireless AIM-T

Download link: [*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[ ](https://developer.amd.com/tools-for-dmtf-dash/)

AMD Provisioning Console (on the website) is merged into DASHCLI installation package. For example:
```
AMD_DASH_CLI_Setup_4.0.0.xxxx.exe
```

### 2.3.1     Provisioning 

For security purpose, most of the DASH commands require username/password. These usernames and passwords must be provisioned on the client (AIM-T system). When a client receives a DASH command, it checks whether the username/password with DASH command match the provisioned settings or not. Only authorized DASH commands will be processed. 

For configuring provisioning data and to provision it on the AIM-T system, refer to Appendix A. 

?>Users should backup the crypto key folders in the following location for re-provisioning: 
```C:\Users\XXX\Documents\AMD Provisioning Console\Cryptostore```

### 2.3.2      Re-provisioning 

AMD supports re-provisioning and un-provisioning capabilities. Re-provisioning can be used when a user (IT administrator) wants to change the provisioned username/password or Wi-Fi AP’s setting. The user can create a new package with the original crypto key and perform provisioning process again to overwrite the original settings on the AIM-T system. For steps to create a provisioning package and re-provision a AIM-T system, refer to Appendix D. 

?>Users should back-up the crypto key safe in case they change the provisioned settings in the future.

### 2.3.3      Un-provisioning 

Un-provisioning can be used when a user (IT administrator) wants to wipe out the provisioning data in the AIM-T system. The user can trigger un-provisioning by sending a special DASH command with the username/password provisioned on the AIM-T system. In a case where a user has lost the original crypto key but wants to change username/password or Wi-Fi AP’s setting, the user can un-provision the old provisioning data, and follow section 2.3.1 to create a new crypto key and provision a new configuration. For steps to un-provision a AIM-T system, refer to Appendix E. 

?>The un-provisioning process will wipe out the provisioned username/password. User must redo the provisioning to make DASH functional again.

## 2.4	DASHCLI

Download link: [*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[ ](https://developer.amd.com/tools-for-dmtf-dash/)

DASHCLI is a command line tool running on host (IT’s system) for sending DASH commands to client (AIM-T system). For security purpose, most of the DASH commands require username/password. After launching DASHCLI, you can enter DASH commands such as the following: 
```
dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 enumerate computersystem 
```

The following figure shows DASHCLI: 

<div style="text-align:center;">

![](..\img\guides\aimt\dashcli.jpg)</div>

For more DASH commands, refer to Appendix F. 

## 2.5    **AMD Manageability Service (AMS)** 

If an OEM enables the AIM-T feature from the factory, AMS should already be installed. For AIM-T capable systems not having AIM-T enabled from the factory, you can download and install AMS from Microsoft Store [(](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG)[*https://apps.microsoft.com/store/detail/9PM4WBSLVZTG*](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG)[)](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG): 

<div style="text-align:center;">

![](..\img\guides\aimt\installing_ams.jpg) </div>

By default, AMS should be installed on OEM’s AIM-T capable products. AMS is auto launched when system boots to OS with Wi-Fi connection. AMS is available in hidden icons; you can double-click the icon to launch it: 

<div style="text-align:center;">

![](..\img\guides\aimt\ams_icon.jpg)</div>

You can check the AIM-T status in the AMS UI. If AIM-T is enabled in BIOS, the system is provisioned, and Wi-Fi is connected to Wi-Fi AP; the AMS should look as follows: 

<div style="text-align:center;">

![](..\img\guides\aimt\aim-t_status.jpg)</div>

AMS UI will be hidden if you log in to Windows with a standard user account. AMS will not be visible in **Apps & features** for a standard user, but it will not affect the DASH commands. The AIM-T system with a standard user account can still receive DASH commands from host. Contrarily, if a client user logs in with an administrator account, he/she can see AMS UI and AIMT status. 

## 2.6    Realtek Ethernet Controller All-in-One Windows Driver 

Contact OEM to get the installation package and detailed information. 

You should install Realtek Ethernet Controller All-in-One Windows Driver on client (AIM-T system) to make the system ready for DASH commands. Once the package is installed, you can check the DASH status and firmware version of NIC with Realtek service UI as follows: 

<div style="text-align:center;">

![](..\img\guides\aimt\realtek_ui.jpg)</div>

You can find the execution file and launch Realtek UI in the default directory: 
```
C:\Program Files (x86)\Realtek\Realtek Windows NIC Driver\RtDashService\RtDashUI
```
DASH client shows the current DASH status and FW version on the AIM-T system: 


<div style="text-align:center;">

![](..\img\guides\aimt\realtek_dash_client.jpg)</div>

Once the driver installation completes, you can trigger DASH commands to retrieve information from the AIM-T system. The following is an example showing how to send a DASH command to get AIM-T system’s processor info: 

<div style="text-align:center;">

![](..\img\guides\aimt\aimt_system_proc_info.jpg) </div>

?>The default credential for Realtek NIC is **Administrator** and **Realtek**. To learn how to change username and password for wired DASH by flashing Realtek NIC firmware, refer to Appendix F.