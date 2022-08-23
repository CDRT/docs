# Glossary #

<!-- !> To find more details in the table below, scroll to the right. -->

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
| DASH| $2 Desktop and mobile Architecture for System Hardware.  <br /> <br /> Secure out-of-band and remote client management standard. <br /> <br /> *More information:* -  ["Desktop and Mobile Architecture for System Hardware" at DTMF.org](https://www.dmtf.org/standards/dash) <br /> | $3 | $4 | $5 |

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
| HDP| $2 Hard Disk Password <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Intel AMT| $2 https://en.wikipedia.org/wiki/Intel_Active_Management_Technology <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| IOMMU| $2 https://lenovopress.lenovo.com/lp1467.pdf <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| IRQ| $2 https://en.wikipedia.org/wiki/Interrupt_request_(PC_architecture) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ITC| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Lenovo Diagnostic-Memory test| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Magic packet| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Master hard disk password| $2 synonym to Admin (hard disk) password. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Microsoft 3rd Party UEFI CA| $2 clear meaning but needs some description / explanation! <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MDT| $2 Microsoft Deployment Toolkit <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MEBx| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ME (firmware)| $2 <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| memtest86| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| MFG mode| $2 manufacturing mode (?) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| motherboard silkscreen| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NFC| $2 near-field communication <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NIC| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| NVMe| $2 NVM Express or Non-Volatile Memory Host Controller Interface Specification is an open, logical-device interface specification for accessing a computer's non-volatile storage media usually attached via PCI Express bus. NVMe SSDs are about 3-4 times faster than SATA SSDs. <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| ODM| $2 original design manufacturer (???) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| OEM| $2 https://en.wikipedia.org/wiki/Original_equipment_manufacturer  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Optane mode| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| OSD| $2 Operating System Deployment <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PAP| $2 supervisor password (?) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Password Mode| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PCR1| $2 Platform Configuration Register (PCR) is a memory location in the TPM that has some unique properties. *More information:* https://docs.microsoft.com/en-us/windows/security/information-protection/tpm/switch-pcr-banks-on-tpm-2-0-devices  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PK| $2 platform key <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Platform| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| POP| $2 Power On Password <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| POST| $2 Power On Self Test <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Predesktop| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| PXE| $2 https://en.wikipedia.org/wiki/Preboot_Execution_Environment <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| RAID| $2 https://en.wikipedia.org/wiki/RAID <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| RST| $2 Rapid Storage Technology <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SATA| $2 Serial AT Attachment <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SCCM| $2 Configuration Manager or System Center Configuration Manager <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SEAP| $2 (see also EAP) <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Security Chip| $2 aka Trusted Platform Module (TPM). More information here: https://docs.microsoft.com/en-us/windows/security/information-protection/tpm/trusted-platform-module-overview and here https://docs.microsoft.com/en-us/windows/security/information-protection/tpm/trusted-platform-module-top-node  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SEL| $2 system event log <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Setup mode| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SGX| $2 https://en.wikipedia.org/wiki/Software_Guard_Extensions  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SID| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SIPP| $2 Stable Image Platform Program <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SMP| $2 System Management Password <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SMBIOS| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SRSETUP| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SR TOOL| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SSD password| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| Sticky Key| $2  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

| Acronym | Term | AKA | See also | asdf |
|---|---|---|---|---|
| SVP| $2 Supervisor Password <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

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
| TPM| $2 Trusted Platform Module| $2 https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/oem-tpm  <br /> <br /> *More information:* <br /> <br /> *Relevant settings:* <br /><br />| $3 | $4 | $5 |

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