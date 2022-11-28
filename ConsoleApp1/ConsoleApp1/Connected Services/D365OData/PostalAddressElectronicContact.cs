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
    /// There are no comments for PostalAddressElectronicContactSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddressElectronicContactSingle")]
    public partial class PostalAddressElectronicContactSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PostalAddressElectronicContact>
    {
        /// <summary>
        /// Initialize a new PostalAddressElectronicContactSingle object.
        /// </summary>
        public PostalAddressElectronicContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PostalAddressElectronicContactSingle object.
        /// </summary>
        public PostalAddressElectronicContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PostalAddressElectronicContactSingle object.
        /// </summary>
        public PostalAddressElectronicContactSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PostalAddressElectronicContact> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PostalAddressElectronicContact in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Locator
    /// Type
    /// PostalAddressLocationId
    /// Description
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Locator", "Type", "PostalAddressLocationId", "Description")]
    [global::Microsoft.OData.Client.EntitySet("PostalAddressElectronicContacts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddressElectronicContact")]
    public partial class PostalAddressElectronicContact : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PostalAddressElectronicContact object.
        /// </summary>
        /// <param name="locator">Initial value of Locator.</param>
        /// <param name="postalAddressLocationId">Initial value of PostalAddressLocationId.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PostalAddressElectronicContact CreatePostalAddressElectronicContact(string locator, string postalAddressLocationId, string description)
        {
            PostalAddressElectronicContact postalAddressElectronicContact = new PostalAddressElectronicContact();
            postalAddressElectronicContact.Locator = locator;
            postalAddressElectronicContact.PostalAddressLocationId = postalAddressLocationId;
            postalAddressElectronicContact.Description = description;
            return postalAddressElectronicContact;
        }
        /// <summary>
        /// There are no comments for Property Locator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Locator")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Locator is required.")]
        public virtual string Locator
        {
            get
            {
                return this._Locator;
            }
            set
            {
                this.OnLocatorChanging(value);
                this._Locator = value;
                this.OnLocatorChanged();
                this.OnPropertyChanged("Locator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Locator;
        partial void OnLocatorChanging(string value);
        partial void OnLocatorChanged();
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
        /// There are no comments for Property PostalAddressLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddressLocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostalAddressLocationId is required.")]
        public virtual string PostalAddressLocationId
        {
            get
            {
                return this._PostalAddressLocationId;
            }
            set
            {
                this.OnPostalAddressLocationIdChanging(value);
                this._PostalAddressLocationId = value;
                this.OnPostalAddressLocationIdChanged();
                this.OnPropertyChanged("PostalAddressLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostalAddressLocationId;
        partial void OnPostalAddressLocationIdChanging(string value);
        partial void OnPostalAddressLocationIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Description is required.")]
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
        /// There are no comments for Property Purpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Purpose")]
        public virtual string Purpose
        {
            get
            {
                return this._Purpose;
            }
            set
            {
                this.OnPurposeChanging(value);
                this._Purpose = value;
                this.OnPurposeChanged();
                this.OnPropertyChanged("Purpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Purpose;
        partial void OnPurposeChanging(string value);
        partial void OnPurposeChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocationId")]
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
        /// There are no comments for Property IsMobile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsMobile")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsMobile
        {
            get
            {
                return this._IsMobile;
            }
            set
            {
                this.OnIsMobileChanging(value);
                this._IsMobile = value;
                this.OnIsMobileChanged();
                this.OnPropertyChanged("IsMobile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsMobile;
        partial void OnIsMobileChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsMobileChanged();
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