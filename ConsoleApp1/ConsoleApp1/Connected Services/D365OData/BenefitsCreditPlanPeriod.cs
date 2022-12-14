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
    /// There are no comments for BenefitsCreditPlanPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCreditPlanPeriodSingle")]
    public partial class BenefitsCreditPlanPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsCreditPlanPeriod>
    {
        /// <summary>
        /// Initialize a new BenefitsCreditPlanPeriodSingle object.
        /// </summary>
        public BenefitsCreditPlanPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsCreditPlanPeriodSingle object.
        /// </summary>
        public BenefitsCreditPlanPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsCreditPlanPeriodSingle object.
        /// </summary>
        public BenefitsCreditPlanPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsCreditPlanPeriod> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BenefitsCreditPlanPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PlanId
    /// PeriodId
    /// CreditId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PlanId", "PeriodId", "CreditId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsCreditPlanPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCreditPlanPeriod")]
    public partial class BenefitsCreditPlanPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsCreditPlanPeriod object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="periodId">Initial value of PeriodId.</param>
        /// <param name="creditId">Initial value of CreditId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsCreditPlanPeriod CreateBenefitsCreditPlanPeriod(string dataAreaId, string planId, string periodId, string creditId)
        {
            BenefitsCreditPlanPeriod benefitsCreditPlanPeriod = new BenefitsCreditPlanPeriod();
            benefitsCreditPlanPeriod.DataAreaId = dataAreaId;
            benefitsCreditPlanPeriod.PlanId = planId;
            benefitsCreditPlanPeriod.PeriodId = periodId;
            benefitsCreditPlanPeriod.CreditId = creditId;
            return benefitsCreditPlanPeriod;
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
        /// There are no comments for Property CreditId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CreditId is required.")]
        public virtual string CreditId
        {
            get
            {
                return this._CreditId;
            }
            set
            {
                this.OnCreditIdChanging(value);
                this._CreditId = value;
                this.OnCreditIdChanged();
                this.OnPropertyChanged("CreditId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditId;
        partial void OnCreditIdChanging(string value);
        partial void OnCreditIdChanged();
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
