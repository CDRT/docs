# AIM-T User Guide - Windows


## Chapter 1 - Introduction

This document specifies how user (for example, an IT administrator) uses AMD wireless AIM-T 
and wired DASH to manage AIM-T system remotely in an enterprise network. AIM-T is a 
solution that enables AMD-based commercial platforms to provide secure and remote 
management capability. It is achieved by integrating a dedicated core in AMD’s Client SoC 
(starting from AMD RyzenTM 7 PRO processors) along with all the supporting SoC/platform level 
hardware, firmware, software, and interfaces. With the help of special WLAN and LAN modules, 
AIM-T can management a remote system through a Wi-Fi or ethernet connection.

### Acronyms and Abbreviations

| Term  | Definition                                          |
|-------|-----------------------------------------------------|
| AIM-T | AMD Integrated Management Technology                |
| AMD   | Advanced Micro Devices                              |
| AMS   | AMD Manageability Service                           |
| AP    | Access Point                                        |
| BIOS  | Basic Input/Output System                           |
| DASH  | Desktop and Mobile Architecture for System Hardware |
| DMTF  | Distributed Management Task Force                   |
| IP    | Internet Protocol                                   |
| IT    | Information Technology                              |
| KVM   | Keyboard Video and Mouse                            |
| LAN   | Local Area Network (aka Ethernet)                   |
| NIC   | Network Interface Controller                        |
| OEM   | Original Equipment Manufacturer                     |
| OS    | Operating System                                    |
| SoC   | System on a Chip                                    |
| UI    | User Interface                                      |
| WLAN  | Wireless Local Area Network (aka Wi-Fi)             |
| VNC   | Virtual Network Computing                           |

<div style="text-align:center; padding-bottom:40px;">Table 1. Acronyms and Abbreviations</div>

## Chapter 2 - Wireless and Wired AIM-T Setup

### 2.1 Prerequisites

A laptop or desktop system with OEM’s brand which supports AIM-T and Wired DASH function.
AIM-T requires Qualcomm WLAN (QCA6850) and wired DASH requires Realtek LAN 
(RTL8111E) in the system.
<div style="text-align:center;">

![](..\img\guides\aimt\software_requirement_for_wireless_aimt.png)

Table 2-1. Software Requirement for Wireless AIM-T
</div>
<div style="text-align:center;">

![](..\img\guides\aimt\software_requirement_for_wired_dash.png)

Table 2-2. Software Requirement for Wired DASH</div>

### 2.2 BIOS

OEMs have their own BIOS setup menu. You must contact OEM service or read manuals to find out how to turn on/off wireless AIM-T and wired DASH related functions in the BIOS setup menu. The following is an example showing AMD’s standard UI for enabling AIM-T and wired DASH: 
<div style="text-align:center;">

![](..\img\guides\aimt\aimt_options.jpg) 

Figure 2-1. AIM-T Options</div>

<div style="text-align:center;">

![](..\img\guides\aimt\aimt_adv_options.jpg)

Figure 2-2. AIM-T Advanced Options</div>

### 2.3  Provisioning Console for Wireless AIM-T

