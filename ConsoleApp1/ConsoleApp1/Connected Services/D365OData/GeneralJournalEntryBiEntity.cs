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
    /// There are no comments for GeneralJournalEntryBiEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralJournalEntryBiEntitySingle")]
    public partial class GeneralJournalEntryBiEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GeneralJournalEntryBiEntity>
    {
        /// <summary>
        /// Initialize a new GeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public GeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public GeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public GeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GeneralJournalEntryBiEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for GeneralJournalEntryBiEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RecordId")]
    [global::Microsoft.OData.Client.EntitySet("GeneralJournalEntryBiEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralJournalEntryBiEntity")]
    public partial class GeneralJournalEntryBiEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GeneralJournalEntryBiEntity object.
        /// </summary>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="budgetSourceLedgerEntryPosted">Initial value of BudgetSourceLedgerEntryPosted.</param>
        /// <param name="ledgerEntryJournal">Initial value of LedgerEntryJournal.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="partitionId">Initial value of PartitionId.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        /// <param name="ledger">Initial value of Ledger.</param>
        /// <param name="recordVersion">Initial value of RecordVersion.</param>
        /// <param name="subledgerJournalEntry">Initial value of SubledgerJournalEntry.</param>
        /// <param name="recordCreatedTransactionId">Initial value of RecordCreatedTransactionId.</param>
        /// <param name="transferId">Initial value of TransferId.</param>
        /// <param name="fiscalCalendarYear">Initial value of FiscalCalendarYear.</param>
        /// <param name="recordCreatedDateTime">Initial value of RecordCreatedDateTime.</param>
        /// <param name="fiscalCalendarPeriod">Initial value of FiscalCalendarPeriod.</param>
        /// <param name="acknowledgementDate">Initial value of AcknowledgementDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GeneralJournalEntryBiEntity CreateGeneralJournalEntryBiEntity(long recordId, 
                    long budgetSourceLedgerEntryPosted, 
                    long ledgerEntryJournal, 
                    global::System.DateTimeOffset accountingDate, 
                    long partitionId, 
                    global::System.DateTimeOffset documentDate, 
                    long ledger, 
                    int recordVersion, 
                    long subledgerJournalEntry, 
                    long recordCreatedTransactionId, 
                    long transferId, 
                    long fiscalCalendarYear, 
                    global::System.DateTimeOffset recordCreatedDateTime, 
                    long fiscalCalendarPeriod, 
                    global::System.DateTimeOffset acknowledgementDate)
        {
            GeneralJournalEntryBiEntity generalJournalEntryBiEntity = new GeneralJournalEntryBiEntity();
            generalJournalEntryBiEntity.RecordId = recordId;
            generalJournalEntryBiEntity.BudgetSourceLedgerEntryPosted = budgetSourceLedgerEntryPosted;
            generalJournalEntryBiEntity.LedgerEntryJournal = ledgerEntryJournal;
            generalJournalEntryBiEntity.AccountingDate = accountingDate;
            generalJournalEntryBiEntity.PartitionId = partitionId;
            generalJournalEntryBiEntity.DocumentDate = documentDate;
            generalJournalEntryBiEntity.Ledger = ledger;
            generalJournalEntryBiEntity.RecordVersion = recordVersion;
            generalJournalEntryBiEntity.SubledgerJournalEntry = subledgerJournalEntry;
            generalJournalEntryBiEntity.RecordCreatedTransactionId = recordCreatedTransactionId;
            generalJournalEntryBiEntity.TransferId = transferId;
            generalJournalEntryBiEntity.FiscalCalendarYear = fiscalCalendarYear;
            generalJournalEntryBiEntity.RecordCreatedDateTime = recordCreatedDateTime;
            generalJournalEntryBiEntity.FiscalCalendarPeriod = fiscalCalendarPeriod;
            generalJournalEntryBiEntity.AcknowledgementDate = acknowledgementDate;
            return generalJournalEntryBiEntity;
        }
        /// <summary>
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingLayer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
        /// <summary>
        /// There are no comments for Property SubledgerVoucherDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerVoucherDataAreaId")]
        public virtual string SubledgerVoucherDataAreaId
        {
            get
            {
                return this._SubledgerVoucherDataAreaId;
            }
            set
            {
                this.OnSubledgerVoucherDataAreaIdChanging(value);
                this._SubledgerVoucherDataAreaId = value;
                this.OnSubledgerVoucherDataAreaIdChanged();
                this.OnPropertyChanged("SubledgerVoucherDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubledgerVoucherDataAreaId;
        partial void OnSubledgerVoucherDataAreaIdChanging(string value);
        partial void OnSubledgerVoucherDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property BudgetSourceLedgerEntryPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSourceLedgerEntryPosted")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetSourceLedgerEntryPosted is required.")]
        public virtual long BudgetSourceLedgerEntryPosted
        {
            get
            {
                return this._BudgetSourceLedgerEntryPosted;
            }
            set
            {
                this.OnBudgetSourceLedgerEntryPostedChanging(value);
                this._BudgetSourceLedgerEntryPosted = value;
                this.OnBudgetSourceLedgerEntryPostedChanged();
                this.OnPropertyChanged("BudgetSourceLedgerEntryPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _BudgetSourceLedgerEntryPosted;
        partial void OnBudgetSourceLedgerEntryPostedChanging(long value);
        partial void OnBudgetSourceLedgerEntryPostedChanged();
        /// <summary>
        /// There are no comments for Property LedgerEntryJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerEntryJournal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerEntryJournal is required.")]
        public virtual long LedgerEntryJournal
        {
            get
            {
                return this._LedgerEntryJournal;
            }
            set
            {
                this.OnLedgerEntryJournalChanging(value);
                this._LedgerEntryJournal = value;
                this.OnLedgerEntryJournalChanged();
                this.OnPropertyChanged("LedgerEntryJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LedgerEntryJournal;
        partial void OnLedgerEntryJournalChanging(long value);
        partial void OnLedgerEntryJournalChanged();
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
        /// There are no comments for Property PartitionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartitionId is required.")]
        public virtual long PartitionId
        {
            get
            {
                return this._PartitionId;
            }
            set
            {
                this.OnPartitionIdChanging(value);
                this._PartitionId = value;
                this.OnPartitionIdChanged();
                this.OnPropertyChanged("PartitionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PartitionId;
        partial void OnPartitionIdChanging(long value);
        partial void OnPartitionIdChanged();
        /// <summary>
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentDate is required.")]
        public virtual global::System.DateTimeOffset DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DocumentDate;
        partial void OnDocumentDateChanging(global::System.DateTimeOffset value);
        partial void OnDocumentDateChanged();
        /// <summary>
        /// There are no comments for Property JournalCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> JournalCategory
        {
            get
            {
                return this._JournalCategory;
            }
            set
            {
                this.OnJournalCategoryChanging(value);
                this._JournalCategory = value;
                this.OnJournalCategoryChanged();
                this.OnPropertyChanged("JournalCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> _JournalCategory;
        partial void OnJournalCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> value);
        partial void OnJournalCategoryChanged();
        /// <summary>
        /// There are no comments for Property LedgerPostingJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerPostingJournal")]
        public virtual string LedgerPostingJournal
        {
            get
            {
                return this._LedgerPostingJournal;
            }
            set
            {
                this.OnLedgerPostingJournalChanging(value);
                this._LedgerPostingJournal = value;
                this.OnLedgerPostingJournalChanged();
                this.OnPropertyChanged("LedgerPostingJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerPostingJournal;
        partial void OnLedgerPostingJournalChanging(string value);
        partial void OnLedgerPostingJournalChanged();
        /// <summary>
        /// There are no comments for Property Ledger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Ledger")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Ledger is required.")]
        public virtual long Ledger
        {
            get
            {
                return this._Ledger;
            }
            set
            {
                this.OnLedgerChanging(value);
                this._Ledger = value;
                this.OnLedgerChanged();
                this.OnPropertyChanged("Ledger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Ledger;
        partial void OnLedgerChanging(long value);
        partial void OnLedgerChanged();
        /// <summary>
        /// There are no comments for Property LedgerPostingJournalDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerPostingJournalDataAreaId")]
        public virtual string LedgerPostingJournalDataAreaId
        {
            get
            {
                return this._LedgerPostingJournalDataAreaId;
            }
            set
            {
                this.OnLedgerPostingJournalDataAreaIdChanging(value);
                this._LedgerPostingJournalDataAreaId = value;
                this.OnLedgerPostingJournalDataAreaIdChanged();
                this.OnPropertyChanged("LedgerPostingJournalDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerPostingJournalDataAreaId;
        partial void OnLedgerPostingJournalDataAreaIdChanging(string value);
        partial void OnLedgerPostingJournalDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property RecordVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordVersion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordVersion is required.")]
        public virtual int RecordVersion
        {
            get
            {
                return this._RecordVersion;
            }
            set
            {
                this.OnRecordVersionChanging(value);
                this._RecordVersion = value;
                this.OnRecordVersionChanged();
                this.OnPropertyChanged("RecordVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RecordVersion;
        partial void OnRecordVersionChanging(int value);
        partial void OnRecordVersionChanged();
        /// <summary>
        /// There are no comments for Property SubledgerJournalEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerJournalEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SubledgerJournalEntry is required.")]
        public virtual long SubledgerJournalEntry
        {
            get
            {
                return this._SubledgerJournalEntry;
            }
            set
            {
                this.OnSubledgerJournalEntryChanging(value);
                this._SubledgerJournalEntry = value;
                this.OnSubledgerJournalEntryChanged();
                this.OnPropertyChanged("SubledgerJournalEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SubledgerJournalEntry;
        partial void OnSubledgerJournalEntryChanging(long value);
        partial void OnSubledgerJournalEntryChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
        public virtual string DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentNumber;
        partial void OnDocumentNumberChanging(string value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property RecordCreatedTransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordCreatedTransactionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordCreatedTransactionId is required.")]
        public virtual long RecordCreatedTransactionId
        {
            get
            {
                return this._RecordCreatedTransactionId;
            }
            set
            {
                this.OnRecordCreatedTransactionIdChanging(value);
                this._RecordCreatedTransactionId = value;
                this.OnRecordCreatedTransactionIdChanged();
                this.OnPropertyChanged("RecordCreatedTransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordCreatedTransactionId;
        partial void OnRecordCreatedTransactionIdChanging(long value);
        partial void OnRecordCreatedTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property SubledgerVoucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerVoucher")]
        public virtual string SubledgerVoucher
        {
            get
            {
                return this._SubledgerVoucher;
            }
            set
            {
                this.OnSubledgerVoucherChanging(value);
                this._SubledgerVoucher = value;
                this.OnSubledgerVoucherChanged();
                this.OnPropertyChanged("SubledgerVoucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubledgerVoucher;
        partial void OnSubledgerVoucherChanging(string value);
        partial void OnSubledgerVoucherChanged();
        /// <summary>
        /// There are no comments for Property TransferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransferId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransferId is required.")]
        public virtual long TransferId
        {
            get
            {
                return this._TransferId;
            }
            set
            {
                this.OnTransferIdChanging(value);
                this._TransferId = value;
                this.OnTransferIdChanged();
                this.OnPropertyChanged("TransferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _TransferId;
        partial void OnTransferIdChanging(long value);
        partial void OnTransferIdChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYear")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendarYear is required.")]
        public virtual long FiscalCalendarYear
        {
            get
            {
                return this._FiscalCalendarYear;
            }
            set
            {
                this.OnFiscalCalendarYearChanging(value);
                this._FiscalCalendarYear = value;
                this.OnFiscalCalendarYearChanged();
                this.OnPropertyChanged("FiscalCalendarYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _FiscalCalendarYear;
        partial void OnFiscalCalendarYearChanging(long value);
        partial void OnFiscalCalendarYearChanged();
        /// <summary>
        /// There are no comments for Property RecordCreatedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordCreatedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordCreatedDateTime is required.")]
        public virtual global::System.DateTimeOffset RecordCreatedDateTime
        {
            get
            {
                return this._RecordCreatedDateTime;
            }
            set
            {
                this.OnRecordCreatedDateTimeChanging(value);
                this._RecordCreatedDateTime = value;
                this.OnRecordCreatedDateTimeChanged();
                this.OnPropertyChanged("RecordCreatedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RecordCreatedDateTime;
        partial void OnRecordCreatedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnRecordCreatedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendarPeriod is required.")]
        public virtual long FiscalCalendarPeriod
        {
            get
            {
                return this._FiscalCalendarPeriod;
            }
            set
            {
                this.OnFiscalCalendarPeriodChanging(value);
                this._FiscalCalendarPeriod = value;
                this.OnFiscalCalendarPeriodChanged();
                this.OnPropertyChanged("FiscalCalendarPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _FiscalCalendarPeriod;
        partial void OnFiscalCalendarPeriodChanging(long value);
        partial void OnFiscalCalendarPeriodChanged();
        /// <summary>
        /// There are no comments for Property JournalNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNumber")]
        public virtual string JournalNumber
        {
            get
            {
                return this._JournalNumber;
            }
            set
            {
                this.OnJournalNumberChanging(value);
                this._JournalNumber = value;
                this.OnJournalNumberChanged();
                this.OnPropertyChanged("JournalNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNumber;
        partial void OnJournalNumberChanging(string value);
        partial void OnJournalNumberChanged();
        /// <summary>
        /// There are no comments for Property AcknowledgementDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AcknowledgementDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AcknowledgementDate is required.")]
        public virtual global::System.DateTimeOffset AcknowledgementDate
        {
            get
            {
                return this._AcknowledgementDate;
            }
            set
            {
                this.OnAcknowledgementDateChanging(value);
                this._AcknowledgementDate = value;
                this.OnAcknowledgementDateChanged();
                this.OnPropertyChanged("AcknowledgementDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AcknowledgementDate;
        partial void OnAcknowledgementDateChanging(global::System.DateTimeOffset value);
        partial void OnAcknowledgementDateChanged();
        /// <summary>
        /// There are no comments for Property RecordCreatedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordCreatedBy")]
        public virtual string RecordCreatedBy
        {
            get
            {
                return this._RecordCreatedBy;
            }
            set
            {
                this.OnRecordCreatedByChanging(value);
                this._RecordCreatedBy = value;
                this.OnRecordCreatedByChanged();
                this.OnPropertyChanged("RecordCreatedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecordCreatedBy;
        partial void OnRecordCreatedByChanging(string value);
        partial void OnRecordCreatedByChanged();
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
