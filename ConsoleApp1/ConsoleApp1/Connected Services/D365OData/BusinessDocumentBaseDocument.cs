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
    /// There are no comments for BusinessDocumentBaseDocumentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentBaseDocumentSingle")]
    public partial class BusinessDocumentBaseDocumentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentBaseDocument>
    {
        /// <summary>
        /// Initialize a new BusinessDocumentBaseDocumentSingle object.
        /// </summary>
        public BusinessDocumentBaseDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BusinessDocumentBaseDocumentSingle object.
        /// </summary>
        public BusinessDocumentBaseDocumentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BusinessDocumentBaseDocumentSingle object.
        /// </summary>
        public BusinessDocumentBaseDocumentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentBaseDocument> query)
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
    /// There are no comments for BusinessDocumentBaseDocument in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BaseDocumentRecId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BaseDocumentRecId")]
    [global::Microsoft.OData.Client.EntitySet("BusinessDocumentBaseDocuments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentBaseDocument")]
    public partial class BusinessDocumentBaseDocument : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BusinessDocumentBaseDocument object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="baseDocumentRecId">Initial value of BaseDocumentRecId.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        /// <param name="refRecId">Initial value of RefRecId.</param>
        /// <param name="refTableId">Initial value of RefTableId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="businessDocumentSalesInvoiceBase">Initial value of BusinessDocumentSalesInvoiceBase.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BusinessDocumentBaseDocument CreateBusinessDocumentBaseDocument(string dataAreaId, 
                    long baseDocumentRecId, 
                    global::System.DateTimeOffset documentDate, 
                    long refRecId, 
                    int refTableId, 
                    int lineNumber, 
                    global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBase businessDocumentSalesInvoiceBase)
        {
            BusinessDocumentBaseDocument businessDocumentBaseDocument = new BusinessDocumentBaseDocument();
            businessDocumentBaseDocument.DataAreaId = dataAreaId;
            businessDocumentBaseDocument.BaseDocumentRecId = baseDocumentRecId;
            businessDocumentBaseDocument.DocumentDate = documentDate;
            businessDocumentBaseDocument.RefRecId = refRecId;
            businessDocumentBaseDocument.RefTableId = refTableId;
            businessDocumentBaseDocument.LineNumber = lineNumber;
            if ((businessDocumentSalesInvoiceBase == null))
            {
                throw new global::System.ArgumentNullException("businessDocumentSalesInvoiceBase");
            }
            businessDocumentBaseDocument.BusinessDocumentSalesInvoiceBase = businessDocumentSalesInvoiceBase;
            return businessDocumentBaseDocument;
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
        /// There are no comments for Property BaseDocumentRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseDocumentRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BaseDocumentRecId is required.")]
        public virtual long BaseDocumentRecId
        {
            get
            {
                return this._BaseDocumentRecId;
            }
            set
            {
                this.OnBaseDocumentRecIdChanging(value);
                this._BaseDocumentRecId = value;
                this.OnBaseDocumentRecIdChanged();
                this.OnPropertyChanged("BaseDocumentRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _BaseDocumentRecId;
        partial void OnBaseDocumentRecIdChanging(long value);
        partial void OnBaseDocumentRecIdChanged();
        /// <summary>
        /// There are no comments for Property CIPEcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CIPEcode")]
        public virtual string CIPEcode
        {
            get
            {
                return this._CIPEcode;
            }
            set
            {
                this.OnCIPEcodeChanging(value);
                this._CIPEcode = value;
                this.OnCIPEcodeChanged();
                this.OnPropertyChanged("CIPEcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CIPEcode;
        partial void OnCIPEcodeChanging(string value);
        partial void OnCIPEcodeChanged();
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
        /// There are no comments for Property OrderOrAgreementCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderOrAgreementCode")]
        public virtual string OrderOrAgreementCode
        {
            get
            {
                return this._OrderOrAgreementCode;
            }
            set
            {
                this.OnOrderOrAgreementCodeChanging(value);
                this._OrderOrAgreementCode = value;
                this.OnOrderOrAgreementCodeChanged();
                this.OnPropertyChanged("OrderOrAgreementCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderOrAgreementCode;
        partial void OnOrderOrAgreementCodeChanging(string value);
        partial void OnOrderOrAgreementCodeChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
        public virtual string DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentNumber;
        partial void OnDocumentNumberChanging(string value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property TenderCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TenderCode")]
        public virtual string TenderCode
        {
            get
            {
                return this._TenderCode;
            }
            set
            {
                this.OnTenderCodeChanging(value);
                this._TenderCode = value;
                this.OnTenderCodeChanged();
                this.OnPropertyChanged("TenderCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TenderCode;
        partial void OnTenderCodeChanging(string value);
        partial void OnTenderCodeChanged();
        /// <summary>
        /// There are no comments for Property RefRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefRecId is required.")]
        public virtual long RefRecId
        {
            get
            {
                return this._RefRecId;
            }
            set
            {
                this.OnRefRecIdChanging(value);
                this._RefRecId = value;
                this.OnRefRecIdChanged();
                this.OnPropertyChanged("RefRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RefRecId;
        partial void OnRefRecIdChanging(long value);
        partial void OnRefRecIdChanged();
        /// <summary>
        /// There are no comments for Property SalesId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesId")]
        public virtual string SalesId
        {
            get
            {
                return this._SalesId;
            }
            set
            {
                this.OnSalesIdChanging(value);
                this._SalesId = value;
                this.OnSalesIdChanged();
                this.OnPropertyChanged("SalesId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesId;
        partial void OnSalesIdChanging(string value);
        partial void OnSalesIdChanged();
        /// <summary>
        /// There are no comments for Property DocumentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocumentType_IT> DocumentType
        {
            get
            {
                return this._DocumentType;
            }
            set
            {
                this.OnDocumentTypeChanging(value);
                this._DocumentType = value;
                this.OnDocumentTypeChanged();
                this.OnPropertyChanged("DocumentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocumentType_IT> _DocumentType;
        partial void OnDocumentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocumentType_IT> value);
        partial void OnDocumentTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentTypeStr in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTypeStr")]
        public virtual string DocumentTypeStr
        {
            get
            {
                return this._DocumentTypeStr;
            }
            set
            {
                this.OnDocumentTypeStrChanging(value);
                this._DocumentTypeStr = value;
                this.OnDocumentTypeStrChanged();
                this.OnPropertyChanged("DocumentTypeStr");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentTypeStr;
        partial void OnDocumentTypeStrChanging(string value);
        partial void OnDocumentTypeStrChanged();
        /// <summary>
        /// There are no comments for Property RefTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefTableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefTableId is required.")]
        public virtual int RefTableId
        {
            get
            {
                return this._RefTableId;
            }
            set
            {
                this.OnRefTableIdChanging(value);
                this._RefTableId = value;
                this.OnRefTableIdChanged();
                this.OnPropertyChanged("RefTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RefTableId;
        partial void OnRefTableIdChanging(int value);
        partial void OnRefTableIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual int LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LineNumber;
        partial void OnLineNumberChanging(int value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property BusinessDocumentSalesInvoiceBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentSalesInvoiceBase")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BusinessDocumentSalesInvoiceBase is required.")]
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
