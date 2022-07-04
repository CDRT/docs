# Network Setup #

![](./img/thinkcenter_network_setup.png)

<details><summary>Onboard Ethernet Controller</summary>

Options:

1.  **Enabled** - Default.
2.  Disabled.

!> Setting to `Disabled` also disables all [Intel (R) AMT](https://software.intel.com/sites/manageability/AMT_Implementation_and_Reference_Guide/default.htm) related functions.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| OnboardEthernetController | Disabled, Enabled | yes |

</details>

<details><summary>Wireless LAN Access</summary>

Controls access to WiFi.

Options:

1.  **Enabled** - enables wireless LAN. Default.
2.  Disabled - enables wireless LAN.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WirelessLANAccess | Disabled, Enabled | yes |

</details>

<details><summary>Wireless LAN PXE boot</summary>

Whether to load Wireless LAN UNDI Driver to support wireless LAN PXE boot or HTTPS boot.

Options:

1.  **Disabled** - Default.
2.  Enabled.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WirelessLANPXE | Disabled, Enabled | yes |

</details>


<details><summary>Wireless Auto Disconnection</summary>

Disable wireless LAN when onboard Ethernet is connected.

1.  **Disabled** - Default.
2.  Enable.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WirelessAutoDisconnection | Disabled, Enabled | yes |

</details>

### Wireless Certified Information (display only) ###
<!-- SIMULATOR DOES NOT SUPPORT -->

<details><summary>PXE IPV4 Network Stack</summary>

Options:

1. **Disabled** - Default.
2. Enabled.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| PXEIPV4NetworkStack | Disabled, Enabled | yes |

</details>


<details><summary>PXE IPV6 Network Stack</summary>

Options:

1.  **Disabled** - Default.
2.  Enabled.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| PXEIPV6NetworkStack | Disabled, Enabled | yes |

</details>

<details><summary>HTTPS Support</summary>

IPV4 and IPV6 boot support.

Options:

2.  **Disabled** - Default.
1.  Enabled.

<!-- NO WMI -->

</details>


<details><summary>HTTPS Boot</summary>

Custom HTTPS boot.

Options:

1.  **Disabled** - Default.
2.  Enabled.

?> If enabled, `HTTPs Boot Configuration` and `Tls Auth Configuration` will be shown.

<!-- WMI: no -->
</details>

<details><summary>Lenovo Cloud Services</summary>

Whether `Lenovo Cloud` will be selected in boot menu, to boot from Lenovo Cloud server directly.

1.  **Disabled** - Default.
2. Enabled.

<!-- WMI: no -->
</details>

<details><summary>Win VDI Boot</summary>

When enabled, `Win VDI Boot` will be selected in boot menu, to boot from Lenovo Cloud server and load VDI service.

Options:

1. **Disabled** - Default.
2. Enabled.

<!-- WMI: no -->

</details>

## HTTPs Boot Configuration  ##

![](./img/thinkcenter_https_boot_configuration.png)

Create a new boot option based on a HTTPS URL.

?> Only one configuration can be entered at a time. The configuration will take effect after a system reboot.

<details><summary>Input the description</summary>

?> Press `Enter` to input a label for the newly created URL and it will be displayed in the boot sequence menu.

<!-- WMI: no -->

</details>

<details><summary>Internet Protocol</summary>

Options:

1.  **Ipv4** - enables IPV4. Default.
2.  Ipv6 - enables IPV6.

<!-- WMI: no -->

</details>

<details><summary>Boot URL</summary>

?> Use the `TLS Auth configuration` to import the CA to support the HTTPs boot 

<!-- WMI: no -->

</details>

<details><summary>Delete HTTPs Boot Option from List</summary>

?> Select and press `Enter` to remove an EFI HTTPs boot option.

<!-- WMI: no -->

</details>

## TLS Auth Configuration ##


![](./img/thinkcenter_tls_auth_configuration.png)


Server CA configuration (display only).

?> Press `Enter` to select TLS auto configuration for HTTPS boot.

## WiFi Configuration ##

![](./img/thinkcenter_WiFi_configuration.png)

<details><summary>Automatic Connection Support</summary>

Automatically connect to WiFi on boot.

Options:

1. **Disabled** - Default.
2. Enabled.

<!-- WMI: no -->

</details>

### Current Connection (display only) ###

Displays the current WiFi connection.

### Wi-Fi Scan ###

?> Press `Enter` to scan the available connections.

### Scanned List (display only) ###

Scanned WiFi nodes.