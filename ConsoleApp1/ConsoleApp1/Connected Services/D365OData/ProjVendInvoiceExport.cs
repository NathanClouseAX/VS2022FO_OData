//------------------------------------------------------------------------------
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
    /// There are no comments for ProjVendInvoiceExportSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceExportSingle")]
    public partial class ProjVendInvoiceExportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjVendInvoiceExport>
    {
        /// <summary>
        /// Initialize a new ProjVendInvoiceExportSingle object.
        /// </summary>
        public ProjVendInvoiceExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjVendInvoiceExportSingle object.
        /// </summary>
        public ProjVendInvoiceExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjVendInvoiceExportSingle object.
        /// </summary>
        public ProjVendInvoiceExportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjVendInvoiceExport> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjVendInvoiceLineExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceLineExport")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntitySingle ProjVendInvoiceLineExport
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjVendInvoiceLineExport == null))
                {
                    this._ProjVendInvoiceLineExport = new global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntitySingle(this.Context, GetPath("ProjVendInvoiceLineExport"));
                }
                return this._ProjVendInvoiceLineExport;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntitySingle _ProjVendInvoiceLineExport;
    }
    /// <summary>
    /// There are no comments for ProjVendInvoiceExport in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TableRefId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TableRefId")]
    [global::Microsoft.OData.Client.EntitySet("ProjVendInvoicesExport")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceExport")]
    public partial class ProjVendInvoiceExport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjVendInvoiceExport object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="tableRefId">Initial value of TableRefId.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjVendInvoiceExport CreateProjVendInvoiceExport(string dataAreaId, string tableRefId, global::System.DateTimeOffset transDate, global::System.DateTimeOffset documentDate)
        {
            ProjVendInvoiceExport projVendInvoiceExport = new ProjVendInvoiceExport();
            projVendInvoiceExport.DataAreaId = dataAreaId;
            projVendInvoiceExport.TableRefId = tableRefId;
            projVendInvoiceExport.TransDate = transDate;
            projVendInvoiceExport.DocumentDate = documentDate;
            return projVendInvoiceExport;
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
        /// There are no comments for Property TableRefId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableRefId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableRefId is required.")]
        public virtual string TableRefId
        {
            get
            {
                return this._TableRefId;
            }
            set
            {
                this.OnTableRefIdChanging(value);
                this._TableRefId = value;
                this.OnTableRefIdChanged();
                this.OnPropertyChanged("TableRefId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableRefId;
        partial void OnTableRefIdChanging(string value);
        partial void OnTableRefIdChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property OrderAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderAccount")]
        public virtual string OrderAccount
        {
            get
            {
                return this._OrderAccount;
            }
            set
            {
                this.OnOrderAccountChanging(value);
                this._OrderAccount = value;
                this.OnOrderAccountChanged();
                this.OnPropertyChanged("OrderAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderAccount;
        partial void OnOrderAccountChanging(string value);
        partial void OnOrderAccountChanged();
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
        /// There are no comments for Property VendorInvoiceNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorInvoiceNum")]
        public virtual string VendorInvoiceNum
        {
            get
            {
                return this._VendorInvoiceNum;
            }
            set
            {
                this.OnVendorInvoiceNumChanging(value);
                this._VendorInvoiceNum = value;
                this.OnVendorInvoiceNumChanged();
                this.OnPropertyChanged("VendorInvoiceNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorInvoiceNum;
        partial void OnVendorInvoiceNumChanging(string value);
        partial void OnVendorInvoiceNumChanged();
        /// <summary>
        /// There are no comments for Property SubcontractInvoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubcontractInvoice")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SubcontractInvoice
        {
            get
            {
                return this._SubcontractInvoice;
            }
            set
            {
                this.OnSubcontractInvoiceChanging(value);
                this._SubcontractInvoice = value;
                this.OnSubcontractInvoiceChanged();
                this.OnPropertyChanged("SubcontractInvoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SubcontractInvoice;
        partial void OnSubcontractInvoiceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSubcontractInvoiceChanged();
        /// <summary>
        /// There are no comments for Property PurchId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchId")]
        public virtual string PurchId
        {
            get
            {
                return this._PurchId;
            }
            set
            {
                this.OnPurchIdChanging(value);
                this._PurchId = value;
                this.OnPurchIdChanged();
                this.OnPropertyChanged("PurchId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchId;
        partial void OnPurchIdChanging(string value);
        partial void OnPurchIdChanged();
        /// <summary>
        /// There are no comments for Property ProjVendInvoiceLineExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjVendInvoiceLineExport")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntity ProjVendInvoiceLineExport
        {
            get
            {
                return this._ProjVendInvoiceLineExport;
            }
            set
            {
                this.OnProjVendInvoiceLineExportChanging(value);
                this._ProjVendInvoiceLineExport = value;
                this.OnProjVendInvoiceLineExportChanged();
                this.OnPropertyChanged("ProjVendInvoiceLineExport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntity _ProjVendInvoiceLineExport;
        partial void OnProjVendInvoiceLineExportChanging(global::Microsoft.Dynamics.DataEntities.ProjVendInvoiceLineExportEntity value);
        partial void OnProjVendInvoiceLineExportChanged();
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
