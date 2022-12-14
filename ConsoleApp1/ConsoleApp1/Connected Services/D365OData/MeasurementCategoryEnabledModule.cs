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
    /// There are no comments for MeasurementCategoryEnabledModuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MeasurementCategoryEnabledModuleSingle")]
    public partial class MeasurementCategoryEnabledModuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MeasurementCategoryEnabledModule>
    {
        /// <summary>
        /// Initialize a new MeasurementCategoryEnabledModuleSingle object.
        /// </summary>
        public MeasurementCategoryEnabledModuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MeasurementCategoryEnabledModuleSingle object.
        /// </summary>
        public MeasurementCategoryEnabledModuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MeasurementCategoryEnabledModuleSingle object.
        /// </summary>
        public MeasurementCategoryEnabledModuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MeasurementCategoryEnabledModule> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MeasurementCategoryEnabledModule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Module
    /// CompanyId
    /// CategoryId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Module", "CompanyId", "CategoryId")]
    [global::Microsoft.OData.Client.EntitySet("MeasurementCategoryEnabledModules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MeasurementCategoryEnabledModule")]
    public partial class MeasurementCategoryEnabledModule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MeasurementCategoryEnabledModule object.
        /// </summary>
        /// <param name="companyId">Initial value of CompanyId.</param>
        /// <param name="categoryId">Initial value of CategoryId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MeasurementCategoryEnabledModule CreateMeasurementCategoryEnabledModule(string companyId, string categoryId)
        {
            MeasurementCategoryEnabledModule measurementCategoryEnabledModule = new MeasurementCategoryEnabledModule();
            measurementCategoryEnabledModule.CompanyId = companyId;
            measurementCategoryEnabledModule.CategoryId = categoryId;
            return measurementCategoryEnabledModule;
        }
        /// <summary>
        /// There are no comments for Property Module in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Module")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MeasurementCategoryEnabledForModule> Module
        {
            get
            {
                return this._Module;
            }
            set
            {
                this.OnModuleChanging(value);
                this._Module = value;
                this.OnModuleChanged();
                this.OnPropertyChanged("Module");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MeasurementCategoryEnabledForModule> _Module;
        partial void OnModuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MeasurementCategoryEnabledForModule> value);
        partial void OnModuleChanged();
        /// <summary>
        /// There are no comments for Property CompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompanyId is required.")]
        public virtual string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                this.OnCompanyIdChanging(value);
                this._CompanyId = value;
                this.OnCompanyIdChanged();
                this.OnPropertyChanged("CompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyId;
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryId is required.")]
        public virtual string CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryId;
        partial void OnCategoryIdChanging(string value);
        partial void OnCategoryIdChanged();
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
