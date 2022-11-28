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
    /// There are no comments for ProjAdvancedJournalLineHourSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjAdvancedJournalLineHourSingle")]
    public partial class ProjAdvancedJournalLineHourSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjAdvancedJournalLineHour>
    {
        /// <summary>
        /// Initialize a new ProjAdvancedJournalLineHourSingle object.
        /// </summary>
        public ProjAdvancedJournalLineHourSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjAdvancedJournalLineHourSingle object.
        /// </summary>
        public ProjAdvancedJournalLineHourSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjAdvancedJournalLineHourSingle object.
        /// </summary>
        public ProjAdvancedJournalLineHourSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjAdvancedJournalLineHour> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjAdvancedJournalLineHour in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineNumber
    /// ProjAdvancedJournal
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNumber", "ProjAdvancedJournal")]
    [global::Microsoft.OData.Client.EntitySet("ProjAdvancedJournalLineHours")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjAdvancedJournalLineHour")]
    public partial class ProjAdvancedJournalLineHour : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjAdvancedJournalLineHour object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="projAdvancedJournal">Initial value of ProjAdvancedJournal.</param>
        /// <param name="unitPrice">Initial value of UnitPrice.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="priceExchangeRate">Initial value of PriceExchangeRate.</param>
        /// <param name="unitCost">Initial value of UnitCost.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="extendedCost">Initial value of ExtendedCost.</param>
        /// <param name="extendedPrice">Initial value of ExtendedPrice.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjAdvancedJournalLineHour CreateProjAdvancedJournalLineHour(string dataAreaId, 
                    decimal lineNumber, 
                    long projAdvancedJournal, 
                    decimal unitPrice, 
                    global::System.DateTimeOffset accountingDate, 
                    decimal priceExchangeRate, 
                    decimal unitCost, 
                    decimal quantity, 
                    decimal extendedCost, 
                    decimal extendedPrice)
        {
            ProjAdvancedJournalLineHour projAdvancedJournalLineHour = new ProjAdvancedJournalLineHour();
            projAdvancedJournalLineHour.DataAreaId = dataAreaId;
            projAdvancedJournalLineHour.LineNumber = lineNumber;
            projAdvancedJournalLineHour.ProjAdvancedJournal = projAdvancedJournal;
            projAdvancedJournalLineHour.UnitPrice = unitPrice;
            projAdvancedJournalLineHour.AccountingDate = accountingDate;
            projAdvancedJournalLineHour.PriceExchangeRate = priceExchangeRate;
            projAdvancedJournalLineHour.UnitCost = unitCost;
            projAdvancedJournalLineHour.Quantity = quantity;
            projAdvancedJournalLineHour.ExtendedCost = extendedCost;
            projAdvancedJournalLineHour.ExtendedPrice = extendedPrice;
            return projAdvancedJournalLineHour;
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
        /// There are no comments for Property ProjAdvancedJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjAdvancedJournal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjAdvancedJournal is required.")]
        public virtual long ProjAdvancedJournal
        {
            get
            {
                return this._ProjAdvancedJournal;
            }
            set
            {
                this.OnProjAdvancedJournalChanging(value);
                this._ProjAdvancedJournal = value;
                this.OnProjAdvancedJournalChanged();
                this.OnPropertyChanged("ProjAdvancedJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ProjAdvancedJournal;
        partial void OnProjAdvancedJournalChanging(long value);
        partial void OnProjAdvancedJournalChanged();
        /// <summary>
        /// There are no comments for Property ActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityNumber")]
        public virtual string ActivityNumber
        {
            get
            {
                return this._ActivityNumber;
            }
            set
            {
                this.OnActivityNumberChanging(value);
                this._ActivityNumber = value;
                this.OnActivityNumberChanged();
                this.OnPropertyChanged("ActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityNumber;
        partial void OnActivityNumberChanging(string value);
        partial void OnActivityNumberChanged();
        /// <summary>
        /// There are no comments for Property ProjCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCategoryId")]
        public virtual string ProjCategoryId
        {
            get
            {
                return this._ProjCategoryId;
            }
            set
            {
                this.OnProjCategoryIdChanging(value);
                this._ProjCategoryId = value;
                this.OnProjCategoryIdChanged();
                this.OnPropertyChanged("ProjCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjCategoryId;
        partial void OnProjCategoryIdChanging(string value);
        partial void OnProjCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ProjDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjDataAreaId")]
        public virtual string ProjDataAreaId
        {
            get
            {
                return this._ProjDataAreaId;
            }
            set
            {
                this.OnProjDataAreaIdChanging(value);
                this._ProjDataAreaId = value;
                this.OnProjDataAreaIdChanged();
                this.OnPropertyChanged("ProjDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjDataAreaId;
        partial void OnProjDataAreaIdChanging(string value);
        partial void OnProjDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property TransType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransType> TransType
        {
            get
            {
                return this._TransType;
            }
            set
            {
                this.OnTransTypeChanging(value);
                this._TransType = value;
                this.OnTransTypeChanged();
                this.OnPropertyChanged("TransType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransType> _TransType;
        partial void OnTransTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjTransType> value);
        partial void OnTransTypeChanged();
        /// <summary>
        /// There are no comments for Property ProjId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjId")]
        public virtual string ProjId
        {
            get
            {
                return this._ProjId;
            }
            set
            {
                this.OnProjIdChanging(value);
                this._ProjId = value;
                this.OnProjIdChanged();
                this.OnPropertyChanged("ProjId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjId;
        partial void OnProjIdChanging(string value);
        partial void OnProjIdChanged();
        /// <summary>
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Voucher")]
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
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        public virtual string TaxGroup
        {
            get
            {
                return this._TaxGroup;
            }
            set
            {
                this.OnTaxGroupChanging(value);
                this._TaxGroup = value;
                this.OnTaxGroupChanged();
                this.OnPropertyChanged("TaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroup;
        partial void OnTaxGroupChanging(string value);
        partial void OnTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property ProjectSalesTaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectSalesTaxItemGroup")]
        public virtual string ProjectSalesTaxItemGroup
        {
            get
            {
                return this._ProjectSalesTaxItemGroup;
            }
            set
            {
                this.OnProjectSalesTaxItemGroupChanging(value);
                this._ProjectSalesTaxItemGroup = value;
                this.OnProjectSalesTaxItemGroupChanged();
                this.OnPropertyChanged("ProjectSalesTaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectSalesTaxItemGroup;
        partial void OnProjectSalesTaxItemGroupChanging(string value);
        partial void OnProjectSalesTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitPrice is required.")]
        public virtual decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitPrice;
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property AccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingDate is required.")]
        public virtual global::System.DateTimeOffset AccountingDate
        {
            get
            {
                return this._AccountingDate;
            }
            set
            {
                this.OnAccountingDateChanging(value);
                this._AccountingDate = value;
                this.OnAccountingDateChanged();
                this.OnPropertyChanged("AccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingDate;
        partial void OnAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingDateChanged();
        /// <summary>
        /// There are no comments for Property PostError in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostError")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PostError
        {
            get
            {
                return this._PostError;
            }
            set
            {
                this.OnPostErrorChanging(value);
                this._PostError = value;
                this.OnPostErrorChanged();
                this.OnPropertyChanged("PostError");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PostError;
        partial void OnPostErrorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPostErrorChanged();
        /// <summary>
        /// There are no comments for Property PriceExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceExchangeRate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceExchangeRate is required.")]
        public virtual decimal PriceExchangeRate
        {
            get
            {
                return this._PriceExchangeRate;
            }
            set
            {
                this.OnPriceExchangeRateChanging(value);
                this._PriceExchangeRate = value;
                this.OnPriceExchangeRateChanged();
                this.OnPropertyChanged("PriceExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PriceExchangeRate;
        partial void OnPriceExchangeRateChanging(decimal value);
        partial void OnPriceExchangeRateChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        /// <summary>
        /// There are no comments for Property UnitCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitCost")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitCost is required.")]
        public virtual decimal UnitCost
        {
            get
            {
                return this._UnitCost;
            }
            set
            {
                this.OnUnitCostChanging(value);
                this._UnitCost = value;
                this.OnUnitCostChanged();
                this.OnPropertyChanged("UnitCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitCost;
        partial void OnUnitCostChanging(decimal value);
        partial void OnUnitCostChanged();
        /// <summary>
        /// There are no comments for Property PriceCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceCurrency")]
        public virtual string PriceCurrency
        {
            get
            {
                return this._PriceCurrency;
            }
            set
            {
                this.OnPriceCurrencyChanging(value);
                this._PriceCurrency = value;
                this.OnPriceCurrencyChanged();
                this.OnPropertyChanged("PriceCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceCurrency;
        partial void OnPriceCurrencyChanging(string value);
        partial void OnPriceCurrencyChanged();
        /// <summary>
        /// There are no comments for Property LinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinePropertyId")]
        public virtual string LinePropertyId
        {
            get
            {
                return this._LinePropertyId;
            }
            set
            {
                this.OnLinePropertyIdChanging(value);
                this._LinePropertyId = value;
                this.OnLinePropertyIdChanged();
                this.OnPropertyChanged("LinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinePropertyId;
        partial void OnLinePropertyIdChanging(string value);
        partial void OnLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property ContractLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractLineId")]
        public virtual string ContractLineId
        {
            get
            {
                return this._ContractLineId;
            }
            set
            {
                this.OnContractLineIdChanging(value);
                this._ContractLineId = value;
                this.OnContractLineIdChanged();
                this.OnPropertyChanged("ContractLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContractLineId;
        partial void OnContractLineIdChanging(string value);
        partial void OnContractLineIdChanged();
        /// <summary>
        /// There are no comments for Property ExtendedCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtendedCost")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExtendedCost is required.")]
        public virtual decimal ExtendedCost
        {
            get
            {
                return this._ExtendedCost;
            }
            set
            {
                this.OnExtendedCostChanging(value);
                this._ExtendedCost = value;
                this.OnExtendedCostChanged();
                this.OnPropertyChanged("ExtendedCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExtendedCost;
        partial void OnExtendedCostChanging(decimal value);
        partial void OnExtendedCostChanged();
        /// <summary>
        /// There are no comments for Property ProjectSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectSalesTaxGroup")]
        public virtual string ProjectSalesTaxGroup
        {
            get
            {
                return this._ProjectSalesTaxGroup;
            }
            set
            {
                this.OnProjectSalesTaxGroupChanging(value);
                this._ProjectSalesTaxGroup = value;
                this.OnProjectSalesTaxGroupChanged();
                this.OnPropertyChanged("ProjectSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectSalesTaxGroup;
        partial void OnProjectSalesTaxGroupChanging(string value);
        partial void OnProjectSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property TaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxItemGroup")]
        public virtual string TaxItemGroup
        {
            get
            {
                return this._TaxItemGroup;
            }
            set
            {
                this.OnTaxItemGroupChanging(value);
                this._TaxItemGroup = value;
                this.OnTaxItemGroupChanged();
                this.OnPropertyChanged("TaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxItemGroup;
        partial void OnTaxItemGroupChanging(string value);
        partial void OnTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property ExtendedPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtendedPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExtendedPrice is required.")]
        public virtual decimal ExtendedPrice
        {
            get
            {
                return this._ExtendedPrice;
            }
            set
            {
                this.OnExtendedPriceChanging(value);
                this._ExtendedPrice = value;
                this.OnExtendedPriceChanged();
                this.OnPropertyChanged("ExtendedPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExtendedPrice;
        partial void OnExtendedPriceChanging(decimal value);
        partial void OnExtendedPriceChanged();
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