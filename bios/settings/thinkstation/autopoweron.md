# Automatic Power On Settings #
### General ###
![](./img/autopoweron.png)

<details><summary>Wake on LAN</summary>
One of 2 states:

1. **Enabled** – Wake on LAN (Local Area Network) is enabled. Default.
2. Disabled – Wake on LAN is disabled.

**Note**. This item controls the wake up event from onboard LAN (Local Area Network) and PCI (Peripheral Component Interconnect) LAN.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Wake from Serial Port Ring</summary>
One of 2 states:

1. **Enabled** – Default. 
2. Disabled

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Wake Up on Alarm </summary>
One of 5 options to select whether to enable Wake Up on Alarm, to turn on your system on a special day of the month, special day of the week or daily:

1. **Disabled** - the system will not turn on automatically. Default. 
2. Single Event - the system will turn on one-time on the specified day and time. 
3. Daily Event - the system will turn on every day at the specified time.
4. Weekly Event - the system will turn on every week on the specified day and time.
5. User Defined - this option enables 'User Defined Alarm' group of settings. 

**Note**. Values in these fields may be overwritten by the operating system. 

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Alarm Time ( HH : MM : SS)</summary>
Field to select the exact time for the system to turn on. <br>
Active when ‘Wake Up on Alarm’ has one of the values:

* Single Event
* Daily Event
* Weekly Event

Possible values:

1.	**00 : 00 : 00** – Default
2.	HH : MM : SS<br>
    a. HH - Hour:  00 ~ 23<br>
    b. MM - Minute:  00 ~ 59<br>
    c. SS - Second:  00 ~ 59<br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Alarm Date (MM/DD/YYYY) </summary>
Field to select the exact day for the system to turn on.<br> 
Active only when 'Wake Up on Alarm' has value 'Single Event'. <br>
Possible values:

1.	**01/01/YYYY** – Default.
2.	MM/DD/YYYY:<br>
    a. MM – Months: January to December <br>
    b. DD – Date: 1 ~ 31 <br>
    c. YYYY – Year: 1980 ~ 2099 <br>

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


<details><summary>Alarm Day of Week</summary>
Field to select the exact day for the system to turn on. <br>
Active only when 'Wake Up on Alarm' has value 'Weekly Event'.<br>
Possible values:

1. **Sunday** – Default
2. Monday
3. Tuesday
4. Wednesday
5. Thursday
6. Friday
7. Saturday

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
|:---|:---|:---|:---|
|  |  |  | Both |
</details>


### User Defined Alarm ###
![](./img/userdefinedalarm.png)

<details><summary>Sunday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Monday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Tuesday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Wednesday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Thursday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Friday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>

<details><summary>Saturday</summary>
One of 2 states to select:

1. **Off** - the system will not turn on automatically on this day. Default.
2. On – the system will turn on automatically on this day.

| WMI Setting name | Values | SVP Req'd | AMD/Intel |
   |:---|:---|:---|:---|
|   |   | No | Both |
</details>