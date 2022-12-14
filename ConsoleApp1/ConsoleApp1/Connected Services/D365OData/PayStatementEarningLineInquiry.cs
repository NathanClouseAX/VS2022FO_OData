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
    /// There are no comments for PayStatementEarningLineInquirySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayStatementEarningLineInquirySingle")]
    public partial class PayStatementEarningLineInquirySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementEarningLineInquiry>
    {
        /// <summary>
        /// Initialize a new PayStatementEarningLineInquirySingle object.
        /// </summary>
        public PayStatementEarningLineInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayStatementEarningLineInquirySingle object.
        /// </summary>
        public PayStatementEarningLineInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayStatementEarningLineInquirySingle object.
        /// </summary>
        public PayStatementEarningLineInquirySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayStatementEarningLineInquiry> query)
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
    /// There are no comments for PayStatementEarningLineInquiry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PayStatementNumber
    /// LineNum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PayStatementNumber", "LineNum")]
    [global::Microsoft.OData.Client.EntitySet("PayStatementEarningLineInquiries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayStatementEarningLineInquiry")]
    public partial class PayStatementEarningLineInquiry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayStatementEarningLineInquiry object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="accountingCurrencyAmount">Initial value of AccountingCurrencyAmount.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="earningRate">Initial value of EarningRate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayStatementEarningLineInquiry CreatePayStatementEarningLineInquiry(string dataAreaId, 
                    string payStatementNumber, 
                    decimal lineNum, 
                    decimal accountingCurrencyAmount, 
                    global::System.DateTimeOffset periodEndDate, 
                    global::System.DateTimeOffset accountingDate, 
                    global::System.DateTimeOffset periodStartDate, 
                    decimal earningRate, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            PayStatementEarningLineInquiry payStatementEarningLineInquiry = new PayStatementEarningLineInquiry();
            payStatementEarningLineInquiry.DataAreaId = dataAreaId;
            payStatementEarningLineInquiry.PayStatementNumber = payStatementNumber;
            payStatementEarningLineInquiry.LineNum = lineNum;
            payStatementEarningLineInquiry.AccountingCurrencyAmount = accountingCurrencyAmount;
            payStatementEarningLineInquiry.PeriodEndDate = periodEndDate;
            payStatementEarningLineInquiry.AccountingDate = accountingDate;
            payStatementEarningLineInquiry.PeriodStartDate = periodStartDate;
            payStatementEarningLineInquiry.EarningRate = earningRate;
            payStatementEarningLineInquiry.Quantity = quantity;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            payStatementEarningLineInquiry.PayStatementHeader = payStatementHeader;
            return payStatementEarningLineInquiry;
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
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property PayCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayCycleId")]
        public virtual string PayCycleId
        {
            get
            {
                return this._PayCycleId;
            }
            set
            {
                this.OnPayCycleIdChanging(value);
                this._PayCycleId = value;
                this.OnPayCycleIdChanged();
                this.OnPropertyChanged("PayCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayCycleId;
        partial void OnPayCycleIdChanging(string value);
        partial void OnPayCycleIdChanged();
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
        /// There are no comments for Property BenefitPlanIDGLI in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlanIDGLI")]
        public virtual string BenefitPlanIDGLI
        {
            get
            {
                return this._BenefitPlanIDGLI;
            }
            set
            {
                this.OnBenefitPlanIDGLIChanging(value);
                this._BenefitPlanIDGLI = value;
                this.OnBenefitPlanIDGLIChanged();
                this.OnPropertyChanged("BenefitPlanIDGLI");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanIDGLI;
        partial void OnBenefitPlanIDGLIChanging(string value);
        partial void OnBenefitPlanIDGLIChanged();
        /// <summary>
        /// There are no comments for Property Source in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Source")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> Source
        {
            get
            {
                return this._Source;
            }
            set
            {
                this.OnSourceChanging(value);
                this._Source = value;
                this.OnSourceChanged();
                this.OnPropertyChanged("Source");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> _Source;
        partial void OnSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPayStatementLineSource> value);
        partial void OnSourceChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingCurrencyAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingCurrencyAmount is required.")]
        public virtual decimal AccountingCurrencyAmount
        {
            get
            {
                return this._AccountingCurrencyAmount;
            }
            set
            {
                this.OnAccountingCurrencyAmountChanging(value);
                this._AccountingCurrencyAmount = value;
                this.OnAccountingCurrencyAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyAmount;
        partial void OnAccountingCurrencyAmountChanging(decimal value);
        partial void OnAccountingCurrencyAmountChanged();
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionId")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property WorkerCompensation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerCompensation")]
        public virtual string WorkerCompensation
        {
            get
            {
                return this._WorkerCompensation;
            }
            set
            {
                this.OnWorkerCompensationChanging(value);
                this._WorkerCompensation = value;
                this.OnWorkerCompensationChanged();
                this.OnPropertyChanged("WorkerCompensation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerCompensation;
        partial void OnWorkerCompensationChanging(string value);
        partial void OnWorkerCompensationChanged();
        /// <summary>
        /// There are no comments for Property EarningCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EarningCode")]
        public virtual string EarningCode
        {
            get
            {
                return this._EarningCode;
            }
            set
            {
                this.OnEarningCodeChanging(value);
                this._EarningCode = value;
                this.OnEarningCodeChanged();
                this.OnPropertyChanged("EarningCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCode;
        partial void OnEarningCodeChanging(string value);
        partial void OnEarningCodeChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodEndDate is required.")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
        /// <summary>
        /// There are no comments for Property BenefitOptionIDGLI in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitOptionIDGLI")]
        public virtual string BenefitOptionIDGLI
        {
            get
            {
                return this._BenefitOptionIDGLI;
            }
            set
            {
                this.OnBenefitOptionIDGLIChanging(value);
                this._BenefitOptionIDGLI = value;
                this.OnBenefitOptionIDGLIChanged();
                this.OnPropertyChanged("BenefitOptionIDGLI");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitOptionIDGLI;
        partial void OnBenefitOptionIDGLIChanging(string value);
        partial void OnBenefitOptionIDGLIChanged();
        /// <summary>
        /// There are no comments for Property TaxRegionDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxRegionDescription")]
        public virtual string TaxRegionDescription
        {
            get
            {
                return this._TaxRegionDescription;
            }
            set
            {
                this.OnTaxRegionDescriptionChanging(value);
                this._TaxRegionDescription = value;
                this.OnTaxRegionDescriptionChanged();
                this.OnPropertyChanged("TaxRegionDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxRegionDescription;
        partial void OnTaxRegionDescriptionChanging(string value);
        partial void OnTaxRegionDescriptionChanged();
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
        /// There are no comments for Property BenefitOptionIDComp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitOptionIDComp")]
        public virtual string BenefitOptionIDComp
        {
            get
            {
                return this._BenefitOptionIDComp;
            }
            set
            {
                this.OnBenefitOptionIDCompChanging(value);
                this._BenefitOptionIDComp = value;
                this.OnBenefitOptionIDCompChanged();
                this.OnPropertyChanged("BenefitOptionIDComp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitOptionIDComp;
        partial void OnBenefitOptionIDCompChanging(string value);
        partial void OnBenefitOptionIDCompChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
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
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodStartDate is required.")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property EarningRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EarningRate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EarningRate is required.")]
        public virtual decimal EarningRate
        {
            get
            {
                return this._EarningRate;
            }
            set
            {
                this.OnEarningRateChanging(value);
                this._EarningRate = value;
                this.OnEarningRateChanged();
                this.OnPropertyChanged("EarningRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EarningRate;
        partial void OnEarningRateChanging(decimal value);
        partial void OnEarningRateChanged();
        /// <summary>
        /// There are no comments for Property GeneralLiabilityInsurance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralLiabilityInsurance")]
        public virtual string GeneralLiabilityInsurance
        {
            get
            {
                return this._GeneralLiabilityInsurance;
            }
            set
            {
                this.OnGeneralLiabilityInsuranceChanging(value);
                this._GeneralLiabilityInsurance = value;
                this.OnGeneralLiabilityInsuranceChanged();
                this.OnPropertyChanged("GeneralLiabilityInsurance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GeneralLiabilityInsurance;
        partial void OnGeneralLiabilityInsuranceChanging(string value);
        partial void OnGeneralLiabilityInsuranceChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlanIDComp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlanIDComp")]
        public virtual string BenefitPlanIDComp
        {
            get
            {
                return this._BenefitPlanIDComp;
            }
            set
            {
                this.OnBenefitPlanIDCompChanging(value);
                this._BenefitPlanIDComp = value;
                this.OnBenefitPlanIDCompChanged();
                this.OnPropertyChanged("BenefitPlanIDComp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanIDComp;
        partial void OnBenefitPlanIDCompChanging(string value);
        partial void OnBenefitPlanIDCompChanged();
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
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
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
