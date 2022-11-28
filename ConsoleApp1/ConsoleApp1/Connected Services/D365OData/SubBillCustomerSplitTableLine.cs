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
    /// There are no comments for SubBillCustomerSplitTableLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillCustomerSplitTableLineSingle")]
    public partial class SubBillCustomerSplitTableLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillCustomerSplitTableLine>
    {
        /// <summary>
        /// Initialize a new SubBillCustomerSplitTableLineSingle object.
        /// </summary>
        public SubBillCustomerSplitTableLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillCustomerSplitTableLineSingle object.
        /// </summary>
        public SubBillCustomerSplitTableLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillCustomerSplitTableLineSingle object.
        /// </summary>
        public SubBillCustomerSplitTableLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillCustomerSplitTableLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillCustomerSplitTableLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ScheduleNumber
    /// ScheduleLineNum
    /// CustAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ScheduleNumber", "ScheduleLineNum", "CustAccount")]
    [global::Microsoft.OData.Client.EntitySet("SubBillCustomerSplitTableLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillCustomerSplitTableLine")]
    public partial class SubBillCustomerSplitTableLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillCustomerSplitTableLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="scheduleNumber">Initial value of ScheduleNumber.</param>
        /// <param name="scheduleLineNum">Initial value of ScheduleLineNum.</param>
        /// <param name="custAccount">Initial value of CustAccount.</param>
        /// <param name="billingStartDate">Initial value of BillingStartDate.</param>
        /// <param name="billingEndDate">Initial value of BillingEndDate.</param>
        /// <param name="percentage">Initial value of Percentage.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillCustomerSplitTableLine CreateSubBillCustomerSplitTableLine(string dataAreaId, 
                    string scheduleNumber, 
                    decimal scheduleLineNum, 
                    string custAccount, 
                    global::System.DateTimeOffset billingStartDate, 
                    global::System.DateTimeOffset billingEndDate, 
                    decimal percentage, 
                    decimal lineNum)
        {
            SubBillCustomerSplitTableLine subBillCustomerSplitTableLine = new SubBillCustomerSplitTableLine();
            subBillCustomerSplitTableLine.DataAreaId = dataAreaId;
            subBillCustomerSplitTableLine.ScheduleNumber = scheduleNumber;
            subBillCustomerSplitTableLine.ScheduleLineNum = scheduleLineNum;
            subBillCustomerSplitTableLine.CustAccount = custAccount;
            subBillCustomerSplitTableLine.BillingStartDate = billingStartDate;
            subBillCustomerSplitTableLine.BillingEndDate = billingEndDate;
            subBillCustomerSplitTableLine.Percentage = percentage;
            subBillCustomerSplitTableLine.LineNum = lineNum;
            return subBillCustomerSplitTableLine;
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
        /// There are no comments for Property ScheduleLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScheduleLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScheduleLineNum is required.")]
        public virtual decimal ScheduleLineNum
        {
            get
            {
                return this._ScheduleLineNum;
            }
            set
            {
                this.OnScheduleLineNumChanging(value);
                this._ScheduleLineNum = value;
                this.OnScheduleLineNumChanged();
                this.OnPropertyChanged("ScheduleLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ScheduleLineNum;
        partial void OnScheduleLineNumChanging(decimal value);
        partial void OnScheduleLineNumChanged();
        /// <summary>
        /// There are no comments for Property CustAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustAccount is required.")]
        public virtual string CustAccount
        {
            get
            {
                return this._CustAccount;
            }
            set
            {
                this.OnCustAccountChanging(value);
                this._CustAccount = value;
                this.OnCustAccountChanged();
                this.OnPropertyChanged("CustAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustAccount;
        partial void OnCustAccountChanging(string value);
        partial void OnCustAccountChanged();
        /// <summary>
        /// There are no comments for Property BillingStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingStartDate is required.")]
        public virtual global::System.DateTimeOffset BillingStartDate
        {
            get
            {
                return this._BillingStartDate;
            }
            set
            {
                this.OnBillingStartDateChanging(value);
                this._BillingStartDate = value;
                this.OnBillingStartDateChanged();
                this.OnPropertyChanged("BillingStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BillingStartDate;
        partial void OnBillingStartDateChanging(global::System.DateTimeOffset value);
        partial void OnBillingStartDateChanged();
        /// <summary>
        /// There are no comments for Property ProjLinePropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjLinePropertyId")]
        public virtual string ProjLinePropertyId
        {
            get
            {
                return this._ProjLinePropertyId;
            }
            set
            {
                this.OnProjLinePropertyIdChanging(value);
                this._ProjLinePropertyId = value;
                this.OnProjLinePropertyIdChanged();
                this.OnPropertyChanged("ProjLinePropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjLinePropertyId;
        partial void OnProjLinePropertyIdChanging(string value);
        partial void OnProjLinePropertyIdChanged();
        /// <summary>
        /// There are no comments for Property ProjCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCategoryId")]
        public virtual string ProjCategoryId
        {
            get
            {
                return this._ProjCategoryId;
            }
            set
            {
                this.OnProjCategoryIdChanging(value);
                this._ProjCategoryId = value;
                this.OnProjCategoryIdChanged();
                this.OnPropertyChanged("ProjCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjCategoryId;
        partial void OnProjCategoryIdChanging(string value);
        partial void OnProjCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property BillingEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingEndDate is required.")]
        public virtual global::System.DateTimeOffset BillingEndDate
        {
            get
            {
                return this._BillingEndDate;
            }
            set
            {
                this.OnBillingEndDateChanging(value);
                this._BillingEndDate = value;
                this.OnBillingEndDateChanged();
                this.OnPropertyChanged("BillingEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BillingEndDate;
        partial void OnBillingEndDateChanging(global::System.DateTimeOffset value);
        partial void OnBillingEndDateChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceAccount")]
        public virtual string InvoiceAccount
        {
            get
            {
                return this._InvoiceAccount;
            }
            set
            {
                this.OnInvoiceAccountChanging(value);
                this._InvoiceAccount = value;
                this.OnInvoiceAccountChanged();
                this.OnPropertyChanged("InvoiceAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceAccount;
        partial void OnInvoiceAccountChanging(string value);
        partial void OnInvoiceAccountChanged();
        /// <summary>
        /// There are no comments for Property Percentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Percentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Percentage is required.")]
        public virtual decimal Percentage
        {
            get
            {
                return this._Percentage;
            }
            set
            {
                this.OnPercentageChanging(value);
                this._Percentage = value;
                this.OnPercentageChanged();
                this.OnPropertyChanged("Percentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percentage;
        partial void OnPercentageChanging(decimal value);
        partial void OnPercentageChanged();
        /// <summary>
        /// There are no comments for Property ProjId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjId")]
        public virtual string ProjId
        {
            get
            {
                return this._ProjId;
            }
            set
            {
                this.OnProjIdChanging(value);
                this._ProjId = value;
                this.OnProjIdChanged();
                this.OnPropertyChanged("ProjId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjId;
        partial void OnProjIdChanging(string value);
        partial void OnProjIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerRequisition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRequisition")]
        public virtual string CustomerRequisition
        {
            get
            {
                return this._CustomerRequisition;
            }
            set
            {
                this.OnCustomerRequisitionChanging(value);
                this._CustomerRequisition = value;
                this.OnCustomerRequisitionChanged();
                this.OnPropertyChanged("CustomerRequisition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerRequisition;
        partial void OnCustomerRequisitionChanging(string value);
        partial void OnCustomerRequisitionChanged();
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
        /// There are no comments for Property DeliveryAddressName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryAddressName")]
        public virtual string DeliveryAddressName
        {
            get
            {
                return this._DeliveryAddressName;
            }
            set
            {
                this.OnDeliveryAddressNameChanging(value);
                this._DeliveryAddressName = value;
                this.OnDeliveryAddressNameChanged();
                this.OnPropertyChanged("DeliveryAddressName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryAddressName;
        partial void OnDeliveryAddressNameChanging(string value);
        partial void OnDeliveryAddressNameChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Email")]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property CustomerReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerReference")]
        public virtual string CustomerReference
        {
            get
            {
                return this._CustomerReference;
            }
            set
            {
                this.OnCustomerReferenceChanging(value);
                this._CustomerReference = value;
                this.OnCustomerReferenceChanged();
                this.OnPropertyChanged("CustomerReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerReference;
        partial void OnCustomerReferenceChanging(string value);
        partial void OnCustomerReferenceChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermId")]
        public virtual string PaymentTermId
        {
            get
            {
                return this._PaymentTermId;
            }
            set
            {
                this.OnPaymentTermIdChanging(value);
                this._PaymentTermId = value;
                this.OnPaymentTermIdChanged();
                this.OnPropertyChanged("PaymentTermId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentTermId;
        partial void OnPaymentTermIdChanging(string value);
        partial void OnPaymentTermIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMethod")]
        public virtual string PaymentMethod
        {
            get
            {
                return this._PaymentMethod;
            }
            set
            {
                this.OnPaymentMethodChanging(value);
                this._PaymentMethod = value;
                this.OnPaymentMethodChanged();
                this.OnPropertyChanged("PaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMethod;
        partial void OnPaymentMethodChanging(string value);
        partial void OnPaymentMethodChanged();
        /// <summary>
        /// There are no comments for Property BillingAddressName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingAddressName")]
        public virtual string BillingAddressName
        {
            get
            {
                return this._BillingAddressName;
            }
            set
            {
                this.OnBillingAddressNameChanging(value);
                this._BillingAddressName = value;
                this.OnBillingAddressNameChanged();
                this.OnPropertyChanged("BillingAddressName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingAddressName;
        partial void OnBillingAddressNameChanging(string value);
        partial void OnBillingAddressNameChanged();
        /// <summary>
        /// There are no comments for Property InternetAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternetAddress")]
        public virtual string InternetAddress
        {
            get
            {
                return this._InternetAddress;
            }
            set
            {
                this.OnInternetAddressChanging(value);
                this._InternetAddress = value;
                this.OnInternetAddressChanged();
                this.OnPropertyChanged("InternetAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternetAddress;
        partial void OnInternetAddressChanging(string value);
        partial void OnInternetAddressChanged();
        /// <summary>
        /// There are no comments for Property EndUserAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndUserAccount")]
        public virtual string EndUserAccount
        {
            get
            {
                return this._EndUserAccount;
            }
            set
            {
                this.OnEndUserAccountChanging(value);
                this._EndUserAccount = value;
                this.OnEndUserAccountChanged();
                this.OnPropertyChanged("EndUserAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EndUserAccount;
        partial void OnEndUserAccountChanging(string value);
        partial void OnEndUserAccountChanged();
        /// <summary>
        /// There are no comments for Property PaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentSchedule")]
        public virtual string PaymentSchedule
        {
            get
            {
                return this._PaymentSchedule;
            }
            set
            {
                this.OnPaymentScheduleChanging(value);
                this._PaymentSchedule = value;
                this.OnPaymentScheduleChanged();
                this.OnPropertyChanged("PaymentSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentSchedule;
        partial void OnPaymentScheduleChanging(string value);
        partial void OnPaymentScheduleChanged();
        /// <summary>
        /// There are no comments for Property ContactPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPerson")]
        public virtual string ContactPerson
        {
            get
            {
                return this._ContactPerson;
            }
            set
            {
                this.OnContactPersonChanging(value);
                this._ContactPerson = value;
                this.OnContactPersonChanged();
                this.OnPropertyChanged("ContactPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactPerson;
        partial void OnContactPersonChanging(string value);
        partial void OnContactPersonChanged();
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
