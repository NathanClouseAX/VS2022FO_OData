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
    /// There are no comments for PerDiemLocationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerDiemLocationSingle")]
    public partial class PerDiemLocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PerDiemLocation>
    {
        /// <summary>
        /// Initialize a new PerDiemLocationSingle object.
        /// </summary>
        public PerDiemLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PerDiemLocationSingle object.
        /// </summary>
        public PerDiemLocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PerDiemLocationSingle object.
        /// </summary>
        public PerDiemLocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PerDiemLocation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PerDiemLocation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Location
    /// StateId
    /// CountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Location", "StateId", "CountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("PerDiemLocations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerDiemLocation")]
    public partial class PerDiemLocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PerDiemLocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="location">Initial value of Location.</param>
        /// <param name="stateId">Initial value of StateId.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PerDiemLocation CreatePerDiemLocation(string dataAreaId, string location, string stateId, string countryRegionId)
        {
            PerDiemLocation perDiemLocation = new PerDiemLocation();
            perDiemLocation.DataAreaId = dataAreaId;
            perDiemLocation.Location = location;
            perDiemLocation.StateId = stateId;
            perDiemLocation.CountryRegionId = countryRegionId;
            return perDiemLocation;
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
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Location is required.")]
        public virtual string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Location;
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property StateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StateId is required.")]
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
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryRegionId is required.")]
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
