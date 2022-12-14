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
    /// There are no comments for DocumentFacilityGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentFacilityGroupSingle")]
    public partial class DocumentFacilityGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentFacilityGroup>
    {
        /// <summary>
        /// Initialize a new DocumentFacilityGroupSingle object.
        /// </summary>
        public DocumentFacilityGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DocumentFacilityGroupSingle object.
        /// </summary>
        public DocumentFacilityGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DocumentFacilityGroupSingle object.
        /// </summary>
        public DocumentFacilityGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentFacilityGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FacilityGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FacilityGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType> FacilityGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FacilityGroups == null))
                {
                    this._FacilityGroups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType>(GetPath("FacilityGroups"));
                }
                return this._FacilityGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType> _FacilityGroups;
    }
    /// <summary>
    /// There are no comments for DocumentFacilityGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FacilityGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FacilityGroup")]
    [global::Microsoft.OData.Client.EntitySet("DocumentFacilityGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentFacilityGroup")]
    public partial class DocumentFacilityGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DocumentFacilityGroup object.
        /// </summary>
        /// <param name="facilityGroup">Initial value of FacilityGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DocumentFacilityGroup CreateDocumentFacilityGroup(string facilityGroup)
        {
            DocumentFacilityGroup documentFacilityGroup = new DocumentFacilityGroup();
            documentFacilityGroup.FacilityGroup = facilityGroup;
            return documentFacilityGroup;
        }
        /// <summary>
        /// There are no comments for Property FacilityGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FacilityGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FacilityGroup is required.")]
        public virtual string FacilityGroup
        {
            get
            {
                return this._FacilityGroup;
            }
            set
            {
                this.OnFacilityGroupChanging(value);
                this._FacilityGroup = value;
                this.OnFacilityGroupChanged();
                this.OnPropertyChanged("FacilityGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FacilityGroup;
        partial void OnFacilityGroupChanging(string value);
        partial void OnFacilityGroupChanged();
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
        /// There are no comments for Property FacilityGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FacilityGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType> FacilityGroups
        {
            get
            {
                return this._FacilityGroups;
            }
            set
            {
                this.OnFacilityGroupsChanging(value);
                this._FacilityGroups = value;
                this.OnFacilityGroupsChanged();
                this.OnPropertyChanged("FacilityGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType> _FacilityGroups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFacilityGroupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DocumentFacilityType> value);
        partial void OnFacilityGroupsChanged();
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
