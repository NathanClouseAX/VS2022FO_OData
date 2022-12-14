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
    /// There are no comments for VendInvoiceRegisterHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterHeaderSingle")]
    public partial class VendInvoiceRegisterHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendInvoiceRegisterHeader>
    {
        /// <summary>
        /// Initialize a new VendInvoiceRegisterHeaderSingle object.
        /// </summary>
        public VendInvoiceRegisterHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendInvoiceRegisterHeaderSingle object.
        /// </summary>
        public VendInvoiceRegisterHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendInvoiceRegisterHeaderSingle object.
        /// </summary>
        public VendInvoiceRegisterHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendInvoiceRegisterHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendInvoiceRegisterLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterLine")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine> VendInvoiceRegisterLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendInvoiceRegisterLine == null))
                {
                    this._VendInvoiceRegisterLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine>(GetPath("VendInvoiceRegisterLine"));
                }
                return this._VendInvoiceRegisterLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine> _VendInvoiceRegisterLine;
        /// <summary>
        /// There are no comments for VendInvoiceRegisterLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterLineV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2> VendInvoiceRegisterLineV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendInvoiceRegisterLineV2 == null))
                {
                    this._VendInvoiceRegisterLineV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2>(GetPath("VendInvoiceRegisterLineV2"));
                }
                return this._VendInvoiceRegisterLineV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2> _VendInvoiceRegisterLineV2;
    }
    /// <summary>
    /// There are no comments for VendInvoiceRegisterHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("VendInvoiceRegisterHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterHeader")]
    public partial class VendInvoiceRegisterHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendInvoiceRegisterHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendInvoiceRegisterHeader CreateVendInvoiceRegisterHeader(string dataAreaId, string journalBatchNumber)
        {
            VendInvoiceRegisterHeader vendInvoiceRegisterHeader = new VendInvoiceRegisterHeader();
            vendInvoiceRegisterHeader.DataAreaId = dataAreaId;
            vendInvoiceRegisterHeader.JournalBatchNumber = journalBatchNumber;
            return vendInvoiceRegisterHeader;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalBatchNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalBatchNumber is required.")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalName")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
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
        /// There are no comments for Property SalesTaxIncluded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxIncluded")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SalesTaxIncluded
        {
            get
            {
                return this._SalesTaxIncluded;
            }
            set
            {
                this.OnSalesTaxIncludedChanging(value);
                this._SalesTaxIncluded = value;
                this.OnSalesTaxIncludedChanged();
                this.OnPropertyChanged("SalesTaxIncluded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SalesTaxIncluded;
        partial void OnSalesTaxIncludedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSalesTaxIncludedChanged();
        /// <summary>
        /// There are no comments for Property VendInvoiceRegisterLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterLine")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine> VendInvoiceRegisterLine
        {
            get
            {
                return this._VendInvoiceRegisterLine;
            }
            set
            {
                this.OnVendInvoiceRegisterLineChanging(value);
                this._VendInvoiceRegisterLine = value;
                this.OnVendInvoiceRegisterLineChanged();
                this.OnPropertyChanged("VendInvoiceRegisterLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine> _VendInvoiceRegisterLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendInvoiceRegisterLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLine> value);
        partial void OnVendInvoiceRegisterLineChanged();
        /// <summary>
        /// There are no comments for Property VendInvoiceRegisterLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceRegisterLineV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2> VendInvoiceRegisterLineV2
        {
            get
            {
                return this._VendInvoiceRegisterLineV2;
            }
            set
            {
                this.OnVendInvoiceRegisterLineV2Changing(value);
                this._VendInvoiceRegisterLineV2 = value;
                this.OnVendInvoiceRegisterLineV2Changed();
                this.OnPropertyChanged("VendInvoiceRegisterLineV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2> _VendInvoiceRegisterLineV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendInvoiceRegisterLineV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceRegisterLineV2> value);
        partial void OnVendInvoiceRegisterLineV2Changed();
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
