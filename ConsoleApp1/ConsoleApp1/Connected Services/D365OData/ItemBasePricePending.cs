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
    /// There are no comments for ItemBasePricePendingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBasePricePendingSingle")]
    public partial class ItemBasePricePendingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemBasePricePending>
    {
        /// <summary>
        /// Initialize a new ItemBasePricePendingSingle object.
        /// </summary>
        public ItemBasePricePendingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemBasePricePendingSingle object.
        /// </summary>
        public ItemBasePricePendingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemBasePricePendingSingle object.
        /// </summary>
        public ItemBasePricePendingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemBasePricePending> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ItemBasePricePending in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PriceType
    /// ItemId
    /// VersionId
    /// FromDate
    /// ProductConfigurationId
    /// ProductColorId
    /// PriceWarehouseId
    /// PriceSiteId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PriceType", "ItemId", "VersionId", "FromDate", "ProductConfigurationId", "ProductColorId", "PriceWarehouseId", "PriceSiteId", "ProductSizeId", "ProductStyleId", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("ItemBasePricePending")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBasePricePending")]
    public partial class ItemBasePricePending : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemBasePricePending object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="versionId">Initial value of VersionId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="priceWarehouseId">Initial value of PriceWarehouseId.</param>
        /// <param name="priceSiteId">Initial value of PriceSiteId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="markup">Initial value of Markup.</param>
        /// <param name="price">Initial value of Price.</param>
        /// <param name="markupQty">Initial value of MarkupQty.</param>
        /// <param name="priceQty">Initial value of PriceQty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemBasePricePending CreateItemBasePricePending(string dataAreaId, 
                    string itemId, 
                    string versionId, 
                    global::System.DateTimeOffset fromDate, 
                    string productConfigurationId, 
                    string productColorId, 
                    string priceWarehouseId, 
                    string priceSiteId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    decimal markup, 
                    decimal price, 
                    decimal markupQty, 
                    decimal priceQty)
        {
            ItemBasePricePending itemBasePricePending = new ItemBasePricePending();
            itemBasePricePending.DataAreaId = dataAreaId;
            itemBasePricePending.ItemId = itemId;
            itemBasePricePending.VersionId = versionId;
            itemBasePricePending.FromDate = fromDate;
            itemBasePricePending.ProductConfigurationId = productConfigurationId;
            itemBasePricePending.ProductColorId = productColorId;
            itemBasePricePending.PriceWarehouseId = priceWarehouseId;
            itemBasePricePending.PriceSiteId = priceSiteId;
            itemBasePricePending.ProductSizeId = productSizeId;
            itemBasePricePending.ProductStyleId = productStyleId;
            itemBasePricePending.ProductVersionId = productVersionId;
            itemBasePricePending.Markup = markup;
            itemBasePricePending.Price = price;
            itemBasePricePending.MarkupQty = markupQty;
            itemBasePricePending.PriceQty = priceQty;
            return itemBasePricePending;
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
        /// There are no comments for Property PriceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPBasePriceType> PriceType
        {
            get
            {
                return this._PriceType;
            }
            set
            {
                this.OnPriceTypeChanging(value);
                this._PriceType = value;
                this.OnPriceTypeChanged();
                this.OnPropertyChanged("PriceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPBasePriceType> _PriceType;
        partial void OnPriceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPBasePriceType> value);
        partial void OnPriceTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property VersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionId is required.")]
        public virtual string VersionId
        {
            get
            {
                return this._VersionId;
            }
            set
            {
                this.OnVersionIdChanging(value);
                this._VersionId = value;
                this.OnVersionIdChanged();
                this.OnPropertyChanged("VersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VersionId;
        partial void OnVersionIdChanging(string value);
        partial void OnVersionIdChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromDate is required.")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductConfigurationId is required.")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
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
        /// There are no comments for Property PriceWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceWarehouseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceWarehouseId is required.")]
        public virtual string PriceWarehouseId
        {
            get
            {
                return this._PriceWarehouseId;
            }
            set
            {
                this.OnPriceWarehouseIdChanging(value);
                this._PriceWarehouseId = value;
                this.OnPriceWarehouseIdChanged();
                this.OnPropertyChanged("PriceWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceWarehouseId;
        partial void OnPriceWarehouseIdChanging(string value);
        partial void OnPriceWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property PriceSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceSiteId is required.")]
        public virtual string PriceSiteId
        {
            get
            {
                return this._PriceSiteId;
            }
            set
            {
                this.OnPriceSiteIdChanging(value);
                this._PriceSiteId = value;
                this.OnPriceSiteIdChanged();
                this.OnPropertyChanged("PriceSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceSiteId;
        partial void OnPriceSiteIdChanging(string value);
        partial void OnPriceSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductSizeId is required.")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersionId is required.")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property Markup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Markup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Markup is required.")]
        public virtual decimal Markup
        {
            get
            {
                return this._Markup;
            }
            set
            {
                this.OnMarkupChanging(value);
                this._Markup = value;
                this.OnMarkupChanged();
                this.OnPropertyChanged("Markup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Markup;
        partial void OnMarkupChanging(decimal value);
        partial void OnMarkupChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Price")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Price is required.")]
        public virtual decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property PriceAllocateMarkup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceAllocateMarkup")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PriceAllocateMarkup
        {
            get
            {
                return this._PriceAllocateMarkup;
            }
            set
            {
                this.OnPriceAllocateMarkupChanging(value);
                this._PriceAllocateMarkup = value;
                this.OnPriceAllocateMarkupChanged();
                this.OnPropertyChanged("PriceAllocateMarkup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PriceAllocateMarkup;
        partial void OnPriceAllocateMarkupChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPriceAllocateMarkupChanged();
        /// <summary>
        /// There are no comments for Property MarkupQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MarkupQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MarkupQty is required.")]
        public virtual decimal MarkupQty
        {
            get
            {
                return this._MarkupQty;
            }
            set
            {
                this.OnMarkupQtyChanging(value);
                this._MarkupQty = value;
                this.OnMarkupQtyChanged();
                this.OnPropertyChanged("MarkupQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MarkupQty;
        partial void OnMarkupQtyChanging(decimal value);
        partial void OnMarkupQtyChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitId")]
        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
        /// <summary>
        /// There are no comments for Property Calculated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Calculated")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Calculated
        {
            get
            {
                return this._Calculated;
            }
            set
            {
                this.OnCalculatedChanging(value);
                this._Calculated = value;
                this.OnCalculatedChanged();
                this.OnPropertyChanged("Calculated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Calculated;
        partial void OnCalculatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCalculatedChanged();
        /// <summary>
        /// There are no comments for Property PriceQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceQty is required.")]
        public virtual decimal PriceQty
        {
            get
            {
                return this._PriceQty;
            }
            set
            {
                this.OnPriceQtyChanging(value);
                this._PriceQty = value;
                this.OnPriceQtyChanged();
                this.OnPropertyChanged("PriceQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PriceQty;
        partial void OnPriceQtyChanging(decimal value);
        partial void OnPriceQtyChanged();
        /// <summary>
        /// There are no comments for Property ItemDisplayName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemDisplayName")]
        public virtual string ItemDisplayName
        {
            get
            {
                return this._ItemDisplayName;
            }
            set
            {
                this.OnItemDisplayNameChanging(value);
                this._ItemDisplayName = value;
                this.OnItemDisplayNameChanged();
                this.OnPropertyChanged("ItemDisplayName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemDisplayName;
        partial void OnItemDisplayNameChanging(string value);
        partial void OnItemDisplayNameChanged();
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