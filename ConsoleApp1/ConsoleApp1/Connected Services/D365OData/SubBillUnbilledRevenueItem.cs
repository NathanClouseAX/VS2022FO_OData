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
    /// There are no comments for SubBillUnbilledRevenueItemSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillUnbilledRevenueItemSingle")]
    public partial class SubBillUnbilledRevenueItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillUnbilledRevenueItem>
    {
        /// <summary>
        /// Initialize a new SubBillUnbilledRevenueItemSingle object.
        /// </summary>
        public SubBillUnbilledRevenueItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillUnbilledRevenueItemSingle object.
        /// </summary>
        public SubBillUnbilledRevenueItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillUnbilledRevenueItemSingle object.
        /// </summary>
        public SubBillUnbilledRevenueItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillUnbilledRevenueItem> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillUnbilledRevenueItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemCode
    /// ItemRelation
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemCode", "ItemRelation")]
    [global::Microsoft.OData.Client.EntitySet("SubBillUnbilledRevenueItems")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillUnbilledRevenueItem")]
    public partial class SubBillUnbilledRevenueItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillUnbilledRevenueItem object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemRelation">Initial value of ItemRelation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillUnbilledRevenueItem CreateSubBillUnbilledRevenueItem(string dataAreaId, string itemRelation)
        {
            SubBillUnbilledRevenueItem subBillUnbilledRevenueItem = new SubBillUnbilledRevenueItem();
            subBillUnbilledRevenueItem.DataAreaId = dataAreaId;
            subBillUnbilledRevenueItem.ItemRelation = itemRelation;
            return subBillUnbilledRevenueItem;
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
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> _ItemCode;
        partial void OnItemCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> value);
        partial void OnItemCodeChanged();
        /// <summary>
        /// There are no comments for Property ItemRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemRelation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemRelation is required.")]
        public virtual string ItemRelation
        {
            get
            {
                return this._ItemRelation;
            }
            set
            {
                this.OnItemRelationChanging(value);
                this._ItemRelation = value;
                this.OnItemRelationChanged();
                this.OnPropertyChanged("ItemRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemRelation;
        partial void OnItemRelationChanging(string value);
        partial void OnItemRelationChanged();
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