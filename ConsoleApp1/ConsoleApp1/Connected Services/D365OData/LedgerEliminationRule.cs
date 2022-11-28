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
    /// There are no comments for LedgerEliminationRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerEliminationRuleSingle")]
    public partial class LedgerEliminationRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerEliminationRule>
    {
        /// <summary>
        /// Initialize a new LedgerEliminationRuleSingle object.
        /// </summary>
        public LedgerEliminationRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerEliminationRuleSingle object.
        /// </summary>
        public LedgerEliminationRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerEliminationRuleSingle object.
        /// </summary>
        public LedgerEliminationRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerEliminationRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerEliminationRuleLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerEliminationRuleLine")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine> LedgerEliminationRuleLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerEliminationRuleLine == null))
                {
                    this._LedgerEliminationRuleLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine>(GetPath("LedgerEliminationRuleLine"));
                }
                return this._LedgerEliminationRuleLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine> _LedgerEliminationRuleLine;
        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
    }
    /// <summary>
    /// There are no comments for LedgerEliminationRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RuleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RuleId")]
    [global::Microsoft.OData.Client.EntitySet("LedgerEliminationRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerEliminationRule")]
    public partial class LedgerEliminationRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerEliminationRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ruleId">Initial value of RuleId.</param>
        /// <param name="dateLastRun">Initial value of DateLastRun.</param>
        /// <param name="effectiveStartDate">Initial value of EffectiveStartDate.</param>
        /// <param name="effectiveEndDate">Initial value of EffectiveEndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerEliminationRule CreateLedgerEliminationRule(string dataAreaId, string ruleId, global::System.DateTimeOffset dateLastRun, global::System.DateTimeOffset effectiveStartDate, global::System.DateTimeOffset effectiveEndDate)
        {
            LedgerEliminationRule ledgerEliminationRule = new LedgerEliminationRule();
            ledgerEliminationRule.DataAreaId = dataAreaId;
            ledgerEliminationRule.RuleId = ruleId;
            ledgerEliminationRule.DateLastRun = dateLastRun;
            ledgerEliminationRule.EffectiveStartDate = effectiveStartDate;
            ledgerEliminationRule.EffectiveEndDate = effectiveEndDate;
            return ledgerEliminationRule;
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
        /// There are no comments for Property RuleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleId is required.")]
        public virtual string RuleId
        {
            get
            {
                return this._RuleId;
            }
            set
            {
                this.OnRuleIdChanging(value);
                this._RuleId = value;
                this.OnRuleIdChanged();
                this.OnPropertyChanged("RuleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleId;
        partial void OnRuleIdChanging(string value);
        partial void OnRuleIdChanged();
        /// <summary>
        /// There are no comments for Property DateLastRun in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateLastRun")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateLastRun is required.")]
        public virtual global::System.DateTimeOffset DateLastRun
        {
            get
            {
                return this._DateLastRun;
            }
            set
            {
                this.OnDateLastRunChanging(value);
                this._DateLastRun = value;
                this.OnDateLastRunChanged();
                this.OnPropertyChanged("DateLastRun");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateLastRun;
        partial void OnDateLastRunChanging(global::System.DateTimeOffset value);
        partial void OnDateLastRunChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalName")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property Active in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Active")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Active;
        partial void OnActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property DestinationCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DestinationCompany")]
        public virtual string DestinationCompany
        {
            get
            {
                return this._DestinationCompany;
            }
            set
            {
                this.OnDestinationCompanyChanging(value);
                this._DestinationCompany = value;
                this.OnDestinationCompanyChanged();
                this.OnPropertyChanged("DestinationCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationCompany;
        partial void OnDestinationCompanyChanging(string value);
        partial void OnDestinationCompanyChanged();
        /// <summary>
        /// There are no comments for Property EffectiveStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveStartDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveStartDate
        {
            get
            {
                return this._EffectiveStartDate;
            }
            set
            {
                this.OnEffectiveStartDateChanging(value);
                this._EffectiveStartDate = value;
                this.OnEffectiveStartDateChanged();
                this.OnPropertyChanged("EffectiveStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveStartDate;
        partial void OnEffectiveStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveStartDateChanged();
        /// <summary>
        /// There are no comments for Property EffectiveEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveEndDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveEndDate
        {
            get
            {
                return this._EffectiveEndDate;
            }
            set
            {
                this.OnEffectiveEndDateChanging(value);
                this._EffectiveEndDate = value;
                this.OnEffectiveEndDateChanged();
                this.OnPropertyChanged("EffectiveEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveEndDate;
        partial void OnEffectiveEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveEndDateChanged();
        /// <summary>
        /// There are no comments for Property LedgerEliminationRuleLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerEliminationRuleLine")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine> LedgerEliminationRuleLine
        {
            get
            {
                return this._LedgerEliminationRuleLine;
            }
            set
            {
                this.OnLedgerEliminationRuleLineChanging(value);
                this._LedgerEliminationRuleLine = value;
                this.OnLedgerEliminationRuleLineChanged();
                this.OnPropertyChanged("LedgerEliminationRuleLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine> _LedgerEliminationRuleLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerEliminationRuleLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerEliminationRuleLine> value);
        partial void OnLedgerEliminationRuleLineChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
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
