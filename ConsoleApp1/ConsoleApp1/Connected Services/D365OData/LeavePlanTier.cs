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
    /// There are no comments for LeavePlanTierSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanTierSingle")]
    public partial class LeavePlanTierSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeavePlanTier>
    {
        /// <summary>
        /// Initialize a new LeavePlanTierSingle object.
        /// </summary>
        public LeavePlanTierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeavePlanTierSingle object.
        /// </summary>
        public LeavePlanTierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeavePlanTierSingle object.
        /// </summary>
        public LeavePlanTierSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeavePlanTier> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Plan")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeavePlanSingle Plan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Plan == null))
                {
                    this._Plan = new global::Microsoft.Dynamics.DataEntities.LeavePlanSingle(this.Context, GetPath("Plan"));
                }
                return this._Plan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeavePlanSingle _Plan;
    }
    /// <summary>
    /// There are no comments for LeavePlanTier in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LeavePlanId
    /// TierNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeavePlanId", "TierNumber")]
    [global::Microsoft.OData.Client.EntitySet("LeavePlanTiers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanTier")]
    public partial class LeavePlanTier : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeavePlanTier object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="leavePlanId">Initial value of LeavePlanId.</param>
        /// <param name="tierNumber">Initial value of TierNumber.</param>
        /// <param name="grant">Initial value of Grant.</param>
        /// <param name="maximumCarryover">Initial value of MaximumCarryover.</param>
        /// <param name="minimumBalance">Initial value of MinimumBalance.</param>
        /// <param name="accrualAmount">Initial value of AccrualAmount.</param>
        /// <param name="monthsOfService">Initial value of MonthsOfService.</param>
        /// <param name="maximumBalance">Initial value of MaximumBalance.</param>
        /// <param name="qualifyingAmount">Initial value of QualifyingAmount.</param>
        /// <param name="plan">Initial value of Plan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeavePlanTier CreateLeavePlanTier(string dataAreaId, 
                    string leavePlanId, 
                    decimal tierNumber, 
                    decimal grant, 
                    decimal maximumCarryover, 
                    decimal minimumBalance, 
                    decimal accrualAmount, 
                    decimal monthsOfService, 
                    decimal maximumBalance, 
                    decimal qualifyingAmount, 
                    global::Microsoft.Dynamics.DataEntities.LeavePlan plan)
        {
            LeavePlanTier leavePlanTier = new LeavePlanTier();
            leavePlanTier.DataAreaId = dataAreaId;
            leavePlanTier.LeavePlanId = leavePlanId;
            leavePlanTier.TierNumber = tierNumber;
            leavePlanTier.Grant = grant;
            leavePlanTier.MaximumCarryover = maximumCarryover;
            leavePlanTier.MinimumBalance = minimumBalance;
            leavePlanTier.AccrualAmount = accrualAmount;
            leavePlanTier.MonthsOfService = monthsOfService;
            leavePlanTier.MaximumBalance = maximumBalance;
            leavePlanTier.QualifyingAmount = qualifyingAmount;
            if ((plan == null))
            {
                throw new global::System.ArgumentNullException("plan");
            }
            leavePlanTier.Plan = plan;
            return leavePlanTier;
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
        /// There are no comments for Property LeavePlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeavePlanId is required.")]
        public virtual string LeavePlanId
        {
            get
            {
                return this._LeavePlanId;
            }
            set
            {
                this.OnLeavePlanIdChanging(value);
                this._LeavePlanId = value;
                this.OnLeavePlanIdChanged();
                this.OnPropertyChanged("LeavePlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeavePlanId;
        partial void OnLeavePlanIdChanging(string value);
        partial void OnLeavePlanIdChanged();
        /// <summary>
        /// There are no comments for Property TierNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TierNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TierNumber is required.")]
        public virtual decimal TierNumber
        {
            get
            {
                return this._TierNumber;
            }
            set
            {
                this.OnTierNumberChanging(value);
                this._TierNumber = value;
                this.OnTierNumberChanged();
                this.OnPropertyChanged("TierNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TierNumber;
        partial void OnTierNumberChanging(decimal value);
        partial void OnTierNumberChanged();
        /// <summary>
        /// There are no comments for Property Grant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Grant")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Grant is required.")]
        public virtual decimal Grant
        {
            get
            {
                return this._Grant;
            }
            set
            {
                this.OnGrantChanging(value);
                this._Grant = value;
                this.OnGrantChanged();
                this.OnPropertyChanged("Grant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Grant;
        partial void OnGrantChanging(decimal value);
        partial void OnGrantChanged();
        /// <summary>
        /// There are no comments for Property MaximumCarryover in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumCarryover")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumCarryover is required.")]
        public virtual decimal MaximumCarryover
        {
            get
            {
                return this._MaximumCarryover;
            }
            set
            {
                this.OnMaximumCarryoverChanging(value);
                this._MaximumCarryover = value;
                this.OnMaximumCarryoverChanged();
                this.OnPropertyChanged("MaximumCarryover");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumCarryover;
        partial void OnMaximumCarryoverChanging(decimal value);
        partial void OnMaximumCarryoverChanged();
        /// <summary>
        /// There are no comments for Property MinimumBalance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumBalance")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumBalance is required.")]
        public virtual decimal MinimumBalance
        {
            get
            {
                return this._MinimumBalance;
            }
            set
            {
                this.OnMinimumBalanceChanging(value);
                this._MinimumBalance = value;
                this.OnMinimumBalanceChanged();
                this.OnPropertyChanged("MinimumBalance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumBalance;
        partial void OnMinimumBalanceChanging(decimal value);
        partial void OnMinimumBalanceChanged();
        /// <summary>
        /// There are no comments for Property AccrualAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualAmount is required.")]
        public virtual decimal AccrualAmount
        {
            get
            {
                return this._AccrualAmount;
            }
            set
            {
                this.OnAccrualAmountChanging(value);
                this._AccrualAmount = value;
                this.OnAccrualAmountChanged();
                this.OnPropertyChanged("AccrualAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccrualAmount;
        partial void OnAccrualAmountChanging(decimal value);
        partial void OnAccrualAmountChanged();
        /// <summary>
        /// There are no comments for Property MonthsOfService in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MonthsOfService")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MonthsOfService is required.")]
        public virtual decimal MonthsOfService
        {
            get
            {
                return this._MonthsOfService;
            }
            set
            {
                this.OnMonthsOfServiceChanging(value);
                this._MonthsOfService = value;
                this.OnMonthsOfServiceChanged();
                this.OnPropertyChanged("MonthsOfService");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MonthsOfService;
        partial void OnMonthsOfServiceChanging(decimal value);
        partial void OnMonthsOfServiceChanged();
        /// <summary>
        /// There are no comments for Property MaximumBalance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumBalance")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumBalance is required.")]
        public virtual decimal MaximumBalance
        {
            get
            {
                return this._MaximumBalance;
            }
            set
            {
                this.OnMaximumBalanceChanging(value);
                this._MaximumBalance = value;
                this.OnMaximumBalanceChanged();
                this.OnPropertyChanged("MaximumBalance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumBalance;
        partial void OnMaximumBalanceChanging(decimal value);
        partial void OnMaximumBalanceChanged();
        /// <summary>
        /// There are no comments for Property QualifyingAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QualifyingAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualifyingAmount is required.")]
        public virtual decimal QualifyingAmount
        {
            get
            {
                return this._QualifyingAmount;
            }
            set
            {
                this.OnQualifyingAmountChanging(value);
                this._QualifyingAmount = value;
                this.OnQualifyingAmountChanged();
                this.OnPropertyChanged("QualifyingAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QualifyingAmount;
        partial void OnQualifyingAmountChanging(decimal value);
        partial void OnQualifyingAmountChanged();
        /// <summary>
        /// There are no comments for Property UseFullTimeEquivalency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseFullTimeEquivalency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseFullTimeEquivalency
        {
            get
            {
                return this._UseFullTimeEquivalency;
            }
            set
            {
                this.OnUseFullTimeEquivalencyChanging(value);
                this._UseFullTimeEquivalency = value;
                this.OnUseFullTimeEquivalencyChanged();
                this.OnPropertyChanged("UseFullTimeEquivalency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseFullTimeEquivalency;
        partial void OnUseFullTimeEquivalencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseFullTimeEquivalencyChanged();
        /// <summary>
        /// There are no comments for Property Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Plan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Plan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeavePlan Plan
        {
            get
            {
                return this._Plan;
            }
            set
            {
                this.OnPlanChanging(value);
                this._Plan = value;
                this.OnPlanChanged();
                this.OnPropertyChanged("Plan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeavePlan _Plan;
        partial void OnPlanChanging(global::Microsoft.Dynamics.DataEntities.LeavePlan value);
        partial void OnPlanChanged();
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
