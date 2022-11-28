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
    /// There are no comments for TitleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TitleSingle")]
    public partial class TitleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Title>
    {
        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TitleSingle object.
        /// </summary>
        public TitleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Title> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Workers")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Workers == null))
                {
                    this._Workers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Worker>(GetPath("Workers"));
                }
                return this._Workers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> _Workers;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employees == null))
                {
                    this._Employees = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Employee>(GetPath("Employees"));
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> _Employees;
        /// <summary>
        /// There are no comments for ContractorsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractorsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ContractorV2> ContractorsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ContractorsV2 == null))
                {
                    this._ContractorsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ContractorV2>(GetPath("ContractorsV2"));
                }
                return this._ContractorsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ContractorV2> _ContractorsV2;
        /// <summary>
        /// There are no comments for PositionDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PositionDetail> PositionDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionDetails == null))
                {
                    this._PositionDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PositionDetail>(GetPath("PositionDetails"));
                }
                return this._PositionDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PositionDetail> _PositionDetails;
        /// <summary>
        /// There are no comments for WorkerTitles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTitles")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary> WorkerTitles
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerTitles == null))
                {
                    this._WorkerTitles = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary>(GetPath("WorkerTitles"));
                }
                return this._WorkerTitles;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerSummary> _WorkerTitles;
        /// <summary>
        /// There are no comments for Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Contractors")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Contractors == null))
                {
                    this._Contractors = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Contractor>(GetPath("Contractors"));
                }
                return this._Contractors;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors;
        /// <summary>
        /// There are no comments for Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Jobs")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Jobs == null))
                {
                    this._Jobs = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Job>(GetPath("Jobs"));
                }
                return this._Jobs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Job> _Jobs;
        /// <summary>
        /// There are no comments for EmployeesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeesV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmployeeV2> EmployeesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmployeesV2 == null))
                {
                    this._EmployeesV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmployeeV2>(GetPath("EmployeesV2"));
                }
                return this._EmployeesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmployeeV2> _EmployeesV2;
        /// <summary>
        /// There are no comments for Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Positions")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Positions == null))
                {
                    this._Positions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Position>(GetPath("Positions"));
                }
                return this._Positions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> _Positions;
        /// <summary>
        /// There are no comments for PositionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PositionV2> PositionsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionsV2 == null))
                {
                    this._PositionsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PositionV2>(GetPath("PositionsV2"));
                }
                return this._PositionsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PositionV2> _PositionsV2;
        /// <summary>
        /// There are no comments for RecruitingRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> RecruitingRequests
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingRequests == null))
                {
                    this._RecruitingRequests = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest>(GetPath("RecruitingRequests"));
                }
                return this._RecruitingRequests;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> _RecruitingRequests;
        /// <summary>
        /// There are no comments for WorkerTitleCurrent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTitleCurrent")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent> WorkerTitleCurrent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerTitleCurrent == null))
                {
                    this._WorkerTitleCurrent = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent>(GetPath("WorkerTitleCurrent"));
                }
                return this._WorkerTitleCurrent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent> _WorkerTitleCurrent;
    }
    /// <summary>
    /// There are no comments for Title in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TitleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TitleId")]
    [global::Microsoft.OData.Client.EntitySet("Titles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Title")]
    public partial class Title : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Title object.
        /// </summary>
        /// <param name="titleId">Initial value of TitleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Title CreateTitle(string titleId)
        {
            Title title = new Title();
            title.TitleId = titleId;
            return title;
        }
        /// <summary>
        /// There are no comments for Property TitleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TitleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TitleId is required.")]
        public virtual string TitleId
        {
            get
            {
                return this._TitleId;
            }
            set
            {
                this.OnTitleIdChanging(value);
                this._TitleId = value;
                this.OnTitleIdChanged();
                this.OnPropertyChanged("TitleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TitleId;
        partial void OnTitleIdChanging(string value);
        partial void OnTitleIdChanged();
        /// <summary>
        /// There are no comments for Property Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Workers")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                return this._Workers;
            }
            set
            {
                this.OnWorkersChanging(value);
                this._Workers = value;
                this.OnWorkersChanged();
                this.OnPropertyChanged("Workers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> _Workers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> value);
        partial void OnWorkersChanged();
        /// <summary>
        /// There are no comments for Property Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Employees")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this.OnEmployeesChanging(value);
                this._Employees = value;
                this.OnEmployeesChanged();
                this.OnPropertyChanged("Employees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> _Employees = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> value);
        partial void OnEmployeesChanged();
        /// <summary>
        /// There are no comments for Property ContractorsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractorsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ContractorV2> ContractorsV2
        {
            get
            {
                return this._ContractorsV2;
            }
            set
            {
                this.OnContractorsV2Changing(value);
                this._ContractorsV2 = value;
                this.OnContractorsV2Changed();
                this.OnPropertyChanged("ContractorsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ContractorV2> _ContractorsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ContractorV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContractorsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ContractorV2> value);
        partial void OnContractorsV2Changed();
        /// <summary>
        /// There are no comments for Property PositionDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionDetail> PositionDetails
        {
            get
            {
                return this._PositionDetails;
            }
            set
            {
                this.OnPositionDetailsChanging(value);
                this._PositionDetails = value;
                this.OnPositionDetailsChanged();
                this.OnPropertyChanged("PositionDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionDetail> _PositionDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionDetail> value);
        partial void OnPositionDetailsChanged();
        /// <summary>
        /// There are no comments for Property WorkerTitles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTitles")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> WorkerTitles
        {
            get
            {
                return this._WorkerTitles;
            }
            set
            {
                this.OnWorkerTitlesChanging(value);
                this._WorkerTitles = value;
                this.OnWorkerTitlesChanged();
                this.OnPropertyChanged("WorkerTitles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> _WorkerTitles = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerTitlesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerSummary> value);
        partial void OnWorkerTitlesChanged();
        /// <summary>
        /// There are no comments for Property Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Contractors")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                return this._Contractors;
            }
            set
            {
                this.OnContractorsChanging(value);
                this._Contractors = value;
                this.OnContractorsChanged();
                this.OnPropertyChanged("Contractors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContractorsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> value);
        partial void OnContractorsChanged();
        /// <summary>
        /// There are no comments for Property Jobs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Jobs")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> Jobs
        {
            get
            {
                return this._Jobs;
            }
            set
            {
                this.OnJobsChanging(value);
                this._Jobs = value;
                this.OnJobsChanged();
                this.OnPropertyChanged("Jobs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> _Jobs = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Job> value);
        partial void OnJobsChanged();
        /// <summary>
        /// There are no comments for Property EmployeesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeesV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmployeeV2> EmployeesV2
        {
            get
            {
                return this._EmployeesV2;
            }
            set
            {
                this.OnEmployeesV2Changing(value);
                this._EmployeesV2 = value;
                this.OnEmployeesV2Changed();
                this.OnPropertyChanged("EmployeesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmployeeV2> _EmployeesV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmployeeV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmployeeV2> value);
        partial void OnEmployeesV2Changed();
        /// <summary>
        /// There are no comments for Property Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Positions")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                return this._Positions;
            }
            set
            {
                this.OnPositionsChanging(value);
                this._Positions = value;
                this.OnPositionsChanged();
                this.OnPropertyChanged("Positions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> _Positions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> value);
        partial void OnPositionsChanged();
        /// <summary>
        /// There are no comments for Property PositionsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionV2> PositionsV2
        {
            get
            {
                return this._PositionsV2;
            }
            set
            {
                this.OnPositionsV2Changing(value);
                this._PositionsV2 = value;
                this.OnPositionsV2Changed();
                this.OnPropertyChanged("PositionsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionV2> _PositionsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PositionV2> value);
        partial void OnPositionsV2Changed();
        /// <summary>
        /// There are no comments for Property RecruitingRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> RecruitingRequests
        {
            get
            {
                return this._RecruitingRequests;
            }
            set
            {
                this.OnRecruitingRequestsChanging(value);
                this._RecruitingRequests = value;
                this.OnRecruitingRequestsChanged();
                this.OnPropertyChanged("RecruitingRequests");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> _RecruitingRequests = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRecruitingRequestsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RecruitingRequest> value);
        partial void OnRecruitingRequestsChanged();
        /// <summary>
        /// There are no comments for Property WorkerTitleCurrent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTitleCurrent")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent> WorkerTitleCurrent
        {
            get
            {
                return this._WorkerTitleCurrent;
            }
            set
            {
                this.OnWorkerTitleCurrentChanging(value);
                this._WorkerTitleCurrent = value;
                this.OnWorkerTitleCurrentChanged();
                this.OnPropertyChanged("WorkerTitleCurrent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent> _WorkerTitleCurrent = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerTitleCurrentChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerTitleCurrent> value);
        partial void OnWorkerTitleCurrentChanged();
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
