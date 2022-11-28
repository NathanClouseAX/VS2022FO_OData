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
    /// There are no comments for ProductColorGroupLineV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineV2Single")]
    public partial class ProductColorGroupLineV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLineV2>
    {
        /// <summary>
        /// Initialize a new ProductColorGroupLineV2Single object.
        /// </summary>
        public ProductColorGroupLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineV2Single object.
        /// </summary>
        public ProductColorGroupLineV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineV2Single object.
        /// </summary>
        public ProductColorGroupLineV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLineV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductColorGroupLineV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductColorGroupId
    /// ColorName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductColorGroupId", "ColorName")]
    [global::Microsoft.OData.Client.EntitySet("ProductColorGroupLineV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineV2")]
    public partial class ProductColorGroupLineV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductColorGroupLineV2 object.
        /// </summary>
        /// <param name="productColorGroupId">Initial value of ProductColorGroupId.</param>
        /// <param name="colorName">Initial value of ColorName.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductColorGroupLineV2 CreateProductColorGroupLineV2(string productColorGroupId, string colorName, decimal displayOrder, int replenishmentWeight)
        {
            ProductColorGroupLineV2 productColorGroupLineV2 = new ProductColorGroupLineV2();
            productColorGroupLineV2.ProductColorGroupId = productColorGroupId;
            productColorGroupLineV2.ColorName = colorName;
            productColorGroupLineV2.DisplayOrder = displayOrder;
            productColorGroupLineV2.ReplenishmentWeight = replenishmentWeight;
            return productColorGroupLineV2;
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
        /// There are no comments for Property ColorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColorName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ColorName is required.")]
        public virtual string ColorName
        {
            get
            {
                return this._ColorName;
            }
            set
            {
                this.OnColorNameChanging(value);
                this._ColorName = value;
                this.OnColorNameChanged();
                this.OnPropertyChanged("ColorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColorName;
        partial void OnColorNameChanging(string value);
        partial void OnColorNameChanged();
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
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
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
        /// There are no comments for Property ColorDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColorDescription")]
        public virtual string ColorDescription
        {
            get
            {
                return this._ColorDescription;
            }
            set
            {
                this.OnColorDescriptionChanging(value);
                this._ColorDescription = value;
                this.OnColorDescriptionChanged();
                this.OnPropertyChanged("ColorDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColorDescription;
        partial void OnColorDescriptionChanging(string value);
        partial void OnColorDescriptionChanged();
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
