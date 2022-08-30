# Advanced #

![](./img/advanced.png)

<details><summary>Intel(R) SIPP Support</summary>

?> Intel(R) Stable Image Platform Program (SIPP) aligns and stabilizes key Intel platform components, enabling a predictable transition from one technology generation to the next.

Options:

1. **Enabled** – Default.
2. Disabled.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| IntelSIPPSupport | Disabled,Enabled | yes | Intel |
</details>


<details><summary>Intel(R) DPTF Support</summary>

?> Intel(R) Dynamic Platform and Thermal Framework (DPTF) assists with managing power to the CPU vs temperature, keeping CPU temperature down while still delivering good performance.

Options:

1. **Enabled** – Default.
2. Disabled.

?> This feature is optional, so may not be available on all models.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| IntelDPTFSupport | Disabled,Enabled | yes | Intel |

</details>