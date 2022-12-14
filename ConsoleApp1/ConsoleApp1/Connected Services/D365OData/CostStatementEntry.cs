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
    /// There are no comments for CostStatementEntrySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostStatementEntrySingle")]
    public partial class CostStatementEntrySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostStatementEntry>
    {
        /// <summary>
        /// Initialize a new CostStatementEntrySingle object.
        /// </summary>
        public CostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostStatementEntrySingle object.
        /// </summary>
        public CostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostStatementEntrySingle object.
        /// </summary>
        public CostStatementEntrySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostStatementEntry> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OperationalSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationalSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle OperationalSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperationalSite == null))
                {
                    this._OperationalSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("OperationalSite"));
                }
                return this._OperationalSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _OperationalSite;
    }
    /// <summary>
    /// There are no comments for CostStatementEntry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CostStatementType
    /// AccountingDate
    /// LevelOneCostStatementLineCategoryName
    /// LevelTwoCostStatementLineCategoryName
    /// LevelThreeCostStatementLineCategoryName
    /// OperationalSiteId
    /// CostResourceType
    /// CostResourceId
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CostStatementType", "AccountingDate", "LevelOneCostStatementLineCategoryName", "LevelTwoCostStatementLineCategoryName", "LevelThreeCostStatementLineCategoryName", "OperationalSiteId", "CostResourceType", "CostResourceId", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("CostStatementEntries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostStatementEntry")]
    public partial class CostStatementEntry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostStatementEntry object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        /// <param name="operationalSiteId">Initial value of OperationalSiteId.</param>
        /// <param name="costResourceId">Initial value of CostResourceId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="costAmount">Initial value of CostAmount.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostStatementEntry CreateCostStatementEntry(string dataAreaId, 
                    global::System.DateTimeOffset accountingDate, 
                    string operationalSiteId, 
                    string costResourceId, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    decimal costAmount, 
                    decimal quantity)
        {
            CostStatementEntry costStatementEntry = new CostStatementEntry();
            costStatementEntry.DataAreaId = dataAreaId;
            costStatementEntry.AccountingDate = accountingDate;
            costStatementEntry.OperationalSiteId = operationalSiteId;
            costStatementEntry.CostResourceId = costResourceId;
            costStatementEntry.ProductConfigurationId = productConfigurationId;
            costStatementEntry.ProductColorId = productColorId;
            costStatementEntry.ProductSizeId = productSizeId;
            costStatementEntry.ProductStyleId = productStyleId;
            costStatementEntry.CostAmount = costAmount;
            costStatementEntry.Quantity = quantity;
            return costStatementEntry;
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
        /// There are no comments for Property CostStatementType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostStatementType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> CostStatementType
        {
            get
            {
                return this._CostStatementType;
            }
            set
            {
                this.OnCostStatementTypeChanging(value);
                this._CostStatementType = value;
                this.OnCostStatementTypeChanged();
                this.OnPropertyChanged("CostStatementType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> _CostStatementType;
        partial void OnCostStatementTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementType> value);
        partial void OnCostStatementTypeChanged();
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
        /// There are no comments for Property LevelOneCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelOneCostStatementLineCategoryName")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> LevelOneCostStatementLineCategoryName
        {
            get
            {
                return this._LevelOneCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelOneCostStatementLineCategoryNameChanging(value);
                this._LevelOneCostStatementLineCategoryName = value;
                this.OnLevelOneCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelOneCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> _LevelOneCostStatementLineCategoryName;
        partial void OnLevelOneCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel1> value);
        partial void OnLevelOneCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LevelTwoCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelTwoCostStatementLineCategoryName")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> LevelTwoCostStatementLineCategoryName
        {
            get
            {
                return this._LevelTwoCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelTwoCostStatementLineCategoryNameChanging(value);
                this._LevelTwoCostStatementLineCategoryName = value;
                this.OnLevelTwoCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelTwoCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> _LevelTwoCostStatementLineCategoryName;
        partial void OnLevelTwoCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel2> value);
        partial void OnLevelTwoCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property LevelThreeCostStatementLineCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelThreeCostStatementLineCategoryName")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> LevelThreeCostStatementLineCategoryName
        {
            get
            {
                return this._LevelThreeCostStatementLineCategoryName;
            }
            set
            {
                this.OnLevelThreeCostStatementLineCategoryNameChanging(value);
                this._LevelThreeCostStatementLineCategoryName = value;
                this.OnLevelThreeCostStatementLineCategoryNameChanged();
                this.OnPropertyChanged("LevelThreeCostStatementLineCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> _LevelThreeCostStatementLineCategoryName;
        partial void OnLevelThreeCostStatementLineCategoryNameChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CostStatementLineCategoryLevel3> value);
        partial void OnLevelThreeCostStatementLineCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property OperationalSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationalSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperationalSiteId is required.")]
        public virtual string OperationalSiteId
        {
            get
            {
                return this._OperationalSiteId;
            }
            set
            {
                this.OnOperationalSiteIdChanging(value);
                this._OperationalSiteId = value;
                this.OnOperationalSiteIdChanged();
                this.OnPropertyChanged("OperationalSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationalSiteId;
        partial void OnOperationalSiteIdChanging(string value);
        partial void OnOperationalSiteIdChanged();
        /// <summary>
        /// There are no comments for Property CostResourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostResourceType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> CostResourceType
        {
            get
            {
                return this._CostResourceType;
            }
            set
            {
                this.OnCostResourceTypeChanging(value);
                this._CostResourceType = value;
                this.OnCostResourceTypeChanged();
                this.OnPropertyChanged("CostResourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> _CostResourceType;
        partial void OnCostResourceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventValueReportResourceType> value);
        partial void OnCostResourceTypeChanged();
        /// <summary>
        /// There are no comments for Property CostResourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostResourceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostResourceId is required.")]
        public virtual string CostResourceId
        {
            get
            {
                return this._CostResourceId;
            }
            set
            {
                this.OnCostResourceIdChanging(value);
                this._CostResourceId = value;
                this.OnCostResourceIdChanged();
                this.OnPropertyChanged("CostResourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostResourceId;
        partial void OnCostResourceIdChanging(string value);
        partial void OnCostResourceIdChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductConfigurationId is required.")]
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
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorId is required.")]
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
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductSizeId is required.")]
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
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleId is required.")]
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
        /// There are no comments for Property CostResourceGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostResourceGroupId")]
        public virtual string CostResourceGroupId
        {
            get
            {
                return this._CostResourceGroupId;
            }
            set
            {
                this.OnCostResourceGroupIdChanging(value);
                this._CostResourceGroupId = value;
                this.OnCostResourceGroupIdChanged();
                this.OnPropertyChanged("CostResourceGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostResourceGroupId;
        partial void OnCostResourceGroupIdChanging(string value);
        partial void OnCostResourceGroupIdChanged();
        /// <summary>
        /// There are no comments for Property CostAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostAmount is required.")]
        public virtual decimal CostAmount
        {
            get
            {
                return this._CostAmount;
            }
            set
            {
                this.OnCostAmountChanging(value);
                this._CostAmount = value;
                this.OnCostAmountChanged();
                this.OnPropertyChanged("CostAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostAmount;
        partial void OnCostAmountChanging(decimal value);
        partial void OnCostAmountChanged();
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
        /// There are no comments for Property OperationalSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationalSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite OperationalSite
        {
            get
            {
                return this._OperationalSite;
            }
            set
            {
                this.OnOperationalSiteChanging(value);
                this._OperationalSite = value;
                this.OnOperationalSiteChanged();
                this.OnPropertyChanged("OperationalSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _OperationalSite;
        partial void OnOperationalSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnOperationalSiteChanged();
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
