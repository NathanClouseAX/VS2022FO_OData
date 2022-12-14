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
    /// There are no comments for SalesOrderOriginCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderOriginCodeSingle")]
    public partial class SalesOrderOriginCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesOrderOriginCode>
    {
        /// <summary>
        /// Initialize a new SalesOrderOriginCodeSingle object.
        /// </summary>
        public SalesOrderOriginCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesOrderOriginCodeSingle object.
        /// </summary>
        public SalesOrderOriginCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesOrderOriginCodeSingle object.
        /// </summary>
        public SalesOrderOriginCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesOrderOriginCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SalesOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2> SalesOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesOrderHeaders == null))
                {
                    this._SalesOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2>(GetPath("SalesOrderHeaders"));
                }
                return this._SalesOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2> _SalesOrderHeaders;
        /// <summary>
        /// There are no comments for SalesInvoiceHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesInvoiceHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader> SalesInvoiceHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesInvoiceHeaders == null))
                {
                    this._SalesInvoiceHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader>(GetPath("SalesInvoiceHeaders"));
                }
                return this._SalesInvoiceHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader> _SalesInvoiceHeaders;
    }
    /// <summary>
    /// There are no comments for SalesOrderOriginCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OriginCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OriginCode")]
    [global::Microsoft.OData.Client.EntitySet("SalesOrderOriginCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderOriginCode")]
    public partial class SalesOrderOriginCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesOrderOriginCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="originCode">Initial value of OriginCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesOrderOriginCode CreateSalesOrderOriginCode(string dataAreaId, string originCode)
        {
            SalesOrderOriginCode salesOrderOriginCode = new SalesOrderOriginCode();
            salesOrderOriginCode.DataAreaId = dataAreaId;
            salesOrderOriginCode.OriginCode = originCode;
            return salesOrderOriginCode;
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
        /// There are no comments for Property OriginCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OriginCode is required.")]
        public virtual string OriginCode
        {
            get
            {
                return this._OriginCode;
            }
            set
            {
                this.OnOriginCodeChanging(value);
                this._OriginCode = value;
                this.OnOriginCodeChanged();
                this.OnPropertyChanged("OriginCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginCode;
        partial void OnOriginCodeChanging(string value);
        partial void OnOriginCodeChanged();
        /// <summary>
        /// There are no comments for Property OriginDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginDescription")]
        public virtual string OriginDescription
        {
            get
            {
                return this._OriginDescription;
            }
            set
            {
                this.OnOriginDescriptionChanging(value);
                this._OriginDescription = value;
                this.OnOriginDescriptionChanged();
                this.OnPropertyChanged("OriginDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginDescription;
        partial void OnOriginDescriptionChanging(string value);
        partial void OnOriginDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsOriginTypeAssigned in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsOriginTypeAssigned")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsOriginTypeAssigned
        {
            get
            {
                return this._IsOriginTypeAssigned;
            }
            set
            {
                this.OnIsOriginTypeAssignedChanging(value);
                this._IsOriginTypeAssigned = value;
                this.OnIsOriginTypeAssignedChanged();
                this.OnPropertyChanged("IsOriginTypeAssigned");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsOriginTypeAssigned;
        partial void OnIsOriginTypeAssignedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsOriginTypeAssignedChanged();
        /// <summary>
        /// There are no comments for Property OriginType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesOriginType> OriginType
        {
            get
            {
                return this._OriginType;
            }
            set
            {
                this.OnOriginTypeChanging(value);
                this._OriginType = value;
                this.OnOriginTypeChanged();
                this.OnPropertyChanged("OriginType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesOriginType> _OriginType;
        partial void OnOriginTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesOriginType> value);
        partial void OnOriginTypeChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this.OnSalesOrderHeadersChanging(value);
                this._SalesOrderHeaders = value;
                this.OnSalesOrderHeadersChanged();
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2> _SalesOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesOrderHeaderV2> value);
        partial void OnSalesOrderHeadersChanged();
        /// <summary>
        /// There are no comments for Property SalesInvoiceHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesInvoiceHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader> SalesInvoiceHeaders
        {
            get
            {
                return this._SalesInvoiceHeaders;
            }
            set
            {
                this.OnSalesInvoiceHeadersChanging(value);
                this._SalesInvoiceHeaders = value;
                this.OnSalesInvoiceHeadersChanged();
                this.OnPropertyChanged("SalesInvoiceHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader> _SalesInvoiceHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesInvoiceHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesInvoiceJournalHeader> value);
        partial void OnSalesInvoiceHeadersChanged();
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
