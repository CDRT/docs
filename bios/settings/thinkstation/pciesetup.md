# PCIe Setup #

![](./img/ts_pciesetup_px1.png)
![](./img/ts_pciesetup_px2.png)
<!--![](./img/ts_pciesetup_px.png)
![](./img/ts_pciesetup_px_2.png)-->

<details><summary>Re-Size BAR Support</summary>
If system has Resizable BAR capable PCIe Devices, this option
Enables or Disables Resizable BAR Support.
Options:

1. **Disabled** – Default.
2. Enabled.
</details>


<details><summary>SR-IOV Support</summary>
If system has SR-IOV capable PCIe Devices, this option Enables
or Disables Single Root IO Virtualization Support.

Options:

1. **Disabled** – Default.
2. Enabled.

</details>

<details><summary>ASPM Support</summary>
<Auto> Configure ASPM automatically according to what the
attached device supports in each PCI Express port
<Disabled> Disable ASPM support of all PCI Express ports.

Options:

1. **Disabled** – Default.
2. Auto.

</details>

<details><summary>Link Training Timeout(uS)</summary>
Defines number of Microseconds software will wait before polling
'Link Training' bit in Link Status register. Value range from 10 to 10000 uS.
Options:

1. **1000** – Default.
2. Simulator not support.

</details>

<!-- Need to add all of the PCIe Slotx Configurations 
These will likely be subheader drop downs
-->