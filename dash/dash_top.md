## Lenovo and AMD DASH Management <!-- {docsify-ignore} -->

# Overview

## What is DASH?

DASH (Desktop and mobile Architecture for System Hardware) is a secure out-of-band and remote client management standard. Out-of-band management tasks include powering a system on when it is powered off and obtaining asset and health information when the operating system is not available.

DASH was developed and released by the DMTF (Distributed Management Task Force). DASH profile specification source material can be found at: [DMTF - Management Profiles](http://www.dmtf.org/standards/profiles)

For more information refer to [DMTF - Desktop and Mobile Architecture for System Hardware](https://www.dmtf.org/standards/dash)

AMD Management Console can be downloaded here: [Tools for DMTF DASH](https://developer.amd.com/tools-for-dmtf-dash/) . It can be installed on any Windows workstation or Windows Server OS to use for monitoring and managing the client systems.

## System Requirements

DASH capable client computer systems require DASH be enabled and configured. These settings are not engaged by default. Equipment manufacturers provide the tools and processes to configure DASH. System administrators will need to verify the steps required for their specific hardware.

Operating Systems

- Windows 7 (32 and 64 bit)
- Windows 8 (32 and 64 bit)
- Windows 8.1 (32 and 64 bit)
- Windows Server 2008 R2 (64 bit)
- Windows Server 2012 (64 bit)
- Windows Server 2012 R2
- Windows Server 2016
- Windows Server 2019

**AMC** (AMD Management Console) requires a minimum of 1 GB Disk space and 4 GB RAM. It supports DASH 1.2.

**NOTE: If you have AMC already installed, you will first have to uninstall that version before installing the latest version of AMC.**

Lenovo AMD ThinkPad and ThinkCentre models support management via DASH and ethernet utilizing AMD Management Console, the DASH CLI, or the AMPS Management Plug-in for SCCM (more than 500 clients). These applications all use the Realtek DASH Controller.

The appropriate Realtek DASH Controller, along with all the latest drivers and firmware updates, can be found by searching for your system name or serial number at [https://pcsupport.lenovo.com](https://pcsupport.lenvo.com/).

1.
# Installation

## Installing AMC

This chapter provides the installation instructions and requirements for AMC.

  1.
### Installation Requirements

Use the _AMC-setup-[version]-AMD.exe_ to install AMC. Detailed instructions and release notes can be found in the installation directory, which by default is _C:\Program Files (x86)\AMD Management Console\docs_.

**Note:** If you have an old AMC version installed, you first must uninstall that version before installing the latest version of AMC.

  1.
### Authentication

When the AMC Console is launched the first time, you will be prompted to proceed to configuration. Alternatively, you can later access these settings via the **Configuration** tab in the upper right of the AMC Management Console.

The AMC console configuration supports up to three authentication entries. Each credential entry requires a unique Authentication Identifier and Schema. AMC has support for two types of authentication schemas: Digest and Active Directory.

At least one authentication entry must be configured before a client system can be discovered. If there is more than one credential, AMC will try each credential in sequential order.

For the changes to take effect, click **Validate** and then click **Save.**

1.
# Enabling DASH on client systems

DASH capable systems must first have DASH enabled in the BIOS. Next, the Windows software must be configured.

Prerequisites:

- DASH firmware enabled
- Windows DASH client software
- The latest DASH console tool, which can be found[here.](https://developer.amd.com/tools-for-dmtf-dash/)

**Note** : DashConfig, an AMD tool, is packaged with AMC and can be used for configuration. Refer the release notes of DASH Config tool or see [Provisioning tools for DASH standalone systems](https://community.amd.com/t5/amd-manageability-community-tkb/provisioning-tools-for-dash-standalone-systems/ta-p/420927)

Two different DashConfig tools are available: DashConfig for Broadcom and DashConfigRT for Realtek. Most all Lenovo systems will require the DASHConfigRT tool.

## DASH setup

  1.
### Enable DASH in BIOS