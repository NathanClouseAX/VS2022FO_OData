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
    /// There are no comments for RegistrationTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationTypeSingle")]
    public partial class RegistrationTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RegistrationType>
    {
        /// <summary>
        /// Initialize a new RegistrationTypeSingle object.
        /// </summary>
        public RegistrationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RegistrationTypeSingle object.
        /// </summary>
        public RegistrationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RegistrationTypeSingle object.
        /// </summary>
        public RegistrationTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RegistrationType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RegistrationType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RegistrationType
    /// CountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RegistrationType", "CountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("RegistrationTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationType")]
    public partial class RegistrationType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RegistrationType object.
        /// </summary>
        /// <param name="registrationType1">Initial value of RegistrationType1.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RegistrationType CreateRegistrationType(string registrationType1, string countryRegionId)
        {
            RegistrationType registrationType = new RegistrationType();
            registrationType.RegistrationType1 = registrationType1;
            registrationType.CountryRegionId = countryRegionId;
            return registrationType;
        }
        /// <summary>
        /// There are no comments for Property RegistrationType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegistrationType1 is required.")]
        public virtual string RegistrationType1
        {
            get
            {
                return this._RegistrationType1;
            }
            set
            {
                this.OnRegistrationType1Changing(value);
                this._RegistrationType1 = value;
                this.OnRegistrationType1Changed();
                this.OnPropertyChanged("RegistrationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegistrationType1;
        partial void OnRegistrationType1Changing(string value);
        partial void OnRegistrationType1Changed();
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
        /// There are no comments for Property IsRegistrationNumberUnique in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRegistrationNumberUnique")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRegistrationNumberUnique
        {
            get
            {
                return this._IsRegistrationNumberUnique;
            }
            set
            {
                this.OnIsRegistrationNumberUniqueChanging(value);
                this._IsRegistrationNumberUnique = value;
                this.OnIsRegistrationNumberUniqueChanged();
                this.OnPropertyChanged("IsRegistrationNumberUnique");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRegistrationNumberUnique;
        partial void OnIsRegistrationNumberUniqueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRegistrationNumberUniqueChanged();
        /// <summary>
        /// There are no comments for Property PartyTypeRestriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyTypeRestriction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PartyTypeRestriction> PartyTypeRestriction
        {
            get
            {
                return this._PartyTypeRestriction;
            }
            set
            {
                this.OnPartyTypeRestrictionChanging(value);
                this._PartyTypeRestriction = value;
                this.OnPartyTypeRestrictionChanged();
                this.OnPropertyChanged("PartyTypeRestriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PartyTypeRestriction> _PartyTypeRestriction;
        partial void OnPartyTypeRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PartyTypeRestriction> value);
        partial void OnPartyTypeRestrictionChanged();
        /// <summary>
        /// There are no comments for Property RegistrationAuthority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationAuthority")]
        public virtual string RegistrationAuthority
        {
            get
            {
                return this._RegistrationAuthority;
            }
            set
            {
                this.OnRegistrationAuthorityChanging(value);
                this._RegistrationAuthority = value;
                this.OnRegistrationAuthorityChanged();
                this.OnPropertyChanged("RegistrationAuthority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegistrationAuthority;
        partial void OnRegistrationAuthorityChanging(string value);
        partial void OnRegistrationAuthorityChanged();
        /// <summary>
        /// There are no comments for Property IsRegistrationNumberUpdateable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRegistrationNumberUpdateable")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRegistrationNumberUpdateable
        {
            get
            {
                return this._IsRegistrationNumberUpdateable;
            }
            set
            {
                this.OnIsRegistrationNumberUpdateableChanging(value);
                this._IsRegistrationNumberUpdateable = value;
                this.OnIsRegistrationNumberUpdateableChanged();
                this.OnPropertyChanged("IsRegistrationNumberUpdateable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRegistrationNumberUpdateable;
        partial void OnIsRegistrationNumberUpdateableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRegistrationNumberUpdateableChanged();
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
        /// There are no comments for Property IsPrimaryAddressRestricted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPrimaryAddressRestricted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrimaryAddressRestricted
        {
            get
            {
                return this._IsPrimaryAddressRestricted;
            }
            set
            {
                this.OnIsPrimaryAddressRestrictedChanging(value);
                this._IsPrimaryAddressRestricted = value;
                this.OnIsPrimaryAddressRestrictedChanged();
                this.OnPropertyChanged("IsPrimaryAddressRestricted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrimaryAddressRestricted;
        partial void OnIsPrimaryAddressRestrictedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrimaryAddressRestrictedChanged();
        /// <summary>
        /// There are no comments for Property Format in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Format")]
        public virtual string Format
        {
            get
            {
                return this._Format;
            }
            set
            {
                this.OnFormatChanging(value);
                this._Format = value;
                this.OnFormatChanged();
                this.OnPropertyChanged("Format");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Format;
        partial void OnFormatChanging(string value);
        partial void OnFormatChanged();
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