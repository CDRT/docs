
![](./img/thinkcenter_security.png)

 - [More information at Lenovo Support - types of password](https://support.lenovo.com/us/en/solutions/ht513634)
 - [More information at Lenovo Support - password manager](https://support.lenovo.com/us/en/solutions/ht103666-introduction-to-password-manager-thinkpad-thinkcentre-thinkstation)

<details><summary>Supervisor Password</summary>

Shows the status of the password.

One of 2 possible options for password status:

1.  **Not Installed** - password disabled. Default.
2.  Installed -  password enabled.

</details>

<details><summary>Power-On Password</summary>

Shows the status of the password.

One of 2 possible options for password status:

1. **Not Installed** - password disabled. Default.
2. Installed -  password enabled.

</details>

<details><summary>System Management Password</summary>

Shows the status of the password.

One of 2 possible options for password status:

1. **Not Installed** - password disabled. Default.
2. Installed -  password enabled.

</details>

<details><summary>Set Supervisor Password</summary>

Set, change, or delete the Supervisor Password.

**NOTE:** To delete Supervisor Password, enter blank fields for each new password line item.

</details>

<details><summary>Set Power-On Password</summary>

Set, change, or delete the Power-On Password.

**NOTE:** To delete Power-On Password, enter blank fields for each new password line item.

</details>

<details><summary>Set System Management Password</summary>

Set, change, or delete the System Management Password (SMP).

**NOTE:** To delete System Management Password, enter blank fields for each new password line item.

</details>

### System Management Password Access Control ###

The System Management Password prevents unauthorized users from accessing BIOS Setup in default.

<details><summary>Access Security Settings</summary>

Set the level of security settings access for the SMP.

One of 2 possible options for SMP security settings access:

1.  **Disabled** - disables security settings access.
2.  Enabled - enables security settings access. Default.

<!--
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| AccessSecuritySettings | setting_values | yes_no | amd_intel |
-->

**NOTE:** When enabled, the SMP has the same security settings access permissions as the SVP.

</details>

<details><summary>Remote Set SMP</summary>

One of 2 possible options for remote setting of the SMP:

1.  **Disabled** - disables remote setting of the SMP.
2.  Enabled - enables remote setting of the SMP. Default.

<!--
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| RemoteSetSMP | setting_values | yes_no | amd_intel |
-->

</details>

<!-- 
### Hard Disk Password ###

Configure hard disk password.

### Password Policies ###

Configure the password policies

-->

<details><summary>Secure Roll Back Prevention</summary>

1.  **Yes** - Flashing BIOS to a previous or current version is NOT allowed. Default.
1.  No - Flashing BIOS to a previous or current version is allowed.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SecureRollBackPrevention | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Windows UEFI Firmware Update</summary>

This option enables or disables Windows UEFI firmware update feature.

One of 2 possible options for Windows UEFI firmware updates:

1. **Enabled** - Allow Windows UEFI firmware update. Default.
1. Disabled - BIOS Will Skip Windows UEFI firmware update.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WindowsUEFIFirmwareUpdate | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Smart USB Protection</summary>

Smart USB Protection could block copying data from the
computer to the USB storage device in windows.

One of 2 possible options for Smart USB Protection:

1.  **Disabled** - disables Smart USB Protection. Default.
1.  Read Only - The user can copy data from USB storage device to the computer but cannot copy data from the computer to USB storage device.
1.  NO Access - The user cannot use usa storage device in windows


<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SmartUSBProtection | setting_values | yes_no | amd_intel |
-->


</details>

<details><summary>Secure Wipe</summary>

Hide or display the "Secure Wipe" option on the F12 BIOS Startup Menu.

One of 2 possible options for Secure Wipe:

1.  **Disabled** - disables Secure Wipe. Default.
2.  Enabled - enables Secure Wipe.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| securewipe | setting_values | yes_no | amd_intel |
-->

<!-- TODO: why is securewipe lowercase? -->
</details>

<!-- <details><summary>TCG Feature setup</summary>
contains TCG security features.
</details>

<details><summary>System Event Log</summary>
View or clear the system event log.
</details>

<details><summary>Sec Boot</summary>
Secure Boot flow control. Secure Boot is possible only
if System runs in user MOde.
</details>

<details><summary>Certificate-based BIOS Authentication</summary>
</details>

<details><summary>Computrace</summary>
</details>
 -->

<details><summary>Device Guard</summary>

Device Guard protects against malware by restricting the device across several technologies.   

One of 2 possible options for Device Guard:

1.  **Disabled** - Ethernet, USB, CD, and other boot methods are enabled.
1.  Enabled - CPU Virtualization Technology，IOMMU (Intel VT-d, AMD-Vi),  Secure boot, and TPM are enabled. Ethernet, USB, CD, and other boot methods are disabled. Only SATA devices are allowed.


<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| DeviceGuard | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Secure Core PC Level3</summary>

One of 2 possible options for support Windows 10/11 Secured-core PCs Level3:

1.  **Disabled** - disables support for Windows 10/11 Secured-core PCs Level3. Default.
2.  Enabled - enables support for Windows 10/11 Secured-core PCs Level3.

 - [More information at Microsoft Docs](https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/oem-highly-secure)

</details>

<details><summary>Electronic Lock</summary>
Select whether to lock the chassis to prevent unauthorized physical access to the system components.


**NOTE:** Effective on the next startup after BIOS setting is saved.

One of 2 possible options for Electronic Lock:

1.  **Disabled** - disables Electronic Lock. Default.
2.  Enabled - enables Electronic Lock.


<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| setting_name | setting_values | yes_no | amd_intel |
-->


</details>

<details><summary>Cover Tamper Detected</summary>

Chassis Intrusion Detection is a utility that can tell whether someone has opened the case (intruded into the chassis).

One of 2 possible options for Chassis Intrusion Detection:

1.  **Disabled** - disables Chassis Intrusion Detection. Default.
2.  Enabled - enables Chassis Intrusion Detection.

**NOTE:** If chassis tamper occurs, you can only clear this error by entering setup.


<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| CoverTamperDetected | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Configuration Change Detection</summary>

One of 2 possible options for Configuration Change Detection:

1.  **Disabled** - disables Configuration Change Detection. Default.
2.  Enabled - enables Configuration Change Detection. When a device is installed or removed, the system will notify the user during POST.


**NOTE:** This notice can only be cleared by entering BIOS setup, saving and then exiting.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ConfigurationChangeDetection | setting_values | yes_no | amd_intel |
-->


</details>

<!-- <details><summary>Password Count Exceeded Error</summary>
select Enabled to snow the POST 0199 error and
prompt for password. Select Disabled to hide the POST
0199 error and proceed Without any user action required. -->