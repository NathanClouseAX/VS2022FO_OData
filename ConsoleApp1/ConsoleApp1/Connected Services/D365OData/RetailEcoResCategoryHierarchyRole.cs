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
    /// There are no comments for RetailEcoResCategoryHierarchyRoleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailEcoResCategoryHierarchyRoleSingle")]
    public partial class RetailEcoResCategoryHierarchyRoleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailEcoResCategoryHierarchyRole>
    {
        /// <summary>
        /// Initialize a new RetailEcoResCategoryHierarchyRoleSingle object.
        /// </summary>
        public RetailEcoResCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailEcoResCategoryHierarchyRoleSingle object.
        /// </summary>
        public RetailEcoResCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailEcoResCategoryHierarchyRoleSingle object.
        /// </summary>
        public RetailEcoResCategoryHierarchyRoleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailEcoResCategoryHierarchyRole> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailEcoResCategoryHierarchyRole in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NamedCategoryHierarchyRoleAsInt
    /// EcoResCategoryHierarchy_Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("NamedCategoryHierarchyRoleAsInt", "EcoResCategoryHierarchy_Name")]
    [global::Microsoft.OData.Client.EntitySet("RetailEcoResCategoryHierarchyRole")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailEcoResCategoryHierarchyRole")]
    public partial class RetailEcoResCategoryHierarchyRole : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailEcoResCategoryHierarchyRole object.
        /// </summary>
        /// <param name="namedCategoryHierarchyRoleAsInt">Initial value of NamedCategoryHierarchyRoleAsInt.</param>
        /// <param name="ecoResCategoryHierarchy_Name">Initial value of EcoResCategoryHierarchy_Name.</param>
        /// <param name="categoryHierarchy">Initial value of CategoryHierarchy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailEcoResCategoryHierarchyRole CreateRetailEcoResCategoryHierarchyRole(int namedCategoryHierarchyRoleAsInt, string ecoResCategoryHierarchy_Name, long categoryHierarchy)
        {
            RetailEcoResCategoryHierarchyRole retailEcoResCategoryHierarchyRole = new RetailEcoResCategoryHierarchyRole();
            retailEcoResCategoryHierarchyRole.NamedCategoryHierarchyRoleAsInt = namedCategoryHierarchyRoleAsInt;
            retailEcoResCategoryHierarchyRole.EcoResCategoryHierarchy_Name = ecoResCategoryHierarchy_Name;
            retailEcoResCategoryHierarchyRole.CategoryHierarchy = categoryHierarchy;
            return retailEcoResCategoryHierarchyRole;
        }
        /// <summary>
        /// There are no comments for Property NamedCategoryHierarchyRoleAsInt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NamedCategoryHierarchyRoleAsInt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NamedCategoryHierarchyRoleAsInt is required.")]
        public virtual int NamedCategoryHierarchyRoleAsInt
        {
            get
            {
                return this._NamedCategoryHierarchyRoleAsInt;
            }
            set
            {
                this.OnNamedCategoryHierarchyRoleAsIntChanging(value);
                this._NamedCategoryHierarchyRoleAsInt = value;
                this.OnNamedCategoryHierarchyRoleAsIntChanged();
                this.OnPropertyChanged("NamedCategoryHierarchyRoleAsInt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NamedCategoryHierarchyRoleAsInt;
        partial void OnNamedCategoryHierarchyRoleAsIntChanging(int value);
        partial void OnNamedCategoryHierarchyRoleAsIntChanged();
        /// <summary>
        /// There are no comments for Property EcoResCategoryHierarchy_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EcoResCategoryHierarchy_Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EcoResCategoryHierarchy_Name is required.")]
        public virtual string EcoResCategoryHierarchy_Name
        {
            get
            {
                return this._EcoResCategoryHierarchy_Name;
            }
            set
            {
                this.OnEcoResCategoryHierarchy_NameChanging(value);
                this._EcoResCategoryHierarchy_Name = value;
                this.OnEcoResCategoryHierarchy_NameChanged();
                this.OnPropertyChanged("EcoResCategoryHierarchy_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EcoResCategoryHierarchy_Name;
        partial void OnEcoResCategoryHierarchy_NameChanging(string value);
        partial void OnEcoResCategoryHierarchy_NameChanged();
        /// <summary>
        /// There are no comments for Property NamedCategoryHierarchyRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NamedCategoryHierarchyRole")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> NamedCategoryHierarchyRole
        {
            get
            {
                return this._NamedCategoryHierarchyRole;
            }
            set
            {
                this.OnNamedCategoryHierarchyRoleChanging(value);
                this._NamedCategoryHierarchyRole = value;
                this.OnNamedCategoryHierarchyRoleChanged();
                this.OnPropertyChanged("NamedCategoryHierarchyRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> _NamedCategoryHierarchyRole;
        partial void OnNamedCategoryHierarchyRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResCategoryNamedHierarchyRole> value);
        partial void OnNamedCategoryHierarchyRoleChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryHierarchy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryHierarchy is required.")]
        public virtual long CategoryHierarchy
        {
            get
            {
                return this._CategoryHierarchy;
            }
            set
            {
                this.OnCategoryHierarchyChanging(value);
                this._CategoryHierarchy = value;
                this.OnCategoryHierarchyChanged();
                this.OnPropertyChanged("CategoryHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CategoryHierarchy;
        partial void OnCategoryHierarchyChanging(long value);
        partial void OnCategoryHierarchyChanged();
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
