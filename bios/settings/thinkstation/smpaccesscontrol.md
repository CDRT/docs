# System Management Password Access Control #
![](./img/smpaccesscontrol.png)

<details><summary>Access Security Settings</summary>
One of 2 states:

1. **Disabled** – SMP cannot control security settings. Default. 
2. Enabled – allows SMP to have the same authority as SVP to control security settings.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Remote Set SMP</summary>
One of 2 states:

1. **Disabled** – an SVP is needed for set SMP via WMI. Default.
2. Enabled – allows remote set SMP via WMI without an SVP verify.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>