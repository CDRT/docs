# Security #

![](./img/thinkcenter_security.png)

 - [More information at Lenovo Support - types of password](https://support.lenovo.com/us/en/solutions/ht513634)
 - [More information at Lenovo Support - password manager](https://support.lenovo.com/us/en/solutions/ht103666-introduction-to-password-manager-thinkpad-thinkcentre-thinkstation)

<details><summary>Supervisor Password</summary>

Options:

1.  **Not Installed** - password disabled. Default.
2.  Installed -  password enabled.

</details>

<details><summary>Power-On Password</summary>

Options:

1. **Not Installed** - password disabled. Default.
2. Installed -  password enabled.

</details>

<details><summary>System Management Password</summary>

Options:

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

<!-- ### System Management Password Access Control ###

The System Management Password prevents unauthorized users from accessing BIOS Setup in default. -->

<!-- 
### Hard Disk Password ###

Configure hard disk password.

### Password Policies ###

Configure the password policies

-->

<details><summary>Secure Roll Back Prevention</summary>

Whether flashing BIOS to a previous or current version is prevented (NOT allowed).

Options:

1.  **Yes** - Flashing NOT allowed. Default.
1.  No - Flashing BIOS allowed.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SecureRollBackPrevention | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Windows UEFI Firmware Update</summary>

Options:

1. **Enabled** - Default.
1. Disabled - BIOS will skip Windows UEFI firmware update.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WindowsUEFIFirmwareUpdate | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Smart USB Protection</summary>

Block USB write access (copying data from computer to USB storage device) in Windows.

Options:

1.  **Disabled** - disables Smart USB Protection. Default.
1.  Read Only - The user can copy data from USB to computer, but not from computer to USB.
1.  NO Access - The user cannot use USB storage device in Windows.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SmartUSBProtection | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Secure Wipe</summary>

Hide or display the `Secure Wipe` option on the F12 BIOS Startup Menu.

Options:

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

Options:

1.  **Disabled** - Ethernet, USB, CD, and other boot methods are enabled.
1.  Enabled - CPU Virtualization Technology，IOMMU (Intel VT-d, AMD-Vi),  Secure boot, and TPM are enabled. Ethernet, USB, CD, and other boot methods are disabled. Only SATA devices are allowed.


<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| DeviceGuard | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Secure Core PC Level3</summary>

Whether to support Windows 10/11 Secured-core PCs' Level3:

1.  **Disabled** - Default.
2.  Enabled.

 - [More information at Microsoft Docs](https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/oem-highly-secure)

</details>

<details><summary>Electronic Lock</summary>

Whether to lock the chassis to prevent unauthorized physical access to the system components.

**NOTE:** Effective on the next startup after BIOS setting is saved.

Options:

1.  **Disabled** - Default.
2.  Enabled.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| setting_name | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Cover Tamper Detected</summary>

Chassis Intrusion Detection is a utility that can tell whether someone has opened the case (intruded into the chassis).

Options:

1.  **Disabled** - Default.
1.  Enabled.

**NOTE:** If chassis tamper occurs, you can only clear this error by entering setup.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| CoverTamperDetected | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Configuration Change Detection</summary>

Options:

1.  **Disabled** - Default.
2.  Enabled. When a device is installed or removed, the system will notify the user during POST.

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