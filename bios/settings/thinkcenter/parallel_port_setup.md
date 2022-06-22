# Parallel Port Setup #

<!-- MODEL: S only -->

![](./img/thinkcenter_parallel_port_setup.png)
<details><summary>Parallel Port Address</summary>

Options:

1.  **378** - enables logical parallel port 378. Default.
2.  278 - enables logical parallel port 278.
3.  Disabled - disables the parallel port. The parallel port will not be seen by the OS.

<!-- TODO: add WMI -->
</details>

<details><summary>Parallel Port Mode</summary>

The parallel port mode has only one value: EPP (Enhanced Parallel Port).

<!-- TODO: add WMI -->
</details>

<details><summary>EPP Version</summary>
Version of the EPP (Enhanced Parallel Port) standard used.

Options:

1.  **1.9** - enables version 1.9. Default.
2.  1.7 - enables version 1.7.

<!-- TODO: add WMI -->
?> Version 1.7 is supported as an optional setting for backward compatibility with older devices. There are differences between versions 1.9 and 1.7 which may affect the operation of devices.

</details>

<details><summary>Parallel Port IRQ</summary>
Settings for the IRQ (Interrupt Request) line.

Options:

1.  **IRQ7** - enables interrupt line 7. Default.
2.  IRQ 5 - enables interrupt line 5.

<!-- TODO: add WMI -->
</details>
