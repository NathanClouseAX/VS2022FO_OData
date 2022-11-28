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
    /// There are no comments for AssetMaintenanceFunctionalLocationWorkerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFunctionalLocationWorkerSingle")]
    public partial class AssetMaintenanceFunctionalLocationWorkerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationWorker>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationWorkerSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationWorkerSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationWorkerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationWorkerSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationWorkerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationWorker> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle AssetMaintenanceWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorker == null))
                {
                    this._AssetMaintenanceWorker = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle(this.Context, GetPath("AssetMaintenanceWorker"));
                }
                return this._AssetMaintenanceWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkerSingle _AssetMaintenanceWorker;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFunctionalLocation")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle AssetMaintenanceFunctionalLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocation == null))
                {
                    this._AssetMaintenanceFunctionalLocation = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle(this.Context, GetPath("AssetMaintenanceFunctionalLocation"));
                }
                return this._AssetMaintenanceFunctionalLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationSingle _AssetMaintenanceFunctionalLocation;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceFunctionalLocationWorker in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FunctionalLocationId
    /// WorkerPersonnelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FunctionalLocationId", "WorkerPersonnelNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFunctionalLocationWorkers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFunctionalLocationWorker")]
    public partial class AssetMaintenanceFunctionalLocationWorker : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFunctionalLocationWorker object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="functionalLocationId">Initial value of FunctionalLocationId.</param>
        /// <param name="workerPersonnelNumber">Initial value of WorkerPersonnelNumber.</param>
        /// <param name="assetMaintenanceWorker">Initial value of AssetMaintenanceWorker.</param>
        /// <param name="assetMaintenanceFunctionalLocation">Initial value of AssetMaintenanceFunctionalLocation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFunctionalLocationWorker CreateAssetMaintenanceFunctionalLocationWorker(string dataAreaId, string functionalLocationId, string workerPersonnelNumber, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker assetMaintenanceWorker, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation assetMaintenanceFunctionalLocation)
        {
            AssetMaintenanceFunctionalLocationWorker assetMaintenanceFunctionalLocationWorker = new AssetMaintenanceFunctionalLocationWorker();
            assetMaintenanceFunctionalLocationWorker.DataAreaId = dataAreaId;
            assetMaintenanceFunctionalLocationWorker.FunctionalLocationId = functionalLocationId;
            assetMaintenanceFunctionalLocationWorker.WorkerPersonnelNumber = workerPersonnelNumber;
            if ((assetMaintenanceWorker == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceWorker");
            }
            assetMaintenanceFunctionalLocationWorker.AssetMaintenanceWorker = assetMaintenanceWorker;
            if ((assetMaintenanceFunctionalLocation == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFunctionalLocation");
            }
            assetMaintenanceFunctionalLocationWorker.AssetMaintenanceFunctionalLocation = assetMaintenanceFunctionalLocation;
            return assetMaintenanceFunctionalLocationWorker;
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
        /// There are no comments for Property FunctionalLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FunctionalLocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FunctionalLocationId is required.")]
        public virtual string FunctionalLocationId
        {
            get
            {
                return this._FunctionalLocationId;
            }
            set
            {
                this.OnFunctionalLocationIdChanging(value);
                this._FunctionalLocationId = value;
                this.OnFunctionalLocationIdChanged();
                this.OnPropertyChanged("FunctionalLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationId;
        partial void OnFunctionalLocationIdChanging(string value);
        partial void OnFunctionalLocationIdChanged();
        /// <summary>
        /// There are no comments for Property WorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerPersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerPersonnelNumber is required.")]
        public virtual string WorkerPersonnelNumber
        {
            get
            {
                return this._WorkerPersonnelNumber;
            }
            set
            {
                this.OnWorkerPersonnelNumberChanging(value);
                this._WorkerPersonnelNumber = value;
                this.OnWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("WorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerPersonnelNumber;
        partial void OnWorkerPersonnelNumberChanging(string value);
        partial void OnWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property PrimaryFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryFunctionalLocation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrimaryFunctionalLocation
        {
            get
            {
                return this._PrimaryFunctionalLocation;
            }
            set
            {
                this.OnPrimaryFunctionalLocationChanging(value);
                this._PrimaryFunctionalLocation = value;
                this.OnPrimaryFunctionalLocationChanged();
                this.OnPropertyChanged("PrimaryFunctionalLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrimaryFunctionalLocation;
        partial void OnPrimaryFunctionalLocationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrimaryFunctionalLocationChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceWorker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker AssetMaintenanceWorker
        {
            get
            {
                return this._AssetMaintenanceWorker;
            }
            set
            {
                this.OnAssetMaintenanceWorkerChanging(value);
                this._AssetMaintenanceWorker = value;
                this.OnAssetMaintenanceWorkerChanged();
                this.OnPropertyChanged("AssetMaintenanceWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker _AssetMaintenanceWorker;
        partial void OnAssetMaintenanceWorkerChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorker value);
        partial void OnAssetMaintenanceWorkerChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFunctionalLocation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceFunctionalLocation is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation AssetMaintenanceFunctionalLocation
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocation;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationChanging(value);
                this._AssetMaintenanceFunctionalLocation = value;
                this.OnAssetMaintenanceFunctionalLocationChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation _AssetMaintenanceFunctionalLocation;
        partial void OnAssetMaintenanceFunctionalLocationChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocation value);
        partial void OnAssetMaintenanceFunctionalLocationChanged();
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
