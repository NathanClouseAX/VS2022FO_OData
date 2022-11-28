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
    /// There are no comments for BenefitsCreditPeriodEmployeeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCreditPeriodEmployeeSingle")]
    public partial class BenefitsCreditPeriodEmployeeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsCreditPeriodEmployee>
    {
        /// <summary>
        /// Initialize a new BenefitsCreditPeriodEmployeeSingle object.
        /// </summary>
        public BenefitsCreditPeriodEmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsCreditPeriodEmployeeSingle object.
        /// </summary>
        public BenefitsCreditPeriodEmployeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsCreditPeriodEmployeeSingle object.
        /// </summary>
        public BenefitsCreditPeriodEmployeeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsCreditPeriodEmployee> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
    }
    /// <summary>
    /// There are no comments for BenefitsCreditPeriodEmployee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PersonnelNumber
    /// Period_FK_PlanPeriodId
    /// LegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PersonnelNumber", "Period_FK_PlanPeriodId", "LegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsCreditPeriodEmployees")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsCreditPeriodEmployee")]
    public partial class BenefitsCreditPeriodEmployee : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsCreditPeriodEmployee object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="period_FK_PlanPeriodId">Initial value of Period_FK_PlanPeriodId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="creditPeriodEmployeeValue">Initial value of CreditPeriodEmployeeValue.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsCreditPeriodEmployee CreateBenefitsCreditPeriodEmployee(string dataAreaId, 
                    string personnelNumber, 
                    string period_FK_PlanPeriodId, 
                    string legalEntityId, 
                    decimal creditPeriodEmployeeValue, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            BenefitsCreditPeriodEmployee benefitsCreditPeriodEmployee = new BenefitsCreditPeriodEmployee();
            benefitsCreditPeriodEmployee.DataAreaId = dataAreaId;
            benefitsCreditPeriodEmployee.PersonnelNumber = personnelNumber;
            benefitsCreditPeriodEmployee.Period_FK_PlanPeriodId = period_FK_PlanPeriodId;
            benefitsCreditPeriodEmployee.LegalEntityId = legalEntityId;
            benefitsCreditPeriodEmployee.CreditPeriodEmployeeValue = creditPeriodEmployeeValue;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            benefitsCreditPeriodEmployee.Worker = worker;
            return benefitsCreditPeriodEmployee;
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
        /// There are no comments for Property Period_FK_PlanPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Period_FK_PlanPeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Period_FK_PlanPeriodId is required.")]
        public virtual string Period_FK_PlanPeriodId
        {
            get
            {
                return this._Period_FK_PlanPeriodId;
            }
            set
            {
                this.OnPeriod_FK_PlanPeriodIdChanging(value);
                this._Period_FK_PlanPeriodId = value;
                this.OnPeriod_FK_PlanPeriodIdChanged();
                this.OnPropertyChanged("Period_FK_PlanPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Period_FK_PlanPeriodId;
        partial void OnPeriod_FK_PlanPeriodIdChanging(string value);
        partial void OnPeriod_FK_PlanPeriodIdChanged();
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
        /// There are no comments for Property CreditId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditId")]
        public virtual string CreditId
        {
            get
            {
                return this._CreditId;
            }
            set
            {
                this.OnCreditIdChanging(value);
                this._CreditId = value;
                this.OnCreditIdChanged();
                this.OnPropertyChanged("CreditId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditId;
        partial void OnCreditIdChanging(string value);
        partial void OnCreditIdChanged();
        /// <summary>
        /// There are no comments for Property CreditPeriodEmployeeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPeriodEmployeeValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CreditPeriodEmployeeValue is required.")]
        public virtual decimal CreditPeriodEmployeeValue
        {
            get
            {
                return this._CreditPeriodEmployeeValue;
            }
            set
            {
                this.OnCreditPeriodEmployeeValueChanging(value);
                this._CreditPeriodEmployeeValue = value;
                this.OnCreditPeriodEmployeeValueChanged();
                this.OnPropertyChanged("CreditPeriodEmployeeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CreditPeriodEmployeeValue;
        partial void OnCreditPeriodEmployeeValueChanging(decimal value);
        partial void OnCreditPeriodEmployeeValueChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property PlanPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanPeriodId")]
        public virtual string PlanPeriodId
        {
            get
            {
                return this._PlanPeriodId;
            }
            set
            {
                this.OnPlanPeriodIdChanging(value);
                this._PlanPeriodId = value;
                this.OnPlanPeriodIdChanged();
                this.OnPropertyChanged("PlanPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanPeriodId;
        partial void OnPlanPeriodIdChanging(string value);
        partial void OnPlanPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Worker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
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
