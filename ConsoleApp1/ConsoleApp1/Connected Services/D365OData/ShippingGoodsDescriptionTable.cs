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
    /// There are no comments for ShippingGoodsDescriptionTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingGoodsDescriptionTableSingle")]
    public partial class ShippingGoodsDescriptionTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingGoodsDescriptionTable>
    {
        /// <summary>
        /// Initialize a new ShippingGoodsDescriptionTableSingle object.
        /// </summary>
        public ShippingGoodsDescriptionTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingGoodsDescriptionTableSingle object.
        /// </summary>
        public ShippingGoodsDescriptionTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingGoodsDescriptionTableSingle object.
        /// </summary>
        public ShippingGoodsDescriptionTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingGoodsDescriptionTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShippingGoodsDescriptionTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GoodsDescription
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GoodsDescription")]
    [global::Microsoft.OData.Client.EntitySet("ShippingGoodsDescriptionTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingGoodsDescriptionTable")]
    public partial class ShippingGoodsDescriptionTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingGoodsDescriptionTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="goodsDescription">Initial value of GoodsDescription.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingGoodsDescriptionTable CreateShippingGoodsDescriptionTable(string dataAreaId, string goodsDescription)
        {
            ShippingGoodsDescriptionTable shippingGoodsDescriptionTable = new ShippingGoodsDescriptionTable();
            shippingGoodsDescriptionTable.DataAreaId = dataAreaId;
            shippingGoodsDescriptionTable.GoodsDescription = goodsDescription;
            return shippingGoodsDescriptionTable;
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
        /// There are no comments for Property GoodsDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoodsDescription")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GoodsDescription is required.")]
        public virtual string GoodsDescription
        {
            get
            {
                return this._GoodsDescription;
            }
            set
            {
                this.OnGoodsDescriptionChanging(value);
                this._GoodsDescription = value;
                this.OnGoodsDescriptionChanged();
                this.OnPropertyChanged("GoodsDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GoodsDescription;
        partial void OnGoodsDescriptionChanging(string value);
        partial void OnGoodsDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DetailedGoodsDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DetailedGoodsDescription")]
        public virtual string DetailedGoodsDescription
        {
            get
            {
                return this._DetailedGoodsDescription;
            }
            set
            {
                this.OnDetailedGoodsDescriptionChanging(value);
                this._DetailedGoodsDescription = value;
                this.OnDetailedGoodsDescriptionChanged();
                this.OnPropertyChanged("DetailedGoodsDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DetailedGoodsDescription;
        partial void OnDetailedGoodsDescriptionChanging(string value);
        partial void OnDetailedGoodsDescriptionChanged();
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