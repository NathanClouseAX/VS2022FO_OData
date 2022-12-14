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
    /// There are no comments for CustomerRebateReductionPrincipleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateReductionPrincipleSingle")]
    public partial class CustomerRebateReductionPrincipleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRebateReductionPrinciple>
    {
        /// <summary>
        /// Initialize a new CustomerRebateReductionPrincipleSingle object.
        /// </summary>
        public CustomerRebateReductionPrincipleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerRebateReductionPrincipleSingle object.
        /// </summary>
        public CustomerRebateReductionPrincipleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerRebateReductionPrincipleSingle object.
        /// </summary>
        public CustomerRebateReductionPrincipleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRebateReductionPrinciple> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsAgreementHeaders == null))
                {
                    this._RebateAndDeductionsAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(GetPath("RebateAndDeductionsAgreementHeaders"));
                }
                return this._RebateAndDeductionsAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders;
    }
    /// <summary>
    /// There are no comments for CustomerRebateReductionPrinciple in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PrincipleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PrincipleId")]
    [global::Microsoft.OData.Client.EntitySet("CustomerRebateReductionPrinciples")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateReductionPrinciple")]
    public partial class CustomerRebateReductionPrinciple : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerRebateReductionPrinciple object.
        /// </summary>
        /// <param name="principleId">Initial value of PrincipleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerRebateReductionPrinciple CreateCustomerRebateReductionPrinciple(string principleId)
        {
            CustomerRebateReductionPrinciple customerRebateReductionPrinciple = new CustomerRebateReductionPrinciple();
            customerRebateReductionPrinciple.PrincipleId = principleId;
            return customerRebateReductionPrinciple;
        }
        /// <summary>
        /// There are no comments for Property PrincipleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrincipleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PrincipleId is required.")]
        public virtual string PrincipleId
        {
            get
            {
                return this._PrincipleId;
            }
            set
            {
                this.OnPrincipleIdChanging(value);
                this._PrincipleId = value;
                this.OnPrincipleIdChanged();
                this.OnPropertyChanged("PrincipleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrincipleId;
        partial void OnPrincipleIdChanging(string value);
        partial void OnPrincipleIdChanged();
        /// <summary>
        /// There are no comments for Property PrincipleDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrincipleDescription")]
        public virtual string PrincipleDescription
        {
            get
            {
                return this._PrincipleDescription;
            }
            set
            {
                this.OnPrincipleDescriptionChanging(value);
                this._PrincipleDescription = value;
                this.OnPrincipleDescriptionChanged();
                this.OnPropertyChanged("PrincipleDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrincipleDescription;
        partial void OnPrincipleDescriptionChanging(string value);
        partial void OnPrincipleDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsReductionExcludingRebate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsReductionExcludingRebate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsReductionExcludingRebate
        {
            get
            {
                return this._IsReductionExcludingRebate;
            }
            set
            {
                this.OnIsReductionExcludingRebateChanging(value);
                this._IsReductionExcludingRebate = value;
                this.OnIsReductionExcludingRebateChanged();
                this.OnPropertyChanged("IsReductionExcludingRebate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsReductionExcludingRebate;
        partial void OnIsReductionExcludingRebateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReductionExcludingRebateChanged();
        /// <summary>
        /// There are no comments for Property RebateCalculationReductionBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateCalculationReductionBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReductionBasis> RebateCalculationReductionBasis
        {
            get
            {
                return this._RebateCalculationReductionBasis;
            }
            set
            {
                this.OnRebateCalculationReductionBasisChanging(value);
                this._RebateCalculationReductionBasis = value;
                this.OnRebateCalculationReductionBasisChanged();
                this.OnPropertyChanged("RebateCalculationReductionBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReductionBasis> _RebateCalculationReductionBasis;
        partial void OnRebateCalculationReductionBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateReductionBasis> value);
        partial void OnRebateCalculationReductionBasisChanged();
        /// <summary>
        /// There are no comments for Property IsReductionApplyingRebate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsReductionApplyingRebate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsReductionApplyingRebate
        {
            get
            {
                return this._IsReductionApplyingRebate;
            }
            set
            {
                this.OnIsReductionApplyingRebateChanging(value);
                this._IsReductionApplyingRebate = value;
                this.OnIsReductionApplyingRebateChanged();
                this.OnPropertyChanged("IsReductionApplyingRebate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsReductionApplyingRebate;
        partial void OnIsReductionApplyingRebateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReductionApplyingRebateChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                return this._RebateAndDeductionsAgreementHeaders;
            }
            set
            {
                this.OnRebateAndDeductionsAgreementHeadersChanging(value);
                this._RebateAndDeductionsAgreementHeaders = value;
                this.OnRebateAndDeductionsAgreementHeadersChanged();
                this.OnPropertyChanged("RebateAndDeductionsAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateAndDeductionsAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> value);
        partial void OnRebateAndDeductionsAgreementHeadersChanged();
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
