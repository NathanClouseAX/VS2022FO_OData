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
    /// There are no comments for EFDocTechResponsibleInformationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EFDocTechResponsibleInformationSingle")]
    public partial class EFDocTechResponsibleInformationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EFDocTechResponsibleInformation>
    {
        /// <summary>
        /// Initialize a new EFDocTechResponsibleInformationSingle object.
        /// </summary>
        public EFDocTechResponsibleInformationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EFDocTechResponsibleInformationSingle object.
        /// </summary>
        public EFDocTechResponsibleInformationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EFDocTechResponsibleInformationSingle object.
        /// </summary>
        public EFDocTechResponsibleInformationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EFDocTechResponsibleInformation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EFDocTechResponsibleInformation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// State
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "State")]
    [global::Microsoft.OData.Client.EntitySet("EFDocTechResponsibleInformations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EFDocTechResponsibleInformation")]
    public partial class EFDocTechResponsibleInformation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EFDocTechResponsibleInformation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="state">Initial value of State.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EFDocTechResponsibleInformation CreateEFDocTechResponsibleInformation(string dataAreaId, string state)
        {
            EFDocTechResponsibleInformation eFDocTechResponsibleInformation = new EFDocTechResponsibleInformation();
            eFDocTechResponsibleInformation.DataAreaId = dataAreaId;
            eFDocTechResponsibleInformation.State = state;
            return eFDocTechResponsibleInformation;
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
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsibleCSRTId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsibleCSRTId")]
        public virtual string TechnicalResponsibleCSRTId
        {
            get
            {
                return this._TechnicalResponsibleCSRTId;
            }
            set
            {
                this.OnTechnicalResponsibleCSRTIdChanging(value);
                this._TechnicalResponsibleCSRTId = value;
                this.OnTechnicalResponsibleCSRTIdChanged();
                this.OnPropertyChanged("TechnicalResponsibleCSRTId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsibleCSRTId;
        partial void OnTechnicalResponsibleCSRTIdChanging(string value);
        partial void OnTechnicalResponsibleCSRTIdChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsibleContactName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsibleContactName")]
        public virtual string TechnicalResponsibleContactName
        {
            get
            {
                return this._TechnicalResponsibleContactName;
            }
            set
            {
                this.OnTechnicalResponsibleContactNameChanging(value);
                this._TechnicalResponsibleContactName = value;
                this.OnTechnicalResponsibleContactNameChanged();
                this.OnPropertyChanged("TechnicalResponsibleContactName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsibleContactName;
        partial void OnTechnicalResponsibleContactNameChanging(string value);
        partial void OnTechnicalResponsibleContactNameChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsibleCSRT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsibleCSRT")]
        public virtual string TechnicalResponsibleCSRT
        {
            get
            {
                return this._TechnicalResponsibleCSRT;
            }
            set
            {
                this.OnTechnicalResponsibleCSRTChanging(value);
                this._TechnicalResponsibleCSRT = value;
                this.OnTechnicalResponsibleCSRTChanged();
                this.OnPropertyChanged("TechnicalResponsibleCSRT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsibleCSRT;
        partial void OnTechnicalResponsibleCSRTChanging(string value);
        partial void OnTechnicalResponsibleCSRTChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsiblePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsiblePhone")]
        public virtual string TechnicalResponsiblePhone
        {
            get
            {
                return this._TechnicalResponsiblePhone;
            }
            set
            {
                this.OnTechnicalResponsiblePhoneChanging(value);
                this._TechnicalResponsiblePhone = value;
                this.OnTechnicalResponsiblePhoneChanged();
                this.OnPropertyChanged("TechnicalResponsiblePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsiblePhone;
        partial void OnTechnicalResponsiblePhoneChanging(string value);
        partial void OnTechnicalResponsiblePhoneChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsibleCNPJ in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsibleCNPJ")]
        public virtual string TechnicalResponsibleCNPJ
        {
            get
            {
                return this._TechnicalResponsibleCNPJ;
            }
            set
            {
                this.OnTechnicalResponsibleCNPJChanging(value);
                this._TechnicalResponsibleCNPJ = value;
                this.OnTechnicalResponsibleCNPJChanged();
                this.OnPropertyChanged("TechnicalResponsibleCNPJ");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsibleCNPJ;
        partial void OnTechnicalResponsibleCNPJChanging(string value);
        partial void OnTechnicalResponsibleCNPJChanged();
        /// <summary>
        /// There are no comments for Property TechnicalResponsibleEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalResponsibleEmail")]
        public virtual string TechnicalResponsibleEmail
        {
            get
            {
                return this._TechnicalResponsibleEmail;
            }
            set
            {
                this.OnTechnicalResponsibleEmailChanging(value);
                this._TechnicalResponsibleEmail = value;
                this.OnTechnicalResponsibleEmailChanged();
                this.OnPropertyChanged("TechnicalResponsibleEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalResponsibleEmail;
        partial void OnTechnicalResponsibleEmailChanging(string value);
        partial void OnTechnicalResponsibleEmailChanged();
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
