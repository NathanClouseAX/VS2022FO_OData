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
    /// There are no comments for WarehouseOnHandV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseOnHandV2Single")]
    public partial class WarehouseOnHandV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseOnHandV2>
    {
        /// <summary>
        /// Initialize a new WarehouseOnHandV2Single object.
        /// </summary>
        public WarehouseOnHandV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseOnHandV2Single object.
        /// </summary>
        public WarehouseOnHandV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseOnHandV2Single object.
        /// </summary>
        public WarehouseOnHandV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseOnHandV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WarehouseOnHandV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemNumber
    /// ProductColorId
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductStyleId
    /// ProductVersionId
    /// InventorySiteId
    /// InventoryWarehouseId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber", "ProductColorId", "ProductConfigurationId", "ProductSizeId", "ProductStyleId", "ProductVersionId", "InventorySiteId", "InventoryWarehouseId")]
    [global::Microsoft.OData.Client.EntitySet("WarehousesOnHandV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseOnHandV2")]
    public partial class WarehouseOnHandV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseOnHandV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="inventorySiteId">Initial value of InventorySiteId.</param>
        /// <param name="inventoryWarehouseId">Initial value of InventoryWarehouseId.</param>
        /// <param name="availableOnHandQuantity">Initial value of AvailableOnHandQuantity.</param>
        /// <param name="reservedOnHandQuantity">Initial value of ReservedOnHandQuantity.</param>
        /// <param name="availableOrderedQuantity">Initial value of AvailableOrderedQuantity.</param>
        /// <param name="reservedOrderedQuantity">Initial value of ReservedOrderedQuantity.</param>
        /// <param name="onHandQuantity">Initial value of OnHandQuantity.</param>
        /// <param name="orderedQuantity">Initial value of OrderedQuantity.</param>
        /// <param name="onOrderQuantity">Initial value of OnOrderQuantity.</param>
        /// <param name="totalAvailableQuantity">Initial value of TotalAvailableQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseOnHandV2 CreateWarehouseOnHandV2(string dataAreaId, 
                    string itemNumber, 
                    string productColorId, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productStyleId, 
                    string productVersionId, 
                    string inventorySiteId, 
                    string inventoryWarehouseId, 
                    decimal availableOnHandQuantity, 
                    decimal reservedOnHandQuantity, 
                    decimal availableOrderedQuantity, 
                    decimal reservedOrderedQuantity, 
                    decimal onHandQuantity, 
                    decimal orderedQuantity, 
                    decimal onOrderQuantity, 
                    decimal totalAvailableQuantity)
        {
            WarehouseOnHandV2 warehouseOnHandV2 = new WarehouseOnHandV2();
            warehouseOnHandV2.DataAreaId = dataAreaId;
            warehouseOnHandV2.ItemNumber = itemNumber;
            warehouseOnHandV2.ProductColorId = productColorId;
            warehouseOnHandV2.ProductConfigurationId = productConfigurationId;
            warehouseOnHandV2.ProductSizeId = productSizeId;
            warehouseOnHandV2.ProductStyleId = productStyleId;
            warehouseOnHandV2.ProductVersionId = productVersionId;
            warehouseOnHandV2.InventorySiteId = inventorySiteId;
            warehouseOnHandV2.InventoryWarehouseId = inventoryWarehouseId;
            warehouseOnHandV2.AvailableOnHandQuantity = availableOnHandQuantity;
            warehouseOnHandV2.ReservedOnHandQuantity = reservedOnHandQuantity;
            warehouseOnHandV2.AvailableOrderedQuantity = availableOrderedQuantity;
            warehouseOnHandV2.ReservedOrderedQuantity = reservedOrderedQuantity;
            warehouseOnHandV2.OnHandQuantity = onHandQuantity;
            warehouseOnHandV2.OrderedQuantity = orderedQuantity;
            warehouseOnHandV2.OnOrderQuantity = onOrderQuantity;
            warehouseOnHandV2.TotalAvailableQuantity = totalAvailableQuantity;
            return warehouseOnHandV2;
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
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemNumber is required.")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
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
        /// There are no comments for Property InventorySiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventorySiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventorySiteId is required.")]
        public virtual string InventorySiteId
        {
            get
            {
                return this._InventorySiteId;
            }
            set
            {
                this.OnInventorySiteIdChanging(value);
                this._InventorySiteId = value;
                this.OnInventorySiteIdChanged();
                this.OnPropertyChanged("InventorySiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventorySiteId;
        partial void OnInventorySiteIdChanging(string value);
        partial void OnInventorySiteIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryWarehouseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventoryWarehouseId is required.")]
        public virtual string InventoryWarehouseId
        {
            get
            {
                return this._InventoryWarehouseId;
            }
            set
            {
                this.OnInventoryWarehouseIdChanging(value);
                this._InventoryWarehouseId = value;
                this.OnInventoryWarehouseIdChanged();
                this.OnPropertyChanged("InventoryWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryWarehouseId;
        partial void OnInventoryWarehouseIdChanging(string value);
        partial void OnInventoryWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property AvailableOnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AvailableOnHandQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AvailableOnHandQuantity is required.")]
        public virtual decimal AvailableOnHandQuantity
        {
            get
            {
                return this._AvailableOnHandQuantity;
            }
            set
            {
                this.OnAvailableOnHandQuantityChanging(value);
                this._AvailableOnHandQuantity = value;
                this.OnAvailableOnHandQuantityChanged();
                this.OnPropertyChanged("AvailableOnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOnHandQuantity;
        partial void OnAvailableOnHandQuantityChanging(decimal value);
        partial void OnAvailableOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property ReservedOnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReservedOnHandQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReservedOnHandQuantity is required.")]
        public virtual decimal ReservedOnHandQuantity
        {
            get
            {
                return this._ReservedOnHandQuantity;
            }
            set
            {
                this.OnReservedOnHandQuantityChanging(value);
                this._ReservedOnHandQuantity = value;
                this.OnReservedOnHandQuantityChanged();
                this.OnPropertyChanged("ReservedOnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOnHandQuantity;
        partial void OnReservedOnHandQuantityChanging(decimal value);
        partial void OnReservedOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property AvailableOrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AvailableOrderedQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AvailableOrderedQuantity is required.")]
        public virtual decimal AvailableOrderedQuantity
        {
            get
            {
                return this._AvailableOrderedQuantity;
            }
            set
            {
                this.OnAvailableOrderedQuantityChanging(value);
                this._AvailableOrderedQuantity = value;
                this.OnAvailableOrderedQuantityChanged();
                this.OnPropertyChanged("AvailableOrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AvailableOrderedQuantity;
        partial void OnAvailableOrderedQuantityChanging(decimal value);
        partial void OnAvailableOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductName")]
        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property ReservedOrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReservedOrderedQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReservedOrderedQuantity is required.")]
        public virtual decimal ReservedOrderedQuantity
        {
            get
            {
                return this._ReservedOrderedQuantity;
            }
            set
            {
                this.OnReservedOrderedQuantityChanging(value);
                this._ReservedOrderedQuantity = value;
                this.OnReservedOrderedQuantityChanged();
                this.OnPropertyChanged("ReservedOrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReservedOrderedQuantity;
        partial void OnReservedOrderedQuantityChanging(decimal value);
        partial void OnReservedOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnHandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnHandQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OnHandQuantity is required.")]
        public virtual decimal OnHandQuantity
        {
            get
            {
                return this._OnHandQuantity;
            }
            set
            {
                this.OnOnHandQuantityChanging(value);
                this._OnHandQuantity = value;
                this.OnOnHandQuantityChanged();
                this.OnPropertyChanged("OnHandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnHandQuantity;
        partial void OnOnHandQuantityChanging(decimal value);
        partial void OnOnHandQuantityChanged();
        /// <summary>
        /// There are no comments for Property AreWarehouseManagementProcessesUsed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AreWarehouseManagementProcessesUsed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreWarehouseManagementProcessesUsed
        {
            get
            {
                return this._AreWarehouseManagementProcessesUsed;
            }
            set
            {
                this.OnAreWarehouseManagementProcessesUsedChanging(value);
                this._AreWarehouseManagementProcessesUsed = value;
                this.OnAreWarehouseManagementProcessesUsedChanged();
                this.OnPropertyChanged("AreWarehouseManagementProcessesUsed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreWarehouseManagementProcessesUsed;
        partial void OnAreWarehouseManagementProcessesUsedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreWarehouseManagementProcessesUsedChanged();
        /// <summary>
        /// There are no comments for Property OrderedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderedQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OrderedQuantity is required.")]
        public virtual decimal OrderedQuantity
        {
            get
            {
                return this._OrderedQuantity;
            }
            set
            {
                this.OnOrderedQuantityChanging(value);
                this._OrderedQuantity = value;
                this.OnOrderedQuantityChanged();
                this.OnPropertyChanged("OrderedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OrderedQuantity;
        partial void OnOrderedQuantityChanging(decimal value);
        partial void OnOrderedQuantityChanged();
        /// <summary>
        /// There are no comments for Property OnOrderQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnOrderQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OnOrderQuantity is required.")]
        public virtual decimal OnOrderQuantity
        {
            get
            {
                return this._OnOrderQuantity;
            }
            set
            {
                this.OnOnOrderQuantityChanging(value);
                this._OnOrderQuantity = value;
                this.OnOnOrderQuantityChanged();
                this.OnPropertyChanged("OnOrderQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OnOrderQuantity;
        partial void OnOnOrderQuantityChanging(decimal value);
        partial void OnOnOrderQuantityChanged();
        /// <summary>
        /// There are no comments for Property TotalAvailableQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAvailableQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalAvailableQuantity is required.")]
        public virtual decimal TotalAvailableQuantity
        {
            get
            {
                return this._TotalAvailableQuantity;
            }
            set
            {
                this.OnTotalAvailableQuantityChanging(value);
                this._TotalAvailableQuantity = value;
                this.OnTotalAvailableQuantityChanged();
                this.OnPropertyChanged("TotalAvailableQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalAvailableQuantity;
        partial void OnTotalAvailableQuantityChanging(decimal value);
        partial void OnTotalAvailableQuantityChanged();
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
