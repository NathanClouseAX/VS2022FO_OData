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
    /// There are no comments for BudgetModelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetModelSingle")]
    public partial class BudgetModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetModel>
    {
        /// <summary>
        /// Initialize a new BudgetModelSingle object.
        /// </summary>
        public BudgetModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetModelSingle object.
        /// </summary>
        public BudgetModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetModelSingle object.
        /// </summary>
        public BudgetModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetRegisterEntryBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetRegisterEntryBudgetModel")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle BudgetRegisterEntryBudgetModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryBudgetModel == null))
                {
                    this._BudgetRegisterEntryBudgetModel = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle(this.Context, GetPath("BudgetRegisterEntryBudgetModel"));
                }
                return this._BudgetRegisterEntryBudgetModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntrySingle _BudgetRegisterEntryBudgetModel;
        /// <summary>
        /// There are no comments for BudgetSubmodelBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSubmodelBudgetModel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> BudgetSubmodelBudgetModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetSubmodelBudgetModel == null))
                {
                    this._BudgetSubmodelBudgetModel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel>(GetPath("BudgetSubmodelBudgetModel"));
                }
                return this._BudgetSubmodelBudgetModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> _BudgetSubmodelBudgetModel;
        /// <summary>
        /// There are no comments for BudgetSubmodel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSubmodel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> BudgetSubmodel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetSubmodel == null))
                {
                    this._BudgetSubmodel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel>(GetPath("BudgetSubmodel"));
                }
                return this._BudgetSubmodel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> _BudgetSubmodel;
        /// <summary>
        /// There are no comments for BudgetRegisterEntryHeaderBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetRegisterEntryHeaderBudgetModel")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle BudgetRegisterEntryHeaderBudgetModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetRegisterEntryHeaderBudgetModel == null))
                {
                    this._BudgetRegisterEntryHeaderBudgetModel = new global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle(this.Context, GetPath("BudgetRegisterEntryHeaderBudgetModel"));
                }
                return this._BudgetRegisterEntryHeaderBudgetModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeaderSingle _BudgetRegisterEntryHeaderBudgetModel;
        /// <summary>
        /// There are no comments for BudgetTrackingWorkspaceParametersBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetTrackingWorkspaceParametersBudgetModel")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetTrackingWorkspaceParametersBudgetModel == null))
                {
                    this._BudgetTrackingWorkspaceParametersBudgetModel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(GetPath("BudgetTrackingWorkspaceParametersBudgetModel"));
                }
                return this._BudgetTrackingWorkspaceParametersBudgetModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetModel;
    }
    /// <summary>
    /// There are no comments for BudgetModel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BudgetModel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BudgetModel")]
    [global::Microsoft.OData.Client.EntitySet("BudgetModels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetModel")]
    public partial class BudgetModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="budgetModel1">Initial value of BudgetModel1.</param>
        /// <param name="budgetRegisterEntryBudgetModel">Initial value of BudgetRegisterEntryBudgetModel.</param>
        /// <param name="budgetRegisterEntryHeaderBudgetModel">Initial value of BudgetRegisterEntryHeaderBudgetModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetModel CreateBudgetModel(string dataAreaId, string budgetModel1, global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry budgetRegisterEntryBudgetModel, global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader budgetRegisterEntryHeaderBudgetModel)
        {
            BudgetModel budgetModel = new BudgetModel();
            budgetModel.DataAreaId = dataAreaId;
            budgetModel.BudgetModel1 = budgetModel1;
            if ((budgetRegisterEntryBudgetModel == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryBudgetModel");
            }
            budgetModel.BudgetRegisterEntryBudgetModel = budgetRegisterEntryBudgetModel;
            if ((budgetRegisterEntryHeaderBudgetModel == null))
            {
                throw new global::System.ArgumentNullException("budgetRegisterEntryHeaderBudgetModel");
            }
            budgetModel.BudgetRegisterEntryHeaderBudgetModel = budgetRegisterEntryHeaderBudgetModel;
            return budgetModel;
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
        /// There are no comments for Property BudgetModel1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetModel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetModel1 is required.")]
        public virtual string BudgetModel1
        {
            get
            {
                return this._BudgetModel1;
            }
            set
            {
                this.OnBudgetModel1Changing(value);
                this._BudgetModel1 = value;
                this.OnBudgetModel1Changed();
                this.OnPropertyChanged("BudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetModel1;
        partial void OnBudgetModel1Changing(string value);
        partial void OnBudgetModel1Changed();
        /// <summary>
        /// There are no comments for Property Stopped in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Stopped")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Stopped
        {
            get
            {
                return this._Stopped;
            }
            set
            {
                this.OnStoppedChanging(value);
                this._Stopped = value;
                this.OnStoppedChanged();
                this.OnPropertyChanged("Stopped");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Stopped;
        partial void OnStoppedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnStoppedChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property CashFlowForecasts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CashFlowForecasts")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CashFlowForecasts
        {
            get
            {
                return this._CashFlowForecasts;
            }
            set
            {
                this.OnCashFlowForecastsChanging(value);
                this._CashFlowForecasts = value;
                this.OnCashFlowForecastsChanged();
                this.OnPropertyChanged("CashFlowForecasts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CashFlowForecasts;
        partial void OnCashFlowForecastsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCashFlowForecastsChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetRegisterEntryBudgetModel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetRegisterEntryBudgetModel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry BudgetRegisterEntryBudgetModel
        {
            get
            {
                return this._BudgetRegisterEntryBudgetModel;
            }
            set
            {
                this.OnBudgetRegisterEntryBudgetModelChanging(value);
                this._BudgetRegisterEntryBudgetModel = value;
                this.OnBudgetRegisterEntryBudgetModelChanged();
                this.OnPropertyChanged("BudgetRegisterEntryBudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry _BudgetRegisterEntryBudgetModel;
        partial void OnBudgetRegisterEntryBudgetModelChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntry value);
        partial void OnBudgetRegisterEntryBudgetModelChanged();
        /// <summary>
        /// There are no comments for Property BudgetSubmodelBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSubmodelBudgetModel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> BudgetSubmodelBudgetModel
        {
            get
            {
                return this._BudgetSubmodelBudgetModel;
            }
            set
            {
                this.OnBudgetSubmodelBudgetModelChanging(value);
                this._BudgetSubmodelBudgetModel = value;
                this.OnBudgetSubmodelBudgetModelChanged();
                this.OnPropertyChanged("BudgetSubmodelBudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> _BudgetSubmodelBudgetModel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetSubmodelBudgetModelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> value);
        partial void OnBudgetSubmodelBudgetModelChanged();
        /// <summary>
        /// There are no comments for Property BudgetSubmodel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSubmodel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> BudgetSubmodel
        {
            get
            {
                return this._BudgetSubmodel;
            }
            set
            {
                this.OnBudgetSubmodelChanging(value);
                this._BudgetSubmodel = value;
                this.OnBudgetSubmodelChanged();
                this.OnPropertyChanged("BudgetSubmodel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> _BudgetSubmodel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetSubmodelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetSubModel> value);
        partial void OnBudgetSubmodelChanged();
        /// <summary>
        /// There are no comments for Property BudgetRegisterEntryHeaderBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetRegisterEntryHeaderBudgetModel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetRegisterEntryHeaderBudgetModel is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader BudgetRegisterEntryHeaderBudgetModel
        {
            get
            {
                return this._BudgetRegisterEntryHeaderBudgetModel;
            }
            set
            {
                this.OnBudgetRegisterEntryHeaderBudgetModelChanging(value);
                this._BudgetRegisterEntryHeaderBudgetModel = value;
                this.OnBudgetRegisterEntryHeaderBudgetModelChanged();
                this.OnPropertyChanged("BudgetRegisterEntryHeaderBudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader _BudgetRegisterEntryHeaderBudgetModel;
        partial void OnBudgetRegisterEntryHeaderBudgetModelChanging(global::Microsoft.Dynamics.DataEntities.BudgetRegisterEntryHeader value);
        partial void OnBudgetRegisterEntryHeaderBudgetModelChanged();
        /// <summary>
        /// There are no comments for Property BudgetTrackingWorkspaceParametersBudgetModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetTrackingWorkspaceParametersBudgetModel")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetModel
        {
            get
            {
                return this._BudgetTrackingWorkspaceParametersBudgetModel;
            }
            set
            {
                this.OnBudgetTrackingWorkspaceParametersBudgetModelChanging(value);
                this._BudgetTrackingWorkspaceParametersBudgetModel = value;
                this.OnBudgetTrackingWorkspaceParametersBudgetModelChanged();
                this.OnPropertyChanged("BudgetTrackingWorkspaceParametersBudgetModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetModel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetTrackingWorkspaceParametersBudgetModelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> value);
        partial void OnBudgetTrackingWorkspaceParametersBudgetModelChanged();
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
