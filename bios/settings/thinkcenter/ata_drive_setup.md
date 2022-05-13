# ATA Drive Setup #

![](./img/thinkcenter_ata_drive_setup.png)

<details><summary>SATA Controller</summary>

One of 2 possible options for enabling the SATA controller:

1.  **Enable** - enables the SATA controller. Default.
2.  Disable - disables the SATA controller.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SATAController | setting_values | yes_no | amd_intel |
> **Note**. If the "SATA Controller" is set to "Disabled", then “Configure SATA as” and "SATA Drive #" will be hidden.
</details>

<details><summary>SATA DRIVE #</summary>
One of the (Serial AT Attachment) Drives. Number depends on model.
One of 2 possible options for feature:

1.  **Enabled** - enables this SATA drive. Default.
2.  Disabled - disables this SATA drive.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SATADrive1 | setting_values | yes_no | amd_intel |
> **Note** The WMI setting name for Drive 1 is shown. Other drives follow the pattern `SATADrive#` where `#` is the number of the drive.
</details>

<details><summary>Configure SATA As</summary>
Configure the SATA (Serial AT Attachment) drive controller.
One of 2 possible options for the SATA drive controller:

1.  **AHCI** - enables AHCI (Advanced Host Controller Interface). Default.
2.  Intel (R) RST with Intel (R) Optane mode - enables RST.
3. RAID - enables RAID. <!-- MODEL: M70S Gen3 only-->

<!-- TODO: add WMI -->

</details>

<details><summary>Intel Rapid Storage Technology</summary>

<!-- SIMULATOR DOES NOT SUPPORT -->
</details>

<details><summary>Hard Disk Pre-Delay</summary>
This delay ensures the hard disk has initialized after power up, prior to being accessed, to avoid the disk hanging.
One of 8 possible options for the delay time:

1.  **Disabled** - enables delay. Default.
2.  3 - 30 seconds - enables delay, in increments of 3 seconds up 15, then 21 or 30.

<!-- TODO: add WMI -->
</details>
