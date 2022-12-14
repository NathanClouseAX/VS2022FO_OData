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
    /// There are no comments for WorkerEnrolledBenefitInquirySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefitInquirySingle")]
    public partial class WorkerEnrolledBenefitInquirySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitInquiry>
    {
        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitInquirySingle object.
        /// </summary>
        public WorkerEnrolledBenefitInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitInquirySingle object.
        /// </summary>
        public WorkerEnrolledBenefitInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledBenefitInquirySingle object.
        /// </summary>
        public WorkerEnrolledBenefitInquirySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledBenefitInquiry> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefit")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle Benefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefit == null))
                {
                    this._Benefit = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("Benefit"));
                }
                return this._Benefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _Benefit;
    }
    /// <summary>
    /// There are no comments for WorkerEnrolledBenefitInquiry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("WorkerEnrolledBenefitInquiries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefitInquiry")]
    public partial class WorkerEnrolledBenefitInquiry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerEnrolledBenefitInquiry object.
        /// </summary>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="contributionAmountCur">Initial value of ContributionAmountCur.</param>
        /// <param name="deductionAmountCur">Initial value of DeductionAmountCur.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerEnrolledBenefitInquiry CreateWorkerEnrolledBenefitInquiry(global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    decimal contributionAmountCur, 
                    decimal deductionAmountCur, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.Benefit benefit)
        {
            WorkerEnrolledBenefitInquiry workerEnrolledBenefitInquiry = new WorkerEnrolledBenefitInquiry();
            workerEnrolledBenefitInquiry.ValidFrom = validFrom;
            workerEnrolledBenefitInquiry.ValidTo = validTo;
            workerEnrolledBenefitInquiry.ContributionAmountCur = contributionAmountCur;
            workerEnrolledBenefitInquiry.DeductionAmountCur = deductionAmountCur;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerEnrolledBenefitInquiry.Worker = worker;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            workerEnrolledBenefitInquiry.Benefit = benefit;
            return workerEnrolledBenefitInquiry;
        }
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
        /// There are no comments for Property PayrollCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> PayrollCategory
        {
            get
            {
                return this._PayrollCategory;
            }
            set
            {
                this.OnPayrollCategoryChanging(value);
                this._PayrollCategory = value;
                this.OnPayrollCategoryChanged();
                this.OnPropertyChanged("PayrollCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> _PayrollCategory;
        partial void OnPayrollCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> value);
        partial void OnPayrollCategoryChanged();
        /// <summary>
        /// There are no comments for Property ContributionRateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionRateSource")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> ContributionRateSource
        {
            get
            {
                return this._ContributionRateSource;
            }
            set
            {
                this.OnContributionRateSourceChanging(value);
                this._ContributionRateSource = value;
                this.OnContributionRateSourceChanged();
                this.OnPropertyChanged("ContributionRateSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> _ContributionRateSource;
        partial void OnContributionRateSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> value);
        partial void OnContributionRateSourceChanged();
        /// <summary>
        /// There are no comments for Property ContributionAmountCur in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionAmountCur")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContributionAmountCur is required.")]
        public virtual decimal ContributionAmountCur
        {
            get
            {
                return this._ContributionAmountCur;
            }
            set
            {
                this.OnContributionAmountCurChanging(value);
                this._ContributionAmountCur = value;
                this.OnContributionAmountCurChanged();
                this.OnPropertyChanged("ContributionAmountCur");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ContributionAmountCur;
        partial void OnContributionAmountCurChanging(decimal value);
        partial void OnContributionAmountCurChanged();
        /// <summary>
        /// There are no comments for Property DeductionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> DeductionBasis
        {
            get
            {
                return this._DeductionBasis;
            }
            set
            {
                this.OnDeductionBasisChanging(value);
                this._DeductionBasis = value;
                this.OnDeductionBasisChanged();
                this.OnPropertyChanged("DeductionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> _DeductionBasis;
        partial void OnDeductionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> value);
        partial void OnDeductionBasisChanged();
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
        /// There are no comments for Property BenefitTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitTypeId")]
        public virtual string BenefitTypeId
        {
            get
            {
                return this._BenefitTypeId;
            }
            set
            {
                this.OnBenefitTypeIdChanging(value);
                this._BenefitTypeId = value;
                this.OnBenefitTypeIdChanged();
                this.OnPropertyChanged("BenefitTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitTypeId;
        partial void OnBenefitTypeIdChanging(string value);
        partial void OnBenefitTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ContributionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> ContributionBasis
        {
            get
            {
                return this._ContributionBasis;
            }
            set
            {
                this.OnContributionBasisChanging(value);
                this._ContributionBasis = value;
                this.OnContributionBasisChanged();
                this.OnPropertyChanged("ContributionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> _ContributionBasis;
        partial void OnContributionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> value);
        partial void OnContributionBasisChanged();
        /// <summary>
        /// There are no comments for Property DeductionAmountCur in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionAmountCur")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeductionAmountCur is required.")]
        public virtual decimal DeductionAmountCur
        {
            get
            {
                return this._DeductionAmountCur;
            }
            set
            {
                this.OnDeductionAmountCurChanging(value);
                this._DeductionAmountCur = value;
                this.OnDeductionAmountCurChanged();
                this.OnPropertyChanged("DeductionAmountCur");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeductionAmountCur;
        partial void OnDeductionAmountCurChanging(decimal value);
        partial void OnDeductionAmountCurChanged();
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitId")]
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
        /// There are no comments for Property DeductionRateSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionRateSource")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> DeductionRateSource
        {
            get
            {
                return this._DeductionRateSource;
            }
            set
            {
                this.OnDeductionRateSourceChanging(value);
                this._DeductionRateSource = value;
                this.OnDeductionRateSourceChanged();
                this.OnPropertyChanged("DeductionRateSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> _DeductionRateSource;
        partial void OnDeductionRateSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollBenefitRateSource> value);
        partial void OnDeductionRateSourceChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlanAndOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlanAndOption")]
        public virtual string BenefitPlanAndOption
        {
            get
            {
                return this._BenefitPlanAndOption;
            }
            set
            {
                this.OnBenefitPlanAndOptionChanging(value);
                this._BenefitPlanAndOption = value;
                this.OnBenefitPlanAndOptionChanged();
                this.OnPropertyChanged("BenefitPlanAndOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanAndOption;
        partial void OnBenefitPlanAndOptionChanging(string value);
        partial void OnBenefitPlanAndOptionChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Worker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
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
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Benefit is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit Benefit
        {
            get
            {
                return this._Benefit;
            }
            set
            {
                this.OnBenefitChanging(value);
                this._Benefit = value;
                this.OnBenefitChanged();
                this.OnPropertyChanged("Benefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _Benefit;
        partial void OnBenefitChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnBenefitChanged();
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
