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
    /// There are no comments for GoalSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GoalSingle")]
    public partial class GoalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Goal>
    {
        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GoalSingle object.
        /// </summary>
        public GoalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Goal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Discussions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussions")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoal> Discussions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Discussions == null))
                {
                    this._Discussions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoal>(GetPath("Discussions"));
                }
                return this._Discussions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoal> _Discussions;
        /// <summary>
        /// There are no comments for PerformanceJournalEntryRelations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntryRelations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry> PerformanceJournalEntryRelations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PerformanceJournalEntryRelations == null))
                {
                    this._PerformanceJournalEntryRelations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry>(GetPath("PerformanceJournalEntryRelations"));
                }
                return this._PerformanceJournalEntryRelations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry> _PerformanceJournalEntryRelations;
        /// <summary>
        /// There are no comments for DiscussionPerformanceJournalEntryRelations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionPerformanceJournalEntryRelations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry> DiscussionPerformanceJournalEntryRelations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DiscussionPerformanceJournalEntryRelations == null))
                {
                    this._DiscussionPerformanceJournalEntryRelations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry>(GetPath("DiscussionPerformanceJournalEntryRelations"));
                }
                return this._DiscussionPerformanceJournalEntryRelations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry> _DiscussionPerformanceJournalEntryRelations;
        /// <summary>
        /// There are no comments for Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalMeasurement> Measurements
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Measurements == null))
                {
                    this._Measurements = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GoalMeasurement>(GetPath("Measurements"));
                }
                return this._Measurements;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalMeasurement> _Measurements;
        /// <summary>
        /// There are no comments for DiscussionComments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionComments")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment> DiscussionComments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DiscussionComments == null))
                {
                    this._DiscussionComments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment>(GetPath("DiscussionComments"));
                }
                return this._DiscussionComments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment> _DiscussionComments;
        /// <summary>
        /// There are no comments for GoalHeading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalHeading")]
        public virtual global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle GoalHeading
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GoalHeading == null))
                {
                    this._GoalHeading = new global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle(this.Context, GetPath("GoalHeading"));
                }
                return this._GoalHeading;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.GoalHeadingSingle _GoalHeading;
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
    }
    /// <summary>
    /// There are no comments for Goal in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Goal
    /// PersonnelNumber
    /// GoalHeadingId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Goal", "PersonnelNumber", "GoalHeadingId")]
    [global::Microsoft.OData.Client.EntitySet("Goals")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Goal")]
    public partial class Goal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Goal object.
        /// </summary>
        /// <param name="goal1">Initial value of Goal1.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="goalHeadingId">Initial value of GoalHeadingId.</param>
        /// <param name="dateFinished">Initial value of DateFinished.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="percentComplete">Initial value of PercentComplete.</param>
        /// <param name="goalHeading">Initial value of GoalHeading.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Goal CreateGoal(string goal1, 
                    string personnelNumber, 
                    string goalHeadingId, 
                    global::System.DateTimeOffset dateFinished, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    decimal percentComplete, 
                    global::Microsoft.Dynamics.DataEntities.GoalHeading goalHeading, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            Goal goal = new Goal();
            goal.Goal1 = goal1;
            goal.PersonnelNumber = personnelNumber;
            goal.GoalHeadingId = goalHeadingId;
            goal.DateFinished = dateFinished;
            goal.StartDate = startDate;
            goal.EndDate = endDate;
            goal.PercentComplete = percentComplete;
            if ((goalHeading == null))
            {
                throw new global::System.ArgumentNullException("goalHeading");
            }
            goal.GoalHeading = goalHeading;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            goal.Worker = worker;
            return goal;
        }
        /// <summary>
        /// There are no comments for Property Goal1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Goal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Goal1 is required.")]
        public virtual string Goal1
        {
            get
            {
                return this._Goal1;
            }
            set
            {
                this.OnGoal1Changing(value);
                this._Goal1 = value;
                this.OnGoal1Changed();
                this.OnPropertyChanged("Goal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Goal1;
        partial void OnGoal1Changing(string value);
        partial void OnGoal1Changed();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelNumber is required.")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property GoalHeadingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalHeadingId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GoalHeadingId is required.")]
        public virtual string GoalHeadingId
        {
            get
            {
                return this._GoalHeadingId;
            }
            set
            {
                this.OnGoalHeadingIdChanging(value);
                this._GoalHeadingId = value;
                this.OnGoalHeadingIdChanged();
                this.OnPropertyChanged("GoalHeadingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GoalHeadingId;
        partial void OnGoalHeadingIdChanging(string value);
        partial void OnGoalHeadingIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmGoalStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DateFinished in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateFinished")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateFinished is required.")]
        public virtual global::System.DateTimeOffset DateFinished
        {
            get
            {
                return this._DateFinished;
            }
            set
            {
                this.OnDateFinishedChanging(value);
                this._DateFinished = value;
                this.OnDateFinishedChanged();
                this.OnPropertyChanged("DateFinished");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateFinished;
        partial void OnDateFinishedChanging(global::System.DateTimeOffset value);
        partial void OnDateFinishedChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property PercentComplete in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PercentComplete")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PercentComplete is required.")]
        public virtual decimal PercentComplete
        {
            get
            {
                return this._PercentComplete;
            }
            set
            {
                this.OnPercentCompleteChanging(value);
                this._PercentComplete = value;
                this.OnPercentCompleteChanged();
                this.OnPropertyChanged("PercentComplete");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentComplete;
        partial void OnPercentCompleteChanging(decimal value);
        partial void OnPercentCompleteChanged();
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
        /// There are no comments for Property GoalLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalLevel")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> GoalLevel
        {
            get
            {
                return this._GoalLevel;
            }
            set
            {
                this.OnGoalLevelChanging(value);
                this._GoalLevel = value;
                this.OnGoalLevelChanged();
                this.OnPropertyChanged("GoalLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> _GoalLevel;
        partial void OnGoalLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> value);
        partial void OnGoalLevelChanged();
        /// <summary>
        /// There are no comments for Property Overview in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Overview")]
        public virtual string Overview
        {
            get
            {
                return this._Overview;
            }
            set
            {
                this.OnOverviewChanging(value);
                this._Overview = value;
                this.OnOverviewChanged();
                this.OnPropertyChanged("Overview");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Overview;
        partial void OnOverviewChanging(string value);
        partial void OnOverviewChanged();
        /// <summary>
        /// There are no comments for Property Discussions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussions")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoal> Discussions
        {
            get
            {
                return this._Discussions;
            }
            set
            {
                this.OnDiscussionsChanging(value);
                this._Discussions = value;
                this.OnDiscussionsChanged();
                this.OnPropertyChanged("Discussions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoal> _Discussions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDiscussionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoal> value);
        partial void OnDiscussionsChanged();
        /// <summary>
        /// There are no comments for Property PerformanceJournalEntryRelations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntryRelations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry> PerformanceJournalEntryRelations
        {
            get
            {
                return this._PerformanceJournalEntryRelations;
            }
            set
            {
                this.OnPerformanceJournalEntryRelationsChanging(value);
                this._PerformanceJournalEntryRelations = value;
                this.OnPerformanceJournalEntryRelationsChanged();
                this.OnPropertyChanged("PerformanceJournalEntryRelations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry> _PerformanceJournalEntryRelations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPerformanceJournalEntryRelationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalPerformanceJournalEntry> value);
        partial void OnPerformanceJournalEntryRelationsChanged();
        /// <summary>
        /// There are no comments for Property DiscussionPerformanceJournalEntryRelations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionPerformanceJournalEntryRelations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry> DiscussionPerformanceJournalEntryRelations
        {
            get
            {
                return this._DiscussionPerformanceJournalEntryRelations;
            }
            set
            {
                this.OnDiscussionPerformanceJournalEntryRelationsChanging(value);
                this._DiscussionPerformanceJournalEntryRelations = value;
                this.OnDiscussionPerformanceJournalEntryRelationsChanged();
                this.OnPropertyChanged("DiscussionPerformanceJournalEntryRelations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry> _DiscussionPerformanceJournalEntryRelations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDiscussionPerformanceJournalEntryRelationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionPerformanceJournalEntry> value);
        partial void OnDiscussionPerformanceJournalEntryRelationsChanged();
        /// <summary>
        /// There are no comments for Property Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalMeasurement> Measurements
        {
            get
            {
                return this._Measurements;
            }
            set
            {
                this.OnMeasurementsChanging(value);
                this._Measurements = value;
                this.OnMeasurementsChanged();
                this.OnPropertyChanged("Measurements");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalMeasurement> _Measurements = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalMeasurement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnMeasurementsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalMeasurement> value);
        partial void OnMeasurementsChanged();
        /// <summary>
        /// There are no comments for Property DiscussionComments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscussionComments")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment> DiscussionComments
        {
            get
            {
                return this._DiscussionComments;
            }
            set
            {
                this.OnDiscussionCommentsChanging(value);
                this._DiscussionComments = value;
                this.OnDiscussionCommentsChanged();
                this.OnPropertyChanged("DiscussionComments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment> _DiscussionComments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDiscussionCommentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DiscussionGoalComment> value);
        partial void OnDiscussionCommentsChanged();
        /// <summary>
        /// There are no comments for Property GoalHeading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalHeading")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GoalHeading is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.GoalHeading GoalHeading
        {
            get
            {
                return this._GoalHeading;
            }
            set
            {
                this.OnGoalHeadingChanging(value);
                this._GoalHeading = value;
                this.OnGoalHeadingChanged();
                this.OnPropertyChanged("GoalHeading");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.GoalHeading _GoalHeading;
        partial void OnGoalHeadingChanging(global::Microsoft.Dynamics.DataEntities.GoalHeading value);
        partial void OnGoalHeadingChanged();
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
