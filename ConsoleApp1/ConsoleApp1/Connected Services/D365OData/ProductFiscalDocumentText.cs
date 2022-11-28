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
    /// There are no comments for ProductFiscalDocumentTextSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductFiscalDocumentTextSingle")]
    public partial class ProductFiscalDocumentTextSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductFiscalDocumentText>
    {
        /// <summary>
        /// Initialize a new ProductFiscalDocumentTextSingle object.
        /// </summary>
        public ProductFiscalDocumentTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductFiscalDocumentTextSingle object.
        /// </summary>
        public ProductFiscalDocumentTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductFiscalDocumentTextSingle object.
        /// </summary>
        public ProductFiscalDocumentTextSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductFiscalDocumentText> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductFiscalDocumentText in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Item
    /// FiscalDocumentText
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Item", "FiscalDocumentText")]
    [global::Microsoft.OData.Client.EntitySet("ProductFiscalDocumentTexts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductFiscalDocumentText")]
    public partial class ProductFiscalDocumentText : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductFiscalDocumentText object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="item">Initial value of Item.</param>
        /// <param name="fiscalDocumentText">Initial value of FiscalDocumentText.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductFiscalDocumentText CreateProductFiscalDocumentText(string dataAreaId, string item, string fiscalDocumentText)
        {
            ProductFiscalDocumentText productFiscalDocumentText = new ProductFiscalDocumentText();
            productFiscalDocumentText.DataAreaId = dataAreaId;
            productFiscalDocumentText.Item = item;
            productFiscalDocumentText.FiscalDocumentText = fiscalDocumentText;
            return productFiscalDocumentText;
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
        /// There are no comments for Property Item in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Item")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Item is required.")]
        public virtual string Item
        {
            get
            {
                return this._Item;
            }
            set
            {
                this.OnItemChanging(value);
                this._Item = value;
                this.OnItemChanged();
                this.OnPropertyChanged("Item");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Item;
        partial void OnItemChanging(string value);
        partial void OnItemChanged();
        /// <summary>
        /// There are no comments for Property FiscalDocumentText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentText")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalDocumentText is required.")]
        public virtual string FiscalDocumentText
        {
            get
            {
                return this._FiscalDocumentText;
            }
            set
            {
                this.OnFiscalDocumentTextChanging(value);
                this._FiscalDocumentText = value;
                this.OnFiscalDocumentTextChanged();
                this.OnPropertyChanged("FiscalDocumentText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalDocumentText;
        partial void OnFiscalDocumentTextChanging(string value);
        partial void OnFiscalDocumentTextChanged();
        /// <summary>
        /// There are no comments for Property FiscalInformation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalInformation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FiscalInformation
        {
            get
            {
                return this._FiscalInformation;
            }
            set
            {
                this.OnFiscalInformationChanging(value);
                this._FiscalInformation = value;
                this.OnFiscalInformationChanged();
                this.OnPropertyChanged("FiscalInformation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FiscalInformation;
        partial void OnFiscalInformationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFiscalInformationChanged();
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
        /// There are no comments for Property Restriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Restriction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> Restriction
        {
            get
            {
                return this._Restriction;
            }
            set
            {
                this.OnRestrictionChanging(value);
                this._Restriction = value;
                this.OnRestrictionChanged();
                this.OnPropertyChanged("Restriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _Restriction;
        partial void OnRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnRestrictionChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalDocumentTextType_BR> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalDocumentTextType_BR> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalDocumentTextType_BR> value);
        partial void OnTypeChanged();
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
