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
    /// There are no comments for VariableCompensationEnrollmentV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VariableCompensationEnrollmentV2Single")]
    public partial class VariableCompensationEnrollmentV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<VariableCompensationEnrollmentV2>
    {
        /// <summary>
        /// Initialize a new VariableCompensationEnrollmentV2Single object.
        /// </summary>
        public VariableCompensationEnrollmentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VariableCompensationEnrollmentV2Single object.
        /// </summary>
        public VariableCompensationEnrollmentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VariableCompensationEnrollmentV2Single object.
        /// </summary>
        public VariableCompensationEnrollmentV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<VariableCompensationEnrollmentV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VariableCompensationPlanV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VariableCompensationPlanV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2Single VariableCompensationPlanV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VariableCompensationPlanV2 == null))
                {
                    this._VariableCompensationPlanV2 = new global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2Single(this.Context, GetPath("VariableCompensationPlanV2"));
                }
                return this._VariableCompensationPlanV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2Single _VariableCompensationPlanV2;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for VariableCompensationEnrollmentV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PersonnelNumber
    /// Plan
    /// EffectiveDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PersonnelNumber", "Plan", "EffectiveDate")]
    [global::Microsoft.OData.Client.EntitySet("VariableCompensationEnrollmentsV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VariableCompensationEnrollmentV2")]
    public partial class VariableCompensationEnrollmentV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VariableCompensationEnrollmentV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="plan">Initial value of Plan.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="awardPercent">Initial value of AwardPercent.</param>
        /// <param name="numberOfUnitsReal">Initial value of NumberOfUnitsReal.</param>
        /// <param name="hireRuleDate">Initial value of HireRuleDate.</param>
        /// <param name="awardAmount">Initial value of AwardAmount.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="variableCompensationPlanV2">Initial value of VariableCompensationPlanV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VariableCompensationEnrollmentV2 CreateVariableCompensationEnrollmentV2(string dataAreaId, 
                    string personnelNumber, 
                    string plan, 
                    global::System.DateTimeOffset effectiveDate, 
                    decimal awardPercent, 
                    decimal numberOfUnitsReal, 
                    global::System.DateTimeOffset hireRuleDate, 
                    decimal awardAmount, 
                    global::System.DateTimeOffset expirationDate, 
                    global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2 variableCompensationPlanV2)
        {
            VariableCompensationEnrollmentV2 variableCompensationEnrollmentV2 = new VariableCompensationEnrollmentV2();
            variableCompensationEnrollmentV2.DataAreaId = dataAreaId;
            variableCompensationEnrollmentV2.PersonnelNumber = personnelNumber;
            variableCompensationEnrollmentV2.Plan = plan;
            variableCompensationEnrollmentV2.EffectiveDate = effectiveDate;
            variableCompensationEnrollmentV2.AwardPercent = awardPercent;
            variableCompensationEnrollmentV2.NumberOfUnitsReal = numberOfUnitsReal;
            variableCompensationEnrollmentV2.HireRuleDate = hireRuleDate;
            variableCompensationEnrollmentV2.AwardAmount = awardAmount;
            variableCompensationEnrollmentV2.ExpirationDate = expirationDate;
            if ((variableCompensationPlanV2 == null))
            {
                throw new global::System.ArgumentNullException("variableCompensationPlanV2");
            }
            variableCompensationEnrollmentV2.VariableCompensationPlanV2 = variableCompensationPlanV2;
            return variableCompensationEnrollmentV2;
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
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelNumber is required.")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Plan")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Plan is required.")]
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
        /// There are no comments for Property AwardPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardPercent is required.")]
        public virtual decimal AwardPercent
        {
            get
            {
                return this._AwardPercent;
            }
            set
            {
                this.OnAwardPercentChanging(value);
                this._AwardPercent = value;
                this.OnAwardPercentChanged();
                this.OnPropertyChanged("AwardPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AwardPercent;
        partial void OnAwardPercentChanging(decimal value);
        partial void OnAwardPercentChanged();
        /// <summary>
        /// There are no comments for Property NumberOfUnitsReal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfUnitsReal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfUnitsReal is required.")]
        public virtual decimal NumberOfUnitsReal
        {
            get
            {
                return this._NumberOfUnitsReal;
            }
            set
            {
                this.OnNumberOfUnitsRealChanging(value);
                this._NumberOfUnitsReal = value;
                this.OnNumberOfUnitsRealChanged();
                this.OnPropertyChanged("NumberOfUnitsReal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NumberOfUnitsReal;
        partial void OnNumberOfUnitsRealChanging(decimal value);
        partial void OnNumberOfUnitsRealChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionDisplayValue")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarEnrollEmpllStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarEnrollEmpllStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarEnrollEmpllStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property HireRuleDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HireRuleDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HireRuleDate is required.")]
        public virtual global::System.DateTimeOffset HireRuleDate
        {
            get
            {
                return this._HireRuleDate;
            }
            set
            {
                this.OnHireRuleDateChanging(value);
                this._HireRuleDate = value;
                this.OnHireRuleDateChanged();
                this.OnPropertyChanged("HireRuleDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _HireRuleDate;
        partial void OnHireRuleDateChanging(global::System.DateTimeOffset value);
        partial void OnHireRuleDateChanged();
        /// <summary>
        /// There are no comments for Property AwardAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardAmount is required.")]
        public virtual decimal AwardAmount
        {
            get
            {
                return this._AwardAmount;
            }
            set
            {
                this.OnAwardAmountChanging(value);
                this._AwardAmount = value;
                this.OnAwardAmountChanged();
                this.OnPropertyChanged("AwardAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AwardAmount;
        partial void OnAwardAmountChanging(decimal value);
        partial void OnAwardAmountChanged();
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
        /// There are no comments for Property VariableCompensationPlanV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VariableCompensationPlanV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VariableCompensationPlanV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2 VariableCompensationPlanV2
        {
            get
            {
                return this._VariableCompensationPlanV2;
            }
            set
            {
                this.OnVariableCompensationPlanV2Changing(value);
                this._VariableCompensationPlanV2 = value;
                this.OnVariableCompensationPlanV2Changed();
                this.OnPropertyChanged("VariableCompensationPlanV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2 _VariableCompensationPlanV2;
        partial void OnVariableCompensationPlanV2Changing(global::Microsoft.Dynamics.DataEntities.CompVarPlanTableV2 value);
        partial void OnVariableCompensationPlanV2Changed();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
