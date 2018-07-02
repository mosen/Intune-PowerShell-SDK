// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; objects.</para>
    ///     <para type="description">GET ~/me/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; objects in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Get", "Me_DeviceManagementTroubleshootingEvents", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    [ResourceReference]
    public class Get_Me_DeviceManagementTroubleshootingEvents : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.enrollmentTroubleshootingEvent")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object.</para>
    ///     <para type="description">POST ~/me/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object to the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("New", "Me_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
    [ResourceReference]
    public class New_Me_DeviceManagementTroubleshootingEvents : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceManagementTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.enrollmentTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter enrollmentTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;userEnrollment&apos;, &apos;deviceEnrollmentManager&apos;, &apos;appleBulkWithUser&apos;, &apos;appleBulkWithoutUser&apos;, &apos;windowsAzureADJoin&apos;, &apos;windowsBulkUserless&apos;, &apos;windowsAutoEnrollment&apos;, &apos;windowsBulkAzureDomainJoin&apos;, &apos;windowsCoManagement&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [ValidateSet(@"unknown", @"userEnrollment", @"deviceEnrollmentManager", @"appleBulkWithUser", @"appleBulkWithoutUser", @"windowsAzureADJoin", @"windowsBulkUserless", @"windowsAutoEnrollment", @"windowsBulkAzureDomainJoin", @"windowsCoManagement")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;authentication&apos;, &apos;authorization&apos;, &apos;accountValidation&apos;, &apos;userValidation&apos;, &apos;deviceNotSupported&apos;, &apos;inMaintenance&apos;, &apos;badRequest&apos;, &apos;featureNotSupported&apos;, &apos;enrollmentRestrictionsEnforced&apos;, &apos;clientDisconnected&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [ValidateSet(@"unknown", @"authentication", @"authorization", @"accountValidation", @"userValidation", @"deviceNotSupported", @"inMaintenance", @"badRequest", @"featureNotSupported", @"enrollmentRestrictionsEnforced", @"clientDisconnected")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/deviceManagementTroubleshootingEvents";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot;.</para>
    ///     <para type="description">PATCH ~/me/deviceManagementTroubleshootingEvents</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Update", "Me_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    public class Update_Me_DeviceManagementTroubleshootingEvents : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.deviceManagementTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter deviceManagementTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Time when the event occurred .</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;eventDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset eventDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Id used for tracing the failure in the service.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.deviceManagementTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;correlationId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String correlationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"#microsoft.graph.enrollmentTroubleshootingEvent")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.")]
        public System.Management.Automation.SwitchParameter enrollmentTroubleshootingEvent { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Device identifier created or collected by Intune.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedDeviceIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String managedDeviceIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Operating System.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;operatingSystem&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String operatingSystem { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">OS Version.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;osVersion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String osVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Identifier for the user that tried to enroll the device.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Azure AD device identifier.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Type of the enrollment.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;userEnrollment&apos;, &apos;deviceEnrollmentManager&apos;, &apos;appleBulkWithUser&apos;, &apos;appleBulkWithoutUser&apos;, &apos;windowsAzureADJoin&apos;, &apos;windowsBulkUserless&apos;, &apos;windowsAutoEnrollment&apos;, &apos;windowsBulkAzureDomainJoin&apos;, &apos;windowsCoManagement&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentType")]
        [Selectable]
        [ValidateSet(@"unknown", @"userEnrollment", @"deviceEnrollmentManager", @"appleBulkWithUser", @"appleBulkWithoutUser", @"windowsAzureADJoin", @"windowsBulkUserless", @"windowsAutoEnrollment", @"windowsBulkAzureDomainJoin", @"windowsCoManagement")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enrollmentType&quot; property, of type &quot;microsoft.graph.deviceEnrollmentType&quot;.")]
        public System.String enrollmentType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Highlevel failure category.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;authentication&apos;, &apos;authorization&apos;, &apos;accountValidation&apos;, &apos;userValidation&apos;, &apos;deviceNotSupported&apos;, &apos;inMaintenance&apos;, &apos;badRequest&apos;, &apos;featureNotSupported&apos;, &apos;enrollmentRestrictionsEnforced&apos;, &apos;clientDisconnected&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.deviceEnrollmentFailureReason")]
        [Selectable]
        [ValidateSet(@"unknown", @"authentication", @"authorization", @"accountValidation", @"userValidation", @"deviceNotSupported", @"inMaintenance", @"badRequest", @"featureNotSupported", @"enrollmentRestrictionsEnforced", @"clientDisconnected")]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureCategory&quot; property, of type &quot;microsoft.graph.deviceEnrollmentFailureReason&quot;.")]
        public System.String failureCategory { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.enrollmentTroubleshootingEvent&quot; type.</para>
        ///     <para type="description">Detailed failure reason.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.enrollmentTroubleshootingEvent", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;failureReason&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String failureReason { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object.</para>
    ///     <para type="description">DELETE ~/me/deviceManagementTroubleshootingEvents/deviceManagementTroubleshootingEventId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object from the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
    ///     <para type="description">The list of troubleshooting events for this user.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_DeviceManagementTroubleshootingEvents", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceManagementTroubleshootingEvent")]
    [ResourceIdPropertyName("deviceManagementTroubleshootingEventId")]
    public class Remove_Me_DeviceManagementTroubleshootingEvents : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceManagementTroubleshootingEvent&quot; object in the &quot;deviceManagementTroubleshootingEvents&quot; collection.")]
        public System.String deviceManagementTroubleshootingEventId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEventId}";
        }
    }
}