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
    /// There are no comments for ProjectLedgerPostingDefinitionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectLedgerPostingDefinitionSingle")]
    public partial class ProjectLedgerPostingDefinitionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectLedgerPostingDefinition>
    {
        /// <summary>
        /// Initialize a new ProjectLedgerPostingDefinitionSingle object.
        /// </summary>
        public ProjectLedgerPostingDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectLedgerPostingDefinitionSingle object.
        /// </summary>
        public ProjectLedgerPostingDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectLedgerPostingDefinitionSingle object.
        /// </summary>
        public ProjectLedgerPostingDefinitionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectLedgerPostingDefinition> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
    /// <summary>
    /// There are no comments for ProjectLedgerPostingDefinition in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjectAccountType
    /// ProjectId
    /// ProjectGroup
    /// CategoryId
    /// CategoryGroup
    /// TaxGroupId
    /// ProjectContractId
    /// FundingSourceId
    /// BorrowingLegalEntity
    /// LendingLegalEntity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjectAccountType", "ProjectId", "ProjectGroup", "CategoryId", "CategoryGroup", "TaxGroupId", "ProjectContractId", "FundingSourceId", "BorrowingLegalEntity", "LendingLegalEntity")]
    [global::Microsoft.OData.Client.EntitySet("ProjectLedgerPostingDefinitions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectLedgerPostingDefinition")]
    public partial class ProjectLedgerPostingDefinition : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectLedgerPostingDefinition object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projectId">Initial value of ProjectId.</param>
        /// <param name="projectGroup">Initial value of ProjectGroup.</param>
        /// <param name="categoryId">Initial value of CategoryId.</param>
        /// <param name="categoryGroup">Initial value of CategoryGroup.</param>
        /// <param name="taxGroupId">Initial value of TaxGroupId.</param>
        /// <param name="projectContractId">Initial value of ProjectContractId.</param>
        /// <param name="fundingSourceId">Initial value of FundingSourceId.</param>
        /// <param name="borrowingLegalEntity">Initial value of BorrowingLegalEntity.</param>
        /// <param name="lendingLegalEntity">Initial value of LendingLegalEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectLedgerPostingDefinition CreateProjectLedgerPostingDefinition(string dataAreaId, 
                    string projectId, 
                    string projectGroup, 
                    string categoryId, 
                    string categoryGroup, 
                    string taxGroupId, 
                    string projectContractId, 
                    string fundingSourceId, 
                    string borrowingLegalEntity, 
                    string lendingLegalEntity)
        {
            ProjectLedgerPostingDefinition projectLedgerPostingDefinition = new ProjectLedgerPostingDefinition();
            projectLedgerPostingDefinition.DataAreaId = dataAreaId;
            projectLedgerPostingDefinition.ProjectId = projectId;
            projectLedgerPostingDefinition.ProjectGroup = projectGroup;
            projectLedgerPostingDefinition.CategoryId = categoryId;
            projectLedgerPostingDefinition.CategoryGroup = categoryGroup;
            projectLedgerPostingDefinition.TaxGroupId = taxGroupId;
            projectLedgerPostingDefinition.ProjectContractId = projectContractId;
            projectLedgerPostingDefinition.FundingSourceId = fundingSourceId;
            projectLedgerPostingDefinition.BorrowingLegalEntity = borrowingLegalEntity;
            projectLedgerPostingDefinition.LendingLegalEntity = lendingLegalEntity;
            return projectLedgerPostingDefinition;
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
        /// There are no comments for Property ProjectAccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectAccountType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAccountType> ProjectAccountType
        {
            get
            {
                return this._ProjectAccountType;
            }
            set
            {
                this.OnProjectAccountTypeChanging(value);
                this._ProjectAccountType = value;
                this.OnProjectAccountTypeChanged();
                this.OnPropertyChanged("ProjectAccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAccountType> _ProjectAccountType;
        partial void OnProjectAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjAccountType> value);
        partial void OnProjectAccountTypeChanged();
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
        /// There are no comments for Property ProjectGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectGroup is required.")]
        public virtual string ProjectGroup
        {
            get
            {
                return this._ProjectGroup;
            }
            set
            {
                this.OnProjectGroupChanging(value);
                this._ProjectGroup = value;
                this.OnProjectGroupChanged();
                this.OnPropertyChanged("ProjectGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectGroup;
        partial void OnProjectGroupChanging(string value);
        partial void OnProjectGroupChanged();
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
        /// There are no comments for Property CategoryGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryGroup is required.")]
        public virtual string CategoryGroup
        {
            get
            {
                return this._CategoryGroup;
            }
            set
            {
                this.OnCategoryGroupChanging(value);
                this._CategoryGroup = value;
                this.OnCategoryGroupChanged();
                this.OnPropertyChanged("CategoryGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryGroup;
        partial void OnCategoryGroupChanging(string value);
        partial void OnCategoryGroupChanged();
        /// <summary>
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxGroupId is required.")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
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
        /// There are no comments for Property BorrowingLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BorrowingLegalEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BorrowingLegalEntity is required.")]
        public virtual string BorrowingLegalEntity
        {
            get
            {
                return this._BorrowingLegalEntity;
            }
            set
            {
                this.OnBorrowingLegalEntityChanging(value);
                this._BorrowingLegalEntity = value;
                this.OnBorrowingLegalEntityChanged();
                this.OnPropertyChanged("BorrowingLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BorrowingLegalEntity;
        partial void OnBorrowingLegalEntityChanging(string value);
        partial void OnBorrowingLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LendingLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LendingLegalEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LendingLegalEntity is required.")]
        public virtual string LendingLegalEntity
        {
            get
            {
                return this._LendingLegalEntity;
            }
            set
            {
                this.OnLendingLegalEntityChanging(value);
                this._LendingLegalEntity = value;
                this.OnLendingLegalEntityChanged();
                this.OnPropertyChanged("LendingLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LendingLegalEntity;
        partial void OnLendingLegalEntityChanging(string value);
        partial void OnLendingLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property MainAccountIdDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccountIdDisplayValue")]
        public virtual string MainAccountIdDisplayValue
        {
            get
            {
                return this._MainAccountIdDisplayValue;
            }
            set
            {
                this.OnMainAccountIdDisplayValueChanging(value);
                this._MainAccountIdDisplayValue = value;
                this.OnMainAccountIdDisplayValueChanged();
                this.OnPropertyChanged("MainAccountIdDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountIdDisplayValue;
        partial void OnMainAccountIdDisplayValueChanging(string value);
        partial void OnMainAccountIdDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
