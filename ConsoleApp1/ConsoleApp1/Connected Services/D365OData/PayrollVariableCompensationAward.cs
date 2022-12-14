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
    /// There are no comments for PayrollVariableCompensationAwardSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollVariableCompensationAwardSingle")]
    public partial class PayrollVariableCompensationAwardSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollVariableCompensationAward>
    {
        /// <summary>
        /// Initialize a new PayrollVariableCompensationAwardSingle object.
        /// </summary>
        public PayrollVariableCompensationAwardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollVariableCompensationAwardSingle object.
        /// </summary>
        public PayrollVariableCompensationAwardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollVariableCompensationAwardSingle object.
        /// </summary>
        public PayrollVariableCompensationAwardSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollVariableCompensationAward> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollFixedCompensationPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollFixedCompensationPlan")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan> PayrollFixedCompensationPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollFixedCompensationPlan == null))
                {
                    this._PayrollFixedCompensationPlan = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan>(GetPath("PayrollFixedCompensationPlan"));
                }
                return this._PayrollFixedCompensationPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan> _PayrollFixedCompensationPlan;
        /// <summary>
        /// There are no comments for BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle BaseWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseWorker == null))
                {
                    this._BaseWorker = new global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle(this.Context, GetPath("BaseWorker"));
                }
                return this._BaseWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle _BaseWorker;
        /// <summary>
        /// There are no comments for PayrollEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployee")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle PayrollEmployee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollEmployee == null))
                {
                    this._PayrollEmployee = new global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle(this.Context, GetPath("PayrollEmployee"));
                }
                return this._PayrollEmployee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle _PayrollEmployee;
    }
    /// <summary>
    /// There are no comments for PayrollVariableCompensationAward in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PersonnelNumber
    /// PlanId
    /// TypeId
    /// AwardDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PersonnelNumber", "PlanId", "TypeId", "AwardDate")]
    [global::Microsoft.OData.Client.EntitySet("PayrollVariableCompensationAwards")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollVariableCompensationAward")]
    public partial class PayrollVariableCompensationAward : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollVariableCompensationAward object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="typeId">Initial value of TypeId.</param>
        /// <param name="awardDate">Initial value of AwardDate.</param>
        /// <param name="unitValue">Initial value of UnitValue.</param>
        /// <param name="numberOfUnits">Initial value of NumberOfUnits.</param>
        /// <param name="baseWorker">Initial value of BaseWorker.</param>
        /// <param name="payrollEmployee">Initial value of PayrollEmployee.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollVariableCompensationAward CreatePayrollVariableCompensationAward(string dataAreaId, 
                    string personnelNumber, 
                    string planId, 
                    string typeId, 
                    global::System.DateTimeOffset awardDate, 
                    decimal unitValue, 
                    decimal numberOfUnits, 
                    global::Microsoft.Dynamics.DataEntities.BaseWorker baseWorker, 
                    global::Microsoft.Dynamics.DataEntities.PayrollEmployee payrollEmployee)
        {
            PayrollVariableCompensationAward payrollVariableCompensationAward = new PayrollVariableCompensationAward();
            payrollVariableCompensationAward.DataAreaId = dataAreaId;
            payrollVariableCompensationAward.PersonnelNumber = personnelNumber;
            payrollVariableCompensationAward.PlanId = planId;
            payrollVariableCompensationAward.TypeId = typeId;
            payrollVariableCompensationAward.AwardDate = awardDate;
            payrollVariableCompensationAward.UnitValue = unitValue;
            payrollVariableCompensationAward.NumberOfUnits = numberOfUnits;
            if ((baseWorker == null))
            {
                throw new global::System.ArgumentNullException("baseWorker");
            }
            payrollVariableCompensationAward.BaseWorker = baseWorker;
            if ((payrollEmployee == null))
            {
                throw new global::System.ArgumentNullException("payrollEmployee");
            }
            payrollVariableCompensationAward.PayrollEmployee = payrollEmployee;
            return payrollVariableCompensationAward;
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
        /// There are no comments for Property PlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanId is required.")]
        public virtual string PlanId
        {
            get
            {
                return this._PlanId;
            }
            set
            {
                this.OnPlanIdChanging(value);
                this._PlanId = value;
                this.OnPlanIdChanged();
                this.OnPropertyChanged("PlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanId;
        partial void OnPlanIdChanging(string value);
        partial void OnPlanIdChanged();
        /// <summary>
        /// There are no comments for Property TypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TypeId is required.")]
        public virtual string TypeId
        {
            get
            {
                return this._TypeId;
            }
            set
            {
                this.OnTypeIdChanging(value);
                this._TypeId = value;
                this.OnTypeIdChanged();
                this.OnPropertyChanged("TypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TypeId;
        partial void OnTypeIdChanging(string value);
        partial void OnTypeIdChanged();
        /// <summary>
        /// There are no comments for Property AwardDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardDate is required.")]
        public virtual global::System.DateTimeOffset AwardDate
        {
            get
            {
                return this._AwardDate;
            }
            set
            {
                this.OnAwardDateChanging(value);
                this._AwardDate = value;
                this.OnAwardDateChanged();
                this.OnPropertyChanged("AwardDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AwardDate;
        partial void OnAwardDateChanging(global::System.DateTimeOffset value);
        partial void OnAwardDateChanged();
        /// <summary>
        /// There are no comments for Property FixedPlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedPlanId")]
        public virtual string FixedPlanId
        {
            get
            {
                return this._FixedPlanId;
            }
            set
            {
                this.OnFixedPlanIdChanging(value);
                this._FixedPlanId = value;
                this.OnFixedPlanIdChanged();
                this.OnPropertyChanged("FixedPlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FixedPlanId;
        partial void OnFixedPlanIdChanging(string value);
        partial void OnFixedPlanIdChanged();
        /// <summary>
        /// There are no comments for Property UnitCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitCurrencyCode")]
        public virtual string UnitCurrencyCode
        {
            get
            {
                return this._UnitCurrencyCode;
            }
            set
            {
                this.OnUnitCurrencyCodeChanging(value);
                this._UnitCurrencyCode = value;
                this.OnUnitCurrencyCodeChanged();
                this.OnPropertyChanged("UnitCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitCurrencyCode;
        partial void OnUnitCurrencyCodeChanging(string value);
        partial void OnUnitCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AwardType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardEmplType> AwardType
        {
            get
            {
                return this._AwardType;
            }
            set
            {
                this.OnAwardTypeChanging(value);
                this._AwardType = value;
                this.OnAwardTypeChanged();
                this.OnPropertyChanged("AwardType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardEmplType> _AwardType;
        partial void OnAwardTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompVarAwardEmplType> value);
        partial void OnAwardTypeChanged();
        /// <summary>
        /// There are no comments for Property UnitValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitValue is required.")]
        public virtual decimal UnitValue
        {
            get
            {
                return this._UnitValue;
            }
            set
            {
                this.OnUnitValueChanging(value);
                this._UnitValue = value;
                this.OnUnitValueChanged();
                this.OnPropertyChanged("UnitValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UnitValue;
        partial void OnUnitValueChanging(decimal value);
        partial void OnUnitValueChanged();
        /// <summary>
        /// There are no comments for Property ProcessType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> ProcessType
        {
            get
            {
                return this._ProcessType;
            }
            set
            {
                this.OnProcessTypeChanging(value);
                this._ProcessType = value;
                this.OnProcessTypeChanged();
                this.OnPropertyChanged("ProcessType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> _ProcessType;
        partial void OnProcessTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompProcessType> value);
        partial void OnProcessTypeChanged();
        /// <summary>
        /// There are no comments for Property NumberOfUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfUnits")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfUnits is required.")]
        public virtual decimal NumberOfUnits
        {
            get
            {
                return this._NumberOfUnits;
            }
            set
            {
                this.OnNumberOfUnitsChanging(value);
                this._NumberOfUnits = value;
                this.OnNumberOfUnitsChanged();
                this.OnPropertyChanged("NumberOfUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _NumberOfUnits;
        partial void OnNumberOfUnitsChanging(decimal value);
        partial void OnNumberOfUnitsChanged();
        /// <summary>
        /// There are no comments for Property PayrollFixedCompensationPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollFixedCompensationPlan")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan> PayrollFixedCompensationPlan
        {
            get
            {
                return this._PayrollFixedCompensationPlan;
            }
            set
            {
                this.OnPayrollFixedCompensationPlanChanging(value);
                this._PayrollFixedCompensationPlan = value;
                this.OnPayrollFixedCompensationPlanChanged();
                this.OnPropertyChanged("PayrollFixedCompensationPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan> _PayrollFixedCompensationPlan = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPayrollFixedCompensationPlanChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollFixedCompensationPlan> value);
        partial void OnPayrollFixedCompensationPlanChanged();
        /// <summary>
        /// There are no comments for Property BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BaseWorker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorker BaseWorker
        {
            get
            {
                return this._BaseWorker;
            }
            set
            {
                this.OnBaseWorkerChanging(value);
                this._BaseWorker = value;
                this.OnBaseWorkerChanged();
                this.OnPropertyChanged("BaseWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorker _BaseWorker;
        partial void OnBaseWorkerChanging(global::Microsoft.Dynamics.DataEntities.BaseWorker value);
        partial void OnBaseWorkerChanged();
        /// <summary>
        /// There are no comments for Property PayrollEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployee")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayrollEmployee is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollEmployee PayrollEmployee
        {
            get
            {
                return this._PayrollEmployee;
            }
            set
            {
                this.OnPayrollEmployeeChanging(value);
                this._PayrollEmployee = value;
                this.OnPayrollEmployeeChanged();
                this.OnPropertyChanged("PayrollEmployee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollEmployee _PayrollEmployee;
        partial void OnPayrollEmployeeChanging(global::Microsoft.Dynamics.DataEntities.PayrollEmployee value);
        partial void OnPayrollEmployeeChanged();
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
