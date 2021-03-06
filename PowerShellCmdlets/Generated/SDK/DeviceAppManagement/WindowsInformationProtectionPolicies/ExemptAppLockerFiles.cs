// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceReference]
    public class Get_DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String windowsInformationProtectionAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{windowsInformationProtectionAppLockerFileId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object to the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    [ResourceReference]
    public class New_DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String windowsInformationProtectionAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{windowsInformationProtectionAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    public class Update_DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String windowsInformationProtectionAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{windowsInformationProtectionAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/windowsInformationProtectionAppLockerFileId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object from the &quot;exemptAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input exempt apps through xml files</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("exemptAppLockerFileODataType")]
    public class Remove_DeviceAppManagement_WindowsInformationProtectionPolicies_ExemptAppLockerFiles : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;exemptAppLockerFiles&quot; collection.")]
        public System.String windowsInformationProtectionAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.windowsInformationProtectionPolicy&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateSet(@"microsoft.graph.windowsInformationProtectionPolicy")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/exemptAppLockerFiles/{windowsInformationProtectionAppLockerFileId}";
        }
    }
}