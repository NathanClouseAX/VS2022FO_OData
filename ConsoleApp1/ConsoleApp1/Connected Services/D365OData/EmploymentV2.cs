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
    /// There are no comments for EmploymentV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentV2Single")]
    public partial class EmploymentV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentV2>
    {
        /// <summary>
        /// Initialize a new EmploymentV2Single object.
        /// </summary>
        public EmploymentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmploymentV2Single object.
        /// </summary>
        public EmploymentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmploymentV2Single object.
        /// </summary>
        public EmploymentV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<EmploymentV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RegulatoryEstablishmentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentDetail")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle RegulatoryEstablishmentDetail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RegulatoryEstablishmentDetail == null))
                {
                    this._RegulatoryEstablishmentDetail = new global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle(this.Context, GetPath("RegulatoryEstablishmentDetail"));
                }
                return this._RegulatoryEstablishmentDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle _RegulatoryEstablishmentDetail;
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
        /// <summary>
        /// There are no comments for WorkCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkCalendar")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkCalendarSingle WorkCalendar
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkCalendar == null))
                {
                    this._WorkCalendar = new global::Microsoft.Dynamics.DataEntities.WorkCalendarSingle(this.Context, GetPath("WorkCalendar"));
                }
                return this._WorkCalendar;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkCalendarSingle _WorkCalendar;
        /// <summary>
        /// There are no comments for EmploymentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentDetails == null))
                {
                    this._EmploymentDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(GetPath("EmploymentDetails"));
                }
                return this._EmploymentDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetails;
        /// <summary>
        /// There are no comments for EmploymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentTerms")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> EmploymentTerms
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentTerms == null))
                {
                    this._EmploymentTerms = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm>(GetPath("EmploymentTerms"));
                }
                return this._EmploymentTerms;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> _EmploymentTerms;
    }
    /// <summary>
    /// There are no comments for EmploymentV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LegalEntityId
    /// EmploymentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LegalEntityId", "EmploymentId")]
    [global::Microsoft.OData.Client.EntitySet("EmploymentsV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentV2")]
    public partial class EmploymentV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmploymentV2 object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="employmentId">Initial value of EmploymentId.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmploymentV2 CreateEmploymentV2(string personnelNumber, 
                    string legalEntityId, 
                    string employmentId, 
                    global::System.DateTimeOffset employmentEndDate, 
                    global::System.DateTimeOffset employmentStartDate, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            EmploymentV2 employmentV2 = new EmploymentV2();
            employmentV2.PersonnelNumber = personnelNumber;
            employmentV2.LegalEntityId = legalEntityId;
            employmentV2.EmploymentId = employmentId;
            employmentV2.EmploymentEndDate = employmentEndDate;
            employmentV2.EmploymentStartDate = employmentStartDate;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            employmentV2.Worker = worker;
            return employmentV2;
        }
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
        /// There are no comments for Property EmploymentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentId is required.")]
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
        /// There are no comments for Property RegulatoryEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentId")]
        public virtual string RegulatoryEstablishmentId
        {
            get
            {
                return this._RegulatoryEstablishmentId;
            }
            set
            {
                this.OnRegulatoryEstablishmentIdChanging(value);
                this._RegulatoryEstablishmentId = value;
                this.OnRegulatoryEstablishmentIdChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegulatoryEstablishmentId;
        partial void OnRegulatoryEstablishmentIdChanging(string value);
        partial void OnRegulatoryEstablishmentIdChanged();
        /// <summary>
        /// There are no comments for Property WorkerType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> WorkerType
        {
            get
            {
                return this._WorkerType;
            }
            set
            {
                this.OnWorkerTypeChanging(value);
                this._WorkerType = value;
                this.OnWorkerTypeChanged();
                this.OnPropertyChanged("WorkerType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> _WorkerType;
        partial void OnWorkerTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> value);
        partial void OnWorkerTypeChanged();
        /// <summary>
        /// There are no comments for Property CalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarId")]
        public virtual string CalendarId
        {
            get
            {
                return this._CalendarId;
            }
            set
            {
                this.OnCalendarIdChanging(value);
                this._CalendarId = value;
                this.OnCalendarIdChanged();
                this.OnPropertyChanged("CalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalendarId;
        partial void OnCalendarIdChanging(string value);
        partial void OnCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property CalendarLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarLegalEntityId")]
        public virtual string CalendarLegalEntityId
        {
            get
            {
                return this._CalendarLegalEntityId;
            }
            set
            {
                this.OnCalendarLegalEntityIdChanging(value);
                this._CalendarLegalEntityId = value;
                this.OnCalendarLegalEntityIdChanged();
                this.OnPropertyChanged("CalendarLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalendarLegalEntityId;
        partial void OnCalendarLegalEntityIdChanging(string value);
        partial void OnCalendarLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegulatoryEstablishmentDetail")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail RegulatoryEstablishmentDetail
        {
            get
            {
                return this._RegulatoryEstablishmentDetail;
            }
            set
            {
                this.OnRegulatoryEstablishmentDetailChanging(value);
                this._RegulatoryEstablishmentDetail = value;
                this.OnRegulatoryEstablishmentDetailChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail _RegulatoryEstablishmentDetail;
        partial void OnRegulatoryEstablishmentDetailChanging(global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail value);
        partial void OnRegulatoryEstablishmentDetailChanged();
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
        /// There are no comments for Property WorkCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkCalendar")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkCalendar WorkCalendar
        {
            get
            {
                return this._WorkCalendar;
            }
            set
            {
                this.OnWorkCalendarChanging(value);
                this._WorkCalendar = value;
                this.OnWorkCalendarChanged();
                this.OnPropertyChanged("WorkCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkCalendar _WorkCalendar;
        partial void OnWorkCalendarChanging(global::Microsoft.Dynamics.DataEntities.WorkCalendar value);
        partial void OnWorkCalendarChanged();
        /// <summary>
        /// There are no comments for Property EmploymentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetails
        {
            get
            {
                return this._EmploymentDetails;
            }
            set
            {
                this.OnEmploymentDetailsChanging(value);
                this._EmploymentDetails = value;
                this.OnEmploymentDetailsChanged();
                this.OnPropertyChanged("EmploymentDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> value);
        partial void OnEmploymentDetailsChanged();
        /// <summary>
        /// There are no comments for Property EmploymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentTerms")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> EmploymentTerms
        {
            get
            {
                return this._EmploymentTerms;
            }
            set
            {
                this.OnEmploymentTermsChanging(value);
                this._EmploymentTerms = value;
                this.OnEmploymentTermsChanged();
                this.OnPropertyChanged("EmploymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> _EmploymentTerms = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentTermsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> value);
        partial void OnEmploymentTermsChanged();
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
