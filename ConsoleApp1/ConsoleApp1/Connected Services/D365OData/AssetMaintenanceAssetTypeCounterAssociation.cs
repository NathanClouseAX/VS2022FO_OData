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
    /// There are no comments for AssetMaintenanceAssetTypeCounterAssociationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetTypeCounterAssociationSingle")]
    public partial class AssetMaintenanceAssetTypeCounterAssociationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeCounterAssociation>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeCounterAssociationSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeCounterAssociationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeCounterAssociationSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeCounterAssociationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeCounterAssociationSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeCounterAssociationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeCounterAssociation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetCounter")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle AssetMaintenanceAssetCounter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCounter == null))
                {
                    this._AssetMaintenanceAssetCounter = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle(this.Context, GetPath("AssetMaintenanceAssetCounter"));
                }
                return this._AssetMaintenanceAssetCounter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle _AssetMaintenanceAssetCounter;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetType")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle AssetMaintenanceAssetType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetType == null))
                {
                    this._AssetMaintenanceAssetType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle(this.Context, GetPath("AssetMaintenanceAssetType"));
                }
                return this._AssetMaintenanceAssetType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeSingle _AssetMaintenanceAssetType;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceAssetTypeCounterAssociation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// MaintenanceAssetTypeId
    /// MaintenanceAssetCounterId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetTypeId", "MaintenanceAssetCounterId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetTypeCounterAssociations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetTypeCounterAssociation")]
    public partial class AssetMaintenanceAssetTypeCounterAssociation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetTypeCounterAssociation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="maintenanceAssetCounterId">Initial value of MaintenanceAssetCounterId.</param>
        /// <param name="assetMaintenanceAssetCounter">Initial value of AssetMaintenanceAssetCounter.</param>
        /// <param name="assetMaintenanceAssetType">Initial value of AssetMaintenanceAssetType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetTypeCounterAssociation CreateAssetMaintenanceAssetTypeCounterAssociation(string dataAreaId, string maintenanceAssetTypeId, string maintenanceAssetCounterId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter assetMaintenanceAssetCounter, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType assetMaintenanceAssetType)
        {
            AssetMaintenanceAssetTypeCounterAssociation assetMaintenanceAssetTypeCounterAssociation = new AssetMaintenanceAssetTypeCounterAssociation();
            assetMaintenanceAssetTypeCounterAssociation.DataAreaId = dataAreaId;
            assetMaintenanceAssetTypeCounterAssociation.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceAssetTypeCounterAssociation.MaintenanceAssetCounterId = maintenanceAssetCounterId;
            if ((assetMaintenanceAssetCounter == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetCounter");
            }
            assetMaintenanceAssetTypeCounterAssociation.AssetMaintenanceAssetCounter = assetMaintenanceAssetCounter;
            if ((assetMaintenanceAssetType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetType");
            }
            assetMaintenanceAssetTypeCounterAssociation.AssetMaintenanceAssetType = assetMaintenanceAssetType;
            return assetMaintenanceAssetTypeCounterAssociation;
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
        /// There are no comments for Property MaintenanceAssetTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetTypeId is required.")]
        public virtual string MaintenanceAssetTypeId
        {
            get
            {
                return this._MaintenanceAssetTypeId;
            }
            set
            {
                this.OnMaintenanceAssetTypeIdChanging(value);
                this._MaintenanceAssetTypeId = value;
                this.OnMaintenanceAssetTypeIdChanged();
                this.OnPropertyChanged("MaintenanceAssetTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetTypeId;
        partial void OnMaintenanceAssetTypeIdChanging(string value);
        partial void OnMaintenanceAssetTypeIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetCounterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetCounterId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetCounterId is required.")]
        public virtual string MaintenanceAssetCounterId
        {
            get
            {
                return this._MaintenanceAssetCounterId;
            }
            set
            {
                this.OnMaintenanceAssetCounterIdChanging(value);
                this._MaintenanceAssetCounterId = value;
                this.OnMaintenanceAssetCounterIdChanged();
                this.OnPropertyChanged("MaintenanceAssetCounterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetCounterId;
        partial void OnMaintenanceAssetCounterIdChanging(string value);
        partial void OnMaintenanceAssetCounterIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetCounter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceAssetCounter is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter AssetMaintenanceAssetCounter
        {
            get
            {
                return this._AssetMaintenanceAssetCounter;
            }
            set
            {
                this.OnAssetMaintenanceAssetCounterChanging(value);
                this._AssetMaintenanceAssetCounter = value;
                this.OnAssetMaintenanceAssetCounterChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter _AssetMaintenanceAssetCounter;
        partial void OnAssetMaintenanceAssetCounterChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter value);
        partial void OnAssetMaintenanceAssetCounterChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceAssetType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType AssetMaintenanceAssetType
        {
            get
            {
                return this._AssetMaintenanceAssetType;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeChanging(value);
                this._AssetMaintenanceAssetType = value;
                this.OnAssetMaintenanceAssetTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType _AssetMaintenanceAssetType;
        partial void OnAssetMaintenanceAssetTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType value);
        partial void OnAssetMaintenanceAssetTypeChanged();
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
