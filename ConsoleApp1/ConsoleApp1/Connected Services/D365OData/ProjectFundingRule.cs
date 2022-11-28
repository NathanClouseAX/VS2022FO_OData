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
    /// There are no comments for ProjectFundingRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectFundingRuleSingle")]
    public partial class ProjectFundingRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectFundingRule>
    {
        /// <summary>
        /// Initialize a new ProjectFundingRuleSingle object.
        /// </summary>
        public ProjectFundingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectFundingRuleSingle object.
        /// </summary>
        public ProjectFundingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectFundingRuleSingle object.
        /// </summary>
        public ProjectFundingRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectFundingRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjectContract in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContract")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectContractSingle ProjectContract
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectContract == null))
                {
                    this._ProjectContract = new global::Microsoft.Dynamics.DataEntities.ProjectContractSingle(this.Context, GetPath("ProjectContract"));
                }
                return this._ProjectContract;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectContractSingle _ProjectContract;
    }
    /// <summary>
    /// There are no comments for ProjectFundingRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjectContractId
    /// Priority
    /// ProjectId
    /// ActivityNumber
    /// TransactionType
    /// CategoryId
    /// CategoryGroupId
    /// ItemId
    /// EndDate
    /// StartDate
    /// ResourceId
    /// FundingSourceId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjectContractId", "Priority", "ProjectId", "ActivityNumber", "TransactionType", "CategoryId", "CategoryGroupId", "ItemId", "EndDate", "StartDate", "ResourceId", "FundingSourceId")]
    [global::Microsoft.OData.Client.EntitySet("ProjectFundingRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectFundingRule")]
    public partial class ProjectFundingRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectFundingRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projectContractId">Initial value of ProjectContractId.</param>
        /// <param name="priority">Initial value of Priority.</param>
        /// <param name="projectId">Initial value of ProjectId.</param>
        /// <param name="activityNumber">Initial value of ActivityNumber.</param>
        /// <param name="categoryId">Initial value of CategoryId.</param>
        /// <param name="categoryGroupId">Initial value of CategoryGroupId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="resourceId">Initial value of ResourceId.</param>
        /// <param name="fundingSourceId">Initial value of FundingSourceId.</param>
        /// <param name="allocationPercentage">Initial value of AllocationPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectFundingRule CreateProjectFundingRule(string dataAreaId, 
                    string projectContractId, 
                    int priority, 
                    string projectId, 
                    string activityNumber, 
                    string categoryId, 
                    string categoryGroupId, 
                    string itemId, 
                    global::System.DateTimeOffset endDate, 
                    global::System.DateTimeOffset startDate, 
                    string resourceId, 
                    string fundingSourceId, 
                    decimal allocationPercentage)
        {
            ProjectFundingRule projectFundingRule = new ProjectFundingRule();
            projectFundingRule.DataAreaId = dataAreaId;
            projectFundingRule.ProjectContractId = projectContractId;
            projectFundingRule.Priority = priority;
            projectFundingRule.ProjectId = projectId;
            projectFundingRule.ActivityNumber = activityNumber;
            projectFundingRule.CategoryId = categoryId;
            projectFundingRule.CategoryGroupId = categoryGroupId;
            projectFundingRule.ItemId = itemId;
            projectFundingRule.EndDate = endDate;
            projectFundingRule.StartDate = startDate;
            projectFundingRule.ResourceId = resourceId;
            projectFundingRule.FundingSourceId = fundingSourceId;
            projectFundingRule.AllocationPercentage = allocationPercentage;
            return projectFundingRule;
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
        /// There are no comments for Property ProjectContractId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContractId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectContractId is required.")]
        public virtual string ProjectContractId
        {
            get
            {
                return this._ProjectContractId;
            }
            set
            {
                this.OnProjectContractIdChanging(value);
                this._ProjectContractId = value;
                this.OnProjectContractIdChanged();
                this.OnPropertyChanged("ProjectContractId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectContractId;
        partial void OnProjectContractIdChanging(string value);
        partial void OnProjectContractIdChanged();
        /// <summary>
        /// There are no comments for Property Priority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Priority")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Priority is required.")]
        public virtual int Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this.OnPriorityChanging(value);
                this._Priority = value;
                this.OnPriorityChanged();
                this.OnPropertyChanged("Priority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Priority;
        partial void OnPriorityChanging(int value);
        partial void OnPriorityChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectId is required.")]
        public virtual string ProjectId
        {
            get
            {
                return this._ProjectId;
            }
            set
            {
                this.OnProjectIdChanging(value);
                this._ProjectId = value;
                this.OnProjectIdChanged();
                this.OnPropertyChanged("ProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectId;
        partial void OnProjectIdChanging(string value);
        partial void OnProjectIdChanged();
        /// <summary>
        /// There are no comments for Property ActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActivityNumber is required.")]
        public virtual string ActivityNumber
        {
            get
            {
                return this._ActivityNumber;
            }
            set
            {
                this.OnActivityNumberChanging(value);
                this._ActivityNumber = value;
                this.OnActivityNumberChanged();
                this.OnPropertyChanged("ActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityNumber;
        partial void OnActivityNumberChanging(string value);
        partial void OnActivityNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAllTrxType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAllTrxType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAllTrxType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryId is required.")]
        public virtual string CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryId;
        partial void OnCategoryIdChanging(string value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property CategoryGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryGroupId is required.")]
        public virtual string CategoryGroupId
        {
            get
            {
                return this._CategoryGroupId;
            }
            set
            {
                this.OnCategoryGroupIdChanging(value);
                this._CategoryGroupId = value;
                this.OnCategoryGroupIdChanged();
                this.OnPropertyChanged("CategoryGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryGroupId;
        partial void OnCategoryGroupIdChanging(string value);
        partial void OnCategoryGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property ResourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ResourceId is required.")]
        public virtual string ResourceId
        {
            get
            {
                return this._ResourceId;
            }
            set
            {
                this.OnResourceIdChanging(value);
                this._ResourceId = value;
                this.OnResourceIdChanged();
                this.OnPropertyChanged("ResourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceId;
        partial void OnResourceIdChanging(string value);
        partial void OnResourceIdChanged();
        /// <summary>
        /// There are no comments for Property FundingSourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundingSourceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FundingSourceId is required.")]
        public virtual string FundingSourceId
        {
            get
            {
                return this._FundingSourceId;
            }
            set
            {
                this.OnFundingSourceIdChanging(value);
                this._FundingSourceId = value;
                this.OnFundingSourceIdChanged();
                this.OnPropertyChanged("FundingSourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundingSourceId;
        partial void OnFundingSourceIdChanging(string value);
        partial void OnFundingSourceIdChanged();
        /// <summary>
        /// There are no comments for Property AllocateRounding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocateRounding")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllocateRounding
        {
            get
            {
                return this._AllocateRounding;
            }
            set
            {
                this.OnAllocateRoundingChanging(value);
                this._AllocateRounding = value;
                this.OnAllocateRoundingChanged();
                this.OnPropertyChanged("AllocateRounding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllocateRounding;
        partial void OnAllocateRoundingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllocateRoundingChanged();
        /// <summary>
        /// There are no comments for Property AllocationPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AllocationPercentage is required.")]
        public virtual decimal AllocationPercentage
        {
            get
            {
                return this._AllocationPercentage;
            }
            set
            {
                this.OnAllocationPercentageChanging(value);
                this._AllocationPercentage = value;
                this.OnAllocationPercentageChanged();
                this.OnPropertyChanged("AllocationPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AllocationPercentage;
        partial void OnAllocationPercentageChanging(decimal value);
        partial void OnAllocationPercentageChanged();
        /// <summary>
        /// There are no comments for Property ProjectContract in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContract")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectContract ProjectContract
        {
            get
            {
                return this._ProjectContract;
            }
            set
            {
                this.OnProjectContractChanging(value);
                this._ProjectContract = value;
                this.OnProjectContractChanged();
                this.OnPropertyChanged("ProjectContract");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectContract _ProjectContract;
        partial void OnProjectContractChanging(global::Microsoft.Dynamics.DataEntities.ProjectContract value);
        partial void OnProjectContractChanged();
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