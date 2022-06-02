# PCI Express Configuration #

![](./img/thinkcenter_pci_express_configuration.png)

<details><summary>ASPM support</summary>

One of 2 possible options for active-state power management:

1. **Auto** - Configure ASPM automatically according to what the attached device supports in each PCI Express port. Default.
2. Disable - Disable ASPM support of all PCI Express ports.

<!-- TODO: add WMI
| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| setting_name | setting_values | yes_no | amd_intel |
-->
</details>

Select PCI Express port speed.

<details><summary>PCIe 16x Slot speed</summary>

One of 1 possible options for 16x:

1.  **Auto** - enables default_value. Default.
2.  Gen 1 - enables Gen 1.
3.  Gen 2 - enables Gen 2.
4.  Gen 3 - enables Gen 3.
5.  Gen 4 - enables Gen 4.

<!-- MODEL: S only-->
</details>

<details><summary>PCIe 8x Slot speed</summary>

One of 1 possible options for 8x:

1.  **Auto** - enables default_value. Default.
2.  Gen 1 - enables Gen 1.
3.  Gen 2 - enables Gen 2.
4.  Gen 3 - enables Gen 3.
5.  Gen 4 - enables Gen 4.

<!-- MODEL: M90q only -->
</details>

<details><summary>PCIe 4x Slot speed</summary>

One of 1 possible options for 4x:

1.  **Auto** - enables default_value. Default.
2.  Gen 1 - enables Gen 1.
3.  Gen 2 - enables Gen 2.
4.  Gen 3 - enables Gen 3.
5.  Gen 4 - enables Gen 4.

<!-- MODEL: S only-->
</details>

<details><summary>PCIe 1x Slot speed</summary>

One of 1 possible options for 1x:

1.  **Auto** - enables default_value. Default.
2.  Gen 1 - enables Gen 1.
3.  Gen 2 - enables Gen 2.
4.  Gen 3 - enables Gen 3.

<!-- MODEL: not M70 q-->
</details>