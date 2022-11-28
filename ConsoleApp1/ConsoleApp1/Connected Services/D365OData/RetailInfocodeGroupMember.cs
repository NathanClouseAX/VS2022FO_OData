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
    /// There are no comments for RetailInfocodeGroupMemberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInfocodeGroupMemberSingle")]
    public partial class RetailInfocodeGroupMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInfocodeGroupMember>
    {
        /// <summary>
        /// Initialize a new RetailInfocodeGroupMemberSingle object.
        /// </summary>
        public RetailInfocodeGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInfocodeGroupMemberSingle object.
        /// </summary>
        public RetailInfocodeGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInfocodeGroupMemberSingle object.
        /// </summary>
        public RetailInfocodeGroupMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInfocodeGroupMember> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailInfocodeGroupMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GroupId
    /// InfocodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId", "InfocodeId")]
    [global::Microsoft.OData.Client.EntitySet("RetailInfocodeGroupMembers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInfocodeGroupMember")]
    public partial class RetailInfocodeGroupMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInfocodeGroupMember object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        /// <param name="infocodeId">Initial value of InfocodeId.</param>
        /// <param name="priority">Initial value of Priority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInfocodeGroupMember CreateRetailInfocodeGroupMember(string dataAreaId, string groupId, string infocodeId, int priority)
        {
            RetailInfocodeGroupMember retailInfocodeGroupMember = new RetailInfocodeGroupMember();
            retailInfocodeGroupMember.DataAreaId = dataAreaId;
            retailInfocodeGroupMember.GroupId = groupId;
            retailInfocodeGroupMember.InfocodeId = infocodeId;
            retailInfocodeGroupMember.Priority = priority;
            return retailInfocodeGroupMember;
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
        /// There are no comments for Property InfocodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InfocodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InfocodeId is required.")]
        public virtual string InfocodeId
        {
            get
            {
                return this._InfocodeId;
            }
            set
            {
                this.OnInfocodeIdChanging(value);
                this._InfocodeId = value;
                this.OnInfocodeIdChanged();
                this.OnPropertyChanged("InfocodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InfocodeId;
        partial void OnInfocodeIdChanging(string value);
        partial void OnInfocodeIdChanged();
        /// <summary>
        /// There are no comments for Property Priority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Priority")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Priority is required.")]
        public virtual int Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this.OnPriorityChanging(value);
                this._Priority = value;
                this.OnPriorityChanged();
                this.OnPropertyChanged("Priority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Priority;
        partial void OnPriorityChanging(int value);
        partial void OnPriorityChanged();
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
