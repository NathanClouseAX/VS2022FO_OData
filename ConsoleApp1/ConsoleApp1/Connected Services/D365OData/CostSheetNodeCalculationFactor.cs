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
    /// There are no comments for CostSheetNodeCalculationFactorSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostSheetNodeCalculationFactorSingle")]
    public partial class CostSheetNodeCalculationFactorSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostSheetNodeCalculationFactor>
    {
        /// <summary>
        /// Initialize a new CostSheetNodeCalculationFactorSingle object.
        /// </summary>
        public CostSheetNodeCalculationFactorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostSheetNodeCalculationFactorSingle object.
        /// </summary>
        public CostSheetNodeCalculationFactorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostSheetNodeCalculationFactorSingle object.
        /// </summary>
        public CostSheetNodeCalculationFactorSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostSheetNodeCalculationFactor> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostSheetNodeCalculationFactor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CostSheetNodeName
    /// PriceSiteId
    /// FromDate
    /// CostingVersionId
    /// ItemNumber
    /// ProductGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CostSheetNodeName", "PriceSiteId", "FromDate", "CostingVersionId", "ItemNumber", "ProductGroupId")]
    [global::Microsoft.OData.Client.EntitySet("CostSheetNodeCalculationFactors")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostSheetNodeCalculationFactor")]
    public partial class CostSheetNodeCalculationFactor : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostSheetNodeCalculationFactor object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="costSheetNodeName">Initial value of CostSheetNodeName.</param>
        /// <param name="priceSiteId">Initial value of PriceSiteId.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="costingVersionId">Initial value of CostingVersionId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="productGroupId">Initial value of ProductGroupId.</param>
        /// <param name="surchargePercentage">Initial value of SurchargePercentage.</param>
        /// <param name="accountingCurrencyRateAmount">Initial value of AccountingCurrencyRateAmount.</param>
        /// <param name="accountingCurrencyUnitBasedAmount">Initial value of AccountingCurrencyUnitBasedAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostSheetNodeCalculationFactor CreateCostSheetNodeCalculationFactor(string dataAreaId, 
                    string costSheetNodeName, 
                    string priceSiteId, 
                    global::System.DateTimeOffset fromDate, 
                    string costingVersionId, 
                    string itemNumber, 
                    string productGroupId, 
                    decimal surchargePercentage, 
                    decimal accountingCurrencyRateAmount, 
                    decimal accountingCurrencyUnitBasedAmount)
        {
            CostSheetNodeCalculationFactor costSheetNodeCalculationFactor = new CostSheetNodeCalculationFactor();
            costSheetNodeCalculationFactor.DataAreaId = dataAreaId;
            costSheetNodeCalculationFactor.CostSheetNodeName = costSheetNodeName;
            costSheetNodeCalculationFactor.PriceSiteId = priceSiteId;
            costSheetNodeCalculationFactor.FromDate = fromDate;
            costSheetNodeCalculationFactor.CostingVersionId = costingVersionId;
            costSheetNodeCalculationFactor.ItemNumber = itemNumber;
            costSheetNodeCalculationFactor.ProductGroupId = productGroupId;
            costSheetNodeCalculationFactor.SurchargePercentage = surchargePercentage;
            costSheetNodeCalculationFactor.AccountingCurrencyRateAmount = accountingCurrencyRateAmount;
            costSheetNodeCalculationFactor.AccountingCurrencyUnitBasedAmount = accountingCurrencyUnitBasedAmount;
            return costSheetNodeCalculationFactor;
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
        /// There are no comments for Property CostSheetNodeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostSheetNodeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostSheetNodeName is required.")]
        public virtual string CostSheetNodeName
        {
            get
            {
                return this._CostSheetNodeName;
            }
            set
            {
                this.OnCostSheetNodeNameChanging(value);
                this._CostSheetNodeName = value;
                this.OnCostSheetNodeNameChanged();
                this.OnPropertyChanged("CostSheetNodeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostSheetNodeName;
        partial void OnCostSheetNodeNameChanging(string value);
        partial void OnCostSheetNodeNameChanged();
        /// <summary>
        /// There are no comments for Property PriceSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceSiteId is required.")]
        public virtual string PriceSiteId
        {
            get
            {
                return this._PriceSiteId;
            }
            set
            {
                this.OnPriceSiteIdChanging(value);
                this._PriceSiteId = value;
                this.OnPriceSiteIdChanged();
                this.OnPropertyChanged("PriceSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceSiteId;
        partial void OnPriceSiteIdChanging(string value);
        partial void OnPriceSiteIdChanged();
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
        /// There are no comments for Property CostingVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostingVersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostingVersionId is required.")]
        public virtual string CostingVersionId
        {
            get
            {
                return this._CostingVersionId;
            }
            set
            {
                this.OnCostingVersionIdChanging(value);
                this._CostingVersionId = value;
                this.OnCostingVersionIdChanged();
                this.OnPropertyChanged("CostingVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostingVersionId;
        partial void OnCostingVersionIdChanging(string value);
        partial void OnCostingVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemNumber is required.")]
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
        /// There are no comments for Property ProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductGroupId is required.")]
        public virtual string ProductGroupId
        {
            get
            {
                return this._ProductGroupId;
            }
            set
            {
                this.OnProductGroupIdChanging(value);
                this._ProductGroupId = value;
                this.OnProductGroupIdChanged();
                this.OnPropertyChanged("ProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductGroupId;
        partial void OnProductGroupIdChanging(string value);
        partial void OnProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property SurchargePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SurchargePercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SurchargePercentage is required.")]
        public virtual decimal SurchargePercentage
        {
            get
            {
                return this._SurchargePercentage;
            }
            set
            {
                this.OnSurchargePercentageChanging(value);
                this._SurchargePercentage = value;
                this.OnSurchargePercentageChanged();
                this.OnPropertyChanged("SurchargePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SurchargePercentage;
        partial void OnSurchargePercentageChanging(decimal value);
        partial void OnSurchargePercentageChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyRateAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingCurrencyRateAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingCurrencyRateAmount is required.")]
        public virtual decimal AccountingCurrencyRateAmount
        {
            get
            {
                return this._AccountingCurrencyRateAmount;
            }
            set
            {
                this.OnAccountingCurrencyRateAmountChanging(value);
                this._AccountingCurrencyRateAmount = value;
                this.OnAccountingCurrencyRateAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyRateAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyRateAmount;
        partial void OnAccountingCurrencyRateAmountChanging(decimal value);
        partial void OnAccountingCurrencyRateAmountChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyUnitBasedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingCurrencyUnitBasedAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingCurrencyUnitBasedAmount is required.")]
        public virtual decimal AccountingCurrencyUnitBasedAmount
        {
            get
            {
                return this._AccountingCurrencyUnitBasedAmount;
            }
            set
            {
                this.OnAccountingCurrencyUnitBasedAmountChanging(value);
                this._AccountingCurrencyUnitBasedAmount = value;
                this.OnAccountingCurrencyUnitBasedAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyUnitBasedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyUnitBasedAmount;
        partial void OnAccountingCurrencyUnitBasedAmountChanging(decimal value);
        partial void OnAccountingCurrencyUnitBasedAmountChanged();
        /// <summary>
        /// There are no comments for Property CostingVersionStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostingVersionStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionStatus> CostingVersionStatus
        {
            get
            {
                return this._CostingVersionStatus;
            }
            set
            {
                this.OnCostingVersionStatusChanging(value);
                this._CostingVersionStatus = value;
                this.OnCostingVersionStatusChanged();
                this.OnPropertyChanged("CostingVersionStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionStatus> _CostingVersionStatus;
        partial void OnCostingVersionStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostingVersionStatus> value);
        partial void OnCostingVersionStatusChanged();
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
