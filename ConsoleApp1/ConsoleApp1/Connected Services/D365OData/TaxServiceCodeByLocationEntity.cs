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
    /// There are no comments for TaxServiceCodeByLocationEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxServiceCodeByLocationEntitySingle")]
    public partial class TaxServiceCodeByLocationEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxServiceCodeByLocationEntity>
    {
        /// <summary>
        /// Initialize a new TaxServiceCodeByLocationEntitySingle object.
        /// </summary>
        public TaxServiceCodeByLocationEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxServiceCodeByLocationEntitySingle object.
        /// </summary>
        public TaxServiceCodeByLocationEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxServiceCodeByLocationEntitySingle object.
        /// </summary>
        public TaxServiceCodeByLocationEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxServiceCodeByLocationEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxServiceCodeByLocationEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ParentServiceCode
    /// CountryRegion
    /// State
    /// City
    /// ServiceCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ParentServiceCode", "CountryRegion", "State", "City", "ServiceCode")]
    [global::Microsoft.OData.Client.EntitySet("TaxServiceCodeByLocationEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxServiceCodeByLocationEntity")]
    public partial class TaxServiceCodeByLocationEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxServiceCodeByLocationEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="parentServiceCode">Initial value of ParentServiceCode.</param>
        /// <param name="countryRegion">Initial value of CountryRegion.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="city">Initial value of City.</param>
        /// <param name="serviceCode">Initial value of ServiceCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxServiceCodeByLocationEntity CreateTaxServiceCodeByLocationEntity(string dataAreaId, 
                    string parentServiceCode, 
                    string countryRegion, 
                    string state, 
                    string city, 
                    string serviceCode)
        {
            TaxServiceCodeByLocationEntity taxServiceCodeByLocationEntity = new TaxServiceCodeByLocationEntity();
            taxServiceCodeByLocationEntity.DataAreaId = dataAreaId;
            taxServiceCodeByLocationEntity.ParentServiceCode = parentServiceCode;
            taxServiceCodeByLocationEntity.CountryRegion = countryRegion;
            taxServiceCodeByLocationEntity.State = state;
            taxServiceCodeByLocationEntity.City = city;
            taxServiceCodeByLocationEntity.ServiceCode = serviceCode;
            return taxServiceCodeByLocationEntity;
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
        /// There are no comments for Property ParentServiceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentServiceCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentServiceCode is required.")]
        public virtual string ParentServiceCode
        {
            get
            {
                return this._ParentServiceCode;
            }
            set
            {
                this.OnParentServiceCodeChanging(value);
                this._ParentServiceCode = value;
                this.OnParentServiceCodeChanged();
                this.OnPropertyChanged("ParentServiceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentServiceCode;
        partial void OnParentServiceCodeChanging(string value);
        partial void OnParentServiceCodeChanged();
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
        /// There are no comments for Property ServiceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ServiceCode is required.")]
        public virtual string ServiceCode
        {
            get
            {
                return this._ServiceCode;
            }
            set
            {
                this.OnServiceCodeChanging(value);
                this._ServiceCode = value;
                this.OnServiceCodeChanged();
                this.OnPropertyChanged("ServiceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceCode;
        partial void OnServiceCodeChanging(string value);
        partial void OnServiceCodeChanged();
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
        /// There are no comments for Property ServiceCodeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCodeDescription")]
        public virtual string ServiceCodeDescription
        {
            get
            {
                return this._ServiceCodeDescription;
            }
            set
            {
                this.OnServiceCodeDescriptionChanging(value);
                this._ServiceCodeDescription = value;
                this.OnServiceCodeDescriptionChanged();
                this.OnPropertyChanged("ServiceCodeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceCodeDescription;
        partial void OnServiceCodeDescriptionChanging(string value);
        partial void OnServiceCodeDescriptionChanged();
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