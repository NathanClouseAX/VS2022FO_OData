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
    /// There are no comments for OrganizationHierarchyPurposeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationHierarchyPurposeSingle")]
    public partial class OrganizationHierarchyPurposeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OrganizationHierarchyPurpose>
    {
        /// <summary>
        /// Initialize a new OrganizationHierarchyPurposeSingle object.
        /// </summary>
        public OrganizationHierarchyPurposeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OrganizationHierarchyPurposeSingle object.
        /// </summary>
        public OrganizationHierarchyPurposeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OrganizationHierarchyPurposeSingle object.
        /// </summary>
        public OrganizationHierarchyPurposeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OrganizationHierarchyPurpose> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for OrganizationHierarchyPurpose in the schema.
    /// </summary>
    /// <KeyProperties>
    /// HierarchyPurpose
    /// HierarchyType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HierarchyPurpose", "HierarchyType")]
    [global::Microsoft.OData.Client.EntitySet("OrganizationHierarchyPurposes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationHierarchyPurpose")]
    public partial class OrganizationHierarchyPurpose : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OrganizationHierarchyPurpose object.
        /// </summary>
        /// <param name="hierarchyType">Initial value of HierarchyType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OrganizationHierarchyPurpose CreateOrganizationHierarchyPurpose(string hierarchyType)
        {
            OrganizationHierarchyPurpose organizationHierarchyPurpose = new OrganizationHierarchyPurpose();
            organizationHierarchyPurpose.HierarchyType = hierarchyType;
            return organizationHierarchyPurpose;
        }
        /// <summary>
        /// There are no comments for Property HierarchyPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HierarchyPurpose")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HierarchyPurpose> HierarchyPurpose
        {
            get
            {
                return this._HierarchyPurpose;
            }
            set
            {
                this.OnHierarchyPurposeChanging(value);
                this._HierarchyPurpose = value;
                this.OnHierarchyPurposeChanged();
                this.OnPropertyChanged("HierarchyPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HierarchyPurpose> _HierarchyPurpose;
        partial void OnHierarchyPurposeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HierarchyPurpose> value);
        partial void OnHierarchyPurposeChanged();
        /// <summary>
        /// There are no comments for Property HierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HierarchyType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HierarchyType is required.")]
        public virtual string HierarchyType
        {
            get
            {
                return this._HierarchyType;
            }
            set
            {
                this.OnHierarchyTypeChanging(value);
                this._HierarchyType = value;
                this.OnHierarchyTypeChanged();
                this.OnPropertyChanged("HierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HierarchyType;
        partial void OnHierarchyTypeChanging(string value);
        partial void OnHierarchyTypeChanged();
        /// <summary>
        /// There are no comments for Property Immutable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Immutable")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Immutable
        {
            get
            {
                return this._Immutable;
            }
            set
            {
                this.OnImmutableChanging(value);
                this._Immutable = value;
                this.OnImmutableChanged();
                this.OnPropertyChanged("Immutable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Immutable;
        partial void OnImmutableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnImmutableChanged();
        /// <summary>
        /// There are no comments for Property SetAsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SetAsDefault")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SetAsDefault
        {
            get
            {
                return this._SetAsDefault;
            }
            set
            {
                this.OnSetAsDefaultChanging(value);
                this._SetAsDefault = value;
                this.OnSetAsDefaultChanged();
                this.OnPropertyChanged("SetAsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SetAsDefault;
        partial void OnSetAsDefaultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSetAsDefaultChanged();
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
