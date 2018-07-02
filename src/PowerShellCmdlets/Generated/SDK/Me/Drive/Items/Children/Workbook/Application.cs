// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;application&quot; object.</para>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/children/{childId}/workbook/application</para>
    ///     <para type="description">Retrieves the &quot;application&quot; object (which is of type &quot;microsoft.graph.workbookApplication&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Items_Children_Workbook_Application", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookApplication")]
    [ResourceReference]
    public class Get_Me_Drive_Items_Children_Workbook_Application : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookApplication&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String calculationMode { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/workbook/application";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookApplication&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/children/{childId}/workbook/application</para>
    ///     <para type="description">Creates the &quot;application&quot; object (which is of type &quot;microsoft.graph.workbookApplication&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Items_Children_Workbook_Application", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookApplication")]
    [ODataType("microsoft.graph.workbookApplication")]
    [ResourceReference]
    public class New_Me_Drive_Items_Children_Workbook_Application : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookApplication&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookApplication", HelpMessage = @"The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String calculationMode { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/workbook/application";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookApplication&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/items/{itemId}/children/{childId}/workbook/application</para>
    ///     <para type="description">Updates the &quot;application&quot; object (which is of type &quot;microsoft.graph.workbookApplication&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Items_Children_Workbook_Application", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookApplication")]
    [ODataType("microsoft.graph.workbookApplication")]
    public class Update_Me_Drive_Items_Children_Workbook_Application : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookApplication&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbookApplication", HelpMessage = @"The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;calculationMode&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String calculationMode { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/workbook/application";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookApplication&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/items/{itemId}/children/{childId}/workbook/application</para>
    ///     <para type="description">Removes the &quot;application&quot; object (which is of type &quot;microsoft.graph.workbookApplication&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Items_Children_Workbook_Application", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookApplication")]
    public class Remove_Me_Drive_Items_Children_Workbook_Application : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/workbook/application";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/items/{itemId}/children/{childId}/workbook/application/calculate</para>
    ///     <para type="description">The action &quot;microsoft.graph.calculate&quot;, which exists on the type &quot;microsoft.graph.workbookApplication&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Items_Children_Workbook_Application_Calculate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookApplication")]
    public class Invoke_Me_Drive_Items_Children_Workbook_Application_Calculate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;calculationType&quot; parameter, which is accepted by the &quot;microsoft.graph.calculate&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;calculationType&quot; parameter, which is accepted by the &quot;microsoft.graph.calculate&quot; action.")]
        public System.String calculationType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/workbook/application/calculate";
        }
    }
}