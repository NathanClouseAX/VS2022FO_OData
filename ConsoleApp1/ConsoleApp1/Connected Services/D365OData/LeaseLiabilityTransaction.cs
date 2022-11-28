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
    /// There are no comments for LeaseLiabilityTransactionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaseLiabilityTransactionSingle")]
    public partial class LeaseLiabilityTransactionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseLiabilityTransaction>
    {
        /// <summary>
        /// Initialize a new LeaseLiabilityTransactionSingle object.
        /// </summary>
        public LeaseLiabilityTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseLiabilityTransactionSingle object.
        /// </summary>
        public LeaseLiabilityTransactionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseLiabilityTransactionSingle object.
        /// </summary>
        public LeaseLiabilityTransactionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseLiabilityTransaction> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LeaseLiabilityTransaction in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Voucher
    /// TransactionType
    /// BookId
    /// Account
    /// Amount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Voucher", "TransactionType", "BookId", "Account", "Amount")]
    [global::Microsoft.OData.Client.EntitySet("LeaseLiabilityTransactions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaseLiabilityTransaction")]
    public partial class LeaseLiabilityTransaction : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseLiabilityTransaction object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="voucher">Initial value of Voucher.</param>
        /// <param name="bookId">Initial value of BookId.</param>
        /// <param name="account">Initial value of Account.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseLiabilityTransaction CreateLeaseLiabilityTransaction(string dataAreaId, 
                    string voucher, 
                    string bookId, 
                    string account, 
                    decimal amount, 
                    global::System.DateTimeOffset transactionDate)
        {
            LeaseLiabilityTransaction leaseLiabilityTransaction = new LeaseLiabilityTransaction();
            leaseLiabilityTransaction.DataAreaId = dataAreaId;
            leaseLiabilityTransaction.Voucher = voucher;
            leaseLiabilityTransaction.BookId = bookId;
            leaseLiabilityTransaction.Account = account;
            leaseLiabilityTransaction.Amount = amount;
            leaseLiabilityTransaction.TransactionDate = transactionDate;
            return leaseLiabilityTransaction;
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
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Voucher")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Voucher is required.")]
        public virtual string Voucher
        {
            get
            {
                return this._Voucher;
            }
            set
            {
                this.OnVoucherChanging(value);
                this._Voucher = value;
                this.OnVoucherChanged();
                this.OnPropertyChanged("Voucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Voucher;
        partial void OnVoucherChanging(string value);
        partial void OnVoucherChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerTransType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property BookId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BookId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BookId is required.")]
        public virtual string BookId
        {
            get
            {
                return this._BookId;
            }
            set
            {
                this.OnBookIdChanging(value);
                this._BookId = value;
                this.OnBookIdChanged();
                this.OnPropertyChanged("BookId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BookId;
        partial void OnBookIdChanging(string value);
        partial void OnBookIdChanged();
        /// <summary>
        /// There are no comments for Property Account in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Account")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Account is required.")]
        public virtual string Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                this.OnAccountChanging(value);
                this._Account = value;
                this.OnAccountChanged();
                this.OnPropertyChanged("Account");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Account;
        partial void OnAccountChanging(string value);
        partial void OnAccountChanged();
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
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
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
