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
    /// There are no comments for AddressCitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCitySingle")]
    public partial class AddressCitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressCity>
    {
        /// <summary>
        /// Initialize a new AddressCitySingle object.
        /// </summary>
        public AddressCitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressCitySingle object.
        /// </summary>
        public AddressCitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressCitySingle object.
        /// </summary>
        public AddressCitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressCity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressStateSingle State
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._State == null))
                {
                    this._State = new global::Microsoft.Dynamics.DataEntities.AddressStateSingle(this.Context, GetPath("State"));
                }
                return this._State;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressStateSingle _State;
        /// <summary>
        /// There are no comments for County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("County")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountySingle County
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._County == null))
                {
                    this._County = new global::Microsoft.Dynamics.DataEntities.AddressCountySingle(this.Context, GetPath("County"));
                }
                return this._County;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountySingle _County;
        /// <summary>
        /// There are no comments for CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegion")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle CountryRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CountryRegion == null))
                {
                    this._CountryRegion = new global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle(this.Context, GetPath("CountryRegion"));
                }
                return this._CountryRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle _CountryRegion;
        /// <summary>
        /// There are no comments for AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetLocation")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetLocation == null))
                {
                    this._AssetLocation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation>(GetPath("AssetLocation"));
                }
                return this._AssetLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation;
        /// <summary>
        /// There are no comments for Districts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Districts")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict> Districts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Districts == null))
                {
                    this._Districts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict>(GetPath("Districts"));
                }
                return this._Districts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict> _Districts;
        /// <summary>
        /// There are no comments for DistrictsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DistrictsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2> DistrictsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DistrictsV2 == null))
                {
                    this._DistrictsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2>(GetPath("DistrictsV2"));
                }
                return this._DistrictsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2> _DistrictsV2;
    }
    /// <summary>
    /// There are no comments for AddressCity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CityKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CityKey")]
    [global::Microsoft.OData.Client.EntitySet("AddressCities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCity")]
    public partial class AddressCity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressCity object.
        /// </summary>
        /// <param name="cityKey">Initial value of CityKey.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="countryRegion">Initial value of CountryRegion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressCity CreateAddressCity(string cityKey, global::Microsoft.Dynamics.DataEntities.AddressState state, global::Microsoft.Dynamics.DataEntities.AddressCountryRegion countryRegion)
        {
            AddressCity addressCity = new AddressCity();
            addressCity.CityKey = cityKey;
            if ((state == null))
            {
                throw new global::System.ArgumentNullException("state");
            }
            addressCity.State = state;
            if ((countryRegion == null))
            {
                throw new global::System.ArgumentNullException("countryRegion");
            }
            addressCity.CountryRegion = countryRegion;
            return addressCity;
        }
        /// <summary>
        /// There are no comments for Property CityKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CityKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CityKey is required.")]
        public virtual string CityKey
        {
            get
            {
                return this._CityKey;
            }
            set
            {
                this.OnCityKeyChanging(value);
                this._CityKey = value;
                this.OnCityKeyChanged();
                this.OnPropertyChanged("CityKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityKey;
        partial void OnCityKeyChanging(string value);
        partial void OnCityKeyChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionId")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
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
        /// There are no comments for Property CountyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountyId")]
        public virtual string CountyId
        {
            get
            {
                return this._CountyId;
            }
            set
            {
                this.OnCountyIdChanging(value);
                this._CountyId = value;
                this.OnCountyIdChanged();
                this.OnPropertyChanged("CountyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountyId;
        partial void OnCountyIdChanging(string value);
        partial void OnCountyIdChanged();
        /// <summary>
        /// There are no comments for Property StateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StateId")]
        public virtual string StateId
        {
            get
            {
                return this._StateId;
            }
            set
            {
                this.OnStateIdChanging(value);
                this._StateId = value;
                this.OnStateIdChanged();
                this.OnPropertyChanged("StateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StateId;
        partial void OnStateIdChanging(string value);
        partial void OnStateIdChanged();
        /// <summary>
        /// There are no comments for Property CityInKana in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CityInKana")]
        public virtual string CityInKana
        {
            get
            {
                return this._CityInKana;
            }
            set
            {
                this.OnCityInKanaChanging(value);
                this._CityInKana = value;
                this.OnCityInKanaChanged();
                this.OnPropertyChanged("CityInKana");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CityInKana;
        partial void OnCityInKanaChanging(string value);
        partial void OnCityInKanaChanged();
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
        /// There are no comments for Property ItalyMunicipalityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItalyMunicipalityCode")]
        public virtual string ItalyMunicipalityCode
        {
            get
            {
                return this._ItalyMunicipalityCode;
            }
            set
            {
                this.OnItalyMunicipalityCodeChanging(value);
                this._ItalyMunicipalityCode = value;
                this.OnItalyMunicipalityCodeChanged();
                this.OnPropertyChanged("ItalyMunicipalityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItalyMunicipalityCode;
        partial void OnItalyMunicipalityCodeChanging(string value);
        partial void OnItalyMunicipalityCodeChanged();
        /// <summary>
        /// There are no comments for Property BrazilCityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilCityCode")]
        public virtual string BrazilCityCode
        {
            get
            {
                return this._BrazilCityCode;
            }
            set
            {
                this.OnBrazilCityCodeChanging(value);
                this._BrazilCityCode = value;
                this.OnBrazilCityCodeChanged();
                this.OnPropertyChanged("BrazilCityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BrazilCityCode;
        partial void OnBrazilCityCodeChanging(string value);
        partial void OnBrazilCityCodeChanged();
        /// <summary>
        /// There are no comments for Property ItalyCityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItalyCityCode")]
        public virtual string ItalyCityCode
        {
            get
            {
                return this._ItalyCityCode;
            }
            set
            {
                this.OnItalyCityCodeChanging(value);
                this._ItalyCityCode = value;
                this.OnItalyCityCodeChanged();
                this.OnPropertyChanged("ItalyCityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItalyCityCode;
        partial void OnItalyCityCodeChanging(string value);
        partial void OnItalyCityCodeChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressState State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressState _State;
        partial void OnStateChanging(global::Microsoft.Dynamics.DataEntities.AddressState value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("County")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCounty County
        {
            get
            {
                return this._County;
            }
            set
            {
                this.OnCountyChanging(value);
                this._County = value;
                this.OnCountyChanged();
                this.OnPropertyChanged("County");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCounty _County;
        partial void OnCountyChanging(global::Microsoft.Dynamics.DataEntities.AddressCounty value);
        partial void OnCountyChanged();
        /// <summary>
        /// There are no comments for Property CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryRegion is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this.OnCountryRegionChanging(value);
                this._CountryRegion = value;
                this.OnCountryRegionChanged();
                this.OnPropertyChanged("CountryRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegion _CountryRegion;
        partial void OnCountryRegionChanging(global::Microsoft.Dynamics.DataEntities.AddressCountryRegion value);
        partial void OnCountryRegionChanged();
        /// <summary>
        /// There are no comments for Property AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetLocation")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                return this._AssetLocation;
            }
            set
            {
                this.OnAssetLocationChanging(value);
                this._AssetLocation = value;
                this.OnAssetLocationChanged();
                this.OnPropertyChanged("AssetLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetLocationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> value);
        partial void OnAssetLocationChanged();
        /// <summary>
        /// There are no comments for Property Districts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Districts")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> Districts
        {
            get
            {
                return this._Districts;
            }
            set
            {
                this.OnDistrictsChanging(value);
                this._Districts = value;
                this.OnDistrictsChanged();
                this.OnPropertyChanged("Districts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> _Districts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDistrictsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> value);
        partial void OnDistrictsChanged();
        /// <summary>
        /// There are no comments for Property DistrictsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DistrictsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2> DistrictsV2
        {
            get
            {
                return this._DistrictsV2;
            }
            set
            {
                this.OnDistrictsV2Changing(value);
                this._DistrictsV2 = value;
                this.OnDistrictsV2Changed();
                this.OnPropertyChanged("DistrictsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2> _DistrictsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDistrictsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrictV2> value);
        partial void OnDistrictsV2Changed();
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
