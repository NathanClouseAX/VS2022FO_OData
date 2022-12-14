//------------------------------------------------------------------------------
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
    /// There are no comments for MessageItemsLogSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageItemsLogSingle")]
    public partial class MessageItemsLogSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MessageItemsLog>
    {
        /// <summary>
        /// Initialize a new MessageItemsLogSingle object.
        /// </summary>
        public MessageItemsLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MessageItemsLogSingle object.
        /// </summary>
        public MessageItemsLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MessageItemsLogSingle object.
        /// </summary>
        public MessageItemsLogSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MessageItemsLog> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MessageItemsLog in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemId
    /// ItemTypeId
    /// MessageId
    /// ActionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemId", "ItemTypeId", "MessageId", "ActionId")]
    [global::Microsoft.OData.Client.EntitySet("MessageItemsLogs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageItemsLog")]
    public partial class MessageItemsLog : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MessageItemsLog object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="itemTypeId">Initial value of ItemTypeId.</param>
        /// <param name="messageId">Initial value of MessageId.</param>
        /// <param name="actionId">Initial value of ActionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MessageItemsLog CreateMessageItemsLog(string dataAreaId, string itemId, string itemTypeId, string messageId, string actionId)
        {
            MessageItemsLog messageItemsLog = new MessageItemsLog();
            messageItemsLog.DataAreaId = dataAreaId;
            messageItemsLog.ItemId = itemId;
            messageItemsLog.ItemTypeId = itemTypeId;
            messageItemsLog.MessageId = messageId;
            messageItemsLog.ActionId = actionId;
            return messageItemsLog;
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
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property ItemTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemTypeId is required.")]
        public virtual string ItemTypeId
        {
            get
            {
                return this._ItemTypeId;
            }
            set
            {
                this.OnItemTypeIdChanging(value);
                this._ItemTypeId = value;
                this.OnItemTypeIdChanged();
                this.OnPropertyChanged("ItemTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemTypeId;
        partial void OnItemTypeIdChanging(string value);
        partial void OnItemTypeIdChanged();
        /// <summary>
        /// There are no comments for Property MessageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MessageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MessageId is required.")]
        public virtual string MessageId
        {
            get
            {
                return this._MessageId;
            }
            set
            {
                this.OnMessageIdChanging(value);
                this._MessageId = value;
                this.OnMessageIdChanged();
                this.OnPropertyChanged("MessageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MessageId;
        partial void OnMessageIdChanging(string value);
        partial void OnMessageIdChanged();
        /// <summary>
        /// There are no comments for Property ActionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActionId is required.")]
        public virtual string ActionId
        {
            get
            {
                return this._ActionId;
            }
            set
            {
                this.OnActionIdChanging(value);
                this._ActionId = value;
                this.OnActionIdChanged();
                this.OnPropertyChanged("ActionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActionId;
        partial void OnActionIdChanging(string value);
        partial void OnActionIdChanged();
        /// <summary>
        /// There are no comments for Property ItemStatusFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemStatusFrom")]
        public virtual string ItemStatusFrom
        {
            get
            {
                return this._ItemStatusFrom;
            }
            set
            {
                this.OnItemStatusFromChanging(value);
                this._ItemStatusFrom = value;
                this.OnItemStatusFromChanged();
                this.OnPropertyChanged("ItemStatusFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemStatusFrom;
        partial void OnItemStatusFromChanging(string value);
        partial void OnItemStatusFromChanged();
        /// <summary>
        /// There are no comments for Property ItemStatusTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemStatusTo")]
        public virtual string ItemStatusTo
        {
            get
            {
                return this._ItemStatusTo;
            }
            set
            {
                this.OnItemStatusToChanging(value);
                this._ItemStatusTo = value;
                this.OnItemStatusToChanged();
                this.OnPropertyChanged("ItemStatusTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemStatusTo;
        partial void OnItemStatusToChanging(string value);
        partial void OnItemStatusToChanged();
        /// <summary>
        /// There are no comments for Property ProcessingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessingId")]
        public virtual string ProcessingId
        {
            get
            {
                return this._ProcessingId;
            }
            set
            {
                this.OnProcessingIdChanging(value);
                this._ProcessingId = value;
                this.OnProcessingIdChanged();
                this.OnPropertyChanged("ProcessingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessingId;
        partial void OnProcessingIdChanging(string value);
        partial void OnProcessingIdChanged();
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
