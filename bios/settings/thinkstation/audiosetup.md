# Audio Setup Settings #
![](./img/audiosetup.png)

<details><summary>Onboard Audio Controller</summary>
Options:

1. **Enabled**. Default. 
2. Disabled.

!> If set to `Disabled`, the `Internal Speaker` setting will be unavailable.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| OnboardAudioController |  | yes | Both |
</details>


<details><summary>Internal Speaker</summary>

Whether the internal speaker is available in the OS.

Options:

1. **Enabled** - Default. 
2. Disabled 

?> Unavailable if `Onboarding Audio Controller` is set to `Disabled`.

| WMI Setting name | Values | SVP / SMP Req'd | AMD/Intel |
|:---|:---|:---|:---|
| InternalSpeaker |  | yes | Both |
</details>