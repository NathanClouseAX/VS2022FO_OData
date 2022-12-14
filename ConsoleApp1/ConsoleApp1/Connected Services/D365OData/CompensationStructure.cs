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
    /// There are no comments for CompensationStructureSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationStructureSingle")]
    public partial class CompensationStructureSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationStructure>
    {
        /// <summary>
        /// Initialize a new CompensationStructureSingle object.
        /// </summary>
        public CompensationStructureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationStructureSingle object.
        /// </summary>
        public CompensationStructureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationStructureSingle object.
        /// </summary>
        public CompensationStructureSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationStructure> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for CompensationGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationGrid")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationGridSingle CompensationGrid
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationGrid == null))
                {
                    this._CompensationGrid = new global::Microsoft.Dynamics.DataEntities.CompensationGridSingle(this.Context, GetPath("CompensationGrid"));
                }
                return this._CompensationGrid;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationGridSingle _CompensationGrid;
        /// <summary>
        /// There are no comments for ReferencePointSetupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferencePointSetupLine")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLineSingle ReferencePointSetupLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReferencePointSetupLine == null))
                {
                    this._ReferencePointSetupLine = new global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLineSingle(this.Context, GetPath("ReferencePointSetupLine"));
                }
                return this._ReferencePointSetupLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLineSingle _ReferencePointSetupLine;
    }
    /// <summary>
    /// There are no comments for CompensationStructure in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Grid
    /// LevelId
    /// ReferencePoint
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Grid", "LevelId", "ReferencePoint")]
    [global::Microsoft.OData.Client.EntitySet("CompensationStructures")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationStructure")]
    public partial class CompensationStructure : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationStructure object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="grid">Initial value of Grid.</param>
        /// <param name="levelId">Initial value of LevelId.</param>
        /// <param name="referencePoint">Initial value of ReferencePoint.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationStructure CreateCompensationStructure(string dataAreaId, string grid, string levelId, string referencePoint, decimal amount)
        {
            CompensationStructure compensationStructure = new CompensationStructure();
            compensationStructure.DataAreaId = dataAreaId;
            compensationStructure.Grid = grid;
            compensationStructure.LevelId = levelId;
            compensationStructure.ReferencePoint = referencePoint;
            compensationStructure.Amount = amount;
            return compensationStructure;
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
        /// There are no comments for Property Grid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Grid")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Grid is required.")]
        public virtual string Grid
        {
            get
            {
                return this._Grid;
            }
            set
            {
                this.OnGridChanging(value);
                this._Grid = value;
                this.OnGridChanged();
                this.OnPropertyChanged("Grid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Grid;
        partial void OnGridChanging(string value);
        partial void OnGridChanged();
        /// <summary>
        /// There are no comments for Property LevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LevelId is required.")]
        public virtual string LevelId
        {
            get
            {
                return this._LevelId;
            }
            set
            {
                this.OnLevelIdChanging(value);
                this._LevelId = value;
                this.OnLevelIdChanged();
                this.OnPropertyChanged("LevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LevelId;
        partial void OnLevelIdChanging(string value);
        partial void OnLevelIdChanged();
        /// <summary>
        /// There are no comments for Property ReferencePoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferencePoint")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferencePoint is required.")]
        public virtual string ReferencePoint
        {
            get
            {
                return this._ReferencePoint;
            }
            set
            {
                this.OnReferencePointChanging(value);
                this._ReferencePoint = value;
                this.OnReferencePointChanged();
                this.OnPropertyChanged("ReferencePoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferencePoint;
        partial void OnReferencePointChanging(string value);
        partial void OnReferencePointChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property ReferenceSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceSetup")]
        public virtual string ReferenceSetup
        {
            get
            {
                return this._ReferenceSetup;
            }
            set
            {
                this.OnReferenceSetupChanging(value);
                this._ReferenceSetup = value;
                this.OnReferenceSetupChanged();
                this.OnPropertyChanged("ReferenceSetup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceSetup;
        partial void OnReferenceSetupChanging(string value);
        partial void OnReferenceSetupChanged();
        /// <summary>
        /// There are no comments for Property CompensationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationLevel")]
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
        /// There are no comments for Property CompensationGrid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationGrid")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationGrid CompensationGrid
        {
            get
            {
                return this._CompensationGrid;
            }
            set
            {
                this.OnCompensationGridChanging(value);
                this._CompensationGrid = value;
                this.OnCompensationGridChanged();
                this.OnPropertyChanged("CompensationGrid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationGrid _CompensationGrid;
        partial void OnCompensationGridChanging(global::Microsoft.Dynamics.DataEntities.CompensationGrid value);
        partial void OnCompensationGridChanged();
        /// <summary>
        /// There are no comments for Property ReferencePointSetupLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferencePointSetupLine")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine ReferencePointSetupLine
        {
            get
            {
                return this._ReferencePointSetupLine;
            }
            set
            {
                this.OnReferencePointSetupLineChanging(value);
                this._ReferencePointSetupLine = value;
                this.OnReferencePointSetupLineChanged();
                this.OnPropertyChanged("ReferencePointSetupLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine _ReferencePointSetupLine;
        partial void OnReferencePointSetupLineChanging(global::Microsoft.Dynamics.DataEntities.CompensationReferencePointSetupLine value);
        partial void OnReferencePointSetupLineChanged();
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
