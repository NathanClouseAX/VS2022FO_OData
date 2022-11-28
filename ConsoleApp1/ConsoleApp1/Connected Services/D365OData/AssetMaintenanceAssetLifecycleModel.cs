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
    /// There are no comments for AssetMaintenanceAssetLifecycleModelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleModelSingle")]
    public partial class AssetMaintenanceAssetLifecycleModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModel>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleModelState")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> AssetMaintenanceAssetLifecycleModelState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetLifecycleModelState == null))
                {
                    this._AssetMaintenanceAssetLifecycleModelState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState>(GetPath("AssetMaintenanceAssetLifecycleModelState"));
                }
                return this._AssetMaintenanceAssetLifecycleModelState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> _AssetMaintenanceAssetLifecycleModelState;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceAssetLifecycleModel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LifecycleModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetLifecycleModels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleModel")]
    public partial class AssetMaintenanceAssetLifecycleModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetLifecycleModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetLifecycleModel CreateAssetMaintenanceAssetLifecycleModel(string dataAreaId, string lifecycleModelId)
        {
            AssetMaintenanceAssetLifecycleModel assetMaintenanceAssetLifecycleModel = new AssetMaintenanceAssetLifecycleModel();
            assetMaintenanceAssetLifecycleModel.DataAreaId = dataAreaId;
            assetMaintenanceAssetLifecycleModel.LifecycleModelId = lifecycleModelId;
            return assetMaintenanceAssetLifecycleModel;
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
        /// There are no comments for Property LifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifecycleModelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LifecycleModelId is required.")]
        public virtual string LifecycleModelId
        {
            get
            {
                return this._LifecycleModelId;
            }
            set
            {
                this.OnLifecycleModelIdChanging(value);
                this._LifecycleModelId = value;
                this.OnLifecycleModelIdChanged();
                this.OnPropertyChanged("LifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleModelId;
        partial void OnLifecycleModelIdChanging(string value);
        partial void OnLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property InStorageLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InStorageLifecycleStateId")]
        public virtual string InStorageLifecycleStateId
        {
            get
            {
                return this._InStorageLifecycleStateId;
            }
            set
            {
                this.OnInStorageLifecycleStateIdChanging(value);
                this._InStorageLifecycleStateId = value;
                this.OnInStorageLifecycleStateIdChanged();
                this.OnPropertyChanged("InStorageLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InStorageLifecycleStateId;
        partial void OnInStorageLifecycleStateIdChanging(string value);
        partial void OnInStorageLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property ActiveLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveLifecycleStateId")]
        public virtual string ActiveLifecycleStateId
        {
            get
            {
                return this._ActiveLifecycleStateId;
            }
            set
            {
                this.OnActiveLifecycleStateIdChanging(value);
                this._ActiveLifecycleStateId = value;
                this.OnActiveLifecycleStateIdChanged();
                this.OnPropertyChanged("ActiveLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActiveLifecycleStateId;
        partial void OnActiveLifecycleStateIdChanging(string value);
        partial void OnActiveLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property InboundLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InboundLifecycleStateId")]
        public virtual string InboundLifecycleStateId
        {
            get
            {
                return this._InboundLifecycleStateId;
            }
            set
            {
                this.OnInboundLifecycleStateIdChanging(value);
                this._InboundLifecycleStateId = value;
                this.OnInboundLifecycleStateIdChanged();
                this.OnPropertyChanged("InboundLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InboundLifecycleStateId;
        partial void OnInboundLifecycleStateIdChanging(string value);
        partial void OnInboundLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property OnLoanLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnLoanLifecycleStateId")]
        public virtual string OnLoanLifecycleStateId
        {
            get
            {
                return this._OnLoanLifecycleStateId;
            }
            set
            {
                this.OnOnLoanLifecycleStateIdChanging(value);
                this._OnLoanLifecycleStateId = value;
                this.OnOnLoanLifecycleStateIdChanged();
                this.OnPropertyChanged("OnLoanLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OnLoanLifecycleStateId;
        partial void OnOnLoanLifecycleStateIdChanging(string value);
        partial void OnOnLoanLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property ReceivedLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceivedLifecycleStateId")]
        public virtual string ReceivedLifecycleStateId
        {
            get
            {
                return this._ReceivedLifecycleStateId;
            }
            set
            {
                this.OnReceivedLifecycleStateIdChanging(value);
                this._ReceivedLifecycleStateId = value;
                this.OnReceivedLifecycleStateIdChanged();
                this.OnPropertyChanged("ReceivedLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivedLifecycleStateId;
        partial void OnReceivedLifecycleStateIdChanging(string value);
        partial void OnReceivedLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property OutboundLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OutboundLifecycleStateId")]
        public virtual string OutboundLifecycleStateId
        {
            get
            {
                return this._OutboundLifecycleStateId;
            }
            set
            {
                this.OnOutboundLifecycleStateIdChanging(value);
                this._OutboundLifecycleStateId = value;
                this.OnOutboundLifecycleStateIdChanged();
                this.OnPropertyChanged("OutboundLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OutboundLifecycleStateId;
        partial void OnOutboundLifecycleStateIdChanging(string value);
        partial void OnOutboundLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleModelState")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> AssetMaintenanceAssetLifecycleModelState
        {
            get
            {
                return this._AssetMaintenanceAssetLifecycleModelState;
            }
            set
            {
                this.OnAssetMaintenanceAssetLifecycleModelStateChanging(value);
                this._AssetMaintenanceAssetLifecycleModelState = value;
                this.OnAssetMaintenanceAssetLifecycleModelStateChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetLifecycleModelState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> _AssetMaintenanceAssetLifecycleModelState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetLifecycleModelStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetLifecycleModelState> value);
        partial void OnAssetMaintenanceAssetLifecycleModelStateChanged();
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