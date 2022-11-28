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
    /// There are no comments for PublishedRequestForQuotationReplyLineSummarySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublishedRequestForQuotationReplyLineSummarySingle")]
    public partial class PublishedRequestForQuotationReplyLineSummarySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationReplyLineSummary>
    {
        /// <summary>
        /// Initialize a new PublishedRequestForQuotationReplyLineSummarySingle object.
        /// </summary>
        public PublishedRequestForQuotationReplyLineSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationReplyLineSummarySingle object.
        /// </summary>
        public PublishedRequestForQuotationReplyLineSummarySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationReplyLineSummarySingle object.
        /// </summary>
        public PublishedRequestForQuotationReplyLineSummarySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationReplyLineSummary> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PublishedRequestForQuotationReplyLineSummary in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RFQNumber
    /// RFQCaseNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RFQNumber", "RFQCaseNumber")]
    [global::Microsoft.OData.Client.EntitySet("PublishedRequestForQuotationReplyLineSummaries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublishedRequestForQuotationReplyLineSummary")]
    public partial class PublishedRequestForQuotationReplyLineSummary : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PublishedRequestForQuotationReplyLineSummary object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rFQNumber">Initial value of RFQNumber.</param>
        /// <param name="rFQCaseNumber">Initial value of RFQCaseNumber.</param>
        /// <param name="totalVendorScore">Initial value of TotalVendorScore.</param>
        /// <param name="lineAmount">Initial value of LineAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PublishedRequestForQuotationReplyLineSummary CreatePublishedRequestForQuotationReplyLineSummary(string dataAreaId, string rFQNumber, string rFQCaseNumber, int totalVendorScore, decimal lineAmount)
        {
            PublishedRequestForQuotationReplyLineSummary publishedRequestForQuotationReplyLineSummary = new PublishedRequestForQuotationReplyLineSummary();
            publishedRequestForQuotationReplyLineSummary.DataAreaId = dataAreaId;
            publishedRequestForQuotationReplyLineSummary.RFQNumber = rFQNumber;
            publishedRequestForQuotationReplyLineSummary.RFQCaseNumber = rFQCaseNumber;
            publishedRequestForQuotationReplyLineSummary.TotalVendorScore = totalVendorScore;
            publishedRequestForQuotationReplyLineSummary.LineAmount = lineAmount;
            return publishedRequestForQuotationReplyLineSummary;
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
        /// There are no comments for Property RFQNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFQNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RFQNumber is required.")]
        public virtual string RFQNumber
        {
            get
            {
                return this._RFQNumber;
            }
            set
            {
                this.OnRFQNumberChanging(value);
                this._RFQNumber = value;
                this.OnRFQNumberChanged();
                this.OnPropertyChanged("RFQNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQNumber;
        partial void OnRFQNumberChanging(string value);
        partial void OnRFQNumberChanged();
        /// <summary>
        /// There are no comments for Property RFQCaseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFQCaseNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RFQCaseNumber is required.")]
        public virtual string RFQCaseNumber
        {
            get
            {
                return this._RFQCaseNumber;
            }
            set
            {
                this.OnRFQCaseNumberChanging(value);
                this._RFQCaseNumber = value;
                this.OnRFQCaseNumberChanged();
                this.OnPropertyChanged("RFQCaseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseNumber;
        partial void OnRFQCaseNumberChanging(string value);
        partial void OnRFQCaseNumberChanged();
        /// <summary>
        /// There are no comments for Property VendorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorName")]
        public virtual string VendorName
        {
            get
            {
                return this._VendorName;
            }
            set
            {
                this.OnVendorNameChanging(value);
                this._VendorName = value;
                this.OnVendorNameChanged();
                this.OnPropertyChanged("VendorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorName;
        partial void OnVendorNameChanging(string value);
        partial void OnVendorNameChanged();
        /// <summary>
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccountNumber")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property TotalVendorScore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalVendorScore")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TotalVendorScore is required.")]
        public virtual int TotalVendorScore
        {
            get
            {
                return this._TotalVendorScore;
            }
            set
            {
                this.OnTotalVendorScoreChanging(value);
                this._TotalVendorScore = value;
                this.OnTotalVendorScoreChanged();
                this.OnPropertyChanged("TotalVendorScore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TotalVendorScore;
        partial void OnTotalVendorScoreChanging(int value);
        partial void OnTotalVendorScoreChanged();
        /// <summary>
        /// There are no comments for Property VendorReplyStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorReplyStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQReplyStatus_PSN> VendorReplyStatus
        {
            get
            {
                return this._VendorReplyStatus;
            }
            set
            {
                this.OnVendorReplyStatusChanging(value);
                this._VendorReplyStatus = value;
                this.OnVendorReplyStatusChanged();
                this.OnPropertyChanged("VendorReplyStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQReplyStatus_PSN> _VendorReplyStatus;
        partial void OnVendorReplyStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQReplyStatus_PSN> value);
        partial void OnVendorReplyStatusChanged();
        /// <summary>
        /// There are no comments for Property TotalVendorScoreComment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalVendorScoreComment")]
        public virtual string TotalVendorScoreComment
        {
            get
            {
                return this._TotalVendorScoreComment;
            }
            set
            {
                this.OnTotalVendorScoreCommentChanging(value);
                this._TotalVendorScoreComment = value;
                this.OnTotalVendorScoreCommentChanged();
                this.OnPropertyChanged("TotalVendorScoreComment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalVendorScoreComment;
        partial void OnTotalVendorScoreCommentChanging(string value);
        partial void OnTotalVendorScoreCommentChanged();
        /// <summary>
        /// There are no comments for Property IsBidAwarded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsBidAwarded")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBidAwarded
        {
            get
            {
                return this._IsBidAwarded;
            }
            set
            {
                this.OnIsBidAwardedChanging(value);
                this._IsBidAwarded = value;
                this.OnIsBidAwardedChanged();
                this.OnPropertyChanged("IsBidAwarded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBidAwarded;
        partial void OnIsBidAwardedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBidAwardedChanged();
        /// <summary>
        /// There are no comments for Property HighestRFQStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HighestRFQStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> HighestRFQStatus
        {
            get
            {
                return this._HighestRFQStatus;
            }
            set
            {
                this.OnHighestRFQStatusChanging(value);
                this._HighestRFQStatus = value;
                this.OnHighestRFQStatusChanged();
                this.OnPropertyChanged("HighestRFQStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> _HighestRFQStatus;
        partial void OnHighestRFQStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> value);
        partial void OnHighestRFQStatusChanged();
        /// <summary>
        /// There are no comments for Property LowestRFQStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LowestRFQStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> LowestRFQStatus
        {
            get
            {
                return this._LowestRFQStatus;
            }
            set
            {
                this.OnLowestRFQStatusChanging(value);
                this._LowestRFQStatus = value;
                this.OnLowestRFQStatusChanged();
                this.OnPropertyChanged("LowestRFQStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> _LowestRFQStatus;
        partial void OnLowestRFQStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQStatus> value);
        partial void OnLowestRFQStatusChanged();
        /// <summary>
        /// There are no comments for Property RFQCaseRequestingWorkerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFQCaseRequestingWorkerName")]
        public virtual string RFQCaseRequestingWorkerName
        {
            get
            {
                return this._RFQCaseRequestingWorkerName;
            }
            set
            {
                this.OnRFQCaseRequestingWorkerNameChanging(value);
                this._RFQCaseRequestingWorkerName = value;
                this.OnRFQCaseRequestingWorkerNameChanged();
                this.OnPropertyChanged("RFQCaseRequestingWorkerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseRequestingWorkerName;
        partial void OnRFQCaseRequestingWorkerNameChanging(string value);
        partial void OnRFQCaseRequestingWorkerNameChanged();
        /// <summary>
        /// There are no comments for Property LineAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineAmount is required.")]
        public virtual decimal LineAmount
        {
            get
            {
                return this._LineAmount;
            }
            set
            {
                this.OnLineAmountChanging(value);
                this._LineAmount = value;
                this.OnLineAmountChanged();
                this.OnPropertyChanged("LineAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineAmount;
        partial void OnLineAmountChanging(decimal value);
        partial void OnLineAmountChanged();
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
