# Power Settings #
### General ###
![](./img/power.png)

<details><summary>Intel (R) SpeedStep Technology</summary>
One of 2 possible options to select the mode of Intel (R) SteedStep Technology at runtime:

1.	**On** – Intel (R) SpeedStep Technology is turned on. Default.
2.	Off - Intel (R) SpeedStep Technology is turned off.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| SpeedStep | Disable, Enable | No | Intel |
</details>

<details><summary>Scheme for AC</summary>
One of 2 possible options of thermal management scheme to use:

1.	**Maximize Performance** - reduces CPU throttling. Default.
2.	Balanced - balanced sound, temperature, and performance.

**Note**. Each scheme affects fan sound, temperature, and performance. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| AdaptiveThermalManagementAC | MaximizePerformance, Balanced | No | Both |
</details>

<details><summary>Scheme for Battery</summary>
One of 2 possible options of thermal management scheme to use:

1.	Maximize Performance - reduces CPU throttling.
2.	**Balanced** - balanced sound, temperature, and performance. Default.

**Note**. Each scheme affects fan sound, temperature, and performance.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| AdaptiveThermalManagementBattery | MaximizePerformance,  Balanced | No | Both |
</details>

<details><summary>CPU Power Management</summary>
One of 2 possible options:

1.	**Automatic** - enabled power saving feature that stops the microprocessor clock automatically when there are no system activities. Default. 
2.	Disabled - disabled power saving feature.

**Note**. Normally, it is not necessary to change this setting.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| CPUPowerManagement | Disable, Automatic | No | Both |
</details>

<details><summary>Power On with AC Attach</summary>
One of 2 possible options for a feature that powers on the system when AC is attached:

1.	Enabled - the system is powered when AC is attached. When the system is in hibernate state, the system resumes
2.	**Disabled** - the system is not powered on nor resumed when AC is attached. Default.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| OnByAcAttach | Disable, Enable | No | Both |
</details>

<details><summary>Disable Built-in Battery</summary>
Option to temporarily disable battery for servicing the system. <br>
This option requests additional confirmation. <br>
After selecting this item, the system will be automatically powered off, then ready to be serviced.

**Note**. The battery will be automatically enabled when the AC adapter is reconnected.

</details>

### Automatic Power On ###
![](./img/autopoweron.png)

<details><summary>Wake Up on Alarm</summary>
One of 5 possible options for defining when the system shall turn on automatically:

1.	**Disabled** - the system will not turn on automatically. Default.
2.	Single Event - the system will turn on one-time on the specified day and time. 
3.	Daily Event - the system will turn on every day at the specified time.
4.	Weekly Event - the system will turn on every week on the specified day and time.
5.	User Defined - this option enables ‘User Defined Alarm’ group of settings. 

**Note**. Wake up will only occur on AC power.  Values for the ‘Wake Up on Alarm’ group of settings can be overwritten by the operating system. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| WakeUponAlarm | Disable, UserDefined, WeeklyEvent, <br>DailyEvent, SingleEvent | No | Both |
</details>

<details><summary>Alarm Date (MM/DD/YYYY)</summary>
Field to select the exact day for the system to turn on. Active only when ‘Wake Up on Alarm’ has value ‘Single Event’. 
Possible values:

1.	**N/A** – Default.
2.	MM/DD/YYYY:<br>
    a. MM – Months: January to December <br>
    b. DD – Date: 1 ~ 31 <br>
    c. YYYY – Year: 1980 ~ 2099 <br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| AlarmDate | MM/DD/YYYY | No | Both |
</details>

<details><summary>Alarm Time (HH : MM : SS)</summary>
Field to select the exact time for the system to turn on. Active when ‘Wake Up on Alarm’ has one of the values:

* Single Event
* Daily Event
* Weekly Event

Possible values:

1.	**N/A** – Default
2.	HH : MM : SS<br>
    a. HH - Hour:  00 ~ 23<br>
    b. MM - Minute:  00 ~ 59<br>
    c. SS - Second:  00 ~ 59<br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| AlarmTime | HH/MM/SS | No | Both |
</details>

<details><summary>Alarm Day of Week</summary>
Field to select the exact day for the system to turn on. Active only when ‘Wake Up on Alarm’ has value ‘Weekly Event’.
Possible values:

1.	**N/A** – Default
2.	Sunday
3.	Monday
4.	Tuesday
5.	Wednesday
6.	Thursday
7.	Friday
8.	Saturday

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| AlarmDayofWeek | Sunday, Monday, Tuesday, <br>Wednesday, Thursday, Friday, Saturday | No | Both |
</details>

### Automatic Power On - User Defined Alarm ###
![](./img/autopoweronuserdefined.png)

<details><summary>Sunday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmSunday | Disable, Enable | No | Both |
</details>

<details><summary>Monday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmMonday | Disable, Enable | No | Both |
</details>

<details><summary>Tuesday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmTuesday | Disable, Enable | No | Both |
</details>

<details><summary>Wednesday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmWednesday | Disable, Enable | No | Both |
</details>

<details><summary>Thursday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmThursday | Disable, Enable | No | Both |
</details>

<details><summary>Friday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmFriday | Disable, Enable | No | Both |
</details>

<details><summary>Saturday</summary>
One of 2 states to select:

1.	**Off** - the system will not turn on automatically on this day. Default.
2.	On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmSaturday | Disable, Enable | No | Both |
</details>

<details><summary>User Defined Alarm Time (HH : MM : SS)</summary>
Field to select the exact time for the system to turn on.
Possible values:

1.	**N/A** – Default
2.	HH : MM : SS<br>
    a. HH - Hour:  00 ~ 23<br>
    b. MM - Minute:  00 ~ 59<br>
    c. SS - Second:  00 ~ 59<br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
| UserDefinedAlarmTime | HH/MM/SS | No | Both |
</details>