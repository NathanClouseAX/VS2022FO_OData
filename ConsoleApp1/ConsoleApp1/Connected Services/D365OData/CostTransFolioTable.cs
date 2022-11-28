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
    /// There are no comments for CostTransFolioTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostTransFolioTableSingle")]
    public partial class CostTransFolioTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostTransFolioTable>
    {
        /// <summary>
        /// Initialize a new CostTransFolioTableSingle object.
        /// </summary>
        public CostTransFolioTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostTransFolioTableSingle object.
        /// </summary>
        public CostTransFolioTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostTransFolioTableSingle object.
        /// </summary>
        public CostTransFolioTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostTransFolioTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostTransFolioTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShipFolioId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShipFolioId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("CostTransFolioTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostTransFolioTable")]
    public partial class CostTransFolioTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostTransFolioTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shipFolioId">Initial value of ShipFolioId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="costValue">Initial value of CostValue.</param>
        /// <param name="minCostAmount">Initial value of MinCostAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostTransFolioTable CreateCostTransFolioTable(string dataAreaId, string shipFolioId, decimal lineNumber, decimal costValue, decimal minCostAmount)
        {
            CostTransFolioTable costTransFolioTable = new CostTransFolioTable();
            costTransFolioTable.DataAreaId = dataAreaId;
            costTransFolioTable.ShipFolioId = shipFolioId;
            costTransFolioTable.LineNumber = lineNumber;
            costTransFolioTable.CostValue = costValue;
            costTransFolioTable.MinCostAmount = minCostAmount;
            return costTransFolioTable;
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
        /// There are no comments for Property ShipFolioId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipFolioId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipFolioId is required.")]
        public virtual string ShipFolioId
        {
            get
            {
                return this._ShipFolioId;
            }
            set
            {
                this.OnShipFolioIdChanging(value);
                this._ShipFolioId = value;
                this.OnShipFolioIdChanged();
                this.OnPropertyChanged("ShipFolioId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipFolioId;
        partial void OnShipFolioIdChanging(string value);
        partial void OnShipFolioIdChanged();
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
        /// There are no comments for Property ShipCostTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipCostTypeId")]
        public virtual string ShipCostTypeId
        {
            get
            {
                return this._ShipCostTypeId;
            }
            set
            {
                this.OnShipCostTypeIdChanging(value);
                this._ShipCostTypeId = value;
                this.OnShipCostTypeIdChanged();
                this.OnPropertyChanged("ShipCostTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipCostTypeId;
        partial void OnShipCostTypeIdChanging(string value);
        partial void OnShipCostTypeIdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property CostValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostValue is required.")]
        public virtual decimal CostValue
        {
            get
            {
                return this._CostValue;
            }
            set
            {
                this.OnCostValueChanging(value);
                this._CostValue = value;
                this.OnCostValueChanged();
                this.OnPropertyChanged("CostValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostValue;
        partial void OnCostValueChanging(decimal value);
        partial void OnCostValueChanged();
        /// <summary>
        /// There are no comments for Property ShipCostCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipCostCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostCategory> ShipCostCategory
        {
            get
            {
                return this._ShipCostCategory;
            }
            set
            {
                this.OnShipCostCategoryChanging(value);
                this._ShipCostCategory = value;
                this.OnShipCostCategoryChanged();
                this.OnPropertyChanged("ShipCostCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostCategory> _ShipCostCategory;
        partial void OnShipCostCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostCategory> value);
        partial void OnShipCostCategoryChanged();
        /// <summary>
        /// There are no comments for Property ApportionmentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApportionmentMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostApportionmentMethod> ApportionmentMethod
        {
            get
            {
                return this._ApportionmentMethod;
            }
            set
            {
                this.OnApportionmentMethodChanging(value);
                this._ApportionmentMethod = value;
                this.OnApportionmentMethodChanged();
                this.OnPropertyChanged("ApportionmentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostApportionmentMethod> _ApportionmentMethod;
        partial void OnApportionmentMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ITMCostApportionmentMethod> value);
        partial void OnApportionmentMethodChanged();
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
        /// There are no comments for Property LinkCostTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkCostTypeId")]
        public virtual string LinkCostTypeId
        {
            get
            {
                return this._LinkCostTypeId;
            }
            set
            {
                this.OnLinkCostTypeIdChanging(value);
                this._LinkCostTypeId = value;
                this.OnLinkCostTypeIdChanged();
                this.OnPropertyChanged("LinkCostTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinkCostTypeId;
        partial void OnLinkCostTypeIdChanging(string value);
        partial void OnLinkCostTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ShipDataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipDataArea")]
        public virtual string ShipDataArea
        {
            get
            {
                return this._ShipDataArea;
            }
            set
            {
                this.OnShipDataAreaChanging(value);
                this._ShipDataArea = value;
                this.OnShipDataAreaChanged();
                this.OnPropertyChanged("ShipDataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipDataArea;
        partial void OnShipDataAreaChanging(string value);
        partial void OnShipDataAreaChanged();
        /// <summary>
        /// There are no comments for Property MinCostAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinCostAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinCostAmount is required.")]
        public virtual decimal MinCostAmount
        {
            get
            {
                return this._MinCostAmount;
            }
            set
            {
                this.OnMinCostAmountChanging(value);
                this._MinCostAmount = value;
                this.OnMinCostAmountChanged();
                this.OnPropertyChanged("MinCostAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinCostAmount;
        partial void OnMinCostAmountChanging(decimal value);
        partial void OnMinCostAmountChanged();
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
