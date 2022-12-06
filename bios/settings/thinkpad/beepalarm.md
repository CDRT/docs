# Beep and Alarm Settings #
![](./img/beepalarm.png)

<details><summary>Password Beep</summary>

One of 2 possible states for the password beep:

1.	**Off** - no beep sounds. Default.
2.	On - system will make a beep sound when the system is waiting for a power-on, hard disk, or supervisor password.

    ?>  Different beeps will be sounded when the entered password matches or does not match the configured password.


| WMI Setting name | Values | Locked by SVP | AMD/Intel |
|:---|:---|:---|:---|
| PasswordBeep | Disable, Enable | Yes | Both |

</details>

<details><summary>Keyboard Beep</summary>

One of 2 possible states for the keyboard beep:

1.	**On** - a beep will sound when unmanageable key combination is pressed. Default.
2.	Off - a beep is disabled.


| WMI Setting name | Values | Locked by SVP | AMD/Intel |
|:---|:---|:---|:---|
| KeyboardBeep | Disable, Enable | Yes| Both |

</details>