# Internal Device Access Settings #

![](./img/internaldeviceaccess.png)

<details><summary>Bottom Cover Tamper Detection</summary>

Options:

1.	On. If detected, Supervisor Password is required to boot the system.
2.	**Off** - Default.

!> Bottom Cover Tamper Detection will not take effect unless Supervisor Password is enabled.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BottomCoverTamperDetected | Disable, Enable | No | Both |

</details>

<details><summary>Internal Storage Tamper Detection</summary>

Detects removal of any fixed or removable Internal storage while the system is in sleep state (S3).

!>  While `on`, if storage is removed while the system is in S3 state, the system will shutdown when woken from S3. Unsaved data will be lost.

Options:

1.	On.
2.	**Off** - Default.

</details>