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
    /// There are no comments for TransactionGTEChargeTaxLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionGTEChargeTaxLineSingle")]
    public partial class TransactionGTEChargeTaxLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionGTEChargeTaxLine>
    {
        /// <summary>
        /// Initialize a new TransactionGTEChargeTaxLineSingle object.
        /// </summary>
        public TransactionGTEChargeTaxLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransactionGTEChargeTaxLineSingle object.
        /// </summary>
        public TransactionGTEChargeTaxLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransactionGTEChargeTaxLineSingle object.
        /// </summary>
        public TransactionGTEChargeTaxLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionGTEChargeTaxLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransactionGTEChargeTaxLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OperatingUnitNumber
    /// TerminalId
    /// TransactionId
    /// SaleLineNum
    /// MarkupLineNum
    /// TaxComponent
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperatingUnitNumber", "TerminalId", "TransactionId", "SaleLineNum", "MarkupLineNum", "TaxComponent")]
    [global::Microsoft.OData.Client.EntitySet("TransactionGTEChargeTaxLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionGTEChargeTaxLine")]
    public partial class TransactionGTEChargeTaxLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransactionGTEChargeTaxLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="terminalId">Initial value of TerminalId.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="saleLineNum">Initial value of SaleLineNum.</param>
        /// <param name="markupLineNum">Initial value of MarkupLineNum.</param>
        /// <param name="taxComponent">Initial value of TaxComponent.</param>
        /// <param name="taxPercentage">Initial value of TaxPercentage.</param>
        /// <param name="taxAmount">Initial value of TaxAmount.</param>
        /// <param name="taxBasis">Initial value of TaxBasis.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransactionGTEChargeTaxLine CreateTransactionGTEChargeTaxLine(string dataAreaId, 
                    string operatingUnitNumber, 
                    string terminalId, 
                    string transactionId, 
                    decimal saleLineNum, 
                    decimal markupLineNum, 
                    string taxComponent, 
                    decimal taxPercentage, 
                    decimal taxAmount, 
                    decimal taxBasis)
        {
            TransactionGTEChargeTaxLine transactionGTEChargeTaxLine = new TransactionGTEChargeTaxLine();
            transactionGTEChargeTaxLine.DataAreaId = dataAreaId;
            transactionGTEChargeTaxLine.OperatingUnitNumber = operatingUnitNumber;
            transactionGTEChargeTaxLine.TerminalId = terminalId;
            transactionGTEChargeTaxLine.TransactionId = transactionId;
            transactionGTEChargeTaxLine.SaleLineNum = saleLineNum;
            transactionGTEChargeTaxLine.MarkupLineNum = markupLineNum;
            transactionGTEChargeTaxLine.TaxComponent = taxComponent;
            transactionGTEChargeTaxLine.TaxPercentage = taxPercentage;
            transactionGTEChargeTaxLine.TaxAmount = taxAmount;
            transactionGTEChargeTaxLine.TaxBasis = taxBasis;
            return transactionGTEChargeTaxLine;
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
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnitNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperatingUnitNumber is required.")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property TerminalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TerminalId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TerminalId is required.")]
        public virtual string TerminalId
        {
            get
            {
                return this._TerminalId;
            }
            set
            {
                this.OnTerminalIdChanging(value);
                this._TerminalId = value;
                this.OnTerminalIdChanged();
                this.OnPropertyChanged("TerminalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TerminalId;
        partial void OnTerminalIdChanging(string value);
        partial void OnTerminalIdChanged();
        /// <summary>
        /// There are no comments for Property TransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionId is required.")]
        public virtual string TransactionId
        {
            get
            {
                return this._TransactionId;
            }
            set
            {
                this.OnTransactionIdChanging(value);
                this._TransactionId = value;
                this.OnTransactionIdChanged();
                this.OnPropertyChanged("TransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionId;
        partial void OnTransactionIdChanging(string value);
        partial void OnTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property SaleLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SaleLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SaleLineNum is required.")]
        public virtual decimal SaleLineNum
        {
            get
            {
                return this._SaleLineNum;
            }
            set
            {
                this.OnSaleLineNumChanging(value);
                this._SaleLineNum = value;
                this.OnSaleLineNumChanged();
                this.OnPropertyChanged("SaleLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SaleLineNum;
        partial void OnSaleLineNumChanging(decimal value);
        partial void OnSaleLineNumChanged();
        /// <summary>
        /// There are no comments for Property MarkupLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MarkupLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MarkupLineNum is required.")]
        public virtual decimal MarkupLineNum
        {
            get
            {
                return this._MarkupLineNum;
            }
            set
            {
                this.OnMarkupLineNumChanging(value);
                this._MarkupLineNum = value;
                this.OnMarkupLineNumChanged();
                this.OnPropertyChanged("MarkupLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MarkupLineNum;
        partial void OnMarkupLineNumChanging(decimal value);
        partial void OnMarkupLineNumChanged();
        /// <summary>
        /// There are no comments for Property TaxComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxComponent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxComponent is required.")]
        public virtual string TaxComponent
        {
            get
            {
                return this._TaxComponent;
            }
            set
            {
                this.OnTaxComponentChanging(value);
                this._TaxComponent = value;
                this.OnTaxComponentChanged();
                this.OnPropertyChanged("TaxComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxComponent;
        partial void OnTaxComponentChanging(string value);
        partial void OnTaxComponentChanged();
        /// <summary>
        /// There are no comments for Property TaxPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxPercentage is required.")]
        public virtual decimal TaxPercentage
        {
            get
            {
                return this._TaxPercentage;
            }
            set
            {
                this.OnTaxPercentageChanging(value);
                this._TaxPercentage = value;
                this.OnTaxPercentageChanged();
                this.OnPropertyChanged("TaxPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxPercentage;
        partial void OnTaxPercentageChanging(decimal value);
        partial void OnTaxPercentageChanged();
        /// <summary>
        /// There are no comments for Property IsIncludedInPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsIncludedInPrice")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsIncludedInPrice
        {
            get
            {
                return this._IsIncludedInPrice;
            }
            set
            {
                this.OnIsIncludedInPriceChanging(value);
                this._IsIncludedInPrice = value;
                this.OnIsIncludedInPriceChanged();
                this.OnPropertyChanged("IsIncludedInPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsIncludedInPrice;
        partial void OnIsIncludedInPriceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsIncludedInPriceChanged();
        /// <summary>
        /// There are no comments for Property TaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxAmount is required.")]
        public virtual decimal TaxAmount
        {
            get
            {
                return this._TaxAmount;
            }
            set
            {
                this.OnTaxAmountChanging(value);
                this._TaxAmount = value;
                this.OnTaxAmountChanged();
                this.OnPropertyChanged("TaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxAmount;
        partial void OnTaxAmountChanging(decimal value);
        partial void OnTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property TaxBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxBasis")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxBasis is required.")]
        public virtual decimal TaxBasis
        {
            get
            {
                return this._TaxBasis;
            }
            set
            {
                this.OnTaxBasisChanging(value);
                this._TaxBasis = value;
                this.OnTaxBasisChanged();
                this.OnPropertyChanged("TaxBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxBasis;
        partial void OnTaxBasisChanging(decimal value);
        partial void OnTaxBasisChanged();
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
