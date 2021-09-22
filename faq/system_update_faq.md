## System Update FAQ <!-- {docsify-ignore} -->

<details>
<summary>How to run System Update by command line? </summary>

System Update can be controlled via command line by leveraging the group policy control for the Administrator Command Line. A typical scenario would have System Update executed by a task in the Windows Task Scheduler set to run on a recurring basis to ensure the device stays current. That scheduled task would execute:

```
C:\Program Files (x86)\Lenovo\System Update\tvsu.exe /CM
```

The rest of the command line parameters would be specified as a Policy in the registry using either Group Policy or by manipulating the registry directly at:

```
HKLM\Software\Policies\Lenovo\System Update\UserSettings\General
Value: [REG_SZ] AdminCommandLine
```

?>Note: When using a custom scheduled task, a new task should be created, and the default task created when System Update is installed should be disabled. 

Additionally, the “SchedulerAbility” setting must be set to “NO” in the registry at:
```
"HKLM:\SOFTWARE\WOW6432Node\Lenovo\System Update\Preferences\UserSettings\Scheduler" 
```
This will prevent System Update from re-enabling the default tasks.

</details>

