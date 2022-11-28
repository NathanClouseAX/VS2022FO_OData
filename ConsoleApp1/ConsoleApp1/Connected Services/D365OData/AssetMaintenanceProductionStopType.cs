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
    /// There are no comments for AssetMaintenanceProductionStopTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceProductionStopTypeSingle")]
    public partial class AssetMaintenanceProductionStopTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceProductionStopType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceProductionStopTypeSingle object.
        /// </summary>
        public AssetMaintenanceProductionStopTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceProductionStopTypeSingle object.
        /// </summary>
        public AssetMaintenanceProductionStopTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceProductionStopTypeSingle object.
        /// </summary>
        public AssetMaintenanceProductionStopTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceProductionStopType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceProductionStopType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProductionStopTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductionStopTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceProductionStopTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceProductionStopType")]
    public partial class AssetMaintenanceProductionStopType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceProductionStopType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="productionStopTypeId">Initial value of ProductionStopTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceProductionStopType CreateAssetMaintenanceProductionStopType(string dataAreaId, string productionStopTypeId)
        {
            AssetMaintenanceProductionStopType assetMaintenanceProductionStopType = new AssetMaintenanceProductionStopType();
            assetMaintenanceProductionStopType.DataAreaId = dataAreaId;
            assetMaintenanceProductionStopType.ProductionStopTypeId = productionStopTypeId;
            return assetMaintenanceProductionStopType;
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
        /// There are no comments for Property ProductionStopTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionStopTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductionStopTypeId is required.")]
        public virtual string ProductionStopTypeId
        {
            get
            {
                return this._ProductionStopTypeId;
            }
            set
            {
                this.OnProductionStopTypeIdChanging(value);
                this._ProductionStopTypeId = value;
                this.OnProductionStopTypeIdChanged();
                this.OnPropertyChanged("ProductionStopTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionStopTypeId;
        partial void OnProductionStopTypeIdChanging(string value);
        partial void OnProductionStopTypeIdChanged();
        /// <summary>
        /// There are no comments for Property KPIInclude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("KPIInclude")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> KPIInclude
        {
            get
            {
                return this._KPIInclude;
            }
            set
            {
                this.OnKPIIncludeChanging(value);
                this._KPIInclude = value;
                this.OnKPIIncludeChanged();
                this.OnPropertyChanged("KPIInclude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _KPIInclude;
        partial void OnKPIIncludeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnKPIIncludeChanged();
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
