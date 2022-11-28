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
    /// There are no comments for AssetMaintenanceWorkOrderPoolSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderPoolSingle")]
    public partial class AssetMaintenanceWorkOrderPoolSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderPool>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderPoolSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderPoolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderPoolSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderPoolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderPoolSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderPoolSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderPool> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorkOrderPool in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PoolId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PoolId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderPools")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderPool")]
    public partial class AssetMaintenanceWorkOrderPool : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderPool object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="poolId">Initial value of PoolId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderPool CreateAssetMaintenanceWorkOrderPool(string dataAreaId, string poolId)
        {
            AssetMaintenanceWorkOrderPool assetMaintenanceWorkOrderPool = new AssetMaintenanceWorkOrderPool();
            assetMaintenanceWorkOrderPool.DataAreaId = dataAreaId;
            assetMaintenanceWorkOrderPool.PoolId = poolId;
            return assetMaintenanceWorkOrderPool;
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
        /// There are no comments for Property PoolId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PoolId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PoolId is required.")]
        public virtual string PoolId
        {
            get
            {
                return this._PoolId;
            }
            set
            {
                this.OnPoolIdChanging(value);
                this._PoolId = value;
                this.OnPoolIdChanged();
                this.OnPropertyChanged("PoolId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PoolId;
        partial void OnPoolIdChanging(string value);
        partial void OnPoolIdChanged();
        /// <summary>
        /// There are no comments for Property RemoveAtWorkOrderLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RemoveAtWorkOrderLifecycleStateId")]
        public virtual string RemoveAtWorkOrderLifecycleStateId
        {
            get
            {
                return this._RemoveAtWorkOrderLifecycleStateId;
            }
            set
            {
                this.OnRemoveAtWorkOrderLifecycleStateIdChanging(value);
                this._RemoveAtWorkOrderLifecycleStateId = value;
                this.OnRemoveAtWorkOrderLifecycleStateIdChanged();
                this.OnPropertyChanged("RemoveAtWorkOrderLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RemoveAtWorkOrderLifecycleStateId;
        partial void OnRemoveAtWorkOrderLifecycleStateIdChanging(string value);
        partial void OnRemoveAtWorkOrderLifecycleStateIdChanged();
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
        /// There are no comments for Property Active in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Active")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Active;
        partial void OnActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property DeleteWorkOrderRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeleteWorkOrderRelation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DeleteWorkOrderRelation
        {
            get
            {
                return this._DeleteWorkOrderRelation;
            }
            set
            {
                this.OnDeleteWorkOrderRelationChanging(value);
                this._DeleteWorkOrderRelation = value;
                this.OnDeleteWorkOrderRelationChanged();
                this.OnPropertyChanged("DeleteWorkOrderRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DeleteWorkOrderRelation;
        partial void OnDeleteWorkOrderRelationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDeleteWorkOrderRelationChanged();
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
