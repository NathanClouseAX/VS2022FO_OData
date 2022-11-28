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
    /// There are no comments for LicensePlateLabelBuildConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LicensePlateLabelBuildConfigurationSingle")]
    public partial class LicensePlateLabelBuildConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LicensePlateLabelBuildConfiguration>
    {
        /// <summary>
        /// Initialize a new LicensePlateLabelBuildConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LicensePlateLabelBuildConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LicensePlateLabelBuildConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LicensePlateLabelBuildConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LicensePlateLabelBuildConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LicensePlateLabelBuildConfigurationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LicensePlateLabelBuildConfigurationId")]
    [global::Microsoft.OData.Client.EntitySet("LicensePlateLabelBuildConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LicensePlateLabelBuildConfiguration")]
    public partial class LicensePlateLabelBuildConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LicensePlateLabelBuildConfiguration object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="licensePlateLabelBuildConfigurationId">Initial value of LicensePlateLabelBuildConfigurationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LicensePlateLabelBuildConfiguration CreateLicensePlateLabelBuildConfiguration(string dataAreaId, string licensePlateLabelBuildConfigurationId)
        {
            LicensePlateLabelBuildConfiguration licensePlateLabelBuildConfiguration = new LicensePlateLabelBuildConfiguration();
            licensePlateLabelBuildConfiguration.DataAreaId = dataAreaId;
            licensePlateLabelBuildConfiguration.LicensePlateLabelBuildConfigurationId = licensePlateLabelBuildConfigurationId;
            return licensePlateLabelBuildConfiguration;
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
        /// There are no comments for Property LicensePlateLabelBuildConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LicensePlateLabelBuildConfigurationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LicensePlateLabelBuildConfigurationId is required.")]
        public virtual string LicensePlateLabelBuildConfigurationId
        {
            get
            {
                return this._LicensePlateLabelBuildConfigurationId;
            }
            set
            {
                this.OnLicensePlateLabelBuildConfigurationIdChanging(value);
                this._LicensePlateLabelBuildConfigurationId = value;
                this.OnLicensePlateLabelBuildConfigurationIdChanged();
                this.OnPropertyChanged("LicensePlateLabelBuildConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LicensePlateLabelBuildConfigurationId;
        partial void OnLicensePlateLabelBuildConfigurationIdChanging(string value);
        partial void OnLicensePlateLabelBuildConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ConfigurationDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfigurationDescription")]
        public virtual string ConfigurationDescription
        {
            get
            {
                return this._ConfigurationDescription;
            }
            set
            {
                this.OnConfigurationDescriptionChanging(value);
                this._ConfigurationDescription = value;
                this.OnConfigurationDescriptionChanged();
                this.OnPropertyChanged("ConfigurationDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfigurationDescription;
        partial void OnConfigurationDescriptionChanging(string value);
        partial void OnConfigurationDescriptionChanged();
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
