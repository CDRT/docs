### Boot Priority Order ###

This sequence is used when the system is powered up normally.

**NOTE:** Use up and down arrows to select. `+` and `-` increase or decrease priority. Use `x` to exclude the device from the boot sequence.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BootOrder | setting_values | yes_no | amd_intel |
-->

<details><summary>First Boot Device</summary>

Select the first boot priority group. BIOS will try to boot from the group first before trying the boot order.

One of 7 possible options for first boot priority group:

1. **Boot Order**. Default.
1. Network
1. SATA Drive
1. M.2 Drive
1. VMD Drive
1. USB HDD
1. USB CDROM

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| Firstbootdevice | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>First Network Device</summary>

Select the first boot device from the designated group.

**WARNING:** if disabled, the system will try to boot from all the devices in the group.

One of 3 possible options for first network device:

1. **Disabled** - the system will try to boot from all the devices in the group. Default.
1. Network1
1. Network2

</details>

<details><summary>Boot Up Num-Lock Status</summary>

This field indicates the state Of the NumLock feature Of the keyboard after Startup.

One of 2 possible options for NumLock:

1. **On** - keypad keys will act as numeric keys. Default.
1. Off - Keypad keys will act as cursor keys.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BootUpNumLockStatus | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Fast Boot</summary>

This feature can record the last successful startup state to reduce the POST time at the next startup.

**WARNING:** We recommended turning off Fast Boot if you often use CD/DVD or network to load your operating system.

One of 2 possible options for Fast Boot:

1.  **Enabled** - enables Fast Boot. Default.
1.  Disabled - disables Fast Boot.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| FastBoot | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Option Keys Display</summary>

Controls the system software option key prompts (such as the F1 key) when the system is turned on.

One of 2 possible options for option key prompts:

1.  **Disabled** - disables option key prompts. Default.
2.  Enabled - enables option key prompts.

**NOTE:** Disabling the prompts will not affect the function of a specific key.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| OptionKeysDisplay | setting_values | yes_no | amd_intel |
-->

</details>