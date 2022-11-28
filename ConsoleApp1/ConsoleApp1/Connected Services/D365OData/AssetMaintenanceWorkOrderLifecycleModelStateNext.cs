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
    /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelStateNextSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModelStateNextSingle")]
    public partial class AssetMaintenanceWorkOrderLifecycleModelStateNextSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModelStateNext>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateNextSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateNextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateNextSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateNextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateNextSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateNextSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModelStateNext> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelStateNext in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LifecycleModelId
    /// LifecycleStateId
    /// NextLifecycleModelId
    /// NextLifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId", "LifecycleStateId", "NextLifecycleModelId", "NextLifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderLifecycleModelStateNexts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModelStateNext")]
    public partial class AssetMaintenanceWorkOrderLifecycleModelStateNext : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderLifecycleModelStateNext object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        /// <param name="nextLifecycleModelId">Initial value of NextLifecycleModelId.</param>
        /// <param name="nextLifecycleStateId">Initial value of NextLifecycleStateId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderLifecycleModelStateNext CreateAssetMaintenanceWorkOrderLifecycleModelStateNext(string dataAreaId, string lifecycleModelId, string lifecycleStateId, string nextLifecycleModelId, string nextLifecycleStateId)
        {
            AssetMaintenanceWorkOrderLifecycleModelStateNext assetMaintenanceWorkOrderLifecycleModelStateNext = new AssetMaintenanceWorkOrderLifecycleModelStateNext();
            assetMaintenanceWorkOrderLifecycleModelStateNext.DataAreaId = dataAreaId;
            assetMaintenanceWorkOrderLifecycleModelStateNext.LifecycleModelId = lifecycleModelId;
            assetMaintenanceWorkOrderLifecycleModelStateNext.LifecycleStateId = lifecycleStateId;
            assetMaintenanceWorkOrderLifecycleModelStateNext.NextLifecycleModelId = nextLifecycleModelId;
            assetMaintenanceWorkOrderLifecycleModelStateNext.NextLifecycleStateId = nextLifecycleStateId;
            return assetMaintenanceWorkOrderLifecycleModelStateNext;
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
        /// There are no comments for Property LifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifecycleStateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LifecycleStateId is required.")]
        public virtual string LifecycleStateId
        {
            get
            {
                return this._LifecycleStateId;
            }
            set
            {
                this.OnLifecycleStateIdChanging(value);
                this._LifecycleStateId = value;
                this.OnLifecycleStateIdChanged();
                this.OnPropertyChanged("LifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleStateId;
        partial void OnLifecycleStateIdChanging(string value);
        partial void OnLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property NextLifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextLifecycleModelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NextLifecycleModelId is required.")]
        public virtual string NextLifecycleModelId
        {
            get
            {
                return this._NextLifecycleModelId;
            }
            set
            {
                this.OnNextLifecycleModelIdChanging(value);
                this._NextLifecycleModelId = value;
                this.OnNextLifecycleModelIdChanged();
                this.OnPropertyChanged("NextLifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NextLifecycleModelId;
        partial void OnNextLifecycleModelIdChanging(string value);
        partial void OnNextLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property NextLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextLifecycleStateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NextLifecycleStateId is required.")]
        public virtual string NextLifecycleStateId
        {
            get
            {
                return this._NextLifecycleStateId;
            }
            set
            {
                this.OnNextLifecycleStateIdChanging(value);
                this._NextLifecycleStateId = value;
                this.OnNextLifecycleStateIdChanged();
                this.OnPropertyChanged("NextLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NextLifecycleStateId;
        partial void OnNextLifecycleStateIdChanging(string value);
        partial void OnNextLifecycleStateIdChanged();
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
