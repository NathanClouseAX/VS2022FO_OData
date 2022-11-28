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
    /// There are no comments for ProductStyleGroupLineV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleGroupLineV2Single")]
    public partial class ProductStyleGroupLineV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLineV2>
    {
        /// <summary>
        /// Initialize a new ProductStyleGroupLineV2Single object.
        /// </summary>
        public ProductStyleGroupLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineV2Single object.
        /// </summary>
        public ProductStyleGroupLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductStyleGroupLineV2Single object.
        /// </summary>
        public ProductStyleGroupLineV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductStyleGroupLineV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductStyleGroupLineV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductStyleGroupId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductStyleGroupId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("ProductStyleGroupLineV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleGroupLineV2")]
    public partial class ProductStyleGroupLineV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductStyleGroupLineV2 object.
        /// </summary>
        /// <param name="productStyleGroupId">Initial value of ProductStyleGroupId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductStyleGroupLineV2 CreateProductStyleGroupLineV2(string productStyleGroupId, string productStyleId, int replenishmentWeight, decimal displayOrder)
        {
            ProductStyleGroupLineV2 productStyleGroupLineV2 = new ProductStyleGroupLineV2();
            productStyleGroupLineV2.ProductStyleGroupId = productStyleGroupId;
            productStyleGroupLineV2.ProductStyleId = productStyleId;
            productStyleGroupLineV2.ReplenishmentWeight = replenishmentWeight;
            productStyleGroupLineV2.DisplayOrder = displayOrder;
            return productStyleGroupLineV2;
        }
        /// <summary>
        /// There are no comments for Property ProductStyleGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleGroupId is required.")]
        public virtual string ProductStyleGroupId
        {
            get
            {
                return this._ProductStyleGroupId;
            }
            set
            {
                this.OnProductStyleGroupIdChanging(value);
                this._ProductStyleGroupId = value;
                this.OnProductStyleGroupIdChanged();
                this.OnPropertyChanged("ProductStyleGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleGroupId;
        partial void OnProductStyleGroupIdChanging(string value);
        partial void OnProductStyleGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleId is required.")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property RefinerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefinerGroup")]
        public virtual string RefinerGroup
        {
            get
            {
                return this._RefinerGroup;
            }
            set
            {
                this.OnRefinerGroupChanging(value);
                this._RefinerGroup = value;
                this.OnRefinerGroupChanged();
                this.OnPropertyChanged("RefinerGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefinerGroup;
        partial void OnRefinerGroupChanging(string value);
        partial void OnRefinerGroupChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReplenishmentWeight")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReplenishmentWeight is required.")]
        public virtual int ReplenishmentWeight
        {
            get
            {
                return this._ReplenishmentWeight;
            }
            set
            {
                this.OnReplenishmentWeightChanging(value);
                this._ReplenishmentWeight = value;
                this.OnReplenishmentWeightChanged();
                this.OnPropertyChanged("ReplenishmentWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplenishmentWeight;
        partial void OnReplenishmentWeightChanging(int value);
        partial void OnReplenishmentWeightChanged();
        /// <summary>
        /// There are no comments for Property StyleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StyleName")]
        public virtual string StyleName
        {
            get
            {
                return this._StyleName;
            }
            set
            {
                this.OnStyleNameChanging(value);
                this._StyleName = value;
                this.OnStyleNameChanged();
                this.OnPropertyChanged("StyleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StyleName;
        partial void OnStyleNameChanging(string value);
        partial void OnStyleNameChanged();
        /// <summary>
        /// There are no comments for Property StyleDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StyleDescription")]
        public virtual string StyleDescription
        {
            get
            {
                return this._StyleDescription;
            }
            set
            {
                this.OnStyleDescriptionChanging(value);
                this._StyleDescription = value;
                this.OnStyleDescriptionChanged();
                this.OnPropertyChanged("StyleDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StyleDescription;
        partial void OnStyleDescriptionChanging(string value);
        partial void OnStyleDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Hexcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Hexcode")]
        public virtual string Hexcode
        {
            get
            {
                return this._Hexcode;
            }
            set
            {
                this.OnHexcodeChanging(value);
                this._Hexcode = value;
                this.OnHexcodeChanged();
                this.OnPropertyChanged("Hexcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Hexcode;
        partial void OnHexcodeChanging(string value);
        partial void OnHexcodeChanged();
        /// <summary>
        /// There are no comments for Property DisplayOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplayOrder")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DisplayOrder is required.")]
        public virtual decimal DisplayOrder
        {
            get
            {
                return this._DisplayOrder;
            }
            set
            {
                this.OnDisplayOrderChanging(value);
                this._DisplayOrder = value;
                this.OnDisplayOrderChanged();
                this.OnPropertyChanged("DisplayOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplayOrder;
        partial void OnDisplayOrderChanging(decimal value);
        partial void OnDisplayOrderChanged();
        /// <summary>
        /// There are no comments for Property BarcodeNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeNumber")]
        public virtual string BarcodeNumber
        {
            get
            {
                return this._BarcodeNumber;
            }
            set
            {
                this.OnBarcodeNumberChanging(value);
                this._BarcodeNumber = value;
                this.OnBarcodeNumberChanged();
                this.OnPropertyChanged("BarcodeNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeNumber;
        partial void OnBarcodeNumberChanging(string value);
        partial void OnBarcodeNumberChanged();
        /// <summary>
        /// There are no comments for Property Url in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Url")]
        public virtual string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                this.OnUrlChanging(value);
                this._Url = value;
                this.OnUrlChanged();
                this.OnPropertyChanged("Url");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Url;
        partial void OnUrlChanging(string value);
        partial void OnUrlChanged();
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