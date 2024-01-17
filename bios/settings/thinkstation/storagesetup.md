# Storage Setup #

![](./img/ts_storagesetup_p3twr_1.png)
<!--![](./img/ts_storagesetup_p3twr_2.png)-->
![](./img/ts_storagesetup_px_1.png)
![](./img/ts_storagesetup_px_2.png)


<details><summary>SATA Controller</summary>

Options:

1. **Enabled** – Default.
2. Disabled.
</details>


<details><summary>SATA Drive 1</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>


<details><summary>SATA Drive 2</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>SATA Drive 3</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>SATA Drive 4</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>SATA Drive 5</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>SATA Drive 6</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>M.2 Drive 1</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>M.2 Drive 2</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>M.2 Drive 3</summary>

Options:

1. **Enabled** – Default.
2. Disabled.

</details>

<details><summary>MCIO Drive 1-1</summary>

</details>

<details><summary>MCIO Drive 1-2</summary>

</details>

<details><summary>MCIO Drive 2-1</summary>

</details>

<details><summary>MCIO Drive 2-2</summary>

</details>

<details><summary>SATA Drive * Hot-Plug Support</summary>
Options:

1. Enabled.
2. **Disabled** – Default.

</details>

<details><summary>Configure Storage as</summary>
Mode Options:

1. **AHCI** – Default.
2. RAID

?>Device driver support is required for AHCI or RAID.
Depending on how the hard disk image was installed, changing
this setting may prevent the system from booting.

</details>

<details><summary>Hard Disk Pre-delay</summary>
Adds a delay before the first access of a hard disk by the system
software. Some hard disks hang if accessed before they have
initialized themselves. This delay ensures the hard disk has
initialized after power up, prior to being accessed.

Options:

1. **Disabled** – Default.
2. 3 Seconds
3. 6 Seconds
4. 9 Seconds
5. 12 Seconds
5. 15 Seconds
6. 21 Seconds
7. 30 Seconds



</details>

### Intel(R) VMD Technology ###
![](./img/ts_intelvmd_1.png)
![](./img/ts_intelvmd_2.png)
![](./img/ts_intelvmd_3.png)

Enable the VMD(Volume Management Device) technology to 
support configure PCIe storages to VROC(Virtual RAID on 
CPU) feature.

<!-- More options for users: (Display image here?)
would these be more dropdown subheaders? or do we make it another page
look at atadriversetup for ex on how they did it
EX: M.2 Slot 1, M.2 Slot 2, M.2 Slot3
	PCIe Slot1, etc -->



</details>