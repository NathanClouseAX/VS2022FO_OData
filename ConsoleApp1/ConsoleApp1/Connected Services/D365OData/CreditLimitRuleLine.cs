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
    /// There are no comments for CreditLimitRuleLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditLimitRuleLineSingle")]
    public partial class CreditLimitRuleLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CreditLimitRuleLine>
    {
        /// <summary>
        /// Initialize a new CreditLimitRuleLineSingle object.
        /// </summary>
        public CreditLimitRuleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CreditLimitRuleLineSingle object.
        /// </summary>
        public CreditLimitRuleLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CreditLimitRuleLineSingle object.
        /// </summary>
        public CreditLimitRuleLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CreditLimitRuleLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CreditLimitRuleLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RuleRiskGroupId
    /// RuleCurrencyCode
    /// LineNum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RuleRiskGroupId", "RuleCurrencyCode", "LineNum")]
    [global::Microsoft.OData.Client.EntitySet("CreditLimitRuleLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditLimitRuleLine")]
    public partial class CreditLimitRuleLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CreditLimitRuleLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ruleRiskGroupId">Initial value of RuleRiskGroupId.</param>
        /// <param name="ruleCurrencyCode">Initial value of RuleCurrencyCode.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="creditMax">Initial value of CreditMax.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CreditLimitRuleLine CreateCreditLimitRuleLine(string dataAreaId, string ruleRiskGroupId, string ruleCurrencyCode, decimal lineNum, decimal creditMax)
        {
            CreditLimitRuleLine creditLimitRuleLine = new CreditLimitRuleLine();
            creditLimitRuleLine.DataAreaId = dataAreaId;
            creditLimitRuleLine.RuleRiskGroupId = ruleRiskGroupId;
            creditLimitRuleLine.RuleCurrencyCode = ruleCurrencyCode;
            creditLimitRuleLine.LineNum = lineNum;
            creditLimitRuleLine.CreditMax = creditMax;
            return creditLimitRuleLine;
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
        /// There are no comments for Property RuleRiskGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleRiskGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleRiskGroupId is required.")]
        public virtual string RuleRiskGroupId
        {
            get
            {
                return this._RuleRiskGroupId;
            }
            set
            {
                this.OnRuleRiskGroupIdChanging(value);
                this._RuleRiskGroupId = value;
                this.OnRuleRiskGroupIdChanged();
                this.OnPropertyChanged("RuleRiskGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleRiskGroupId;
        partial void OnRuleRiskGroupIdChanging(string value);
        partial void OnRuleRiskGroupIdChanged();
        /// <summary>
        /// There are no comments for Property RuleCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleCurrencyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleCurrencyCode is required.")]
        public virtual string RuleCurrencyCode
        {
            get
            {
                return this._RuleCurrencyCode;
            }
            set
            {
                this.OnRuleCurrencyCodeChanging(value);
                this._RuleCurrencyCode = value;
                this.OnRuleCurrencyCodeChanged();
                this.OnPropertyChanged("RuleCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleCurrencyCode;
        partial void OnRuleCurrencyCodeChanging(string value);
        partial void OnRuleCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
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
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property ComparisonValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ComparisonValue")]
        public virtual string ComparisonValue
        {
            get
            {
                return this._ComparisonValue;
            }
            set
            {
                this.OnComparisonValueChanging(value);
                this._ComparisonValue = value;
                this.OnComparisonValueChanged();
                this.OnPropertyChanged("ComparisonValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ComparisonValue;
        partial void OnComparisonValueChanging(string value);
        partial void OnComparisonValueChanged();
        /// <summary>
        /// There are no comments for Property ComparisonOperator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ComparisonOperator")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManComparisonOperator> ComparisonOperator
        {
            get
            {
                return this._ComparisonOperator;
            }
            set
            {
                this.OnComparisonOperatorChanging(value);
                this._ComparisonOperator = value;
                this.OnComparisonOperatorChanged();
                this.OnPropertyChanged("ComparisonOperator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManComparisonOperator> _ComparisonOperator;
        partial void OnComparisonOperatorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManComparisonOperator> value);
        partial void OnComparisonOperatorChanged();
        /// <summary>
        /// There are no comments for Property CreditMax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditMax")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CreditMax is required.")]
        public virtual decimal CreditMax
        {
            get
            {
                return this._CreditMax;
            }
            set
            {
                this.OnCreditMaxChanging(value);
                this._CreditMax = value;
                this.OnCreditMaxChanged();
                this.OnPropertyChanged("CreditMax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CreditMax;
        partial void OnCreditMaxChanging(decimal value);
        partial void OnCreditMaxChanged();
        /// <summary>
        /// There are no comments for Property RiskScoreGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RiskScoreGroupId")]
        public virtual string RiskScoreGroupId
        {
            get
            {
                return this._RiskScoreGroupId;
            }
            set
            {
                this.OnRiskScoreGroupIdChanging(value);
                this._RiskScoreGroupId = value;
                this.OnRiskScoreGroupIdChanged();
                this.OnPropertyChanged("RiskScoreGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RiskScoreGroupId;
        partial void OnRiskScoreGroupIdChanging(string value);
        partial void OnRiskScoreGroupIdChanged();
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
