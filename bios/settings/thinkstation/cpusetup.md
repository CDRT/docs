# CPU Setup Settings #
![](./img/cpusetup.png)

<details><summary>Intel(R) Speed Shift Technology</summary>
Intel(R) Speed Shift Technology is an energy efficient method of frequency control by the hardware rather than relying on OS control.<br>
One of 2 possible states:

1. **Enabled** – Default. 
2. Disabled – Intel(R) Speed Shift Technology is turned off. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Intel(R) Hyper-Threading Technology</summary>
Intel(R) Hyper-Threading Technology allows multiple logical processors within the same processor core share execution resources and cache hierarchy between logical processors.<br>
One of 2 possible states:

1. **Enabled** – Default. 
2. Disabled – Intel(R) Hyper-Threading Technology is turned off. 

**Note**. If "TXT" has "Enabled" status, then this item will be enabled and not available for disabling. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Core Multi-Processing</summary>
One of 2 possible states:

1. **Enabled** – All CPU cores are available to the OS. Default. 
2. Disabled – Only one core will be available to the OS.

**Note**. If "TXT" has "Enabled" status, then this item will be enabled and not available for disabling.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Intel(R) Virtualization Technology</summary>
One of 2 possible states:

1. **Enabled** – Default. Intel(R) Virtualization Technology allows PC platforms to run multiple applications and operating systems simultaneously in independent partitions, to help to manage and protect the multi-functional capabilities of PCs.
2. Disabled – Intel(R) Virtualization Technology is turned off and following items get “Disabled” status and become unavailable:<br>
  a. VT-d Feature<br>
  b. TxT

Additional information is available here: [How to enable Virtualization Technology on Lenovo PC computers](https://support.lenovo.com/de/en/solutions/ht500006).

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>VT-d Feature</summary>
One of 2 possible states:

1. **Enabled** – Default. VT-d support on Intel platforms provides the capability to ensure improved isolation of I/O resources for greater reliability, security, and availability.
2. Disabled - VT-d Feature is turned off.

Additional information is available here: [VT-d Feature](https://www.intel.com/content/www/us/en/search.html?ws=text#q=VT-d%20Feature&sort=relevancy&f:@tabfilter=[Developers]).

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>TxT</summary>
One of 2 possible states:

1. Enabled –Trusted Execution Technology (TxT) provides hardware-based mechanisms that help protect against software-based attacks and protects the confidentiality and integrity of all data stored or created on the client PC.
Note. If TxT is set to “Enabled”, then the Security Chip will be set to “Enabled” automatically.
2. **Disabled** – TxT feature is turned off. Default.

Additional information is available here: [Intel(R) TXT Overview](https://www.intel.com/content/www/us/en/support/articles/000025873/technologies.html).

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>IOMMU</summary>
Intel Input\Output Memory Management Unit (IOMMU) is a hardware component that performs address translation from I/O device virtual addresses to physical addresses. This hardware-assisted I/O address translation improves the system performance within a virtual environment.<br>
One of 2 possible states:

1. Enabled – IOMMU is turned on.
2. **Disabled** – IOMMU is turned off. Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>C1E Support</summary>
C1 is a state where the processor is not executing instructions, but can return to an executing state immediately.<br>
One of 2 possible states:

1. **Enabled** – Default. Enhanced C1 state (C1E) provides lower power consumption when the computer is idle.  
2. Disabled.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>C State Support</summary>
One of 6 possible options to select supported CPU power management status to minimize the idle power consumption of processor:

1. C1 – C1 only.
2. C1C3 – C1 and C3.
3. C1C3C6 – C1, C3 and C6.
4. C1C3C6C7C8 – C1, C3, C6, C7 and C8.
5. **C1C3C6C7C8C10** – C1, C3, C6, C7, C8 and C10. Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Turbo Mode</summary>
One of 2 possible states:

1. **Enabled** – allows the processor to assess its ow thermals, current and power to come up with a dynamic upper limit on its frequency benefit. Default. 
2. Disabled - Turbo Mode is turned off. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>CPU ID</summary>
Displays the Processor ID. View only.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Microcode Revision ( MM/DD/YYYY )</summary>
Displays the CPU Microcode Revision date. View only.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>