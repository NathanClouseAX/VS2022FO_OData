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
    /// There are no comments for SiteGateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SiteGateSingle")]
    public partial class SiteGateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SiteGate>
    {
        /// <summary>
        /// Initialize a new SiteGateSingle object.
        /// </summary>
        public SiteGateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SiteGateSingle object.
        /// </summary>
        public SiteGateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SiteGateSingle object.
        /// </summary>
        public SiteGateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SiteGate> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SiteGate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Type
    /// GateId
    /// SiteId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Type", "GateId", "SiteId")]
    [global::Microsoft.OData.Client.EntitySet("SiteGate")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SiteGate")]
    public partial class SiteGate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SiteGate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="gateId">Initial value of GateId.</param>
        /// <param name="siteId">Initial value of SiteId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SiteGate CreateSiteGate(string dataAreaId, string gateId, string siteId)
        {
            SiteGate siteGate = new SiteGate();
            siteGate.DataAreaId = dataAreaId;
            siteGate.GateId = gateId;
            siteGate.SiteId = siteId;
            return siteGate;
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateType_IN> value);
        partial void OnTypeChanged();
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