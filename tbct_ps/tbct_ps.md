# Think BIOS Config Tool

## Introduction

The Think BIOS Configurator tool was developed using the WMI BIOS interface methods and the scripts located at [this website](http://support.lenovo.com/us/en/documents/ht100612) <!--change the link here once new one is available--> to create a user friendly way of applying changes to the BIOS from within the Windows environment. This document will describe the ways the tool can be used and the various options it supports. The application needs no other files for execution. The application will read from WMI to provide the proper options for each of the available settings.

?>Not all BIOS settings are exposed through the WMI interface.  This tool will list only the settings that are configurable through WMI.</i>

## Standard Execution of Application
Below is an example of what a standard execution of the application will look like using Windows PowerShell. The **Work with Settings** tab is displayed by default, which is shown in the first image. 

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctps1.png)
</div>

The second image displays the **Other Actions** tab.

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsoa.png)
</div>

The thirdimage displays the **Preferences** tab.

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpspref.png)
</div>

This document will detail how each action can be performed using the Think BIOS Config Tool. 

## Settings

<!-- Insert Image here-->

### Settings Table 
<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctps1_2.png)
</div>

The Settings Table displays the current settings of the target machine. As seen above, each setting has an associated value column which can be changed easily. Most settings are in the form of dropdown boxes but options like ‘BootOrder’ have more complex options to select the new value of the setting. 

### Save Changed Settings <!-- {docsify-ignore} -->

If the user makes any changes, the text of the setting name will be changed to red (as seen below with the AlwaysOnUSB setting) to signify that it is a value different than what is currently set on the computer.

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctps1_1.png)
</div>

Once all the required changes have been set, click **Save Changed Settings** and the application attempts to commit the changes to the machine. Only the settings that are pending change are attempted to be saved to save time and eliminate any issues with trying to commit a setting will the same value. This is what will be displayed after the button is clicked:

<!-- add message box of saved chnages here -->

As seen above, the application was successful in setting one setting. Error messages are provided in the case of a failure. More than likely, the error users will see will be ‘Access Denied’.

?>All settings will only take affect once the computer is restarted.

<!-- Is the bwlow paragraph and image still true? -->
<!--If a user closes the application with changes pending, a message will be displayed that there were pending changes. Unfortunately, there is a bug in Microsoft’s code that makes it so the closing of the application cannot be stopped once it is started.

<div style="text-align:center;padding-bottom:40px;padding-top:40px">

![Pending changes](../img/reference/tbct/tbct10.png)
</div>
-->

?>Not all BIOS settings are affected by the BIOS defaults change and varies by product. If the button is clicked, a warning prompt will be shown to confirm the user wishes to do that.

### Revert Changes <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsrevert_changes.png)
</div>

If settings have been changed in the application but not applied to the machine and the user wants to revert back to the original settings, click **Revert Changes**. <!-- make sure this is correct--> The user will see the items that were previously marked in red text will be reverted back to black text and the values reset to their original settings. This is a quick way for the user to create multiple configuration files and revert back to the settings they had already saved.

### Reset to Factory Defaults <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsreset_factory.png)
</div>

The **Reset to Factory Defaults** button applies factory default values to the settings.

### Reset to Custom Defaults <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsreset_custom.png)
</div>

### Generate INI <!-- {docsify-ignore} -->
<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsini_gen.png)
</div>

On the bottom right, there is a **Generate INI** button. This will create an .INI file of the current settings. The file will be generated in the working directory the application is launched from, inside the Output folder. The file will be named after the localhost name the settings are being accessed on. The settings that are exported are the current settings of the machine AND the pending changes to the machine. This is done to allow the user to create these files without having to commit changes to the machine. The created file has an optional first line if there is a supervisor password and the remaining lines are of the form key,value. If there is a supervisor password on the machine the application will include it based on the details provided in the Security Actions sections below. <!-- Make sure the file downloads in the same location or do we need to edit it? -->

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpsini_ex.png)
</div>

### Create Intune Package <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Think BIOS Config Tool UI](../img/reference/tbct_ps/tbctpscreate_intune.png)
</div>

## Security

