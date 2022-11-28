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
    /// There are no comments for PurchAgreementPaymentOrderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchAgreementPaymentOrderSingle")]
    public partial class PurchAgreementPaymentOrderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchAgreementPaymentOrder>
    {
        /// <summary>
        /// Initialize a new PurchAgreementPaymentOrderSingle object.
        /// </summary>
        public PurchAgreementPaymentOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchAgreementPaymentOrderSingle object.
        /// </summary>
        public PurchAgreementPaymentOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchAgreementPaymentOrderSingle object.
        /// </summary>
        public PurchAgreementPaymentOrderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchAgreementPaymentOrder> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PurchAgreementPaymentOrder in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LegalEntity
    /// PurchaseAgreement
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LegalEntity", "PurchaseAgreement")]
    [global::Microsoft.OData.Client.EntitySet("PurchAgreementPaymentOrders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchAgreementPaymentOrder")]
    public partial class PurchAgreementPaymentOrder : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchAgreementPaymentOrder object.
        /// </summary>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        /// <param name="purchaseAgreement">Initial value of PurchaseAgreement.</param>
        /// <param name="periodNumber">Initial value of PeriodNumber.</param>
        /// <param name="periodDate">Initial value of PeriodDate.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchAgreementPaymentOrder CreatePurchAgreementPaymentOrder(string legalEntity, string purchaseAgreement, int periodNumber, global::System.DateTimeOffset periodDate, global::System.DateTimeOffset documentDate)
        {
            PurchAgreementPaymentOrder purchAgreementPaymentOrder = new PurchAgreementPaymentOrder();
            purchAgreementPaymentOrder.LegalEntity = legalEntity;
            purchAgreementPaymentOrder.PurchaseAgreement = purchaseAgreement;
            purchAgreementPaymentOrder.PeriodNumber = periodNumber;
            purchAgreementPaymentOrder.PeriodDate = periodDate;
            purchAgreementPaymentOrder.DocumentDate = documentDate;
            return purchAgreementPaymentOrder;
        }
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntity is required.")]
        public virtual string LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity;
        partial void OnLegalEntityChanging(string value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreement")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseAgreement is required.")]
        public virtual string PurchaseAgreement
        {
            get
            {
                return this._PurchaseAgreement;
            }
            set
            {
                this.OnPurchaseAgreementChanging(value);
                this._PurchaseAgreement = value;
                this.OnPurchaseAgreementChanged();
                this.OnPropertyChanged("PurchaseAgreement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseAgreement;
        partial void OnPurchaseAgreementChanging(string value);
        partial void OnPurchaseAgreementChanged();
        /// <summary>
        /// There are no comments for Property UCI in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UCI")]
        public virtual string UCI
        {
            get
            {
                return this._UCI;
            }
            set
            {
                this.OnUCIChanging(value);
                this._UCI = value;
                this.OnUCIChanged();
                this.OnPropertyChanged("UCI");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UCI;
        partial void OnUCIChanging(string value);
        partial void OnUCIChanged();
        /// <summary>
        /// There are no comments for Property RRCPrinting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RRCPrinting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RRCPrinting
        {
            get
            {
                return this._RRCPrinting;
            }
            set
            {
                this.OnRRCPrintingChanging(value);
                this._RRCPrinting = value;
                this.OnRRCPrintingChanged();
                this.OnPropertyChanged("RRCPrinting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RRCPrinting;
        partial void OnRRCPrintingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRRCPrintingChanged();
        /// <summary>
        /// There are no comments for Property PeriodNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodNumber is required.")]
        public virtual int PeriodNumber
        {
            get
            {
                return this._PeriodNumber;
            }
            set
            {
                this.OnPeriodNumberChanging(value);
                this._PeriodNumber = value;
                this.OnPeriodNumberChanged();
                this.OnPropertyChanged("PeriodNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PeriodNumber;
        partial void OnPeriodNumberChanging(int value);
        partial void OnPeriodNumberChanged();
        /// <summary>
        /// There are no comments for Property PurposeText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurposeText")]
        public virtual string PurposeText
        {
            get
            {
                return this._PurposeText;
            }
            set
            {
                this.OnPurposeTextChanging(value);
                this._PurposeText = value;
                this.OnPurposeTextChanged();
                this.OnPropertyChanged("PurposeText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurposeText;
        partial void OnPurposeTextChanging(string value);
        partial void OnPurposeTextChanged();
        /// <summary>
        /// There are no comments for Property BudgetRevenueCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetRevenueCode")]
        public virtual string BudgetRevenueCode
        {
            get
            {
                return this._BudgetRevenueCode;
            }
            set
            {
                this.OnBudgetRevenueCodeChanging(value);
                this._BudgetRevenueCode = value;
                this.OnBudgetRevenueCodeChanged();
                this.OnPropertyChanged("BudgetRevenueCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetRevenueCode;
        partial void OnBudgetRevenueCodeChanging(string value);
        partial void OnBudgetRevenueCodeChanged();
        /// <summary>
        /// There are no comments for Property OrderOfPayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderOfPayment")]
        public virtual string OrderOfPayment
        {
            get
            {
                return this._OrderOfPayment;
            }
            set
            {
                this.OnOrderOfPaymentChanging(value);
                this._OrderOfPayment = value;
                this.OnOrderOfPaymentChanged();
                this.OnPropertyChanged("OrderOfPayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderOfPayment;
        partial void OnOrderOfPaymentChanging(string value);
        partial void OnOrderOfPaymentChanged();
        /// <summary>
        /// There are no comments for Property PeriodCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymentOrderPeriodCode_RU> PeriodCode
        {
            get
            {
                return this._PeriodCode;
            }
            set
            {
                this.OnPeriodCodeChanging(value);
                this._PeriodCode = value;
                this.OnPeriodCodeChanged();
                this.OnPropertyChanged("PeriodCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymentOrderPeriodCode_RU> _PeriodCode;
        partial void OnPeriodCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PaymentOrderPeriodCode_RU> value);
        partial void OnPeriodCodeChanged();
        /// <summary>
        /// There are no comments for Property PeriodDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodDate is required.")]
        public virtual global::System.DateTimeOffset PeriodDate
        {
            get
            {
                return this._PeriodDate;
            }
            set
            {
                this.OnPeriodDateChanging(value);
                this._PeriodDate = value;
                this.OnPeriodDateChanged();
                this.OnPropertyChanged("PeriodDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodDate;
        partial void OnPeriodDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodDateChanged();
        /// <summary>
        /// There are no comments for Property OriginPayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginPayment")]
        public virtual string OriginPayment
        {
            get
            {
                return this._OriginPayment;
            }
            set
            {
                this.OnOriginPaymentChanging(value);
                this._OriginPayment = value;
                this.OnOriginPaymentChanged();
                this.OnPropertyChanged("OriginPayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginPayment;
        partial void OnOriginPaymentChanging(string value);
        partial void OnOriginPaymentChanged();
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
        /// There are no comments for Property RCOAD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RCOAD")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RCOAD
        {
            get
            {
                return this._RCOAD;
            }
            set
            {
                this.OnRCOADChanging(value);
                this._RCOAD = value;
                this.OnRCOADChanged();
                this.OnPropertyChanged("RCOAD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RCOAD;
        partial void OnRCOADChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRCOADChanged();
        /// <summary>
        /// There are no comments for Property PaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentType")]
        public virtual string PaymentType
        {
            get
            {
                return this._PaymentType;
            }
            set
            {
                this.OnPaymentTypeChanging(value);
                this._PaymentType = value;
                this.OnPaymentTypeChanged();
                this.OnPropertyChanged("PaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentType;
        partial void OnPaymentTypeChanging(string value);
        partial void OnPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property NumberStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberStatus")]
        public virtual string NumberStatus
        {
            get
            {
                return this._NumberStatus;
            }
            set
            {
                this.OnNumberStatusChanging(value);
                this._NumberStatus = value;
                this.OnNumberStatusChanged();
                this.OnPropertyChanged("NumberStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumberStatus;
        partial void OnNumberStatusChanging(string value);
        partial void OnNumberStatusChanged();
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
