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
    /// There are no comments for OpenPurchaseTotalDiscountJournalLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenPurchaseTotalDiscountJournalLineSingle")]
    public partial class OpenPurchaseTotalDiscountJournalLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OpenPurchaseTotalDiscountJournalLine>
    {
        /// <summary>
        /// Initialize a new OpenPurchaseTotalDiscountJournalLineSingle object.
        /// </summary>
        public OpenPurchaseTotalDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OpenPurchaseTotalDiscountJournalLineSingle object.
        /// </summary>
        public OpenPurchaseTotalDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OpenPurchaseTotalDiscountJournalLineSingle object.
        /// </summary>
        public OpenPurchaseTotalDiscountJournalLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OpenPurchaseTotalDiscountJournalLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TotalDiscountVendorGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalDiscountVendorGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroupSingle TotalDiscountVendorGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TotalDiscountVendorGroup == null))
                {
                    this._TotalDiscountVendorGroup = new global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroupSingle(this.Context, GetPath("TotalDiscountVendorGroup"));
                }
                return this._TotalDiscountVendorGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroupSingle _TotalDiscountVendorGroup;
        /// <summary>
        /// There are no comments for VendorV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2Single VendorV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorV2 == null))
                {
                    this._VendorV2 = new global::Microsoft.Dynamics.DataEntities.VendorV2Single(this.Context, GetPath("VendorV2"));
                }
                return this._VendorV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2Single _VendorV2;
    }
    /// <summary>
    /// There are no comments for OpenPurchaseTotalDiscountJournalLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TradeAgreementJournalNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAgreementJournalNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("OpenPurchaseTotalDiscountJournalLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenPurchaseTotalDiscountJournalLine")]
    public partial class OpenPurchaseTotalDiscountJournalLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OpenPurchaseTotalDiscountJournalLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="tradeAgreementJournalNumber">Initial value of TradeAgreementJournalNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="discountAmount">Initial value of DiscountAmount.</param>
        /// <param name="discountApplicableFromDate">Initial value of DiscountApplicableFromDate.</param>
        /// <param name="discountPercentage2">Initial value of DiscountPercentage2.</param>
        /// <param name="discountPercentage1">Initial value of DiscountPercentage1.</param>
        /// <param name="discountApplicableToDate">Initial value of DiscountApplicableToDate.</param>
        /// <param name="toOrderSubtotalAmount">Initial value of ToOrderSubtotalAmount.</param>
        /// <param name="fromOrderSubtotalAmount">Initial value of FromOrderSubtotalAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OpenPurchaseTotalDiscountJournalLine CreateOpenPurchaseTotalDiscountJournalLine(string dataAreaId, 
                    string tradeAgreementJournalNumber, 
                    decimal lineNumber, 
                    decimal discountAmount, 
                    global::System.DateTimeOffset discountApplicableFromDate, 
                    decimal discountPercentage2, 
                    decimal discountPercentage1, 
                    global::System.DateTimeOffset discountApplicableToDate, 
                    decimal toOrderSubtotalAmount, 
                    decimal fromOrderSubtotalAmount)
        {
            OpenPurchaseTotalDiscountJournalLine openPurchaseTotalDiscountJournalLine = new OpenPurchaseTotalDiscountJournalLine();
            openPurchaseTotalDiscountJournalLine.DataAreaId = dataAreaId;
            openPurchaseTotalDiscountJournalLine.TradeAgreementJournalNumber = tradeAgreementJournalNumber;
            openPurchaseTotalDiscountJournalLine.LineNumber = lineNumber;
            openPurchaseTotalDiscountJournalLine.DiscountAmount = discountAmount;
            openPurchaseTotalDiscountJournalLine.DiscountApplicableFromDate = discountApplicableFromDate;
            openPurchaseTotalDiscountJournalLine.DiscountPercentage2 = discountPercentage2;
            openPurchaseTotalDiscountJournalLine.DiscountPercentage1 = discountPercentage1;
            openPurchaseTotalDiscountJournalLine.DiscountApplicableToDate = discountApplicableToDate;
            openPurchaseTotalDiscountJournalLine.ToOrderSubtotalAmount = toOrderSubtotalAmount;
            openPurchaseTotalDiscountJournalLine.FromOrderSubtotalAmount = fromOrderSubtotalAmount;
            return openPurchaseTotalDiscountJournalLine;
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
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccountNumber")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
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
        /// There are no comments for Property TotalDiscountVendorGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalDiscountVendorGroupCode")]
        public virtual string TotalDiscountVendorGroupCode
        {
            get
            {
                return this._TotalDiscountVendorGroupCode;
            }
            set
            {
                this.OnTotalDiscountVendorGroupCodeChanging(value);
                this._TotalDiscountVendorGroupCode = value;
                this.OnTotalDiscountVendorGroupCodeChanged();
                this.OnPropertyChanged("TotalDiscountVendorGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalDiscountVendorGroupCode;
        partial void OnTotalDiscountVendorGroupCodeChanging(string value);
        partial void OnTotalDiscountVendorGroupCodeChanged();
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
        /// There are no comments for Property ToOrderSubtotalAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToOrderSubtotalAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToOrderSubtotalAmount is required.")]
        public virtual decimal ToOrderSubtotalAmount
        {
            get
            {
                return this._ToOrderSubtotalAmount;
            }
            set
            {
                this.OnToOrderSubtotalAmountChanging(value);
                this._ToOrderSubtotalAmount = value;
                this.OnToOrderSubtotalAmountChanged();
                this.OnPropertyChanged("ToOrderSubtotalAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToOrderSubtotalAmount;
        partial void OnToOrderSubtotalAmountChanging(decimal value);
        partial void OnToOrderSubtotalAmountChanged();
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
        /// There are no comments for Property FromOrderSubtotalAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromOrderSubtotalAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromOrderSubtotalAmount is required.")]
        public virtual decimal FromOrderSubtotalAmount
        {
            get
            {
                return this._FromOrderSubtotalAmount;
            }
            set
            {
                this.OnFromOrderSubtotalAmountChanging(value);
                this._FromOrderSubtotalAmount = value;
                this.OnFromOrderSubtotalAmountChanged();
                this.OnPropertyChanged("FromOrderSubtotalAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromOrderSubtotalAmount;
        partial void OnFromOrderSubtotalAmountChanging(decimal value);
        partial void OnFromOrderSubtotalAmountChanged();
        /// <summary>
        /// There are no comments for Property TotalDiscountVendorGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalDiscountVendorGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroup TotalDiscountVendorGroup
        {
            get
            {
                return this._TotalDiscountVendorGroup;
            }
            set
            {
                this.OnTotalDiscountVendorGroupChanging(value);
                this._TotalDiscountVendorGroup = value;
                this.OnTotalDiscountVendorGroupChanged();
                this.OnPropertyChanged("TotalDiscountVendorGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroup _TotalDiscountVendorGroup;
        partial void OnTotalDiscountVendorGroupChanging(global::Microsoft.Dynamics.DataEntities.TotalDiscountVendorGroup value);
        partial void OnTotalDiscountVendorGroupChanged();
        /// <summary>
        /// There are no comments for Property VendorV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2 VendorV2
        {
            get
            {
                return this._VendorV2;
            }
            set
            {
                this.OnVendorV2Changing(value);
                this._VendorV2 = value;
                this.OnVendorV2Changed();
                this.OnPropertyChanged("VendorV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2 _VendorV2;
        partial void OnVendorV2Changing(global::Microsoft.Dynamics.DataEntities.VendorV2 value);
        partial void OnVendorV2Changed();
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
