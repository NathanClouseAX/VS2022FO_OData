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
    /// There are no comments for AddressObjectSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressObjectSingle")]
    public partial class AddressObjectSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressObject>
    {
        /// <summary>
        /// Initialize a new AddressObjectSingle object.
        /// </summary>
        public AddressObjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressObjectSingle object.
        /// </summary>
        public AddressObjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressObjectSingle object.
        /// </summary>
        public AddressObjectSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressObject> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AddressObject in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AOId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AOId")]
    [global::Microsoft.OData.Client.EntitySet("AddressObjects")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressObject")]
    public partial class AddressObject : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressObject object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="aOId">Initial value of AOId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressObject CreateAddressObject(string dataAreaId, string aOId)
        {
            AddressObject addressObject = new AddressObject();
            addressObject.DataAreaId = dataAreaId;
            addressObject.AOId = aOId;
            return addressObject;
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
        /// There are no comments for Property AOId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AOId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AOId is required.")]
        public virtual string AOId
        {
            get
            {
                return this._AOId;
            }
            set
            {
                this.OnAOIdChanging(value);
                this._AOId = value;
                this.OnAOIdChanged();
                this.OnPropertyChanged("AOId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AOId;
        partial void OnAOIdChanging(string value);
        partial void OnAOIdChanged();
        /// <summary>
        /// There are no comments for Property OperStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperStatus")]
        public virtual string OperStatus
        {
            get
            {
                return this._OperStatus;
            }
            set
            {
                this.OnOperStatusChanging(value);
                this._OperStatus = value;
                this.OnOperStatusChanged();
                this.OnPropertyChanged("OperStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperStatus;
        partial void OnOperStatusChanging(string value);
        partial void OnOperStatusChanged();
        /// <summary>
        /// There are no comments for Property ExtrCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtrCode")]
        public virtual string ExtrCode
        {
            get
            {
                return this._ExtrCode;
            }
            set
            {
                this.OnExtrCodeChanging(value);
                this._ExtrCode = value;
                this.OnExtrCodeChanged();
                this.OnPropertyChanged("ExtrCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExtrCode;
        partial void OnExtrCodeChanging(string value);
        partial void OnExtrCodeChanged();
        /// <summary>
        /// There are no comments for Property PrevId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrevId")]
        public virtual string PrevId
        {
            get
            {
                return this._PrevId;
            }
            set
            {
                this.OnPrevIdChanging(value);
                this._PrevId = value;
                this.OnPrevIdChanged();
                this.OnPropertyChanged("PrevId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrevId;
        partial void OnPrevIdChanging(string value);
        partial void OnPrevIdChanged();
        /// <summary>
        /// There are no comments for Property ActStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActStatus")]
        public virtual string ActStatus
        {
            get
            {
                return this._ActStatus;
            }
            set
            {
                this.OnActStatusChanging(value);
                this._ActStatus = value;
                this.OnActStatusChanged();
                this.OnPropertyChanged("ActStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActStatus;
        partial void OnActStatusChanging(string value);
        partial void OnActStatusChanged();
        /// <summary>
        /// There are no comments for Property AOGuid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AOGuid")]
        public virtual string AOGuid
        {
            get
            {
                return this._AOGuid;
            }
            set
            {
                this.OnAOGuidChanging(value);
                this._AOGuid = value;
                this.OnAOGuidChanged();
                this.OnPropertyChanged("AOGuid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AOGuid;
        partial void OnAOGuidChanging(string value);
        partial void OnAOGuidChanged();
        /// <summary>
        /// There are no comments for Property StreetCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StreetCode")]
        public virtual string StreetCode
        {
            get
            {
                return this._StreetCode;
            }
            set
            {
                this.OnStreetCodeChanging(value);
                this._StreetCode = value;
                this.OnStreetCodeChanged();
                this.OnPropertyChanged("StreetCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StreetCode;
        partial void OnStreetCodeChanging(string value);
        partial void OnStreetCodeChanged();
        /// <summary>
        /// There are no comments for Property IFNSFL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IFNSFL")]
        public virtual string IFNSFL
        {
            get
            {
                return this._IFNSFL;
            }
            set
            {
                this.OnIFNSFLChanging(value);
                this._IFNSFL = value;
                this.OnIFNSFLChanged();
                this.OnPropertyChanged("IFNSFL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IFNSFL;
        partial void OnIFNSFLChanging(string value);
        partial void OnIFNSFLChanged();
        /// <summary>
        /// There are no comments for Property AreaCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AreaCode")]
        public virtual string AreaCode
        {
            get
            {
                return this._AreaCode;
            }
            set
            {
                this.OnAreaCodeChanging(value);
                this._AreaCode = value;
                this.OnAreaCodeChanged();
                this.OnPropertyChanged("AreaCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AreaCode;
        partial void OnAreaCodeChanging(string value);
        partial void OnAreaCodeChanged();
        /// <summary>
        /// There are no comments for Property RegionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegionCode")]
        public virtual string RegionCode
        {
            get
            {
                return this._RegionCode;
            }
            set
            {
                this.OnRegionCodeChanging(value);
                this._RegionCode = value;
                this.OnRegionCodeChanged();
                this.OnPropertyChanged("RegionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegionCode;
        partial void OnRegionCodeChanging(string value);
        partial void OnRegionCodeChanged();
        /// <summary>
        /// There are no comments for Property LiveStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LiveStatus")]
        public virtual string LiveStatus
        {
            get
            {
                return this._LiveStatus;
            }
            set
            {
                this.OnLiveStatusChanging(value);
                this._LiveStatus = value;
                this.OnLiveStatusChanged();
                this.OnPropertyChanged("LiveStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LiveStatus;
        partial void OnLiveStatusChanging(string value);
        partial void OnLiveStatusChanged();
        /// <summary>
        /// There are no comments for Property DivType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DivType")]
        public virtual string DivType
        {
            get
            {
                return this._DivType;
            }
            set
            {
                this.OnDivTypeChanging(value);
                this._DivType = value;
                this.OnDivTypeChanged();
                this.OnPropertyChanged("DivType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DivType;
        partial void OnDivTypeChanging(string value);
        partial void OnDivTypeChanged();
        /// <summary>
        /// There are no comments for Property CtArCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CtArCode")]
        public virtual string CtArCode
        {
            get
            {
                return this._CtArCode;
            }
            set
            {
                this.OnCtArCodeChanging(value);
                this._CtArCode = value;
                this.OnCtArCodeChanged();
                this.OnPropertyChanged("CtArCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CtArCode;
        partial void OnCtArCodeChanging(string value);
        partial void OnCtArCodeChanged();
        /// <summary>
        /// There are no comments for Property NextId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextId")]
        public virtual string NextId
        {
            get
            {
                return this._NextId;
            }
            set
            {
                this.OnNextIdChanging(value);
                this._NextId = value;
                this.OnNextIdChanged();
                this.OnPropertyChanged("NextId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NextId;
        partial void OnNextIdChanging(string value);
        partial void OnNextIdChanged();
        /// <summary>
        /// There are no comments for Property OKATO in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OKATO")]
        public virtual string OKATO
        {
            get
            {
                return this._OKATO;
            }
            set
            {
                this.OnOKATOChanging(value);
                this._OKATO = value;
                this.OnOKATOChanged();
                this.OnPropertyChanged("OKATO");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OKATO;
        partial void OnOKATOChanging(string value);
        partial void OnOKATOChanged();
        /// <summary>
        /// There are no comments for Property AOLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AOLevel")]
        public virtual string AOLevel
        {
            get
            {
                return this._AOLevel;
            }
            set
            {
                this.OnAOLevelChanging(value);
                this._AOLevel = value;
                this.OnAOLevelChanged();
                this.OnPropertyChanged("AOLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AOLevel;
        partial void OnAOLevelChanging(string value);
        partial void OnAOLevelChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortName")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property ParentGuid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentGuid")]
        public virtual string ParentGuid
        {
            get
            {
                return this._ParentGuid;
            }
            set
            {
                this.OnParentGuidChanging(value);
                this._ParentGuid = value;
                this.OnParentGuidChanged();
                this.OnPropertyChanged("ParentGuid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentGuid;
        partial void OnParentGuidChanging(string value);
        partial void OnParentGuidChanged();
        /// <summary>
        /// There are no comments for Property TerrIFNSFL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TerrIFNSFL")]
        public virtual string TerrIFNSFL
        {
            get
            {
                return this._TerrIFNSFL;
            }
            set
            {
                this.OnTerrIFNSFLChanging(value);
                this._TerrIFNSFL = value;
                this.OnTerrIFNSFLChanged();
                this.OnPropertyChanged("TerrIFNSFL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TerrIFNSFL;
        partial void OnTerrIFNSFLChanging(string value);
        partial void OnTerrIFNSFLChanged();
        /// <summary>
        /// There are no comments for Property OffName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OffName")]
        public virtual string OffName
        {
            get
            {
                return this._OffName;
            }
            set
            {
                this.OnOffNameChanging(value);
                this._OffName = value;
                this.OnOffNameChanged();
                this.OnPropertyChanged("OffName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffName;
        partial void OnOffNameChanging(string value);
        partial void OnOffNameChanged();
        /// <summary>
        /// There are no comments for Property CityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CityCode")]
        public virtual string CityCode
        {
            get
            {
                return this._CityCode;
            }
            set
            {
                this.OnCityCodeChanging(value);
                this._CityCode = value;
                this.OnCityCodeChanged();
                this.OnPropertyChanged("CityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityCode;
        partial void OnCityCodeChanging(string value);
        partial void OnCityCodeChanged();
        /// <summary>
        /// There are no comments for Property PlaceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlaceCode")]
        public virtual string PlaceCode
        {
            get
            {
                return this._PlaceCode;
            }
            set
            {
                this.OnPlaceCodeChanging(value);
                this._PlaceCode = value;
                this.OnPlaceCodeChanged();
                this.OnPropertyChanged("PlaceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlaceCode;
        partial void OnPlaceCodeChanging(string value);
        partial void OnPlaceCodeChanged();
        /// <summary>
        /// There are no comments for Property PostalCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalCode")]
        public virtual string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                this.OnPostalCodeChanging(value);
                this._PostalCode = value;
                this.OnPostalCodeChanged();
                this.OnPropertyChanged("PostalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostalCode;
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        /// <summary>
        /// There are no comments for Property PlanCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanCode")]
        public virtual string PlanCode
        {
            get
            {
                return this._PlanCode;
            }
            set
            {
                this.OnPlanCodeChanging(value);
                this._PlanCode = value;
                this.OnPlanCodeChanged();
                this.OnPropertyChanged("PlanCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanCode;
        partial void OnPlanCodeChanging(string value);
        partial void OnPlanCodeChanged();
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