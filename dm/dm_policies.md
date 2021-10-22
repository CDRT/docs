## Intune

### **Overview**

This page will present the policies found in the Dock Manager ADMX template, along with the OMA-URIs which can be used to configure the application on clients.

Refer to the [Dock Manager blog article](dm/dm) on how to create the Win32 app.

### **ADMX Ingestion**

Sign in to the [MEM admin center](https://endpoint.microsoft.com/#blade/Microsoft_Intune_DeviceSettings/DevicesWindowsMenu/configProfiles) and create a new Configuration profile for **Windows 10 and later**, selecting the **Custom** template profile.  Enter the required information for the new profile, for example:

**Name**: Lenovo Dock Manager ADMX Ingest

In the Custom OMA-URI Settings menu, click Add to add a new setting.

**Name**: ADMX Ingest

**OMA-URI**: ./Device/Vendor/MSFT/Policy/ConfigOperations/ADMXInstall/DockManager/Policy/DockManager

**Data Type**: String

**Value**: Copy the contents of the .admx into this field

Click OK to complete adding the new OMA-URI row.  Repeat the same steps and add any additional policies you want to manage to the profile.

### **General**

### Ask Before Firmware Update

This setting will configure to enable/disable a prompt to the user before executing the firmware update.

If this setting is enabled, prompt will ask the user to proceed executing update firmware.

If this setting is disabled, prompt will not be shown and will directly proceed executing firmware update.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~General/AskBeforeFirmwareUpdate
```

Values:

`<enabled/>`
`<disabled/>`


### Enable Notifications

This setting will configure whether to enable notifications during firmware download and update.
      
If this setting is enabled, notification will be enabled and shown.

If this setting is disabled, notification will not be shown.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~General/EnableNotifications
```

Values:

`<enabled/>`
`<disabled/>`

### Log File Age to Cleanup

If this setting is enabled, it will configure the number of elapsed days before deleting the outdated log files based on the number of days inputted inside the textbox in the options panel.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~General/LogfileAgeToCleanup
```

Values:

`<enabled/> <data id="LogfileAgeToCleanup_Prompt" value="30"/>`

`<disabled/>`


### Log File Max Size

If this setting is enabled, it will specify the log max file size in kb before creating a new log file based on the inputted value inside the textbox in the options panel.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~General/LogfileMaxSize
```

Values:

`<enabled/> <data id="LogfileMaxSize_Prompt" value="1024"/>`

`<disabled/>`

### Repository Location

Description: If this setting is enabled, it will configure the specified repository location for downloading the latest firmware updates based on the inputted path inside the textbox in the options panel.

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~General/RepositoryLocation
```

Values:

`<enabled/> <data id="RepositoryLocation_Prompt" value="\\share\dock-firmware"/>`

`<enabled/> <data id="RepositoryLocation_Prompt" value="C:\dock-firmware"/>`

`<disabled/>`

### **Scheduling**

### Frequency

If this settings is enabled, it will edit the frequency on how the next scheduled task's execute date should be updated. 

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/Frequency
```

Values:

`<enabled/> <data id="Frequency_Dropdown" value="MONTHLY"/>`

`<disabled/>`

?>Note: Frequency values include DAILY,WEEKLY, and MONTHLY which can be configured on the dropdown provided inside the options panel.

### Run At

Description: If this setting is enabled, it will edit the time upon when the next scheduled task's execute date should be updated. 

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/RunAt
```

Values:

`<enabled/> <data id="RunAt_Prompt" value="20:30:00"/>`

`<disabled/>`

?>Note: Valid inputs includes any time of the day in 24:MM:SS format which can be inputted inside the textbox in the options panel.

### Run Days

If this setting is enabled, it will edit the day/s when the next scheduled task's execute date should be updated. 

Valid inputs are 1-31 and can be separated by a comma (e.g. 1,2,31) which can be inputted inside the textbox in the options panel.        

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/RunDays
```

Values:

`<enabled/> <data id="RunDays_Prompt" value="1,15"/>`

`<disabled/>`

?>Note: This configuration will be use when the Frequency policy is enabled and set to "MONTHLY".

### Run Month

If this setting is enabled, it will edit the month/s when the next scheduled task's execute date should be updated. 

Valid inputs are January-December and can be separated by a comma (e.g. January,February) which can be inputted inside the textbox in the options panel.  

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/RunMonth
```

Values:

`<enabled/>`
`<data id="RunMonth_Prompt" value="January,March,May,July,September,November"/>`
`<disabled/>`

?>Note: This configuration will be use when the Frequency policy is enabled and set to "MONTHLY".

### Run Monthly On

If this setting is enabled, it will edit the month/s when the next scheduled task's execute date should be updated. 

Valid inputs include: First, Second, Third, Fourth, Last; and can be separated by a comma (e.g. First,Second,Last) which can be inputted inside the textbox in the options panel.  

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/RunMonthlyOn
```

Values:

`<enabled/> <data id="RunMonthlyOn_Prompt" value="First,Last"/>`

`<disabled/>`

?>Note: This configuration will be use when the Frequency policy is enabled and set to "MONTHLY".

### Run On

If this setting is enabled, it will edit the day of the week when the next scheduled task's execute date should be updated. 

Valid inputs are Sunday-Monday and can be separated by a comma (e.g. Monday,Tuesday) which can be inputted inside the textbox in the options panel.  

OMA-URI:
```
./Device/Vendor/MSFT/Policy/Config/DockManager~Policy~LenovoCompany~DockManager~Scheduler/RunOn
```

Values:

`<enabled/> <data id="RunOn_Prompt" value="Sunday,Friday"/>`

`<disabled/>`

?>Note: This configuration will be used when the Frequency policy is enabled and set to "MONTHLY" or "WEEKLY".