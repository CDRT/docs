# Video Setup #

![](./img/thinkcenter_video_setup.png)

<details><summary>Select Active Video</summary>
The primary video device for graphics output.
One of 3 possible options for primary video device:

1.  **Auto** - enables automatic selection of graphics output by the system. Default.
2.  IGD - enables IGD (Integrated Graphics Device).
3.  PEG - enables PEG (PCIe Graphic).

**Note**:
- If `Auto` is seleted, the system will select a graphics output, prioritizing PEG.
- The "IGD" option will not appear if not supported by the CPU.
<!-- TODO: add WMI -->
</details>

<details><summary>Pre-Allocated Memory Size</summary>
Allocate memory to the IGD (Internal Graphics Device).

One of 5 possible options, from **32MB** to 160MB, in 32MB increments.

<!-- TODO: add WMI -->
</details>

<details><summary>Total Graphics Memory</summary>
Total memory shared by all graphics devices.
One of 3 possible options for total memory:

1.  **Maximum** - enables maximum memory allocation. Default.
2.  128MB - enables 128MB of memory allocation.
3.  256MB - enables 256MB of memory allocation.
</details>

<details><summary>Dual DisplayPorts</summary>
Enable support for MST (multi-stream transport), allowing daisy-chaining of graphics output devices.
One of 2 possible options for MST:

1.  **MST** - enables multi-stream transport. Default.
2.  SST - enables single-stream transport.

<!-- TODO: add WMI -->
</details>
