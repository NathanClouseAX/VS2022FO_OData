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
    /// There are no comments for PickupTimeslotSettingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PickupTimeslotSettingSingle")]
    public partial class PickupTimeslotSettingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PickupTimeslotSetting>
    {
        /// <summary>
        /// Initialize a new PickupTimeslotSettingSingle object.
        /// </summary>
        public PickupTimeslotSettingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PickupTimeslotSettingSingle object.
        /// </summary>
        public PickupTimeslotSettingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PickupTimeslotSettingSingle object.
        /// </summary>
        public PickupTimeslotSettingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PickupTimeslotSetting> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PickupTimeslotSetting in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineNum
    /// TimeslotId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNum", "TimeslotId")]
    [global::Microsoft.OData.Client.EntitySet("PickupTimeslotSettings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PickupTimeslotSetting")]
    public partial class PickupTimeslotSetting : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PickupTimeslotSetting object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="timeslotId">Initial value of TimeslotId.</param>
        /// <param name="interval">Initial value of Interval.</param>
        /// <param name="startTime">Initial value of StartTime.</param>
        /// <param name="endTime">Initial value of EndTime.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="capacityPerInterval">Initial value of CapacityPerInterval.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PickupTimeslotSetting CreatePickupTimeslotSetting(string dataAreaId, 
                    decimal lineNum, 
                    string timeslotId, 
                    int interval, 
                    int startTime, 
                    int endTime, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    int capacityPerInterval)
        {
            PickupTimeslotSetting pickupTimeslotSetting = new PickupTimeslotSetting();
            pickupTimeslotSetting.DataAreaId = dataAreaId;
            pickupTimeslotSetting.LineNum = lineNum;
            pickupTimeslotSetting.TimeslotId = timeslotId;
            pickupTimeslotSetting.Interval = interval;
            pickupTimeslotSetting.StartTime = startTime;
            pickupTimeslotSetting.EndTime = endTime;
            pickupTimeslotSetting.StartDate = startDate;
            pickupTimeslotSetting.EndDate = endDate;
            pickupTimeslotSetting.CapacityPerInterval = capacityPerInterval;
            return pickupTimeslotSetting;
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
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property TimeslotId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeslotId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TimeslotId is required.")]
        public virtual string TimeslotId
        {
            get
            {
                return this._TimeslotId;
            }
            set
            {
                this.OnTimeslotIdChanging(value);
                this._TimeslotId = value;
                this.OnTimeslotIdChanged();
                this.OnPropertyChanged("TimeslotId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeslotId;
        partial void OnTimeslotIdChanging(string value);
        partial void OnTimeslotIdChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnMonday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnMonday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnMonday
        {
            get
            {
                return this._ActiveOnMonday;
            }
            set
            {
                this.OnActiveOnMondayChanging(value);
                this._ActiveOnMonday = value;
                this.OnActiveOnMondayChanged();
                this.OnPropertyChanged("ActiveOnMonday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnMonday;
        partial void OnActiveOnMondayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnMondayChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnWednesday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnWednesday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnWednesday
        {
            get
            {
                return this._ActiveOnWednesday;
            }
            set
            {
                this.OnActiveOnWednesdayChanging(value);
                this._ActiveOnWednesday = value;
                this.OnActiveOnWednesdayChanged();
                this.OnPropertyChanged("ActiveOnWednesday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnWednesday;
        partial void OnActiveOnWednesdayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnWednesdayChanged();
        /// <summary>
        /// There are no comments for Property Interval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Interval")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Interval is required.")]
        public virtual int Interval
        {
            get
            {
                return this._Interval;
            }
            set
            {
                this.OnIntervalChanging(value);
                this._Interval = value;
                this.OnIntervalChanged();
                this.OnPropertyChanged("Interval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Interval;
        partial void OnIntervalChanging(int value);
        partial void OnIntervalChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnSunday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnSunday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnSunday
        {
            get
            {
                return this._ActiveOnSunday;
            }
            set
            {
                this.OnActiveOnSundayChanging(value);
                this._ActiveOnSunday = value;
                this.OnActiveOnSundayChanged();
                this.OnPropertyChanged("ActiveOnSunday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnSunday;
        partial void OnActiveOnSundayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnSundayChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnTuesday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnTuesday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnTuesday
        {
            get
            {
                return this._ActiveOnTuesday;
            }
            set
            {
                this.OnActiveOnTuesdayChanging(value);
                this._ActiveOnTuesday = value;
                this.OnActiveOnTuesdayChanged();
                this.OnPropertyChanged("ActiveOnTuesday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnTuesday;
        partial void OnActiveOnTuesdayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnTuesdayChanged();
        /// <summary>
        /// There are no comments for Property StartTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartTime is required.")]
        public virtual int StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this.OnStartTimeChanging(value);
                this._StartTime = value;
                this.OnStartTimeChanged();
                this.OnPropertyChanged("StartTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StartTime;
        partial void OnStartTimeChanging(int value);
        partial void OnStartTimeChanged();
        /// <summary>
        /// There are no comments for Property DlvMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DlvMode")]
        public virtual string DlvMode
        {
            get
            {
                return this._DlvMode;
            }
            set
            {
                this.OnDlvModeChanging(value);
                this._DlvMode = value;
                this.OnDlvModeChanged();
                this.OnPropertyChanged("DlvMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DlvMode;
        partial void OnDlvModeChanging(string value);
        partial void OnDlvModeChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnThursday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnThursday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnThursday
        {
            get
            {
                return this._ActiveOnThursday;
            }
            set
            {
                this.OnActiveOnThursdayChanging(value);
                this._ActiveOnThursday = value;
                this.OnActiveOnThursdayChanged();
                this.OnPropertyChanged("ActiveOnThursday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnThursday;
        partial void OnActiveOnThursdayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnThursdayChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnFriday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnFriday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnFriday
        {
            get
            {
                return this._ActiveOnFriday;
            }
            set
            {
                this.OnActiveOnFridayChanging(value);
                this._ActiveOnFriday = value;
                this.OnActiveOnFridayChanged();
                this.OnPropertyChanged("ActiveOnFriday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnFriday;
        partial void OnActiveOnFridayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnFridayChanged();
        /// <summary>
        /// There are no comments for Property EndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndTime is required.")]
        public virtual int EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                this.OnEndTimeChanging(value);
                this._EndTime = value;
                this.OnEndTimeChanged();
                this.OnPropertyChanged("EndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EndTime;
        partial void OnEndTimeChanging(int value);
        partial void OnEndTimeChanged();
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
        /// There are no comments for Property CapacityPerInterval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CapacityPerInterval")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CapacityPerInterval is required.")]
        public virtual int CapacityPerInterval
        {
            get
            {
                return this._CapacityPerInterval;
            }
            set
            {
                this.OnCapacityPerIntervalChanging(value);
                this._CapacityPerInterval = value;
                this.OnCapacityPerIntervalChanged();
                this.OnPropertyChanged("CapacityPerInterval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CapacityPerInterval;
        partial void OnCapacityPerIntervalChanging(int value);
        partial void OnCapacityPerIntervalChanged();
        /// <summary>
        /// There are no comments for Property ActiveOnSaturday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveOnSaturday")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ActiveOnSaturday
        {
            get
            {
                return this._ActiveOnSaturday;
            }
            set
            {
                this.OnActiveOnSaturdayChanging(value);
                this._ActiveOnSaturday = value;
                this.OnActiveOnSaturdayChanged();
                this.OnPropertyChanged("ActiveOnSaturday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ActiveOnSaturday;
        partial void OnActiveOnSaturdayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveOnSaturdayChanged();
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