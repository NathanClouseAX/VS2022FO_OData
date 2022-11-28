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
    /// There are no comments for LedgerJournalCostLinesPurchLineTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalCostLinesPurchLineTableSingle")]
    public partial class LedgerJournalCostLinesPurchLineTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalCostLinesPurchLineTable>
    {
        /// <summary>
        /// Initialize a new LedgerJournalCostLinesPurchLineTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesPurchLineTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerJournalCostLinesPurchLineTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesPurchLineTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerJournalCostLinesPurchLineTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesPurchLineTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalCostLinesPurchLineTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LedgerJournalCostLinesPurchLineTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// JournalNum
    /// JournalLineNumber
    /// PurchaseOrderId
    /// PurchaseOrderLineNumber
    /// CostTransactionLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalNum", "JournalLineNumber", "PurchaseOrderId", "PurchaseOrderLineNumber", "CostTransactionLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("LedgerJournalCostLinesPurchLineTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalCostLinesPurchLineTable")]
    public partial class LedgerJournalCostLinesPurchLineTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerJournalCostLinesPurchLineTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="journalNum">Initial value of JournalNum.</param>
        /// <param name="journalLineNumber">Initial value of JournalLineNumber.</param>
        /// <param name="purchaseOrderId">Initial value of PurchaseOrderId.</param>
        /// <param name="purchaseOrderLineNumber">Initial value of PurchaseOrderLineNumber.</param>
        /// <param name="costTransactionLineNumber">Initial value of CostTransactionLineNumber.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerJournalCostLinesPurchLineTable CreateLedgerJournalCostLinesPurchLineTable(string dataAreaId, 
                    string journalNum, 
                    decimal journalLineNumber, 
                    string purchaseOrderId, 
                    long purchaseOrderLineNumber, 
                    decimal costTransactionLineNumber, 
                    decimal amount)
        {
            LedgerJournalCostLinesPurchLineTable ledgerJournalCostLinesPurchLineTable = new LedgerJournalCostLinesPurchLineTable();
            ledgerJournalCostLinesPurchLineTable.DataAreaId = dataAreaId;
            ledgerJournalCostLinesPurchLineTable.JournalNum = journalNum;
            ledgerJournalCostLinesPurchLineTable.JournalLineNumber = journalLineNumber;
            ledgerJournalCostLinesPurchLineTable.PurchaseOrderId = purchaseOrderId;
            ledgerJournalCostLinesPurchLineTable.PurchaseOrderLineNumber = purchaseOrderLineNumber;
            ledgerJournalCostLinesPurchLineTable.CostTransactionLineNumber = costTransactionLineNumber;
            ledgerJournalCostLinesPurchLineTable.Amount = amount;
            return ledgerJournalCostLinesPurchLineTable;
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
        /// There are no comments for Property JournalNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalNum is required.")]
        public virtual string JournalNum
        {
            get
            {
                return this._JournalNum;
            }
            set
            {
                this.OnJournalNumChanging(value);
                this._JournalNum = value;
                this.OnJournalNumChanged();
                this.OnPropertyChanged("JournalNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNum;
        partial void OnJournalNumChanging(string value);
        partial void OnJournalNumChanged();
        /// <summary>
        /// There are no comments for Property JournalLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalLineNumber is required.")]
        public virtual decimal JournalLineNumber
        {
            get
            {
                return this._JournalLineNumber;
            }
            set
            {
                this.OnJournalLineNumberChanging(value);
                this._JournalLineNumber = value;
                this.OnJournalLineNumberChanged();
                this.OnPropertyChanged("JournalLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalLineNumber;
        partial void OnJournalLineNumberChanging(decimal value);
        partial void OnJournalLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseOrderId is required.")]
        public virtual string PurchaseOrderId
        {
            get
            {
                return this._PurchaseOrderId;
            }
            set
            {
                this.OnPurchaseOrderIdChanging(value);
                this._PurchaseOrderId = value;
                this.OnPurchaseOrderIdChanged();
                this.OnPropertyChanged("PurchaseOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderId;
        partial void OnPurchaseOrderIdChanging(string value);
        partial void OnPurchaseOrderIdChanged();
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
        /// There are no comments for Property CostTransactionLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostTransactionLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostTransactionLineNumber is required.")]
        public virtual decimal CostTransactionLineNumber
        {
            get
            {
                return this._CostTransactionLineNumber;
            }
            set
            {
                this.OnCostTransactionLineNumberChanging(value);
                this._CostTransactionLineNumber = value;
                this.OnCostTransactionLineNumberChanged();
                this.OnPropertyChanged("CostTransactionLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostTransactionLineNumber;
        partial void OnCostTransactionLineNumberChanging(decimal value);
        partial void OnCostTransactionLineNumberChanged();
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