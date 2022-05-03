# CPU Setup #
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