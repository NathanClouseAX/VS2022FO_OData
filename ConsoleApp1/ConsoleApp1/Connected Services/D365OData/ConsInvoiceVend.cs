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
    /// There are no comments for ConsInvoiceVendSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConsInvoiceVendSingle")]
    public partial class ConsInvoiceVendSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConsInvoiceVend>
    {
        /// <summary>
        /// Initialize a new ConsInvoiceVendSingle object.
        /// </summary>
        public ConsInvoiceVendSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConsInvoiceVendSingle object.
        /// </summary>
        public ConsInvoiceVendSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConsInvoiceVendSingle object.
        /// </summary>
        public ConsInvoiceVendSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConsInvoiceVend> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ConsInvoiceVend in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ConsolidationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ConsolidationId")]
    [global::Microsoft.OData.Client.EntitySet("ConsInvoicesVend")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConsInvoiceVend")]
    public partial class ConsInvoiceVend : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConsInvoiceVend object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="consolidationId">Initial value of ConsolidationId.</param>
        /// <param name="executionDate">Initial value of ExecutionDate.</param>
        /// <param name="dueDate">Initial value of DueDate.</param>
        /// <param name="consolidationDate">Initial value of ConsolidationDate.</param>
        /// <param name="previouslyPaidAmount">Initial value of PreviouslyPaidAmount.</param>
        /// <param name="previousInvoiceAmount">Initial value of PreviousInvoiceAmount.</param>
        /// <param name="invoiceAmountDuringConsolidationPeriod">Initial value of InvoiceAmountDuringConsolidationPeriod.</param>
        /// <param name="adjustmentAmount">Initial value of AdjustmentAmount.</param>
        /// <param name="salesTax">Initial value of SalesTax.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConsInvoiceVend CreateConsInvoiceVend(string dataAreaId, 
                    string consolidationId, 
                    global::System.DateTimeOffset executionDate, 
                    global::System.DateTimeOffset dueDate, 
                    global::System.DateTimeOffset consolidationDate, 
                    decimal previouslyPaidAmount, 
                    decimal previousInvoiceAmount, 
                    decimal invoiceAmountDuringConsolidationPeriod, 
                    decimal adjustmentAmount, 
                    decimal salesTax)
        {
            ConsInvoiceVend consInvoiceVend = new ConsInvoiceVend();
            consInvoiceVend.DataAreaId = dataAreaId;
            consInvoiceVend.ConsolidationId = consolidationId;
            consInvoiceVend.ExecutionDate = executionDate;
            consInvoiceVend.DueDate = dueDate;
            consInvoiceVend.ConsolidationDate = consolidationDate;
            consInvoiceVend.PreviouslyPaidAmount = previouslyPaidAmount;
            consInvoiceVend.PreviousInvoiceAmount = previousInvoiceAmount;
            consInvoiceVend.InvoiceAmountDuringConsolidationPeriod = invoiceAmountDuringConsolidationPeriod;
            consInvoiceVend.AdjustmentAmount = adjustmentAmount;
            consInvoiceVend.SalesTax = salesTax;
            return consInvoiceVend;
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
        /// There are no comments for Property ConsolidationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsolidationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConsolidationId is required.")]
        public virtual string ConsolidationId
        {
            get
            {
                return this._ConsolidationId;
            }
            set
            {
                this.OnConsolidationIdChanging(value);
                this._ConsolidationId = value;
                this.OnConsolidationIdChanged();
                this.OnPropertyChanged("ConsolidationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConsolidationId;
        partial void OnConsolidationIdChanging(string value);
        partial void OnConsolidationIdChanged();
        /// <summary>
        /// There are no comments for Property ExecutionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExecutionDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExecutionDate is required.")]
        public virtual global::System.DateTimeOffset ExecutionDate
        {
            get
            {
                return this._ExecutionDate;
            }
            set
            {
                this.OnExecutionDateChanging(value);
                this._ExecutionDate = value;
                this.OnExecutionDateChanged();
                this.OnPropertyChanged("ExecutionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExecutionDate;
        partial void OnExecutionDateChanging(global::System.DateTimeOffset value);
        partial void OnExecutionDateChanged();
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendConsInvoiceStatus_JP> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendConsInvoiceStatus_JP> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustVendConsInvoiceStatus_JP> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ReferenceConsolidationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceConsolidationId")]
        public virtual string ReferenceConsolidationId
        {
            get
            {
                return this._ReferenceConsolidationId;
            }
            set
            {
                this.OnReferenceConsolidationIdChanging(value);
                this._ReferenceConsolidationId = value;
                this.OnReferenceConsolidationIdChanged();
                this.OnPropertyChanged("ReferenceConsolidationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceConsolidationId;
        partial void OnReferenceConsolidationIdChanging(string value);
        partial void OnReferenceConsolidationIdChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property ConsolidationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsolidationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConsolidationDate is required.")]
        public virtual global::System.DateTimeOffset ConsolidationDate
        {
            get
            {
                return this._ConsolidationDate;
            }
            set
            {
                this.OnConsolidationDateChanging(value);
                this._ConsolidationDate = value;
                this.OnConsolidationDateChanged();
                this.OnPropertyChanged("ConsolidationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ConsolidationDate;
        partial void OnConsolidationDateChanging(global::System.DateTimeOffset value);
        partial void OnConsolidationDateChanged();
        /// <summary>
        /// There are no comments for Property PreviouslyPaidAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreviouslyPaidAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PreviouslyPaidAmount is required.")]
        public virtual decimal PreviouslyPaidAmount
        {
            get
            {
                return this._PreviouslyPaidAmount;
            }
            set
            {
                this.OnPreviouslyPaidAmountChanging(value);
                this._PreviouslyPaidAmount = value;
                this.OnPreviouslyPaidAmountChanged();
                this.OnPropertyChanged("PreviouslyPaidAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PreviouslyPaidAmount;
        partial void OnPreviouslyPaidAmountChanging(decimal value);
        partial void OnPreviouslyPaidAmountChanged();
        /// <summary>
        /// There are no comments for Property PreviousInvoiceAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreviousInvoiceAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PreviousInvoiceAmount is required.")]
        public virtual decimal PreviousInvoiceAmount
        {
            get
            {
                return this._PreviousInvoiceAmount;
            }
            set
            {
                this.OnPreviousInvoiceAmountChanging(value);
                this._PreviousInvoiceAmount = value;
                this.OnPreviousInvoiceAmountChanged();
                this.OnPropertyChanged("PreviousInvoiceAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PreviousInvoiceAmount;
        partial void OnPreviousInvoiceAmountChanging(decimal value);
        partial void OnPreviousInvoiceAmountChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAmountDuringConsolidationPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceAmountDuringConsolidationPeriod")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoiceAmountDuringConsolidationPeriod is required.")]
        public virtual decimal InvoiceAmountDuringConsolidationPeriod
        {
            get
            {
                return this._InvoiceAmountDuringConsolidationPeriod;
            }
            set
            {
                this.OnInvoiceAmountDuringConsolidationPeriodChanging(value);
                this._InvoiceAmountDuringConsolidationPeriod = value;
                this.OnInvoiceAmountDuringConsolidationPeriodChanged();
                this.OnPropertyChanged("InvoiceAmountDuringConsolidationPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoiceAmountDuringConsolidationPeriod;
        partial void OnInvoiceAmountDuringConsolidationPeriodChanging(decimal value);
        partial void OnInvoiceAmountDuringConsolidationPeriodChanged();
        /// <summary>
        /// There are no comments for Property AdjustmentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustmentAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdjustmentAmount is required.")]
        public virtual decimal AdjustmentAmount
        {
            get
            {
                return this._AdjustmentAmount;
            }
            set
            {
                this.OnAdjustmentAmountChanging(value);
                this._AdjustmentAmount = value;
                this.OnAdjustmentAmountChanged();
                this.OnPropertyChanged("AdjustmentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AdjustmentAmount;
        partial void OnAdjustmentAmountChanging(decimal value);
        partial void OnAdjustmentAmountChanged();
        /// <summary>
        /// There are no comments for Property SalesTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTax")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesTax is required.")]
        public virtual decimal SalesTax
        {
            get
            {
                return this._SalesTax;
            }
            set
            {
                this.OnSalesTaxChanging(value);
                this._SalesTax = value;
                this.OnSalesTaxChanged();
                this.OnPropertyChanged("SalesTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesTax;
        partial void OnSalesTaxChanging(decimal value);
        partial void OnSalesTaxChanged();
        /// <summary>
        /// There are no comments for Property TermsOfPayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TermsOfPayment")]
        public virtual string TermsOfPayment
        {
            get
            {
                return this._TermsOfPayment;
            }
            set
            {
                this.OnTermsOfPaymentChanging(value);
                this._TermsOfPayment = value;
                this.OnTermsOfPaymentChanged();
                this.OnPropertyChanged("TermsOfPayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TermsOfPayment;
        partial void OnTermsOfPaymentChanging(string value);
        partial void OnTermsOfPaymentChanged();
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