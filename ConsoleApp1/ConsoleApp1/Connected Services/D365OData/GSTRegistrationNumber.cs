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
    /// There are no comments for GSTRegistrationNumberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GSTRegistrationNumberSingle")]
    public partial class GSTRegistrationNumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GSTRegistrationNumber>
    {
        /// <summary>
        /// Initialize a new GSTRegistrationNumberSingle object.
        /// </summary>
        public GSTRegistrationNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GSTRegistrationNumberSingle object.
        /// </summary>
        public GSTRegistrationNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GSTRegistrationNumberSingle object.
        /// </summary>
        public GSTRegistrationNumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GSTRegistrationNumber> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for GSTRegistrationNumber in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RegistrationNumberType
    /// RegistrationNumber
    /// CasualToDate
    /// CasualFromDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RegistrationNumberType", "RegistrationNumber", "CasualToDate", "CasualFromDate")]
    [global::Microsoft.OData.Client.EntitySet("GSTRegistrationNumbers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GSTRegistrationNumber")]
    public partial class GSTRegistrationNumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GSTRegistrationNumber object.
        /// </summary>
        /// <param name="registrationNumber">Initial value of RegistrationNumber.</param>
        /// <param name="casualToDate">Initial value of CasualToDate.</param>
        /// <param name="casualFromDate">Initial value of CasualFromDate.</param>
        /// <param name="turnOver">Initial value of TurnOver.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GSTRegistrationNumber CreateGSTRegistrationNumber(string registrationNumber, global::System.DateTimeOffset casualToDate, global::System.DateTimeOffset casualFromDate, decimal turnOver)
        {
            GSTRegistrationNumber gSTRegistrationNumber = new GSTRegistrationNumber();
            gSTRegistrationNumber.RegistrationNumber = registrationNumber;
            gSTRegistrationNumber.CasualToDate = casualToDate;
            gSTRegistrationNumber.CasualFromDate = casualFromDate;
            gSTRegistrationNumber.TurnOver = turnOver;
            return gSTRegistrationNumber;
        }
        /// <summary>
        /// There are no comments for Property RegistrationNumberType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationNumberType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> RegistrationNumberType
        {
            get
            {
                return this._RegistrationNumberType;
            }
            set
            {
                this.OnRegistrationNumberTypeChanging(value);
                this._RegistrationNumberType = value;
                this.OnRegistrationNumberTypeChanged();
                this.OnPropertyChanged("RegistrationNumberType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> _RegistrationNumberType;
        partial void OnRegistrationNumberTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRegistrationType_IN> value);
        partial void OnRegistrationNumberTypeChanged();
        /// <summary>
        /// There are no comments for Property RegistrationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegistrationNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegistrationNumber is required.")]
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
        /// There are no comments for Property CasualToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CasualToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CasualToDate is required.")]
        public virtual global::System.DateTimeOffset CasualToDate
        {
            get
            {
                return this._CasualToDate;
            }
            set
            {
                this.OnCasualToDateChanging(value);
                this._CasualToDate = value;
                this.OnCasualToDateChanged();
                this.OnPropertyChanged("CasualToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CasualToDate;
        partial void OnCasualToDateChanging(global::System.DateTimeOffset value);
        partial void OnCasualToDateChanged();
        /// <summary>
        /// There are no comments for Property CasualFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CasualFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CasualFromDate is required.")]
        public virtual global::System.DateTimeOffset CasualFromDate
        {
            get
            {
                return this._CasualFromDate;
            }
            set
            {
                this.OnCasualFromDateChanging(value);
                this._CasualFromDate = value;
                this.OnCasualFromDateChanged();
                this.OnPropertyChanged("CasualFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CasualFromDate;
        partial void OnCasualFromDateChanging(global::System.DateTimeOffset value);
        partial void OnCasualFromDateChanged();
        /// <summary>
        /// There are no comments for Property BusinessVerticals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessVerticals")]
        public virtual string BusinessVerticals
        {
            get
            {
                return this._BusinessVerticals;
            }
            set
            {
                this.OnBusinessVerticalsChanging(value);
                this._BusinessVerticals = value;
                this.OnBusinessVerticalsChanged();
                this.OnPropertyChanged("BusinessVerticals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BusinessVerticals;
        partial void OnBusinessVerticalsChanging(string value);
        partial void OnBusinessVerticalsChanged();
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
        /// There are no comments for Property Shared in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Shared")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Shared
        {
            get
            {
                return this._Shared;
            }
            set
            {
                this.OnSharedChanging(value);
                this._Shared = value;
                this.OnSharedChanged();
                this.OnPropertyChanged("Shared");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Shared;
        partial void OnSharedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSharedChanged();
        /// <summary>
        /// There are no comments for Property CasualDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CasualDescription")]
        public virtual string CasualDescription
        {
            get
            {
                return this._CasualDescription;
            }
            set
            {
                this.OnCasualDescriptionChanging(value);
                this._CasualDescription = value;
                this.OnCasualDescriptionChanged();
                this.OnPropertyChanged("CasualDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CasualDescription;
        partial void OnCasualDescriptionChanging(string value);
        partial void OnCasualDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TurnOver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TurnOver")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TurnOver is required.")]
        public virtual decimal TurnOver
        {
            get
            {
                return this._TurnOver;
            }
            set
            {
                this.OnTurnOverChanging(value);
                this._TurnOver = value;
                this.OnTurnOverChanged();
                this.OnPropertyChanged("TurnOver");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TurnOver;
        partial void OnTurnOverChanging(decimal value);
        partial void OnTurnOverChanged();
        /// <summary>
        /// There are no comments for Property CreatedCompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreatedCompanyId")]
        public virtual string CreatedCompanyId
        {
            get
            {
                return this._CreatedCompanyId;
            }
            set
            {
                this.OnCreatedCompanyIdChanging(value);
                this._CreatedCompanyId = value;
                this.OnCreatedCompanyIdChanged();
                this.OnPropertyChanged("CreatedCompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreatedCompanyId;
        partial void OnCreatedCompanyIdChanging(string value);
        partial void OnCreatedCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GSTType_IN> Type
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GSTType_IN> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GSTType_IN> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property NameOfTaxablePerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameOfTaxablePerson")]
        public virtual string NameOfTaxablePerson
        {
            get
            {
                return this._NameOfTaxablePerson;
            }
            set
            {
                this.OnNameOfTaxablePersonChanging(value);
                this._NameOfTaxablePerson = value;
                this.OnNameOfTaxablePersonChanged();
                this.OnPropertyChanged("NameOfTaxablePerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameOfTaxablePerson;
        partial void OnNameOfTaxablePersonChanging(string value);
        partial void OnNameOfTaxablePersonChanged();
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