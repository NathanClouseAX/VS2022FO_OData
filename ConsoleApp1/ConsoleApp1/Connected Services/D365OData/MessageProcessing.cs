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
    /// There are no comments for MessageProcessingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageProcessingSingle")]
    public partial class MessageProcessingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MessageProcessing>
    {
        /// <summary>
        /// Initialize a new MessageProcessingSingle object.
        /// </summary>
        public MessageProcessingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MessageProcessingSingle object.
        /// </summary>
        public MessageProcessingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MessageProcessingSingle object.
        /// </summary>
        public MessageProcessingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MessageProcessing> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MessageProcessing in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Processing
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Processing")]
    [global::Microsoft.OData.Client.EntitySet("MessageProcessings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageProcessing")]
    public partial class MessageProcessing : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MessageProcessing object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="processing">Initial value of Processing.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MessageProcessing CreateMessageProcessing(string dataAreaId, string processing)
        {
            MessageProcessing messageProcessing = new MessageProcessing();
            messageProcessing.DataAreaId = dataAreaId;
            messageProcessing.Processing = processing;
            return messageProcessing;
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
        /// There are no comments for Property Processing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Processing")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Processing is required.")]
        public virtual string Processing
        {
            get
            {
                return this._Processing;
            }
            set
            {
                this.OnProcessingChanging(value);
                this._Processing = value;
                this.OnProcessingChanged();
                this.OnPropertyChanged("Processing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Processing;
        partial void OnProcessingChanging(string value);
        partial void OnProcessingChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
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