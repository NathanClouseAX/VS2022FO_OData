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
    /// There are no comments for ProductReleasePolicySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductReleasePolicySingle")]
    public partial class ProductReleasePolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReleasePolicy>
    {
        /// <summary>
        /// Initialize a new ProductReleasePolicySingle object.
        /// </summary>
        public ProductReleasePolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductReleasePolicySingle object.
        /// </summary>
        public ProductReleasePolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductReleasePolicySingle object.
        /// </summary>
        public ProductReleasePolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReleasePolicy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringProductCategoryDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductCategoryDetails == null))
                {
                    this._EngineeringProductCategoryDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(GetPath("EngineeringProductCategoryDetails"));
                }
                return this._EngineeringProductCategoryDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails;
        /// <summary>
        /// There are no comments for ProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductV2> ProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductsV2 == null))
                {
                    this._ProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductV2>(GetPath("ProductsV2"));
                }
                return this._ProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductV2> _ProductsV2;
        /// <summary>
        /// There are no comments for ProductReleasePolicyLegalEntityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductReleasePolicyLegalEntityRules")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule> ProductReleasePolicyLegalEntityRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductReleasePolicyLegalEntityRules == null))
                {
                    this._ProductReleasePolicyLegalEntityRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule>(GetPath("ProductReleasePolicyLegalEntityRules"));
                }
                return this._ProductReleasePolicyLegalEntityRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule> _ProductReleasePolicyLegalEntityRules;
    }
    /// <summary>
    /// There are no comments for ProductReleasePolicy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PolicyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PolicyName")]
    [global::Microsoft.OData.Client.EntitySet("ProductReleasePolicies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductReleasePolicy")]
    public partial class ProductReleasePolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductReleasePolicy object.
        /// </summary>
        /// <param name="policyName">Initial value of PolicyName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductReleasePolicy CreateProductReleasePolicy(string policyName)
        {
            ProductReleasePolicy productReleasePolicy = new ProductReleasePolicy();
            productReleasePolicy.PolicyName = policyName;
            return productReleasePolicy;
        }
        /// <summary>
        /// There are no comments for Property PolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PolicyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PolicyName is required.")]
        public virtual string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this.OnPolicyNameChanging(value);
                this._PolicyName = value;
                this.OnPolicyNameChanged();
                this.OnPropertyChanged("PolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyName;
        partial void OnPolicyNameChanging(string value);
        partial void OnPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property ApplicableProductType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApplicableProductType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductType> ApplicableProductType
        {
            get
            {
                return this._ApplicableProductType;
            }
            set
            {
                this.OnApplicableProductTypeChanging(value);
                this._ApplicableProductType = value;
                this.OnApplicableProductTypeChanged();
                this.OnPropertyChanged("ApplicableProductType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductType> _ApplicableProductType;
        partial void OnApplicableProductTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EcoResProductType> value);
        partial void OnApplicableProductTypeChanged();
        /// <summary>
        /// There are no comments for Property PmfProductType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PmfProductType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PmfProductType> PmfProductType
        {
            get
            {
                return this._PmfProductType;
            }
            set
            {
                this.OnPmfProductTypeChanging(value);
                this._PmfProductType = value;
                this.OnPmfProductTypeChanged();
                this.OnPropertyChanged("PmfProductType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PmfProductType> _PmfProductType;
        partial void OnPmfProductTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PmfProductType> value);
        partial void OnPmfProductTypeChanged();
        /// <summary>
        /// There are no comments for Property IsPolicyActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPolicyActive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPolicyActive
        {
            get
            {
                return this._IsPolicyActive;
            }
            set
            {
                this.OnIsPolicyActiveChanging(value);
                this._IsPolicyActive = value;
                this.OnIsPolicyActiveChanged();
                this.OnPropertyChanged("IsPolicyActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPolicyActive;
        partial void OnIsPolicyActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPolicyActiveChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseEnforceDateRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillProductReleaseEnforceDateRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseEnforceDateRule
        {
            get
            {
                return this._WillProductReleaseEnforceDateRule;
            }
            set
            {
                this.OnWillProductReleaseEnforceDateRuleChanging(value);
                this._WillProductReleaseEnforceDateRule = value;
                this.OnWillProductReleaseEnforceDateRuleChanged();
                this.OnPropertyChanged("WillProductReleaseEnforceDateRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseEnforceDateRule;
        partial void OnWillProductReleaseEnforceDateRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseEnforceDateRuleChanged();
        /// <summary>
        /// There are no comments for Property ApplyTemplatesRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApplyTemplatesRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseApplyTemplateMode> ApplyTemplatesRule
        {
            get
            {
                return this._ApplyTemplatesRule;
            }
            set
            {
                this.OnApplyTemplatesRuleChanging(value);
                this._ApplyTemplatesRule = value;
                this.OnApplyTemplatesRuleChanged();
                this.OnPropertyChanged("ApplyTemplatesRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseApplyTemplateMode> _ApplyTemplatesRule;
        partial void OnApplyTemplatesRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseApplyTemplateMode> value);
        partial void OnApplyTemplatesRuleChanged();
        /// <summary>
        /// There are no comments for Property PolicyDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PolicyDescription")]
        public virtual string PolicyDescription
        {
            get
            {
                return this._PolicyDescription;
            }
            set
            {
                this.OnPolicyDescriptionChanging(value);
                this._PolicyDescription = value;
                this.OnPolicyDescriptionChanged();
                this.OnPropertyChanged("PolicyDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyDescription;
        partial void OnPolicyDescriptionChanging(string value);
        partial void OnPolicyDescriptionChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringProductCategoryDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                return this._EngineeringProductCategoryDetails;
            }
            set
            {
                this.OnEngineeringProductCategoryDetailsChanging(value);
                this._EngineeringProductCategoryDetails = value;
                this.OnEngineeringProductCategoryDetailsChanged();
                this.OnPropertyChanged("EngineeringProductCategoryDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringProductCategoryDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> value);
        partial void OnEngineeringProductCategoryDetailsChanged();
        /// <summary>
        /// There are no comments for Property ProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> ProductsV2
        {
            get
            {
                return this._ProductsV2;
            }
            set
            {
                this.OnProductsV2Changing(value);
                this._ProductsV2 = value;
                this.OnProductsV2Changed();
                this.OnPropertyChanged("ProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> _ProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductV2> value);
        partial void OnProductsV2Changed();
        /// <summary>
        /// There are no comments for Property ProductReleasePolicyLegalEntityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductReleasePolicyLegalEntityRules")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule> ProductReleasePolicyLegalEntityRules
        {
            get
            {
                return this._ProductReleasePolicyLegalEntityRules;
            }
            set
            {
                this.OnProductReleasePolicyLegalEntityRulesChanging(value);
                this._ProductReleasePolicyLegalEntityRules = value;
                this.OnProductReleasePolicyLegalEntityRulesChanged();
                this.OnPropertyChanged("ProductReleasePolicyLegalEntityRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule> _ProductReleasePolicyLegalEntityRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductReleasePolicyLegalEntityRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleasePolicyLegalEntityRule> value);
        partial void OnProductReleasePolicyLegalEntityRulesChanged();
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
