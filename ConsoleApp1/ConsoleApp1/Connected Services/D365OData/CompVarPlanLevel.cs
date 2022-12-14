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
    /// There are no comments for CompVarPlanLevelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevelSingle")]
    public partial class CompVarPlanLevelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompVarPlanLevel>
    {
        /// <summary>
        /// Initialize a new CompVarPlanLevelSingle object.
        /// </summary>
        public CompVarPlanLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompVarPlanLevelSingle object.
        /// </summary>
        public CompVarPlanLevelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompVarPlanLevelSingle object.
        /// </summary>
        public CompVarPlanLevelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompVarPlanLevel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompVarPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanTable")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompVarPlanTableSingle CompVarPlanTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompVarPlanTable == null))
                {
                    this._CompVarPlanTable = new global::Microsoft.Dynamics.DataEntities.CompVarPlanTableSingle(this.Context, GetPath("CompVarPlanTable"));
                }
                return this._CompVarPlanTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompVarPlanTableSingle _CompVarPlanTable;
        /// <summary>
        /// There are no comments for CompensationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevel")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationLevelSingle CompensationLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationLevel == null))
                {
                    this._CompensationLevel = new global::Microsoft.Dynamics.DataEntities.CompensationLevelSingle(this.Context, GetPath("CompensationLevel"));
                }
                return this._CompensationLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationLevelSingle _CompensationLevel;
    }
    /// <summary>
    /// There are no comments for CompVarPlanLevel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CompensationLevelId
    /// PlanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CompensationLevelId", "PlanId")]
    [global::Microsoft.OData.Client.EntitySet("CompVarPlanLevels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanLevel")]
    public partial class CompVarPlanLevel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompVarPlanLevel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="compensationLevelId">Initial value of CompensationLevelId.</param>
        /// <param name="planId">Initial value of PlanId.</param>
        /// <param name="awardPercent">Initial value of AwardPercent.</param>
        /// <param name="awardUnits">Initial value of AwardUnits.</param>
        /// <param name="awardAmount">Initial value of AwardAmount.</param>
        /// <param name="compVarPlanTable">Initial value of CompVarPlanTable.</param>
        /// <param name="compensationLevel">Initial value of CompensationLevel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompVarPlanLevel CreateCompVarPlanLevel(string dataAreaId, 
                    string compensationLevelId, 
                    string planId, 
                    decimal awardPercent, 
                    int awardUnits, 
                    decimal awardAmount, 
                    global::Microsoft.Dynamics.DataEntities.CompVarPlanTable compVarPlanTable, 
                    global::Microsoft.Dynamics.DataEntities.CompensationLevel compensationLevel)
        {
            CompVarPlanLevel compVarPlanLevel = new CompVarPlanLevel();
            compVarPlanLevel.DataAreaId = dataAreaId;
            compVarPlanLevel.CompensationLevelId = compensationLevelId;
            compVarPlanLevel.PlanId = planId;
            compVarPlanLevel.AwardPercent = awardPercent;
            compVarPlanLevel.AwardUnits = awardUnits;
            compVarPlanLevel.AwardAmount = awardAmount;
            if ((compVarPlanTable == null))
            {
                throw new global::System.ArgumentNullException("compVarPlanTable");
            }
            compVarPlanLevel.CompVarPlanTable = compVarPlanTable;
            if ((compensationLevel == null))
            {
                throw new global::System.ArgumentNullException("compensationLevel");
            }
            compVarPlanLevel.CompensationLevel = compensationLevel;
            return compVarPlanLevel;
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
        /// There are no comments for Property CompensationLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompensationLevelId is required.")]
        public virtual string CompensationLevelId
        {
            get
            {
                return this._CompensationLevelId;
            }
            set
            {
                this.OnCompensationLevelIdChanging(value);
                this._CompensationLevelId = value;
                this.OnCompensationLevelIdChanged();
                this.OnPropertyChanged("CompensationLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompensationLevelId;
        partial void OnCompensationLevelIdChanging(string value);
        partial void OnCompensationLevelIdChanged();
        /// <summary>
        /// There are no comments for Property PlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlanId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlanId is required.")]
        public virtual string PlanId
        {
            get
            {
                return this._PlanId;
            }
            set
            {
                this.OnPlanIdChanging(value);
                this._PlanId = value;
                this.OnPlanIdChanged();
                this.OnPropertyChanged("PlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlanId;
        partial void OnPlanIdChanging(string value);
        partial void OnPlanIdChanged();
        /// <summary>
        /// There are no comments for Property AwardPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardPercent is required.")]
        public virtual decimal AwardPercent
        {
            get
            {
                return this._AwardPercent;
            }
            set
            {
                this.OnAwardPercentChanging(value);
                this._AwardPercent = value;
                this.OnAwardPercentChanged();
                this.OnPropertyChanged("AwardPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AwardPercent;
        partial void OnAwardPercentChanging(decimal value);
        partial void OnAwardPercentChanged();
        /// <summary>
        /// There are no comments for Property AwardUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardUnits")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardUnits is required.")]
        public virtual int AwardUnits
        {
            get
            {
                return this._AwardUnits;
            }
            set
            {
                this.OnAwardUnitsChanging(value);
                this._AwardUnits = value;
                this.OnAwardUnitsChanged();
                this.OnPropertyChanged("AwardUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AwardUnits;
        partial void OnAwardUnitsChanging(int value);
        partial void OnAwardUnitsChanged();
        /// <summary>
        /// There are no comments for Property AwardAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AwardAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AwardAmount is required.")]
        public virtual decimal AwardAmount
        {
            get
            {
                return this._AwardAmount;
            }
            set
            {
                this.OnAwardAmountChanging(value);
                this._AwardAmount = value;
                this.OnAwardAmountChanged();
                this.OnPropertyChanged("AwardAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AwardAmount;
        partial void OnAwardAmountChanging(decimal value);
        partial void OnAwardAmountChanged();
        /// <summary>
        /// There are no comments for Property CompVarPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanTable")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompVarPlanTable is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompVarPlanTable CompVarPlanTable
        {
            get
            {
                return this._CompVarPlanTable;
            }
            set
            {
                this.OnCompVarPlanTableChanging(value);
                this._CompVarPlanTable = value;
                this.OnCompVarPlanTableChanged();
                this.OnPropertyChanged("CompVarPlanTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompVarPlanTable _CompVarPlanTable;
        partial void OnCompVarPlanTableChanging(global::Microsoft.Dynamics.DataEntities.CompVarPlanTable value);
        partial void OnCompVarPlanTableChanged();
        /// <summary>
        /// There are no comments for Property CompensationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompensationLevel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationLevel CompensationLevel
        {
            get
            {
                return this._CompensationLevel;
            }
            set
            {
                this.OnCompensationLevelChanging(value);
                this._CompensationLevel = value;
                this.OnCompensationLevelChanged();
                this.OnPropertyChanged("CompensationLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationLevel _CompensationLevel;
        partial void OnCompensationLevelChanging(global::Microsoft.Dynamics.DataEntities.CompensationLevel value);
        partial void OnCompensationLevelChanged();
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
