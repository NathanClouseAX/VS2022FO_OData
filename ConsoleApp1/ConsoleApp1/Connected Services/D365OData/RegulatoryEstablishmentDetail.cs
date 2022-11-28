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
    /// There are no comments for RegulatoryEstablishmentDetailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentDetailSingle")]
    public partial class RegulatoryEstablishmentDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishmentDetail>
    {
        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishmentDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for RegulatoryEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishment")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle RegulatoryEstablishment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RegulatoryEstablishment == null))
                {
                    this._RegulatoryEstablishment = new global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle(this.Context, GetPath("RegulatoryEstablishment"));
                }
                return this._RegulatoryEstablishment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle _RegulatoryEstablishment;
        /// <summary>
        /// There are no comments for EmploymentV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentV2Single EmploymentV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentV2 == null))
                {
                    this._EmploymentV2 = new global::Microsoft.Dynamics.DataEntities.EmploymentV2Single(this.Context, GetPath("EmploymentV2"));
                }
                return this._EmploymentV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentV2Single _EmploymentV2;
        /// <summary>
        /// There are no comments for Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employment")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentSingle Employment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employment == null))
                {
                    this._Employment = new global::Microsoft.Dynamics.DataEntities.EmploymentSingle(this.Context, GetPath("Employment"));
                }
                return this._Employment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentSingle _Employment;
        /// <summary>
        /// There are no comments for EmploymentPerCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentPerCompany")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentPerCompanySingle EmploymentPerCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentPerCompany == null))
                {
                    this._EmploymentPerCompany = new global::Microsoft.Dynamics.DataEntities.EmploymentPerCompanySingle(this.Context, GetPath("EmploymentPerCompany"));
                }
                return this._EmploymentPerCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentPerCompanySingle _EmploymentPerCompany;
    }
    /// <summary>
    /// There are no comments for RegulatoryEstablishmentDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RegulatoryEstablishmentId
    /// LegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RegulatoryEstablishmentId", "LegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("RegulatoryEstablishmentDetails")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentDetail")]
    public partial class RegulatoryEstablishmentDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RegulatoryEstablishmentDetail object.
        /// </summary>
        /// <param name="regulatoryEstablishmentId">Initial value of RegulatoryEstablishmentId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        /// <param name="regulatoryEstablishment">Initial value of RegulatoryEstablishment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RegulatoryEstablishmentDetail CreateRegulatoryEstablishmentDetail(string regulatoryEstablishmentId, string legalEntityId, global::Microsoft.Dynamics.DataEntities.LegalEntity legalEntity, global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment regulatoryEstablishment)
        {
            RegulatoryEstablishmentDetail regulatoryEstablishmentDetail = new RegulatoryEstablishmentDetail();
            regulatoryEstablishmentDetail.RegulatoryEstablishmentId = regulatoryEstablishmentId;
            regulatoryEstablishmentDetail.LegalEntityId = legalEntityId;
            if ((legalEntity == null))
            {
                throw new global::System.ArgumentNullException("legalEntity");
            }
            regulatoryEstablishmentDetail.LegalEntity = legalEntity;
            if ((regulatoryEstablishment == null))
            {
                throw new global::System.ArgumentNullException("regulatoryEstablishment");
            }
            regulatoryEstablishmentDetail.RegulatoryEstablishment = regulatoryEstablishment;
            return regulatoryEstablishmentDetail;
        }
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegulatoryEstablishmentId is required.")]
        public virtual string RegulatoryEstablishmentId
        {
            get
            {
                return this._RegulatoryEstablishmentId;
            }
            set
            {
                this.OnRegulatoryEstablishmentIdChanging(value);
                this._RegulatoryEstablishmentId = value;
                this.OnRegulatoryEstablishmentIdChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegulatoryEstablishmentId;
        partial void OnRegulatoryEstablishmentIdChanging(string value);
        partial void OnRegulatoryEstablishmentIdChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property UnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitNumber")]
        public virtual string UnitNumber
        {
            get
            {
                return this._UnitNumber;
            }
            set
            {
                this.OnUnitNumberChanging(value);
                this._UnitNumber = value;
                this.OnUnitNumberChanged();
                this.OnPropertyChanged("UnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitNumber;
        partial void OnUnitNumberChanging(string value);
        partial void OnUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property DunsNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DunsNumber")]
        public virtual string DunsNumber
        {
            get
            {
                return this._DunsNumber;
            }
            set
            {
                this.OnDunsNumberChanging(value);
                this._DunsNumber = value;
                this.OnDunsNumberChanged();
                this.OnPropertyChanged("DunsNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DunsNumber;
        partial void OnDunsNumberChanging(string value);
        partial void OnDunsNumberChanged();
        /// <summary>
        /// There are no comments for Property IsHeadquarter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsHeadquarter")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsHeadquarter
        {
            get
            {
                return this._IsHeadquarter;
            }
            set
            {
                this.OnIsHeadquarterChanging(value);
                this._IsHeadquarter = value;
                this.OnIsHeadquarterChanged();
                this.OnPropertyChanged("IsHeadquarter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsHeadquarter;
        partial void OnIsHeadquarterChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsHeadquarterChanged();
        /// <summary>
        /// There are no comments for Property EmployerIdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployerIdentificationNumber")]
        public virtual string EmployerIdentificationNumber
        {
            get
            {
                return this._EmployerIdentificationNumber;
            }
            set
            {
                this.OnEmployerIdentificationNumberChanging(value);
                this._EmployerIdentificationNumber = value;
                this.OnEmployerIdentificationNumberChanged();
                this.OnPropertyChanged("EmployerIdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployerIdentificationNumber;
        partial void OnEmployerIdentificationNumberChanging(string value);
        partial void OnEmployerIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property NAICSCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NAICSCode")]
        public virtual string NAICSCode
        {
            get
            {
                return this._NAICSCode;
            }
            set
            {
                this.OnNAICSCodeChanging(value);
                this._NAICSCode = value;
                this.OnNAICSCodeChanged();
                this.OnPropertyChanged("NAICSCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NAICSCode;
        partial void OnNAICSCodeChanging(string value);
        partial void OnNAICSCodeChanged();
        /// <summary>
        /// There are no comments for Property IndustryDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IndustryDescription")]
        public virtual string IndustryDescription
        {
            get
            {
                return this._IndustryDescription;
            }
            set
            {
                this.OnIndustryDescriptionChanging(value);
                this._IndustryDescription = value;
                this.OnIndustryDescriptionChanged();
                this.OnPropertyChanged("IndustryDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IndustryDescription;
        partial void OnIndustryDescriptionChanging(string value);
        partial void OnIndustryDescriptionChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntity is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishment")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RegulatoryEstablishment is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment RegulatoryEstablishment
        {
            get
            {
                return this._RegulatoryEstablishment;
            }
            set
            {
                this.OnRegulatoryEstablishmentChanging(value);
                this._RegulatoryEstablishment = value;
                this.OnRegulatoryEstablishmentChanged();
                this.OnPropertyChanged("RegulatoryEstablishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment _RegulatoryEstablishment;
        partial void OnRegulatoryEstablishmentChanging(global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment value);
        partial void OnRegulatoryEstablishmentChanged();
        /// <summary>
        /// There are no comments for Property EmploymentV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentV2 EmploymentV2
        {
            get
            {
                return this._EmploymentV2;
            }
            set
            {
                this.OnEmploymentV2Changing(value);
                this._EmploymentV2 = value;
                this.OnEmploymentV2Changed();
                this.OnPropertyChanged("EmploymentV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentV2 _EmploymentV2;
        partial void OnEmploymentV2Changing(global::Microsoft.Dynamics.DataEntities.EmploymentV2 value);
        partial void OnEmploymentV2Changed();
        /// <summary>
        /// There are no comments for Property Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Employment")]
        public virtual global::Microsoft.Dynamics.DataEntities.Employment Employment
        {
            get
            {
                return this._Employment;
            }
            set
            {
                this.OnEmploymentChanging(value);
                this._Employment = value;
                this.OnEmploymentChanged();
                this.OnPropertyChanged("Employment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Employment _Employment;
        partial void OnEmploymentChanging(global::Microsoft.Dynamics.DataEntities.Employment value);
        partial void OnEmploymentChanged();
        /// <summary>
        /// There are no comments for Property EmploymentPerCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentPerCompany")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentPerCompany EmploymentPerCompany
        {
            get
            {
                return this._EmploymentPerCompany;
            }
            set
            {
                this.OnEmploymentPerCompanyChanging(value);
                this._EmploymentPerCompany = value;
                this.OnEmploymentPerCompanyChanged();
                this.OnPropertyChanged("EmploymentPerCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentPerCompany _EmploymentPerCompany;
        partial void OnEmploymentPerCompanyChanging(global::Microsoft.Dynamics.DataEntities.EmploymentPerCompany value);
        partial void OnEmploymentPerCompanyChanged();
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