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
    /// There are no comments for RecruitingRequestPositionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequestPositionSingle")]
    public partial class RecruitingRequestPositionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingRequestPosition>
    {
        /// <summary>
        /// Initialize a new RecruitingRequestPositionSingle object.
        /// </summary>
        public RecruitingRequestPositionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RecruitingRequestPositionSingle object.
        /// </summary>
        public RecruitingRequestPositionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RecruitingRequestPositionSingle object.
        /// </summary>
        public RecruitingRequestPositionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RecruitingRequestPosition> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReportsToPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToPosition")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single ReportsToPosition
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReportsToPosition == null))
                {
                    this._ReportsToPosition = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("ReportsToPosition"));
                }
                return this._ReportsToPosition;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _ReportsToPosition;
        /// <summary>
        /// There are no comments for Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Position")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single Position
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Position == null))
                {
                    this._Position = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("Position"));
                }
                return this._Position;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _Position;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for RecruitingRequest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequest")]
        public virtual global::Microsoft.Dynamics.DataEntities.RecruitingRequestSingle RecruitingRequest
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RecruitingRequest == null))
                {
                    this._RecruitingRequest = new global::Microsoft.Dynamics.DataEntities.RecruitingRequestSingle(this.Context, GetPath("RecruitingRequest"));
                }
                return this._RecruitingRequest;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RecruitingRequestSingle _RecruitingRequest;
        /// <summary>
        /// There are no comments for PositionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionType")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionTypeSingle PositionType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionType == null))
                {
                    this._PositionType = new global::Microsoft.Dynamics.DataEntities.PositionTypeSingle(this.Context, GetPath("PositionType"));
                }
                return this._PositionType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionTypeSingle _PositionType;
        /// <summary>
        /// There are no comments for ReportsToWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle ReportsToWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReportsToWorker == null))
                {
                    this._ReportsToWorker = new global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle(this.Context, GetPath("ReportsToWorker"));
                }
                return this._ReportsToWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle _ReportsToWorker;
    }
    /// <summary>
    /// There are no comments for RecruitingRequestPosition in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RecruitingRequestId
    /// PositionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecruitingRequestId", "PositionId")]
    [global::Microsoft.OData.Client.EntitySet("RecruitingRequestPositions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequestPosition")]
    public partial class RecruitingRequestPosition : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RecruitingRequestPosition object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="recruitingRequestId">Initial value of RecruitingRequestId.</param>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="recruitingRequest">Initial value of RecruitingRequest.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RecruitingRequestPosition CreateRecruitingRequestPosition(string dataAreaId, string recruitingRequestId, string positionId, global::Microsoft.Dynamics.DataEntities.PositionV2 position, global::Microsoft.Dynamics.DataEntities.RecruitingRequest recruitingRequest)
        {
            RecruitingRequestPosition recruitingRequestPosition = new RecruitingRequestPosition();
            recruitingRequestPosition.DataAreaId = dataAreaId;
            recruitingRequestPosition.RecruitingRequestId = recruitingRequestId;
            recruitingRequestPosition.PositionId = positionId;
            if ((position == null))
            {
                throw new global::System.ArgumentNullException("position");
            }
            recruitingRequestPosition.Position = position;
            if ((recruitingRequest == null))
            {
                throw new global::System.ArgumentNullException("recruitingRequest");
            }
            recruitingRequestPosition.RecruitingRequest = recruitingRequest;
            return recruitingRequestPosition;
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
        /// There are no comments for Property RecruitingRequestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequestId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecruitingRequestId is required.")]
        public virtual string RecruitingRequestId
        {
            get
            {
                return this._RecruitingRequestId;
            }
            set
            {
                this.OnRecruitingRequestIdChanging(value);
                this._RecruitingRequestId = value;
                this.OnRecruitingRequestIdChanged();
                this.OnPropertyChanged("RecruitingRequestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecruitingRequestId;
        partial void OnRecruitingRequestIdChanging(string value);
        partial void OnRecruitingRequestIdChanged();
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PositionId is required.")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property FinancialDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FinancialDimension")]
        public virtual string FinancialDimension
        {
            get
            {
                return this._FinancialDimension;
            }
            set
            {
                this.OnFinancialDimensionChanging(value);
                this._FinancialDimension = value;
                this.OnFinancialDimensionChanged();
                this.OnPropertyChanged("FinancialDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FinancialDimension;
        partial void OnFinancialDimensionChanging(string value);
        partial void OnFinancialDimensionChanged();
        /// <summary>
        /// There are no comments for Property PositionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionTypeId")]
        public virtual string PositionTypeId
        {
            get
            {
                return this._PositionTypeId;
            }
            set
            {
                this.OnPositionTypeIdChanging(value);
                this._PositionTypeId = value;
                this.OnPositionTypeIdChanged();
                this.OnPropertyChanged("PositionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionTypeId;
        partial void OnPositionTypeIdChanging(string value);
        partial void OnPositionTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmRecruitingRequestPositionStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmRecruitingRequestPositionStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmRecruitingRequestPositionStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ReportsToPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToPersonnelNumber")]
        public virtual string ReportsToPersonnelNumber
        {
            get
            {
                return this._ReportsToPersonnelNumber;
            }
            set
            {
                this.OnReportsToPersonnelNumberChanging(value);
                this._ReportsToPersonnelNumber = value;
                this.OnReportsToPersonnelNumberChanged();
                this.OnPropertyChanged("ReportsToPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportsToPersonnelNumber;
        partial void OnReportsToPersonnelNumberChanging(string value);
        partial void OnReportsToPersonnelNumberChanged();
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
        /// There are no comments for Property ReportsToPositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToPositionId")]
        public virtual string ReportsToPositionId
        {
            get
            {
                return this._ReportsToPositionId;
            }
            set
            {
                this.OnReportsToPositionIdChanging(value);
                this._ReportsToPositionId = value;
                this.OnReportsToPositionIdChanged();
                this.OnPropertyChanged("ReportsToPositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportsToPositionId;
        partial void OnReportsToPositionIdChanging(string value);
        partial void OnReportsToPositionIdChanged();
        /// <summary>
        /// There are no comments for Property DepartmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepartmentNumber")]
        public virtual string DepartmentNumber
        {
            get
            {
                return this._DepartmentNumber;
            }
            set
            {
                this.OnDepartmentNumberChanging(value);
                this._DepartmentNumber = value;
                this.OnDepartmentNumberChanged();
                this.OnPropertyChanged("DepartmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentNumber;
        partial void OnDepartmentNumberChanging(string value);
        partial void OnDepartmentNumberChanged();
        /// <summary>
        /// There are no comments for Property ReportsToPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToPosition")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 ReportsToPosition
        {
            get
            {
                return this._ReportsToPosition;
            }
            set
            {
                this.OnReportsToPositionChanging(value);
                this._ReportsToPosition = value;
                this.OnReportsToPositionChanged();
                this.OnPropertyChanged("ReportsToPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _ReportsToPosition;
        partial void OnReportsToPositionChanging(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnReportsToPositionChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Position")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Position is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _Position;
        partial void OnPositionChanging(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property RecruitingRequest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecruitingRequest")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecruitingRequest is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RecruitingRequest RecruitingRequest
        {
            get
            {
                return this._RecruitingRequest;
            }
            set
            {
                this.OnRecruitingRequestChanging(value);
                this._RecruitingRequest = value;
                this.OnRecruitingRequestChanged();
                this.OnPropertyChanged("RecruitingRequest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RecruitingRequest _RecruitingRequest;
        partial void OnRecruitingRequestChanging(global::Microsoft.Dynamics.DataEntities.RecruitingRequest value);
        partial void OnRecruitingRequestChanged();
        /// <summary>
        /// There are no comments for Property PositionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionType")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionType PositionType
        {
            get
            {
                return this._PositionType;
            }
            set
            {
                this.OnPositionTypeChanging(value);
                this._PositionType = value;
                this.OnPositionTypeChanged();
                this.OnPropertyChanged("PositionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionType _PositionType;
        partial void OnPositionTypeChanging(global::Microsoft.Dynamics.DataEntities.PositionType value);
        partial void OnPositionTypeChanged();
        /// <summary>
        /// There are no comments for Property ReportsToWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsToWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorker ReportsToWorker
        {
            get
            {
                return this._ReportsToWorker;
            }
            set
            {
                this.OnReportsToWorkerChanging(value);
                this._ReportsToWorker = value;
                this.OnReportsToWorkerChanged();
                this.OnPropertyChanged("ReportsToWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorker _ReportsToWorker;
        partial void OnReportsToWorkerChanging(global::Microsoft.Dynamics.DataEntities.BaseWorker value);
        partial void OnReportsToWorkerChanged();
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
