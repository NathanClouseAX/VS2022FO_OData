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
    /// There are no comments for BenefitOptionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitOptionSingle")]
    public partial class BenefitOptionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitOption>
    {
        /// <summary>
        /// Initialize a new BenefitOptionSingle object.
        /// </summary>
        public BenefitOptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitOptionSingle object.
        /// </summary>
        public BenefitOptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitOptionSingle object.
        /// </summary>
        public BenefitOptionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitOption> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Benefits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefits")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Benefit> Benefits
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Benefits == null))
                {
                    this._Benefits = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Benefit>(GetPath("Benefits"));
                }
                return this._Benefits;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Benefit> _Benefits;
        /// <summary>
        /// There are no comments for BenefitEligibilityOverrides in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitEligibilityOverrides")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride> BenefitEligibilityOverrides
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitEligibilityOverrides == null))
                {
                    this._BenefitEligibilityOverrides = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride>(GetPath("BenefitEligibilityOverrides"));
                }
                return this._BenefitEligibilityOverrides;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride> _BenefitEligibilityOverrides;
    }
    /// <summary>
    /// There are no comments for BenefitOption in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitOptionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitOptionId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitOptions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitOption")]
    public partial class BenefitOption : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitOption object.
        /// </summary>
        /// <param name="benefitOptionId">Initial value of BenefitOptionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitOption CreateBenefitOption(string benefitOptionId)
        {
            BenefitOption benefitOption = new BenefitOption();
            benefitOption.BenefitOptionId = benefitOptionId;
            return benefitOption;
        }
        /// <summary>
        /// There are no comments for Property BenefitOptionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitOptionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitOptionId is required.")]
        public virtual string BenefitOptionId
        {
            get
            {
                return this._BenefitOptionId;
            }
            set
            {
                this.OnBenefitOptionIdChanging(value);
                this._BenefitOptionId = value;
                this.OnBenefitOptionIdChanged();
                this.OnPropertyChanged("BenefitOptionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitOptionId;
        partial void OnBenefitOptionIdChanging(string value);
        partial void OnBenefitOptionIdChanged();
        /// <summary>
        /// There are no comments for Property AllowBeneficiaryDesignations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowBeneficiaryDesignations")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowBeneficiaryDesignations
        {
            get
            {
                return this._AllowBeneficiaryDesignations;
            }
            set
            {
                this.OnAllowBeneficiaryDesignationsChanging(value);
                this._AllowBeneficiaryDesignations = value;
                this.OnAllowBeneficiaryDesignationsChanged();
                this.OnPropertyChanged("AllowBeneficiaryDesignations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowBeneficiaryDesignations;
        partial void OnAllowBeneficiaryDesignationsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowBeneficiaryDesignationsChanged();
        /// <summary>
        /// There are no comments for Property AllowDependentCoverage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowDependentCoverage")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowDependentCoverage
        {
            get
            {
                return this._AllowDependentCoverage;
            }
            set
            {
                this.OnAllowDependentCoverageChanging(value);
                this._AllowDependentCoverage = value;
                this.OnAllowDependentCoverageChanged();
                this.OnPropertyChanged("AllowDependentCoverage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowDependentCoverage;
        partial void OnAllowDependentCoverageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowDependentCoverageChanged();
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
        /// There are no comments for Property IsWaive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsWaive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsWaive
        {
            get
            {
                return this._IsWaive;
            }
            set
            {
                this.OnIsWaiveChanging(value);
                this._IsWaive = value;
                this.OnIsWaiveChanged();
                this.OnPropertyChanged("IsWaive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsWaive;
        partial void OnIsWaiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsWaiveChanged();
        /// <summary>
        /// There are no comments for Property Benefits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Benefits")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Benefit> Benefits
        {
            get
            {
                return this._Benefits;
            }
            set
            {
                this.OnBenefitsChanging(value);
                this._Benefits = value;
                this.OnBenefitsChanged();
                this.OnPropertyChanged("Benefits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Benefit> _Benefits = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Benefit>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Benefit> value);
        partial void OnBenefitsChanged();
        /// <summary>
        /// There are no comments for Property BenefitEligibilityOverrides in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitEligibilityOverrides")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride> BenefitEligibilityOverrides
        {
            get
            {
                return this._BenefitEligibilityOverrides;
            }
            set
            {
                this.OnBenefitEligibilityOverridesChanging(value);
                this._BenefitEligibilityOverrides = value;
                this.OnBenefitEligibilityOverridesChanged();
                this.OnPropertyChanged("BenefitEligibilityOverrides");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride> _BenefitEligibilityOverrides = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitEligibilityOverridesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitEligibilityOverride> value);
        partial void OnBenefitEligibilityOverridesChanged();
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
