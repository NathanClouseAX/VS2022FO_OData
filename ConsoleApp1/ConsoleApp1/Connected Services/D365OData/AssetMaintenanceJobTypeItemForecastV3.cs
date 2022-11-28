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
    /// There are no comments for AssetMaintenanceJobTypeItemForecastV3Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceJobTypeItemForecastV3Single")]
    public partial class AssetMaintenanceJobTypeItemForecastV3Single : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeItemForecastV3>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeItemForecastV3Single object.
        /// </summary>
        public AssetMaintenanceJobTypeItemForecastV3Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeItemForecastV3Single object.
        /// </summary>
        public AssetMaintenanceJobTypeItemForecastV3Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeItemForecastV3Single object.
        /// </summary>
        public AssetMaintenanceJobTypeItemForecastV3Single(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeItemForecastV3> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceJobTypeItemForecastV3 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ForecastEntryNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ForecastEntryNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceJobTypeItemForecastsV3")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceJobTypeItemForecastV3")]
    public partial class AssetMaintenanceJobTypeItemForecastV3 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceJobTypeItemForecastV3 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="forecastEntryNumber">Initial value of ForecastEntryNumber.</param>
        /// <param name="forecastCostPrice">Initial value of ForecastCostPrice.</param>
        /// <param name="forecastSalesQuantity">Initial value of ForecastSalesQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceJobTypeItemForecastV3 CreateAssetMaintenanceJobTypeItemForecastV3(string dataAreaId, string forecastEntryNumber, decimal forecastCostPrice, decimal forecastSalesQuantity)
        {
            AssetMaintenanceJobTypeItemForecastV3 assetMaintenanceJobTypeItemForecastV3 = new AssetMaintenanceJobTypeItemForecastV3();
            assetMaintenanceJobTypeItemForecastV3.DataAreaId = dataAreaId;
            assetMaintenanceJobTypeItemForecastV3.ForecastEntryNumber = forecastEntryNumber;
            assetMaintenanceJobTypeItemForecastV3.ForecastCostPrice = forecastCostPrice;
            assetMaintenanceJobTypeItemForecastV3.ForecastSalesQuantity = forecastSalesQuantity;
            return assetMaintenanceJobTypeItemForecastV3;
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
        /// There are no comments for Property ForecastEntryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastEntryNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastEntryNumber is required.")]
        public virtual string ForecastEntryNumber
        {
            get
            {
                return this._ForecastEntryNumber;
            }
            set
            {
                this.OnForecastEntryNumberChanging(value);
                this._ForecastEntryNumber = value;
                this.OnForecastEntryNumberChanged();
                this.OnPropertyChanged("ForecastEntryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastEntryNumber;
        partial void OnForecastEntryNumberChanging(string value);
        partial void OnForecastEntryNumberChanged();
        /// <summary>
        /// There are no comments for Property StorageSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StorageSiteId")]
        public virtual string StorageSiteId
        {
            get
            {
                return this._StorageSiteId;
            }
            set
            {
                this.OnStorageSiteIdChanging(value);
                this._StorageSiteId = value;
                this.OnStorageSiteIdChanged();
                this.OnPropertyChanged("StorageSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StorageSiteId;
        partial void OnStorageSiteIdChanging(string value);
        partial void OnStorageSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastCostPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastCostPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastCostPrice is required.")]
        public virtual decimal ForecastCostPrice
        {
            get
            {
                return this._ForecastCostPrice;
            }
            set
            {
                this.OnForecastCostPriceChanging(value);
                this._ForecastCostPrice = value;
                this.OnForecastCostPriceChanged();
                this.OnPropertyChanged("ForecastCostPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ForecastCostPrice;
        partial void OnForecastCostPriceChanging(decimal value);
        partial void OnForecastCostPriceChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
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
        /// There are no comments for Property ModelProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelProductId")]
        public virtual string ModelProductId
        {
            get
            {
                return this._ModelProductId;
            }
            set
            {
                this.OnModelProductIdChanging(value);
                this._ModelProductId = value;
                this.OnModelProductIdChanged();
                this.OnPropertyChanged("ModelProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelProductId;
        partial void OnModelProductIdChanging(string value);
        partial void OnModelProductIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
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
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobVariantId")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersionId")]
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
        /// There are no comments for Property FunctionalLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FunctionalLocationId")]
        public virtual string FunctionalLocationId
        {
            get
            {
                return this._FunctionalLocationId;
            }
            set
            {
                this.OnFunctionalLocationIdChanging(value);
                this._FunctionalLocationId = value;
                this.OnFunctionalLocationIdChanged();
                this.OnPropertyChanged("FunctionalLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationId;
        partial void OnFunctionalLocationIdChanging(string value);
        partial void OnFunctionalLocationIdChanged();
        /// <summary>
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTradeId")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetTypeId")]
        public virtual string MaintenanceAssetTypeId
        {
            get
            {
                return this._MaintenanceAssetTypeId;
            }
            set
            {
                this.OnMaintenanceAssetTypeIdChanging(value);
                this._MaintenanceAssetTypeId = value;
                this.OnMaintenanceAssetTypeIdChanged();
                this.OnPropertyChanged("MaintenanceAssetTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetTypeId;
        partial void OnMaintenanceAssetTypeIdChanging(string value);
        partial void OnMaintenanceAssetTypeIdChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTypeId")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property StorageLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StorageLocationId")]
        public virtual string StorageLocationId
        {
            get
            {
                return this._StorageLocationId;
            }
            set
            {
                this.OnStorageLocationIdChanging(value);
                this._StorageLocationId = value;
                this.OnStorageLocationIdChanged();
                this.OnPropertyChanged("StorageLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StorageLocationId;
        partial void OnStorageLocationIdChanging(string value);
        partial void OnStorageLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastModelId")]
        public virtual string ForecastModelId
        {
            get
            {
                return this._ForecastModelId;
            }
            set
            {
                this.OnForecastModelIdChanging(value);
                this._ForecastModelId = value;
                this.OnForecastModelIdChanged();
                this.OnPropertyChanged("ForecastModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastModelId;
        partial void OnForecastModelIdChanging(string value);
        partial void OnForecastModelIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastSalesUnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastSalesUnitId")]
        public virtual string ForecastSalesUnitId
        {
            get
            {
                return this._ForecastSalesUnitId;
            }
            set
            {
                this.OnForecastSalesUnitIdChanging(value);
                this._ForecastSalesUnitId = value;
                this.OnForecastSalesUnitIdChanged();
                this.OnPropertyChanged("ForecastSalesUnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastSalesUnitId;
        partial void OnForecastSalesUnitIdChanging(string value);
        partial void OnForecastSalesUnitIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastItemId")]
        public virtual string ForecastItemId
        {
            get
            {
                return this._ForecastItemId;
            }
            set
            {
                this.OnForecastItemIdChanging(value);
                this._ForecastItemId = value;
                this.OnForecastItemIdChanged();
                this.OnPropertyChanged("ForecastItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastItemId;
        partial void OnForecastItemIdChanging(string value);
        partial void OnForecastItemIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastSalesQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastSalesQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ForecastSalesQuantity is required.")]
        public virtual decimal ForecastSalesQuantity
        {
            get
            {
                return this._ForecastSalesQuantity;
            }
            set
            {
                this.OnForecastSalesQuantityChanging(value);
                this._ForecastSalesQuantity = value;
                this.OnForecastSalesQuantityChanged();
                this.OnPropertyChanged("ForecastSalesQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ForecastSalesQuantity;
        partial void OnForecastSalesQuantityChanging(decimal value);
        partial void OnForecastSalesQuantityChanged();
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductId")]
        public virtual string ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductId;
        partial void OnProductIdChanging(string value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property StorageWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StorageWarehouseId")]
        public virtual string StorageWarehouseId
        {
            get
            {
                return this._StorageWarehouseId;
            }
            set
            {
                this.OnStorageWarehouseIdChanging(value);
                this._StorageWarehouseId = value;
                this.OnStorageWarehouseIdChanged();
                this.OnPropertyChanged("StorageWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StorageWarehouseId;
        partial void OnStorageWarehouseIdChanging(string value);
        partial void OnStorageWarehouseIdChanged();
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
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelId")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastProjectLinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastProjectLinePropertyId")]
        public virtual string ForecastProjectLinePropertyId
        {
            get
            {
                return this._ForecastProjectLinePropertyId;
            }
            set
            {
                this.OnForecastProjectLinePropertyIdChanging(value);
                this._ForecastProjectLinePropertyId = value;
                this.OnForecastProjectLinePropertyIdChanged();
                this.OnPropertyChanged("ForecastProjectLinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastProjectLinePropertyId;
        partial void OnForecastProjectLinePropertyIdChanging(string value);
        partial void OnForecastProjectLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property ForecastCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastCurrency")]
        public virtual string ForecastCurrency
        {
            get
            {
                return this._ForecastCurrency;
            }
            set
            {
                this.OnForecastCurrencyChanging(value);
                this._ForecastCurrency = value;
                this.OnForecastCurrencyChanged();
                this.OnPropertyChanged("ForecastCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastCurrency;
        partial void OnForecastCurrencyChanging(string value);
        partial void OnForecastCurrencyChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetId")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
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