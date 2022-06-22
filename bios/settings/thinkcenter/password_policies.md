# Password Policies #


![](./img/thinkcenter_password_policy.png)

 - [More information at Lenovo Support - types of password](https://support.lenovo.com/us/en/solutions/ht513634)
 - [More information at Lenovo Support - password manager](https://support.lenovo.com/us/en/solutions/ht103666-introduction-to-password-manager-thinkpad-thinkcentre-thinkstation)

<details><summary>Set Minimum Length</summary>

Options:

 *  **Disabled** - no minimum (see below). Default.
 *   4 - 12 characters minimum.

?> If no minimum is set, passwords may be 1 to 128 characters long.

?> If a minimum is set, it applies to:
 - Supervisor Password (SVP)
 - System Management Password (SMP)
 - Power-on (POP) and Hard Disk Passwords 

?> If both `Set Minimum Length` and `Set Strong Password` are enabled, the longest value for minimum length applies.

<!-- 
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SetMinimumLength | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Set Strong Password</summary>

Options:

1.  **Enabled** - Upper case, lower case and numeric characters are all required. Special characters are optional. The minimum length is 8. Default.
1.  Disabled - The minimum length is 1 character.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SetStrongPassword | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Keyboard Layout</summary>

Select the keyboard language for password.

Options:

1.  **English** - Default.
2.  French
3.  German
4.  Russian
5.  Chinese

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| KeyboardLayout | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>BIOS Password At System Boot</summary>

Whether to give a BIOS password prompt at system boot (when the system starts from the full off or hibernate state):

1.  **Yes** - Default.
1.  No.

!> To prevent unauthorized access to the system, we recommend setting user authentication on the OS.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BIOSPasswordAtSystemBoot | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>BIOS Password At Reboot</summary>

Whether the power-on password (POP) is required when system restarts.

Options:

1.  **No** - disables password prompt on reboot. Default.
1.  Yes - enables password prompt on reboot.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BIOSPasswordAtReboot | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>BIOS Password At Boot Device List</summary>

Whether the user is prompted for a password when F12 is pressed during POST (and an administrator password was set).

Options:

1.  **No** - Default.
1.  Yes.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BIOSPasswordAtBootDeviceList | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Require SVP when Flashing</summary>

Whether the supervisor password (SVP) is required when updating the system firmware.

Options:

1.  **No** - Default.
1.  Yes.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| RequireSVPwhenFlashing | setting_values | yes_no | amd_intel |
-->


</details>

<details><summary>POP Changeable by User</summary>

Whether the Power-On Password (POP) can be changed by users, or else, only with the Supervisor Password (SVP).

Options:

1.  **Yes** - Default.
2.  No.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| POPChangeablebyUser | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Allow the Jumper to Clear SVP</summary>

Whether to allow the hardware jumper to clear the Supervisor
password.

Options:

1.  **Yes** - Default.
2.  No.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| AllowJumperClearSVP | setting_values | yes_no | amd_intel |
-->
!> When disabled, no action can reset the SVP if you forget it.

</details>

<details><summary>Password Count Exceeded Error</summary>

Whether to show the POST 0199 error and password prompt:

1.  **Enabled** - Default.
2.  Disabled.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PasswordCountExceededError | setting_values | yes_no | amd_intel |
-->

 - [More information at Lenovo Support](https://support.lenovo.com/lt/en/solutions/ht052093-error-0199-system-security-security-password-retry-count-exceeded-thinkcentre-m90-m90p-thinkserver-ts200v-thinkstation-e20)

</details>