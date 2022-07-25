# Network Settings #
### General ###
![](./img/network.png)
<details><summary>Wake On Lan</summary>

Options:

1.	**AC Only** - Wake On LAN only when AC is attached. Default.
2.	Disabled. 
3.	AC and Battery - Wake On LAN with both AC and Battery.

!> AC is required with magic packet type Wake On LAN. 

!> Wake On LAN may be blocked due to password configuration.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WakeOnLAN | Disable, ACOnly, ACandBattery, Enable | No | Both |
</details>

<details><summary>Wake On LAN from Dock</summary>

Options:

1.	**On** - Default.
2.	Off. 

!> Will not work while Secure Boot is disabled.

!> Wake On LAN from Dock works only when ThinkPad USB-C Dock or ThinkPad Thunderbolt Dock is attached.

!> Wake on LAN from Dock may be blocked due to password configuration.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WakeOnLANDock  | Disable, Enable | No | Both |
</details>

<details><summary>Lenovo Cloud Services</summary>

Options:

1.	**On**. System connects Lenovo Cloud Services via HTTPs. DHCP option settings are not required. Default.
2.	Off. 

!> Will not work while Secure Boot is disabled.


**Additional information**<br>
Once enabled, the feature is available in:
 - BIOS -> Startup -> Edit Boot Order
 - BIOS -> Startup -> Network Boot
 - F12 Boot Menu

