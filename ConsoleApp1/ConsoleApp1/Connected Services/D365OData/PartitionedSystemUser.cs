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
    /// There are no comments for PartitionedSystemUserSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionedSystemUserSingle")]
    public partial class PartitionedSystemUserSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartitionedSystemUser>
    {
        /// <summary>
        /// Initialize a new PartitionedSystemUserSingle object.
        /// </summary>
        public PartitionedSystemUserSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartitionedSystemUserSingle object.
        /// </summary>
        public PartitionedSystemUserSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartitionedSystemUserSingle object.
        /// </summary>
        public PartitionedSystemUserSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartitionedSystemUser> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PartitionedSystemUser in the schema.
    /// </summary>
    /// <KeyProperties>
    /// UserID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("UserID")]
    [global::Microsoft.OData.Client.EntitySet("PartitionedSystemUsers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionedSystemUser")]
    public partial class PartitionedSystemUser : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartitionedSystemUser object.
        /// </summary>
        /// <param name="userID">Initial value of UserID.</param>
        /// <param name="defaultPartition">Initial value of DefaultPartition.</param>
        /// <param name="enabled">Initial value of Enabled.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartitionedSystemUser CreatePartitionedSystemUser(string userID, bool defaultPartition, bool enabled)
        {
            PartitionedSystemUser partitionedSystemUser = new PartitionedSystemUser();
            partitionedSystemUser.UserID = userID;
            partitionedSystemUser.DefaultPartition = defaultPartition;
            partitionedSystemUser.Enabled = enabled;
            return partitionedSystemUser;
        }
        /// <summary>
        /// There are no comments for Property UserID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UserID is required.")]
        public virtual string UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this.OnUserIDChanging(value);
                this._UserID = value;
                this.OnUserIDChanged();
                this.OnPropertyChanged("UserID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserID;
        partial void OnUserIDChanging(string value);
        partial void OnUserIDChanged();
        /// <summary>
        /// There are no comments for Property DefaultPartition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPartition")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefaultPartition is required.")]
        public virtual bool DefaultPartition
        {
            get
            {
                return this._DefaultPartition;
            }
            set
            {
                this.OnDefaultPartitionChanging(value);
                this._DefaultPartition = value;
                this.OnDefaultPartitionChanged();
                this.OnPropertyChanged("DefaultPartition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private bool _DefaultPartition;
        partial void OnDefaultPartitionChanging(bool value);
        partial void OnDefaultPartitionChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UserAccountType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UserAccountType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UserAccountType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property UserInfo_language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserInfo_language")]
        public virtual string UserInfo_language
        {
            get
            {
                return this._UserInfo_language;
            }
            set
            {
                this.OnUserInfo_languageChanging(value);
                this._UserInfo_language = value;
                this.OnUserInfo_languageChanged();
                this.OnPropertyChanged("UserInfo_language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserInfo_language;
        partial void OnUserInfo_languageChanging(string value);
        partial void OnUserInfo_languageChanged();
        /// <summary>
        /// There are no comments for Property NetworkDomain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NetworkDomain")]
        public virtual string NetworkDomain
        {
            get
            {
                return this._NetworkDomain;
            }
            set
            {
                this.OnNetworkDomainChanging(value);
                this._NetworkDomain = value;
                this.OnNetworkDomainChanged();
                this.OnPropertyChanged("NetworkDomain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NetworkDomain;
        partial void OnNetworkDomainChanging(string value);
        partial void OnNetworkDomainChanged();
        /// <summary>
        /// There are no comments for Property PartitionKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionKey")]
        public virtual string PartitionKey
        {
            get
            {
                return this._PartitionKey;
            }
            set
            {
                this.OnPartitionKeyChanging(value);
                this._PartitionKey = value;
                this.OnPartitionKeyChanged();
                this.OnPropertyChanged("PartitionKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartitionKey;
        partial void OnPartitionKeyChanging(string value);
        partial void OnPartitionKeyChanged();
        /// <summary>
        /// There are no comments for Property Alias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Alias")]
        public virtual string Alias
        {
            get
            {
                return this._Alias;
            }
            set
            {
                this.OnAliasChanging(value);
                this._Alias = value;
                this.OnAliasChanged();
                this.OnPropertyChanged("Alias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Alias;
        partial void OnAliasChanging(string value);
        partial void OnAliasChanged();
        /// <summary>
        /// There are no comments for Property PersonName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonName")]
        public virtual string PersonName
        {
            get
            {
                return this._PersonName;
            }
            set
            {
                this.OnPersonNameChanging(value);
                this._PersonName = value;
                this.OnPersonNameChanged();
                this.OnPropertyChanged("PersonName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonName;
        partial void OnPersonNameChanging(string value);
        partial void OnPersonNameChanged();
        /// <summary>
        /// There are no comments for Property UserName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserName")]
        public virtual string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this.OnUserNameChanging(value);
                this._UserName = value;
                this.OnUserNameChanged();
                this.OnPropertyChanged("UserName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserName;
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        /// <summary>
        /// There are no comments for Property Enabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Enabled")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Enabled is required.")]
        public virtual bool Enabled
        {
            get
            {
                return this._Enabled;
            }
            set
            {
                this.OnEnabledChanging(value);
                this._Enabled = value;
                this.OnEnabledChanged();
                this.OnPropertyChanged("Enabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private bool _Enabled;
        partial void OnEnabledChanging(bool value);
        partial void OnEnabledChanged();
        /// <summary>
        /// There are no comments for Property Helplanguage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Helplanguage")]
        public virtual string Helplanguage
        {
            get
            {
                return this._Helplanguage;
            }
            set
            {
                this.OnHelplanguageChanging(value);
                this._Helplanguage = value;
                this.OnHelplanguageChanged();
                this.OnPropertyChanged("Helplanguage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Helplanguage;
        partial void OnHelplanguageChanging(string value);
        partial void OnHelplanguageChanged();
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
