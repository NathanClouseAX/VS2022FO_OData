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
    /// There are no comments for CompensationEligibilityRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationEligibilityRuleSingle")]
    public partial class CompensationEligibilityRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationEligibilityRule>
    {
        /// <summary>
        /// Initialize a new CompensationEligibilityRuleSingle object.
        /// </summary>
        public CompensationEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationEligibilityRuleSingle object.
        /// </summary>
        public CompensationEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationEligibilityRuleSingle object.
        /// </summary>
        public CompensationEligibilityRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationEligibilityRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("JobType")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTypeSingle JobType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobType == null))
                {
                    this._JobType = new global::Microsoft.Dynamics.DataEntities.JobTypeSingle(this.Context, GetPath("JobType"));
                }
                return this._JobType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTypeSingle _JobType;
        /// <summary>
        /// There are no comments for Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle Location
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Location == null))
                {
                    this._Location = new global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle(this.Context, GetPath("Location"));
                }
                return this._Location;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationRegionSingle _Location;
        /// <summary>
        /// There are no comments for Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Job")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobSingle Job
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Job == null))
                {
                    this._Job = new global::Microsoft.Dynamics.DataEntities.JobSingle(this.Context, GetPath("Job"));
                }
                return this._Job;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobSingle _Job;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompFixedPlanTable")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompFixedPlanTableSingle CompFixedPlanTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompFixedPlanTable == null))
                {
                    this._CompFixedPlanTable = new global::Microsoft.Dynamics.DataEntities.CompFixedPlanTableSingle(this.Context, GetPath("CompFixedPlanTable"));
                }
                return this._CompFixedPlanTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompFixedPlanTableSingle _CompFixedPlanTable;
        /// <summary>
        /// There are no comments for OMOperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OMOperatingUnit")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle OMOperatingUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OMOperatingUnit == null))
                {
                    this._OMOperatingUnit = new global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle(this.Context, GetPath("OMOperatingUnit"));
                }
                return this._OMOperatingUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle _OMOperatingUnit;
        /// <summary>
        /// There are no comments for JobFunction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("JobFunction")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobFunctionSingle JobFunction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobFunction == null))
                {
                    this._JobFunction = new global::Microsoft.Dynamics.DataEntities.JobFunctionSingle(this.Context, GetPath("JobFunction"));
                }
                return this._JobFunction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobFunctionSingle _JobFunction;
        /// <summary>
        /// There are no comments for LaborUnion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborUnion")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnionsSingle LaborUnion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LaborUnion == null))
                {
                    this._LaborUnion = new global::Microsoft.Dynamics.DataEntities.UnionsSingle(this.Context, GetPath("LaborUnion"));
                }
                return this._LaborUnion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnionsSingle _LaborUnion;
    }
    /// <summary>
    /// There are no comments for CompensationEligibilityRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Eligibility
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Eligibility")]
    [global::Microsoft.OData.Client.EntitySet("CompensationEligibilityRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationEligibilityRule")]
    public partial class CompensationEligibilityRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationEligibilityRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="eligibility">Initial value of Eligibility.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationEligibilityRule CreateCompensationEligibilityRule(string dataAreaId, string eligibility, global::System.DateTimeOffset expirationDate, global::System.DateTimeOffset effectiveDate)
        {
            CompensationEligibilityRule compensationEligibilityRule = new CompensationEligibilityRule();
            compensationEligibilityRule.DataAreaId = dataAreaId;
            compensationEligibilityRule.Eligibility = eligibility;
            compensationEligibilityRule.ExpirationDate = expirationDate;
            compensationEligibilityRule.EffectiveDate = effectiveDate;
            return compensationEligibilityRule;
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
        /// There are no comments for Property Eligibility in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Eligibility")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Eligibility is required.")]
        public virtual string Eligibility
        {
            get
            {
                return this._Eligibility;
            }
            set
            {
                this.OnEligibilityChanging(value);
                this._Eligibility = value;
                this.OnEligibilityChanged();
                this.OnPropertyChanged("Eligibility");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Eligibility;
        partial void OnEligibilityChanging(string value);
        partial void OnEligibilityChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpirationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpirationDate is required.")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
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
        /// There are no comments for Property LaborUnionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborUnionId")]
        public virtual string LaborUnionId
        {
            get
            {
                return this._LaborUnionId;
            }
            set
            {
                this.OnLaborUnionIdChanging(value);
                this._LaborUnionId = value;
                this.OnLaborUnionIdChanged();
                this.OnPropertyChanged("LaborUnionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LaborUnionId;
        partial void OnLaborUnionIdChanging(string value);
        partial void OnLaborUnionIdChanged();
        /// <summary>
        /// There are no comments for Property DepartmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepartmentNumber")]
        public virtual string DepartmentNumber
        {
            get
            {
                return this._DepartmentNumber;
            }
            set
            {
                this.OnDepartmentNumberChanging(value);
                this._DepartmentNumber = value;
                this.OnDepartmentNumberChanged();
                this.OnPropertyChanged("DepartmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentNumber;
        partial void OnDepartmentNumberChanging(string value);
        partial void OnDepartmentNumberChanged();
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobId")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
        /// <summary>
        /// There are no comments for Property FunctionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FunctionId")]
        public virtual string FunctionId
        {
            get
            {
                return this._FunctionId;
            }
            set
            {
                this.OnFunctionIdChanging(value);
                this._FunctionId = value;
                this.OnFunctionIdChanged();
                this.OnPropertyChanged("FunctionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionId;
        partial void OnFunctionIdChanging(string value);
        partial void OnFunctionIdChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocationId")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Plan")]
        public virtual string Plan
        {
            get
            {
                return this._Plan;
            }
            set
            {
                this.OnPlanChanging(value);
                this._Plan = value;
                this.OnPlanChanged();
                this.OnPropertyChanged("Plan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Plan;
        partial void OnPlanChanging(string value);
        partial void OnPlanChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property JobTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTypeId")]
        public virtual string JobTypeId
        {
            get
            {
                return this._JobTypeId;
            }
            set
            {
                this.OnJobTypeIdChanging(value);
                this._JobTypeId = value;
                this.OnJobTypeIdChanged();
                this.OnPropertyChanged("JobTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTypeId;
        partial void OnJobTypeIdChanging(string value);
        partial void OnJobTypeIdChanged();
        /// <summary>
        /// There are no comments for Property RestrictEligibilityToWorkersInSelectedLevels in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RestrictEligibilityToWorkersInSelectedLevels")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RestrictEligibilityToWorkersInSelectedLevels
        {
            get
            {
                return this._RestrictEligibilityToWorkersInSelectedLevels;
            }
            set
            {
                this.OnRestrictEligibilityToWorkersInSelectedLevelsChanging(value);
                this._RestrictEligibilityToWorkersInSelectedLevels = value;
                this.OnRestrictEligibilityToWorkersInSelectedLevelsChanged();
                this.OnPropertyChanged("RestrictEligibilityToWorkersInSelectedLevels");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RestrictEligibilityToWorkersInSelectedLevels;
        partial void OnRestrictEligibilityToWorkersInSelectedLevelsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRestrictEligibilityToWorkersInSelectedLevelsChanged();
        /// <summary>
        /// There are no comments for Property JobType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobType")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobType JobType
        {
            get
            {
                return this._JobType;
            }
            set
            {
                this.OnJobTypeChanging(value);
                this._JobType = value;
                this.OnJobTypeChanged();
                this.OnPropertyChanged("JobType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobType _JobType;
        partial void OnJobTypeChanging(global::Microsoft.Dynamics.DataEntities.JobType value);
        partial void OnJobTypeChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationRegion Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationRegion _Location;
        partial void OnLocationChanging(global::Microsoft.Dynamics.DataEntities.CompensationRegion value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Job")]
        public virtual global::Microsoft.Dynamics.DataEntities.Job Job
        {
            get
            {
                return this._Job;
            }
            set
            {
                this.OnJobChanging(value);
                this._Job = value;
                this.OnJobChanged();
                this.OnPropertyChanged("Job");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Job _Job;
        partial void OnJobChanging(global::Microsoft.Dynamics.DataEntities.Job value);
        partial void OnJobChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property CompFixedPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompFixedPlanTable")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable CompFixedPlanTable
        {
            get
            {
                return this._CompFixedPlanTable;
            }
            set
            {
                this.OnCompFixedPlanTableChanging(value);
                this._CompFixedPlanTable = value;
                this.OnCompFixedPlanTableChanged();
                this.OnPropertyChanged("CompFixedPlanTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable _CompFixedPlanTable;
        partial void OnCompFixedPlanTableChanging(global::Microsoft.Dynamics.DataEntities.CompFixedPlanTable value);
        partial void OnCompFixedPlanTableChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OMOperatingUnit")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnit OMOperatingUnit
        {
            get
            {
                return this._OMOperatingUnit;
            }
            set
            {
                this.OnOMOperatingUnitChanging(value);
                this._OMOperatingUnit = value;
                this.OnOMOperatingUnitChanged();
                this.OnPropertyChanged("OMOperatingUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnit _OMOperatingUnit;
        partial void OnOMOperatingUnitChanging(global::Microsoft.Dynamics.DataEntities.OperatingUnit value);
        partial void OnOMOperatingUnitChanged();
        /// <summary>
        /// There are no comments for Property JobFunction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobFunction")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobFunction JobFunction
        {
            get
            {
                return this._JobFunction;
            }
            set
            {
                this.OnJobFunctionChanging(value);
                this._JobFunction = value;
                this.OnJobFunctionChanged();
                this.OnPropertyChanged("JobFunction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobFunction _JobFunction;
        partial void OnJobFunctionChanging(global::Microsoft.Dynamics.DataEntities.JobFunction value);
        partial void OnJobFunctionChanged();
        /// <summary>
        /// There are no comments for Property LaborUnion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborUnion")]
        public virtual global::Microsoft.Dynamics.DataEntities.Unions LaborUnion
        {
            get
            {
                return this._LaborUnion;
            }
            set
            {
                this.OnLaborUnionChanging(value);
                this._LaborUnion = value;
                this.OnLaborUnionChanged();
                this.OnPropertyChanged("LaborUnion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Unions _LaborUnion;
        partial void OnLaborUnionChanging(global::Microsoft.Dynamics.DataEntities.Unions value);
        partial void OnLaborUnionChanged();
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
