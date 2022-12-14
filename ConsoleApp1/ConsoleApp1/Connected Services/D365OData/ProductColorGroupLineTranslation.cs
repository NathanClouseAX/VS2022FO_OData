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
    /// There are no comments for ProductColorGroupLineTranslationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineTranslationSingle")]
    public partial class ProductColorGroupLineTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLineTranslation>
    {
        /// <summary>
        /// Initialize a new ProductColorGroupLineTranslationSingle object.
        /// </summary>
        public ProductColorGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineTranslationSingle object.
        /// </summary>
        public ProductColorGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineTranslationSingle object.
        /// </summary>
        public ProductColorGroupLineTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLineTranslation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductColorGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLine")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineSingle ProductColorGroupLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColorGroupLine == null))
                {
                    this._ProductColorGroupLine = new global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineSingle(this.Context, GetPath("ProductColorGroupLine"));
                }
                return this._ProductColorGroupLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineSingle _ProductColorGroupLine;
    }
    /// <summary>
    /// There are no comments for ProductColorGroupLineTranslation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductColorGroupId
    /// ProductColorId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductColorGroupId", "ProductColorId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("ProductColorGroupLineTranslations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineTranslation")]
    public partial class ProductColorGroupLineTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductColorGroupLineTranslation object.
        /// </summary>
        /// <param name="productColorGroupId">Initial value of ProductColorGroupId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="productColorGroupLine">Initial value of ProductColorGroupLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductColorGroupLineTranslation CreateProductColorGroupLineTranslation(string productColorGroupId, string productColorId, string languageId, global::Microsoft.Dynamics.DataEntities.ProductColorGroupLine productColorGroupLine)
        {
            ProductColorGroupLineTranslation productColorGroupLineTranslation = new ProductColorGroupLineTranslation();
            productColorGroupLineTranslation.ProductColorGroupId = productColorGroupId;
            productColorGroupLineTranslation.ProductColorId = productColorId;
            productColorGroupLineTranslation.LanguageId = languageId;
            if ((productColorGroupLine == null))
            {
                throw new global::System.ArgumentNullException("productColorGroupLine");
            }
            productColorGroupLineTranslation.ProductColorGroupLine = productColorGroupLine;
            return productColorGroupLineTranslation;
        }
        /// <summary>
        /// There are no comments for Property ProductColorGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorGroupId is required.")]
        public virtual string ProductColorGroupId
        {
            get
            {
                return this._ProductColorGroupId;
            }
            set
            {
                this.OnProductColorGroupIdChanging(value);
                this._ProductColorGroupId = value;
                this.OnProductColorGroupIdChanged();
                this.OnPropertyChanged("ProductColorGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorGroupId;
        partial void OnProductColorGroupIdChanging(string value);
        partial void OnProductColorGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorId is required.")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
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
        /// There are no comments for Property TranslatedColorDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TranslatedColorDescription")]
        public virtual string TranslatedColorDescription
        {
            get
            {
                return this._TranslatedColorDescription;
            }
            set
            {
                this.OnTranslatedColorDescriptionChanging(value);
                this._TranslatedColorDescription = value;
                this.OnTranslatedColorDescriptionChanged();
                this.OnPropertyChanged("TranslatedColorDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedColorDescription;
        partial void OnTranslatedColorDescriptionChanging(string value);
        partial void OnTranslatedColorDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TranslatedColorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TranslatedColorName")]
        public virtual string TranslatedColorName
        {
            get
            {
                return this._TranslatedColorName;
            }
            set
            {
                this.OnTranslatedColorNameChanging(value);
                this._TranslatedColorName = value;
                this.OnTranslatedColorNameChanged();
                this.OnPropertyChanged("TranslatedColorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TranslatedColorName;
        partial void OnTranslatedColorNameChanging(string value);
        partial void OnTranslatedColorNameChanged();
        /// <summary>
        /// There are no comments for Property ProductColorGroupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLine")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorGroupLine is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorGroupLine ProductColorGroupLine
        {
            get
            {
                return this._ProductColorGroupLine;
            }
            set
            {
                this.OnProductColorGroupLineChanging(value);
                this._ProductColorGroupLine = value;
                this.OnProductColorGroupLineChanged();
                this.OnPropertyChanged("ProductColorGroupLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorGroupLine _ProductColorGroupLine;
        partial void OnProductColorGroupLineChanging(global::Microsoft.Dynamics.DataEntities.ProductColorGroupLine value);
        partial void OnProductColorGroupLineChanged();
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
