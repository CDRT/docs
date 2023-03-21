# PCI Express Configuration Settings #
![](./img/pciexpressconfig.png)

<details><summary>ASPM Support</summary>

ASPM (Active State Power Management).

Options:

1. **Auto** – configure ASPM automatically according to what the attached device supports in each PCI (Peripheral Component Interconnect) Express port. Default.
2. Disabled – Disable ASPM support of all PCI Express ports.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ASPMSupport | Disabled, Auto | yes | Both |
</details>

<details><summary>PCIe 16x Slot Speed</summary>

Options:

1. **Auto** – Default.
2. Gen 1
3. Gen 2
4. Gen 3
5. Gen 4

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe16xSlotSpeed | Auto, Gen1, Gen2, Gen3, Gen4 | yes | Intel |
</details>

<details><summary>PCIe 4x Slot Speed</summary>

Options:

1. **Auto** – Default.
2. Gen 1
3. Gen 2
4. Gen 3

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe4xSlotSpeed | Auto, Gen1, Gen2, Gen3 | yes | Intel |
</details>

<details><summary>PCIe 1x Slot Speed</summary>

Options:

1. **Auto** – Default.
2. Gen 1
3. Gen 2
4. Gen 3

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe1xSlotSpeed | Auto, Gen1, Gen2, Gen3 | yes | Intel |
</details>