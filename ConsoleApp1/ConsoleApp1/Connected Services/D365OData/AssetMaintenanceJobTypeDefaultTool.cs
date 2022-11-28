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
    /// There are no comments for AssetMaintenanceJobTypeDefaultToolSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceJobTypeDefaultToolSingle")]
    public partial class AssetMaintenanceJobTypeDefaultToolSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeDefaultTool>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeDefaultToolSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeDefaultToolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeDefaultToolSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeDefaultToolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceJobTypeDefaultToolSingle object.
        /// </summary>
        public AssetMaintenanceJobTypeDefaultToolSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceJobTypeDefaultTool> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceJobTypeDefaultTool in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FunctionalLocationId
    /// MaintenanceAssetTypeId
    /// ProductId
    /// ModelProductId
    /// ModelId
    /// MaintenanceAssetId
    /// JobTypeId
    /// JobVariantId
    /// JobTradeId
    /// Resource
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FunctionalLocationId", "MaintenanceAssetTypeId", "ProductId", "ModelProductId", "ModelId", "MaintenanceAssetId", "JobTypeId", "JobVariantId", "JobTradeId", "Resource")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceJobTypeDefaultTools")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceJobTypeDefaultTool")]
    public partial class AssetMaintenanceJobTypeDefaultTool : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceJobTypeDefaultTool object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="functionalLocationId">Initial value of FunctionalLocationId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="modelProductId">Initial value of ModelProductId.</param>
        /// <param name="modelId">Initial value of ModelId.</param>
        /// <param name="maintenanceAssetId">Initial value of MaintenanceAssetId.</param>
        /// <param name="jobTypeId">Initial value of JobTypeId.</param>
        /// <param name="jobVariantId">Initial value of JobVariantId.</param>
        /// <param name="jobTradeId">Initial value of JobTradeId.</param>
        /// <param name="resource">Initial value of Resource.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceJobTypeDefaultTool CreateAssetMaintenanceJobTypeDefaultTool(string dataAreaId, 
                    string functionalLocationId, 
                    string maintenanceAssetTypeId, 
                    string productId, 
                    string modelProductId, 
                    string modelId, 
                    string maintenanceAssetId, 
                    string jobTypeId, 
                    string jobVariantId, 
                    string jobTradeId, 
                    string resource)
        {
            AssetMaintenanceJobTypeDefaultTool assetMaintenanceJobTypeDefaultTool = new AssetMaintenanceJobTypeDefaultTool();
            assetMaintenanceJobTypeDefaultTool.DataAreaId = dataAreaId;
            assetMaintenanceJobTypeDefaultTool.FunctionalLocationId = functionalLocationId;
            assetMaintenanceJobTypeDefaultTool.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceJobTypeDefaultTool.ProductId = productId;
            assetMaintenanceJobTypeDefaultTool.ModelProductId = modelProductId;
            assetMaintenanceJobTypeDefaultTool.ModelId = modelId;
            assetMaintenanceJobTypeDefaultTool.MaintenanceAssetId = maintenanceAssetId;
            assetMaintenanceJobTypeDefaultTool.JobTypeId = jobTypeId;
            assetMaintenanceJobTypeDefaultTool.JobVariantId = jobVariantId;
            assetMaintenanceJobTypeDefaultTool.JobTradeId = jobTradeId;
            assetMaintenanceJobTypeDefaultTool.Resource = resource;
            return assetMaintenanceJobTypeDefaultTool;
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
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductId is required.")]
        public virtual string ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductId;
        partial void OnProductIdChanging(string value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property ModelProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelProductId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelProductId is required.")]
        public virtual string ModelProductId
        {
            get
            {
                return this._ModelProductId;
            }
            set
            {
                this.OnModelProductIdChanging(value);
                this._ModelProductId = value;
                this.OnModelProductIdChanged();
                this.OnPropertyChanged("ModelProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelProductId;
        partial void OnModelProductIdChanging(string value);
        partial void OnModelProductIdChanged();
        /// <summary>
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelId is required.")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetId is required.")]
        public virtual string MaintenanceAssetId
        {
            get
            {
                return this._MaintenanceAssetId;
            }
            set
            {
                this.OnMaintenanceAssetIdChanging(value);
                this._MaintenanceAssetId = value;
                this.OnMaintenanceAssetIdChanged();
                this.OnPropertyChanged("MaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetId;
        partial void OnMaintenanceAssetIdChanging(string value);
        partial void OnMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTypeId is required.")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property JobVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobVariantId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobVariantId is required.")]
        public virtual string JobVariantId
        {
            get
            {
                return this._JobVariantId;
            }
            set
            {
                this.OnJobVariantIdChanging(value);
                this._JobVariantId = value;
                this.OnJobVariantIdChanged();
                this.OnPropertyChanged("JobVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobVariantId;
        partial void OnJobVariantIdChanging(string value);
        partial void OnJobVariantIdChanged();
        /// <summary>
        /// There are no comments for Property JobTradeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTradeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobTradeId is required.")]
        public virtual string JobTradeId
        {
            get
            {
                return this._JobTradeId;
            }
            set
            {
                this.OnJobTradeIdChanging(value);
                this._JobTradeId = value;
                this.OnJobTradeIdChanged();
                this.OnPropertyChanged("JobTradeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTradeId;
        partial void OnJobTradeIdChanging(string value);
        partial void OnJobTradeIdChanged();
        /// <summary>
        /// There are no comments for Property Resource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Resource")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Resource is required.")]
        public virtual string Resource
        {
            get
            {
                return this._Resource;
            }
            set
            {
                this.OnResourceChanging(value);
                this._Resource = value;
                this.OnResourceChanged();
                this.OnPropertyChanged("Resource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Resource;
        partial void OnResourceChanging(string value);
        partial void OnResourceChanged();
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
