// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_HanaOnAzure_2017_11_03_preview
    {
        private const string ProviderNamespace = "Microsoft.HanaOnAzure";
        private const string ApiVersion = "2017-11-03-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_hanaInstances = new ResourceTypeReference(ProviderNamespace, new[]{"hanaInstances"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sapMonitors = new ResourceTypeReference(ProviderNamespace, new[]{"sapMonitors"}, ApiVersion);
        private static Lazy<Microsoft_HanaOnAzure_2017_11_03_preview> InstanceLazy = new Lazy<Microsoft_HanaOnAzure_2017_11_03_preview>(() => new Microsoft_HanaOnAzure_2017_11_03_preview());
        private Microsoft_HanaOnAzure_2017_11_03_preview()
        {
            HanaInstanceProperties = new NamedObjectType("HanaInstanceProperties", new ITypeProperty[]{new LazyTypeProperty("hardwareProfile", () => HardwareProfile, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => StorageProfile, TypePropertyFlags.None), new LazyTypeProperty("osProfile", () => OSProfile, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => NetworkProfile, TypePropertyFlags.None), new TypeProperty("hanaInstanceId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("powerState", UnionType.Create(new StringLiteralType("'starting'"), new StringLiteralType("'started'"), new StringLiteralType("'stopping'"), new StringLiteralType("'stopped'"), new StringLiteralType("'restarting'"), new StringLiteralType("'unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("proximityPlacementGroup", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("hwRevision", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("partnerNodeId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Migrating'")), TypePropertyFlags.ReadOnly)}, null);
            HardwareProfile = new NamedObjectType("HardwareProfile", new ITypeProperty[]{new TypeProperty("hardwareType", UnionType.Create(new StringLiteralType("'Cisco_UCS'"), new StringLiteralType("'HPE'")), TypePropertyFlags.ReadOnly), new TypeProperty("hanaInstanceSize", UnionType.Create(new StringLiteralType("'S72m'"), new StringLiteralType("'S144m'"), new StringLiteralType("'S72'"), new StringLiteralType("'S144'"), new StringLiteralType("'S192'"), new StringLiteralType("'S192m'"), new StringLiteralType("'S192xm'"), new StringLiteralType("'S96'"), new StringLiteralType("'S112'"), new StringLiteralType("'S224'"), new StringLiteralType("'S224m'"), new StringLiteralType("'S224om'"), new StringLiteralType("'S224oo'"), new StringLiteralType("'S224oom'"), new StringLiteralType("'S224ooo'"), new StringLiteralType("'S384'"), new StringLiteralType("'S384m'"), new StringLiteralType("'S384xm'"), new StringLiteralType("'S384xxm'"), new StringLiteralType("'S448'"), new StringLiteralType("'S448m'"), new StringLiteralType("'S448om'"), new StringLiteralType("'S448oo'"), new StringLiteralType("'S448oom'"), new StringLiteralType("'S448ooo'"), new StringLiteralType("'S576m'"), new StringLiteralType("'S576xm'"), new StringLiteralType("'S672'"), new StringLiteralType("'S672m'"), new StringLiteralType("'S672om'"), new StringLiteralType("'S672oo'"), new StringLiteralType("'S672oom'"), new StringLiteralType("'S672ooo'"), new StringLiteralType("'S768'"), new StringLiteralType("'S768m'"), new StringLiteralType("'S768xm'"), new StringLiteralType("'S896'"), new StringLiteralType("'S896m'"), new StringLiteralType("'S896om'"), new StringLiteralType("'S896oo'"), new StringLiteralType("'S896oom'"), new StringLiteralType("'S896ooo'"), new StringLiteralType("'S960m'")), TypePropertyFlags.ReadOnly)}, null);
            StorageProfile = new NamedObjectType("StorageProfile", new ITypeProperty[]{new TypeProperty("nfsIpAddress", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("osDisks", () => new TypedArrayType(Disk), TypePropertyFlags.None)}, null);
            Disk = new NamedObjectType("Disk", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("lun", LanguageConstants.Int, TypePropertyFlags.ReadOnly)}, null);
            OSProfile = new NamedObjectType("OSProfile", new ITypeProperty[]{new TypeProperty("computerName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("sshPublicKey", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NetworkProfile = new NamedObjectType("NetworkProfile", new ITypeProperty[]{new LazyTypeProperty("networkInterfaces", () => new TypedArrayType(IpAddress), TypePropertyFlags.None), new TypeProperty("circuitId", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            IpAddress = new NamedObjectType("IpAddress", new ITypeProperty[]{new TypeProperty("ipAddress", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SapMonitorProperties = new NamedObjectType("SapMonitorProperties", new ITypeProperty[]{new TypeProperty("hanaSubnet", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaHostname", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbSqlPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("hanaDbUsername", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbPasswordKeyVaultUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbCredentialsMsiId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Migrating'")), TypePropertyFlags.ReadOnly), new TypeProperty("managedResourceGroupName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("logAnalyticsWorkspaceArmId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableCustomerAnalytics", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceSharedKey", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_hanaInstances = new ResourceType("Microsoft.HanaOnAzure/hanaInstances", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.HanaOnAzure/hanaInstances'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => HanaInstanceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-11-03-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_hanaInstances);
            ResourceType_sapMonitors = new ResourceType("Microsoft.HanaOnAzure/sapMonitors", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.HanaOnAzure/sapMonitors'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => SapMonitorProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-11-03-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_sapMonitors);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_hanaInstances, () => InstanceLazy.Value.ResourceType_hanaInstances);
            registrar.RegisterType(ResourceTypeReference_sapMonitors, () => InstanceLazy.Value.ResourceType_sapMonitors);
        }
        private readonly ResourceType ResourceType_hanaInstances;
        private readonly ResourceType ResourceType_sapMonitors;
        private readonly TypeSymbol HanaInstanceProperties;
        private readonly TypeSymbol HardwareProfile;
        private readonly TypeSymbol StorageProfile;
        private readonly TypeSymbol Disk;
        private readonly TypeSymbol OSProfile;
        private readonly TypeSymbol NetworkProfile;
        private readonly TypeSymbol IpAddress;
        private readonly TypeSymbol SapMonitorProperties;
    }
}
