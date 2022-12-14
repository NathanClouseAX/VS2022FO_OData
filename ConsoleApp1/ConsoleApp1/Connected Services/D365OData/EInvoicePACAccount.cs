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
    /// There are no comments for EInvoicePACAccountSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EInvoicePACAccountSingle")]
    public partial class EInvoicePACAccountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EInvoicePACAccount>
    {
        /// <summary>
        /// Initialize a new EInvoicePACAccountSingle object.
        /// </summary>
        public EInvoicePACAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EInvoicePACAccountSingle object.
        /// </summary>
        public EInvoicePACAccountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EInvoicePACAccountSingle object.
        /// </summary>
        public EInvoicePACAccountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EInvoicePACAccount> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EInvoicePACAccount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PACAccountId
    /// Environment
    /// WebService
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PACAccountId", "Environment", "WebService")]
    [global::Microsoft.OData.Client.EntitySet("EInvoicePACAccounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EInvoicePACAccount")]
    public partial class EInvoicePACAccount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EInvoicePACAccount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="pACAccountId">Initial value of PACAccountId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EInvoicePACAccount CreateEInvoicePACAccount(string dataAreaId, string pACAccountId)
        {
            EInvoicePACAccount eInvoicePACAccount = new EInvoicePACAccount();
            eInvoicePACAccount.DataAreaId = dataAreaId;
            eInvoicePACAccount.PACAccountId = pACAccountId;
            return eInvoicePACAccount;
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
        /// There are no comments for Property PACAccountId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PACAccountId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PACAccountId is required.")]
        public virtual string PACAccountId
        {
            get
            {
                return this._PACAccountId;
            }
            set
            {
                this.OnPACAccountIdChanging(value);
                this._PACAccountId = value;
                this.OnPACAccountIdChanged();
                this.OnPropertyChanged("PACAccountId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PACAccountId;
        partial void OnPACAccountIdChanging(string value);
        partial void OnPACAccountIdChanged();
        /// <summary>
        /// There are no comments for Property Environment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Environment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIEnvironment_MX> Environment
        {
            get
            {
                return this._Environment;
            }
            set
            {
                this.OnEnvironmentChanging(value);
                this._Environment = value;
                this.OnEnvironmentChanged();
                this.OnPropertyChanged("Environment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIEnvironment_MX> _Environment;
        partial void OnEnvironmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIEnvironment_MX> value);
        partial void OnEnvironmentChanged();
        /// <summary>
        /// There are no comments for Property WebService in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebService")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIWebService_MX> WebService
        {
            get
            {
                return this._WebService;
            }
            set
            {
                this.OnWebServiceChanging(value);
                this._WebService = value;
                this.OnWebServiceChanged();
                this.OnPropertyChanged("WebService");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIWebService_MX> _WebService;
        partial void OnWebServiceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EInvoiceCFDIWebService_MX> value);
        partial void OnWebServiceChanged();
        /// <summary>
        /// There are no comments for Property WebServiceMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebServiceMethod")]
        public virtual string WebServiceMethod
        {
            get
            {
                return this._WebServiceMethod;
            }
            set
            {
                this.OnWebServiceMethodChanging(value);
                this._WebServiceMethod = value;
                this.OnWebServiceMethodChanged();
                this.OnPropertyChanged("WebServiceMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WebServiceMethod;
        partial void OnWebServiceMethodChanging(string value);
        partial void OnWebServiceMethodChanged();
        /// <summary>
        /// There are no comments for Property RFCNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFCNumber")]
        public virtual string RFCNumber
        {
            get
            {
                return this._RFCNumber;
            }
            set
            {
                this.OnRFCNumberChanging(value);
                this._RFCNumber = value;
                this.OnRFCNumberChanged();
                this.OnPropertyChanged("RFCNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFCNumber;
        partial void OnRFCNumberChanging(string value);
        partial void OnRFCNumberChanged();
        /// <summary>
        /// There are no comments for Property URL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("URL")]
        public virtual string URL
        {
            get
            {
                return this._URL;
            }
            set
            {
                this.OnURLChanging(value);
                this._URL = value;
                this.OnURLChanged();
                this.OnPropertyChanged("URL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _URL;
        partial void OnURLChanging(string value);
        partial void OnURLChanged();
        /// <summary>
        /// There are no comments for Property PACAccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PACAccountName")]
        public virtual string PACAccountName
        {
            get
            {
                return this._PACAccountName;
            }
            set
            {
                this.OnPACAccountNameChanging(value);
                this._PACAccountName = value;
                this.OnPACAccountNameChanged();
                this.OnPropertyChanged("PACAccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PACAccountName;
        partial void OnPACAccountNameChanging(string value);
        partial void OnPACAccountNameChanged();
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
