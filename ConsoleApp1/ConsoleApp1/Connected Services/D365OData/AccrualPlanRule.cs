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
    /// There are no comments for AccrualPlanRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlanRuleSingle")]
    public partial class AccrualPlanRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualPlanRule>
    {
        /// <summary>
        /// Initialize a new AccrualPlanRuleSingle object.
        /// </summary>
        public AccrualPlanRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccrualPlanRuleSingle object.
        /// </summary>
        public AccrualPlanRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccrualPlanRuleSingle object.
        /// </summary>
        public AccrualPlanRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualPlanRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlan")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle AccrualPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualPlan == null))
                {
                    this._AccrualPlan = new global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle(this.Context, GetPath("AccrualPlan"));
                }
                return this._AccrualPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle _AccrualPlan;
    }
    /// <summary>
    /// There are no comments for AccrualPlanRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccrualId
    /// EmploymentMonths
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccrualId", "EmploymentMonths")]
    [global::Microsoft.OData.Client.EntitySet("AccrualPlanRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlanRule")]
    public partial class AccrualPlanRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccrualPlanRule object.
        /// </summary>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="employmentMonths">Initial value of EmploymentMonths.</param>
        /// <param name="maximumLimit">Initial value of MaximumLimit.</param>
        /// <param name="hourlyRate">Initial value of HourlyRate.</param>
        /// <param name="minimumLimit">Initial value of MinimumLimit.</param>
        /// <param name="carryForwardLimit">Initial value of CarryForwardLimit.</param>
        /// <param name="accrualPlan">Initial value of AccrualPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccrualPlanRule CreateAccrualPlanRule(string accrualId, 
                    decimal employmentMonths, 
                    decimal maximumLimit, 
                    decimal hourlyRate, 
                    decimal minimumLimit, 
                    decimal carryForwardLimit, 
                    global::Microsoft.Dynamics.DataEntities.AccrualPlan accrualPlan)
        {
            AccrualPlanRule accrualPlanRule = new AccrualPlanRule();
            accrualPlanRule.AccrualId = accrualId;
            accrualPlanRule.EmploymentMonths = employmentMonths;
            accrualPlanRule.MaximumLimit = maximumLimit;
            accrualPlanRule.HourlyRate = hourlyRate;
            accrualPlanRule.MinimumLimit = minimumLimit;
            accrualPlanRule.CarryForwardLimit = carryForwardLimit;
            if ((accrualPlan == null))
            {
                throw new global::System.ArgumentNullException("accrualPlan");
            }
            accrualPlanRule.AccrualPlan = accrualPlan;
            return accrualPlanRule;
        }
        /// <summary>
        /// There are no comments for Property AccrualId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualId is required.")]
        public virtual string AccrualId
        {
            get
            {
                return this._AccrualId;
            }
            set
            {
                this.OnAccrualIdChanging(value);
                this._AccrualId = value;
                this.OnAccrualIdChanged();
                this.OnPropertyChanged("AccrualId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccrualId;
        partial void OnAccrualIdChanging(string value);
        partial void OnAccrualIdChanged();
        /// <summary>
        /// There are no comments for Property EmploymentMonths in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentMonths")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentMonths is required.")]
        public virtual decimal EmploymentMonths
        {
            get
            {
                return this._EmploymentMonths;
            }
            set
            {
                this.OnEmploymentMonthsChanging(value);
                this._EmploymentMonths = value;
                this.OnEmploymentMonthsChanged();
                this.OnPropertyChanged("EmploymentMonths");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EmploymentMonths;
        partial void OnEmploymentMonthsChanging(decimal value);
        partial void OnEmploymentMonthsChanged();
        /// <summary>
        /// There are no comments for Property MaximumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumLimit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumLimit is required.")]
        public virtual decimal MaximumLimit
        {
            get
            {
                return this._MaximumLimit;
            }
            set
            {
                this.OnMaximumLimitChanging(value);
                this._MaximumLimit = value;
                this.OnMaximumLimitChanged();
                this.OnPropertyChanged("MaximumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumLimit;
        partial void OnMaximumLimitChanging(decimal value);
        partial void OnMaximumLimitChanged();
        /// <summary>
        /// There are no comments for Property HourlyRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HourlyRate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HourlyRate is required.")]
        public virtual decimal HourlyRate
        {
            get
            {
                return this._HourlyRate;
            }
            set
            {
                this.OnHourlyRateChanging(value);
                this._HourlyRate = value;
                this.OnHourlyRateChanged();
                this.OnPropertyChanged("HourlyRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _HourlyRate;
        partial void OnHourlyRateChanging(decimal value);
        partial void OnHourlyRateChanged();
        /// <summary>
        /// There are no comments for Property MinimumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumLimit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumLimit is required.")]
        public virtual decimal MinimumLimit
        {
            get
            {
                return this._MinimumLimit;
            }
            set
            {
                this.OnMinimumLimitChanging(value);
                this._MinimumLimit = value;
                this.OnMinimumLimitChanged();
                this.OnPropertyChanged("MinimumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumLimit;
        partial void OnMinimumLimitChanging(decimal value);
        partial void OnMinimumLimitChanged();
        /// <summary>
        /// There are no comments for Property CarryForwardLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CarryForwardLimit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CarryForwardLimit is required.")]
        public virtual decimal CarryForwardLimit
        {
            get
            {
                return this._CarryForwardLimit;
            }
            set
            {
                this.OnCarryForwardLimitChanging(value);
                this._CarryForwardLimit = value;
                this.OnCarryForwardLimitChanged();
                this.OnPropertyChanged("CarryForwardLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CarryForwardLimit;
        partial void OnCarryForwardLimitChanging(decimal value);
        partial void OnCarryForwardLimitChanged();
        /// <summary>
        /// There are no comments for Property AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualPlan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlan AccrualPlan
        {
            get
            {
                return this._AccrualPlan;
            }
            set
            {
                this.OnAccrualPlanChanging(value);
                this._AccrualPlan = value;
                this.OnAccrualPlanChanged();
                this.OnPropertyChanged("AccrualPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlan _AccrualPlan;
        partial void OnAccrualPlanChanging(global::Microsoft.Dynamics.DataEntities.AccrualPlan value);
        partial void OnAccrualPlanChanged();
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
