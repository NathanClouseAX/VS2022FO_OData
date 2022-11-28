﻿//------------------------------------------------------------------------------
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
    /// There are no comments for ResourceCategorySharedSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceCategorySharedSingle")]
    public partial class ResourceCategorySharedSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCategoryShared>
    {
        /// <summary>
        /// Initialize a new ResourceCategorySharedSingle object.
        /// </summary>
        public ResourceCategorySharedSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ResourceCategorySharedSingle object.
        /// </summary>
        public ResourceCategorySharedSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ResourceCategorySharedSingle object.
        /// </summary>
        public ResourceCategorySharedSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCategoryShared> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ResourceCategoryShared in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RoleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RoleId")]
    [global::Microsoft.OData.Client.EntitySet("ResourceCategoriesShared")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceCategoryShared")]
    public partial class ResourceCategoryShared : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ResourceCategoryShared object.
        /// </summary>
        /// <param name="roleId">Initial value of RoleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ResourceCategoryShared CreateResourceCategoryShared(string roleId)
        {
            ResourceCategoryShared resourceCategoryShared = new ResourceCategoryShared();
            resourceCategoryShared.RoleId = roleId;
            return resourceCategoryShared;
        }
        /// <summary>
        /// There are no comments for Property RoleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RoleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoleId is required.")]
        public virtual string RoleId
        {
            get
            {
                return this._RoleId;
            }
            set
            {
                this.OnRoleIdChanging(value);
                this._RoleId = value;
                this.OnRoleIdChanged();
                this.OnPropertyChanged("RoleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoleId;
        partial void OnRoleIdChanging(string value);
        partial void OnRoleIdChanged();
        /// <summary>
        /// There are no comments for Property IsCategoryDisabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCategoryDisabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> IsCategoryDisabled
        {
            get
            {
                return this._IsCategoryDisabled;
            }
            set
            {
                this.OnIsCategoryDisabledChanging(value);
                this._IsCategoryDisabled = value;
                this.OnIsCategoryDisabledChanged();
                this.OnPropertyChanged("IsCategoryDisabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> _IsCategoryDisabled;
        partial void OnIsCategoryDisabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> value);
        partial void OnIsCategoryDisabledChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
