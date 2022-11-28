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
    /// There are no comments for FiscalCalendarPeriodBiEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarPeriodBiEntitySingle")]
    public partial class FiscalCalendarPeriodBiEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarPeriodBiEntity>
    {
        /// <summary>
        /// Initialize a new FiscalCalendarPeriodBiEntitySingle object.
        /// </summary>
        public FiscalCalendarPeriodBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalCalendarPeriodBiEntitySingle object.
        /// </summary>
        public FiscalCalendarPeriodBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalCalendarPeriodBiEntitySingle object.
        /// </summary>
        public FiscalCalendarPeriodBiEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarPeriodBiEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalCalendarPeriodBiEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("FiscalCalendarPeriodBiEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarPeriodBiEntity")]
    public partial class FiscalCalendarPeriodBiEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalCalendarPeriodBiEntity object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="fiscalCalendarYear">Initial value of FiscalCalendarYear.</param>
        /// <param name="fiscalCalendar">Initial value of FiscalCalendar.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="sysRowVersionNumber">Initial value of SysRowVersionNumber.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalCalendarPeriodBiEntity CreateFiscalCalendarPeriodBiEntity(string name, 
                    long fiscalCalendarYear, 
                    long fiscalCalendar, 
                    global::System.DateTimeOffset startDate, 
                    long sysRowVersionNumber, 
                    global::System.DateTimeOffset endDate)
        {
            FiscalCalendarPeriodBiEntity fiscalCalendarPeriodBiEntity = new FiscalCalendarPeriodBiEntity();
            fiscalCalendarPeriodBiEntity.Name = name;
            fiscalCalendarPeriodBiEntity.FiscalCalendarYear = fiscalCalendarYear;
            fiscalCalendarPeriodBiEntity.FiscalCalendar = fiscalCalendar;
            fiscalCalendarPeriodBiEntity.StartDate = startDate;
            fiscalCalendarPeriodBiEntity.SysRowVersionNumber = sysRowVersionNumber;
            fiscalCalendarPeriodBiEntity.EndDate = endDate;
            return fiscalCalendarPeriodBiEntity;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property FiscalCalendarYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarYear")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendarYear is required.")]
        public virtual long FiscalCalendarYear
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
        private long _FiscalCalendarYear;
        partial void OnFiscalCalendarYearChanging(long value);
        partial void OnFiscalCalendarYearChanged();
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
        /// There are no comments for Property FiscalCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendar")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalCalendar is required.")]
        public virtual long FiscalCalendar
        {
            get
            {
                return this._FiscalCalendar;
            }
            set
            {
                this.OnFiscalCalendarChanging(value);
                this._FiscalCalendar = value;
                this.OnFiscalCalendarChanged();
                this.OnPropertyChanged("FiscalCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _FiscalCalendar;
        partial void OnFiscalCalendarChanging(long value);
        partial void OnFiscalCalendarChanged();
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
        /// There are no comments for Property SysRowVersionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysRowVersionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SysRowVersionNumber is required.")]
        public virtual long SysRowVersionNumber
        {
            get
            {
                return this._SysRowVersionNumber;
            }
            set
            {
                this.OnSysRowVersionNumberChanging(value);
                this._SysRowVersionNumber = value;
                this.OnSysRowVersionNumberChanged();
                this.OnPropertyChanged("SysRowVersionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SysRowVersionNumber;
        partial void OnSysRowVersionNumberChanging(long value);
        partial void OnSysRowVersionNumberChanged();
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