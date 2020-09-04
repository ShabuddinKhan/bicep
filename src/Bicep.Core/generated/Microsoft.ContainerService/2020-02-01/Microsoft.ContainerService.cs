// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2020_02_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2020-02-01";
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters_agentPools = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters", "agentPools"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2020_02_01> InstanceLazy = new Lazy<Microsoft_ContainerService_2020_02_01>(() => new Microsoft_ContainerService_2020_02_01());
        private Microsoft_ContainerService_2020_02_01()
        {
            ManagedClusterProperties = new NamedObjectType("ManagedClusterProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("maxAgentPools", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("kubernetesVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fqdn", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("privateFQDN", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("agentPoolProfiles", () => new TypedArrayType(ManagedClusterAgentPoolProfile), TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.None), new LazyTypeProperty("windowsProfile", () => ManagedClusterWindowsProfile, TypePropertyFlags.None), new LazyTypeProperty("servicePrincipalProfile", () => ManagedClusterServicePrincipalProfile, TypePropertyFlags.None), new TypeProperty("addonProfiles", new NamedObjectType("addonProfiles", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => ManagedClusterAddonProfile, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("nodeResourceGroup", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableRBAC", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enablePodSecurityPolicy", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => ContainerServiceNetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("aadProfile", () => ManagedClusterAADProfile, TypePropertyFlags.None), new LazyTypeProperty("autoScalerProfile", () => ManagedClusterPropertiesAutoScalerProfile, TypePropertyFlags.None), new LazyTypeProperty("apiServerAccessProfile", () => ManagedClusterAPIServerAccessProfile, TypePropertyFlags.None), new TypeProperty("diskEncryptionSetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("identityProfile", new NamedObjectType("identityProfile", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ManagedClusterAgentPoolProfile = new NamedObjectType("ManagedClusterAgentPoolProfile", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", UnionType.Create(new StringLiteralType("'Standard_A1'"), new StringLiteralType("'Standard_A10'"), new StringLiteralType("'Standard_A11'"), new StringLiteralType("'Standard_A1_v2'"), new StringLiteralType("'Standard_A2'"), new StringLiteralType("'Standard_A2_v2'"), new StringLiteralType("'Standard_A2m_v2'"), new StringLiteralType("'Standard_A3'"), new StringLiteralType("'Standard_A4'"), new StringLiteralType("'Standard_A4_v2'"), new StringLiteralType("'Standard_A4m_v2'"), new StringLiteralType("'Standard_A5'"), new StringLiteralType("'Standard_A6'"), new StringLiteralType("'Standard_A7'"), new StringLiteralType("'Standard_A8'"), new StringLiteralType("'Standard_A8_v2'"), new StringLiteralType("'Standard_A8m_v2'"), new StringLiteralType("'Standard_A9'"), new StringLiteralType("'Standard_B2ms'"), new StringLiteralType("'Standard_B2s'"), new StringLiteralType("'Standard_B4ms'"), new StringLiteralType("'Standard_B8ms'"), new StringLiteralType("'Standard_D1'"), new StringLiteralType("'Standard_D11'"), new StringLiteralType("'Standard_D11_v2'"), new StringLiteralType("'Standard_D11_v2_Promo'"), new StringLiteralType("'Standard_D12'"), new StringLiteralType("'Standard_D12_v2'"), new StringLiteralType("'Standard_D12_v2_Promo'"), new StringLiteralType("'Standard_D13'"), new StringLiteralType("'Standard_D13_v2'"), new StringLiteralType("'Standard_D13_v2_Promo'"), new StringLiteralType("'Standard_D14'"), new StringLiteralType("'Standard_D14_v2'"), new StringLiteralType("'Standard_D14_v2_Promo'"), new StringLiteralType("'Standard_D15_v2'"), new StringLiteralType("'Standard_D16_v3'"), new StringLiteralType("'Standard_D16s_v3'"), new StringLiteralType("'Standard_D1_v2'"), new StringLiteralType("'Standard_D2'"), new StringLiteralType("'Standard_D2_v2'"), new StringLiteralType("'Standard_D2_v2_Promo'"), new StringLiteralType("'Standard_D2_v3'"), new StringLiteralType("'Standard_D2s_v3'"), new StringLiteralType("'Standard_D3'"), new StringLiteralType("'Standard_D32_v3'"), new StringLiteralType("'Standard_D32s_v3'"), new StringLiteralType("'Standard_D3_v2'"), new StringLiteralType("'Standard_D3_v2_Promo'"), new StringLiteralType("'Standard_D4'"), new StringLiteralType("'Standard_D4_v2'"), new StringLiteralType("'Standard_D4_v2_Promo'"), new StringLiteralType("'Standard_D4_v3'"), new StringLiteralType("'Standard_D4s_v3'"), new StringLiteralType("'Standard_D5_v2'"), new StringLiteralType("'Standard_D5_v2_Promo'"), new StringLiteralType("'Standard_D64_v3'"), new StringLiteralType("'Standard_D64s_v3'"), new StringLiteralType("'Standard_D8_v3'"), new StringLiteralType("'Standard_D8s_v3'"), new StringLiteralType("'Standard_DS1'"), new StringLiteralType("'Standard_DS11'"), new StringLiteralType("'Standard_DS11_v2'"), new StringLiteralType("'Standard_DS11_v2_Promo'"), new StringLiteralType("'Standard_DS12'"), new StringLiteralType("'Standard_DS12_v2'"), new StringLiteralType("'Standard_DS12_v2_Promo'"), new StringLiteralType("'Standard_DS13'"), new StringLiteralType("'Standard_DS13-2_v2'"), new StringLiteralType("'Standard_DS13-4_v2'"), new StringLiteralType("'Standard_DS13_v2'"), new StringLiteralType("'Standard_DS13_v2_Promo'"), new StringLiteralType("'Standard_DS14'"), new StringLiteralType("'Standard_DS14-4_v2'"), new StringLiteralType("'Standard_DS14-8_v2'"), new StringLiteralType("'Standard_DS14_v2'"), new StringLiteralType("'Standard_DS14_v2_Promo'"), new StringLiteralType("'Standard_DS15_v2'"), new StringLiteralType("'Standard_DS1_v2'"), new StringLiteralType("'Standard_DS2'"), new StringLiteralType("'Standard_DS2_v2'"), new StringLiteralType("'Standard_DS2_v2_Promo'"), new StringLiteralType("'Standard_DS3'"), new StringLiteralType("'Standard_DS3_v2'"), new StringLiteralType("'Standard_DS3_v2_Promo'"), new StringLiteralType("'Standard_DS4'"), new StringLiteralType("'Standard_DS4_v2'"), new StringLiteralType("'Standard_DS4_v2_Promo'"), new StringLiteralType("'Standard_DS5_v2'"), new StringLiteralType("'Standard_DS5_v2_Promo'"), new StringLiteralType("'Standard_E16_v3'"), new StringLiteralType("'Standard_E16s_v3'"), new StringLiteralType("'Standard_E2_v3'"), new StringLiteralType("'Standard_E2s_v3'"), new StringLiteralType("'Standard_E32-16s_v3'"), new StringLiteralType("'Standard_E32-8s_v3'"), new StringLiteralType("'Standard_E32_v3'"), new StringLiteralType("'Standard_E32s_v3'"), new StringLiteralType("'Standard_E4_v3'"), new StringLiteralType("'Standard_E4s_v3'"), new StringLiteralType("'Standard_E64-16s_v3'"), new StringLiteralType("'Standard_E64-32s_v3'"), new StringLiteralType("'Standard_E64_v3'"), new StringLiteralType("'Standard_E64s_v3'"), new StringLiteralType("'Standard_E8_v3'"), new StringLiteralType("'Standard_E8s_v3'"), new StringLiteralType("'Standard_F1'"), new StringLiteralType("'Standard_F16'"), new StringLiteralType("'Standard_F16s'"), new StringLiteralType("'Standard_F16s_v2'"), new StringLiteralType("'Standard_F1s'"), new StringLiteralType("'Standard_F2'"), new StringLiteralType("'Standard_F2s'"), new StringLiteralType("'Standard_F2s_v2'"), new StringLiteralType("'Standard_F32s_v2'"), new StringLiteralType("'Standard_F4'"), new StringLiteralType("'Standard_F4s'"), new StringLiteralType("'Standard_F4s_v2'"), new StringLiteralType("'Standard_F64s_v2'"), new StringLiteralType("'Standard_F72s_v2'"), new StringLiteralType("'Standard_F8'"), new StringLiteralType("'Standard_F8s'"), new StringLiteralType("'Standard_F8s_v2'"), new StringLiteralType("'Standard_G1'"), new StringLiteralType("'Standard_G2'"), new StringLiteralType("'Standard_G3'"), new StringLiteralType("'Standard_G4'"), new StringLiteralType("'Standard_G5'"), new StringLiteralType("'Standard_GS1'"), new StringLiteralType("'Standard_GS2'"), new StringLiteralType("'Standard_GS3'"), new StringLiteralType("'Standard_GS4'"), new StringLiteralType("'Standard_GS4-4'"), new StringLiteralType("'Standard_GS4-8'"), new StringLiteralType("'Standard_GS5'"), new StringLiteralType("'Standard_GS5-16'"), new StringLiteralType("'Standard_GS5-8'"), new StringLiteralType("'Standard_H16'"), new StringLiteralType("'Standard_H16m'"), new StringLiteralType("'Standard_H16mr'"), new StringLiteralType("'Standard_H16r'"), new StringLiteralType("'Standard_H8'"), new StringLiteralType("'Standard_H8m'"), new StringLiteralType("'Standard_L16s'"), new StringLiteralType("'Standard_L32s'"), new StringLiteralType("'Standard_L4s'"), new StringLiteralType("'Standard_L8s'"), new StringLiteralType("'Standard_M128-32ms'"), new StringLiteralType("'Standard_M128-64ms'"), new StringLiteralType("'Standard_M128ms'"), new StringLiteralType("'Standard_M128s'"), new StringLiteralType("'Standard_M64-16ms'"), new StringLiteralType("'Standard_M64-32ms'"), new StringLiteralType("'Standard_M64ms'"), new StringLiteralType("'Standard_M64s'"), new StringLiteralType("'Standard_NC12'"), new StringLiteralType("'Standard_NC12s_v2'"), new StringLiteralType("'Standard_NC12s_v3'"), new StringLiteralType("'Standard_NC24'"), new StringLiteralType("'Standard_NC24r'"), new StringLiteralType("'Standard_NC24rs_v2'"), new StringLiteralType("'Standard_NC24rs_v3'"), new StringLiteralType("'Standard_NC24s_v2'"), new StringLiteralType("'Standard_NC24s_v3'"), new StringLiteralType("'Standard_NC6'"), new StringLiteralType("'Standard_NC6s_v2'"), new StringLiteralType("'Standard_NC6s_v3'"), new StringLiteralType("'Standard_ND12s'"), new StringLiteralType("'Standard_ND24rs'"), new StringLiteralType("'Standard_ND24s'"), new StringLiteralType("'Standard_ND6s'"), new StringLiteralType("'Standard_NV12'"), new StringLiteralType("'Standard_NV24'"), new StringLiteralType("'Standard_NV6'")), TypePropertyFlags.None), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPods", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Linux'"), new StringLiteralType("'Windows'")), TypePropertyFlags.None), new TypeProperty("maxCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("enableAutoScaling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("type", UnionType.Create(new StringLiteralType("'VirtualMachineScaleSets'"), new StringLiteralType("'AvailabilitySet'")), TypePropertyFlags.None), new TypeProperty("orchestratorVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("availabilityZones", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enableNodePublicIP", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("scaleSetPriority", UnionType.Create(new StringLiteralType("'Spot'"), new StringLiteralType("'Low'"), new StringLiteralType("'Regular'")), TypePropertyFlags.None), new TypeProperty("scaleSetEvictionPolicy", UnionType.Create(new StringLiteralType("'Delete'"), new StringLiteralType("'Deallocate'")), TypePropertyFlags.None), new TypeProperty("spotMaxPrice", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("nodeLabels", new NamedObjectType("nodeLabels", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("nodeTaints", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new LazyTypeProperty("publicKeys", () => new TypedArrayType(ContainerServiceSshPublicKey), TypePropertyFlags.Required)}, null);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ManagedClusterWindowsProfile = new NamedObjectType("ManagedClusterWindowsProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterServicePrincipalProfile = new NamedObjectType("ManagedClusterServicePrincipalProfile", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterAddonProfile = new NamedObjectType("ManagedClusterAddonProfile", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("config", new NamedObjectType("config", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("identity", () => ManagedClusterAddonProfileIdentity, TypePropertyFlags.ReadOnly)}, null);
            ManagedClusterAddonProfileIdentity = new NamedObjectType("ManagedClusterAddonProfileIdentity", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("objectId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ContainerServiceNetworkProfile = new NamedObjectType("ContainerServiceNetworkProfile", new ITypeProperty[]{new TypeProperty("networkPlugin", UnionType.Create(new StringLiteralType("'azure'"), new StringLiteralType("'kubenet'")), TypePropertyFlags.None), new TypeProperty("networkPolicy", UnionType.Create(new StringLiteralType("'calico'"), new StringLiteralType("'azure'")), TypePropertyFlags.None), new TypeProperty("networkMode", UnionType.Create(new StringLiteralType("'transparent'"), new StringLiteralType("'bridge'")), TypePropertyFlags.None), new TypeProperty("podCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsServiceIP", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dockerBridgeCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("outboundType", UnionType.Create(new StringLiteralType("'loadBalancer'"), new StringLiteralType("'userDefinedRouting'")), TypePropertyFlags.None), new TypeProperty("loadBalancerSku", UnionType.Create(new StringLiteralType("'standard'"), new StringLiteralType("'basic'")), TypePropertyFlags.None), new LazyTypeProperty("loadBalancerProfile", () => ManagedClusterLoadBalancerProfile, TypePropertyFlags.None)}, null);
            ManagedClusterLoadBalancerProfile = new NamedObjectType("ManagedClusterLoadBalancerProfile", new ITypeProperty[]{new LazyTypeProperty("managedOutboundIPs", () => ManagedClusterLoadBalancerProfileManagedOutboundIPs, TypePropertyFlags.None), new LazyTypeProperty("outboundIPPrefixes", () => ManagedClusterLoadBalancerProfileOutboundIPPrefixes, TypePropertyFlags.None), new LazyTypeProperty("outboundIPs", () => ManagedClusterLoadBalancerProfileOutboundIPs, TypePropertyFlags.None), new LazyTypeProperty("effectiveOutboundIPs", () => new TypedArrayType(ResourceReference), TypePropertyFlags.None), new TypeProperty("allocatedOutboundPorts", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("idleTimeoutInMinutes", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            ManagedClusterLoadBalancerProfileManagedOutboundIPs = new NamedObjectType("ManagedClusterLoadBalancerProfileManagedOutboundIPs", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            ManagedClusterLoadBalancerProfileOutboundIPPrefixes = new NamedObjectType("ManagedClusterLoadBalancerProfileOutboundIPPrefixes", new ITypeProperty[]{new LazyTypeProperty("publicIPPrefixes", () => new TypedArrayType(ResourceReference), TypePropertyFlags.None)}, null);
            ResourceReference = new NamedObjectType("ResourceReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterLoadBalancerProfileOutboundIPs = new NamedObjectType("ManagedClusterLoadBalancerProfileOutboundIPs", new ITypeProperty[]{new LazyTypeProperty("publicIPs", () => new TypedArrayType(ResourceReference), TypePropertyFlags.None)}, null);
            ManagedClusterAADProfile = new NamedObjectType("ManagedClusterAADProfile", new ITypeProperty[]{new TypeProperty("clientAppID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serverAppID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serverAppSecret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantID", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterPropertiesAutoScalerProfile = new NamedObjectType("ManagedClusterPropertiesAutoScalerProfile", new ITypeProperty[]{new TypeProperty("scan-interval", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-add", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-delete", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-delay-after-failure", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-unneeded-time", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-unready-time", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scale-down-utilization-threshold", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("max-graceful-termination-sec", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterAPIServerAccessProfile = new NamedObjectType("ManagedClusterAPIServerAccessProfile", new ITypeProperty[]{new TypeProperty("authorizedIPRanges", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enablePrivateCluster", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties = new NamedObjectType("Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("objectId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ManagedClusterIdentity = new NamedObjectType("ManagedClusterIdentity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", UnionType.Create(new StringLiteralType("'SystemAssigned'"), new StringLiteralType("'None'")), TypePropertyFlags.None)}, null);
            ManagedClusterAgentPoolProfileProperties = new NamedObjectType("ManagedClusterAgentPoolProfileProperties", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", UnionType.Create(new StringLiteralType("'Standard_A1'"), new StringLiteralType("'Standard_A10'"), new StringLiteralType("'Standard_A11'"), new StringLiteralType("'Standard_A1_v2'"), new StringLiteralType("'Standard_A2'"), new StringLiteralType("'Standard_A2_v2'"), new StringLiteralType("'Standard_A2m_v2'"), new StringLiteralType("'Standard_A3'"), new StringLiteralType("'Standard_A4'"), new StringLiteralType("'Standard_A4_v2'"), new StringLiteralType("'Standard_A4m_v2'"), new StringLiteralType("'Standard_A5'"), new StringLiteralType("'Standard_A6'"), new StringLiteralType("'Standard_A7'"), new StringLiteralType("'Standard_A8'"), new StringLiteralType("'Standard_A8_v2'"), new StringLiteralType("'Standard_A8m_v2'"), new StringLiteralType("'Standard_A9'"), new StringLiteralType("'Standard_B2ms'"), new StringLiteralType("'Standard_B2s'"), new StringLiteralType("'Standard_B4ms'"), new StringLiteralType("'Standard_B8ms'"), new StringLiteralType("'Standard_D1'"), new StringLiteralType("'Standard_D11'"), new StringLiteralType("'Standard_D11_v2'"), new StringLiteralType("'Standard_D11_v2_Promo'"), new StringLiteralType("'Standard_D12'"), new StringLiteralType("'Standard_D12_v2'"), new StringLiteralType("'Standard_D12_v2_Promo'"), new StringLiteralType("'Standard_D13'"), new StringLiteralType("'Standard_D13_v2'"), new StringLiteralType("'Standard_D13_v2_Promo'"), new StringLiteralType("'Standard_D14'"), new StringLiteralType("'Standard_D14_v2'"), new StringLiteralType("'Standard_D14_v2_Promo'"), new StringLiteralType("'Standard_D15_v2'"), new StringLiteralType("'Standard_D16_v3'"), new StringLiteralType("'Standard_D16s_v3'"), new StringLiteralType("'Standard_D1_v2'"), new StringLiteralType("'Standard_D2'"), new StringLiteralType("'Standard_D2_v2'"), new StringLiteralType("'Standard_D2_v2_Promo'"), new StringLiteralType("'Standard_D2_v3'"), new StringLiteralType("'Standard_D2s_v3'"), new StringLiteralType("'Standard_D3'"), new StringLiteralType("'Standard_D32_v3'"), new StringLiteralType("'Standard_D32s_v3'"), new StringLiteralType("'Standard_D3_v2'"), new StringLiteralType("'Standard_D3_v2_Promo'"), new StringLiteralType("'Standard_D4'"), new StringLiteralType("'Standard_D4_v2'"), new StringLiteralType("'Standard_D4_v2_Promo'"), new StringLiteralType("'Standard_D4_v3'"), new StringLiteralType("'Standard_D4s_v3'"), new StringLiteralType("'Standard_D5_v2'"), new StringLiteralType("'Standard_D5_v2_Promo'"), new StringLiteralType("'Standard_D64_v3'"), new StringLiteralType("'Standard_D64s_v3'"), new StringLiteralType("'Standard_D8_v3'"), new StringLiteralType("'Standard_D8s_v3'"), new StringLiteralType("'Standard_DS1'"), new StringLiteralType("'Standard_DS11'"), new StringLiteralType("'Standard_DS11_v2'"), new StringLiteralType("'Standard_DS11_v2_Promo'"), new StringLiteralType("'Standard_DS12'"), new StringLiteralType("'Standard_DS12_v2'"), new StringLiteralType("'Standard_DS12_v2_Promo'"), new StringLiteralType("'Standard_DS13'"), new StringLiteralType("'Standard_DS13-2_v2'"), new StringLiteralType("'Standard_DS13-4_v2'"), new StringLiteralType("'Standard_DS13_v2'"), new StringLiteralType("'Standard_DS13_v2_Promo'"), new StringLiteralType("'Standard_DS14'"), new StringLiteralType("'Standard_DS14-4_v2'"), new StringLiteralType("'Standard_DS14-8_v2'"), new StringLiteralType("'Standard_DS14_v2'"), new StringLiteralType("'Standard_DS14_v2_Promo'"), new StringLiteralType("'Standard_DS15_v2'"), new StringLiteralType("'Standard_DS1_v2'"), new StringLiteralType("'Standard_DS2'"), new StringLiteralType("'Standard_DS2_v2'"), new StringLiteralType("'Standard_DS2_v2_Promo'"), new StringLiteralType("'Standard_DS3'"), new StringLiteralType("'Standard_DS3_v2'"), new StringLiteralType("'Standard_DS3_v2_Promo'"), new StringLiteralType("'Standard_DS4'"), new StringLiteralType("'Standard_DS4_v2'"), new StringLiteralType("'Standard_DS4_v2_Promo'"), new StringLiteralType("'Standard_DS5_v2'"), new StringLiteralType("'Standard_DS5_v2_Promo'"), new StringLiteralType("'Standard_E16_v3'"), new StringLiteralType("'Standard_E16s_v3'"), new StringLiteralType("'Standard_E2_v3'"), new StringLiteralType("'Standard_E2s_v3'"), new StringLiteralType("'Standard_E32-16s_v3'"), new StringLiteralType("'Standard_E32-8s_v3'"), new StringLiteralType("'Standard_E32_v3'"), new StringLiteralType("'Standard_E32s_v3'"), new StringLiteralType("'Standard_E4_v3'"), new StringLiteralType("'Standard_E4s_v3'"), new StringLiteralType("'Standard_E64-16s_v3'"), new StringLiteralType("'Standard_E64-32s_v3'"), new StringLiteralType("'Standard_E64_v3'"), new StringLiteralType("'Standard_E64s_v3'"), new StringLiteralType("'Standard_E8_v3'"), new StringLiteralType("'Standard_E8s_v3'"), new StringLiteralType("'Standard_F1'"), new StringLiteralType("'Standard_F16'"), new StringLiteralType("'Standard_F16s'"), new StringLiteralType("'Standard_F16s_v2'"), new StringLiteralType("'Standard_F1s'"), new StringLiteralType("'Standard_F2'"), new StringLiteralType("'Standard_F2s'"), new StringLiteralType("'Standard_F2s_v2'"), new StringLiteralType("'Standard_F32s_v2'"), new StringLiteralType("'Standard_F4'"), new StringLiteralType("'Standard_F4s'"), new StringLiteralType("'Standard_F4s_v2'"), new StringLiteralType("'Standard_F64s_v2'"), new StringLiteralType("'Standard_F72s_v2'"), new StringLiteralType("'Standard_F8'"), new StringLiteralType("'Standard_F8s'"), new StringLiteralType("'Standard_F8s_v2'"), new StringLiteralType("'Standard_G1'"), new StringLiteralType("'Standard_G2'"), new StringLiteralType("'Standard_G3'"), new StringLiteralType("'Standard_G4'"), new StringLiteralType("'Standard_G5'"), new StringLiteralType("'Standard_GS1'"), new StringLiteralType("'Standard_GS2'"), new StringLiteralType("'Standard_GS3'"), new StringLiteralType("'Standard_GS4'"), new StringLiteralType("'Standard_GS4-4'"), new StringLiteralType("'Standard_GS4-8'"), new StringLiteralType("'Standard_GS5'"), new StringLiteralType("'Standard_GS5-16'"), new StringLiteralType("'Standard_GS5-8'"), new StringLiteralType("'Standard_H16'"), new StringLiteralType("'Standard_H16m'"), new StringLiteralType("'Standard_H16mr'"), new StringLiteralType("'Standard_H16r'"), new StringLiteralType("'Standard_H8'"), new StringLiteralType("'Standard_H8m'"), new StringLiteralType("'Standard_L16s'"), new StringLiteralType("'Standard_L32s'"), new StringLiteralType("'Standard_L4s'"), new StringLiteralType("'Standard_L8s'"), new StringLiteralType("'Standard_M128-32ms'"), new StringLiteralType("'Standard_M128-64ms'"), new StringLiteralType("'Standard_M128ms'"), new StringLiteralType("'Standard_M128s'"), new StringLiteralType("'Standard_M64-16ms'"), new StringLiteralType("'Standard_M64-32ms'"), new StringLiteralType("'Standard_M64ms'"), new StringLiteralType("'Standard_M64s'"), new StringLiteralType("'Standard_NC12'"), new StringLiteralType("'Standard_NC12s_v2'"), new StringLiteralType("'Standard_NC12s_v3'"), new StringLiteralType("'Standard_NC24'"), new StringLiteralType("'Standard_NC24r'"), new StringLiteralType("'Standard_NC24rs_v2'"), new StringLiteralType("'Standard_NC24rs_v3'"), new StringLiteralType("'Standard_NC24s_v2'"), new StringLiteralType("'Standard_NC24s_v3'"), new StringLiteralType("'Standard_NC6'"), new StringLiteralType("'Standard_NC6s_v2'"), new StringLiteralType("'Standard_NC6s_v3'"), new StringLiteralType("'Standard_ND12s'"), new StringLiteralType("'Standard_ND24rs'"), new StringLiteralType("'Standard_ND24s'"), new StringLiteralType("'Standard_ND6s'"), new StringLiteralType("'Standard_NV12'"), new StringLiteralType("'Standard_NV24'"), new StringLiteralType("'Standard_NV6'")), TypePropertyFlags.None), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPods", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Linux'"), new StringLiteralType("'Windows'")), TypePropertyFlags.None), new TypeProperty("maxCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("enableAutoScaling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("type", UnionType.Create(new StringLiteralType("'VirtualMachineScaleSets'"), new StringLiteralType("'AvailabilitySet'")), TypePropertyFlags.None), new TypeProperty("orchestratorVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("availabilityZones", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("enableNodePublicIP", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("scaleSetPriority", UnionType.Create(new StringLiteralType("'Spot'"), new StringLiteralType("'Low'"), new StringLiteralType("'Regular'")), TypePropertyFlags.None), new TypeProperty("scaleSetEvictionPolicy", UnionType.Create(new StringLiteralType("'Delete'"), new StringLiteralType("'Deallocate'")), TypePropertyFlags.None), new TypeProperty("spotMaxPrice", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("nodeLabels", new NamedObjectType("nodeLabels", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("nodeTaints", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            ResourceType_managedClusters = new ResourceType("Microsoft.ContainerService/managedClusters", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerService/managedClusters'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedClusterProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => ManagedClusterIdentity, TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2020-02-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_managedClusters);
            ResourceType_managedClusters_agentPools = new ResourceType("Microsoft.ContainerService/managedClusters/agentPools", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerService/managedClusters/agentPools'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => ManagedClusterAgentPoolProfileProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-02-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_managedClusters_agentPools);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_managedClusters, () => InstanceLazy.Value.ResourceType_managedClusters);
            registrar.RegisterType(ResourceTypeReference_managedClusters_agentPools, () => InstanceLazy.Value.ResourceType_managedClusters_agentPools);
        }
        private readonly ResourceType ResourceType_managedClusters;
        private readonly ResourceType ResourceType_managedClusters_agentPools;
        private readonly TypeSymbol ManagedClusterProperties;
        private readonly TypeSymbol ManagedClusterAgentPoolProfile;
        private readonly TypeSymbol ContainerServiceLinuxProfile;
        private readonly TypeSymbol ContainerServiceSshConfiguration;
        private readonly TypeSymbol ContainerServiceSshPublicKey;
        private readonly TypeSymbol ManagedClusterWindowsProfile;
        private readonly TypeSymbol ManagedClusterServicePrincipalProfile;
        private readonly TypeSymbol ManagedClusterAddonProfile;
        private readonly TypeSymbol ManagedClusterAddonProfileIdentity;
        private readonly TypeSymbol ContainerServiceNetworkProfile;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfile;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileManagedOutboundIPs;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileOutboundIPPrefixes;
        private readonly TypeSymbol ResourceReference;
        private readonly TypeSymbol ManagedClusterLoadBalancerProfileOutboundIPs;
        private readonly TypeSymbol ManagedClusterAADProfile;
        private readonly TypeSymbol ManagedClusterPropertiesAutoScalerProfile;
        private readonly TypeSymbol ManagedClusterAPIServerAccessProfile;
        private readonly TypeSymbol Componentsqit0etschemasmanagedclusterpropertiespropertiesidentityprofileadditionalproperties;
        private readonly TypeSymbol ManagedClusterIdentity;
        private readonly TypeSymbol ManagedClusterAgentPoolProfileProperties;
    }
}
