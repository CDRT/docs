# Appendix C: Un-provisioning 

Complete the following steps to un-provision: 

1. Ensure that the AIM-T system has enabled AIM-T and is provisioned. You can send some DASH commands in Appendix D to ensure that DASH is working with its username/password. 

2. Send a special DASH command to the AIM-T system: 

   ```
   dashcli.exe -S https -h <ipaddress> -p 664 -u <username> -P <password>
    -C raw ei AMD_ProvisioningService 
   ```

3. Copy TOTPToken: 

   <div style="text-align:center;"><img src="..\img\guides\aimt\totptoken.jpg"></div>

4. There is a 180 second timeout for the second command for un-provisioning: 

```
dashcli.exe -S https -h <ipaddress> -p 664 -u <username> -P <password> -C raw
im http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/AMD_ProvisioningService?
Name="ProvisioningService:0", TOTPToken="<TOTPToken>" 
RequestStateChange "RequestedState=32771"    
```

?>If it has passed 180 seconds but you have not run the second command, you can just go back to Step 1.