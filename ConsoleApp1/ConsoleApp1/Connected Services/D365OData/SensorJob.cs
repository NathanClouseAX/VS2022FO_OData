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
    /// There are no comments for SensorJobSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorJobSingle")]
    public partial class SensorJobSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SensorJob>
    {
        /// <summary>
        /// Initialize a new SensorJobSingle object.
        /// </summary>
        public SensorJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SensorJobSingle object.
        /// </summary>
        public SensorJobSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SensorJobSingle object.
        /// </summary>
        public SensorJobSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SensorJob> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SensorJob in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SensorId
    /// JobId
    /// JobDataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SensorId", "JobId", "JobDataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("SensorJobs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorJob")]
    public partial class SensorJob : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SensorJob object.
        /// </summary>
        /// <param name="sensorId">Initial value of SensorId.</param>
        /// <param name="jobId">Initial value of JobId.</param>
        /// <param name="jobDataAreaId">Initial value of JobDataAreaId.</param>
        /// <param name="machineNotReportingThreshold">Initial value of MachineNotReportingThreshold.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SensorJob CreateSensorJob(string sensorId, string jobId, string jobDataAreaId, int machineNotReportingThreshold)
        {
            SensorJob sensorJob = new SensorJob();
            sensorJob.SensorId = sensorId;
            sensorJob.JobId = jobId;
            sensorJob.JobDataAreaId = jobDataAreaId;
            sensorJob.MachineNotReportingThreshold = machineNotReportingThreshold;
            return sensorJob;
        }
        /// <summary>
        /// There are no comments for Property SensorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SensorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SensorId is required.")]
        public virtual string SensorId
        {
            get
            {
                return this._SensorId;
            }
            set
            {
                this.OnSensorIdChanging(value);
                this._SensorId = value;
                this.OnSensorIdChanged();
                this.OnPropertyChanged("SensorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SensorId;
        partial void OnSensorIdChanging(string value);
        partial void OnSensorIdChanged();
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
        /// There are no comments for Property JobDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobDataAreaId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JobDataAreaId is required.")]
        public virtual string JobDataAreaId
        {
            get
            {
                return this._JobDataAreaId;
            }
            set
            {
                this.OnJobDataAreaIdChanging(value);
                this._JobDataAreaId = value;
                this.OnJobDataAreaIdChanged();
                this.OnPropertyChanged("JobDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobDataAreaId;
        partial void OnJobDataAreaIdChanging(string value);
        partial void OnJobDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property MachineNotReportingThreshold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MachineNotReportingThreshold")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MachineNotReportingThreshold is required.")]
        public virtual int MachineNotReportingThreshold
        {
            get
            {
                return this._MachineNotReportingThreshold;
            }
            set
            {
                this.OnMachineNotReportingThresholdChanging(value);
                this._MachineNotReportingThreshold = value;
                this.OnMachineNotReportingThresholdChanged();
                this.OnPropertyChanged("MachineNotReportingThreshold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MachineNotReportingThreshold;
        partial void OnMachineNotReportingThresholdChanging(int value);
        partial void OnMachineNotReportingThresholdChanged();
        /// <summary>
        /// There are no comments for Property IsJobInProgress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsJobInProgress")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsJobInProgress
        {
            get
            {
                return this._IsJobInProgress;
            }
            set
            {
                this.OnIsJobInProgressChanging(value);
                this._IsJobInProgress = value;
                this.OnIsJobInProgressChanged();
                this.OnPropertyChanged("IsJobInProgress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsJobInProgress;
        partial void OnIsJobInProgressChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsJobInProgressChanged();
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