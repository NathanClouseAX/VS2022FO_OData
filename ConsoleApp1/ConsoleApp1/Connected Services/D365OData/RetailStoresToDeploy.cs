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
    /// There are no comments for RetailStoresToDeploySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoresToDeploySingle")]
    public partial class RetailStoresToDeploySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoresToDeploy>
    {
        /// <summary>
        /// Initialize a new RetailStoresToDeploySingle object.
        /// </summary>
        public RetailStoresToDeploySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoresToDeploySingle object.
        /// </summary>
        public RetailStoresToDeploySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoresToDeploySingle object.
        /// </summary>
        public RetailStoresToDeploySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoresToDeploy> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailStoresToDeploy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// StoreNumber
    /// TerminalId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StoreNumber", "TerminalId")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoresToDeploys")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoresToDeploy")]
    public partial class RetailStoresToDeploy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoresToDeploy object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="terminalId">Initial value of TerminalId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoresToDeploy CreateRetailStoresToDeploy(string dataAreaId, string storeNumber, string terminalId)
        {
            RetailStoresToDeploy retailStoresToDeploy = new RetailStoresToDeploy();
            retailStoresToDeploy.DataAreaId = dataAreaId;
            retailStoresToDeploy.StoreNumber = storeNumber;
            retailStoresToDeploy.TerminalId = terminalId;
            return retailStoresToDeploy;
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
        /// There are no comments for Property TerminalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TerminalId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TerminalId is required.")]
        public virtual string TerminalId
        {
            get
            {
                return this._TerminalId;
            }
            set
            {
                this.OnTerminalIdChanging(value);
                this._TerminalId = value;
                this.OnTerminalIdChanged();
                this.OnPropertyChanged("TerminalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TerminalId;
        partial void OnTerminalIdChanging(string value);
        partial void OnTerminalIdChanged();
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
