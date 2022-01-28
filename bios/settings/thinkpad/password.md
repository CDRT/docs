# Password Settings #
### General ###
![](./img/password.png)

<details><summary>Supervisor Password</summary>
The supervisor password protects the system information stored in UEFI BIOS. When entering the UEFI BIOS menu, enter the correct supervisor password in the window prompted. You also can press Enter to skip the password prompt. However, you cannot change most of the system configuration options in UEFI BIOS.

**The supervisor password can be set only through the UEFI BIOS menu.** Once it is in place, then it can be modified Windows Management Instrumentation (WMI) with the Lenovo client-management interface.

If you have set both the supervisor password and power-on password, you can use the supervisor password to access your computer when you turn it on. The supervisor password overrides the power-on password. 

One of 2 possible states:
1.	**Disabled** - no password defined. Default.
2.	Enabled - for enabling system will request to set and confirm password. <br>
While enabling the following parameters are available:

* 2.1 [Enter New Password]
* 2.2 [Confirm New Password]
* 2.3 Show Password – [On\Off] statuses
* 2.4 Keyboard layout: XXXX – Possible values are the same as in [Keyboard\Mouse -> Keyboard Layout](bios/settings/thinkpad/keyboardmouse.md) <br>
* 2.5 < Actions >:<br>
    2.5.1. **Save** – default<br>
    2.5.2. Cancel<br>

When enabled Supervisor Password prevents unauthorized users from accessing these items in ThinkPad Setup:
* Boot priority lists
* Network related items
* Date & Time

**Note**. To have a beep sound when the system is waiting for this password, enable the [Password Beep feature in the Alarm submenu](bios/settings/thinkpad/beepalarm.md).


| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>