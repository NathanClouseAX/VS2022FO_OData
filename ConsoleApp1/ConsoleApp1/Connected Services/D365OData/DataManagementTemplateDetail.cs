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
    /// There are no comments for DataManagementTemplateDetailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DataManagementTemplateDetailSingle")]
    public partial class DataManagementTemplateDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateDetail>
    {
        /// <summary>
        /// Initialize a new DataManagementTemplateDetailSingle object.
        /// </summary>
        public DataManagementTemplateDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateDetailSingle object.
        /// </summary>
        public DataManagementTemplateDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateDetailSingle object.
        /// </summary>
        public DataManagementTemplateDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DefinitionGroupTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplate")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle DefinitionGroupTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefinitionGroupTemplate == null))
                {
                    this._DefinitionGroupTemplate = new global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle(this.Context, GetPath("DefinitionGroupTemplate"));
                }
                return this._DefinitionGroupTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle _DefinitionGroupTemplate;
    }
    /// <summary>
    /// There are no comments for DataManagementTemplateDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// EntityName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId", "EntityName")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementTemplateDetails")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DataManagementTemplateDetail")]
    public partial class DataManagementTemplateDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementTemplateDetail object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="entityName">Initial value of EntityName.</param>
        /// <param name="levelInExecutionUnit">Initial value of LevelInExecutionUnit.</param>
        /// <param name="executionUnit">Initial value of ExecutionUnit.</param>
        /// <param name="sequenceInLevel">Initial value of SequenceInLevel.</param>
        /// <param name="definitionGroupTemplate">Initial value of DefinitionGroupTemplate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementTemplateDetail CreateDataManagementTemplateDetail(string templateId, 
                    string entityName, 
                    int levelInExecutionUnit, 
                    int executionUnit, 
                    int sequenceInLevel, 
                    global::Microsoft.Dynamics.DataEntities.DataManagementTemplate definitionGroupTemplate)
        {
            DataManagementTemplateDetail dataManagementTemplateDetail = new DataManagementTemplateDetail();
            dataManagementTemplateDetail.TemplateId = templateId;
            dataManagementTemplateDetail.EntityName = entityName;
            dataManagementTemplateDetail.LevelInExecutionUnit = levelInExecutionUnit;
            dataManagementTemplateDetail.ExecutionUnit = executionUnit;
            dataManagementTemplateDetail.SequenceInLevel = sequenceInLevel;
            if ((definitionGroupTemplate == null))
            {
                throw new global::System.ArgumentNullException("definitionGroupTemplate");
            }
            dataManagementTemplateDetail.DefinitionGroupTemplate = definitionGroupTemplate;
            return dataManagementTemplateDetail;
        }
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TemplateId is required.")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property EntityName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntityName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EntityName is required.")]
        public virtual string EntityName
        {
            get
            {
                return this._EntityName;
            }
            set
            {
                this.OnEntityNameChanging(value);
                this._EntityName = value;
                this.OnEntityNameChanged();
                this.OnPropertyChanged("EntityName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntityName;
        partial void OnEntityNameChanging(string value);
        partial void OnEntityNameChanged();
        /// <summary>
        /// There are no comments for Property LevelInExecutionUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LevelInExecutionUnit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LevelInExecutionUnit is required.")]
        public virtual int LevelInExecutionUnit
        {
            get
            {
                return this._LevelInExecutionUnit;
            }
            set
            {
                this.OnLevelInExecutionUnitChanging(value);
                this._LevelInExecutionUnit = value;
                this.OnLevelInExecutionUnitChanged();
                this.OnPropertyChanged("LevelInExecutionUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LevelInExecutionUnit;
        partial void OnLevelInExecutionUnitChanging(int value);
        partial void OnLevelInExecutionUnitChanged();
        /// <summary>
        /// There are no comments for Property FailLevelOnError in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FailLevelOnError")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FailLevelOnError
        {
            get
            {
                return this._FailLevelOnError;
            }
            set
            {
                this.OnFailLevelOnErrorChanging(value);
                this._FailLevelOnError = value;
                this.OnFailLevelOnErrorChanged();
                this.OnPropertyChanged("FailLevelOnError");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FailLevelOnError;
        partial void OnFailLevelOnErrorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFailLevelOnErrorChanged();
        /// <summary>
        /// There are no comments for Property ValidationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidationStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesError> ValidationStatus
        {
            get
            {
                return this._ValidationStatus;
            }
            set
            {
                this.OnValidationStatusChanging(value);
                this._ValidationStatus = value;
                this.OnValidationStatusChanged();
                this.OnPropertyChanged("ValidationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesError> _ValidationStatus;
        partial void OnValidationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYesError> value);
        partial void OnValidationStatusChanged();
        /// <summary>
        /// There are no comments for Property FailExecutionUnitOnError in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FailExecutionUnitOnError")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FailExecutionUnitOnError
        {
            get
            {
                return this._FailExecutionUnitOnError;
            }
            set
            {
                this.OnFailExecutionUnitOnErrorChanging(value);
                this._FailExecutionUnitOnError = value;
                this.OnFailExecutionUnitOnErrorChanged();
                this.OnPropertyChanged("FailExecutionUnitOnError");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FailExecutionUnitOnError;
        partial void OnFailExecutionUnitOnErrorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFailExecutionUnitOnErrorChanged();
        /// <summary>
        /// There are no comments for Property ExecutionUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExecutionUnit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExecutionUnit is required.")]
        public virtual int ExecutionUnit
        {
            get
            {
                return this._ExecutionUnit;
            }
            set
            {
                this.OnExecutionUnitChanging(value);
                this._ExecutionUnit = value;
                this.OnExecutionUnitChanged();
                this.OnPropertyChanged("ExecutionUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ExecutionUnit;
        partial void OnExecutionUnitChanging(int value);
        partial void OnExecutionUnitChanged();
        /// <summary>
        /// There are no comments for Property SequenceInLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceInLevel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceInLevel is required.")]
        public virtual int SequenceInLevel
        {
            get
            {
                return this._SequenceInLevel;
            }
            set
            {
                this.OnSequenceInLevelChanging(value);
                this._SequenceInLevel = value;
                this.OnSequenceInLevelChanged();
                this.OnPropertyChanged("SequenceInLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceInLevel;
        partial void OnSequenceInLevelChanging(int value);
        partial void OnSequenceInLevelChanged();
        /// <summary>
        /// There are no comments for Property DefinitionGroupTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefinitionGroupTemplate is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplate DefinitionGroupTemplate
        {
            get
            {
                return this._DefinitionGroupTemplate;
            }
            set
            {
                this.OnDefinitionGroupTemplateChanging(value);
                this._DefinitionGroupTemplate = value;
                this.OnDefinitionGroupTemplateChanged();
                this.OnPropertyChanged("DefinitionGroupTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplate _DefinitionGroupTemplate;
        partial void OnDefinitionGroupTemplateChanging(global::Microsoft.Dynamics.DataEntities.DataManagementTemplate value);
        partial void OnDefinitionGroupTemplateChanged();
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
