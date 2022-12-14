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
    /// There are no comments for GoalTemplateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GoalTemplateSingle")]
    public partial class GoalTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GoalTemplate>
    {
        /// <summary>
        /// Initialize a new GoalTemplateSingle object.
        /// </summary>
        public GoalTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GoalTemplateSingle object.
        /// </summary>
        public GoalTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GoalTemplateSingle object.
        /// </summary>
        public GoalTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GoalTemplate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for GoalTemplatePerfJournals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalTemplatePerfJournals")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal> GoalTemplatePerfJournals
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GoalTemplatePerfJournals == null))
                {
                    this._GoalTemplatePerfJournals = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal>(GetPath("GoalTemplatePerfJournals"));
                }
                return this._GoalTemplatePerfJournals;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal> _GoalTemplatePerfJournals;
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
        /// There are no comments for Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement> Measurements
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Measurements == null))
                {
                    this._Measurements = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement>(GetPath("Measurements"));
                }
                return this._Measurements;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement> _Measurements;
    }
    /// <summary>
    /// There are no comments for GoalTemplate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId")]
    [global::Microsoft.OData.Client.EntitySet("GoalTemplates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GoalTemplate")]
    public partial class GoalTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GoalTemplate object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="goalHeading">Initial value of GoalHeading.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GoalTemplate CreateGoalTemplate(int templateId, global::Microsoft.Dynamics.DataEntities.GoalHeading goalHeading)
        {
            GoalTemplate goalTemplate = new GoalTemplate();
            goalTemplate.TemplateId = templateId;
            if ((goalHeading == null))
            {
                throw new global::System.ArgumentNullException("goalHeading");
            }
            goalTemplate.GoalHeading = goalHeading;
            return goalTemplate;
        }
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TemplateId is required.")]
        public virtual int TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TemplateId;
        partial void OnTemplateIdChanging(int value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Title")]
        public virtual string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Level in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Level")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> Level
        {
            get
            {
                return this._Level;
            }
            set
            {
                this.OnLevelChanging(value);
                this._Level = value;
                this.OnLevelChanged();
                this.OnPropertyChanged("Level");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> _Level;
        partial void OnLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmGoalLevel> value);
        partial void OnLevelChanged();
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
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property GoalHeadingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalHeadingId")]
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
        /// There are no comments for Property GoalTemplatePerfJournals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GoalTemplatePerfJournals")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal> GoalTemplatePerfJournals
        {
            get
            {
                return this._GoalTemplatePerfJournals;
            }
            set
            {
                this.OnGoalTemplatePerfJournalsChanging(value);
                this._GoalTemplatePerfJournals = value;
                this.OnGoalTemplatePerfJournalsChanged();
                this.OnPropertyChanged("GoalTemplatePerfJournals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal> _GoalTemplatePerfJournals = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnGoalTemplatePerfJournalsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplatePerformanceJournal> value);
        partial void OnGoalTemplatePerfJournalsChanged();
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
        /// There are no comments for Property Measurements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Measurements")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement> Measurements
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
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement> _Measurements = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnMeasurementsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.GoalTemplateMeasurement> value);
        partial void OnMeasurementsChanged();
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
