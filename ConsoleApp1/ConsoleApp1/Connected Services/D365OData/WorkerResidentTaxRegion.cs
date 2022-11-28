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
    /// There are no comments for WorkerResidentTaxRegionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerResidentTaxRegionSingle")]
    public partial class WorkerResidentTaxRegionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerResidentTaxRegion>
    {
        /// <summary>
        /// Initialize a new WorkerResidentTaxRegionSingle object.
        /// </summary>
        public WorkerResidentTaxRegionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkerResidentTaxRegionSingle object.
        /// </summary>
        public WorkerResidentTaxRegionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkerResidentTaxRegionSingle object.
        /// </summary>
        public WorkerResidentTaxRegionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkerResidentTaxRegion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerTaxRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTaxRegion")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle WorkerTaxRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerTaxRegion == null))
                {
                    this._WorkerTaxRegion = new global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle(this.Context, GetPath("WorkerTaxRegion"));
                }
                return this._WorkerTaxRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerTaxRegionSingle _WorkerTaxRegion;
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
    /// There are no comments for WorkerResidentTaxRegion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("WorkerResidentTaxRegions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerResidentTaxRegion")]
    public partial class WorkerResidentTaxRegion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkerResidentTaxRegion object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="workerTaxRegion">Initial value of WorkerTaxRegion.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkerResidentTaxRegion CreateWorkerResidentTaxRegion(string personnelNumber, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo, global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion workerTaxRegion, global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            WorkerResidentTaxRegion workerResidentTaxRegion = new WorkerResidentTaxRegion();
            workerResidentTaxRegion.PersonnelNumber = personnelNumber;
            workerResidentTaxRegion.ValidFrom = validFrom;
            workerResidentTaxRegion.ValidTo = validTo;
            if ((workerTaxRegion == null))
            {
                throw new global::System.ArgumentNullException("workerTaxRegion");
            }
            workerResidentTaxRegion.WorkerTaxRegion = workerTaxRegion;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            workerResidentTaxRegion.Worker = worker;
            return workerResidentTaxRegion;
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
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocationId")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property IsApplyingCourtesyWithholding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsApplyingCourtesyWithholding")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApplyingCourtesyWithholding
        {
            get
            {
                return this._IsApplyingCourtesyWithholding;
            }
            set
            {
                this.OnIsApplyingCourtesyWithholdingChanging(value);
                this._IsApplyingCourtesyWithholding = value;
                this.OnIsApplyingCourtesyWithholdingChanged();
                this.OnPropertyChanged("IsApplyingCourtesyWithholding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApplyingCourtesyWithholding;
        partial void OnIsApplyingCourtesyWithholdingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApplyingCourtesyWithholdingChanged();
        /// <summary>
        /// There are no comments for Property WorkerTaxRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkerTaxRegion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkerTaxRegion is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion WorkerTaxRegion
        {
            get
            {
                return this._WorkerTaxRegion;
            }
            set
            {
                this.OnWorkerTaxRegionChanging(value);
                this._WorkerTaxRegion = value;
                this.OnWorkerTaxRegionChanged();
                this.OnPropertyChanged("WorkerTaxRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion _WorkerTaxRegion;
        partial void OnWorkerTaxRegionChanging(global::Microsoft.Dynamics.DataEntities.WorkerTaxRegion value);
        partial void OnWorkerTaxRegionChanged();
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
