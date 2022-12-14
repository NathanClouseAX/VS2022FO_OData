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
    /// There are no comments for CurrencyRevaluationAccountV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyRevaluationAccountV2Single")]
    public partial class CurrencyRevaluationAccountV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyRevaluationAccountV2>
    {
        /// <summary>
        /// Initialize a new CurrencyRevaluationAccountV2Single object.
        /// </summary>
        public CurrencyRevaluationAccountV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CurrencyRevaluationAccountV2Single object.
        /// </summary>
        public CurrencyRevaluationAccountV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CurrencyRevaluationAccountV2Single object.
        /// </summary>
        public CurrencyRevaluationAccountV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyRevaluationAccountV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for Currencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Currencies")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currencies
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currencies == null))
                {
                    this._Currencies = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currencies"));
                }
                return this._Currencies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currencies;
    }
    /// <summary>
    /// There are no comments for CurrencyRevaluationAccountV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CurrencyCode
    /// LegalEntityId
    /// Posting
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CurrencyCode", "LegalEntityId", "Posting")]
    [global::Microsoft.OData.Client.EntitySet("CurrencyRevaluationAccountsV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyRevaluationAccountV2")]
    public partial class CurrencyRevaluationAccountV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CurrencyRevaluationAccountV2 object.
        /// </summary>
        /// <param name="currencyCode">Initial value of CurrencyCode.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CurrencyRevaluationAccountV2 CreateCurrencyRevaluationAccountV2(string currencyCode, string legalEntityId)
        {
            CurrencyRevaluationAccountV2 currencyRevaluationAccountV2 = new CurrencyRevaluationAccountV2();
            currencyRevaluationAccountV2.CurrencyCode = currencyCode;
            currencyRevaluationAccountV2.LegalEntityId = legalEntityId;
            return currencyRevaluationAccountV2;
        }
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrencyCode is required.")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
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
        /// There are no comments for Property Posting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Posting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGainLossAccountType> Posting
        {
            get
            {
                return this._Posting;
            }
            set
            {
                this.OnPostingChanging(value);
                this._Posting = value;
                this.OnPostingChanged();
                this.OnPropertyChanged("Posting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGainLossAccountType> _Posting;
        partial void OnPostingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGainLossAccountType> value);
        partial void OnPostingChanged();
        /// <summary>
        /// There are no comments for Property MainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccountIdDisplayValue")]
        public virtual string MainAccountIdDisplayValue
        {
            get
            {
                return this._MainAccountIdDisplayValue;
            }
            set
            {
                this.OnMainAccountIdDisplayValueChanging(value);
                this._MainAccountIdDisplayValue = value;
                this.OnMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdDisplayValue;
        partial void OnMainAccountIdDisplayValueChanging(string value);
        partial void OnMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property RealizedTaxMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RealizedTaxMainAccountIdDisplayValue")]
        public virtual string RealizedTaxMainAccountIdDisplayValue
        {
            get
            {
                return this._RealizedTaxMainAccountIdDisplayValue;
            }
            set
            {
                this.OnRealizedTaxMainAccountIdDisplayValueChanging(value);
                this._RealizedTaxMainAccountIdDisplayValue = value;
                this.OnRealizedTaxMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("RealizedTaxMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RealizedTaxMainAccountIdDisplayValue;
        partial void OnRealizedTaxMainAccountIdDisplayValueChanging(string value);
        partial void OnRealizedTaxMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ExchAdjTaxableType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchAdjTaxableType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ExchAdjTaxableType_W> ExchAdjTaxableType
        {
            get
            {
                return this._ExchAdjTaxableType;
            }
            set
            {
                this.OnExchAdjTaxableTypeChanging(value);
                this._ExchAdjTaxableType = value;
                this.OnExchAdjTaxableTypeChanged();
                this.OnPropertyChanged("ExchAdjTaxableType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ExchAdjTaxableType_W> _ExchAdjTaxableType;
        partial void OnExchAdjTaxableTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ExchAdjTaxableType_W> value);
        partial void OnExchAdjTaxableTypeChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property Currencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currencies")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currencies
        {
            get
            {
                return this._Currencies;
            }
            set
            {
                this.OnCurrenciesChanging(value);
                this._Currencies = value;
                this.OnCurrenciesChanged();
                this.OnPropertyChanged("Currencies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currencies;
        partial void OnCurrenciesChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrenciesChanged();
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
