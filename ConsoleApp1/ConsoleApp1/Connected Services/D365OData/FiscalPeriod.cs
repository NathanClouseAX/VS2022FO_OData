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
    /// There are no comments for FiscalPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPeriodSingle")]
    public partial class FiscalPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalPeriod>
    {
        /// <summary>
        /// Initialize a new FiscalPeriodSingle object.
        /// </summary>
        public FiscalPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalPeriodSingle object.
        /// </summary>
        public FiscalPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalPeriodSingle object.
        /// </summary>
        public FiscalPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FiscalCalendarPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntitySingle FiscalCalendarPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FiscalCalendarPeriod == null))
                {
                    this._FiscalCalendarPeriod = new global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntitySingle(this.Context, GetPath("FiscalCalendarPeriod"));
                }
                return this._FiscalCalendarPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntitySingle _FiscalCalendarPeriod;
        /// <summary>
        /// There are no comments for FiscalCalendarYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYear")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntitySingle FiscalCalendarYear
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FiscalCalendarYear == null))
                {
                    this._FiscalCalendarYear = new global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntitySingle(this.Context, GetPath("FiscalCalendarYear"));
                }
                return this._FiscalCalendarYear;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntitySingle _FiscalCalendarYear;
        /// <summary>
        /// There are no comments for BudgetTrackingWorkspaceParametersFiscalPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetTrackingWorkspaceParametersFiscalPeriod")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersFiscalPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetTrackingWorkspaceParametersFiscalPeriod == null))
                {
                    this._BudgetTrackingWorkspaceParametersFiscalPeriod = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(GetPath("BudgetTrackingWorkspaceParametersFiscalPeriod"));
                }
                return this._BudgetTrackingWorkspaceParametersFiscalPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersFiscalPeriod;
    }
    /// <summary>
    /// There are no comments for FiscalPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Calendar
    /// FiscalYear
    /// StartDate
    /// EndDate
    /// PeriodName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Calendar", "FiscalYear", "StartDate", "EndDate", "PeriodName")]
    [global::Microsoft.OData.Client.EntitySet("FiscalPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPeriod")]
    public partial class FiscalPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalPeriod object.
        /// </summary>
        /// <param name="calendar">Initial value of Calendar.</param>
        /// <param name="fiscalYear">Initial value of FiscalYear.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="periodName">Initial value of PeriodName.</param>
        /// <param name="days">Initial value of Days.</param>
        /// <param name="fiscalCalendarPeriod">Initial value of FiscalCalendarPeriod.</param>
        /// <param name="fiscalCalendarYear">Initial value of FiscalCalendarYear.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalPeriod CreateFiscalPeriod(string calendar, 
                    string fiscalYear, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    string periodName, 
                    int days, 
                    global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntity fiscalCalendarPeriod, 
                    global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity fiscalCalendarYear)
        {
            FiscalPeriod fiscalPeriod = new FiscalPeriod();
            fiscalPeriod.Calendar = calendar;
            fiscalPeriod.FiscalYear = fiscalYear;
            fiscalPeriod.StartDate = startDate;
            fiscalPeriod.EndDate = endDate;
            fiscalPeriod.PeriodName = periodName;
            fiscalPeriod.Days = days;
            if ((fiscalCalendarPeriod == null))
            {
                throw new global::System.ArgumentNullException("fiscalCalendarPeriod");
            }
            fiscalPeriod.FiscalCalendarPeriod = fiscalCalendarPeriod;
            if ((fiscalCalendarYear == null))
            {
                throw new global::System.ArgumentNullException("fiscalCalendarYear");
            }
            fiscalPeriod.FiscalCalendarYear = fiscalCalendarYear;
            return fiscalPeriod;
        }
        /// <summary>
        /// There are no comments for Property Calendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Calendar")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Calendar is required.")]
        public virtual string Calendar
        {
            get
            {
                return this._Calendar;
            }
            set
            {
                this.OnCalendarChanging(value);
                this._Calendar = value;
                this.OnCalendarChanged();
                this.OnPropertyChanged("Calendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Calendar;
        partial void OnCalendarChanging(string value);
        partial void OnCalendarChanged();
        /// <summary>
        /// There are no comments for Property FiscalYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalYear")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalYear is required.")]
        public virtual string FiscalYear
        {
            get
            {
                return this._FiscalYear;
            }
            set
            {
                this.OnFiscalYearChanging(value);
                this._FiscalYear = value;
                this.OnFiscalYearChanged();
                this.OnPropertyChanged("FiscalYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalYear;
        partial void OnFiscalYearChanging(string value);
        partial void OnFiscalYearChanged();
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
        /// There are no comments for Property PeriodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodName is required.")]
        public virtual string PeriodName
        {
            get
            {
                return this._PeriodName;
            }
            set
            {
                this.OnPeriodNameChanging(value);
                this._PeriodName = value;
                this.OnPeriodNameChanged();
                this.OnPropertyChanged("PeriodName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodName;
        partial void OnPeriodNameChanging(string value);
        partial void OnPeriodNameChanged();
        /// <summary>
        /// There are no comments for Property Quarter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quarter")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalQuarter> Quarter
        {
            get
            {
                return this._Quarter;
            }
            set
            {
                this.OnQuarterChanging(value);
                this._Quarter = value;
                this.OnQuarterChanged();
                this.OnPropertyChanged("Quarter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalQuarter> _Quarter;
        partial void OnQuarterChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalQuarter> value);
        partial void OnQuarterChanged();
        /// <summary>
        /// There are no comments for Property Days in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Days")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Days is required.")]
        public virtual int Days
        {
            get
            {
                return this._Days;
            }
            set
            {
                this.OnDaysChanging(value);
                this._Days = value;
                this.OnDaysChanged();
                this.OnPropertyChanged("Days");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Days;
        partial void OnDaysChanging(int value);
        partial void OnDaysChanged();
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
        /// There are no comments for Property CalendarType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CalendarType_IN> CalendarType
        {
            get
            {
                return this._CalendarType;
            }
            set
            {
                this.OnCalendarTypeChanging(value);
                this._CalendarType = value;
                this.OnCalendarTypeChanged();
                this.OnPropertyChanged("CalendarType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CalendarType_IN> _CalendarType;
        partial void OnCalendarTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CalendarType_IN> value);
        partial void OnCalendarTypeChanged();
        /// <summary>
        /// There are no comments for Property Month in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Month")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodMonth> Month
        {
            get
            {
                return this._Month;
            }
            set
            {
                this.OnMonthChanging(value);
                this._Month = value;
                this.OnMonthChanged();
                this.OnPropertyChanged("Month");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodMonth> _Month;
        partial void OnMonthChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodMonth> value);
        partial void OnMonthChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiscalPeriodType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortName")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendarPeriod is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntity FiscalCalendarPeriod
        {
            get
            {
                return this._FiscalCalendarPeriod;
            }
            set
            {
                this.OnFiscalCalendarPeriodChanging(value);
                this._FiscalCalendarPeriod = value;
                this.OnFiscalCalendarPeriodChanged();
                this.OnPropertyChanged("FiscalCalendarPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntity _FiscalCalendarPeriod;
        partial void OnFiscalCalendarPeriodChanging(global::Microsoft.Dynamics.DataEntities.FiscalCalendarEntity value);
        partial void OnFiscalCalendarPeriodChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYear")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendarYear is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity FiscalCalendarYear
        {
            get
            {
                return this._FiscalCalendarYear;
            }
            set
            {
                this.OnFiscalCalendarYearChanging(value);
                this._FiscalCalendarYear = value;
                this.OnFiscalCalendarYearChanged();
                this.OnPropertyChanged("FiscalCalendarYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity _FiscalCalendarYear;
        partial void OnFiscalCalendarYearChanging(global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity value);
        partial void OnFiscalCalendarYearChanged();
        /// <summary>
        /// There are no comments for Property BudgetTrackingWorkspaceParametersFiscalPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetTrackingWorkspaceParametersFiscalPeriod")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersFiscalPeriod
        {
            get
            {
                return this._BudgetTrackingWorkspaceParametersFiscalPeriod;
            }
            set
            {
                this.OnBudgetTrackingWorkspaceParametersFiscalPeriodChanging(value);
                this._BudgetTrackingWorkspaceParametersFiscalPeriod = value;
                this.OnBudgetTrackingWorkspaceParametersFiscalPeriodChanged();
                this.OnPropertyChanged("BudgetTrackingWorkspaceParametersFiscalPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersFiscalPeriod = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetTrackingWorkspaceParametersFiscalPeriodChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> value);
        partial void OnBudgetTrackingWorkspaceParametersFiscalPeriodChanged();
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
