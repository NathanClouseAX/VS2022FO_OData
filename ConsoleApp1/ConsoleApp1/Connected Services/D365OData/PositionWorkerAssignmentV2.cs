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
    /// There are no comments for PositionWorkerAssignmentV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PositionWorkerAssignmentV2Single")]
    public partial class PositionWorkerAssignmentV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionWorkerAssignmentV2>
    {
        /// <summary>
        /// Initialize a new PositionWorkerAssignmentV2Single object.
        /// </summary>
        public PositionWorkerAssignmentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionWorkerAssignmentV2Single object.
        /// </summary>
        public PositionWorkerAssignmentV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionWorkerAssignmentV2Single object.
        /// </summary>
        public PositionWorkerAssignmentV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionWorkerAssignmentV2> query)
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
        /// There are no comments for PayrollPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollPosition")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollPositionSingle PayrollPosition
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollPosition == null))
                {
                    this._PayrollPosition = new global::Microsoft.Dynamics.DataEntities.PayrollPositionSingle(this.Context, GetPath("PayrollPosition"));
                }
                return this._PayrollPosition;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollPositionSingle _PayrollPosition;
    }
    /// <summary>
    /// There are no comments for PositionWorkerAssignmentV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PositionId
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionId", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("PositionWorkerAssignmentsV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PositionWorkerAssignmentV2")]
    public partial class PositionWorkerAssignmentV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionWorkerAssignmentV2 object.
        /// </summary>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="worker">Initial value of Worker.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="baseWorker">Initial value of BaseWorker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionWorkerAssignmentV2 CreatePositionWorkerAssignmentV2(string positionId, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 position, 
                    global::Microsoft.Dynamics.DataEntities.BaseWorker baseWorker)
        {
            PositionWorkerAssignmentV2 positionWorkerAssignmentV2 = new PositionWorkerAssignmentV2();
            positionWorkerAssignmentV2.PositionId = positionId;
            positionWorkerAssignmentV2.ValidFrom = validFrom;
            positionWorkerAssignmentV2.ValidTo = validTo;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            positionWorkerAssignmentV2.Worker = worker;
            if ((position == null))
            {
                throw new global::System.ArgumentNullException("position");
            }
            positionWorkerAssignmentV2.Position = position;
            if ((baseWorker == null))
            {
                throw new global::System.ArgumentNullException("baseWorker");
            }
            positionWorkerAssignmentV2.BaseWorker = baseWorker;
            return positionWorkerAssignmentV2;
        }
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
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ReasonCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonCodeId")]
        public virtual string ReasonCodeId
        {
            get
            {
                return this._ReasonCodeId;
            }
            set
            {
                this.OnReasonCodeIdChanging(value);
                this._ReasonCodeId = value;
                this.OnReasonCodeIdChanged();
                this.OnPropertyChanged("ReasonCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCodeId;
        partial void OnReasonCodeIdChanging(string value);
        partial void OnReasonCodeIdChanged();
        /// <summary>
        /// There are no comments for Property IsPrimaryPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPrimaryPosition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrimaryPosition
        {
            get
            {
                return this._IsPrimaryPosition;
            }
            set
            {
                this.OnIsPrimaryPositionChanging(value);
                this._IsPrimaryPosition = value;
                this.OnIsPrimaryPositionChanged();
                this.OnPropertyChanged("IsPrimaryPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrimaryPosition;
        partial void OnIsPrimaryPositionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrimaryPositionChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
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
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
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
        /// There are no comments for Property PayrollPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollPosition")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollPosition PayrollPosition
        {
            get
            {
                return this._PayrollPosition;
            }
            set
            {
                this.OnPayrollPositionChanging(value);
                this._PayrollPosition = value;
                this.OnPayrollPositionChanged();
                this.OnPropertyChanged("PayrollPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollPosition _PayrollPosition;
        partial void OnPayrollPositionChanging(global::Microsoft.Dynamics.DataEntities.PayrollPosition value);
        partial void OnPayrollPositionChanged();
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