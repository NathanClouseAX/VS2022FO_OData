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
    /// There are no comments for SADDocumentInvoiceLineLedgerJournalSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoiceLineLedgerJournalSingle")]
    public partial class SADDocumentInvoiceLineLedgerJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoiceLineLedgerJournal>
    {
        /// <summary>
        /// Initialize a new SADDocumentInvoiceLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoiceLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoiceLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentInvoiceLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoiceLineLedgerJournal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for SADDocumentInvoiceLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoiceLedgerJournal")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournalSingle SADDocumentInvoiceLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentInvoiceLedgerJournal == null))
                {
                    this._SADDocumentInvoiceLedgerJournal = new global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournalSingle(this.Context, GetPath("SADDocumentInvoiceLedgerJournal"));
                }
                return this._SADDocumentInvoiceLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournalSingle _SADDocumentInvoiceLedgerJournal;
        /// <summary>
        /// There are no comments for SADDocumentLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentLineLedgerJournal")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournalSingle SADDocumentLineLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentLineLedgerJournal == null))
                {
                    this._SADDocumentLineLedgerJournal = new global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournalSingle(this.Context, GetPath("SADDocumentLineLedgerJournal"));
                }
                return this._SADDocumentLineLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournalSingle _SADDocumentLineLedgerJournal;
    }
    /// <summary>
    /// There are no comments for SADDocumentInvoiceLineLedgerJournal in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecordId")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentInvoiceLineLedgerJournals")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoiceLineLedgerJournal")]
    public partial class SADDocumentInvoiceLineLedgerJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentInvoiceLineLedgerJournal object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="sADDate">Initial value of SADDate.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="sADDocumentInvoiceLedgerJournal">Initial value of SADDocumentInvoiceLedgerJournal.</param>
        /// <param name="sADDocumentLineLedgerJournal">Initial value of SADDocumentLineLedgerJournal.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentInvoiceLineLedgerJournal CreateSADDocumentInvoiceLineLedgerJournal(string dataAreaId, 
                    long recordId, 
                    global::System.DateTimeOffset sADDate, 
                    global::System.DateTimeOffset invoiceDate, 
                    int position, 
                    decimal amount, 
                    global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal sADDocumentInvoiceLedgerJournal, 
                    global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal sADDocumentLineLedgerJournal)
        {
            SADDocumentInvoiceLineLedgerJournal sADDocumentInvoiceLineLedgerJournal = new SADDocumentInvoiceLineLedgerJournal();
            sADDocumentInvoiceLineLedgerJournal.DataAreaId = dataAreaId;
            sADDocumentInvoiceLineLedgerJournal.RecordId = recordId;
            sADDocumentInvoiceLineLedgerJournal.SADDate = sADDate;
            sADDocumentInvoiceLineLedgerJournal.InvoiceDate = invoiceDate;
            sADDocumentInvoiceLineLedgerJournal.Position = position;
            sADDocumentInvoiceLineLedgerJournal.Amount = amount;
            if ((sADDocumentInvoiceLedgerJournal == null))
            {
                throw new global::System.ArgumentNullException("sADDocumentInvoiceLedgerJournal");
            }
            sADDocumentInvoiceLineLedgerJournal.SADDocumentInvoiceLedgerJournal = sADDocumentInvoiceLedgerJournal;
            if ((sADDocumentLineLedgerJournal == null))
            {
                throw new global::System.ArgumentNullException("sADDocumentLineLedgerJournal");
            }
            sADDocumentInvoiceLineLedgerJournal.SADDocumentLineLedgerJournal = sADDocumentLineLedgerJournal;
            return sADDocumentInvoiceLineLedgerJournal;
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
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Invoice")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
        /// <summary>
        /// There are no comments for Property SADDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SADDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SADDate is required.")]
        public virtual global::System.DateTimeOffset SADDate
        {
            get
            {
                return this._SADDate;
            }
            set
            {
                this.OnSADDateChanging(value);
                this._SADDate = value;
                this.OnSADDateChanged();
                this.OnPropertyChanged("SADDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SADDate;
        partial void OnSADDateChanging(global::System.DateTimeOffset value);
        partial void OnSADDateChanged();
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
        /// There are no comments for Property SADNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SADNumber")]
        public virtual string SADNumber
        {
            get
            {
                return this._SADNumber;
            }
            set
            {
                this.OnSADNumberChanging(value);
                this._SADNumber = value;
                this.OnSADNumberChanged();
                this.OnPropertyChanged("SADNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADNumber;
        partial void OnSADNumberChanging(string value);
        partial void OnSADNumberChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAccountDisplayValue")]
        public virtual string LedgerAccountDisplayValue
        {
            get
            {
                return this._LedgerAccountDisplayValue;
            }
            set
            {
                this.OnLedgerAccountDisplayValueChanging(value);
                this._LedgerAccountDisplayValue = value;
                this.OnLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("LedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerAccountDisplayValue;
        partial void OnLedgerAccountDisplayValueChanging(string value);
        partial void OnLedgerAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Position")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Position is required.")]
        public virtual int Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Position;
        partial void OnPositionChanging(int value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property ItemCommodityCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCommodityCode")]
        public virtual string ItemCommodityCode
        {
            get
            {
                return this._ItemCommodityCode;
            }
            set
            {
                this.OnItemCommodityCodeChanging(value);
                this._ItemCommodityCode = value;
                this.OnItemCommodityCodeChanged();
                this.OnPropertyChanged("ItemCommodityCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemCommodityCode;
        partial void OnItemCommodityCodeChanging(string value);
        partial void OnItemCommodityCodeChanged();
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
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentInvoiceLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoiceLedgerJournal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SADDocumentInvoiceLedgerJournal is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal SADDocumentInvoiceLedgerJournal
        {
            get
            {
                return this._SADDocumentInvoiceLedgerJournal;
            }
            set
            {
                this.OnSADDocumentInvoiceLedgerJournalChanging(value);
                this._SADDocumentInvoiceLedgerJournal = value;
                this.OnSADDocumentInvoiceLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentInvoiceLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal _SADDocumentInvoiceLedgerJournal;
        partial void OnSADDocumentInvoiceLedgerJournalChanging(global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLedgerJournal value);
        partial void OnSADDocumentInvoiceLedgerJournalChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentLineLedgerJournal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SADDocumentLineLedgerJournal is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal SADDocumentLineLedgerJournal
        {
            get
            {
                return this._SADDocumentLineLedgerJournal;
            }
            set
            {
                this.OnSADDocumentLineLedgerJournalChanging(value);
                this._SADDocumentLineLedgerJournal = value;
                this.OnSADDocumentLineLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentLineLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal _SADDocumentLineLedgerJournal;
        partial void OnSADDocumentLineLedgerJournalChanging(global::Microsoft.Dynamics.DataEntities.SADDocumentLineLedgerJournal value);
        partial void OnSADDocumentLineLedgerJournalChanged();
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
