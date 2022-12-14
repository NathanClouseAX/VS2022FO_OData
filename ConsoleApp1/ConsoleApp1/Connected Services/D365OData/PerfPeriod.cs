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
    /// There are no comments for PerfPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerfPeriodSingle")]
    public partial class PerfPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PerfPeriod>
    {
        /// <summary>
        /// Initialize a new PerfPeriodSingle object.
        /// </summary>
        public PerfPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PerfPeriodSingle object.
        /// </summary>
        public PerfPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PerfPeriodSingle object.
        /// </summary>
        public PerfPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PerfPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Discussion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussion")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Discussion> Discussion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Discussion == null))
                {
                    this._Discussion = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Discussion>(GetPath("Discussion"));
                }
                return this._Discussion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Discussion> _Discussion;
    }
    /// <summary>
    /// There are no comments for PerfPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PerfPeriodId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PerfPeriodId")]
    [global::Microsoft.OData.Client.EntitySet("PerfPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerfPeriod")]
    public partial class PerfPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PerfPeriod object.
        /// </summary>
        /// <param name="perfPeriodId">Initial value of PerfPeriodId.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PerfPeriod CreatePerfPeriod(string perfPeriodId, global::System.DateTimeOffset startDate, global::System.DateTimeOffset endDate)
        {
            PerfPeriod perfPeriod = new PerfPeriod();
            perfPeriod.PerfPeriodId = perfPeriodId;
            perfPeriod.StartDate = startDate;
            perfPeriod.EndDate = endDate;
            return perfPeriod;
        }
        /// <summary>
        /// There are no comments for Property PerfPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PerfPeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PerfPeriodId is required.")]
        public virtual string PerfPeriodId
        {
            get
            {
                return this._PerfPeriodId;
            }
            set
            {
                this.OnPerfPeriodIdChanging(value);
                this._PerfPeriodId = value;
                this.OnPerfPeriodIdChanged();
                this.OnPropertyChanged("PerfPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PerfPeriodId;
        partial void OnPerfPeriodIdChanging(string value);
        partial void OnPerfPeriodIdChanged();
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
        /// There are no comments for Property Discussion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Discussion")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> Discussion
        {
            get
            {
                return this._Discussion;
            }
            set
            {
                this.OnDiscussionChanging(value);
                this._Discussion = value;
                this.OnDiscussionChanged();
                this.OnPropertyChanged("Discussion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> _Discussion = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDiscussionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> value);
        partial void OnDiscussionChanged();
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
