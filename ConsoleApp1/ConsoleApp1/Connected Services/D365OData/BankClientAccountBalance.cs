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
    /// There are no comments for BankClientAccountBalanceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankClientAccountBalanceSingle")]
    public partial class BankClientAccountBalanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BankClientAccountBalance>
    {
        /// <summary>
        /// Initialize a new BankClientAccountBalanceSingle object.
        /// </summary>
        public BankClientAccountBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BankClientAccountBalanceSingle object.
        /// </summary>
        public BankClientAccountBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BankClientAccountBalanceSingle object.
        /// </summary>
        public BankClientAccountBalanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BankClientAccountBalance> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BankClientAccountBalance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BankAccount
    /// RecordType
    /// FromDate
    /// ToDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BankAccount", "RecordType", "FromDate", "ToDate")]
    [global::Microsoft.OData.Client.EntitySet("BankClientAccountBalances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankClientAccountBalance")]
    public partial class BankClientAccountBalance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BankClientAccountBalance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="bankAccount">Initial value of BankAccount.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BankClientAccountBalance CreateBankClientAccountBalance(string dataAreaId, string bankAccount, global::System.DateTimeOffset fromDate, global::System.DateTimeOffset toDate, decimal amount)
        {
            BankClientAccountBalance bankClientAccountBalance = new BankClientAccountBalance();
            bankClientAccountBalance.DataAreaId = dataAreaId;
            bankClientAccountBalance.BankAccount = bankAccount;
            bankClientAccountBalance.FromDate = fromDate;
            bankClientAccountBalance.ToDate = toDate;
            bankClientAccountBalance.Amount = amount;
            return bankClientAccountBalance;
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
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BankAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BankAccount is required.")]
        public virtual string BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccount;
        partial void OnBankAccountChanging(string value);
        partial void OnBankAccountChanged();
        /// <summary>
        /// There are no comments for Property RecordType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankClientBalanceType_RU> RecordType
        {
            get
            {
                return this._RecordType;
            }
            set
            {
                this.OnRecordTypeChanging(value);
                this._RecordType = value;
                this.OnRecordTypeChanged();
                this.OnPropertyChanged("RecordType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankClientBalanceType_RU> _RecordType;
        partial void OnRecordTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BankClientBalanceType_RU> value);
        partial void OnRecordTypeChanged();
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
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToDate is required.")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
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
