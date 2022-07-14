# Startup #
![](./img/startup.png)

<details><summary>First Boot Device</summary>

BIOS will try to boot from the group first before trying the boot order.

Options:

1. **Boot Order** – Default. 
2. Network
3. SATA Drive
4. M.2 Drive
5. PCIE Drive
6. USB HDD
7. USB CDROM

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| FirstBootDevice |  | yes | Both |
</details>


<details><summary>First {Drive Type} Device</summary>

Select the first boot device from the designated group:

{Drive Type} means one of:
 - Network
 - SATA
 - M.2
 - PCIE.


1. **Disabled** – system will try to boot from all the devices in the group. Default.
2. Other options will show the relevant list of devices in the group depending on the selected item in 'First Boot Device': 'Network', 'SATA Drive', 'M.2 Drive' or 'PCIE'.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Boot Up Num-Lock Status</summary>

Whether keys on the keypad will act as numeric keys.

Options:

1. **On** – numeric keys. Default. 
2. Off – cursor keys.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BootUpNumLockStatus |  | yes | Both |
</details>


<details><summary>Fast Boot</summary>

 Whether to record the last successful startup state to reduce the POST time at the next startup.

!> We recommended turning off “Fast Boot” if you often use CD/DVD or network to load your operating system.

Options:

1. **Enabled** – Default. 
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| FastBoot |  | yes | Both |
</details>


<details><summary>Option Keys Display</summary>

Whether to display option key prompts (such as F1 key) when the system is turned on.<br>

Options:

1. Enabled. 
2. **Disabled** - Default.

?> Disabling the prompts will not affect the function of a specific key.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| OptionKeysDisplay |  | yes | Both |
</details>


<details><summary>Option Keys Display Style</summary>

?> Visible only if `Option Keys Display` is `Enabled` state.

Which prompts to display on the POST logo screen when the system is turned on.

Options:

1. **Normal** – prompt for the Enter key and display a menu. Default.
2. Legacy – prompt for F1 and F12.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| OptionKeysDisplayStyle |  | yes | Both |
</details>