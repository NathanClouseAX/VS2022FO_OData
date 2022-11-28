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
    /// There are no comments for DocumentProjInvoiceRevenueLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentProjInvoiceRevenueLineSingle")]
    public partial class DocumentProjInvoiceRevenueLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentProjInvoiceRevenueLine>
    {
        /// <summary>
        /// Initialize a new DocumentProjInvoiceRevenueLineSingle object.
        /// </summary>
        public DocumentProjInvoiceRevenueLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DocumentProjInvoiceRevenueLineSingle object.
        /// </summary>
        public DocumentProjInvoiceRevenueLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DocumentProjInvoiceRevenueLineSingle object.
        /// </summary>
        public DocumentProjInvoiceRevenueLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentProjInvoiceRevenueLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DocumentProjectInvoiceBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentProjectInvoiceBase")]
        public virtual global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBaseSingle DocumentProjectInvoiceBase
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DocumentProjectInvoiceBase == null))
                {
                    this._DocumentProjectInvoiceBase = new global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBaseSingle(this.Context, GetPath("DocumentProjectInvoiceBase"));
                }
                return this._DocumentProjectInvoiceBase;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBaseSingle _DocumentProjectInvoiceBase;
        /// <summary>
        /// There are no comments for BusinessDocumentTaxTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentTaxTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction> BusinessDocumentTaxTransaction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessDocumentTaxTransaction == null))
                {
                    this._BusinessDocumentTaxTransaction = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction>(GetPath("BusinessDocumentTaxTransaction"));
                }
                return this._BusinessDocumentTaxTransaction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction> _BusinessDocumentTaxTransaction;
    }
    /// <summary>
    /// There are no comments for DocumentProjInvoiceRevenueLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TransId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransId")]
    [global::Microsoft.OData.Client.EntitySet("DocumentProjInvoiceRevenueLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentProjInvoiceRevenueLine")]
    public partial class DocumentProjInvoiceRevenueLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DocumentProjInvoiceRevenueLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="transId">Initial value of TransId.</param>
        /// <param name="invoiceDate">Initial value of InvoiceDate.</param>
        /// <param name="projInvoiceRevenueTableId">Initial value of ProjInvoiceRevenueTableId.</param>
        /// <param name="projInvoiceRevenueRecId">Initial value of ProjInvoiceRevenueRecId.</param>
        /// <param name="taxAmount">Initial value of TaxAmount.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="salesPrice">Initial value of SalesPrice.</param>
        /// <param name="lineAmount">Initial value of LineAmount.</param>
        /// <param name="qty">Initial value of Qty.</param>
        /// <param name="documentProjectInvoiceBase">Initial value of DocumentProjectInvoiceBase.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DocumentProjInvoiceRevenueLine CreateDocumentProjInvoiceRevenueLine(string dataAreaId, 
                    string transId, 
                    global::System.DateTimeOffset invoiceDate, 
                    int projInvoiceRevenueTableId, 
                    long projInvoiceRevenueRecId, 
                    decimal taxAmount, 
                    global::System.DateTimeOffset transDate, 
                    decimal salesPrice, 
                    decimal lineAmount, 
                    decimal qty, 
                    global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBase documentProjectInvoiceBase)
        {
            DocumentProjInvoiceRevenueLine documentProjInvoiceRevenueLine = new DocumentProjInvoiceRevenueLine();
            documentProjInvoiceRevenueLine.DataAreaId = dataAreaId;
            documentProjInvoiceRevenueLine.TransId = transId;
            documentProjInvoiceRevenueLine.InvoiceDate = invoiceDate;
            documentProjInvoiceRevenueLine.ProjInvoiceRevenueTableId = projInvoiceRevenueTableId;
            documentProjInvoiceRevenueLine.ProjInvoiceRevenueRecId = projInvoiceRevenueRecId;
            documentProjInvoiceRevenueLine.TaxAmount = taxAmount;
            documentProjInvoiceRevenueLine.TransDate = transDate;
            documentProjInvoiceRevenueLine.SalesPrice = salesPrice;
            documentProjInvoiceRevenueLine.LineAmount = lineAmount;
            documentProjInvoiceRevenueLine.Qty = qty;
            if ((documentProjectInvoiceBase == null))
            {
                throw new global::System.ArgumentNullException("documentProjectInvoiceBase");
            }
            documentProjInvoiceRevenueLine.DocumentProjectInvoiceBase = documentProjectInvoiceBase;
            return documentProjInvoiceRevenueLine;
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
        /// There are no comments for Property TransId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransId is required.")]
        public virtual string TransId
        {
            get
            {
                return this._TransId;
            }
            set
            {
                this.OnTransIdChanging(value);
                this._TransId = value;
                this.OnTransIdChanged();
                this.OnPropertyChanged("TransId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransId;
        partial void OnTransIdChanging(string value);
        partial void OnTransIdChanged();
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
        /// There are no comments for Property DataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataArea")]
        public virtual string DataArea
        {
            get
            {
                return this._DataArea;
            }
            set
            {
                this.OnDataAreaChanging(value);
                this._DataArea = value;
                this.OnDataAreaChanged();
                this.OnPropertyChanged("DataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataArea;
        partial void OnDataAreaChanging(string value);
        partial void OnDataAreaChanged();
        /// <summary>
        /// There are no comments for Property ProjInvoiceRevenueTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjInvoiceRevenueTableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjInvoiceRevenueTableId is required.")]
        public virtual int ProjInvoiceRevenueTableId
        {
            get
            {
                return this._ProjInvoiceRevenueTableId;
            }
            set
            {
                this.OnProjInvoiceRevenueTableIdChanging(value);
                this._ProjInvoiceRevenueTableId = value;
                this.OnProjInvoiceRevenueTableIdChanged();
                this.OnPropertyChanged("ProjInvoiceRevenueTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ProjInvoiceRevenueTableId;
        partial void OnProjInvoiceRevenueTableIdChanging(int value);
        partial void OnProjInvoiceRevenueTableIdChanged();
        /// <summary>
        /// There are no comments for Property ProjInvoiceRevenueRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjInvoiceRevenueRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjInvoiceRevenueRecId is required.")]
        public virtual long ProjInvoiceRevenueRecId
        {
            get
            {
                return this._ProjInvoiceRevenueRecId;
            }
            set
            {
                this.OnProjInvoiceRevenueRecIdChanging(value);
                this._ProjInvoiceRevenueRecId = value;
                this.OnProjInvoiceRevenueRecIdChanged();
                this.OnPropertyChanged("ProjInvoiceRevenueRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ProjInvoiceRevenueRecId;
        partial void OnProjInvoiceRevenueRecIdChanging(long value);
        partial void OnProjInvoiceRevenueRecIdChanged();
        /// <summary>
        /// There are no comments for Property TaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxAmount is required.")]
        public virtual decimal TaxAmount
        {
            get
            {
                return this._TaxAmount;
            }
            set
            {
                this.OnTaxAmountChanging(value);
                this._TaxAmount = value;
                this.OnTaxAmountChanged();
                this.OnPropertyChanged("TaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TaxAmount;
        partial void OnTaxAmountChanging(decimal value);
        partial void OnTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property TransDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransDate is required.")]
        public virtual global::System.DateTimeOffset TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                this.OnTransDateChanging(value);
                this._TransDate = value;
                this.OnTransDateChanged();
                this.OnPropertyChanged("TransDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransDate;
        partial void OnTransDateChanging(global::System.DateTimeOffset value);
        partial void OnTransDateChanged();
        /// <summary>
        /// There are no comments for Property LedgerVoucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerVoucher")]
        public virtual string LedgerVoucher
        {
            get
            {
                return this._LedgerVoucher;
            }
            set
            {
                this.OnLedgerVoucherChanging(value);
                this._LedgerVoucher = value;
                this.OnLedgerVoucherChanged();
                this.OnPropertyChanged("LedgerVoucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerVoucher;
        partial void OnLedgerVoucherChanging(string value);
        partial void OnLedgerVoucherChanged();
        /// <summary>
        /// There are no comments for Property SalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesPrice is required.")]
        public virtual decimal SalesPrice
        {
            get
            {
                return this._SalesPrice;
            }
            set
            {
                this.OnSalesPriceChanging(value);
                this._SalesPrice = value;
                this.OnSalesPriceChanged();
                this.OnPropertyChanged("SalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesPrice;
        partial void OnSalesPriceChanging(decimal value);
        partial void OnSalesPriceChanged();
        /// <summary>
        /// There are no comments for Property ProjInvoiceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjInvoiceId")]
        public virtual string ProjInvoiceId
        {
            get
            {
                return this._ProjInvoiceId;
            }
            set
            {
                this.OnProjInvoiceIdChanging(value);
                this._ProjInvoiceId = value;
                this.OnProjInvoiceIdChanged();
                this.OnPropertyChanged("ProjInvoiceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjInvoiceId;
        partial void OnProjInvoiceIdChanging(string value);
        partial void OnProjInvoiceIdChanged();
        /// <summary>
        /// There are no comments for Property Txt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Txt")]
        public virtual string Txt
        {
            get
            {
                return this._Txt;
            }
            set
            {
                this.OnTxtChanging(value);
                this._Txt = value;
                this.OnTxtChanged();
                this.OnPropertyChanged("Txt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Txt;
        partial void OnTxtChanging(string value);
        partial void OnTxtChanged();
        /// <summary>
        /// There are no comments for Property LineAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineAmount is required.")]
        public virtual decimal LineAmount
        {
            get
            {
                return this._LineAmount;
            }
            set
            {
                this.OnLineAmountChanging(value);
                this._LineAmount = value;
                this.OnLineAmountChanged();
                this.OnPropertyChanged("LineAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineAmount;
        partial void OnLineAmountChanging(decimal value);
        partial void OnLineAmountChanged();
        /// <summary>
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupId")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Qty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Qty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Qty is required.")]
        public virtual decimal Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this.OnQtyChanging(value);
                this._Qty = value;
                this.OnQtyChanged();
                this.OnPropertyChanged("Qty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Qty;
        partial void OnQtyChanging(decimal value);
        partial void OnQtyChanged();
        /// <summary>
        /// There are no comments for Property DocumentProjectInvoiceBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentProjectInvoiceBase")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentProjectInvoiceBase is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBase DocumentProjectInvoiceBase
        {
            get
            {
                return this._DocumentProjectInvoiceBase;
            }
            set
            {
                this.OnDocumentProjectInvoiceBaseChanging(value);
                this._DocumentProjectInvoiceBase = value;
                this.OnDocumentProjectInvoiceBaseChanged();
                this.OnPropertyChanged("DocumentProjectInvoiceBase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBase _DocumentProjectInvoiceBase;
        partial void OnDocumentProjectInvoiceBaseChanging(global::Microsoft.Dynamics.DataEntities.DocumentProjectInvoiceBase value);
        partial void OnDocumentProjectInvoiceBaseChanged();
        /// <summary>
        /// There are no comments for Property BusinessDocumentTaxTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentTaxTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction> BusinessDocumentTaxTransaction
        {
            get
            {
                return this._BusinessDocumentTaxTransaction;
            }
            set
            {
                this.OnBusinessDocumentTaxTransactionChanging(value);
                this._BusinessDocumentTaxTransaction = value;
                this.OnBusinessDocumentTaxTransactionChanged();
                this.OnPropertyChanged("BusinessDocumentTaxTransaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction> _BusinessDocumentTaxTransaction = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBusinessDocumentTaxTransactionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BusinessDocumentTaxTransaction> value);
        partial void OnBusinessDocumentTaxTransactionChanged();
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
