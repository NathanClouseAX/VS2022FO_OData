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
    /// There are no comments for CurrencyIndexTransSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyIndexTransSingle")]
    public partial class CurrencyIndexTransSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyIndexTrans>
    {
        /// <summary>
        /// Initialize a new CurrencyIndexTransSingle object.
        /// </summary>
        public CurrencyIndexTransSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CurrencyIndexTransSingle object.
        /// </summary>
        public CurrencyIndexTransSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CurrencyIndexTransSingle object.
        /// </summary>
        public CurrencyIndexTransSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyIndexTrans> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CurrencyIndexTrans in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RuleGroup
    /// InflationIndex
    /// FromDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RuleGroup", "InflationIndex", "FromDate")]
    [global::Microsoft.OData.Client.EntitySet("CurrencyIndexTrans")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyIndexTrans")]
    public partial class CurrencyIndexTrans : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CurrencyIndexTrans object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ruleGroup">Initial value of RuleGroup.</param>
        /// <param name="inflationIndex">Initial value of InflationIndex.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CurrencyIndexTrans CreateCurrencyIndexTrans(string dataAreaId, string ruleGroup, string inflationIndex, global::System.DateTimeOffset fromDate, decimal exchangeRate)
        {
            CurrencyIndexTrans currencyIndexTrans = new CurrencyIndexTrans();
            currencyIndexTrans.DataAreaId = dataAreaId;
            currencyIndexTrans.RuleGroup = ruleGroup;
            currencyIndexTrans.InflationIndex = inflationIndex;
            currencyIndexTrans.FromDate = fromDate;
            currencyIndexTrans.ExchangeRate = exchangeRate;
            return currencyIndexTrans;
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
        /// There are no comments for Property RuleGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleGroup is required.")]
        public virtual string RuleGroup
        {
            get
            {
                return this._RuleGroup;
            }
            set
            {
                this.OnRuleGroupChanging(value);
                this._RuleGroup = value;
                this.OnRuleGroupChanged();
                this.OnPropertyChanged("RuleGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleGroup;
        partial void OnRuleGroupChanging(string value);
        partial void OnRuleGroupChanged();
        /// <summary>
        /// There are no comments for Property InflationIndex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InflationIndex")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InflationIndex is required.")]
        public virtual string InflationIndex
        {
            get
            {
                return this._InflationIndex;
            }
            set
            {
                this.OnInflationIndexChanging(value);
                this._InflationIndex = value;
                this.OnInflationIndexChanged();
                this.OnPropertyChanged("InflationIndex");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InflationIndex;
        partial void OnInflationIndexChanging(string value);
        partial void OnInflationIndexChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromDate is required.")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeRate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExchangeRate is required.")]
        public virtual decimal ExchangeRate
        {
            get
            {
                return this._ExchangeRate;
            }
            set
            {
                this.OnExchangeRateChanging(value);
                this._ExchangeRate = value;
                this.OnExchangeRateChanged();
                this.OnPropertyChanged("ExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRate;
        partial void OnExchangeRateChanging(decimal value);
        partial void OnExchangeRateChanged();
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
