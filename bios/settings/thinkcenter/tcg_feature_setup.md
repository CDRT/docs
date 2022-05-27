# TCG Feature setup

![](./img/thinkcenter_tcg_feature_setup.png)

<details><summary>TCG Security Device State</summary>

Displays the current TCG Security Device (cannot be changed).

One of 3 possible options:

 - Discrete TPM 1.2
 - Discrete TPM 2.0
 - Firmware TPM 2.0


<!-- TODO: add WMI
-->


</details>

<details><summary>Security Chip 2.0</summary>

1.  **Enabled** - TCG security feature is fully functional.
1.  Disabled - TCG security feature is not functional.

**NOTE** - If set to "Disabled", the TXT Will be set to "Disabled" automatically.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SecurityChip | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Clear TCG Security Feature</summary>

Select whether to clear TCG Security Feature.

**WARNING**: Any data in TPM Will be cleared.

One of 2 possible options for Clear TCG Security Feature:

1.  **No** - disables Clear TCG Security Feature. Default.
1.  Yes - enables Clear TCG Security Feature.


<!-- TODO: add WMI
-->


</details>

<details><summary>Physical Presence for Clear</summary>

Whether to require confirmation of a user's physical presence when clearing tne security chip.

1.  **Enabled** - Display user confirmation screen when clearing.
1.  Disabled - NO user confirmation screen when clearing.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PhysicalPresenceforClear | setting_values | yes_no | amd_intel |
-->

</details>