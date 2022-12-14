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
    /// There are no comments for PolicyViolationJustificationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PolicyViolationJustificationSingle")]
    public partial class PolicyViolationJustificationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyViolationJustification>
    {
        /// <summary>
        /// Initialize a new PolicyViolationJustificationSingle object.
        /// </summary>
        public PolicyViolationJustificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PolicyViolationJustificationSingle object.
        /// </summary>
        public PolicyViolationJustificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PolicyViolationJustificationSingle object.
        /// </summary>
        public PolicyViolationJustificationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyViolationJustification> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PolicyViolationJustification in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JustificationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JustificationId")]
    [global::Microsoft.OData.Client.EntitySet("PolicyViolationJustifications")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PolicyViolationJustification")]
    public partial class PolicyViolationJustification : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PolicyViolationJustification object.
        /// </summary>
        /// <param name="justificationId">Initial value of JustificationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PolicyViolationJustification CreatePolicyViolationJustification(global::System.Guid justificationId)
        {
            PolicyViolationJustification policyViolationJustification = new PolicyViolationJustification();
            policyViolationJustification.JustificationId = justificationId;
            return policyViolationJustification;
        }
        /// <summary>
        /// There are no comments for Property JustificationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JustificationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JustificationId is required.")]
        public virtual global::System.Guid JustificationId
        {
            get
            {
                return this._JustificationId;
            }
            set
            {
                this.OnJustificationIdChanging(value);
                this._JustificationId = value;
                this.OnJustificationIdChanged();
                this.OnPropertyChanged("JustificationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _JustificationId;
        partial void OnJustificationIdChanging(global::System.Guid value);
        partial void OnJustificationIdChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property JustificationText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JustificationText")]
        public virtual string JustificationText
        {
            get
            {
                return this._JustificationText;
            }
            set
            {
                this.OnJustificationTextChanging(value);
                this._JustificationText = value;
                this.OnJustificationTextChanged();
                this.OnPropertyChanged("JustificationText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JustificationText;
        partial void OnJustificationTextChanging(string value);
        partial void OnJustificationTextChanged();
        /// <summary>
        /// There are no comments for Property Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Action")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowAction> Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                this.OnActionChanging(value);
                this._Action = value;
                this.OnActionChanged();
                this.OnPropertyChanged("Action");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowAction> _Action;
        partial void OnActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowAction> value);
        partial void OnActionChanged();
        /// <summary>
        /// There are no comments for Property ViolatingRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ViolatingRecordId")]
        public virtual string ViolatingRecordId
        {
            get
            {
                return this._ViolatingRecordId;
            }
            set
            {
                this.OnViolatingRecordIdChanging(value);
                this._ViolatingRecordId = value;
                this.OnViolatingRecordIdChanged();
                this.OnPropertyChanged("ViolatingRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ViolatingRecordId;
        partial void OnViolatingRecordIdChanging(string value);
        partial void OnViolatingRecordIdChanged();
        /// <summary>
        /// There are no comments for Property ViolationJustificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ViolationJustificationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationJustificationTypeEnum> ViolationJustificationType
        {
            get
            {
                return this._ViolationJustificationType;
            }
            set
            {
                this.OnViolationJustificationTypeChanging(value);
                this._ViolationJustificationType = value;
                this.OnViolationJustificationTypeChanged();
                this.OnPropertyChanged("ViolationJustificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationJustificationTypeEnum> _ViolationJustificationType;
        partial void OnViolationJustificationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationJustificationTypeEnum> value);
        partial void OnViolationJustificationTypeChanged();
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
