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
    /// There are no comments for EmergencyResponseSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmergencyResponseSingle")]
    public partial class EmergencyResponseSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmergencyResponse>
    {
        /// <summary>
        /// Initialize a new EmergencyResponseSingle object.
        /// </summary>
        public EmergencyResponseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmergencyResponseSingle object.
        /// </summary>
        public EmergencyResponseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmergencyResponseSingle object.
        /// </summary>
        public EmergencyResponseSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmergencyResponse> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EmergencyResponse in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EMSCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EMSCode")]
    [global::Microsoft.OData.Client.EntitySet("EmergencyResponses")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmergencyResponse")]
    public partial class EmergencyResponse : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmergencyResponse object.
        /// </summary>
        /// <param name="eMSCode">Initial value of EMSCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmergencyResponse CreateEmergencyResponse(string eMSCode)
        {
            EmergencyResponse emergencyResponse = new EmergencyResponse();
            emergencyResponse.EMSCode = eMSCode;
            return emergencyResponse;
        }
        /// <summary>
        /// There are no comments for Property EMSCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EMSCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EMSCode is required.")]
        public virtual string EMSCode
        {
            get
            {
                return this._EMSCode;
            }
            set
            {
                this.OnEMSCodeChanging(value);
                this._EMSCode = value;
                this.OnEMSCodeChanged();
                this.OnPropertyChanged("EMSCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EMSCode;
        partial void OnEMSCodeChanging(string value);
        partial void OnEMSCodeChanged();
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
