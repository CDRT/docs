## Intune

### **Overview**

This page will present the policies found in the Commercial Vantage ADMX template, along with the OMA-URIs which can be used to configure the application on clients.

Refer to this [Commercial Vantage blog article](https://thinkdeploy.blogspot.com/2020/11/deploying-commercial-vantage-with-intune.html 'target=_blank') on how to create the Win32 app and [Managing Commercial Vantage in Intune](https://thinkdeploy.blogspot.com/2020/11/manage-commercial-vantage-with-intune.html) for steps on how to ingest the ADMX file in Intune.

### **Dashboard**

#### Dashboard

When this policy is enabled, the Dashboard feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~8EB4B7362B69050BFD52D7A0636C0562/26EB604F31FEA5A31B30EE1DA8B6774D
```

Values:

`<enabled/>`
`<disabled/>`

### **Device**

#### Smart Assist

When this policy is enabled, the Smart Assist feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB/1631A70618C59A6199301D764A23F246
```

Values:

`<enabled/>`
`<disabled/>`

#### Device Settings

When this policy is enabled, the Device Settings feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB/45F6F49C7B88A4F6681C08269E51869F
```

Values:

`<enabled/>`
`<disabled/>`

#### System Update

When this policy is enabled, the System Update feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB/C2A1B40F7DC05396F6FC85A58E76A0A2
```

Values:

`<enabled/>`
`<disabled/>`

#### My Device

When this policy is enabled, the My Device feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB/E39E265DD63799F578A4F5EF9ED9E271
```

Values:

`<enabled/>`
`<disabled/>`

### **Device Settings**

#### Microphone Settings

When this policy is enabled, the Microphone Settings features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~0DCC7F7AF7643439978A86FD8954E056/3DE55572B38BBE99A42335869E037DF3
```

Values:

`<enabled/>`
`<disabled/>`

#### Audio Smart Settings

When this policy is enabled, the Audio Smart Settings feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~0DCC7F7AF7643439978A86FD8954E056/4E23CB25D710E406CF34EE9C2D5E8F77
```

Values:

`<enabled/>`
`<disabled/>`

#### Camera

When this policy is enabled, the Camera features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~2F1A3379F15869B17CDC4166675CF9F4/70DA5C43A08ABFF6465613AD5E3426D8
```

Values:

`<enabled/>`
`<disabled/>`

#### Display

When this policy is enabled, the Display features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~2F1A3379F15869B17CDC4166675CF9F4/BCC3FA02172D8F220765BCC0DAF5897A
```

Values:

`<enabled/>`
`<disabled/>`

#### Intelligent Keyboard

When this policy is enabled, the Intelligent Keyboard feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~DC6ABC1D9A065D6934DBBF4A781C1743/B472A13920E69AD5EA4E8C8AE4F32DBA
```

Values:

`<enabled/>`
`<disabled/>`

#### Power Settings

When this policy is enabled, the Power Settings of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/5C2B0833E82D16B3417540950063B3B1
```

Values:

`<enabled/>`
`<disabled/>`

#### Write Battery Information to WMI

?>Note: Added in version 10.2109

This policy setting allows Commercial Vantage to write the computer battery information into the Lenovo Namespace WMI table. If you enable it, the battery information will be written to WMI.  The information written will appear as follows:

![battery info](../img/cv/battery_info.png)

This policy setting allows the Administrator to configure the schedule type, schedule day, and schedule time for writing the computer battery information to WMI.
The Schedule type value should be a number (0-2), where 0 means daily, 1 means weekly, 2 means monthly.

If the Schedule type value is set to 0, the Schedule day value should be set to 0 (and this value will be ignored). If the Schedule type is set to 1, the Schedule day value should be a number (0-6), where 0 means Sunday, 1 means Monday, 2 means Tuesday... 

If the Schedule type is set to 2, the Schedule day value should be a number (-1 or 1-31), where -1 means the last day of the month, 1 means the first day of the month, 2 means the second day of the month...

The Schedule time value format should be HH: mm:ss. For example, 18: 30:00 represents 6:30PM.

If you disable or do not configure this policy setting, the battery information will not be written to WMI.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/64F93BB9BFC0EB1C9ADD81981905E061
```

?>  `ADE41242A9F8CE596481FE945E5FE5D8 = Schedule Type`
    `F04F922293A120999D4EB95012CA0C64 = Schedule Day`
    `AC72B4BC066D807C760A11748C39F451 = Schedule Time`

Values:

`<enabled/>`  
`<data id="ADE41242A9F8CE596481FE945E5FE5D8" value="1"/>`
`<data id="F04F922293A120999D4EB95012CA0C64" value="1"/>`
`<data id="AC72B4BC066D807C760A11748C39F451" value="10:00:00"/>`

`<disabled/>`

#### DPM Power Settings

?>Note: Added in version 10.2104

When this policy is enabled, the Desktop Power Manager Power Settings of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/664C30E3A0368439C2BF8EEA05E32EE9
```

Values:

`<enabled/>`
`<disabled/>`

#### Battery Settings 

?>Added in version 10.2104

When this policy is enabled, the Battery Settings features of Commercial Vantage will be turned off.

Battery percentage for starting and stopping charge threshold can only be set in increments of 5. Any value input will be rolled to next increment of 5.

If an IT Admin sets a "Start Charging" greater than "Stop Charging", Vantage will ignore "Start Charging" set by Admin and will "Start Charging" at 5% less than "Stop Charging".
Ex: IT Admin sets "Start Charging" = 60 and "Stop Charging" = 50. Then, Vantage will "Start Charging" at 45 since "Stop Charging" = 50

If checkbox to "Automatically set the start charging" is checked by IT Admin, Vantage will ignore "Start Charging" set by Admin and will "Start Charging" at "Stop Charging" minus 5.
Ex: If checkbox selected and "Stop Charging" is set to 90, then "Start Charging" is set to 85.

When the toggle to "Automatically Set Threshold" is on, then Battery Threshold "Start" cannot be set.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/6A6C1333A96BD99C316FC0AC169C6B8D
```

?>  `4B9DE8D61B215393ED7255D0719FA5FA = Threshold Start`
    `2FE339B04615BBA5C913F45FB6A1B34D = Threshold Stop`
    `51A1765894644A2F58B9AF5EE7F65922 = Auto Start Charging`

Values:

`<enabled/>`  
`<data id="30B3EB897294AF0A770737E004CCE7B0" value="true"/>`
`<data id="4B9DE8D61B215393ED7255D0719FA5FA" value="60"/>`
`<data id="2FE339B04615BBA5C913F45FB6A1B34D" value="80"/>`
`<data id="51A1765894644A2F58B9AF5EE7F65922" value="false"/>`

`<disabled/>`

!> If this policy is enabled, the Battery Settings section in the GUI will disappear.

#### Power Smart Settings

?> Added in version 10.2104

When this policy is enabled, the Power Smart Settings of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/ADB803E7378E121123D5E08D9A2D0AE3
```

Values:

`<enabled/>`
`<disabled/>`

#### Standby Settings

?> Added in version 10.2104

When this policy is enabled, the Standby Settings feature of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/B0FE740B6951DD55D924F47EE0577466
```

Values:

`<enabled/>`
`<disabled/>`

#### Energy Star

?> Added in version 10.2104

When this policy is enabled, the Energy Star features of Commercial Vantage will be turned off

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~E4F5170489B8C677D42DEB4590E140A7/D2EF91148F6CAD7276895C6CB7051E06
```

Values:

`<enabled/>`
`<disabled/>`

#### Active Protection System Settings

?> Added in version 10.2104

When this policy is enabled, the Active Protection System Settings features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~45D8B8B2CBDB4610CAB05A18CF2C9868/3E5A8FB355FCCB817AD1D3DEFAC78170
```

Values:

`<enabled/>`
`<disabled/>`

#### Intelligent Screen

When this policy is enabled, the Intelligent Screen features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~45D8B8B2CBDB4610CAB05A18CF2C9868/9DB9CAC9C421AFDB3A3381486210EA6C
```

Values:

`<enabled/>`
`<disabled/>`

#### Intelligent Security Settings

?> Added in version 10.2104

When this policy is enabled, the Intelligent Security Settings features of Commercial Vantage will be turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~8BFC79DE8BB6F9B73316906802BA1CF8~45D8B8B2CBDB4610CAB05A18CF2C9868/E01515303271B7087B61546ECED61B39
```

Values:

`<enabled/>`
`<disabled/>`

### **System Update**

#### System Update Configuration

This policy setting provides the ability for the Administrator to configure the filter of searching updates.  If you enable this policy setting, Commercial Vantage will search for updates based on this filter. This policy affects both manual and auto update.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7/E1181AE4156C9E11CAF88FC6416AE108
```

Values:

`<enabled/>`  
`<data id="602015B22CFEA08C53FEC8C3E81356BF" value="true"/>`
`<data id="CE7D1526B3D8674705FF75DFF52B4416" value="true"/>`
`<data id="7C75C7AA6FF288235BCA3886FA9A4176" value="true"/>`
`<data id="94803C37291A574BB4CAF4DFAE682CC2" value="true"/>`
`<data id="7326616EB323392D1BB0E6436A4A02AF" value="false"/>`
`<data id="6564E6607DD79991C0A56F009A4102FA" value="true"/>`
`<data id="B78D824B47B0EC632B7EDEF30B63E2D9" value="true"/>`
`<data id="A0DEF98CD96C592582382A3453CB78BA" value="true"/>`
`<data id="8E6885D7C10107B5CD98053B7D8B2A6E" value="true"/>`
`<data id="A45D902F95DDD3B8597B21175A66A804" value="true"/>`
`<data id="46302403B9C32072305518FE20DC6720" value="false"/>`
`<data id="FDC13AFD3BA418958D122D78105C2F90" value="false"/>`
`<data id="3297105136FCEC5D3432C0FA2FDB73BB" value="false"/>`
`<data id="C62002C924CF75712313AC1CF94525AB" value="false"/>`
`<data id="9A82A62C3EF3BA2FCC142413A1FAC951" value="false"/>`

`<disabled/>`

?> All elements must be specified with a value of either True or False.  Reference the legend below for Boolean id elements to string match.

`602015B22CFEA08C53FEC8C3E81356BF = Critical Applications`
`CE7D1526B3D8674705FF75DFF52B4416 = Critical Drivers`
`7C75C7AA6FF288235BCA3886FA9A4176 = Critical BIOS`
`94803C37291A574BB4CAF4DFAE682CC2 = Critical Firmware`
`7326616EB323392D1BB0E6436A4A02AF = Critical Others`
`6564E6607DD79991C0A56F009A4102FA = Recommended Applications`
`B78D824B47B0EC632B7EDEF30B63E2D9 = Recommended Drivers`
`A0DEF98CD96C592582382A3453CB78BA = Recommended BIOS`
`8E6885D7C10107B5CD98053B7D8B2A6E = Recommended Firmware`
`A45D902F95DDD3B8597B21175A66A804 = Recommended Others`
`46302403B9C32072305518FE20DC6720 = Optional Applications`
`FDC13AFD3BA418958D122D78105C2F90 = Optional Drivers`
`3297105136FCEC5D3432C0FA2FDB73BB = Optional BIOS`
`C62002C924CF75712313AC1CF94525AB = Optional Firmware`
`9A82A62C3EF3BA2FCC142413A1FAC951 = Optional Others`

#### System Update Repository

Defines the location of where System Update will pickup available content.

?> Supports UNC paths or a local drive only

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7/BD0C70F0CE887CC46496DD7BF81C0B8C
```

Values:

`<enabled/>`  
`<data id="BD0C70F0CE887CC46496DD7BF81C0B8C" value="\\your_repository"/>`

#### Auto Update

This policy setting provides the ability for the Administrator to control auto update.  If you enable this policy setting, the auto update will be enabled. If you disable this policy setting, the auto update will be disabled.  If you do not configure this policy setting, it will keep the last status and can be controlled by the end user.  By default, auto update will install critical updates and recommended drivers.  If you want customization, please change the setting "Configure System Update".

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/CD787218E9D584BCE873273A0AFD7F05
```

Values:

`<enabled/>`
`<disabled/>`

#### Auto Update - Schedule Day Of Week

This policy setting provides the ability for the Administrator to configure the day of week for auto updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/80393D48344F26E5AE90D0F22D6B676F
```

Values:

`<enabled/>`  
`<data id="80393D48344F26E5AE90D0F22D6B676F" value="3"/>`

?> The value should be a number (0-6), where 0 means Sunday, 1 means Monday, 2 means Tuesday...

#### Defer Update

?> Added in version 10.2104 v2

This policy setting provides the ability for the Administrator to control deferred updates.  If you enable this policy setting, when there are some updates that needs to reboot the system, the end user can defer these updates for 1 hour.  If you disable or do not configure this policy setting, the end user can cancel these updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/C015CAB39D5B210745DC6D0F43029C21
```

Values:

`<enabled/>`
`<disabled/>`

#### Turn Off Run-Once Task

?> Added in version 10.2104 v2

When this policy is enabled, the initial check for updates by Commercial Vantage is turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/D89714B27390B0E22E66BCA5C8A43FAE
```

Values:

`<enabled/>`
`<disabled/>`

#### Auto Update - Schedule Time

This policy setting provides the ability for the Administrator to configure the time for auto updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/EC653B23E1449655915FA566BEA54E40
```

Values:

`<enabled/>`  
`<data id="EC653B23E1449655915FA566BEA54E40" value="10:00:00"/>`

?> For example, 18: 30:00 for 6:30 PM

#### Warranty Information

?> Added in version 10.2104

This policy setting allows the Administrator to hide the warranty information in Commercial Vantage.  If you enable it, the warranty information will be removed from the Commercial Vantage GUI.  If you disable or not configure it, the warranty information will be shown.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~4D633640E5CF3443867C0771CE6106B0/29310C221BB9070F63950B4D1EF6E2FD
```

Values:

`<enabled/>`
`<disabled/>`

#### Write Warranty Information to WMI

?> Added in version 10.2104

This policy setting allows the Administrator to enable Commercial Vantage to writing the warranty information of the system into the Lenovo Namespace WMI table.  If you enable it, the warranty information will be written to the WMI table.  If you disable or not configure it, the warranty information will not be written to WMI table.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~4D633640E5CF3443867C0771CE6106B0/8431B9B72EC21BF09C22F293D7E3F2D5
```

Values:

`<enabled/>`
`<disabled/>`

### **EULA**

#### Auto Accept EULA

When you use this policy to disable the EULA and Privacy window, a notification will go back to Lenovo that the EULA has been accepted.  No other data is collected.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~261C3D29FFEB46D46D29941DC7D22786/423D78F64EDE5D50939BFF9E369A1FC4
```

Values:

`<enabled/>`
`<disabled/>`

### **Wifi Security**

#### Wifi Security

 When this policy is enabled, the Wifi Security feature of Commercial Vantage will be turned off.

 OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~247D6178BE8CC3C83409E26C3E1CE0D9/11116BCCD9E515307397B1CE23E74D13
```

Values:

`<enabled/>`
`<disabled/>`