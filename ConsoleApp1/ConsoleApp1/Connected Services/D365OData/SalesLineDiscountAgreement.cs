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
    /// There are no comments for SalesLineDiscountAgreementSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesLineDiscountAgreementSingle")]
    public partial class SalesLineDiscountAgreementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesLineDiscountAgreement>
    {
        /// <summary>
        /// Initialize a new SalesLineDiscountAgreementSingle object.
        /// </summary>
        public SalesLineDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesLineDiscountAgreementSingle object.
        /// </summary>
        public SalesLineDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesLineDiscountAgreementSingle object.
        /// </summary>
        public SalesLineDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesLineDiscountAgreement> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SalesLineDiscountAgreement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecordId")]
    [global::Microsoft.OData.Client.EntitySet("SalesLineDiscountAgreements")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesLineDiscountAgreement")]
    public partial class SalesLineDiscountAgreement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesLineDiscountAgreement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="discountAmount">Initial value of DiscountAmount.</param>
        /// <param name="discountApplicableFromDate">Initial value of DiscountApplicableFromDate.</param>
        /// <param name="toQuantity">Initial value of ToQuantity.</param>
        /// <param name="discountPercentage2">Initial value of DiscountPercentage2.</param>
        /// <param name="discountPercentage1">Initial value of DiscountPercentage1.</param>
        /// <param name="discountApplicableToDate">Initial value of DiscountApplicableToDate.</param>
        /// <param name="fromQuantity">Initial value of FromQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesLineDiscountAgreement CreateSalesLineDiscountAgreement(string dataAreaId, 
                    long recordId, 
                    decimal discountAmount, 
                    global::System.DateTimeOffset discountApplicableFromDate, 
                    decimal toQuantity, 
                    decimal discountPercentage2, 
                    decimal discountPercentage1, 
                    global::System.DateTimeOffset discountApplicableToDate, 
                    decimal fromQuantity)
        {
            SalesLineDiscountAgreement salesLineDiscountAgreement = new SalesLineDiscountAgreement();
            salesLineDiscountAgreement.DataAreaId = dataAreaId;
            salesLineDiscountAgreement.RecordId = recordId;
            salesLineDiscountAgreement.DiscountAmount = discountAmount;
            salesLineDiscountAgreement.DiscountApplicableFromDate = discountApplicableFromDate;
            salesLineDiscountAgreement.ToQuantity = toQuantity;
            salesLineDiscountAgreement.DiscountPercentage2 = discountPercentage2;
            salesLineDiscountAgreement.DiscountPercentage1 = discountPercentage1;
            salesLineDiscountAgreement.DiscountApplicableToDate = discountApplicableToDate;
            salesLineDiscountAgreement.FromQuantity = fromQuantity;
            return salesLineDiscountAgreement;
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
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
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
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
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
        /// There are no comments for Property DiscountSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountSiteId")]
        public virtual string DiscountSiteId
        {
            get
            {
                return this._DiscountSiteId;
            }
            set
            {
                this.OnDiscountSiteIdChanging(value);
                this._DiscountSiteId = value;
                this.OnDiscountSiteIdChanged();
                this.OnPropertyChanged("DiscountSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountSiteId;
        partial void OnDiscountSiteIdChanging(string value);
        partial void OnDiscountSiteIdChanged();
        /// <summary>
        /// There are no comments for Property LineDiscountProductGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountProductGroupCode")]
        public virtual string LineDiscountProductGroupCode
        {
            get
            {
                return this._LineDiscountProductGroupCode;
            }
            set
            {
                this.OnLineDiscountProductGroupCodeChanging(value);
                this._LineDiscountProductGroupCode = value;
                this.OnLineDiscountProductGroupCodeChanged();
                this.OnPropertyChanged("LineDiscountProductGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineDiscountProductGroupCode;
        partial void OnLineDiscountProductGroupCodeChanging(string value);
        partial void OnLineDiscountProductGroupCodeChanged();
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
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
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
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductNumber")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersionId")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property LineDiscountCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountCustomerGroupCode")]
        public virtual string LineDiscountCustomerGroupCode
        {
            get
            {
                return this._LineDiscountCustomerGroupCode;
            }
            set
            {
                this.OnLineDiscountCustomerGroupCodeChanging(value);
                this._LineDiscountCustomerGroupCode = value;
                this.OnLineDiscountCustomerGroupCodeChanged();
                this.OnPropertyChanged("LineDiscountCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineDiscountCustomerGroupCode;
        partial void OnLineDiscountCustomerGroupCodeChanging(string value);
        partial void OnLineDiscountCustomerGroupCodeChanged();
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
        /// There are no comments for Property DiscountWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountWarehouseId")]
        public virtual string DiscountWarehouseId
        {
            get
            {
                return this._DiscountWarehouseId;
            }
            set
            {
                this.OnDiscountWarehouseIdChanging(value);
                this._DiscountWarehouseId = value;
                this.OnDiscountWarehouseIdChanged();
                this.OnPropertyChanged("DiscountWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountWarehouseId;
        partial void OnDiscountWarehouseIdChanging(string value);
        partial void OnDiscountWarehouseIdChanged();
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
