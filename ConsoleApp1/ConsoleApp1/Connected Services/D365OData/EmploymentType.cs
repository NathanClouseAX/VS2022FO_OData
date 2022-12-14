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
    /// There are no comments for EmploymentTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentTypeSingle")]
    public partial class EmploymentTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentType>
    {
        /// <summary>
        /// Initialize a new EmploymentTypeSingle object.
        /// </summary>
        public EmploymentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmploymentTypeSingle object.
        /// </summary>
        public EmploymentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmploymentTypeSingle object.
        /// </summary>
        public EmploymentTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EmploymentType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EmploymentTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EmploymentTypeId")]
    [global::Microsoft.OData.Client.EntitySet("EmploymentTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentType")]
    public partial class EmploymentType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmploymentType object.
        /// </summary>
        /// <param name="employmentTypeId">Initial value of EmploymentTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmploymentType CreateEmploymentType(string employmentTypeId)
        {
            EmploymentType employmentType = new EmploymentType();
            employmentType.EmploymentTypeId = employmentTypeId;
            return employmentType;
        }
        /// <summary>
        /// There are no comments for Property EmploymentTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentTypeId is required.")]
        public virtual string EmploymentTypeId
        {
            get
            {
                return this._EmploymentTypeId;
            }
            set
            {
                this.OnEmploymentTypeIdChanging(value);
                this._EmploymentTypeId = value;
                this.OnEmploymentTypeIdChanged();
                this.OnPropertyChanged("EmploymentTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmploymentTypeId;
        partial void OnEmploymentTypeIdChanging(string value);
        partial void OnEmploymentTypeIdChanged();
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
