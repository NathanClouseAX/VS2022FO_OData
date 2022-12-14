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
    /// There are no comments for VendDlvLeadTimePredictionResultSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendDlvLeadTimePredictionResultSingle")]
    public partial class VendDlvLeadTimePredictionResultSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendDlvLeadTimePredictionResult>
    {
        /// <summary>
        /// Initialize a new VendDlvLeadTimePredictionResultSingle object.
        /// </summary>
        public VendDlvLeadTimePredictionResultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendDlvLeadTimePredictionResultSingle object.
        /// </summary>
        public VendDlvLeadTimePredictionResultSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendDlvLeadTimePredictionResultSingle object.
        /// </summary>
        public VendDlvLeadTimePredictionResultSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendDlvLeadTimePredictionResult> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VendDlvLeadTimePredictionResult in the schema.
    /// </summary>
    /// <KeyProperties>
    /// HashKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HashKey")]
    [global::Microsoft.OData.Client.EntitySet("VendDlvLeadTimePredictionResults")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendDlvLeadTimePredictionResult")]
    public partial class VendDlvLeadTimePredictionResult : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendDlvLeadTimePredictionResult object.
        /// </summary>
        /// <param name="hashKey">Initial value of HashKey.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="scoredDate">Initial value of ScoredDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendDlvLeadTimePredictionResult CreateVendDlvLeadTimePredictionResult(string hashKey, long lineNumber, global::System.DateTimeOffset scoredDate)
        {
            VendDlvLeadTimePredictionResult vendDlvLeadTimePredictionResult = new VendDlvLeadTimePredictionResult();
            vendDlvLeadTimePredictionResult.HashKey = hashKey;
            vendDlvLeadTimePredictionResult.LineNumber = lineNumber;
            vendDlvLeadTimePredictionResult.ScoredDate = scoredDate;
            return vendDlvLeadTimePredictionResult;
        }
        /// <summary>
        /// There are no comments for Property HashKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HashKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HashKey is required.")]
        public virtual string HashKey
        {
            get
            {
                return this._HashKey;
            }
            set
            {
                this.OnHashKeyChanging(value);
                this._HashKey = value;
                this.OnHashKeyChanged();
                this.OnPropertyChanged("HashKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HashKey;
        partial void OnHashKeyChanging(string value);
        partial void OnHashKeyChanged();
        /// <summary>
        /// There are no comments for Property Explainability in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Explainability")]
        public virtual string Explainability
        {
            get
            {
                return this._Explainability;
            }
            set
            {
                this.OnExplainabilityChanging(value);
                this._Explainability = value;
                this.OnExplainabilityChanged();
                this.OnPropertyChanged("Explainability");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Explainability;
        partial void OnExplainabilityChanging(string value);
        partial void OnExplainabilityChanged();
        /// <summary>
        /// There are no comments for Property ReferenceDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceDataAreaId")]
        public virtual string ReferenceDataAreaId
        {
            get
            {
                return this._ReferenceDataAreaId;
            }
            set
            {
                this.OnReferenceDataAreaIdChanging(value);
                this._ReferenceDataAreaId = value;
                this.OnReferenceDataAreaIdChanged();
                this.OnPropertyChanged("ReferenceDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceDataAreaId;
        partial void OnReferenceDataAreaIdChanging(string value);
        partial void OnReferenceDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual long LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LineNumber;
        partial void OnLineNumberChanging(long value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ScoredDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScoredDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScoredDate is required.")]
        public virtual global::System.DateTimeOffset ScoredDate
        {
            get
            {
                return this._ScoredDate;
            }
            set
            {
                this.OnScoredDateChanging(value);
                this._ScoredDate = value;
                this.OnScoredDateChanged();
                this.OnPropertyChanged("ScoredDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ScoredDate;
        partial void OnScoredDateChanging(global::System.DateTimeOffset value);
        partial void OnScoredDateChanged();
        /// <summary>
        /// There are no comments for Property ModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelId")]
        public virtual string ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                this.OnModelIdChanging(value);
                this._ModelId = value;
                this.OnModelIdChanged();
                this.OnPropertyChanged("ModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelId;
        partial void OnModelIdChanging(string value);
        partial void OnModelIdChanged();
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
        /// There are no comments for Property Likelihoods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Likelihoods")]
        public virtual string Likelihoods
        {
            get
            {
                return this._Likelihoods;
            }
            set
            {
                this.OnLikelihoodsChanging(value);
                this._Likelihoods = value;
                this.OnLikelihoodsChanged();
                this.OnPropertyChanged("Likelihoods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Likelihoods;
        partial void OnLikelihoodsChanging(string value);
        partial void OnLikelihoodsChanged();
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
