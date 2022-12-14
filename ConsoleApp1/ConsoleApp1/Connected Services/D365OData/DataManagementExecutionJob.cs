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
    /// There are no comments for DataManagementExecutionJobSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DataManagementExecutionJobSingle")]
    public partial class DataManagementExecutionJobSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementExecutionJob>
    {
        /// <summary>
        /// Initialize a new DataManagementExecutionJobSingle object.
        /// </summary>
        public DataManagementExecutionJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementExecutionJobSingle object.
        /// </summary>
        public DataManagementExecutionJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementExecutionJobSingle object.
        /// </summary>
        public DataManagementExecutionJobSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementExecutionJob> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail> Details
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Details == null))
                {
                    this._Details = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail>(GetPath("Details"));
                }
                return this._Details;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail> _Details;
    }
    /// <summary>
    /// There are no comments for DataManagementExecutionJob in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobId")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementExecutionJobs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DataManagementExecutionJob")]
    public partial class DataManagementExecutionJob : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementExecutionJob object.
        /// </summary>
        /// <param name="jobId">Initial value of JobId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementExecutionJob CreateDataManagementExecutionJob(string jobId)
        {
            DataManagementExecutionJob dataManagementExecutionJob = new DataManagementExecutionJob();
            dataManagementExecutionJob.JobId = jobId;
            return dataManagementExecutionJob;
        }
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobId is required.")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
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
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail> Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail> _Details = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementExecutionJobDetail> value);
        partial void OnDetailsChanged();
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
