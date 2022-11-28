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
    /// There are no comments for LedgerTransSettlementAccountSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerTransSettlementAccountSingle")]
    public partial class LedgerTransSettlementAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerTransSettlementAccount>
    {
        /// <summary>
        /// Initialize a new LedgerTransSettlementAccountSingle object.
        /// </summary>
        public LedgerTransSettlementAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerTransSettlementAccountSingle object.
        /// </summary>
        public LedgerTransSettlementAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerTransSettlementAccountSingle object.
        /// </summary>
        public LedgerTransSettlementAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerTransSettlementAccount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerTransSettlementAccountsMainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerTransSettlementAccountsMainAccountEntityRole")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccountSingle LedgerTransSettlementAccountsMainAccountEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerTransSettlementAccountsMainAccountEntityRole == null))
                {
                    this._LedgerTransSettlementAccountsMainAccountEntityRole = new global::Microsoft.Dynamics.DataEntities.MainAccountSingle(this.Context, GetPath("LedgerTransSettlementAccountsMainAccountEntityRole"));
                }
                return this._LedgerTransSettlementAccountsMainAccountEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccountSingle _LedgerTransSettlementAccountsMainAccountEntityRole;
    }
    /// <summary>
    /// There are no comments for LedgerTransSettlementAccount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MainAccountId
    /// ChartOfAccounts
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MainAccountId", "ChartOfAccounts")]
    [global::Microsoft.OData.Client.EntitySet("LedgerTransSettlementAccounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerTransSettlementAccount")]
    public partial class LedgerTransSettlementAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerTransSettlementAccount object.
        /// </summary>
        /// <param name="mainAccountId">Initial value of MainAccountId.</param>
        /// <param name="chartOfAccounts">Initial value of ChartOfAccounts.</param>
        /// <param name="ledgerTransSettlementAccountsMainAccountEntityRole">Initial value of LedgerTransSettlementAccountsMainAccountEntityRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerTransSettlementAccount CreateLedgerTransSettlementAccount(string mainAccountId, string chartOfAccounts, global::Microsoft.Dynamics.DataEntities.MainAccount ledgerTransSettlementAccountsMainAccountEntityRole)
        {
            LedgerTransSettlementAccount ledgerTransSettlementAccount = new LedgerTransSettlementAccount();
            ledgerTransSettlementAccount.MainAccountId = mainAccountId;
            ledgerTransSettlementAccount.ChartOfAccounts = chartOfAccounts;
            if ((ledgerTransSettlementAccountsMainAccountEntityRole == null))
            {
                throw new global::System.ArgumentNullException("ledgerTransSettlementAccountsMainAccountEntityRole");
            }
            ledgerTransSettlementAccount.LedgerTransSettlementAccountsMainAccountEntityRole = ledgerTransSettlementAccountsMainAccountEntityRole;
            return ledgerTransSettlementAccount;
        }
        /// <summary>
        /// There are no comments for Property MainAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccountId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MainAccountId is required.")]
        public virtual string MainAccountId
        {
            get
            {
                return this._MainAccountId;
            }
            set
            {
                this.OnMainAccountIdChanging(value);
                this._MainAccountId = value;
                this.OnMainAccountIdChanged();
                this.OnPropertyChanged("MainAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountId;
        partial void OnMainAccountIdChanging(string value);
        partial void OnMainAccountIdChanged();
        /// <summary>
        /// There are no comments for Property ChartOfAccounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChartOfAccounts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChartOfAccounts is required.")]
        public virtual string ChartOfAccounts
        {
            get
            {
                return this._ChartOfAccounts;
            }
            set
            {
                this.OnChartOfAccountsChanging(value);
                this._ChartOfAccounts = value;
                this.OnChartOfAccountsChanged();
                this.OnPropertyChanged("ChartOfAccounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChartOfAccounts;
        partial void OnChartOfAccountsChanging(string value);
        partial void OnChartOfAccountsChanged();
        /// <summary>
        /// There are no comments for Property TypicalBalance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypicalBalance")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerSettlementsAccountTypicalBalance> TypicalBalance
        {
            get
            {
                return this._TypicalBalance;
            }
            set
            {
                this.OnTypicalBalanceChanging(value);
                this._TypicalBalance = value;
                this.OnTypicalBalanceChanged();
                this.OnPropertyChanged("TypicalBalance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerSettlementsAccountTypicalBalance> _TypicalBalance;
        partial void OnTypicalBalanceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerSettlementsAccountTypicalBalance> value);
        partial void OnTypicalBalanceChanged();
        /// <summary>
        /// There are no comments for Property KeepDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("KeepDetails")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> KeepDetails
        {
            get
            {
                return this._KeepDetails;
            }
            set
            {
                this.OnKeepDetailsChanging(value);
                this._KeepDetails = value;
                this.OnKeepDetailsChanged();
                this.OnPropertyChanged("KeepDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _KeepDetails;
        partial void OnKeepDetailsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnKeepDetailsChanged();
        /// <summary>
        /// There are no comments for Property LedgerTransSettlementAccountsMainAccountEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerTransSettlementAccountsMainAccountEntityRole")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerTransSettlementAccountsMainAccountEntityRole is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.MainAccount LedgerTransSettlementAccountsMainAccountEntityRole
        {
            get
            {
                return this._LedgerTransSettlementAccountsMainAccountEntityRole;
            }
            set
            {
                this.OnLedgerTransSettlementAccountsMainAccountEntityRoleChanging(value);
                this._LedgerTransSettlementAccountsMainAccountEntityRole = value;
                this.OnLedgerTransSettlementAccountsMainAccountEntityRoleChanged();
                this.OnPropertyChanged("LedgerTransSettlementAccountsMainAccountEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MainAccount _LedgerTransSettlementAccountsMainAccountEntityRole;
        partial void OnLedgerTransSettlementAccountsMainAccountEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.MainAccount value);
        partial void OnLedgerTransSettlementAccountsMainAccountEntityRoleChanged();
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