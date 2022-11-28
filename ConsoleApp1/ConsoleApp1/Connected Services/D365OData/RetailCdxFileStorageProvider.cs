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
    /// There are no comments for RetailCdxFileStorageProviderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCdxFileStorageProviderSingle")]
    public partial class RetailCdxFileStorageProviderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCdxFileStorageProvider>
    {
        /// <summary>
        /// Initialize a new RetailCdxFileStorageProviderSingle object.
        /// </summary>
        public RetailCdxFileStorageProviderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCdxFileStorageProviderSingle object.
        /// </summary>
        public RetailCdxFileStorageProviderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCdxFileStorageProviderSingle object.
        /// </summary>
        public RetailCdxFileStorageProviderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCdxFileStorageProvider> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailCdxFileStorageProvider in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("RetailCdxFileStorageProviders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCdxFileStorageProvider")]
    public partial class RetailCdxFileStorageProvider : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCdxFileStorageProvider object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCdxFileStorageProvider CreateRetailCdxFileStorageProvider(string name)
        {
            RetailCdxFileStorageProvider retailCdxFileStorageProvider = new RetailCdxFileStorageProvider();
            retailCdxFileStorageProvider.Name = name;
            return retailCdxFileStorageProvider;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property ShareDownloadPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShareDownloadPath")]
        public virtual string ShareDownloadPath
        {
            get
            {
                return this._ShareDownloadPath;
            }
            set
            {
                this.OnShareDownloadPathChanging(value);
                this._ShareDownloadPath = value;
                this.OnShareDownloadPathChanged();
                this.OnPropertyChanged("ShareDownloadPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShareDownloadPath;
        partial void OnShareDownloadPathChanging(string value);
        partial void OnShareDownloadPathChanged();
        /// <summary>
        /// There are no comments for Property PackageStoreType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackageStoreType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCDXPackageStoreType> PackageStoreType
        {
            get
            {
                return this._PackageStoreType;
            }
            set
            {
                this.OnPackageStoreTypeChanging(value);
                this._PackageStoreType = value;
                this.OnPackageStoreTypeChanged();
                this.OnPropertyChanged("PackageStoreType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCDXPackageStoreType> _PackageStoreType;
        partial void OnPackageStoreTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCDXPackageStoreType> value);
        partial void OnPackageStoreTypeChanged();
        /// <summary>
        /// There are no comments for Property ShareUploadPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShareUploadPath")]
        public virtual string ShareUploadPath
        {
            get
            {
                return this._ShareUploadPath;
            }
            set
            {
                this.OnShareUploadPathChanging(value);
                this._ShareUploadPath = value;
                this.OnShareUploadPathChanged();
                this.OnPropertyChanged("ShareUploadPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShareUploadPath;
        partial void OnShareUploadPathChanging(string value);
        partial void OnShareUploadPathChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
