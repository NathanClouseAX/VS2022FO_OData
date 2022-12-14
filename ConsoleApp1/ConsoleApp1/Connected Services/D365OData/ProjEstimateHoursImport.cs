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
    /// There are no comments for ProjEstimateHoursImportSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjEstimateHoursImportSingle")]
    public partial class ProjEstimateHoursImportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjEstimateHoursImport>
    {
        /// <summary>
        /// Initialize a new ProjEstimateHoursImportSingle object.
        /// </summary>
        public ProjEstimateHoursImportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjEstimateHoursImportSingle object.
        /// </summary>
        public ProjEstimateHoursImportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjEstimateHoursImportSingle object.
        /// </summary>
        public ProjEstimateHoursImportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjEstimateHoursImport> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjEstimateHoursImport in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// EstimateHoursImportId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EstimateHoursImportId")]
    [global::Microsoft.OData.Client.EntitySet("ProjEstimateHoursImport")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjEstimateHoursImport")]
    public partial class ProjEstimateHoursImport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjEstimateHoursImport object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="estimateHoursImportId">Initial value of EstimateHoursImportId.</param>
        /// <param name="duration">Initial value of Duration.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="plannedSalesAmount">Initial value of PlannedSalesAmount.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="plannedCostAmount">Initial value of PlannedCostAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjEstimateHoursImport CreateProjEstimateHoursImport(string dataAreaId, 
                    global::System.Guid estimateHoursImportId, 
                    decimal duration, 
                    int sequenceNumber, 
                    decimal plannedSalesAmount, 
                    global::System.DateTimeOffset startDate, 
                    decimal plannedCostAmount)
        {
            ProjEstimateHoursImport projEstimateHoursImport = new ProjEstimateHoursImport();
            projEstimateHoursImport.DataAreaId = dataAreaId;
            projEstimateHoursImport.EstimateHoursImportId = estimateHoursImportId;
            projEstimateHoursImport.Duration = duration;
            projEstimateHoursImport.SequenceNumber = sequenceNumber;
            projEstimateHoursImport.PlannedSalesAmount = plannedSalesAmount;
            projEstimateHoursImport.StartDate = startDate;
            projEstimateHoursImport.PlannedCostAmount = plannedCostAmount;
            return projEstimateHoursImport;
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
        /// There are no comments for Property EstimateHoursImportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EstimateHoursImportId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EstimateHoursImportId is required.")]
        public virtual global::System.Guid EstimateHoursImportId
        {
            get
            {
                return this._EstimateHoursImportId;
            }
            set
            {
                this.OnEstimateHoursImportIdChanging(value);
                this._EstimateHoursImportId = value;
                this.OnEstimateHoursImportIdChanged();
                this.OnPropertyChanged("EstimateHoursImportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _EstimateHoursImportId;
        partial void OnEstimateHoursImportIdChanging(global::System.Guid value);
        partial void OnEstimateHoursImportIdChanged();
        /// <summary>
        /// There are no comments for Property Duration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Duration")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Duration is required.")]
        public virtual decimal Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Duration;
        partial void OnDurationChanging(decimal value);
        partial void OnDurationChanged();
        /// <summary>
        /// There are no comments for Property ResourceCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceCategoryId")]
        public virtual string ResourceCategoryId
        {
            get
            {
                return this._ResourceCategoryId;
            }
            set
            {
                this.OnResourceCategoryIdChanging(value);
                this._ResourceCategoryId = value;
                this.OnResourceCategoryIdChanged();
                this.OnPropertyChanged("ResourceCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceCategoryId;
        partial void OnResourceCategoryIdChanging(string value);
        partial void OnResourceCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceNumber is required.")]
        public virtual int SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNumber;
        partial void OnSequenceNumberChanging(int value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCategoryId")]
        public virtual string TransactionCategoryId
        {
            get
            {
                return this._TransactionCategoryId;
            }
            set
            {
                this.OnTransactionCategoryIdChanging(value);
                this._TransactionCategoryId = value;
                this.OnTransactionCategoryIdChanged();
                this.OnPropertyChanged("TransactionCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCategoryId;
        partial void OnTransactionCategoryIdChanging(string value);
        partial void OnTransactionCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property PlannedSalesAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedSalesAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlannedSalesAmount is required.")]
        public virtual decimal PlannedSalesAmount
        {
            get
            {
                return this._PlannedSalesAmount;
            }
            set
            {
                this.OnPlannedSalesAmountChanging(value);
                this._PlannedSalesAmount = value;
                this.OnPlannedSalesAmountChanged();
                this.OnPropertyChanged("PlannedSalesAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PlannedSalesAmount;
        partial void OnPlannedSalesAmountChanging(decimal value);
        partial void OnPlannedSalesAmountChanged();
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
        /// There are no comments for Property ActivityNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityNumber")]
        public virtual string ActivityNumber
        {
            get
            {
                return this._ActivityNumber;
            }
            set
            {
                this.OnActivityNumberChanging(value);
                this._ActivityNumber = value;
                this.OnActivityNumberChanged();
                this.OnPropertyChanged("ActivityNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityNumber;
        partial void OnActivityNumberChanging(string value);
        partial void OnActivityNumberChanged();
        /// <summary>
        /// There are no comments for Property PlannedCostAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedCostAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlannedCostAmount is required.")]
        public virtual decimal PlannedCostAmount
        {
            get
            {
                return this._PlannedCostAmount;
            }
            set
            {
                this.OnPlannedCostAmountChanging(value);
                this._PlannedCostAmount = value;
                this.OnPlannedCostAmountChanged();
                this.OnPropertyChanged("PlannedCostAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PlannedCostAmount;
        partial void OnPlannedCostAmountChanging(decimal value);
        partial void OnPlannedCostAmountChanged();
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
        /// There are no comments for Property ContractLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractLineId")]
        public virtual string ContractLineId
        {
            get
            {
                return this._ContractLineId;
            }
            set
            {
                this.OnContractLineIdChanging(value);
                this._ContractLineId = value;
                this.OnContractLineIdChanged();
                this.OnPropertyChanged("ContractLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContractLineId;
        partial void OnContractLineIdChanging(string value);
        partial void OnContractLineIdChanged();
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
