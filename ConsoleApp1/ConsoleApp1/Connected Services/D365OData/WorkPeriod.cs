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
    /// There are no comments for WorkPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkPeriodSingle")]
    public partial class WorkPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkPeriod>
    {
        /// <summary>
        /// Initialize a new WorkPeriodSingle object.
        /// </summary>
        public WorkPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkPeriodSingle object.
        /// </summary>
        public WorkPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkPeriodSingle object.
        /// </summary>
        public WorkPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkPeriod> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WorkPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// WorkCycleId
    /// PeriodStartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("WorkCycleId", "PeriodStartDate")]
    [global::Microsoft.OData.Client.EntitySet("WorkPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkPeriod")]
    public partial class WorkPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkPeriod object.
        /// </summary>
        /// <param name="workCycleId">Initial value of WorkCycleId.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkPeriod CreateWorkPeriod(string workCycleId, global::System.DateTimeOffset periodStartDate, global::System.DateTimeOffset periodEndDate)
        {
            WorkPeriod workPeriod = new WorkPeriod();
            workPeriod.WorkCycleId = workCycleId;
            workPeriod.PeriodStartDate = periodStartDate;
            workPeriod.PeriodEndDate = periodEndDate;
            return workPeriod;
        }
        /// <summary>
        /// There are no comments for Property WorkCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkCycleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkCycleId is required.")]
        public virtual string WorkCycleId
        {
            get
            {
                return this._WorkCycleId;
            }
            set
            {
                this.OnWorkCycleIdChanging(value);
                this._WorkCycleId = value;
                this.OnWorkCycleIdChanged();
                this.OnPropertyChanged("WorkCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkCycleId;
        partial void OnWorkCycleIdChanging(string value);
        partial void OnWorkCycleIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodStartDate is required.")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comments")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodEndDate is required.")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
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