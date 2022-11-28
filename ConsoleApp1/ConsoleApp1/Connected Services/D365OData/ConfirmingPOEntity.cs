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
    /// There are no comments for ConfirmingPOEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmingPOEntitySingle")]
    public partial class ConfirmingPOEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConfirmingPOEntity>
    {
        /// <summary>
        /// Initialize a new ConfirmingPOEntitySingle object.
        /// </summary>
        public ConfirmingPOEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConfirmingPOEntitySingle object.
        /// </summary>
        public ConfirmingPOEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConfirmingPOEntitySingle object.
        /// </summary>
        public ConfirmingPOEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConfirmingPOEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ConfirmingPOEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ConfirmingPOID
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ConfirmingPOID", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ConfirmingPOEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmingPOEntity")]
    public partial class ConfirmingPOEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConfirmingPOEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="confirmingPOID">Initial value of ConfirmingPOID.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConfirmingPOEntity CreateConfirmingPOEntity(string dataAreaId, string confirmingPOID, string languageId)
        {
            ConfirmingPOEntity confirmingPOEntity = new ConfirmingPOEntity();
            confirmingPOEntity.DataAreaId = dataAreaId;
            confirmingPOEntity.ConfirmingPOID = confirmingPOID;
            confirmingPOEntity.LanguageId = languageId;
            return confirmingPOEntity;
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
        /// There are no comments for Property ConfirmingPOID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmingPOID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConfirmingPOID is required.")]
        public virtual string ConfirmingPOID
        {
            get
            {
                return this._ConfirmingPOID;
            }
            set
            {
                this.OnConfirmingPOIDChanging(value);
                this._ConfirmingPOID = value;
                this.OnConfirmingPOIDChanged();
                this.OnPropertyChanged("ConfirmingPOID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfirmingPOID;
        partial void OnConfirmingPOIDChanging(string value);
        partial void OnConfirmingPOIDChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LanguageId is required.")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
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
        /// There are no comments for Property ConfirmingPOMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmingPOMessage")]
        public virtual string ConfirmingPOMessage
        {
            get
            {
                return this._ConfirmingPOMessage;
            }
            set
            {
                this.OnConfirmingPOMessageChanging(value);
                this._ConfirmingPOMessage = value;
                this.OnConfirmingPOMessageChanged();
                this.OnPropertyChanged("ConfirmingPOMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfirmingPOMessage;
        partial void OnConfirmingPOMessageChanging(string value);
        partial void OnConfirmingPOMessageChanged();
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
