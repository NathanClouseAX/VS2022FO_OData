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
    /// There are no comments for LeasingGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeasingGroupSingle")]
    public partial class LeasingGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeasingGroup>
    {
        /// <summary>
        /// Initialize a new LeasingGroupSingle object.
        /// </summary>
        public LeasingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeasingGroupSingle object.
        /// </summary>
        public LeasingGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeasingGroupSingle object.
        /// </summary>
        public LeasingGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeasingGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LeasingGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LeaseGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaseGroup")]
    [global::Microsoft.OData.Client.EntitySet("LeasingGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeasingGroup")]
    public partial class LeasingGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeasingGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="leaseGroup">Initial value of LeaseGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeasingGroup CreateLeasingGroup(string dataAreaId, string leaseGroup)
        {
            LeasingGroup leasingGroup = new LeasingGroup();
            leasingGroup.DataAreaId = dataAreaId;
            leasingGroup.LeaseGroup = leaseGroup;
            return leasingGroup;
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
        /// There are no comments for Property LeaseGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaseGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseGroup is required.")]
        public virtual string LeaseGroup
        {
            get
            {
                return this._LeaseGroup;
            }
            set
            {
                this.OnLeaseGroupChanging(value);
                this._LeaseGroup = value;
                this.OnLeaseGroupChanged();
                this.OnPropertyChanged("LeaseGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaseGroup;
        partial void OnLeaseGroupChanging(string value);
        partial void OnLeaseGroupChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
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