Download link: [*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[ ](https://developer.amd.com/tools-for-dmtf-dash/)

AMD Provisioning Console (on the website) is merged into DASHCLI installation package. For example:
```
AMD_DASH_CLI_Setup_4.0.0.xxxx.exe
```

#### 2.3.1     Provisioning 

For security purpose, most of the DASH commands require username/password. These usernames and passwords must be provisioned on the client (AIM-T system). When a client receives a DASH command, it checks whether the username/password with DASH command match the provisioned settings or not. Only authorized DASH commands will be processed. 

For configuring provisioning data and to provision it on the AIM-T system, refer to Appendix A. 

?>Users should backup the crypto key folders in the following location for re-provisioning: 
```C:\Users\XXX\Documents\AMD Provisioning Console\Cryptostore```

#### 2.3.2      Re-provisioning 

AMD supports re-provisioning and un-provisioning capabilities. Re-provisioning can be used when a user (IT administrator) wants to change the provisioned username/password or Wi-Fi AP’s setting. The user can create a new package with the original crypto key and perform provisioning process again to overwrite the original settings on the AIM-T system. For steps to create a provisioning package and re-provision a AIM-T system, refer to Appendix D. 

?>Users should back-up the crypto key safe in case they change the provisioned settings in the future.

#### 2.3.3      Un-provisioning 

Un-provisioning can be used when a user (IT administrator) wants to wipe out the provisioning data in the AIM-T system. The user can trigger un-provisioning by sending a special DASH command with the username/password provisioned on the AIM-T system. In a case where a user has lost the original crypto key but wants to change username/password or Wi-Fi AP’s setting, the user can un-provision the old provisioning data, and follow section 2.3.1 to create a new crypto key and provision a new configuration. For steps to un-provision a AIM-T system, refer to Appendix E. 

?>The un-provisioning process will wipe out the provisioned username/password. User must redo the provisioning to make DASH functional again.

### 2.4	DASHCLI

Download link: [*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[ ](https://developer.amd.com/tools-for-dmtf-dash/)

DASHCLI is a command line tool running on host (IT’s system) for sending DASH commands to client (AIM-T system). For security purpose, most of the DASH commands require username/password. After launching DASHCLI, you can enter DASH commands such as the following: 
```
dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 enumerate computersystem 
```

The following figure shows DASHCLI: 

<div style="text-align:center;">

![](..\img\guides\aimt\dashcli.jpg)

Figure 2-3. DASHCLI</div>

For more DASH commands, refer to Appendix F. 

### 2.5    **AMD Manageability Service (AMS)** 

If an OEM enables the AIM-T feature from the factory, AMS should already be installed. For AIM-T capable systems not having AIM-T enabled from the factory, you can download and install AMS from Microsoft Store [(](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG)[*https://apps.microsoft.com/store/detail/9PM4WBSLVZTG*](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG)[)](https://apps.microsoft.com/store/detail/9PM4WBSLVZTG): 

<div style="text-align:center;">

![](..\img\guides\aimt\installing_ams.jpg) 

Figure 2-4. Installing AMS</div>

By default, AMS should be installed on OEM’s AIM-T capable products. AMS is auto launched when system boots to OS with Wi-Fi connection. AMS is available in hidden icons; you can double-click the icon to launch it: 

<div style="text-align:center;">

![](..\img\guides\aimt\ams_icon.jpg)

Figure 2-5. AMS Icon</div>

You can check the AIM-T status in the AMS UI. If AIM-T is enabled in BIOS, the system is provisioned, and Wi-Fi is connected to Wi-Fi AP; the AMS should look as follows: 

<div style="text-align:center;">

![](..\img\guides\aimt\aim-t_status.jpg)

Figure 2-6. AIM-T Status</div>

AMS UI will be hidden if you log in to Windows with a standard user account. AMS will not be visible in **Apps & features** for a standard user, but it will not affect the DASH commands. The AIM-T system with a standard user account can still receive DASH commands from host. Contrarily, if a client user logs in with an administrator account, he/she can see AMS UI and AIMT status. 

### 2.6    Realtek Ethernet Controller All-in-One Windows Driver 

Contact OEM to get the installation package and detailed information. 

You should install Realtek Ethernet Controller All-in-One Windows Driver on client (AIM-T system) to make the system ready for DASH commands. Once the package is installed, you can check the DASH status and firmware version of NIC with Realtek service UI as follows: 

<div style="text-align:center;">

![](..\img\guides\aimt\realtek_ui.jpg) 

Figure 2-7 Realtek UI</div>

You can find the execution file and launch Realtek UI in the default directory: 
```
C:\Program Files (x86)\Realtek\Realtek Windows NIC Driver\RtDashService\RtDashUI
```
DASH client shows the current DASH status and FW version on the AIM-T system: 


<div style="text-align:center;">

![](..\img\guides\aimt\realtek_dash_client.jpg)

Figure 2-8 DASH Client</div>

Once the driver installation completes, you can trigger DASH commands to retrieve information from the AIM-T system. The following is an example showing how to send a DASH command to get AIM-T system’s processor info: 

<div style="text-align:center;">

![](..\img\guides\aimt\aimt_system_proc_info.jpg) 

Figure 2-9 AIM-T System Processor Info</div>

?>The default credential for Realtek NIC is **Administrator** and **Realtek**. To learn how to change username and password for wired DASH by flashing Realtek NIC firmware, refer to Appendix F.

## Chapter 3 - User Scenario

### 3.1 AIM-T in OS

#### 3.1.1 Prerequisites 

+ Client (AIM-T system) has AMS installed and provisioned 
+ Host (IT admin’s console system) has DASHCLI installed 
+ Host can ping client’s IP 

#### 3.1.2     Expected Behavior 

When a client user is working on a AIM-T system, an enterprise IT can send DASH commands (Appendix D) to the client and fetch system’s software and hardware information back silently. Some DASH commands can force the AIM-T system to shut down or reboot. In that case, the client user will observe system graceful shutdown, hard shutdown, or reboot without any notification. Also, the enterprise IT can force a AIM-T system to do BIOS capsule update with a special DASH command and process (Appendix H). 

Moreover, the IT can request the client to establish a KVM (Appendix E) session. In OS, IT can start an OS KVM in which a VNC viewer will pop-up immediately and show AIM-T system’s screen. The other option is that IT sends a BIOS KVM command through DASH to request the AIM-T system restart and enter BIOS setup menu. When the client enters BIOS menu, the VNC viewer on host system should display the same screen. 

?>A user can terminate KVM session by closing VNC viewer. The safe way to shut down a AIM-T system is to close the VNC viewer and send a DASH command to shut the AIM-T system down (Appendix D).

#### 3.1.3 Graceful Shutdown 

After a user triggers graceful shutdown in OS power menu on a AIM-T system having a power adaptor attached, the system will shut down and restart AIM-T. Thirty seconds later, the system will have AIM-T capability to process DASH commands and KVM session request. For more information, refer to section 3.2. 

### 3.2 AIM-T in Shutdown Mode 

### 3.2.1 Prerequisites 

+ AIM-T function needs to be enabled in BIOS setup menu on the AIM-T system 
+ The AIM-T system must be AIM-T provisioned 
+ Power adaptor must be attached 

#### 3.2.2 Expected Behavior 

When AIM-T is working in shutdown mode on a AIM-T system, there is no display. However, the power LED may blink and fan spin occasionally depending on the OEM’s design and Wi-Fi AP’s behavior. Normally, when a client user shuts the system down through OS, the power LED and fan should turn off for 40 seconds. Then, the power LED and fan turn off again. After that, a host (IT’s system) can send DASH commands (Appendix D) to the AIM-T system which will wake up with power LED on, fan spinning, and it will take 60 seconds to be prepared for the incoming DASH commands. Some DASH commands can force the AIM-T systems boot to OS. When there is no more DASH command in the queue for 3 minutes, the system will shutdown. Same as AIM-T in OS mode, AIM-T supports KVM function in shutdown mode. The KVM (Appendix E) session request sent from IT will trigger the system restart and establish a KVM connection. 

#### 3.2.3 Pressing Power Button 

In the shutdown mode, regardless of power LED is on or off, a client user can boot the system to OS by pressing a power button. 

***Note:\*** *When the power LED turns on, a AIM-T system may not be ready for handling the power button event for the first 30 seconds. User should press the power button after 30 seconds of power LED turning on.* 

#### 3.2.4 Detaching Power Adaptor 

Power adaptor attachment is one of the requirements for AIM-T in shutdown mode. Removing power adaptor will force the system turn AIM-T off during shutdown mode.

## Chapter 4 - Troubleshooting

### 4.1 On AIM-T DASH System 

#### 4.1.1 AMS Status is Off 

<div style="text-align:center;">

![](..\img\guides\aimt\ams_status_off.jpg) 

Figure 4-1. AMS Status is Off</div>

If the **Manageability status** is OFF in the AMS UI tray, user can check the following to recover it: 

+ AIM-T is ON in the BIOS menu 
+ Device Manager > System > AMS-MailboxDrv works properly 
+ Launch services to ensure that AMS is running 

#### 4.1.2     Red AMS UI Tray 

In some cases, the AMS tray icon will turn red as AMS may not start: 

<div style="text-align:center;">

<img src="..\img\guides\aimt\red_ams_UI_tray.png" style="zoom:30%;" />

Figure 4-2. AMS UI Tray Issues</div>

You can re-launch AMS to recover it. 

Also, you can search for **Services** and start AMD as follows: 

<div style="text-align:center;">

<img src="..\img\guides\aimt\start_ams_service.png" style="zoom:40%;" >

Figure 4-3. Start AMS Service</div>

#### 4.1.3      AMS UI Tray Hangs 

There is a known issue that the AMS UI tray will hang after resuming from hibernate. However, it does not impact any AIM-T functionality because AMS UI and its service are separate and the service runs properly when UI hangs. When the AMS UI tray hangs, user can right-click the AMS icon to exit and re-launch it from the Windows Start Menu. 

The AMS UI tray will be in green when it is working properly: 

<div style="text-align:center;">

<img src="..\img\guides\aimt\green_ams_ui_tray.jpg"> 

Figure 4-4. Green AMS UI Tray</div>

### 4.2     On Console (DASH CLI) System 

#### 4.2.1      KVM Command Response 

Both OS KVM and BIOS KVM require a KVMSSHKey which is in a provisioning package generated by the user (refer to Appendix A) and should be saved in: 
```
C:\Program Files (x86)\DASH CLI 4.x\certs\
```        

The folder *certs* is set as an administrator folder which may be controlled by an enterprise IT policy. 

<div style="text-align:center;">

<img src="..\img\guides\aimt\dash_cli_kvm_output.jpg">  

Figure 4-5. DASH CLI – KVM Output</div>

#### 4.2.2     Unresponsive AIM-T System 

<div style="text-align:center;">

<img src="..\img\guides\aimt\unresponsive_aim-t_system.jpg"> 

Figure 4-6. Unresponsive AIM-T System</div>

When a AIM-T system is in the shutdown mode, the console cannot get any DASH response immediately. You should wake the AIM-T system up by sending a DASH command. Then, the AIM-T system will take one to one and a half minute to be ready for handling DASH commands. 

You can keep sending DASH commands to ensure that the AIM-T system is ready. 

<div style="text-align:center;">

<img src="..\img\guides\aimt\responsive_aimt_system.jpg">

Figure 4-7. Responsive AIM-T system</div> 

Other reasons for a AIM-T system being unresponsive can be the AIM-T system is not connected to the same network domain or it is not configured properly. To fix the AIM-T system, refer to section 4.1. 

#### 4.2.3      Display is Distorted While Connecting KVM 

<div style="text-align:center;">

<img src="..\img\guides\aimt\distorted_display.jpg"> 

Figure 4-8. Distorted Display</div>

When a host system initiates a KVM session with a AIM-T system, the host user (enterprise IT admin) may witness a distorted VNC viewer. Most of the time, this problem happens when the client was in the shutdown mode and woken up by a KVM request. This problem can be recovered by rebooting the AIM-T system. When a host user witnesses the issue, he/she can launch a new DASHCLI console (do not close the old one) and send a power cycle DASH command to the client: 

```
dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664
 -t computersystem[0] power cycle
```

This command can reboot the AIM-T system. Then, the host user will see the client’s BIOS menu with a clear display on the VNC viewer in a few minutes. 

## Appendix A-Configuring the Provisioning Data 

Complete the following steps to configure the provisioning data: 

1. On host (IT’s system), install AMD Provisioning Console tool using the executable file (for example, Provisioning_Console_setup-1.0.0.xxx-AMD.exe). 

2. Launch AMD Provisioning Console. 

3. Fill in the organization information. 

4. Select the location where you want to store the profiles: 
	<div style="text-align:center;">

	<img src="..\img\guides\aimt\profile_location.jpg"> 

	Figure 5-1. Profile Location</div>

5. Fill in the contact information: 

	<div style="text-align:center;">
	
	<img src="..\img\guides\aimt\contact_information.jpg"> 

	Figure 5-2. Contact Information</div>

6. Provide a **Package name**. 
   It will be a part of the provisioning package’s folder name. 

7. Create a new Crypto and select it from the **Crypto store** drop-down: 
	<div style="text-align:center;">
	
	<img src="..\img\guides\aimt\crypto_store.jpg"> 

	Figure 5-3. Crypto store</div>

8. Add two users (one standard and one admin) without changing the **Roles** configuration: 
	
	<div style="text-align:center;">
	
	<img src="..\img\guides\aimt\adding_users.jpg"> 
   
	Figure 5-4. Adding Users</div>

9. Add one Wi-Fi access point, this setting is required for AIM-T in system shutdown mode: 

	<div style="text-align:center;">
	
	<img src="..\img\guides\aimt\adding_wi-fi_access_point.jpg"> 

	Figure 5-5. Adding Wi-Fi Access Point</div>

10. Use the default port number (664) for **Secure port**: 
	<div style="text-align:center;">
	
    <img src="..\img\guides\aimt\secure_port.jpg"> 
    
    Figure 5-6. Secure Port</div>

    
11. Generate a TLS certificate: 
	<div style="text-align:center;">
	
    <img src="..\img\guides\aimt\tls_certificate.jpg"> </div>


12. Generate a KVM key: 
    <img src="..\img\guides\aimt\kvm_key.jpg"> 

    **Figure - KVM Key** 

13. All the supported DASH profiles enabled by default. If required, you can disable some of the profiles: 
    <img src="..\img\guides\aimt\dash_profiles.jpg"> 

    **Figure - DASH Profiles** 

14. Alerts are not required: 
    <img src="..\img\guides\aimt\alerts.jpg">

    **Figure - Alerts** 

15. Click the **Submit** button: 
    <img src="..\img\guides\aimt\summary_and_result.jpg">

    **Figure - Summary and Result** 

    The provisioning package is generated. 

16. Copy the provisioning package (saved in the directory set in Step 4) to client (AIM-T system). 

17. On the client, launch a prompt command as an administrator and go to the package location. 

18. Type the command AIM-TProvisioningApp.exe -i XXXX_oMt: 
    <img src="..\img\guides\aimt\provisioning_command.jpg">

    **Figure - Provisioning Command** 

19. If you generated a KVM key in Step12, copy the KVMSSHKey from the provisioning package (*<package path>\consolecertificates\KVMSSHKey*) to *C:\Program Files (x86)\DASH CLI 4.0\certs\* on host. 

20. Ensure that the owner of KVMSSHKey is same as the Windows local user with full control. When copying the KVMSSHKey, the owner of the file may change. You must check the owner before using the KVM: 
    <img src="..\img\guides\aimt\check_kvmsshkey_owner.jpg">

    **Figure - Check KVMSSHKey Owner**

## Appendix B-Re-provisioning 

Complete the following steps to re-provision: 

1. Ensure that provisioning is done on the AIM-T system. 

2. Launch *AMD Provisioning Console*. 

3. Select the crypto key provisioned on the AIM-T system: 
   <img src="..\img\guides\aimt\select_crypto_key.jpg">
   **Figure - Select Crypto Key** 

4. If you cannot see the original crypto key in Step 3 but you do have a copy of the key, copy it to *Documents\AMD Provisioning Console\Cryptostore*. 
   <img src="..\img\guides\aimt\copy_crypto_key.jpg">

   **Figure - Copy Crypto Key** 

5. Redo the steps 2 and 3. 

6. Refer to Appendix A and generate a provisioning package with a new username/password or new Wi-Fi AP’s setting. 

7. Execute the command: 

   ```
   AIM-TProvisioningApp.exe -i XXXX_M 
   ```

   <img src="..\img\guides\aimt\provisioning_command.jpg">

   **Figure - Re-provisioning Command** 

8. If you re-generate a new KVM key, complete step 19 in Appendix A to copy the KVMSSHKey to DASHCLI’s *cert* folder.

## Appendix C-Un-provisioning 

Complete the following steps to un-provision: 

1. Ensure that the AIM-T system has enabled AIM-T and is provisioned. You can send some DASH commands in Appendix D to ensure that DASH is working with its username/password. 

2. Send a special DASH command to the AIM-T system: 

   ```
   dashcli.exe -S https -h <ipaddress> -p 664 -u <username> -P <password>
    -C raw ei AMD_ProvisioningService 
   ```

3. Copy TOTPToken: 

   <img src="..\img\guides\aimt\totptoken.jpg">

   **Figure - TOTPToken** 

4. There is a 180 second timeout for the second command for un-provisioning: 

```
dashcli.exe -S https -h <ipaddress> -p 664 -u <username> -P <password> -C raw
im http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/AMD_ProvisioningService?
Name="ProvisioningService:0", TOTPToken="<TOTPToken>" 
RequestStateChange "RequestedState=32771"    
```

**Note:** *If it has passed 180 seconds but you have not run the second command, you can just go back to step 1.* 

## Appendix D-Supported DASH Commands

Following are the supported commands for a DASH capable system: 

**Note:** *Adding -v 1 option will provide detailed logs.* 

### Table 4. Supported DASH Commands 

| **Commands**                                                 | **Description**                                           |
| ------------------------------------------------------------ | --------------------------------------------------------- |
| dashcli.exe  -h <ipaddress> -S https -C -p 664 -a digest discover info | Display discovery information with Digest  authentication |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate computersystem | Enumerate all the computer system profile instances       |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   registeredprofile | Enumerate all the registered  profile instances           |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate sensor | Enumerate sensor details                                  |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate processor | Enumerate all the processor profile  instances            |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate dhcpclient | Enumerate all the DHCP client profile instances           |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate dnsclient | Enumerate all the DNS client profile instances            |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate ethernetport | Enumerate all the ethernet port profile instances         |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate networkport | Enumerate all the network port profile instances          |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate ipinterface | Enumerate all the IP interface profile instances          |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   ipconfiguration | Enumerate all the IP configuration profile instances      |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   operatingsystem | Enumerate all the OS profile instances                    |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate asset | Enumerate all the asset profile instances                 |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate memory | Enumerate all the memory profile instances                |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate pcidevice | Enumerate all the PCI device instances                    |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate ssh | Enumerate all the SSH profile instances                   |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate recordlog | Enumerate all the records information                     |

| **Commands**                                                 | **Description**                                  |
| ------------------------------------------------------------ | ------------------------------------------------ |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate battery | Enumerate the battery info                       |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power status | Display current power status of the AIM-T system |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power shutdown | Power shutdown the AIM-T system                  |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power cycle | Power cycle the AIM-T system                     |
| dashcli -h dash-system -p 664 -S  https -C -u <username> -P  <password> software[0] install   <URL for Capsule>   Example: dashcli -h 192.168.0.176 -S https -C -p  664  -u admin -P amd@123 -t software[0]  install http://192.168.0.211:3274/Capsule.zip | Update the Software BIOS through Capsule update  |

   **Appendix D                 Supported DASH Commands** 

## Appendix E-Using KVM

When a OEM device supports KVM function, a host (IT’s system) can use DASHCLI startkvm command to initiate a KVM session to the AIM-T system: 

`dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startkvm` 

Complete the following steps to establish a KVM session: 

1. Enable AIM-T and KVM function on AIM-T system’s BIOS setup menu. 

2. Ensure that the AIM-T system has been AIM-T provisioned (Appendix A). 

3. Place a copy of KVMSSHKey in *C:\Program Files (x86)\DASH CLI 4.0\certs\,* where you execute DASHCLI commands on host (Appendix A). 

4. Boot AIM-T system to OS. 

5. Run one of the following DASH commands on the host: 

   ```
   dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startkvm 
   ```

   **or** 

   ```
   dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startoskvm 
   ```

For more information, refer to Figure DASH CLI – KVM Output. 

6. If the step 3 was executed correctly, a VNC viewer will be launched on host. 

7. If the graphics driver installed on the AIM-T system supports instant KVM, go to step 8 for OS KVM. Otherwise, the system will auto-reboot and go to step 10 for BIOS KVM. 

​       

| ***Using  KVM\*** | ***Appendix E\*** |
| ----------------- | ----------------- |
|                   |                   |

8. Host can see the client’s screen on VNC viewer called OS KVM: 

   <img src="..\img\guides\aimt\amd_kvm_viewer.jpg" style="zoom:80%;">

   **Figure - AMD KVM Viewer** 

9. To trigger the BIOS KVM, configure the VNC viewer to restart the client in Windows power option. 

10. After reboot, the AIM-T system will stop at F1/F2 window. The same screen is displayed on the VNC viewer. F1 is selected by default; it is to continue to OS and F2 is to boot to BIOS. 

**Note:** *OEM may change the definition of F1/F2 or replace it with other keys.* 

11. Based on the F1/F2 configuration in the previous step, press F1 on the VNC Viewer. The AIM-T system will boot to OS and OS KVM will be established. 

    If you press F2, the client will boot to BIOS setup menu (BIOS KVM). 

12. Ensure that BIOS menu navigation is possible using keyboard and mouse from the VNC viewer. 

13. If required, modify the BIOS settings using VNC viewer and save them. 

14. The AIM-T system should auto-reboot while exiting the BIOS setup menu. Check if the changes made in the previous step are reflected correctly. 

15. Close the VNC viewer to finish the KVM session and select **Yes** to reboot the AIM-T system again. 

**Note:** *If you select **No**, the AIM-T system will not restart.* 

## Appendix F-Flashing RTK NIC Firmware 

Contact OEM for more information on getting the flash tool with the bin file. 

You can use the command line interface with the related bin file (68EPSPIB.bin) to flash Realtek NIC’s firmware and Config file (68EPSPI.CFG) to run *WINPG64.bat*. The following figure shows the firmware flashed successfully: 

<img src="..\img\guides\aimt\firmware_flash_status.jpg">

**Figure - Firmware Flash Status** 



## Appendix G-Supported Wired DASH Profiles 

##### Table 5. Supported Wired DASH Profiles 

| **Profiles**               | **Requirement** |
| -------------------------- | --------------- |
| Base Desktop and Mobile    | Mandatory       |
| Profile Registration       | Mandatory       |
| Role Based Authorization   | Mandatory       |
| Simple Identity Management | Mandatory       |
| BIOS Management            | Optional        |
| Boot Control               | Optional        |
| CPU                        | Optional        |
| DHCP                       | Optional        |
| Fan                        | Optional        |
| Indications                | Optional        |
| IP Interface               | Optional        |
| KVM Redirection            | Optional        |
| OS Status                  | Optional        |
| Physical Asset             | Optional        |
| Power State Management     | Optional        |
| Power Supply               | Optional        |
| Record Log                 | Optional        |
| Sensor                     | Optional        |
| Battery                    | Optional        |
| Software Inventory         | Optional        |
| Software Update            | Optional        |
| System Memory              | Optional        |
| Text Console redirection   | Optional        |
| USB Redirection            | Optional        |

## Appendix H-Updating BIOS Capsule 

An enterprise IT admin is allowed to force a AIM-T system for performing a BIOS capsule update with DASH commands. However, the IT must setup a download server for AIM-T systems to download the latest valid capsule that can be recognized and installed by Windows OS. The AMS installed on AIM-T systems utilizes an inbox app *PnPutil.exe* in OS to install a BIOS capsule. DASH commands can ask a AIM-T system to download the capsule and then AMS will run *PnPutil.exe* to install the capsule. 

### H.1    Setting up a Download Server 

AMD provides the tool AMD Management Console (AMC -[ ](https://developer.amd.com/tools-for-dmtf-dash/)[*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[)](https://developer.amd.com/tools-for-dmtf-dash/) to send DASH commands with a user-friendly interface. When installing AMC, the installer will simulate a virtual webserver with the network port 3274 (by default) and create a folder “*C:\AMC-ISO*” to act as the download space. 

<img src="..\img\guides\aimt\amc_port_selection.jpg"> 

**Figure - AMC - Port Selection** 

After AMC is installed, you can place any file in the folder *C:\AMC-ISO* and type-in *http://<IP>:3274* in web browser to test it: 

<img src="..\img\guides\aimt\testing_amc.jpg"> 

**Figure - Testing AMC** 

***Note:\*** *The network port 3274 may be blocked by the firewall, an IT admin must give permission to allow the traffic through this port.* 

### H.2    Preparing a Valid Capsule 

An enterprise IT should be able to download a BIOS capsule from the OEM’s website (or other channels). A valid capsule includes: 

•   *.bin* or *.cap* file – the new firmware 

•   *.cer* file – the certificate 

•   *.cat* file – the driver catalog 

•   *.inf* file – the driver information 

You can launch a command prompt as admin and execute the following command to trigger the capsule installation: 

```
PnPutil.exe /add-driver xxx.inf /install 
```

If the installation is successful, it means the capsule is valid: 

<img src="..\img\guides\aimt\valid_capsule.jpg"> 

**Figure - Valid Capsule** 

### H.3    Reforming the Capsule 

After verifying the content of a BIOS capsule, reform the capsule to an AMS readable format as follows: 

1. Create a folder **Capsule**. 

2. Copy all the files from the valid capsule and paste them to the new folder *\Capsule*. 

3. Zip *\Capsule* into *capsule.zip.* 

4. Put *capsule.zip* in *C:\AMC-ISO.* 



### H.4    DASH Command for Capsule Update 

```
dashcli -h <ipaddress> -p 664 -S https -C -u <username> -P <password>
software[0] install <URL for Capsule> 
```

<img src="..\img\guides\aimt\capsule_update.jpg"> 

**Figure - Capsule Update** 