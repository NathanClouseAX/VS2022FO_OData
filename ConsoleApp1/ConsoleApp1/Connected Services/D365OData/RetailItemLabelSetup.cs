//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/27/2022 9:27:22 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for RetailItemLabelSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailItemLabelSetupSingle")]
    public partial class RetailItemLabelSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailItemLabelSetup>
    {
        /// <summary>
        /// Initialize a new RetailItemLabelSetupSingle object.
        /// </summary>
        public RetailItemLabelSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailItemLabelSetupSingle object.
        /// </summary>
        public RetailItemLabelSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailItemLabelSetupSingle object.
        /// </summary>
        public RetailItemLabelSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailItemLabelSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailItemLabelSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LabelType
    /// ItemId
    /// OrganizationHierarchyTypeName
    /// OrganizationPartyNumber
    /// ReportName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LabelType", "ItemId", "OrganizationHierarchyTypeName", "OrganizationPartyNumber", "ReportName")]
    [global::Microsoft.OData.Client.EntitySet("RetailItemLabelSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailItemLabelSetup")]
    public partial class RetailItemLabelSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailItemLabelSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="organizationHierarchyTypeName">Initial value of OrganizationHierarchyTypeName.</param>
        /// <param name="organizationPartyNumber">Initial value of OrganizationPartyNumber.</param>
        /// <param name="reportName">Initial value of ReportName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailItemLabelSetup CreateRetailItemLabelSetup(string dataAreaId, string itemId, string organizationHierarchyTypeName, string organizationPartyNumber, string reportName)
        {
            RetailItemLabelSetup retailItemLabelSetup = new RetailItemLabelSetup();
            retailItemLabelSetup.DataAreaId = dataAreaId;
            retailItemLabelSetup.ItemId = itemId;
            retailItemLabelSetup.OrganizationHierarchyTypeName = organizationHierarchyTypeName;
            retailItemLabelSetup.OrganizationPartyNumber = organizationPartyNumber;
            retailItemLabelSetup.ReportName = reportName;
            return retailItemLabelSetup;
        }
        /// <summary>
        /// There are no comments for Property DataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("dataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataAreaId is required.")]
        public virtual string DataAreaId
        {
            get
            {
                return this._DataAreaId;
            }
            set
            {
                this.OnDataAreaIdChanging(value);
                this._DataAreaId = value;
                this.OnDataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataAreaId;
        partial void OnDataAreaIdChanging(string value);
        partial void OnDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property LabelType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LabelType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> LabelType
        {
            get
            {
                return this._LabelType;
            }
            set
            {
                this.OnLabelTypeChanging(value);
                this._LabelType = value;
                this.OnLabelTypeChanged();
                this.OnPropertyChanged("LabelType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> _LabelType;
        partial void OnLabelTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> value);
        partial void OnLabelTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property OrganizationHierarchyTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationHierarchyTypeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OrganizationHierarchyTypeName is required.")]
        public virtual string OrganizationHierarchyTypeName
        {
            get
            {
                return this._OrganizationHierarchyTypeName;
            }
            set
            {
                this.OnOrganizationHierarchyTypeNameChanging(value);
                this._OrganizationHierarchyTypeName = value;
                this.OnOrganizationHierarchyTypeNameChanged();
                this.OnPropertyChanged("OrganizationHierarchyTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationHierarchyTypeName;
        partial void OnOrganizationHierarchyTypeNameChanging(string value);
        partial void OnOrganizationHierarchyTypeNameChanged();
        /// <summary>
        /// There are no comments for Property OrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationPartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OrganizationPartyNumber is required.")]
        public virtual string OrganizationPartyNumber
        {
            get
            {
                return this._OrganizationPartyNumber;
            }
            set
            {
                this.OnOrganizationPartyNumberChanging(value);
                this._OrganizationPartyNumber = value;
                this.OnOrganizationPartyNumberChanged();
                this.OnPropertyChanged("OrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationPartyNumber;
        partial void OnOrganizationPartyNumberChanging(string value);
        partial void OnOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ReportName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReportName is required.")]
        public virtual string ReportName
        {
            get
            {
                return this._ReportName;
            }
            set
            {
                this.OnReportNameChanging(value);
                this._ReportName = value;
                this.OnReportNameChanged();
                this.OnPropertyChanged("ReportName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportName;
        partial void OnReportNameChanging(string value);
        partial void OnReportNameChanged();
        /// <summary>
        /// There are no comments for Property Text1IsItemDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text1IsItemDescription")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Text1IsItemDescription
        {
            get
            {
                return this._Text1IsItemDescription;
            }
            set
            {
                this.OnText1IsItemDescriptionChanging(value);
                this._Text1IsItemDescription = value;
                this.OnText1IsItemDescriptionChanged();
                this.OnPropertyChanged("Text1IsItemDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Text1IsItemDescription;
        partial void OnText1IsItemDescriptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnText1IsItemDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Text1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text1")]
        public virtual string Text1
        {
            get
            {
                return this._Text1;
            }
            set
            {
                this.OnText1Changing(value);
                this._Text1 = value;
                this.OnText1Changed();
                this.OnPropertyChanged("Text1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text1;
        partial void OnText1Changing(string value);
        partial void OnText1Changed();
        /// <summary>
        /// There are no comments for Property Text2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text2")]
        public virtual string Text2
        {
            get
            {
                return this._Text2;
            }
            set
            {
                this.OnText2Changing(value);
                this._Text2 = value;
                this.OnText2Changed();
                this.OnPropertyChanged("Text2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text2;
        partial void OnText2Changing(string value);
        partial void OnText2Changed();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
