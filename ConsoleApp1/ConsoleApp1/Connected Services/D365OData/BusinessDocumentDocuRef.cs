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
    /// There are no comments for BusinessDocumentDocuRefSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentDocuRefSingle")]
    public partial class BusinessDocumentDocuRefSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentDocuRef>
    {
        /// <summary>
        /// Initialize a new BusinessDocumentDocuRefSingle object.
        /// </summary>
        public BusinessDocumentDocuRefSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BusinessDocumentDocuRefSingle object.
        /// </summary>
        public BusinessDocumentDocuRefSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BusinessDocumentDocuRefSingle object.
        /// </summary>
        public BusinessDocumentDocuRefSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessDocumentDocuRef> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BusinessDocumentSalesInvoiceLineItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentSalesInvoiceLineItem")]
        public virtual global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItemSingle BusinessDocumentSalesInvoiceLineItem
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessDocumentSalesInvoiceLineItem == null))
                {
                    this._BusinessDocumentSalesInvoiceLineItem = new global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItemSingle(this.Context, GetPath("BusinessDocumentSalesInvoiceLineItem"));
                }
                return this._BusinessDocumentSalesInvoiceLineItem;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItemSingle _BusinessDocumentSalesInvoiceLineItem;
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
    /// There are no comments for BusinessDocumentDocuRef in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DocuRefRecId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DocuRefRecId")]
    [global::Microsoft.OData.Client.EntitySet("BusinessDocumentDocuRefs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentDocuRef")]
    public partial class BusinessDocumentDocuRef : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BusinessDocumentDocuRef object.
        /// </summary>
        /// <param name="docuRefRecId">Initial value of DocuRefRecId.</param>
        /// <param name="refTableId">Initial value of RefTableId.</param>
        /// <param name="refRecId">Initial value of RefRecId.</param>
        /// <param name="businessDocumentSalesInvoiceLineItem">Initial value of BusinessDocumentSalesInvoiceLineItem.</param>
        /// <param name="businessDocumentSalesInvoiceBase">Initial value of BusinessDocumentSalesInvoiceBase.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BusinessDocumentDocuRef CreateBusinessDocumentDocuRef(long docuRefRecId, int refTableId, long refRecId, global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItem businessDocumentSalesInvoiceLineItem, global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceBase businessDocumentSalesInvoiceBase)
        {
            BusinessDocumentDocuRef businessDocumentDocuRef = new BusinessDocumentDocuRef();
            businessDocumentDocuRef.DocuRefRecId = docuRefRecId;
            businessDocumentDocuRef.RefTableId = refTableId;
            businessDocumentDocuRef.RefRecId = refRecId;
            if ((businessDocumentSalesInvoiceLineItem == null))
            {
                throw new global::System.ArgumentNullException("businessDocumentSalesInvoiceLineItem");
            }
            businessDocumentDocuRef.BusinessDocumentSalesInvoiceLineItem = businessDocumentSalesInvoiceLineItem;
            if ((businessDocumentSalesInvoiceBase == null))
            {
                throw new global::System.ArgumentNullException("businessDocumentSalesInvoiceBase");
            }
            businessDocumentDocuRef.BusinessDocumentSalesInvoiceBase = businessDocumentSalesInvoiceBase;
            return businessDocumentDocuRef;
        }
        /// <summary>
        /// There are no comments for Property DocuRefRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocuRefRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocuRefRecId is required.")]
        public virtual long DocuRefRecId
        {
            get
            {
                return this._DocuRefRecId;
            }
            set
            {
                this.OnDocuRefRecIdChanging(value);
                this._DocuRefRecId = value;
                this.OnDocuRefRecIdChanged();
                this.OnPropertyChanged("DocuRefRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _DocuRefRecId;
        partial void OnDocuRefRecIdChanging(long value);
        partial void OnDocuRefRecIdChanged();
        /// <summary>
        /// There are no comments for Property URI in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("URI")]
        public virtual string URI
        {
            get
            {
                return this._URI;
            }
            set
            {
                this.OnURIChanging(value);
                this._URI = value;
                this.OnURIChanged();
                this.OnPropertyChanged("URI");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _URI;
        partial void OnURIChanging(string value);
        partial void OnURIChanged();
        /// <summary>
        /// There are no comments for Property ContentBase64 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContentBase64")]
        public virtual string ContentBase64
        {
            get
            {
                return this._ContentBase64;
            }
            set
            {
                this.OnContentBase64Changing(value);
                this._ContentBase64 = value;
                this.OnContentBase64Changed();
                this.OnPropertyChanged("ContentBase64");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContentBase64;
        partial void OnContentBase64Changing(string value);
        partial void OnContentBase64Changed();
        /// <summary>
        /// There are no comments for Property RestrictionStr in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RestrictionStr")]
        public virtual string RestrictionStr
        {
            get
            {
                return this._RestrictionStr;
            }
            set
            {
                this.OnRestrictionStrChanging(value);
                this._RestrictionStr = value;
                this.OnRestrictionStrChanged();
                this.OnPropertyChanged("RestrictionStr");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RestrictionStr;
        partial void OnRestrictionStrChanging(string value);
        partial void OnRestrictionStrChanged();
        /// <summary>
        /// There are no comments for Property FileType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileType")]
        public virtual string FileType
        {
            get
            {
                return this._FileType;
            }
            set
            {
                this.OnFileTypeChanging(value);
                this._FileType = value;
                this.OnFileTypeChanged();
                this.OnPropertyChanged("FileType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileType;
        partial void OnFileTypeChanging(string value);
        partial void OnFileTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentType")]
        public virtual string DocumentType
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
        private string _DocumentType;
        partial void OnDocumentTypeChanging(string value);
        partial void OnDocumentTypeChanged();
        /// <summary>
        /// There are no comments for Property TypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeId")]
        public virtual string TypeId
        {
            get
            {
                return this._TypeId;
            }
            set
            {
                this.OnTypeIdChanging(value);
                this._TypeId = value;
                this.OnTypeIdChanged();
                this.OnPropertyChanged("TypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TypeId;
        partial void OnTypeIdChanging(string value);
        partial void OnTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Restriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Restriction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> Restriction
        {
            get
            {
                return this._Restriction;
            }
            set
            {
                this.OnRestrictionChanging(value);
                this._Restriction = value;
                this.OnRestrictionChanged();
                this.OnPropertyChanged("Restriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _Restriction;
        partial void OnRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnRestrictionChanged();
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
        /// There are no comments for Property Content in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Content")]
        public virtual byte[] Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this.OnContentChanging(value);
                this._Content = value;
                this.OnContentChanged();
                this.OnPropertyChanged("Content");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Content;
        partial void OnContentChanging(byte[] value);
        partial void OnContentChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
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
        /// There are no comments for Property FileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileName")]
        public virtual string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this.OnFileNameChanging(value);
                this._FileName = value;
                this.OnFileNameChanged();
                this.OnPropertyChanged("FileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileName;
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
        /// <summary>
        /// There are no comments for Property BusinessDocumentSalesInvoiceLineItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessDocumentSalesInvoiceLineItem")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BusinessDocumentSalesInvoiceLineItem is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItem BusinessDocumentSalesInvoiceLineItem
        {
            get
            {
                return this._BusinessDocumentSalesInvoiceLineItem;
            }
            set
            {
                this.OnBusinessDocumentSalesInvoiceLineItemChanging(value);
                this._BusinessDocumentSalesInvoiceLineItem = value;
                this.OnBusinessDocumentSalesInvoiceLineItemChanged();
                this.OnPropertyChanged("BusinessDocumentSalesInvoiceLineItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItem _BusinessDocumentSalesInvoiceLineItem;
        partial void OnBusinessDocumentSalesInvoiceLineItemChanging(global::Microsoft.Dynamics.DataEntities.BusinessDocumentSalesInvoiceLineItem value);
        partial void OnBusinessDocumentSalesInvoiceLineItemChanged();
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
