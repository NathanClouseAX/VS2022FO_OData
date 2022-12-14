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
    /// There are no comments for PayrollUSTaxTransactionSummarySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollUSTaxTransactionSummarySingle")]
    public partial class PayrollUSTaxTransactionSummarySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollUSTaxTransactionSummary>
    {
        /// <summary>
        /// Initialize a new PayrollUSTaxTransactionSummarySingle object.
        /// </summary>
        public PayrollUSTaxTransactionSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollUSTaxTransactionSummarySingle object.
        /// </summary>
        public PayrollUSTaxTransactionSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollUSTaxTransactionSummarySingle object.
        /// </summary>
        public PayrollUSTaxTransactionSummarySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollUSTaxTransactionSummary> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayStatementHeader")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle PayStatementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayStatementHeader == null))
                {
                    this._PayStatementHeader = new global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle(this.Context, GetPath("PayStatementHeader"));
                }
                return this._PayStatementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle _PayStatementHeader;
    }
    /// <summary>
    /// There are no comments for PayrollUSTaxTransactionSummary in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Worker
    /// PersonnelNumber
    /// PayStatementNumber
    /// TransDate
    /// TaxCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Worker", "PersonnelNumber", "PayStatementNumber", "TransDate", "TaxCode")]
    [global::Microsoft.OData.Client.EntitySet("PayrollUSTaxTransactionSummaries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollUSTaxTransactionSummary")]
    public partial class PayrollUSTaxTransactionSummary : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollUSTaxTransactionSummary object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="taxCode">Initial value of TaxCode.</param>
        /// <param name="actualCombinedTax">Initial value of ActualCombinedTax.</param>
        /// <param name="grossSubjectWages">Initial value of GrossSubjectWages.</param>
        /// <param name="priorStateWageAmount">Initial value of PriorStateWageAmount.</param>
        /// <param name="rate">Initial value of Rate.</param>
        /// <param name="systemCalculatedTax">Initial value of SystemCalculatedTax.</param>
        /// <param name="subjectWages">Initial value of SubjectWages.</param>
        /// <param name="wageBase">Initial value of WageBase.</param>
        /// <param name="hours">Initial value of Hours.</param>
        /// <param name="grossWages">Initial value of GrossWages.</param>
        /// <param name="excessWages">Initial value of ExcessWages.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollUSTaxTransactionSummary CreatePayrollUSTaxTransactionSummary(string dataAreaId, 
                    string worker, 
                    string personnelNumber, 
                    string payStatementNumber, 
                    global::System.DateTimeOffset transDate, 
                    string taxCode, 
                    decimal actualCombinedTax, 
                    decimal grossSubjectWages, 
                    decimal priorStateWageAmount, 
                    decimal rate, 
                    decimal systemCalculatedTax, 
                    decimal subjectWages, 
                    decimal wageBase, 
                    decimal hours, 
                    decimal grossWages, 
                    decimal excessWages, 
                    global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            PayrollUSTaxTransactionSummary payrollUSTaxTransactionSummary = new PayrollUSTaxTransactionSummary();
            payrollUSTaxTransactionSummary.DataAreaId = dataAreaId;
            payrollUSTaxTransactionSummary.Worker = worker;
            payrollUSTaxTransactionSummary.PersonnelNumber = personnelNumber;
            payrollUSTaxTransactionSummary.PayStatementNumber = payStatementNumber;
            payrollUSTaxTransactionSummary.TransDate = transDate;
            payrollUSTaxTransactionSummary.TaxCode = taxCode;
            payrollUSTaxTransactionSummary.ActualCombinedTax = actualCombinedTax;
            payrollUSTaxTransactionSummary.GrossSubjectWages = grossSubjectWages;
            payrollUSTaxTransactionSummary.PriorStateWageAmount = priorStateWageAmount;
            payrollUSTaxTransactionSummary.Rate = rate;
            payrollUSTaxTransactionSummary.SystemCalculatedTax = systemCalculatedTax;
            payrollUSTaxTransactionSummary.SubjectWages = subjectWages;
            payrollUSTaxTransactionSummary.WageBase = wageBase;
            payrollUSTaxTransactionSummary.Hours = hours;
            payrollUSTaxTransactionSummary.GrossWages = grossWages;
            payrollUSTaxTransactionSummary.ExcessWages = excessWages;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            payrollUSTaxTransactionSummary.PayStatementHeader = payStatementHeader;
            return payrollUSTaxTransactionSummary;
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
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Worker is required.")]
        public virtual string Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Worker;
        partial void OnWorkerChanging(string value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelNumber is required.")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property PayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayStatementNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayStatementNumber is required.")]
        public virtual string PayStatementNumber
        {
            get
            {
                return this._PayStatementNumber;
            }
            set
            {
                this.OnPayStatementNumberChanging(value);
                this._PayStatementNumber = value;
                this.OnPayStatementNumberChanged();
                this.OnPropertyChanged("PayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayStatementNumber;
        partial void OnPayStatementNumberChanging(string value);
        partial void OnPayStatementNumberChanged();
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
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxCode is required.")]
        public virtual string TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property Residency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Residency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> Residency
        {
            get
            {
                return this._Residency;
            }
            set
            {
                this.OnResidencyChanging(value);
                this._Residency = value;
                this.OnResidencyChanged();
                this.OnPropertyChanged("Residency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> _Residency;
        partial void OnResidencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> value);
        partial void OnResidencyChanged();
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
        /// There are no comments for Property ActualCombinedTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualCombinedTax")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualCombinedTax is required.")]
        public virtual decimal ActualCombinedTax
        {
            get
            {
                return this._ActualCombinedTax;
            }
            set
            {
                this.OnActualCombinedTaxChanging(value);
                this._ActualCombinedTax = value;
                this.OnActualCombinedTaxChanged();
                this.OnPropertyChanged("ActualCombinedTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ActualCombinedTax;
        partial void OnActualCombinedTaxChanging(decimal value);
        partial void OnActualCombinedTaxChanged();
        /// <summary>
        /// There are no comments for Property GrossSubjectWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossSubjectWages")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GrossSubjectWages is required.")]
        public virtual decimal GrossSubjectWages
        {
            get
            {
                return this._GrossSubjectWages;
            }
            set
            {
                this.OnGrossSubjectWagesChanging(value);
                this._GrossSubjectWages = value;
                this.OnGrossSubjectWagesChanged();
                this.OnPropertyChanged("GrossSubjectWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _GrossSubjectWages;
        partial void OnGrossSubjectWagesChanging(decimal value);
        partial void OnGrossSubjectWagesChanged();
        /// <summary>
        /// There are no comments for Property PriorStateWageAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriorStateWageAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriorStateWageAmount is required.")]
        public virtual decimal PriorStateWageAmount
        {
            get
            {
                return this._PriorStateWageAmount;
            }
            set
            {
                this.OnPriorStateWageAmountChanging(value);
                this._PriorStateWageAmount = value;
                this.OnPriorStateWageAmountChanged();
                this.OnPropertyChanged("PriorStateWageAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PriorStateWageAmount;
        partial void OnPriorStateWageAmountChanging(decimal value);
        partial void OnPriorStateWageAmountChanged();
        /// <summary>
        /// There are no comments for Property Rate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Rate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Rate is required.")]
        public virtual decimal Rate
        {
            get
            {
                return this._Rate;
            }
            set
            {
                this.OnRateChanging(value);
                this._Rate = value;
                this.OnRateChanged();
                this.OnPropertyChanged("Rate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Rate;
        partial void OnRateChanging(decimal value);
        partial void OnRateChanged();
        /// <summary>
        /// There are no comments for Property SystemCalculatedTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemCalculatedTax")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SystemCalculatedTax is required.")]
        public virtual decimal SystemCalculatedTax
        {
            get
            {
                return this._SystemCalculatedTax;
            }
            set
            {
                this.OnSystemCalculatedTaxChanging(value);
                this._SystemCalculatedTax = value;
                this.OnSystemCalculatedTaxChanged();
                this.OnPropertyChanged("SystemCalculatedTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SystemCalculatedTax;
        partial void OnSystemCalculatedTaxChanging(decimal value);
        partial void OnSystemCalculatedTaxChanged();
        /// <summary>
        /// There are no comments for Property PriorState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriorState")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> PriorState
        {
            get
            {
                return this._PriorState;
            }
            set
            {
                this.OnPriorStateChanging(value);
                this._PriorState = value;
                this.OnPriorStateChanged();
                this.OnPropertyChanged("PriorState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> _PriorState;
        partial void OnPriorStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> value);
        partial void OnPriorStateChanged();
        /// <summary>
        /// There are no comments for Property SubjectWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubjectWages")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SubjectWages is required.")]
        public virtual decimal SubjectWages
        {
            get
            {
                return this._SubjectWages;
            }
            set
            {
                this.OnSubjectWagesChanging(value);
                this._SubjectWages = value;
                this.OnSubjectWagesChanged();
                this.OnPropertyChanged("SubjectWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SubjectWages;
        partial void OnSubjectWagesChanging(decimal value);
        partial void OnSubjectWagesChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCodeType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> TaxCodeType
        {
            get
            {
                return this._TaxCodeType;
            }
            set
            {
                this.OnTaxCodeTypeChanging(value);
                this._TaxCodeType = value;
                this.OnTaxCodeTypeChanged();
                this.OnPropertyChanged("TaxCodeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> _TaxCodeType;
        partial void OnTaxCodeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> value);
        partial void OnTaxCodeTypeChanged();
        /// <summary>
        /// There are no comments for Property PoliticalSubDivisionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PoliticalSubDivisionId")]
        public virtual string PoliticalSubDivisionId
        {
            get
            {
                return this._PoliticalSubDivisionId;
            }
            set
            {
                this.OnPoliticalSubDivisionIdChanging(value);
                this._PoliticalSubDivisionId = value;
                this.OnPoliticalSubDivisionIdChanged();
                this.OnPropertyChanged("PoliticalSubDivisionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PoliticalSubDivisionId;
        partial void OnPoliticalSubDivisionIdChanging(string value);
        partial void OnPoliticalSubDivisionIdChanged();
        /// <summary>
        /// There are no comments for Property WageBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WageBase")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WageBase is required.")]
        public virtual decimal WageBase
        {
            get
            {
                return this._WageBase;
            }
            set
            {
                this.OnWageBaseChanging(value);
                this._WageBase = value;
                this.OnWageBaseChanged();
                this.OnPropertyChanged("WageBase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WageBase;
        partial void OnWageBaseChanging(decimal value);
        partial void OnWageBaseChanged();
        /// <summary>
        /// There are no comments for Property Hours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Hours")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Hours is required.")]
        public virtual decimal Hours
        {
            get
            {
                return this._Hours;
            }
            set
            {
                this.OnHoursChanging(value);
                this._Hours = value;
                this.OnHoursChanged();
                this.OnPropertyChanged("Hours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Hours;
        partial void OnHoursChanging(decimal value);
        partial void OnHoursChanged();
        /// <summary>
        /// There are no comments for Property VendInvoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoice")]
        public virtual string VendInvoice
        {
            get
            {
                return this._VendInvoice;
            }
            set
            {
                this.OnVendInvoiceChanging(value);
                this._VendInvoice = value;
                this.OnVendInvoiceChanged();
                this.OnPropertyChanged("VendInvoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendInvoice;
        partial void OnVendInvoiceChanging(string value);
        partial void OnVendInvoiceChanged();
        /// <summary>
        /// There are no comments for Property GrossWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossWages")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GrossWages is required.")]
        public virtual decimal GrossWages
        {
            get
            {
                return this._GrossWages;
            }
            set
            {
                this.OnGrossWagesChanging(value);
                this._GrossWages = value;
                this.OnGrossWagesChanged();
                this.OnPropertyChanged("GrossWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _GrossWages;
        partial void OnGrossWagesChanging(decimal value);
        partial void OnGrossWagesChanged();
        /// <summary>
        /// There are no comments for Property TaxationState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxationState")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> TaxationState
        {
            get
            {
                return this._TaxationState;
            }
            set
            {
                this.OnTaxationStateChanging(value);
                this._TaxationState = value;
                this.OnTaxationStateChanged();
                this.OnPropertyChanged("TaxationState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> _TaxationState;
        partial void OnTaxationStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> value);
        partial void OnTaxationStateChanged();
        /// <summary>
        /// There are no comments for Property ExcessWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExcessWages")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExcessWages is required.")]
        public virtual decimal ExcessWages
        {
            get
            {
                return this._ExcessWages;
            }
            set
            {
                this.OnExcessWagesChanging(value);
                this._ExcessWages = value;
                this.OnExcessWagesChanged();
                this.OnPropertyChanged("ExcessWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExcessWages;
        partial void OnExcessWagesChanging(decimal value);
        partial void OnExcessWagesChanged();
        /// <summary>
        /// There are no comments for Property PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayStatementHeader")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayStatementHeader is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeader PayStatementHeader
        {
            get
            {
                return this._PayStatementHeader;
            }
            set
            {
                this.OnPayStatementHeaderChanging(value);
                this._PayStatementHeader = value;
                this.OnPayStatementHeaderChanged();
                this.OnPropertyChanged("PayStatementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeader _PayStatementHeader;
        partial void OnPayStatementHeaderChanging(global::Microsoft.Dynamics.DataEntities.PayStatementHeader value);
        partial void OnPayStatementHeaderChanged();
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
