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
    /// There are no comments for DefinitionGroupTemplateHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateHeaderSingle")]
    public partial class DefinitionGroupTemplateHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DefinitionGroupTemplateHeader>
    {
        /// <summary>
        /// Initialize a new DefinitionGroupTemplateHeaderSingle object.
        /// </summary>
        public DefinitionGroupTemplateHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DefinitionGroupTemplateHeaderSingle object.
        /// </summary>
        public DefinitionGroupTemplateHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DefinitionGroupTemplateHeaderSingle object.
        /// </summary>
        public DefinitionGroupTemplateHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DefinitionGroupTemplateHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DMFDefinitionGroupTemplateLineEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateLineEntityRole")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle DMFDefinitionGroupTemplateLineEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DMFDefinitionGroupTemplateLineEntityRole == null))
                {
                    this._DMFDefinitionGroupTemplateLineEntityRole = new global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle(this.Context, GetPath("DMFDefinitionGroupTemplateLineEntityRole"));
                }
                return this._DMFDefinitionGroupTemplateLineEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle _DMFDefinitionGroupTemplateLineEntityRole;
        /// <summary>
        /// There are no comments for DMFDefinitionGroupTemplateLineRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateLineRole")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle DMFDefinitionGroupTemplateLineRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DMFDefinitionGroupTemplateLineRole == null))
                {
                    this._DMFDefinitionGroupTemplateLineRole = new global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle(this.Context, GetPath("DMFDefinitionGroupTemplateLineRole"));
                }
                return this._DMFDefinitionGroupTemplateLineRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLineSingle _DMFDefinitionGroupTemplateLineRole;
    }
    /// <summary>
    /// There are no comments for DefinitionGroupTemplateHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId")]
    [global::Microsoft.OData.Client.EntitySet("DefinitionGroupTemplateHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateHeader")]
    public partial class DefinitionGroupTemplateHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DefinitionGroupTemplateHeader object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="validatedDateTime">Initial value of ValidatedDateTime.</param>
        /// <param name="dMFDefinitionGroupTemplateLineRole">Initial value of DMFDefinitionGroupTemplateLineRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DefinitionGroupTemplateHeader CreateDefinitionGroupTemplateHeader(string templateId, global::System.DateTimeOffset validatedDateTime, global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine dMFDefinitionGroupTemplateLineRole)
        {
            DefinitionGroupTemplateHeader definitionGroupTemplateHeader = new DefinitionGroupTemplateHeader();
            definitionGroupTemplateHeader.TemplateId = templateId;
            definitionGroupTemplateHeader.ValidatedDateTime = validatedDateTime;
            if ((dMFDefinitionGroupTemplateLineRole == null))
            {
                throw new global::System.ArgumentNullException("dMFDefinitionGroupTemplateLineRole");
            }
            definitionGroupTemplateHeader.DMFDefinitionGroupTemplateLineRole = dMFDefinitionGroupTemplateLineRole;
            return definitionGroupTemplateHeader;
        }
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TemplateId is required.")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFDefinitionGroupTemplateStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFDefinitionGroupTemplateStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFDefinitionGroupTemplateStatus> value);
        partial void OnStatusChanged();
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
        /// There are no comments for Property ValidatedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidatedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidatedDateTime is required.")]
        public virtual global::System.DateTimeOffset ValidatedDateTime
        {
            get
            {
                return this._ValidatedDateTime;
            }
            set
            {
                this.OnValidatedDateTimeChanging(value);
                this._ValidatedDateTime = value;
                this.OnValidatedDateTimeChanged();
                this.OnPropertyChanged("ValidatedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidatedDateTime;
        partial void OnValidatedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnValidatedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property DMFDefinitionGroupTemplateLineEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateLineEntityRole")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine DMFDefinitionGroupTemplateLineEntityRole
        {
            get
            {
                return this._DMFDefinitionGroupTemplateLineEntityRole;
            }
            set
            {
                this.OnDMFDefinitionGroupTemplateLineEntityRoleChanging(value);
                this._DMFDefinitionGroupTemplateLineEntityRole = value;
                this.OnDMFDefinitionGroupTemplateLineEntityRoleChanged();
                this.OnPropertyChanged("DMFDefinitionGroupTemplateLineEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine _DMFDefinitionGroupTemplateLineEntityRole;
        partial void OnDMFDefinitionGroupTemplateLineEntityRoleChanging(global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine value);
        partial void OnDMFDefinitionGroupTemplateLineEntityRoleChanged();
        /// <summary>
        /// There are no comments for Property DMFDefinitionGroupTemplateLineRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateLineRole")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DMFDefinitionGroupTemplateLineRole is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine DMFDefinitionGroupTemplateLineRole
        {
            get
            {
                return this._DMFDefinitionGroupTemplateLineRole;
            }
            set
            {
                this.OnDMFDefinitionGroupTemplateLineRoleChanging(value);
                this._DMFDefinitionGroupTemplateLineRole = value;
                this.OnDMFDefinitionGroupTemplateLineRoleChanged();
                this.OnPropertyChanged("DMFDefinitionGroupTemplateLineRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine _DMFDefinitionGroupTemplateLineRole;
        partial void OnDMFDefinitionGroupTemplateLineRoleChanging(global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateLine value);
        partial void OnDMFDefinitionGroupTemplateLineRoleChanged();
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
