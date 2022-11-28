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
    /// There are no comments for CDSInventoryChargeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSInventoryChargeSingle")]
    public partial class CDSInventoryChargeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSInventoryCharge>
    {
        /// <summary>
        /// Initialize a new CDSInventoryChargeSingle object.
        /// </summary>
        public CDSInventoryChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSInventoryChargeSingle object.
        /// </summary>
        public CDSInventoryChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSInventoryChargeSingle object.
        /// </summary>
        public CDSInventoryChargeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSInventoryCharge> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CDSInventoryCharge in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ChargeCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ChargeCode")]
    [global::Microsoft.OData.Client.EntitySet("CDSInventoryCharges")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSInventoryCharge")]
    public partial class CDSInventoryCharge : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSInventoryCharge object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="chargeCode">Initial value of ChargeCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSInventoryCharge CreateCDSInventoryCharge(string dataAreaId, string chargeCode)
        {
            CDSInventoryCharge cDSInventoryCharge = new CDSInventoryCharge();
            cDSInventoryCharge.DataAreaId = dataAreaId;
            cDSInventoryCharge.ChargeCode = chargeCode;
            return cDSInventoryCharge;
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
        /// There are no comments for Property ChargeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargeCode is required.")]
        public virtual string ChargeCode
        {
            get
            {
                return this._ChargeCode;
            }
            set
            {
                this.OnChargeCodeChanging(value);
                this._ChargeCode = value;
                this.OnChargeCodeChanged();
                this.OnPropertyChanged("ChargeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeCode;
        partial void OnChargeCodeChanging(string value);
        partial void OnChargeCodeChanged();
        /// <summary>
        /// There are no comments for Property ChargeClassification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeClassification")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupClassification_BR> ChargeClassification
        {
            get
            {
                return this._ChargeClassification;
            }
            set
            {
                this.OnChargeClassificationChanging(value);
                this._ChargeClassification = value;
                this.OnChargeClassificationChanged();
                this.OnPropertyChanged("ChargeClassification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupClassification_BR> _ChargeClassification;
        partial void OnChargeClassificationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupClassification_BR> value);
        partial void OnChargeClassificationChanged();
        /// <summary>
        /// There are no comments for Property CreditPostingMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPostingMainAccountIdDisplayValue")]
        public virtual string CreditPostingMainAccountIdDisplayValue
        {
            get
            {
                return this._CreditPostingMainAccountIdDisplayValue;
            }
            set
            {
                this.OnCreditPostingMainAccountIdDisplayValueChanging(value);
                this._CreditPostingMainAccountIdDisplayValue = value;
                this.OnCreditPostingMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("CreditPostingMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditPostingMainAccountIdDisplayValue;
        partial void OnCreditPostingMainAccountIdDisplayValueChanging(string value);
        partial void OnCreditPostingMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DebitPostingMainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitPostingMainAccountIdDisplayValue")]
        public virtual string DebitPostingMainAccountIdDisplayValue
        {
            get
            {
                return this._DebitPostingMainAccountIdDisplayValue;
            }
            set
            {
                this.OnDebitPostingMainAccountIdDisplayValueChanging(value);
                this._DebitPostingMainAccountIdDisplayValue = value;
                this.OnDebitPostingMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("DebitPostingMainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DebitPostingMainAccountIdDisplayValue;
        partial void OnDebitPostingMainAccountIdDisplayValueChanging(string value);
        partial void OnDebitPostingMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DebitPostingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitPostingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> DebitPostingMethod
        {
            get
            {
                return this._DebitPostingMethod;
            }
            set
            {
                this.OnDebitPostingMethodChanging(value);
                this._DebitPostingMethod = value;
                this.OnDebitPostingMethodChanged();
                this.OnPropertyChanged("DebitPostingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> _DebitPostingMethod;
        partial void OnDebitPostingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> value);
        partial void OnDebitPostingMethodChanged();
        /// <summary>
        /// There are no comments for Property ChargeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeDescription")]
        public virtual string ChargeDescription
        {
            get
            {
                return this._ChargeDescription;
            }
            set
            {
                this.OnChargeDescriptionChanging(value);
                this._ChargeDescription = value;
                this.OnChargeDescriptionChanged();
                this.OnPropertyChanged("ChargeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeDescription;
        partial void OnChargeDescriptionChanging(string value);
        partial void OnChargeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property WillIntrastatInvoiceValueIncludeChargeAmounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillIntrastatInvoiceValueIncludeChargeAmounts")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillIntrastatInvoiceValueIncludeChargeAmounts
        {
            get
            {
                return this._WillIntrastatInvoiceValueIncludeChargeAmounts;
            }
            set
            {
                this.OnWillIntrastatInvoiceValueIncludeChargeAmountsChanging(value);
                this._WillIntrastatInvoiceValueIncludeChargeAmounts = value;
                this.OnWillIntrastatInvoiceValueIncludeChargeAmountsChanged();
                this.OnPropertyChanged("WillIntrastatInvoiceValueIncludeChargeAmounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillIntrastatInvoiceValueIncludeChargeAmounts;
        partial void OnWillIntrastatInvoiceValueIncludeChargeAmountsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillIntrastatInvoiceValueIncludeChargeAmountsChanged();
        /// <summary>
        /// There are no comments for Property LedgerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerName")]
        public virtual string LedgerName
        {
            get
            {
                return this._LedgerName;
            }
            set
            {
                this.OnLedgerNameChanging(value);
                this._LedgerName = value;
                this.OnLedgerNameChanged();
                this.OnPropertyChanged("LedgerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerName;
        partial void OnLedgerNameChanging(string value);
        partial void OnLedgerNameChanged();
        /// <summary>
        /// There are no comments for Property DebitPostingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitPostingType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> DebitPostingType
        {
            get
            {
                return this._DebitPostingType;
            }
            set
            {
                this.OnDebitPostingTypeChanging(value);
                this._DebitPostingType = value;
                this.OnDebitPostingTypeChanged();
                this.OnPropertyChanged("DebitPostingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> _DebitPostingType;
        partial void OnDebitPostingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> value);
        partial void OnDebitPostingTypeChanged();
        /// <summary>
        /// There are no comments for Property WillIntrastatStatisticalValueIncludeChargeAmounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillIntrastatStatisticalValueIncludeChargeAmounts")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillIntrastatStatisticalValueIncludeChargeAmounts
        {
            get
            {
                return this._WillIntrastatStatisticalValueIncludeChargeAmounts;
            }
            set
            {
                this.OnWillIntrastatStatisticalValueIncludeChargeAmountsChanging(value);
                this._WillIntrastatStatisticalValueIncludeChargeAmounts = value;
                this.OnWillIntrastatStatisticalValueIncludeChargeAmountsChanged();
                this.OnPropertyChanged("WillIntrastatStatisticalValueIncludeChargeAmounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillIntrastatStatisticalValueIncludeChargeAmounts;
        partial void OnWillIntrastatStatisticalValueIncludeChargeAmountsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillIntrastatStatisticalValueIncludeChargeAmountsChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxItemGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxItemGroupCode")]
        public virtual string SalesTaxItemGroupCode
        {
            get
            {
                return this._SalesTaxItemGroupCode;
            }
            set
            {
                this.OnSalesTaxItemGroupCodeChanging(value);
                this._SalesTaxItemGroupCode = value;
                this.OnSalesTaxItemGroupCodeChanged();
                this.OnPropertyChanged("SalesTaxItemGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxItemGroupCode;
        partial void OnSalesTaxItemGroupCodeChanging(string value);
        partial void OnSalesTaxItemGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property CreditPostingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPostingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> CreditPostingMethod
        {
            get
            {
                return this._CreditPostingMethod;
            }
            set
            {
                this.OnCreditPostingMethodChanging(value);
                this._CreditPostingMethod = value;
                this.OnCreditPostingMethodChanged();
                this.OnPropertyChanged("CreditPostingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> _CreditPostingMethod;
        partial void OnCreditPostingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupType> value);
        partial void OnCreditPostingMethodChanged();
        /// <summary>
        /// There are no comments for Property ChartOfAccountsName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChartOfAccountsName")]
        public virtual string ChartOfAccountsName
        {
            get
            {
                return this._ChartOfAccountsName;
            }
            set
            {
                this.OnChartOfAccountsNameChanging(value);
                this._ChartOfAccountsName = value;
                this.OnChartOfAccountsNameChanged();
                this.OnPropertyChanged("ChartOfAccountsName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChartOfAccountsName;
        partial void OnChartOfAccountsNameChanging(string value);
        partial void OnChartOfAccountsNameChanged();
        /// <summary>
        /// There are no comments for Property CreditPostingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPostingType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> CreditPostingType
        {
            get
            {
                return this._CreditPostingType;
            }
            set
            {
                this.OnCreditPostingTypeChanging(value);
                this._CreditPostingType = value;
                this.OnCreditPostingTypeChanged();
                this.OnPropertyChanged("CreditPostingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> _CreditPostingType;
        partial void OnCreditPostingTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerPostingType> value);
        partial void OnCreditPostingTypeChanged();
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
