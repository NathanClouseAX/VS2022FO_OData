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
    /// There are no comments for WorkerEnrolledAccrualInquirySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledAccrualInquirySingle")]
    public partial class WorkerEnrolledAccrualInquirySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledAccrualInquiry>
    {
        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualInquirySingle object.
        /// </summary>
        public WorkerEnrolledAccrualInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualInquirySingle object.
        /// </summary>
        public WorkerEnrolledAccrualInquirySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerEnrolledAccrualInquirySingle object.
        /// </summary>
        public WorkerEnrolledAccrualInquirySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerEnrolledAccrualInquiry> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlan")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle AccrualPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualPlan == null))
                {
                    this._AccrualPlan = new global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle(this.Context, GetPath("AccrualPlan"));
                }
                return this._AccrualPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle _AccrualPlan;
    }
    /// <summary>
    /// There are no comments for WorkerEnrolledAccrualInquiry in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// WorkerName
    /// AccrualId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WorkerName", "AccrualId")]
    [global::Microsoft.OData.Client.EntitySet("WorkerEnrolledAccrualInquiries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledAccrualInquiry")]
    public partial class WorkerEnrolledAccrualInquiry : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerEnrolledAccrualInquiry object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="workerName">Initial value of WorkerName.</param>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="totalUsed">Initial value of TotalUsed.</param>
        /// <param name="totalAvailableHours">Initial value of TotalAvailableHours.</param>
        /// <param name="accrualYearStartDate">Initial value of AccrualYearStartDate.</param>
        /// <param name="totalPendingUsage">Initial value of TotalPendingUsage.</param>
        /// <param name="totalAccrued">Initial value of TotalAccrued.</param>
        /// <param name="totalCarryOver">Initial value of TotalCarryOver.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="accrualPlan">Initial value of AccrualPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerEnrolledAccrualInquiry CreateWorkerEnrolledAccrualInquiry(string dataAreaId, 
                    string workerName, 
                    string accrualId, 
                    decimal totalUsed, 
                    decimal totalAvailableHours, 
                    global::System.DateTimeOffset accrualYearStartDate, 
                    decimal totalPendingUsage, 
                    decimal totalAccrued, 
                    decimal totalCarryOver, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.AccrualPlan accrualPlan)
        {
            WorkerEnrolledAccrualInquiry workerEnrolledAccrualInquiry = new WorkerEnrolledAccrualInquiry();
            workerEnrolledAccrualInquiry.DataAreaId = dataAreaId;
            workerEnrolledAccrualInquiry.WorkerName = workerName;
            workerEnrolledAccrualInquiry.AccrualId = accrualId;
            workerEnrolledAccrualInquiry.TotalUsed = totalUsed;
            workerEnrolledAccrualInquiry.TotalAvailableHours = totalAvailableHours;
            workerEnrolledAccrualInquiry.AccrualYearStartDate = accrualYearStartDate;
            workerEnrolledAccrualInquiry.TotalPendingUsage = totalPendingUsage;
            workerEnrolledAccrualInquiry.TotalAccrued = totalAccrued;
            workerEnrolledAccrualInquiry.TotalCarryOver = totalCarryOver;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerEnrolledAccrualInquiry.Worker = worker;
            if ((accrualPlan == null))
            {
                throw new global::System.ArgumentNullException("accrualPlan");
            }
            workerEnrolledAccrualInquiry.AccrualPlan = accrualPlan;
            return workerEnrolledAccrualInquiry;
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
        /// There are no comments for Property WorkerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerName is required.")]
        public virtual string WorkerName
        {
            get
            {
                return this._WorkerName;
            }
            set
            {
                this.OnWorkerNameChanging(value);
                this._WorkerName = value;
                this.OnWorkerNameChanged();
                this.OnPropertyChanged("WorkerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerName;
        partial void OnWorkerNameChanging(string value);
        partial void OnWorkerNameChanged();
        /// <summary>
        /// There are no comments for Property AccrualId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualId is required.")]
        public virtual string AccrualId
        {
            get
            {
                return this._AccrualId;
            }
            set
            {
                this.OnAccrualIdChanging(value);
                this._AccrualId = value;
                this.OnAccrualIdChanged();
                this.OnPropertyChanged("AccrualId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccrualId;
        partial void OnAccrualIdChanging(string value);
        partial void OnAccrualIdChanged();
        /// <summary>
        /// There are no comments for Property TotalUsed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalUsed")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalUsed is required.")]
        public virtual decimal TotalUsed
        {
            get
            {
                return this._TotalUsed;
            }
            set
            {
                this.OnTotalUsedChanging(value);
                this._TotalUsed = value;
                this.OnTotalUsedChanged();
                this.OnPropertyChanged("TotalUsed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalUsed;
        partial void OnTotalUsedChanging(decimal value);
        partial void OnTotalUsedChanged();
        /// <summary>
        /// There are no comments for Property TotalAvailableHours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAvailableHours")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalAvailableHours is required.")]
        public virtual decimal TotalAvailableHours
        {
            get
            {
                return this._TotalAvailableHours;
            }
            set
            {
                this.OnTotalAvailableHoursChanging(value);
                this._TotalAvailableHours = value;
                this.OnTotalAvailableHoursChanged();
                this.OnPropertyChanged("TotalAvailableHours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalAvailableHours;
        partial void OnTotalAvailableHoursChanging(decimal value);
        partial void OnTotalAvailableHoursChanged();
        /// <summary>
        /// There are no comments for Property AccrualYearStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualYearStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualYearStartDate is required.")]
        public virtual global::System.DateTimeOffset AccrualYearStartDate
        {
            get
            {
                return this._AccrualYearStartDate;
            }
            set
            {
                this.OnAccrualYearStartDateChanging(value);
                this._AccrualYearStartDate = value;
                this.OnAccrualYearStartDateChanged();
                this.OnPropertyChanged("AccrualYearStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccrualYearStartDate;
        partial void OnAccrualYearStartDateChanging(global::System.DateTimeOffset value);
        partial void OnAccrualYearStartDateChanged();
        /// <summary>
        /// There are no comments for Property TotalPendingUsage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalPendingUsage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalPendingUsage is required.")]
        public virtual decimal TotalPendingUsage
        {
            get
            {
                return this._TotalPendingUsage;
            }
            set
            {
                this.OnTotalPendingUsageChanging(value);
                this._TotalPendingUsage = value;
                this.OnTotalPendingUsageChanged();
                this.OnPropertyChanged("TotalPendingUsage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalPendingUsage;
        partial void OnTotalPendingUsageChanging(decimal value);
        partial void OnTotalPendingUsageChanged();
        /// <summary>
        /// There are no comments for Property TotalAccrued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAccrued")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalAccrued is required.")]
        public virtual decimal TotalAccrued
        {
            get
            {
                return this._TotalAccrued;
            }
            set
            {
                this.OnTotalAccruedChanging(value);
                this._TotalAccrued = value;
                this.OnTotalAccruedChanged();
                this.OnPropertyChanged("TotalAccrued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalAccrued;
        partial void OnTotalAccruedChanging(decimal value);
        partial void OnTotalAccruedChanged();
        /// <summary>
        /// There are no comments for Property TotalCarryOver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalCarryOver")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalCarryOver is required.")]
        public virtual decimal TotalCarryOver
        {
            get
            {
                return this._TotalCarryOver;
            }
            set
            {
                this.OnTotalCarryOverChanging(value);
                this._TotalCarryOver = value;
                this.OnTotalCarryOverChanged();
                this.OnPropertyChanged("TotalCarryOver");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalCarryOver;
        partial void OnTotalCarryOverChanging(decimal value);
        partial void OnTotalCarryOverChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Worker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPlan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualPlan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlan AccrualPlan
        {
            get
            {
                return this._AccrualPlan;
            }
            set
            {
                this.OnAccrualPlanChanging(value);
                this._AccrualPlan = value;
                this.OnAccrualPlanChanged();
                this.OnPropertyChanged("AccrualPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlan _AccrualPlan;
        partial void OnAccrualPlanChanging(global::Microsoft.Dynamics.DataEntities.AccrualPlan value);
        partial void OnAccrualPlanChanged();
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
