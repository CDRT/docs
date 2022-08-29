# USB Setup Settings #

![](./img/usbsetup.png)

?> The number of USB ports may vary depending on model.

<details><summary>USB Port Access</summary>

Whether to enable USB devices.

!> When disabled, all other USB settings are removed, except for `USB Enumeration Delay`.

Options:

1. **Enabled** – Default.
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| USBPortAccess | Disabled,Enabled | yes | Both |

</details>

<details><summary>USB Enumeration Delay</summary>

Whether extra delay is added when host performs USB enumeration.

!> May improve the compatibility of USB device detection but increase POST Time.

1. Enabled.
2. **Disabled** - Default.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| USBEnumerationDelay |  | yes | Both |

</details>

<details><summary>Front USB Ports</summary>

Whether to enable all Front USB ports and relevant setting fields. 

Options:

1. **Enabled** – Default.
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| FrontUSBPorts | Disabled,Enabled | yes | Both |

</details>


<details><summary>USB Port {Number}</summary>

{Number} is the order number of the front USB port. 

For each Front USB Port:

1. **Enabled**. Default, if `Enabled` is selected in `Front USB Ports`. 
2. Disabled. 

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| USBPort1 |  | yes | Both |

?> The WMI setting name is for USB port 1. For other USB ports change the number to that of the desired front USB port.

</details>


<details><summary>Rear USB Ports</summary>

Whether to enable or disable all rear USB ports and relevant settings. 

Options:

1. **Enabled** –  Default.
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| RearUSBPorts | Disabled,Enabled | yes | Both |
</details>

<details><summary>USB Port {Number}</summary>

{Number} is the number of the rear USB port (total number of ports dependent on model).

For each Rear USB Port:

1. **Enabled**. Default, if `Enabled` is selected in `Rear USB Ports`. 
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| USBPort7 |  | yes | Both |

?> The WMI setting name is for USB port 7. For other USB ports change the number to that of the desired rear USB port.

</details>