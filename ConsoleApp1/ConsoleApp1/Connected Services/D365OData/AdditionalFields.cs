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
    /// There are no comments for AdditionalFieldsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalFieldsSingle")]
    public partial class AdditionalFieldsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdditionalFields>
    {
        /// <summary>
        /// Initialize a new AdditionalFieldsSingle object.
        /// </summary>
        public AdditionalFieldsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdditionalFieldsSingle object.
        /// </summary>
        public AdditionalFieldsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdditionalFieldsSingle object.
        /// </summary>
        public AdditionalFieldsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdditionalFields> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AdditionalFields in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FieldName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FieldName")]
    [global::Microsoft.OData.Client.EntitySet("AdditionalFields")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalFields")]
    public partial class AdditionalFields : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdditionalFields object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fieldName">Initial value of FieldName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdditionalFields CreateAdditionalFields(string dataAreaId, string fieldName)
        {
            AdditionalFields additionalFields = new AdditionalFields();
            additionalFields.DataAreaId = dataAreaId;
            additionalFields.FieldName = fieldName;
            return additionalFields;
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
        /// There are no comments for Property FieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FieldName is required.")]
        public virtual string FieldName
        {
            get
            {
                return this._FieldName;
            }
            set
            {
                this.OnFieldNameChanging(value);
                this._FieldName = value;
                this.OnFieldNameChanged();
                this.OnPropertyChanged("FieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldName;
        partial void OnFieldNameChanging(string value);
        partial void OnFieldNameChanged();
        /// <summary>
        /// There are no comments for Property UserEdit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserEdit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UserEdit
        {
            get
            {
                return this._UserEdit;
            }
            set
            {
                this.OnUserEditChanging(value);
                this._UserEdit = value;
                this.OnUserEditChanged();
                this.OnPropertyChanged("UserEdit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UserEdit;
        partial void OnUserEditChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUserEditChanged();
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
        /// There are no comments for Property IsHidden in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsHidden")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsHidden
        {
            get
            {
                return this._IsHidden;
            }
            set
            {
                this.OnIsHiddenChanging(value);
                this._IsHidden = value;
                this.OnIsHiddenChanged();
                this.OnPropertyChanged("IsHidden");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsHidden;
        partial void OnIsHiddenChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsHiddenChanged();
        /// <summary>
        /// There are no comments for Property IsCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCounter")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCounter
        {
            get
            {
                return this._IsCounter;
            }
            set
            {
                this.OnIsCounterChanging(value);
                this._IsCounter = value;
                this.OnIsCounterChanged();
                this.OnPropertyChanged("IsCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCounter;
        partial void OnIsCounterChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCounterChanged();
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
