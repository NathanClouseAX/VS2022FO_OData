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
    /// There are no comments for FundSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FundSingle")]
    public partial class FundSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Fund>
    {
        /// <summary>
        /// Initialize a new FundSingle object.
        /// </summary>
        public FundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FundSingle object.
        /// </summary>
        public FundSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FundSingle object.
        /// </summary>
        public FundSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Fund> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Fund in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FundNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FundNumber")]
    [global::Microsoft.OData.Client.EntitySet("Funds")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Fund")]
    public partial class Fund : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Fund object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fundNumber">Initial value of FundNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Fund CreateFund(string dataAreaId, string fundNumber)
        {
            Fund fund = new Fund();
            fund.DataAreaId = dataAreaId;
            fund.FundNumber = fundNumber;
            return fund;
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
        /// There are no comments for Property FundNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FundNumber is required.")]
        public virtual string FundNumber
        {
            get
            {
                return this._FundNumber;
            }
            set
            {
                this.OnFundNumberChanging(value);
                this._FundNumber = value;
                this.OnFundNumberChanged();
                this.OnPropertyChanged("FundNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundNumber;
        partial void OnFundNumberChanging(string value);
        partial void OnFundNumberChanged();
        /// <summary>
        /// There are no comments for Property IsMajor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsMajor")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsMajor
        {
            get
            {
                return this._IsMajor;
            }
            set
            {
                this.OnIsMajorChanging(value);
                this._IsMajor = value;
                this.OnIsMajorChanged();
                this.OnPropertyChanged("IsMajor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsMajor;
        partial void OnIsMajorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsMajorChanged();
        /// <summary>
        /// There are no comments for Property FundClass in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundClass")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FundClassValue> FundClass
        {
            get
            {
                return this._FundClass;
            }
            set
            {
                this.OnFundClassChanging(value);
                this._FundClass = value;
                this.OnFundClassChanged();
                this.OnPropertyChanged("FundClass");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FundClassValue> _FundClass;
        partial void OnFundClassChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FundClassValue> value);
        partial void OnFundClassChanged();
        /// <summary>
        /// There are no comments for Property FundName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundName")]
        public virtual string FundName
        {
            get
            {
                return this._FundName;
            }
            set
            {
                this.OnFundNameChanging(value);
                this._FundName = value;
                this.OnFundNameChanged();
                this.OnPropertyChanged("FundName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundName;
        partial void OnFundNameChanging(string value);
        partial void OnFundNameChanged();
        /// <summary>
        /// There are no comments for Property YearEndOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("YearEndOption")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerFundYearEndOption> YearEndOption
        {
            get
            {
                return this._YearEndOption;
            }
            set
            {
                this.OnYearEndOptionChanging(value);
                this._YearEndOption = value;
                this.OnYearEndOptionChanged();
                this.OnPropertyChanged("YearEndOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerFundYearEndOption> _YearEndOption;
        partial void OnYearEndOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerFundYearEndOption> value);
        partial void OnYearEndOptionChanged();
        /// <summary>
        /// There are no comments for Property OverrideYearEndOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverrideYearEndOption")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OverrideYearEndOption
        {
            get
            {
                return this._OverrideYearEndOption;
            }
            set
            {
                this.OnOverrideYearEndOptionChanging(value);
                this._OverrideYearEndOption = value;
                this.OnOverrideYearEndOptionChanged();
                this.OnPropertyChanged("OverrideYearEndOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OverrideYearEndOption;
        partial void OnOverrideYearEndOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOverrideYearEndOptionChanged();
        /// <summary>
        /// There are no comments for Property FundType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundType")]
        public virtual string FundType
        {
            get
            {
                return this._FundType;
            }
            set
            {
                this.OnFundTypeChanging(value);
                this._FundType = value;
                this.OnFundTypeChanged();
                this.OnPropertyChanged("FundType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundType;
        partial void OnFundTypeChanging(string value);
        partial void OnFundTypeChanged();
        /// <summary>
        /// There are no comments for Property IsNonReportingFund in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsNonReportingFund")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsNonReportingFund
        {
            get
            {
                return this._IsNonReportingFund;
            }
            set
            {
                this.OnIsNonReportingFundChanging(value);
                this._IsNonReportingFund = value;
                this.OnIsNonReportingFundChanged();
                this.OnPropertyChanged("IsNonReportingFund");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsNonReportingFund;
        partial void OnIsNonReportingFundChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsNonReportingFundChanged();
        /// <summary>
        /// There are no comments for Property PSNTreasurerFundReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PSNTreasurerFundReport")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PSNTreasurerFundReport
        {
            get
            {
                return this._PSNTreasurerFundReport;
            }
            set
            {
                this.OnPSNTreasurerFundReportChanging(value);
                this._PSNTreasurerFundReport = value;
                this.OnPSNTreasurerFundReportChanged();
                this.OnPropertyChanged("PSNTreasurerFundReport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PSNTreasurerFundReport;
        partial void OnPSNTreasurerFundReportChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPSNTreasurerFundReportChanged();
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
