# System Management Password Access Control

![](./img/thinkcenter_system_management_password_access_control.png)

<details><summary>Access Security Settings</summary>

Allow SMP (System Management Password) to have the same authority as SVP (Supervisor Password) to control security settings.

Options:

1.  **Disabled** - Default.
2.  Enabled.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| AccessSecuritySettings | setting_values | yes_no | amd_intel |
-->
</details>

<details><summary>Remote Set SMP</summary>

Allow remote setting of the SMP via WMI without SVP (Supervisor Password) verification.

Options:

1.  **Disabled** - Default.
2.  Enabled.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| RemoteSetSMP | setting_values | yes_no | amd_intel |
-->
</details>
