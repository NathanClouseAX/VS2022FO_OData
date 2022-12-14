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
    /// There are no comments for TradeAllowanceAgreementMerchandisingEventBillBackLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventBillBackLineSingle")]
    public partial class TradeAllowanceAgreementMerchandisingEventBillBackLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEventBillBackLine>
    {
        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventBillBackLineSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventBillBackLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventBillBackLineSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventBillBackLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventBillBackLineSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventBillBackLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEventBillBackLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventBillBack in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventBillBack")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle TradeAllowanceAgreementMerchandisingEventBillBack
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventBillBack == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventBillBack = new global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle(this.Context, GetPath("TradeAllowanceAgreementMerchandisingEventBillBack"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventBillBack;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle _TradeAllowanceAgreementMerchandisingEventBillBack;
        /// <summary>
        /// There are no comments for BillBackQuantityUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackQuantityUnitOfMeasure")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle BillBackQuantityUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BillBackQuantityUnitOfMeasure == null))
                {
                    this._BillBackQuantityUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("BillBackQuantityUnitOfMeasure"));
                }
                return this._BillBackQuantityUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _BillBackQuantityUnitOfMeasure;
        /// <summary>
        /// There are no comments for BillBackAmountCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackAmountCurrency")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle BillBackAmountCurrency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BillBackAmountCurrency == null))
                {
                    this._BillBackAmountCurrency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("BillBackAmountCurrency"));
                }
                return this._BillBackAmountCurrency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _BillBackAmountCurrency;
    }
    /// <summary>
    /// There are no comments for TradeAllowanceAgreementMerchandisingEventBillBackLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TradeAllowanceAgreementId
    /// CustomerAccountNumber
    /// TradeAllowanceAgreementMerchandisingEventId
    /// TradeAllowanceAgreementMerchandisingEventBillBackId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAllowanceAgreementId", "CustomerAccountNumber", "TradeAllowanceAgreementMerchandisingEventId", "TradeAllowanceAgreementMerchandisingEventBillBackId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("TradeAllowanceAgreementMerchandisingEventBillBackLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventBillBackLine")]
    public partial class TradeAllowanceAgreementMerchandisingEventBillBackLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TradeAllowanceAgreementMerchandisingEventBillBackLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="tradeAllowanceAgreementId">Initial value of TradeAllowanceAgreementId.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        /// <param name="tradeAllowanceAgreementMerchandisingEventId">Initial value of TradeAllowanceAgreementMerchandisingEventId.</param>
        /// <param name="tradeAllowanceAgreementMerchandisingEventBillBackId">Initial value of TradeAllowanceAgreementMerchandisingEventBillBackId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="fromBillBackQuantity">Initial value of FromBillBackQuantity.</param>
        /// <param name="toBillBackQuantity">Initial value of ToBillBackQuantity.</param>
        /// <param name="billBackAmount">Initial value of BillBackAmount.</param>
        /// <param name="tradeAllowanceAgreementMerchandisingEventBillBack">Initial value of TradeAllowanceAgreementMerchandisingEventBillBack.</param>
        /// <param name="billBackQuantityUnitOfMeasure">Initial value of BillBackQuantityUnitOfMeasure.</param>
        /// <param name="billBackAmountCurrency">Initial value of BillBackAmountCurrency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TradeAllowanceAgreementMerchandisingEventBillBackLine CreateTradeAllowanceAgreementMerchandisingEventBillBackLine(string dataAreaId, 
                    string tradeAllowanceAgreementId, 
                    string customerAccountNumber, 
                    string tradeAllowanceAgreementMerchandisingEventId, 
                    string tradeAllowanceAgreementMerchandisingEventBillBackId, 
                    decimal lineNumber, 
                    decimal fromBillBackQuantity, 
                    decimal toBillBackQuantity, 
                    decimal billBackAmount, 
                    global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack tradeAllowanceAgreementMerchandisingEventBillBack, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure billBackQuantityUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.Currency billBackAmountCurrency)
        {
            TradeAllowanceAgreementMerchandisingEventBillBackLine tradeAllowanceAgreementMerchandisingEventBillBackLine = new TradeAllowanceAgreementMerchandisingEventBillBackLine();
            tradeAllowanceAgreementMerchandisingEventBillBackLine.DataAreaId = dataAreaId;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.TradeAllowanceAgreementId = tradeAllowanceAgreementId;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.CustomerAccountNumber = customerAccountNumber;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.TradeAllowanceAgreementMerchandisingEventId = tradeAllowanceAgreementMerchandisingEventId;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.TradeAllowanceAgreementMerchandisingEventBillBackId = tradeAllowanceAgreementMerchandisingEventBillBackId;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.LineNumber = lineNumber;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.FromBillBackQuantity = fromBillBackQuantity;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.ToBillBackQuantity = toBillBackQuantity;
            tradeAllowanceAgreementMerchandisingEventBillBackLine.BillBackAmount = billBackAmount;
            if ((tradeAllowanceAgreementMerchandisingEventBillBack == null))
            {
                throw new global::System.ArgumentNullException("tradeAllowanceAgreementMerchandisingEventBillBack");
            }
            tradeAllowanceAgreementMerchandisingEventBillBackLine.TradeAllowanceAgreementMerchandisingEventBillBack = tradeAllowanceAgreementMerchandisingEventBillBack;
            if ((billBackQuantityUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("billBackQuantityUnitOfMeasure");
            }
            tradeAllowanceAgreementMerchandisingEventBillBackLine.BillBackQuantityUnitOfMeasure = billBackQuantityUnitOfMeasure;
            if ((billBackAmountCurrency == null))
            {
                throw new global::System.ArgumentNullException("billBackAmountCurrency");
            }
            tradeAllowanceAgreementMerchandisingEventBillBackLine.BillBackAmountCurrency = billBackAmountCurrency;
            return tradeAllowanceAgreementMerchandisingEventBillBackLine;
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
        /// There are no comments for Property TradeAllowanceAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAllowanceAgreementId is required.")]
        public virtual string TradeAllowanceAgreementId
        {
            get
            {
                return this._TradeAllowanceAgreementId;
            }
            set
            {
                this.OnTradeAllowanceAgreementIdChanging(value);
                this._TradeAllowanceAgreementId = value;
                this.OnTradeAllowanceAgreementIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementId;
        partial void OnTradeAllowanceAgreementIdChanging(string value);
        partial void OnTradeAllowanceAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccountNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerAccountNumber is required.")]
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
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAllowanceAgreementMerchandisingEventId is required.")]
        public virtual string TradeAllowanceAgreementMerchandisingEventId
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventId;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventIdChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventId = value;
                this.OnTradeAllowanceAgreementMerchandisingEventIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementMerchandisingEventId;
        partial void OnTradeAllowanceAgreementMerchandisingEventIdChanging(string value);
        partial void OnTradeAllowanceAgreementMerchandisingEventIdChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventBillBackId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventBillBackId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAllowanceAgreementMerchandisingEventBillBackId is required.")]
        public virtual string TradeAllowanceAgreementMerchandisingEventBillBackId
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventBillBackId;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackIdChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventBillBackId = value;
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventBillBackId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementMerchandisingEventBillBackId;
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackIdChanging(string value);
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackIdChanged();
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
        /// There are no comments for Property FromBillBackQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromBillBackQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromBillBackQuantity is required.")]
        public virtual decimal FromBillBackQuantity
        {
            get
            {
                return this._FromBillBackQuantity;
            }
            set
            {
                this.OnFromBillBackQuantityChanging(value);
                this._FromBillBackQuantity = value;
                this.OnFromBillBackQuantityChanged();
                this.OnPropertyChanged("FromBillBackQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromBillBackQuantity;
        partial void OnFromBillBackQuantityChanging(decimal value);
        partial void OnFromBillBackQuantityChanged();
        /// <summary>
        /// There are no comments for Property BillBackAmountCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackAmountCurrencyCode")]
        public virtual string BillBackAmountCurrencyCode
        {
            get
            {
                return this._BillBackAmountCurrencyCode;
            }
            set
            {
                this.OnBillBackAmountCurrencyCodeChanging(value);
                this._BillBackAmountCurrencyCode = value;
                this.OnBillBackAmountCurrencyCodeChanged();
                this.OnPropertyChanged("BillBackAmountCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillBackAmountCurrencyCode;
        partial void OnBillBackAmountCurrencyCodeChanging(string value);
        partial void OnBillBackAmountCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property BillBackQuantityUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackQuantityUnitSymbol")]
        public virtual string BillBackQuantityUnitSymbol
        {
            get
            {
                return this._BillBackQuantityUnitSymbol;
            }
            set
            {
                this.OnBillBackQuantityUnitSymbolChanging(value);
                this._BillBackQuantityUnitSymbol = value;
                this.OnBillBackQuantityUnitSymbolChanged();
                this.OnPropertyChanged("BillBackQuantityUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillBackQuantityUnitSymbol;
        partial void OnBillBackQuantityUnitSymbolChanging(string value);
        partial void OnBillBackQuantityUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property BillBackAmountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackAmountType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsRebateAmtType> BillBackAmountType
        {
            get
            {
                return this._BillBackAmountType;
            }
            set
            {
                this.OnBillBackAmountTypeChanging(value);
                this._BillBackAmountType = value;
                this.OnBillBackAmountTypeChanged();
                this.OnPropertyChanged("BillBackAmountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsRebateAmtType> _BillBackAmountType;
        partial void OnBillBackAmountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsRebateAmtType> value);
        partial void OnBillBackAmountTypeChanged();
        /// <summary>
        /// There are no comments for Property ToBillBackQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToBillBackQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToBillBackQuantity is required.")]
        public virtual decimal ToBillBackQuantity
        {
            get
            {
                return this._ToBillBackQuantity;
            }
            set
            {
                this.OnToBillBackQuantityChanging(value);
                this._ToBillBackQuantity = value;
                this.OnToBillBackQuantityChanged();
                this.OnPropertyChanged("ToBillBackQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToBillBackQuantity;
        partial void OnToBillBackQuantityChanging(decimal value);
        partial void OnToBillBackQuantityChanged();
        /// <summary>
        /// There are no comments for Property BillBackAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillBackAmount is required.")]
        public virtual decimal BillBackAmount
        {
            get
            {
                return this._BillBackAmount;
            }
            set
            {
                this.OnBillBackAmountChanging(value);
                this._BillBackAmount = value;
                this.OnBillBackAmountChanged();
                this.OnPropertyChanged("BillBackAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BillBackAmount;
        partial void OnBillBackAmountChanging(decimal value);
        partial void OnBillBackAmountChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventBillBack in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TradeAllowanceAgreementMerchandisingEventBillBack")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TradeAllowanceAgreementMerchandisingEventBillBack is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack TradeAllowanceAgreementMerchandisingEventBillBack
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventBillBack;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventBillBack = value;
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventBillBack");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack _TradeAllowanceAgreementMerchandisingEventBillBack;
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackChanging(global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack value);
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackChanged();
        /// <summary>
        /// There are no comments for Property BillBackQuantityUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackQuantityUnitOfMeasure")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillBackQuantityUnitOfMeasure is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure BillBackQuantityUnitOfMeasure
        {
            get
            {
                return this._BillBackQuantityUnitOfMeasure;
            }
            set
            {
                this.OnBillBackQuantityUnitOfMeasureChanging(value);
                this._BillBackQuantityUnitOfMeasure = value;
                this.OnBillBackQuantityUnitOfMeasureChanged();
                this.OnPropertyChanged("BillBackQuantityUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _BillBackQuantityUnitOfMeasure;
        partial void OnBillBackQuantityUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnBillBackQuantityUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property BillBackAmountCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillBackAmountCurrency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillBackAmountCurrency is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency BillBackAmountCurrency
        {
            get
            {
                return this._BillBackAmountCurrency;
            }
            set
            {
                this.OnBillBackAmountCurrencyChanging(value);
                this._BillBackAmountCurrency = value;
                this.OnBillBackAmountCurrencyChanged();
                this.OnPropertyChanged("BillBackAmountCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _BillBackAmountCurrency;
        partial void OnBillBackAmountCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnBillBackAmountCurrencyChanged();
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
