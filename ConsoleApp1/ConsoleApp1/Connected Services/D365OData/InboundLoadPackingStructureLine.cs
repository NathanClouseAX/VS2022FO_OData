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
    /// There are no comments for InboundLoadPackingStructureLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InboundLoadPackingStructureLineSingle")]
    public partial class InboundLoadPackingStructureLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InboundLoadPackingStructureLine>
    {
        /// <summary>
        /// Initialize a new InboundLoadPackingStructureLineSingle object.
        /// </summary>
        public InboundLoadPackingStructureLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InboundLoadPackingStructureLineSingle object.
        /// </summary>
        public InboundLoadPackingStructureLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InboundLoadPackingStructureLineSingle object.
        /// </summary>
        public InboundLoadPackingStructureLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InboundLoadPackingStructureLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LoadPackingStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LoadPackingStructure")]
        public virtual global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructuresSingle LoadPackingStructure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LoadPackingStructure == null))
                {
                    this._LoadPackingStructure = new global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructuresSingle(this.Context, GetPath("LoadPackingStructure"));
                }
                return this._LoadPackingStructure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructuresSingle _LoadPackingStructure;
    }
    /// <summary>
    /// There are no comments for InboundLoadPackingStructureLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InboundShipmentId
    /// PackingStructureLicensePlateNumber
    /// ItemNumber
    /// ProductColorId
    /// ProductSizeId
    /// ProductConfigurationId
    /// ProductStyleId
    /// ItemBatchNumber
    /// ItemSerialNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InboundShipmentId", "PackingStructureLicensePlateNumber", "ItemNumber", "ProductColorId", "ProductSizeId", "ProductConfigurationId", "ProductStyleId", "ItemBatchNumber", "ItemSerialNumber")]
    [global::Microsoft.OData.Client.EntitySet("InboundLoadPackingStructureLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InboundLoadPackingStructureLine")]
    public partial class InboundLoadPackingStructureLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InboundLoadPackingStructureLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="inboundShipmentId">Initial value of InboundShipmentId.</param>
        /// <param name="packingStructureLicensePlateNumber">Initial value of PackingStructureLicensePlateNumber.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="itemBatchNumber">Initial value of ItemBatchNumber.</param>
        /// <param name="itemSerialNumber">Initial value of ItemSerialNumber.</param>
        /// <param name="capturedWeight">Initial value of CapturedWeight.</param>
        /// <param name="itemBatchExpirationDate">Initial value of ItemBatchExpirationDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="purchaseOrderLineNumber">Initial value of PurchaseOrderLineNumber.</param>
        /// <param name="loadPackingStructure">Initial value of LoadPackingStructure.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InboundLoadPackingStructureLine CreateInboundLoadPackingStructureLine(string dataAreaId, 
                    string inboundShipmentId, 
                    string packingStructureLicensePlateNumber, 
                    string itemNumber, 
                    string productColorId, 
                    string productSizeId, 
                    string productConfigurationId, 
                    string productStyleId, 
                    string itemBatchNumber, 
                    string itemSerialNumber, 
                    decimal capturedWeight, 
                    global::System.DateTimeOffset itemBatchExpirationDate, 
                    decimal quantity, 
                    long purchaseOrderLineNumber, 
                    global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructures loadPackingStructure)
        {
            InboundLoadPackingStructureLine inboundLoadPackingStructureLine = new InboundLoadPackingStructureLine();
            inboundLoadPackingStructureLine.DataAreaId = dataAreaId;
            inboundLoadPackingStructureLine.InboundShipmentId = inboundShipmentId;
            inboundLoadPackingStructureLine.PackingStructureLicensePlateNumber = packingStructureLicensePlateNumber;
            inboundLoadPackingStructureLine.ItemNumber = itemNumber;
            inboundLoadPackingStructureLine.ProductColorId = productColorId;
            inboundLoadPackingStructureLine.ProductSizeId = productSizeId;
            inboundLoadPackingStructureLine.ProductConfigurationId = productConfigurationId;
            inboundLoadPackingStructureLine.ProductStyleId = productStyleId;
            inboundLoadPackingStructureLine.ItemBatchNumber = itemBatchNumber;
            inboundLoadPackingStructureLine.ItemSerialNumber = itemSerialNumber;
            inboundLoadPackingStructureLine.CapturedWeight = capturedWeight;
            inboundLoadPackingStructureLine.ItemBatchExpirationDate = itemBatchExpirationDate;
            inboundLoadPackingStructureLine.Quantity = quantity;
            inboundLoadPackingStructureLine.PurchaseOrderLineNumber = purchaseOrderLineNumber;
            if ((loadPackingStructure == null))
            {
                throw new global::System.ArgumentNullException("loadPackingStructure");
            }
            inboundLoadPackingStructureLine.LoadPackingStructure = loadPackingStructure;
            return inboundLoadPackingStructureLine;
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
        /// There are no comments for Property InboundShipmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InboundShipmentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InboundShipmentId is required.")]
        public virtual string InboundShipmentId
        {
            get
            {
                return this._InboundShipmentId;
            }
            set
            {
                this.OnInboundShipmentIdChanging(value);
                this._InboundShipmentId = value;
                this.OnInboundShipmentIdChanged();
                this.OnPropertyChanged("InboundShipmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InboundShipmentId;
        partial void OnInboundShipmentIdChanging(string value);
        partial void OnInboundShipmentIdChanged();
        /// <summary>
        /// There are no comments for Property PackingStructureLicensePlateNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackingStructureLicensePlateNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PackingStructureLicensePlateNumber is required.")]
        public virtual string PackingStructureLicensePlateNumber
        {
            get
            {
                return this._PackingStructureLicensePlateNumber;
            }
            set
            {
                this.OnPackingStructureLicensePlateNumberChanging(value);
                this._PackingStructureLicensePlateNumber = value;
                this.OnPackingStructureLicensePlateNumberChanged();
                this.OnPropertyChanged("PackingStructureLicensePlateNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackingStructureLicensePlateNumber;
        partial void OnPackingStructureLicensePlateNumberChanging(string value);
        partial void OnPackingStructureLicensePlateNumberChanged();
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
        /// There are no comments for Property ItemBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBatchNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemBatchNumber is required.")]
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
        /// There are no comments for Property ItemSerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemSerialNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemSerialNumber is required.")]
        public virtual string ItemSerialNumber
        {
            get
            {
                return this._ItemSerialNumber;
            }
            set
            {
                this.OnItemSerialNumberChanging(value);
                this._ItemSerialNumber = value;
                this.OnItemSerialNumberChanged();
                this.OnPropertyChanged("ItemSerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSerialNumber;
        partial void OnItemSerialNumberChanging(string value);
        partial void OnItemSerialNumberChanged();
        /// <summary>
        /// There are no comments for Property CapturedWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CapturedWeight")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CapturedWeight is required.")]
        public virtual decimal CapturedWeight
        {
            get
            {
                return this._CapturedWeight;
            }
            set
            {
                this.OnCapturedWeightChanging(value);
                this._CapturedWeight = value;
                this.OnCapturedWeightChanged();
                this.OnPropertyChanged("CapturedWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CapturedWeight;
        partial void OnCapturedWeightChanging(decimal value);
        partial void OnCapturedWeightChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderNumber")]
        public virtual string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this.OnPurchaseOrderNumberChanging(value);
                this._PurchaseOrderNumber = value;
                this.OnPurchaseOrderNumberChanged();
                this.OnPropertyChanged("PurchaseOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderNumber;
        partial void OnPurchaseOrderNumberChanging(string value);
        partial void OnPurchaseOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property ItemBatchExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBatchExpirationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemBatchExpirationDate is required.")]
        public virtual global::System.DateTimeOffset ItemBatchExpirationDate
        {
            get
            {
                return this._ItemBatchExpirationDate;
            }
            set
            {
                this.OnItemBatchExpirationDateChanging(value);
                this._ItemBatchExpirationDate = value;
                this.OnItemBatchExpirationDateChanged();
                this.OnPropertyChanged("ItemBatchExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ItemBatchExpirationDate;
        partial void OnItemBatchExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnItemBatchExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitSymbol")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
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
        /// There are no comments for Property PurchaseOrderLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseOrderLineNumber is required.")]
        public virtual long PurchaseOrderLineNumber
        {
            get
            {
                return this._PurchaseOrderLineNumber;
            }
            set
            {
                this.OnPurchaseOrderLineNumberChanging(value);
                this._PurchaseOrderLineNumber = value;
                this.OnPurchaseOrderLineNumberChanged();
                this.OnPropertyChanged("PurchaseOrderLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PurchaseOrderLineNumber;
        partial void OnPurchaseOrderLineNumberChanging(long value);
        partial void OnPurchaseOrderLineNumberChanged();
        /// <summary>
        /// There are no comments for Property LoadPackingStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoadPackingStructure")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoadPackingStructure is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructures LoadPackingStructure
        {
            get
            {
                return this._LoadPackingStructure;
            }
            set
            {
                this.OnLoadPackingStructureChanging(value);
                this._LoadPackingStructure = value;
                this.OnLoadPackingStructureChanged();
                this.OnPropertyChanged("LoadPackingStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructures _LoadPackingStructure;
        partial void OnLoadPackingStructureChanging(global::Microsoft.Dynamics.DataEntities.InboundLoadPackingStructures value);
        partial void OnLoadPackingStructureChanged();
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
