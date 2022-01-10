# Network Settings #
### General ###
![](./img/network.png)
<details><summary>Wake On Lan</summary>
One of 3 possible states: <br>

1.	AC Only - Wake On LAN function works only when AC is attached. Default.
2.	Disabled - function is turned off. 
3.	AC and Battery - Wake On LAN function works with both AC and Battery.

**Note**: AC is required with magic packet type Wake On LAN. 
Wake On LAN function may be blocked due to password configuration. 
</details>

<details><summary>Wake On LAN from Dock</summary>
One of 2 possible states:

1.	On - function is turned on. Default.

   **Note**: This feature will not work while Secure Boot is disabled.

2.	Off - function is turned off. 

   **Note**: Wake On LAN from Dock works only when ThinkPad USB-C Dock or ThinkPad Thunderbolt 3 Dock is attached.
Wake on LAN from Dock function may be blocked due to password configuration.
</details>

<details><summary>Lenovo Cloud Services</summary>
One of 2 possible states:

1.	On - function is turned on. System connects Lenovo Cloud Services via HTTPs. DHCP option settings are not required. Default.

   **Note**: This feature will not work while Secure Boot is disabled.

2.	Off - function is turned off. 

**Additional information**<br>
Once the feature is enabled, then it becomes available for selection in “BIOS -> Startup -> Edit Boot Order”, or “BIOS -> Startup -> Network Boot”, or via F12 Boot Menu. 
When “Lenovo Cloud Services” booted, then following options will be available for selection:
1. Lenovo Cloud Deploy (ITC) – it is a method to send Factory-Style images to customers for deployment in the field. 
Additional information is here: [Lenovo Cloud Deploy](https://www.lenovoclouddeploy.com/en/auth/welcome)
2. Windows Virtual Desktop (VDI) – it provides the VDI environment to customer. VDI itself will be setup by the customer (IT Admin). If this option is selected, then it will become available as a boot option.  
Additional information is here: [Client Virtualization & Infrastructure Solutions - Lenovo](https://www.lenovo.com/lt/lt/data-center/solutions/client-virtualization) and [Windows Virtual Desktop](https://www.microsoft.com/en-us/microsoft-365/blog/2019/09/30/windows-virtual-desktop-generally-available-worldwide/).
</details>


### WiFi Configuration ###
![](./img/wifi.png)
