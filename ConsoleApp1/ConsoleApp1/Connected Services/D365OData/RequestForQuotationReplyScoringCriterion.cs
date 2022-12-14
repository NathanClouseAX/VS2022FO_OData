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
    /// There are no comments for RequestForQuotationReplyScoringCriterionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RequestForQuotationReplyScoringCriterionSingle")]
    public partial class RequestForQuotationReplyScoringCriterionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RequestForQuotationReplyScoringCriterion>
    {
        /// <summary>
        /// Initialize a new RequestForQuotationReplyScoringCriterionSingle object.
        /// </summary>
        public RequestForQuotationReplyScoringCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RequestForQuotationReplyScoringCriterionSingle object.
        /// </summary>
        public RequestForQuotationReplyScoringCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RequestForQuotationReplyScoringCriterionSingle object.
        /// </summary>
        public RequestForQuotationReplyScoringCriterionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RequestForQuotationReplyScoringCriterion> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RequestForQuotationReplyScoringCriterion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RFQNumber
    /// CriterionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RFQNumber", "CriterionId")]
    [global::Microsoft.OData.Client.EntitySet("RequestForQuotationReplyScoringCriteria")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RequestForQuotationReplyScoringCriterion")]
    public partial class RequestForQuotationReplyScoringCriterion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RequestForQuotationReplyScoringCriterion object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rFQNumber">Initial value of RFQNumber.</param>
        /// <param name="criterionId">Initial value of CriterionId.</param>
        /// <param name="criterionScore">Initial value of CriterionScore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RequestForQuotationReplyScoringCriterion CreateRequestForQuotationReplyScoringCriterion(string dataAreaId, string rFQNumber, string criterionId, int criterionScore)
        {
            RequestForQuotationReplyScoringCriterion requestForQuotationReplyScoringCriterion = new RequestForQuotationReplyScoringCriterion();
            requestForQuotationReplyScoringCriterion.DataAreaId = dataAreaId;
            requestForQuotationReplyScoringCriterion.RFQNumber = rFQNumber;
            requestForQuotationReplyScoringCriterion.CriterionId = criterionId;
            requestForQuotationReplyScoringCriterion.CriterionScore = criterionScore;
            return requestForQuotationReplyScoringCriterion;
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
        /// There are no comments for Property CriterionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CriterionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CriterionId is required.")]
        public virtual string CriterionId
        {
            get
            {
                return this._CriterionId;
            }
            set
            {
                this.OnCriterionIdChanging(value);
                this._CriterionId = value;
                this.OnCriterionIdChanged();
                this.OnPropertyChanged("CriterionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CriterionId;
        partial void OnCriterionIdChanging(string value);
        partial void OnCriterionIdChanged();
        /// <summary>
        /// There are no comments for Property CriterionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CriterionName")]
        public virtual string CriterionName
        {
            get
            {
                return this._CriterionName;
            }
            set
            {
                this.OnCriterionNameChanging(value);
                this._CriterionName = value;
                this.OnCriterionNameChanged();
                this.OnPropertyChanged("CriterionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CriterionName;
        partial void OnCriterionNameChanging(string value);
        partial void OnCriterionNameChanged();
        /// <summary>
        /// There are no comments for Property VendorScoringStatusComment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorScoringStatusComment")]
        public virtual string VendorScoringStatusComment
        {
            get
            {
                return this._VendorScoringStatusComment;
            }
            set
            {
                this.OnVendorScoringStatusCommentChanging(value);
                this._VendorScoringStatusComment = value;
                this.OnVendorScoringStatusCommentChanged();
                this.OnPropertyChanged("VendorScoringStatusComment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorScoringStatusComment;
        partial void OnVendorScoringStatusCommentChanging(string value);
        partial void OnVendorScoringStatusCommentChanged();
        /// <summary>
        /// There are no comments for Property CriterionScore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CriterionScore")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CriterionScore is required.")]
        public virtual int CriterionScore
        {
            get
            {
                return this._CriterionScore;
            }
            set
            {
                this.OnCriterionScoreChanging(value);
                this._CriterionScore = value;
                this.OnCriterionScoreChanged();
                this.OnPropertyChanged("CriterionScore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CriterionScore;
        partial void OnCriterionScoreChanging(int value);
        partial void OnCriterionScoreChanged();
        /// <summary>
        /// There are no comments for Property VendorRFQReplyStatusCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRFQReplyStatusCode")]
        public virtual string VendorRFQReplyStatusCode
        {
            get
            {
                return this._VendorRFQReplyStatusCode;
            }
            set
            {
                this.OnVendorRFQReplyStatusCodeChanging(value);
                this._VendorRFQReplyStatusCode = value;
                this.OnVendorRFQReplyStatusCodeChanged();
                this.OnPropertyChanged("VendorRFQReplyStatusCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorRFQReplyStatusCode;
        partial void OnVendorRFQReplyStatusCodeChanging(string value);
        partial void OnVendorRFQReplyStatusCodeChanged();
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
