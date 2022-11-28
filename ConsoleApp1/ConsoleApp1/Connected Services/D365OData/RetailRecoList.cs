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
    /// There are no comments for RetailRecoListSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailRecoListSingle")]
    public partial class RetailRecoListSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailRecoList>
    {
        /// <summary>
        /// Initialize a new RetailRecoListSingle object.
        /// </summary>
        public RetailRecoListSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailRecoListSingle object.
        /// </summary>
        public RetailRecoListSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailRecoListSingle object.
        /// </summary>
        public RetailRecoListSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailRecoList> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailRecoList in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ListId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ListId")]
    [global::Microsoft.OData.Client.EntitySet("RetailRecoLists")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailRecoList")]
    public partial class RetailRecoList : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailRecoList object.
        /// </summary>
        /// <param name="listId">Initial value of ListId.</param>
        /// <param name="lastModifiedDateTime">Initial value of LastModifiedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailRecoList CreateRetailRecoList(string listId, global::System.DateTimeOffset lastModifiedDateTime)
        {
            RetailRecoList retailRecoList = new RetailRecoList();
            retailRecoList.ListId = listId;
            retailRecoList.LastModifiedDateTime = lastModifiedDateTime;
            return retailRecoList;
        }
        /// <summary>
        /// There are no comments for Property ListId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ListId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ListId is required.")]
        public virtual string ListId
        {
            get
            {
                return this._ListId;
            }
            set
            {
                this.OnListIdChanging(value);
                this._ListId = value;
                this.OnListIdChanged();
                this.OnPropertyChanged("ListId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ListId;
        partial void OnListIdChanging(string value);
        partial void OnListIdChanged();
        /// <summary>
        /// There are no comments for Property LastModifiedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastModifiedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LastModifiedDateTime is required.")]
        public virtual global::System.DateTimeOffset LastModifiedDateTime
        {
            get
            {
                return this._LastModifiedDateTime;
            }
            set
            {
                this.OnLastModifiedDateTimeChanging(value);
                this._LastModifiedDateTime = value;
                this.OnLastModifiedDateTimeChanged();
                this.OnPropertyChanged("LastModifiedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LastModifiedDateTime;
        partial void OnLastModifiedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnLastModifiedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ListTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ListTitle")]
        public virtual string ListTitle
        {
            get
            {
                return this._ListTitle;
            }
            set
            {
                this.OnListTitleChanging(value);
                this._ListTitle = value;
                this.OnListTitleChanged();
                this.OnPropertyChanged("ListTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ListTitle;
        partial void OnListTitleChanging(string value);
        partial void OnListTitleChanged();
        /// <summary>
        /// There are no comments for Property ListType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ListType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRecoListTypeBase> ListType
        {
            get
            {
                return this._ListType;
            }
            set
            {
                this.OnListTypeChanging(value);
                this._ListType = value;
                this.OnListTypeChanged();
                this.OnPropertyChanged("ListType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRecoListTypeBase> _ListType;
        partial void OnListTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailRecoListTypeBase> value);
        partial void OnListTypeChanged();
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
