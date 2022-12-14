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
    /// There are no comments for BenefitsPlanEmployeeLifeEventTransactionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEmployeeLifeEventTransactionSingle")]
    public partial class BenefitsPlanEmployeeLifeEventTransactionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPlanEmployeeLifeEventTransaction>
    {
        /// <summary>
        /// Initialize a new BenefitsPlanEmployeeLifeEventTransactionSingle object.
        /// </summary>
        public BenefitsPlanEmployeeLifeEventTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsPlanEmployeeLifeEventTransactionSingle object.
        /// </summary>
        public BenefitsPlanEmployeeLifeEventTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsPlanEmployeeLifeEventTransactionSingle object.
        /// </summary>
        public BenefitsPlanEmployeeLifeEventTransactionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPlanEmployeeLifeEventTransaction> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BenefitsPlanEmployeeLifeEventTransaction in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// PlanPeriodId
    /// PlanEmployeeBeforeLifeEventPlanId
    /// PlanEmployeeBeforeLifeEventCoverageOptionId
    /// PlanEmployeeBeforeLifeEventValidFrom
    /// PlanEmployeeBeforeLifeEventValidTo
    /// LegalEntityId
    /// LineNum
    /// LifeEventTypeId
    /// LifeEventDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "PlanPeriodId", "PlanEmployeeBeforeLifeEventPlanId", "PlanEmployeeBeforeLifeEventCoverageOptionId", "PlanEmployeeBeforeLifeEventValidFrom", "PlanEmployeeBeforeLifeEventValidTo", "LegalEntityId", "LineNum", "LifeEventTypeId", "LifeEventDate")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsPlanEmployeeLifeEventTransactions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPlanEmployeeLifeEventTransaction")]
    public partial class BenefitsPlanEmployeeLifeEventTransaction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsPlanEmployeeLifeEventTransaction object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="planPeriodId">Initial value of PlanPeriodId.</param>
        /// <param name="planEmployeeBeforeLifeEventPlanId">Initial value of PlanEmployeeBeforeLifeEventPlanId.</param>
        /// <param name="planEmployeeBeforeLifeEventCoverageOptionId">Initial value of PlanEmployeeBeforeLifeEventCoverageOptionId.</param>
        /// <param name="planEmployeeBeforeLifeEventValidFrom">Initial value of PlanEmployeeBeforeLifeEventValidFrom.</param>
        /// <param name="planEmployeeBeforeLifeEventValidTo">Initial value of PlanEmployeeBeforeLifeEventValidTo.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="lifeEventTypeId">Initial value of LifeEventTypeId.</param>
        /// <param name="lifeEventDate">Initial value of LifeEventDate.</param>
        /// <param name="planEmployeeAfterLifeEventValidTo">Initial value of PlanEmployeeAfterLifeEventValidTo.</param>
        /// <param name="planEmployeeAfterLifeEventValidFrom">Initial value of PlanEmployeeAfterLifeEventValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsPlanEmployeeLifeEventTransaction CreateBenefitsPlanEmployeeLifeEventTransaction(string personnelNumber, 
                    string planPeriodId, 
                    string planEmployeeBeforeLifeEventPlanId, 
                    string planEmployeeBeforeLifeEventCoverageOptionId, 
                    global::System.DateTimeOffset planEmployeeBeforeLifeEventValidFrom, 
                    global::System.DateTimeOffset planEmployeeBeforeLifeEventValidTo, 
                    string legalEntityId, 
                    int lineNum, 
                    string lifeEventTypeId, 
                    global::System.DateTimeOffset lifeEventDate, 
                    global::System.DateTimeOffset planEmployeeAfterLifeEventValidTo, 
                    global::System.DateTimeOffset planEmployeeAfterLifeEventValidFrom)
        {
            BenefitsPlanEmployeeLifeEventTransaction benefitsPlanEmployeeLifeEventTransaction = new BenefitsPlanEmployeeLifeEventTransaction();
            benefitsPlanEmployeeLifeEventTransaction.PersonnelNumber = personnelNumber;
            benefitsPlanEmployeeLifeEventTransaction.PlanPeriodId = planPeriodId;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeBeforeLifeEventPlanId = planEmployeeBeforeLifeEventPlanId;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeBeforeLifeEventCoverageOptionId = planEmployeeBeforeLifeEventCoverageOptionId;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeBeforeLifeEventValidFrom = planEmployeeBeforeLifeEventValidFrom;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeBeforeLifeEventValidTo = planEmployeeBeforeLifeEventValidTo;
            benefitsPlanEmployeeLifeEventTransaction.LegalEntityId = legalEntityId;
            benefitsPlanEmployeeLifeEventTransaction.LineNum = lineNum;
            benefitsPlanEmployeeLifeEventTransaction.LifeEventTypeId = lifeEventTypeId;
            benefitsPlanEmployeeLifeEventTransaction.LifeEventDate = lifeEventDate;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeAfterLifeEventValidTo = planEmployeeAfterLifeEventValidTo;
            benefitsPlanEmployeeLifeEventTransaction.PlanEmployeeAfterLifeEventValidFrom = planEmployeeAfterLifeEventValidFrom;
            return benefitsPlanEmployeeLifeEventTransaction;
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
        /// There are no comments for Property PlanPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanPeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanPeriodId is required.")]
        public virtual string PlanPeriodId
        {
            get
            {
                return this._PlanPeriodId;
            }
            set
            {
                this.OnPlanPeriodIdChanging(value);
                this._PlanPeriodId = value;
                this.OnPlanPeriodIdChanged();
                this.OnPropertyChanged("PlanPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanPeriodId;
        partial void OnPlanPeriodIdChanging(string value);
        partial void OnPlanPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeBeforeLifeEventPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeBeforeLifeEventPlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeBeforeLifeEventPlanId is required.")]
        public virtual string PlanEmployeeBeforeLifeEventPlanId
        {
            get
            {
                return this._PlanEmployeeBeforeLifeEventPlanId;
            }
            set
            {
                this.OnPlanEmployeeBeforeLifeEventPlanIdChanging(value);
                this._PlanEmployeeBeforeLifeEventPlanId = value;
                this.OnPlanEmployeeBeforeLifeEventPlanIdChanged();
                this.OnPropertyChanged("PlanEmployeeBeforeLifeEventPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanEmployeeBeforeLifeEventPlanId;
        partial void OnPlanEmployeeBeforeLifeEventPlanIdChanging(string value);
        partial void OnPlanEmployeeBeforeLifeEventPlanIdChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeBeforeLifeEventCoverageOptionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeBeforeLifeEventCoverageOptionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeBeforeLifeEventCoverageOptionId is required.")]
        public virtual string PlanEmployeeBeforeLifeEventCoverageOptionId
        {
            get
            {
                return this._PlanEmployeeBeforeLifeEventCoverageOptionId;
            }
            set
            {
                this.OnPlanEmployeeBeforeLifeEventCoverageOptionIdChanging(value);
                this._PlanEmployeeBeforeLifeEventCoverageOptionId = value;
                this.OnPlanEmployeeBeforeLifeEventCoverageOptionIdChanged();
                this.OnPropertyChanged("PlanEmployeeBeforeLifeEventCoverageOptionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanEmployeeBeforeLifeEventCoverageOptionId;
        partial void OnPlanEmployeeBeforeLifeEventCoverageOptionIdChanging(string value);
        partial void OnPlanEmployeeBeforeLifeEventCoverageOptionIdChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeBeforeLifeEventValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeBeforeLifeEventValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeBeforeLifeEventValidFrom is required.")]
        public virtual global::System.DateTimeOffset PlanEmployeeBeforeLifeEventValidFrom
        {
            get
            {
                return this._PlanEmployeeBeforeLifeEventValidFrom;
            }
            set
            {
                this.OnPlanEmployeeBeforeLifeEventValidFromChanging(value);
                this._PlanEmployeeBeforeLifeEventValidFrom = value;
                this.OnPlanEmployeeBeforeLifeEventValidFromChanged();
                this.OnPropertyChanged("PlanEmployeeBeforeLifeEventValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PlanEmployeeBeforeLifeEventValidFrom;
        partial void OnPlanEmployeeBeforeLifeEventValidFromChanging(global::System.DateTimeOffset value);
        partial void OnPlanEmployeeBeforeLifeEventValidFromChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeBeforeLifeEventValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeBeforeLifeEventValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeBeforeLifeEventValidTo is required.")]
        public virtual global::System.DateTimeOffset PlanEmployeeBeforeLifeEventValidTo
        {
            get
            {
                return this._PlanEmployeeBeforeLifeEventValidTo;
            }
            set
            {
                this.OnPlanEmployeeBeforeLifeEventValidToChanging(value);
                this._PlanEmployeeBeforeLifeEventValidTo = value;
                this.OnPlanEmployeeBeforeLifeEventValidToChanged();
                this.OnPropertyChanged("PlanEmployeeBeforeLifeEventValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PlanEmployeeBeforeLifeEventValidTo;
        partial void OnPlanEmployeeBeforeLifeEventValidToChanging(global::System.DateTimeOffset value);
        partial void OnPlanEmployeeBeforeLifeEventValidToChanged();
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
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual int LineNum
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
        private int _LineNum;
        partial void OnLineNumChanging(int value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property LifeEventTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifeEventTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LifeEventTypeId is required.")]
        public virtual string LifeEventTypeId
        {
            get
            {
                return this._LifeEventTypeId;
            }
            set
            {
                this.OnLifeEventTypeIdChanging(value);
                this._LifeEventTypeId = value;
                this.OnLifeEventTypeIdChanged();
                this.OnPropertyChanged("LifeEventTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifeEventTypeId;
        partial void OnLifeEventTypeIdChanging(string value);
        partial void OnLifeEventTypeIdChanged();
        /// <summary>
        /// There are no comments for Property LifeEventDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifeEventDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LifeEventDate is required.")]
        public virtual global::System.DateTimeOffset LifeEventDate
        {
            get
            {
                return this._LifeEventDate;
            }
            set
            {
                this.OnLifeEventDateChanging(value);
                this._LifeEventDate = value;
                this.OnLifeEventDateChanged();
                this.OnPropertyChanged("LifeEventDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LifeEventDate;
        partial void OnLifeEventDateChanging(global::System.DateTimeOffset value);
        partial void OnLifeEventDateChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeAfterLifeEventPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeAfterLifeEventPlanId")]
        public virtual string PlanEmployeeAfterLifeEventPlanId
        {
            get
            {
                return this._PlanEmployeeAfterLifeEventPlanId;
            }
            set
            {
                this.OnPlanEmployeeAfterLifeEventPlanIdChanging(value);
                this._PlanEmployeeAfterLifeEventPlanId = value;
                this.OnPlanEmployeeAfterLifeEventPlanIdChanged();
                this.OnPropertyChanged("PlanEmployeeAfterLifeEventPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanEmployeeAfterLifeEventPlanId;
        partial void OnPlanEmployeeAfterLifeEventPlanIdChanging(string value);
        partial void OnPlanEmployeeAfterLifeEventPlanIdChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeAfterLifeEventValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeAfterLifeEventValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeAfterLifeEventValidTo is required.")]
        public virtual global::System.DateTimeOffset PlanEmployeeAfterLifeEventValidTo
        {
            get
            {
                return this._PlanEmployeeAfterLifeEventValidTo;
            }
            set
            {
                this.OnPlanEmployeeAfterLifeEventValidToChanging(value);
                this._PlanEmployeeAfterLifeEventValidTo = value;
                this.OnPlanEmployeeAfterLifeEventValidToChanged();
                this.OnPropertyChanged("PlanEmployeeAfterLifeEventValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PlanEmployeeAfterLifeEventValidTo;
        partial void OnPlanEmployeeAfterLifeEventValidToChanging(global::System.DateTimeOffset value);
        partial void OnPlanEmployeeAfterLifeEventValidToChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeAfterLiveEventCoverageOptionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeAfterLiveEventCoverageOptionId")]
        public virtual string PlanEmployeeAfterLiveEventCoverageOptionId
        {
            get
            {
                return this._PlanEmployeeAfterLiveEventCoverageOptionId;
            }
            set
            {
                this.OnPlanEmployeeAfterLiveEventCoverageOptionIdChanging(value);
                this._PlanEmployeeAfterLiveEventCoverageOptionId = value;
                this.OnPlanEmployeeAfterLiveEventCoverageOptionIdChanged();
                this.OnPropertyChanged("PlanEmployeeAfterLiveEventCoverageOptionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanEmployeeAfterLiveEventCoverageOptionId;
        partial void OnPlanEmployeeAfterLiveEventCoverageOptionIdChanging(string value);
        partial void OnPlanEmployeeAfterLiveEventCoverageOptionIdChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeBeforeLifeEventStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeBeforeLifeEventStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> PlanEmployeeBeforeLifeEventStatus
        {
            get
            {
                return this._PlanEmployeeBeforeLifeEventStatus;
            }
            set
            {
                this.OnPlanEmployeeBeforeLifeEventStatusChanging(value);
                this._PlanEmployeeBeforeLifeEventStatus = value;
                this.OnPlanEmployeeBeforeLifeEventStatusChanged();
                this.OnPropertyChanged("PlanEmployeeBeforeLifeEventStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> _PlanEmployeeBeforeLifeEventStatus;
        partial void OnPlanEmployeeBeforeLifeEventStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitEmployeePlanStatus> value);
        partial void OnPlanEmployeeBeforeLifeEventStatusChanged();
        /// <summary>
        /// There are no comments for Property PlanEmployeeAfterLifeEventValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanEmployeeAfterLifeEventValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanEmployeeAfterLifeEventValidFrom is required.")]
        public virtual global::System.DateTimeOffset PlanEmployeeAfterLifeEventValidFrom
        {
            get
            {
                return this._PlanEmployeeAfterLifeEventValidFrom;
            }
            set
            {
                this.OnPlanEmployeeAfterLifeEventValidFromChanging(value);
                this._PlanEmployeeAfterLifeEventValidFrom = value;
                this.OnPlanEmployeeAfterLifeEventValidFromChanged();
                this.OnPropertyChanged("PlanEmployeeAfterLifeEventValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PlanEmployeeAfterLifeEventValidFrom;
        partial void OnPlanEmployeeAfterLifeEventValidFromChanging(global::System.DateTimeOffset value);
        partial void OnPlanEmployeeAfterLifeEventValidFromChanged();
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
