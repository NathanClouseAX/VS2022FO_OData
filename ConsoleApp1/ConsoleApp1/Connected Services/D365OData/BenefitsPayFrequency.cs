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
    /// There are no comments for BenefitsPayFrequencySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPayFrequencySingle")]
    public partial class BenefitsPayFrequencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPayFrequency>
    {
        /// <summary>
        /// Initialize a new BenefitsPayFrequencySingle object.
        /// </summary>
        public BenefitsPayFrequencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsPayFrequencySingle object.
        /// </summary>
        public BenefitsPayFrequencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsPayFrequencySingle object.
        /// </summary>
        public BenefitsPayFrequencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsPayFrequency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitsParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsParameter")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsParameterSingle BenefitsParameter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsParameter == null))
                {
                    this._BenefitsParameter = new global::Microsoft.Dynamics.DataEntities.BenefitsParameterSingle(this.Context, GetPath("BenefitsParameter"));
                }
                return this._BenefitsParameter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsParameterSingle _BenefitsParameter;
        /// <summary>
        /// There are no comments for BenefitsRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsRate")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRate> BenefitsRate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsRate == null))
                {
                    this._BenefitsRate = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRate>(GetPath("BenefitsRate"));
                }
                return this._BenefitsRate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsRate> _BenefitsRate;
        /// <summary>
        /// There are no comments for BenefitsParameterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsParameterV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2Single BenefitsParameterV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsParameterV2 == null))
                {
                    this._BenefitsParameterV2 = new global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2Single(this.Context, GetPath("BenefitsParameterV2"));
                }
                return this._BenefitsParameterV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2Single _BenefitsParameterV2;
    }
    /// <summary>
    /// There are no comments for BenefitsPayFrequency in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PayFrequencyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PayFrequencyId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsPayFrequencies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPayFrequency")]
    public partial class BenefitsPayFrequency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsPayFrequency object.
        /// </summary>
        /// <param name="payFrequencyId">Initial value of PayFrequencyId.</param>
        /// <param name="weeklyConversionFactor">Initial value of WeeklyConversionFactor.</param>
        /// <param name="monthlyConversionFactor">Initial value of MonthlyConversionFactor.</param>
        /// <param name="biweeklyConversionFactor">Initial value of BiweeklyConversionFactor.</param>
        /// <param name="numberOfPayPeriods">Initial value of NumberOfPayPeriods.</param>
        /// <param name="annualConversionFactor">Initial value of AnnualConversionFactor.</param>
        /// <param name="quarterlyConversionFactor">Initial value of QuarterlyConversionFactor.</param>
        /// <param name="semiAnnualConversionFactor">Initial value of SemiAnnualConversionFactor.</param>
        /// <param name="semiMonthlyConversionFactor">Initial value of SemiMonthlyConversionFactor.</param>
        /// <param name="dailyConversionFactor">Initial value of DailyConversionFactor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsPayFrequency CreateBenefitsPayFrequency(string payFrequencyId, 
                    decimal weeklyConversionFactor, 
                    decimal monthlyConversionFactor, 
                    decimal biweeklyConversionFactor, 
                    int numberOfPayPeriods, 
                    decimal annualConversionFactor, 
                    decimal quarterlyConversionFactor, 
                    decimal semiAnnualConversionFactor, 
                    decimal semiMonthlyConversionFactor, 
                    decimal dailyConversionFactor)
        {
            BenefitsPayFrequency benefitsPayFrequency = new BenefitsPayFrequency();
            benefitsPayFrequency.PayFrequencyId = payFrequencyId;
            benefitsPayFrequency.WeeklyConversionFactor = weeklyConversionFactor;
            benefitsPayFrequency.MonthlyConversionFactor = monthlyConversionFactor;
            benefitsPayFrequency.BiweeklyConversionFactor = biweeklyConversionFactor;
            benefitsPayFrequency.NumberOfPayPeriods = numberOfPayPeriods;
            benefitsPayFrequency.AnnualConversionFactor = annualConversionFactor;
            benefitsPayFrequency.QuarterlyConversionFactor = quarterlyConversionFactor;
            benefitsPayFrequency.SemiAnnualConversionFactor = semiAnnualConversionFactor;
            benefitsPayFrequency.SemiMonthlyConversionFactor = semiMonthlyConversionFactor;
            benefitsPayFrequency.DailyConversionFactor = dailyConversionFactor;
            return benefitsPayFrequency;
        }
        /// <summary>
        /// There are no comments for Property PayFrequencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayFrequencyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayFrequencyId is required.")]
        public virtual string PayFrequencyId
        {
            get
            {
                return this._PayFrequencyId;
            }
            set
            {
                this.OnPayFrequencyIdChanging(value);
                this._PayFrequencyId = value;
                this.OnPayFrequencyIdChanged();
                this.OnPropertyChanged("PayFrequencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayFrequencyId;
        partial void OnPayFrequencyIdChanging(string value);
        partial void OnPayFrequencyIdChanged();
        /// <summary>
        /// There are no comments for Property WeeklyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WeeklyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WeeklyConversionFactor is required.")]
        public virtual decimal WeeklyConversionFactor
        {
            get
            {
                return this._WeeklyConversionFactor;
            }
            set
            {
                this.OnWeeklyConversionFactorChanging(value);
                this._WeeklyConversionFactor = value;
                this.OnWeeklyConversionFactorChanged();
                this.OnPropertyChanged("WeeklyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WeeklyConversionFactor;
        partial void OnWeeklyConversionFactorChanging(decimal value);
        partial void OnWeeklyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property MonthlyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MonthlyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MonthlyConversionFactor is required.")]
        public virtual decimal MonthlyConversionFactor
        {
            get
            {
                return this._MonthlyConversionFactor;
            }
            set
            {
                this.OnMonthlyConversionFactorChanging(value);
                this._MonthlyConversionFactor = value;
                this.OnMonthlyConversionFactorChanged();
                this.OnPropertyChanged("MonthlyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MonthlyConversionFactor;
        partial void OnMonthlyConversionFactorChanging(decimal value);
        partial void OnMonthlyConversionFactorChanged();
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
        /// There are no comments for Property BiweeklyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BiweeklyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BiweeklyConversionFactor is required.")]
        public virtual decimal BiweeklyConversionFactor
        {
            get
            {
                return this._BiweeklyConversionFactor;
            }
            set
            {
                this.OnBiweeklyConversionFactorChanging(value);
                this._BiweeklyConversionFactor = value;
                this.OnBiweeklyConversionFactorChanged();
                this.OnPropertyChanged("BiweeklyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BiweeklyConversionFactor;
        partial void OnBiweeklyConversionFactorChanging(decimal value);
        partial void OnBiweeklyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property Period in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Period")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPayFrequencyPeriod> Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this.OnPeriodChanging(value);
                this._Period = value;
                this.OnPeriodChanged();
                this.OnPropertyChanged("Period");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPayFrequencyPeriod> _Period;
        partial void OnPeriodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitPayFrequencyPeriod> value);
        partial void OnPeriodChanged();
        /// <summary>
        /// There are no comments for Property NumberOfPayPeriods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfPayPeriods")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfPayPeriods is required.")]
        public virtual int NumberOfPayPeriods
        {
            get
            {
                return this._NumberOfPayPeriods;
            }
            set
            {
                this.OnNumberOfPayPeriodsChanging(value);
                this._NumberOfPayPeriods = value;
                this.OnNumberOfPayPeriodsChanged();
                this.OnPropertyChanged("NumberOfPayPeriods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfPayPeriods;
        partial void OnNumberOfPayPeriodsChanging(int value);
        partial void OnNumberOfPayPeriodsChanged();
        /// <summary>
        /// There are no comments for Property AnnualConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AnnualConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AnnualConversionFactor is required.")]
        public virtual decimal AnnualConversionFactor
        {
            get
            {
                return this._AnnualConversionFactor;
            }
            set
            {
                this.OnAnnualConversionFactorChanging(value);
                this._AnnualConversionFactor = value;
                this.OnAnnualConversionFactorChanged();
                this.OnPropertyChanged("AnnualConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AnnualConversionFactor;
        partial void OnAnnualConversionFactorChanging(decimal value);
        partial void OnAnnualConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property QuarterlyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuarterlyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuarterlyConversionFactor is required.")]
        public virtual decimal QuarterlyConversionFactor
        {
            get
            {
                return this._QuarterlyConversionFactor;
            }
            set
            {
                this.OnQuarterlyConversionFactorChanging(value);
                this._QuarterlyConversionFactor = value;
                this.OnQuarterlyConversionFactorChanged();
                this.OnPropertyChanged("QuarterlyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QuarterlyConversionFactor;
        partial void OnQuarterlyConversionFactorChanging(decimal value);
        partial void OnQuarterlyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property SemiAnnualConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SemiAnnualConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SemiAnnualConversionFactor is required.")]
        public virtual decimal SemiAnnualConversionFactor
        {
            get
            {
                return this._SemiAnnualConversionFactor;
            }
            set
            {
                this.OnSemiAnnualConversionFactorChanging(value);
                this._SemiAnnualConversionFactor = value;
                this.OnSemiAnnualConversionFactorChanged();
                this.OnPropertyChanged("SemiAnnualConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SemiAnnualConversionFactor;
        partial void OnSemiAnnualConversionFactorChanging(decimal value);
        partial void OnSemiAnnualConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property SemiMonthlyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SemiMonthlyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SemiMonthlyConversionFactor is required.")]
        public virtual decimal SemiMonthlyConversionFactor
        {
            get
            {
                return this._SemiMonthlyConversionFactor;
            }
            set
            {
                this.OnSemiMonthlyConversionFactorChanging(value);
                this._SemiMonthlyConversionFactor = value;
                this.OnSemiMonthlyConversionFactorChanged();
                this.OnPropertyChanged("SemiMonthlyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SemiMonthlyConversionFactor;
        partial void OnSemiMonthlyConversionFactorChanging(decimal value);
        partial void OnSemiMonthlyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property DailyConversionFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DailyConversionFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DailyConversionFactor is required.")]
        public virtual decimal DailyConversionFactor
        {
            get
            {
                return this._DailyConversionFactor;
            }
            set
            {
                this.OnDailyConversionFactorChanging(value);
                this._DailyConversionFactor = value;
                this.OnDailyConversionFactorChanged();
                this.OnPropertyChanged("DailyConversionFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DailyConversionFactor;
        partial void OnDailyConversionFactorChanging(decimal value);
        partial void OnDailyConversionFactorChanged();
        /// <summary>
        /// There are no comments for Property BenefitsParameter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsParameter")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsParameter BenefitsParameter
        {
            get
            {
                return this._BenefitsParameter;
            }
            set
            {
                this.OnBenefitsParameterChanging(value);
                this._BenefitsParameter = value;
                this.OnBenefitsParameterChanged();
                this.OnPropertyChanged("BenefitsParameter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsParameter _BenefitsParameter;
        partial void OnBenefitsParameterChanging(global::Microsoft.Dynamics.DataEntities.BenefitsParameter value);
        partial void OnBenefitsParameterChanged();
        /// <summary>
        /// There are no comments for Property BenefitsRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsRate")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRate> BenefitsRate
        {
            get
            {
                return this._BenefitsRate;
            }
            set
            {
                this.OnBenefitsRateChanging(value);
                this._BenefitsRate = value;
                this.OnBenefitsRateChanged();
                this.OnPropertyChanged("BenefitsRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRate> _BenefitsRate = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsRateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsRate> value);
        partial void OnBenefitsRateChanged();
        /// <summary>
        /// There are no comments for Property BenefitsParameterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsParameterV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2 BenefitsParameterV2
        {
            get
            {
                return this._BenefitsParameterV2;
            }
            set
            {
                this.OnBenefitsParameterV2Changing(value);
                this._BenefitsParameterV2 = value;
                this.OnBenefitsParameterV2Changed();
                this.OnPropertyChanged("BenefitsParameterV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2 _BenefitsParameterV2;
        partial void OnBenefitsParameterV2Changing(global::Microsoft.Dynamics.DataEntities.BenefitsParameterV2 value);
        partial void OnBenefitsParameterV2Changed();
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
