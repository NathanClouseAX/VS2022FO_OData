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
    /// There are no comments for CurrencyRuleGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyRuleGroupSingle")]
    public partial class CurrencyRuleGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyRuleGroup>
    {
        /// <summary>
        /// Initialize a new CurrencyRuleGroupSingle object.
        /// </summary>
        public CurrencyRuleGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CurrencyRuleGroupSingle object.
        /// </summary>
        public CurrencyRuleGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CurrencyRuleGroupSingle object.
        /// </summary>
        public CurrencyRuleGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyRuleGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CurrencyRuleGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CurrencyRuleGroupId
    /// RuleGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CurrencyRuleGroupId", "RuleGroupId")]
    [global::Microsoft.OData.Client.EntitySet("CurrencyRuleGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyRuleGroup")]
    public partial class CurrencyRuleGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CurrencyRuleGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="currencyRuleGroupId">Initial value of CurrencyRuleGroupId.</param>
        /// <param name="ruleGroupId">Initial value of RuleGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CurrencyRuleGroup CreateCurrencyRuleGroup(string dataAreaId, string currencyRuleGroupId, string ruleGroupId)
        {
            CurrencyRuleGroup currencyRuleGroup = new CurrencyRuleGroup();
            currencyRuleGroup.DataAreaId = dataAreaId;
            currencyRuleGroup.CurrencyRuleGroupId = currencyRuleGroupId;
            currencyRuleGroup.RuleGroupId = ruleGroupId;
            return currencyRuleGroup;
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
        /// There are no comments for Property CurrencyRuleGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyRuleGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrencyRuleGroupId is required.")]
        public virtual string CurrencyRuleGroupId
        {
            get
            {
                return this._CurrencyRuleGroupId;
            }
            set
            {
                this.OnCurrencyRuleGroupIdChanging(value);
                this._CurrencyRuleGroupId = value;
                this.OnCurrencyRuleGroupIdChanged();
                this.OnPropertyChanged("CurrencyRuleGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyRuleGroupId;
        partial void OnCurrencyRuleGroupIdChanging(string value);
        partial void OnCurrencyRuleGroupIdChanged();
        /// <summary>
        /// There are no comments for Property RuleGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleGroupId is required.")]
        public virtual string RuleGroupId
        {
            get
            {
                return this._RuleGroupId;
            }
            set
            {
                this.OnRuleGroupIdChanging(value);
                this._RuleGroupId = value;
                this.OnRuleGroupIdChanged();
                this.OnPropertyChanged("RuleGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleGroupId;
        partial void OnRuleGroupIdChanging(string value);
        partial void OnRuleGroupIdChanged();
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