### Authentication <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Authentication](../img/reference/tbct_ps/tbctps2.png)
</div>

If settings are being changed on a system where a BIOS Supervisor Password has been set, the **Authentications** section provides the ability to provide the necessary password details. At the top left of the application you will see a section for authentication.


### Target Remote <!-- {docsify-ignore} -->
By default the application will attempt to load the settings of the local machine when it launches. The address and model of the machine whose settings are being displayed will be displayed above the Settings table, such as:

<div style="text-align:center;">

![Target Remote](../img/reference/tbct_ps/tbctps3_1.png)
</div>


If you would like to target another remote machine on the network, use the **Target Remote** section to the left. Enter the IP Address, Username, and Password for the targetted machine. 

<div style="text-align:center;">

![Target Remote](../img/reference/tbct_ps/tbctps3.png)
</div>

<!-- Add images/error messages that may pop up if host is unreachable or the WMI service is unavailable -->

Once connected to the remote computer, the screen will refresh with the data that is on that machine. To switch back to the local machine, just click the <!--‘Target Local’ --> button, which is only enabled if the application is accessing a remote machine.  <!-- Add how to revert back? -->

<!-- ### Output Location --><!-- {docsify-ignore} -->

<!-- <div style="text-align:center;">![Output Location](../img/reference/tbct_ps/tbctps4.png)</div> -->






## Other Actions

Below is an example of what the application will display when the **Other Actions** tab is selected.

<div style="text-align:center;">

![Other Actions](../img/reference/tbct_ps/tbctpsoa.png)
</div>

### Supervisor Password <!-- {docsify-ignore} -->

<div style="text-align:center;">

![INI Upload](../img/reference/tbct_ps/tbctpsoa1.png)
</div>


### Apply Settings INI <!-- {docsify-ignore} -->

<div style="text-align:center;">

![INI Upload](../img/reference/tbct_ps/tbctpsoa2.png)
</div>

When the **Other Actions** tab is clicked, there will be an option to browse and select an .INI file that was previously generated by this program. Once selected, click **Apply Settings** to make any changes detected in the .INI file. All the settings are read into the potential changes and then compared to the current settings of the machine. Only those that are different will be applied. Specify Supervisor password if applicable or specify an encryption passphrase if used in the INI file. 

The user will also have the option to clear the Supervisor password or the Fingerprint data by simply clicking one of the two buttons below the 'Apply Settings' button.

### Clear Password or Fingerprint Dara <!-- {docsify-ignore} -->

<div style="text-align:center;">

![INI Upload](../img/reference/tbct_ps/tbctpsoa3.png)
</div>



### Change Supervisor Password <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Password Change](../img/reference/tbct_ps/tbctpsoa4.png)
</div>



## Preferences

Below is an example of what the application will display when the **Preferences** tab is selected.

<div style="text-align:center;">

![Other Actions](../img/reference/tbct_ps/tbctpspref.png)
</div>

### Output Location <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Password Change](../img/reference/tbct_ps/tbctpspref1.png)
</div>

### Enable Logging <!-- {docsify-ignore} -->

<div style="text-align:center;">

![Password Change](../img/reference/tbct_ps/tbctpspref2.png)
</div>

<!--### Execution via Command Line
This was a very important feature when developing this application.  By having command line execution of the application, the user can use this in deployment situations.  When used in this fashion, the application will flash briefly and suppress all notifications.  All command line parameters must be enclosed in quotation marks and have the following format: **"switch=key,value"**. There are no spaces around the equals sign. There are several switches that are supported. Order does not matter but parameters are processed from left to right. Therefore if for some reason the user provides any switch more than once the last one will be the one the application uses. If the user passes both the ‘config’ and ‘file’ switch in one command, the ‘file’ switch will take precedence over the ‘config’.

### File Switch

To apply a configuration or password file via the command line, the user would want to use the ‘file’ switch. The configuration file can be described either by a full path or just the name if it is located in the same folder as the application itself. Just like the ‘Apply config file’, all the settings will be processed and applied if they are different than the current settings on the machine.

Example:
```
ThinkBiosConfig.hta "file=C:\W550sConfig.ini"
```

