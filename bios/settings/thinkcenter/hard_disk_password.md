# Hard Disk Password #

![](./img/thinkcenter_hard_disk_password.png)

<!-- MODEL: M70s disabled, M70q, M90 s & q enter -->

<details><summary>M.2 Drive 1 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data from the hard disk. In addition to the User Password, a optional Master Password can be used to recover the disk if the user password is lost.

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>M.2 Drive 2 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user password, an optional Master password can be used to recover the disk if the user Password is lost.

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>PCIe Drive 1 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master Password can be used to recover the disk if the user password iS lost.

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>PCIe Drive 2 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master Password can be used to recover the disk if the user Password is lost.

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>SATA Drive 1 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master Password can be used to recover the disk if the user password iS lost.

**NOTE** It several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>SATA Drive 2 Password</summary>

Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master password can be used to recover the disk if the user Password is lost. 

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>SATA Drive 3 Password</summary>

A Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master Password can be used to recover the disk if the user password iS lost. 

**NOTE** It several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>SATA Drive 4 Password</summary>

Hard Disk Password prevents unauthorized users from accessing the data on the Hard Disk. In addition to the user Password, an optional Master password can be used to recover the disk if the user Password is lost.

**NOTE** If several disks are present, we recommend setting all Hard Disk Passwords to the same.

</details>

<details><summary>Require HDP on System Boot</summary>

One of 3 possible options for the Hard Disk Password (HDP):
1.  **Auto** - HDP will be required if the Hard Disk is in lock status when the system starts from the full off, hibernate or restart state. Default.
2.  Power On - HDP will be required when the system starts from the full off or hibernate state.
3.  No - HDP will not be required. However, HDP will be required when the hard disk is attached to a different system.

</details>

<details><summary>Block SID Authentication</summary>

description.
One of 2 possible options for SID authentication:

1.  **Enabled** - enables SID authentication block. Default.
2.  Disabled - disables SID authentication block.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| BlockSIDAuthentication | setting_values | yes_no | amd_intel |
-->

</details>


### Security Erase HDD Data ###

Select this option to security erase HDD data.

The items are only available when corresponding hard disk password is present.

**WARNING:** All HDD data will be erased and the hard disk password will be deleted.

![](./img/thinkcenter_secure_erase_hdd_data.png)


<details><summary>Erase M.2 Drive 1 Data</summary>

Securely erase M.2 Drive data.

</details>

<details><summary>Erase M.2 Drive 2 Data</summary>

Securely erase M.2 Drive data.

</details>

<details><summary>Erase PCIe Drive 1 Data</summary>

Securely erase PCIe Drive 1 data.

</details>

<details><summary>Erase PCIe Drive 2 Data</summary>

Securely erase PCIe Drive 2 data.

</details>

<details><summary>Erase SATA Drive 1 Data</summary>

Securely erase SATA Drive 1 data.

</details>

<details><summary>Erase SATA Drive 2 Data</summary>

Securely erase SATA Drive 2 data.

</details>

<details><summary>Erase SATA Drive 3 Data</summary>

Securely erase SATA Drive 3 data.

</details>

<details><summary>Erase SATA Drive 4 Data</summary>

Securely erase SATA Drive 4 data.

</details>
