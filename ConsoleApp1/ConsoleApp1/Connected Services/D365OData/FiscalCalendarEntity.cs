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
    /// There are no comments for FiscalCalendarEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarEntitySingle")]
    public partial class FiscalCalendarEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarEntity>
    {
        /// <summary>
        /// Initialize a new FiscalCalendarEntitySingle object.
        /// </summary>
        public FiscalCalendarEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalCalendarEntitySingle object.
        /// </summary>
        public FiscalCalendarEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalCalendarEntitySingle object.
        /// </summary>
        public FiscalCalendarEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FiscalPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPeriod")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FiscalPeriod> FiscalPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FiscalPeriod == null))
                {
                    this._FiscalPeriod = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FiscalPeriod>(GetPath("FiscalPeriod"));
                }
                return this._FiscalPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FiscalPeriod> _FiscalPeriod;
        /// <summary>
        /// There are no comments for FiscalCalendarYearEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYearEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity> FiscalCalendarYearEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FiscalCalendarYearEntity == null))
                {
                    this._FiscalCalendarYearEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity>(GetPath("FiscalCalendarYearEntity"));
                }
                return this._FiscalCalendarYearEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity> _FiscalCalendarYearEntity;
    }
    /// <summary>
    /// There are no comments for FiscalCalendarEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CalendarId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CalendarId")]
    [global::Microsoft.OData.Client.EntitySet("FiscalCalendarsEntity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarEntity")]
    public partial class FiscalCalendarEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalCalendarEntity object.
        /// </summary>
        /// <param name="calendarId">Initial value of CalendarId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalCalendarEntity CreateFiscalCalendarEntity(string calendarId)
        {
            FiscalCalendarEntity fiscalCalendarEntity = new FiscalCalendarEntity();
            fiscalCalendarEntity.CalendarId = calendarId;
            return fiscalCalendarEntity;
        }
        /// <summary>
        /// There are no comments for Property CalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CalendarId is required.")]
        public virtual string CalendarId
        {
            get
            {
                return this._CalendarId;
            }
            set
            {
                this.OnCalendarIdChanging(value);
                this._CalendarId = value;
                this.OnCalendarIdChanged();
                this.OnPropertyChanged("CalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalendarId;
        partial void OnCalendarIdChanging(string value);
        partial void OnCalendarIdChanged();
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
        /// There are no comments for Property FiscalPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPeriod")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalPeriod> FiscalPeriod
        {
            get
            {
                return this._FiscalPeriod;
            }
            set
            {
                this.OnFiscalPeriodChanging(value);
                this._FiscalPeriod = value;
                this.OnFiscalPeriodChanged();
                this.OnPropertyChanged("FiscalPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalPeriod> _FiscalPeriod = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalPeriod>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFiscalPeriodChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalPeriod> value);
        partial void OnFiscalPeriodChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarYearEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYearEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity> FiscalCalendarYearEntity
        {
            get
            {
                return this._FiscalCalendarYearEntity;
            }
            set
            {
                this.OnFiscalCalendarYearEntityChanging(value);
                this._FiscalCalendarYearEntity = value;
                this.OnFiscalCalendarYearEntityChanged();
                this.OnPropertyChanged("FiscalCalendarYearEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity> _FiscalCalendarYearEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFiscalCalendarYearEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FiscalCalendarYearEntity> value);
        partial void OnFiscalCalendarYearEntityChanged();
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
