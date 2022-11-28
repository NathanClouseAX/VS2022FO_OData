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
    /// There are no comments for InventorySiteGateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventorySiteGateSingle")]
    public partial class InventorySiteGateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventorySiteGate>
    {
        /// <summary>
        /// Initialize a new InventorySiteGateSingle object.
        /// </summary>
        public InventorySiteGateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventorySiteGateSingle object.
        /// </summary>
        public InventorySiteGateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventorySiteGateSingle object.
        /// </summary>
        public InventorySiteGateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventorySiteGate> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for InventorySiteGate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GateType
    /// GateId
    /// SiteId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GateType", "GateId", "SiteId")]
    [global::Microsoft.OData.Client.EntitySet("InventorySiteGates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventorySiteGate")]
    public partial class InventorySiteGate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventorySiteGate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="gateId">Initial value of GateId.</param>
        /// <param name="siteId">Initial value of SiteId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventorySiteGate CreateInventorySiteGate(string dataAreaId, string gateId, string siteId)
        {
            InventorySiteGate inventorySiteGate = new InventorySiteGate();
            inventorySiteGate.DataAreaId = dataAreaId;
            inventorySiteGate.GateId = gateId;
            inventorySiteGate.SiteId = siteId;
            return inventorySiteGate;
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
        /// There are no comments for Property GateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GateType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> GateType
        {
            get
            {
                return this._GateType;
            }
            set
            {
                this.OnGateTypeChanging(value);
                this._GateType = value;
                this.OnGateTypeChanged();
                this.OnPropertyChanged("GateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> _GateType;
        partial void OnGateTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> value);
        partial void OnGateTypeChanged();
        /// <summary>
        /// There are no comments for Property GateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GateId is required.")]
        public virtual string GateId
        {
            get
            {
                return this._GateId;
            }
            set
            {
                this.OnGateIdChanging(value);
                this._GateId = value;
                this.OnGateIdChanged();
                this.OnPropertyChanged("GateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GateId;
        partial void OnGateIdChanging(string value);
        partial void OnGateIdChanged();
        /// <summary>
        /// There are no comments for Property SiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SiteId is required.")]
        public virtual string SiteId
        {
            get
            {
                return this._SiteId;
            }
            set
            {
                this.OnSiteIdChanging(value);
                this._SiteId = value;
                this.OnSiteIdChanged();
                this.OnPropertyChanged("SiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SiteId;
        partial void OnSiteIdChanging(string value);
        partial void OnSiteIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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