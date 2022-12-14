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
    /// There are no comments for BenefitsPlanEligibilityRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEligibilityRuleSingle")]
    public partial class BenefitsPlanEligibilityRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPlanEligibilityRule>
    {
        /// <summary>
        /// Initialize a new BenefitsPlanEligibilityRuleSingle object.
        /// </summary>
        public BenefitsPlanEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsPlanEligibilityRuleSingle object.
        /// </summary>
        public BenefitsPlanEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsPlanEligibilityRuleSingle object.
        /// </summary>
        public BenefitsPlanEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPlanEligibilityRule> query)
            : base(query) {}

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
        /// There are no comments for BenefitsWaitingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsWaitingPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle BenefitsWaitingPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsWaitingPeriod == null))
                {
                    this._BenefitsWaitingPeriod = new global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle(this.Context, GetPath("BenefitsWaitingPeriod"));
                }
                return this._BenefitsWaitingPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle _BenefitsWaitingPeriod;
        /// <summary>
        /// There are no comments for BenefitsEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRule")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRuleSingle BenefitsEligibilityRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsEligibilityRule == null))
                {
                    this._BenefitsEligibilityRule = new global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRuleSingle(this.Context, GetPath("BenefitsEligibilityRule"));
                }
                return this._BenefitsEligibilityRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRuleSingle _BenefitsEligibilityRule;
        /// <summary>
        /// There are no comments for BenefitsDeductionWaitingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsDeductionWaitingPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle BenefitsDeductionWaitingPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsDeductionWaitingPeriod == null))
                {
                    this._BenefitsDeductionWaitingPeriod = new global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle(this.Context, GetPath("BenefitsDeductionWaitingPeriod"));
                }
                return this._BenefitsDeductionWaitingPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriodSingle _BenefitsDeductionWaitingPeriod;
    }
    /// <summary>
    /// There are no comments for BenefitsPlanEligibilityRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PlanId
    /// EligibilityRuleId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PlanId", "EligibilityRuleId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsPlanEligibilityRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEligibilityRule")]
    public partial class BenefitsPlanEligibilityRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsPlanEligibilityRule object.
        /// </summary>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="eligibilityRuleId">Initial value of EligibilityRuleId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="benefitsPlan">Initial value of BenefitsPlan.</param>
        /// <param name="benefitsEligibilityRule">Initial value of BenefitsEligibilityRule.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsPlanEligibilityRule CreateBenefitsPlanEligibilityRule(string planId, string eligibilityRuleId, decimal lineNumber, global::Microsoft.Dynamics.DataEntities.BenefitsPlan benefitsPlan, global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRule benefitsEligibilityRule)
        {
            BenefitsPlanEligibilityRule benefitsPlanEligibilityRule = new BenefitsPlanEligibilityRule();
            benefitsPlanEligibilityRule.PlanId = planId;
            benefitsPlanEligibilityRule.EligibilityRuleId = eligibilityRuleId;
            benefitsPlanEligibilityRule.LineNumber = lineNumber;
            if ((benefitsPlan == null))
            {
                throw new global::System.ArgumentNullException("benefitsPlan");
            }
            benefitsPlanEligibilityRule.BenefitsPlan = benefitsPlan;
            if ((benefitsEligibilityRule == null))
            {
                throw new global::System.ArgumentNullException("benefitsEligibilityRule");
            }
            benefitsPlanEligibilityRule.BenefitsEligibilityRule = benefitsEligibilityRule;
            return benefitsPlanEligibilityRule;
        }
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
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property SourceDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceDate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitRuleStartDate> SourceDate
        {
            get
            {
                return this._SourceDate;
            }
            set
            {
                this.OnSourceDateChanging(value);
                this._SourceDate = value;
                this.OnSourceDateChanged();
                this.OnPropertyChanged("SourceDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitRuleStartDate> _SourceDate;
        partial void OnSourceDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitRuleStartDate> value);
        partial void OnSourceDateChanged();
        /// <summary>
        /// There are no comments for Property DeductionWaitingPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionWaitingPeriodId")]
        public virtual string DeductionWaitingPeriodId
        {
            get
            {
                return this._DeductionWaitingPeriodId;
            }
            set
            {
                this.OnDeductionWaitingPeriodIdChanging(value);
                this._DeductionWaitingPeriodId = value;
                this.OnDeductionWaitingPeriodIdChanged();
                this.OnPropertyChanged("DeductionWaitingPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeductionWaitingPeriodId;
        partial void OnDeductionWaitingPeriodIdChanging(string value);
        partial void OnDeductionWaitingPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property ActionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitAction> ActionType
        {
            get
            {
                return this._ActionType;
            }
            set
            {
                this.OnActionTypeChanging(value);
                this._ActionType = value;
                this.OnActionTypeChanged();
                this.OnPropertyChanged("ActionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitAction> _ActionType;
        partial void OnActionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitAction> value);
        partial void OnActionTypeChanged();
        /// <summary>
        /// There are no comments for Property CoverageWaitingPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CoverageWaitingPeriodId")]
        public virtual string CoverageWaitingPeriodId
        {
            get
            {
                return this._CoverageWaitingPeriodId;
            }
            set
            {
                this.OnCoverageWaitingPeriodIdChanging(value);
                this._CoverageWaitingPeriodId = value;
                this.OnCoverageWaitingPeriodIdChanged();
                this.OnPropertyChanged("CoverageWaitingPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CoverageWaitingPeriodId;
        partial void OnCoverageWaitingPeriodIdChanging(string value);
        partial void OnCoverageWaitingPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitsPlan is required.")]
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
        /// There are no comments for Property BenefitsWaitingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsWaitingPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod BenefitsWaitingPeriod
        {
            get
            {
                return this._BenefitsWaitingPeriod;
            }
            set
            {
                this.OnBenefitsWaitingPeriodChanging(value);
                this._BenefitsWaitingPeriod = value;
                this.OnBenefitsWaitingPeriodChanged();
                this.OnPropertyChanged("BenefitsWaitingPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod _BenefitsWaitingPeriod;
        partial void OnBenefitsWaitingPeriodChanging(global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod value);
        partial void OnBenefitsWaitingPeriodChanged();
        /// <summary>
        /// There are no comments for Property BenefitsEligibilityRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRule")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitsEligibilityRule is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRule BenefitsEligibilityRule
        {
            get
            {
                return this._BenefitsEligibilityRule;
            }
            set
            {
                this.OnBenefitsEligibilityRuleChanging(value);
                this._BenefitsEligibilityRule = value;
                this.OnBenefitsEligibilityRuleChanged();
                this.OnPropertyChanged("BenefitsEligibilityRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRule _BenefitsEligibilityRule;
        partial void OnBenefitsEligibilityRuleChanging(global::Microsoft.Dynamics.DataEntities.BenefitsEligibilityRule value);
        partial void OnBenefitsEligibilityRuleChanged();
        /// <summary>
        /// There are no comments for Property BenefitsDeductionWaitingPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsDeductionWaitingPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod BenefitsDeductionWaitingPeriod
        {
            get
            {
                return this._BenefitsDeductionWaitingPeriod;
            }
            set
            {
                this.OnBenefitsDeductionWaitingPeriodChanging(value);
                this._BenefitsDeductionWaitingPeriod = value;
                this.OnBenefitsDeductionWaitingPeriodChanged();
                this.OnPropertyChanged("BenefitsDeductionWaitingPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod _BenefitsDeductionWaitingPeriod;
        partial void OnBenefitsDeductionWaitingPeriodChanging(global::Microsoft.Dynamics.DataEntities.BenefitsWaitingPeriod value);
        partial void OnBenefitsDeductionWaitingPeriodChanged();
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
