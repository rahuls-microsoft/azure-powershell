// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>The list of available upgrades for compute pools.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterUpgradeProfileTypeConverter))]
    public partial class ManagedClusterUpgradeProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterUpgradeProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterUpgradeProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterUpgradeProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterUpgradeProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterUpgradeProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile) content.GetValueForProperty("ControlPlaneProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfile, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentPoolProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).AgentPoolProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile[]) content.GetValueForProperty("AgentPoolProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).AgentPoolProfile, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileTypeConverter.ConvertFrom));
            }
            if (content.Contains("ControlPlaneProfileOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileOSType = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.OSType) content.GetValueForProperty("ControlPlaneProfileOSType",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileOSType, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.OSType.CreateFrom);
            }
            if (content.Contains("ControlPlaneProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileKubernetesVersion = (string) content.GetValueForProperty("ControlPlaneProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileName = (string) content.GetValueForProperty("ControlPlaneProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfileUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfileUpgradesItem[]) content.GetValueForProperty("ControlPlaneProfileUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileUpgrade, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfileUpgradesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileUpgradesItemTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterUpgradeProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterUpgradeProfilePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile) content.GetValueForProperty("ControlPlaneProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfile, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentPoolProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).AgentPoolProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile[]) content.GetValueForProperty("AgentPoolProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).AgentPoolProfile, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfile>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileTypeConverter.ConvertFrom));
            }
            if (content.Contains("ControlPlaneProfileOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileOSType = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.OSType) content.GetValueForProperty("ControlPlaneProfileOSType",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileOSType, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.OSType.CreateFrom);
            }
            if (content.Contains("ControlPlaneProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileKubernetesVersion = (string) content.GetValueForProperty("ControlPlaneProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileName = (string) content.GetValueForProperty("ControlPlaneProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ControlPlaneProfileUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfileUpgradesItem[]) content.GetValueForProperty("ControlPlaneProfileUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterUpgradeProfileInternal)this).ControlPlaneProfileUpgrade, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterPoolUpgradeProfileUpgradesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPoolUpgradeProfileUpgradesItemTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The list of available upgrades for compute pools.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterUpgradeProfileTypeConverter))]
    public partial interface IManagedClusterUpgradeProfile

    {

    }
}