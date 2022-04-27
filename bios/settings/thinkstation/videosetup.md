# Video Setup #
![](./img/videosetup.png)

<details><summary>Select Active Video</summary>
One of 3 options to select primary video device that will be used for graphics output:

1. **Auto** – Default. If selected, then system will prioritize video devices as following sequence:<br>
    a.	PEG<br>
    b.	IGD<br>
2. IGD – Internal Graphics Device will be used.
3. PEG – PCI-e Graphics Device will be used.

**Note**. If CPU does not support integrated graphics, there will be no “IGD” option.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Pre-Allocated Memory Size</summary>
One of 3 options to allocate memory in the IGD (Internal Graphics Device):

1. **32 MB** – Default.
2. 64 MB
3. 128 MB

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Total Graphics Memory</summary>
One of 3 options to allocate total memory which graphics device shares:

1. 128 MB
2. 256 MB
3. **Maximum** – Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>