# Appendix A: Configuring the Provisioning Data 

Complete the following steps to configure the provisioning data: 

1. On host (IT’s system), install AMD Provisioning Console tool using the executable file (for example, Provisioning_Console_setup-1.0.0.xxx-AMD.exe). 

2. Launch AMD Provisioning Console. 

3. Fill in the organization information. 

4. Select the location where you want to store the profiles: 
	<div style="text-align:center;"><img src="..\img\guides\aimt\profile_location.jpg"></div>

5. Fill in the contact information: 

	<div style="text-align:center;"><img src="..\img\guides\aimt\contact_information.jpg"></div>

6. Provide a **Package name**. 
   It will be a part of the provisioning package’s folder name. 

7. Create a new Crypto and select it from the **Crypto store** drop-down: 
	<div style="text-align:center;"><img src="..\img\guides\aimt\crypto_store.jpg"></div>

8. Add two users (one standard and one admin) without changing the **Roles** configuration: 
	
	<div style="text-align:center;"><img src="..\img\guides\aimt\adding_users.jpg"></div>

9. Add one Wi-Fi access point, this setting is required for AIM-T in system shutdown mode: 

	<div style="text-align:center;"><img src="..\img\guides\aimt\adding_wi-fi_access_point.jpg"></div>

10. Use the default port number (664) for **Secure port**: 
	<div style="text-align:center;"><img src="..\img\guides\aimt\secure_port.jpg"></div>

    
11. Generate a TLS certificate: 
	<div style="text-align:center;"> <img src="..\img\guides\aimt\tls_certificate.jpg"> </div>


12. Generate a KVM key: 
    <div style="text-align:center;"><img src="..\img\guides\aimt\kvm_key.jpg"></div> 

13. All the supported DASH profiles enabled by default. If required, you can disable some of the profiles: 
    <div style="text-align:center;"><img src="..\img\guides\aimt\dash_profiles.jpg"></div> 

14. Alerts are not required: 
    <div style="text-align:center;"><img src="..\img\guides\aimt\alerts.jpg"></div>

15. Click the **Submit** button: 
    <div style="text-align:center;"><img src="..\img\guides\aimt\summary_and_result.jpg"></div>

    The provisioning package is generated. 

16. Copy the provisioning package (saved in the directory set in Step 4) to client (AIM-T system). 

17. On the client, launch a prompt command as an administrator and go to the package location. 

18. Type the command AIM-TProvisioningApp.exe -i XXXX_oMt: 
    <div style="text-align:center;"><img src="..\img\guides\aimt\provisioning_command.jpg"></div>

19. If you generated a KVM key in Step12, copy the KVMSSHKey from the provisioning package (*<package path>\consolecertificates\KVMSSHKey*) to ```C:\Program Files (x86)\DASH CLI 4.0\certs\``` on host. 

20. Ensure that the owner of KVMSSHKey is same as the Windows local user with full control. When copying the KVMSSHKey, the owner of the file may change. You must check the owner before using the KVM: 
<div style="text-align:center;">
    <img src="..\img\guides\aimt\check_kvmsshkey_owner.jpg"></div>

