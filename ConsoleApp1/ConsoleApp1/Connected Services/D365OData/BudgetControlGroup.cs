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
    /// There are no comments for BudgetControlGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroupSingle")]
    public partial class BudgetControlGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroup>
    {
        /// <summary>
        /// Initialize a new BudgetControlGroupSingle object.
        /// </summary>
        public BudgetControlGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupSingle object.
        /// </summary>
        public BudgetControlGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupSingle object.
        /// </summary>
        public BudgetControlGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlGroupCriterionGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroupCriterionGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion> BudgetControlGroupCriterionGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlGroupCriterionGroup == null))
                {
                    this._BudgetControlGroupCriterionGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion>(GetPath("BudgetControlGroupCriterionGroup"));
                }
                return this._BudgetControlGroupCriterionGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion> _BudgetControlGroupCriterionGroup;
        /// <summary>
        /// There are no comments for BudgetControlGroupOverBudgetPermissionsBudgetControlGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroupOverBudgetPermissionsBudgetControlGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> BudgetControlGroupOverBudgetPermissionsBudgetControlGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlGroupOverBudgetPermissionsBudgetControlGroup == null))
                {
                    this._BudgetControlGroupOverBudgetPermissionsBudgetControlGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission>(GetPath("BudgetControlGroupOverBudgetPermissionsBudgetControlGroup"));
                }
                return this._BudgetControlGroupOverBudgetPermissionsBudgetControlGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> _BudgetControlGroupOverBudgetPermissionsBudgetControlGroup;
        /// <summary>
        /// There are no comments for BudgetManagers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetManagers")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUserSingle BudgetManagers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetManagers == null))
                {
                    this._BudgetManagers = new global::Microsoft.Dynamics.DataEntities.SystemUserSingle(this.Context, GetPath("BudgetManagers"));
                }
                return this._BudgetManagers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUserSingle _BudgetManagers;
        /// <summary>
        /// There are no comments for BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlConfigurations")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle BudgetControlConfigurations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlConfigurations == null))
                {
                    this._BudgetControlConfigurations = new global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle(this.Context, GetPath("BudgetControlConfigurations"));
                }
                return this._BudgetControlConfigurations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle _BudgetControlConfigurations;
        /// <summary>
        /// There are no comments for BudgetCycleTimeSpans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCycleTimeSpans")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle BudgetCycleTimeSpans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetCycleTimeSpans == null))
                {
                    this._BudgetCycleTimeSpans = new global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle(this.Context, GetPath("BudgetCycleTimeSpans"));
                }
                return this._BudgetCycleTimeSpans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle _BudgetCycleTimeSpans;
    }
    /// <summary>
    /// There are no comments for BudgetControlGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LegalEntityId
    /// Status
    /// MemberName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "MemberName")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroup")]
    public partial class BudgetControlGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="memberName">Initial value of MemberName.</param>
        /// <param name="budgetThresholdPercent">Initial value of BudgetThresholdPercent.</param>
        /// <param name="budgetControlConfigurations">Initial value of BudgetControlConfigurations.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlGroup CreateBudgetControlGroup(string dataAreaId, string legalEntityId, string memberName, decimal budgetThresholdPercent, global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration budgetControlConfigurations)
        {
            BudgetControlGroup budgetControlGroup = new BudgetControlGroup();
            budgetControlGroup.DataAreaId = dataAreaId;
            budgetControlGroup.LegalEntityId = legalEntityId;
            budgetControlGroup.MemberName = memberName;
            budgetControlGroup.BudgetThresholdPercent = budgetThresholdPercent;
            if ((budgetControlConfigurations == null))
            {
                throw new global::System.ArgumentNullException("budgetControlConfigurations");
            }
            budgetControlGroup.BudgetControlConfigurations = budgetControlConfigurations;
            return budgetControlGroup;
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property MemberName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MemberName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MemberName is required.")]
        public virtual string MemberName
        {
            get
            {
                return this._MemberName;
            }
            set
            {
                this.OnMemberNameChanging(value);
                this._MemberName = value;
                this.OnMemberNameChanged();
                this.OnPropertyChanged("MemberName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MemberName;
        partial void OnMemberNameChanging(string value);
        partial void OnMemberNameChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlInterval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlInterval")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> BudgetControlInterval
        {
            get
            {
                return this._BudgetControlInterval;
            }
            set
            {
                this.OnBudgetControlIntervalChanging(value);
                this._BudgetControlInterval = value;
                this.OnBudgetControlIntervalChanged();
                this.OnPropertyChanged("BudgetControlInterval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> _BudgetControlInterval;
        partial void OnBudgetControlIntervalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> value);
        partial void OnBudgetControlIntervalChanged();
        /// <summary>
        /// There are no comments for Property BudgetManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetManager")]
        public virtual string BudgetManager
        {
            get
            {
                return this._BudgetManager;
            }
            set
            {
                this.OnBudgetManagerChanging(value);
                this._BudgetManager = value;
                this.OnBudgetManagerChanged();
                this.OnPropertyChanged("BudgetManager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetManager;
        partial void OnBudgetManagerChanging(string value);
        partial void OnBudgetManagerChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpanName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCycleTimeSpanName")]
        public virtual string BudgetCycleTimeSpanName
        {
            get
            {
                return this._BudgetCycleTimeSpanName;
            }
            set
            {
                this.OnBudgetCycleTimeSpanNameChanging(value);
                this._BudgetCycleTimeSpanName = value;
                this.OnBudgetCycleTimeSpanNameChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpanName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpanName;
        partial void OnBudgetCycleTimeSpanNameChanging(string value);
        partial void OnBudgetCycleTimeSpanNameChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpanFiscalCalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCycleTimeSpanFiscalCalendarId")]
        public virtual string BudgetCycleTimeSpanFiscalCalendarId
        {
            get
            {
                return this._BudgetCycleTimeSpanFiscalCalendarId;
            }
            set
            {
                this.OnBudgetCycleTimeSpanFiscalCalendarIdChanging(value);
                this._BudgetCycleTimeSpanFiscalCalendarId = value;
                this.OnBudgetCycleTimeSpanFiscalCalendarIdChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpanFiscalCalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpanFiscalCalendarId;
        partial void OnBudgetCycleTimeSpanFiscalCalendarIdChanging(string value);
        partial void OnBudgetCycleTimeSpanFiscalCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property BudgetThresholdPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetThresholdPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetThresholdPercent is required.")]
        public virtual decimal BudgetThresholdPercent
        {
            get
            {
                return this._BudgetThresholdPercent;
            }
            set
            {
                this.OnBudgetThresholdPercentChanging(value);
                this._BudgetThresholdPercent = value;
                this.OnBudgetThresholdPercentChanged();
                this.OnPropertyChanged("BudgetThresholdPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BudgetThresholdPercent;
        partial void OnBudgetThresholdPercentChanging(decimal value);
        partial void OnBudgetThresholdPercentChanged();
        /// <summary>
        /// There are no comments for Property MemberDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MemberDescription")]
        public virtual string MemberDescription
        {
            get
            {
                return this._MemberDescription;
            }
            set
            {
                this.OnMemberDescriptionChanging(value);
                this._MemberDescription = value;
                this.OnMemberDescriptionChanged();
                this.OnPropertyChanged("MemberDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MemberDescription;
        partial void OnMemberDescriptionChanging(string value);
        partial void OnMemberDescriptionChanged();
        /// <summary>
        /// There are no comments for Property InUseBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InUseBy")]
        public virtual string InUseBy
        {
            get
            {
                return this._InUseBy;
            }
            set
            {
                this.OnInUseByChanging(value);
                this._InUseBy = value;
                this.OnInUseByChanged();
                this.OnPropertyChanged("InUseBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InUseBy;
        partial void OnInUseByChanging(string value);
        partial void OnInUseByChanged();
        /// <summary>
        /// There are no comments for Property ParentMemberName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentMemberName")]
        public virtual string ParentMemberName
        {
            get
            {
                return this._ParentMemberName;
            }
            set
            {
                this.OnParentMemberNameChanging(value);
                this._ParentMemberName = value;
                this.OnParentMemberNameChanged();
                this.OnPropertyChanged("ParentMemberName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentMemberName;
        partial void OnParentMemberNameChanging(string value);
        partial void OnParentMemberNameChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlGroupCriterionGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroupCriterionGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion> BudgetControlGroupCriterionGroup
        {
            get
            {
                return this._BudgetControlGroupCriterionGroup;
            }
            set
            {
                this.OnBudgetControlGroupCriterionGroupChanging(value);
                this._BudgetControlGroupCriterionGroup = value;
                this.OnBudgetControlGroupCriterionGroupChanged();
                this.OnPropertyChanged("BudgetControlGroupCriterionGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion> _BudgetControlGroupCriterionGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlGroupCriterionGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupCriterion> value);
        partial void OnBudgetControlGroupCriterionGroupChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlGroupOverBudgetPermissionsBudgetControlGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlGroupOverBudgetPermissionsBudgetControlGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> BudgetControlGroupOverBudgetPermissionsBudgetControlGroup
        {
            get
            {
                return this._BudgetControlGroupOverBudgetPermissionsBudgetControlGroup;
            }
            set
            {
                this.OnBudgetControlGroupOverBudgetPermissionsBudgetControlGroupChanging(value);
                this._BudgetControlGroupOverBudgetPermissionsBudgetControlGroup = value;
                this.OnBudgetControlGroupOverBudgetPermissionsBudgetControlGroupChanged();
                this.OnPropertyChanged("BudgetControlGroupOverBudgetPermissionsBudgetControlGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> _BudgetControlGroupOverBudgetPermissionsBudgetControlGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlGroupOverBudgetPermissionsBudgetControlGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlGroupOverBudgetPermission> value);
        partial void OnBudgetControlGroupOverBudgetPermissionsBudgetControlGroupChanged();
        /// <summary>
        /// There are no comments for Property BudgetManagers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetManagers")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUser BudgetManagers
        {
            get
            {
                return this._BudgetManagers;
            }
            set
            {
                this.OnBudgetManagersChanging(value);
                this._BudgetManagers = value;
                this.OnBudgetManagersChanged();
                this.OnPropertyChanged("BudgetManagers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUser _BudgetManagers;
        partial void OnBudgetManagersChanging(global::Microsoft.Dynamics.DataEntities.SystemUser value);
        partial void OnBudgetManagersChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlConfigurations")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetControlConfigurations is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration BudgetControlConfigurations
        {
            get
            {
                return this._BudgetControlConfigurations;
            }
            set
            {
                this.OnBudgetControlConfigurationsChanging(value);
                this._BudgetControlConfigurations = value;
                this.OnBudgetControlConfigurationsChanged();
                this.OnPropertyChanged("BudgetControlConfigurations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration _BudgetControlConfigurations;
        partial void OnBudgetControlConfigurationsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration value);
        partial void OnBudgetControlConfigurationsChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCycleTimeSpans")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan BudgetCycleTimeSpans
        {
            get
            {
                return this._BudgetCycleTimeSpans;
            }
            set
            {
                this.OnBudgetCycleTimeSpansChanging(value);
                this._BudgetCycleTimeSpans = value;
                this.OnBudgetCycleTimeSpansChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan _BudgetCycleTimeSpans;
        partial void OnBudgetCycleTimeSpansChanging(global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan value);
        partial void OnBudgetCycleTimeSpansChanged();
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
