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
    /// There are no comments for ItemHazardousMaterialSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemHazardousMaterialSingle")]
    public partial class ItemHazardousMaterialSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemHazardousMaterial>
    {
        /// <summary>
        /// Initialize a new ItemHazardousMaterialSingle object.
        /// </summary>
        public ItemHazardousMaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemHazardousMaterialSingle object.
        /// </summary>
        public ItemHazardousMaterialSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemHazardousMaterialSingle object.
        /// </summary>
        public ItemHazardousMaterialSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemHazardousMaterial> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ItemHazardousMaterial in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemId
    /// RegCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemId", "RegCode")]
    [global::Microsoft.OData.Client.EntitySet("ItemHazardousMaterials")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemHazardousMaterial")]
    public partial class ItemHazardousMaterial : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemHazardousMaterial object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="regCode">Initial value of RegCode.</param>
        /// <param name="multiplier">Initial value of Multiplier.</param>
        /// <param name="qty">Initial value of Qty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemHazardousMaterial CreateItemHazardousMaterial(string dataAreaId, string itemId, string regCode, decimal multiplier, decimal qty)
        {
            ItemHazardousMaterial itemHazardousMaterial = new ItemHazardousMaterial();
            itemHazardousMaterial.DataAreaId = dataAreaId;
            itemHazardousMaterial.ItemId = itemId;
            itemHazardousMaterial.RegCode = regCode;
            itemHazardousMaterial.Multiplier = multiplier;
            itemHazardousMaterial.Qty = qty;
            return itemHazardousMaterial;
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
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property RegCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegCode is required.")]
        public virtual string RegCode
        {
            get
            {
                return this._RegCode;
            }
            set
            {
                this.OnRegCodeChanging(value);
                this._RegCode = value;
                this.OnRegCodeChanged();
                this.OnPropertyChanged("RegCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegCode;
        partial void OnRegCodeChanging(string value);
        partial void OnRegCodeChanged();
        /// <summary>
        /// There are no comments for Property MaterialDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaterialDescription")]
        public virtual string MaterialDescription
        {
            get
            {
                return this._MaterialDescription;
            }
            set
            {
                this.OnMaterialDescriptionChanging(value);
                this._MaterialDescription = value;
                this.OnMaterialDescriptionChanged();
                this.OnPropertyChanged("MaterialDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialDescription;
        partial void OnMaterialDescriptionChanging(string value);
        partial void OnMaterialDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ClassCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClassCode")]
        public virtual string ClassCode
        {
            get
            {
                return this._ClassCode;
            }
            set
            {
                this.OnClassCodeChanging(value);
                this._ClassCode = value;
                this.OnClassCodeChanged();
                this.OnPropertyChanged("ClassCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassCode;
        partial void OnClassCodeChanging(string value);
        partial void OnClassCodeChanged();
        /// <summary>
        /// There are no comments for Property LabelCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LabelCode")]
        public virtual string LabelCode
        {
            get
            {
                return this._LabelCode;
            }
            set
            {
                this.OnLabelCodeChanging(value);
                this._LabelCode = value;
                this.OnLabelCodeChanged();
                this.OnPropertyChanged("LabelCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LabelCode;
        partial void OnLabelCodeChanging(string value);
        partial void OnLabelCodeChanged();
        /// <summary>
        /// There are no comments for Property LimitedQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LimitedQty")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LimitedQty
        {
            get
            {
                return this._LimitedQty;
            }
            set
            {
                this.OnLimitedQtyChanging(value);
                this._LimitedQty = value;
                this.OnLimitedQtyChanged();
                this.OnPropertyChanged("LimitedQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LimitedQty;
        partial void OnLimitedQtyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLimitedQtyChanged();
        /// <summary>
        /// There are no comments for Property StowageCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StowageCode")]
        public virtual string StowageCode
        {
            get
            {
                return this._StowageCode;
            }
            set
            {
                this.OnStowageCodeChanging(value);
                this._StowageCode = value;
                this.OnStowageCodeChanged();
                this.OnPropertyChanged("StowageCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StowageCode;
        partial void OnStowageCodeChanging(string value);
        partial void OnStowageCodeChanged();
        /// <summary>
        /// There are no comments for Property EMSCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EMSCode")]
        public virtual string EMSCode
        {
            get
            {
                return this._EMSCode;
            }
            set
            {
                this.OnEMSCodeChanging(value);
                this._EMSCode = value;
                this.OnEMSCodeChanged();
                this.OnPropertyChanged("EMSCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EMSCode;
        partial void OnEMSCodeChanging(string value);
        partial void OnEMSCodeChanged();
        /// <summary>
        /// There are no comments for Property PackInstCodePassenger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackInstCodePassenger")]
        public virtual string PackInstCodePassenger
        {
            get
            {
                return this._PackInstCodePassenger;
            }
            set
            {
                this.OnPackInstCodePassengerChanging(value);
                this._PackInstCodePassenger = value;
                this.OnPackInstCodePassengerChanged();
                this.OnPropertyChanged("PackInstCodePassenger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackInstCodePassenger;
        partial void OnPackInstCodePassengerChanging(string value);
        partial void OnPackInstCodePassengerChanged();
        /// <summary>
        /// There are no comments for Property PackInstCodeCargo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackInstCodeCargo")]
        public virtual string PackInstCodeCargo
        {
            get
            {
                return this._PackInstCodeCargo;
            }
            set
            {
                this.OnPackInstCodeCargoChanging(value);
                this._PackInstCodeCargo = value;
                this.OnPackInstCodeCargoChanged();
                this.OnPropertyChanged("PackInstCodeCargo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackInstCodeCargo;
        partial void OnPackInstCodeCargoChanging(string value);
        partial void OnPackInstCodeCargoChanged();
        /// <summary>
        /// There are no comments for Property Multiplier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Multiplier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Multiplier is required.")]
        public virtual decimal Multiplier
        {
            get
            {
                return this._Multiplier;
            }
            set
            {
                this.OnMultiplierChanging(value);
                this._Multiplier = value;
                this.OnMultiplierChanged();
                this.OnPropertyChanged("Multiplier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Multiplier;
        partial void OnMultiplierChanging(decimal value);
        partial void OnMultiplierChanged();
        /// <summary>
        /// There are no comments for Property EnviroDangerous in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnviroDangerous")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnviroDangerous
        {
            get
            {
                return this._EnviroDangerous;
            }
            set
            {
                this.OnEnviroDangerousChanging(value);
                this._EnviroDangerous = value;
                this.OnEnviroDangerousChanged();
                this.OnPropertyChanged("EnviroDangerous");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnviroDangerous;
        partial void OnEnviroDangerousChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnviroDangerousChanged();
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
        /// There are no comments for Property ClassGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClassGroupCode")]
        public virtual string ClassGroupCode
        {
            get
            {
                return this._ClassGroupCode;
            }
            set
            {
                this.OnClassGroupCodeChanging(value);
                this._ClassGroupCode = value;
                this.OnClassGroupCodeChanged();
                this.OnPropertyChanged("ClassGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassGroupCode;
        partial void OnClassGroupCodeChanging(string value);
        partial void OnClassGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasure")]
        public virtual string UnitOfMeasure
        {
            get
            {
                return this._UnitOfMeasure;
            }
            set
            {
                this.OnUnitOfMeasureChanging(value);
                this._UnitOfMeasure = value;
                this.OnUnitOfMeasureChanged();
                this.OnPropertyChanged("UnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasure;
        partial void OnUnitOfMeasureChanging(string value);
        partial void OnUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property MaterialCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaterialCode")]
        public virtual string MaterialCode
        {
            get
            {
                return this._MaterialCode;
            }
            set
            {
                this.OnMaterialCodeChanging(value);
                this._MaterialCode = value;
                this.OnMaterialCodeChanged();
                this.OnPropertyChanged("MaterialCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialCode;
        partial void OnMaterialCodeChanging(string value);
        partial void OnMaterialCodeChanged();
        /// <summary>
        /// There are no comments for Property TechnicalNameCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalNameCode")]
        public virtual string TechnicalNameCode
        {
            get
            {
                return this._TechnicalNameCode;
            }
            set
            {
                this.OnTechnicalNameCodeChanging(value);
                this._TechnicalNameCode = value;
                this.OnTechnicalNameCodeChanged();
                this.OnPropertyChanged("TechnicalNameCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalNameCode;
        partial void OnTechnicalNameCodeChanging(string value);
        partial void OnTechnicalNameCodeChanged();
        /// <summary>
        /// There are no comments for Property TransportCategoryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportCategoryCode")]
        public virtual string TransportCategoryCode
        {
            get
            {
                return this._TransportCategoryCode;
            }
            set
            {
                this.OnTransportCategoryCodeChanging(value);
                this._TransportCategoryCode = value;
                this.OnTransportCategoryCodeChanged();
                this.OnPropertyChanged("TransportCategoryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportCategoryCode;
        partial void OnTransportCategoryCodeChanging(string value);
        partial void OnTransportCategoryCodeChanged();
        /// <summary>
        /// There are no comments for Property IdentificationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationCode")]
        public virtual string IdentificationCode
        {
            get
            {
                return this._IdentificationCode;
            }
            set
            {
                this.OnIdentificationCodeChanging(value);
                this._IdentificationCode = value;
                this.OnIdentificationCodeChanged();
                this.OnPropertyChanged("IdentificationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationCode;
        partial void OnIdentificationCodeChanging(string value);
        partial void OnIdentificationCodeChanged();
        /// <summary>
        /// There are no comments for Property Flashpoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Flashpoint")]
        public virtual string Flashpoint
        {
            get
            {
                return this._Flashpoint;
            }
            set
            {
                this.OnFlashpointChanging(value);
                this._Flashpoint = value;
                this.OnFlashpointChanged();
                this.OnPropertyChanged("Flashpoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Flashpoint;
        partial void OnFlashpointChanging(string value);
        partial void OnFlashpointChanged();
        /// <summary>
        /// There are no comments for Property MarinePollutant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MarinePollutant")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MarinePollutant
        {
            get
            {
                return this._MarinePollutant;
            }
            set
            {
                this.OnMarinePollutantChanging(value);
                this._MarinePollutant = value;
                this.OnMarinePollutantChanged();
                this.OnPropertyChanged("MarinePollutant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MarinePollutant;
        partial void OnMarinePollutantChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMarinePollutantChanged();
        /// <summary>
        /// There are no comments for Property IsMaterialRadioactive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsMaterialRadioactive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsMaterialRadioactive
        {
            get
            {
                return this._IsMaterialRadioactive;
            }
            set
            {
                this.OnIsMaterialRadioactiveChanging(value);
                this._IsMaterialRadioactive = value;
                this.OnIsMaterialRadioactiveChanged();
                this.OnPropertyChanged("IsMaterialRadioactive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsMaterialRadioactive;
        partial void OnIsMaterialRadioactiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsMaterialRadioactiveChanged();
        /// <summary>
        /// There are no comments for Property AirType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AirType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> AirType
        {
            get
            {
                return this._AirType;
            }
            set
            {
                this.OnAirTypeChanging(value);
                this._AirType = value;
                this.OnAirTypeChanged();
                this.OnPropertyChanged("AirType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> _AirType;
        partial void OnAirTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HMIMAirType> value);
        partial void OnAirTypeChanged();
        /// <summary>
        /// There are no comments for Property IATAStar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IATAStar")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IATAStar
        {
            get
            {
                return this._IATAStar;
            }
            set
            {
                this.OnIATAStarChanging(value);
                this._IATAStar = value;
                this.OnIATAStarChanged();
                this.OnPropertyChanged("IATAStar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IATAStar;
        partial void OnIATAStarChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIATAStarChanged();
        /// <summary>
        /// There are no comments for Property NOS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NOS")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> NOS
        {
            get
            {
                return this._NOS;
            }
            set
            {
                this.OnNOSChanging(value);
                this._NOS = value;
                this.OnNOSChanged();
                this.OnPropertyChanged("NOS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _NOS;
        partial void OnNOSChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNOSChanged();
        /// <summary>
        /// There are no comments for Property PackingGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackingGroupCode")]
        public virtual string PackingGroupCode
        {
            get
            {
                return this._PackingGroupCode;
            }
            set
            {
                this.OnPackingGroupCodeChanging(value);
                this._PackingGroupCode = value;
                this.OnPackingGroupCodeChanged();
                this.OnPropertyChanged("PackingGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackingGroupCode;
        partial void OnPackingGroupCodeChanging(string value);
        partial void OnPackingGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property DivisionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DivisionCode")]
        public virtual string DivisionCode
        {
            get
            {
                return this._DivisionCode;
            }
            set
            {
                this.OnDivisionCodeChanging(value);
                this._DivisionCode = value;
                this.OnDivisionCodeChanged();
                this.OnPropertyChanged("DivisionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DivisionCode;
        partial void OnDivisionCodeChanging(string value);
        partial void OnDivisionCodeChanged();
        /// <summary>
        /// There are no comments for Property TunnelCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TunnelCode")]
        public virtual string TunnelCode
        {
            get
            {
                return this._TunnelCode;
            }
            set
            {
                this.OnTunnelCodeChanging(value);
                this._TunnelCode = value;
                this.OnTunnelCodeChanged();
                this.OnPropertyChanged("TunnelCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TunnelCode;
        partial void OnTunnelCodeChanging(string value);
        partial void OnTunnelCodeChanged();
        /// <summary>
        /// There are no comments for Property PackCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackCode")]
        public virtual string PackCode
        {
            get
            {
                return this._PackCode;
            }
            set
            {
                this.OnPackCodeChanging(value);
                this._PackCode = value;
                this.OnPackCodeChanged();
                this.OnPropertyChanged("PackCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackCode;
        partial void OnPackCodeChanging(string value);
        partial void OnPackCodeChanged();
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
