# Secure Boot


![](./img/thinkcenter_secure_boot.png)


### System Mode ###

<details><summary>Secure Boot</summary>

1.  **Enabled** - BIOS will prevent unauthorized OS from loading.
1.  Disabled - disables Secure Boot.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SecureBoot | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Restore Factory Keys</summary>

Restore Factory Keys Will put secure boot into factory defaults.

Press `Yes` to proceed, or `No` to cancel.

</details>

<details><summary>Reset Platform to Setup Mode</summary>

Reset to setup mode will move secure boot to setup mode.

</details>

<details><summary>Enter Audit Mode</summary>

Enter Audit Mode workflow.

Transition from user to Audit Mode will result in erasing PK variable.

</details>

<details><summary>Enter Deployed Mode</summary>

Transition between Deployment and User Modes.

</details>

<details><summary>Allow Microsoft 3rd Party UEFI CA</summary>

One of 2 possible options for Microsoft 3rd Party UEFI CA:

1.  **Enabled** - enables Microsoft 3rd Party UEFI CA. Default.
2.  Disabled - disables Microsoft 3rd Party UEFI CA.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| AllowMicrosoft3rdPartyUEFICA | setting_values | yes_no | amd_intel |

**NOTE:** If add-on Cards are supported, Microsoft 3rd Party UEFI CA will not be removed until load boot loader.

<!-- MODEL: Only M90t/s-3 -->

</details>

### Key Management ###

<!-- SIMULATOR DOES NOT SUPPORT --> 