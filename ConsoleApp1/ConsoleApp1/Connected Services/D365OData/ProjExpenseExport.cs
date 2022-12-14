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
    /// There are no comments for ProjExpenseExportSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjExpenseExportSingle")]
    public partial class ProjExpenseExportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjExpenseExport>
    {
        /// <summary>
        /// Initialize a new ProjExpenseExportSingle object.
        /// </summary>
        public ProjExpenseExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjExpenseExportSingle object.
        /// </summary>
        public ProjExpenseExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjExpenseExportSingle object.
        /// </summary>
        public ProjExpenseExportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjExpenseExport> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjExpenseExport in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ExpTransNumber
    /// ReferenceDataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ExpTransNumber", "ReferenceDataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("ProjExpensesExport")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjExpenseExport")]
    public partial class ProjExpenseExport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjExpenseExport object.
        /// </summary>
        /// <param name="expTransNumber">Initial value of ExpTransNumber.</param>
        /// <param name="referenceDataAreaId">Initial value of ReferenceDataAreaId.</param>
        /// <param name="netAmount">Initial value of NetAmount.</param>
        /// <param name="taxAmount">Initial value of TaxAmount.</param>
        /// <param name="projCostTransExists">Initial value of ProjCostTransExists.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjExpenseExport CreateProjExpenseExport(string expTransNumber, 
                    string referenceDataAreaId, 
                    decimal netAmount, 
                    decimal taxAmount, 
                    int projCostTransExists, 
                    decimal amount, 
                    global::System.DateTimeOffset transDate, 
                    decimal quantity)
        {
            ProjExpenseExport projExpenseExport = new ProjExpenseExport();
            projExpenseExport.ExpTransNumber = expTransNumber;
            projExpenseExport.ReferenceDataAreaId = referenceDataAreaId;
            projExpenseExport.NetAmount = netAmount;
            projExpenseExport.TaxAmount = taxAmount;
            projExpenseExport.ProjCostTransExists = projCostTransExists;
            projExpenseExport.Amount = amount;
            projExpenseExport.TransDate = transDate;
            projExpenseExport.Quantity = quantity;
            return projExpenseExport;
        }
        /// <summary>
        /// There are no comments for Property ExpTransNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpTransNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpTransNumber is required.")]
        public virtual string ExpTransNumber
        {
            get
            {
                return this._ExpTransNumber;
            }
            set
            {
                this.OnExpTransNumberChanging(value);
                this._ExpTransNumber = value;
                this.OnExpTransNumberChanged();
                this.OnPropertyChanged("ExpTransNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExpTransNumber;
        partial void OnExpTransNumberChanging(string value);
        partial void OnExpTransNumberChanged();
        /// <summary>
        /// There are no comments for Property ReferenceDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceDataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceDataAreaId is required.")]
        public virtual string ReferenceDataAreaId
        {
            get
            {
                return this._ReferenceDataAreaId;
            }
            set
            {
                this.OnReferenceDataAreaIdChanging(value);
                this._ReferenceDataAreaId = value;
                this.OnReferenceDataAreaIdChanged();
                this.OnPropertyChanged("ReferenceDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceDataAreaId;
        partial void OnReferenceDataAreaIdChanging(string value);
        partial void OnReferenceDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property ProjTransId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjTransId")]
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
        /// There are no comments for Property NetAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NetAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NetAmount is required.")]
        public virtual decimal NetAmount
        {
            get
            {
                return this._NetAmount;
            }
            set
            {
                this.OnNetAmountChanging(value);
                this._NetAmount = value;
                this.OnNetAmountChanged();
                this.OnPropertyChanged("NetAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NetAmount;
        partial void OnNetAmountChanging(decimal value);
        partial void OnNetAmountChanged();
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
        /// There are no comments for Property TaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxAmount is required.")]
        public virtual decimal TaxAmount
        {
            get
            {
                return this._TaxAmount;
            }
            set
            {
                this.OnTaxAmountChanging(value);
                this._TaxAmount = value;
                this.OnTaxAmountChanged();
                this.OnPropertyChanged("TaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxAmount;
        partial void OnTaxAmountChanging(decimal value);
        partial void OnTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property ExchangeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeCode")]
        public virtual string ExchangeCode
        {
            get
            {
                return this._ExchangeCode;
            }
            set
            {
                this.OnExchangeCodeChanging(value);
                this._ExchangeCode = value;
                this.OnExchangeCodeChanged();
                this.OnPropertyChanged("ExchangeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExchangeCode;
        partial void OnExchangeCodeChanging(string value);
        partial void OnExchangeCodeChanged();
        /// <summary>
        /// There are no comments for Property ProjCostTransExists in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCostTransExists")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjCostTransExists is required.")]
        public virtual int ProjCostTransExists
        {
            get
            {
                return this._ProjCostTransExists;
            }
            set
            {
                this.OnProjCostTransExistsChanging(value);
                this._ProjCostTransExists = value;
                this.OnProjCostTransExistsChanged();
                this.OnPropertyChanged("ProjCostTransExists");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProjCostTransExists;
        partial void OnProjCostTransExistsChanging(int value);
        partial void OnProjCostTransExistsChanged();
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
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
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
        /// There are no comments for Property AdditionalInformation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalInformation")]
        public virtual string AdditionalInformation
        {
            get
            {
                return this._AdditionalInformation;
            }
            set
            {
                this.OnAdditionalInformationChanging(value);
                this._AdditionalInformation = value;
                this.OnAdditionalInformationChanged();
                this.OnPropertyChanged("AdditionalInformation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdditionalInformation;
        partial void OnAdditionalInformationChanging(string value);
        partial void OnAdditionalInformationChanged();
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
        /// There are no comments for Property CostType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostType")]
        public virtual string CostType
        {
            get
            {
                return this._CostType;
            }
            set
            {
                this.OnCostTypeChanging(value);
                this._CostType = value;
                this.OnCostTypeChanged();
                this.OnPropertyChanged("CostType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostType;
        partial void OnCostTypeChanging(string value);
        partial void OnCostTypeChanged();
        /// <summary>
        /// There are no comments for Property InterCompanyLE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InterCompanyLE")]
        public virtual string InterCompanyLE
        {
            get
            {
                return this._InterCompanyLE;
            }
            set
            {
                this.OnInterCompanyLEChanging(value);
                this._InterCompanyLE = value;
                this.OnInterCompanyLEChanged();
                this.OnPropertyChanged("InterCompanyLE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InterCompanyLE;
        partial void OnInterCompanyLEChanging(string value);
        partial void OnInterCompanyLEChanged();
        /// <summary>
        /// There are no comments for Property ProjActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjActivityNumber")]
        public virtual string ProjActivityNumber
        {
            get
            {
                return this._ProjActivityNumber;
            }
            set
            {
                this.OnProjActivityNumberChanging(value);
                this._ProjActivityNumber = value;
                this.OnProjActivityNumberChanged();
                this.OnPropertyChanged("ProjActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjActivityNumber;
        partial void OnProjActivityNumberChanging(string value);
        partial void OnProjActivityNumberChanged();
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
