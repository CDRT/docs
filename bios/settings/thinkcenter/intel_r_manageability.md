# Intel(R) Manageability #

![](./img/thinkcenter_intel_r_manageability.png)

 - [More information at Intel.com](https://software.intel.com/sites/manageability/AMT_Implementation_and_Reference_Guide/default.htm)

<details><summary>Intel(R) Manageability Control</summary>

<!-- TODO: feature confirmation-->

One of 2 possible options for Intel(R) Manageability Control:

1.  **Enabled** - enables Intel(R) Manageability Control. Default.
2.  Disabled - disables Intel(R) Manageability Control.

<!-- TODO: add WMI -->

**WARNING:** If you set Intel(R) Manageability Control to "Disabled":

 1. If system is provisioned, MEBx will be unprovisioned
first. <strong>When the unprovsioning prompt appears, select YES.</strong>

 2. Manageability functions will be disabled. <strong>You can
enter ME-BX or BIOS to re-enable Intel(R) Manageability.</strong>.

</details>


<details><summary>Intel(R) Manageability Reset</summary>

Return Intel(R) Manageability settings to default configuration.

One of 2 possible options for Intel(R) Manageability Reset:

1. **Enabled** - enables Intel(R) Manageability Reset. Default.
2. Disabled - disables Intel(R) Manageability Reset.

**Note:**  WARNING: the MEBx password will also be reset.

</details>

### ME Firmware Version ###

Displays the firmware version.

<!-- TODO: styles-->

### Manageability Type ###

Displays the manageability type.

<!-- TODO: styles-->

</details>

<details><summary>USB Provisioning</summary>


One of 2 possible options for USB provisioning:

1.  **Enabled** - enables USB provisioning. Default.
2.  Disabled - disables USB provisioning.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| USBProvisioning | setting_values | yes_no | amd_intel |
-->

</details>
