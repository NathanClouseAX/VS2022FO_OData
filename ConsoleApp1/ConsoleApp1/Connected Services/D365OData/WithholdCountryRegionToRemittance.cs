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
    /// There are no comments for WithholdCountryRegionToRemittanceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdCountryRegionToRemittanceSingle")]
    public partial class WithholdCountryRegionToRemittanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdCountryRegionToRemittance>
    {
        /// <summary>
        /// Initialize a new WithholdCountryRegionToRemittanceSingle object.
        /// </summary>
        public WithholdCountryRegionToRemittanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdCountryRegionToRemittanceSingle object.
        /// </summary>
        public WithholdCountryRegionToRemittanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdCountryRegionToRemittanceSingle object.
        /// </summary>
        public WithholdCountryRegionToRemittanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdCountryRegionToRemittance> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WithholdCountryRegionToRemittance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CountryCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CountryCode")]
    [global::Microsoft.OData.Client.EntitySet("WithholdCountryRegionToRemittances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdCountryRegionToRemittance")]
    public partial class WithholdCountryRegionToRemittance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdCountryRegionToRemittance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="countryCode">Initial value of CountryCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdCountryRegionToRemittance CreateWithholdCountryRegionToRemittance(string dataAreaId, string countryCode)
        {
            WithholdCountryRegionToRemittance withholdCountryRegionToRemittance = new WithholdCountryRegionToRemittance();
            withholdCountryRegionToRemittance.DataAreaId = dataAreaId;
            withholdCountryRegionToRemittance.CountryCode = countryCode;
            return withholdCountryRegionToRemittance;
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
        /// There are no comments for Property CountryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryCode is required.")]
        public virtual string CountryCode
        {
            get
            {
                return this._CountryCode;
            }
            set
            {
                this.OnCountryCodeChanging(value);
                this._CountryCode = value;
                this.OnCountryCodeChanged();
                this.OnPropertyChanged("CountryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryCode;
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
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
        /// There are no comments for Property CountryRegionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionName")]
        public virtual string CountryRegionName
        {
            get
            {
                return this._CountryRegionName;
            }
            set
            {
                this.OnCountryRegionNameChanging(value);
                this._CountryRegionName = value;
                this.OnCountryRegionNameChanged();
                this.OnPropertyChanged("CountryRegionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionName;
        partial void OnCountryRegionNameChanging(string value);
        partial void OnCountryRegionNameChanged();
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