# Appendix E: Using KVM

When a OEM device supports KVM function, a host (IT’s system) can use DASHCLI startkvm command to initiate a KVM session to the AIM-T system: 
```
dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startkvm
```

Complete the following steps to establish a KVM session: 

1. Enable AIM-T and KVM function on AIM-T system’s BIOS setup menu. 

2. Ensure that the AIM-T system has been AIM-T provisioned (Appendix A). 

3. Place a copy of KVMSSHKey in *C:\Program Files (x86)\DASH CLI 4.0\certs\,* where you execute DASHCLI commands on host (Appendix A). 

4. Boot AIM-T system to OS. 

5. Run one of the following DASH commands on the host: 

   ```
   dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startkvm 
   ```

   **or** 

   ```
   dashcli.exe -h <ipaddress> -u <username> -P <password> -S https -C -p 664 -t kvmredirection[0] startoskvm 
   ```

	For more information, refer to Figure DASH CLI – KVM Output. 
	
6. If the step 3 was executed correctly, a VNC viewer will be launched on host. 

7. If the graphics driver installed on the AIM-T system supports instant KVM, go to step 8 for OS KVM. Otherwise, the system will auto-reboot and go to step 10 for BIOS KVM. 

8. Host can see the client’s screen on VNC viewer called OS KVM: 

   <div style="text-align:center;"><img src="..\img\guides\aimt\amd_kvm_viewer.jpg" style="zoom:80%;"></div>


9. To trigger the BIOS KVM, configure the VNC viewer to restart the client in Windows power option. 

10. After reboot, the AIM-T system will stop at F1/F2 window. The same screen is displayed on the VNC viewer. F1 is selected by default; it is to continue to OS and F2 is to boot to BIOS. 

	?>OEM may change the definition of F1/F2 or replace it with other keys.

11. Based on the F1/F2 configuration in the previous step, press F1 on the VNC Viewer. The AIM-T system will boot to OS and OS KVM will be established. 

	?>If you press F2, the client will boot to BIOS setup menu (BIOS KVM). 

12. Ensure that BIOS menu navigation is possible using keyboard and mouse from the VNC viewer. 

13. If required, modify the BIOS settings using VNC viewer and save them. 

14. The AIM-T system should auto-reboot while exiting the BIOS setup menu. Check if the changes made in the previous step are reflected correctly. 

15. Close the VNC viewer to finish the KVM session and select **Yes** to reboot the AIM-T system again. 

	?>If you select **No**, the AIM-T system will not restart.