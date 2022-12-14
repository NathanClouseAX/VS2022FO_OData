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
    /// There are no comments for GroupRetailTaxFilterSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GroupRetailTaxFilterSingle")]
    public partial class GroupRetailTaxFilterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GroupRetailTaxFilter>
    {
        /// <summary>
        /// Initialize a new GroupRetailTaxFilterSingle object.
        /// </summary>
        public GroupRetailTaxFilterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GroupRetailTaxFilterSingle object.
        /// </summary>
        public GroupRetailTaxFilterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GroupRetailTaxFilterSingle object.
        /// </summary>
        public GroupRetailTaxFilterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GroupRetailTaxFilter> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroupSingle TaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroup == null))
                {
                    this._TaxGroup = new global::Microsoft.Dynamics.DataEntities.TaxGroupSingle(this.Context, GetPath("TaxGroup"));
                }
                return this._TaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroupSingle _TaxGroup;
    }
    /// <summary>
    /// There are no comments for GroupRetailTaxFilter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TaxGroupId
    /// City
    /// CountryRegion
    /// County
    /// District
    /// State
    /// ZipCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxGroupId", "City", "CountryRegion", "County", "District", "State", "ZipCode")]
    [global::Microsoft.OData.Client.EntitySet("GroupRetailTaxFilters")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GroupRetailTaxFilter")]
    public partial class GroupRetailTaxFilter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GroupRetailTaxFilter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="taxGroupId">Initial value of TaxGroupId.</param>
        /// <param name="city">Initial value of City.</param>
        /// <param name="countryRegion">Initial value of CountryRegion.</param>
        /// <param name="county">Initial value of County.</param>
        /// <param name="district">Initial value of District.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="zipCode">Initial value of ZipCode.</param>
        /// <param name="districtId">Initial value of DistrictId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GroupRetailTaxFilter CreateGroupRetailTaxFilter(string dataAreaId, 
                    string taxGroupId, 
                    string city, 
                    string countryRegion, 
                    string county, 
                    string district, 
                    string state, 
                    string zipCode, 
                    long districtId)
        {
            GroupRetailTaxFilter groupRetailTaxFilter = new GroupRetailTaxFilter();
            groupRetailTaxFilter.DataAreaId = dataAreaId;
            groupRetailTaxFilter.TaxGroupId = taxGroupId;
            groupRetailTaxFilter.City = city;
            groupRetailTaxFilter.CountryRegion = countryRegion;
            groupRetailTaxFilter.County = county;
            groupRetailTaxFilter.District = district;
            groupRetailTaxFilter.State = state;
            groupRetailTaxFilter.ZipCode = zipCode;
            groupRetailTaxFilter.DistrictId = districtId;
            return groupRetailTaxFilter;
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
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxGroupId is required.")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "City is required.")]
        public virtual string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
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
        /// There are no comments for Property District in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("District")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "District is required.")]
        public virtual string District
        {
            get
            {
                return this._District;
            }
            set
            {
                this.OnDistrictChanging(value);
                this._District = value;
                this.OnDistrictChanged();
                this.OnPropertyChanged("District");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _District;
        partial void OnDistrictChanging(string value);
        partial void OnDistrictChanged();
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
        /// There are no comments for Property ZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ZipCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ZipCode is required.")]
        public virtual string ZipCode
        {
            get
            {
                return this._ZipCode;
            }
            set
            {
                this.OnZipCodeChanging(value);
                this._ZipCode = value;
                this.OnZipCodeChanged();
                this.OnPropertyChanged("ZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZipCode;
        partial void OnZipCodeChanging(string value);
        partial void OnZipCodeChanged();
        /// <summary>
        /// There are no comments for Property DistrictId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DistrictId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DistrictId is required.")]
        public virtual long DistrictId
        {
            get
            {
                return this._DistrictId;
            }
            set
            {
                this.OnDistrictIdChanging(value);
                this._DistrictId = value;
                this.OnDistrictIdChanged();
                this.OnPropertyChanged("DistrictId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _DistrictId;
        partial void OnDistrictIdChanging(long value);
        partial void OnDistrictIdChanged();
        /// <summary>
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroup TaxGroup
        {
            get
            {
                return this._TaxGroup;
            }
            set
            {
                this.OnTaxGroupChanging(value);
                this._TaxGroup = value;
                this.OnTaxGroupChanged();
                this.OnPropertyChanged("TaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroup _TaxGroup;
        partial void OnTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxGroup value);
        partial void OnTaxGroupChanged();
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
