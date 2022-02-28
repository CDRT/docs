# Internal Device Access Settings #
![](./img/internaldeviceaccess.png)

<details><summary>Bottom Cover Tamper Detection</summary>
One of 2 possible states:

1.	On – enables the tamper detection. If detected, Supervisor Password is required to boot the system.
2.	**Off** – disables the tamper detection. Default.

**Note**. Bottom Cover Tamper Detection will not take effect unless Supervisor Password is enabled.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BottomCoverTamperDetected | Disable, Enable | No | Both |
</details>


<details><summary>Internal Storage Tamper Detection</summary>
One of 2 possible states:

1.	On – enables detecting removal of any fixed or removable Internal storage while the system is in sleep state (S3). If a storage is removed while the system is in S3 state, the system will shutdown when woken from S3. Unsaved data will be lost.
2.	**Off** – disables the tamper detection. Default.

</details>