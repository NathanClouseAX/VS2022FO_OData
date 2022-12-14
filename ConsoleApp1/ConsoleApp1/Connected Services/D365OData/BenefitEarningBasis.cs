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
    /// There are no comments for BenefitEarningBasisSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitEarningBasisSingle")]
    public partial class BenefitEarningBasisSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEarningBasis>
    {
        /// <summary>
        /// Initialize a new BenefitEarningBasisSingle object.
        /// </summary>
        public BenefitEarningBasisSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitEarningBasisSingle object.
        /// </summary>
        public BenefitEarningBasisSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitEarningBasisSingle object.
        /// </summary>
        public BenefitEarningBasisSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitEarningBasis> query)
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
    /// There are no comments for BenefitEarningBasis in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EarningCodeId
    /// BenefitPlanId
    /// BenefitOptionId
    /// Effective
    /// Expiration
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EarningCodeId", "BenefitPlanId", "BenefitOptionId", "Effective", "Expiration")]
    [global::Microsoft.OData.Client.EntitySet("BenefitEarningBasis")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitEarningBasis")]
    public partial class BenefitEarningBasis : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitEarningBasis object.
        /// </summary>
        /// <param name="earningCodeId">Initial value of EarningCodeId.</param>
        /// <param name="benefitPlanId">Initial value of BenefitPlanId.</param>
        /// <param name="benefitOptionId">Initial value of BenefitOptionId.</param>
        /// <param name="effective">Initial value of Effective.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="benefit">Initial value of Benefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitEarningBasis CreateBenefitEarningBasis(string earningCodeId, 
                    string benefitPlanId, 
                    string benefitOptionId, 
                    global::System.DateTimeOffset effective, 
                    global::System.DateTimeOffset expiration, 
                    global::Microsoft.Dynamics.DataEntities.Benefit benefit)
        {
            BenefitEarningBasis benefitEarningBasis = new BenefitEarningBasis();
            benefitEarningBasis.EarningCodeId = earningCodeId;
            benefitEarningBasis.BenefitPlanId = benefitPlanId;
            benefitEarningBasis.BenefitOptionId = benefitOptionId;
            benefitEarningBasis.Effective = effective;
            benefitEarningBasis.Expiration = expiration;
            if ((benefit == null))
            {
                throw new global::System.ArgumentNullException("benefit");
            }
            benefitEarningBasis.Benefit = benefit;
            return benefitEarningBasis;
        }
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EarningCodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EarningCodeId is required.")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property BenefitPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitPlanId is required.")]
        public virtual string BenefitPlanId
        {
            get
            {
                return this._BenefitPlanId;
            }
            set
            {
                this.OnBenefitPlanIdChanging(value);
                this._BenefitPlanId = value;
                this.OnBenefitPlanIdChanged();
                this.OnPropertyChanged("BenefitPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitPlanId;
        partial void OnBenefitPlanIdChanging(string value);
        partial void OnBenefitPlanIdChanged();
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
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Effective")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Effective is required.")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Expiration")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Expiration is required.")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitId")]
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
