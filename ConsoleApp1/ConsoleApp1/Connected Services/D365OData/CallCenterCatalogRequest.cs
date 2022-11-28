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
    /// There are no comments for CallCenterCatalogRequestSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CallCenterCatalogRequestSingle")]
    public partial class CallCenterCatalogRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterCatalogRequest>
    {
        /// <summary>
        /// Initialize a new CallCenterCatalogRequestSingle object.
        /// </summary>
        public CallCenterCatalogRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CallCenterCatalogRequestSingle object.
        /// </summary>
        public CallCenterCatalogRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CallCenterCatalogRequestSingle object.
        /// </summary>
        public CallCenterCatalogRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterCatalogRequest> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CallCenterCatalogRequest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CatalogDescription
    /// CatalogRequestNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CatalogDescription", "CatalogRequestNumber")]
    [global::Microsoft.OData.Client.EntitySet("CallCenterCatalogRequests")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CallCenterCatalogRequest")]
    public partial class CallCenterCatalogRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CallCenterCatalogRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="catalogDescription">Initial value of CatalogDescription.</param>
        /// <param name="catalogRequestNumber">Initial value of CatalogRequestNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CallCenterCatalogRequest CreateCallCenterCatalogRequest(string dataAreaId, string catalogDescription, decimal catalogRequestNumber)
        {
            CallCenterCatalogRequest callCenterCatalogRequest = new CallCenterCatalogRequest();
            callCenterCatalogRequest.DataAreaId = dataAreaId;
            callCenterCatalogRequest.CatalogDescription = catalogDescription;
            callCenterCatalogRequest.CatalogRequestNumber = catalogRequestNumber;
            return callCenterCatalogRequest;
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
        /// There are no comments for Property CatalogDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatalogDescription")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CatalogDescription is required.")]
        public virtual string CatalogDescription
        {
            get
            {
                return this._CatalogDescription;
            }
            set
            {
                this.OnCatalogDescriptionChanging(value);
                this._CatalogDescription = value;
                this.OnCatalogDescriptionChanged();
                this.OnPropertyChanged("CatalogDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogDescription;
        partial void OnCatalogDescriptionChanging(string value);
        partial void OnCatalogDescriptionChanged();
        /// <summary>
        /// There are no comments for Property CatalogRequestNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatalogRequestNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CatalogRequestNumber is required.")]
        public virtual decimal CatalogRequestNumber
        {
            get
            {
                return this._CatalogRequestNumber;
            }
            set
            {
                this.OnCatalogRequestNumberChanging(value);
                this._CatalogRequestNumber = value;
                this.OnCatalogRequestNumberChanged();
                this.OnPropertyChanged("CatalogRequestNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CatalogRequestNumber;
        partial void OnCatalogRequestNumberChanging(decimal value);
        partial void OnCatalogRequestNumberChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccount")]
        public virtual string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property SourceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceCode")]
        public virtual string SourceCode
        {
            get
            {
                return this._SourceCode;
            }
            set
            {
                this.OnSourceCodeChanging(value);
                this._SourceCode = value;
                this.OnSourceCodeChanged();
                this.OnPropertyChanged("SourceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceCode;
        partial void OnSourceCodeChanging(string value);
        partial void OnSourceCodeChanged();
        /// <summary>
        /// There are no comments for Property LogId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogId")]
        public virtual string LogId
        {
            get
            {
                return this._LogId;
            }
            set
            {
                this.OnLogIdChanging(value);
                this._LogId = value;
                this.OnLogIdChanged();
                this.OnPropertyChanged("LogId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LogId;
        partial void OnLogIdChanging(string value);
        partial void OnLogIdChanged();
        /// <summary>
        /// There are no comments for Property RequestStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCatalogStatus> RequestStatus
        {
            get
            {
                return this._RequestStatus;
            }
            set
            {
                this.OnRequestStatusChanging(value);
                this._RequestStatus = value;
                this.OnRequestStatusChanged();
                this.OnPropertyChanged("RequestStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCatalogStatus> _RequestStatus;
        partial void OnRequestStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCatalogStatus> value);
        partial void OnRequestStatusChanged();
        /// <summary>
        /// There are no comments for Property BusinessRelationAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessRelationAccount")]
        public virtual string BusinessRelationAccount
        {
            get
            {
                return this._BusinessRelationAccount;
            }
            set
            {
                this.OnBusinessRelationAccountChanging(value);
                this._BusinessRelationAccount = value;
                this.OnBusinessRelationAccountChanged();
                this.OnPropertyChanged("BusinessRelationAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BusinessRelationAccount;
        partial void OnBusinessRelationAccountChanging(string value);
        partial void OnBusinessRelationAccountChanged();
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