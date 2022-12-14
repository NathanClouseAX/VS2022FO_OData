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
    /// There are no comments for InflationAdjustmentJournalSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InflationAdjustmentJournalSingle")]
    public partial class InflationAdjustmentJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InflationAdjustmentJournal>
    {
        /// <summary>
        /// Initialize a new InflationAdjustmentJournalSingle object.
        /// </summary>
        public InflationAdjustmentJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InflationAdjustmentJournalSingle object.
        /// </summary>
        public InflationAdjustmentJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InflationAdjustmentJournalSingle object.
        /// </summary>
        public InflationAdjustmentJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InflationAdjustmentJournal> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for InflationAdjustmentJournal in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Voucher
    /// ReversedVoucher
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Voucher", "ReversedVoucher")]
    [global::Microsoft.OData.Client.EntitySet("InflationAdjustmentJournals")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InflationAdjustmentJournal")]
    public partial class InflationAdjustmentJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InflationAdjustmentJournal object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="voucher">Initial value of Voucher.</param>
        /// <param name="reversedVoucher">Initial value of ReversedVoucher.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="postingDate">Initial value of PostingDate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InflationAdjustmentJournal CreateInflationAdjustmentJournal(string dataAreaId, 
                    string voucher, 
                    string reversedVoucher, 
                    global::System.DateTimeOffset fromDate, 
                    global::System.DateTimeOffset postingDate, 
                    global::System.DateTimeOffset toDate)
        {
            InflationAdjustmentJournal inflationAdjustmentJournal = new InflationAdjustmentJournal();
            inflationAdjustmentJournal.DataAreaId = dataAreaId;
            inflationAdjustmentJournal.Voucher = voucher;
            inflationAdjustmentJournal.ReversedVoucher = reversedVoucher;
            inflationAdjustmentJournal.FromDate = fromDate;
            inflationAdjustmentJournal.PostingDate = postingDate;
            inflationAdjustmentJournal.ToDate = toDate;
            return inflationAdjustmentJournal;
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
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Voucher")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Voucher is required.")]
        public virtual string Voucher
        {
            get
            {
                return this._Voucher;
            }
            set
            {
                this.OnVoucherChanging(value);
                this._Voucher = value;
                this.OnVoucherChanged();
                this.OnPropertyChanged("Voucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Voucher;
        partial void OnVoucherChanging(string value);
        partial void OnVoucherChanged();
        /// <summary>
        /// There are no comments for Property ReversedVoucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReversedVoucher")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReversedVoucher is required.")]
        public virtual string ReversedVoucher
        {
            get
            {
                return this._ReversedVoucher;
            }
            set
            {
                this.OnReversedVoucherChanging(value);
                this._ReversedVoucher = value;
                this.OnReversedVoucherChanged();
                this.OnPropertyChanged("ReversedVoucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReversedVoucher;
        partial void OnReversedVoucherChanging(string value);
        partial void OnReversedVoucherChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InflationAdjJournalStatus_MX> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InflationAdjJournalStatus_MX> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InflationAdjJournalStatus_MX> value);
        partial void OnStatusChanged();
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
        /// There are no comments for Property PostingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostingDate is required.")]
        public virtual global::System.DateTimeOffset PostingDate
        {
            get
            {
                return this._PostingDate;
            }
            set
            {
                this.OnPostingDateChanging(value);
                this._PostingDate = value;
                this.OnPostingDateChanged();
                this.OnPropertyChanged("PostingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PostingDate;
        partial void OnPostingDateChanging(global::System.DateTimeOffset value);
        partial void OnPostingDateChanged();
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
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingLayer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
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
