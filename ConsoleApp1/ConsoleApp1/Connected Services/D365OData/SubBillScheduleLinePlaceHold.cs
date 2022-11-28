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
    /// There are no comments for SubBillScheduleLinePlaceHoldSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillScheduleLinePlaceHoldSingle")]
    public partial class SubBillScheduleLinePlaceHoldSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillScheduleLinePlaceHold>
    {
        /// <summary>
        /// Initialize a new SubBillScheduleLinePlaceHoldSingle object.
        /// </summary>
        public SubBillScheduleLinePlaceHoldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillScheduleLinePlaceHoldSingle object.
        /// </summary>
        public SubBillScheduleLinePlaceHoldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillScheduleLinePlaceHoldSingle object.
        /// </summary>
        public SubBillScheduleLinePlaceHoldSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillScheduleLinePlaceHold> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillScheduleLinePlaceHold in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ScheduleNumber
    /// LineNum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ScheduleNumber", "LineNum")]
    [global::Microsoft.OData.Client.EntitySet("SubBillScheduleLinePlaceHolds")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillScheduleLinePlaceHold")]
    public partial class SubBillScheduleLinePlaceHold : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillScheduleLinePlaceHold object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="scheduleNumber">Initial value of ScheduleNumber.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="adjustSchedule">Initial value of AdjustSchedule.</param>
        /// <param name="holdDate">Initial value of HoldDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillScheduleLinePlaceHold CreateSubBillScheduleLinePlaceHold(string dataAreaId, string scheduleNumber, decimal lineNum, int adjustSchedule, global::System.DateTimeOffset holdDate)
        {
            SubBillScheduleLinePlaceHold subBillScheduleLinePlaceHold = new SubBillScheduleLinePlaceHold();
            subBillScheduleLinePlaceHold.DataAreaId = dataAreaId;
            subBillScheduleLinePlaceHold.ScheduleNumber = scheduleNumber;
            subBillScheduleLinePlaceHold.LineNum = lineNum;
            subBillScheduleLinePlaceHold.AdjustSchedule = adjustSchedule;
            subBillScheduleLinePlaceHold.HoldDate = holdDate;
            return subBillScheduleLinePlaceHold;
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
        /// There are no comments for Property ScheduleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScheduleNumber is required.")]
        public virtual string ScheduleNumber
        {
            get
            {
                return this._ScheduleNumber;
            }
            set
            {
                this.OnScheduleNumberChanging(value);
                this._ScheduleNumber = value;
                this.OnScheduleNumberChanged();
                this.OnPropertyChanged("ScheduleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScheduleNumber;
        partial void OnScheduleNumberChanging(string value);
        partial void OnScheduleNumberChanged();
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
        /// There are no comments for Property HoldReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HoldReasonCode")]
        public virtual string HoldReasonCode
        {
            get
            {
                return this._HoldReasonCode;
            }
            set
            {
                this.OnHoldReasonCodeChanging(value);
                this._HoldReasonCode = value;
                this.OnHoldReasonCodeChanged();
                this.OnPropertyChanged("HoldReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HoldReasonCode;
        partial void OnHoldReasonCodeChanging(string value);
        partial void OnHoldReasonCodeChanged();
        /// <summary>
        /// There are no comments for Property AdjustSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustSchedule")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdjustSchedule is required.")]
        public virtual int AdjustSchedule
        {
            get
            {
                return this._AdjustSchedule;
            }
            set
            {
                this.OnAdjustScheduleChanging(value);
                this._AdjustSchedule = value;
                this.OnAdjustScheduleChanged();
                this.OnPropertyChanged("AdjustSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AdjustSchedule;
        partial void OnAdjustScheduleChanging(int value);
        partial void OnAdjustScheduleChanged();
        /// <summary>
        /// There are no comments for Property HoldDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HoldDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HoldDate is required.")]
        public virtual global::System.DateTimeOffset HoldDate
        {
            get
            {
                return this._HoldDate;
            }
            set
            {
                this.OnHoldDateChanging(value);
                this._HoldDate = value;
                this.OnHoldDateChanged();
                this.OnPropertyChanged("HoldDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _HoldDate;
        partial void OnHoldDateChanging(global::System.DateTimeOffset value);
        partial void OnHoldDateChanged();
        /// <summary>
        /// There are no comments for Property HoldNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HoldNotes")]
        public virtual string HoldNotes
        {
            get
            {
                return this._HoldNotes;
            }
            set
            {
                this.OnHoldNotesChanging(value);
                this._HoldNotes = value;
                this.OnHoldNotesChanged();
                this.OnPropertyChanged("HoldNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HoldNotes;
        partial void OnHoldNotesChanging(string value);
        partial void OnHoldNotesChanged();
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