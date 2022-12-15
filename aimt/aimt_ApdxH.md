# Appendix H: Updating BIOS Capsule 

An enterprise IT admin is allowed to force a AIM-T system for performing a BIOS capsule update with DASH commands. However, the IT must setup a download server for AIM-T systems to download the latest valid capsule that can be recognized and installed by Windows OS. The AMS installed on AIM-T systems utilizes an inbox app *PnPutil.exe* in OS to install a BIOS capsule. DASH commands can ask a AIM-T system to download the capsule and then AMS will run *PnPutil.exe* to install the capsule. 

## Setting up a Download Server 

AMD provides the tool AMD Management Console (AMC -[ ](https://developer.amd.com/tools-for-dmtf-dash/)[*https://developer.amd.com/tools*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*for*](https://developer.amd.com/tools-for-dmtf-dash/)[*dmtf*](https://developer.amd.com/tools-for-dmtf-dash/)[*-*](https://developer.amd.com/tools-for-dmtf-dash/)[*dash/*](https://developer.amd.com/tools-for-dmtf-dash/)[)](https://developer.amd.com/tools-for-dmtf-dash/) to send DASH commands with a user-friendly interface. When installing AMC, the installer will simulate a virtual webserver with the network port 3274 (by default) and create a folder “*C:\AMC-ISO*” to act as the download space. 

<div style="text-align:center;"><img src="..\img\guides\aimt\amc_port_selection.jpg"></div>


After AMC is installed, you can place any file in the folder *C:\AMC-ISO* and type-in *http://<IP>:3274* in web browser to test it: 

<div style="text-align:center;"><img src="..\img\guides\aimt\testing_amc.jpg"></div>

?>The network port 3274 may be blocked by the firewall, an IT admin must give permission to allow the traffic through this port.

## Preparing a Valid Capsule 

An enterprise IT should be able to download a BIOS capsule from the OEM’s website (or other channels). A valid capsule includes: 

+ *.bin* or *.cap* file – the new firmware 

+ *.cer* file – the certificate 

+ *.cat* file – the driver catalog 

+ *.inf* file – the driver information 

You can launch a command prompt as admin and execute the following command to trigger the capsule installation: 

```
PnPutil.exe /add-driver xxx.inf /install 
```

If the installation is successful, it means the capsule is valid: 

<div style="text-align:center;"><img src="..\img\guides\aimt\valid_capsule.jpg"></div>

## Reforming the Capsule 

After verifying the content of a BIOS capsule, reform the capsule to an AMS readable format as follows: 

1. Create a folder **Capsule**. 

2. Copy all the files from the valid capsule and paste them to the new folder *\Capsule*. 

3. Zip *\Capsule* into *capsule.zip.* 

4. Put *capsule.zip* in *C:\AMC-ISO.* 


## DASH Command for Capsule Update 

```
dashcli -h <ipaddress> -p 664 -S https -C -u <username> -P <password>
software[0] install <URL for Capsule> 
```

<div style="text-align:center;"><img src="..\img\guides\aimt\capsule_update.jpg"> </div> 