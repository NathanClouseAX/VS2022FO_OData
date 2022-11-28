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
    /// There are no comments for ReleaseKindTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleaseKindTableSingle")]
    public partial class ReleaseKindTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleaseKindTable>
    {
        /// <summary>
        /// Initialize a new ReleaseKindTableSingle object.
        /// </summary>
        public ReleaseKindTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleaseKindTableSingle object.
        /// </summary>
        public ReleaseKindTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleaseKindTableSingle object.
        /// </summary>
        public ReleaseKindTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleaseKindTable> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
    /// <summary>
    /// There are no comments for ReleaseKindTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ReleaseKindId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReleaseKindId")]
    [global::Microsoft.OData.Client.EntitySet("ReleaseKindTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleaseKindTable")]
    public partial class ReleaseKindTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleaseKindTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="releaseKindId">Initial value of ReleaseKindId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleaseKindTable CreateReleaseKindTable(string dataAreaId, string releaseKindId)
        {
            ReleaseKindTable releaseKindTable = new ReleaseKindTable();
            releaseKindTable.DataAreaId = dataAreaId;
            releaseKindTable.ReleaseKindId = releaseKindId;
            return releaseKindTable;
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
        /// There are no comments for Property ReleaseKindId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleaseKindId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleaseKindId is required.")]
        public virtual string ReleaseKindId
        {
            get
            {
                return this._ReleaseKindId;
            }
            set
            {
                this.OnReleaseKindIdChanging(value);
                this._ReleaseKindId = value;
                this.OnReleaseKindIdChanged();
                this.OnPropertyChanged("ReleaseKindId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleaseKindId;
        partial void OnReleaseKindIdChanging(string value);
        partial void OnReleaseKindIdChanged();
        /// <summary>
        /// There are no comments for Property DefectiveProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefectiveProduct")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DefectiveProduct
        {
            get
            {
                return this._DefectiveProduct;
            }
            set
            {
                this.OnDefectiveProductChanging(value);
                this._DefectiveProduct = value;
                this.OnDefectiveProductChanged();
                this.OnPropertyChanged("DefectiveProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DefectiveProduct;
        partial void OnDefectiveProductChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDefectiveProductChanged();
        /// <summary>
        /// There are no comments for Property Warehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Warehouse")]
        public virtual string Warehouse
        {
            get
            {
                return this._Warehouse;
            }
            set
            {
                this.OnWarehouseChanging(value);
                this._Warehouse = value;
                this.OnWarehouseChanged();
                this.OnPropertyChanged("Warehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Warehouse;
        partial void OnWarehouseChanging(string value);
        partial void OnWarehouseChanged();
        /// <summary>
        /// There are no comments for Property CostingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostingRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProdReleaseCalcPrinciple_RU> CostingRule
        {
            get
            {
                return this._CostingRule;
            }
            set
            {
                this.OnCostingRuleChanging(value);
                this._CostingRule = value;
                this.OnCostingRuleChanged();
                this.OnPropertyChanged("CostingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProdReleaseCalcPrinciple_RU> _CostingRule;
        partial void OnCostingRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProdReleaseCalcPrinciple_RU> value);
        partial void OnCostingRuleChanged();
        /// <summary>
        /// There are no comments for Property Scrap in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Scrap")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Scrap
        {
            get
            {
                return this._Scrap;
            }
            set
            {
                this.OnScrapChanging(value);
                this._Scrap = value;
                this.OnScrapChanged();
                this.OnPropertyChanged("Scrap");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Scrap;
        partial void OnScrapChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnScrapChanged();
        /// <summary>
        /// There are no comments for Property LossPhysLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LossPhysLedgerDimensionDisplayValue")]
        public virtual string LossPhysLedgerDimensionDisplayValue
        {
            get
            {
                return this._LossPhysLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnLossPhysLedgerDimensionDisplayValueChanging(value);
                this._LossPhysLedgerDimensionDisplayValue = value;
                this.OnLossPhysLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("LossPhysLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LossPhysLedgerDimensionDisplayValue;
        partial void OnLossPhysLedgerDimensionDisplayValueChanging(string value);
        partial void OnLossPhysLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property LossAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LossAccountDisplayValue")]
        public virtual string LossAccountDisplayValue
        {
            get
            {
                return this._LossAccountDisplayValue;
            }
            set
            {
                this.OnLossAccountDisplayValueChanging(value);
                this._LossAccountDisplayValue = value;
                this.OnLossAccountDisplayValueChanged();
                this.OnPropertyChanged("LossAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LossAccountDisplayValue;
        partial void OnLossAccountDisplayValueChanging(string value);
        partial void OnLossAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
