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
    /// There are no comments for UserStoreSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserStoreSingle")]
    public partial class UserStoreSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserStore>
    {
        /// <summary>
        /// Initialize a new UserStoreSingle object.
        /// </summary>
        public UserStoreSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserStoreSingle object.
        /// </summary>
        public UserStoreSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserStoreSingle object.
        /// </summary>
        public UserStoreSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserStore> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for UserStore in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// StoreNumber
    /// User
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StoreNumber", "User")]
    [global::Microsoft.OData.Client.EntitySet("UserStores")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserStore")]
    public partial class UserStore : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserStore object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="user">Initial value of User.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserStore CreateUserStore(string dataAreaId, string storeNumber, string user)
        {
            UserStore userStore = new UserStore();
            userStore.DataAreaId = dataAreaId;
            userStore.StoreNumber = storeNumber;
            userStore.User = user;
            return userStore;
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
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "User is required.")]
        public virtual string User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _User;
        partial void OnUserChanging(string value);
        partial void OnUserChanged();
        /// <summary>
        /// There are no comments for Property StoreName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreName")]
        public virtual string StoreName
        {
            get
            {
                return this._StoreName;
            }
            set
            {
                this.OnStoreNameChanging(value);
                this._StoreName = value;
                this.OnStoreNameChanged();
                this.OnPropertyChanged("StoreName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreName;
        partial void OnStoreNameChanging(string value);
        partial void OnStoreNameChanged();
        /// <summary>
        /// There are no comments for Property PrimaryStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryStore")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PrimaryStore
        {
            get
            {
                return this._PrimaryStore;
            }
            set
            {
                this.OnPrimaryStoreChanging(value);
                this._PrimaryStore = value;
                this.OnPrimaryStoreChanged();
                this.OnPropertyChanged("PrimaryStore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PrimaryStore;
        partial void OnPrimaryStoreChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrimaryStoreChanged();
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
