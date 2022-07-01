# Video Setup #

![](./img/thinkcenter_video_setup.png)

<details><summary>Select Active Video</summary>

The primary video device for graphics output.

Options:

1.  **Auto** - automatic selection of graphics output by the system. Default.
1.  IGD - Select Integrated Graphics Device.
1.  PEG - Select PCIe Graphic.


?> If `Auto` is selected, the system will select a graphics output, **prioritizing PEG**. <br /> 

?> The `IGD` option will not appear if not supported by the CPU.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| SelectActiveVideo  | IGD, [PEG], Auto | yes |

</details>

<details><summary>Pre-Allocated Memory Size</summary>

Allocate memory to the IGD (Internal Graphics Device).

Options:

1.  **32MB** - Default.
1.  64MB
1.  96MB
1.  128MB
1.  160MB

<!-- TODO: add WMI -->
</details>

<details><summary>Total Graphics Memory</summary>

Total memory shared by all graphics devices.

Options:

1.  **Maximum** - enables maximum memory allocation. Default.
2.  128MB.
3.  256MB.
</details>

<details><summary>Dual DisplayPorts</summary>

Dual display ports 1 and 2.

Enable support for MST (multi-stream transport), allowing daisy-chaining of graphics output devices.

Options:

1.  **MST** - Default.
2.  SST (single-stream transport).

<!-- TODO: add WMI -->
</details>
