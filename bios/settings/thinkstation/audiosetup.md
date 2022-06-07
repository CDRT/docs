# Audio Setup Settings #
![](./img/audiosetup.png)

<details><summary>Onboard Audio Controller</summary>
One of 2 possible states for the Onboard Audio Controller:

1. **Enabled** – the Onboard Audio Controller is enabled. Default. 
2. Disabled – the Onboard Audio Controller is disabled. If selected, then `Internal Speaker` setting is unavailable.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Internal Speaker</summary>
One of 2 possible states for the Internal Speaker:

1. **Enabled** – enables use of Internal Speaker. Default. 
2. Disabled – disables use of Internal Speaker. It will not be available in OS.

**Note**. The field is unavailable if `Onboarding Audio Controller` is set to `Disabled`.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>