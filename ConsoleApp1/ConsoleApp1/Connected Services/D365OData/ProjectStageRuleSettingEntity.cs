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
    /// There are no comments for ProjectStageRuleSettingEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectStageRuleSettingEntitySingle")]
    public partial class ProjectStageRuleSettingEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectStageRuleSettingEntity>
    {
        /// <summary>
        /// Initialize a new ProjectStageRuleSettingEntitySingle object.
        /// </summary>
        public ProjectStageRuleSettingEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectStageRuleSettingEntitySingle object.
        /// </summary>
        public ProjectStageRuleSettingEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectStageRuleSettingEntitySingle object.
        /// </summary>
        public ProjectStageRuleSettingEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectStageRuleSettingEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjectStageRuleSettingEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjStatus
    /// ProjType
    /// ProjStatusRule
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjStatus", "ProjType", "ProjStatusRule")]
    [global::Microsoft.OData.Client.EntitySet("ProjectStageRuleSettingEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectStageRuleSettingEntity")]
    public partial class ProjectStageRuleSettingEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectStageRuleSettingEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectStageRuleSettingEntity CreateProjectStageRuleSettingEntity(string dataAreaId)
        {
            ProjectStageRuleSettingEntity projectStageRuleSettingEntity = new ProjectStageRuleSettingEntity();
            projectStageRuleSettingEntity.DataAreaId = dataAreaId;
            return projectStageRuleSettingEntity;
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
        /// There are no comments for Property ProjStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatus> ProjStatus
        {
            get
            {
                return this._ProjStatus;
            }
            set
            {
                this.OnProjStatusChanging(value);
                this._ProjStatus = value;
                this.OnProjStatusChanged();
                this.OnPropertyChanged("ProjStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatus> _ProjStatus;
        partial void OnProjStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatus> value);
        partial void OnProjStatusChanged();
        /// <summary>
        /// There are no comments for Property ProjType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjType> ProjType
        {
            get
            {
                return this._ProjType;
            }
            set
            {
                this.OnProjTypeChanging(value);
                this._ProjType = value;
                this.OnProjTypeChanged();
                this.OnPropertyChanged("ProjType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjType> _ProjType;
        partial void OnProjTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjType> value);
        partial void OnProjTypeChanged();
        /// <summary>
        /// There are no comments for Property ProjStatusRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjStatusRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatusRule> ProjStatusRule
        {
            get
            {
                return this._ProjStatusRule;
            }
            set
            {
                this.OnProjStatusRuleChanging(value);
                this._ProjStatusRule = value;
                this.OnProjStatusRuleChanged();
                this.OnPropertyChanged("ProjStatusRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatusRule> _ProjStatusRule;
        partial void OnProjStatusRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjStatusRule> value);
        partial void OnProjStatusRuleChanged();
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
