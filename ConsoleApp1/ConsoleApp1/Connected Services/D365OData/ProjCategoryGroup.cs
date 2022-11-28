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
    /// There are no comments for ProjCategoryGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCategoryGroupSingle")]
    public partial class ProjCategoryGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjCategoryGroup>
    {
        /// <summary>
        /// Initialize a new ProjCategoryGroupSingle object.
        /// </summary>
        public ProjCategoryGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjCategoryGroupSingle object.
        /// </summary>
        public ProjCategoryGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjCategoryGroupSingle object.
        /// </summary>
        public ProjCategoryGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjCategoryGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjCategoryGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CategoryGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CategoryGroupId")]
    [global::Microsoft.OData.Client.EntitySet("ProjCategoryGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCategoryGroup")]
    public partial class ProjCategoryGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjCategoryGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="categoryGroupId">Initial value of CategoryGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjCategoryGroup CreateProjCategoryGroup(string dataAreaId, string categoryGroupId)
        {
            ProjCategoryGroup projCategoryGroup = new ProjCategoryGroup();
            projCategoryGroup.DataAreaId = dataAreaId;
            projCategoryGroup.CategoryGroupId = categoryGroupId;
            return projCategoryGroup;
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
        /// There are no comments for Property CategoryGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryGroupId is required.")]
        public virtual string CategoryGroupId
        {
            get
            {
                return this._CategoryGroupId;
            }
            set
            {
                this.OnCategoryGroupIdChanging(value);
                this._CategoryGroupId = value;
                this.OnCategoryGroupIdChanged();
                this.OnPropertyChanged("CategoryGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryGroupId;
        partial void OnCategoryGroupIdChanging(string value);
        partial void OnCategoryGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> CategoryType
        {
            get
            {
                return this._CategoryType;
            }
            set
            {
                this.OnCategoryTypeChanging(value);
                this._CategoryType = value;
                this.OnCategoryTypeChanged();
                this.OnPropertyChanged("CategoryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> _CategoryType;
        partial void OnCategoryTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> value);
        partial void OnCategoryTypeChanged();
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