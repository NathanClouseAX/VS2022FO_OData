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
    /// There are no comments for RetailStoreWorkShiftSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreWorkShiftSingle")]
    public partial class RetailStoreWorkShiftSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreWorkShift>
    {
        /// <summary>
        /// Initialize a new RetailStoreWorkShiftSingle object.
        /// </summary>
        public RetailStoreWorkShiftSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreWorkShiftSingle object.
        /// </summary>
        public RetailStoreWorkShiftSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreWorkShiftSingle object.
        /// </summary>
        public RetailStoreWorkShiftSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreWorkShift> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailStoreWorkShift in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShiftDate
    /// ShiftId
    /// StoreNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShiftDate", "ShiftId", "StoreNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreWorkShifts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailStoreWorkShift")]
    public partial class RetailStoreWorkShift : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreWorkShift object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shiftDate">Initial value of ShiftDate.</param>
        /// <param name="shiftId">Initial value of ShiftId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="startingTime">Initial value of StartingTime.</param>
        /// <param name="replicationCounter">Initial value of ReplicationCounter.</param>
        /// <param name="endingTime">Initial value of EndingTime.</param>
        /// <param name="startingDate">Initial value of StartingDate.</param>
        /// <param name="endingDate">Initial value of EndingDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreWorkShift CreateRetailStoreWorkShift(string dataAreaId, 
                    global::System.DateTimeOffset shiftDate, 
                    string shiftId, 
                    string storeNumber, 
                    int startingTime, 
                    int replicationCounter, 
                    int endingTime, 
                    global::System.DateTimeOffset startingDate, 
                    global::System.DateTimeOffset endingDate)
        {
            RetailStoreWorkShift retailStoreWorkShift = new RetailStoreWorkShift();
            retailStoreWorkShift.DataAreaId = dataAreaId;
            retailStoreWorkShift.ShiftDate = shiftDate;
            retailStoreWorkShift.ShiftId = shiftId;
            retailStoreWorkShift.StoreNumber = storeNumber;
            retailStoreWorkShift.StartingTime = startingTime;
            retailStoreWorkShift.ReplicationCounter = replicationCounter;
            retailStoreWorkShift.EndingTime = endingTime;
            retailStoreWorkShift.StartingDate = startingDate;
            retailStoreWorkShift.EndingDate = endingDate;
            return retailStoreWorkShift;
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
        /// There are no comments for Property ShiftDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShiftDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShiftDate is required.")]
        public virtual global::System.DateTimeOffset ShiftDate
        {
            get
            {
                return this._ShiftDate;
            }
            set
            {
                this.OnShiftDateChanging(value);
                this._ShiftDate = value;
                this.OnShiftDateChanged();
                this.OnPropertyChanged("ShiftDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ShiftDate;
        partial void OnShiftDateChanging(global::System.DateTimeOffset value);
        partial void OnShiftDateChanged();
        /// <summary>
        /// There are no comments for Property ShiftId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShiftId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShiftId is required.")]
        public virtual string ShiftId
        {
            get
            {
                return this._ShiftId;
            }
            set
            {
                this.OnShiftIdChanging(value);
                this._ShiftId = value;
                this.OnShiftIdChanged();
                this.OnPropertyChanged("ShiftId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShiftId;
        partial void OnShiftIdChanging(string value);
        partial void OnShiftIdChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property StartingTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartingTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartingTime is required.")]
        public virtual int StartingTime
        {
            get
            {
                return this._StartingTime;
            }
            set
            {
                this.OnStartingTimeChanging(value);
                this._StartingTime = value;
                this.OnStartingTimeChanged();
                this.OnPropertyChanged("StartingTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StartingTime;
        partial void OnStartingTimeChanging(int value);
        partial void OnStartingTimeChanged();
        /// <summary>
        /// There are no comments for Property ReplicationCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReplicationCounter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReplicationCounter is required.")]
        public virtual int ReplicationCounter
        {
            get
            {
                return this._ReplicationCounter;
            }
            set
            {
                this.OnReplicationCounterChanging(value);
                this._ReplicationCounter = value;
                this.OnReplicationCounterChanged();
                this.OnPropertyChanged("ReplicationCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplicationCounter;
        partial void OnReplicationCounterChanging(int value);
        partial void OnReplicationCounterChanged();
        /// <summary>
        /// There are no comments for Property EndingTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndingTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndingTime is required.")]
        public virtual int EndingTime
        {
            get
            {
                return this._EndingTime;
            }
            set
            {
                this.OnEndingTimeChanging(value);
                this._EndingTime = value;
                this.OnEndingTimeChanged();
                this.OnPropertyChanged("EndingTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EndingTime;
        partial void OnEndingTimeChanging(int value);
        partial void OnEndingTimeChanged();
        /// <summary>
        /// There are no comments for Property StartingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartingDate is required.")]
        public virtual global::System.DateTimeOffset StartingDate
        {
            get
            {
                return this._StartingDate;
            }
            set
            {
                this.OnStartingDateChanging(value);
                this._StartingDate = value;
                this.OnStartingDateChanged();
                this.OnPropertyChanged("StartingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartingDate;
        partial void OnStartingDateChanging(global::System.DateTimeOffset value);
        partial void OnStartingDateChanged();
        /// <summary>
        /// There are no comments for Property WorkShiftStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkShiftStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailWorkShiftStatus> WorkShiftStatus
        {
            get
            {
                return this._WorkShiftStatus;
            }
            set
            {
                this.OnWorkShiftStatusChanging(value);
                this._WorkShiftStatus = value;
                this.OnWorkShiftStatusChanged();
                this.OnPropertyChanged("WorkShiftStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailWorkShiftStatus> _WorkShiftStatus;
        partial void OnWorkShiftStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailWorkShiftStatus> value);
        partial void OnWorkShiftStatusChanged();
        /// <summary>
        /// There are no comments for Property EndingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndingDate is required.")]
        public virtual global::System.DateTimeOffset EndingDate
        {
            get
            {
                return this._EndingDate;
            }
            set
            {
                this.OnEndingDateChanging(value);
                this._EndingDate = value;
                this.OnEndingDateChanged();
                this.OnPropertyChanged("EndingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndingDate;
        partial void OnEndingDateChanging(global::System.DateTimeOffset value);
        partial void OnEndingDateChanged();
        /// <summary>
        /// There are no comments for Property StatementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatementId")]
        public virtual string StatementId
        {
            get
            {
                return this._StatementId;
            }
            set
            {
                this.OnStatementIdChanging(value);
                this._StatementId = value;
                this.OnStatementIdChanged();
                this.OnPropertyChanged("StatementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatementId;
        partial void OnStatementIdChanging(string value);
        partial void OnStatementIdChanged();
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
