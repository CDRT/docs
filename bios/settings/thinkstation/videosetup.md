# Video Setup Settings #
![](./img/videosetup.png)

<details><summary>Select Active Video</summary>

Options:

1. **Auto** – Default. If selected, then system will prioritize video devices as following sequence:<br>
    a.	PEG<br>
    b.	IGD<br>
2. IGD – Internal Graphics Device will be used.
3. PEG – PCI-e Graphics Device will be used.

?> If CPU does not support integrated graphics, there will be no `IGD` option.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| SelectActiveVideo |  | yes | Both |
</details>


<details><summary>Pre-Allocated Memory Size</summary>

Allocate memory in the IGD (Internal Graphics Device).

Options:

1. **32 MB** – Default.
2. 64 MB
3. 128 MB

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| Pre-AllocatedMemorySize |  | yes | Both |
</details>


<details><summary>Total Graphics Memory</summary>

Allocate total memory which graphics device shares.

Optional:

1. 128 MB
2. 256 MB
3. **Maximum** – Default.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| TotalGraphicsMemory |  | yes | Both |
</details>