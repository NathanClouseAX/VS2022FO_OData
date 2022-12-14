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
    /// There are no comments for LegalRepresentativeContactSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentativeContactSingle")]
    public partial class LegalRepresentativeContactSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LegalRepresentativeContact>
    {
        /// <summary>
        /// Initialize a new LegalRepresentativeContactSingle object.
        /// </summary>
        public LegalRepresentativeContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LegalRepresentativeContactSingle object.
        /// </summary>
        public LegalRepresentativeContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LegalRepresentativeContactSingle object.
        /// </summary>
        public LegalRepresentativeContactSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LegalRepresentativeContact> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LegalRepresentativeContact in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FiscalOrganizationRootFiscalEstablishmentDataArea
    /// FiscalOrganizationRootFiscalEstablishment
    /// LegalRepresentativeCPF
    /// LegalRepresentativeRole
    /// ContactNumberOrAddress
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FiscalOrganizationRootFiscalEstablishmentDataArea", "FiscalOrganizationRootFiscalEstablishment", "LegalRepresentativeCPF", "LegalRepresentativeRole", "ContactNumberOrAddress")]
    [global::Microsoft.OData.Client.EntitySet("LegalRepresentativeContacts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentativeContact")]
    public partial class LegalRepresentativeContact : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LegalRepresentativeContact object.
        /// </summary>
        /// <param name="fiscalOrganizationRootFiscalEstablishmentDataArea">Initial value of FiscalOrganizationRootFiscalEstablishmentDataArea.</param>
        /// <param name="fiscalOrganizationRootFiscalEstablishment">Initial value of FiscalOrganizationRootFiscalEstablishment.</param>
        /// <param name="legalRepresentativeCPF">Initial value of LegalRepresentativeCPF.</param>
        /// <param name="contactNumberOrAddress">Initial value of ContactNumberOrAddress.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LegalRepresentativeContact CreateLegalRepresentativeContact(string fiscalOrganizationRootFiscalEstablishmentDataArea, string fiscalOrganizationRootFiscalEstablishment, string legalRepresentativeCPF, string contactNumberOrAddress)
        {
            LegalRepresentativeContact legalRepresentativeContact = new LegalRepresentativeContact();
            legalRepresentativeContact.FiscalOrganizationRootFiscalEstablishmentDataArea = fiscalOrganizationRootFiscalEstablishmentDataArea;
            legalRepresentativeContact.FiscalOrganizationRootFiscalEstablishment = fiscalOrganizationRootFiscalEstablishment;
            legalRepresentativeContact.LegalRepresentativeCPF = legalRepresentativeCPF;
            legalRepresentativeContact.ContactNumberOrAddress = contactNumberOrAddress;
            return legalRepresentativeContact;
        }
        /// <summary>
        /// There are no comments for Property FiscalOrganizationRootFiscalEstablishmentDataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalOrganizationRootFiscalEstablishmentDataArea")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalOrganizationRootFiscalEstablishmentDataArea is required.")]
        public virtual string FiscalOrganizationRootFiscalEstablishmentDataArea
        {
            get
            {
                return this._FiscalOrganizationRootFiscalEstablishmentDataArea;
            }
            set
            {
                this.OnFiscalOrganizationRootFiscalEstablishmentDataAreaChanging(value);
                this._FiscalOrganizationRootFiscalEstablishmentDataArea = value;
                this.OnFiscalOrganizationRootFiscalEstablishmentDataAreaChanged();
                this.OnPropertyChanged("FiscalOrganizationRootFiscalEstablishmentDataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalOrganizationRootFiscalEstablishmentDataArea;
        partial void OnFiscalOrganizationRootFiscalEstablishmentDataAreaChanging(string value);
        partial void OnFiscalOrganizationRootFiscalEstablishmentDataAreaChanged();
        /// <summary>
        /// There are no comments for Property FiscalOrganizationRootFiscalEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalOrganizationRootFiscalEstablishment")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalOrganizationRootFiscalEstablishment is required.")]
        public virtual string FiscalOrganizationRootFiscalEstablishment
        {
            get
            {
                return this._FiscalOrganizationRootFiscalEstablishment;
            }
            set
            {
                this.OnFiscalOrganizationRootFiscalEstablishmentChanging(value);
                this._FiscalOrganizationRootFiscalEstablishment = value;
                this.OnFiscalOrganizationRootFiscalEstablishmentChanged();
                this.OnPropertyChanged("FiscalOrganizationRootFiscalEstablishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalOrganizationRootFiscalEstablishment;
        partial void OnFiscalOrganizationRootFiscalEstablishmentChanging(string value);
        partial void OnFiscalOrganizationRootFiscalEstablishmentChanged();
        /// <summary>
        /// There are no comments for Property LegalRepresentativeCPF in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentativeCPF")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalRepresentativeCPF is required.")]
        public virtual string LegalRepresentativeCPF
        {
            get
            {
                return this._LegalRepresentativeCPF;
            }
            set
            {
                this.OnLegalRepresentativeCPFChanging(value);
                this._LegalRepresentativeCPF = value;
                this.OnLegalRepresentativeCPFChanged();
                this.OnPropertyChanged("LegalRepresentativeCPF");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalRepresentativeCPF;
        partial void OnLegalRepresentativeCPFChanging(string value);
        partial void OnLegalRepresentativeCPFChanged();
        /// <summary>
        /// There are no comments for Property LegalRepresentativeRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentativeRole")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> LegalRepresentativeRole
        {
            get
            {
                return this._LegalRepresentativeRole;
            }
            set
            {
                this.OnLegalRepresentativeRoleChanging(value);
                this._LegalRepresentativeRole = value;
                this.OnLegalRepresentativeRoleChanged();
                this.OnPropertyChanged("LegalRepresentativeRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> _LegalRepresentativeRole;
        partial void OnLegalRepresentativeRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> value);
        partial void OnLegalRepresentativeRoleChanged();
        /// <summary>
        /// There are no comments for Property ContactNumberOrAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactNumberOrAddress")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContactNumberOrAddress is required.")]
        public virtual string ContactNumberOrAddress
        {
            get
            {
                return this._ContactNumberOrAddress;
            }
            set
            {
                this.OnContactNumberOrAddressChanging(value);
                this._ContactNumberOrAddress = value;
                this.OnContactNumberOrAddressChanged();
                this.OnPropertyChanged("ContactNumberOrAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactNumberOrAddress;
        partial void OnContactNumberOrAddressChanging(string value);
        partial void OnContactNumberOrAddressChanged();
        /// <summary>
        /// There are no comments for Property IsPrivate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPrivate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrivate
        {
            get
            {
                return this._IsPrivate;
            }
            set
            {
                this.OnIsPrivateChanging(value);
                this._IsPrivate = value;
                this.OnIsPrivateChanged();
                this.OnPropertyChanged("IsPrivate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrivate;
        partial void OnIsPrivateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrivateChanged();
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
        /// There are no comments for Property IsPrimary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPrimary")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrimary
        {
            get
            {
                return this._IsPrimary;
            }
            set
            {
                this.OnIsPrimaryChanging(value);
                this._IsPrimary = value;
                this.OnIsPrimaryChanged();
                this.OnPropertyChanged("IsPrimary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrimary;
        partial void OnIsPrimaryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrimaryChanged();
        /// <summary>
        /// There are no comments for Property Extension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Extension")]
        public virtual string Extension
        {
            get
            {
                return this._Extension;
            }
            set
            {
                this.OnExtensionChanging(value);
                this._Extension = value;
                this.OnExtensionChanged();
                this.OnPropertyChanged("Extension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Extension;
        partial void OnExtensionChanging(string value);
        partial void OnExtensionChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LogisticsElectronicAddressMethodType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property IsMobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsMobilePhone")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsMobilePhone
        {
            get
            {
                return this._IsMobilePhone;
            }
            set
            {
                this.OnIsMobilePhoneChanging(value);
                this._IsMobilePhone = value;
                this.OnIsMobilePhoneChanged();
                this.OnPropertyChanged("IsMobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsMobilePhone;
        partial void OnIsMobilePhoneChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property IsInstantMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsInstantMessage")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInstantMessage
        {
            get
            {
                return this._IsInstantMessage;
            }
            set
            {
                this.OnIsInstantMessageChanging(value);
                this._IsInstantMessage = value;
                this.OnIsInstantMessageChanged();
                this.OnPropertyChanged("IsInstantMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInstantMessage;
        partial void OnIsInstantMessageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInstantMessageChanged();
        /// <summary>
        /// There are no comments for Property InternationalCallingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternationalCallingCode")]
        public virtual string InternationalCallingCode
        {
            get
            {
                return this._InternationalCallingCode;
            }
            set
            {
                this.OnInternationalCallingCodeChanging(value);
                this._InternationalCallingCode = value;
                this.OnInternationalCallingCodeChanged();
                this.OnPropertyChanged("InternationalCallingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternationalCallingCode;
        partial void OnInternationalCallingCodeChanging(string value);
        partial void OnInternationalCallingCodeChanged();
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
