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
    /// There are no comments for AssetMaintenanceAssetTypeFaultTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetTypeFaultTypeSingle")]
    public partial class AssetMaintenanceAssetTypeFaultTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeFaultType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultTypeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultTypeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceAssetTypeFaultTypeSingle object.
        /// </summary>
        public AssetMaintenanceAssetTypeFaultTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceAssetTypeFaultType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceFaultType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultType")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultTypeSingle AssetMaintenanceFaultType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFaultType == null))
                {
                    this._AssetMaintenanceFaultType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultTypeSingle(this.Context, GetPath("AssetMaintenanceFaultType"));
                }
                return this._AssetMaintenanceFaultType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultTypeSingle _AssetMaintenanceFaultType;
        /// <summary>
        /// There are no comments for AssetMaintenanceFaultArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultArea")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultAreaSingle AssetMaintenanceFaultArea
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFaultArea == null))
                {
                    this._AssetMaintenanceFaultArea = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultAreaSingle(this.Context, GetPath("AssetMaintenanceFaultArea"));
                }
                return this._AssetMaintenanceFaultArea;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultAreaSingle _AssetMaintenanceFaultArea;
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
        /// <summary>
        /// There are no comments for AssetMaintenanceFaultSymptom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultSymptom")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle AssetMaintenanceFaultSymptom
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFaultSymptom == null))
                {
                    this._AssetMaintenanceFaultSymptom = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle(this.Context, GetPath("AssetMaintenanceFaultSymptom"));
                }
                return this._AssetMaintenanceFaultSymptom;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptomSingle _AssetMaintenanceFaultSymptom;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceAssetTypeFaultType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// MaintenanceAssetTypeId
    /// FaultSymptomId
    /// FaultAreaId
    /// FaultTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceAssetTypeId", "FaultSymptomId", "FaultAreaId", "FaultTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceAssetTypeFaultTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceAssetTypeFaultType")]
    public partial class AssetMaintenanceAssetTypeFaultType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceAssetTypeFaultType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="maintenanceAssetTypeId">Initial value of MaintenanceAssetTypeId.</param>
        /// <param name="faultSymptomId">Initial value of FaultSymptomId.</param>
        /// <param name="faultAreaId">Initial value of FaultAreaId.</param>
        /// <param name="faultTypeId">Initial value of FaultTypeId.</param>
        /// <param name="assetMaintenanceFaultType">Initial value of AssetMaintenanceFaultType.</param>
        /// <param name="assetMaintenanceFaultArea">Initial value of AssetMaintenanceFaultArea.</param>
        /// <param name="assetMaintenanceAssetType">Initial value of AssetMaintenanceAssetType.</param>
        /// <param name="assetMaintenanceFaultSymptom">Initial value of AssetMaintenanceFaultSymptom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceAssetTypeFaultType CreateAssetMaintenanceAssetTypeFaultType(string dataAreaId, 
                    string maintenanceAssetTypeId, 
                    string faultSymptomId, 
                    string faultAreaId, 
                    string faultTypeId, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultType assetMaintenanceFaultType, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultArea assetMaintenanceFaultArea, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetType assetMaintenanceAssetType, 
                    global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom assetMaintenanceFaultSymptom)
        {
            AssetMaintenanceAssetTypeFaultType assetMaintenanceAssetTypeFaultType = new AssetMaintenanceAssetTypeFaultType();
            assetMaintenanceAssetTypeFaultType.DataAreaId = dataAreaId;
            assetMaintenanceAssetTypeFaultType.MaintenanceAssetTypeId = maintenanceAssetTypeId;
            assetMaintenanceAssetTypeFaultType.FaultSymptomId = faultSymptomId;
            assetMaintenanceAssetTypeFaultType.FaultAreaId = faultAreaId;
            assetMaintenanceAssetTypeFaultType.FaultTypeId = faultTypeId;
            if ((assetMaintenanceFaultType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFaultType");
            }
            assetMaintenanceAssetTypeFaultType.AssetMaintenanceFaultType = assetMaintenanceFaultType;
            if ((assetMaintenanceFaultArea == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFaultArea");
            }
            assetMaintenanceAssetTypeFaultType.AssetMaintenanceFaultArea = assetMaintenanceFaultArea;
            if ((assetMaintenanceAssetType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceAssetType");
            }
            assetMaintenanceAssetTypeFaultType.AssetMaintenanceAssetType = assetMaintenanceAssetType;
            if ((assetMaintenanceFaultSymptom == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFaultSymptom");
            }
            assetMaintenanceAssetTypeFaultType.AssetMaintenanceFaultSymptom = assetMaintenanceFaultSymptom;
            return assetMaintenanceAssetTypeFaultType;
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
        /// There are no comments for Property FaultSymptomId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FaultSymptomId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FaultSymptomId is required.")]
        public virtual string FaultSymptomId
        {
            get
            {
                return this._FaultSymptomId;
            }
            set
            {
                this.OnFaultSymptomIdChanging(value);
                this._FaultSymptomId = value;
                this.OnFaultSymptomIdChanged();
                this.OnPropertyChanged("FaultSymptomId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaultSymptomId;
        partial void OnFaultSymptomIdChanging(string value);
        partial void OnFaultSymptomIdChanged();
        /// <summary>
        /// There are no comments for Property FaultAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FaultAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FaultAreaId is required.")]
        public virtual string FaultAreaId
        {
            get
            {
                return this._FaultAreaId;
            }
            set
            {
                this.OnFaultAreaIdChanging(value);
                this._FaultAreaId = value;
                this.OnFaultAreaIdChanged();
                this.OnPropertyChanged("FaultAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaultAreaId;
        partial void OnFaultAreaIdChanging(string value);
        partial void OnFaultAreaIdChanged();
        /// <summary>
        /// There are no comments for Property FaultTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FaultTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FaultTypeId is required.")]
        public virtual string FaultTypeId
        {
            get
            {
                return this._FaultTypeId;
            }
            set
            {
                this.OnFaultTypeIdChanging(value);
                this._FaultTypeId = value;
                this.OnFaultTypeIdChanged();
                this.OnPropertyChanged("FaultTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaultTypeId;
        partial void OnFaultTypeIdChanging(string value);
        partial void OnFaultTypeIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFaultType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceFaultType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultType AssetMaintenanceFaultType
        {
            get
            {
                return this._AssetMaintenanceFaultType;
            }
            set
            {
                this.OnAssetMaintenanceFaultTypeChanging(value);
                this._AssetMaintenanceFaultType = value;
                this.OnAssetMaintenanceFaultTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceFaultType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultType _AssetMaintenanceFaultType;
        partial void OnAssetMaintenanceFaultTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultType value);
        partial void OnAssetMaintenanceFaultTypeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFaultArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultArea")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceFaultArea is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultArea AssetMaintenanceFaultArea
        {
            get
            {
                return this._AssetMaintenanceFaultArea;
            }
            set
            {
                this.OnAssetMaintenanceFaultAreaChanging(value);
                this._AssetMaintenanceFaultArea = value;
                this.OnAssetMaintenanceFaultAreaChanged();
                this.OnPropertyChanged("AssetMaintenanceFaultArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultArea _AssetMaintenanceFaultArea;
        partial void OnAssetMaintenanceFaultAreaChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultArea value);
        partial void OnAssetMaintenanceFaultAreaChanged();
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
        /// There are no comments for Property AssetMaintenanceFaultSymptom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceFaultSymptom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetMaintenanceFaultSymptom is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom AssetMaintenanceFaultSymptom
        {
            get
            {
                return this._AssetMaintenanceFaultSymptom;
            }
            set
            {
                this.OnAssetMaintenanceFaultSymptomChanging(value);
                this._AssetMaintenanceFaultSymptom = value;
                this.OnAssetMaintenanceFaultSymptomChanged();
                this.OnPropertyChanged("AssetMaintenanceFaultSymptom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom _AssetMaintenanceFaultSymptom;
        partial void OnAssetMaintenanceFaultSymptomChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFaultSymptom value);
        partial void OnAssetMaintenanceFaultSymptomChanged();
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
