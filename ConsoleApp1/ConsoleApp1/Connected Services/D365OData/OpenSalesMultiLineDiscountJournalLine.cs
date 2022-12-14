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
    /// There are no comments for OpenSalesMultiLineDiscountJournalLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenSalesMultiLineDiscountJournalLineSingle")]
    public partial class OpenSalesMultiLineDiscountJournalLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OpenSalesMultiLineDiscountJournalLine>
    {
        /// <summary>
        /// Initialize a new OpenSalesMultiLineDiscountJournalLineSingle object.
        /// </summary>
        public OpenSalesMultiLineDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OpenSalesMultiLineDiscountJournalLineSingle object.
        /// </summary>
        public OpenSalesMultiLineDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OpenSalesMultiLineDiscountJournalLineSingle object.
        /// </summary>
        public OpenSalesMultiLineDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OpenSalesMultiLineDiscountJournalLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for MultilineDiscountProductGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MultilineDiscountProductGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroupSingle MultilineDiscountProductGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MultilineDiscountProductGroup == null))
                {
                    this._MultilineDiscountProductGroup = new global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroupSingle(this.Context, GetPath("MultilineDiscountProductGroup"));
                }
                return this._MultilineDiscountProductGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroupSingle _MultilineDiscountProductGroup;
        /// <summary>
        /// There are no comments for MultilineDiscountCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MultilineDiscountCustomerGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroupSingle MultilineDiscountCustomerGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MultilineDiscountCustomerGroup == null))
                {
                    this._MultilineDiscountCustomerGroup = new global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroupSingle(this.Context, GetPath("MultilineDiscountCustomerGroup"));
                }
                return this._MultilineDiscountCustomerGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroupSingle _MultilineDiscountCustomerGroup;
        /// <summary>
        /// There are no comments for CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3Single CustomerV3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerV3 == null))
                {
                    this._CustomerV3 = new global::Microsoft.Dynamics.DataEntities.CustomerV3Single(this.Context, GetPath("CustomerV3"));
                }
                return this._CustomerV3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3Single _CustomerV3;
    }
    /// <summary>
    /// There are no comments for OpenSalesMultiLineDiscountJournalLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TradeAgreementJournalNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAgreementJournalNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("OpenSalesMultiLineDiscountJournalLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenSalesMultiLineDiscountJournalLine")]
    public partial class OpenSalesMultiLineDiscountJournalLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OpenSalesMultiLineDiscountJournalLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="tradeAgreementJournalNumber">Initial value of TradeAgreementJournalNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="discountPercentage2">Initial value of DiscountPercentage2.</param>
        /// <param name="discountPercentage1">Initial value of DiscountPercentage1.</param>
        /// <param name="toQuantity">Initial value of ToQuantity.</param>
        /// <param name="discountApplicableFromDate">Initial value of DiscountApplicableFromDate.</param>
        /// <param name="discountApplicableToDate">Initial value of DiscountApplicableToDate.</param>
        /// <param name="discountAmount">Initial value of DiscountAmount.</param>
        /// <param name="fromQuantity">Initial value of FromQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OpenSalesMultiLineDiscountJournalLine CreateOpenSalesMultiLineDiscountJournalLine(string dataAreaId, 
                    string tradeAgreementJournalNumber, 
                    decimal lineNumber, 
                    decimal discountPercentage2, 
                    decimal discountPercentage1, 
                    decimal toQuantity, 
                    global::System.DateTimeOffset discountApplicableFromDate, 
                    global::System.DateTimeOffset discountApplicableToDate, 
                    decimal discountAmount, 
                    decimal fromQuantity)
        {
            OpenSalesMultiLineDiscountJournalLine openSalesMultiLineDiscountJournalLine = new OpenSalesMultiLineDiscountJournalLine();
            openSalesMultiLineDiscountJournalLine.DataAreaId = dataAreaId;
            openSalesMultiLineDiscountJournalLine.TradeAgreementJournalNumber = tradeAgreementJournalNumber;
            openSalesMultiLineDiscountJournalLine.LineNumber = lineNumber;
            openSalesMultiLineDiscountJournalLine.DiscountPercentage2 = discountPercentage2;
            openSalesMultiLineDiscountJournalLine.DiscountPercentage1 = discountPercentage1;
            openSalesMultiLineDiscountJournalLine.ToQuantity = toQuantity;
            openSalesMultiLineDiscountJournalLine.DiscountApplicableFromDate = discountApplicableFromDate;
            openSalesMultiLineDiscountJournalLine.DiscountApplicableToDate = discountApplicableToDate;
            openSalesMultiLineDiscountJournalLine.DiscountAmount = discountAmount;
            openSalesMultiLineDiscountJournalLine.FromQuantity = fromQuantity;
            return openSalesMultiLineDiscountJournalLine;
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
        /// There are no comments for Property TradeAgreementJournalNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAgreementJournalNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAgreementJournalNumber is required.")]
        public virtual string TradeAgreementJournalNumber
        {
            get
            {
                return this._TradeAgreementJournalNumber;
            }
            set
            {
                this.OnTradeAgreementJournalNumberChanging(value);
                this._TradeAgreementJournalNumber = value;
                this.OnTradeAgreementJournalNumberChanged();
                this.OnPropertyChanged("TradeAgreementJournalNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAgreementJournalNumber;
        partial void OnTradeAgreementJournalNumberChanging(string value);
        partial void OnTradeAgreementJournalNumberChanged();
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
        /// There are no comments for Property WillSearchContinue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillSearchContinue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillSearchContinue
        {
            get
            {
                return this._WillSearchContinue;
            }
            set
            {
                this.OnWillSearchContinueChanging(value);
                this._WillSearchContinue = value;
                this.OnWillSearchContinueChanged();
                this.OnPropertyChanged("WillSearchContinue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillSearchContinue;
        partial void OnWillSearchContinueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillSearchContinueChanged();
        /// <summary>
        /// There are no comments for Property QuantityUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuantityUnitSymbol")]
        public virtual string QuantityUnitSymbol
        {
            get
            {
                return this._QuantityUnitSymbol;
            }
            set
            {
                this.OnQuantityUnitSymbolChanging(value);
                this._QuantityUnitSymbol = value;
                this.OnQuantityUnitSymbolChanged();
                this.OnPropertyChanged("QuantityUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QuantityUnitSymbol;
        partial void OnQuantityUnitSymbolChanging(string value);
        partial void OnQuantityUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property DiscountPercentage2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentage2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountPercentage2 is required.")]
        public virtual decimal DiscountPercentage2
        {
            get
            {
                return this._DiscountPercentage2;
            }
            set
            {
                this.OnDiscountPercentage2Changing(value);
                this._DiscountPercentage2 = value;
                this.OnDiscountPercentage2Changed();
                this.OnPropertyChanged("DiscountPercentage2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountPercentage2;
        partial void OnDiscountPercentage2Changing(decimal value);
        partial void OnDiscountPercentage2Changed();
        /// <summary>
        /// There are no comments for Property DiscountPercentage1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentage1")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountPercentage1 is required.")]
        public virtual decimal DiscountPercentage1
        {
            get
            {
                return this._DiscountPercentage1;
            }
            set
            {
                this.OnDiscountPercentage1Changing(value);
                this._DiscountPercentage1 = value;
                this.OnDiscountPercentage1Changed();
                this.OnPropertyChanged("DiscountPercentage1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountPercentage1;
        partial void OnDiscountPercentage1Changing(decimal value);
        partial void OnDiscountPercentage1Changed();
        /// <summary>
        /// There are no comments for Property ToQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToQuantity is required.")]
        public virtual decimal ToQuantity
        {
            get
            {
                return this._ToQuantity;
            }
            set
            {
                this.OnToQuantityChanging(value);
                this._ToQuantity = value;
                this.OnToQuantityChanged();
                this.OnPropertyChanged("ToQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToQuantity;
        partial void OnToQuantityChanging(decimal value);
        partial void OnToQuantityChanged();
        /// <summary>
        /// There are no comments for Property DiscountApplicableFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountApplicableFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountApplicableFromDate is required.")]
        public virtual global::System.DateTimeOffset DiscountApplicableFromDate
        {
            get
            {
                return this._DiscountApplicableFromDate;
            }
            set
            {
                this.OnDiscountApplicableFromDateChanging(value);
                this._DiscountApplicableFromDate = value;
                this.OnDiscountApplicableFromDateChanged();
                this.OnPropertyChanged("DiscountApplicableFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DiscountApplicableFromDate;
        partial void OnDiscountApplicableFromDateChanging(global::System.DateTimeOffset value);
        partial void OnDiscountApplicableFromDateChanged();
        /// <summary>
        /// There are no comments for Property MultiLineDiscountCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MultiLineDiscountCustomerGroupCode")]
        public virtual string MultiLineDiscountCustomerGroupCode
        {
            get
            {
                return this._MultiLineDiscountCustomerGroupCode;
            }
            set
            {
                this.OnMultiLineDiscountCustomerGroupCodeChanging(value);
                this._MultiLineDiscountCustomerGroupCode = value;
                this.OnMultiLineDiscountCustomerGroupCodeChanged();
                this.OnPropertyChanged("MultiLineDiscountCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MultiLineDiscountCustomerGroupCode;
        partial void OnMultiLineDiscountCustomerGroupCodeChanging(string value);
        partial void OnMultiLineDiscountCustomerGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property DiscountApplicableToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountApplicableToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountApplicableToDate is required.")]
        public virtual global::System.DateTimeOffset DiscountApplicableToDate
        {
            get
            {
                return this._DiscountApplicableToDate;
            }
            set
            {
                this.OnDiscountApplicableToDateChanging(value);
                this._DiscountApplicableToDate = value;
                this.OnDiscountApplicableToDateChanged();
                this.OnPropertyChanged("DiscountApplicableToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DiscountApplicableToDate;
        partial void OnDiscountApplicableToDateChanging(global::System.DateTimeOffset value);
        partial void OnDiscountApplicableToDateChanged();
        /// <summary>
        /// There are no comments for Property DiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountAmount is required.")]
        public virtual decimal DiscountAmount
        {
            get
            {
                return this._DiscountAmount;
            }
            set
            {
                this.OnDiscountAmountChanging(value);
                this._DiscountAmount = value;
                this.OnDiscountAmountChanged();
                this.OnPropertyChanged("DiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountAmount;
        partial void OnDiscountAmountChanging(decimal value);
        partial void OnDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property DiscountCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountCurrencyCode")]
        public virtual string DiscountCurrencyCode
        {
            get
            {
                return this._DiscountCurrencyCode;
            }
            set
            {
                this.OnDiscountCurrencyCodeChanging(value);
                this._DiscountCurrencyCode = value;
                this.OnDiscountCurrencyCodeChanged();
                this.OnPropertyChanged("DiscountCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountCurrencyCode;
        partial void OnDiscountCurrencyCodeChanging(string value);
        partial void OnDiscountCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property FromQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromQuantity is required.")]
        public virtual decimal FromQuantity
        {
            get
            {
                return this._FromQuantity;
            }
            set
            {
                this.OnFromQuantityChanging(value);
                this._FromQuantity = value;
                this.OnFromQuantityChanged();
                this.OnPropertyChanged("FromQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromQuantity;
        partial void OnFromQuantityChanging(decimal value);
        partial void OnFromQuantityChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccountNumber")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property MultiLineDiscountProductGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MultiLineDiscountProductGroupCode")]
        public virtual string MultiLineDiscountProductGroupCode
        {
            get
            {
                return this._MultiLineDiscountProductGroupCode;
            }
            set
            {
                this.OnMultiLineDiscountProductGroupCodeChanging(value);
                this._MultiLineDiscountProductGroupCode = value;
                this.OnMultiLineDiscountProductGroupCodeChanged();
                this.OnPropertyChanged("MultiLineDiscountProductGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MultiLineDiscountProductGroupCode;
        partial void OnMultiLineDiscountProductGroupCodeChanging(string value);
        partial void OnMultiLineDiscountProductGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property IsGenericCurrencySearchEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsGenericCurrencySearchEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsGenericCurrencySearchEnabled
        {
            get
            {
                return this._IsGenericCurrencySearchEnabled;
            }
            set
            {
                this.OnIsGenericCurrencySearchEnabledChanging(value);
                this._IsGenericCurrencySearchEnabled = value;
                this.OnIsGenericCurrencySearchEnabledChanged();
                this.OnPropertyChanged("IsGenericCurrencySearchEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsGenericCurrencySearchEnabled;
        partial void OnIsGenericCurrencySearchEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsGenericCurrencySearchEnabledChanged();
        /// <summary>
        /// There are no comments for Property ProcessingLog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessingLog")]
        public virtual string ProcessingLog
        {
            get
            {
                return this._ProcessingLog;
            }
            set
            {
                this.OnProcessingLogChanging(value);
                this._ProcessingLog = value;
                this.OnProcessingLogChanged();
                this.OnPropertyChanged("ProcessingLog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessingLog;
        partial void OnProcessingLogChanging(string value);
        partial void OnProcessingLogChanged();
        /// <summary>
        /// There are no comments for Property MultilineDiscountProductGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MultilineDiscountProductGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroup MultilineDiscountProductGroup
        {
            get
            {
                return this._MultilineDiscountProductGroup;
            }
            set
            {
                this.OnMultilineDiscountProductGroupChanging(value);
                this._MultilineDiscountProductGroup = value;
                this.OnMultilineDiscountProductGroupChanged();
                this.OnPropertyChanged("MultilineDiscountProductGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroup _MultilineDiscountProductGroup;
        partial void OnMultilineDiscountProductGroupChanging(global::Microsoft.Dynamics.DataEntities.MultilineDiscountProductGroup value);
        partial void OnMultilineDiscountProductGroupChanged();
        /// <summary>
        /// There are no comments for Property MultilineDiscountCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MultilineDiscountCustomerGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroup MultilineDiscountCustomerGroup
        {
            get
            {
                return this._MultilineDiscountCustomerGroup;
            }
            set
            {
                this.OnMultilineDiscountCustomerGroupChanging(value);
                this._MultilineDiscountCustomerGroup = value;
                this.OnMultilineDiscountCustomerGroupChanged();
                this.OnPropertyChanged("MultilineDiscountCustomerGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroup _MultilineDiscountCustomerGroup;
        partial void OnMultilineDiscountCustomerGroupChanging(global::Microsoft.Dynamics.DataEntities.MultilineDiscountCustomerGroup value);
        partial void OnMultilineDiscountCustomerGroupChanged();
        /// <summary>
        /// There are no comments for Property CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3 CustomerV3
        {
            get
            {
                return this._CustomerV3;
            }
            set
            {
                this.OnCustomerV3Changing(value);
                this._CustomerV3 = value;
                this.OnCustomerV3Changed();
                this.OnPropertyChanged("CustomerV3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3 _CustomerV3;
        partial void OnCustomerV3Changing(global::Microsoft.Dynamics.DataEntities.CustomerV3 value);
        partial void OnCustomerV3Changed();
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
