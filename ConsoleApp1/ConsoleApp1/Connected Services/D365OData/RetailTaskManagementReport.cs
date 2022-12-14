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
    /// There are no comments for RetailTaskManagementReportSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTaskManagementReportSingle")]
    public partial class RetailTaskManagementReportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTaskManagementReport>
    {
        /// <summary>
        /// Initialize a new RetailTaskManagementReportSingle object.
        /// </summary>
        public RetailTaskManagementReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTaskManagementReportSingle object.
        /// </summary>
        public RetailTaskManagementReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTaskManagementReportSingle object.
        /// </summary>
        public RetailTaskManagementReportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTaskManagementReport> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTaskManagementReport in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Process_ProcessId
    /// TaskId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Process_ProcessId", "TaskId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTaskManagementReports")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTaskManagementReport")]
    public partial class RetailTaskManagementReport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTaskManagementReport object.
        /// </summary>
        /// <param name="process_ProcessId">Initial value of Process_ProcessId.</param>
        /// <param name="taskId">Initial value of TaskId.</param>
        /// <param name="process_TargetDate">Initial value of Process_TargetDate.</param>
        /// <param name="completionDateTime">Initial value of CompletionDateTime.</param>
        /// <param name="dueDate">Initial value of DueDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTaskManagementReport CreateRetailTaskManagementReport(global::System.Guid process_ProcessId, global::System.Guid taskId, global::System.DateTimeOffset process_TargetDate, global::System.DateTimeOffset completionDateTime, global::System.DateTimeOffset dueDate)
        {
            RetailTaskManagementReport retailTaskManagementReport = new RetailTaskManagementReport();
            retailTaskManagementReport.Process_ProcessId = process_ProcessId;
            retailTaskManagementReport.TaskId = taskId;
            retailTaskManagementReport.Process_TargetDate = process_TargetDate;
            retailTaskManagementReport.CompletionDateTime = completionDateTime;
            retailTaskManagementReport.DueDate = dueDate;
            return retailTaskManagementReport;
        }
        /// <summary>
        /// There are no comments for Property Process_ProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Process_ProcessId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Process_ProcessId is required.")]
        public virtual global::System.Guid Process_ProcessId
        {
            get
            {
                return this._Process_ProcessId;
            }
            set
            {
                this.OnProcess_ProcessIdChanging(value);
                this._Process_ProcessId = value;
                this.OnProcess_ProcessIdChanged();
                this.OnPropertyChanged("Process_ProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _Process_ProcessId;
        partial void OnProcess_ProcessIdChanging(global::System.Guid value);
        partial void OnProcess_ProcessIdChanged();
        /// <summary>
        /// There are no comments for Property TaskId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaskId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaskId is required.")]
        public virtual global::System.Guid TaskId
        {
            get
            {
                return this._TaskId;
            }
            set
            {
                this.OnTaskIdChanging(value);
                this._TaskId = value;
                this.OnTaskIdChanged();
                this.OnPropertyChanged("TaskId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _TaskId;
        partial void OnTaskIdChanging(global::System.Guid value);
        partial void OnTaskIdChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property Process_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Process_Name")]
        public virtual string Process_Name
        {
            get
            {
                return this._Process_Name;
            }
            set
            {
                this.OnProcess_NameChanging(value);
                this._Process_Name = value;
                this.OnProcess_NameChanged();
                this.OnPropertyChanged("Process_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Process_Name;
        partial void OnProcess_NameChanging(string value);
        partial void OnProcess_NameChanged();
        /// <summary>
        /// There are no comments for Property Process_TargetDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Process_TargetDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Process_TargetDate is required.")]
        public virtual global::System.DateTimeOffset Process_TargetDate
        {
            get
            {
                return this._Process_TargetDate;
            }
            set
            {
                this.OnProcess_TargetDateChanging(value);
                this._Process_TargetDate = value;
                this.OnProcess_TargetDateChanged();
                this.OnPropertyChanged("Process_TargetDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Process_TargetDate;
        partial void OnProcess_TargetDateChanging(global::System.DateTimeOffset value);
        partial void OnProcess_TargetDateChanged();
        /// <summary>
        /// There are no comments for Property Process_Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Process_Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessHeaderStatus> Process_Status
        {
            get
            {
                return this._Process_Status;
            }
            set
            {
                this.OnProcess_StatusChanging(value);
                this._Process_Status = value;
                this.OnProcess_StatusChanged();
                this.OnPropertyChanged("Process_Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessHeaderStatus> _Process_Status;
        partial void OnProcess_StatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessHeaderStatus> value);
        partial void OnProcess_StatusChanged();
        /// <summary>
        /// There are no comments for Property AssignedWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedWorker")]
        public virtual string AssignedWorker
        {
            get
            {
                return this._AssignedWorker;
            }
            set
            {
                this.OnAssignedWorkerChanging(value);
                this._AssignedWorker = value;
                this.OnAssignedWorkerChanged();
                this.OnPropertyChanged("AssignedWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssignedWorker;
        partial void OnAssignedWorkerChanging(string value);
        partial void OnAssignedWorkerChanged();
        /// <summary>
        /// There are no comments for Property CompletionDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompletionDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompletionDateTime is required.")]
        public virtual global::System.DateTimeOffset CompletionDateTime
        {
            get
            {
                return this._CompletionDateTime;
            }
            set
            {
                this.OnCompletionDateTimeChanging(value);
                this._CompletionDateTime = value;
                this.OnCompletionDateTimeChanged();
                this.OnPropertyChanged("CompletionDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletionDateTime;
        partial void OnCompletionDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCompletionDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ResolvedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResolvedBy")]
        public virtual string ResolvedBy
        {
            get
            {
                return this._ResolvedBy;
            }
            set
            {
                this.OnResolvedByChanging(value);
                this._ResolvedBy = value;
                this.OnResolvedByChanged();
                this.OnPropertyChanged("ResolvedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResolvedBy;
        partial void OnResolvedByChanging(string value);
        partial void OnResolvedByChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DueDate is required.")]
        public virtual global::System.DateTimeOffset DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DueDate;
        partial void OnDueDateChanging(global::System.DateTimeOffset value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property Process_Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Process_Worker")]
        public virtual string Process_Worker
        {
            get
            {
                return this._Process_Worker;
            }
            set
            {
                this.OnProcess_WorkerChanging(value);
                this._Process_Worker = value;
                this.OnProcess_WorkerChanged();
                this.OnPropertyChanged("Process_Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Process_Worker;
        partial void OnProcess_WorkerChanging(string value);
        partial void OnProcess_WorkerChanged();
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
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessTaskStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessTaskStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BusinessProcessTaskStatus> value);
        partial void OnStatusChanged();
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
