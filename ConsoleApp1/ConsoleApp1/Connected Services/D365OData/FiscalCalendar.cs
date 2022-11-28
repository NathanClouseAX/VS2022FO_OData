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
    /// There are no comments for FiscalCalendarSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarSingle")]
    public partial class FiscalCalendarSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendar>
    {
        /// <summary>
        /// Initialize a new FiscalCalendarSingle object.
        /// </summary>
        public FiscalCalendarSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalCalendarSingle object.
        /// </summary>
        public FiscalCalendarSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalCalendarSingle object.
        /// </summary>
        public FiscalCalendarSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendar> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalCalendar in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LedgerGregorianDateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LedgerGregorianDateId")]
    [global::Microsoft.OData.Client.EntitySet("FiscalCalendars")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendar")]
    public partial class FiscalCalendar : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalCalendar object.
        /// </summary>
        /// <param name="ledgerGregorianDateId">Initial value of LedgerGregorianDateId.</param>
        /// <param name="yearOffset">Initial value of YearOffset.</param>
        /// <param name="periodRecId">Initial value of PeriodRecId.</param>
        /// <param name="calendarRecId">Initial value of CalendarRecId.</param>
        /// <param name="gregorianDate">Initial value of GregorianDate.</param>
        /// <param name="ledgerRecId">Initial value of LedgerRecId.</param>
        /// <param name="quarterOffset">Initial value of QuarterOffset.</param>
        /// <param name="periodOffset">Initial value of PeriodOffset.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalCalendar CreateFiscalCalendar(string ledgerGregorianDateId, 
                    int yearOffset, 
                    long periodRecId, 
                    long calendarRecId, 
                    global::System.DateTimeOffset gregorianDate, 
                    long ledgerRecId, 
                    int quarterOffset, 
                    int periodOffset)
        {
            FiscalCalendar fiscalCalendar = new FiscalCalendar();
            fiscalCalendar.LedgerGregorianDateId = ledgerGregorianDateId;
            fiscalCalendar.YearOffset = yearOffset;
            fiscalCalendar.PeriodRecId = periodRecId;
            fiscalCalendar.CalendarRecId = calendarRecId;
            fiscalCalendar.GregorianDate = gregorianDate;
            fiscalCalendar.LedgerRecId = ledgerRecId;
            fiscalCalendar.QuarterOffset = quarterOffset;
            fiscalCalendar.PeriodOffset = periodOffset;
            return fiscalCalendar;
        }
        /// <summary>
        /// There are no comments for Property LedgerGregorianDateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerGregorianDateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerGregorianDateId is required.")]
        public virtual string LedgerGregorianDateId
        {
            get
            {
                return this._LedgerGregorianDateId;
            }
            set
            {
                this.OnLedgerGregorianDateIdChanging(value);
                this._LedgerGregorianDateId = value;
                this.OnLedgerGregorianDateIdChanged();
                this.OnPropertyChanged("LedgerGregorianDateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerGregorianDateId;
        partial void OnLedgerGregorianDateIdChanging(string value);
        partial void OnLedgerGregorianDateIdChanged();
        /// <summary>
        /// There are no comments for Property YearOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("YearOffset")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "YearOffset is required.")]
        public virtual int YearOffset
        {
            get
            {
                return this._YearOffset;
            }
            set
            {
                this.OnYearOffsetChanging(value);
                this._YearOffset = value;
                this.OnYearOffsetChanged();
                this.OnPropertyChanged("YearOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _YearOffset;
        partial void OnYearOffsetChanging(int value);
        partial void OnYearOffsetChanged();
        /// <summary>
        /// There are no comments for Property PeriodRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodRecId is required.")]
        public virtual long PeriodRecId
        {
            get
            {
                return this._PeriodRecId;
            }
            set
            {
                this.OnPeriodRecIdChanging(value);
                this._PeriodRecId = value;
                this.OnPeriodRecIdChanged();
                this.OnPropertyChanged("PeriodRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PeriodRecId;
        partial void OnPeriodRecIdChanging(long value);
        partial void OnPeriodRecIdChanged();
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
        /// There are no comments for Property CalendarRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CalendarRecId is required.")]
        public virtual long CalendarRecId
        {
            get
            {
                return this._CalendarRecId;
            }
            set
            {
                this.OnCalendarRecIdChanging(value);
                this._CalendarRecId = value;
                this.OnCalendarRecIdChanged();
                this.OnPropertyChanged("CalendarRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CalendarRecId;
        partial void OnCalendarRecIdChanging(long value);
        partial void OnCalendarRecIdChanged();
        /// <summary>
        /// There are no comments for Property YearName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("YearName")]
        public virtual string YearName
        {
            get
            {
                return this._YearName;
            }
            set
            {
                this.OnYearNameChanging(value);
                this._YearName = value;
                this.OnYearNameChanged();
                this.OnPropertyChanged("YearName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _YearName;
        partial void OnYearNameChanging(string value);
        partial void OnYearNameChanged();
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
        /// There are no comments for Property GregorianDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GregorianDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GregorianDate is required.")]
        public virtual global::System.DateTimeOffset GregorianDate
        {
            get
            {
                return this._GregorianDate;
            }
            set
            {
                this.OnGregorianDateChanging(value);
                this._GregorianDate = value;
                this.OnGregorianDateChanged();
                this.OnPropertyChanged("GregorianDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _GregorianDate;
        partial void OnGregorianDateChanging(global::System.DateTimeOffset value);
        partial void OnGregorianDateChanged();
        /// <summary>
        /// There are no comments for Property LedgerRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerRecId is required.")]
        public virtual long LedgerRecId
        {
            get
            {
                return this._LedgerRecId;
            }
            set
            {
                this.OnLedgerRecIdChanging(value);
                this._LedgerRecId = value;
                this.OnLedgerRecIdChanged();
                this.OnPropertyChanged("LedgerRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LedgerRecId;
        partial void OnLedgerRecIdChanging(long value);
        partial void OnLedgerRecIdChanged();
        /// <summary>
        /// There are no comments for Property QuarterOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuarterOffset")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuarterOffset is required.")]
        public virtual int QuarterOffset
        {
            get
            {
                return this._QuarterOffset;
            }
            set
            {
                this.OnQuarterOffsetChanging(value);
                this._QuarterOffset = value;
                this.OnQuarterOffsetChanged();
                this.OnPropertyChanged("QuarterOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QuarterOffset;
        partial void OnQuarterOffsetChanging(int value);
        partial void OnQuarterOffsetChanged();
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
        /// There are no comments for Property CalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarId")]
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
        /// There are no comments for Property PeriodOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodOffset")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodOffset is required.")]
        public virtual int PeriodOffset
        {
            get
            {
                return this._PeriodOffset;
            }
            set
            {
                this.OnPeriodOffsetChanging(value);
                this._PeriodOffset = value;
                this.OnPeriodOffsetChanged();
                this.OnPropertyChanged("PeriodOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PeriodOffset;
        partial void OnPeriodOffsetChanging(int value);
        partial void OnPeriodOffsetChanged();
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
