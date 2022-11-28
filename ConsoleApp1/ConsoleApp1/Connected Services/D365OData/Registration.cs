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
    /// There are no comments for RegistrationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationSingle")]
    public partial class RegistrationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Registration>
    {
        /// <summary>
        /// Initialize a new RegistrationSingle object.
        /// </summary>
        public RegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RegistrationSingle object.
        /// </summary>
        public RegistrationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RegistrationSingle object.
        /// </summary>
        public RegistrationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Registration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Registration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// LocationId
    /// ValidFrom
    /// LegislationType
    /// CountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "LocationId", "ValidFrom", "LegislationType", "CountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("Registrations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Registration")]
    public partial class Registration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Registration object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="locationId">Initial value of LocationId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="issueDate">Initial value of IssueDate.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Registration CreateRegistration(string partyNumber, 
                    string locationId, 
                    global::System.DateTimeOffset validFrom, 
                    string countryRegionId, 
                    global::System.DateTimeOffset issueDate, 
                    global::System.DateTimeOffset validTo)
        {
            Registration registration = new Registration();
            registration.PartyNumber = partyNumber;
            registration.LocationId = locationId;
            registration.ValidFrom = validFrom;
            registration.CountryRegionId = countryRegionId;
            registration.IssueDate = issueDate;
            registration.ValidTo = validTo;
            return registration;
        }
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyNumber is required.")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LocationId is required.")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property LegislationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegislationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationTypesList> LegislationType
        {
            get
            {
                return this._LegislationType;
            }
            set
            {
                this.OnLegislationTypeChanging(value);
                this._LegislationType = value;
                this.OnLegislationTypeChanged();
                this.OnPropertyChanged("LegislationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationTypesList> _LegislationType;
        partial void OnLegislationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationTypesList> value);
        partial void OnLegislationTypeChanged();
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
        /// There are no comments for Property RegistrationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationNumber")]
        public virtual string RegistrationNumber
        {
            get
            {
                return this._RegistrationNumber;
            }
            set
            {
                this.OnRegistrationNumberChanging(value);
                this._RegistrationNumber = value;
                this.OnRegistrationNumberChanged();
                this.OnPropertyChanged("RegistrationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegistrationNumber;
        partial void OnRegistrationNumberChanging(string value);
        partial void OnRegistrationNumberChanged();
        /// <summary>
        /// There are no comments for Property Issuer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Issuer")]
        public virtual string Issuer
        {
            get
            {
                return this._Issuer;
            }
            set
            {
                this.OnIssuerChanging(value);
                this._Issuer = value;
                this.OnIssuerChanged();
                this.OnPropertyChanged("Issuer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Issuer;
        partial void OnIssuerChanging(string value);
        partial void OnIssuerChanged();
        /// <summary>
        /// There are no comments for Property IssueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssueDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IssueDate is required.")]
        public virtual global::System.DateTimeOffset IssueDate
        {
            get
            {
                return this._IssueDate;
            }
            set
            {
                this.OnIssueDateChanging(value);
                this._IssueDate = value;
                this.OnIssueDateChanged();
                this.OnPropertyChanged("IssueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _IssueDate;
        partial void OnIssueDateChanging(global::System.DateTimeOffset value);
        partial void OnIssueDateChanged();
        /// <summary>
        /// There are no comments for Property TaxRegstrationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxRegstrationType")]
        public virtual string TaxRegstrationType
        {
            get
            {
                return this._TaxRegstrationType;
            }
            set
            {
                this.OnTaxRegstrationTypeChanging(value);
                this._TaxRegstrationType = value;
                this.OnTaxRegstrationTypeChanged();
                this.OnPropertyChanged("TaxRegstrationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxRegstrationType;
        partial void OnTaxRegstrationTypeChanging(string value);
        partial void OnTaxRegstrationTypeChanged();
        /// <summary>
        /// There are no comments for Property Section in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Section")]
        public virtual string Section
        {
            get
            {
                return this._Section;
            }
            set
            {
                this.OnSectionChanging(value);
                this._Section = value;
                this.OnSectionChanged();
                this.OnPropertyChanged("Section");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Section;
        partial void OnSectionChanging(string value);
        partial void OnSectionChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
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