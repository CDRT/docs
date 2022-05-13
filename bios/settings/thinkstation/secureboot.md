# Secure Boot Settings #
### General ###
![](./img/secureboot.png)

<details><summary>System Mode</summary>
Shows the current system mode. View only.<br>
Possible values:

1. **Deployed Mode** - Default
2. Audit  Mode
3. User Mode
4. Setup Mode

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Secure Boot</summary>
One of 2 states:

1. **Enabled** – enables Secure Boot, BIOS will prevent un-authorized OS be loaded. Default.
2. Disabled – disables Secure Boot.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Restore Factory Keys</summary>
Reset Factory Keys will put secure boot into factory defaults.<br>

**Note**. It will require additional confirmation. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Reset Platform to Setup Mode</summary>
Reset to setup mode will move secure boot to setup mode.<br>

**Note**. It will require additional confirmation.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Enter Audit Mode</summary>
The option will enter Audit Mode workflow.<br>
Transition from User to Audit Mode will result in erasing of PK (Platform Key) value. <br>

**Note**. It will require additional confirmation.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Enter Deployment Mode</summary>
Option to transition between User and Deployment modes.<br>

**Note**. It will require additional confirmation.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


### Key Management ###
<!-- TBD need to find the image -->

<details><summary>Platform Key (PK)</summary>
The platform key establishes a trust relationship between the platform owner and the platform firmware. The platform owner enrolls the public half of the key into the platform firmware. The platform owner can later use the private half of the key to change platform ownership or to enroll a Key Exchange Key. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Key Exchange Key (KEK)</summary>
Key exchange keys establish a trust relationship between the operating system and the platform firmware. Each operating system (and potentially, each 3rd party application that needs to communicate with platform firmware) enrolls a public key into the platform firmware.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Authorized Signature Database (DB)</summary>
Database keys shows the list of allowed certificates. System will check digital signatures of bootloaders using public keys in the DB. Only software or firmware which has a bootloader signed with a corresponding private key will be allowed to run. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Forbidden Signature Database (DBX)</summary>
Forbidden Signature Database shows not allowed certificates. System will block any software or firmware signed with a corresponding private key. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Authorized TimeStamps (DBt)</summary>
If present, contains the platform-defined secure boot timestamp signature database. This is not used at runtime but is provided in order to allow the OS to recover the OEM's default key setup.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>OsRecovery Signatures (DBr)</summary>
If present, contains the platform-defined secure boot authorized recovery signature database. This is not used at runtime but is provided in order to allow the OS to recover the OEM's default key setup.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>