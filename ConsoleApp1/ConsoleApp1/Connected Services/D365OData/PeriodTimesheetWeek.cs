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
    /// There are no comments for PeriodTimesheetWeekSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodTimesheetWeekSingle")]
    public partial class PeriodTimesheetWeekSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodTimesheetWeek>
    {
        /// <summary>
        /// Initialize a new PeriodTimesheetWeekSingle object.
        /// </summary>
        public PeriodTimesheetWeekSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PeriodTimesheetWeekSingle object.
        /// </summary>
        public PeriodTimesheetWeekSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PeriodTimesheetWeekSingle object.
        /// </summary>
        public PeriodTimesheetWeekSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodTimesheetWeek> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PeriodTimesheetWeek in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PeriodId
    /// PeriodFrom
    /// PeriodTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PeriodId", "PeriodFrom", "PeriodTo")]
    [global::Microsoft.OData.Client.EntitySet("PeriodTimesheetWeeks")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodTimesheetWeek")]
    public partial class PeriodTimesheetWeek : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PeriodTimesheetWeek object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="periodId">Initial value of PeriodId.</param>
        /// <param name="periodFrom">Initial value of PeriodFrom.</param>
        /// <param name="periodTo">Initial value of PeriodTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PeriodTimesheetWeek CreatePeriodTimesheetWeek(string dataAreaId, string periodId, global::System.DateTimeOffset periodFrom, global::System.DateTimeOffset periodTo)
        {
            PeriodTimesheetWeek periodTimesheetWeek = new PeriodTimesheetWeek();
            periodTimesheetWeek.DataAreaId = dataAreaId;
            periodTimesheetWeek.PeriodId = periodId;
            periodTimesheetWeek.PeriodFrom = periodFrom;
            periodTimesheetWeek.PeriodTo = periodTo;
            return periodTimesheetWeek;
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
        /// There are no comments for Property PeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodId is required.")]
        public virtual string PeriodId
        {
            get
            {
                return this._PeriodId;
            }
            set
            {
                this.OnPeriodIdChanging(value);
                this._PeriodId = value;
                this.OnPeriodIdChanged();
                this.OnPropertyChanged("PeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodId;
        partial void OnPeriodIdChanging(string value);
        partial void OnPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodFrom is required.")]
        public virtual global::System.DateTimeOffset PeriodFrom
        {
            get
            {
                return this._PeriodFrom;
            }
            set
            {
                this.OnPeriodFromChanging(value);
                this._PeriodFrom = value;
                this.OnPeriodFromChanged();
                this.OnPropertyChanged("PeriodFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodFrom;
        partial void OnPeriodFromChanging(global::System.DateTimeOffset value);
        partial void OnPeriodFromChanged();
        /// <summary>
        /// There are no comments for Property PeriodTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodTo is required.")]
        public virtual global::System.DateTimeOffset PeriodTo
        {
            get
            {
                return this._PeriodTo;
            }
            set
            {
                this.OnPeriodToChanging(value);
                this._PeriodTo = value;
                this.OnPeriodToChanged();
                this.OnPropertyChanged("PeriodTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodTo;
        partial void OnPeriodToChanging(global::System.DateTimeOffset value);
        partial void OnPeriodToChanged();
        /// <summary>
        /// There are no comments for Property PeriodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodName")]
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