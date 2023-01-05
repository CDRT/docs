# Device Guard Settings #
![](./img/deviceguard.png)

<details><summary>Device Guard</summary>

Whether to enable Microsoft (R) Device Guard.

!> To configure Device Guard, Supervisor Password must be set.

Possible options:

1.	**Off** - Default. 
2.	On

!>  When enabled, Intel Virtualization Technology, Intel VT-d Feature, Secure Boot and OS Optimized Defaults are automatically enabled.

!> Boot Order is restricted to customer image only.

?> This option requires additional confirmation.

| WMI Setting name | Values | Locked by SVP | AMD/Intel |
|:---|:---|:---|:---|
| DeviceGuard | Disable, Enable | Yes | Intel |

</details>