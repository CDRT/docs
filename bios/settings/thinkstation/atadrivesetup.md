# ATA Drive Setup Settings #
![](./img/atadrivesetup.png)

<details><summary>SATA Controller</summary>
One of 2 possible states for the SATA controller:

1. **Enabled** – SATA controller is enabled. Default.
2. Disabled – SATA controller is disabled.

!> When SATA controller is disabled, the following settings become unavailable:<br>    a. SATA Drive (drives 1 to 5) <br>    b. SATA Drive * Hot-Plug Support <br>    c. Configure SATA as <br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>SATA Drive {Number}</summary>
One of 2 possible states for each SATA Drive numbered {Number}:

1. **Enabled** – the corresponding SATA Drive is enabled. Default. 
2. Disabled – the corresponding SATA Drive is disabled.

**Note**. The fields are unavailable, if `SATA Controller` is set to `Disabled`.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>SATA Drive * Hot-Plug Support</summary>
One of 2 possible states for the hot-plug port:

1. Enabled – the hot-plug port is enabled. 
2. **Disabled** – the hot-plug port is disabled. Default.

**Note**. The field is unavailable, if `SATA Controller` is set to `Disabled`.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Configure SATA as</summary>
One of 3 possible options for SATA configuration mode:

1. **ANCI** – Default. Requires additional confirmation.<br> 
2. Intel(R) RST with Intel(R) Optane
3. RAID – Requires additional confirmation.<br> 

!> If you change the SATA mode to `ANCI` you may not boot the system due to the failure of Intel(R) RST with Intel(R) Optane (RAID) function.<br />Do not disable SATA drives in RAID mode. Otherwise you may not boot the system due to the failure of RAID function. <br /> Device driver support is required for `ANCI` or `RAID` or Intel(R) RST with Intel(R) Optane. 
Depending on how the hard disk image was installed, changing the setting may prevent the system from booting.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Hard Disk Pre-delay</summary>

Add a delay before the first access of a hard disk by the system software. 

Some hard disks hang if accessed before they have initialized themselves.

This delay ensures the hard disk has initialized after power up, prior to being accessed.<br>

One of 8 possible options:

1. **Disabled** – Default.
2. 3 Seconds
3. 6 Seconds
4. 9 Seconds
5. 12 Seconds
6. 15 Seconds
7. 21 Seconds
8. 30 Seconds

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>