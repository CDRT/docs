# Lenovo Deployment Assistant <br/>Companion Scripts

## PURPOSE
The companion scripts are part of the Lenovo Deployment Assistant application and are developed to simplify the Lenovo software configuration process using Microsoft Endpoint Configuration Manager.

## USING
The scripts were developed for [using from Microsoft Endpoint Configuration Manager](https://docs.microsoft.com/en-us/mem/configmgr/apps/deploy-use/create-deploy-scripts) with Run Script feature. 
You could run the script directly on the client machine using the PS console. 
However, it may require permissions of the administrator to run it.
All the scripts are signed by Lenovo sertificate. Undoubtedly, you could edit any script manually, but it is not recommended.
The exception is Configure Commertial Vantage script, where IT specialist have to uncomment blocks of the script to add values to the registry.

## MESSAGES
If the script executes from Microsoft Endpoint Configuration Manager it always returns 0 - Succeded.
The result of the work, errors and warnings that occurred during the execution of the script will be displayed as messages.
The messages could be of two types: *LDA_INFORMATION*  and *LDA_ERROR* and also annotated with timestamp.

You can see the result of the script execution for each device in the Script Status Monitoring window.

### Messages examples

Normal result of script execution:

<img src="lda/companion_scripts/Images/NormalScriptResult.png" alt="Normal result of the script" />


Additional information showed after script execution:

<img src="lda/companion_scripts/Images/AdditionalInformation.png" alt="Additional result of the script" />


Error message after script execution:

<img src="lda/companion_scripts/Images/ParameterErrorScriptResult.png" alt="Parameter error" />

## PARAMETERS
There are two types of parameters: optional and mandatory.

In the Run Script window mandatory parameters are markered by red cycle with exclamation symbol:

<img src="lda/companion_scripts/Images/MandatoryParameters.png" alt="Mandatory parameter" />


Despite the fact that the Run Script engine of the Microsoft Endpoint Configuration Manager has built-in validation of the parameters, it is not used. 
Instead of built-in validation, parameters validation is performed during script execution. 
Attentively read about script parameters in the documentation.

## REQUIREMENTS
* [Microsoft Endpoint Configuration Manager](https://docs.microsoft.com/en-us/mem/configmgr/) must be installed on the server machine.

## RELATED LINKS

[Create and run PowerShell scripts from the Configuration Manager console](https://docs.microsoft.com/en-us/mem/configmgr/apps/deploy-use/create-deploy-scripts)
[Microsoft Endpoint Configuration Manager Documentation](https://docs.microsoft.com/en-us/mem/configmgr/)
