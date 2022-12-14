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
    /// There are no comments for RetailInventItemBarcodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInventItemBarcodeSingle")]
    public partial class RetailInventItemBarcodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInventItemBarcode>
    {
        /// <summary>
        /// Initialize a new RetailInventItemBarcodeSingle object.
        /// </summary>
        public RetailInventItemBarcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInventItemBarcodeSingle object.
        /// </summary>
        public RetailInventItemBarcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInventItemBarcodeSingle object.
        /// </summary>
        public RetailInventItemBarcodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInventItemBarcode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailInventItemBarcode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BarcodeSetupId
    /// InventDimId
    /// ItemId
    /// ItemBarCode
    /// RetailVariantId
    /// UnitID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "barcodeSetupId", "inventDimId", "itemId", "itemBarCode", "RetailVariantId", "UnitID")]
    [global::Microsoft.OData.Client.EntitySet("RetailInventItemBarcode")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInventItemBarcode")]
    public partial class RetailInventItemBarcode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInventItemBarcode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="barcodeSetupId">Initial value of BarcodeSetupId.</param>
        /// <param name="inventDimId">Initial value of InventDimId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="itemBarCode">Initial value of ItemBarCode.</param>
        /// <param name="retailVariantId">Initial value of RetailVariantId.</param>
        /// <param name="unitID">Initial value of UnitID.</param>
        /// <param name="qty">Initial value of Qty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInventItemBarcode CreateRetailInventItemBarcode(string dataAreaId, 
                    string barcodeSetupId, 
                    string inventDimId, 
                    string itemId, 
                    string itemBarCode, 
                    string retailVariantId, 
                    string unitID, 
                    decimal qty)
        {
            RetailInventItemBarcode retailInventItemBarcode = new RetailInventItemBarcode();
            retailInventItemBarcode.DataAreaId = dataAreaId;
            retailInventItemBarcode.BarcodeSetupId = barcodeSetupId;
            retailInventItemBarcode.InventDimId = inventDimId;
            retailInventItemBarcode.ItemId = itemId;
            retailInventItemBarcode.ItemBarCode = itemBarCode;
            retailInventItemBarcode.RetailVariantId = retailVariantId;
            retailInventItemBarcode.UnitID = unitID;
            retailInventItemBarcode.Qty = qty;
            return retailInventItemBarcode;
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
        /// There are no comments for Property BarcodeSetupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("barcodeSetupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BarcodeSetupId is required.")]
        public virtual string BarcodeSetupId
        {
            get
            {
                return this._BarcodeSetupId;
            }
            set
            {
                this.OnBarcodeSetupIdChanging(value);
                this._BarcodeSetupId = value;
                this.OnBarcodeSetupIdChanged();
                this.OnPropertyChanged("barcodeSetupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeSetupId;
        partial void OnBarcodeSetupIdChanging(string value);
        partial void OnBarcodeSetupIdChanged();
        /// <summary>
        /// There are no comments for Property InventDimId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("inventDimId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventDimId is required.")]
        public virtual string InventDimId
        {
            get
            {
                return this._InventDimId;
            }
            set
            {
                this.OnInventDimIdChanging(value);
                this._InventDimId = value;
                this.OnInventDimIdChanged();
                this.OnPropertyChanged("inventDimId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventDimId;
        partial void OnInventDimIdChanging(string value);
        partial void OnInventDimIdChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("itemId")]
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
                this.OnPropertyChanged("itemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property ItemBarCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("itemBarCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemBarCode is required.")]
        public virtual string ItemBarCode
        {
            get
            {
                return this._ItemBarCode;
            }
            set
            {
                this.OnItemBarCodeChanging(value);
                this._ItemBarCode = value;
                this.OnItemBarCodeChanged();
                this.OnPropertyChanged("itemBarCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemBarCode;
        partial void OnItemBarCodeChanging(string value);
        partial void OnItemBarCodeChanged();
        /// <summary>
        /// There are no comments for Property RetailVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVariantId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailVariantId is required.")]
        public virtual string RetailVariantId
        {
            get
            {
                return this._RetailVariantId;
            }
            set
            {
                this.OnRetailVariantIdChanging(value);
                this._RetailVariantId = value;
                this.OnRetailVariantIdChanged();
                this.OnPropertyChanged("RetailVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailVariantId;
        partial void OnRetailVariantIdChanging(string value);
        partial void OnRetailVariantIdChanged();
        /// <summary>
        /// There are no comments for Property UnitID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitID is required.")]
        public virtual string UnitID
        {
            get
            {
                return this._UnitID;
            }
            set
            {
                this.OnUnitIDChanging(value);
                this._UnitID = value;
                this.OnUnitIDChanged();
                this.OnPropertyChanged("UnitID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitID;
        partial void OnUnitIDChanging(string value);
        partial void OnUnitIDChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("description")]
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
                this.OnPropertyChanged("description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property UseForInput in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("useForInput")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseForInput
        {
            get
            {
                return this._UseForInput;
            }
            set
            {
                this.OnUseForInputChanging(value);
                this._UseForInput = value;
                this.OnUseForInputChanged();
                this.OnPropertyChanged("useForInput");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseForInput;
        partial void OnUseForInputChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseForInputChanged();
        /// <summary>
        /// There are no comments for Property RetailShowForItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailShowForItem")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RetailShowForItem
        {
            get
            {
                return this._RetailShowForItem;
            }
            set
            {
                this.OnRetailShowForItemChanging(value);
                this._RetailShowForItem = value;
                this.OnRetailShowForItemChanged();
                this.OnPropertyChanged("RetailShowForItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RetailShowForItem;
        partial void OnRetailShowForItemChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRetailShowForItemChanged();
        /// <summary>
        /// There are no comments for Property UseForPrinting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("useForPrinting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseForPrinting
        {
            get
            {
                return this._UseForPrinting;
            }
            set
            {
                this.OnUseForPrintingChanging(value);
                this._UseForPrinting = value;
                this.OnUseForPrintingChanged();
                this.OnPropertyChanged("useForPrinting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseForPrinting;
        partial void OnUseForPrintingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseForPrintingChanged();
        /// <summary>
        /// There are no comments for Property Blocked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Blocked")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Blocked
        {
            get
            {
                return this._Blocked;
            }
            set
            {
                this.OnBlockedChanging(value);
                this._Blocked = value;
                this.OnBlockedChanged();
                this.OnPropertyChanged("Blocked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Blocked;
        partial void OnBlockedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBlockedChanged();
        /// <summary>
        /// There are no comments for Property Qty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("qty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Qty is required.")]
        public virtual decimal Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this.OnQtyChanging(value);
                this._Qty = value;
                this.OnQtyChanged();
                this.OnPropertyChanged("qty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Qty;
        partial void OnQtyChanging(decimal value);
        partial void OnQtyChanged();
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
