# 3 User Scenario

## 3.1 AIM-T in OS

### 3.1.1 Prerequisites 

+ Client (AIM-T system) has AMS installed and provisioned 
+ Host (IT admin’s console system) has DASHCLI installed 
+ Host can ping client’s IP 

### 3.1.2     Expected Behavior 

When a client user is working on a AIM-T system, an enterprise IT can send DASH commands (Appendix D) to the client and fetch system’s software and hardware information back silently. Some DASH commands can force the AIM-T system to shut down or reboot. In that case, the client user will observe system graceful shutdown, hard shutdown, or reboot without any notification. Also, the enterprise IT can force a AIM-T system to do BIOS capsule update with a special DASH command and process (Appendix H). 

Moreover, the IT can request the client to establish a KVM (Appendix E) session. In OS, IT can start an OS KVM in which a VNC viewer will pop-up immediately and show AIM-T system’s screen. The other option is that IT sends a BIOS KVM command through DASH to request the AIM-T system restart and enter BIOS setup menu. When the client enters BIOS menu, the VNC viewer on host system should display the same screen. 

?>A user can terminate KVM session by closing VNC viewer. The safe way to shut down a AIM-T system is to close the VNC viewer and send a DASH command to shut the AIM-T system down (Appendix D).

### 3.1.3 Graceful Shutdown 

After a user triggers graceful shutdown in OS power menu on a AIM-T system having a power adaptor attached, the system will shut down and restart AIM-T. Thirty seconds later, the system will have AIM-T capability to process DASH commands and KVM session request. For more information, refer to section 3.2. 

## 3.2 AIM-T in Shutdown Mode 

### 3.2.1 Prerequisites 

+ AIM-T function needs to be enabled in BIOS setup menu on the AIM-T system 
+ The AIM-T system must be AIM-T provisioned 
+ Power adaptor must be attached 

### 3.2.2 Expected Behavior 

When AIM-T is working in shutdown mode on a AIM-T system, there is no display. However, the power LED may blink and fan spin occasionally depending on the OEM’s design and Wi-Fi AP’s behavior. Normally, when a client user shuts the system down through OS, the power LED and fan should turn off for 40 seconds. Then, the power LED and fan turn off again. After that, a host (IT’s system) can send DASH commands (Appendix D) to the AIM-T system which will wake up with power LED on, fan spinning, and it will take 60 seconds to be prepared for the incoming DASH commands. Some DASH commands can force the AIM-T systems boot to OS. When there is no more DASH command in the queue for 3 minutes, the system will shutdown. Same as AIM-T in OS mode, AIM-T supports KVM function in shutdown mode. The KVM (Appendix E) session request sent from IT will trigger the system restart and establish a KVM connection. 

### 3.2.3 Pressing Power Button 

In the shutdown mode, regardless of power LED is on or off, a client user can boot the system to OS by pressing a power button. 

?>When the power LED turns on, a AIM-T system may not be ready for handling the power button event for the first 30 seconds. User should press the power button after 30 seconds of power LED turning on.

### 3.2.4 Detaching Power Adaptor 

Power adaptor attachment is one of the requirements for AIM-T in shutdown mode. Removing power adaptor will force the system turn AIM-T off during shutdown mode.
