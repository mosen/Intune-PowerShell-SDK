// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;parentSection&quot; object.</para>
    ///     <para type="description">GET ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection</para>
    ///     <para type="description">Retrieves the &quot;parentSection&quot; object (which is of type &quot;microsoft.graph.onenoteSection&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_Notebooks_Sections_Pages_ParentSection", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.onenoteSection")]
    [ResourceReference]
    public class Get_Me_Onenote_Notebooks_Sections_Pages_ParentSection : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionLinks")]
        [Selectable]
        [Sortable]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String pagesUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [Expandable]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Sortable]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onenoteSection&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection</para>
    ///     <para type="description">Creates the &quot;parentSection&quot; object (which is of type &quot;microsoft.graph.onenoteSection&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_Notebooks_Sections_Pages_ParentSection", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.onenoteSection")]
    [ODataType("microsoft.graph.onenoteSection")]
    [ResourceReference]
    public class New_Me_Onenote_Notebooks_Sections_Pages_ParentSection : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String pagesUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onenoteSection&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection</para>
    ///     <para type="description">Updates the &quot;parentSection&quot; object (which is of type &quot;microsoft.graph.onenoteSection&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_Notebooks_Sections_Pages_ParentSection", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.onenoteSection")]
    [ODataType("microsoft.graph.onenoteSection")]
    public class Update_Me_Onenote_Notebooks_Sections_Pages_ParentSection : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isDefault { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionLinks")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;links&quot; property, of type &quot;microsoft.graph.sectionLinks&quot;.")]
        public System.Object links { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pagesUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String pagesUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentNotebook&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object parentNotebook { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentSectionGroup&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object parentSectionGroup { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteSection&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteSection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onenoteSection&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection</para>
    ///     <para type="description">Removes the &quot;parentSection&quot; object (which is of type &quot;microsoft.graph.onenoteSection&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_Notebooks_Sections_Pages_ParentSection", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteSection")]
    public class Remove_Me_Onenote_Notebooks_Sections_Pages_ParentSection : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection/copyToNotebook</para>
    ///     <para type="description">The action &quot;microsoft.graph.copyToNotebook&quot;, which exists on the type &quot;microsoft.graph.onenoteSection&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_Notebooks_Sections_Pages_ParentSection_CopyToNotebook", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteSection")]
    public class Invoke_Me_Onenote_Notebooks_Sections_Pages_ParentSection_CopyToNotebook : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.")]
        public System.String id { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.")]
        public System.String renameAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.")]
        public System.String siteCollectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToNotebook&quot; action.")]
        public System.String siteId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection/copyToNotebook";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection/copyToSectionGroup</para>
    ///     <para type="description">The action &quot;microsoft.graph.copyToSectionGroup&quot;, which exists on the type &quot;microsoft.graph.onenoteSection&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.onenoteOperation&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Onenote_Notebooks_Sections_Pages_ParentSection_CopyToSectionGroup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteSection")]
    public class Invoke_Me_Onenote_Notebooks_Sections_Pages_ParentSection_CopyToSectionGroup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;id&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.")]
        public System.String id { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;renameAs&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.")]
        public System.String renameAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteCollectionId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.")]
        public System.String siteCollectionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;siteId&quot; parameter, which is accepted by the &quot;microsoft.graph.copyToSectionGroup&quot; action.")]
        public System.String siteId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenotePage&quot; object in the &quot;pages&quot; collection.")]
        public System.String pageId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.onenoteSection&quot; object in the &quot;sections&quot; collection.")]
        public System.String sectionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.notebook&quot; object in the &quot;notebooks&quot; collection.")]
        public System.String notebookId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/notebooks/{notebookId}/sections/{sectionId}/pages/{pageId}/parentSection/copyToSectionGroup";
        }
    }
}