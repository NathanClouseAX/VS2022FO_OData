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
    /// There are no comments for WorkerGarnishmentDetailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerGarnishmentDetailSingle")]
    public partial class WorkerGarnishmentDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerGarnishmentDetail>
    {
        /// <summary>
        /// Initialize a new WorkerGarnishmentDetailSingle object.
        /// </summary>
        public WorkerGarnishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerGarnishmentDetailSingle object.
        /// </summary>
        public WorkerGarnishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerGarnishmentDetailSingle object.
        /// </summary>
        public WorkerGarnishmentDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerGarnishmentDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefit")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle WorkerEnrolledBenefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledBenefit == null))
                {
                    this._WorkerEnrolledBenefit = new global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle(this.Context, GetPath("WorkerEnrolledBenefit"));
                }
                return this._WorkerEnrolledBenefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle _WorkerEnrolledBenefit;
    }
    /// <summary>
    /// There are no comments for WorkerGarnishmentDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitID
    /// PersonnelNumber
    /// EnrollmentStart
    /// EnrollmentEnd
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitID", "PersonnelNumber", "EnrollmentStart", "EnrollmentEnd")]
    [global::Microsoft.OData.Client.EntitySet("WorkerGarnishmentDetails")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerGarnishmentDetail")]
    public partial class WorkerGarnishmentDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerGarnishmentDetail object.
        /// </summary>
        /// <param name="benefitID">Initial value of BenefitID.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="enrollmentStart">Initial value of EnrollmentStart.</param>
        /// <param name="enrollmentEnd">Initial value of EnrollmentEnd.</param>
        /// <param name="administrativeFee">Initial value of AdministrativeFee.</param>
        /// <param name="workerEnrolledBenefit">Initial value of WorkerEnrolledBenefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerGarnishmentDetail CreateWorkerGarnishmentDetail(string benefitID, 
                    string personnelNumber, 
                    global::System.DateTimeOffset enrollmentStart, 
                    global::System.DateTimeOffset enrollmentEnd, 
                    decimal administrativeFee, 
                    global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit workerEnrolledBenefit)
        {
            WorkerGarnishmentDetail workerGarnishmentDetail = new WorkerGarnishmentDetail();
            workerGarnishmentDetail.BenefitID = benefitID;
            workerGarnishmentDetail.PersonnelNumber = personnelNumber;
            workerGarnishmentDetail.EnrollmentStart = enrollmentStart;
            workerGarnishmentDetail.EnrollmentEnd = enrollmentEnd;
            workerGarnishmentDetail.AdministrativeFee = administrativeFee;
            if ((workerEnrolledBenefit == null))
            {
                throw new global::System.ArgumentNullException("workerEnrolledBenefit");
            }
            workerGarnishmentDetail.WorkerEnrolledBenefit = workerEnrolledBenefit;
            return workerGarnishmentDetail;
        }
        /// <summary>
        /// There are no comments for Property BenefitID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitID is required.")]
        public virtual string BenefitID
        {
            get
            {
                return this._BenefitID;
            }
            set
            {
                this.OnBenefitIDChanging(value);
                this._BenefitID = value;
                this.OnBenefitIDChanged();
                this.OnPropertyChanged("BenefitID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitID;
        partial void OnBenefitIDChanging(string value);
        partial void OnBenefitIDChanged();
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
        /// There are no comments for Property EnrollmentStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollmentStart")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollmentStart is required.")]
        public virtual global::System.DateTimeOffset EnrollmentStart
        {
            get
            {
                return this._EnrollmentStart;
            }
            set
            {
                this.OnEnrollmentStartChanging(value);
                this._EnrollmentStart = value;
                this.OnEnrollmentStartChanged();
                this.OnPropertyChanged("EnrollmentStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentStart;
        partial void OnEnrollmentStartChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentStartChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollmentEnd")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnrollmentEnd is required.")]
        public virtual global::System.DateTimeOffset EnrollmentEnd
        {
            get
            {
                return this._EnrollmentEnd;
            }
            set
            {
                this.OnEnrollmentEndChanging(value);
                this._EnrollmentEnd = value;
                this.OnEnrollmentEndChanged();
                this.OnPropertyChanged("EnrollmentEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentEnd;
        partial void OnEnrollmentEndChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentEndChanged();
        /// <summary>
        /// There are no comments for Property AdministrativeFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdministrativeFee")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdministrativeFee is required.")]
        public virtual decimal AdministrativeFee
        {
            get
            {
                return this._AdministrativeFee;
            }
            set
            {
                this.OnAdministrativeFeeChanging(value);
                this._AdministrativeFee = value;
                this.OnAdministrativeFeeChanged();
                this.OnPropertyChanged("AdministrativeFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AdministrativeFee;
        partial void OnAdministrativeFeeChanging(decimal value);
        partial void OnAdministrativeFeeChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionId")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property GarnishmentTaxLevyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GarnishmentTaxLevyType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> GarnishmentTaxLevyType
        {
            get
            {
                return this._GarnishmentTaxLevyType;
            }
            set
            {
                this.OnGarnishmentTaxLevyTypeChanging(value);
                this._GarnishmentTaxLevyType = value;
                this.OnGarnishmentTaxLevyTypeChanged();
                this.OnPropertyChanged("GarnishmentTaxLevyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> _GarnishmentTaxLevyType;
        partial void OnGarnishmentTaxLevyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollGarnishmentTaxLevyType> value);
        partial void OnGarnishmentTaxLevyTypeChanged();
        /// <summary>
        /// There are no comments for Property CaseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CaseNumber")]
        public virtual string CaseNumber
        {
            get
            {
                return this._CaseNumber;
            }
            set
            {
                this.OnCaseNumberChanging(value);
                this._CaseNumber = value;
                this.OnCaseNumberChanged();
                this.OnPropertyChanged("CaseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CaseNumber;
        partial void OnCaseNumberChanging(string value);
        partial void OnCaseNumberChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerEnrolledBenefit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerEnrolledBenefit is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit WorkerEnrolledBenefit
        {
            get
            {
                return this._WorkerEnrolledBenefit;
            }
            set
            {
                this.OnWorkerEnrolledBenefitChanging(value);
                this._WorkerEnrolledBenefit = value;
                this.OnWorkerEnrolledBenefitChanged();
                this.OnPropertyChanged("WorkerEnrolledBenefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit _WorkerEnrolledBenefit;
        partial void OnWorkerEnrolledBenefitChanging(global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit value);
        partial void OnWorkerEnrolledBenefitChanged();
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
