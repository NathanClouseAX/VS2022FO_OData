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
    /// There are no comments for RetailTmpCustomerMediaSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTmpCustomerMediaSingle")]
    public partial class RetailTmpCustomerMediaSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTmpCustomerMedia>
    {
        /// <summary>
        /// Initialize a new RetailTmpCustomerMediaSingle object.
        /// </summary>
        public RetailTmpCustomerMediaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTmpCustomerMediaSingle object.
        /// </summary>
        public RetailTmpCustomerMediaSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTmpCustomerMediaSingle object.
        /// </summary>
        public RetailTmpCustomerMediaSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTmpCustomerMedia> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTmpCustomerMedia in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Customer
    /// FileName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Customer", "FileName")]
    [global::Microsoft.OData.Client.EntitySet("RetailTmpCustomerMedias")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTmpCustomerMedia")]
    public partial class RetailTmpCustomerMedia : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTmpCustomerMedia object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="customer">Initial value of Customer.</param>
        /// <param name="fileName">Initial value of FileName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTmpCustomerMedia CreateRetailTmpCustomerMedia(string dataAreaId, string customer, string fileName)
        {
            RetailTmpCustomerMedia retailTmpCustomerMedia = new RetailTmpCustomerMedia();
            retailTmpCustomerMedia.DataAreaId = dataAreaId;
            retailTmpCustomerMedia.Customer = customer;
            retailTmpCustomerMedia.FileName = fileName;
            return retailTmpCustomerMedia;
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
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Customer is required.")]
        public virtual string Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Customer;
        partial void OnCustomerChanging(string value);
        partial void OnCustomerChanged();
        /// <summary>
        /// There are no comments for Property FileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FileName is required.")]
        public virtual string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this.OnFileNameChanging(value);
                this._FileName = value;
                this.OnFileNameChanged();
                this.OnPropertyChanged("FileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileName;
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
        /// <summary>
        /// There are no comments for Property AssociationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssociationStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailMediaAssociationStatus> AssociationStatus
        {
            get
            {
                return this._AssociationStatus;
            }
            set
            {
                this.OnAssociationStatusChanging(value);
                this._AssociationStatus = value;
                this.OnAssociationStatusChanged();
                this.OnPropertyChanged("AssociationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailMediaAssociationStatus> _AssociationStatus;
        partial void OnAssociationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailMediaAssociationStatus> value);
        partial void OnAssociationStatusChanged();
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
        /// There are no comments for Property CustomerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerName")]
        public virtual string CustomerName
        {
            get
            {
                return this._CustomerName;
            }
            set
            {
                this.OnCustomerNameChanging(value);
                this._CustomerName = value;
                this.OnCustomerNameChanged();
                this.OnPropertyChanged("CustomerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerName;
        partial void OnCustomerNameChanging(string value);
        partial void OnCustomerNameChanged();
        /// <summary>
        /// There are no comments for Property Url in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Url")]
        public virtual string Url
        {
            get
            {
                return this._Url;
            }
            set
            {
                this.OnUrlChanging(value);
                this._Url = value;
                this.OnUrlChanged();
                this.OnPropertyChanged("Url");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Url;
        partial void OnUrlChanging(string value);
        partial void OnUrlChanged();
        /// <summary>
        /// There are no comments for Property CompanyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyCode")]
        public virtual string CompanyCode
        {
            get
            {
                return this._CompanyCode;
            }
            set
            {
                this.OnCompanyCodeChanging(value);
                this._CompanyCode = value;
                this.OnCompanyCodeChanged();
                this.OnPropertyChanged("CompanyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyCode;
        partial void OnCompanyCodeChanging(string value);
        partial void OnCompanyCodeChanged();
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
