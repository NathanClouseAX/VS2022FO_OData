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
    /// There are no comments for BenefitsPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriodSingle")]
    public partial class BenefitsPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPeriod>
    {
        /// <summary>
        /// Initialize a new BenefitsPeriodSingle object.
        /// </summary>
        public BenefitsPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsPeriodSingle object.
        /// </summary>
        public BenefitsPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsPeriodSingle object.
        /// </summary>
        public BenefitsPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollWorkerBenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerBenefitPlan")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlanSingle PayrollWorkerBenefitPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollWorkerBenefitPlan == null))
                {
                    this._PayrollWorkerBenefitPlan = new global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlanSingle(this.Context, GetPath("PayrollWorkerBenefitPlan"));
                }
                return this._PayrollWorkerBenefitPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlanSingle _PayrollWorkerBenefitPlan;
        /// <summary>
        /// There are no comments for BenefitsPeriodEmployeeLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriodEmployeeLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> BenefitsPeriodEmployeeLifeEventTransaction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPeriodEmployeeLifeEventTransaction == null))
                {
                    this._BenefitsPeriodEmployeeLifeEventTransaction = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction>(GetPath("BenefitsPeriodEmployeeLifeEventTransaction"));
                }
                return this._BenefitsPeriodEmployeeLifeEventTransaction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> _BenefitsPeriodEmployeeLifeEventTransaction;
    }
    /// <summary>
    /// There are no comments for BenefitsPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PeriodId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PeriodId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriod")]
    public partial class BenefitsPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsPeriod object.
        /// </summary>
        /// <param name="periodId">Initial value of PeriodId.</param>
        /// <param name="enrollStartDateTime">Initial value of EnrollStartDateTime.</param>
        /// <param name="enrollStartDate">Initial value of EnrollStartDate.</param>
        /// <param name="enrollEndDateTime">Initial value of EnrollEndDateTime.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="enrollEndDate">Initial value of EnrollEndDate.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="payrollWorkerBenefitPlan">Initial value of PayrollWorkerBenefitPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsPeriod CreateBenefitsPeriod(string periodId, 
                    global::System.DateTimeOffset enrollStartDateTime, 
                    global::System.DateTimeOffset enrollStartDate, 
                    global::System.DateTimeOffset enrollEndDateTime, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset enrollEndDate, 
                    global::System.DateTimeOffset validFrom, 
                    global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlan payrollWorkerBenefitPlan)
        {
            BenefitsPeriod benefitsPeriod = new BenefitsPeriod();
            benefitsPeriod.PeriodId = periodId;
            benefitsPeriod.EnrollStartDateTime = enrollStartDateTime;
            benefitsPeriod.EnrollStartDate = enrollStartDate;
            benefitsPeriod.EnrollEndDateTime = enrollEndDateTime;
            benefitsPeriod.ValidTo = validTo;
            benefitsPeriod.EnrollEndDate = enrollEndDate;
            benefitsPeriod.ValidFrom = validFrom;
            if ((payrollWorkerBenefitPlan == null))
            {
                throw new global::System.ArgumentNullException("payrollWorkerBenefitPlan");
            }
            benefitsPeriod.PayrollWorkerBenefitPlan = payrollWorkerBenefitPlan;
            return benefitsPeriod;
        }
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
        /// There are no comments for Property EnrollStartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollStartDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollStartDateTime is required.")]
        public virtual global::System.DateTimeOffset EnrollStartDateTime
        {
            get
            {
                return this._EnrollStartDateTime;
            }
            set
            {
                this.OnEnrollStartDateTimeChanging(value);
                this._EnrollStartDateTime = value;
                this.OnEnrollStartDateTimeChanged();
                this.OnPropertyChanged("EnrollStartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollStartDateTime;
        partial void OnEnrollStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnEnrollStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property EnrollStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollStartDate is required.")]
        public virtual global::System.DateTimeOffset EnrollStartDate
        {
            get
            {
                return this._EnrollStartDate;
            }
            set
            {
                this.OnEnrollStartDateChanging(value);
                this._EnrollStartDate = value;
                this.OnEnrollStartDateChanged();
                this.OnPropertyChanged("EnrollStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollStartDate;
        partial void OnEnrollStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEnrollStartDateChanged();
        /// <summary>
        /// There are no comments for Property PreviousPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreviousPeriodId")]
        public virtual string PreviousPeriodId
        {
            get
            {
                return this._PreviousPeriodId;
            }
            set
            {
                this.OnPreviousPeriodIdChanging(value);
                this._PreviousPeriodId = value;
                this.OnPreviousPeriodIdChanged();
                this.OnPropertyChanged("PreviousPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PreviousPeriodId;
        partial void OnPreviousPeriodIdChanging(string value);
        partial void OnPreviousPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property EnrollEndDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollEndDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollEndDateTime is required.")]
        public virtual global::System.DateTimeOffset EnrollEndDateTime
        {
            get
            {
                return this._EnrollEndDateTime;
            }
            set
            {
                this.OnEnrollEndDateTimeChanging(value);
                this._EnrollEndDateTime = value;
                this.OnEnrollEndDateTimeChanged();
                this.OnPropertyChanged("EnrollEndDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollEndDateTime;
        partial void OnEnrollEndDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnEnrollEndDateTimeChanged();
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
        /// There are no comments for Property EnrollEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollEndDate is required.")]
        public virtual global::System.DateTimeOffset EnrollEndDate
        {
            get
            {
                return this._EnrollEndDate;
            }
            set
            {
                this.OnEnrollEndDateChanging(value);
                this._EnrollEndDate = value;
                this.OnEnrollEndDateChanged();
                this.OnPropertyChanged("EnrollEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollEndDate;
        partial void OnEnrollEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEnrollEndDateChanged();
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
        /// There are no comments for Property PayrollWorkerBenefitPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerBenefitPlan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayrollWorkerBenefitPlan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlan PayrollWorkerBenefitPlan
        {
            get
            {
                return this._PayrollWorkerBenefitPlan;
            }
            set
            {
                this.OnPayrollWorkerBenefitPlanChanging(value);
                this._PayrollWorkerBenefitPlan = value;
                this.OnPayrollWorkerBenefitPlanChanged();
                this.OnPropertyChanged("PayrollWorkerBenefitPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlan _PayrollWorkerBenefitPlan;
        partial void OnPayrollWorkerBenefitPlanChanging(global::Microsoft.Dynamics.DataEntities.PayrollWorkerBenefitPlan value);
        partial void OnPayrollWorkerBenefitPlanChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPeriodEmployeeLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriodEmployeeLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> BenefitsPeriodEmployeeLifeEventTransaction
        {
            get
            {
                return this._BenefitsPeriodEmployeeLifeEventTransaction;
            }
            set
            {
                this.OnBenefitsPeriodEmployeeLifeEventTransactionChanging(value);
                this._BenefitsPeriodEmployeeLifeEventTransaction = value;
                this.OnBenefitsPeriodEmployeeLifeEventTransactionChanged();
                this.OnPropertyChanged("BenefitsPeriodEmployeeLifeEventTransaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> _BenefitsPeriodEmployeeLifeEventTransaction = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsPeriodEmployeeLifeEventTransactionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> value);
        partial void OnBenefitsPeriodEmployeeLifeEventTransactionChanged();
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
