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
    /// There are no comments for LeavePlanV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanV2Single")]
    public partial class LeavePlanV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<LeavePlanV2>
    {
        /// <summary>
        /// Initialize a new LeavePlanV2Single object.
        /// </summary>
        public LeavePlanV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeavePlanV2Single object.
        /// </summary>
        public LeavePlanV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeavePlanV2Single object.
        /// </summary>
        public LeavePlanV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<LeavePlanV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LeavePlanTiersV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanTiersV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2> LeavePlanTiersV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeavePlanTiersV2 == null))
                {
                    this._LeavePlanTiersV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2>(GetPath("LeavePlanTiersV2"));
                }
                return this._LeavePlanTiersV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2> _LeavePlanTiersV2;
        /// <summary>
        /// There are no comments for LeaveBankTransactions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBankTransactions")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction> LeaveBankTransactions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveBankTransactions == null))
                {
                    this._LeaveBankTransactions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction>(GetPath("LeaveBankTransactions"));
                }
                return this._LeaveBankTransactions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction> _LeaveBankTransactions;
        /// <summary>
        /// There are no comments for LeaveBankTransactionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBankTransactionsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2> LeaveBankTransactionsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveBankTransactionsV2 == null))
                {
                    this._LeaveBankTransactionsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2>(GetPath("LeaveBankTransactionsV2"));
                }
                return this._LeaveBankTransactionsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2> _LeaveBankTransactionsV2;
        /// <summary>
        /// There are no comments for LeaveEnrollmentsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveEnrollmentsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2> LeaveEnrollmentsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveEnrollmentsV2 == null))
                {
                    this._LeaveEnrollmentsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2>(GetPath("LeaveEnrollmentsV2"));
                }
                return this._LeaveEnrollmentsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2> _LeaveEnrollmentsV2;
    }
    /// <summary>
    /// There are no comments for LeavePlanV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("LeavePlansV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanV2")]
    public partial class LeavePlanV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeavePlanV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeavePlanV2 CreateLeavePlanV2(string dataAreaId, string name, global::System.DateTimeOffset startDate)
        {
            LeavePlanV2 leavePlanV2 = new LeavePlanV2();
            leavePlanV2.DataAreaId = dataAreaId;
            leavePlanV2.Name = name;
            leavePlanV2.StartDate = startDate;
            return leavePlanV2;
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property AccrualFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualFrequency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualFrequency> AccrualFrequency
        {
            get
            {
                return this._AccrualFrequency;
            }
            set
            {
                this.OnAccrualFrequencyChanging(value);
                this._AccrualFrequency = value;
                this.OnAccrualFrequencyChanged();
                this.OnPropertyChanged("AccrualFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualFrequency> _AccrualFrequency;
        partial void OnAccrualFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualFrequency> value);
        partial void OnAccrualFrequencyChanged();
        /// <summary>
        /// There are no comments for Property AccrualType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualType> AccrualType
        {
            get
            {
                return this._AccrualType;
            }
            set
            {
                this.OnAccrualTypeChanging(value);
                this._AccrualType = value;
                this.OnAccrualTypeChanged();
                this.OnPropertyChanged("AccrualType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualType> _AccrualType;
        partial void OnAccrualTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualType> value);
        partial void OnAccrualTypeChanged();
        /// <summary>
        /// There are no comments for Property LeaveTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveTypeId")]
        public virtual string LeaveTypeId
        {
            get
            {
                return this._LeaveTypeId;
            }
            set
            {
                this.OnLeaveTypeIdChanging(value);
                this._LeaveTypeId = value;
                this.OnLeaveTypeIdChanged();
                this.OnPropertyChanged("LeaveTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaveTypeId;
        partial void OnLeaveTypeIdChanging(string value);
        partial void OnLeaveTypeIdChanged();
        /// <summary>
        /// There are no comments for Property EmployeeSpecificDateFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeSpecificDateFieldName")]
        public virtual string EmployeeSpecificDateFieldName
        {
            get
            {
                return this._EmployeeSpecificDateFieldName;
            }
            set
            {
                this.OnEmployeeSpecificDateFieldNameChanging(value);
                this._EmployeeSpecificDateFieldName = value;
                this.OnEmployeeSpecificDateFieldNameChanged();
                this.OnPropertyChanged("EmployeeSpecificDateFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployeeSpecificDateFieldName;
        partial void OnEmployeeSpecificDateFieldNameChanging(string value);
        partial void OnEmployeeSpecificDateFieldNameChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentAccrualPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnrollmentAccrualPolicy")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> EnrollmentAccrualPolicy
        {
            get
            {
                return this._EnrollmentAccrualPolicy;
            }
            set
            {
                this.OnEnrollmentAccrualPolicyChanging(value);
                this._EnrollmentAccrualPolicy = value;
                this.OnEnrollmentAccrualPolicyChanged();
                this.OnPropertyChanged("EnrollmentAccrualPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> _EnrollmentAccrualPolicy;
        partial void OnEnrollmentAccrualPolicyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> value);
        partial void OnEnrollmentAccrualPolicyChanged();
        /// <summary>
        /// There are no comments for Property HoursWorkedType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HoursWorkedType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHoursWorkedType> HoursWorkedType
        {
            get
            {
                return this._HoursWorkedType;
            }
            set
            {
                this.OnHoursWorkedTypeChanging(value);
                this._HoursWorkedType = value;
                this.OnHoursWorkedTypeChanged();
                this.OnPropertyChanged("HoursWorkedType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHoursWorkedType> _HoursWorkedType;
        partial void OnHoursWorkedTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHoursWorkedType> value);
        partial void OnHoursWorkedTypeChanged();
        /// <summary>
        /// There are no comments for Property AccrualAwardDateBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualAwardDateBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAccrualAwardDateBasis> AccrualAwardDateBasis
        {
            get
            {
                return this._AccrualAwardDateBasis;
            }
            set
            {
                this.OnAccrualAwardDateBasisChanging(value);
                this._AccrualAwardDateBasis = value;
                this.OnAccrualAwardDateBasisChanged();
                this.OnPropertyChanged("AccrualAwardDateBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAccrualAwardDateBasis> _AccrualAwardDateBasis;
        partial void OnAccrualAwardDateBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAccrualAwardDateBasis> value);
        partial void OnAccrualAwardDateBasisChanged();
        /// <summary>
        /// There are no comments for Property EmployeeSpecificDateTableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeSpecificDateTableName")]
        public virtual string EmployeeSpecificDateTableName
        {
            get
            {
                return this._EmployeeSpecificDateTableName;
            }
            set
            {
                this.OnEmployeeSpecificDateTableNameChanging(value);
                this._EmployeeSpecificDateTableName = value;
                this.OnEmployeeSpecificDateTableNameChanged();
                this.OnPropertyChanged("EmployeeSpecificDateTableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployeeSpecificDateTableName;
        partial void OnEmployeeSpecificDateTableNameChanging(string value);
        partial void OnEmployeeSpecificDateTableNameChanged();
        /// <summary>
        /// There are no comments for Property AccrualPeriodBasis in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccrualPeriodBasis")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPeriodBasis> AccrualPeriodBasis
        {
            get
            {
                return this._AccrualPeriodBasis;
            }
            set
            {
                this.OnAccrualPeriodBasisChanging(value);
                this._AccrualPeriodBasis = value;
                this.OnAccrualPeriodBasisChanged();
                this.OnPropertyChanged("AccrualPeriodBasis");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPeriodBasis> _AccrualPeriodBasis;
        partial void OnAccrualPeriodBasisChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPeriodBasis> value);
        partial void OnAccrualPeriodBasisChanged();
        /// <summary>
        /// There are no comments for Property UnenrollmentAccrualPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnenrollmentAccrualPolicy")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> UnenrollmentAccrualPolicy
        {
            get
            {
                return this._UnenrollmentAccrualPolicy;
            }
            set
            {
                this.OnUnenrollmentAccrualPolicyChanging(value);
                this._UnenrollmentAccrualPolicy = value;
                this.OnUnenrollmentAccrualPolicyChanged();
                this.OnPropertyChanged("UnenrollmentAccrualPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> _UnenrollmentAccrualPolicy;
        partial void OnUnenrollmentAccrualPolicyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeavePlanAccrualPolicy> value);
        partial void OnUnenrollmentAccrualPolicyChanged();
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
        /// There are no comments for Property LeavePlanTiersV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeavePlanTiersV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2> LeavePlanTiersV2
        {
            get
            {
                return this._LeavePlanTiersV2;
            }
            set
            {
                this.OnLeavePlanTiersV2Changing(value);
                this._LeavePlanTiersV2 = value;
                this.OnLeavePlanTiersV2Changed();
                this.OnPropertyChanged("LeavePlanTiersV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2> _LeavePlanTiersV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeavePlanTiersV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeavePlanTierV2> value);
        partial void OnLeavePlanTiersV2Changed();
        /// <summary>
        /// There are no comments for Property LeaveBankTransactions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBankTransactions")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction> LeaveBankTransactions
        {
            get
            {
                return this._LeaveBankTransactions;
            }
            set
            {
                this.OnLeaveBankTransactionsChanging(value);
                this._LeaveBankTransactions = value;
                this.OnLeaveBankTransactionsChanged();
                this.OnPropertyChanged("LeaveBankTransactions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction> _LeaveBankTransactions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveBankTransactionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransaction> value);
        partial void OnLeaveBankTransactionsChanged();
        /// <summary>
        /// There are no comments for Property LeaveBankTransactionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBankTransactionsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2> LeaveBankTransactionsV2
        {
            get
            {
                return this._LeaveBankTransactionsV2;
            }
            set
            {
                this.OnLeaveBankTransactionsV2Changing(value);
                this._LeaveBankTransactionsV2 = value;
                this.OnLeaveBankTransactionsV2Changed();
                this.OnPropertyChanged("LeaveBankTransactionsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2> _LeaveBankTransactionsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveBankTransactionsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBankTransactionV2> value);
        partial void OnLeaveBankTransactionsV2Changed();
        /// <summary>
        /// There are no comments for Property LeaveEnrollmentsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveEnrollmentsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2> LeaveEnrollmentsV2
        {
            get
            {
                return this._LeaveEnrollmentsV2;
            }
            set
            {
                this.OnLeaveEnrollmentsV2Changing(value);
                this._LeaveEnrollmentsV2 = value;
                this.OnLeaveEnrollmentsV2Changed();
                this.OnPropertyChanged("LeaveEnrollmentsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2> _LeaveEnrollmentsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveEnrollmentsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveEnrollmentV2> value);
        partial void OnLeaveEnrollmentsV2Changed();
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