# Appendix D: Supported DASH Commands

Following are the supported commands for a DASH capable system: 

?>Adding -v 1 option will provide detailed logs.

## Supported DASH Commands 

| **Commands**                                                 | **Description**                                           |
| ------------------------------------------------------------ | --------------------------------------------------------- |
| dashcli.exe  -h <ipaddress> -S https -C -p 664 -a digest discover info | Display discovery information with Digest  authentication |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate computersystem | Enumerate all the computer system profile instances       |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   registeredprofile | Enumerate all the registered  profile instances           |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate sensor | Enumerate sensor details                                  |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate processor | Enumerate all the processor profile  instances            |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate dhcpclient | Enumerate all the DHCP client profile instances           |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate dnsclient | Enumerate all the DNS client profile instances            |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate ethernetport | Enumerate all the ethernet port profile instances         |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate networkport | Enumerate all the network port profile instances          |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 enumerate ipinterface | Enumerate all the IP interface profile instances          |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   ipconfiguration | Enumerate all the IP configuration profile instances      |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate   operatingsystem | Enumerate all the OS profile instances                    |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate asset | Enumerate all the asset profile instances                 |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate memory | Enumerate all the memory profile instances                |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate pcidevice | Enumerate all the PCI device instances                    |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate ssh | Enumerate all the SSH profile instances                   |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate recordlog | Enumerate all the records information                     |

| **Commands**                                                 | **Description**                                  |
| ------------------------------------------------------------ | ------------------------------------------------ |
| dashcli.exe  -h <ipaddress> -u <username> -P <password> -S https -C -p  664 enumerate battery | Enumerate the battery info                       |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power status | Display current power status of the AIM-T system |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power shutdown | Power shutdown the AIM-T system                  |
| dashcli.exe  -h <ipaddress> -u <username> -P   <password>  -S https -C -p 664 -t   computersystem[#instance] power cycle | Power cycle the AIM-T system                     |
| dashcli -h dash-system -p 664 -S  https -C -u <username> -P  <password> software[0] install   <URL for Capsule>   Example: dashcli -h 192.168.0.176 -S https -C -p  664  -u admin -P amd@123 -t software[0]  install http://192.168.0.211:3274/Capsule.zip | Update the Software BIOS through Capsule update  |

