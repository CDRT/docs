# Glossary #

<div class="table-wrapper" >

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Admin Password | $2 Administrator (hard disk) Password <br /> <br /> Hard disk password, available if `Dual Password` is enabled. <br /> - ThinkPad: Admin + User password <br /> - ThinkCentre & Thinkstation: Master + User passwords. <br /> <br /> Admin and Master are synonyms.<br /> <br /> *More information:* <br /> - ["Types of password for ThinkPad" at Lenovo Support](https://support.lenovo.com/lt/en/solutions/ht036206-types-of-password-for-thinkpad) <br /> - ["Types of Passwords for ThinkCentre, ThinkStation" at Lenovo Support](https://support.lenovo.com/lt/en/solutions/ht513634) <br /> - [BIOS Security Settings](https://docs.lenovocdrt.com/#/bios/bios_guide?id=bios-security-settings) <br /> <br /> *Relevant settings:* <br /> - [Hard Disk Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br />- [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) <br /> - [NVMe1 Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| AHCI| $2 Advanced Host Controller Interface <br /> <br /> *More information:* <br /> - ["Serial ATA AHCI: Specification" at Intel.com](https://www.intel.com/content/www/us/en/io/serial-ata/serial-ata-ahci-spec-rev1-3-1.html) <br /> <br /> *Relevant settings:* <br /><br /> - [Configure SATA As (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) | $3 | $4 RAID | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ASPM| $2 Active State Power Management <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> [ASPM Support](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/pci_express_configuration) <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ATA| $2 Advanced Technology Attachment (Hard Disk Drive)<br /><br /> A hard disk drive with an integrated controller. Usually implemented as a serial drive (SATA).<br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> -  [SATA Controller](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) <br /> - [SATA Drive {Number} Password](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br /> - [First Boot Device](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br /><br />| $3 IDE, SATA, PATA | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Audit mode| $2  Enables programmatic discovery of signature list combinations that successfully authenticate installed EFI images without the risk of rendering a system unbootable. Chosen signature lists configurations can be tested to ensure the system will continue to boot after the system is transitioned out of Audit Mode.<br /> <br /> *More information:* <br /> [UEFI Specification Version 2.9 (March 2021) at UEFI.org](https://uefi.org/sites/default/files/resources/UEFI_Spec_2_9_2021_03_18.pdf) <br /><br /> *Relevant settings:* <br /> - [Enter Audit Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot?id=enter-audit-mode) <br />| $3 | $4 Custom mode | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| BIOS| $2 Basic Input/Output System (overrides user OS permissions to access settings in all cases; has no access to OS settings) <br /> <br /> *More information:* <br />  - ["What Is BIOS?" at Lenovo Support](https://support.lenovo.com/lt/en/videos/vid100790-what-is-bios) <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 UEFI | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| BIOS Self-healing| $2 BIOS is programmed to restore the machine to its previous state through an uncorrupted, secure backup. <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| CA| $2 Certification Authority. <br /> <br /> *More information:* <br />  - ["Windows Secure Boot Key Creation and Management Guidance" at Microsoft.com](https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/windows-secure-boot-key-creation-and-management-guidance) <br /> *Relevant settings:* <br /> - [Allow Microsoft 3rd Party UEFI CA (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot) <br /> - [TLS Auth Configuration (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| C State| $2 Core Power States <br /> <br /> A series of states numbered 0 to n, where each state represents lower power consumption. <br /> <br />*More information:* <br /> - ["C-State" at Intel.com](https://www.intel.com/content/www/us/en/develop/documentation/vtune-help/top/reference/energy-analysis-metrics-reference/c-state.html) <br /> <br />*Relevant settings:* <br /> - [C State Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/cpu_setup) <br /> <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Custom Mode| $2  <br /> <br /> *More information:* <!--- TODO ---> <br /> <br /> *Relevant settings:* <br /> - [Secure Boot Key State](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| DASH| $2 Desktop and mobile Architecture for System Hardware.  <br /> <br /> Secure out-of-band and remote client management standard. <br /> <br /> *More information:* <br>  - [DASH article at Lenovo CDRT](https://docs.lenovocdrt.com/#/dash/dash_top) <br> -  ["Desktop and Mobile Architecture for System Hardware" at DTMF.org](https://www.dmtf.org/standards/dash) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Deployed mode| $2 <!-- (see System Deploy Mode) --> <br /> <br /> *More information:* <!-- TODO --> <br /> <br /> *Relevant settings:* <br />- [Enter Deployed Mode (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot)<br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| DHCP| $2 Dynamic Host Configuration Protocol <br /> <br /> Network management protocol used on Internet Protocol (IP) networks for automatically assigning IP addresses and other communication parameters to devices connected to the network using a client-server architecture. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* [Lenovo Cloud Services (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| DPTF| $2 Dynamic Platform and Thermal Framework <br /> <br /> *More information:* <!-- TODO --> <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| DRAM| $2 Dynamic Random-Access Memory <br /> <!-- TODO --> <br /> Random-access semiconductor memory that stores each bit of data in a memory cell, usually consisting of a tiny capacitor and a transistor, both typically based on metal-oxide-semiconductor technology. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 NVDIMM | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| EAP| $2 Extensible Authentication Protocol <br /><br /> Authentication framework supporting multiple authentication methods. <br /><br /> *More information:* <br> - ["Extensible Authentication Protocol (EAP)" at IETF.org](https://datatracker.ietf.org/doc/html/rfc3748) <br /> - ["802.1X Overview and EAP Types" at Intel.com](https://www.intel.com/content/www/us/en/support/articles/000006999/wireless/legacy-intel-wireless-products.html) <br /><br /> *Relevant settings:* <br /> - [EAP Authentication Method (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| EEPROM| $2 Electrically Erasable Programmable Read-Only Memory <br /> Non-volatile memory storing relatively small amounts of data by allowing individual bytes to be erased and reprogrammed. <br /> <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /> - [MAC Address Pass Through (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| EFI| $2  <br /> Used in the context of HTTPS Boot<br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Delete HTTPs Boot Option from List (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup?id=delete-https-boot-option-from-list) <br />| $3 | $4 UEFI | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| EIST| $2 Enhanced Intel SpeedStep® Technology <br /> <br /> Dynamically adjusts processor voltage and core frequency, to decrease average power consumption and heat production. <br /> <br />  *More information:* <br /> -  - ["Overview of Enhanced Intel SpeedStep® Technology for Intel® Processors"at Intel.com] - (https://www.intel.com/content/www/us/en/support/articles/000007073/processors.html) <br /> *Relevant settings:* <br /> - [EIST Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/cpu_setup)<br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| EPP| $2 Enhanced Parallel Port <br /> <br /> A high-speed bi-directional mode for non-printer peripherals. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Parallel Port Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/parallel_port_setup.md)<br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Flash BIOS| $2  <br /> <br /> *More information:* <br /> - ["How to update BIOS" at Intel.com](https://www.intel.com/content/www/us/en/gaming/resources/how-to-update-bios.html) <br /> *Relevant settings:* <br /> - ["How to update system BIOS - Windows" at Lenovo.com](https://support.lenovo.com/uu/en/solutions/ht500008-how-to-update-system-bios-windows) <br /> - [Flash BIOS Updating by End-Users (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/uefibiosupdate.md) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2  Form factor <br /> <br /> The size and spatial design of the computer and its individual components. Broadly similar or the same across a model line. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| GPU | $2  Graphics Processing Unit <br /> <br /> *More information:* <br />  - ["What Is a GPU?" at Intel.com](https://www.intel.com/content/www/us/en/products/docs/processors/what-is-a-gpu.html) <br /> *Relevant settings:* <br /> - [PCIe Tunneling (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/thunderbolttm4.md) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| HDD | $2 Hard Disk Drive <br /> <br /> *More information:* <br />  - ["Laptop Hard Drives, SSD & Storage" at Lenovo.com](https://www.lenovo.com/us/en/faqs/laptop-faqs/hard-drives-ssd-guide/) <br /> *Relevant settings:* <br /> - [First Boot Device (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/startup.md) <br /> - [Boot Priority Order (THinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup.md) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| HDP| $2 Hard Disk Password <br /> <br /> Prevents unauthorized access to the data on the storage drive. Some models may support dual passwords, with a user password and an administrator password. <br /> <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /> - [Require HDP on System Boot (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br /> - [Hard Disk Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Intel AMT| $2 Intel ® Active Management Technology. <br /> <br /> Remote management solution from Intel ®. <br /> <br />*More information:* <br /> - ["Intel® Active Management Technology" at Intel.com](https://www.intel.com/content/www/us/en/architecture-and-technology/intel-active-management-technology.html) <br /> *Relevant settings:* <br /> - [Intel® Manageability (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/intel_r_manageability) <br /> - [Intel® AMT Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/intelramt) <br /> - [Onboard Ethernet Controller (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) <br />  | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| IOMMU| $2  Input-Output Memory Management Unit.<br /> <br /> Hardware assisted address translation from I/O device virtual addresses to physical addresses, to improve the system performance in virtual environments. <br /> <br /> *More information:* <br /> - [More information at Lenovo.com](https://lenovopress.lenovo.com/lp1467.pdf) <br /> *Relevant settings:* <br /> - [Device Guard (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) <br /> - [Device Guard (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/deviceguard) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| IRQ| $2 Interrupt Request Line. <br /> <br /> Hardware line allowing devices to take over processor resources for their function. IRQs are assigned numbers to prioritize devices. <br /> <br /> *More information:* <!-- TODO --> <br /> <br /> *Relevant settings:* <br /> - [Parallel Port IRQ (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/parallel_port_setup) <br /> - [Serial Port Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/serial_port_setup) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ITC| $2 Imaging Technology Center. <br /> Lenovo's Cloud Deployment solutions. <br /> *More information:* <br />  - [More information at lenovoclouddeploy.com](https://www.lenovoclouddeploy.com/en/auth/welcome) <br>  - [More information at Lenovo.com](https://static.lenovo.com/na/services/pdfs/4390_Cloud_Imaging_Flyer_FINAL_High_Res.pdf) <br /> *Relevant settings:* <br /> - [Lenovo Cloud Services (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
|  | $2 Lenovo Diagnostics. <br /> Tool for testing Lenovo computers. Composed from Modules (diagnostics for a group of devices), Tools for creating custom diagnostic scripts, system information, and Log History. <br /> *More information:* <br />  - ["Lenovo Diagnostics for Windows" at Lenovo PC Support](https://pcsupport.lenovo.com/us/en/downloads/ds102687) <br /> *Relevant settings:* <br /> - [Intel® Total Memory Encryption (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/memoryprotection) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Magic packet. <br /> Network packet specific to the network card, used in the Wake On LAN feature. <br /> *More information:* <br />  <br /> *Relevant settings:* <br /> - [Wake On Lan (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| (M)HDP | $2 (Master) Hard Disk Password. <br /> <br /> *More information:* <!-- TODO --> <br /> <br /> *Relevant settings:* <br /> - [Hard Disk Password (ThinkStation)](https://docs.lenovocdrt.com/#/bios/settings/thinkstation/hard_disk_password.md) <br />| $3 Admin (hard disk) password. | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Microsoft 3rd Party UEFI CA <br /> <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MDT| $2 Microsoft Deployment Toolkit <br /> <br /> *More information:*  - [More information at Microsoft.com](https://docs.microsoft.com/en-us/mem/configmgr/mdt/) <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MEBx| $2  Intel® Management Engine BIOS Extension. <br /> A BIOS menu extension on the Intel® AMT system that can be used to view and manually configure some of Intel® AMT settings. <br /> *More information:* <br />  - [More information at Intel.com](https://www.intel.com/content/dam/support/us/en/documents/software/software-applications/Intel_SCS_Deployment_Guide.pdf) <br /> *Relevant settings:* <br /> - [Intel® MEBx (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/intel_r_manageability) <br />| $3 | $4 AMT | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ME (firmware)| $2 <br /> Intel ® Management Engine. <br /> An embedded microcontroller providing features including OOB (out of band) management. <br /><br /> *More information:* <br />  - [More information at Intel.com](https://www.intel.com/content/www/us/en/support/articles/000008927/software/chipset-software.html) <br /> *Relevant settings:* <br /> [Enhanced Power Saving Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/power) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| memtest86 | $2 Commonly used memory (RAM) testing application. <br /> <br /> *More information:* <br />  - [More information at memtest86.com](https://www.memtest86.com/) <br /> <br /> *Relevant settings:* <br /> - [Intel(R) Total Memory Encryption (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/memoryprotection) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MFG mode | $2 Manufacturing Mode <br /> <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /> - [Security Chip (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) <br />| $3 | $4 | $5 |

<!-- | Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| motherboard silkscreen | $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 | -->

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NFC| $2 Near-Field Communication. <br /> <!-- TODO --> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [NFC Device (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/ioportaccess) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NIC| $2 Network Interface Controller / Card. <br />  <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /> - [MAC Address Pass Through (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br /> <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NVMe| $2 NVM Express or Non-Volatile Memory Host Controller Interface Specification is an open, logical-device interface specification for accessing a computer's non-volatile storage media usually attached via PCI Express bus. <br />  <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [NVMe1 Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) <br /> [Network Boot (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ODM| $2 Original Design Manufacturer <br /> <br /> *More information:* <br />  - ["Lenovo CSP Is For You!" at Lenovo YouTube](https://www.youtube.com/watch?v=2dFgkv2OQ5Y) <br/>  - ["Lenovo's Secret Recipe For Hyperscale Success Is Called ODM+" at Forbes.com](https://www.forbes.com/sites/patrickmoorhead/2018/10/22/lenovos-secret-recipe-for-hyperscale-success-is-called-odm/) <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| OEM| $2 Original Equipment Manufacturer  <br /> <br /> A company that manufactures products that it has designed from purchased components and sells those products under the company's brand name.
 <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| OOB | $2 Out-of-band. <br /> As in Out-of-band management. <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 ME | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
|  | $2 Optane <br /> <br /> *More information:* <br />  - ["Intel® Optane™ Memory - Responsive Memory, Accelerated Performance"at Lenovo.com](https://www.intel.com/content/www/us/en/products/details/memory-storage/optane-memory.html) <br /> *Relevant settings:* <br />  - [ATA Drive Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| OSD| $2 Operating System Deployment <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PAP| $2 supervisor password (?) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Require SVP when Flashing (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) <br /> - [Set Supervisor Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) <br />| $3 | $4 | $5 |

<!-- | Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Password Mode <br /> As opposed to Certificate Mode. <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 | -->

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PCR1 | $2 A Platform Configuration Register (PCR) is a memory location in the TPM, for storing security metrics. <br /> <br /> *More information:* <!-- TODO --> <br /> <br /> *Relevant settings:*  <br /> - [Security Chip (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) <br />| $3 | $4 Trusted Platform Module (TPM) | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PEAP| $2 Protected / Lightweight Extensible Authentication Protocol <!-- TODO: PEAP, LEAP or SEAP? --> <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Network (ThinkPad)]() <br />| $3 | $4 EAP, LEAP | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PK | $2 Platform key <br />  The public key used in Secure Boot.<br /> *More information:* <br />  - ["Key Management" at Lenovo CDRT](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot?id=key-management) <br /> *Relevant settings:* <br /> - [Enter Audit Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot?id=enter-audit-mode) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Platform <br /> A specific combination of hardware and software. <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:*<br /> - [Intel (R) SIPP Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/advanced) <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| POP| $2 Power On Password <br /> Allows the computer to power on directly to a password prompt but go no further until the correct password is entered. <br /> *More information:* <br /> - [BIOS Guide](https://docs.lenovocdrt.com/#/bios/bios_guide) <br /> *Relevant settings:* - [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| POST| $2 Power On Self Test <br /> Process of testing and initializing memory, devices, and (depending on model) software required by OS, immediately after power on and before OS is loaded. <br /> *More information:* <br /> <!-- TODO --> <br /> *Relevant settings:* <br /> - [Password Count Exceeded Error (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) <br /> - [USB Enumeration Delay (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/usb_setup) | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Predesktop| $2 <!-- TODO --> <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PXE| $2 Preboot eXecution Environment <br /> Method for booting computers using a network interface, independent of local storage devices or installed operating systems. <br /> *More information:* <br />  - ["Preboot Execution Environment (PXE)" at Microsoft.com](https://learn.microsoft.com/en-us/previous-versions/ms818762(v=msdn.10)) <br /> *Relevant settings:* <br /> - [Network Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) <br /> - [Network Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) <br/> - [Network Boot (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup)  | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| RAID| $2 Redundant Array of Independent Disks <br /> A standard configuration of multiple, redundant hard disks into logical units for scale and reliability. <br /> *More information:* <br />  - ["Common RAID Disk Data Format (DDF)" at Storage Networking Industry Association](https://www.snia.org/tech_activities/standards/curr_standards/ddf) <br /> *Relevant settings:* <br /> - [ATA Drive Setup(ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| RST| $2 Rapid Storage Technology <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Configure SATA As (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) <br />| $3 | $4 RAID, Optane | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SATA| $2 Serial AT ("Advanced Technology") Attachment <br /> Standard interface between computer bus and storage devices. <br /> *More information:* <br />  - ["Developers Can Trust Intel Leadership in Serial ATA" at Intel.com](https://www.intel.com/content/www/us/en/io/serial-ata/serial-ata-developer.html) <br /> *Relevant settings:* <br /> - [ATA Drive Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) <br /> - [Startup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/startup) | $3 | $4 ATA, PATA | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| (SC)CM| $2 Configuration Manager or System Center Configuration Manager <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Security Chip <br /> A type of Trusted Platform Module (TPM) implemented as a separate chip. <br />  and here https://docs.microsoft.com/en-us/windows/security/information-protection/tpm/trusted-platform-module-top-node  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 Trusted Platform Module (TPM) | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SEL| $2 System Event Log <br /> <br /> *More information:* <br /> <!-- TODO: --> <br /> *Relevant settings:* <br /> - [System Event Log (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/system_event_log) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Setup mode| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /> - [Secure Boot Mode (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SGX | $2  Intel® Software Guard Extensions <br /> Protect selected code and data from modification, by partitioning applications into hardened enclaves or trusted execution modules. <br /> *More information:* <br />  - ["Intel® Software Guard Extensions" at Intel.com](https://www.intel.com/content/www/us/en/developer/tools/software-guard-extensions/overview.html) <br /> *Relevant settings:* <br /> <!-- TODO: --> <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SID | $2 Security Identifier <br />  <br /> *More information:* <br /> <!-- TODO: --> <br /> *Relevant settings:* <br /> - [Block SID Authentication (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) <br /> - [Block SID Authentication (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SIPP| $2 Intel® Stable Image Platform Program <br /> Validation program that aims for no hardware changes throughout the buying cycle, for at least 15 months or until the next generational release. <br /> *More information:* <br />  - ["PC Upgrade: Intel® SIPP" at Intel.com](https://www.intel.com/content/www/us/en/architecture-and-technology/stable-it-platform-program.html) <br /> *Relevant settings:* <br /> - [Intel (R) SIPP Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/advanced) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SMP| $2 System Management Password <br /> Administrator password mid-way between the Supervisor Password (SVP) and a user password. Can be configured to have the same permissions as the SVP.<br /> *More information:* <br /> <br /> *Relevant settings:*  <br /> - [System Management Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security)  <br /> - [System Management Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SMBIOS | $2 System Management BIOS <br /> Specification for integration of BIOS information into operating systems and higher-level management applications. <br /> *More information:* <br />  - ["System Management Bios Reference Specification Eases Implementation for Managed PCs" at Intel.com](https://newsroom.intel.com/news-releases/system-management-bios-reference-specification-eases-implementation-for-managed-pcs/)  - ["System Management BIOS" at DMTF.org](https://www.dmtf.org/standards/smbios) <br /> *Relevant settings:*  <br /> - [BIOS Reporting (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SRSETUP| $2 DOS application to allow ThinkPad Setup settings to be common to all machines and to be controlled remotely. <br /> <br /> *More information:*  - ["ThinkPad Setup Settings Capture/Playback Utility (SRSETUP) for UEFI - ThinkPad" at Lenovo Support](https://support.lenovo.com/us/en/downloads/ds112377-thinkpad-setup-settings-captureplayback-utility-srsetup-for-uefi-thinkpad)| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SR TOOL| $2  <br /> <!-- TODO: --> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SSD password | $2 SSD Hard Disk Password <br /> <!-- TODO: --> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| | $2 Sticky Key <br /> When a modifier key (such as shift, CTRL, ALT) remains active until another key is pressed. <br /> *More information:* <br /> <!-- TODO: --> <br /> *Relevant settings:*  <br /> - [Fn Sticky Key (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/keyboardmouse) <br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SVP | $2 Supervisor Password <br /> <br /> *More information:* <br /> <br /> *Relevant settings:*   <br /> - [Device Guard Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/deviceguard) <br /> - [Supervisor Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) <br /> <br /> - [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) <br /> | $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| System Deployment Boot Mode (SDBM)| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Sx states| $2 system power states https://docs.microsoft.com/en-us/windows/win32/power/system-power-states  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TBCT| $2 Think BIOS Config Tool <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TCG| $2 Trusted Computing Group https://trustedcomputinggroup.org/  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TME| $2 Total Memory Encryption <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TPM| $2 Trusted Platform Module <br><br> A secure cryptoprocessor, which is either logically or physically separate from the main chipset, and used for security functions. <br> | $2  *More information:* <br />  - ["Lenovo Trusted Platform Module (TPM) FAQ" at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht512598) <br />  - ["Trusted Platform Module" at Microsoft.com](https://learn.microsoft.com/en-us/windows/security/information-protection/tpm/trusted-platform-module-top-node) <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TSME| $2 Transparent Secure Memory Encryption  <br /> <br /> *More information:*  <br /> - [White paper at AMD.com](https://www.amd.com/system/files/documents/amd-memory-guard-white-paper.pdf) <br /> <br /> *Relevant settings:* <br /><br />| $3 AMD Memory Guard | $4 SATA | $5 asdfasdf |
| TrackPad| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| TrackPoint| $2 <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| UEFI| $2 Unified Extensible Firmware Interface <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| UMI| $2 Unified Memory Architecture <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| UNDI| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| USB| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| User mode| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Vantage| $2 AKA Lenovo Vantage, see also https://support.lenovo.com/us/en/solutions/ht505081-lenovo-vantage-using-your-pc-just-got-easier and https://www.lenovo.com/us/en/software/vantage <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| VDI| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| VMM| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Wireless Certified Information| $2 <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| WMI| $2 Windows Management Interface <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |



<!-- | Certificate Mode| $2 (see Password(less?) Mode) use a x509 certificate instead of SVP and SMP. Devin Mcdermott prepared this description but so far it has not been published: BIOS certificate-based features.docx <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

 -->