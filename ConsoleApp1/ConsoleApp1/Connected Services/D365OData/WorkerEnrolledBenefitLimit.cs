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
    /// There are no comments for WorkerEnrolledBenefitLimitSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefitLimitSingle")]
    public partial class WorkerEnrolledBenefitLimitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitLimit>
    {
        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitLimitSingle object.
        /// </summary>
        public WorkerEnrolledBenefitLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitLimitSingle object.
        /// </summary>
        public WorkerEnrolledBenefitLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitLimitSingle object.
        /// </summary>
        public WorkerEnrolledBenefitLimitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitLimit> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefit")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle WorkerEnrolledBenefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledBenefit == null))
                {
                    this._WorkerEnrolledBenefit = new global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle(this.Context, GetPath("WorkerEnrolledBenefit"));
                }
                return this._WorkerEnrolledBenefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle _WorkerEnrolledBenefit;
    }
    /// <summary>
    /// There are no comments for WorkerEnrolledBenefitLimit in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// PersonnelNumber
    /// EnrollmentStart
    /// EnrollmentEnd
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "PersonnelNumber", "EnrollmentStart", "EnrollmentEnd")]
    [global::Microsoft.OData.Client.EntitySet("WorkerEnrolledBenefitLimits")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefitLimit")]
    public partial class WorkerEnrolledBenefitLimit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerEnrolledBenefitLimit object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="enrollmentStart">Initial value of EnrollmentStart.</param>
        /// <param name="enrollmentEnd">Initial value of EnrollmentEnd.</param>
        /// <param name="deductionLimitEndDate">Initial value of DeductionLimitEndDate.</param>
        /// <param name="contributionLimitPeriodRemaining">Initial value of ContributionLimitPeriodRemaining.</param>
        /// <param name="deductionLimitPeriodRemaining">Initial value of DeductionLimitPeriodRemaining.</param>
        /// <param name="deductionLimitAmount">Initial value of DeductionLimitAmount.</param>
        /// <param name="contributionLimitAmount">Initial value of ContributionLimitAmount.</param>
        /// <param name="contributionLimitEndDate">Initial value of ContributionLimitEndDate.</param>
        /// <param name="workerEnrolledBenefit">Initial value of WorkerEnrolledBenefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerEnrolledBenefitLimit CreateWorkerEnrolledBenefitLimit(string benefitId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset enrollmentStart, 
                    global::System.DateTimeOffset enrollmentEnd, 
                    global::System.DateTimeOffset deductionLimitEndDate, 
                    decimal contributionLimitPeriodRemaining, 
                    decimal deductionLimitPeriodRemaining, 
                    decimal deductionLimitAmount, 
                    decimal contributionLimitAmount, 
                    global::System.DateTimeOffset contributionLimitEndDate, 
                    global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit workerEnrolledBenefit)
        {
            WorkerEnrolledBenefitLimit workerEnrolledBenefitLimit = new WorkerEnrolledBenefitLimit();
            workerEnrolledBenefitLimit.BenefitId = benefitId;
            workerEnrolledBenefitLimit.PersonnelNumber = personnelNumber;
            workerEnrolledBenefitLimit.EnrollmentStart = enrollmentStart;
            workerEnrolledBenefitLimit.EnrollmentEnd = enrollmentEnd;
            workerEnrolledBenefitLimit.DeductionLimitEndDate = deductionLimitEndDate;
            workerEnrolledBenefitLimit.ContributionLimitPeriodRemaining = contributionLimitPeriodRemaining;
            workerEnrolledBenefitLimit.DeductionLimitPeriodRemaining = deductionLimitPeriodRemaining;
            workerEnrolledBenefitLimit.DeductionLimitAmount = deductionLimitAmount;
            workerEnrolledBenefitLimit.ContributionLimitAmount = contributionLimitAmount;
            workerEnrolledBenefitLimit.ContributionLimitEndDate = contributionLimitEndDate;
            if ((workerEnrolledBenefit == null))
            {
                throw new global::System.ArgumentNullException("workerEnrolledBenefit");
            }
            workerEnrolledBenefitLimit.WorkerEnrolledBenefit = workerEnrolledBenefit;
            return workerEnrolledBenefitLimit;
        }
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitId is required.")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
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
        /// There are no comments for Property EnrollmentStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollmentStart")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollmentStart is required.")]
        public virtual global::System.DateTimeOffset EnrollmentStart
        {
            get
            {
                return this._EnrollmentStart;
            }
            set
            {
                this.OnEnrollmentStartChanging(value);
                this._EnrollmentStart = value;
                this.OnEnrollmentStartChanged();
                this.OnPropertyChanged("EnrollmentStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentStart;
        partial void OnEnrollmentStartChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentStartChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollmentEnd")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollmentEnd is required.")]
        public virtual global::System.DateTimeOffset EnrollmentEnd
        {
            get
            {
                return this._EnrollmentEnd;
            }
            set
            {
                this.OnEnrollmentEndChanging(value);
                this._EnrollmentEnd = value;
                this.OnEnrollmentEndChanged();
                this.OnPropertyChanged("EnrollmentEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentEnd;
        partial void OnEnrollmentEndChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentEndChanged();
        /// <summary>
        /// There are no comments for Property DeductionLimitPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionLimitPeriod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> DeductionLimitPeriod
        {
            get
            {
                return this._DeductionLimitPeriod;
            }
            set
            {
                this.OnDeductionLimitPeriodChanging(value);
                this._DeductionLimitPeriod = value;
                this.OnDeductionLimitPeriodChanged();
                this.OnPropertyChanged("DeductionLimitPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> _DeductionLimitPeriod;
        partial void OnDeductionLimitPeriodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> value);
        partial void OnDeductionLimitPeriodChanged();
        /// <summary>
        /// There are no comments for Property DeductionLimitEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionLimitEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionLimitEndDate is required.")]
        public virtual global::System.DateTimeOffset DeductionLimitEndDate
        {
            get
            {
                return this._DeductionLimitEndDate;
            }
            set
            {
                this.OnDeductionLimitEndDateChanging(value);
                this._DeductionLimitEndDate = value;
                this.OnDeductionLimitEndDateChanged();
                this.OnPropertyChanged("DeductionLimitEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeductionLimitEndDate;
        partial void OnDeductionLimitEndDateChanging(global::System.DateTimeOffset value);
        partial void OnDeductionLimitEndDateChanged();
        /// <summary>
        /// There are no comments for Property ContributionLimitPeriodRemaining in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionLimitPeriodRemaining")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContributionLimitPeriodRemaining is required.")]
        public virtual decimal ContributionLimitPeriodRemaining
        {
            get
            {
                return this._ContributionLimitPeriodRemaining;
            }
            set
            {
                this.OnContributionLimitPeriodRemainingChanging(value);
                this._ContributionLimitPeriodRemaining = value;
                this.OnContributionLimitPeriodRemainingChanged();
                this.OnPropertyChanged("ContributionLimitPeriodRemaining");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ContributionLimitPeriodRemaining;
        partial void OnContributionLimitPeriodRemainingChanging(decimal value);
        partial void OnContributionLimitPeriodRemainingChanged();
        /// <summary>
        /// There are no comments for Property ContributionLimitPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionLimitPeriod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> ContributionLimitPeriod
        {
            get
            {
                return this._ContributionLimitPeriod;
            }
            set
            {
                this.OnContributionLimitPeriodChanging(value);
                this._ContributionLimitPeriod = value;
                this.OnContributionLimitPeriodChanged();
                this.OnPropertyChanged("ContributionLimitPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> _ContributionLimitPeriod;
        partial void OnContributionLimitPeriodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollLimitPeriod> value);
        partial void OnContributionLimitPeriodChanged();
        /// <summary>
        /// There are no comments for Property DeductionLimitPeriodRemaining in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionLimitPeriodRemaining")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionLimitPeriodRemaining is required.")]
        public virtual decimal DeductionLimitPeriodRemaining
        {
            get
            {
                return this._DeductionLimitPeriodRemaining;
            }
            set
            {
                this.OnDeductionLimitPeriodRemainingChanging(value);
                this._DeductionLimitPeriodRemaining = value;
                this.OnDeductionLimitPeriodRemainingChanged();
                this.OnPropertyChanged("DeductionLimitPeriodRemaining");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeductionLimitPeriodRemaining;
        partial void OnDeductionLimitPeriodRemainingChanging(decimal value);
        partial void OnDeductionLimitPeriodRemainingChanged();
        /// <summary>
        /// There are no comments for Property DeductionLimitAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionLimitAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionLimitAmount is required.")]
        public virtual decimal DeductionLimitAmount
        {
            get
            {
                return this._DeductionLimitAmount;
            }
            set
            {
                this.OnDeductionLimitAmountChanging(value);
                this._DeductionLimitAmount = value;
                this.OnDeductionLimitAmountChanged();
                this.OnPropertyChanged("DeductionLimitAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeductionLimitAmount;
        partial void OnDeductionLimitAmountChanging(decimal value);
        partial void OnDeductionLimitAmountChanged();
        /// <summary>
        /// There are no comments for Property ContributionLimitAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionLimitAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContributionLimitAmount is required.")]
        public virtual decimal ContributionLimitAmount
        {
            get
            {
                return this._ContributionLimitAmount;
            }
            set
            {
                this.OnContributionLimitAmountChanging(value);
                this._ContributionLimitAmount = value;
                this.OnContributionLimitAmountChanged();
                this.OnPropertyChanged("ContributionLimitAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ContributionLimitAmount;
        partial void OnContributionLimitAmountChanging(decimal value);
        partial void OnContributionLimitAmountChanged();
        /// <summary>
        /// There are no comments for Property ContributionLimitEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionLimitEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContributionLimitEndDate is required.")]
        public virtual global::System.DateTimeOffset ContributionLimitEndDate
        {
            get
            {
                return this._ContributionLimitEndDate;
            }
            set
            {
                this.OnContributionLimitEndDateChanging(value);
                this._ContributionLimitEndDate = value;
                this.OnContributionLimitEndDateChanged();
                this.OnPropertyChanged("ContributionLimitEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ContributionLimitEndDate;
        partial void OnContributionLimitEndDateChanging(global::System.DateTimeOffset value);
        partial void OnContributionLimitEndDateChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerEnrolledBenefit is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit WorkerEnrolledBenefit
        {
            get
            {
                return this._WorkerEnrolledBenefit;
            }
            set
            {
                this.OnWorkerEnrolledBenefitChanging(value);
                this._WorkerEnrolledBenefit = value;
                this.OnWorkerEnrolledBenefitChanged();
                this.OnPropertyChanged("WorkerEnrolledBenefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit _WorkerEnrolledBenefit;
        partial void OnWorkerEnrolledBenefitChanging(global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit value);
        partial void OnWorkerEnrolledBenefitChanged();
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
