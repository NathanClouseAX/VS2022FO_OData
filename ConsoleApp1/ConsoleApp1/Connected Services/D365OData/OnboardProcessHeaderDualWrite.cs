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
    /// There are no comments for OnboardProcessHeaderDualWriteSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OnboardProcessHeaderDualWriteSingle")]
    public partial class OnboardProcessHeaderDualWriteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OnboardProcessHeaderDualWrite>
    {
        /// <summary>
        /// Initialize a new OnboardProcessHeaderDualWriteSingle object.
        /// </summary>
        public OnboardProcessHeaderDualWriteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OnboardProcessHeaderDualWriteSingle object.
        /// </summary>
        public OnboardProcessHeaderDualWriteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OnboardProcessHeaderDualWriteSingle object.
        /// </summary>
        public OnboardProcessHeaderDualWriteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OnboardProcessHeaderDualWrite> query)
            : base(query) {}

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
        /// There are no comments for ProcessHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessHeader")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProcessHeaderSingle ProcessHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProcessHeader == null))
                {
                    this._ProcessHeader = new global::Microsoft.Dynamics.DataEntities.ProcessHeaderSingle(this.Context, GetPath("ProcessHeader"));
                }
                return this._ProcessHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProcessHeaderSingle _ProcessHeader;
    }
    /// <summary>
    /// There are no comments for OnboardProcessHeaderDualWrite in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProcessId
    /// OnboardedEmployeePersonnelNumber
    /// EmploymentPersonnelNumber
    /// EmploymentStartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProcessId", "OnboardedEmployeePersonnelNumber", "EmploymentPersonnelNumber", "EmploymentStartDate")]
    [global::Microsoft.OData.Client.EntitySet("OnboardProcessHeadersDualWrite")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OnboardProcessHeaderDualWrite")]
    public partial class OnboardProcessHeaderDualWrite : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OnboardProcessHeaderDualWrite object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="processId">Initial value of ProcessId.</param>
        /// <param name="onboardedEmployeePersonnelNumber">Initial value of OnboardedEmployeePersonnelNumber.</param>
        /// <param name="employmentPersonnelNumber">Initial value of EmploymentPersonnelNumber.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="baseWorker">Initial value of BaseWorker.</param>
        /// <param name="processHeader">Initial value of ProcessHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OnboardProcessHeaderDualWrite CreateOnboardProcessHeaderDualWrite(string dataAreaId, 
                    global::System.Guid processId, 
                    string onboardedEmployeePersonnelNumber, 
                    string employmentPersonnelNumber, 
                    global::System.DateTimeOffset employmentStartDate, 
                    global::System.DateTimeOffset employmentEndDate, 
                    global::Microsoft.Dynamics.DataEntities.BaseWorker baseWorker, 
                    global::Microsoft.Dynamics.DataEntities.ProcessHeader processHeader)
        {
            OnboardProcessHeaderDualWrite onboardProcessHeaderDualWrite = new OnboardProcessHeaderDualWrite();
            onboardProcessHeaderDualWrite.DataAreaId = dataAreaId;
            onboardProcessHeaderDualWrite.ProcessId = processId;
            onboardProcessHeaderDualWrite.OnboardedEmployeePersonnelNumber = onboardedEmployeePersonnelNumber;
            onboardProcessHeaderDualWrite.EmploymentPersonnelNumber = employmentPersonnelNumber;
            onboardProcessHeaderDualWrite.EmploymentStartDate = employmentStartDate;
            onboardProcessHeaderDualWrite.EmploymentEndDate = employmentEndDate;
            if ((baseWorker == null))
            {
                throw new global::System.ArgumentNullException("baseWorker");
            }
            onboardProcessHeaderDualWrite.BaseWorker = baseWorker;
            if ((processHeader == null))
            {
                throw new global::System.ArgumentNullException("processHeader");
            }
            onboardProcessHeaderDualWrite.ProcessHeader = processHeader;
            return onboardProcessHeaderDualWrite;
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
        /// There are no comments for Property ProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcessId is required.")]
        public virtual global::System.Guid ProcessId
        {
            get
            {
                return this._ProcessId;
            }
            set
            {
                this.OnProcessIdChanging(value);
                this._ProcessId = value;
                this.OnProcessIdChanged();
                this.OnPropertyChanged("ProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ProcessId;
        partial void OnProcessIdChanging(global::System.Guid value);
        partial void OnProcessIdChanged();
        /// <summary>
        /// There are no comments for Property OnboardedEmployeePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnboardedEmployeePersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OnboardedEmployeePersonnelNumber is required.")]
        public virtual string OnboardedEmployeePersonnelNumber
        {
            get
            {
                return this._OnboardedEmployeePersonnelNumber;
            }
            set
            {
                this.OnOnboardedEmployeePersonnelNumberChanging(value);
                this._OnboardedEmployeePersonnelNumber = value;
                this.OnOnboardedEmployeePersonnelNumberChanged();
                this.OnPropertyChanged("OnboardedEmployeePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OnboardedEmployeePersonnelNumber;
        partial void OnOnboardedEmployeePersonnelNumberChanging(string value);
        partial void OnOnboardedEmployeePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property EmploymentPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmploymentPersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmploymentPersonnelNumber is required.")]
        public virtual string EmploymentPersonnelNumber
        {
            get
            {
                return this._EmploymentPersonnelNumber;
            }
            set
            {
                this.OnEmploymentPersonnelNumberChanging(value);
                this._EmploymentPersonnelNumber = value;
                this.OnEmploymentPersonnelNumberChanged();
                this.OnPropertyChanged("EmploymentPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmploymentPersonnelNumber;
        partial void OnEmploymentPersonnelNumberChanging(string value);
        partial void OnEmploymentPersonnelNumberChanged();
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
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
        /// There are no comments for Property ProcessHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessHeader")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcessHeader is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProcessHeader ProcessHeader
        {
            get
            {
                return this._ProcessHeader;
            }
            set
            {
                this.OnProcessHeaderChanging(value);
                this._ProcessHeader = value;
                this.OnProcessHeaderChanged();
                this.OnPropertyChanged("ProcessHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProcessHeader _ProcessHeader;
        partial void OnProcessHeaderChanging(global::Microsoft.Dynamics.DataEntities.ProcessHeader value);
        partial void OnProcessHeaderChanged();
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
