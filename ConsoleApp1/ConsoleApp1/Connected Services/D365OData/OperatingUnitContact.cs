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
    /// There are no comments for OperatingUnitContactSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnitContactSingle")]
    public partial class OperatingUnitContactSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OperatingUnitContact>
    {
        /// <summary>
        /// Initialize a new OperatingUnitContactSingle object.
        /// </summary>
        public OperatingUnitContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OperatingUnitContactSingle object.
        /// </summary>
        public OperatingUnitContactSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OperatingUnitContactSingle object.
        /// </summary>
        public OperatingUnitContactSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OperatingUnitContact> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnit")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle OperatingUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperatingUnit == null))
                {
                    this._OperatingUnit = new global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle(this.Context, GetPath("OperatingUnit"));
                }
                return this._OperatingUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle _OperatingUnit;
    }
    /// <summary>
    /// There are no comments for OperatingUnitContact in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Type
    /// Description
    /// Locator
    /// OMOperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Type", "Description", "Locator", "OMOperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("OperatingUnitContacts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnitContact")]
    public partial class OperatingUnitContact : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OperatingUnitContact object.
        /// </summary>
        /// <param name="description">Initial value of Description.</param>
        /// <param name="locator">Initial value of Locator.</param>
        /// <param name="oMOperatingUnitNumber">Initial value of OMOperatingUnitNumber.</param>
        /// <param name="operatingUnit">Initial value of OperatingUnit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OperatingUnitContact CreateOperatingUnitContact(string description, string locator, string oMOperatingUnitNumber, global::Microsoft.Dynamics.DataEntities.OperatingUnit operatingUnit)
        {
            OperatingUnitContact operatingUnitContact = new OperatingUnitContact();
            operatingUnitContact.Description = description;
            operatingUnitContact.Locator = locator;
            operatingUnitContact.OMOperatingUnitNumber = oMOperatingUnitNumber;
            if ((operatingUnit == null))
            {
                throw new global::System.ArgumentNullException("operatingUnit");
            }
            operatingUnitContact.OperatingUnit = operatingUnit;
            return operatingUnitContact;
        }
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
        /// There are no comments for Property OMOperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OMOperatingUnitNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OMOperatingUnitNumber is required.")]
        public virtual string OMOperatingUnitNumber
        {
            get
            {
                return this._OMOperatingUnitNumber;
            }
            set
            {
                this.OnOMOperatingUnitNumberChanging(value);
                this._OMOperatingUnitNumber = value;
                this.OnOMOperatingUnitNumberChanged();
                this.OnPropertyChanged("OMOperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OMOperatingUnitNumber;
        partial void OnOMOperatingUnitNumberChanging(string value);
        partial void OnOMOperatingUnitNumberChanged();
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
        /// There are no comments for Property CountryRegionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionCode")]
        public virtual string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this.OnCountryRegionCodeChanging(value);
                this._CountryRegionCode = value;
                this.OnCountryRegionCodeChanged();
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionCode;
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
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
        /// There are no comments for Property LocatorExtension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocatorExtension")]
        public virtual string LocatorExtension
        {
            get
            {
                return this._LocatorExtension;
            }
            set
            {
                this.OnLocatorExtensionChanging(value);
                this._LocatorExtension = value;
                this.OnLocatorExtensionChanged();
                this.OnPropertyChanged("LocatorExtension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocatorExtension;
        partial void OnLocatorExtensionChanging(string value);
        partial void OnLocatorExtensionChanged();
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
        /// There are no comments for Property OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperatingUnit is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnit OperatingUnit
        {
            get
            {
                return this._OperatingUnit;
            }
            set
            {
                this.OnOperatingUnitChanging(value);
                this._OperatingUnit = value;
                this.OnOperatingUnitChanged();
                this.OnPropertyChanged("OperatingUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnit _OperatingUnit;
        partial void OnOperatingUnitChanging(global::Microsoft.Dynamics.DataEntities.OperatingUnit value);
        partial void OnOperatingUnitChanged();
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
