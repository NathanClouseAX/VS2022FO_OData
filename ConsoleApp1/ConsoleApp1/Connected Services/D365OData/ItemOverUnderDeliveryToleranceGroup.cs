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
    /// There are no comments for ItemOverUnderDeliveryToleranceGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemOverUnderDeliveryToleranceGroupSingle")]
    public partial class ItemOverUnderDeliveryToleranceGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemOverUnderDeliveryToleranceGroup>
    {
        /// <summary>
        /// Initialize a new ItemOverUnderDeliveryToleranceGroupSingle object.
        /// </summary>
        public ItemOverUnderDeliveryToleranceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemOverUnderDeliveryToleranceGroupSingle object.
        /// </summary>
        public ItemOverUnderDeliveryToleranceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemOverUnderDeliveryToleranceGroupSingle object.
        /// </summary>
        public ItemOverUnderDeliveryToleranceGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemOverUnderDeliveryToleranceGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ItemOverUnderDeliveryToleranceGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("ItemOverUnderDeliveryToleranceGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemOverUnderDeliveryToleranceGroup")]
    public partial class ItemOverUnderDeliveryToleranceGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemOverUnderDeliveryToleranceGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemOverUnderDeliveryToleranceGroup CreateItemOverUnderDeliveryToleranceGroup(string dataAreaId, string groupId)
        {
            ItemOverUnderDeliveryToleranceGroup itemOverUnderDeliveryToleranceGroup = new ItemOverUnderDeliveryToleranceGroup();
            itemOverUnderDeliveryToleranceGroup.DataAreaId = dataAreaId;
            itemOverUnderDeliveryToleranceGroup.GroupId = groupId;
            return itemOverUnderDeliveryToleranceGroup;
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupId is required.")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property GroupDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupDescription")]
        public virtual string GroupDescription
        {
            get
            {
                return this._GroupDescription;
            }
            set
            {
                this.OnGroupDescriptionChanging(value);
                this._GroupDescription = value;
                this.OnGroupDescriptionChanged();
                this.OnPropertyChanged("GroupDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupDescription;
        partial void OnGroupDescriptionChanging(string value);
        partial void OnGroupDescriptionChanged();
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