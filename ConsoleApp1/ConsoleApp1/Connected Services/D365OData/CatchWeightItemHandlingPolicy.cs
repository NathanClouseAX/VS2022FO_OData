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
    /// There are no comments for CatchWeightItemHandlingPolicySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CatchWeightItemHandlingPolicySingle")]
    public partial class CatchWeightItemHandlingPolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CatchWeightItemHandlingPolicy>
    {
        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicySingle object.
        /// </summary>
        public CatchWeightItemHandlingPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicySingle object.
        /// </summary>
        public CatchWeightItemHandlingPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CatchWeightItemHandlingPolicySingle object.
        /// </summary>
        public CatchWeightItemHandlingPolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CatchWeightItemHandlingPolicy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
    /// <summary>
    /// There are no comments for CatchWeightItemHandlingPolicy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PolicyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PolicyName")]
    [global::Microsoft.OData.Client.EntitySet("CatchWeightItemHandlingPolicies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CatchWeightItemHandlingPolicy")]
    public partial class CatchWeightItemHandlingPolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CatchWeightItemHandlingPolicy object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="policyName">Initial value of PolicyName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CatchWeightItemHandlingPolicy CreateCatchWeightItemHandlingPolicy(string dataAreaId, string policyName)
        {
            CatchWeightItemHandlingPolicy catchWeightItemHandlingPolicy = new CatchWeightItemHandlingPolicy();
            catchWeightItemHandlingPolicy.DataAreaId = dataAreaId;
            catchWeightItemHandlingPolicy.PolicyName = policyName;
            return catchWeightItemHandlingPolicy;
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
        /// There are no comments for Property OutboundWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OutboundWeightCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> OutboundWeightCapturingMethod
        {
            get
            {
                return this._OutboundWeightCapturingMethod;
            }
            set
            {
                this.OnOutboundWeightCapturingMethodChanging(value);
                this._OutboundWeightCapturingMethod = value;
                this.OnOutboundWeightCapturingMethodChanged();
                this.OnPropertyChanged("OutboundWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> _OutboundWeightCapturingMethod;
        partial void OnOutboundWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightCapturingMethod> value);
        partial void OnOutboundWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property InboundCatchWeightTagCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InboundCatchWeightTagCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> InboundCatchWeightTagCapturingMethod
        {
            get
            {
                return this._InboundCatchWeightTagCapturingMethod;
            }
            set
            {
                this.OnInboundCatchWeightTagCapturingMethodChanging(value);
                this._InboundCatchWeightTagCapturingMethod = value;
                this.OnInboundCatchWeightTagCapturingMethodChanged();
                this.OnPropertyChanged("InboundCatchWeightTagCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> _InboundCatchWeightTagCapturingMethod;
        partial void OnInboundCatchWeightTagCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundCatchWeightTagCapturingMethod> value);
        partial void OnInboundCatchWeightTagCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property OutboundWeightVarianceMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OutboundWeightVarianceMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> OutboundWeightVarianceMethod
        {
            get
            {
                return this._OutboundWeightVarianceMethod;
            }
            set
            {
                this.OnOutboundWeightVarianceMethodChanging(value);
                this._OutboundWeightVarianceMethod = value;
                this.OnOutboundWeightVarianceMethodChanged();
                this.OnPropertyChanged("OutboundWeightVarianceMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> _OutboundWeightVarianceMethod;
        partial void OnOutboundWeightVarianceMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSOutboundWeightVarianceMethod> value);
        partial void OnOutboundWeightVarianceMethodChanged();
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
        /// There are no comments for Property SalesOrderWeightCapturingProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderWeightCapturingProcess")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> SalesOrderWeightCapturingProcess
        {
            get
            {
                return this._SalesOrderWeightCapturingProcess;
            }
            set
            {
                this.OnSalesOrderWeightCapturingProcessChanging(value);
                this._SalesOrderWeightCapturingProcess = value;
                this.OnSalesOrderWeightCapturingProcessChanged();
                this.OnPropertyChanged("SalesOrderWeightCapturingProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> _SalesOrderWeightCapturingProcess;
        partial void OnSalesOrderWeightCapturingProcessChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSSalesOrderWeightCapturingProcess> value);
        partial void OnSalesOrderWeightCapturingProcessChanged();
        /// <summary>
        /// There are no comments for Property InboundWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InboundWeightCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> InboundWeightCapturingMethod
        {
            get
            {
                return this._InboundWeightCapturingMethod;
            }
            set
            {
                this.OnInboundWeightCapturingMethodChanging(value);
                this._InboundWeightCapturingMethod = value;
                this.OnInboundWeightCapturingMethodChanged();
                this.OnPropertyChanged("InboundWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> _InboundWeightCapturingMethod;
        partial void OnInboundWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSInboundWeightCapturingMethod> value);
        partial void OnInboundWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property MovementWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MovementWeightCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> MovementWeightCapturingMethod
        {
            get
            {
                return this._MovementWeightCapturingMethod;
            }
            set
            {
                this.OnMovementWeightCapturingMethodChanging(value);
                this._MovementWeightCapturingMethod = value;
                this.OnMovementWeightCapturingMethodChanged();
                this.OnPropertyChanged("MovementWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> _MovementWeightCapturingMethod;
        partial void OnMovementWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSMovementWeightCapturingMethod> value);
        partial void OnMovementWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property CountingWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountingWeightCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> CountingWeightCapturingMethod
        {
            get
            {
                return this._CountingWeightCapturingMethod;
            }
            set
            {
                this.OnCountingWeightCapturingMethodChanging(value);
                this._CountingWeightCapturingMethod = value;
                this.OnCountingWeightCapturingMethodChanged();
                this.OnPropertyChanged("CountingWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> _CountingWeightCapturingMethod;
        partial void OnCountingWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSCountingWeightCapturingMethod> value);
        partial void OnCountingWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property TransferIssueWeightCapturingProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransferIssueWeightCapturingProcess")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> TransferIssueWeightCapturingProcess
        {
            get
            {
                return this._TransferIssueWeightCapturingProcess;
            }
            set
            {
                this.OnTransferIssueWeightCapturingProcessChanging(value);
                this._TransferIssueWeightCapturingProcess = value;
                this.OnTransferIssueWeightCapturingProcessChanged();
                this.OnPropertyChanged("TransferIssueWeightCapturingProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> _TransferIssueWeightCapturingProcess;
        partial void OnTransferIssueWeightCapturingProcessChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSTransferIssueWeightCapturingProcess> value);
        partial void OnTransferIssueWeightCapturingProcessChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightTagTracking in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatchWeightTagTracking")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CatchWeightTagTracking
        {
            get
            {
                return this._CatchWeightTagTracking;
            }
            set
            {
                this.OnCatchWeightTagTrackingChanging(value);
                this._CatchWeightTagTracking = value;
                this.OnCatchWeightTagTrackingChanged();
                this.OnPropertyChanged("CatchWeightTagTracking");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CatchWeightTagTracking;
        partial void OnCatchWeightTagTrackingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCatchWeightTagTrackingChanged();
        /// <summary>
        /// There are no comments for Property ProductionPickingWeightCapturingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionPickingWeightCapturingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> ProductionPickingWeightCapturingMethod
        {
            get
            {
                return this._ProductionPickingWeightCapturingMethod;
            }
            set
            {
                this.OnProductionPickingWeightCapturingMethodChanging(value);
                this._ProductionPickingWeightCapturingMethod = value;
                this.OnProductionPickingWeightCapturingMethodChanged();
                this.OnPropertyChanged("ProductionPickingWeightCapturingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> _ProductionPickingWeightCapturingMethod;
        partial void OnProductionPickingWeightCapturingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSProductionPickingWeightCapturingMethod> value);
        partial void OnProductionPickingWeightCapturingMethodChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