### Config Switch
To apply a single configuration change, the user would want to use the "config" switch. This switch is mainly used for when the user wants to change just one setting and using a configuration file would be too much overhead. 

Example:
```
ThinkBiosConfig.hta "config=USB30Mode,Disable"
```

### Pass Switch
This switch is used in conjunction with both ‘file’ and ‘config’. If there is a supervisor password on the target machine, the application needs this information to apply the settings. 

In the case of the ‘file’ switch, the application will be expecting the encryption key that was used when creating the configuration file if the password was encrypted and stored in the file or the supervisor password itself. If there is an encrypted string at the beginning of the file, the application will attempt to decrypt the first line of the configuration file to retrieve the supervisor password that is stored in the file. 

?>This option must be used with a password file.

Example
```
ThinkBiosConfig.hta "file=C:\W550sConfig.ini" "pass=myEncryptionKey"
```

In the case of the ‘config’ switch, the application will be expecting the supervisor password itself. This will be passed to the application to save the setting properly.

Example:
```
ThinkBiosConfig.hta "config=USB30Mode,Disable" "pass=mySupervisorPassword"
```

Also if working with a different language than ‘US’ the user can enter their language along with the password in the following format (example demonstrates French password).

Example
```
ThinkBiosConfig.hta "config=USB30Mode,Disable" "pass=mySupervisorPassword,ascii,fr"
```

### Remote Switch
The remote feature allows the user to set the target computer before the application displays the first settings. This can be used in two ways: set the target computer and open the GUI or set the target computer and apply a command line switch to it. To set the target computer for the GUI, only include the ‘remote’ switch. 

Example:
```
ThinkBiosConfig.hta "remote=<IP_or_Hostname>"
```
To apply a command line switch to the remote machine, just use the previously described switches.  Remember order of the switches does not matter.
Example:
```
ThinkBiosConfig.hta "remote=<IP_or_Hostname>" "file=C:\W550sConfig.ini"
```

### Log Switch
Use this switch to control where the log file should be written to. By default, a log file with the name of machineType_serialNumber.txt will be created in the current directory with the tool.  

Example:
```
ThinkBiosConfig.hta "log=C:\path\to\log\"
```

### NoLog Switch
Use this switch to prevent the log file from being created or written to. The switch is case insensitive.

Example:
```
ThinkBiosConfig.hta "NoLog"
```

### Default Switch
Use this switch to apply the default settings to a computer quickly. The only parameter for this setting is a case insensitive "true". Only when it is provided will the settings be reset. No actions will be taken if any other string is provided.  

Example:
```
ThinkBiosConfig.hta "default=true"
```

### Help Switch
Shows a list of the most recent changes to the tool.
Example:
```
ThinkBiosConfig.hta "help"
```

### Deployment Situations
This application can be used in a deployment environment like MDT or Configuration Manager as long as support for HTA/HTML is enabled (MDT boot images provide this by default, ConfigMgr needs to have the feature enabled).  The application must be called after the disk has been partitioned.  In testing, placing the command during the Post-Install step seems like a good place.  Also remember that a restart is required to apply the settings.  

Example code for a task sequence step:
```
cmd.exe /c PathToApp\ThinkBiosConfig.hta "config=BootOrder,HDD0:PCILAN"
```

?>The ```cmd.exe /c``` is needed 9 out of 10 times when running as a Local System account.  In some cases it isn’t necessary but for consistency it is recommended.

### Troubleshooting
If a supervisor password exists and you know you are typing in the correct password but are receiving ‘Access Denied’ errors, restart the machine.  You may have exceeded the allowed attempts. The tool will validate the password to prevent exceeding the number of allowed attempts.

M910x has a slightly different ‘Load Defaults’ functionality. Once it is completed, you will no longer be able to see the settings until after a reboot.

Executing ThinkBiosConfig.hta under Powershell requires special attention when command line parameters are used. To pass the desired switches, Powershell needs them inside single quotes.

Example: 
```
ThinkBiosConfig.hta '"help"'  

ThinkBiosConfig.hta '"file=C:\W550sConfig.ini"' '"pass=myEncryptionKey"' -->
```