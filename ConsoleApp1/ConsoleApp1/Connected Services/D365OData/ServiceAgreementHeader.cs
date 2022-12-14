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
    /// There are no comments for ServiceAgreementHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementHeaderSingle")]
    public partial class ServiceAgreementHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ServiceAgreementHeader>
    {
        /// <summary>
        /// Initialize a new ServiceAgreementHeaderSingle object.
        /// </summary>
        public ServiceAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ServiceAgreementHeaderSingle object.
        /// </summary>
        public ServiceAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ServiceAgreementHeaderSingle object.
        /// </summary>
        public ServiceAgreementHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ServiceAgreementHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PreferredTechnicianWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PreferredTechnicianWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle PreferredTechnicianWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PreferredTechnicianWorker == null))
                {
                    this._PreferredTechnicianWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("PreferredTechnicianWorker"));
                }
                return this._PreferredTechnicianWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _PreferredTechnicianWorker;
        /// <summary>
        /// There are no comments for ContactPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPerson")]
        public virtual global::Microsoft.Dynamics.DataEntities.ContactPersonSingle ContactPerson
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ContactPerson == null))
                {
                    this._ContactPerson = new global::Microsoft.Dynamics.DataEntities.ContactPersonSingle(this.Context, GetPath("ContactPerson"));
                }
                return this._ContactPerson;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ContactPersonSingle _ContactPerson;
        /// <summary>
        /// There are no comments for Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Project")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectSingle Project
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Project == null))
                {
                    this._Project = new global::Microsoft.Dynamics.DataEntities.ProjectSingle(this.Context, GetPath("Project"));
                }
                return this._Project;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectSingle _Project;
        /// <summary>
        /// There are no comments for ServiceOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader> ServiceOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ServiceOrderHeaders == null))
                {
                    this._ServiceOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader>(GetPath("ServiceOrderHeaders"));
                }
                return this._ServiceOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader> _ServiceOrderHeaders;
        /// <summary>
        /// There are no comments for ServiceAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementLines")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine> ServiceAgreementLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ServiceAgreementLines == null))
                {
                    this._ServiceAgreementLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine>(GetPath("ServiceAgreementLines"));
                }
                return this._ServiceAgreementLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine> _ServiceAgreementLines;
        /// <summary>
        /// There are no comments for ServiceOrderLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceOrderLines")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine> ServiceOrderLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ServiceOrderLines == null))
                {
                    this._ServiceOrderLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine>(GetPath("ServiceOrderLines"));
                }
                return this._ServiceOrderLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine> _ServiceOrderLines;
    }
    /// <summary>
    /// There are no comments for ServiceAgreementHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ServiceAgreementId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ServiceAgreementId")]
    [global::Microsoft.OData.Client.EntitySet("ServiceAgreementHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementHeader")]
    public partial class ServiceAgreementHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ServiceAgreementHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="serviceAgreementId">Initial value of ServiceAgreementId.</param>
        /// <param name="serviceAgreementStartDate">Initial value of ServiceAgreementStartDate.</param>
        /// <param name="serviceAgreementEndDate">Initial value of ServiceAgreementEndDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ServiceAgreementHeader CreateServiceAgreementHeader(string dataAreaId, string serviceAgreementId, global::System.DateTimeOffset serviceAgreementStartDate, global::System.DateTimeOffset serviceAgreementEndDate)
        {
            ServiceAgreementHeader serviceAgreementHeader = new ServiceAgreementHeader();
            serviceAgreementHeader.DataAreaId = dataAreaId;
            serviceAgreementHeader.ServiceAgreementId = serviceAgreementId;
            serviceAgreementHeader.ServiceAgreementStartDate = serviceAgreementStartDate;
            serviceAgreementHeader.ServiceAgreementEndDate = serviceAgreementEndDate;
            return serviceAgreementHeader;
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
        /// There are no comments for Property ServiceAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ServiceAgreementId is required.")]
        public virtual string ServiceAgreementId
        {
            get
            {
                return this._ServiceAgreementId;
            }
            set
            {
                this.OnServiceAgreementIdChanging(value);
                this._ServiceAgreementId = value;
                this.OnServiceAgreementIdChanged();
                this.OnPropertyChanged("ServiceAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceAgreementId;
        partial void OnServiceAgreementIdChanging(string value);
        partial void OnServiceAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementDescription")]
        public virtual string ServiceAgreementDescription
        {
            get
            {
                return this._ServiceAgreementDescription;
            }
            set
            {
                this.OnServiceAgreementDescriptionChanging(value);
                this._ServiceAgreementDescription = value;
                this.OnServiceAgreementDescriptionChanged();
                this.OnPropertyChanged("ServiceAgreementDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceAgreementDescription;
        partial void OnServiceAgreementDescriptionChanging(string value);
        partial void OnServiceAgreementDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PreferredTechnicianPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreferredTechnicianPersonnelNumber")]
        public virtual string PreferredTechnicianPersonnelNumber
        {
            get
            {
                return this._PreferredTechnicianPersonnelNumber;
            }
            set
            {
                this.OnPreferredTechnicianPersonnelNumberChanging(value);
                this._PreferredTechnicianPersonnelNumber = value;
                this.OnPreferredTechnicianPersonnelNumberChanged();
                this.OnPropertyChanged("PreferredTechnicianPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PreferredTechnicianPersonnelNumber;
        partial void OnPreferredTechnicianPersonnelNumberChanging(string value);
        partial void OnPreferredTechnicianPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementTemplateGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementTemplateGroupId")]
        public virtual string ServiceAgreementTemplateGroupId
        {
            get
            {
                return this._ServiceAgreementTemplateGroupId;
            }
            set
            {
                this.OnServiceAgreementTemplateGroupIdChanging(value);
                this._ServiceAgreementTemplateGroupId = value;
                this.OnServiceAgreementTemplateGroupIdChanged();
                this.OnPropertyChanged("ServiceAgreementTemplateGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceAgreementTemplateGroupId;
        partial void OnServiceAgreementTemplateGroupIdChanging(string value);
        partial void OnServiceAgreementTemplateGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementStartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ServiceAgreementStartDate is required.")]
        public virtual global::System.DateTimeOffset ServiceAgreementStartDate
        {
            get
            {
                return this._ServiceAgreementStartDate;
            }
            set
            {
                this.OnServiceAgreementStartDateChanging(value);
                this._ServiceAgreementStartDate = value;
                this.OnServiceAgreementStartDateChanged();
                this.OnPropertyChanged("ServiceAgreementStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ServiceAgreementStartDate;
        partial void OnServiceAgreementStartDateChanging(global::System.DateTimeOffset value);
        partial void OnServiceAgreementStartDateChanged();
        /// <summary>
        /// There are no comments for Property ServiceLevelAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceLevelAgreementId")]
        public virtual string ServiceLevelAgreementId
        {
            get
            {
                return this._ServiceLevelAgreementId;
            }
            set
            {
                this.OnServiceLevelAgreementIdChanging(value);
                this._ServiceLevelAgreementId = value;
                this.OnServiceLevelAgreementIdChanged();
                this.OnPropertyChanged("ServiceLevelAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceLevelAgreementId;
        partial void OnServiceLevelAgreementIdChanging(string value);
        partial void OnServiceLevelAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property ContactPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPersonId")]
        public virtual string ContactPersonId
        {
            get
            {
                return this._ContactPersonId;
            }
            set
            {
                this.OnContactPersonIdChanging(value);
                this._ContactPersonId = value;
                this.OnContactPersonIdChanged();
                this.OnPropertyChanged("ContactPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactPersonId;
        partial void OnContactPersonIdChanging(string value);
        partial void OnContactPersonIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultLineActivityTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultLineActivityTypeId")]
        public virtual string DefaultLineActivityTypeId
        {
            get
            {
                return this._DefaultLineActivityTypeId;
            }
            set
            {
                this.OnDefaultLineActivityTypeIdChanging(value);
                this._DefaultLineActivityTypeId = value;
                this.OnDefaultLineActivityTypeIdChanged();
                this.OnPropertyChanged("DefaultLineActivityTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultLineActivityTypeId;
        partial void OnDefaultLineActivityTypeIdChanging(string value);
        partial void OnDefaultLineActivityTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectId")]
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
        /// There are no comments for Property ProjectCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectCustomerAccountNumber")]
        public virtual string ProjectCustomerAccountNumber
        {
            get
            {
                return this._ProjectCustomerAccountNumber;
            }
            set
            {
                this.OnProjectCustomerAccountNumberChanging(value);
                this._ProjectCustomerAccountNumber = value;
                this.OnProjectCustomerAccountNumberChanged();
                this.OnPropertyChanged("ProjectCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectCustomerAccountNumber;
        partial void OnProjectCustomerAccountNumberChanging(string value);
        partial void OnProjectCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementEndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ServiceAgreementEndDate is required.")]
        public virtual global::System.DateTimeOffset ServiceAgreementEndDate
        {
            get
            {
                return this._ServiceAgreementEndDate;
            }
            set
            {
                this.OnServiceAgreementEndDateChanging(value);
                this._ServiceAgreementEndDate = value;
                this.OnServiceAgreementEndDateChanged();
                this.OnPropertyChanged("ServiceAgreementEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ServiceAgreementEndDate;
        partial void OnServiceAgreementEndDateChanging(global::System.DateTimeOffset value);
        partial void OnServiceAgreementEndDateChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementGroupId")]
        public virtual string ServiceAgreementGroupId
        {
            get
            {
                return this._ServiceAgreementGroupId;
            }
            set
            {
                this.OnServiceAgreementGroupIdChanging(value);
                this._ServiceAgreementGroupId = value;
                this.OnServiceAgreementGroupIdChanged();
                this.OnPropertyChanged("ServiceAgreementGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceAgreementGroupId;
        partial void OnServiceAgreementGroupIdChanging(string value);
        partial void OnServiceAgreementGroupIdChanged();
        /// <summary>
        /// There are no comments for Property IsAgreementSuspended in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAgreementSuspended")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAgreementSuspended
        {
            get
            {
                return this._IsAgreementSuspended;
            }
            set
            {
                this.OnIsAgreementSuspendedChanging(value);
                this._IsAgreementSuspended = value;
                this.OnIsAgreementSuspendedChanged();
                this.OnPropertyChanged("IsAgreementSuspended");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAgreementSuspended;
        partial void OnIsAgreementSuspendedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAgreementSuspendedChanged();
        /// <summary>
        /// There are no comments for Property ServiceResponsiblePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceResponsiblePersonnelNumber")]
        public virtual string ServiceResponsiblePersonnelNumber
        {
            get
            {
                return this._ServiceResponsiblePersonnelNumber;
            }
            set
            {
                this.OnServiceResponsiblePersonnelNumberChanging(value);
                this._ServiceResponsiblePersonnelNumber = value;
                this.OnServiceResponsiblePersonnelNumberChanged();
                this.OnPropertyChanged("ServiceResponsiblePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceResponsiblePersonnelNumber;
        partial void OnServiceResponsiblePersonnelNumberChanging(string value);
        partial void OnServiceResponsiblePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property CombineServiceOrderMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CombineServiceOrderMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SMAGroupServiceOrder> CombineServiceOrderMethod
        {
            get
            {
                return this._CombineServiceOrderMethod;
            }
            set
            {
                this.OnCombineServiceOrderMethodChanging(value);
                this._CombineServiceOrderMethod = value;
                this.OnCombineServiceOrderMethodChanged();
                this.OnPropertyChanged("CombineServiceOrderMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SMAGroupServiceOrder> _CombineServiceOrderMethod;
        partial void OnCombineServiceOrderMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SMAGroupServiceOrder> value);
        partial void OnCombineServiceOrderMethodChanged();
        /// <summary>
        /// There are no comments for Property PreferredTechnicianWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreferredTechnicianWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker PreferredTechnicianWorker
        {
            get
            {
                return this._PreferredTechnicianWorker;
            }
            set
            {
                this.OnPreferredTechnicianWorkerChanging(value);
                this._PreferredTechnicianWorker = value;
                this.OnPreferredTechnicianWorkerChanged();
                this.OnPropertyChanged("PreferredTechnicianWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _PreferredTechnicianWorker;
        partial void OnPreferredTechnicianWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnPreferredTechnicianWorkerChanged();
        /// <summary>
        /// There are no comments for Property ContactPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPerson")]
        public virtual global::Microsoft.Dynamics.DataEntities.ContactPerson ContactPerson
        {
            get
            {
                return this._ContactPerson;
            }
            set
            {
                this.OnContactPersonChanging(value);
                this._ContactPerson = value;
                this.OnContactPersonChanged();
                this.OnPropertyChanged("ContactPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ContactPerson _ContactPerson;
        partial void OnContactPersonChanging(global::Microsoft.Dynamics.DataEntities.ContactPerson value);
        partial void OnContactPersonChanged();
        /// <summary>
        /// There are no comments for Property Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Project")]
        public virtual global::Microsoft.Dynamics.DataEntities.Project Project
        {
            get
            {
                return this._Project;
            }
            set
            {
                this.OnProjectChanging(value);
                this._Project = value;
                this.OnProjectChanged();
                this.OnPropertyChanged("Project");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Project _Project;
        partial void OnProjectChanging(global::Microsoft.Dynamics.DataEntities.Project value);
        partial void OnProjectChanged();
        /// <summary>
        /// There are no comments for Property ServiceOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader> ServiceOrderHeaders
        {
            get
            {
                return this._ServiceOrderHeaders;
            }
            set
            {
                this.OnServiceOrderHeadersChanging(value);
                this._ServiceOrderHeaders = value;
                this.OnServiceOrderHeadersChanged();
                this.OnPropertyChanged("ServiceOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader> _ServiceOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnServiceOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderHeader> value);
        partial void OnServiceOrderHeadersChanged();
        /// <summary>
        /// There are no comments for Property ServiceAgreementLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceAgreementLines")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine> ServiceAgreementLines
        {
            get
            {
                return this._ServiceAgreementLines;
            }
            set
            {
                this.OnServiceAgreementLinesChanging(value);
                this._ServiceAgreementLines = value;
                this.OnServiceAgreementLinesChanged();
                this.OnPropertyChanged("ServiceAgreementLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine> _ServiceAgreementLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnServiceAgreementLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceAgreementLine> value);
        partial void OnServiceAgreementLinesChanged();
        /// <summary>
        /// There are no comments for Property ServiceOrderLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceOrderLines")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine> ServiceOrderLines
        {
            get
            {
                return this._ServiceOrderLines;
            }
            set
            {
                this.OnServiceOrderLinesChanging(value);
                this._ServiceOrderLines = value;
                this.OnServiceOrderLinesChanged();
                this.OnPropertyChanged("ServiceOrderLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine> _ServiceOrderLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnServiceOrderLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ServiceOrderLine> value);
        partial void OnServiceOrderLinesChanged();
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
