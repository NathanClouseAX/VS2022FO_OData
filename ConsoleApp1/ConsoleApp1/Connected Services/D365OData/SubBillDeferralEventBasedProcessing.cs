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
    /// There are no comments for SubBillDeferralEventBasedProcessingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillDeferralEventBasedProcessingSingle")]
    public partial class SubBillDeferralEventBasedProcessingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillDeferralEventBasedProcessing>
    {
        /// <summary>
        /// Initialize a new SubBillDeferralEventBasedProcessingSingle object.
        /// </summary>
        public SubBillDeferralEventBasedProcessingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillDeferralEventBasedProcessingSingle object.
        /// </summary>
        public SubBillDeferralEventBasedProcessingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillDeferralEventBasedProcessingSingle object.
        /// </summary>
        public SubBillDeferralEventBasedProcessingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillDeferralEventBasedProcessing> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillDeferralEventBasedProcessing in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// EventDescription
    /// CustomerNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EventDescription", "CustomerNumber")]
    [global::Microsoft.OData.Client.EntitySet("SubBillDeferralEventBasedProcessings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillDeferralEventBasedProcessing")]
    public partial class SubBillDeferralEventBasedProcessing : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillDeferralEventBasedProcessing object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="eventDescription">Initial value of EventDescription.</param>
        /// <param name="customerNumber">Initial value of CustomerNumber.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="line">Initial value of Line.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillDeferralEventBasedProcessing CreateSubBillDeferralEventBasedProcessing(string dataAreaId, 
                    string eventDescription, 
                    string customerNumber, 
                    global::System.DateTimeOffset endDate, 
                    int line, 
                    global::System.DateTimeOffset expirationDate)
        {
            SubBillDeferralEventBasedProcessing subBillDeferralEventBasedProcessing = new SubBillDeferralEventBasedProcessing();
            subBillDeferralEventBasedProcessing.DataAreaId = dataAreaId;
            subBillDeferralEventBasedProcessing.EventDescription = eventDescription;
            subBillDeferralEventBasedProcessing.CustomerNumber = customerNumber;
            subBillDeferralEventBasedProcessing.EndDate = endDate;
            subBillDeferralEventBasedProcessing.Line = line;
            subBillDeferralEventBasedProcessing.ExpirationDate = expirationDate;
            return subBillDeferralEventBasedProcessing;
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
        /// There are no comments for Property EventDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EventDescription")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EventDescription is required.")]
        public virtual string EventDescription
        {
            get
            {
                return this._EventDescription;
            }
            set
            {
                this.OnEventDescriptionChanging(value);
                this._EventDescription = value;
                this.OnEventDescriptionChanged();
                this.OnPropertyChanged("EventDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EventDescription;
        partial void OnEventDescriptionChanging(string value);
        partial void OnEventDescriptionChanged();
        /// <summary>
        /// There are no comments for Property CustomerNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerNumber is required.")]
        public virtual string CustomerNumber
        {
            get
            {
                return this._CustomerNumber;
            }
            set
            {
                this.OnCustomerNumberChanging(value);
                this._CustomerNumber = value;
                this.OnCustomerNumberChanged();
                this.OnPropertyChanged("CustomerNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerNumber;
        partial void OnCustomerNumberChanging(string value);
        partial void OnCustomerNumberChanged();
        /// <summary>
        /// There are no comments for Property ScheduleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleNumber")]
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
        /// There are no comments for Property Line in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Line")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Line is required.")]
        public virtual int Line
        {
            get
            {
                return this._Line;
            }
            set
            {
                this.OnLineChanging(value);
                this._Line = value;
                this.OnLineChanged();
                this.OnPropertyChanged("Line");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Line;
        partial void OnLineChanging(int value);
        partial void OnLineChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpirationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpirationDate is required.")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
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
