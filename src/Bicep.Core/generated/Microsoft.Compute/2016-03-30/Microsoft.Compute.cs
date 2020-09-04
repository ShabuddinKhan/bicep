// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Compute_2016_03_30
    {
        private const string ProviderNamespace = "Microsoft.Compute";
        private const string ApiVersion = "2016-03-30";
        private static readonly ResourceTypeReference ResourceTypeReference_availabilitySets = new ResourceTypeReference(ProviderNamespace, new[]{"availabilitySets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_virtualMachines = new ResourceTypeReference(ProviderNamespace, new[]{"virtualMachines"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_virtualMachineScaleSets = new ResourceTypeReference(ProviderNamespace, new[]{"virtualMachineScaleSets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_virtualMachines_extensions = new ResourceTypeReference(ProviderNamespace, new[]{"virtualMachines", "extensions"}, ApiVersion);
        private static Lazy<Microsoft_Compute_2016_03_30> InstanceLazy = new Lazy<Microsoft_Compute_2016_03_30>(() => new Microsoft_Compute_2016_03_30());
        private Microsoft_Compute_2016_03_30()
        {
            AvailabilitySetProperties = new NamedObjectType("AvailabilitySetProperties", new ITypeProperty[]{new TypeProperty("platformUpdateDomainCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("platformFaultDomainCount", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("virtualMachines", () => new TypedArrayType(SubResource), TypePropertyFlags.None), new LazyTypeProperty("statuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.ReadOnly)}, null);
            SubResource = new NamedObjectType("SubResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            InstanceViewStatus = new NamedObjectType("InstanceViewStatus", new ITypeProperty[]{new TypeProperty("code", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("level", UnionType.Create(new StringLiteralType("'Info'"), new StringLiteralType("'Warning'"), new StringLiteralType("'Error'")), TypePropertyFlags.None), new TypeProperty("displayStatus", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("time", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualMachineExtensionProperties = new NamedObjectType("VirtualMachineExtensionProperties", new ITypeProperty[]{new TypeProperty("forceUpdateTag", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("typeHandlerVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("autoUpgradeMinorVersion", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("settings", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("protectedSettings", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("instanceView", () => VirtualMachineExtensionInstanceView, TypePropertyFlags.None)}, null);
            VirtualMachineExtensionInstanceView = new NamedObjectType("VirtualMachineExtensionInstanceView", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("typeHandlerVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("substatuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.None), new LazyTypeProperty("statuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.None)}, null);
            Plan = new NamedObjectType("Plan", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("product", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("promotionCode", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualMachineProperties = new NamedObjectType("VirtualMachineProperties", new ITypeProperty[]{new LazyTypeProperty("hardwareProfile", () => HardwareProfile, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => StorageProfile, TypePropertyFlags.None), new LazyTypeProperty("osProfile", () => OSProfile, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => NetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("diagnosticsProfile", () => DiagnosticsProfile, TypePropertyFlags.None), new LazyTypeProperty("availabilitySet", () => SubResource, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("instanceView", () => VirtualMachineInstanceView, TypePropertyFlags.ReadOnly), new TypeProperty("licenseType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vmId", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            HardwareProfile = new NamedObjectType("HardwareProfile", new ITypeProperty[]{new TypeProperty("vmSize", UnionType.Create(new StringLiteralType("'Basic_A0'"), new StringLiteralType("'Basic_A1'"), new StringLiteralType("'Basic_A2'"), new StringLiteralType("'Basic_A3'"), new StringLiteralType("'Basic_A4'"), new StringLiteralType("'Standard_A0'"), new StringLiteralType("'Standard_A1'"), new StringLiteralType("'Standard_A2'"), new StringLiteralType("'Standard_A3'"), new StringLiteralType("'Standard_A4'"), new StringLiteralType("'Standard_A5'"), new StringLiteralType("'Standard_A6'"), new StringLiteralType("'Standard_A7'"), new StringLiteralType("'Standard_A8'"), new StringLiteralType("'Standard_A9'"), new StringLiteralType("'Standard_A10'"), new StringLiteralType("'Standard_A11'"), new StringLiteralType("'Standard_D1'"), new StringLiteralType("'Standard_D2'"), new StringLiteralType("'Standard_D3'"), new StringLiteralType("'Standard_D4'"), new StringLiteralType("'Standard_D11'"), new StringLiteralType("'Standard_D12'"), new StringLiteralType("'Standard_D13'"), new StringLiteralType("'Standard_D14'"), new StringLiteralType("'Standard_D1_v2'"), new StringLiteralType("'Standard_D2_v2'"), new StringLiteralType("'Standard_D3_v2'"), new StringLiteralType("'Standard_D4_v2'"), new StringLiteralType("'Standard_D5_v2'"), new StringLiteralType("'Standard_D11_v2'"), new StringLiteralType("'Standard_D12_v2'"), new StringLiteralType("'Standard_D13_v2'"), new StringLiteralType("'Standard_D14_v2'"), new StringLiteralType("'Standard_D15_v2'"), new StringLiteralType("'Standard_DS1'"), new StringLiteralType("'Standard_DS2'"), new StringLiteralType("'Standard_DS3'"), new StringLiteralType("'Standard_DS4'"), new StringLiteralType("'Standard_DS11'"), new StringLiteralType("'Standard_DS12'"), new StringLiteralType("'Standard_DS13'"), new StringLiteralType("'Standard_DS14'"), new StringLiteralType("'Standard_DS1_v2'"), new StringLiteralType("'Standard_DS2_v2'"), new StringLiteralType("'Standard_DS3_v2'"), new StringLiteralType("'Standard_DS4_v2'"), new StringLiteralType("'Standard_DS5_v2'"), new StringLiteralType("'Standard_DS11_v2'"), new StringLiteralType("'Standard_DS12_v2'"), new StringLiteralType("'Standard_DS13_v2'"), new StringLiteralType("'Standard_DS14_v2'"), new StringLiteralType("'Standard_DS15_v2'"), new StringLiteralType("'Standard_G1'"), new StringLiteralType("'Standard_G2'"), new StringLiteralType("'Standard_G3'"), new StringLiteralType("'Standard_G4'"), new StringLiteralType("'Standard_G5'"), new StringLiteralType("'Standard_GS1'"), new StringLiteralType("'Standard_GS2'"), new StringLiteralType("'Standard_GS3'"), new StringLiteralType("'Standard_GS4'"), new StringLiteralType("'Standard_GS5'")), TypePropertyFlags.None)}, null);
            StorageProfile = new NamedObjectType("StorageProfile", new ITypeProperty[]{new LazyTypeProperty("imageReference", () => ImageReference, TypePropertyFlags.None), new LazyTypeProperty("osDisk", () => OSDisk, TypePropertyFlags.None), new LazyTypeProperty("dataDisks", () => new TypedArrayType(DataDisk), TypePropertyFlags.None)}, null);
            ImageReference = new NamedObjectType("ImageReference", new ITypeProperty[]{new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None)}, null);
            OSDisk = new NamedObjectType("OSDisk", new ITypeProperty[]{new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.None), new LazyTypeProperty("encryptionSettings", () => DiskEncryptionSettings, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("vhd", () => VirtualHardDisk, TypePropertyFlags.Required), new LazyTypeProperty("image", () => VirtualHardDisk, TypePropertyFlags.None), new TypeProperty("caching", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'ReadOnly'"), new StringLiteralType("'ReadWrite'")), TypePropertyFlags.None), new TypeProperty("createOption", UnionType.Create(new StringLiteralType("'FromImage'"), new StringLiteralType("'Empty'"), new StringLiteralType("'Attach'")), TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            DiskEncryptionSettings = new NamedObjectType("DiskEncryptionSettings", new ITypeProperty[]{new LazyTypeProperty("diskEncryptionKey", () => KeyVaultSecretReference, TypePropertyFlags.None), new LazyTypeProperty("keyEncryptionKey", () => KeyVaultKeyReference, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            KeyVaultSecretReference = new NamedObjectType("KeyVaultSecretReference", new ITypeProperty[]{new TypeProperty("secretUrl", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("sourceVault", () => SubResource, TypePropertyFlags.Required)}, null);
            KeyVaultKeyReference = new NamedObjectType("KeyVaultKeyReference", new ITypeProperty[]{new TypeProperty("keyUrl", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("sourceVault", () => SubResource, TypePropertyFlags.Required)}, null);
            VirtualHardDisk = new NamedObjectType("VirtualHardDisk", new ITypeProperty[]{new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None)}, null);
            DataDisk = new NamedObjectType("DataDisk", new ITypeProperty[]{new TypeProperty("lun", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("vhd", () => VirtualHardDisk, TypePropertyFlags.Required), new LazyTypeProperty("image", () => VirtualHardDisk, TypePropertyFlags.None), new TypeProperty("caching", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'ReadOnly'"), new StringLiteralType("'ReadWrite'")), TypePropertyFlags.None), new TypeProperty("createOption", UnionType.Create(new StringLiteralType("'FromImage'"), new StringLiteralType("'Empty'"), new StringLiteralType("'Attach'")), TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            OSProfile = new NamedObjectType("OSProfile", new ITypeProperty[]{new TypeProperty("computerName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("customData", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("windowsConfiguration", () => WindowsConfiguration, TypePropertyFlags.None), new LazyTypeProperty("linuxConfiguration", () => LinuxConfiguration, TypePropertyFlags.None), new LazyTypeProperty("secrets", () => new TypedArrayType(VaultSecretGroup), TypePropertyFlags.None)}, null);
            WindowsConfiguration = new NamedObjectType("WindowsConfiguration", new ITypeProperty[]{new TypeProperty("provisionVMAgent", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableAutomaticUpdates", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("additionalUnattendContent", () => new TypedArrayType(AdditionalUnattendContent), TypePropertyFlags.None), new LazyTypeProperty("winRM", () => WinRMConfiguration, TypePropertyFlags.None)}, null);
            AdditionalUnattendContent = new NamedObjectType("AdditionalUnattendContent", new ITypeProperty[]{new TypeProperty("passName", new StringLiteralType("'OobeSystem'"), TypePropertyFlags.None), new TypeProperty("componentName", new StringLiteralType("'Microsoft-Windows-Shell-Setup'"), TypePropertyFlags.None), new TypeProperty("settingName", UnionType.Create(new StringLiteralType("'AutoLogon'"), new StringLiteralType("'FirstLogonCommands'")), TypePropertyFlags.None), new TypeProperty("content", LanguageConstants.String, TypePropertyFlags.None)}, null);
            WinRMConfiguration = new NamedObjectType("WinRMConfiguration", new ITypeProperty[]{new LazyTypeProperty("listeners", () => new TypedArrayType(WinRMListener), TypePropertyFlags.None)}, null);
            WinRMListener = new NamedObjectType("WinRMListener", new ITypeProperty[]{new TypeProperty("protocol", UnionType.Create(new StringLiteralType("'Http'"), new StringLiteralType("'Https'")), TypePropertyFlags.None), new TypeProperty("certificateUrl", LanguageConstants.String, TypePropertyFlags.None)}, null);
            LinuxConfiguration = new NamedObjectType("LinuxConfiguration", new ITypeProperty[]{new TypeProperty("disablePasswordAuthentication", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("ssh", () => SshConfiguration, TypePropertyFlags.None)}, null);
            SshConfiguration = new NamedObjectType("SshConfiguration", new ITypeProperty[]{new LazyTypeProperty("publicKeys", () => new TypedArrayType(SshPublicKey), TypePropertyFlags.None)}, null);
            SshPublicKey = new NamedObjectType("SshPublicKey", new ITypeProperty[]{new TypeProperty("path", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VaultSecretGroup = new NamedObjectType("VaultSecretGroup", new ITypeProperty[]{new LazyTypeProperty("sourceVault", () => SubResource, TypePropertyFlags.None), new LazyTypeProperty("vaultCertificates", () => new TypedArrayType(VaultCertificate), TypePropertyFlags.None)}, null);
            VaultCertificate = new NamedObjectType("VaultCertificate", new ITypeProperty[]{new TypeProperty("certificateUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("certificateStore", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NetworkProfile = new NamedObjectType("NetworkProfile", new ITypeProperty[]{new LazyTypeProperty("networkInterfaces", () => new TypedArrayType(NetworkInterfaceReference), TypePropertyFlags.None)}, null);
            NetworkInterfaceReference = new NamedObjectType("NetworkInterfaceReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => NetworkInterfaceReferenceProperties, TypePropertyFlags.None)}, null);
            NetworkInterfaceReferenceProperties = new NamedObjectType("NetworkInterfaceReferenceProperties", new ITypeProperty[]{new TypeProperty("primary", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            DiagnosticsProfile = new NamedObjectType("DiagnosticsProfile", new ITypeProperty[]{new LazyTypeProperty("bootDiagnostics", () => BootDiagnostics, TypePropertyFlags.None)}, null);
            BootDiagnostics = new NamedObjectType("BootDiagnostics", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageUri", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualMachineInstanceView = new NamedObjectType("VirtualMachineInstanceView", new ITypeProperty[]{new TypeProperty("platformUpdateDomain", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("platformFaultDomain", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("rdpThumbPrint", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("vmAgent", () => VirtualMachineAgentInstanceView, TypePropertyFlags.None), new LazyTypeProperty("disks", () => new TypedArrayType(DiskInstanceView), TypePropertyFlags.None), new LazyTypeProperty("extensions", () => new TypedArrayType(VirtualMachineExtensionInstanceView), TypePropertyFlags.None), new LazyTypeProperty("bootDiagnostics", () => BootDiagnosticsInstanceView, TypePropertyFlags.None), new LazyTypeProperty("statuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.None)}, null);
            VirtualMachineAgentInstanceView = new NamedObjectType("VirtualMachineAgentInstanceView", new ITypeProperty[]{new TypeProperty("vmAgentVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("extensionHandlers", () => new TypedArrayType(VirtualMachineExtensionHandlerInstanceView), TypePropertyFlags.None), new LazyTypeProperty("statuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.None)}, null);
            VirtualMachineExtensionHandlerInstanceView = new NamedObjectType("VirtualMachineExtensionHandlerInstanceView", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("typeHandlerVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("status", () => InstanceViewStatus, TypePropertyFlags.None)}, null);
            DiskInstanceView = new NamedObjectType("DiskInstanceView", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("statuses", () => new TypedArrayType(InstanceViewStatus), TypePropertyFlags.None)}, null);
            BootDiagnosticsInstanceView = new NamedObjectType("BootDiagnosticsInstanceView", new ITypeProperty[]{new TypeProperty("consoleScreenshotBlobUri", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("serialConsoleLogBlobUri", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            VirtualMachineExtension = new NamedObjectType("VirtualMachineExtension", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => VirtualMachineExtensionProperties, TypePropertyFlags.None)}, null);
            VirtualMachineIdentity = new NamedObjectType("VirtualMachineIdentity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'SystemAssigned'"), TypePropertyFlags.None)}, null);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetProperties = new NamedObjectType("VirtualMachineScaleSetProperties", new ITypeProperty[]{new LazyTypeProperty("upgradePolicy", () => UpgradePolicy, TypePropertyFlags.None), new LazyTypeProperty("virtualMachineProfile", () => VirtualMachineScaleSetVMProfile, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("overProvision", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            UpgradePolicy = new NamedObjectType("UpgradePolicy", new ITypeProperty[]{new TypeProperty("mode", UnionType.Create(new StringLiteralType("'Automatic'"), new StringLiteralType("'Manual'")), TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetVMProfile = new NamedObjectType("VirtualMachineScaleSetVMProfile", new ITypeProperty[]{new LazyTypeProperty("osProfile", () => VirtualMachineScaleSetOSProfile, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => VirtualMachineScaleSetStorageProfile, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => VirtualMachineScaleSetNetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("extensionProfile", () => VirtualMachineScaleSetExtensionProfile, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetOSProfile = new NamedObjectType("VirtualMachineScaleSetOSProfile", new ITypeProperty[]{new TypeProperty("computerNamePrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("customData", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("windowsConfiguration", () => WindowsConfiguration, TypePropertyFlags.None), new LazyTypeProperty("linuxConfiguration", () => LinuxConfiguration, TypePropertyFlags.None), new LazyTypeProperty("secrets", () => new TypedArrayType(VaultSecretGroup), TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetStorageProfile = new NamedObjectType("VirtualMachineScaleSetStorageProfile", new ITypeProperty[]{new LazyTypeProperty("imageReference", () => ImageReference, TypePropertyFlags.None), new LazyTypeProperty("osDisk", () => VirtualMachineScaleSetOSDisk, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetOSDisk = new NamedObjectType("VirtualMachineScaleSetOSDisk", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("caching", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'ReadOnly'"), new StringLiteralType("'ReadWrite'")), TypePropertyFlags.None), new TypeProperty("createOption", UnionType.Create(new StringLiteralType("'FromImage'"), new StringLiteralType("'Empty'"), new StringLiteralType("'Attach'")), TypePropertyFlags.Required), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.None), new LazyTypeProperty("image", () => VirtualHardDisk, TypePropertyFlags.None), new TypeProperty("vhdContainers", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetNetworkProfile = new NamedObjectType("VirtualMachineScaleSetNetworkProfile", new ITypeProperty[]{new LazyTypeProperty("networkInterfaceConfigurations", () => new TypedArrayType(VirtualMachineScaleSetNetworkConfiguration), TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetNetworkConfiguration = new NamedObjectType("VirtualMachineScaleSetNetworkConfiguration", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VirtualMachineScaleSetNetworkConfigurationProperties, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetNetworkConfigurationProperties = new NamedObjectType("VirtualMachineScaleSetNetworkConfigurationProperties", new ITypeProperty[]{new TypeProperty("primary", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("ipConfigurations", () => new TypedArrayType(VirtualMachineScaleSetIPConfiguration), TypePropertyFlags.Required)}, null);
            VirtualMachineScaleSetIPConfiguration = new NamedObjectType("VirtualMachineScaleSetIPConfiguration", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VirtualMachineScaleSetIPConfigurationProperties, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetIPConfigurationProperties = new NamedObjectType("VirtualMachineScaleSetIPConfigurationProperties", new ITypeProperty[]{new LazyTypeProperty("subnet", () => ApiEntityReference, TypePropertyFlags.Required), new LazyTypeProperty("applicationGatewayBackendAddressPools", () => new TypedArrayType(SubResource), TypePropertyFlags.None), new LazyTypeProperty("loadBalancerBackendAddressPools", () => new TypedArrayType(SubResource), TypePropertyFlags.None), new LazyTypeProperty("loadBalancerInboundNatPools", () => new TypedArrayType(SubResource), TypePropertyFlags.None)}, null);
            ApiEntityReference = new NamedObjectType("ApiEntityReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetExtensionProfile = new NamedObjectType("VirtualMachineScaleSetExtensionProfile", new ITypeProperty[]{new LazyTypeProperty("extensions", () => new TypedArrayType(VirtualMachineScaleSetExtension), TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetExtension = new NamedObjectType("VirtualMachineScaleSetExtension", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => VirtualMachineScaleSetExtensionProperties, TypePropertyFlags.None)}, null);
            VirtualMachineScaleSetExtensionProperties = new NamedObjectType("VirtualMachineScaleSetExtensionProperties", new ITypeProperty[]{new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("typeHandlerVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("autoUpgradeMinorVersion", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("settings", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("protectedSettings", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            VirtualMachineScaleSetIdentity = new NamedObjectType("VirtualMachineScaleSetIdentity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'SystemAssigned'"), TypePropertyFlags.None)}, null);
            ResourceType_availabilitySets = new ResourceType("Microsoft.Compute/availabilitySets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/availabilitySets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => AvailabilitySetProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2016-03-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_availabilitySets);
            ResourceType_virtualMachines = new ResourceType("Microsoft.Compute/virtualMachines", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/virtualMachines'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("plan", () => Plan, TypePropertyFlags.None), new LazyTypeProperty("properties", () => VirtualMachineProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => VirtualMachineIdentity, TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2016-03-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_virtualMachines);
            ResourceType_virtualMachineScaleSets = new ResourceType("Microsoft.Compute/virtualMachineScaleSets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/virtualMachineScaleSets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => VirtualMachineScaleSetProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => VirtualMachineScaleSetIdentity, TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2016-03-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_virtualMachineScaleSets);
            ResourceType_virtualMachines_extensions = new ResourceType("Microsoft.Compute/virtualMachines/extensions", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/virtualMachines/extensions'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => VirtualMachineExtensionProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2016-03-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_virtualMachines_extensions);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_availabilitySets, () => InstanceLazy.Value.ResourceType_availabilitySets);
            registrar.RegisterType(ResourceTypeReference_virtualMachines, () => InstanceLazy.Value.ResourceType_virtualMachines);
            registrar.RegisterType(ResourceTypeReference_virtualMachineScaleSets, () => InstanceLazy.Value.ResourceType_virtualMachineScaleSets);
            registrar.RegisterType(ResourceTypeReference_virtualMachines_extensions, () => InstanceLazy.Value.ResourceType_virtualMachines_extensions);
        }
        private readonly ResourceType ResourceType_availabilitySets;
        private readonly ResourceType ResourceType_virtualMachines;
        private readonly ResourceType ResourceType_virtualMachineScaleSets;
        private readonly ResourceType ResourceType_virtualMachines_extensions;
        private readonly TypeSymbol AvailabilitySetProperties;
        private readonly TypeSymbol SubResource;
        private readonly TypeSymbol InstanceViewStatus;
        private readonly TypeSymbol VirtualMachineExtensionProperties;
        private readonly TypeSymbol VirtualMachineExtensionInstanceView;
        private readonly TypeSymbol Plan;
        private readonly TypeSymbol VirtualMachineProperties;
        private readonly TypeSymbol HardwareProfile;
        private readonly TypeSymbol StorageProfile;
        private readonly TypeSymbol ImageReference;
        private readonly TypeSymbol OSDisk;
        private readonly TypeSymbol DiskEncryptionSettings;
        private readonly TypeSymbol KeyVaultSecretReference;
        private readonly TypeSymbol KeyVaultKeyReference;
        private readonly TypeSymbol VirtualHardDisk;
        private readonly TypeSymbol DataDisk;
        private readonly TypeSymbol OSProfile;
        private readonly TypeSymbol WindowsConfiguration;
        private readonly TypeSymbol AdditionalUnattendContent;
        private readonly TypeSymbol WinRMConfiguration;
        private readonly TypeSymbol WinRMListener;
        private readonly TypeSymbol LinuxConfiguration;
        private readonly TypeSymbol SshConfiguration;
        private readonly TypeSymbol SshPublicKey;
        private readonly TypeSymbol VaultSecretGroup;
        private readonly TypeSymbol VaultCertificate;
        private readonly TypeSymbol NetworkProfile;
        private readonly TypeSymbol NetworkInterfaceReference;
        private readonly TypeSymbol NetworkInterfaceReferenceProperties;
        private readonly TypeSymbol DiagnosticsProfile;
        private readonly TypeSymbol BootDiagnostics;
        private readonly TypeSymbol VirtualMachineInstanceView;
        private readonly TypeSymbol VirtualMachineAgentInstanceView;
        private readonly TypeSymbol VirtualMachineExtensionHandlerInstanceView;
        private readonly TypeSymbol DiskInstanceView;
        private readonly TypeSymbol BootDiagnosticsInstanceView;
        private readonly TypeSymbol VirtualMachineExtension;
        private readonly TypeSymbol VirtualMachineIdentity;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol VirtualMachineScaleSetProperties;
        private readonly TypeSymbol UpgradePolicy;
        private readonly TypeSymbol VirtualMachineScaleSetVMProfile;
        private readonly TypeSymbol VirtualMachineScaleSetOSProfile;
        private readonly TypeSymbol VirtualMachineScaleSetStorageProfile;
        private readonly TypeSymbol VirtualMachineScaleSetOSDisk;
        private readonly TypeSymbol VirtualMachineScaleSetNetworkProfile;
        private readonly TypeSymbol VirtualMachineScaleSetNetworkConfiguration;
        private readonly TypeSymbol VirtualMachineScaleSetNetworkConfigurationProperties;
        private readonly TypeSymbol VirtualMachineScaleSetIPConfiguration;
        private readonly TypeSymbol VirtualMachineScaleSetIPConfigurationProperties;
        private readonly TypeSymbol ApiEntityReference;
        private readonly TypeSymbol VirtualMachineScaleSetExtensionProfile;
        private readonly TypeSymbol VirtualMachineScaleSetExtension;
        private readonly TypeSymbol VirtualMachineScaleSetExtensionProperties;
        private readonly TypeSymbol VirtualMachineScaleSetIdentity;
    }
}
