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
    /// There are no comments for LicensePlateLabelBuildSkipFieldConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LicensePlateLabelBuildSkipFieldConfigurationSingle")]
    public partial class LicensePlateLabelBuildSkipFieldConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LicensePlateLabelBuildSkipFieldConfiguration>
    {
        /// <summary>
        /// Initialize a new LicensePlateLabelBuildSkipFieldConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildSkipFieldConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LicensePlateLabelBuildSkipFieldConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildSkipFieldConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LicensePlateLabelBuildSkipFieldConfigurationSingle object.
        /// </summary>
        public LicensePlateLabelBuildSkipFieldConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LicensePlateLabelBuildSkipFieldConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LicensePlateLabelBuildSkipFieldConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LicensePlateLabelBuildConfigurationId
    /// SkipFieldName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LicensePlateLabelBuildConfigurationId", "SkipFieldName")]
    [global::Microsoft.OData.Client.EntitySet("LicensePlateLabelBuildSkipFieldConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LicensePlateLabelBuildSkipFieldConfiguration")]
    public partial class LicensePlateLabelBuildSkipFieldConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LicensePlateLabelBuildSkipFieldConfiguration object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="licensePlateLabelBuildConfigurationId">Initial value of LicensePlateLabelBuildConfigurationId.</param>
        /// <param name="skipFieldName">Initial value of SkipFieldName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LicensePlateLabelBuildSkipFieldConfiguration CreateLicensePlateLabelBuildSkipFieldConfiguration(string dataAreaId, string licensePlateLabelBuildConfigurationId, string skipFieldName)
        {
            LicensePlateLabelBuildSkipFieldConfiguration licensePlateLabelBuildSkipFieldConfiguration = new LicensePlateLabelBuildSkipFieldConfiguration();
            licensePlateLabelBuildSkipFieldConfiguration.DataAreaId = dataAreaId;
            licensePlateLabelBuildSkipFieldConfiguration.LicensePlateLabelBuildConfigurationId = licensePlateLabelBuildConfigurationId;
            licensePlateLabelBuildSkipFieldConfiguration.SkipFieldName = skipFieldName;
            return licensePlateLabelBuildSkipFieldConfiguration;
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
        /// There are no comments for Property SkipFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SkipFieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SkipFieldName is required.")]
        public virtual string SkipFieldName
        {
            get
            {
                return this._SkipFieldName;
            }
            set
            {
                this.OnSkipFieldNameChanging(value);
                this._SkipFieldName = value;
                this.OnSkipFieldNameChanged();
                this.OnPropertyChanged("SkipFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SkipFieldName;
        partial void OnSkipFieldNameChanging(string value);
        partial void OnSkipFieldNameChanged();
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
