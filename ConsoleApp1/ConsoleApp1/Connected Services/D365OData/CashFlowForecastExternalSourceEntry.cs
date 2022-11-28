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
    /// There are no comments for CashFlowForecastExternalSourceEntrySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashFlowForecastExternalSourceEntrySingle")]
    public partial class CashFlowForecastExternalSourceEntrySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CashFlowForecastExternalSourceEntry>
    {
        /// <summary>
        /// Initialize a new CashFlowForecastExternalSourceEntrySingle object.
        /// </summary>
        public CashFlowForecastExternalSourceEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CashFlowForecastExternalSourceEntrySingle object.
        /// </summary>
        public CashFlowForecastExternalSourceEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CashFlowForecastExternalSourceEntrySingle object.
        /// </summary>
        public CashFlowForecastExternalSourceEntrySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CashFlowForecastExternalSourceEntry> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CurrencyCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCodes")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle CurrencyCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CurrencyCodes == null))
                {
                    this._CurrencyCodes = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("CurrencyCodes"));
                }
                return this._CurrencyCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _CurrencyCodes;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for CashFlowForecastExternalSourceEntry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EntryId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EntryId")]
    [global::Microsoft.OData.Client.EntitySet("CashFlowForecastExternalSourceEntries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashFlowForecastExternalSourceEntry")]
    public partial class CashFlowForecastExternalSourceEntry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CashFlowForecastExternalSourceEntry object.
        /// </summary>
        /// <param name="entryId">Initial value of EntryId.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="transactionAmount">Initial value of TransactionAmount.</param>
        /// <param name="currencyCodes">Initial value of CurrencyCodes.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CashFlowForecastExternalSourceEntry CreateCashFlowForecastExternalSourceEntry(string entryId, global::System.DateTimeOffset transactionDate, decimal transactionAmount, global::Microsoft.Dynamics.DataEntities.Currency currencyCodes)
        {
            CashFlowForecastExternalSourceEntry cashFlowForecastExternalSourceEntry = new CashFlowForecastExternalSourceEntry();
            cashFlowForecastExternalSourceEntry.EntryId = entryId;
            cashFlowForecastExternalSourceEntry.TransactionDate = transactionDate;
            cashFlowForecastExternalSourceEntry.TransactionAmount = transactionAmount;
            if ((currencyCodes == null))
            {
                throw new global::System.ArgumentNullException("currencyCodes");
            }
            cashFlowForecastExternalSourceEntry.CurrencyCodes = currencyCodes;
            return cashFlowForecastExternalSourceEntry;
        }
        /// <summary>
        /// There are no comments for Property EntryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntryId is required.")]
        public virtual string EntryId
        {
            get
            {
                return this._EntryId;
            }
            set
            {
                this.OnEntryIdChanging(value);
                this._EntryId = value;
                this.OnEntryIdChanged();
                this.OnPropertyChanged("EntryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntryId;
        partial void OnEntryIdChanging(string value);
        partial void OnEntryIdChanged();
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
        /// There are no comments for Property AccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountName")]
        public virtual string AccountName
        {
            get
            {
                return this._AccountName;
            }
            set
            {
                this.OnAccountNameChanging(value);
                this._AccountName = value;
                this.OnAccountNameChanged();
                this.OnPropertyChanged("AccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountName;
        partial void OnAccountNameChanging(string value);
        partial void OnAccountNameChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
        public virtual string DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentNumber;
        partial void OnDocumentNumberChanging(string value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCurrencyCode")]
        public virtual string TransactionCurrencyCode
        {
            get
            {
                return this._TransactionCurrencyCode;
            }
            set
            {
                this.OnTransactionCurrencyCodeChanging(value);
                this._TransactionCurrencyCode = value;
                this.OnTransactionCurrencyCodeChanged();
                this.OnPropertyChanged("TransactionCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCurrencyCode;
        partial void OnTransactionCurrencyCodeChanging(string value);
        partial void OnTransactionCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ExternalSourceLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalSourceLegalEntity")]
        public virtual string ExternalSourceLegalEntity
        {
            get
            {
                return this._ExternalSourceLegalEntity;
            }
            set
            {
                this.OnExternalSourceLegalEntityChanging(value);
                this._ExternalSourceLegalEntity = value;
                this.OnExternalSourceLegalEntityChanged();
                this.OnPropertyChanged("ExternalSourceLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalSourceLegalEntity;
        partial void OnExternalSourceLegalEntityChanging(string value);
        partial void OnExternalSourceLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property AccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountNumber")]
        public virtual string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this.OnAccountNumberChanging(value);
                this._AccountNumber = value;
                this.OnAccountNumberChanged();
                this.OnPropertyChanged("AccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumber;
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ExternalSourceName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalSourceName")]
        public virtual string ExternalSourceName
        {
            get
            {
                return this._ExternalSourceName;
            }
            set
            {
                this.OnExternalSourceNameChanging(value);
                this._ExternalSourceName = value;
                this.OnExternalSourceNameChanged();
                this.OnPropertyChanged("ExternalSourceName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalSourceName;
        partial void OnExternalSourceNameChanging(string value);
        partial void OnExternalSourceNameChanged();
        /// <summary>
        /// There are no comments for Property TransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionDate is required.")]
        public virtual global::System.DateTimeOffset TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this.OnTransactionDateChanging(value);
                this._TransactionDate = value;
                this.OnTransactionDateChanged();
                this.OnPropertyChanged("TransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransactionDate;
        partial void OnTransactionDateChanging(global::System.DateTimeOffset value);
        partial void OnTransactionDateChanged();
        /// <summary>
        /// There are no comments for Property TransactionAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionAmount is required.")]
        public virtual decimal TransactionAmount
        {
            get
            {
                return this._TransactionAmount;
            }
            set
            {
                this.OnTransactionAmountChanging(value);
                this._TransactionAmount = value;
                this.OnTransactionAmountChanged();
                this.OnPropertyChanged("TransactionAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TransactionAmount;
        partial void OnTransactionAmountChanging(decimal value);
        partial void OnTransactionAmountChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDimensionDisplayValue")]
        public virtual string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCodes")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrencyCodes is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency CurrencyCodes
        {
            get
            {
                return this._CurrencyCodes;
            }
            set
            {
                this.OnCurrencyCodesChanging(value);
                this._CurrencyCodes = value;
                this.OnCurrencyCodesChanged();
                this.OnPropertyChanged("CurrencyCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _CurrencyCodes;
        partial void OnCurrencyCodesChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyCodesChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
