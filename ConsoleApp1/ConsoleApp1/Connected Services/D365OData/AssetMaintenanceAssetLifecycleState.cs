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
    /// There are no comments for AssetMaintenanceAssetLifecycleStateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleStateSingle")]
    public partial class AssetMaintenanceAssetLifecycleStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleState>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetLifecycleStateSingle object.
        /// </summary>
        public AssetMaintenanceAssetLifecycleStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetLifecycleState> query)
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
        /// <summary>
        /// There are no comments for AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAsset")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> AssetMaintenanceAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAsset == null))
                {
                    this._AssetMaintenanceAsset = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset>(GetPath("AssetMaintenanceAsset"));
                }
                return this._AssetMaintenanceAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> _AssetMaintenanceAsset;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState> AssetMaintenanceWorkOrderLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderLifecycleState == null))
                {
                    this._AssetMaintenanceWorkOrderLifecycleState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState>(GetPath("AssetMaintenanceWorkOrderLifecycleState"));
                }
                return this._AssetMaintenanceWorkOrderLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState> _AssetMaintenanceWorkOrderLifecycleState;
        /// <summary>
        /// There are no comments for EntAssetObjectTableEntity_LifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EntAssetObjectTableEntity_LifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2> EntAssetObjectTableEntity_LifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EntAssetObjectTableEntity_LifecycleState == null))
                {
                    this._EntAssetObjectTableEntity_LifecycleState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2>(GetPath("EntAssetObjectTableEntity_LifecycleState"));
                }
                return this._EntAssetObjectTableEntity_LifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2> _EntAssetObjectTableEntity_LifecycleState;
        /// <summary>
        /// There are no comments for EntAssetObjectTableV3Entity_LifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EntAssetObjectTableV3Entity_LifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3> EntAssetObjectTableV3Entity_LifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EntAssetObjectTableV3Entity_LifecycleState == null))
                {
                    this._EntAssetObjectTableV3Entity_LifecycleState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3>(GetPath("EntAssetObjectTableV3Entity_LifecycleState"));
                }
                return this._EntAssetObjectTableV3Entity_LifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3> _EntAssetObjectTableV3Entity_LifecycleState;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceAssetLifecycleState in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetLifecycleStates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetLifecycleState")]
    public partial class AssetMaintenanceAssetLifecycleState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetLifecycleState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        /// <param name="line">Initial value of Line.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetLifecycleState CreateAssetMaintenanceAssetLifecycleState(string dataAreaId, string lifecycleStateId, int line)
        {
            AssetMaintenanceAssetLifecycleState assetMaintenanceAssetLifecycleState = new AssetMaintenanceAssetLifecycleState();
            assetMaintenanceAssetLifecycleState.DataAreaId = dataAreaId;
            assetMaintenanceAssetLifecycleState.LifecycleStateId = lifecycleStateId;
            assetMaintenanceAssetLifecycleState.Line = line;
            return assetMaintenanceAssetLifecycleState;
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
        /// There are no comments for Property MaintenanceAssetActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetActive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MaintenanceAssetActive
        {
            get
            {
                return this._MaintenanceAssetActive;
            }
            set
            {
                this.OnMaintenanceAssetActiveChanging(value);
                this._MaintenanceAssetActive = value;
                this.OnMaintenanceAssetActiveChanged();
                this.OnPropertyChanged("MaintenanceAssetActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MaintenanceAssetActive;
        partial void OnMaintenanceAssetActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMaintenanceAssetActiveChanged();
        /// <summary>
        /// There are no comments for Property DeleteOpenCalendarLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeleteOpenCalendarLines")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DeleteOpenCalendarLines
        {
            get
            {
                return this._DeleteOpenCalendarLines;
            }
            set
            {
                this.OnDeleteOpenCalendarLinesChanging(value);
                this._DeleteOpenCalendarLines = value;
                this.OnDeleteOpenCalendarLinesChanged();
                this.OnPropertyChanged("DeleteOpenCalendarLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DeleteOpenCalendarLines;
        partial void OnDeleteOpenCalendarLinesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDeleteOpenCalendarLinesChanged();
        /// <summary>
        /// There are no comments for Property Line in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Line")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Line is required.")]
        public virtual int Line
        {
            get
            {
                return this._Line;
            }
            set
            {
                this.OnLineChanging(value);
                this._Line = value;
                this.OnLineChanged();
                this.OnPropertyChanged("Line");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Line;
        partial void OnLineChanging(int value);
        partial void OnLineChanged();
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
        /// There are no comments for Property AssetMaintenanceAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAsset")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> AssetMaintenanceAsset
        {
            get
            {
                return this._AssetMaintenanceAsset;
            }
            set
            {
                this.OnAssetMaintenanceAssetChanging(value);
                this._AssetMaintenanceAsset = value;
                this.OnAssetMaintenanceAssetChanged();
                this.OnPropertyChanged("AssetMaintenanceAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> _AssetMaintenanceAsset = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAsset> value);
        partial void OnAssetMaintenanceAssetChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState> AssetMaintenanceWorkOrderLifecycleState
        {
            get
            {
                return this._AssetMaintenanceWorkOrderLifecycleState;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderLifecycleStateChanging(value);
                this._AssetMaintenanceWorkOrderLifecycleState = value;
                this.OnAssetMaintenanceWorkOrderLifecycleStateChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderLifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState> _AssetMaintenanceWorkOrderLifecycleState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkOrderLifecycleStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState> value);
        partial void OnAssetMaintenanceWorkOrderLifecycleStateChanged();
        /// <summary>
        /// There are no comments for Property EntAssetObjectTableEntity_LifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntAssetObjectTableEntity_LifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2> EntAssetObjectTableEntity_LifecycleState
        {
            get
            {
                return this._EntAssetObjectTableEntity_LifecycleState;
            }
            set
            {
                this.OnEntAssetObjectTableEntity_LifecycleStateChanging(value);
                this._EntAssetObjectTableEntity_LifecycleState = value;
                this.OnEntAssetObjectTableEntity_LifecycleStateChanged();
                this.OnPropertyChanged("EntAssetObjectTableEntity_LifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2> _EntAssetObjectTableEntity_LifecycleState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEntAssetObjectTableEntity_LifecycleStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV2> value);
        partial void OnEntAssetObjectTableEntity_LifecycleStateChanged();
        /// <summary>
        /// There are no comments for Property EntAssetObjectTableV3Entity_LifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntAssetObjectTableV3Entity_LifecycleState")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3> EntAssetObjectTableV3Entity_LifecycleState
        {
            get
            {
                return this._EntAssetObjectTableV3Entity_LifecycleState;
            }
            set
            {
                this.OnEntAssetObjectTableV3Entity_LifecycleStateChanging(value);
                this._EntAssetObjectTableV3Entity_LifecycleState = value;
                this.OnEntAssetObjectTableV3Entity_LifecycleStateChanged();
                this.OnPropertyChanged("EntAssetObjectTableV3Entity_LifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3> _EntAssetObjectTableV3Entity_LifecycleState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEntAssetObjectTableV3Entity_LifecycleStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetV3> value);
        partial void OnEntAssetObjectTableV3Entity_LifecycleStateChanged();
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
