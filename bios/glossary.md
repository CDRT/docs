# Glossary of Terms #
---

### Administrator (hard disk) Password
Hard disk password, available if `Dual Password` is enabled.
- ThinkPad: Admin + User password
- ThinkCentre & Thinkstation: Master + User passwords.

Admin and Master are synonyms.

*More information:*
- ["Types of password for ThinkPad" at Lenovo Support](https://support.lenovo.com/lt/en/solutions/ht036206-types-of-password-for-thinkpad)
- ["Types of Passwords for ThinkCentre, ThinkStation" at Lenovo Support](https://support.lenovo.com/lt/en/solutions/ht513634) 
- [BIOS Security Settings](https://docs.lenovocdrt.com/#/bios/bios_guide?id=bios-security-settings)

*Relevant settings:*
- [Hard Disk Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password)
- [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) 
- [NVMe1 Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) 

*AKA*

*See also:*

---

### AHC 

  Advanced Host Controller Interface 
 
 *More information:* 
 - ["Serial ATA AHCI: Specification" at Intel.com](https://www.intel.com/content/www/us/en/io/serial-ata/serial-ata-ahci-spec-rev1-3-1.html) 
 
 *Relevant settings:* 
 - [Configure SATA As (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 

*See also:*

RAID

---

### AMT 

  Intel ® Active Management Technology. 
 
 Remote management solution from Intel ®. 
 
*More information:* 
 - ["Intel® Active Management Technology" at Intel.com](https://www.intel.com/content/www/us/en/architecture-and-technology/intel-active-management-technology.html) 

 *Relevant settings:* 
 - [Intel® Manageability (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/intel_r_manageability) 
 - [Intel® AMT Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/intelramt) 
 - [Onboard Ethernet Controller (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) 
  

---

### ASPM 

  Active State Power Management 
 
 *More information:* 
 
 *Relevant settings:* 

 - [ASPM Support](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/pci_express_configuration) 



---

### ATA 

  Advanced Technology Attachment (Hard Disk Drive)

 A hard disk drive with an integrated controller. Usually implemented as a serial drive (SATA).
 
 *More information:* 
 
 *Relevant settings:* 
 - [SATA Controller](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 
 - [SATA Drive {Number} Password](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) 
 - [First Boot Device](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) 



*See also:*

IDE, SATA, PATA

---

### Audit mode


 Enables programmatic discovery of signature list combinations that successfully authenticate installed EFI images without the risk of rendering a system unbootable. Chosen signature lists configurations can be tested to ensure the system will continue to boot after the system is transitioned out of Audit Mode.
 
 *More information:* 
 - [UEFI Specification Version 2.9 (March 2021) at UEFI.org](https://uefi.org/sites/default/files/resources/UEFI_Spec_2_9_2021_03_18.pdf) 

 *Relevant settings:* 
 - [Enter Audit Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot?id=enter-audit-mode) 


*See also:*

Custom mode 

---

### BIOS 


  Basic Input/Output System (overrides user OS permissions to access settings in all cases; has no access to OS settings) 
 
 *More information:* 
  - ["What Is BIOS?" at Lenovo Support](https://support.lenovo.com/lt/en/videos/vid100790-what-is-bios) 
 
 *Relevant settings:* 



*See also:*

UEFI

---

### BIOS Self-healing 

 BIOS is programmed to restore the machine to its previous state through an uncorrupted, secure backup. 


---

### CA 

  Certification Authority. 
 
 *More information:* 
  - ["Windows Secure Boot Key Creation and Management Guidance" at Microsoft.com](https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/windows-secure-boot-key-creation-and-management-guidance) 
 
 *Relevant settings:* 
 - [Allow Microsoft 3rd Party UEFI CA (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot) 
 - [TLS Auth Configuration (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) 



---

### C State


 Core Power States 
 
 A series of states numbered 0 to n, where each state represents lower power consumption. 
 
*More information:* 
 - ["C-State" at Intel.com](https://www.intel.com/content/www/us/en/develop/documentation/vtune-help/top/reference/energy-analysis-metrics-reference/c-state.html) 
 
*Relevant settings:* 
 - [C State Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/cpu_setup) 
 


---

### Custom Mode
 
  
  *More information:* <!--- TODO ---> 
  
  *Relevant settings:* 
  - [Secure Boot Key State](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot) 
 

---

### DASH 

  Desktop and mobile Architecture for System Hardware.  
 
 Secure out-of-band and remote client management standard. 
 
 *More information:* 
   - [DASH article at Lenovo CDRT](https://docs.lenovocdrt.com/#/dash/dash_top) 
  -  ["Desktop and Mobile Architecture for System Hardware" at DTMF.org](https://www.dmtf.org/standards/dash) 


---

### Deployed mode

<!-- (see System Deploy Mode) --> 
 
 *More information:* <!-- TODO --> 
 
 *Relevant settings:* 
- [Enter Deployed Mode (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot)


---

### DHCP 

  Dynamic Host Configuration Protocol 
 
 Network management protocol used on Internet Protocol (IP) networks for automatically assigning IP addresses and other communication parameters to devices connected to the network using a client-server architecture. 
 
 *More information:* 
 
 *Relevant settings:* 
 - [Lenovo Cloud Services (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 



---

### DPTF 

  Dynamic Platform and Thermal Framework 
 
 *More information:* <!-- TODO --> 
 
 *Relevant settings:* 



---

### DRAM 

  Dynamic Random-Access Memory 
 <!-- TODO --> 
 Random-access semiconductor memory that stores each bit of data in a memory cell, usually consisting of a tiny capacitor and a transistor, both typically based on metal-oxide-semiconductor technology. 
 
 *More information:* 
 
 *Relevant settings:* 


*See also:*

NVDIMM

---

### EAP 

  Extensible Authentication Protocol 

 Authentication framework supporting multiple authentication methods. 

 *More information:* 
 - ["Extensible Authentication Protocol (EAP)" at IETF.org](https://datatracker.ietf.org/doc/html/rfc3748) 
 - ["802.1X Overview and EAP Types" at Intel.com](https://www.intel.com/content/www/us/en/support/articles/000006999/wireless/legacy-intel-wireless-products.html) 

 *Relevant settings:* 
 - [EAP Authentication Method (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 


---

### EEPROM 

  Electrically Erasable Programmable Read-Only Memory 
 Non-volatile memory storing relatively small amounts of data by allowing individual bytes to be erased and reprogrammed. 
 
 *More information:* 
 
 <!-- TODO --> 
 
 *Relevant settings:* 
 - [MAC Address Pass Through (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 


---

### EFI 

   
 Used in the context of HTTPS Boot
 
 *More information:* 
 
 *Relevant settings:* 
 - [Delete HTTPs Boot Option from List (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup?id=delete-https-boot-option-from-list) 


*See also:*

UEFI 

---

### EIST 

  Enhanced Intel SpeedStep® Technology 
 
 Dynamically adjusts processor voltage and core frequency, to decrease average power consumption and heat production. 
 
  *More information:* 
 - ["Overview of Enhanced Intel SpeedStep® Technology for Intel® Processors"at Intel.com](https://www.intel.com/content/www/us/en/support/articles/000007073/processors.html) 

 *Relevant settings:* 
 - [EIST Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/cpu_setup)

---

### EPP 

  Enhanced Parallel Port 
 
 A high-speed bi-directional mode for non-printer peripherals. 
 
 *More information:* 
 
 *Relevant settings:* 
 - [Parallel Port Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/parallel_port_setup.md)


---

### Flash BIOS

  
   
   *More information:* 
   - ["How to update BIOS" at Intel.com](https://www.intel.com/content/www/us/en/gaming/resources/how-to-update-bios.html) 

   *Relevant settings:* 
   - ["How to update system BIOS - Windows" at Lenovo.com](https://support.lenovo.com/uu/en/solutions/ht500008-how-to-update-system-bios-windows) 
   - [Flash BIOS Updating by End-Users (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/uefibiosupdate.md) 
  

---

###  Form Factor

 
  
  The size and spatial design of the computer and its individual components. Broadly similar or the same across a model line. 
  
  *More information:* 
  
  *Relevant settings:* 
 
 

---

### GPU 

   Graphics Processing Unit 
 
 *More information:* 
  - ["What Is a GPU?" at Intel.com](https://www.intel.com/content/www/us/en/products/docs/processors/what-is-a-gpu.html) 

 *Relevant settings:* 
 - [PCIe Tunneling (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/thunderbolttm4.md) 

*See also:*

UMA

---

### HDD 

  Hard Disk Drive 
 
 *More information:* 
 - ["Laptop Hard Drives, SSD & Storage" at Lenovo.com](https://www.lenovo.com/us/en/faqs/laptop-faqs/hard-drives-ssd-guide/) 
 
 *Relevant settings:* 
 - [First Boot Device (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/startup.md) 
 - [Boot Priority Order (THinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup.md) 


---

### HDP 

  Hard Disk Password 
 
 Prevents unauthorized access to the data on the storage drive. Some models may support dual passwords, with a user password and an administrator password. 
 
 *More information:* 

 <!-- TODO --> 

 *Relevant settings:* 
 - [Require HDP on System Boot (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) 
 - [Hard Disk Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) 
 

---

### IOMMU 

   Input-Output Memory Management Unit.
 
 Hardware assisted address translation from I/O device virtual addresses to physical addresses, to improve the system performance in virtual environments. 
 
 *More information:* 
 - [More information at Lenovo.com](https://lenovopress.lenovo.com/lp1467.pdf) 
 
 *Relevant settings:* 
 - [Device Guard (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) 
 - [Device Guard (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/deviceguard) 


---

### IRQ 

  Interrupt Request Line. 
 
 Hardware line allowing devices to take over processor resources for their function. IRQs are assigned numbers to prioritize devices. 
 
 *More information:* <!-- TODO --> 
 
 *Relevant settings:* 
 - [Parallel Port IRQ (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/parallel_port_setup) 
 - [Serial Port Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/serial_port_setup) 
 

---

### ITC 

  Imaging Technology Center. 
 Lenovo's Cloud Deployment solutions. 
 
 *More information:* 
  - [More information at lenovoclouddeploy.com](https://www.lenovoclouddeploy.com/en/auth/welcome) 
  - [More information at Lenovo.com](https://static.lenovo.com/na/services/pdfs/4390_Cloud_Imaging_Flyer_FINAL_High_Res.pdf) 
 
 *Relevant settings:* 
 - [Lenovo Cloud Services (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 


---

### Lenovo Diagnostics.
 
  Tool for testing Lenovo computers. Composed from Modules (diagnostics for a group of devices), Tools for creating custom diagnostic scripts, system information, and Log History. 

  *More information:* 
   - ["Lenovo Diagnostics for Windows" at Lenovo PC Support](https://pcsupport.lenovo.com/us/en/downloads/ds102687) 
  
  *Relevant settings:* 
  - [Intel® Total Memory Encryption (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/memoryprotection) 
 

---

### Magic Packet.


 Network packet specific to the network card, used in the Wake On LAN feature. 

 *More information:* 
  
 *Relevant settings:* 
 - [Wake On Lan (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 
  

---

### (M)HDP 

  (Master) Hard Disk Password. 

|  Admin (hard disk) password.

 *More information:*
 
 <!-- TODO --> 
 
 *Relevant settings:* 
 - [Hard Disk Password (ThinkStation)](https://docs.lenovocdrt.com/#/bios/settings/thinkstation/hard_disk_password.md) 

---

### Microsoft 3rd Party UEFI CA


 
 *More information:* 

 <!-- TODO --> 

 *Relevant settings:* 



---

### MDT 

  Microsoft Deployment Toolkit 
 
 *More information:*
 - [More information at Microsoft.com](https://docs.microsoft.com/en-us/mem/configmgr/mdt/) 
 
 *Relevant settings:* 



---

### MEBx 

   Intel® Management Engine BIOS Extension. 
 A BIOS menu extension on the Intel® AMT system that can be used to view and manually configure some of Intel® AMT settings. 

 *More information:* 
  - [More information at Intel.com](https://www.intel.com/content/dam/support/us/en/documents/software/software-applications/Intel_SCS_Deployment_Guide.pdf) 

 *Relevant settings:* 
 - [Intel® MEBx (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/intel_r_manageability) 


*See also:*

AMT 

---

### ME 

  
 Intel ® Management Engine. 
 An embedded microcontroller providing features including OOB (out of band) management. 

 *More information:* 
 - [More information at Intel.com](https://www.intel.com/content/www/us/en/support/articles/000008927/software/chipset-software.html) 

 *Relevant settings:* 
 - [Enhanced Power Saving Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/power) 


---

### memtest86 

  Commonly used memory (RAM) testing application. 
 
 *More information:* 
  - [More information at memtest86.com](https://www.memtest86.com/) 
 
 *Relevant settings:* 
 - [Intel(R) Total Memory Encryption (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/memoryprotection) 


---

### MFG (mode) 

  Manufacturing Mode 
 
 *More information:* 

 <!-- TODO --> 

 *Relevant settings:* 
 - [Security Chip (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) 


<!-- ---

### motherboard | silkscreen 

   
 
 *More information:* 
 
 *Relevant settings:* 

 -->

---

### NFC 

  Near-Field Communication. 
 <!-- TODO --> 

 *More information:* 
 
 *Relevant settings:* 
 - [NFC Device (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/ioportaccess) 


---

### NIC 

  Network Interface Controller / Card. 
  
 *More information:* 

 <!-- TODO --> 

 *Relevant settings:* 
 - [MAC Address Pass Through (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 
 


---

### NVMe 

  NVM Express or Non-Volatile Memory Host Controller Interface Specification is an open, logical-device interface specification for accessing a computer's non-volatile storage media usually attached via PCI Express bus. 
  
 *More information:* 
 
 *Relevant settings:* 
 - [NVMe1 Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) 
 - [Network Boot (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup) 


---

### ODM 

  Original Design Manufacturer 
 
 *More information:* 
  - ["Lenovo CSP Is For You!" at Lenovo YouTube](https://www.youtube.com/watch?v=2dFgkv2OQ5Y)   - ["Lenovo's Secret Recipe For Hyperscale Success Is Called ODM+" at Forbes.com](https://www.forbes.com/sites/patrickmoorhead/2018/10/22/lenovos-secret-recipe-for-hyperscale-success-is-called-odm/) 

 *Relevant settings:* 



---

### OEM 

  Original Equipment Manufacturer  
 
 A company that manufactures products that it has designed from purchased components and sells those products under the company's brand name. 
 
 *More information:* 
 
 *Relevant settings:* 



---

### OOB 

  Out-of-band. 

 As in Out-of-band management. 

 *More information:* 
 
 *Relevant settings:* 



*See also:*

ME

---

### Optane 


 
 *More information:* 
  - ["Intel® Optane™ Memory - Responsive Memory, Accelerated Performance"at Lenovo.com](https://www.intel.com/content/www/us/en/products/details/memory-storage/optane-memory.html) 

 *Relevant settings:* 
  - [ATA Drive Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 


---

### OSD 

  Operating System Deployment 
 
 *More information:* 
 
 *Relevant settings:* 



---

### PAP 

  supervisor password (?) 
 
 *More information:* 
 
 *Relevant settings:* 
 - [Require SVP when Flashing (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) 
 - [Set Supervisor Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) 


<!-- ---

### Password Mode 
 As opposed to Certificate Mode. 
 *More information:* 
 
 *Relevant settings:* 

 -->

---

### PCR 

  Platform Configuration Register (PCR) 
 A memory location in the TPM, for storing security metrics. 
 
 *More information:* <!-- TODO --> 
 
 *Relevant settings:*  
 - [Security Chip (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) 

*See also:*

Trusted Platform Module (TPM)

---

### PEAP / LEAP 

  Protected / Lightweight Extensible Authentication Protocol <!-- TODO: PEAP, LEAP or SEAP? --> 
 
 *More information:* 
 
 *Relevant settings:* 
 - [Network (ThinkPad)]() 

*See also:*

EAP, LEAP

---

### PK 

  Platform Key 
  The public key used in Secure Boot.

 *More information:* 
  - ["Key Management" at Lenovo CDRT](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot?id=key-management) 

 *Relevant settings:* 
 - [Enter Audit Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot?id=enter-audit-mode) 


---

### Platform

 
  A specific combination of hardware and software. 

  *More information:* 
  <!-- TODO --> 

  *Relevant settings:*
  - [Intel (R) SIPP Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/advanced) 
 
 

---

### POP 

  Power On Password 

 Allows the computer to power on directly to a password prompt but go no further until the correct password is entered. 
 
 *More information:* 
 - [BIOS Guide](https://docs.lenovocdrt.com/#/bios/bios_guide) 
 
 *Relevant settings:*
 - [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) 



---

### POST 

  Power On Self Test 

 Process of testing and initializing memory, devices, and (depending on model) software required by OS, immediately after power on and before OS is loaded. 
 
 *More information:* 

 <!-- TODO --> 

 *Relevant settings:* 
 - [Password Count Exceeded Error (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) 
 - [USB Enumeration Delay (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/usb_setup) 

---

### Predesktop

 <!-- TODO --> 
  
  *More information:* 
  
  *Relevant settings:* 
 
 

---

### PXE 

  Preboot eXecution Environment 

 Method for booting computers using a network interface, independent of local storage devices or installed operating systems. 
 
 *More information:* 
  - ["Preboot Execution Environment (PXE)" at Microsoft.com](https://learn.microsoft.com/en-us/previous-versions/ms818762(v=msdn.10)) 
 
 *Relevant settings:* 
 - [Network Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) 
 - [Network Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network)  - [Network Boot (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/startup)  

*See also:*

UNDI

---

### RAID 

  Redundant Array of Independent Disks 

 A standard configuration of multiple, redundant hard disks into logical units for scale and reliability. 
 
 *More information:* 
  - ["Common RAID Disk Data Format (DDF)" at Storage Networking Industry Association](https://www.snia.org/tech_activities/standards/curr_standards/ddf) 

 *Relevant settings:* 
 - [ATA Drive Setup(ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 


---

### RST 

  Rapid Storage Technology 
 
 *More information:* 
 
 *Relevant settings:* 
 - [Configure SATA As (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 


*See also:*

RAID, Optane 

---

### SATA 

  Serial AT ("Advanced Technology") Attachment 

 Standard interface between computer bus and storage devices. 

 *More information:* 
  - ["Developers Can Trust Intel Leadership in Serial ATA" at Intel.com](https://www.intel.com/content/www/us/en/io/serial-ata/serial-ata-developer.html) 

 *Relevant settings:* 
 - [ATA Drive Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/ata_drive_setup) 
 - [Startup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/startup) 

*See also:*

ATA, PATA

---

### (SC)CM 

  Configuration Manager or System Center Configuration Manager 
 
 *More information:* 
 
 *Relevant settings:* 



---

### SDBM 

  System Deployment Boot Mode 

 Enables programmatic configuration of key security BIOS settings during operating system deployments. 

 *More information:* 
  - ["System Deployment Boot Mode" at Lenovo CDRT](https://docs.lenovocdrt.com/#/bios/sdbm) 

 *Relevant settings:* 

---

### Security Chip
 
  A type of Trusted Platform Module (TPM) implemented as a separate chip. 
  
  *Relevant settings:* 
 
 - [Security Chip Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip.md)

 *See also:*
 
 Trusted Platform Module (TPM)

*AKA*

TPM

---

### SEL 

  System Event Log 
 
 *Relevant settings:* 
 - [System Event Log (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/system_event_log) 


---

### Setup mode

 Enables installation of Platform Key and customization of Secure Boot signature databases.
  
  *More information:* 
  
 - [More information at microsoft.com](https://learn.microsoft.com/en-us/powershell/module/secureboot/)

  *Relevant settings:* 
  - [Secure Boot Mode (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot) 
 

---

### SGX 

   Intel® Software Guard Extensions 

 Protect selected code and data from modification, by partitioning applications into hardened enclaves or trusted execution modules. 
 
 *More information:* 
  - ["Intel® Software Guard Extensions" at Intel.com](https://www.intel.com/content/www/us/en/developer/tools/software-guard-extensions/overview.html) 
 
---

### SID 

  Security Identifier

 *More information:* 
 - [More information at trustedcomputinggroup.org](https://trustedcomputinggroup.org/wp-content/uploads/TCG_Storage-Feature_Set_Block_SID_Authentication_v1.01_r1.00.pdf)

 *Relevant settings:* 
 - [Block SID Authentication (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password) 
 - [Block SID Authentication (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) 


---

### SIPP 

  Intel® Stable Image Platform Program 

 Validation program that aims for no hardware changes throughout the buying cycle, for at least 15 months or until the next generational release. 

 *More information:* 
  - ["PC Upgrade: Intel® SIPP" at Intel.com](https://www.intel.com/content/www/us/en/architecture-and-technology/stable-it-platform-program.html) 

 *Relevant settings:* 
 - [Intel (R) SIPP Support (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/advanced) 


---

### SMP 

  System Management Password 

 Administrator password mid-way between the Supervisor Password (SVP) and a user password. Can be configured to have the same permissions as the SVP. Can be set through the UEFI BIOS menu or through Windows Management Instrumentation (WMI) with the Lenovo
client-management interface.

 *More information:* 
  - [More information at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht036206-types-of-password-for-thinkpad)

 *Relevant settings:*  
 - [System Management Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security)  
 - [System Management Password (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password) 
 - [System Management Password Access Control (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/system_management_password_access_control.md)

---

### SMBIOS 

  System Management BIOS 
 
 Specification for integration of BIOS information into operating systems and higher-level management applications. 
 
 *More information:* 
  - ["System Management Bios Reference Specification Eases Implementation for Managed PCs" at Intel.com](https://newsroom.intel.com/news-releases/system-management-bios-reference-specification-eases-implementation-for-managed-pcs/)
  - ["System Management BIOS" at DMTF.org](https://www.dmtf.org/standards/smbios) 
 
 *Relevant settings:*  
 - [BIOS Reporting (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip) 
 
 *See also:*

 BIOS, UEFI

---

### SRSETUP 

  DOS application to allow ThinkPad Setup settings to be common to all machines and to be controlled remotely. 
 
 *More information:*
 - ["ThinkPad Setup Settings Capture/Playback Utility (SRSETUP) for UEFI - ThinkPad" at Lenovo Support](https://support.lenovo.com/us/en/downloads/ds112377-thinkpad-setup-settings-captureplayback-utility-srsetup-for-uefi-thinkpad)

---

### SR TOOL 
 IBM Service Request (SR) tool.

!> Replaced by Lenovo Online Service Request function.

 *More information:* 
 
 - [More information at Lenovo Support](https://support.lenovo.com/vn/en/solutions/ht511652)
  
---

### SSD (Solid State Disk) 
 
Storage solution based on collections of memory microchips. Faster, lighter, and more reliable than HDD, but less capacity at the same price.

 *More information:* 
 - ["Laptop Hard Drives, SSD & Storage" at Lenovo.com](https://www.lenovo.com/us/en/faqs/laptop-faqs/hard-drives-ssd-guide/) 

 *See also:*

HDD, HDP

---

### Sticky Key 
 When a modifier key (such as shift, CTRL, ALT) remains active until another key is pressed. 
 
 *More information:* 
 
 - [More information at Lenovo Support](https://pcsupport.lenovo.com/us/en/products/laptops-and-netbooks/thinkpad-p-series-laptops/thinkpad-p50/solutions/ht510960-function-keys-are-not-working)
 
 *Relevant settings:*  
 - [Fn Sticky Key (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/keyboardmouse) 


---

### SVP 

  Supervisor Password 

The Supervisor Password (SVP) protects the system information stored in UEFI BIOS.

 *More information:* 
 - [More information at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht036206-types-of-password-for-thinkpad)

 *Relevant settings:*   
 - [Device Guard Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/deviceguard) 
 - [Supervisor Password (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security) 
 - [Password Policies (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/password_policies) 
 
*See also:*

System Management Password (SMP)

---


### Sx states 

  System power states 
 
 *More information:* 
  - ["System Power States" at Microsoft.com](https://learn.microsoft.com/en-us/windows/win32/power/system-power-states) 

 *Relevant settings:* 
 - [Enhanced Power Saving Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/power) 
 


---

### TBCT 

  Think BIOS Config Tool 
 
 *More information:* 
  - ["Think BIOS Config Tool" at Lenovo CDRT](https://docs.lenovocdrt.com/#/tbct/tbct_top) 

---

### TCG 

  Trusted Computing Group 

 Standards body for secure computing. 

 *More information:* 
  - [More information at trustedcomputinggroup.org](https://trustedcomputinggroup.org/) 

 *Relevant settings:* 
 - [TCG Feature setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/tcg_feature_setup.md)
 - [Block SID Authentication (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/hard_disk_password.md)

*See also:*

TPM

---

### TME 

  Total Memory Encryption 
 
Encrypts a computer’s entire memory with a single transient key. All memory data passing to and from the CPU is encrypted.

 *More information:* 
 
 - ["Intel® Hardware Shield – Intel® Total Memory Encryption" at Lenovo Support](https://www.intel.com/content/dam/www/central-libraries/us/en/documents/white-paper-intel-tme.pdf)

 *Relevant settings:* 
  - [Intel(R) Total Memory Encryption (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/memoryprotection.md)


---

### TPM 

  Trusted Platform Module 
  
   A secure cryptoprocessor, which is either logically or physically separate from the main chipset, and used for security functions. 

*More information:* 
  - ["Lenovo Trusted Platform Module (TPM) FAQ" at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht512598) 
  - ["Trusted Platform Module" at Microsoft.com](https://learn.microsoft.com/en-us/windows/security/information-protection/tpm/trusted-platform-module-top-node) 
 
 *Relevant settings:* 
  - [TCG Security Device State (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/tcg_feature_setup.md)
  - [Security Chip (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip.md)

---

### TSME 
<!-- TODO -->
  Transparent Secure Memory Encryption  
 
 *More information:*  
 - [White paper (PDF) at AMD.com](https://www.amd.com/system/files/documents/amd-memory-guard-white-paper.pdf) 
 
 *Relevant settings:* 



*AKA*

AMD Memory Guard 

*See also:*

SATA 

---

### TrackPad

Touch-sensitive interface surface that allows you to manipulate and interact with your laptop computer through finger gestures.
  
  *More information:* 
   - ["Popular Topics: Keyboard, Mouse, Touchpad, TrackPad, TrackPoint" at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht503907) 

  *Relevant settings:* 
  - [Trackpad (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/keyboardmouse) 
  
 

---

### TrackPoint

Pointing device, controls the mouse pointer with a joystick mounted in the center of the keyboard.
  
  *More information:* 
   - ["Popular Topics: Keyboard, Mouse, Touchpad, TrackPad, TrackPoint" at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht503907) 

  *Relevant settings:* 
   - [TrackPoint (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/keyboardmouse) 
  
 *AKA*

Pointing stick

---

### UEFI 

  Unified Extensible Firmware Interface 
 
 UEFI specifications define an interface in which the implementation of UEFI performs the equivalent of the BIOS, by initiating the platform and loading the operating system. 
 
 *More information:* 
  - ["UEFI FAQS" at UEFI.org](https://uefi.org/faq) 
 
 *Relevant settings:* 
  - [UEFI BIOS Update Option Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/uefibiosupdate) 
  - [SMBIOS Reporting (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/securitychip.md)
  - [Lock UEFI BIOS Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/password.md)
  - [Windows UEFI Firmware Update (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security.md)
  - [Allow Microsoft 3rd Party UEFI CA (Think)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot.md)

*AKA*

BIOS, Firmware

*See also:*

BIOS 

---

### UMA 

  Unified Memory Architecture 
 
Architecture using part of RAM rather than dedicated graphics memory.

 *More information:* 
  - ["Configuring UMA Frame Buffer Size" at AMD.com](https://www.amd.com/en/support/kb/faq/pa-280) 

 *Relevant settings:* 
 - [Total Graphics Memory (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/display) 
 
*See also:*

GPU

---

### UNDI 

Universal Network Driver Interface 
 
API for network cards. 
 
 *More information:* 
 
 - ["UEFI Driver Development Guide for Network Boot Devices" at Intel.com](https://www.intel.com/content/dam/doc/guide/uefi-driver-network-boot-devices-guide.pdf)
  - ["UEFI Drivers" at Intel.com](https://www.intel.com/content/dam/develop/external/us/en/documents/uefi-drivers.ppt)

 *Relevant settings:* 
  
 - [Wireless LAN PXE boot (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) 
 
*See also:*

PXE

---

### USB 

Universal Serial Bus 
 
Connectivity specification that allows peripheral devices like scanners, printers, and memory sticks to be plugged into the computer and configured automatically. 
 
 *More information:* 
 
 - [USB Implementers Forum at USB.org](https://www.usb.org/)

 *Relevant settings:* 
 - [USB Provisioning (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/intel_r_manageability.md)
 - [Smart USB Protection (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/security.md)
 - [USB Setup (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/usb_setup.md)
 - [USB Key Provisioning (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/intelramt.md)
 - [USB Port (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/ioportaccess.md)
 - [PCIe Tunneling (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/thunderbolttm4.md)
 - [USB Settings (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/usb.md)
 
---

### User mode

 
  <!-- TODO: --> 
  *More information:* 
  
  *Relevant settings:* 
  - [System Mode (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/secure_boot) 
  - [Secure Boot Mode (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/secureboot) 
  
 

---

### Vantage (Lenovo)

User interface for changing hardware settings, checking for Lenovo software and driver updates, and more.

  *More information:* 
  - ["Commercial Vantage" at Lenovo CDRT](https://docs.lenovocdrt.com/#/cv/cv_top) 
  - [More information at Lenovo Support](https://support.lenovo.com/us/en/solutions/ht505081-lenovo-vantage-using-your-pc-just-got-easier)
   - [More information at Lenovo.com](https://www.lenovo.com/us/en/software/vantage)
 
---

### VDI 

  Windows Virtual Desktop 

 IT infrastructure that allows access enterprise computer systems from almost any device. 

 *More information:* 
 - [More information at Lenovo Support](https://azure.microsoft.com/en-us/resources/cloud-computing-dictionary/what-is-virtual-desktop-infrastructure-vdi/#what-is-virtualization) 
 
 *Relevant settings:* 
 - [Win VDI Boot (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup)
 - [Lenovo Cloud Services (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/network) 
 


---

### VMM 

Virtual Machine Monitor 
 
The code that creates, manages, and destroys virtualized hardware.
 
 *More information:* 
  - [More information at Lenovo Support](https://support.lenovo.com/de/en/solutions/ht500006)

 *Relevant settings:* 
  - [Intel (R) Virtualization Technology (ThinkPad)](https://docs.lenovocdrt.com/#/bios/settings/thinkpad/virtualization) 

 


---

<!-- ### Wireless Certified Information

 
  
  *More information:* 
  
  *Relevant settings:* 
   
  - [Wireless Certified Information (ThinkCentre)](https://docs.lenovocdrt.com/#/bios/settings/thinkcentre/network_setup) 
  
 

--- -->

### WMI 

Windows Management Instrumentation 
 
WMI is provided as a standard feature in most Windows® operating systems. It provides a powerful set of functions, such as query-based information retrieval and event notification, which enables users to manage both local and remote computers. The Lenovo BIOS WMI interface extends the capabilities of WMI to allow management of BIOS settings.
 
 *More information:* 

 - [Lenovo BIOS Windows Management Instrumentation Interface Deployment Guide For Desktop – Think Series Products (zip file with guide + scripts)](https://download.lenovo.com/pccbbs/thinkcentre_pdf/lenovo_desktop_bios_wmi_deployment_guide_revision_1.7.zip) 
 - [More information at Microsoft.com](https://learn.microsoft.com/en-us/windows/win32/wmisdk/wmi-start-page)




<!-- | Certificate Mode

  (see Password(less?) Mode) use a x509 certificate instead of SVP and SMP. Devin Mcdermott prepared this description but so far it has not been published: BIOS certificate-based features.docx 
 
 *More information:* 
 
 *Relevant settings:* 



 -->