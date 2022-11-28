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
    /// There are no comments for UnionsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UnionsSingle")]
    public partial class UnionsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Unions>
    {
        /// <summary>
        /// Initialize a new UnionsSingle object.
        /// </summary>
        public UnionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UnionsSingle object.
        /// </summary>
        public UnionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UnionsSingle object.
        /// </summary>
        public UnionsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Unions> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationEligibilityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationEligibilityRules")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> CompensationEligibilityRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationEligibilityRules == null))
                {
                    this._CompensationEligibilityRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule>(GetPath("CompensationEligibilityRules"));
                }
                return this._CompensationEligibilityRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> _CompensationEligibilityRules;
        /// <summary>
        /// There are no comments for CompensationFixedIncreaseBudgets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationFixedIncreaseBudgets")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget> CompensationFixedIncreaseBudgets
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationFixedIncreaseBudgets == null))
                {
                    this._CompensationFixedIncreaseBudgets = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget>(GetPath("CompensationFixedIncreaseBudgets"));
                }
                return this._CompensationFixedIncreaseBudgets;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget> _CompensationFixedIncreaseBudgets;
        /// <summary>
        /// There are no comments for LaborUnionAgreements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborUnionAgreements")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement> LaborUnionAgreements
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LaborUnionAgreements == null))
                {
                    this._LaborUnionAgreements = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement>(GetPath("LaborUnionAgreements"));
                }
                return this._LaborUnionAgreements;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement> _LaborUnionAgreements;
        /// <summary>
        /// There are no comments for PersonLaborUnions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonLaborUnions")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion> PersonLaborUnions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonLaborUnions == null))
                {
                    this._PersonLaborUnions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion>(GetPath("PersonLaborUnions"));
                }
                return this._PersonLaborUnions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion> _PersonLaborUnions;
    }
    /// <summary>
    /// There are no comments for Unions in the schema.
    /// </summary>
    /// <KeyProperties>
    /// UnionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("UnionId")]
    [global::Microsoft.OData.Client.EntitySet("Unions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Unions")]
    public partial class Unions : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Unions object.
        /// </summary>
        /// <param name="unionId">Initial value of UnionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Unions CreateUnions(string unionId)
        {
            Unions unions = new Unions();
            unions.UnionId = unionId;
            return unions;
        }
        /// <summary>
        /// There are no comments for Property UnionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnionId is required.")]
        public virtual string UnionId
        {
            get
            {
                return this._UnionId;
            }
            set
            {
                this.OnUnionIdChanging(value);
                this._UnionId = value;
                this.OnUnionIdChanged();
                this.OnPropertyChanged("UnionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnionId;
        partial void OnUnionIdChanging(string value);
        partial void OnUnionIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property EntitledToNegotiate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntitledToNegotiate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EntitledToNegotiate
        {
            get
            {
                return this._EntitledToNegotiate;
            }
            set
            {
                this.OnEntitledToNegotiateChanging(value);
                this._EntitledToNegotiate = value;
                this.OnEntitledToNegotiateChanged();
                this.OnPropertyChanged("EntitledToNegotiate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EntitledToNegotiate;
        partial void OnEntitledToNegotiateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEntitledToNegotiateChanged();
        /// <summary>
        /// There are no comments for Property CompensationEligibilityRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationEligibilityRules")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> CompensationEligibilityRules
        {
            get
            {
                return this._CompensationEligibilityRules;
            }
            set
            {
                this.OnCompensationEligibilityRulesChanging(value);
                this._CompensationEligibilityRules = value;
                this.OnCompensationEligibilityRulesChanged();
                this.OnPropertyChanged("CompensationEligibilityRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> _CompensationEligibilityRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationEligibilityRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationEligibilityRule> value);
        partial void OnCompensationEligibilityRulesChanged();
        /// <summary>
        /// There are no comments for Property CompensationFixedIncreaseBudgets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationFixedIncreaseBudgets")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget> CompensationFixedIncreaseBudgets
        {
            get
            {
                return this._CompensationFixedIncreaseBudgets;
            }
            set
            {
                this.OnCompensationFixedIncreaseBudgetsChanging(value);
                this._CompensationFixedIncreaseBudgets = value;
                this.OnCompensationFixedIncreaseBudgetsChanged();
                this.OnPropertyChanged("CompensationFixedIncreaseBudgets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget> _CompensationFixedIncreaseBudgets = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationFixedIncreaseBudgetsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationFixedIncreaseBudget> value);
        partial void OnCompensationFixedIncreaseBudgetsChanged();
        /// <summary>
        /// There are no comments for Property LaborUnionAgreements in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborUnionAgreements")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement> LaborUnionAgreements
        {
            get
            {
                return this._LaborUnionAgreements;
            }
            set
            {
                this.OnLaborUnionAgreementsChanging(value);
                this._LaborUnionAgreements = value;
                this.OnLaborUnionAgreementsChanged();
                this.OnPropertyChanged("LaborUnionAgreements");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement> _LaborUnionAgreements = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLaborUnionAgreementsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement> value);
        partial void OnLaborUnionAgreementsChanged();
        /// <summary>
        /// There are no comments for Property PersonLaborUnions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonLaborUnions")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion> PersonLaborUnions
        {
            get
            {
                return this._PersonLaborUnions;
            }
            set
            {
                this.OnPersonLaborUnionsChanging(value);
                this._PersonLaborUnions = value;
                this.OnPersonLaborUnionsChanged();
                this.OnPropertyChanged("PersonLaborUnions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion> _PersonLaborUnions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonLaborUnionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonLaborUnion> value);
        partial void OnPersonLaborUnionsChanged();
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