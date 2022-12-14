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
    /// There are no comments for BenefitsEligibilityRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRuleSingle")]
    public partial class BenefitsEligibilityRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsEligibilityRule>
    {
        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleSingle object.
        /// </summary>
        public BenefitsEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleSingle object.
        /// </summary>
        public BenefitsEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleSingle object.
        /// </summary>
        public BenefitsEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsEligibilityRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitsPlanEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEligibilityRule")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule> BenefitsPlanEligibilityRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPlanEligibilityRule == null))
                {
                    this._BenefitsPlanEligibilityRule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule>(GetPath("BenefitsPlanEligibilityRule"));
                }
                return this._BenefitsPlanEligibilityRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule> _BenefitsPlanEligibilityRule;
        /// <summary>
        /// There are no comments for BenefitsProgramEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsProgramEligibilityRule")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule> BenefitsProgramEligibilityRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsProgramEligibilityRule == null))
                {
                    this._BenefitsProgramEligibilityRule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule>(GetPath("BenefitsProgramEligibilityRule"));
                }
                return this._BenefitsProgramEligibilityRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule> _BenefitsProgramEligibilityRule;
    }
    /// <summary>
    /// There are no comments for BenefitsEligibilityRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EligibilityRuleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EligibilityRuleId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsEligibilityRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRule")]
    public partial class BenefitsEligibilityRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsEligibilityRule object.
        /// </summary>
        /// <param name="eligibilityRuleId">Initial value of EligibilityRuleId.</param>
        /// <param name="newHireEnrollmentPeriod">Initial value of NewHireEnrollmentPeriod.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="formerEmploymentStatusFromDays">Initial value of FormerEmploymentStatusFromDays.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="formerEmploymentStatusToDays">Initial value of FormerEmploymentStatusToDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsEligibilityRule CreateBenefitsEligibilityRule(string eligibilityRuleId, 
                    int newHireEnrollmentPeriod, 
                    global::System.DateTimeOffset validFrom, 
                    int formerEmploymentStatusFromDays, 
                    global::System.DateTimeOffset validTo, 
                    int formerEmploymentStatusToDays)
        {
            BenefitsEligibilityRule benefitsEligibilityRule = new BenefitsEligibilityRule();
            benefitsEligibilityRule.EligibilityRuleId = eligibilityRuleId;
            benefitsEligibilityRule.NewHireEnrollmentPeriod = newHireEnrollmentPeriod;
            benefitsEligibilityRule.ValidFrom = validFrom;
            benefitsEligibilityRule.FormerEmploymentStatusFromDays = formerEmploymentStatusFromDays;
            benefitsEligibilityRule.ValidTo = validTo;
            benefitsEligibilityRule.FormerEmploymentStatusToDays = formerEmploymentStatusToDays;
            return benefitsEligibilityRule;
        }
        /// <summary>
        /// There are no comments for Property EligibilityRuleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EligibilityRuleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EligibilityRuleId is required.")]
        public virtual string EligibilityRuleId
        {
            get
            {
                return this._EligibilityRuleId;
            }
            set
            {
                this.OnEligibilityRuleIdChanging(value);
                this._EligibilityRuleId = value;
                this.OnEligibilityRuleIdChanged();
                this.OnPropertyChanged("EligibilityRuleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EligibilityRuleId;
        partial void OnEligibilityRuleIdChanging(string value);
        partial void OnEligibilityRuleIdChanged();
        /// <summary>
        /// There are no comments for Property UseFormerEmploymentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseFormerEmploymentStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseFormerEmploymentStatus
        {
            get
            {
                return this._UseFormerEmploymentStatus;
            }
            set
            {
                this.OnUseFormerEmploymentStatusChanging(value);
                this._UseFormerEmploymentStatus = value;
                this.OnUseFormerEmploymentStatusChanged();
                this.OnPropertyChanged("UseFormerEmploymentStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseFormerEmploymentStatus;
        partial void OnUseFormerEmploymentStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseFormerEmploymentStatusChanged();
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
        /// There are no comments for Property EmployeeStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitCurrentEmploymentStatus> EmployeeStatus
        {
            get
            {
                return this._EmployeeStatus;
            }
            set
            {
                this.OnEmployeeStatusChanging(value);
                this._EmployeeStatus = value;
                this.OnEmployeeStatusChanged();
                this.OnPropertyChanged("EmployeeStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitCurrentEmploymentStatus> _EmployeeStatus;
        partial void OnEmployeeStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitCurrentEmploymentStatus> value);
        partial void OnEmployeeStatusChanged();
        /// <summary>
        /// There are no comments for Property NewHireEnrollmentPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NewHireEnrollmentPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NewHireEnrollmentPeriod is required.")]
        public virtual int NewHireEnrollmentPeriod
        {
            get
            {
                return this._NewHireEnrollmentPeriod;
            }
            set
            {
                this.OnNewHireEnrollmentPeriodChanging(value);
                this._NewHireEnrollmentPeriod = value;
                this.OnNewHireEnrollmentPeriodChanged();
                this.OnPropertyChanged("NewHireEnrollmentPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NewHireEnrollmentPeriod;
        partial void OnNewHireEnrollmentPeriodChanging(int value);
        partial void OnNewHireEnrollmentPeriodChanged();
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
        /// There are no comments for Property UseEmployeeStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseEmployeeStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseEmployeeStatus
        {
            get
            {
                return this._UseEmployeeStatus;
            }
            set
            {
                this.OnUseEmployeeStatusChanging(value);
                this._UseEmployeeStatus = value;
                this.OnUseEmployeeStatusChanged();
                this.OnPropertyChanged("UseEmployeeStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseEmployeeStatus;
        partial void OnUseEmployeeStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseEmployeeStatusChanged();
        /// <summary>
        /// There are no comments for Property EmploymentCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentCategory")]
        public virtual string EmploymentCategory
        {
            get
            {
                return this._EmploymentCategory;
            }
            set
            {
                this.OnEmploymentCategoryChanging(value);
                this._EmploymentCategory = value;
                this.OnEmploymentCategoryChanged();
                this.OnPropertyChanged("EmploymentCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmploymentCategory;
        partial void OnEmploymentCategoryChanging(string value);
        partial void OnEmploymentCategoryChanged();
        /// <summary>
        /// There are no comments for Property FormerEmploymentStatusFromDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormerEmploymentStatusFromDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FormerEmploymentStatusFromDays is required.")]
        public virtual int FormerEmploymentStatusFromDays
        {
            get
            {
                return this._FormerEmploymentStatusFromDays;
            }
            set
            {
                this.OnFormerEmploymentStatusFromDaysChanging(value);
                this._FormerEmploymentStatusFromDays = value;
                this.OnFormerEmploymentStatusFromDaysChanged();
                this.OnPropertyChanged("FormerEmploymentStatusFromDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FormerEmploymentStatusFromDays;
        partial void OnFormerEmploymentStatusFromDaysChanging(int value);
        partial void OnFormerEmploymentStatusFromDaysChanged();
        /// <summary>
        /// There are no comments for Property FormerEmploymentStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormerEmploymentStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmploymentStatus> FormerEmploymentStatus
        {
            get
            {
                return this._FormerEmploymentStatus;
            }
            set
            {
                this.OnFormerEmploymentStatusChanging(value);
                this._FormerEmploymentStatus = value;
                this.OnFormerEmploymentStatusChanged();
                this.OnPropertyChanged("FormerEmploymentStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmploymentStatus> _FormerEmploymentStatus;
        partial void OnFormerEmploymentStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmploymentStatus> value);
        partial void OnFormerEmploymentStatusChanged();
        /// <summary>
        /// There are no comments for Property UseEmployeeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseEmployeeType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseEmployeeType
        {
            get
            {
                return this._UseEmployeeType;
            }
            set
            {
                this.OnUseEmployeeTypeChanging(value);
                this._UseEmployeeType = value;
                this.OnUseEmployeeTypeChanged();
                this.OnPropertyChanged("UseEmployeeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseEmployeeType;
        partial void OnUseEmployeeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseEmployeeTypeChanged();
        /// <summary>
        /// There are no comments for Property UseEmployeeCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseEmployeeCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseEmployeeCategory
        {
            get
            {
                return this._UseEmployeeCategory;
            }
            set
            {
                this.OnUseEmployeeCategoryChanging(value);
                this._UseEmployeeCategory = value;
                this.OnUseEmployeeCategoryChanged();
                this.OnPropertyChanged("UseEmployeeCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseEmployeeCategory;
        partial void OnUseEmployeeCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseEmployeeCategoryChanged();
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
        /// There are no comments for Property UseNewHireRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseNewHireRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseNewHireRule
        {
            get
            {
                return this._UseNewHireRule;
            }
            set
            {
                this.OnUseNewHireRuleChanging(value);
                this._UseNewHireRule = value;
                this.OnUseNewHireRuleChanged();
                this.OnPropertyChanged("UseNewHireRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseNewHireRule;
        partial void OnUseNewHireRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseNewHireRuleChanged();
        /// <summary>
        /// There are no comments for Property FormerEmploymentStatusToDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormerEmploymentStatusToDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FormerEmploymentStatusToDays is required.")]
        public virtual int FormerEmploymentStatusToDays
        {
            get
            {
                return this._FormerEmploymentStatusToDays;
            }
            set
            {
                this.OnFormerEmploymentStatusToDaysChanging(value);
                this._FormerEmploymentStatusToDays = value;
                this.OnFormerEmploymentStatusToDaysChanged();
                this.OnPropertyChanged("FormerEmploymentStatusToDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FormerEmploymentStatusToDays;
        partial void OnFormerEmploymentStatusToDaysChanging(int value);
        partial void OnFormerEmploymentStatusToDaysChanged();
        /// <summary>
        /// There are no comments for Property WorkerType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> WorkerType
        {
            get
            {
                return this._WorkerType;
            }
            set
            {
                this.OnWorkerTypeChanging(value);
                this._WorkerType = value;
                this.OnWorkerTypeChanged();
                this.OnPropertyChanged("WorkerType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> _WorkerType;
        partial void OnWorkerTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> value);
        partial void OnWorkerTypeChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPlanEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEligibilityRule")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule> BenefitsPlanEligibilityRule
        {
            get
            {
                return this._BenefitsPlanEligibilityRule;
            }
            set
            {
                this.OnBenefitsPlanEligibilityRuleChanging(value);
                this._BenefitsPlanEligibilityRule = value;
                this.OnBenefitsPlanEligibilityRuleChanged();
                this.OnPropertyChanged("BenefitsPlanEligibilityRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule> _BenefitsPlanEligibilityRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsPlanEligibilityRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPlanEligibilityRule> value);
        partial void OnBenefitsPlanEligibilityRuleChanged();
        /// <summary>
        /// There are no comments for Property BenefitsProgramEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsProgramEligibilityRule")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule> BenefitsProgramEligibilityRule
        {
            get
            {
                return this._BenefitsProgramEligibilityRule;
            }
            set
            {
                this.OnBenefitsProgramEligibilityRuleChanging(value);
                this._BenefitsProgramEligibilityRule = value;
                this.OnBenefitsProgramEligibilityRuleChanged();
                this.OnPropertyChanged("BenefitsProgramEligibilityRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule> _BenefitsProgramEligibilityRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsProgramEligibilityRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsProgramEligibilityRule> value);
        partial void OnBenefitsProgramEligibilityRuleChanged();
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
