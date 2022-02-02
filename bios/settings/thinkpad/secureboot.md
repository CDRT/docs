# Secure Boot Settings #
### General ###
![](./img/secureboot.png)

<details><summary>Secure Boot</summary>
One of 2 possible options:

1.	On – prevent unauthorized operating systems from running at boot time. Default, if ‘OS Optimized Defaults’ has value ‘On’.
2.	Off – allow to run any operating systems at boot time. Default, if ‘OS Optimized Defaults’ has value ‘Off.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


<details><summary>Secure Boot Mode</summary>
Shows whether the platform is operating in one of 2 possible modes:

1.	Setup mode
2.	**User mode** - default.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


<details><summary>Secure Boot Key State</summary>
Shows whether the secure boot mode is in one of two possible modes:

1.	Custom mode
2.	**Standard mode** - default.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


<details><summary>Reset to Setup Mode</summary>
This option is used to clear the current Platform Key and put the system into setup mode. You can install your own Platform Key and customize the Secure Boot signature databases in setup mode.
The option requires additional confirmation.

**Note**. Secure Boot Mode will be set to Custom Mode.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


<details><summary>Restore Factory Keys</summary>
This option is used to restore all keys and certificates in Secure Boot databases to factory defaults. Any customized Secure Boot settings will be erased, and the default Platform key will be re-established along with the original signature databases including certificate for Microsoft (R) Windows 10 (R).<br>
The option requires additional confirmation.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


<details><summary>Clear All Secure Boot Keys</summary>
This option is used to clear all keys and certificates in Secure Boot databases. You can install your own keys and certificates after selecting this option.<br>
The option requires additional confirmation.

| WMI Setting name | Values |
|:---|:---|
|  |  |
</details>


### Key Management ###