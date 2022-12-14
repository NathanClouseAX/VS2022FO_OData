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
    /// There are no comments for GUPFundTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GUPFundTableSingle")]
    public partial class GUPFundTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GUPFundTable>
    {
        /// <summary>
        /// Initialize a new GUPFundTableSingle object.
        /// </summary>
        public GUPFundTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GUPFundTableSingle object.
        /// </summary>
        public GUPFundTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GUPFundTableSingle object.
        /// </summary>
        public GUPFundTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GUPFundTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for GUPFundTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FundID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FundID")]
    [global::Microsoft.OData.Client.EntitySet("GUPFundTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GUPFundTable")]
    public partial class GUPFundTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GUPFundTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fundID">Initial value of FundID.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="orderedAmt">Initial value of OrderedAmt.</param>
        /// <param name="invoicedAmt">Initial value of InvoicedAmt.</param>
        /// <param name="totalFundAmt">Initial value of TotalFundAmt.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GUPFundTable CreateGUPFundTable(string dataAreaId, 
                    string fundID, 
                    global::System.DateTimeOffset toDate, 
                    global::System.DateTimeOffset fromDate, 
                    decimal orderedAmt, 
                    decimal invoicedAmt, 
                    decimal totalFundAmt)
        {
            GUPFundTable gUPFundTable = new GUPFundTable();
            gUPFundTable.DataAreaId = dataAreaId;
            gUPFundTable.FundID = fundID;
            gUPFundTable.ToDate = toDate;
            gUPFundTable.FromDate = fromDate;
            gUPFundTable.OrderedAmt = orderedAmt;
            gUPFundTable.InvoicedAmt = invoicedAmt;
            gUPFundTable.TotalFundAmt = totalFundAmt;
            return gUPFundTable;
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
        /// There are no comments for Property FundID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FundID is required.")]
        public virtual string FundID
        {
            get
            {
                return this._FundID;
            }
            set
            {
                this.OnFundIDChanging(value);
                this._FundID = value;
                this.OnFundIDChanged();
                this.OnPropertyChanged("FundID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundID;
        partial void OnFundIDChanging(string value);
        partial void OnFundIDChanged();
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
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property Usage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Usage")]
        public virtual string Usage
        {
            get
            {
                return this._Usage;
            }
            set
            {
                this.OnUsageChanging(value);
                this._Usage = value;
                this.OnUsageChanged();
                this.OnPropertyChanged("Usage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Usage;
        partial void OnUsageChanging(string value);
        partial void OnUsageChanged();
        /// <summary>
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToDate is required.")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
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
        /// There are no comments for Property UnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasureSymbol")]
        public virtual string UnitOfMeasureSymbol
        {
            get
            {
                return this._UnitOfMeasureSymbol;
            }
            set
            {
                this.OnUnitOfMeasureSymbolChanging(value);
                this._UnitOfMeasureSymbol = value;
                this.OnUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("UnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasureSymbol;
        partial void OnUnitOfMeasureSymbolChanging(string value);
        partial void OnUnitOfMeasureSymbolChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromDate is required.")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property OrderedAmt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderedAmt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OrderedAmt is required.")]
        public virtual decimal OrderedAmt
        {
            get
            {
                return this._OrderedAmt;
            }
            set
            {
                this.OnOrderedAmtChanging(value);
                this._OrderedAmt = value;
                this.OnOrderedAmtChanged();
                this.OnPropertyChanged("OrderedAmt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OrderedAmt;
        partial void OnOrderedAmtChanging(decimal value);
        partial void OnOrderedAmtChanged();
        /// <summary>
        /// There are no comments for Property RebateRelated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateRelated")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RebateRelated
        {
            get
            {
                return this._RebateRelated;
            }
            set
            {
                this.OnRebateRelatedChanging(value);
                this._RebateRelated = value;
                this.OnRebateRelatedChanged();
                this.OnPropertyChanged("RebateRelated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RebateRelated;
        partial void OnRebateRelatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRebateRelatedChanged();
        /// <summary>
        /// There are no comments for Property FundValueType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundValueType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundValueType> FundValueType
        {
            get
            {
                return this._FundValueType;
            }
            set
            {
                this.OnFundValueTypeChanging(value);
                this._FundValueType = value;
                this.OnFundValueTypeChanged();
                this.OnPropertyChanged("FundValueType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundValueType> _FundValueType;
        partial void OnFundValueTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundValueType> value);
        partial void OnFundValueTypeChanged();
        /// <summary>
        /// There are no comments for Property InvoicedAmt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoicedAmt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoicedAmt is required.")]
        public virtual decimal InvoicedAmt
        {
            get
            {
                return this._InvoicedAmt;
            }
            set
            {
                this.OnInvoicedAmtChanging(value);
                this._InvoicedAmt = value;
                this.OnInvoicedAmtChanged();
                this.OnPropertyChanged("InvoicedAmt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoicedAmt;
        partial void OnInvoicedAmtChanging(decimal value);
        partial void OnInvoicedAmtChanged();
        /// <summary>
        /// There are no comments for Property FundSourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundSourceType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundSourceType> FundSourceType
        {
            get
            {
                return this._FundSourceType;
            }
            set
            {
                this.OnFundSourceTypeChanging(value);
                this._FundSourceType = value;
                this.OnFundSourceTypeChanged();
                this.OnPropertyChanged("FundSourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundSourceType> _FundSourceType;
        partial void OnFundSourceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPFundSourceType> value);
        partial void OnFundSourceTypeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMFundStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property TotalFundAmt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalFundAmt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalFundAmt is required.")]
        public virtual decimal TotalFundAmt
        {
            get
            {
                return this._TotalFundAmt;
            }
            set
            {
                this.OnTotalFundAmtChanging(value);
                this._TotalFundAmt = value;
                this.OnTotalFundAmtChanged();
                this.OnPropertyChanged("TotalFundAmt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TotalFundAmt;
        partial void OnTotalFundAmtChanging(decimal value);
        partial void OnTotalFundAmtChanged();
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
