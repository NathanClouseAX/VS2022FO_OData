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
    /// There are no comments for LeasePaymentScheduleHistorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeasePaymentScheduleHistorySingle")]
    public partial class LeasePaymentScheduleHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleHistory>
    {
        /// <summary>
        /// Initialize a new LeasePaymentScheduleHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeasePaymentScheduleHistorySingle object.
        /// </summary>
        public LeasePaymentScheduleHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeasePaymentScheduleHistory> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LeasePaymentScheduleHistory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LeaseId
    /// LeaseCounter
    /// ScheduleLineDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaseId", "LeaseCounter", "ScheduleLineDate")]
    [global::Microsoft.OData.Client.EntitySet("LeasePaymentSchedulesHistory")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeasePaymentScheduleHistory")]
    public partial class LeasePaymentScheduleHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeasePaymentScheduleHistory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="leaseId">Initial value of LeaseId.</param>
        /// <param name="leaseCounter">Initial value of LeaseCounter.</param>
        /// <param name="scheduleLineDate">Initial value of ScheduleLineDate.</param>
        /// <param name="paymentAmount">Initial value of PaymentAmount.</param>
        /// <param name="counter">Initial value of Counter.</param>
        /// <param name="straightLineCost">Initial value of StraightLineCost.</param>
        /// <param name="presentValue">Initial value of PresentValue.</param>
        /// <param name="numberOfPayment">Initial value of NumberOfPayment.</param>
        /// <param name="lineLeaseCounter">Initial value of LineLeaseCounter.</param>
        /// <param name="totalPresentValue">Initial value of TotalPresentValue.</param>
        /// <param name="months">Initial value of Months.</param>
        /// <param name="variablePayment">Initial value of VariablePayment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeasePaymentScheduleHistory CreateLeasePaymentScheduleHistory(string dataAreaId, 
                    string leaseId, 
                    int leaseCounter, 
                    global::System.DateTimeOffset scheduleLineDate, 
                    decimal paymentAmount, 
                    int counter, 
                    decimal straightLineCost, 
                    decimal presentValue, 
                    int numberOfPayment, 
                    int lineLeaseCounter, 
                    decimal totalPresentValue, 
                    int months, 
                    decimal variablePayment)
        {
            LeasePaymentScheduleHistory leasePaymentScheduleHistory = new LeasePaymentScheduleHistory();
            leasePaymentScheduleHistory.DataAreaId = dataAreaId;
            leasePaymentScheduleHistory.LeaseId = leaseId;
            leasePaymentScheduleHistory.LeaseCounter = leaseCounter;
            leasePaymentScheduleHistory.ScheduleLineDate = scheduleLineDate;
            leasePaymentScheduleHistory.PaymentAmount = paymentAmount;
            leasePaymentScheduleHistory.Counter = counter;
            leasePaymentScheduleHistory.StraightLineCost = straightLineCost;
            leasePaymentScheduleHistory.PresentValue = presentValue;
            leasePaymentScheduleHistory.NumberOfPayment = numberOfPayment;
            leasePaymentScheduleHistory.LineLeaseCounter = lineLeaseCounter;
            leasePaymentScheduleHistory.TotalPresentValue = totalPresentValue;
            leasePaymentScheduleHistory.Months = months;
            leasePaymentScheduleHistory.VariablePayment = variablePayment;
            return leasePaymentScheduleHistory;
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
        /// There are no comments for Property LeaseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseId is required.")]
        public virtual string LeaseId
        {
            get
            {
                return this._LeaseId;
            }
            set
            {
                this.OnLeaseIdChanging(value);
                this._LeaseId = value;
                this.OnLeaseIdChanged();
                this.OnPropertyChanged("LeaseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaseId;
        partial void OnLeaseIdChanging(string value);
        partial void OnLeaseIdChanged();
        /// <summary>
        /// There are no comments for Property LeaseCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaseCounter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseCounter is required.")]
        public virtual int LeaseCounter
        {
            get
            {
                return this._LeaseCounter;
            }
            set
            {
                this.OnLeaseCounterChanging(value);
                this._LeaseCounter = value;
                this.OnLeaseCounterChanged();
                this.OnPropertyChanged("LeaseCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LeaseCounter;
        partial void OnLeaseCounterChanging(int value);
        partial void OnLeaseCounterChanged();
        /// <summary>
        /// There are no comments for Property ScheduleLineDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleLineDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScheduleLineDate is required.")]
        public virtual global::System.DateTimeOffset ScheduleLineDate
        {
            get
            {
                return this._ScheduleLineDate;
            }
            set
            {
                this.OnScheduleLineDateChanging(value);
                this._ScheduleLineDate = value;
                this.OnScheduleLineDateChanged();
                this.OnPropertyChanged("ScheduleLineDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ScheduleLineDate;
        partial void OnScheduleLineDateChanging(global::System.DateTimeOffset value);
        partial void OnScheduleLineDateChanged();
        /// <summary>
        /// There are no comments for Property PaymentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentAmount is required.")]
        public virtual decimal PaymentAmount
        {
            get
            {
                return this._PaymentAmount;
            }
            set
            {
                this.OnPaymentAmountChanging(value);
                this._PaymentAmount = value;
                this.OnPaymentAmountChanged();
                this.OnPropertyChanged("PaymentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaymentAmount;
        partial void OnPaymentAmountChanging(decimal value);
        partial void OnPaymentAmountChanged();
        /// <summary>
        /// There are no comments for Property Counter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Counter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Counter is required.")]
        public virtual int Counter
        {
            get
            {
                return this._Counter;
            }
            set
            {
                this.OnCounterChanging(value);
                this._Counter = value;
                this.OnCounterChanged();
                this.OnPropertyChanged("Counter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Counter;
        partial void OnCounterChanging(int value);
        partial void OnCounterChanged();
        /// <summary>
        /// There are no comments for Property StraightLineCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StraightLineCost")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StraightLineCost is required.")]
        public virtual decimal StraightLineCost
        {
            get
            {
                return this._StraightLineCost;
            }
            set
            {
                this.OnStraightLineCostChanging(value);
                this._StraightLineCost = value;
                this.OnStraightLineCostChanged();
                this.OnPropertyChanged("StraightLineCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _StraightLineCost;
        partial void OnStraightLineCostChanging(decimal value);
        partial void OnStraightLineCostChanged();
        /// <summary>
        /// There are no comments for Property PresentValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PresentValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PresentValue is required.")]
        public virtual decimal PresentValue
        {
            get
            {
                return this._PresentValue;
            }
            set
            {
                this.OnPresentValueChanging(value);
                this._PresentValue = value;
                this.OnPresentValueChanged();
                this.OnPropertyChanged("PresentValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PresentValue;
        partial void OnPresentValueChanging(decimal value);
        partial void OnPresentValueChanged();
        /// <summary>
        /// There are no comments for Property NumberOfPayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfPayment")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfPayment is required.")]
        public virtual int NumberOfPayment
        {
            get
            {
                return this._NumberOfPayment;
            }
            set
            {
                this.OnNumberOfPaymentChanging(value);
                this._NumberOfPayment = value;
                this.OnNumberOfPaymentChanged();
                this.OnPropertyChanged("NumberOfPayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfPayment;
        partial void OnNumberOfPaymentChanging(int value);
        partial void OnNumberOfPaymentChanged();
        /// <summary>
        /// There are no comments for Property LineLeaseCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineLeaseCounter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineLeaseCounter is required.")]
        public virtual int LineLeaseCounter
        {
            get
            {
                return this._LineLeaseCounter;
            }
            set
            {
                this.OnLineLeaseCounterChanging(value);
                this._LineLeaseCounter = value;
                this.OnLineLeaseCounterChanged();
                this.OnPropertyChanged("LineLeaseCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LineLeaseCounter;
        partial void OnLineLeaseCounterChanging(int value);
        partial void OnLineLeaseCounterChanged();
        /// <summary>
        /// There are no comments for Property TotalPresentValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalPresentValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalPresentValue is required.")]
        public virtual decimal TotalPresentValue
        {
            get
            {
                return this._TotalPresentValue;
            }
            set
            {
                this.OnTotalPresentValueChanging(value);
                this._TotalPresentValue = value;
                this.OnTotalPresentValueChanged();
                this.OnPropertyChanged("TotalPresentValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalPresentValue;
        partial void OnTotalPresentValueChanging(decimal value);
        partial void OnTotalPresentValueChanged();
        /// <summary>
        /// There are no comments for Property Months in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Months")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Months is required.")]
        public virtual int Months
        {
            get
            {
                return this._Months;
            }
            set
            {
                this.OnMonthsChanging(value);
                this._Months = value;
                this.OnMonthsChanged();
                this.OnPropertyChanged("Months");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Months;
        partial void OnMonthsChanging(int value);
        partial void OnMonthsChanged();
        /// <summary>
        /// There are no comments for Property VariablePayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VariablePayment")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VariablePayment is required.")]
        public virtual decimal VariablePayment
        {
            get
            {
                return this._VariablePayment;
            }
            set
            {
                this.OnVariablePaymentChanging(value);
                this._VariablePayment = value;
                this.OnVariablePaymentChanged();
                this.OnPropertyChanged("VariablePayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VariablePayment;
        partial void OnVariablePaymentChanging(decimal value);
        partial void OnVariablePaymentChanged();
        /// <summary>
        /// There are no comments for Property JournalPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalPosted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> JournalPosted
        {
            get
            {
                return this._JournalPosted;
            }
            set
            {
                this.OnJournalPostedChanging(value);
                this._JournalPosted = value;
                this.OnJournalPostedChanged();
                this.OnPropertyChanged("JournalPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _JournalPosted;
        partial void OnJournalPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnJournalPostedChanged();
        /// <summary>
        /// There are no comments for Property PaymentConfirmed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentConfirmed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PaymentConfirmed
        {
            get
            {
                return this._PaymentConfirmed;
            }
            set
            {
                this.OnPaymentConfirmedChanging(value);
                this._PaymentConfirmed = value;
                this.OnPaymentConfirmedChanged();
                this.OnPropertyChanged("PaymentConfirmed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PaymentConfirmed;
        partial void OnPaymentConfirmedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPaymentConfirmedChanged();
        /// <summary>
        /// There are no comments for Property JournalNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNum")]
        public virtual string JournalNum
        {
            get
            {
                return this._JournalNum;
            }
            set
            {
                this.OnJournalNumChanging(value);
                this._JournalNum = value;
                this.OnJournalNumChanged();
                this.OnPropertyChanged("JournalNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNum;
        partial void OnJournalNumChanging(string value);
        partial void OnJournalNumChanged();
        /// <summary>
        /// There are no comments for Property JournalCreated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalCreated")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> JournalCreated
        {
            get
            {
                return this._JournalCreated;
            }
            set
            {
                this.OnJournalCreatedChanging(value);
                this._JournalCreated = value;
                this.OnJournalCreatedChanged();
                this.OnPropertyChanged("JournalCreated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _JournalCreated;
        partial void OnJournalCreatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnJournalCreatedChanged();
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