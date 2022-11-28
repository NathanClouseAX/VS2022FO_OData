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
    /// There are no comments for DefinitionGroupTemplateLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateLineSingle")]
    public partial class DefinitionGroupTemplateLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DefinitionGroupTemplateLine>
    {
        /// <summary>
        /// Initialize a new DefinitionGroupTemplateLineSingle object.
        /// </summary>
        public DefinitionGroupTemplateLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DefinitionGroupTemplateLineSingle object.
        /// </summary>
        public DefinitionGroupTemplateLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DefinitionGroupTemplateLineSingle object.
        /// </summary>
        public DefinitionGroupTemplateLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DefinitionGroupTemplateLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DefinitionGroupTemplateHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateHeader")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader> DefinitionGroupTemplateHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefinitionGroupTemplateHeader == null))
                {
                    this._DefinitionGroupTemplateHeader = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader>(GetPath("DefinitionGroupTemplateHeader"));
                }
                return this._DefinitionGroupTemplateHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader> _DefinitionGroupTemplateHeader;
        /// <summary>
        /// There are no comments for DMFDefinitionGroupTemplateHeaderRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateHeaderRole")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeaderSingle DMFDefinitionGroupTemplateHeaderRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DMFDefinitionGroupTemplateHeaderRole == null))
                {
                    this._DMFDefinitionGroupTemplateHeaderRole = new global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeaderSingle(this.Context, GetPath("DMFDefinitionGroupTemplateHeaderRole"));
                }
                return this._DMFDefinitionGroupTemplateHeaderRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeaderSingle _DMFDefinitionGroupTemplateHeaderRole;
    }
    /// <summary>
    /// There are no comments for DefinitionGroupTemplateLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// Entity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId", "Entity")]
    [global::Microsoft.OData.Client.EntitySet("DefinitionGroupTemplateLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateLine")]
    public partial class DefinitionGroupTemplateLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DefinitionGroupTemplateLine object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="entity">Initial value of Entity.</param>
        /// <param name="levelInExecutionUnit">Initial value of LevelInExecutionUnit.</param>
        /// <param name="sequence">Initial value of Sequence.</param>
        /// <param name="executionUnit">Initial value of ExecutionUnit.</param>
        /// <param name="dMFDefinitionGroupTemplateHeaderRole">Initial value of DMFDefinitionGroupTemplateHeaderRole.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DefinitionGroupTemplateLine CreateDefinitionGroupTemplateLine(string templateId, 
                    string entity, 
                    int levelInExecutionUnit, 
                    int sequence, 
                    int executionUnit, 
                    global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader dMFDefinitionGroupTemplateHeaderRole)
        {
            DefinitionGroupTemplateLine definitionGroupTemplateLine = new DefinitionGroupTemplateLine();
            definitionGroupTemplateLine.TemplateId = templateId;
            definitionGroupTemplateLine.Entity = entity;
            definitionGroupTemplateLine.LevelInExecutionUnit = levelInExecutionUnit;
            definitionGroupTemplateLine.Sequence = sequence;
            definitionGroupTemplateLine.ExecutionUnit = executionUnit;
            if ((dMFDefinitionGroupTemplateHeaderRole == null))
            {
                throw new global::System.ArgumentNullException("dMFDefinitionGroupTemplateHeaderRole");
            }
            definitionGroupTemplateLine.DMFDefinitionGroupTemplateHeaderRole = dMFDefinitionGroupTemplateHeaderRole;
            return definitionGroupTemplateLine;
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
        /// There are no comments for Property Entity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Entity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Entity is required.")]
        public virtual string Entity
        {
            get
            {
                return this._Entity;
            }
            set
            {
                this.OnEntityChanging(value);
                this._Entity = value;
                this.OnEntityChanged();
                this.OnPropertyChanged("Entity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Entity;
        partial void OnEntityChanging(string value);
        partial void OnEntityChanged();
        /// <summary>
        /// There are no comments for Property SysModule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysModule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFModule> SysModule
        {
            get
            {
                return this._SysModule;
            }
            set
            {
                this.OnSysModuleChanging(value);
                this._SysModule = value;
                this.OnSysModuleChanged();
                this.OnPropertyChanged("SysModule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFModule> _SysModule;
        partial void OnSysModuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DMFModule> value);
        partial void OnSysModuleChanged();
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
        /// There are no comments for Property Sequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Sequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Sequence is required.")]
        public virtual int Sequence
        {
            get
            {
                return this._Sequence;
            }
            set
            {
                this.OnSequenceChanging(value);
                this._Sequence = value;
                this.OnSequenceChanged();
                this.OnPropertyChanged("Sequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Sequence;
        partial void OnSequenceChanging(int value);
        partial void OnSequenceChanged();
        /// <summary>
        /// There are no comments for Property EntityCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntityCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntityCategory> EntityCategory
        {
            get
            {
                return this._EntityCategory;
            }
            set
            {
                this.OnEntityCategoryChanging(value);
                this._EntityCategory = value;
                this.OnEntityCategoryChanged();
                this.OnPropertyChanged("EntityCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntityCategory> _EntityCategory;
        partial void OnEntityCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntityCategory> value);
        partial void OnEntityCategoryChanged();
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
        /// There are no comments for Property Tags in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Tags")]
        public virtual string Tags
        {
            get
            {
                return this._Tags;
            }
            set
            {
                this.OnTagsChanging(value);
                this._Tags = value;
                this.OnTagsChanged();
                this.OnPropertyChanged("Tags");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Tags;
        partial void OnTagsChanging(string value);
        partial void OnTagsChanged();
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
        /// There are no comments for Property DefinitionGroupTemplateHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupTemplateHeader")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader> DefinitionGroupTemplateHeader
        {
            get
            {
                return this._DefinitionGroupTemplateHeader;
            }
            set
            {
                this.OnDefinitionGroupTemplateHeaderChanging(value);
                this._DefinitionGroupTemplateHeader = value;
                this.OnDefinitionGroupTemplateHeaderChanged();
                this.OnPropertyChanged("DefinitionGroupTemplateHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader> _DefinitionGroupTemplateHeader = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDefinitionGroupTemplateHeaderChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader> value);
        partial void OnDefinitionGroupTemplateHeaderChanged();
        /// <summary>
        /// There are no comments for Property DMFDefinitionGroupTemplateHeaderRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DMFDefinitionGroupTemplateHeaderRole")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DMFDefinitionGroupTemplateHeaderRole is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader DMFDefinitionGroupTemplateHeaderRole
        {
            get
            {
                return this._DMFDefinitionGroupTemplateHeaderRole;
            }
            set
            {
                this.OnDMFDefinitionGroupTemplateHeaderRoleChanging(value);
                this._DMFDefinitionGroupTemplateHeaderRole = value;
                this.OnDMFDefinitionGroupTemplateHeaderRoleChanged();
                this.OnPropertyChanged("DMFDefinitionGroupTemplateHeaderRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader _DMFDefinitionGroupTemplateHeaderRole;
        partial void OnDMFDefinitionGroupTemplateHeaderRoleChanging(global::Microsoft.Dynamics.DataEntities.DefinitionGroupTemplateHeader value);
        partial void OnDMFDefinitionGroupTemplateHeaderRoleChanged();
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