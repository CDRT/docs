# Power Settings #
### General ###
![](./img/power.png)

<details><summary>Intel (R) SpeedStep Technology</summary>
One of 2 possible options to select the mode of Intel (R) SteedStep Technology at runtime:

1.	**On** – Intel (R) SpeedStep Technology is turned on. Default.
2.	Off - Intel (R) SpeedStep Technology is turned off.

| WMI Setting name | Values |
|:---|:---|
| SpeedStep |  |
</details>

<details><summary>Scheme for AC</summary>
One of 2 possible options of thermal management scheme to use:

1.	**Maximize Performance** - reduces CPU throttling. Default.
2.	Balanced - balanced sound, temperature, and performance.

**Note**. Each scheme affects fan sound, temperature, and performance. 

| WMI Setting name | Values |
|:---|:---|
| AdaptiveThermalManagementAC |  |
</details>

<details><summary>Scheme for Battery</summary>
One of 2 possible options of thermal management scheme to use:

1.	Maximize Performance - reduces CPU throttling.
2.	**Balanced** - balanced sound, temperature, and performance. Default.

**Note**. Each scheme affects fan sound, temperature, and performance.

| WMI Setting name | Values |
|:---|:---|
| AdaptiveThermalManagementBattery |  |
</details>

<details><summary>CPU Power Management</summary>
One of 2 possible options:

1.	**Enabled** - enabled power saving feature that stops the microprocessor clock automatically when there are no system activities. Default. 
2.	Disabled - disabled power saving feature.

**Note**. Normally, it is not necessary to change this setting.

| WMI Setting name | Values |
|:---|:---|
| CPUPowerManagement |  |
</details>

<details><summary>Power On with AC Attach</summary>
One of 2 possible options for a feature that powers on the system when AC is attached:

1.	Enabled - the system is powered when AC is attached. When the system is in hibernate state, the system resumes
2.	**Disabled** - the system is not powered on nor resumed when AC is attached. Default.

| WMI Setting name | Values |
|:---|:---|
| OnByAcAttach |  |
</details>

<details><summary>Disable Built-in Battery</summary>
Option to temporarily disable battery for servicing the system. <br>
This option requests additional confirmation. <br>
After selecting this item, the system will be automatically powered off, then ready to be serviced.

**Note**. The battery will be automatically enabled when the AC adapter is reconnected.
</details>

### Automatic Power On ###