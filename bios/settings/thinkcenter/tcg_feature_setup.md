# TCG Feature setup

![](./img/thinkcenter_tcg_feature_setup.png)

<details><summary>TCG Security Device State</summary>

Displays the current TCG Security Device (display only).

Options:

 - Discrete TPM 1.2
 - Discrete TPM 2.0
 - Firmware TPM 2.0

<!-- TODO: add WMI
-->
</details>

<details><summary>Security Chip 2.0</summary>

Whether the TCG security feature is fully functional.

1.  **Enabled** - Default.
1.  Disabled.

**NOTE** - If set to "Disabled", the TxT will be set to "Disabled" automatically.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SecurityChip | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Clear TCG Security Feature</summary>

Whether to clear TCG Security Feature.

**WARNING**: Any data in TPM Will be cleared.

Options:

1.  **No** - Default.
1.  Yes.

<!-- TODO: add WMI
-->
</details>

<details><summary>Physical Presence for Clear</summary>

Whether to require confirmation of a user's physical presence when clearing the security chip.

1.  **Enabled** - Default.
1.  Disabled.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PhysicalPresenceforClear | setting_values | yes_no | amd_intel |
-->

</details>