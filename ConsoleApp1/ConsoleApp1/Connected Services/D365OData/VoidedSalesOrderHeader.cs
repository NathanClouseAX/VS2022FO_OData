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
    /// There are no comments for VoidedSalesOrderHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderHeaderSingle")]
    public partial class VoidedSalesOrderHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VoidedSalesOrderHeader>
    {
        /// <summary>
        /// Initialize a new VoidedSalesOrderHeaderSingle object.
        /// </summary>
        public VoidedSalesOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VoidedSalesOrderHeaderSingle object.
        /// </summary>
        public VoidedSalesOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VoidedSalesOrderHeaderSingle object.
        /// </summary>
        public VoidedSalesOrderHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VoidedSalesOrderHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VoidedSalesOrderLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderLines")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine> VoidedSalesOrderLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VoidedSalesOrderLines == null))
                {
                    this._VoidedSalesOrderLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine>(GetPath("VoidedSalesOrderLines"));
                }
                return this._VoidedSalesOrderLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine> _VoidedSalesOrderLines;
    }
    /// <summary>
    /// There are no comments for VoidedSalesOrderHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SalesOrderNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SalesOrderNumber")]
    [global::Microsoft.OData.Client.EntitySet("VoidedSalesOrderHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderHeader")]
    public partial class VoidedSalesOrderHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VoidedSalesOrderHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="salesOrderNumber">Initial value of SalesOrderNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VoidedSalesOrderHeader CreateVoidedSalesOrderHeader(string dataAreaId, string salesOrderNumber)
        {
            VoidedSalesOrderHeader voidedSalesOrderHeader = new VoidedSalesOrderHeader();
            voidedSalesOrderHeader.DataAreaId = dataAreaId;
            voidedSalesOrderHeader.SalesOrderNumber = salesOrderNumber;
            return voidedSalesOrderHeader;
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
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesOrderNumber is required.")]
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderingCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderingCustomerAccountNumber")]
        public virtual string OrderingCustomerAccountNumber
        {
            get
            {
                return this._OrderingCustomerAccountNumber;
            }
            set
            {
                this.OnOrderingCustomerAccountNumberChanging(value);
                this._OrderingCustomerAccountNumber = value;
                this.OnOrderingCustomerAccountNumberChanged();
                this.OnPropertyChanged("OrderingCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrderingCustomerAccountNumber;
        partial void OnOrderingCustomerAccountNumberChanging(string value);
        partial void OnOrderingCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceCustomerAccountNumber")]
        public virtual string InvoiceCustomerAccountNumber
        {
            get
            {
                return this._InvoiceCustomerAccountNumber;
            }
            set
            {
                this.OnInvoiceCustomerAccountNumberChanging(value);
                this._InvoiceCustomerAccountNumber = value;
                this.OnInvoiceCustomerAccountNumberChanged();
                this.OnPropertyChanged("InvoiceCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceCustomerAccountNumber;
        partial void OnInvoiceCustomerAccountNumberChanging(string value);
        partial void OnInvoiceCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectId")]
        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderName")]
        public virtual string SalesOrderName
        {
            get
            {
                return this._SalesOrderName;
            }
            set
            {
                this.OnSalesOrderNameChanging(value);
                this._SalesOrderName = value;
                this.OnSalesOrderNameChanged();
                this.OnPropertyChanged("SalesOrderName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderName;
        partial void OnSalesOrderNameChanging(string value);
        partial void OnSalesOrderNameChanged();
        /// <summary>
        /// There are no comments for Property VoidedSalesOrderLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VoidedSalesOrderLines")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine> VoidedSalesOrderLines
        {
            get
            {
                return this._VoidedSalesOrderLines;
            }
            set
            {
                this.OnVoidedSalesOrderLinesChanging(value);
                this._VoidedSalesOrderLines = value;
                this.OnVoidedSalesOrderLinesChanged();
                this.OnPropertyChanged("VoidedSalesOrderLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine> _VoidedSalesOrderLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVoidedSalesOrderLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VoidedSalesOrderLine> value);
        partial void OnVoidedSalesOrderLinesChanged();
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
