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
    /// There are no comments for BenefitsEligibilityRuleOverrideSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRuleOverrideSingle")]
    public partial class BenefitsEligibilityRuleOverrideSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsEligibilityRuleOverride>
    {
        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleOverrideSingle object.
        /// </summary>
        public BenefitsEligibilityRuleOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleOverrideSingle object.
        /// </summary>
        public BenefitsEligibilityRuleOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsEligibilityRuleOverrideSingle object.
        /// </summary>
        public BenefitsEligibilityRuleOverrideSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsEligibilityRuleOverride> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BenefitsEligibilityRuleOverride in the schema.
    /// </summary>
    /// <KeyProperties>
    /// WorkerPersonnelNumber
    /// RelationshipType
    /// PlanOrProgramId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("WorkerPersonnelNumber", "RelationshipType", "PlanOrProgramId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsEligibilityRuleOverrides")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEligibilityRuleOverride")]
    public partial class BenefitsEligibilityRuleOverride : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsEligibilityRuleOverride object.
        /// </summary>
        /// <param name="workerPersonnelNumber">Initial value of WorkerPersonnelNumber.</param>
        /// <param name="planOrProgramId">Initial value of PlanOrProgramId.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsEligibilityRuleOverride CreateBenefitsEligibilityRuleOverride(string workerPersonnelNumber, string planOrProgramId, global::System.DateTimeOffset validTo, global::System.DateTimeOffset validFrom)
        {
            BenefitsEligibilityRuleOverride benefitsEligibilityRuleOverride = new BenefitsEligibilityRuleOverride();
            benefitsEligibilityRuleOverride.WorkerPersonnelNumber = workerPersonnelNumber;
            benefitsEligibilityRuleOverride.PlanOrProgramId = planOrProgramId;
            benefitsEligibilityRuleOverride.ValidTo = validTo;
            benefitsEligibilityRuleOverride.ValidFrom = validFrom;
            return benefitsEligibilityRuleOverride;
        }
        /// <summary>
        /// There are no comments for Property WorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerPersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerPersonnelNumber is required.")]
        public virtual string WorkerPersonnelNumber
        {
            get
            {
                return this._WorkerPersonnelNumber;
            }
            set
            {
                this.OnWorkerPersonnelNumberChanging(value);
                this._WorkerPersonnelNumber = value;
                this.OnWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("WorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkerPersonnelNumber;
        partial void OnWorkerPersonnelNumberChanging(string value);
        partial void OnWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitProgramPlanRelation> RelationshipType
        {
            get
            {
                return this._RelationshipType;
            }
            set
            {
                this.OnRelationshipTypeChanging(value);
                this._RelationshipType = value;
                this.OnRelationshipTypeChanged();
                this.OnPropertyChanged("RelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitProgramPlanRelation> _RelationshipType;
        partial void OnRelationshipTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitProgramPlanRelation> value);
        partial void OnRelationshipTypeChanged();
        /// <summary>
        /// There are no comments for Property PlanOrProgramId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanOrProgramId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanOrProgramId is required.")]
        public virtual string PlanOrProgramId
        {
            get
            {
                return this._PlanOrProgramId;
            }
            set
            {
                this.OnPlanOrProgramIdChanging(value);
                this._PlanOrProgramId = value;
                this.OnPlanOrProgramIdChanged();
                this.OnPropertyChanged("PlanOrProgramId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanOrProgramId;
        partial void OnPlanOrProgramIdChanging(string value);
        partial void OnPlanOrProgramIdChanged();
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