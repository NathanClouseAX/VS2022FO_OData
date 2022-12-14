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
    /// There are no comments for SubBillDeferralBalanceEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillDeferralBalanceEntitySingle")]
    public partial class SubBillDeferralBalanceEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillDeferralBalanceEntity>
    {
        /// <summary>
        /// Initialize a new SubBillDeferralBalanceEntitySingle object.
        /// </summary>
        public SubBillDeferralBalanceEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillDeferralBalanceEntitySingle object.
        /// </summary>
        public SubBillDeferralBalanceEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillDeferralBalanceEntitySingle object.
        /// </summary>
        public SubBillDeferralBalanceEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillDeferralBalanceEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillDeferralBalanceEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DeferralScheduleNumber
    /// ItemNumber
    /// BillingScheduleNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DeferralScheduleNumber", "ItemNumber", "BillingScheduleNumber")]
    [global::Microsoft.OData.Client.EntitySet("SubBillDeferralBalancesListEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillDeferralBalanceEntity")]
    public partial class SubBillDeferralBalanceEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillDeferralBalanceEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="deferralScheduleNumber">Initial value of DeferralScheduleNumber.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="billingScheduleNumber">Initial value of BillingScheduleNumber.</param>
        /// <param name="date">Initial value of Date.</param>
        /// <param name="deferralStartDate">Initial value of DeferralStartDate.</param>
        /// <param name="originalDeferralAmount">Initial value of OriginalDeferralAmount.</param>
        /// <param name="recognizedAmount">Initial value of RecognizedAmount.</param>
        /// <param name="deferralEndDate">Initial value of DeferralEndDate.</param>
        /// <param name="deferralBalance">Initial value of DeferralBalance.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillDeferralBalanceEntity CreateSubBillDeferralBalanceEntity(string dataAreaId, 
                    string deferralScheduleNumber, 
                    string itemNumber, 
                    string billingScheduleNumber, 
                    global::System.DateTimeOffset date, 
                    global::System.DateTimeOffset deferralStartDate, 
                    decimal originalDeferralAmount, 
                    decimal recognizedAmount, 
                    global::System.DateTimeOffset deferralEndDate, 
                    decimal deferralBalance)
        {
            SubBillDeferralBalanceEntity subBillDeferralBalanceEntity = new SubBillDeferralBalanceEntity();
            subBillDeferralBalanceEntity.DataAreaId = dataAreaId;
            subBillDeferralBalanceEntity.DeferralScheduleNumber = deferralScheduleNumber;
            subBillDeferralBalanceEntity.ItemNumber = itemNumber;
            subBillDeferralBalanceEntity.BillingScheduleNumber = billingScheduleNumber;
            subBillDeferralBalanceEntity.Date = date;
            subBillDeferralBalanceEntity.DeferralStartDate = deferralStartDate;
            subBillDeferralBalanceEntity.OriginalDeferralAmount = originalDeferralAmount;
            subBillDeferralBalanceEntity.RecognizedAmount = recognizedAmount;
            subBillDeferralBalanceEntity.DeferralEndDate = deferralEndDate;
            subBillDeferralBalanceEntity.DeferralBalance = deferralBalance;
            return subBillDeferralBalanceEntity;
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
        /// There are no comments for Property DeferralScheduleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralScheduleNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralScheduleNumber is required.")]
        public virtual string DeferralScheduleNumber
        {
            get
            {
                return this._DeferralScheduleNumber;
            }
            set
            {
                this.OnDeferralScheduleNumberChanging(value);
                this._DeferralScheduleNumber = value;
                this.OnDeferralScheduleNumberChanged();
                this.OnPropertyChanged("DeferralScheduleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralScheduleNumber;
        partial void OnDeferralScheduleNumberChanging(string value);
        partial void OnDeferralScheduleNumberChanged();
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
        /// There are no comments for Property BillingScheduleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingScheduleNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingScheduleNumber is required.")]
        public virtual string BillingScheduleNumber
        {
            get
            {
                return this._BillingScheduleNumber;
            }
            set
            {
                this.OnBillingScheduleNumberChanging(value);
                this._BillingScheduleNumber = value;
                this.OnBillingScheduleNumberChanged();
                this.OnPropertyChanged("BillingScheduleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingScheduleNumber;
        partial void OnBillingScheduleNumberChanging(string value);
        partial void OnBillingScheduleNumberChanged();
        /// <summary>
        /// There are no comments for Property ScheduleLineStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleLineStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillScheduleStatus> ScheduleLineStatus
        {
            get
            {
                return this._ScheduleLineStatus;
            }
            set
            {
                this.OnScheduleLineStatusChanging(value);
                this._ScheduleLineStatus = value;
                this.OnScheduleLineStatusChanged();
                this.OnPropertyChanged("ScheduleLineStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillScheduleStatus> _ScheduleLineStatus;
        partial void OnScheduleLineStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillScheduleStatus> value);
        partial void OnScheduleLineStatusChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Date is required.")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property DeferralStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralStartDate is required.")]
        public virtual global::System.DateTimeOffset DeferralStartDate
        {
            get
            {
                return this._DeferralStartDate;
            }
            set
            {
                this.OnDeferralStartDateChanging(value);
                this._DeferralStartDate = value;
                this.OnDeferralStartDateChanged();
                this.OnPropertyChanged("DeferralStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeferralStartDate;
        partial void OnDeferralStartDateChanging(global::System.DateTimeOffset value);
        partial void OnDeferralStartDateChanged();
        /// <summary>
        /// There are no comments for Property ScheduleStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleStatus> ScheduleStatus
        {
            get
            {
                return this._ScheduleStatus;
            }
            set
            {
                this.OnScheduleStatusChanging(value);
                this._ScheduleStatus = value;
                this.OnScheduleStatusChanged();
                this.OnPropertyChanged("ScheduleStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleStatus> _ScheduleStatus;
        partial void OnScheduleStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleStatus> value);
        partial void OnScheduleStatusChanged();
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
        /// There are no comments for Property InvoicingName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoicingName")]
        public virtual string InvoicingName
        {
            get
            {
                return this._InvoicingName;
            }
            set
            {
                this.OnInvoicingNameChanging(value);
                this._InvoicingName = value;
                this.OnInvoicingNameChanged();
                this.OnPropertyChanged("InvoicingName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoicingName;
        partial void OnInvoicingNameChanging(string value);
        partial void OnInvoicingNameChanged();
        /// <summary>
        /// There are no comments for Property ScheduleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleType> ScheduleType
        {
            get
            {
                return this._ScheduleType;
            }
            set
            {
                this.OnScheduleTypeChanging(value);
                this._ScheduleType = value;
                this.OnScheduleTypeChanged();
                this.OnPropertyChanged("ScheduleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleType> _ScheduleType;
        partial void OnScheduleTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralScheduleType> value);
        partial void OnScheduleTypeChanged();
        /// <summary>
        /// There are no comments for Property OriginalDeferralAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginalDeferralAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OriginalDeferralAmount is required.")]
        public virtual decimal OriginalDeferralAmount
        {
            get
            {
                return this._OriginalDeferralAmount;
            }
            set
            {
                this.OnOriginalDeferralAmountChanging(value);
                this._OriginalDeferralAmount = value;
                this.OnOriginalDeferralAmountChanged();
                this.OnPropertyChanged("OriginalDeferralAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OriginalDeferralAmount;
        partial void OnOriginalDeferralAmountChanging(decimal value);
        partial void OnOriginalDeferralAmountChanged();
        /// <summary>
        /// There are no comments for Property ChargesCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesCode")]
        public virtual string ChargesCode
        {
            get
            {
                return this._ChargesCode;
            }
            set
            {
                this.OnChargesCodeChanging(value);
                this._ChargesCode = value;
                this.OnChargesCodeChanged();
                this.OnPropertyChanged("ChargesCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargesCode;
        partial void OnChargesCodeChanging(string value);
        partial void OnChargesCodeChanged();
        /// <summary>
        /// There are no comments for Property DeferralAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralAccountDisplayValue")]
        public virtual string DeferralAccountDisplayValue
        {
            get
            {
                return this._DeferralAccountDisplayValue;
            }
            set
            {
                this.OnDeferralAccountDisplayValueChanging(value);
                this._DeferralAccountDisplayValue = value;
                this.OnDeferralAccountDisplayValueChanged();
                this.OnPropertyChanged("DeferralAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralAccountDisplayValue;
        partial void OnDeferralAccountDisplayValueChanging(string value);
        partial void OnDeferralAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralTransactionType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralTransactionType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillDeferralTransactionType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property RecognizedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecognizedAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecognizedAmount is required.")]
        public virtual decimal RecognizedAmount
        {
            get
            {
                return this._RecognizedAmount;
            }
            set
            {
                this.OnRecognizedAmountChanging(value);
                this._RecognizedAmount = value;
                this.OnRecognizedAmountChanged();
                this.OnPropertyChanged("RecognizedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RecognizedAmount;
        partial void OnRecognizedAmountChanging(decimal value);
        partial void OnRecognizedAmountChanged();
        /// <summary>
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Invoice")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
        /// <summary>
        /// There are no comments for Property DeferralEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralEndDate is required.")]
        public virtual global::System.DateTimeOffset DeferralEndDate
        {
            get
            {
                return this._DeferralEndDate;
            }
            set
            {
                this.OnDeferralEndDateChanging(value);
                this._DeferralEndDate = value;
                this.OnDeferralEndDateChanged();
                this.OnPropertyChanged("DeferralEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeferralEndDate;
        partial void OnDeferralEndDateChanging(global::System.DateTimeOffset value);
        partial void OnDeferralEndDateChanged();
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
        /// There are no comments for Property MainAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccount")]
        public virtual string MainAccount
        {
            get
            {
                return this._MainAccount;
            }
            set
            {
                this.OnMainAccountChanging(value);
                this._MainAccount = value;
                this.OnMainAccountChanged();
                this.OnPropertyChanged("MainAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccount;
        partial void OnMainAccountChanging(string value);
        partial void OnMainAccountChanged();
        /// <summary>
        /// There are no comments for Property DeferralBalance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralBalance")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralBalance is required.")]
        public virtual decimal DeferralBalance
        {
            get
            {
                return this._DeferralBalance;
            }
            set
            {
                this.OnDeferralBalanceChanging(value);
                this._DeferralBalance = value;
                this.OnDeferralBalanceChanged();
                this.OnPropertyChanged("DeferralBalance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeferralBalance;
        partial void OnDeferralBalanceChanging(decimal value);
        partial void OnDeferralBalanceChanged();
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
