# Appendix B: Re-provisioning 

Complete the following steps to re-provision: 

1. Ensure that provisioning is done on the AIM-T system. 

2. Launch *AMD Provisioning Console*. 

3. Select the crypto key provisioned on the AIM-T system: 
   <div style="text-align:center;"><img src="..\img\guides\aimt\select_crypto_key.jpg"></div>

4. If you cannot see the original crypto key in Step 3 but you do have a copy of the key, copy it to ```Documents\AMD Provisioning Console\Cryptostore```. 
   <div style="text-align:center;"><img src="..\img\guides\aimt\copy_crypto_key.jpg"></div>

5. Redo the steps 2 and 3. 

6. Refer to Appendix A and generate a provisioning package with a new username/password or new Wi-Fi AP’s setting. 

7. Execute the command: 

   ```
   AIM-TProvisioningApp.exe -i XXXX_M 
   ```

   <div style="text-align:center;"><img src="..\img\guides\aimt\provisioning_command.jpg"></div>

8. If you re-generate a new KVM key, complete step 19 in Appendix A to copy the KVMSSHKey to DASHCLI’s *cert* folder.