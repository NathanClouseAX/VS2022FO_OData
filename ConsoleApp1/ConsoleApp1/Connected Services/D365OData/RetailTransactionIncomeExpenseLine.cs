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
    /// There are no comments for RetailTransactionIncomeExpenseLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTransactionIncomeExpenseLineSingle")]
    public partial class RetailTransactionIncomeExpenseLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionIncomeExpenseLine>
    {
        /// <summary>
        /// Initialize a new RetailTransactionIncomeExpenseLineSingle object.
        /// </summary>
        public RetailTransactionIncomeExpenseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionIncomeExpenseLineSingle object.
        /// </summary>
        public RetailTransactionIncomeExpenseLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionIncomeExpenseLineSingle object.
        /// </summary>
        public RetailTransactionIncomeExpenseLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionIncomeExpenseLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTransactionIncomeExpenseLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Terminal
    /// TransactionNumber
    /// LineNumber
    /// OperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Terminal", "TransactionNumber", "LineNumber", "OperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionIncomeExpenseLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTransactionIncomeExpenseLine")]
    public partial class RetailTransactionIncomeExpenseLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionIncomeExpenseLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        /// <param name="transactionNumber">Initial value of TransactionNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="transactionTime">Initial value of TransactionTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionIncomeExpenseLine CreateRetailTransactionIncomeExpenseLine(string dataAreaId, 
                    string terminal, 
                    string transactionNumber, 
                    decimal lineNumber, 
                    string operatingUnitNumber, 
                    global::System.DateTimeOffset transactionDate, 
                    decimal amount, 
                    int transactionTime)
        {
            RetailTransactionIncomeExpenseLine retailTransactionIncomeExpenseLine = new RetailTransactionIncomeExpenseLine();
            retailTransactionIncomeExpenseLine.DataAreaId = dataAreaId;
            retailTransactionIncomeExpenseLine.Terminal = terminal;
            retailTransactionIncomeExpenseLine.TransactionNumber = transactionNumber;
            retailTransactionIncomeExpenseLine.LineNumber = lineNumber;
            retailTransactionIncomeExpenseLine.OperatingUnitNumber = operatingUnitNumber;
            retailTransactionIncomeExpenseLine.TransactionDate = transactionDate;
            retailTransactionIncomeExpenseLine.Amount = amount;
            retailTransactionIncomeExpenseLine.TransactionTime = transactionTime;
            return retailTransactionIncomeExpenseLine;
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
        /// There are no comments for Property Terminal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Terminal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Terminal is required.")]
        public virtual string Terminal
        {
            get
            {
                return this._Terminal;
            }
            set
            {
                this.OnTerminalChanging(value);
                this._Terminal = value;
                this.OnTerminalChanged();
                this.OnPropertyChanged("Terminal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Terminal;
        partial void OnTerminalChanging(string value);
        partial void OnTerminalChanged();
        /// <summary>
        /// There are no comments for Property TransactionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionNumber is required.")]
        public virtual string TransactionNumber
        {
            get
            {
                return this._TransactionNumber;
            }
            set
            {
                this.OnTransactionNumberChanging(value);
                this._TransactionNumber = value;
                this.OnTransactionNumberChanged();
                this.OnPropertyChanged("TransactionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionNumber;
        partial void OnTransactionNumberChanging(string value);
        partial void OnTransactionNumberChanged();
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
        /// There are no comments for Property ReceiptNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptNumber")]
        public virtual string ReceiptNumber
        {
            get
            {
                return this._ReceiptNumber;
            }
            set
            {
                this.OnReceiptNumberChanging(value);
                this._ReceiptNumber = value;
                this.OnReceiptNumberChanged();
                this.OnPropertyChanged("ReceiptNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceiptNumber;
        partial void OnReceiptNumberChanging(string value);
        partial void OnReceiptNumberChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailIncomeExpense> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property TransactionStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEntryStatus> TransactionStatus
        {
            get
            {
                return this._TransactionStatus;
            }
            set
            {
                this.OnTransactionStatusChanging(value);
                this._TransactionStatus = value;
                this.OnTransactionStatusChanged();
                this.OnPropertyChanged("TransactionStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEntryStatus> _TransactionStatus;
        partial void OnTransactionStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEntryStatus> value);
        partial void OnTransactionStatusChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property TransactionTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionTime is required.")]
        public virtual int TransactionTime
        {
            get
            {
                return this._TransactionTime;
            }
            set
            {
                this.OnTransactionTimeChanging(value);
                this._TransactionTime = value;
                this.OnTransactionTimeChanged();
                this.OnPropertyChanged("TransactionTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TransactionTime;
        partial void OnTransactionTimeChanging(int value);
        partial void OnTransactionTimeChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
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