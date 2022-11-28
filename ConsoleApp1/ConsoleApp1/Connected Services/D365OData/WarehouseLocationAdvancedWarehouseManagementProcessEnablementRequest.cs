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
    /// There are no comments for WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle")]
    public partial class WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest>
    {
        /// <summary>
        /// Initialize a new WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// WarehouseId
    /// WarehouseLocationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarehouseId", "WarehouseLocationId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequests")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest")]
    public partial class WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="warehouseId">Initial value of WarehouseId.</param>
        /// <param name="warehouseLocationId">Initial value of WarehouseLocationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest CreateWarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest(string dataAreaId, string warehouseId, string warehouseLocationId)
        {
            WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest warehouseLocationAdvancedWarehouseManagementProcessEnablementRequest = new WarehouseLocationAdvancedWarehouseManagementProcessEnablementRequest();
            warehouseLocationAdvancedWarehouseManagementProcessEnablementRequest.DataAreaId = dataAreaId;
            warehouseLocationAdvancedWarehouseManagementProcessEnablementRequest.WarehouseId = warehouseId;
            warehouseLocationAdvancedWarehouseManagementProcessEnablementRequest.WarehouseLocationId = warehouseLocationId;
            return warehouseLocationAdvancedWarehouseManagementProcessEnablementRequest;
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
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WarehouseId is required.")]
        public virtual string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WarehouseLocationId is required.")]
        public virtual string WarehouseLocationId
        {
            get
            {
                return this._WarehouseLocationId;
            }
            set
            {
                this.OnWarehouseLocationIdChanging(value);
                this._WarehouseLocationId = value;
                this.OnWarehouseLocationIdChanged();
                this.OnPropertyChanged("WarehouseLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseLocationId;
        partial void OnWarehouseLocationIdChanging(string value);
        partial void OnWarehouseLocationIdChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocationProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocationProfileId")]
        public virtual string WarehouseLocationProfileId
        {
            get
            {
                return this._WarehouseLocationProfileId;
            }
            set
            {
                this.OnWarehouseLocationProfileIdChanging(value);
                this._WarehouseLocationProfileId = value;
                this.OnWarehouseLocationProfileIdChanged();
                this.OnPropertyChanged("WarehouseLocationProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseLocationProfileId;
        partial void OnWarehouseLocationProfileIdChanging(string value);
        partial void OnWarehouseLocationProfileIdChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSLocationType> WarehouseLocationType
        {
            get
            {
                return this._WarehouseLocationType;
            }
            set
            {
                this.OnWarehouseLocationTypeChanging(value);
                this._WarehouseLocationType = value;
                this.OnWarehouseLocationTypeChanged();
                this.OnPropertyChanged("WarehouseLocationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSLocationType> _WarehouseLocationType;
        partial void OnWarehouseLocationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WMSLocationType> value);
        partial void OnWarehouseLocationTypeChanged();
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