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
    /// There are no comments for ServerConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServerConfigurationSingle")]
    public partial class ServerConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ServerConfiguration>
    {
        /// <summary>
        /// Initialize a new ServerConfigurationSingle object.
        /// </summary>
        public ServerConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ServerConfigurationSingle object.
        /// </summary>
        public ServerConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ServerConfigurationSingle object.
        /// </summary>
        public ServerConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ServerConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ServerConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AOSInstanceName
    /// LoadBalancer
    /// ClusterName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AOSInstanceName", "LoadBalancer", "ClusterName")]
    [global::Microsoft.OData.Client.EntitySet("ServerConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServerConfiguration")]
    public partial class ServerConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ServerConfiguration object.
        /// </summary>
        /// <param name="aOSInstanceName">Initial value of AOSInstanceName.</param>
        /// <param name="clusterName">Initial value of ClusterName.</param>
        /// <param name="serverGUID">Initial value of ServerGUID.</param>
        /// <param name="maxConcurrentSessions">Initial value of MaxConcurrentSessions.</param>
        /// <param name="timeAlive">Initial value of TimeAlive.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ServerConfiguration CreateServerConfiguration(string aOSInstanceName, string clusterName, global::System.Guid serverGUID, int maxConcurrentSessions, int timeAlive)
        {
            ServerConfiguration serverConfiguration = new ServerConfiguration();
            serverConfiguration.AOSInstanceName = aOSInstanceName;
            serverConfiguration.ClusterName = clusterName;
            serverConfiguration.ServerGUID = serverGUID;
            serverConfiguration.MaxConcurrentSessions = maxConcurrentSessions;
            serverConfiguration.TimeAlive = timeAlive;
            return serverConfiguration;
        }
        /// <summary>
        /// There are no comments for Property AOSInstanceName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AOSInstanceName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AOSInstanceName is required.")]
        public virtual string AOSInstanceName
        {
            get
            {
                return this._AOSInstanceName;
            }
            set
            {
                this.OnAOSInstanceNameChanging(value);
                this._AOSInstanceName = value;
                this.OnAOSInstanceNameChanged();
                this.OnPropertyChanged("AOSInstanceName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AOSInstanceName;
        partial void OnAOSInstanceNameChanging(string value);
        partial void OnAOSInstanceNameChanged();
        /// <summary>
        /// There are no comments for Property LoadBalancer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoadBalancer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LoadBalancer
        {
            get
            {
                return this._LoadBalancer;
            }
            set
            {
                this.OnLoadBalancerChanging(value);
                this._LoadBalancer = value;
                this.OnLoadBalancerChanged();
                this.OnPropertyChanged("LoadBalancer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LoadBalancer;
        partial void OnLoadBalancerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLoadBalancerChanged();
        /// <summary>
        /// There are no comments for Property ClusterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClusterName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ClusterName is required.")]
        public virtual string ClusterName
        {
            get
            {
                return this._ClusterName;
            }
            set
            {
                this.OnClusterNameChanging(value);
                this._ClusterName = value;
                this.OnClusterNameChanged();
                this.OnPropertyChanged("ClusterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClusterName;
        partial void OnClusterNameChanging(string value);
        partial void OnClusterNameChanged();
        /// <summary>
        /// There are no comments for Property ServerGUID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServerGUID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ServerGUID is required.")]
        public virtual global::System.Guid ServerGUID
        {
            get
            {
                return this._ServerGUID;
            }
            set
            {
                this.OnServerGUIDChanging(value);
                this._ServerGUID = value;
                this.OnServerGUIDChanged();
                this.OnPropertyChanged("ServerGUID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ServerGUID;
        partial void OnServerGUIDChanging(global::System.Guid value);
        partial void OnServerGUIDChanged();
        /// <summary>
        /// There are no comments for Property MaxConcurrentSessions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaxConcurrentSessions")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaxConcurrentSessions is required.")]
        public virtual int MaxConcurrentSessions
        {
            get
            {
                return this._MaxConcurrentSessions;
            }
            set
            {
                this.OnMaxConcurrentSessionsChanging(value);
                this._MaxConcurrentSessions = value;
                this.OnMaxConcurrentSessionsChanged();
                this.OnPropertyChanged("MaxConcurrentSessions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaxConcurrentSessions;
        partial void OnMaxConcurrentSessionsChanging(int value);
        partial void OnMaxConcurrentSessionsChanged();
        /// <summary>
        /// There are no comments for Property TimeAlive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeAlive")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TimeAlive is required.")]
        public virtual int TimeAlive
        {
            get
            {
                return this._TimeAlive;
            }
            set
            {
                this.OnTimeAliveChanging(value);
                this._TimeAlive = value;
                this.OnTimeAliveChanged();
                this.OnPropertyChanged("TimeAlive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TimeAlive;
        partial void OnTimeAliveChanging(int value);
        partial void OnTimeAliveChanged();
        /// <summary>
        /// There are no comments for Property IsRoleIdle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isRoleIdle")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRoleIdle
        {
            get
            {
                return this._IsRoleIdle;
            }
            set
            {
                this.OnIsRoleIdleChanging(value);
                this._IsRoleIdle = value;
                this.OnIsRoleIdleChanged();
                this.OnPropertyChanged("isRoleIdle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRoleIdle;
        partial void OnIsRoleIdleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRoleIdleChanged();
        /// <summary>
        /// There are no comments for Property AzureDeploymentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AzureDeploymentId")]
        public virtual string AzureDeploymentId
        {
            get
            {
                return this._AzureDeploymentId;
            }
            set
            {
                this.OnAzureDeploymentIdChanging(value);
                this._AzureDeploymentId = value;
                this.OnAzureDeploymentIdChanged();
                this.OnPropertyChanged("AzureDeploymentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AzureDeploymentId;
        partial void OnAzureDeploymentIdChanging(string value);
        partial void OnAzureDeploymentIdChanged();
        /// <summary>
        /// There are no comments for Property IsBatchServer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsBatchServer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBatchServer
        {
            get
            {
                return this._IsBatchServer;
            }
            set
            {
                this.OnIsBatchServerChanging(value);
                this._IsBatchServer = value;
                this.OnIsBatchServerChanged();
                this.OnPropertyChanged("IsBatchServer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBatchServer;
        partial void OnIsBatchServerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBatchServerChanged();
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
