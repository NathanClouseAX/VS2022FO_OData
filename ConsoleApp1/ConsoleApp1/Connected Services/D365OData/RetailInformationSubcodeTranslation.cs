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
    /// There are no comments for RetailInformationSubcodeTranslationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcodeTranslationSingle")]
    public partial class RetailInformationSubcodeTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInformationSubcodeTranslation>
    {
        /// <summary>
        /// Initialize a new RetailInformationSubcodeTranslationSingle object.
        /// </summary>
        public RetailInformationSubcodeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInformationSubcodeTranslationSingle object.
        /// </summary>
        public RetailInformationSubcodeTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInformationSubcodeTranslationSingle object.
        /// </summary>
        public RetailInformationSubcodeTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInformationSubcodeTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailInformationSubcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcode")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeSingle RetailInformationSubcode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInformationSubcode == null))
                {
                    this._RetailInformationSubcode = new global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeSingle(this.Context, GetPath("RetailInformationSubcode"));
                }
                return this._RetailInformationSubcode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInformationSubcodeSingle _RetailInformationSubcode;
    }
    /// <summary>
    /// There are no comments for RetailInformationSubcodeTranslation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InfocodeId
    /// SubcodeId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InfocodeId", "SubcodeId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("RetailInformationSubcodeTranslations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcodeTranslation")]
    public partial class RetailInformationSubcodeTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInformationSubcodeTranslation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="infocodeId">Initial value of InfocodeId.</param>
        /// <param name="subcodeId">Initial value of SubcodeId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="retailInformationSubcode">Initial value of RetailInformationSubcode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInformationSubcodeTranslation CreateRetailInformationSubcodeTranslation(string dataAreaId, string infocodeId, string subcodeId, string languageId, global::Microsoft.Dynamics.DataEntities.RetailInformationSubcode retailInformationSubcode)
        {
            RetailInformationSubcodeTranslation retailInformationSubcodeTranslation = new RetailInformationSubcodeTranslation();
            retailInformationSubcodeTranslation.DataAreaId = dataAreaId;
            retailInformationSubcodeTranslation.InfocodeId = infocodeId;
            retailInformationSubcodeTranslation.SubcodeId = subcodeId;
            retailInformationSubcodeTranslation.LanguageId = languageId;
            if ((retailInformationSubcode == null))
            {
                throw new global::System.ArgumentNullException("retailInformationSubcode");
            }
            retailInformationSubcodeTranslation.RetailInformationSubcode = retailInformationSubcode;
            return retailInformationSubcodeTranslation;
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
        /// There are no comments for Property InfocodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InfocodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InfocodeId is required.")]
        public virtual string InfocodeId
        {
            get
            {
                return this._InfocodeId;
            }
            set
            {
                this.OnInfocodeIdChanging(value);
                this._InfocodeId = value;
                this.OnInfocodeIdChanged();
                this.OnPropertyChanged("InfocodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InfocodeId;
        partial void OnInfocodeIdChanging(string value);
        partial void OnInfocodeIdChanged();
        /// <summary>
        /// There are no comments for Property SubcodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubcodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SubcodeId is required.")]
        public virtual string SubcodeId
        {
            get
            {
                return this._SubcodeId;
            }
            set
            {
                this.OnSubcodeIdChanging(value);
                this._SubcodeId = value;
                this.OnSubcodeIdChanged();
                this.OnPropertyChanged("SubcodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubcodeId;
        partial void OnSubcodeIdChanging(string value);
        partial void OnSubcodeIdChanged();
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
        /// There are no comments for Property RetailInformationSubcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInformationSubcode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailInformationSubcode is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInformationSubcode RetailInformationSubcode
        {
            get
            {
                return this._RetailInformationSubcode;
            }
            set
            {
                this.OnRetailInformationSubcodeChanging(value);
                this._RetailInformationSubcode = value;
                this.OnRetailInformationSubcodeChanged();
                this.OnPropertyChanged("RetailInformationSubcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInformationSubcode _RetailInformationSubcode;
        partial void OnRetailInformationSubcodeChanging(global::Microsoft.Dynamics.DataEntities.RetailInformationSubcode value);
        partial void OnRetailInformationSubcodeChanged();
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
