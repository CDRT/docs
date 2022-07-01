# Automatic Power On #

![](./img/thinkcenter_automatic_power_on.png)

<details><summary>Wake on LAN</summary>

Controls the wake up event from onboard LAN and PCI LAN.

Options:

1.  **Enabled** - enables Wake on LAN. Default.
2.  Disabled - disables Wake on LAN.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WakeonLAN | Primary, Automatic, Disabled | yes |

</details>

<details><summary>Wake from Serial Port Ring</summary>

Select whether to enable Wake from Serial Port Ring.

Options:

1. **Enabled** - Default.
2. Disabled.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WakefromSerialPortRing | Primary, Automatic, Disabled | yes |

</details>


<details><summary>Wake Up on Alarm</summary>

Options to turn on your system on a specific day of the month, specific day of the week, or daily at a given time.

A single wake up event, or series of alarm events, can also be defined.

?> Selecting `User Defined` enables the `User Defined Alarm` settings.

?> Values in these fields may be overwritten by the operating system.

Options:

1.  **Disabled** - Disables Wake Up on Alarm. Default.
2.  User Defined - a series of alarm events.
3.  Single Event
4.  Daily Event
5.  Weekly Event

<!-- 
| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| WakeUponAlarm | setting_values | yes_no |
-->

</details>

<details><summary>Startup Sequence</summary>

Select the startup sequence after a Wake Up on Alarm event.

Options:

1.  **Primary** - enables primary startup sequence. Default.
2.  Automatic - disables automatic selection of startup sequence.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| StartupSequence | Primary, Automatic | yes_no |

</details>

### Alarm Time (HH : MM : SS) ###

Specify the time when the system is to wake up.

Hours / minutes / seconds format.

<!-- SIMULATOR DOES NOT SUPPORT -->

### Alarm Date (MM / DD / YYYY) ###

Specify the precise date in month / day / year format.


| WMI Setting name | Values | SVP Req'd |
|:---|:---|:---|
| AlarmDate  | (display only) | yes |


<details><summary>Alarm day of week</summary>

Options:

1. **Sunday** - Default.
2. Monday.
3. Tuesday.
4. Wednesday.
5. Thursday.
6. Friday.
7. Saturday.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| AlarmDayofWeek  | Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, SaturdayStatus | yes |

</details>

## User Defined Alarm ##

![](./img/thinkcenter_user_defined_alarm.png)

Select the day(s) of the week when the system is to wake up. Each {Weekday} (Sunday to Saturday) has its own setting.

<details><summary>{Weekday}</summary>

Options:

1.  **Disabled** - disables wake-up. Default.
2.  Enabled - enables wake-up.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| UserDefinedAlarmFriday | Disabled, Enabled | yes |

?> The WMI setting name for the wake-up timer week shown here is for Friday. For the other weekdays replace `Friday` with the weekday's name.

</details>

<details><summary>User Defined Alarm Time (HH : MM : SS)</summary>

Specify the time when the system is to wake up.

| WMI Setting name | Values | SVP or SMP Req'd |
|:---|:---|:---|
| UserDefinedAlarmTime | (display Only) | yes |

</details>
