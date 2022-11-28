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
    /// There are no comments for VoidedSalesOrderLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderLineSingle")]
    public partial class VoidedSalesOrderLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VoidedSalesOrderLine>
    {
        /// <summary>
        /// Initialize a new VoidedSalesOrderLineSingle object.
        /// </summary>
        public VoidedSalesOrderLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VoidedSalesOrderLineSingle object.
        /// </summary>
        public VoidedSalesOrderLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VoidedSalesOrderLineSingle object.
        /// </summary>
        public VoidedSalesOrderLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VoidedSalesOrderLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VoidedSalesOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderHeader")]
        public virtual global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeaderSingle VoidedSalesOrderHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VoidedSalesOrderHeader == null))
                {
                    this._VoidedSalesOrderHeader = new global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeaderSingle(this.Context, GetPath("VoidedSalesOrderHeader"));
                }
                return this._VoidedSalesOrderHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeaderSingle _VoidedSalesOrderHeader;
    }
    /// <summary>
    /// There are no comments for VoidedSalesOrderLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InventoryLotId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InventoryLotId")]
    [global::Microsoft.OData.Client.EntitySet("VoidedSalesOrderLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderLine")]
    public partial class VoidedSalesOrderLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VoidedSalesOrderLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="inventoryLotId">Initial value of InventoryLotId.</param>
        /// <param name="lineAmount">Initial value of LineAmount.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="voidedSalesOrderHeader">Initial value of VoidedSalesOrderHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VoidedSalesOrderLine CreateVoidedSalesOrderLine(string dataAreaId, string inventoryLotId, decimal lineAmount, decimal lineNumber, global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeader voidedSalesOrderHeader)
        {
            VoidedSalesOrderLine voidedSalesOrderLine = new VoidedSalesOrderLine();
            voidedSalesOrderLine.DataAreaId = dataAreaId;
            voidedSalesOrderLine.InventoryLotId = inventoryLotId;
            voidedSalesOrderLine.LineAmount = lineAmount;
            voidedSalesOrderLine.LineNumber = lineNumber;
            if ((voidedSalesOrderHeader == null))
            {
                throw new global::System.ArgumentNullException("voidedSalesOrderHeader");
            }
            voidedSalesOrderLine.VoidedSalesOrderHeader = voidedSalesOrderHeader;
            return voidedSalesOrderLine;
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
        /// There are no comments for Property InventoryLotId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryLotId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventoryLotId is required.")]
        public virtual string InventoryLotId
        {
            get
            {
                return this._InventoryLotId;
            }
            set
            {
                this.OnInventoryLotIdChanging(value);
                this._InventoryLotId = value;
                this.OnInventoryLotIdChanged();
                this.OnPropertyChanged("InventoryLotId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryLotId;
        partial void OnInventoryLotIdChanging(string value);
        partial void OnInventoryLotIdChanged();
        /// <summary>
        /// There are no comments for Property ItemBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBatchNumber")]
        public virtual string ItemBatchNumber
        {
            get
            {
                return this._ItemBatchNumber;
            }
            set
            {
                this.OnItemBatchNumberChanging(value);
                this._ItemBatchNumber = value;
                this.OnItemBatchNumberChanged();
                this.OnPropertyChanged("ItemBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemBatchNumber;
        partial void OnItemBatchNumberChanging(string value);
        partial void OnItemBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property ProjectActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectActivityNumber")]
        public virtual string ProjectActivityNumber
        {
            get
            {
                return this._ProjectActivityNumber;
            }
            set
            {
                this.OnProjectActivityNumberChanging(value);
                this._ProjectActivityNumber = value;
                this.OnProjectActivityNumberChanged();
                this.OnPropertyChanged("ProjectActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectActivityNumber;
        partial void OnProjectActivityNumberChanging(string value);
        partial void OnProjectActivityNumberChanged();
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
        /// There are no comments for Property ProjectCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectCategoryId")]
        public virtual string ProjectCategoryId
        {
            get
            {
                return this._ProjectCategoryId;
            }
            set
            {
                this.OnProjectCategoryIdChanging(value);
                this._ProjectCategoryId = value;
                this.OnProjectCategoryIdChanged();
                this.OnPropertyChanged("ProjectCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectCategoryId;
        partial void OnProjectCategoryIdChanging(string value);
        partial void OnProjectCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property OrderedInventoryStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderedInventoryStatusId")]
        public virtual string OrderedInventoryStatusId
        {
            get
            {
                return this._OrderedInventoryStatusId;
            }
            set
            {
                this.OnOrderedInventoryStatusIdChanging(value);
                this._OrderedInventoryStatusId = value;
                this.OnOrderedInventoryStatusIdChanged();
                this.OnPropertyChanged("OrderedInventoryStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderedInventoryStatusId;
        partial void OnOrderedInventoryStatusIdChanging(string value);
        partial void OnOrderedInventoryStatusIdChanged();
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
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderNumber")]
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property LineDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineDescription")]
        public virtual string LineDescription
        {
            get
            {
                return this._LineDescription;
            }
            set
            {
                this.OnLineDescriptionChanging(value);
                this._LineDescription = value;
                this.OnLineDescriptionChanged();
                this.OnPropertyChanged("LineDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineDescription;
        partial void OnLineDescriptionChanging(string value);
        partial void OnLineDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
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
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectId")]
        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property ShippingWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingWarehouseId")]
        public virtual string ShippingWarehouseId
        {
            get
            {
                return this._ShippingWarehouseId;
            }
            set
            {
                this.OnShippingWarehouseIdChanging(value);
                this._ShippingWarehouseId = value;
                this.OnShippingWarehouseIdChanged();
                this.OnPropertyChanged("ShippingWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingWarehouseId;
        partial void OnShippingWarehouseIdChanging(string value);
        partial void OnShippingWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property OrderingCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderingCustomerAccountNumber")]
        public virtual string OrderingCustomerAccountNumber
        {
            get
            {
                return this._OrderingCustomerAccountNumber;
            }
            set
            {
                this.OnOrderingCustomerAccountNumberChanging(value);
                this._OrderingCustomerAccountNumber = value;
                this.OnOrderingCustomerAccountNumberChanged();
                this.OnPropertyChanged("OrderingCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderingCustomerAccountNumber;
        partial void OnOrderingCustomerAccountNumberChanging(string value);
        partial void OnOrderingCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceCustomerAccountNumber")]
        public virtual string InvoiceCustomerAccountNumber
        {
            get
            {
                return this._InvoiceCustomerAccountNumber;
            }
            set
            {
                this.OnInvoiceCustomerAccountNumberChanging(value);
                this._InvoiceCustomerAccountNumber = value;
                this.OnInvoiceCustomerAccountNumberChanged();
                this.OnPropertyChanged("InvoiceCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceCustomerAccountNumber;
        partial void OnInvoiceCustomerAccountNumberChanging(string value);
        partial void OnInvoiceCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ShippingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingSiteId")]
        public virtual string ShippingSiteId
        {
            get
            {
                return this._ShippingSiteId;
            }
            set
            {
                this.OnShippingSiteIdChanging(value);
                this._ShippingSiteId = value;
                this.OnShippingSiteIdChanged();
                this.OnPropertyChanged("ShippingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingSiteId;
        partial void OnShippingSiteIdChanging(string value);
        partial void OnShippingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property LineAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineAmount is required.")]
        public virtual decimal LineAmount
        {
            get
            {
                return this._LineAmount;
            }
            set
            {
                this.OnLineAmountChanging(value);
                this._LineAmount = value;
                this.OnLineAmountChanged();
                this.OnPropertyChanged("LineAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineAmount;
        partial void OnLineAmountChanging(decimal value);
        partial void OnLineAmountChanged();
        /// <summary>
        /// There are no comments for Property SalesProductCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesProductCategoryName")]
        public virtual string SalesProductCategoryName
        {
            get
            {
                return this._SalesProductCategoryName;
            }
            set
            {
                this.OnSalesProductCategoryNameChanging(value);
                this._SalesProductCategoryName = value;
                this.OnSalesProductCategoryNameChanged();
                this.OnPropertyChanged("SalesProductCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesProductCategoryName;
        partial void OnSalesProductCategoryNameChanging(string value);
        partial void OnSalesProductCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property VoidedSalesOrderHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderHeader")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VoidedSalesOrderHeader is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeader VoidedSalesOrderHeader
        {
            get
            {
                return this._VoidedSalesOrderHeader;
            }
            set
            {
                this.OnVoidedSalesOrderHeaderChanging(value);
                this._VoidedSalesOrderHeader = value;
                this.OnVoidedSalesOrderHeaderChanged();
                this.OnPropertyChanged("VoidedSalesOrderHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeader _VoidedSalesOrderHeader;
        partial void OnVoidedSalesOrderHeaderChanging(global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderHeader value);
        partial void OnVoidedSalesOrderHeaderChanged();
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
