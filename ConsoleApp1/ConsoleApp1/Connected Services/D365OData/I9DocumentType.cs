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
    /// There are no comments for I9DocumentTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("I9DocumentTypeSingle")]
    public partial class I9DocumentTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<I9DocumentType>
    {
        /// <summary>
        /// Initialize a new I9DocumentTypeSingle object.
        /// </summary>
        public I9DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new I9DocumentTypeSingle object.
        /// </summary>
        public I9DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new I9DocumentTypeSingle object.
        /// </summary>
        public I9DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<I9DocumentType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for IdentificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationType")]
        public virtual global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle IdentificationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._IdentificationType == null))
                {
                    this._IdentificationType = new global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle(this.Context, GetPath("IdentificationType"));
                }
                return this._IdentificationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IdentificationTypeSingle _IdentificationType;
        /// <summary>
        /// There are no comments for IssuingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuingAgency")]
        public virtual global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle IssuingAgency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._IssuingAgency == null))
                {
                    this._IssuingAgency = new global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle(this.Context, GetPath("IssuingAgency"));
                }
                return this._IssuingAgency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IssuingAgencySingle _IssuingAgency;
    }
    /// <summary>
    /// There are no comments for I9DocumentType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// I9DocumentTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("I9DocumentTypeId")]
    [global::Microsoft.OData.Client.EntitySet("I9DocumentTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("I9DocumentType")]
    public partial class I9DocumentType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new I9DocumentType object.
        /// </summary>
        /// <param name="i9DocumentTypeId">Initial value of I9DocumentTypeId.</param>
        /// <param name="expireDate">Initial value of ExpireDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static I9DocumentType CreateI9DocumentType(string i9DocumentTypeId, global::System.DateTimeOffset expireDate)
        {
            I9DocumentType i9DocumentType = new I9DocumentType();
            i9DocumentType.I9DocumentTypeId = i9DocumentTypeId;
            i9DocumentType.ExpireDate = expireDate;
            return i9DocumentType;
        }
        /// <summary>
        /// There are no comments for Property I9DocumentTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("I9DocumentTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "I9DocumentTypeId is required.")]
        public virtual string I9DocumentTypeId
        {
            get
            {
                return this._I9DocumentTypeId;
            }
            set
            {
                this.OnI9DocumentTypeIdChanging(value);
                this._I9DocumentTypeId = value;
                this.OnI9DocumentTypeIdChanged();
                this.OnPropertyChanged("I9DocumentTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _I9DocumentTypeId;
        partial void OnI9DocumentTypeIdChanging(string value);
        partial void OnI9DocumentTypeIdChanged();
        /// <summary>
        /// There are no comments for Property IdentificationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationTypeId")]
        public virtual string IdentificationTypeId
        {
            get
            {
                return this._IdentificationTypeId;
            }
            set
            {
                this.OnIdentificationTypeIdChanging(value);
                this._IdentificationTypeId = value;
                this.OnIdentificationTypeIdChanged();
                this.OnPropertyChanged("IdentificationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationTypeId;
        partial void OnIdentificationTypeIdChanging(string value);
        partial void OnIdentificationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property ListType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ListType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Hcmi9ListType> ListType
        {
            get
            {
                return this._ListType;
            }
            set
            {
                this.OnListTypeChanging(value);
                this._ListType = value;
                this.OnListTypeChanged();
                this.OnPropertyChanged("ListType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Hcmi9ListType> _ListType;
        partial void OnListTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Hcmi9ListType> value);
        partial void OnListTypeChanged();
        /// <summary>
        /// There are no comments for Property IssuingAgencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuingAgencyId")]
        public virtual string IssuingAgencyId
        {
            get
            {
                return this._IssuingAgencyId;
            }
            set
            {
                this.OnIssuingAgencyIdChanging(value);
                this._IssuingAgencyId = value;
                this.OnIssuingAgencyIdChanged();
                this.OnPropertyChanged("IssuingAgencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuingAgencyId;
        partial void OnIssuingAgencyIdChanging(string value);
        partial void OnIssuingAgencyIdChanged();
        /// <summary>
        /// There are no comments for Property ExpireDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpireDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpireDate is required.")]
        public virtual global::System.DateTimeOffset ExpireDate
        {
            get
            {
                return this._ExpireDate;
            }
            set
            {
                this.OnExpireDateChanging(value);
                this._ExpireDate = value;
                this.OnExpireDateChanged();
                this.OnPropertyChanged("ExpireDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpireDate;
        partial void OnExpireDateChanging(global::System.DateTimeOffset value);
        partial void OnExpireDateChanged();
        /// <summary>
        /// There are no comments for Property FormId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormId")]
        public virtual string FormId
        {
            get
            {
                return this._FormId;
            }
            set
            {
                this.OnFormIdChanging(value);
                this._FormId = value;
                this.OnFormIdChanged();
                this.OnPropertyChanged("FormId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormId;
        partial void OnFormIdChanging(string value);
        partial void OnFormIdChanged();
        /// <summary>
        /// There are no comments for Property IdentificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationType")]
        public virtual global::Microsoft.Dynamics.DataEntities.IdentificationType IdentificationType
        {
            get
            {
                return this._IdentificationType;
            }
            set
            {
                this.OnIdentificationTypeChanging(value);
                this._IdentificationType = value;
                this.OnIdentificationTypeChanged();
                this.OnPropertyChanged("IdentificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IdentificationType _IdentificationType;
        partial void OnIdentificationTypeChanging(global::Microsoft.Dynamics.DataEntities.IdentificationType value);
        partial void OnIdentificationTypeChanged();
        /// <summary>
        /// There are no comments for Property IssuingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuingAgency")]
        public virtual global::Microsoft.Dynamics.DataEntities.IssuingAgency IssuingAgency
        {
            get
            {
                return this._IssuingAgency;
            }
            set
            {
                this.OnIssuingAgencyChanging(value);
                this._IssuingAgency = value;
                this.OnIssuingAgencyChanged();
                this.OnPropertyChanged("IssuingAgency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.IssuingAgency _IssuingAgency;
        partial void OnIssuingAgencyChanging(global::Microsoft.Dynamics.DataEntities.IssuingAgency value);
        partial void OnIssuingAgencyChanged();
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