When “Lenovo Cloud Services” booted, the following will be available:
1. **Lenovo Cloud Deploy (ITC)** – sends Factory-Style images to customers for deployment in the field. 
More information: [Lenovo Cloud Deploy](https://www.lenovoclouddeploy.com/en/auth/welcome)
2. **Windows Virtual Desktop (VDI)** – provides the VDI environment to customer. VDI will be setup by the customer (IT Admin). If selected, will become available as a boot option.  
More information: [Client Virtualization & Infrastructure Solutions - Lenovo](https://www.lenovo.com/lt/lt/data-center/solutions/client-virtualization) and [Windows Virtual Desktop](https://www.microsoft.com/en-us/microsoft-365/blog/2019/09/30/windows-virtual-desktop-generally-available-worldwide/).

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| LenovoCloudServices  | Disable, Enable | No | Intel |
</details>

<details><summary>UEFI WI-FI Network Boot</summary>

Options:<br>

1. On. UEFI Wi-Fi driver is loaded at next boot and can connect to Access point.
2. **Off**. Default.

!> Secure Boot must be enabled to use UEFI Network Boot.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WiFiNetworkBoot  | Disable, Enable | No | Intel |
</details>

<details><summary>UEFI IPv4 Network Stack</summary>

Whether to turn on UEFI IPv4 Network Stack for UEFI environment.

Options:<br>

1. **On** - Default.
2. Off.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| IPv4NetworkStack  | Disable, Enable | No | Both |
</details>

<details><summary>UEFI IPv6 Network Stack</summary>

Whether to turn on UEFI IPv6 Network Stack for UEFI environment.

Options:<br>

1. **On** - Default.
2. Off.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| IPv6NetworkStack  | Disable, Enable | No | Both |
</details>

<details><summary>UEFI Network Boot Priority</summary>

Network Stack priority for UEFI PXE Boot.

Options:<br>

1. **IPv4 First** – Default.
2. IPv6 First

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| UefiPxeBootPriority  | IPv6First, IPv4First | No | Both |
</details>

<details><summary>Wireless Auto Disconnection</summary>

Whether Wireless LAN radio is automatically turned off whenever Ethernet cable is connected.

Options:<br>

1. On.
2. **Off**. Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| WirelessAutoDisconnection  | Disable, Enable | No | Both |
</details>

<details><summary>MAC Address Pass Through</summary>

Which MAC Address to use for Dock Ethernet when dock is attached.

Options:<br>

1. **Disabled** - Dock Ethernet uses its own MAC address. Default.
2. Internal MAC Address - Dock Ethernet uses same MAC address as internal LAN.
3. Second MAC Address - Dock Ethernet uses the second MAC address that is stored in the system's EEPROM.

?> `Second MAC Address` allows for a device-specific MAC address that is different from the internal NIC's MAC address so they can be managed separately if necessary.

?> For systems that do not have an internal NIC, there will only be two options: <br /> - off: the dock will use its own MAC Address <br /> - on: the dock will use MAC address stored in the system EEPROM

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| MACAddressPassThrough  | Disable, Enable, Second | No | Both |
</details>

### WiFi Configuration ###
![](./img/wifi.png)

?> All the settings in this group are unavailable via WMI.

<details><summary>MAC Address (display only) </summary>

Media access control (MAC) address of the wireless network interface controller.

?> There could be several MAC addresses, if there is more than one wireless network interface controller. 

For every MAC Address the following information is shown:<br>

* MAC Address - Media access control (MAC) address of the selected wireless network interface controller. 
* [State] - Possible states: 
   1. **Disconnected** - device is not connected to a Wi-Fi network. Default.
   2. Connected to [SSID] - device is connected to a Wi-Fi network which has displayed SSID.
</details>
<br>

### Wi-Fi Network List ###
![](./img/wifinetworklist.png)

?> All the settings in this group are unavailable via WMI.

**Number of networks:** Number of current available networks around. Display only.

For each network the Security Type is shown.  Possible values are "Open" and "Secured".  If Secured, the security type is displayed.

Each SSID can be selected to display more details.

<details><summary>[SSID Value](Status)</summary>

![](./img/wifinetworkconfig.png)

<details><summary>Connection Status (display only)</summary>

 Possible values:

1.	**Disconnected** - device is not connected to this Wi-Fi network. Default.
2.	Connected - device is connected to this Wi-Fi network.    
</details>

<details><summary>SSID (display only) </summary>

SSID (Service Set Identifier) is the name of the wireless network. 
</details>

<details><summary>Security (display only) </summary>

Security type of this Wi-Fi network. Possible values:

1.	Open
2.	WPA2-Personal
3.	WPA2-Enterprise
4. PEAP
5. EAP-TLS

</details>
   
<details><summary>Password</summary>

Field for entering password. 

!> Visible only for networks with security WPA2-Personal.<br>

Password length: 8-63 characters.
</details>

<details><summary>EAP Authentication Method (display only) </summary>

Selected EAP Authentication Method.

!> Visible only for networks with security WPA2-Enterprise. Default value depends on the network.

Possible values:

1. PEAP
2.	EAP-TLS 
</details>

<details><summary>EAP Second Authentication Method (display only) </summary>

Selected EAP Second Authentication Method.

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `PEAP`. Default value depends on the network.

Possible values:

1. MSCHAPv2
</details>

<details><summary>Enroll CA Cert</summary>

This is the option to enroll CA (Certification Authority) certificate. Empty by default.

!> Visible only for networks with security WPA2-Enterprise.
</details>

<details><summary>Enroll Client Cert</summary>

This is the option to enroll client certificate. Empty by default.

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.

</details>

<details><summary>Enroll Client Private Key</summary>

This is the option to enroll client private key. Empty by default.

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.

</details>

<details><summary>Identity (display only) </summary>

Identity value if there is any. Identity length: 6-20 characters.

!> Visible only for networks with security WPA2-Enterprise.
</details>

<details><summary>EAP Password</summary>

Field for entering EAP password. Requirements to password length: 1-63 characters.

!> Visible only for networks with security WPA2-Enterprise.
</details>

<details><summary>[Action]</summary>

Possible actions:

1.	Connect to this network - visible if device is not connected to this Wi-Fi network
2.	Disconnect - visible if device is connected to this Wi-Fi network
</details>
</details>
<br>

### Add Wi-Fi Network ###
![](./img/addwifinetwork.png)

?> All the settings in this group are unavailable via WMI.

<details><summary>SSID</summary>
Field for entering SSID value.
</details>

<details><summary>Security</summary>
Field to select the security type of this Wi-Fi network. Possible values:

1.	**Open** – Default
2.	WPA2-Personal
3.	WPA2-Enterprise
</details>

<details><summary>Password</summary>

Field for entering password.

!> Visible only for a network with security WPA2-Personal.<br>

Password length: 8-63 characters.
</details>

<details><summary>EAP Authentication Method</summary>

Field to select EAP Authentication Method. Possible values:

1.	**PEAP** – Default
2.	EAP-TLS

!> Visible only for a network with security WPA2-Enterprise. 
</details>

<details><summary>EAP Second Authentication Method</summary>

Field to select EAP Second Authentication Method. Possible values:

1.	**MSCHAPv2** – Default. 

!> Visible only for a network with security WPA2-Enterprise and if `EAP Authentication Method` is `PEAP`. 

</details>

<details><summary>Enroll CA Cert</summary>

This is the option to enroll CA (Certification Authority) certificate. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise.

</details>

<details><summary>Enroll Client Cert</summary>

This is the option to enroll client certificate. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.

</details>

<details><summary>Enroll Client Private Key</summary>

This is the option to enroll client private key. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.

</details>

<details><summary>Identity</summary>

Field for entering identity value if there is any.<br> 

Requirements for identity length: 6-20 characters.<br>

!> Visible only for a network with security WPA2-Enterprise. 

</details>

<details><summary>EAP Password</summary>

Field for entering EAP password. <br>

Requirements to password length: 1-63 characters.<br>

!> Visible only for a network with security WPA2-Enterprise. 

</details>

<details><summary>Scan Anyway</summary>

Whether to scan even when this network is not broadcasting its name.

Options:

1.	**On** - the network will be scanned when it does not broadcast its name. Default. 
2.	Off - the network will not be scanned when it does not broadcast its name.

!> Visible only for a network with security WPA2-Enterprise.

</details>

<details><summary>Commit Changes and Exit</summary>

This is the option to save changes and exits back to the Manage Wi-Fi network page. 

</details>

### Manage Wi-Fi Network ###

![](./img/managewifilist.png)

?> All the settings in this group are unavailable via WMI.

<details><summary>[SSID Value][Type] </summary>

SSID value and its type.<br>

Every SSID on the list leads to details for this network. See descriptions below.<br>

![](./img/managewificonfig.png)

<details><summary>SSID</summary>

Field for editing SSID value. 
</details>

<details><summary>Security</summary>

Field to select the security type of this Wi-Fi network. Default value depends on the network. Possible values:

1.	Open 
2.	WPA2-Personal
3.	WPA2-Enterprise
</details>

<details><summary>Password</summary>

Field for entering password.

!> Visible only for a network with security WPA2-Personal.<br> 

Password length: 8-63 characters. 
</details>

<details><summary>EAP Authentication Method</summary>

Field to select EAP Authentication Method. Possible values:

1.	**PEAP** – Default
2.	EAP-TLS

!> Visible only for a network with security WPA2-Enterprise.
</details>

<details><summary>EAP Second Authentication Method</summary>

Field to select EAP Second Authentication Method. Possible values:

1.	**MSCHAPv2** – Default. 

!> Visible only for a network with security WPA2-Enterprise and if `EAP Authentication Method` is `PEAP`. 
</details>

<details><summary>Enroll CA Cert</summary>

This is the option to enroll CA (Certification Authority) certificate. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise. 
</details>

<details><summary>Enroll Client Cert</summary>

This is the option to enroll client certificate. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.
</details>

<details><summary>Enroll Client Private Key</summary>

This is the option to enroll client private key. Empty by default.<br>

!> Visible only for networks with security WPA2-Enterprise and if `EAP Authentication Method` is `EAP-TLS`.
</details>

<details><summary>Identity</summary>

Field to enter identity value if there is any.<br> 

Requirements to identity length: 6-20 characters.<br>

!> Visible only for a network with security WPA2-Enterprise. 
</details>

<details><summary>EAP Password</summary>

Field for entering EAP password. <br>

Requirements to password length: 1-63 characters.<br>

!> Visible only for a network with security WPA2-Enterprise. 
</details>

<details><summary>Scan Anyway</summary>

Field to define whether to scan even when this network is not broadcasting its name. Possible options:

1.	On - the network will be scanned when it does not broadcast its name. 
2.	**Off** - the network will not be scanned when it does not broadcast its name. Default.

!> Visible only for a network with security WPA2-Enterprise.
</details>

<details><summary>Commit Changes and Exit</summary>

This is the option to save changes and exits back to the Manage Wi-Fi network page.
</details>

<details><summary>Forget This Network</summary>

This is the option to forget the settings for the selected network and disconnect from it. 
</details>
</details>


<details><summary>Change Priority</summary>

Leads to the list of saved Wi-Fi networks.<br>  
T
he option will show a warning message if Network List is empty. See descriptions below.<br>

![](./img/managewifipriority.png)

<details><summary>Priority List</summary>

Contains the list of SSIDs of the saved networks. 
</details>

<details><summary>Commit Changes and Exit</summary>

This is the option to save changes and exits back to the Manage Wi-Fi network page.
</details>

</details>