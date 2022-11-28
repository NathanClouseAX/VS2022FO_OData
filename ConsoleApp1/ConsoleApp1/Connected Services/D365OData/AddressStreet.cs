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
    /// There are no comments for AddressStreetSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressStreetSingle")]
    public partial class AddressStreetSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressStreet>
    {
        /// <summary>
        /// Initialize a new AddressStreetSingle object.
        /// </summary>
        public AddressStreetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressStreetSingle object.
        /// </summary>
        public AddressStreetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressStreetSingle object.
        /// </summary>
        public AddressStreetSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressStreet> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AddressStreet in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CountryRegion
    /// State
    /// County
    /// City_FK_Name
    /// District_FK_Name
    /// Name
    /// Description
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CountryRegion", "State", "County", "City_FK_Name", "District_FK_Name", "Name", "Description")]
    [global::Microsoft.OData.Client.EntitySet("AddressStreets")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressStreet")]
    public partial class AddressStreet : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressStreet object.
        /// </summary>
        /// <param name="countryRegion">Initial value of CountryRegion.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="county">Initial value of County.</param>
        /// <param name="city_FK_Name">Initial value of City_FK_Name.</param>
        /// <param name="district_FK_Name">Initial value of District_FK_Name.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressStreet CreateAddressStreet(string countryRegion, 
                    string state, 
                    string county, 
                    string city_FK_Name, 
                    string district_FK_Name, 
                    string name, 
                    string description)
        {
            AddressStreet addressStreet = new AddressStreet();
            addressStreet.CountryRegion = countryRegion;
            addressStreet.State = state;
            addressStreet.County = county;
            addressStreet.City_FK_Name = city_FK_Name;
            addressStreet.District_FK_Name = district_FK_Name;
            addressStreet.Name = name;
            addressStreet.Description = description;
            return addressStreet;
        }
        /// <summary>
        /// There are no comments for Property CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryRegion is required.")]
        public virtual string CountryRegion
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
        private string _CountryRegion;
        partial void OnCountryRegionChanging(string value);
        partial void OnCountryRegionChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual string State
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
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("County")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "County is required.")]
        public virtual string County
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
        private string _County;
        partial void OnCountyChanging(string value);
        partial void OnCountyChanged();
        /// <summary>
        /// There are no comments for Property City_FK_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("City_FK_Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "City_FK_Name is required.")]
        public virtual string City_FK_Name
        {
            get
            {
                return this._City_FK_Name;
            }
            set
            {
                this.OnCity_FK_NameChanging(value);
                this._City_FK_Name = value;
                this.OnCity_FK_NameChanged();
                this.OnPropertyChanged("City_FK_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _City_FK_Name;
        partial void OnCity_FK_NameChanging(string value);
        partial void OnCity_FK_NameChanged();
        /// <summary>
        /// There are no comments for Property District_FK_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("District_FK_Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "District_FK_Name is required.")]
        public virtual string District_FK_Name
        {
            get
            {
                return this._District_FK_Name;
            }
            set
            {
                this.OnDistrict_FK_NameChanging(value);
                this._District_FK_Name = value;
                this.OnDistrict_FK_NameChanged();
                this.OnPropertyChanged("District_FK_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _District_FK_Name;
        partial void OnDistrict_FK_NameChanging(string value);
        partial void OnDistrict_FK_NameChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Description is required.")]
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
        /// There are no comments for Property Properties_FK_OKATO in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Properties_FK_OKATO")]
        public virtual string Properties_FK_OKATO
        {
            get
            {
                return this._Properties_FK_OKATO;
            }
            set
            {
                this.OnProperties_FK_OKATOChanging(value);
                this._Properties_FK_OKATO = value;
                this.OnProperties_FK_OKATOChanged();
                this.OnPropertyChanged("Properties_FK_OKATO");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Properties_FK_OKATO;
        partial void OnProperties_FK_OKATOChanging(string value);
        partial void OnProperties_FK_OKATOChanged();
        /// <summary>
        /// There are no comments for Property Properties_FK_IMNSDistrict in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Properties_FK_IMNSDistrict")]
        public virtual string Properties_FK_IMNSDistrict
        {
            get
            {
                return this._Properties_FK_IMNSDistrict;
            }
            set
            {
                this.OnProperties_FK_IMNSDistrictChanging(value);
                this._Properties_FK_IMNSDistrict = value;
                this.OnProperties_FK_IMNSDistrictChanged();
                this.OnPropertyChanged("Properties_FK_IMNSDistrict");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Properties_FK_IMNSDistrict;
        partial void OnProperties_FK_IMNSDistrictChanging(string value);
        partial void OnProperties_FK_IMNSDistrictChanged();
        /// <summary>
        /// There are no comments for Property Properties_FK_ObjectStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Properties_FK_ObjectStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AddressObjectStatus_RU> Properties_FK_ObjectStatus
        {
            get
            {
                return this._Properties_FK_ObjectStatus;
            }
            set
            {
                this.OnProperties_FK_ObjectStatusChanging(value);
                this._Properties_FK_ObjectStatus = value;
                this.OnProperties_FK_ObjectStatusChanged();
                this.OnPropertyChanged("Properties_FK_ObjectStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AddressObjectStatus_RU> _Properties_FK_ObjectStatus;
        partial void OnProperties_FK_ObjectStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AddressObjectStatus_RU> value);
        partial void OnProperties_FK_ObjectStatusChanged();
        /// <summary>
        /// There are no comments for Property ZipCode_FK_ZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ZipCode_FK_ZipCode")]
        public virtual string ZipCode_FK_ZipCode
        {
            get
            {
                return this._ZipCode_FK_ZipCode;
            }
            set
            {
                this.OnZipCode_FK_ZipCodeChanging(value);
                this._ZipCode_FK_ZipCode = value;
                this.OnZipCode_FK_ZipCodeChanged();
                this.OnPropertyChanged("ZipCode_FK_ZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZipCode_FK_ZipCode;
        partial void OnZipCode_FK_ZipCodeChanging(string value);
        partial void OnZipCode_FK_ZipCodeChanged();
        /// <summary>
        /// There are no comments for Property Properties_FK_GniCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Properties_FK_GniCode")]
        public virtual string Properties_FK_GniCode
        {
            get
            {
                return this._Properties_FK_GniCode;
            }
            set
            {
                this.OnProperties_FK_GniCodeChanging(value);
                this._Properties_FK_GniCode = value;
                this.OnProperties_FK_GniCodeChanged();
                this.OnPropertyChanged("Properties_FK_GniCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Properties_FK_GniCode;
        partial void OnProperties_FK_GniCodeChanging(string value);
        partial void OnProperties_FK_GniCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressTypeTable_RU_AddrTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressTypeTable_RU_AddrTypeCode")]
        public virtual string AddressTypeTable_RU_AddrTypeCode
        {
            get
            {
                return this._AddressTypeTable_RU_AddrTypeCode;
            }
            set
            {
                this.OnAddressTypeTable_RU_AddrTypeCodeChanging(value);
                this._AddressTypeTable_RU_AddrTypeCode = value;
                this.OnAddressTypeTable_RU_AddrTypeCodeChanged();
                this.OnPropertyChanged("AddressTypeTable_RU_AddrTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressTypeTable_RU_AddrTypeCode;
        partial void OnAddressTypeTable_RU_AddrTypeCodeChanging(string value);
        partial void OnAddressTypeTable_RU_AddrTypeCodeChanged();
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