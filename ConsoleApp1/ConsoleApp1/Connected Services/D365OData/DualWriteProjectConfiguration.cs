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
    /// There are no comments for DualWriteProjectConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DualWriteProjectConfigurationSingle")]
    public partial class DualWriteProjectConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DualWriteProjectConfiguration>
    {
        /// <summary>
        /// Initialize a new DualWriteProjectConfigurationSingle object.
        /// </summary>
        public DualWriteProjectConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DualWriteProjectConfigurationSingle object.
        /// </summary>
        public DualWriteProjectConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DualWriteProjectConfigurationSingle object.
        /// </summary>
        public DualWriteProjectConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DualWriteProjectConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DualWriteProjectConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProjectName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProjectName")]
    [global::Microsoft.OData.Client.EntitySet("DualWriteProjectConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DualWriteProjectConfiguration")]
    public partial class DualWriteProjectConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DualWriteProjectConfiguration object.
        /// </summary>
        /// <param name="projectName">Initial value of ProjectName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DualWriteProjectConfiguration CreateDualWriteProjectConfiguration(string projectName)
        {
            DualWriteProjectConfiguration dualWriteProjectConfiguration = new DualWriteProjectConfiguration();
            dualWriteProjectConfiguration.ProjectName = projectName;
            return dualWriteProjectConfiguration;
        }
        /// <summary>
        /// There are no comments for Property ProjectName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectName is required.")]
        public virtual string ProjectName
        {
            get
            {
                return this._ProjectName;
            }
            set
            {
                this.OnProjectNameChanging(value);
                this._ProjectName = value;
                this.OnProjectNameChanged();
                this.OnPropertyChanged("ProjectName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectName;
        partial void OnProjectNameChanging(string value);
        partial void OnProjectNameChanged();
        /// <summary>
        /// There are no comments for Property ServiceBusConnectionString in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceBusConnectionString")]
        public virtual string ServiceBusConnectionString
        {
            get
            {
                return this._ServiceBusConnectionString;
            }
            set
            {
                this.OnServiceBusConnectionStringChanging(value);
                this._ServiceBusConnectionString = value;
                this.OnServiceBusConnectionStringChanged();
                this.OnPropertyChanged("ServiceBusConnectionString");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceBusConnectionString;
        partial void OnServiceBusConnectionStringChanging(string value);
        partial void OnServiceBusConnectionStringChanged();
        /// <summary>
        /// There are no comments for Property EnableBatchLookup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnableBatchLookup")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableBatchLookup
        {
            get
            {
                return this._EnableBatchLookup;
            }
            set
            {
                this.OnEnableBatchLookupChanging(value);
                this._EnableBatchLookup = value;
                this.OnEnableBatchLookupChanged();
                this.OnPropertyChanged("EnableBatchLookup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableBatchLookup;
        partial void OnEnableBatchLookupChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableBatchLookupChanged();
        /// <summary>
        /// There are no comments for Property DualWriteAlertSettings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DualWriteAlertSettings")]
        public virtual string DualWriteAlertSettings
        {
            get
            {
                return this._DualWriteAlertSettings;
            }
            set
            {
                this.OnDualWriteAlertSettingsChanging(value);
                this._DualWriteAlertSettings = value;
                this.OnDualWriteAlertSettingsChanged();
                this.OnPropertyChanged("DualWriteAlertSettings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DualWriteAlertSettings;
        partial void OnDualWriteAlertSettingsChanging(string value);
        partial void OnDualWriteAlertSettingsChanged();
        /// <summary>
        /// There are no comments for Property ExternalEntityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalEntityName")]
        public virtual string ExternalEntityName
        {
            get
            {
                return this._ExternalEntityName;
            }
            set
            {
                this.OnExternalEntityNameChanging(value);
                this._ExternalEntityName = value;
                this.OnExternalEntityNameChanged();
                this.OnPropertyChanged("ExternalEntityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalEntityName;
        partial void OnExternalEntityNameChanging(string value);
        partial void OnExternalEntityNameChanged();
        /// <summary>
        /// There are no comments for Property EnableCache in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnableCache")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableCache
        {
            get
            {
                return this._EnableCache;
            }
            set
            {
                this.OnEnableCacheChanging(value);
                this._EnableCache = value;
                this.OnEnableCacheChanged();
                this.OnPropertyChanged("EnableCache");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableCache;
        partial void OnEnableCacheChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableCacheChanged();
        /// <summary>
        /// There are no comments for Property IntegrationKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntegrationKey")]
        public virtual string IntegrationKey
        {
            get
            {
                return this._IntegrationKey;
            }
            set
            {
                this.OnIntegrationKeyChanging(value);
                this._IntegrationKey = value;
                this.OnIntegrationKeyChanged();
                this.OnPropertyChanged("IntegrationKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntegrationKey;
        partial void OnIntegrationKeyChanging(string value);
        partial void OnIntegrationKeyChanged();
        /// <summary>
        /// There are no comments for Property StorageAccountSASConnectionString in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StorageAccountSASConnectionString")]
        public virtual string StorageAccountSASConnectionString
        {
            get
            {
                return this._StorageAccountSASConnectionString;
            }
            set
            {
                this.OnStorageAccountSASConnectionStringChanging(value);
                this._StorageAccountSASConnectionString = value;
                this.OnStorageAccountSASConnectionStringChanged();
                this.OnPropertyChanged("StorageAccountSASConnectionString");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StorageAccountSASConnectionString;
        partial void OnStorageAccountSASConnectionStringChanging(string value);
        partial void OnStorageAccountSASConnectionStringChanged();
        /// <summary>
        /// There are no comments for Property QueryFilterExpression in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryFilterExpression")]
        public virtual string QueryFilterExpression
        {
            get
            {
                return this._QueryFilterExpression;
            }
            set
            {
                this.OnQueryFilterExpressionChanging(value);
                this._QueryFilterExpression = value;
                this.OnQueryFilterExpressionChanged();
                this.OnPropertyChanged("QueryFilterExpression");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueryFilterExpression;
        partial void OnQueryFilterExpressionChanging(string value);
        partial void OnQueryFilterExpressionChanged();
        /// <summary>
        /// There are no comments for Property IsDebugMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDebugMode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDebugMode
        {
            get
            {
                return this._IsDebugMode;
            }
            set
            {
                this.OnIsDebugModeChanging(value);
                this._IsDebugMode = value;
                this.OnIsDebugModeChanged();
                this.OnPropertyChanged("IsDebugMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDebugMode;
        partial void OnIsDebugModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDebugModeChanged();
        /// <summary>
        /// There are no comments for Property DisablePerfEnhancements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisablePerfEnhancements")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DisablePerfEnhancements
        {
            get
            {
                return this._DisablePerfEnhancements;
            }
            set
            {
                this.OnDisablePerfEnhancementsChanging(value);
                this._DisablePerfEnhancements = value;
                this.OnDisablePerfEnhancementsChanged();
                this.OnPropertyChanged("DisablePerfEnhancements");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DisablePerfEnhancements;
        partial void OnDisablePerfEnhancementsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDisablePerfEnhancementsChanged();
        /// <summary>
        /// There are no comments for Property EnableFailureReconciliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnableFailureReconciliation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableFailureReconciliation
        {
            get
            {
                return this._EnableFailureReconciliation;
            }
            set
            {
                this.OnEnableFailureReconciliationChanging(value);
                this._EnableFailureReconciliation = value;
                this.OnEnableFailureReconciliationChanged();
                this.OnPropertyChanged("EnableFailureReconciliation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableFailureReconciliation;
        partial void OnEnableFailureReconciliationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableFailureReconciliationChanged();
        /// <summary>
        /// There are no comments for Property FieldMap in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldMap")]
        public virtual string FieldMap
        {
            get
            {
                return this._FieldMap;
            }
            set
            {
                this.OnFieldMapChanging(value);
                this._FieldMap = value;
                this.OnFieldMapChanged();
                this.OnPropertyChanged("FieldMap");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldMap;
        partial void OnFieldMapChanging(string value);
        partial void OnFieldMapChanged();
        /// <summary>
        /// There are no comments for Property ExternalLookupUrls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalLookupUrls")]
        public virtual string ExternalLookupUrls
        {
            get
            {
                return this._ExternalLookupUrls;
            }
            set
            {
                this.OnExternalLookupUrlsChanging(value);
                this._ExternalLookupUrls = value;
                this.OnExternalLookupUrlsChanged();
                this.OnPropertyChanged("ExternalLookupUrls");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalLookupUrls;
        partial void OnExternalLookupUrlsChanging(string value);
        partial void OnExternalLookupUrlsChanged();
        /// <summary>
        /// There are no comments for Property PartitionMap in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionMap")]
        public virtual string PartitionMap
        {
            get
            {
                return this._PartitionMap;
            }
            set
            {
                this.OnPartitionMapChanging(value);
                this._PartitionMap = value;
                this.OnPartitionMapChanged();
                this.OnPropertyChanged("PartitionMap");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartitionMap;
        partial void OnPartitionMapChanging(string value);
        partial void OnPartitionMapChanged();
        /// <summary>
        /// There are no comments for Property ExternalEnvironmentUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalEnvironmentUrl")]
        public virtual string ExternalEnvironmentUrl
        {
            get
            {
                return this._ExternalEnvironmentUrl;
            }
            set
            {
                this.OnExternalEnvironmentUrlChanging(value);
                this._ExternalEnvironmentUrl = value;
                this.OnExternalEnvironmentUrlChanged();
                this.OnPropertyChanged("ExternalEnvironmentUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalEnvironmentUrl;
        partial void OnExternalEnvironmentUrlChanging(string value);
        partial void OnExternalEnvironmentUrlChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DualWriteProjectStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DualWriteProjectStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DualWriteProjectStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property IsDelete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDelete")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDelete
        {
            get
            {
                return this._IsDelete;
            }
            set
            {
                this.OnIsDeleteChanging(value);
                this._IsDelete = value;
                this.OnIsDeleteChanged();
                this.OnPropertyChanged("IsDelete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDelete;
        partial void OnIsDeleteChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDeleteChanged();
        /// <summary>
        /// There are no comments for Property InternalEntityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternalEntityName")]
        public virtual string InternalEntityName
        {
            get
            {
                return this._InternalEntityName;
            }
            set
            {
                this.OnInternalEntityNameChanging(value);
                this._InternalEntityName = value;
                this.OnInternalEntityNameChanged();
                this.OnPropertyChanged("InternalEntityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternalEntityName;
        partial void OnInternalEntityNameChanging(string value);
        partial void OnInternalEntityNameChanged();
        /// <summary>
        /// There are no comments for Property DualWriteAutoPauseThresholdSetting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DualWriteAutoPauseThresholdSetting")]
        public virtual string DualWriteAutoPauseThresholdSetting
        {
            get
            {
                return this._DualWriteAutoPauseThresholdSetting;
            }
            set
            {
                this.OnDualWriteAutoPauseThresholdSettingChanging(value);
                this._DualWriteAutoPauseThresholdSetting = value;
                this.OnDualWriteAutoPauseThresholdSettingChanged();
                this.OnPropertyChanged("DualWriteAutoPauseThresholdSetting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DualWriteAutoPauseThresholdSetting;
        partial void OnDualWriteAutoPauseThresholdSettingChanging(string value);
        partial void OnDualWriteAutoPauseThresholdSettingChanged();
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
