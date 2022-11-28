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
    /// There are no comments for BusinessDocumentCustPaymScheduleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentCustPaymScheduleSingle")]
    public partial class BusinessDocumentCustPaymScheduleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentCustPaymSchedule>
    {
        /// <summary>
        /// Initialize a new BusinessDocumentCustPaymScheduleSingle object.
        /// </summary>
        public BusinessDocumentCustPaymScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BusinessDocumentCustPaymScheduleSingle object.
        /// </summary>
        public BusinessDocumentCustPaymScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BusinessDocumentCustPaymScheduleSingle object.
        /// </summary>
        public BusinessDocumentCustPaymScheduleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentCustPaymSchedule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BusinessDocumentSalesInvoiceBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentSalesInvoiceBase")]
        public virtual global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBaseSingle BusinessDocumentSalesInvoiceBase
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessDocumentSalesInvoiceBase == null))
                {
                    this._BusinessDocumentSalesInvoiceBase = new global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBaseSingle(this.Context, GetPath("BusinessDocumentSalesInvoiceBase"));
                }
                return this._BusinessDocumentSalesInvoiceBase;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBaseSingle _BusinessDocumentSalesInvoiceBase;
    }
    /// <summary>
    /// There are no comments for BusinessDocumentCustPaymSchedule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ScheduleLineRecId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ScheduleLineRecId")]
    [global::Microsoft.OData.Client.EntitySet("BusinessDocumentCustPaymSchedules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentCustPaymSchedule")]
    public partial class BusinessDocumentCustPaymSchedule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BusinessDocumentCustPaymSchedule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="scheduleLineRecId">Initial value of ScheduleLineRecId.</param>
        /// <param name="dueAmount">Initial value of DueAmount.</param>
        /// <param name="dueDate">Initial value of DueDate.</param>
        /// <param name="discDate">Initial value of DiscDate.</param>
        /// <param name="extRecId">Initial value of ExtRecId.</param>
        /// <param name="extTableId">Initial value of ExtTableId.</param>
        /// <param name="discAmount">Initial value of DiscAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BusinessDocumentCustPaymSchedule CreateBusinessDocumentCustPaymSchedule(string dataAreaId, 
                    long scheduleLineRecId, 
                    decimal dueAmount, 
                    global::System.DateTimeOffset dueDate, 
                    global::System.DateTimeOffset discDate, 
                    long extRecId, 
                    int extTableId, 
                    decimal discAmount)
        {
            BusinessDocumentCustPaymSchedule businessDocumentCustPaymSchedule = new BusinessDocumentCustPaymSchedule();
            businessDocumentCustPaymSchedule.DataAreaId = dataAreaId;
            businessDocumentCustPaymSchedule.ScheduleLineRecId = scheduleLineRecId;
            businessDocumentCustPaymSchedule.DueAmount = dueAmount;
            businessDocumentCustPaymSchedule.DueDate = dueDate;
            businessDocumentCustPaymSchedule.DiscDate = discDate;
            businessDocumentCustPaymSchedule.ExtRecId = extRecId;
            businessDocumentCustPaymSchedule.ExtTableId = extTableId;
            businessDocumentCustPaymSchedule.DiscAmount = discAmount;
            return businessDocumentCustPaymSchedule;
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
        /// There are no comments for Property ScheduleLineRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleLineRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScheduleLineRecId is required.")]
        public virtual long ScheduleLineRecId
        {
            get
            {
                return this._ScheduleLineRecId;
            }
            set
            {
                this.OnScheduleLineRecIdChanging(value);
                this._ScheduleLineRecId = value;
                this.OnScheduleLineRecIdChanged();
                this.OnPropertyChanged("ScheduleLineRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ScheduleLineRecId;
        partial void OnScheduleLineRecIdChanging(long value);
        partial void OnScheduleLineRecIdChanged();
        /// <summary>
        /// There are no comments for Property DueAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DueAmount is required.")]
        public virtual decimal DueAmount
        {
            get
            {
                return this._DueAmount;
            }
            set
            {
                this.OnDueAmountChanging(value);
                this._DueAmount = value;
                this.OnDueAmountChanged();
                this.OnPropertyChanged("DueAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DueAmount;
        partial void OnDueAmountChanging(decimal value);
        partial void OnDueAmountChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DueDate is required.")]
        public virtual global::System.DateTimeOffset DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DueDate;
        partial void OnDueDateChanging(global::System.DateTimeOffset value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property DiscDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscDate is required.")]
        public virtual global::System.DateTimeOffset DiscDate
        {
            get
            {
                return this._DiscDate;
            }
            set
            {
                this.OnDiscDateChanging(value);
                this._DiscDate = value;
                this.OnDiscDateChanged();
                this.OnPropertyChanged("DiscDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DiscDate;
        partial void OnDiscDateChanging(global::System.DateTimeOffset value);
        partial void OnDiscDateChanged();
        /// <summary>
        /// There are no comments for Property ExtRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExtRecId is required.")]
        public virtual long ExtRecId
        {
            get
            {
                return this._ExtRecId;
            }
            set
            {
                this.OnExtRecIdChanging(value);
                this._ExtRecId = value;
                this.OnExtRecIdChanged();
                this.OnPropertyChanged("ExtRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ExtRecId;
        partial void OnExtRecIdChanging(long value);
        partial void OnExtRecIdChanged();
        /// <summary>
        /// There are no comments for Property ExtTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtTableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExtTableId is required.")]
        public virtual int ExtTableId
        {
            get
            {
                return this._ExtTableId;
            }
            set
            {
                this.OnExtTableIdChanging(value);
                this._ExtTableId = value;
                this.OnExtTableIdChanged();
                this.OnPropertyChanged("ExtTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ExtTableId;
        partial void OnExtTableIdChanging(int value);
        partial void OnExtTableIdChanged();
        /// <summary>
        /// There are no comments for Property SplitPayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SplitPayment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SplitPayment
        {
            get
            {
                return this._SplitPayment;
            }
            set
            {
                this.OnSplitPaymentChanging(value);
                this._SplitPayment = value;
                this.OnSplitPaymentChanged();
                this.OnPropertyChanged("SplitPayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SplitPayment;
        partial void OnSplitPaymentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSplitPaymentChanged();
        /// <summary>
        /// There are no comments for Property DiscAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscAmount is required.")]
        public virtual decimal DiscAmount
        {
            get
            {
                return this._DiscAmount;
            }
            set
            {
                this.OnDiscAmountChanging(value);
                this._DiscAmount = value;
                this.OnDiscAmountChanged();
                this.OnPropertyChanged("DiscAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscAmount;
        partial void OnDiscAmountChanging(decimal value);
        partial void OnDiscAmountChanged();
        /// <summary>
        /// There are no comments for Property BusinessDocumentSalesInvoiceBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentSalesInvoiceBase")]
        public virtual global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBase BusinessDocumentSalesInvoiceBase
        {
            get
            {
                return this._BusinessDocumentSalesInvoiceBase;
            }
            set
            {
                this.OnBusinessDocumentSalesInvoiceBaseChanging(value);
                this._BusinessDocumentSalesInvoiceBase = value;
                this.OnBusinessDocumentSalesInvoiceBaseChanged();
                this.OnPropertyChanged("BusinessDocumentSalesInvoiceBase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBase _BusinessDocumentSalesInvoiceBase;
        partial void OnBusinessDocumentSalesInvoiceBaseChanging(global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBase value);
        partial void OnBusinessDocumentSalesInvoiceBaseChanged();
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