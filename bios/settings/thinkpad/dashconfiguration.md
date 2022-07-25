# DASH Configuration Settings #

DASH provides support for the redirection of KVM (Keyboard, Video and Mouse) and text consoles, as well as USB and media, and supports the management of software updates, UEFI BIOS, batteries, NIC, MAC and IP addresses, as well as DNS and DHCP configuration. DASH specifications also address operating system status, opaque data management.
More information about DASH: [Lenovo and AMD DASH Management](dash/dash_top.md).

<details><summary>DASH Support</summary>

Options:

1.	On.
2.	**Off**. Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| DashEnabled | Disable, Enable | Yes | AMD |
</details>


<details><summary>Wireless DASH Support</summary>

Options:

1.	On.
2.	**Off**. Default.

?> This setting is available only if machine has Pro CPU and a wireless card which supports DASH.


| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WirelessDashEnabled | Disable, Enable | Yes | AMD |
</details>


<details><summary>Realtek LAN Controller</summary>

View-only information about Realtek Ethernet Controller Configuration.

**Driver Information**
1. Driver name
2. Driver Version
3. Driver Released Date

**Device information**
1. Device name
2. PCI Slot
3. MAC Address

**Patent Information**
1. This product is covered by one or more of the following patents - shows the list of patents, if there are any.

</details>