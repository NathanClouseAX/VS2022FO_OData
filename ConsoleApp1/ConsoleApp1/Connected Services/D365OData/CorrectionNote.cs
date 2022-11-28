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
    /// There are no comments for CorrectionNoteSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CorrectionNoteSingle")]
    public partial class CorrectionNoteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CorrectionNote>
    {
        /// <summary>
        /// Initialize a new CorrectionNoteSingle object.
        /// </summary>
        public CorrectionNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CorrectionNoteSingle object.
        /// </summary>
        public CorrectionNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CorrectionNoteSingle object.
        /// </summary>
        public CorrectionNoteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CorrectionNote> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CorrectionNote in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CorrectionNote
    /// Invoice
    /// InvoiceAccount
    /// Date
    /// DocumentDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CorrectionNote", "Invoice", "InvoiceAccount", "Date", "DocumentDate")]
    [global::Microsoft.OData.Client.EntitySet("CorrectionNotes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CorrectionNote")]
    public partial class CorrectionNote : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CorrectionNote object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="correctionNote1">Initial value of CorrectionNote1.</param>
        /// <param name="invoice">Initial value of Invoice.</param>
        /// <param name="invoiceAccount">Initial value of InvoiceAccount.</param>
        /// <param name="date">Initial value of Date.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CorrectionNote CreateCorrectionNote(string dataAreaId, 
                    string correctionNote1, 
                    string invoice, 
                    string invoiceAccount, 
                    global::System.DateTimeOffset date, 
                    global::System.DateTimeOffset documentDate)
        {
            CorrectionNote correctionNote = new CorrectionNote();
            correctionNote.DataAreaId = dataAreaId;
            correctionNote.CorrectionNote1 = correctionNote1;
            correctionNote.Invoice = invoice;
            correctionNote.InvoiceAccount = invoiceAccount;
            correctionNote.Date = date;
            correctionNote.DocumentDate = documentDate;
            return correctionNote;
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
        /// There are no comments for Property CorrectionNote1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CorrectionNote")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CorrectionNote1 is required.")]
        public virtual string CorrectionNote1
        {
            get
            {
                return this._CorrectionNote1;
            }
            set
            {
                this.OnCorrectionNote1Changing(value);
                this._CorrectionNote1 = value;
                this.OnCorrectionNote1Changed();
                this.OnPropertyChanged("CorrectionNote");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CorrectionNote1;
        partial void OnCorrectionNote1Changing(string value);
        partial void OnCorrectionNote1Changed();
        /// <summary>
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Invoice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Invoice is required.")]
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
        /// There are no comments for Property InvoiceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoiceAccount is required.")]
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
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Date is required.")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentDate is required.")]
        public virtual global::System.DateTimeOffset DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DocumentDate;
        partial void OnDocumentDateChanging(global::System.DateTimeOffset value);
        partial void OnDocumentDateChanged();
        /// <summary>
        /// There are no comments for Property Posted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Posted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Posted
        {
            get
            {
                return this._Posted;
            }
            set
            {
                this.OnPostedChanging(value);
                this._Posted = value;
                this.OnPostedChanged();
                this.OnPropertyChanged("Posted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Posted;
        partial void OnPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPostedChanged();
        /// <summary>
        /// There are no comments for Property OriginalText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginalText")]
        public virtual string OriginalText
        {
            get
            {
                return this._OriginalText;
            }
            set
            {
                this.OnOriginalTextChanging(value);
                this._OriginalText = value;
                this.OnOriginalTextChanged();
                this.OnPropertyChanged("OriginalText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginalText;
        partial void OnOriginalTextChanging(string value);
        partial void OnOriginalTextChanged();
        /// <summary>
        /// There are no comments for Property CorrectedText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CorrectedText")]
        public virtual string CorrectedText
        {
            get
            {
                return this._CorrectedText;
            }
            set
            {
                this.OnCorrectedTextChanging(value);
                this._CorrectedText = value;
                this.OnCorrectedTextChanged();
                this.OnPropertyChanged("CorrectedText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CorrectedText;
        partial void OnCorrectedTextChanging(string value);
        partial void OnCorrectedTextChanged();
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
