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
    /// There are no comments for PeriodChargeRuleLineCustomerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodChargeRuleLineCustomerSingle")]
    public partial class PeriodChargeRuleLineCustomerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodChargeRuleLineCustomer>
    {
        /// <summary>
        /// Initialize a new PeriodChargeRuleLineCustomerSingle object.
        /// </summary>
        public PeriodChargeRuleLineCustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PeriodChargeRuleLineCustomerSingle object.
        /// </summary>
        public PeriodChargeRuleLineCustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PeriodChargeRuleLineCustomerSingle object.
        /// </summary>
        public PeriodChargeRuleLineCustomerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodChargeRuleLineCustomer> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currency == null))
                {
                    this._Currency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currency"));
                }
                return this._Currency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currency;
        /// <summary>
        /// There are no comments for UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasure")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle UnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UnitOfMeasure == null))
                {
                    this._UnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("UnitOfMeasure"));
                }
                return this._UnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _UnitOfMeasure;
        /// <summary>
        /// There are no comments for ChargeRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeRule")]
        public virtual global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomerSingle ChargeRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ChargeRule == null))
                {
                    this._ChargeRule = new global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomerSingle(this.Context, GetPath("ChargeRule"));
                }
                return this._ChargeRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomerSingle _ChargeRule;
        /// <summary>
        /// There are no comments for RevenueAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueAccount")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle RevenueAccount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RevenueAccount == null))
                {
                    this._RevenueAccount = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("RevenueAccount"));
                }
                return this._RevenueAccount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _RevenueAccount;
        /// <summary>
        /// There are no comments for SalesCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesCharge")]
        public virtual global::Microsoft.Dynamics.DataEntities.SalesChargesSingle SalesCharge
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesCharge == null))
                {
                    this._SalesCharge = new global::Microsoft.Dynamics.DataEntities.SalesChargesSingle(this.Context, GetPath("SalesCharge"));
                }
                return this._SalesCharge;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SalesChargesSingle _SalesCharge;
    }
    /// <summary>
    /// There are no comments for PeriodChargeRuleLineCustomer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RuleName
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RuleName", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PeriodChargeRuleLineCustomers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodChargeRuleLineCustomer")]
    public partial class PeriodChargeRuleLineCustomer : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PeriodChargeRuleLineCustomer object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ruleName">Initial value of RuleName.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="quantityThreshold">Initial value of QuantityThreshold.</param>
        /// <param name="chargeAmount">Initial value of ChargeAmount.</param>
        /// <param name="monetaryThreshold">Initial value of MonetaryThreshold.</param>
        /// <param name="currency">Initial value of Currency.</param>
        /// <param name="salesCharge">Initial value of SalesCharge.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PeriodChargeRuleLineCustomer CreatePeriodChargeRuleLineCustomer(string dataAreaId, 
                    string ruleName, 
                    decimal lineNumber, 
                    decimal quantityThreshold, 
                    decimal chargeAmount, 
                    decimal monetaryThreshold, 
                    global::Microsoft.Dynamics.DataEntities.Currency currency, 
                    global::Microsoft.Dynamics.DataEntities.SalesCharges salesCharge)
        {
            PeriodChargeRuleLineCustomer periodChargeRuleLineCustomer = new PeriodChargeRuleLineCustomer();
            periodChargeRuleLineCustomer.DataAreaId = dataAreaId;
            periodChargeRuleLineCustomer.RuleName = ruleName;
            periodChargeRuleLineCustomer.LineNumber = lineNumber;
            periodChargeRuleLineCustomer.QuantityThreshold = quantityThreshold;
            periodChargeRuleLineCustomer.ChargeAmount = chargeAmount;
            periodChargeRuleLineCustomer.MonetaryThreshold = monetaryThreshold;
            if ((currency == null))
            {
                throw new global::System.ArgumentNullException("currency");
            }
            periodChargeRuleLineCustomer.Currency = currency;
            if ((salesCharge == null))
            {
                throw new global::System.ArgumentNullException("salesCharge");
            }
            periodChargeRuleLineCustomer.SalesCharge = salesCharge;
            return periodChargeRuleLineCustomer;
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
        /// There are no comments for Property RuleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleName is required.")]
        public virtual string RuleName
        {
            get
            {
                return this._RuleName;
            }
            set
            {
                this.OnRuleNameChanging(value);
                this._RuleName = value;
                this.OnRuleNameChanged();
                this.OnPropertyChanged("RuleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleName;
        partial void OnRuleNameChanging(string value);
        partial void OnRuleNameChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property DebitChargeAmountOnly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitChargeAmountOnly")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DebitChargeAmountOnly
        {
            get
            {
                return this._DebitChargeAmountOnly;
            }
            set
            {
                this.OnDebitChargeAmountOnlyChanging(value);
                this._DebitChargeAmountOnly = value;
                this.OnDebitChargeAmountOnlyChanged();
                this.OnPropertyChanged("DebitChargeAmountOnly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DebitChargeAmountOnly;
        partial void OnDebitChargeAmountOnlyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDebitChargeAmountOnlyChanged();
        /// <summary>
        /// There are no comments for Property RuleLineType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleLineType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupPeriodChargeRuleLineType> RuleLineType
        {
            get
            {
                return this._RuleLineType;
            }
            set
            {
                this.OnRuleLineTypeChanging(value);
                this._RuleLineType = value;
                this.OnRuleLineTypeChanged();
                this.OnPropertyChanged("RuleLineType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupPeriodChargeRuleLineType> _RuleLineType;
        partial void OnRuleLineTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupPeriodChargeRuleLineType> value);
        partial void OnRuleLineTypeChanged();
        /// <summary>
        /// There are no comments for Property DefaultRevenueAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultRevenueAccountDisplayValue")]
        public virtual string DefaultRevenueAccountDisplayValue
        {
            get
            {
                return this._DefaultRevenueAccountDisplayValue;
            }
            set
            {
                this.OnDefaultRevenueAccountDisplayValueChanging(value);
                this._DefaultRevenueAccountDisplayValue = value;
                this.OnDefaultRevenueAccountDisplayValueChanged();
                this.OnPropertyChanged("DefaultRevenueAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultRevenueAccountDisplayValue;
        partial void OnDefaultRevenueAccountDisplayValueChanging(string value);
        partial void OnDefaultRevenueAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SalesChargeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesChargeCode")]
        public virtual string SalesChargeCode
        {
            get
            {
                return this._SalesChargeCode;
            }
            set
            {
                this.OnSalesChargeCodeChanging(value);
                this._SalesChargeCode = value;
                this.OnSalesChargeCodeChanged();
                this.OnPropertyChanged("SalesChargeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesChargeCode;
        partial void OnSalesChargeCodeChanging(string value);
        partial void OnSalesChargeCodeChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitSymbol")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property QuantityThreshold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuantityThreshold")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuantityThreshold is required.")]
        public virtual decimal QuantityThreshold
        {
            get
            {
                return this._QuantityThreshold;
            }
            set
            {
                this.OnQuantityThresholdChanging(value);
                this._QuantityThreshold = value;
                this.OnQuantityThresholdChanged();
                this.OnPropertyChanged("QuantityThreshold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QuantityThreshold;
        partial void OnQuantityThresholdChanging(decimal value);
        partial void OnQuantityThresholdChanged();
        /// <summary>
        /// There are no comments for Property ChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargeAmount is required.")]
        public virtual decimal ChargeAmount
        {
            get
            {
                return this._ChargeAmount;
            }
            set
            {
                this.OnChargeAmountChanging(value);
                this._ChargeAmount = value;
                this.OnChargeAmountChanged();
                this.OnPropertyChanged("ChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargeAmount;
        partial void OnChargeAmountChanging(decimal value);
        partial void OnChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property RuleLineDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleLineDescription")]
        public virtual string RuleLineDescription
        {
            get
            {
                return this._RuleLineDescription;
            }
            set
            {
                this.OnRuleLineDescriptionChanging(value);
                this._RuleLineDescription = value;
                this.OnRuleLineDescriptionChanged();
                this.OnPropertyChanged("RuleLineDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleLineDescription;
        partial void OnRuleLineDescriptionChanging(string value);
        partial void OnRuleLineDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DebitQuantityOnly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitQuantityOnly")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DebitQuantityOnly
        {
            get
            {
                return this._DebitQuantityOnly;
            }
            set
            {
                this.OnDebitQuantityOnlyChanging(value);
                this._DebitQuantityOnly = value;
                this.OnDebitQuantityOnlyChanged();
                this.OnPropertyChanged("DebitQuantityOnly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DebitQuantityOnly;
        partial void OnDebitQuantityOnlyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDebitQuantityOnlyChanged();
        /// <summary>
        /// There are no comments for Property SalesCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesCurrencyCode")]
        public virtual string SalesCurrencyCode
        {
            get
            {
                return this._SalesCurrencyCode;
            }
            set
            {
                this.OnSalesCurrencyCodeChanging(value);
                this._SalesCurrencyCode = value;
                this.OnSalesCurrencyCodeChanged();
                this.OnPropertyChanged("SalesCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCurrencyCode;
        partial void OnSalesCurrencyCodeChanging(string value);
        partial void OnSalesCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ChargeAmountCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeAmountCurrencyCode")]
        public virtual string ChargeAmountCurrencyCode
        {
            get
            {
                return this._ChargeAmountCurrencyCode;
            }
            set
            {
                this.OnChargeAmountCurrencyCodeChanging(value);
                this._ChargeAmountCurrencyCode = value;
                this.OnChargeAmountCurrencyCodeChanged();
                this.OnPropertyChanged("ChargeAmountCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeAmountCurrencyCode;
        partial void OnChargeAmountCurrencyCodeChanging(string value);
        partial void OnChargeAmountCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property MonetaryThreshold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MonetaryThreshold")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MonetaryThreshold is required.")]
        public virtual decimal MonetaryThreshold
        {
            get
            {
                return this._MonetaryThreshold;
            }
            set
            {
                this.OnMonetaryThresholdChanging(value);
                this._MonetaryThreshold = value;
                this.OnMonetaryThresholdChanged();
                this.OnPropertyChanged("MonetaryThreshold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MonetaryThreshold;
        partial void OnMonetaryThresholdChanging(decimal value);
        partial void OnMonetaryThresholdChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Currency is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currency;
        partial void OnCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasure")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure UnitOfMeasure
        {
            get
            {
                return this._UnitOfMeasure;
            }
            set
            {
                this.OnUnitOfMeasureChanging(value);
                this._UnitOfMeasure = value;
                this.OnUnitOfMeasureChanged();
                this.OnPropertyChanged("UnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _UnitOfMeasure;
        partial void OnUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property ChargeRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeRule")]
        public virtual global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomer ChargeRule
        {
            get
            {
                return this._ChargeRule;
            }
            set
            {
                this.OnChargeRuleChanging(value);
                this._ChargeRule = value;
                this.OnChargeRuleChanged();
                this.OnPropertyChanged("ChargeRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomer _ChargeRule;
        partial void OnChargeRuleChanging(global::Microsoft.Dynamics.DataEntities.PeriodChargeRuleCustomer value);
        partial void OnChargeRuleChanged();
        /// <summary>
        /// There are no comments for Property RevenueAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueAccount")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination RevenueAccount
        {
            get
            {
                return this._RevenueAccount;
            }
            set
            {
                this.OnRevenueAccountChanging(value);
                this._RevenueAccount = value;
                this.OnRevenueAccountChanged();
                this.OnPropertyChanged("RevenueAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _RevenueAccount;
        partial void OnRevenueAccountChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnRevenueAccountChanged();
        /// <summary>
        /// There are no comments for Property SalesCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesCharge")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesCharge is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.SalesCharges SalesCharge
        {
            get
            {
                return this._SalesCharge;
            }
            set
            {
                this.OnSalesChargeChanging(value);
                this._SalesCharge = value;
                this.OnSalesChargeChanged();
                this.OnPropertyChanged("SalesCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SalesCharges _SalesCharge;
        partial void OnSalesChargeChanging(global::Microsoft.Dynamics.DataEntities.SalesCharges value);
        partial void OnSalesChargeChanged();
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