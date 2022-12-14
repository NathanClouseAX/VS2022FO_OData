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
    /// There are no comments for ProjVendInvoiceLineExportEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceLineExportEntitySingle")]
    public partial class ProjVendInvoiceLineExportEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjVendInvoiceLineExportEntity>
    {
        /// <summary>
        /// Initialize a new ProjVendInvoiceLineExportEntitySingle object.
        /// </summary>
        public ProjVendInvoiceLineExportEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjVendInvoiceLineExportEntitySingle object.
        /// </summary>
        public ProjVendInvoiceLineExportEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjVendInvoiceLineExportEntitySingle object.
        /// </summary>
        public ProjVendInvoiceLineExportEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjVendInvoiceLineExportEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjVendInvoiceExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceExport")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExportSingle ProjVendInvoiceExport
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjVendInvoiceExport == null))
                {
                    this._ProjVendInvoiceExport = new global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExportSingle(this.Context, GetPath("ProjVendInvoiceExport"));
                }
                return this._ProjVendInvoiceExport;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExportSingle _ProjVendInvoiceExport;
    }
    /// <summary>
    /// There are no comments for ProjVendInvoiceLineExportEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjTransId
    /// ProjDataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjTransId", "ProjDataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("ProjVendInvoiceLinesExportEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceLineExportEntity")]
    public partial class ProjVendInvoiceLineExportEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjVendInvoiceLineExportEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projTransId">Initial value of ProjTransId.</param>
        /// <param name="projDataAreaId">Initial value of ProjDataAreaId.</param>
        /// <param name="qtyReceiveNow">Initial value of QtyReceiveNow.</param>
        /// <param name="purchPrice">Initial value of PurchPrice.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="projItemTransExists">Initial value of ProjItemTransExists.</param>
        /// <param name="lineAmount">Initial value of LineAmount.</param>
        /// <param name="projVendInvoiceExport">Initial value of ProjVendInvoiceExport.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjVendInvoiceLineExportEntity CreateProjVendInvoiceLineExportEntity(string dataAreaId, 
                    string projTransId, 
                    string projDataAreaId, 
                    decimal qtyReceiveNow, 
                    decimal purchPrice, 
                    global::System.DateTimeOffset transDate, 
                    int projItemTransExists, 
                    decimal lineAmount, 
                    global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExport projVendInvoiceExport)
        {
            ProjVendInvoiceLineExportEntity projVendInvoiceLineExportEntity = new ProjVendInvoiceLineExportEntity();
            projVendInvoiceLineExportEntity.DataAreaId = dataAreaId;
            projVendInvoiceLineExportEntity.ProjTransId = projTransId;
            projVendInvoiceLineExportEntity.ProjDataAreaId = projDataAreaId;
            projVendInvoiceLineExportEntity.QtyReceiveNow = qtyReceiveNow;
            projVendInvoiceLineExportEntity.PurchPrice = purchPrice;
            projVendInvoiceLineExportEntity.TransDate = transDate;
            projVendInvoiceLineExportEntity.ProjItemTransExists = projItemTransExists;
            projVendInvoiceLineExportEntity.LineAmount = lineAmount;
            if ((projVendInvoiceExport == null))
            {
                throw new global::System.ArgumentNullException("projVendInvoiceExport");
            }
            projVendInvoiceLineExportEntity.ProjVendInvoiceExport = projVendInvoiceExport;
            return projVendInvoiceLineExportEntity;
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
        /// There are no comments for Property ProjTransId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjTransId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjTransId is required.")]
        public virtual string ProjTransId
        {
            get
            {
                return this._ProjTransId;
            }
            set
            {
                this.OnProjTransIdChanging(value);
                this._ProjTransId = value;
                this.OnProjTransIdChanged();
                this.OnPropertyChanged("ProjTransId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjTransId;
        partial void OnProjTransIdChanging(string value);
        partial void OnProjTransIdChanged();
        /// <summary>
        /// There are no comments for Property ProjDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjDataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjDataAreaId is required.")]
        public virtual string ProjDataAreaId
        {
            get
            {
                return this._ProjDataAreaId;
            }
            set
            {
                this.OnProjDataAreaIdChanging(value);
                this._ProjDataAreaId = value;
                this.OnProjDataAreaIdChanged();
                this.OnPropertyChanged("ProjDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjDataAreaId;
        partial void OnProjDataAreaIdChanging(string value);
        partial void OnProjDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
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
        /// There are no comments for Property PurchUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchUnit")]
        public virtual string PurchUnit
        {
            get
            {
                return this._PurchUnit;
            }
            set
            {
                this.OnPurchUnitChanging(value);
                this._PurchUnit = value;
                this.OnPurchUnitChanged();
                this.OnPropertyChanged("PurchUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchUnit;
        partial void OnPurchUnitChanging(string value);
        partial void OnPurchUnitChanged();
        /// <summary>
        /// There are no comments for Property VendorInvoiceNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorInvoiceNum")]
        public virtual string VendorInvoiceNum
        {
            get
            {
                return this._VendorInvoiceNum;
            }
            set
            {
                this.OnVendorInvoiceNumChanging(value);
                this._VendorInvoiceNum = value;
                this.OnVendorInvoiceNumChanged();
                this.OnPropertyChanged("VendorInvoiceNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorInvoiceNum;
        partial void OnVendorInvoiceNumChanging(string value);
        partial void OnVendorInvoiceNumChanged();
        /// <summary>
        /// There are no comments for Property DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplayProductNumber")]
        public virtual string DisplayProductNumber
        {
            get
            {
                return this._DisplayProductNumber;
            }
            set
            {
                this.OnDisplayProductNumberChanging(value);
                this._DisplayProductNumber = value;
                this.OnDisplayProductNumberChanged();
                this.OnPropertyChanged("DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayProductNumber;
        partial void OnDisplayProductNumberChanging(string value);
        partial void OnDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property CategoryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> CategoryType
        {
            get
            {
                return this._CategoryType;
            }
            set
            {
                this.OnCategoryTypeChanging(value);
                this._CategoryType = value;
                this.OnCategoryTypeChanged();
                this.OnPropertyChanged("CategoryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> _CategoryType;
        partial void OnCategoryTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCategoryType> value);
        partial void OnCategoryTypeChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceAccount")]
        public virtual string InvoiceAccount
        {
            get
            {
                return this._InvoiceAccount;
            }
            set
            {
                this.OnInvoiceAccountChanging(value);
                this._InvoiceAccount = value;
                this.OnInvoiceAccountChanged();
                this.OnPropertyChanged("InvoiceAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAccount;
        partial void OnInvoiceAccountChanging(string value);
        partial void OnInvoiceAccountChanged();
        /// <summary>
        /// There are no comments for Property ProjId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjId")]
        public virtual string ProjId
        {
            get
            {
                return this._ProjId;
            }
            set
            {
                this.OnProjIdChanging(value);
                this._ProjId = value;
                this.OnProjIdChanged();
                this.OnPropertyChanged("ProjId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjId;
        partial void OnProjIdChanging(string value);
        partial void OnProjIdChanged();
        /// <summary>
        /// There are no comments for Property QtyReceiveNow in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QtyReceiveNow")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QtyReceiveNow is required.")]
        public virtual decimal QtyReceiveNow
        {
            get
            {
                return this._QtyReceiveNow;
            }
            set
            {
                this.OnQtyReceiveNowChanging(value);
                this._QtyReceiveNow = value;
                this.OnQtyReceiveNowChanged();
                this.OnPropertyChanged("QtyReceiveNow");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QtyReceiveNow;
        partial void OnQtyReceiveNowChanging(decimal value);
        partial void OnQtyReceiveNowChanged();
        /// <summary>
        /// There are no comments for Property PurchPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchPrice is required.")]
        public virtual decimal PurchPrice
        {
            get
            {
                return this._PurchPrice;
            }
            set
            {
                this.OnPurchPriceChanging(value);
                this._PurchPrice = value;
                this.OnPurchPriceChanged();
                this.OnPropertyChanged("PurchPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PurchPrice;
        partial void OnPurchPriceChanging(decimal value);
        partial void OnPurchPriceChanged();
        /// <summary>
        /// There are no comments for Property ProjTaskNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjTaskNumber")]
        public virtual string ProjTaskNumber
        {
            get
            {
                return this._ProjTaskNumber;
            }
            set
            {
                this.OnProjTaskNumberChanging(value);
                this._ProjTaskNumber = value;
                this.OnProjTaskNumberChanged();
                this.OnPropertyChanged("ProjTaskNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjTaskNumber;
        partial void OnProjTaskNumberChanging(string value);
        partial void OnProjTaskNumberChanged();
        /// <summary>
        /// There are no comments for Property RoleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RoleId")]
        public virtual string RoleId
        {
            get
            {
                return this._RoleId;
            }
            set
            {
                this.OnRoleIdChanging(value);
                this._RoleId = value;
                this.OnRoleIdChanged();
                this.OnPropertyChanged("RoleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoleId;
        partial void OnRoleIdChanging(string value);
        partial void OnRoleIdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("currencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("currencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property TransactionCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCategoryId")]
        public virtual string TransactionCategoryId
        {
            get
            {
                return this._TransactionCategoryId;
            }
            set
            {
                this.OnTransactionCategoryIdChanging(value);
                this._TransactionCategoryId = value;
                this.OnTransactionCategoryIdChanged();
                this.OnPropertyChanged("TransactionCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCategoryId;
        partial void OnTransactionCategoryIdChanging(string value);
        partial void OnTransactionCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property TransDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransDate is required.")]
        public virtual global::System.DateTimeOffset TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                this.OnTransDateChanging(value);
                this._TransDate = value;
                this.OnTransDateChanged();
                this.OnPropertyChanged("TransDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransDate;
        partial void OnTransDateChanging(global::System.DateTimeOffset value);
        partial void OnTransDateChanged();
        /// <summary>
        /// There are no comments for Property OrderAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderAccount")]
        public virtual string OrderAccount
        {
            get
            {
                return this._OrderAccount;
            }
            set
            {
                this.OnOrderAccountChanging(value);
                this._OrderAccount = value;
                this.OnOrderAccountChanged();
                this.OnPropertyChanged("OrderAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderAccount;
        partial void OnOrderAccountChanging(string value);
        partial void OnOrderAccountChanged();
        /// <summary>
        /// There are no comments for Property BillingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBillingType> BillingType
        {
            get
            {
                return this._BillingType;
            }
            set
            {
                this.OnBillingTypeChanging(value);
                this._BillingType = value;
                this.OnBillingTypeChanged();
                this.OnPropertyChanged("BillingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBillingType> _BillingType;
        partial void OnBillingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjBillingType> value);
        partial void OnBillingTypeChanged();
        /// <summary>
        /// There are no comments for Property ProjItemTransExists in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjItemTransExists")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjItemTransExists is required.")]
        public virtual int ProjItemTransExists
        {
            get
            {
                return this._ProjItemTransExists;
            }
            set
            {
                this.OnProjItemTransExistsChanging(value);
                this._ProjItemTransExists = value;
                this.OnProjItemTransExistsChanged();
                this.OnPropertyChanged("ProjItemTransExists");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProjItemTransExists;
        partial void OnProjItemTransExistsChanging(int value);
        partial void OnProjItemTransExistsChanged();
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
        /// There are no comments for Property ProjVendInvoiceExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceExport")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjVendInvoiceExport is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExport ProjVendInvoiceExport
        {
            get
            {
                return this._ProjVendInvoiceExport;
            }
            set
            {
                this.OnProjVendInvoiceExportChanging(value);
                this._ProjVendInvoiceExport = value;
                this.OnProjVendInvoiceExportChanged();
                this.OnPropertyChanged("ProjVendInvoiceExport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExport _ProjVendInvoiceExport;
        partial void OnProjVendInvoiceExportChanging(global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceExport value);
        partial void OnProjVendInvoiceExportChanged();
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
