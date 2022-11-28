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
    /// There are no comments for VoyageCommodityCodeTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoyageCommodityCodeTableSingle")]
    public partial class VoyageCommodityCodeTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VoyageCommodityCodeTable>
    {
        /// <summary>
        /// Initialize a new VoyageCommodityCodeTableSingle object.
        /// </summary>
        public VoyageCommodityCodeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VoyageCommodityCodeTableSingle object.
        /// </summary>
        public VoyageCommodityCodeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VoyageCommodityCodeTableSingle object.
        /// </summary>
        public VoyageCommodityCodeTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VoyageCommodityCodeTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VoyageCommodityCodeTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CommodityCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CommodityCode")]
    [global::Microsoft.OData.Client.EntitySet("VoyageCommodityCodeTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoyageCommodityCodeTable")]
    public partial class VoyageCommodityCodeTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VoyageCommodityCodeTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="commodityCode">Initial value of CommodityCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VoyageCommodityCodeTable CreateVoyageCommodityCodeTable(string dataAreaId, string commodityCode)
        {
            VoyageCommodityCodeTable voyageCommodityCodeTable = new VoyageCommodityCodeTable();
            voyageCommodityCodeTable.DataAreaId = dataAreaId;
            voyageCommodityCodeTable.CommodityCode = commodityCode;
            return voyageCommodityCodeTable;
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
        /// There are no comments for Property CommodityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommodityCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CommodityCode is required.")]
        public virtual string CommodityCode
        {
            get
            {
                return this._CommodityCode;
            }
            set
            {
                this.OnCommodityCodeChanging(value);
                this._CommodityCode = value;
                this.OnCommodityCodeChanged();
                this.OnPropertyChanged("CommodityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CommodityCode;
        partial void OnCommodityCodeChanging(string value);
        partial void OnCommodityCodeChanged();
        /// <summary>
        /// There are no comments for Property CommodityDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommodityDescription")]
        public virtual string CommodityDescription
        {
            get
            {
                return this._CommodityDescription;
            }
            set
            {
                this.OnCommodityDescriptionChanging(value);
                this._CommodityDescription = value;
                this.OnCommodityDescriptionChanged();
                this.OnPropertyChanged("CommodityDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CommodityDescription;
        partial void OnCommodityDescriptionChanging(string value);
        partial void OnCommodityDescriptionChanged();
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
