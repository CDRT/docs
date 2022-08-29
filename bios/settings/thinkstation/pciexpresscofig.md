# PCI Express Configuration Settings #
![](./img/pciexpressconfig.png)

<details><summary>ASPM Support</summary>

ASPM (Active State Power Management).

Options:

1. **Auto** – configure ASPM automatically according to what the attached device supports in each PCI (Peripheral Component Interconnect) Express port. Default.
2. Disabled – Disable ASPM support of all PCI Express ports. 

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ASPMSupport | Disabled,Auto | yes | Both |
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
| PCIe16xSlotSpeed |  | yes | Both |
</details>


<details><summary>PCIe 4x Slot Speed</summary>

Options:

1. **Auto** – Default. 
2. Gen 1
3. Gen 2
4. Gen 3

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe4xSlotSpeed |  | yes | Both |
</details>


<details><summary>PCIe 1x Slot Speed</summary>

Options:

1. **Auto** – Default. 
2. Gen 1
3. Gen 2
4. Gen 3

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe1xSlot1Speed |  | yes | Both |
</details>


<details><summary>PCIe {Generation} Slot Speed</summary> <!-- TODO: confirm Gen = Generation -->

The {Generation} is the item name based on the motherboard silkscreen.<br>

Options:

1. **Auto** – Default. 
2. Gen 1
3. Gen 2
4. Gen 3

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| PCIe{Generation}Slot1Speed |  |  | Both |
</details>