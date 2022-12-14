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
    /// There are no comments for HazardousMaterialTransportCategorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("HazardousMaterialTransportCategorySingle")]
    public partial class HazardousMaterialTransportCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<HazardousMaterialTransportCategory>
    {
        /// <summary>
        /// Initialize a new HazardousMaterialTransportCategorySingle object.
        /// </summary>
        public HazardousMaterialTransportCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new HazardousMaterialTransportCategorySingle object.
        /// </summary>
        public HazardousMaterialTransportCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new HazardousMaterialTransportCategorySingle object.
        /// </summary>
        public HazardousMaterialTransportCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<HazardousMaterialTransportCategory> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for HazardousMaterialTransportCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TransportCategoryCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TransportCategoryCode")]
    [global::Microsoft.OData.Client.EntitySet("HazardousMaterialTransportCategories")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("HazardousMaterialTransportCategory")]
    public partial class HazardousMaterialTransportCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new HazardousMaterialTransportCategory object.
        /// </summary>
        /// <param name="transportCategoryCode">Initial value of TransportCategoryCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static HazardousMaterialTransportCategory CreateHazardousMaterialTransportCategory(string transportCategoryCode)
        {
            HazardousMaterialTransportCategory hazardousMaterialTransportCategory = new HazardousMaterialTransportCategory();
            hazardousMaterialTransportCategory.TransportCategoryCode = transportCategoryCode;
            return hazardousMaterialTransportCategory;
        }
        /// <summary>
        /// There are no comments for Property TransportCategoryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportCategoryCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransportCategoryCode is required.")]
        public virtual string TransportCategoryCode
        {
            get
            {
                return this._TransportCategoryCode;
            }
            set
            {
                this.OnTransportCategoryCodeChanging(value);
                this._TransportCategoryCode = value;
                this.OnTransportCategoryCodeChanged();
                this.OnPropertyChanged("TransportCategoryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportCategoryCode;
        partial void OnTransportCategoryCodeChanging(string value);
        partial void OnTransportCategoryCodeChanged();
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
