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
    /// There are no comments for CDSProjectContractLineMilestoneSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSProjectContractLineMilestoneSingle")]
    public partial class CDSProjectContractLineMilestoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSProjectContractLineMilestone>
    {
        /// <summary>
        /// Initialize a new CDSProjectContractLineMilestoneSingle object.
        /// </summary>
        public CDSProjectContractLineMilestoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSProjectContractLineMilestoneSingle object.
        /// </summary>
        public CDSProjectContractLineMilestoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSProjectContractLineMilestoneSingle object.
        /// </summary>
        public CDSProjectContractLineMilestoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSProjectContractLineMilestone> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CDSProjectContractLineMilestone in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TransactionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransactionId")]
    [global::Microsoft.OData.Client.EntitySet("CDSProjectContractLineMilestones")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSProjectContractLineMilestone")]
    public partial class CDSProjectContractLineMilestone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSProjectContractLineMilestone object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="contractLineRef">Initial value of ContractLineRef.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSProjectContractLineMilestone CreateCDSProjectContractLineMilestone(string dataAreaId, global::System.Guid transactionId, global::System.DateTimeOffset invoiceDate, global::System.Guid contractLineRef, decimal amount)
        {
            CDSProjectContractLineMilestone cDSProjectContractLineMilestone = new CDSProjectContractLineMilestone();
            cDSProjectContractLineMilestone.DataAreaId = dataAreaId;
            cDSProjectContractLineMilestone.TransactionId = transactionId;
            cDSProjectContractLineMilestone.InvoiceDate = invoiceDate;
            cDSProjectContractLineMilestone.ContractLineRef = contractLineRef;
            cDSProjectContractLineMilestone.Amount = amount;
            return cDSProjectContractLineMilestone;
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
        /// There are no comments for Property TransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionId is required.")]
        public virtual global::System.Guid TransactionId
        {
            get
            {
                return this._TransactionId;
            }
            set
            {
                this.OnTransactionIdChanging(value);
                this._TransactionId = value;
                this.OnTransactionIdChanged();
                this.OnPropertyChanged("TransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _TransactionId;
        partial void OnTransactionIdChanging(global::System.Guid value);
        partial void OnTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property InvoiceDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoiceDate is required.")]
        public virtual global::System.DateTimeOffset InvoiceDate
        {
            get
            {
                return this._InvoiceDate;
            }
            set
            {
                this.OnInvoiceDateChanging(value);
                this._InvoiceDate = value;
                this.OnInvoiceDateChanged();
                this.OnPropertyChanged("InvoiceDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _InvoiceDate;
        partial void OnInvoiceDateChanging(global::System.DateTimeOffset value);
        partial void OnInvoiceDateChanged();
        /// <summary>
        /// There are no comments for Property ContractLineRef in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractLineRef")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContractLineRef is required.")]
        public virtual global::System.Guid ContractLineRef
        {
            get
            {
                return this._ContractLineRef;
            }
            set
            {
                this.OnContractLineRefChanging(value);
                this._ContractLineRef = value;
                this.OnContractLineRefChanged();
                this.OnPropertyChanged("ContractLineRef");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ContractLineRef;
        partial void OnContractLineRefChanging(global::System.Guid value);
        partial void OnContractLineRefChanged();
        /// <summary>
        /// There are no comments for Property CurrencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyId")]
        public virtual string CurrencyId
        {
            get
            {
                return this._CurrencyId;
            }
            set
            {
                this.OnCurrencyIdChanging(value);
                this._CurrencyId = value;
                this.OnCurrencyIdChanged();
                this.OnPropertyChanged("CurrencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyId;
        partial void OnCurrencyIdChanging(string value);
        partial void OnCurrencyIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
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