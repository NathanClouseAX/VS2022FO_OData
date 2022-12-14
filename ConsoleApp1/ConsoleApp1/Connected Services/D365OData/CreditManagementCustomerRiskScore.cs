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
    /// There are no comments for CreditManagementCustomerRiskScoreSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditManagementCustomerRiskScoreSingle")]
    public partial class CreditManagementCustomerRiskScoreSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CreditManagementCustomerRiskScore>
    {
        /// <summary>
        /// Initialize a new CreditManagementCustomerRiskScoreSingle object.
        /// </summary>
        public CreditManagementCustomerRiskScoreSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CreditManagementCustomerRiskScoreSingle object.
        /// </summary>
        public CreditManagementCustomerRiskScoreSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CreditManagementCustomerRiskScoreSingle object.
        /// </summary>
        public CreditManagementCustomerRiskScoreSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CreditManagementCustomerRiskScore> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CreditManagementCustomerRiskScore in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CustAccount
    /// RiskScoreGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CustAccount", "RiskScoreGroupId")]
    [global::Microsoft.OData.Client.EntitySet("CreditManagementCustomerRiskScores")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditManagementCustomerRiskScore")]
    public partial class CreditManagementCustomerRiskScore : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CreditManagementCustomerRiskScore object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="custAccount">Initial value of CustAccount.</param>
        /// <param name="riskScoreGroupId">Initial value of RiskScoreGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CreditManagementCustomerRiskScore CreateCreditManagementCustomerRiskScore(string dataAreaId, string custAccount, string riskScoreGroupId)
        {
            CreditManagementCustomerRiskScore creditManagementCustomerRiskScore = new CreditManagementCustomerRiskScore();
            creditManagementCustomerRiskScore.DataAreaId = dataAreaId;
            creditManagementCustomerRiskScore.CustAccount = custAccount;
            creditManagementCustomerRiskScore.RiskScoreGroupId = riskScoreGroupId;
            return creditManagementCustomerRiskScore;
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
        /// There are no comments for Property CustAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustAccount is required.")]
        public virtual string CustAccount
        {
            get
            {
                return this._CustAccount;
            }
            set
            {
                this.OnCustAccountChanging(value);
                this._CustAccount = value;
                this.OnCustAccountChanged();
                this.OnPropertyChanged("CustAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustAccount;
        partial void OnCustAccountChanging(string value);
        partial void OnCustAccountChanged();
        /// <summary>
        /// There are no comments for Property RiskScoreGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RiskScoreGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RiskScoreGroupId is required.")]
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
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
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
