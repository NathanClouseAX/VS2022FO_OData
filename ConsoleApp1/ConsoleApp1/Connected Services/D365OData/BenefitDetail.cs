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
    /// There are no comments for BenefitDetailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitDetailSingle")]
    public partial class BenefitDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitDetail>
    {
        /// <summary>
        /// Initialize a new BenefitDetailSingle object.
        /// </summary>
        public BenefitDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitDetailSingle object.
        /// </summary>
        public BenefitDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitDetailSingle object.
        /// </summary>
        public BenefitDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefit")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle Benefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefit == null))
                {
                    this._Benefit = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("Benefit"));
                }
                return this._Benefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _Benefit;
    }
    /// <summary>
    /// There are no comments for BenefitDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("BenefitDetails")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitDetail")]
    public partial class BenefitDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitDetail object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="defaultDeductionAccountingCurrencyAmt">Initial value of DefaultDeductionAccountingCurrencyAmt.</param>
        /// <param name="defaultContributionAccountingCurrencyAmt">Initial value of DefaultContributionAccountingCurrencyAmt.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitDetail CreateBenefitDetail(string benefitId, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    decimal defaultDeductionAccountingCurrencyAmt, 
                    decimal defaultContributionAccountingCurrencyAmt, 
                    global::Microsoft.Dynamics.DataEntities.Benefit benefit)
        {
            BenefitDetail benefitDetail = new BenefitDetail();
            benefitDetail.BenefitId = benefitId;
            benefitDetail.ValidFrom = validFrom;
            benefitDetail.ValidTo = validTo;
            benefitDetail.DefaultDeductionAccountingCurrencyAmt = defaultDeductionAccountingCurrencyAmt;
            benefitDetail.DefaultContributionAccountingCurrencyAmt = defaultContributionAccountingCurrencyAmt;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            benefitDetail.Benefit = benefit;
            return benefitDetail;
        }
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitId is required.")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property DefaultContributionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultContributionBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> DefaultContributionBasis
        {
            get
            {
                return this._DefaultContributionBasis;
            }
            set
            {
                this.OnDefaultContributionBasisChanging(value);
                this._DefaultContributionBasis = value;
                this.OnDefaultContributionBasisChanged();
                this.OnPropertyChanged("DefaultContributionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> _DefaultContributionBasis;
        partial void OnDefaultContributionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollContributionBasis> value);
        partial void OnDefaultContributionBasisChanged();
        /// <summary>
        /// There are no comments for Property DefaultDeductionAccountingCurrencyAmt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDeductionAccountingCurrencyAmt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefaultDeductionAccountingCurrencyAmt is required.")]
        public virtual decimal DefaultDeductionAccountingCurrencyAmt
        {
            get
            {
                return this._DefaultDeductionAccountingCurrencyAmt;
            }
            set
            {
                this.OnDefaultDeductionAccountingCurrencyAmtChanging(value);
                this._DefaultDeductionAccountingCurrencyAmt = value;
                this.OnDefaultDeductionAccountingCurrencyAmtChanged();
                this.OnPropertyChanged("DefaultDeductionAccountingCurrencyAmt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultDeductionAccountingCurrencyAmt;
        partial void OnDefaultDeductionAccountingCurrencyAmtChanging(decimal value);
        partial void OnDefaultDeductionAccountingCurrencyAmtChanged();
        /// <summary>
        /// There are no comments for Property DefaultContributionAccountingCurrencyAmt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultContributionAccountingCurrencyAmt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefaultContributionAccountingCurrencyAmt is required.")]
        public virtual decimal DefaultContributionAccountingCurrencyAmt
        {
            get
            {
                return this._DefaultContributionAccountingCurrencyAmt;
            }
            set
            {
                this.OnDefaultContributionAccountingCurrencyAmtChanging(value);
                this._DefaultContributionAccountingCurrencyAmt = value;
                this.OnDefaultContributionAccountingCurrencyAmtChanged();
                this.OnPropertyChanged("DefaultContributionAccountingCurrencyAmt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DefaultContributionAccountingCurrencyAmt;
        partial void OnDefaultContributionAccountingCurrencyAmtChanging(decimal value);
        partial void OnDefaultContributionAccountingCurrencyAmtChanged();
        /// <summary>
        /// There are no comments for Property DeductionCalculationFrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionCalculationFrequencyId")]
        public virtual string DeductionCalculationFrequencyId
        {
            get
            {
                return this._DeductionCalculationFrequencyId;
            }
            set
            {
                this.OnDeductionCalculationFrequencyIdChanging(value);
                this._DeductionCalculationFrequencyId = value;
                this.OnDeductionCalculationFrequencyIdChanged();
                this.OnPropertyChanged("DeductionCalculationFrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeductionCalculationFrequencyId;
        partial void OnDeductionCalculationFrequencyIdChanging(string value);
        partial void OnDeductionCalculationFrequencyIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultDeductionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDeductionBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> DefaultDeductionBasis
        {
            get
            {
                return this._DefaultDeductionBasis;
            }
            set
            {
                this.OnDefaultDeductionBasisChanging(value);
                this._DefaultDeductionBasis = value;
                this.OnDefaultDeductionBasisChanged();
                this.OnPropertyChanged("DefaultDeductionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> _DefaultDeductionBasis;
        partial void OnDefaultDeductionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollDeductionBasis> value);
        partial void OnDefaultDeductionBasisChanged();
        /// <summary>
        /// There are no comments for Property ContributionCalculationRateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionCalculationRateId")]
        public virtual string ContributionCalculationRateId
        {
            get
            {
                return this._ContributionCalculationRateId;
            }
            set
            {
                this.OnContributionCalculationRateIdChanging(value);
                this._ContributionCalculationRateId = value;
                this.OnContributionCalculationRateIdChanged();
                this.OnPropertyChanged("ContributionCalculationRateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContributionCalculationRateId;
        partial void OnContributionCalculationRateIdChanging(string value);
        partial void OnContributionCalculationRateIdChanged();
        /// <summary>
        /// There are no comments for Property ContributionCalculationFrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionCalculationFrequencyId")]
        public virtual string ContributionCalculationFrequencyId
        {
            get
            {
                return this._ContributionCalculationFrequencyId;
            }
            set
            {
                this.OnContributionCalculationFrequencyIdChanging(value);
                this._ContributionCalculationFrequencyId = value;
                this.OnContributionCalculationFrequencyIdChanged();
                this.OnPropertyChanged("ContributionCalculationFrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContributionCalculationFrequencyId;
        partial void OnContributionCalculationFrequencyIdChanging(string value);
        partial void OnContributionCalculationFrequencyIdChanged();
        /// <summary>
        /// There are no comments for Property Benefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Benefit is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit Benefit
        {
            get
            {
                return this._Benefit;
            }
            set
            {
                this.OnBenefitChanging(value);
                this._Benefit = value;
                this.OnBenefitChanged();
                this.OnPropertyChanged("Benefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _Benefit;
        partial void OnBenefitChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnBenefitChanged();
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