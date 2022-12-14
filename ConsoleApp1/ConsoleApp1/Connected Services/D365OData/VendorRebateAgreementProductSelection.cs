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
    /// There are no comments for VendorRebateAgreementProductSelectionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRebateAgreementProductSelectionSingle")]
    public partial class VendorRebateAgreementProductSelectionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRebateAgreementProductSelection>
    {
        /// <summary>
        /// Initialize a new VendorRebateAgreementProductSelectionSingle object.
        /// </summary>
        public VendorRebateAgreementProductSelectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorRebateAgreementProductSelectionSingle object.
        /// </summary>
        public VendorRebateAgreementProductSelectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorRebateAgreementProductSelectionSingle object.
        /// </summary>
        public VendorRebateAgreementProductSelectionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRebateAgreementProductSelection> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VendorRebateAgreementProductSelection in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RebateAgreementId
    /// ItemNumber
    /// ProductConfigurationId
    /// ProductColorId
    /// QualifyingWarehouseId
    /// QualifyingSiteId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RebateAgreementId", "ItemNumber", "ProductConfigurationId", "ProductColorId", "QualifyingWarehouseId", "QualifyingSiteId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("VendorRebateAgreementProductSelections")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRebateAgreementProductSelection")]
    public partial class VendorRebateAgreementProductSelection : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorRebateAgreementProductSelection object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rebateAgreementId">Initial value of RebateAgreementId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="qualifyingWarehouseId">Initial value of QualifyingWarehouseId.</param>
        /// <param name="qualifyingSiteId">Initial value of QualifyingSiteId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorRebateAgreementProductSelection CreateVendorRebateAgreementProductSelection(string dataAreaId, 
                    string rebateAgreementId, 
                    string itemNumber, 
                    string productConfigurationId, 
                    string productColorId, 
                    string qualifyingWarehouseId, 
                    string qualifyingSiteId, 
                    string productSizeId, 
                    string productStyleId)
        {
            VendorRebateAgreementProductSelection vendorRebateAgreementProductSelection = new VendorRebateAgreementProductSelection();
            vendorRebateAgreementProductSelection.DataAreaId = dataAreaId;
            vendorRebateAgreementProductSelection.RebateAgreementId = rebateAgreementId;
            vendorRebateAgreementProductSelection.ItemNumber = itemNumber;
            vendorRebateAgreementProductSelection.ProductConfigurationId = productConfigurationId;
            vendorRebateAgreementProductSelection.ProductColorId = productColorId;
            vendorRebateAgreementProductSelection.QualifyingWarehouseId = qualifyingWarehouseId;
            vendorRebateAgreementProductSelection.QualifyingSiteId = qualifyingSiteId;
            vendorRebateAgreementProductSelection.ProductSizeId = productSizeId;
            vendorRebateAgreementProductSelection.ProductStyleId = productStyleId;
            return vendorRebateAgreementProductSelection;
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
        /// There are no comments for Property RebateAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAgreementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RebateAgreementId is required.")]
        public virtual string RebateAgreementId
        {
            get
            {
                return this._RebateAgreementId;
            }
            set
            {
                this.OnRebateAgreementIdChanging(value);
                this._RebateAgreementId = value;
                this.OnRebateAgreementIdChanged();
                this.OnPropertyChanged("RebateAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RebateAgreementId;
        partial void OnRebateAgreementIdChanging(string value);
        partial void OnRebateAgreementIdChanged();
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
        /// There are no comments for Property QualifyingWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QualifyingWarehouseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualifyingWarehouseId is required.")]
        public virtual string QualifyingWarehouseId
        {
            get
            {
                return this._QualifyingWarehouseId;
            }
            set
            {
                this.OnQualifyingWarehouseIdChanging(value);
                this._QualifyingWarehouseId = value;
                this.OnQualifyingWarehouseIdChanged();
                this.OnPropertyChanged("QualifyingWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingWarehouseId;
        partial void OnQualifyingWarehouseIdChanging(string value);
        partial void OnQualifyingWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property QualifyingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QualifyingSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualifyingSiteId is required.")]
        public virtual string QualifyingSiteId
        {
            get
            {
                return this._QualifyingSiteId;
            }
            set
            {
                this.OnQualifyingSiteIdChanging(value);
                this._QualifyingSiteId = value;
                this.OnQualifyingSiteIdChanged();
                this.OnPropertyChanged("QualifyingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingSiteId;
        partial void OnQualifyingSiteIdChanging(string value);
        partial void OnQualifyingSiteIdChanged();
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
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccountNumber")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductUnitSymbol")]
        public virtual string ProductUnitSymbol
        {
            get
            {
                return this._ProductUnitSymbol;
            }
            set
            {
                this.OnProductUnitSymbolChanging(value);
                this._ProductUnitSymbol = value;
                this.OnProductUnitSymbolChanged();
                this.OnPropertyChanged("ProductUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductUnitSymbol;
        partial void OnProductUnitSymbolChanging(string value);
        partial void OnProductUnitSymbolChanged();
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
