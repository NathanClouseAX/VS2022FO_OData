//------------------------------------------------------------------------------
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
    /// There are no comments for RoutePendingRouteCostCategoryUnitCostSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RoutePendingRouteCostCategoryUnitCostSingle")]
    public partial class RoutePendingRouteCostCategoryUnitCostSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoutePendingRouteCostCategoryUnitCost>
    {
        /// <summary>
        /// Initialize a new RoutePendingRouteCostCategoryUnitCostSingle object.
        /// </summary>
        public RoutePendingRouteCostCategoryUnitCostSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoutePendingRouteCostCategoryUnitCostSingle object.
        /// </summary>
        public RoutePendingRouteCostCategoryUnitCostSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoutePendingRouteCostCategoryUnitCostSingle object.
        /// </summary>
        public RoutePendingRouteCostCategoryUnitCostSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoutePendingRouteCostCategoryUnitCost> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle ProductionSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductionSite == null))
                {
                    this._ProductionSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("ProductionSite"));
                }
                return this._ProductionSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _ProductionSite;
        /// <summary>
        /// There are no comments for CostingVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CostingVersion")]
        public virtual global::Microsoft.Dynamics.DataEntities.CostingVersionSingle CostingVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CostingVersion == null))
                {
                    this._CostingVersion = new global::Microsoft.Dynamics.DataEntities.CostingVersionSingle(this.Context, GetPath("CostingVersion"));
                }
                return this._CostingVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CostingVersionSingle _CostingVersion;
    }
    /// <summary>
    /// There are no comments for RoutePendingRouteCostCategoryUnitCost in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RouteCostCategoryId
    /// CostingVersionId
    /// ProductionSiteId
    /// EffectiveDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RouteCostCategoryId", "CostingVersionId", "ProductionSiteId", "EffectiveDate")]
    [global::Microsoft.OData.Client.EntitySet("RoutePendingRouteCostCategoryUnitCosts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RoutePendingRouteCostCategoryUnitCost")]
    public partial class RoutePendingRouteCostCategoryUnitCost : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoutePendingRouteCostCategoryUnitCost object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="routeCostCategoryId">Initial value of RouteCostCategoryId.</param>
        /// <param name="costingVersionId">Initial value of CostingVersionId.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="unitCost">Initial value of UnitCost.</param>
        /// <param name="costingVersion">Initial value of CostingVersion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoutePendingRouteCostCategoryUnitCost CreateRoutePendingRouteCostCategoryUnitCost(string dataAreaId, 
                    string routeCostCategoryId, 
                    string costingVersionId, 
                    string productionSiteId, 
                    global::System.DateTimeOffset effectiveDate, 
                    decimal unitCost, 
                    global::Microsoft.Dynamics.DataEntities.CostingVersion costingVersion)
        {
            RoutePendingRouteCostCategoryUnitCost routePendingRouteCostCategoryUnitCost = new RoutePendingRouteCostCategoryUnitCost();
            routePendingRouteCostCategoryUnitCost.DataAreaId = dataAreaId;
            routePendingRouteCostCategoryUnitCost.RouteCostCategoryId = routeCostCategoryId;
            routePendingRouteCostCategoryUnitCost.CostingVersionId = costingVersionId;
            routePendingRouteCostCategoryUnitCost.ProductionSiteId = productionSiteId;
            routePendingRouteCostCategoryUnitCost.EffectiveDate = effectiveDate;
            routePendingRouteCostCategoryUnitCost.UnitCost = unitCost;
            if ((costingVersion == null))
            {
                throw new global::System.ArgumentNullException("costingVersion");
            }
            routePendingRouteCostCategoryUnitCost.CostingVersion = costingVersion;
            return routePendingRouteCostCategoryUnitCost;
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
        /// There are no comments for Property RouteCostCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteCostCategoryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RouteCostCategoryId is required.")]
        public virtual string RouteCostCategoryId
        {
            get
            {
                return this._RouteCostCategoryId;
            }
            set
            {
                this.OnRouteCostCategoryIdChanging(value);
                this._RouteCostCategoryId = value;
                this.OnRouteCostCategoryIdChanged();
                this.OnPropertyChanged("RouteCostCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteCostCategoryId;
        partial void OnRouteCostCategoryIdChanging(string value);
        partial void OnRouteCostCategoryIdChanged();
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
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductionSiteId is required.")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
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
        /// There are no comments for Property ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite ProductionSite
        {
            get
            {
                return this._ProductionSite;
            }
            set
            {
                this.OnProductionSiteChanging(value);
                this._ProductionSite = value;
                this.OnProductionSiteChanged();
                this.OnPropertyChanged("ProductionSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _ProductionSite;
        partial void OnProductionSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnProductionSiteChanged();
        /// <summary>
        /// There are no comments for Property CostingVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostingVersion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostingVersion is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CostingVersion CostingVersion
        {
            get
            {
                return this._CostingVersion;
            }
            set
            {
                this.OnCostingVersionChanging(value);
                this._CostingVersion = value;
                this.OnCostingVersionChanged();
                this.OnPropertyChanged("CostingVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CostingVersion _CostingVersion;
        partial void OnCostingVersionChanging(global::Microsoft.Dynamics.DataEntities.CostingVersion value);
        partial void OnCostingVersionChanged();
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
