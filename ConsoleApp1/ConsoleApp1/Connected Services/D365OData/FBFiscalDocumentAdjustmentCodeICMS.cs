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
    /// There are no comments for FBFiscalDocumentAdjustmentCodeICMSSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBFiscalDocumentAdjustmentCodeICMSSingle")]
    public partial class FBFiscalDocumentAdjustmentCodeICMSSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FBFiscalDocumentAdjustmentCodeICMS>
    {
        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeICMSSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeICMSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeICMSSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeICMSSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeICMSSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeICMSSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FBFiscalDocumentAdjustmentCodeICMS> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FBFiscalDocumentAdjustmentCodeICMS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AdjustmentCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AdjustmentCode")]
    [global::Microsoft.OData.Client.EntitySet("FBFiscalDocumentAdjustmentCodesICMS")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBFiscalDocumentAdjustmentCodeICMS")]
    public partial class FBFiscalDocumentAdjustmentCodeICMS : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FBFiscalDocumentAdjustmentCodeICMS object.
        /// </summary>
        /// <param name="adjustmentCode">Initial value of AdjustmentCode.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FBFiscalDocumentAdjustmentCodeICMS CreateFBFiscalDocumentAdjustmentCodeICMS(string adjustmentCode, global::System.DateTimeOffset validFromDate, global::System.DateTimeOffset validToDate)
        {
            FBFiscalDocumentAdjustmentCodeICMS fBFiscalDocumentAdjustmentCodeICMS = new FBFiscalDocumentAdjustmentCodeICMS();
            fBFiscalDocumentAdjustmentCodeICMS.AdjustmentCode = adjustmentCode;
            fBFiscalDocumentAdjustmentCodeICMS.ValidFromDate = validFromDate;
            fBFiscalDocumentAdjustmentCodeICMS.ValidToDate = validToDate;
            return fBFiscalDocumentAdjustmentCodeICMS;
        }
        /// <summary>
        /// There are no comments for Property AdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustmentCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdjustmentCode is required.")]
        public virtual string AdjustmentCode
        {
            get
            {
                return this._AdjustmentCode;
            }
            set
            {
                this.OnAdjustmentCodeChanging(value);
                this._AdjustmentCode = value;
                this.OnAdjustmentCodeChanged();
                this.OnPropertyChanged("AdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdjustmentCode;
        partial void OnAdjustmentCodeChanging(string value);
        partial void OnAdjustmentCodeChanged();
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
        /// There are no comments for Property SpedAdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SpedAdjustmentCode")]
        public virtual string SpedAdjustmentCode
        {
            get
            {
                return this._SpedAdjustmentCode;
            }
            set
            {
                this.OnSpedAdjustmentCodeChanging(value);
                this._SpedAdjustmentCode = value;
                this.OnSpedAdjustmentCodeChanged();
                this.OnPropertyChanged("SpedAdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SpedAdjustmentCode;
        partial void OnSpedAdjustmentCodeChanging(string value);
        partial void OnSpedAdjustmentCodeChanged();
        /// <summary>
        /// There are no comments for Property Table52 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Table52")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Table52
        {
            get
            {
                return this._Table52;
            }
            set
            {
                this.OnTable52Changing(value);
                this._Table52 = value;
                this.OnTable52Changed();
                this.OnPropertyChanged("Table52");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Table52;
        partial void OnTable52Changing(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnTable52Changed();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFromDate is required.")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
        /// <summary>
        /// There are no comments for Property TypeOfBenefitCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeOfBenefitCode")]
        public virtual string TypeOfBenefitCode
        {
            get
            {
                return this._TypeOfBenefitCode;
            }
            set
            {
                this.OnTypeOfBenefitCodeChanging(value);
                this._TypeOfBenefitCode = value;
                this.OnTypeOfBenefitCodeChanged();
                this.OnPropertyChanged("TypeOfBenefitCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TypeOfBenefitCode;
        partial void OnTypeOfBenefitCodeChanging(string value);
        partial void OnTypeOfBenefitCodeChanged();
        /// <summary>
        /// There are no comments for Property Classification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Classification")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBFiscalDocumentClassificationICMS_BR> Classification
        {
            get
            {
                return this._Classification;
            }
            set
            {
                this.OnClassificationChanging(value);
                this._Classification = value;
                this.OnClassificationChanged();
                this.OnPropertyChanged("Classification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBFiscalDocumentClassificationICMS_BR> _Classification;
        partial void OnClassificationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBFiscalDocumentClassificationICMS_BR> value);
        partial void OnClassificationChanged();
        /// <summary>
        /// There are no comments for Property TaxPaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPaymentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentCollectionType_BR> TaxPaymentType
        {
            get
            {
                return this._TaxPaymentType;
            }
            set
            {
                this.OnTaxPaymentTypeChanging(value);
                this._TaxPaymentType = value;
                this.OnTaxPaymentTypeChanged();
                this.OnPropertyChanged("TaxPaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentCollectionType_BR> _TaxPaymentType;
        partial void OnTaxPaymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentCollectionType_BR> value);
        partial void OnTaxPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_BR> TaxType
        {
            get
            {
                return this._TaxType;
            }
            set
            {
                this.OnTaxTypeChanging(value);
                this._TaxType = value;
                this.OnTaxTypeChanged();
                this.OnPropertyChanged("TaxType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_BR> _TaxType;
        partial void OnTaxTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxType_BR> value);
        partial void OnTaxTypeChanged();
        /// <summary>
        /// There are no comments for Property Responsibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Responsibility")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentResponsibilityType_BR> Responsibility
        {
            get
            {
                return this._Responsibility;
            }
            set
            {
                this.OnResponsibilityChanging(value);
                this._Responsibility = value;
                this.OnResponsibilityChanged();
                this.OnPropertyChanged("Responsibility");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentResponsibilityType_BR> _Responsibility;
        partial void OnResponsibilityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentResponsibilityType_BR> value);
        partial void OnResponsibilityChanged();
        /// <summary>
        /// There are no comments for Property OtherDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OtherDebit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OtherDebit
        {
            get
            {
                return this._OtherDebit;
            }
            set
            {
                this.OnOtherDebitChanging(value);
                this._OtherDebit = value;
                this.OnOtherDebitChanged();
                this.OnPropertyChanged("OtherDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OtherDebit;
        partial void OnOtherDebitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOtherDebitChanged();
        /// <summary>
        /// There are no comments for Property OccurrenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OccurrenceCode")]
        public virtual string OccurrenceCode
        {
            get
            {
                return this._OccurrenceCode;
            }
            set
            {
                this.OnOccurrenceCodeChanging(value);
                this._OccurrenceCode = value;
                this.OnOccurrenceCodeChanged();
                this.OnPropertyChanged("OccurrenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OccurrenceCode;
        partial void OnOccurrenceCodeChanging(string value);
        partial void OnOccurrenceCodeChanged();
        /// <summary>
        /// There are no comments for Property IsPovertyFund in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPovertyFund")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPovertyFund
        {
            get
            {
                return this._IsPovertyFund;
            }
            set
            {
                this.OnIsPovertyFundChanging(value);
                this._IsPovertyFund = value;
                this.OnIsPovertyFundChanged();
                this.OnPropertyChanged("IsPovertyFund");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPovertyFund;
        partial void OnIsPovertyFundChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPovertyFundChanged();
        /// <summary>
        /// There are no comments for Property ReceitaCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceitaCode")]
        public virtual string ReceitaCode
        {
            get
            {
                return this._ReceitaCode;
            }
            set
            {
                this.OnReceitaCodeChanging(value);
                this._ReceitaCode = value;
                this.OnReceitaCodeChanged();
                this.OnPropertyChanged("ReceitaCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceitaCode;
        partial void OnReceitaCodeChanging(string value);
        partial void OnReceitaCodeChanged();
        /// <summary>
        /// There are no comments for Property SourceTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceTax")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentSourceTaxationType_BR> SourceTax
        {
            get
            {
                return this._SourceTax;
            }
            set
            {
                this.OnSourceTaxChanging(value);
                this._SourceTax = value;
                this.OnSourceTaxChanged();
                this.OnPropertyChanged("SourceTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentSourceTaxationType_BR> _SourceTax;
        partial void OnSourceTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentSourceTaxationType_BR> value);
        partial void OnSourceTaxChanged();
        /// <summary>
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidToDate is required.")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property GIAAdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GIAAdjustmentCode")]
        public virtual string GIAAdjustmentCode
        {
            get
            {
                return this._GIAAdjustmentCode;
            }
            set
            {
                this.OnGIAAdjustmentCodeChanging(value);
                this._GIAAdjustmentCode = value;
                this.OnGIAAdjustmentCodeChanged();
                this.OnPropertyChanged("GIAAdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GIAAdjustmentCode;
        partial void OnGIAAdjustmentCodeChanging(string value);
        partial void OnGIAAdjustmentCodeChanged();
        /// <summary>
        /// There are no comments for Property AssessmentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssessmentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentAssessmentType_BR> AssessmentType
        {
            get
            {
                return this._AssessmentType;
            }
            set
            {
                this.OnAssessmentTypeChanging(value);
                this._AssessmentType = value;
                this.OnAssessmentTypeChanged();
                this.OnPropertyChanged("AssessmentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentAssessmentType_BR> _AssessmentType;
        partial void OnAssessmentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FBAdjustmentAssessmentType_BR> value);
        partial void OnAssessmentTypeChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
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
