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
    /// There are no comments for PayrollWorkerBenefitPlanSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerBenefitPlanSingle")]
    public partial class PayrollWorkerBenefitPlanSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollWorkerBenefitPlan>
    {
        /// <summary>
        /// Initialize a new PayrollWorkerBenefitPlanSingle object.
        /// </summary>
        public PayrollWorkerBenefitPlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollWorkerBenefitPlanSingle object.
        /// </summary>
        public PayrollWorkerBenefitPlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollWorkerBenefitPlanSingle object.
        /// </summary>
        public PayrollWorkerBenefitPlanSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollWorkerBenefitPlan> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle BaseWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseWorker == null))
                {
                    this._BaseWorker = new global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle(this.Context, GetPath("BaseWorker"));
                }
                return this._BaseWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle _BaseWorker;
        /// <summary>
        /// There are no comments for BenefitsPlanType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanType")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPlanTypeSingle BenefitsPlanType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPlanType == null))
                {
                    this._BenefitsPlanType = new global::Microsoft.Dynamics.DataEntities.BenefitsPlanTypeSingle(this.Context, GetPath("BenefitsPlanType"));
                }
                return this._BenefitsPlanType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPlanTypeSingle _BenefitsPlanType;
        /// <summary>
        /// There are no comments for BenefitsPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlan")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPlanSingle BenefitsPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPlan == null))
                {
                    this._BenefitsPlan = new global::Microsoft.Dynamics.DataEntities.BenefitsPlanSingle(this.Context, GetPath("BenefitsPlan"));
                }
                return this._BenefitsPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPlanSingle _BenefitsPlan;
        /// <summary>
        /// There are no comments for BenefitsCoverageOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCoverageOption")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOptionSingle BenefitsCoverageOption
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsCoverageOption == null))
                {
                    this._BenefitsCoverageOption = new global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOptionSingle(this.Context, GetPath("BenefitsCoverageOption"));
                }
                return this._BenefitsCoverageOption;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOptionSingle _BenefitsCoverageOption;
        /// <summary>
        /// There are no comments for BenefitsPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPeriodSingle BenefitsPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPeriod == null))
                {
                    this._BenefitsPeriod = new global::Microsoft.Dynamics.DataEntities.BenefitsPeriodSingle(this.Context, GetPath("BenefitsPeriod"));
                }
                return this._BenefitsPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPeriodSingle _BenefitsPeriod;
    }
    /// <summary>
    /// There are no comments for PayrollWorkerBenefitPlan in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LegalEntityId
    /// PeriodId
    /// PlanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LegalEntityId", "PeriodId", "PlanId")]
    [global::Microsoft.OData.Client.EntitySet("PayrollWorkerBenefitPlans")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerBenefitPlan")]
    public partial class PayrollWorkerBenefitPlan : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollWorkerBenefitPlan object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="periodId">Initial value of PeriodId.</param>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="deductionStartDateTime">Initial value of DeductionStartDateTime.</param>
        /// <param name="deductionEndDateTime">Initial value of DeductionEndDateTime.</param>
        /// <param name="amountEmployee">Initial value of AmountEmployee.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="payPeriod">Initial value of PayPeriod.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="amountEmployer">Initial value of AmountEmployer.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollWorkerBenefitPlan CreatePayrollWorkerBenefitPlan(string personnelNumber, 
                    string legalEntityId, 
                    string periodId, 
                    string planId, 
                    global::System.DateTimeOffset deductionStartDateTime, 
                    global::System.DateTimeOffset deductionEndDateTime, 
                    decimal amountEmployee, 
                    global::System.DateTimeOffset validFrom, 
                    int payPeriod, 
                    global::System.DateTimeOffset validTo, 
                    decimal amountEmployer)
        {
            PayrollWorkerBenefitPlan payrollWorkerBenefitPlan = new PayrollWorkerBenefitPlan();
            payrollWorkerBenefitPlan.PersonnelNumber = personnelNumber;
            payrollWorkerBenefitPlan.LegalEntityId = legalEntityId;
            payrollWorkerBenefitPlan.PeriodId = periodId;
            payrollWorkerBenefitPlan.PlanId = planId;
            payrollWorkerBenefitPlan.DeductionStartDateTime = deductionStartDateTime;
            payrollWorkerBenefitPlan.DeductionEndDateTime = deductionEndDateTime;
            payrollWorkerBenefitPlan.AmountEmployee = amountEmployee;
            payrollWorkerBenefitPlan.ValidFrom = validFrom;
            payrollWorkerBenefitPlan.PayPeriod = payPeriod;
            payrollWorkerBenefitPlan.ValidTo = validTo;
            payrollWorkerBenefitPlan.AmountEmployer = amountEmployer;
            return payrollWorkerBenefitPlan;
        }
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodId is required.")]
        public virtual string PeriodId
        {
            get
            {
                return this._PeriodId;
            }
            set
            {
                this.OnPeriodIdChanging(value);
                this._PeriodId = value;
                this.OnPeriodIdChanged();
                this.OnPropertyChanged("PeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodId;
        partial void OnPeriodIdChanging(string value);
        partial void OnPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property PlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanId is required.")]
        public virtual string PlanId
        {
            get
            {
                return this._PlanId;
            }
            set
            {
                this.OnPlanIdChanging(value);
                this._PlanId = value;
                this.OnPlanIdChanged();
                this.OnPropertyChanged("PlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanId;
        partial void OnPlanIdChanging(string value);
        partial void OnPlanIdChanged();
        /// <summary>
        /// There are no comments for Property PlanTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanTypeId")]
        public virtual string PlanTypeId
        {
            get
            {
                return this._PlanTypeId;
            }
            set
            {
                this.OnPlanTypeIdChanging(value);
                this._PlanTypeId = value;
                this.OnPlanTypeIdChanged();
                this.OnPropertyChanged("PlanTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanTypeId;
        partial void OnPlanTypeIdChanging(string value);
        partial void OnPlanTypeIdChanged();
        /// <summary>
        /// There are no comments for Property DeductionStartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionStartDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionStartDateTime is required.")]
        public virtual global::System.DateTimeOffset DeductionStartDateTime
        {
            get
            {
                return this._DeductionStartDateTime;
            }
            set
            {
                this.OnDeductionStartDateTimeChanging(value);
                this._DeductionStartDateTime = value;
                this.OnDeductionStartDateTimeChanged();
                this.OnPropertyChanged("DeductionStartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeductionStartDateTime;
        partial void OnDeductionStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnDeductionStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property PlanTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanTypeCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPlanTypeCode> PlanTypeCode
        {
            get
            {
                return this._PlanTypeCode;
            }
            set
            {
                this.OnPlanTypeCodeChanging(value);
                this._PlanTypeCode = value;
                this.OnPlanTypeCodeChanged();
                this.OnPropertyChanged("PlanTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPlanTypeCode> _PlanTypeCode;
        partial void OnPlanTypeCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPlanTypeCode> value);
        partial void OnPlanTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property DeductionEndDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionEndDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionEndDateTime is required.")]
        public virtual global::System.DateTimeOffset DeductionEndDateTime
        {
            get
            {
                return this._DeductionEndDateTime;
            }
            set
            {
                this.OnDeductionEndDateTimeChanging(value);
                this._DeductionEndDateTime = value;
                this.OnDeductionEndDateTimeChanged();
                this.OnPropertyChanged("DeductionEndDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeductionEndDateTime;
        partial void OnDeductionEndDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnDeductionEndDateTimeChanged();
        /// <summary>
        /// There are no comments for Property AmountEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountEmployee")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountEmployee is required.")]
        public virtual decimal AmountEmployee
        {
            get
            {
                return this._AmountEmployee;
            }
            set
            {
                this.OnAmountEmployeeChanging(value);
                this._AmountEmployee = value;
                this.OnAmountEmployeeChanged();
                this.OnPropertyChanged("AmountEmployee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountEmployee;
        partial void OnAmountEmployeeChanging(decimal value);
        partial void OnAmountEmployeeChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property PayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayPeriod is required.")]
        public virtual int PayPeriod
        {
            get
            {
                return this._PayPeriod;
            }
            set
            {
                this.OnPayPeriodChanging(value);
                this._PayPeriod = value;
                this.OnPayPeriodChanged();
                this.OnPropertyChanged("PayPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PayPeriod;
        partial void OnPayPeriodChanging(int value);
        partial void OnPayPeriodChanged();
        /// <summary>
        /// There are no comments for Property CoverageOptionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CoverageOptionId")]
        public virtual string CoverageOptionId
        {
            get
            {
                return this._CoverageOptionId;
            }
            set
            {
                this.OnCoverageOptionIdChanging(value);
                this._CoverageOptionId = value;
                this.OnCoverageOptionIdChanged();
                this.OnPropertyChanged("CoverageOptionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CoverageOptionId;
        partial void OnCoverageOptionIdChanging(string value);
        partial void OnCoverageOptionIdChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property AmountEmployer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountEmployer")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountEmployer is required.")]
        public virtual decimal AmountEmployer
        {
            get
            {
                return this._AmountEmployer;
            }
            set
            {
                this.OnAmountEmployerChanging(value);
                this._AmountEmployer = value;
                this.OnAmountEmployerChanged();
                this.OnPropertyChanged("AmountEmployer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountEmployer;
        partial void OnAmountEmployerChanging(decimal value);
        partial void OnAmountEmployerChanged();
        /// <summary>
        /// There are no comments for Property BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorker BaseWorker
        {
            get
            {
                return this._BaseWorker;
            }
            set
            {
                this.OnBaseWorkerChanging(value);
                this._BaseWorker = value;
                this.OnBaseWorkerChanged();
                this.OnPropertyChanged("BaseWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorker _BaseWorker;
        partial void OnBaseWorkerChanging(global::Microsoft.Dynamics.DataEntities.BaseWorker value);
        partial void OnBaseWorkerChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPlanType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanType")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPlanType BenefitsPlanType
        {
            get
            {
                return this._BenefitsPlanType;
            }
            set
            {
                this.OnBenefitsPlanTypeChanging(value);
                this._BenefitsPlanType = value;
                this.OnBenefitsPlanTypeChanged();
                this.OnPropertyChanged("BenefitsPlanType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPlanType _BenefitsPlanType;
        partial void OnBenefitsPlanTypeChanging(global::Microsoft.Dynamics.DataEntities.BenefitsPlanType value);
        partial void OnBenefitsPlanTypeChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlan")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPlan BenefitsPlan
        {
            get
            {
                return this._BenefitsPlan;
            }
            set
            {
                this.OnBenefitsPlanChanging(value);
                this._BenefitsPlan = value;
                this.OnBenefitsPlanChanged();
                this.OnPropertyChanged("BenefitsPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPlan _BenefitsPlan;
        partial void OnBenefitsPlanChanging(global::Microsoft.Dynamics.DataEntities.BenefitsPlan value);
        partial void OnBenefitsPlanChanged();
        /// <summary>
        /// There are no comments for Property BenefitsCoverageOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCoverageOption")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOption BenefitsCoverageOption
        {
            get
            {
                return this._BenefitsCoverageOption;
            }
            set
            {
                this.OnBenefitsCoverageOptionChanging(value);
                this._BenefitsCoverageOption = value;
                this.OnBenefitsCoverageOptionChanged();
                this.OnPropertyChanged("BenefitsCoverageOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOption _BenefitsCoverageOption;
        partial void OnBenefitsCoverageOptionChanging(global::Microsoft.Dynamics.DataEntities.BenefitsCoverageOption value);
        partial void OnBenefitsCoverageOptionChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsPeriod BenefitsPeriod
        {
            get
            {
                return this._BenefitsPeriod;
            }
            set
            {
                this.OnBenefitsPeriodChanging(value);
                this._BenefitsPeriod = value;
                this.OnBenefitsPeriodChanged();
                this.OnPropertyChanged("BenefitsPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsPeriod _BenefitsPeriod;
        partial void OnBenefitsPeriodChanging(global::Microsoft.Dynamics.DataEntities.BenefitsPeriod value);
        partial void OnBenefitsPeriodChanged();
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