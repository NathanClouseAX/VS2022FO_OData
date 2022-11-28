﻿//------------------------------------------------------------------------------
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
    /// There are no comments for JobPreferredEducationDisciplineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("JobPreferredEducationDisciplineSingle")]
    public partial class JobPreferredEducationDisciplineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobPreferredEducationDiscipline>
    {
        /// <summary>
        /// Initialize a new JobPreferredEducationDisciplineSingle object.
        /// </summary>
        public JobPreferredEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobPreferredEducationDisciplineSingle object.
        /// </summary>
        public JobPreferredEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobPreferredEducationDisciplineSingle object.
        /// </summary>
        public JobPreferredEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobPreferredEducationDiscipline> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationDiscipline")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle EducationDiscipline
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDiscipline == null))
                {
                    this._EducationDiscipline = new global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle(this.Context, GetPath("EducationDiscipline"));
                }
                return this._EducationDiscipline;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle _EducationDiscipline;
        /// <summary>
        /// There are no comments for Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Job")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobSingle Job
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Job == null))
                {
                    this._Job = new global::Microsoft.Dynamics.DataEntities.JobSingle(this.Context, GetPath("Job"));
                }
                return this._Job;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobSingle _Job;
    }
    /// <summary>
    /// There are no comments for JobPreferredEducationDiscipline in the schema.
    /// </summary>
    /// <KeyProperties>
    /// JobId
    /// EducationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobId", "EducationId")]
    [global::Microsoft.OData.Client.EntitySet("JobPreferredEducationDisciplines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("JobPreferredEducationDiscipline")]
    public partial class JobPreferredEducationDiscipline : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobPreferredEducationDiscipline object.
        /// </summary>
        /// <param name="jobId">Initial value of JobId.</param>
        /// <param name="educationId">Initial value of EducationId.</param>
        /// <param name="educationDiscipline">Initial value of EducationDiscipline.</param>
        /// <param name="job">Initial value of Job.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobPreferredEducationDiscipline CreateJobPreferredEducationDiscipline(string jobId, string educationId, global::Microsoft.Dynamics.DataEntities.EducationDiscipline educationDiscipline, global::Microsoft.Dynamics.DataEntities.Job job)
        {
            JobPreferredEducationDiscipline jobPreferredEducationDiscipline = new JobPreferredEducationDiscipline();
            jobPreferredEducationDiscipline.JobId = jobId;
            jobPreferredEducationDiscipline.EducationId = educationId;
            if ((educationDiscipline == null))
            {
                throw new global::System.ArgumentNullException("educationDiscipline");
            }
            jobPreferredEducationDiscipline.EducationDiscipline = educationDiscipline;
            if ((job == null))
            {
                throw new global::System.ArgumentNullException("job");
            }
            jobPreferredEducationDiscipline.Job = job;
            return jobPreferredEducationDiscipline;
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
        /// There are no comments for Property EducationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EducationId is required.")]
        public virtual string EducationId
        {
            get
            {
                return this._EducationId;
            }
            set
            {
                this.OnEducationIdChanging(value);
                this._EducationId = value;
                this.OnEducationIdChanged();
                this.OnPropertyChanged("EducationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationId;
        partial void OnEducationIdChanging(string value);
        partial void OnEducationIdChanged();
        /// <summary>
        /// There are no comments for Property Importance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Importance")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> Importance
        {
            get
            {
                return this._Importance;
            }
            set
            {
                this.OnImportanceChanging(value);
                this._Importance = value;
                this.OnImportanceChanged();
                this.OnPropertyChanged("Importance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> _Importance;
        partial void OnImportanceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> value);
        partial void OnImportanceChanged();
        /// <summary>
        /// There are no comments for Property EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EducationDiscipline")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EducationDiscipline is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDiscipline EducationDiscipline
        {
            get
            {
                return this._EducationDiscipline;
            }
            set
            {
                this.OnEducationDisciplineChanging(value);
                this._EducationDiscipline = value;
                this.OnEducationDisciplineChanged();
                this.OnPropertyChanged("EducationDiscipline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDiscipline _EducationDiscipline;
        partial void OnEducationDisciplineChanging(global::Microsoft.Dynamics.DataEntities.EducationDiscipline value);
        partial void OnEducationDisciplineChanged();
        /// <summary>
        /// There are no comments for Property Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Job")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Job is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Job Job
        {
            get
            {
                return this._Job;
            }
            set
            {
                this.OnJobChanging(value);
                this._Job = value;
                this.OnJobChanged();
                this.OnPropertyChanged("Job");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Job _Job;
        partial void OnJobChanging(global::Microsoft.Dynamics.DataEntities.Job value);
        partial void OnJobChanged();
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
