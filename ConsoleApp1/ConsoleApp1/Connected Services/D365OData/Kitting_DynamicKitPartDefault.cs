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
    /// There are no comments for Kitting_DynamicKitPartDefaultSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Kitting_DynamicKitPartDefaultSingle")]
    public partial class Kitting_DynamicKitPartDefaultSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKitPartDefault>
    {
        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartDefaultSingle object.
        /// </summary>
        public Kitting_DynamicKitPartDefaultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartDefaultSingle object.
        /// </summary>
        public Kitting_DynamicKitPartDefaultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartDefaultSingle object.
        /// </summary>
        public Kitting_DynamicKitPartDefaultSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKitPartDefault> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Kitting_DynamicKitPartDefault in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DynamicKitId
    /// DynamicPartGroup
    /// ItemNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DynamicKitId", "DynamicPartGroup", "ItemNumber")]
    [global::Microsoft.OData.Client.EntitySet("Kitting_DynamicKitPartDefaults")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Kitting_DynamicKitPartDefault")]
    public partial class Kitting_DynamicKitPartDefault : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Kitting_DynamicKitPartDefault object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="dynamicKitId">Initial value of DynamicKitId.</param>
        /// <param name="dynamicPartGroup">Initial value of DynamicPartGroup.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="roundUpQty">Initial value of RoundUpQty.</param>
        /// <param name="bOMQtySerie">Initial value of BOMQtySerie.</param>
        /// <param name="constant">Initial value of Constant.</param>
        /// <param name="qty">Initial value of Qty.</param>
        /// <param name="height">Initial value of Height.</param>
        /// <param name="depth">Initial value of Depth.</param>
        /// <param name="density">Initial value of Density.</param>
        /// <param name="width">Initial value of Width.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Kitting_DynamicKitPartDefault CreateKitting_DynamicKitPartDefault(string dataAreaId, 
                    string dynamicKitId, 
                    string dynamicPartGroup, 
                    string itemNumber, 
                    decimal roundUpQty, 
                    decimal bOMQtySerie, 
                    decimal constant, 
                    decimal qty, 
                    decimal height, 
                    decimal depth, 
                    decimal density, 
                    decimal width)
        {
            Kitting_DynamicKitPartDefault kitting_DynamicKitPartDefault = new Kitting_DynamicKitPartDefault();
            kitting_DynamicKitPartDefault.DataAreaId = dataAreaId;
            kitting_DynamicKitPartDefault.DynamicKitId = dynamicKitId;
            kitting_DynamicKitPartDefault.DynamicPartGroup = dynamicPartGroup;
            kitting_DynamicKitPartDefault.ItemNumber = itemNumber;
            kitting_DynamicKitPartDefault.RoundUpQty = roundUpQty;
            kitting_DynamicKitPartDefault.BOMQtySerie = bOMQtySerie;
            kitting_DynamicKitPartDefault.Constant = constant;
            kitting_DynamicKitPartDefault.Qty = qty;
            kitting_DynamicKitPartDefault.Height = height;
            kitting_DynamicKitPartDefault.Depth = depth;
            kitting_DynamicKitPartDefault.Density = density;
            kitting_DynamicKitPartDefault.Width = width;
            return kitting_DynamicKitPartDefault;
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
        /// There are no comments for Property DynamicKitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicKitId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DynamicKitId is required.")]
        public virtual string DynamicKitId
        {
            get
            {
                return this._DynamicKitId;
            }
            set
            {
                this.OnDynamicKitIdChanging(value);
                this._DynamicKitId = value;
                this.OnDynamicKitIdChanged();
                this.OnPropertyChanged("DynamicKitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicKitId;
        partial void OnDynamicKitIdChanging(string value);
        partial void OnDynamicKitIdChanged();
        /// <summary>
        /// There are no comments for Property DynamicPartGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicPartGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DynamicPartGroup is required.")]
        public virtual string DynamicPartGroup
        {
            get
            {
                return this._DynamicPartGroup;
            }
            set
            {
                this.OnDynamicPartGroupChanging(value);
                this._DynamicPartGroup = value;
                this.OnDynamicPartGroupChanged();
                this.OnPropertyChanged("DynamicPartGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicPartGroup;
        partial void OnDynamicPartGroupChanging(string value);
        partial void OnDynamicPartGroupChanged();
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
        /// There are no comments for Property RoundUpQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RoundUpQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoundUpQty is required.")]
        public virtual decimal RoundUpQty
        {
            get
            {
                return this._RoundUpQty;
            }
            set
            {
                this.OnRoundUpQtyChanging(value);
                this._RoundUpQty = value;
                this.OnRoundUpQtyChanged();
                this.OnPropertyChanged("RoundUpQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RoundUpQty;
        partial void OnRoundUpQtyChanging(decimal value);
        partial void OnRoundUpQtyChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsumptionWarehouseId")]
        public virtual string ConsumptionWarehouseId
        {
            get
            {
                return this._ConsumptionWarehouseId;
            }
            set
            {
                this.OnConsumptionWarehouseIdChanging(value);
                this._ConsumptionWarehouseId = value;
                this.OnConsumptionWarehouseIdChanged();
                this.OnPropertyChanged("ConsumptionWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsumptionWarehouseId;
        partial void OnConsumptionWarehouseIdChanging(string value);
        partial void OnConsumptionWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property RoundUp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RoundUp")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> RoundUp
        {
            get
            {
                return this._RoundUp;
            }
            set
            {
                this.OnRoundUpChanging(value);
                this._RoundUp = value;
                this.OnRoundUpChanged();
                this.OnPropertyChanged("RoundUp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> _RoundUp;
        partial void OnRoundUpChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMRoundUp> value);
        partial void OnRoundUpChanged();
        /// <summary>
        /// There are no comments for Property BOMQtySerie in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BOMQtySerie")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BOMQtySerie is required.")]
        public virtual decimal BOMQtySerie
        {
            get
            {
                return this._BOMQtySerie;
            }
            set
            {
                this.OnBOMQtySerieChanging(value);
                this._BOMQtySerie = value;
                this.OnBOMQtySerieChanged();
                this.OnPropertyChanged("BOMQtySerie");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BOMQtySerie;
        partial void OnBOMQtySerieChanging(decimal value);
        partial void OnBOMQtySerieChanged();
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
        /// There are no comments for Property Constant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Constant")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Constant is required.")]
        public virtual decimal Constant
        {
            get
            {
                return this._Constant;
            }
            set
            {
                this.OnConstantChanging(value);
                this._Constant = value;
                this.OnConstantChanged();
                this.OnPropertyChanged("Constant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Constant;
        partial void OnConstantChanging(decimal value);
        partial void OnConstantChanged();
        /// <summary>
        /// There are no comments for Property Qty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Qty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Qty is required.")]
        public virtual decimal Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this.OnQtyChanging(value);
                this._Qty = value;
                this.OnQtyChanged();
                this.OnPropertyChanged("Qty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Qty;
        partial void OnQtyChanging(decimal value);
        partial void OnQtyChanged();
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
        /// There are no comments for Property Height in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Height")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Height is required.")]
        public virtual decimal Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.OnHeightChanging(value);
                this._Height = value;
                this.OnHeightChanged();
                this.OnPropertyChanged("Height");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Height;
        partial void OnHeightChanging(decimal value);
        partial void OnHeightChanged();
        /// <summary>
        /// There are no comments for Property Exclude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Exclude")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Exclude
        {
            get
            {
                return this._Exclude;
            }
            set
            {
                this.OnExcludeChanging(value);
                this._Exclude = value;
                this.OnExcludeChanged();
                this.OnPropertyChanged("Exclude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Exclude;
        partial void OnExcludeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExcludeChanged();
        /// <summary>
        /// There are no comments for Property Depth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Depth")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Depth is required.")]
        public virtual decimal Depth
        {
            get
            {
                return this._Depth;
            }
            set
            {
                this.OnDepthChanging(value);
                this._Depth = value;
                this.OnDepthChanged();
                this.OnPropertyChanged("Depth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Depth;
        partial void OnDepthChanging(decimal value);
        partial void OnDepthChanged();
        /// <summary>
        /// There are no comments for Property Density in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Density")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Density is required.")]
        public virtual decimal Density
        {
            get
            {
                return this._Density;
            }
            set
            {
                this.OnDensityChanging(value);
                this._Density = value;
                this.OnDensityChanged();
                this.OnPropertyChanged("Density");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Density;
        partial void OnDensityChanging(decimal value);
        partial void OnDensityChanged();
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
        /// There are no comments for Property Width in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Width")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Width is required.")]
        public virtual decimal Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this.OnWidthChanging(value);
                this._Width = value;
                this.OnWidthChanged();
                this.OnPropertyChanged("Width");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Width;
        partial void OnWidthChanging(decimal value);
        partial void OnWidthChanged();
        /// <summary>
        /// There are no comments for Property BOMConsump in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BOMConsump")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> BOMConsump
        {
            get
            {
                return this._BOMConsump;
            }
            set
            {
                this.OnBOMConsumpChanging(value);
                this._BOMConsump = value;
                this.OnBOMConsumpChanged();
                this.OnPropertyChanged("BOMConsump");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> _BOMConsump;
        partial void OnBOMConsumpChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BOMConsumpType> value);
        partial void OnBOMConsumpChanged();
        /// <summary>
        /// There are no comments for Property ConsumptionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsumptionSiteId")]
        public virtual string ConsumptionSiteId
        {
            get
            {
                return this._ConsumptionSiteId;
            }
            set
            {
                this.OnConsumptionSiteIdChanging(value);
                this._ConsumptionSiteId = value;
                this.OnConsumptionSiteIdChanged();
                this.OnPropertyChanged("ConsumptionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsumptionSiteId;
        partial void OnConsumptionSiteIdChanging(string value);
        partial void OnConsumptionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property Formula in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Formula")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.KittingBOMFormula> Formula
        {
            get
            {
                return this._Formula;
            }
            set
            {
                this.OnFormulaChanging(value);
                this._Formula = value;
                this.OnFormulaChanged();
                this.OnPropertyChanged("Formula");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.KittingBOMFormula> _Formula;
        partial void OnFormulaChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.KittingBOMFormula> value);
        partial void OnFormulaChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitId")]
        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
        /// <summary>
        /// There are no comments for Property IsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefault")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefault
        {
            get
            {
                return this._IsDefault;
            }
            set
            {
                this.OnIsDefaultChanging(value);
                this._IsDefault = value;
                this.OnIsDefaultChanged();
                this.OnPropertyChanged("IsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefault;
        partial void OnIsDefaultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultChanged();
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
