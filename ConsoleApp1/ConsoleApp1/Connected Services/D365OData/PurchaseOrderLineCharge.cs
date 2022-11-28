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
    /// There are no comments for PurchaseOrderLineChargeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderLineChargeSingle")]
    public partial class PurchaseOrderLineChargeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderLineCharge>
    {
        /// <summary>
        /// Initialize a new PurchaseOrderLineChargeSingle object.
        /// </summary>
        public PurchaseOrderLineChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseOrderLineChargeSingle object.
        /// </summary>
        public PurchaseOrderLineChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseOrderLineChargeSingle object.
        /// </summary>
        public PurchaseOrderLineChargeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderLineCharge> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PurchaseOrderLineCharge in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PurchaseOrderNumber
    /// PurchaseOrderLineNumber
    /// ChargeLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseOrderNumber", "PurchaseOrderLineNumber", "ChargeLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseOrderLineCharges")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderLineCharge")]
    public partial class PurchaseOrderLineCharge : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseOrderLineCharge object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="purchaseOrderNumber">Initial value of PurchaseOrderNumber.</param>
        /// <param name="purchaseOrderLineNumber">Initial value of PurchaseOrderLineNumber.</param>
        /// <param name="chargeLineNumber">Initial value of ChargeLineNumber.</param>
        /// <param name="proportionalChargeAmount">Initial value of ProportionalChargeAmount.</param>
        /// <param name="intercompanyChargePercentage">Initial value of IntercompanyChargePercentage.</param>
        /// <param name="chargePercentage">Initial value of ChargePercentage.</param>
        /// <param name="fixedChargeAmount">Initial value of FixedChargeAmount.</param>
        /// <param name="unitChargeAmount">Initial value of UnitChargeAmount.</param>
        /// <param name="externalChargeAmount">Initial value of ExternalChargeAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseOrderLineCharge CreatePurchaseOrderLineCharge(string dataAreaId, 
                    string purchaseOrderNumber, 
                    long purchaseOrderLineNumber, 
                    decimal chargeLineNumber, 
                    decimal proportionalChargeAmount, 
                    decimal intercompanyChargePercentage, 
                    decimal chargePercentage, 
                    decimal fixedChargeAmount, 
                    decimal unitChargeAmount, 
                    decimal externalChargeAmount)
        {
            PurchaseOrderLineCharge purchaseOrderLineCharge = new PurchaseOrderLineCharge();
            purchaseOrderLineCharge.DataAreaId = dataAreaId;
            purchaseOrderLineCharge.PurchaseOrderNumber = purchaseOrderNumber;
            purchaseOrderLineCharge.PurchaseOrderLineNumber = purchaseOrderLineNumber;
            purchaseOrderLineCharge.ChargeLineNumber = chargeLineNumber;
            purchaseOrderLineCharge.ProportionalChargeAmount = proportionalChargeAmount;
            purchaseOrderLineCharge.IntercompanyChargePercentage = intercompanyChargePercentage;
            purchaseOrderLineCharge.ChargePercentage = chargePercentage;
            purchaseOrderLineCharge.FixedChargeAmount = fixedChargeAmount;
            purchaseOrderLineCharge.UnitChargeAmount = unitChargeAmount;
            purchaseOrderLineCharge.ExternalChargeAmount = externalChargeAmount;
            return purchaseOrderLineCharge;
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
        /// There are no comments for Property PurchaseOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseOrderNumber is required.")]
        public virtual string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this.OnPurchaseOrderNumberChanging(value);
                this._PurchaseOrderNumber = value;
                this.OnPurchaseOrderNumberChanged();
                this.OnPropertyChanged("PurchaseOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderNumber;
        partial void OnPurchaseOrderNumberChanging(string value);
        partial void OnPurchaseOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseOrderLineNumber is required.")]
        public virtual long PurchaseOrderLineNumber
        {
            get
            {
                return this._PurchaseOrderLineNumber;
            }
            set
            {
                this.OnPurchaseOrderLineNumberChanging(value);
                this._PurchaseOrderLineNumber = value;
                this.OnPurchaseOrderLineNumberChanged();
                this.OnPropertyChanged("PurchaseOrderLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PurchaseOrderLineNumber;
        partial void OnPurchaseOrderLineNumberChanging(long value);
        partial void OnPurchaseOrderLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ChargeLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargeLineNumber is required.")]
        public virtual decimal ChargeLineNumber
        {
            get
            {
                return this._ChargeLineNumber;
            }
            set
            {
                this.OnChargeLineNumberChanging(value);
                this._ChargeLineNumber = value;
                this.OnChargeLineNumberChanged();
                this.OnPropertyChanged("ChargeLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargeLineNumber;
        partial void OnChargeLineNumberChanging(decimal value);
        partial void OnChargeLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ProportionalChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProportionalChargeAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProportionalChargeAmount is required.")]
        public virtual decimal ProportionalChargeAmount
        {
            get
            {
                return this._ProportionalChargeAmount;
            }
            set
            {
                this.OnProportionalChargeAmountChanging(value);
                this._ProportionalChargeAmount = value;
                this.OnProportionalChargeAmountChanged();
                this.OnPropertyChanged("ProportionalChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProportionalChargeAmount;
        partial void OnProportionalChargeAmountChanging(decimal value);
        partial void OnProportionalChargeAmountChanged();
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
        /// There are no comments for Property SalesTaxGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxGroupCode")]
        public virtual string SalesTaxGroupCode
        {
            get
            {
                return this._SalesTaxGroupCode;
            }
            set
            {
                this.OnSalesTaxGroupCodeChanging(value);
                this._SalesTaxGroupCode = value;
                this.OnSalesTaxGroupCodeChanged();
                this.OnPropertyChanged("SalesTaxGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroupCode;
        partial void OnSalesTaxGroupCodeChanging(string value);
        partial void OnSalesTaxGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property ChargeAccountingCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeAccountingCurrencyCode")]
        public virtual string ChargeAccountingCurrencyCode
        {
            get
            {
                return this._ChargeAccountingCurrencyCode;
            }
            set
            {
                this.OnChargeAccountingCurrencyCodeChanging(value);
                this._ChargeAccountingCurrencyCode = value;
                this.OnChargeAccountingCurrencyCodeChanged();
                this.OnPropertyChanged("ChargeAccountingCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeAccountingCurrencyCode;
        partial void OnChargeAccountingCurrencyCodeChanging(string value);
        partial void OnChargeAccountingCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property PurchaseChargeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseChargeCode")]
        public virtual string PurchaseChargeCode
        {
            get
            {
                return this._PurchaseChargeCode;
            }
            set
            {
                this.OnPurchaseChargeCodeChanging(value);
                this._PurchaseChargeCode = value;
                this.OnPurchaseChargeCodeChanged();
                this.OnPropertyChanged("PurchaseChargeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseChargeCode;
        partial void OnPurchaseChargeCodeChanging(string value);
        partial void OnPurchaseChargeCodeChanged();
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
        /// There are no comments for Property ChargeCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> ChargeCategory
        {
            get
            {
                return this._ChargeCategory;
            }
            set
            {
                this.OnChargeCategoryChanging(value);
                this._ChargeCategory = value;
                this.OnChargeCategoryChanged();
                this.OnPropertyChanged("ChargeCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> _ChargeCategory;
        partial void OnChargeCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> value);
        partial void OnChargeCategoryChanged();
        /// <summary>
        /// There are no comments for Property IsIntercompanyCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsIntercompanyCharge")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsIntercompanyCharge
        {
            get
            {
                return this._IsIntercompanyCharge;
            }
            set
            {
                this.OnIsIntercompanyChargeChanging(value);
                this._IsIntercompanyCharge = value;
                this.OnIsIntercompanyChargeChanged();
                this.OnPropertyChanged("IsIntercompanyCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsIntercompanyCharge;
        partial void OnIsIntercompanyChargeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsIntercompanyChargeChanged();
        /// <summary>
        /// There are no comments for Property IntercompanyChargePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntercompanyChargePercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntercompanyChargePercentage is required.")]
        public virtual decimal IntercompanyChargePercentage
        {
            get
            {
                return this._IntercompanyChargePercentage;
            }
            set
            {
                this.OnIntercompanyChargePercentageChanging(value);
                this._IntercompanyChargePercentage = value;
                this.OnIntercompanyChargePercentageChanged();
                this.OnPropertyChanged("IntercompanyChargePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _IntercompanyChargePercentage;
        partial void OnIntercompanyChargePercentageChanging(decimal value);
        partial void OnIntercompanyChargePercentageChanged();
        /// <summary>
        /// There are no comments for Property ChargePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargePercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargePercentage is required.")]
        public virtual decimal ChargePercentage
        {
            get
            {
                return this._ChargePercentage;
            }
            set
            {
                this.OnChargePercentageChanging(value);
                this._ChargePercentage = value;
                this.OnChargePercentageChanged();
                this.OnPropertyChanged("ChargePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargePercentage;
        partial void OnChargePercentageChanging(decimal value);
        partial void OnChargePercentageChanged();
        /// <summary>
        /// There are no comments for Property FixedChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedChargeAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FixedChargeAmount is required.")]
        public virtual decimal FixedChargeAmount
        {
            get
            {
                return this._FixedChargeAmount;
            }
            set
            {
                this.OnFixedChargeAmountChanging(value);
                this._FixedChargeAmount = value;
                this.OnFixedChargeAmountChanged();
                this.OnPropertyChanged("FixedChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FixedChargeAmount;
        partial void OnFixedChargeAmountChanging(decimal value);
        partial void OnFixedChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property UnitChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitChargeAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitChargeAmount is required.")]
        public virtual decimal UnitChargeAmount
        {
            get
            {
                return this._UnitChargeAmount;
            }
            set
            {
                this.OnUnitChargeAmountChanging(value);
                this._UnitChargeAmount = value;
                this.OnUnitChargeAmountChanged();
                this.OnPropertyChanged("UnitChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitChargeAmount;
        partial void OnUnitChargeAmountChanging(decimal value);
        partial void OnUnitChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property ExternalChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalChargeAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExternalChargeAmount is required.")]
        public virtual decimal ExternalChargeAmount
        {
            get
            {
                return this._ExternalChargeAmount;
            }
            set
            {
                this.OnExternalChargeAmountChanging(value);
                this._ExternalChargeAmount = value;
                this.OnExternalChargeAmountChanged();
                this.OnPropertyChanged("ExternalChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExternalChargeAmount;
        partial void OnExternalChargeAmountChanging(decimal value);
        partial void OnExternalChargeAmountChanged();
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
