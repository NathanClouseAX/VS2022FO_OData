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
    /// There are no comments for RetailChannelPriceGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelPriceGroupSingle")]
    public partial class RetailChannelPriceGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelPriceGroup>
    {
        /// <summary>
        /// Initialize a new RetailChannelPriceGroupSingle object.
        /// </summary>
        public RetailChannelPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailChannelPriceGroupSingle object.
        /// </summary>
        public RetailChannelPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailChannelPriceGroupSingle object.
        /// </summary>
        public RetailChannelPriceGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelPriceGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OnlineChannel")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle OnlineChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OnlineChannel == null))
                {
                    this._OnlineChannel = new global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle(this.Context, GetPath("OnlineChannel"));
                }
                return this._OnlineChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle _OnlineChannel;
        /// <summary>
        /// There are no comments for RetailCallCenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCallCenter")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCallCenterSingle RetailCallCenter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCallCenter == null))
                {
                    this._RetailCallCenter = new global::Microsoft.Dynamics.DataEntities.RetailCallCenterSingle(this.Context, GetPath("RetailCallCenter"));
                }
                return this._RetailCallCenter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCallCenterSingle _RetailCallCenter;
        /// <summary>
        /// There are no comments for RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannel")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelSingle RetailChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailChannel == null))
                {
                    this._RetailChannel = new global::Microsoft.Dynamics.DataEntities.RetailChannelSingle(this.Context, GetPath("RetailChannel"));
                }
                return this._RetailChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelSingle _RetailChannel;
        /// <summary>
        /// There are no comments for RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStore")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStoreSingle RetailStore
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStore == null))
                {
                    this._RetailStore = new global::Microsoft.Dynamics.DataEntities.RetailStoreSingle(this.Context, GetPath("RetailStore"));
                }
                return this._RetailStore;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStoreSingle _RetailStore;
    }
    /// <summary>
    /// There are no comments for RetailChannelPriceGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GroupCode
    /// RetailChannelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode", "RetailChannelId")]
    [global::Microsoft.OData.Client.EntitySet("RetailChannelPriceGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelPriceGroup")]
    public partial class RetailChannelPriceGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailChannelPriceGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        /// <param name="retailChannelId">Initial value of RetailChannelId.</param>
        /// <param name="onlineChannel">Initial value of OnlineChannel.</param>
        /// <param name="retailCallCenter">Initial value of RetailCallCenter.</param>
        /// <param name="retailChannel">Initial value of RetailChannel.</param>
        /// <param name="retailStore">Initial value of RetailStore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailChannelPriceGroup CreateRetailChannelPriceGroup(string dataAreaId, 
                    string groupCode, 
                    string retailChannelId, 
                    global::Microsoft.Dynamics.DataEntities.OnlineChannel onlineChannel, 
                    global::Microsoft.Dynamics.DataEntities.RetailCallCenter retailCallCenter, 
                    global::Microsoft.Dynamics.DataEntities.RetailChannel retailChannel, 
                    global::Microsoft.Dynamics.DataEntities.RetailStore retailStore)
        {
            RetailChannelPriceGroup retailChannelPriceGroup = new RetailChannelPriceGroup();
            retailChannelPriceGroup.DataAreaId = dataAreaId;
            retailChannelPriceGroup.GroupCode = groupCode;
            retailChannelPriceGroup.RetailChannelId = retailChannelId;
            if ((onlineChannel == null))
            {
                throw new global::System.ArgumentNullException("onlineChannel");
            }
            retailChannelPriceGroup.OnlineChannel = onlineChannel;
            if ((retailCallCenter == null))
            {
                throw new global::System.ArgumentNullException("retailCallCenter");
            }
            retailChannelPriceGroup.RetailCallCenter = retailCallCenter;
            if ((retailChannel == null))
            {
                throw new global::System.ArgumentNullException("retailChannel");
            }
            retailChannelPriceGroup.RetailChannel = retailChannel;
            if ((retailStore == null))
            {
                throw new global::System.ArgumentNullException("retailStore");
            }
            retailChannelPriceGroup.RetailStore = retailStore;
            return retailChannelPriceGroup;
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
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupCode is required.")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property RetailChannelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailChannelId is required.")]
        public virtual string RetailChannelId
        {
            get
            {
                return this._RetailChannelId;
            }
            set
            {
                this.OnRetailChannelIdChanging(value);
                this._RetailChannelId = value;
                this.OnRetailChannelIdChanged();
                this.OnPropertyChanged("RetailChannelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailChannelId;
        partial void OnRetailChannelIdChanging(string value);
        partial void OnRetailChannelIdChanged();
        /// <summary>
        /// There are no comments for Property PriceGroupDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceGroupDataAreaId")]
        public virtual string PriceGroupDataAreaId
        {
            get
            {
                return this._PriceGroupDataAreaId;
            }
            set
            {
                this.OnPriceGroupDataAreaIdChanging(value);
                this._PriceGroupDataAreaId = value;
                this.OnPriceGroupDataAreaIdChanged();
                this.OnPropertyChanged("PriceGroupDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceGroupDataAreaId;
        partial void OnPriceGroupDataAreaIdChanging(string value);
        partial void OnPriceGroupDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnlineChannel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OnlineChannel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannel OnlineChannel
        {
            get
            {
                return this._OnlineChannel;
            }
            set
            {
                this.OnOnlineChannelChanging(value);
                this._OnlineChannel = value;
                this.OnOnlineChannelChanged();
                this.OnPropertyChanged("OnlineChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnlineChannel _OnlineChannel;
        partial void OnOnlineChannelChanging(global::Microsoft.Dynamics.DataEntities.OnlineChannel value);
        partial void OnOnlineChannelChanged();
        /// <summary>
        /// There are no comments for Property RetailCallCenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCallCenter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailCallCenter is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCallCenter RetailCallCenter
        {
            get
            {
                return this._RetailCallCenter;
            }
            set
            {
                this.OnRetailCallCenterChanging(value);
                this._RetailCallCenter = value;
                this.OnRetailCallCenterChanged();
                this.OnPropertyChanged("RetailCallCenter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCallCenter _RetailCallCenter;
        partial void OnRetailCallCenterChanging(global::Microsoft.Dynamics.DataEntities.RetailCallCenter value);
        partial void OnRetailCallCenterChanged();
        /// <summary>
        /// There are no comments for Property RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailChannel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannel RetailChannel
        {
            get
            {
                return this._RetailChannel;
            }
            set
            {
                this.OnRetailChannelChanging(value);
                this._RetailChannel = value;
                this.OnRetailChannelChanged();
                this.OnPropertyChanged("RetailChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannel _RetailChannel;
        partial void OnRetailChannelChanging(global::Microsoft.Dynamics.DataEntities.RetailChannel value);
        partial void OnRetailChannelChanged();
        /// <summary>
        /// There are no comments for Property RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStore")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailStore is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStore RetailStore
        {
            get
            {
                return this._RetailStore;
            }
            set
            {
                this.OnRetailStoreChanging(value);
                this._RetailStore = value;
                this.OnRetailStoreChanged();
                this.OnPropertyChanged("RetailStore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStore _RetailStore;
        partial void OnRetailStoreChanging(global::Microsoft.Dynamics.DataEntities.RetailStore value);
        partial void OnRetailStoreChanged();
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
