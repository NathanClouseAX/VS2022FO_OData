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
    /// There are no comments for TaxItemGroupHeadingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxItemGroupHeadingSingle")]
    public partial class TaxItemGroupHeadingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxItemGroupHeading>
    {
        /// <summary>
        /// Initialize a new TaxItemGroupHeadingSingle object.
        /// </summary>
        public TaxItemGroupHeadingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxItemGroupHeadingSingle object.
        /// </summary>
        public TaxItemGroupHeadingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxItemGroupHeadingSingle object.
        /// </summary>
        public TaxItemGroupHeadingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxItemGroupHeading> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendInvoiceJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceJournalLineItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendInvoiceJournalLineItemSalesTaxGroup == null))
                {
                    this._VendInvoiceJournalLineItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(GetPath("VendInvoiceJournalLineItemSalesTaxGroup"));
                }
                return this._VendInvoiceJournalLineItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for LedgerJournalLineCDSItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineCDSItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalLineCDSItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLineCDSItemSalesTaxGroup == null))
                {
                    this._LedgerJournalLineCDSItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(GetPath("LedgerJournalLineCDSItemSalesTaxGroup"));
                }
                return this._LedgerJournalLineCDSItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalLineCDSItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for LedgerJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine> LedgerJournalLineItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLineItemSalesTaxGroup == null))
                {
                    this._LedgerJournalLineItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine>(GetPath("LedgerJournalLineItemSalesTaxGroup"));
                }
                return this._LedgerJournalLineItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine> _LedgerJournalLineItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalLineTaxItemGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPaymentJournalLineTaxItemGroupEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineTaxItemGroupEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalLineTaxItemGroupEntity == null))
                {
                    this._CustomerPaymentJournalLineTaxItemGroupEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(GetPath("CustomerPaymentJournalLineTaxItemGroupEntity"));
                }
                return this._CustomerPaymentJournalLineTaxItemGroupEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineTaxItemGroupEntity;
        /// <summary>
        /// There are no comments for LedgerJournalLineEntityItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineEntityItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLineEntityItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLineEntityItemSalesTaxGroup == null))
                {
                    this._LedgerJournalLineEntityItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(GetPath("LedgerJournalLineEntityItemSalesTaxGroup"));
                }
                return this._LedgerJournalLineEntityItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLineEntityItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for FreeTextInvoiceLineTaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeTextInvoiceLineTaxItemGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> FreeTextInvoiceLineTaxItemGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FreeTextInvoiceLineTaxItemGroup == null))
                {
                    this._FreeTextInvoiceLineTaxItemGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine>(GetPath("FreeTextInvoiceLineTaxItemGroup"));
                }
                return this._FreeTextInvoiceLineTaxItemGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> _FreeTextInvoiceLineTaxItemGroup;
        /// <summary>
        /// There are no comments for VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentJournalFee")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalFee == null))
                {
                    this._VendorPaymentJournalFee = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(GetPath("VendorPaymentJournalFee"));
                }
                return this._VendorPaymentJournalFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPaymentJournalFee")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> CustomerPaymentJournalFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalFee == null))
                {
                    this._CustomerPaymentJournalFee = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee>(GetPath("CustomerPaymentJournalFee"));
                }
                return this._CustomerPaymentJournalFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> _CustomerPaymentJournalFee;
    }
    /// <summary>
    /// There are no comments for TaxItemGroupHeading in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TaxItemGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxItemGroup")]
    [global::Microsoft.OData.Client.EntitySet("TaxItemGroupHeadings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxItemGroupHeading")]
    public partial class TaxItemGroupHeading : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxItemGroupHeading object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="taxItemGroup">Initial value of TaxItemGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxItemGroupHeading CreateTaxItemGroupHeading(string dataAreaId, string taxItemGroup)
        {
            TaxItemGroupHeading taxItemGroupHeading = new TaxItemGroupHeading();
            taxItemGroupHeading.DataAreaId = dataAreaId;
            taxItemGroupHeading.TaxItemGroup = taxItemGroup;
            return taxItemGroupHeading;
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
        /// There are no comments for Property TaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxItemGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxItemGroup is required.")]
        public virtual string TaxItemGroup
        {
            get
            {
                return this._TaxItemGroup;
            }
            set
            {
                this.OnTaxItemGroupChanging(value);
                this._TaxItemGroup = value;
                this.OnTaxItemGroupChanged();
                this.OnPropertyChanged("TaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxItemGroup;
        partial void OnTaxItemGroupChanging(string value);
        partial void OnTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property VendInvoiceJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendInvoiceJournalLineItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> VendInvoiceJournalLineItemSalesTaxGroup
        {
            get
            {
                return this._VendInvoiceJournalLineItemSalesTaxGroup;
            }
            set
            {
                this.OnVendInvoiceJournalLineItemSalesTaxGroupChanging(value);
                this._VendInvoiceJournalLineItemSalesTaxGroup = value;
                this.OnVendInvoiceJournalLineItemSalesTaxGroupChanged();
                this.OnPropertyChanged("VendInvoiceJournalLineItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> _VendInvoiceJournalLineItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendInvoiceJournalLineItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendInvoiceJournalLine> value);
        partial void OnVendInvoiceJournalLineItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLineCDSItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineCDSItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalLineCDSItemSalesTaxGroup
        {
            get
            {
                return this._LedgerJournalLineCDSItemSalesTaxGroup;
            }
            set
            {
                this.OnLedgerJournalLineCDSItemSalesTaxGroupChanging(value);
                this._LedgerJournalLineCDSItemSalesTaxGroup = value;
                this.OnLedgerJournalLineCDSItemSalesTaxGroupChanged();
                this.OnPropertyChanged("LedgerJournalLineCDSItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalLineCDSItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineCDSItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> value);
        partial void OnLedgerJournalLineCDSItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine> LedgerJournalLineItemSalesTaxGroup
        {
            get
            {
                return this._LedgerJournalLineItemSalesTaxGroup;
            }
            set
            {
                this.OnLedgerJournalLineItemSalesTaxGroupChanging(value);
                this._LedgerJournalLineItemSalesTaxGroup = value;
                this.OnLedgerJournalLineItemSalesTaxGroupChanged();
                this.OnPropertyChanged("LedgerJournalLineItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine> _LedgerJournalLineItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLeaseLedgerJournalLine> value);
        partial void OnLedgerJournalLineItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalLineTaxItemGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPaymentJournalLineTaxItemGroupEntity")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineTaxItemGroupEntity
        {
            get
            {
                return this._CustomerPaymentJournalLineTaxItemGroupEntity;
            }
            set
            {
                this.OnCustomerPaymentJournalLineTaxItemGroupEntityChanging(value);
                this._CustomerPaymentJournalLineTaxItemGroupEntity = value;
                this.OnCustomerPaymentJournalLineTaxItemGroupEntityChanged();
                this.OnPropertyChanged("CustomerPaymentJournalLineTaxItemGroupEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineTaxItemGroupEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalLineTaxItemGroupEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> value);
        partial void OnCustomerPaymentJournalLineTaxItemGroupEntityChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLineEntityItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalLineEntityItemSalesTaxGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLineEntityItemSalesTaxGroup
        {
            get
            {
                return this._LedgerJournalLineEntityItemSalesTaxGroup;
            }
            set
            {
                this.OnLedgerJournalLineEntityItemSalesTaxGroupChanging(value);
                this._LedgerJournalLineEntityItemSalesTaxGroup = value;
                this.OnLedgerJournalLineEntityItemSalesTaxGroupChanged();
                this.OnPropertyChanged("LedgerJournalLineEntityItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLineEntityItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineEntityItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> value);
        partial void OnLedgerJournalLineEntityItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property FreeTextInvoiceLineTaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeTextInvoiceLineTaxItemGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> FreeTextInvoiceLineTaxItemGroup
        {
            get
            {
                return this._FreeTextInvoiceLineTaxItemGroup;
            }
            set
            {
                this.OnFreeTextInvoiceLineTaxItemGroupChanging(value);
                this._FreeTextInvoiceLineTaxItemGroup = value;
                this.OnFreeTextInvoiceLineTaxItemGroupChanged();
                this.OnPropertyChanged("FreeTextInvoiceLineTaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> _FreeTextInvoiceLineTaxItemGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFreeTextInvoiceLineTaxItemGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> value);
        partial void OnFreeTextInvoiceLineTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentJournalFee")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                return this._VendorPaymentJournalFee;
            }
            set
            {
                this.OnVendorPaymentJournalFeeChanging(value);
                this._VendorPaymentJournalFee = value;
                this.OnVendorPaymentJournalFeeChanged();
                this.OnPropertyChanged("VendorPaymentJournalFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorPaymentJournalFeeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> value);
        partial void OnVendorPaymentJournalFeeChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPaymentJournalFee")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> CustomerPaymentJournalFee
        {
            get
            {
                return this._CustomerPaymentJournalFee;
            }
            set
            {
                this.OnCustomerPaymentJournalFeeChanging(value);
                this._CustomerPaymentJournalFee = value;
                this.OnCustomerPaymentJournalFeeChanged();
                this.OnPropertyChanged("CustomerPaymentJournalFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> _CustomerPaymentJournalFee = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalFeeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> value);
        partial void OnCustomerPaymentJournalFeeChanged();
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