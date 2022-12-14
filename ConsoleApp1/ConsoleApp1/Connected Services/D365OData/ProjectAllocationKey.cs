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
    /// There are no comments for ProjectAllocationKeySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectAllocationKeySingle")]
    public partial class ProjectAllocationKeySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectAllocationKey>
    {
        /// <summary>
        /// Initialize a new ProjectAllocationKeySingle object.
        /// </summary>
        public ProjectAllocationKeySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectAllocationKeySingle object.
        /// </summary>
        public ProjectAllocationKeySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectAllocationKeySingle object.
        /// </summary>
        public ProjectAllocationKeySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectAllocationKey> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjectAllocationKey in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AllocationKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AllocationKey")]
    [global::Microsoft.OData.Client.EntitySet("ProjectAllocationKeys")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectAllocationKey")]
    public partial class ProjectAllocationKey : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectAllocationKey object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="allocationKey">Initial value of AllocationKey.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectAllocationKey CreateProjectAllocationKey(string dataAreaId, string allocationKey)
        {
            ProjectAllocationKey projectAllocationKey = new ProjectAllocationKey();
            projectAllocationKey.DataAreaId = dataAreaId;
            projectAllocationKey.AllocationKey = allocationKey;
            return projectAllocationKey;
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
        /// There are no comments for Property AllocationKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AllocationKey is required.")]
        public virtual string AllocationKey
        {
            get
            {
                return this._AllocationKey;
            }
            set
            {
                this.OnAllocationKeyChanging(value);
                this._AllocationKey = value;
                this.OnAllocationKeyChanged();
                this.OnPropertyChanged("AllocationKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllocationKey;
        partial void OnAllocationKeyChanging(string value);
        partial void OnAllocationKeyChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
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
