# 7 Appendix B: Mapdrv Utility

The MapDrv utility provides network share related functions for System Update. To define the network share information, use the MapDrv utility to connect or disconnect network shares. The MapDrv utility maintains network share information in a registry key that is protected by administrator access only. The network share information includes the network share name (in UNC format), user name (saved in the registry as an encrypted string), and the password (saved in the registry as an encrypted string).

The MapDrv utility can be found in the System Update installation directory. The default installation directory is located at ```C:\Program Files (x86)\Lenovo\System Update```.

The network share information is stored in the following registry entry:

```Registry
HKLM\Software\Wow6432Node\Lenovo\MND\TVSUAPPLICATION
```

If an Active Directory policy is used, these values are stored in the following registry entry:

```Registry
HKLM\Software\Policies\Lenovo\MND\TVSUAPPLICATION
```

The strings stored in the **TVSUAPPLICATION** key are:

| **String** | **Description** |
| --- | --- |
| UNC | The value of this string specifies the stored network share. |
| User | The value of this string specifies the stored encrypted user name for this share. |
| Pwd | The value of this string specifies the stored encrypted password for this share. |
| NetPath | The value is generated by the MapDrv utility to indicate the actual connection path. It might be in IP dotted format if the **ServerName** string is not working. The actual connection path may not be the same as the stored **UNC** value. |

<div style="text-align:center;padding-bottom:40px;font-style: italic;">Table 8-1. The MapDrv settings and values</div>

The MapDrv utility also enables an administrator to use the encryption engine to generate an encrypted user name and password, which can be used to pre-populate network share information on multiple systems. Using the encryption engine in this manner does not update the registry on the system.

## 7.1 Command-line Interface

The command-line interface to the MapDrv utility is as follows:

```CMD
Mapdrv /<function><app id> /unc <sharename> /user <username\> /pwd <password> [/timeout <seconds>] [/s]
```

| **Parameter** | **Description** |
| --- | --- |
| /function | Identifies the function to provide. Valid values are store, connect, disconnect, and display. |
| app id | Identifies the application. The value specified is used to form the registry key name that contains the network share information, for example:  **TVSUAPPLICATION** . |
| /unc sharename | Identifies the network share name to store. The share name should be in the UNC form, for example: [**\\\myserver\myshare**](smb://myserver/myshare) |
| /user username | Specifies the user name to store. |
| /pw password | Specifies the password to store. |
| /timeout seconds | Specifies the connection timeout value to store. The default is 30 seconds. |
| /s | Enables a silent operation. |

<div style="text-align:center;padding-bottom:40px;font-style: italic;">Table 8-2. Parameters</div>

The return code is **0** if an operation was successful. Otherwise, the return code is greater than **0**.

When the MapDrv utility is launched with no parameters, the end user will be prompted for the network share, user name and password, and then MapDrv will attempt to connect to the specified network share using the specified credentials.

## 7.2 Displaying Encrypted User Name and Password Strings

This function displays the registry key of the network share information where the encrypted user name and password is stored. Using the /display function will not store the user name and password in the registry. You need to copy the encrypted user name and password to the appropriate registry key.

```CMD
mapdrv /view <app id> /user <username> /pwd <password>
```

Example:

```CMD
mapdrv /view TVSUAPPLICATION /user temp/pwd password

app id: TVSUAPPLICATION

user: temp
pwd: password
```

This command captures the encrypted user name and password to set up the repository with UNC path with authentication.

## 7.3 Storing Network Share Information for a ThinkVantage Application

This function stores the network share information in the registry using to define the subkey from the main MapDrv registry key:

```CMD
mapdrv /store <app id> /unc <sharename> /user <username> /pwd <password> [/timeout <seconds>]
```

This sets the UNC, user name, and password values in the registry.

## 7.4 Connecting to the network share for a ThinkVantage application

Connect the network share for the specified ThinkVantage application:

```CMD
mapdrv /connect <app id> [/s]
```

Connects to the share using the UNC, user name, and password values in the registry. The actual connection UNC is output to the NetPath value.

## 7.5 Disconnecting the Network Share for a ThinkVantage Application

The following command disconnects the network share for the specified ThinkVantage application if the application is currently connected:

```CMD
mapdrv /disconnect <app id>
```

Performs a _**net use /d [NetPath stored in registry]**_ to disconnect the network connection.