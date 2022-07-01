# Serial Port Setup #

![](./img/thinkcenter_serial_port_setup.png)

<details><summary>Serial Port 1 Address</summary>

Choose or disable interrupt lines for serial port 1.

Options:

1.  **2F8/IRQ3** - Default.
2.  3F8/IRQ4.
3.  Disabled - the serial port will not be available to the OS.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| SerialPort1Address | 2F8/IRQ3, 3F8/IRQ4, 3E8/IRQ4, 2E8/IRQ3, Disabled | yes |

</details>

<details><summary>Serial Port 2 Address</summary>

Choose or disable interrupt lines for serial port 2.

Options:

1.  **2F8/IRQ3** - Default.
2.  3F8/IRQ4.
3.  Disabled - the serial port will not be available to the OS.

<!-- TODO: add WMI -->

</details>