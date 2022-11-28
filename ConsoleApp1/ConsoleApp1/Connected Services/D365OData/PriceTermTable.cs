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
    /// There are no comments for PriceTermTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceTermTableSingle")]
    public partial class PriceTermTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PriceTermTable>
    {
        /// <summary>
        /// Initialize a new PriceTermTableSingle object.
        /// </summary>
        public PriceTermTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PriceTermTableSingle object.
        /// </summary>
        public PriceTermTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PriceTermTableSingle object.
        /// </summary>
        public PriceTermTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PriceTermTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PriceTermTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Code")]
    [global::Microsoft.OData.Client.EntitySet("PriceTermTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceTermTable")]
    public partial class PriceTermTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PriceTermTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="code">Initial value of Code.</param>
        /// <param name="calculationSequence">Initial value of CalculationSequence.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PriceTermTable CreatePriceTermTable(string dataAreaId, string code, int calculationSequence)
        {
            PriceTermTable priceTermTable = new PriceTermTable();
            priceTermTable.DataAreaId = dataAreaId;
            priceTermTable.Code = code;
            priceTermTable.CalculationSequence = calculationSequence;
            return priceTermTable;
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
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property CalculationBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculationBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPCalculationBasis> CalculationBasis
        {
            get
            {
                return this._CalculationBasis;
            }
            set
            {
                this.OnCalculationBasisChanging(value);
                this._CalculationBasis = value;
                this.OnCalculationBasisChanged();
                this.OnPropertyChanged("CalculationBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPCalculationBasis> _CalculationBasis;
        partial void OnCalculationBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPCalculationBasis> value);
        partial void OnCalculationBasisChanged();
        /// <summary>
        /// There are no comments for Property CalculateBasePricePurchase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculateBasePricePurchase")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CalculateBasePricePurchase
        {
            get
            {
                return this._CalculateBasePricePurchase;
            }
            set
            {
                this.OnCalculateBasePricePurchaseChanging(value);
                this._CalculateBasePricePurchase = value;
                this.OnCalculateBasePricePurchaseChanged();
                this.OnPropertyChanged("CalculateBasePricePurchase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CalculateBasePricePurchase;
        partial void OnCalculateBasePricePurchaseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCalculateBasePricePurchaseChanged();
        /// <summary>
        /// There are no comments for Property ChargeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeCode")]
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
        /// There are no comments for Property CalculateMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculateMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceTermCalculateMethod> CalculateMethod
        {
            get
            {
                return this._CalculateMethod;
            }
            set
            {
                this.OnCalculateMethodChanging(value);
                this._CalculateMethod = value;
                this.OnCalculateMethodChanged();
                this.OnPropertyChanged("CalculateMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceTermCalculateMethod> _CalculateMethod;
        partial void OnCalculateMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceTermCalculateMethod> value);
        partial void OnCalculateMethodChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property CalculateBasePriceInventory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculateBasePriceInventory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CalculateBasePriceInventory
        {
            get
            {
                return this._CalculateBasePriceInventory;
            }
            set
            {
                this.OnCalculateBasePriceInventoryChanging(value);
                this._CalculateBasePriceInventory = value;
                this.OnCalculateBasePriceInventoryChanged();
                this.OnPropertyChanged("CalculateBasePriceInventory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CalculateBasePriceInventory;
        partial void OnCalculateBasePriceInventoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCalculateBasePriceInventoryChanged();
        /// <summary>
        /// There are no comments for Property CalculationSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculationSequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CalculationSequence is required.")]
        public virtual int CalculationSequence
        {
            get
            {
                return this._CalculationSequence;
            }
            set
            {
                this.OnCalculationSequenceChanging(value);
                this._CalculationSequence = value;
                this.OnCalculationSequenceChanged();
                this.OnPropertyChanged("CalculationSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CalculationSequence;
        partial void OnCalculationSequenceChanging(int value);
        partial void OnCalculationSequenceChanged();
        /// <summary>
        /// There are no comments for Property CalculateBasePriceSales in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculateBasePriceSales")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CalculateBasePriceSales
        {
            get
            {
                return this._CalculateBasePriceSales;
            }
            set
            {
                this.OnCalculateBasePriceSalesChanging(value);
                this._CalculateBasePriceSales = value;
                this.OnCalculateBasePriceSalesChanged();
                this.OnPropertyChanged("CalculateBasePriceSales");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CalculateBasePriceSales;
        partial void OnCalculateBasePriceSalesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCalculateBasePriceSalesChanged();
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