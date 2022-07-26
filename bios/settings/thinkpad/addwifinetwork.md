### Add Wi-Fi Network ###

![](./img/addwifinetwork.png)

?> All the settings in this group are unavailable via WMI.

### SSID ###
Field for entering SSID value.


<details><summary>Security</summary>

Select the security type of this Wi-Fi network.

Possible values:

1.	**Open** – Default
2.	WPA2-Personal
3.	WPA2-Enterprise
</details>

### Password ###

Enter the password.

!> Visible only for a network with security WPA2-Personal.<br>

Password length: 8-63 characters.


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