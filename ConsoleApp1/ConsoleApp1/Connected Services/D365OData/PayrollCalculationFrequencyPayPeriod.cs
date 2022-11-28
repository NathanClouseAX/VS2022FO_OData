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
    /// There are no comments for PayrollCalculationFrequencyPayPeriodSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCalculationFrequencyPayPeriodSingle")]
    public partial class PayrollCalculationFrequencyPayPeriodSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollCalculationFrequencyPayPeriod>
    {
        /// <summary>
        /// Initialize a new PayrollCalculationFrequencyPayPeriodSingle object.
        /// </summary>
        public PayrollCalculationFrequencyPayPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollCalculationFrequencyPayPeriodSingle object.
        /// </summary>
        public PayrollCalculationFrequencyPayPeriodSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollCalculationFrequencyPayPeriodSingle object.
        /// </summary>
        public PayrollCalculationFrequencyPayPeriodSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollCalculationFrequencyPayPeriod> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollCalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCalculationFrequency")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle PayrollCalculationFrequency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollCalculationFrequency == null))
                {
                    this._PayrollCalculationFrequency = new global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle(this.Context, GetPath("PayrollCalculationFrequency"));
                }
                return this._PayrollCalculationFrequency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequencySingle _PayrollCalculationFrequency;
        /// <summary>
        /// There are no comments for PayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayPeriod")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayPeriodSingle PayPeriod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayPeriod == null))
                {
                    this._PayPeriod = new global::Microsoft.Dynamics.DataEntities.PayPeriodSingle(this.Context, GetPath("PayPeriod"));
                }
                return this._PayPeriod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayPeriodSingle _PayPeriod;
    }
    /// <summary>
    /// There are no comments for PayrollCalculationFrequencyPayPeriod in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CalculationFrequencyId
    /// PayCycleId
    /// PeriodEndDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CalculationFrequencyId", "PayCycleId", "PeriodEndDate")]
    [global::Microsoft.OData.Client.EntitySet("PayrollCalculationFrequencyPayPeriods")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCalculationFrequencyPayPeriod")]
    public partial class PayrollCalculationFrequencyPayPeriod : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollCalculationFrequencyPayPeriod object.
        /// </summary>
        /// <param name="calculationFrequencyId">Initial value of CalculationFrequencyId.</param>
        /// <param name="payCycleId">Initial value of PayCycleId.</param>
        /// <param name="periodEndDate">Initial value of PeriodEndDate.</param>
        /// <param name="periodStartDate">Initial value of PeriodStartDate.</param>
        /// <param name="defaultPaymentDate">Initial value of DefaultPaymentDate.</param>
        /// <param name="payrollCalculationFrequency">Initial value of PayrollCalculationFrequency.</param>
        /// <param name="payPeriod">Initial value of PayPeriod.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollCalculationFrequencyPayPeriod CreatePayrollCalculationFrequencyPayPeriod(string calculationFrequencyId, 
                    string payCycleId, 
                    global::System.DateTimeOffset periodEndDate, 
                    global::System.DateTimeOffset periodStartDate, 
                    global::System.DateTimeOffset defaultPaymentDate, 
                    global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency payrollCalculationFrequency, 
                    global::Microsoft.Dynamics.DataEntities.PayPeriod payPeriod)
        {
            PayrollCalculationFrequencyPayPeriod payrollCalculationFrequencyPayPeriod = new PayrollCalculationFrequencyPayPeriod();
            payrollCalculationFrequencyPayPeriod.CalculationFrequencyId = calculationFrequencyId;
            payrollCalculationFrequencyPayPeriod.PayCycleId = payCycleId;
            payrollCalculationFrequencyPayPeriod.PeriodEndDate = periodEndDate;
            payrollCalculationFrequencyPayPeriod.PeriodStartDate = periodStartDate;
            payrollCalculationFrequencyPayPeriod.DefaultPaymentDate = defaultPaymentDate;
            if ((payrollCalculationFrequency == null))
            {
                throw new global::System.ArgumentNullException("payrollCalculationFrequency");
            }
            payrollCalculationFrequencyPayPeriod.PayrollCalculationFrequency = payrollCalculationFrequency;
            if ((payPeriod == null))
            {
                throw new global::System.ArgumentNullException("payPeriod");
            }
            payrollCalculationFrequencyPayPeriod.PayPeriod = payPeriod;
            return payrollCalculationFrequencyPayPeriod;
        }
        /// <summary>
        /// There are no comments for Property CalculationFrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculationFrequencyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CalculationFrequencyId is required.")]
        public virtual string CalculationFrequencyId
        {
            get
            {
                return this._CalculationFrequencyId;
            }
            set
            {
                this.OnCalculationFrequencyIdChanging(value);
                this._CalculationFrequencyId = value;
                this.OnCalculationFrequencyIdChanged();
                this.OnPropertyChanged("CalculationFrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalculationFrequencyId;
        partial void OnCalculationFrequencyIdChanging(string value);
        partial void OnCalculationFrequencyIdChanged();
        /// <summary>
        /// There are no comments for Property PayCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayCycleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayCycleId is required.")]
        public virtual string PayCycleId
        {
            get
            {
                return this._PayCycleId;
            }
            set
            {
                this.OnPayCycleIdChanging(value);
                this._PayCycleId = value;
                this.OnPayCycleIdChanged();
                this.OnPropertyChanged("PayCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayCycleId;
        partial void OnPayCycleIdChanging(string value);
        partial void OnPayCycleIdChanged();
        /// <summary>
        /// There are no comments for Property PeriodEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodEndDate is required.")]
        public virtual global::System.DateTimeOffset PeriodEndDate
        {
            get
            {
                return this._PeriodEndDate;
            }
            set
            {
                this.OnPeriodEndDateChanging(value);
                this._PeriodEndDate = value;
                this.OnPeriodEndDateChanged();
                this.OnPropertyChanged("PeriodEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodEndDate;
        partial void OnPeriodEndDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodEndDateChanged();
        /// <summary>
        /// There are no comments for Property PeriodStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> PeriodStatus
        {
            get
            {
                return this._PeriodStatus;
            }
            set
            {
                this.OnPeriodStatusChanging(value);
                this._PeriodStatus = value;
                this.OnPeriodStatusChanged();
                this.OnPropertyChanged("PeriodStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> _PeriodStatus;
        partial void OnPeriodStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollPeriodStatus> value);
        partial void OnPeriodStatusChanged();
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
        /// There are no comments for Property PeriodStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PeriodStartDate is required.")]
        public virtual global::System.DateTimeOffset PeriodStartDate
        {
            get
            {
                return this._PeriodStartDate;
            }
            set
            {
                this.OnPeriodStartDateChanging(value);
                this._PeriodStartDate = value;
                this.OnPeriodStartDateChanged();
                this.OnPropertyChanged("PeriodStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PeriodStartDate;
        partial void OnPeriodStartDateChanging(global::System.DateTimeOffset value);
        partial void OnPeriodStartDateChanged();
        /// <summary>
        /// There are no comments for Property DefaultPaymentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPaymentDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefaultPaymentDate is required.")]
        public virtual global::System.DateTimeOffset DefaultPaymentDate
        {
            get
            {
                return this._DefaultPaymentDate;
            }
            set
            {
                this.OnDefaultPaymentDateChanging(value);
                this._DefaultPaymentDate = value;
                this.OnDefaultPaymentDateChanged();
                this.OnPropertyChanged("DefaultPaymentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultPaymentDate;
        partial void OnDefaultPaymentDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultPaymentDateChanged();
        /// <summary>
        /// There are no comments for Property PayrollCalculationFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCalculationFrequency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayrollCalculationFrequency is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency PayrollCalculationFrequency
        {
            get
            {
                return this._PayrollCalculationFrequency;
            }
            set
            {
                this.OnPayrollCalculationFrequencyChanging(value);
                this._PayrollCalculationFrequency = value;
                this.OnPayrollCalculationFrequencyChanged();
                this.OnPropertyChanged("PayrollCalculationFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency _PayrollCalculationFrequency;
        partial void OnPayrollCalculationFrequencyChanging(global::Microsoft.Dynamics.DataEntities.PayrollCalculationFrequency value);
        partial void OnPayrollCalculationFrequencyChanged();
        /// <summary>
        /// There are no comments for Property PayPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayPeriod is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayPeriod PayPeriod
        {
            get
            {
                return this._PayPeriod;
            }
            set
            {
                this.OnPayPeriodChanging(value);
                this._PayPeriod = value;
                this.OnPayPeriodChanged();
                this.OnPropertyChanged("PayPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayPeriod _PayPeriod;
        partial void OnPayPeriodChanging(global::Microsoft.Dynamics.DataEntities.PayPeriod value);
        partial void OnPayPeriodChanged();
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