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
    /// There are no comments for CustomOfficesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomOfficesSingle")]
    public partial class CustomOfficesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomOffices>
    {
        /// <summary>
        /// Initialize a new CustomOfficesSingle object.
        /// </summary>
        public CustomOfficesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomOfficesSingle object.
        /// </summary>
        public CustomOfficesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomOfficesSingle object.
        /// </summary>
        public CustomOfficesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomOffices> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CustomOffices in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AgentAccountNumber
    /// OfficeCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AgentAccountNumber", "OfficeCode")]
    [global::Microsoft.OData.Client.EntitySet("CustomOffices")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomOffices")]
    public partial class CustomOffices : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomOffices object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="agentAccountNumber">Initial value of AgentAccountNumber.</param>
        /// <param name="officeCode">Initial value of OfficeCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomOffices CreateCustomOffices(string dataAreaId, string agentAccountNumber, string officeCode)
        {
            CustomOffices customOffices = new CustomOffices();
            customOffices.DataAreaId = dataAreaId;
            customOffices.AgentAccountNumber = agentAccountNumber;
            customOffices.OfficeCode = officeCode;
            return customOffices;
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
        /// There are no comments for Property AgentAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgentAccountNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AgentAccountNumber is required.")]
        public virtual string AgentAccountNumber
        {
            get
            {
                return this._AgentAccountNumber;
            }
            set
            {
                this.OnAgentAccountNumberChanging(value);
                this._AgentAccountNumber = value;
                this.OnAgentAccountNumberChanged();
                this.OnPropertyChanged("AgentAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgentAccountNumber;
        partial void OnAgentAccountNumberChanging(string value);
        partial void OnAgentAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property OfficeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OfficeCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OfficeCode is required.")]
        public virtual string OfficeCode
        {
            get
            {
                return this._OfficeCode;
            }
            set
            {
                this.OnOfficeCodeChanging(value);
                this._OfficeCode = value;
                this.OnOfficeCodeChanged();
                this.OnPropertyChanged("OfficeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfficeCode;
        partial void OnOfficeCodeChanging(string value);
        partial void OnOfficeCodeChanged();
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
