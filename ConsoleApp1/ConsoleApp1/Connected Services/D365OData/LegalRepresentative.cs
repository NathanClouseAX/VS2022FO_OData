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
    /// There are no comments for LegalRepresentativeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentativeSingle")]
    public partial class LegalRepresentativeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LegalRepresentative>
    {
        /// <summary>
        /// Initialize a new LegalRepresentativeSingle object.
        /// </summary>
        public LegalRepresentativeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LegalRepresentativeSingle object.
        /// </summary>
        public LegalRepresentativeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LegalRepresentativeSingle object.
        /// </summary>
        public LegalRepresentativeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LegalRepresentative> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LegalRepresentative in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CPF
    /// FiscalOrganizationRootFiscalEstablishment
    /// FiscalOrganizationRootFiscalEstablishmentDataArea
    /// Role
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CPF", "FiscalOrganizationRootFiscalEstablishment", "FiscalOrganizationRootFiscalEstablishmentDataArea", "Role")]
    [global::Microsoft.OData.Client.EntitySet("LegalRepresentatives")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LegalRepresentative")]
    public partial class LegalRepresentative : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LegalRepresentative object.
        /// </summary>
        /// <param name="cPF">Initial value of CPF.</param>
        /// <param name="fiscalOrganizationRootFiscalEstablishment">Initial value of FiscalOrganizationRootFiscalEstablishment.</param>
        /// <param name="fiscalOrganizationRootFiscalEstablishmentDataArea">Initial value of FiscalOrganizationRootFiscalEstablishmentDataArea.</param>
        /// <param name="cRCExpirationDate">Initial value of CRCExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LegalRepresentative CreateLegalRepresentative(string cPF, string fiscalOrganizationRootFiscalEstablishment, string fiscalOrganizationRootFiscalEstablishmentDataArea, global::System.DateTimeOffset cRCExpirationDate)
        {
            LegalRepresentative legalRepresentative = new LegalRepresentative();
            legalRepresentative.CPF = cPF;
            legalRepresentative.FiscalOrganizationRootFiscalEstablishment = fiscalOrganizationRootFiscalEstablishment;
            legalRepresentative.FiscalOrganizationRootFiscalEstablishmentDataArea = fiscalOrganizationRootFiscalEstablishmentDataArea;
            legalRepresentative.CRCExpirationDate = cRCExpirationDate;
            return legalRepresentative;
        }
        /// <summary>
        /// There are no comments for Property CPF in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CPF")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CPF is required.")]
        public virtual string CPF
        {
            get
            {
                return this._CPF;
            }
            set
            {
                this.OnCPFChanging(value);
                this._CPF = value;
                this.OnCPFChanged();
                this.OnPropertyChanged("CPF");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CPF;
        partial void OnCPFChanging(string value);
        partial void OnCPFChanged();
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
        /// There are no comments for Property Role in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Role")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> Role
        {
            get
            {
                return this._Role;
            }
            set
            {
                this.OnRoleChanging(value);
                this._Role = value;
                this.OnRoleChanged();
                this.OnPropertyChanged("Role");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> _Role;
        partial void OnRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LegalRepresentativeType_BR> value);
        partial void OnRoleChanged();
        /// <summary>
        /// There are no comments for Property CRC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CRC")]
        public virtual string CRC
        {
            get
            {
                return this._CRC;
            }
            set
            {
                this.OnCRCChanging(value);
                this._CRC = value;
                this.OnCRCChanged();
                this.OnPropertyChanged("CRC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CRC;
        partial void OnCRCChanging(string value);
        partial void OnCRCChanged();
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
        /// There are no comments for Property CRCState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CRCState")]
        public virtual string CRCState
        {
            get
            {
                return this._CRCState;
            }
            set
            {
                this.OnCRCStateChanging(value);
                this._CRCState = value;
                this.OnCRCStateChanged();
                this.OnPropertyChanged("CRCState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CRCState;
        partial void OnCRCStateChanging(string value);
        partial void OnCRCStateChanged();
        /// <summary>
        /// There are no comments for Property ValidatedInRFBAuthority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidatedInRFBAuthority")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ValidatedInRFBAuthority
        {
            get
            {
                return this._ValidatedInRFBAuthority;
            }
            set
            {
                this.OnValidatedInRFBAuthorityChanging(value);
                this._ValidatedInRFBAuthority = value;
                this.OnValidatedInRFBAuthorityChanged();
                this.OnPropertyChanged("ValidatedInRFBAuthority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ValidatedInRFBAuthority;
        partial void OnValidatedInRFBAuthorityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnValidatedInRFBAuthorityChanged();
        /// <summary>
        /// There are no comments for Property CRCExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CRCExpirationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CRCExpirationDate is required.")]
        public virtual global::System.DateTimeOffset CRCExpirationDate
        {
            get
            {
                return this._CRCExpirationDate;
            }
            set
            {
                this.OnCRCExpirationDateChanging(value);
                this._CRCExpirationDate = value;
                this.OnCRCExpirationDateChanged();
                this.OnPropertyChanged("CRCExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CRCExpirationDate;
        partial void OnCRCExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnCRCExpirationDateChanged();
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