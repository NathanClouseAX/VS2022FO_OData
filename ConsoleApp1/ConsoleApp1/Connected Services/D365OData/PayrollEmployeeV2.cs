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
    /// There are no comments for PayrollEmployeeV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployeeV2Single")]
    public partial class PayrollEmployeeV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollEmployeeV2>
    {
        /// <summary>
        /// Initialize a new PayrollEmployeeV2Single object.
        /// </summary>
        public PayrollEmployeeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollEmployeeV2Single object.
        /// </summary>
        public PayrollEmployeeV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollEmployeeV2Single object.
        /// </summary>
        public PayrollEmployeeV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollEmployeeV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PersonIdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonIdentificationNumber")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumberSingle PersonIdentificationNumber
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonIdentificationNumber == null))
                {
                    this._PersonIdentificationNumber = new global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumberSingle(this.Context, GetPath("PersonIdentificationNumber"));
                }
                return this._PersonIdentificationNumber;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumberSingle _PersonIdentificationNumber;
        /// <summary>
        /// There are no comments for EmployeeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmployeeV2Single EmployeeV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmployeeV2 == null))
                {
                    this._EmployeeV2 = new global::Microsoft.Dynamics.DataEntities.EmployeeV2Single(this.Context, GetPath("EmployeeV2"));
                }
                return this._EmployeeV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmployeeV2Single _EmployeeV2;
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
        /// There are no comments for EmploymentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentDetail")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentDetail == null))
                {
                    this._EmploymentDetail = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(GetPath("EmploymentDetail"));
                }
                return this._EmploymentDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetail;
    }
    /// <summary>
    /// There are no comments for PayrollEmployeeV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PersonnelNumber
    /// LegalEntityId
    /// EmploymentStartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PersonnelNumber", "LegalEntityId", "EmploymentStartDate")]
    [global::Microsoft.OData.Client.EntitySet("PayrollEmployeesV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployeeV2")]
    public partial class PayrollEmployeeV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollEmployeeV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="birthDate">Initial value of BirthDate.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="employeeV2">Initial value of EmployeeV2.</param>
        /// <param name="baseWorker">Initial value of BaseWorker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollEmployeeV2 CreatePayrollEmployeeV2(string dataAreaId, 
                    string personnelNumber, 
                    string legalEntityId, 
                    global::System.DateTimeOffset employmentStartDate, 
                    global::System.DateTimeOffset birthDate, 
                    global::System.DateTimeOffset employmentEndDate, 
                    global::Microsoft.Dynamics.DataEntities.EmployeeV2 employeeV2, 
                    global::Microsoft.Dynamics.DataEntities.BaseWorker baseWorker)
        {
            PayrollEmployeeV2 payrollEmployeeV2 = new PayrollEmployeeV2();
            payrollEmployeeV2.DataAreaId = dataAreaId;
            payrollEmployeeV2.PersonnelNumber = personnelNumber;
            payrollEmployeeV2.LegalEntityId = legalEntityId;
            payrollEmployeeV2.EmploymentStartDate = employmentStartDate;
            payrollEmployeeV2.BirthDate = birthDate;
            payrollEmployeeV2.EmploymentEndDate = employmentEndDate;
            if ((employeeV2 == null))
            {
                throw new global::System.ArgumentNullException("employeeV2");
            }
            payrollEmployeeV2.EmployeeV2 = employeeV2;
            if ((baseWorker == null))
            {
                throw new global::System.ArgumentNullException("baseWorker");
            }
            payrollEmployeeV2.BaseWorker = baseWorker;
            return payrollEmployeeV2;
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
        /// There are no comments for Property EmploymentStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentStartDate is required.")]
        public virtual global::System.DateTimeOffset EmploymentStartDate
        {
            get
            {
                return this._EmploymentStartDate;
            }
            set
            {
                this.OnEmploymentStartDateChanging(value);
                this._EmploymentStartDate = value;
                this.OnEmploymentStartDateChanged();
                this.OnPropertyChanged("EmploymentStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentStartDate;
        partial void OnEmploymentStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentStartDateChanged();
        /// <summary>
        /// There are no comments for Property EmploymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> EmploymentType
        {
            get
            {
                return this._EmploymentType;
            }
            set
            {
                this.OnEmploymentTypeChanging(value);
                this._EmploymentType = value;
                this.OnEmploymentTypeChanged();
                this.OnPropertyChanged("EmploymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> _EmploymentType;
        partial void OnEmploymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> value);
        partial void OnEmploymentTypeChanged();
        /// <summary>
        /// There are no comments for Property ReadyToPay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReadyToPay")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ReadyToPay
        {
            get
            {
                return this._ReadyToPay;
            }
            set
            {
                this.OnReadyToPayChanging(value);
                this._ReadyToPay = value;
                this.OnReadyToPayChanged();
                this.OnPropertyChanged("ReadyToPay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ReadyToPay;
        partial void OnReadyToPayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReadyToPayChanged();
        /// <summary>
        /// There are no comments for Property IdentificationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationTypeId")]
        public virtual string IdentificationTypeId
        {
            get
            {
                return this._IdentificationTypeId;
            }
            set
            {
                this.OnIdentificationTypeIdChanging(value);
                this._IdentificationTypeId = value;
                this.OnIdentificationTypeIdChanged();
                this.OnPropertyChanged("IdentificationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationTypeId;
        partial void OnIdentificationTypeIdChanging(string value);
        partial void OnIdentificationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property IdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationNumber")]
        public virtual string IdentificationNumber
        {
            get
            {
                return this._IdentificationNumber;
            }
            set
            {
                this.OnIdentificationNumberChanging(value);
                this._IdentificationNumber = value;
                this.OnIdentificationNumberChanged();
                this.OnPropertyChanged("IdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentificationNumber;
        partial void OnIdentificationNumberChanging(string value);
        partial void OnIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property Gender in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Gender")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmPersonGender> Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this.OnGenderChanging(value);
                this._Gender = value;
                this.OnGenderChanged();
                this.OnPropertyChanged("Gender");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmPersonGender> _Gender;
        partial void OnGenderChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmPersonGender> value);
        partial void OnGenderChanged();
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
        /// There are no comments for Property EmploymentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentId")]
        public virtual string EmploymentId
        {
            get
            {
                return this._EmploymentId;
            }
            set
            {
                this.OnEmploymentIdChanging(value);
                this._EmploymentId = value;
                this.OnEmploymentIdChanged();
                this.OnPropertyChanged("EmploymentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmploymentId;
        partial void OnEmploymentIdChanging(string value);
        partial void OnEmploymentIdChanged();
        /// <summary>
        /// There are no comments for Property BirthDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BirthDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BirthDate is required.")]
        public virtual global::System.DateTimeOffset BirthDate
        {
            get
            {
                return this._BirthDate;
            }
            set
            {
                this.OnBirthDateChanging(value);
                this._BirthDate = value;
                this.OnBirthDateChanged();
                this.OnPropertyChanged("BirthDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BirthDate;
        partial void OnBirthDateChanging(global::System.DateTimeOffset value);
        partial void OnBirthDateChanged();
        /// <summary>
        /// There are no comments for Property EmploymentEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentEndDate is required.")]
        public virtual global::System.DateTimeOffset EmploymentEndDate
        {
            get
            {
                return this._EmploymentEndDate;
            }
            set
            {
                this.OnEmploymentEndDateChanging(value);
                this._EmploymentEndDate = value;
                this.OnEmploymentEndDateChanged();
                this.OnPropertyChanged("EmploymentEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentEndDate;
        partial void OnEmploymentEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentEndDateChanged();
        /// <summary>
        /// There are no comments for Property PersonIdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonIdentificationNumber")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber PersonIdentificationNumber
        {
            get
            {
                return this._PersonIdentificationNumber;
            }
            set
            {
                this.OnPersonIdentificationNumberChanging(value);
                this._PersonIdentificationNumber = value;
                this.OnPersonIdentificationNumberChanged();
                this.OnPropertyChanged("PersonIdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber _PersonIdentificationNumber;
        partial void OnPersonIdentificationNumberChanging(global::Microsoft.Dynamics.DataEntities.PersonIdentificationNumber value);
        partial void OnPersonIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property EmployeeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmployeeV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmployeeV2 EmployeeV2
        {
            get
            {
                return this._EmployeeV2;
            }
            set
            {
                this.OnEmployeeV2Changing(value);
                this._EmployeeV2 = value;
                this.OnEmployeeV2Changed();
                this.OnPropertyChanged("EmployeeV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmployeeV2 _EmployeeV2;
        partial void OnEmployeeV2Changing(global::Microsoft.Dynamics.DataEntities.EmployeeV2 value);
        partial void OnEmployeeV2Changed();
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
        /// There are no comments for Property EmploymentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentDetail")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetail
        {
            get
            {
                return this._EmploymentDetail;
            }
            set
            {
                this.OnEmploymentDetailChanging(value);
                this._EmploymentDetail = value;
                this.OnEmploymentDetailChanged();
                this.OnPropertyChanged("EmploymentDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetail = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentDetailChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> value);
        partial void OnEmploymentDetailChanged();
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
