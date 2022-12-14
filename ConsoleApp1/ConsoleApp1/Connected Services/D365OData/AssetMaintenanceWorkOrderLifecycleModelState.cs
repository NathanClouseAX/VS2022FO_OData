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
    /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelStateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModelStateSingle")]
    public partial class AssetMaintenanceWorkOrderLifecycleModelStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModelState>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelStateSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModelState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModel")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelSingle AssetMaintenanceWorkOrderLifecycleModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderLifecycleModel == null))
                {
                    this._AssetMaintenanceWorkOrderLifecycleModel = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelSingle(this.Context, GetPath("AssetMaintenanceWorkOrderLifecycleModel"));
                }
                return this._AssetMaintenanceWorkOrderLifecycleModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelSingle _AssetMaintenanceWorkOrderLifecycleModel;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleState")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleStateSingle AssetMaintenanceWorkOrderLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderLifecycleState == null))
                {
                    this._AssetMaintenanceWorkOrderLifecycleState = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleStateSingle(this.Context, GetPath("AssetMaintenanceWorkOrderLifecycleState"));
                }
                return this._AssetMaintenanceWorkOrderLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleStateSingle _AssetMaintenanceWorkOrderLifecycleState;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelState in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LifecycleModelId
    /// LifecycleStateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId", "LifecycleStateId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderLifecycleModelStates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModelState")]
    public partial class AssetMaintenanceWorkOrderLifecycleModelState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderLifecycleModelState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        /// <param name="lifecycleStateId">Initial value of LifecycleStateId.</param>
        /// <param name="line">Initial value of Line.</param>
        /// <param name="assetMaintenanceWorkOrderLifecycleModel">Initial value of AssetMaintenanceWorkOrderLifecycleModel.</param>
        /// <param name="assetMaintenanceWorkOrderLifecycleState">Initial value of AssetMaintenanceWorkOrderLifecycleState.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderLifecycleModelState CreateAssetMaintenanceWorkOrderLifecycleModelState(string dataAreaId, 
                    string lifecycleModelId, 
                    string lifecycleStateId, 
                    int line, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModel assetMaintenanceWorkOrderLifecycleModel, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState assetMaintenanceWorkOrderLifecycleState)
        {
            AssetMaintenanceWorkOrderLifecycleModelState assetMaintenanceWorkOrderLifecycleModelState = new AssetMaintenanceWorkOrderLifecycleModelState();
            assetMaintenanceWorkOrderLifecycleModelState.DataAreaId = dataAreaId;
            assetMaintenanceWorkOrderLifecycleModelState.LifecycleModelId = lifecycleModelId;
            assetMaintenanceWorkOrderLifecycleModelState.LifecycleStateId = lifecycleStateId;
            assetMaintenanceWorkOrderLifecycleModelState.Line = line;
            if ((assetMaintenanceWorkOrderLifecycleModel == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWorkOrderLifecycleModel");
            }
            assetMaintenanceWorkOrderLifecycleModelState.AssetMaintenanceWorkOrderLifecycleModel = assetMaintenanceWorkOrderLifecycleModel;
            if ((assetMaintenanceWorkOrderLifecycleState == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWorkOrderLifecycleState");
            }
            assetMaintenanceWorkOrderLifecycleModelState.AssetMaintenanceWorkOrderLifecycleState = assetMaintenanceWorkOrderLifecycleState;
            return assetMaintenanceWorkOrderLifecycleModelState;
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
        /// There are no comments for Property AssetMaintenanceWorkOrderLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleModel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceWorkOrderLifecycleModel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModel AssetMaintenanceWorkOrderLifecycleModel
        {
            get
            {
                return this._AssetMaintenanceWorkOrderLifecycleModel;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderLifecycleModelChanging(value);
                this._AssetMaintenanceWorkOrderLifecycleModel = value;
                this.OnAssetMaintenanceWorkOrderLifecycleModelChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderLifecycleModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModel _AssetMaintenanceWorkOrderLifecycleModel;
        partial void OnAssetMaintenanceWorkOrderLifecycleModelChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModel value);
        partial void OnAssetMaintenanceWorkOrderLifecycleModelChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLifecycleState")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceWorkOrderLifecycleState is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState AssetMaintenanceWorkOrderLifecycleState
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
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState _AssetMaintenanceWorkOrderLifecycleState;
        partial void OnAssetMaintenanceWorkOrderLifecycleStateChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleState value);
        partial void OnAssetMaintenanceWorkOrderLifecycleStateChanged();
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
