# Advanced #

![](./img/thinkcenter_advanced.png)

<details><summary>Intel (R) SIPP Support</summary>

Intel (R) Stable Image Platform Program aligns and stabilizes key Intel platform components, enabling a predictable transition from one technology generation to the next.

Options:

1. **Enabled** - enables SIPP. Default.
2. Disabled - disables SIPP.

<!-- TODO: WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| IntelSIPPSupport | setting_values | yes_no | amd_intel |
-->

</details>

<details><summary>Intel (R) Thunderbolt</summary>

Enable or Disable Intel (R) Thunderbolt.

Options:

1.  **Disabled** - disables Intel (R) Thunderbolt. Default.
2.  Enabled - enables Intel (R) Thunderbolt.

<!-- TODO: add WMI -->

</details>


<details><summary>Dust Shield Alert</summary>

The user is reminded to clean the Dust Shield.

Options:

1.  **Enabled** - enables the Dust Shield alert. Default.
1.  Disabled - disables the Dust Shield alert.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| DustShieldAlert | setting_values | yes_no | amd_intel |
-->

?> If the Dust Shield is not cleaned, it will lose its effectiveness and the machine may overheat.

</details>


<details><summary>Intel (R) DPTF Support</summary>

Intel (R) Dynamic Platform and Thermal Framework (DPTF).

IDPTF is a power and thermal management solution, used to resolve fan noise, overheating, and performance-related issues of the system.

Options:

1.  **Enabled** - enables DPTF. Default.
2.  Disabled - disables DPTF.

<!-- TODO: WMI -->

</details>

<details><summary>Windows Modern Standby</summary>

[Windows Modern Standby](https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/modern-standby) is the replacement for the legacy Sleep state.

Options:

1. **Enabled** - enables Windows Modern Standby. Default.
2. Disabled - disables Windows Modern Standby.

<!-- TODO: add WMI-->

<!-- MODEL: NOT M70s-->

</details>

<details><summary>BIOS Self-healing</summary>

Allows the BIOS to automatically attempt to recover a corrupted BIOS without needing a recovery file on external media.

Options:

1.  **Enabled** - Default.
2.  Disabled.

<!--
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BIOSSelfHealing  | setting_values | yes_no | amd_intel |
-->

</details>
