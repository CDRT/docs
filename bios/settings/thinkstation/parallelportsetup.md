# Parallel Port Setup Settings #
![](./img/parallelportsetup.png)

<details><summary>Parallel Port Address</summary>

!> If `Disabled`, the Parallel Port will not be seen by the OS, and the `Parallel Port Mode`,  `EPP Version` and `Parallel Port IRQ` settings will become unavailable. 

Options:

1. Disabled.
2. **378** – Default. 
3. 278

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ParallelPortAddress |  | yes | Both |
</details>

<details><summary>Parallel Port Mode</summary>
Parallel Port Mode.

One option:

1. **EPP** - Enhanced Parallel Port. Default. 

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ParallelPortMode |  | yes | Both |
</details>

<details><summary>EPP Version</summary>

!> Differences between the two versions may affect the operation of devices.

Options:

1. **1.9** – Default.
2. 1.7

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| EPPVersion |  | yes | Both |
</details>

<details><summary>Parallel Port IRQ</summary>

An IRQ (interrupt request) value is an assigned location where the computer can expect the parallel port controller to interrupt it when the device sends the computer signals about its operation. <br>

Options:

1. **IRQ7** – Default.
2. IRQ5

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| ParallelPortIRQ |  | yes | Both |
</details>