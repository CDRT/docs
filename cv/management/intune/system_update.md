### System Update Configuration ###
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

---

### System Update Repository ###
Defines the location of where System Update will pickup available content.

?> Supports UNC paths or a local drive only

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7/BD0C70F0CE887CC46496DD7BF81C0B8C
```

Values:

`<enabled/>`  
`<data id="BD0C70F0CE887CC46496DD7BF81C0B8C" value="\\your_repository"/>`

---

### Auto Update ###
This policy setting provides the ability for the Administrator to control auto update.  If you enable this policy setting, the auto update will be enabled. If you disable this policy setting, the auto update will be disabled.  If you do not configure this policy setting, it will keep the last status and can be controlled by the end user.  By default, auto update will install critical updates and recommended drivers.  If you want customization, please change the setting "Configure System Update".

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/CD787218E9D584BCE873273A0AFD7F05
```

Values:

`<enabled/>`
`<disabled/>`

---

### Defer Update ###

?> Added in version 10.2104 v2

This policy setting provides the ability for the Administrator to control deferred updates.  If you enable this policy setting, when there are some updates that needs to reboot the system, the end user can defer these updates for 1 hour.  If you disable or do not configure this policy setting, the end user can cancel these updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/C015CAB39D5B210745DC6D0F43029C21
```

Values:

`<enabled/>`
`<disabled/>`

---

### Schedule Day of Week ###
This policy setting provides the ability for the Administrator to configure the day of week for auto updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/80393D48344F26E5AE90D0F22D6B676F
```

Values:

`<enabled/>`  
`<data id="80393D48344F26E5AE90D0F22D6B676F" value="3"/>`

?> The value should be a number (0-6), where 0 means Sunday, 1 means Monday, 2 means Tuesday...

---

### Schedule Time ###
This policy setting provides the ability for the Administrator to configure the time for auto updates.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/EC653B23E1449655915FA566BEA54E40
```

Values:

`<enabled/>`  
`<data id="EC653B23E1449655915FA566BEA54E40" value="10:00:00"/>`

?> For example, 18: 30:00 for 6:30 PM

---

### Turn off Run-Once Task ###

?> Added in version 10.2104 v2

When this policy is enabled, the initial check for updates by Commercial Vantage is turned off.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/CommercialVantage~Policy~03E445D7B5956335BEDEF9340AC7E092~7D8BB8A33C8A8577FC2188C5539DFDBB~162A79B7E43E726881D582DBA5C8B0B7~E4FF6280DA9B32B3629E2DCFE74DCCDB/D89714B27390B0E22E66BCA5C8A43FAE
```

Values:

`<enabled/>`
`<disabled/>`