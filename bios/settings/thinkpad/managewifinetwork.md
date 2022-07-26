# Manage Wi-Fi Network #

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

Select the security type of this Wi-Fi network. Default value depends on the network. Possible values:

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

Select EAP Authentication Method. Possible values:

1.	**PEAP** – Default
2.	EAP-TLS

!> Visible only for a network with security WPA2-Enterprise.
</details>

<details><summary>EAP Second Authentication Method</summary>

Select EAP Second Authentication Method. Possible values:

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