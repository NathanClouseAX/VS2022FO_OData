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
    /// There are no comments for CostAccountingDataConnectorGeneralLedgerEntrySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorGeneralLedgerEntrySingle")]
    public partial class CostAccountingDataConnectorGeneralLedgerEntrySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorGeneralLedgerEntry>
    {
        /// <summary>
        /// Initialize a new CostAccountingDataConnectorGeneralLedgerEntrySingle object.
        /// </summary>
        public CostAccountingDataConnectorGeneralLedgerEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorGeneralLedgerEntrySingle object.
        /// </summary>
        public CostAccountingDataConnectorGeneralLedgerEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorGeneralLedgerEntrySingle object.
        /// </summary>
        public CostAccountingDataConnectorGeneralLedgerEntrySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorGeneralLedgerEntry> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostAccountingDataConnectorGeneralLedgerEntry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataConnectorSystemInstanceSurrogateKey
    /// SourceIdentifier
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataConnectorSystemInstanceSurrogateKey", "SourceIdentifier")]
    [global::Microsoft.OData.Client.EntitySet("CostAccountingDataConnectorGeneralLedgerEntries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorGeneralLedgerEntry")]
    public partial class CostAccountingDataConnectorGeneralLedgerEntry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostAccountingDataConnectorGeneralLedgerEntry object.
        /// </summary>
        /// <param name="dataConnectorSystemInstanceSurrogateKey">Initial value of DataConnectorSystemInstanceSurrogateKey.</param>
        /// <param name="sourceIdentifier">Initial value of SourceIdentifier.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostAccountingDataConnectorGeneralLedgerEntry CreateCostAccountingDataConnectorGeneralLedgerEntry(string dataConnectorSystemInstanceSurrogateKey, string sourceIdentifier, global::System.DateTimeOffset accountingDate, decimal amount)
        {
            CostAccountingDataConnectorGeneralLedgerEntry costAccountingDataConnectorGeneralLedgerEntry = new CostAccountingDataConnectorGeneralLedgerEntry();
            costAccountingDataConnectorGeneralLedgerEntry.DataConnectorSystemInstanceSurrogateKey = dataConnectorSystemInstanceSurrogateKey;
            costAccountingDataConnectorGeneralLedgerEntry.SourceIdentifier = sourceIdentifier;
            costAccountingDataConnectorGeneralLedgerEntry.AccountingDate = accountingDate;
            costAccountingDataConnectorGeneralLedgerEntry.Amount = amount;
            return costAccountingDataConnectorGeneralLedgerEntry;
        }
        /// <summary>
        /// There are no comments for Property DataConnectorSystemInstanceSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorSystemInstanceSurrogateKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorSystemInstanceSurrogateKey is required.")]
        public virtual string DataConnectorSystemInstanceSurrogateKey
        {
            get
            {
                return this._DataConnectorSystemInstanceSurrogateKey;
            }
            set
            {
                this.OnDataConnectorSystemInstanceSurrogateKeyChanging(value);
                this._DataConnectorSystemInstanceSurrogateKey = value;
                this.OnDataConnectorSystemInstanceSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorSystemInstanceSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorSystemInstanceSurrogateKey;
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanging(string value);
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanged();
        /// <summary>
        /// There are no comments for Property SourceIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SourceIdentifier is required.")]
        public virtual string SourceIdentifier
        {
            get
            {
                return this._SourceIdentifier;
            }
            set
            {
                this.OnSourceIdentifierChanging(value);
                this._SourceIdentifier = value;
                this.OnSourceIdentifierChanged();
                this.OnPropertyChanged("SourceIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceIdentifier;
        partial void OnSourceIdentifierChanging(string value);
        partial void OnSourceIdentifierChanged();
        /// <summary>
        /// There are no comments for Property MainAccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccountName")]
        public virtual string MainAccountName
        {
            get
            {
                return this._MainAccountName;
            }
            set
            {
                this.OnMainAccountNameChanging(value);
                this._MainAccountName = value;
                this.OnMainAccountNameChanged();
                this.OnPropertyChanged("MainAccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountName;
        partial void OnMainAccountNameChanging(string value);
        partial void OnMainAccountNameChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
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
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorDataTransferSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorDataTransferSurrogateKey")]
        public virtual string DataConnectorDataTransferSurrogateKey
        {
            get
            {
                return this._DataConnectorDataTransferSurrogateKey;
            }
            set
            {
                this.OnDataConnectorDataTransferSurrogateKeyChanging(value);
                this._DataConnectorDataTransferSurrogateKey = value;
                this.OnDataConnectorDataTransferSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorDataTransferSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorDataTransferSurrogateKey;
        partial void OnDataConnectorDataTransferSurrogateKeyChanging(string value);
        partial void OnDataConnectorDataTransferSurrogateKeyChanged();
        /// <summary>
        /// There are no comments for Property DebitCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitCredit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CAMDebitCredit> DebitCredit
        {
            get
            {
                return this._DebitCredit;
            }
            set
            {
                this.OnDebitCreditChanging(value);
                this._DebitCredit = value;
                this.OnDebitCreditChanged();
                this.OnPropertyChanged("DebitCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CAMDebitCredit> _DebitCredit;
        partial void OnDebitCreditChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CAMDebitCredit> value);
        partial void OnDebitCreditChanged();
        /// <summary>
        /// There are no comments for Property AccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingDate is required.")]
        public virtual global::System.DateTimeOffset AccountingDate
        {
            get
            {
                return this._AccountingDate;
            }
            set
            {
                this.OnAccountingDateChanging(value);
                this._AccountingDate = value;
                this.OnAccountingDateChanged();
                this.OnPropertyChanged("AccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingDate;
        partial void OnAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingDateChanged();
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
        /// There are no comments for Property DataConnectorPostingLayerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorPostingLayerName")]
        public virtual string DataConnectorPostingLayerName
        {
            get
            {
                return this._DataConnectorPostingLayerName;
            }
            set
            {
                this.OnDataConnectorPostingLayerNameChanging(value);
                this._DataConnectorPostingLayerName = value;
                this.OnDataConnectorPostingLayerNameChanged();
                this.OnPropertyChanged("DataConnectorPostingLayerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorPostingLayerName;
        partial void OnDataConnectorPostingLayerNameChanging(string value);
        partial void OnDataConnectorPostingLayerNameChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorGeneralLedgerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorGeneralLedgerName")]
        public virtual string DataConnectorGeneralLedgerName
        {
            get
            {
                return this._DataConnectorGeneralLedgerName;
            }
            set
            {
                this.OnDataConnectorGeneralLedgerNameChanging(value);
                this._DataConnectorGeneralLedgerName = value;
                this.OnDataConnectorGeneralLedgerNameChanged();
                this.OnPropertyChanged("DataConnectorGeneralLedgerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorGeneralLedgerName;
        partial void OnDataConnectorGeneralLedgerNameChanging(string value);
        partial void OnDataConnectorGeneralLedgerNameChanged();
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
