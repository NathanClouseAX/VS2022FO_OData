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
    /// There are no comments for ShippingContainerRefrigerationTypeTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerRefrigerationTypeTableSingle")]
    public partial class ShippingContainerRefrigerationTypeTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerRefrigerationTypeTable>
    {
        /// <summary>
        /// Initialize a new ShippingContainerRefrigerationTypeTableSingle object.
        /// </summary>
        public ShippingContainerRefrigerationTypeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingContainerRefrigerationTypeTableSingle object.
        /// </summary>
        public ShippingContainerRefrigerationTypeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingContainerRefrigerationTypeTableSingle object.
        /// </summary>
        public ShippingContainerRefrigerationTypeTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerRefrigerationTypeTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShippingContainerRefrigerationTypeTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RefrigerationTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RefrigerationTypeId")]
    [global::Microsoft.OData.Client.EntitySet("ShippingContainerRefrigerationTypeTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerRefrigerationTypeTable")]
    public partial class ShippingContainerRefrigerationTypeTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingContainerRefrigerationTypeTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="refrigerationTypeId">Initial value of RefrigerationTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingContainerRefrigerationTypeTable CreateShippingContainerRefrigerationTypeTable(string dataAreaId, string refrigerationTypeId)
        {
            ShippingContainerRefrigerationTypeTable shippingContainerRefrigerationTypeTable = new ShippingContainerRefrigerationTypeTable();
            shippingContainerRefrigerationTypeTable.DataAreaId = dataAreaId;
            shippingContainerRefrigerationTypeTable.RefrigerationTypeId = refrigerationTypeId;
            return shippingContainerRefrigerationTypeTable;
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
        /// There are no comments for Property RefrigerationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefrigerationTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefrigerationTypeId is required.")]
        public virtual string RefrigerationTypeId
        {
            get
            {
                return this._RefrigerationTypeId;
            }
            set
            {
                this.OnRefrigerationTypeIdChanging(value);
                this._RefrigerationTypeId = value;
                this.OnRefrigerationTypeIdChanged();
                this.OnPropertyChanged("RefrigerationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefrigerationTypeId;
        partial void OnRefrigerationTypeIdChanging(string value);
        partial void OnRefrigerationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property RefrigerationTypeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefrigerationTypeDescription")]
        public virtual string RefrigerationTypeDescription
        {
            get
            {
                return this._RefrigerationTypeDescription;
            }
            set
            {
                this.OnRefrigerationTypeDescriptionChanging(value);
                this._RefrigerationTypeDescription = value;
                this.OnRefrigerationTypeDescriptionChanged();
                this.OnPropertyChanged("RefrigerationTypeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefrigerationTypeDescription;
        partial void OnRefrigerationTypeDescriptionChanging(string value);
        partial void OnRefrigerationTypeDescriptionChanged();
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