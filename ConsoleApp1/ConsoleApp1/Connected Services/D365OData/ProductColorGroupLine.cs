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
    /// There are no comments for ProductColorGroupLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineSingle")]
    public partial class ProductColorGroupLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLine>
    {
        /// <summary>
        /// Initialize a new ProductColorGroupLineSingle object.
        /// </summary>
        public ProductColorGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineSingle object.
        /// </summary>
        public ProductColorGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductColorGroupLineSingle object.
        /// </summary>
        public ProductColorGroupLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductColorGroupLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductColorGroupLineTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineTranslations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation> ProductColorGroupLineTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColorGroupLineTranslations == null))
                {
                    this._ProductColorGroupLineTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation>(GetPath("ProductColorGroupLineTranslations"));
                }
                return this._ProductColorGroupLineTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation> _ProductColorGroupLineTranslations;
        /// <summary>
        /// There are no comments for ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColor")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorSingle ProductColor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColor == null))
                {
                    this._ProductColor = new global::Microsoft.Dynamics.DataEntities.ProductColorSingle(this.Context, GetPath("ProductColor"));
                }
                return this._ProductColor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorSingle _ProductColor;
        /// <summary>
        /// There are no comments for ProductColorGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorGroupSingle ProductColorGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductColorGroup == null))
                {
                    this._ProductColorGroup = new global::Microsoft.Dynamics.DataEntities.ProductColorGroupSingle(this.Context, GetPath("ProductColorGroup"));
                }
                return this._ProductColorGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorGroupSingle _ProductColorGroup;
    }
    /// <summary>
    /// There are no comments for ProductColorGroupLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductColorGroupId
    /// ProductColorId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductColorGroupId", "ProductColorId")]
    [global::Microsoft.OData.Client.EntitySet("ProductColorGroupLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLine")]
    public partial class ProductColorGroupLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductColorGroupLine object.
        /// </summary>
        /// <param name="productColorGroupId">Initial value of ProductColorGroupId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="displayOrder">Initial value of DisplayOrder.</param>
        /// <param name="productColor">Initial value of ProductColor.</param>
        /// <param name="productColorGroup">Initial value of ProductColorGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductColorGroupLine CreateProductColorGroupLine(string productColorGroupId, 
                    string productColorId, 
                    int replenishmentWeight, 
                    decimal displayOrder, 
                    global::Microsoft.Dynamics.DataEntities.ProductColor productColor, 
                    global::Microsoft.Dynamics.DataEntities.ProductColorGroup productColorGroup)
        {
            ProductColorGroupLine productColorGroupLine = new ProductColorGroupLine();
            productColorGroupLine.ProductColorGroupId = productColorGroupId;
            productColorGroupLine.ProductColorId = productColorId;
            productColorGroupLine.ReplenishmentWeight = replenishmentWeight;
            productColorGroupLine.DisplayOrder = displayOrder;
            if ((productColor == null))
            {
                throw new global::System.ArgumentNullException("productColor");
            }
            productColorGroupLine.ProductColor = productColor;
            if ((productColorGroup == null))
            {
                throw new global::System.ArgumentNullException("productColorGroup");
            }
            productColorGroupLine.ProductColorGroup = productColorGroup;
            return productColorGroupLine;
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
        /// There are no comments for Property ColorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColorName")]
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
        /// There are no comments for Property ProductColorGroupLineTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroupLineTranslations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation> ProductColorGroupLineTranslations
        {
            get
            {
                return this._ProductColorGroupLineTranslations;
            }
            set
            {
                this.OnProductColorGroupLineTranslationsChanging(value);
                this._ProductColorGroupLineTranslations = value;
                this.OnProductColorGroupLineTranslationsChanged();
                this.OnPropertyChanged("ProductColorGroupLineTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation> _ProductColorGroupLineTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductColorGroupLineTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductColorGroupLineTranslation> value);
        partial void OnProductColorGroupLineTranslationsChanged();
        /// <summary>
        /// There are no comments for Property ProductColor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColor is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColor ProductColor
        {
            get
            {
                return this._ProductColor;
            }
            set
            {
                this.OnProductColorChanging(value);
                this._ProductColor = value;
                this.OnProductColorChanged();
                this.OnPropertyChanged("ProductColor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColor _ProductColor;
        partial void OnProductColorChanging(global::Microsoft.Dynamics.DataEntities.ProductColor value);
        partial void OnProductColorChanged();
        /// <summary>
        /// There are no comments for Property ProductColorGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductColorGroup ProductColorGroup
        {
            get
            {
                return this._ProductColorGroup;
            }
            set
            {
                this.OnProductColorGroupChanging(value);
                this._ProductColorGroup = value;
                this.OnProductColorGroupChanged();
                this.OnPropertyChanged("ProductColorGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductColorGroup _ProductColorGroup;
        partial void OnProductColorGroupChanging(global::Microsoft.Dynamics.DataEntities.ProductColorGroup value);
        partial void OnProductColorGroupChanged();
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
