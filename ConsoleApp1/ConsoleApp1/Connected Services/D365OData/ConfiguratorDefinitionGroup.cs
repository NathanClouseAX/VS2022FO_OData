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
    /// There are no comments for ConfiguratorDefinitionGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupSingle")]
    public partial class ConfiguratorDefinitionGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConfiguratorDefinitionGroup>
    {
        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConfiguratorDefinitionGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroupFieldRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupFieldRange")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange> ConfiguratorDefinitionGroupFieldRange
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroupFieldRange == null))
                {
                    this._ConfiguratorDefinitionGroupFieldRange = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange>(GetPath("ConfiguratorDefinitionGroupFieldRange"));
                }
                return this._ConfiguratorDefinitionGroupFieldRange;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange> _ConfiguratorDefinitionGroupFieldRange;
        /// <summary>
        /// There are no comments for Relations_BR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Relations_BR")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Relations_BR> Relations_BR
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Relations_BR == null))
                {
                    this._Relations_BR = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Relations_BR>(GetPath("Relations_BR"));
                }
                return this._Relations_BR;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Relations_BR> _Relations_BR;
        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroupField in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupField")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField> ConfiguratorDefinitionGroupField
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroupField == null))
                {
                    this._ConfiguratorDefinitionGroupField = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField>(GetPath("ConfiguratorDefinitionGroupField"));
                }
                return this._ConfiguratorDefinitionGroupField;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField> _ConfiguratorDefinitionGroupField;
        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroupTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupTable")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable> ConfiguratorDefinitionGroupTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroupTable == null))
                {
                    this._ConfiguratorDefinitionGroupTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable>(GetPath("ConfiguratorDefinitionGroupTable"));
                }
                return this._ConfiguratorDefinitionGroupTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable> _ConfiguratorDefinitionGroupTable;
        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroupSortOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupSortOrder")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder> ConfiguratorDefinitionGroupSortOrder
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroupSortOrder == null))
                {
                    this._ConfiguratorDefinitionGroupSortOrder = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder>(GetPath("ConfiguratorDefinitionGroupSortOrder"));
                }
                return this._ConfiguratorDefinitionGroupSortOrder;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder> _ConfiguratorDefinitionGroupSortOrder;
        /// <summary>
        /// There are no comments for ConfiguratorLayoutGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorLayoutGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup> ConfiguratorLayoutGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorLayoutGroup == null))
                {
                    this._ConfiguratorLayoutGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup>(GetPath("ConfiguratorLayoutGroup"));
                }
                return this._ConfiguratorLayoutGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup> _ConfiguratorLayoutGroup;
        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroupSummation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupSummation")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation> ConfiguratorDefinitionGroupSummation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroupSummation == null))
                {
                    this._ConfiguratorDefinitionGroupSummation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation>(GetPath("ConfiguratorDefinitionGroupSummation"));
                }
                return this._ConfiguratorDefinitionGroupSummation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation> _ConfiguratorDefinitionGroupSummation;
    }
    /// <summary>
    /// There are no comments for ConfiguratorDefinitionGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DefinitionGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DefinitionGroupId")]
    [global::Microsoft.OData.Client.EntitySet("ConfiguratorDefinitionGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroup")]
    public partial class ConfiguratorDefinitionGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConfiguratorDefinitionGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="definitionGroupId">Initial value of DefinitionGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConfiguratorDefinitionGroup CreateConfiguratorDefinitionGroup(string dataAreaId, string definitionGroupId)
        {
            ConfiguratorDefinitionGroup configuratorDefinitionGroup = new ConfiguratorDefinitionGroup();
            configuratorDefinitionGroup.DataAreaId = dataAreaId;
            configuratorDefinitionGroup.DefinitionGroupId = definitionGroupId;
            return configuratorDefinitionGroup;
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
        /// There are no comments for Property DefinitionGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefinitionGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DefinitionGroupId is required.")]
        public virtual string DefinitionGroupId
        {
            get
            {
                return this._DefinitionGroupId;
            }
            set
            {
                this.OnDefinitionGroupIdChanging(value);
                this._DefinitionGroupId = value;
                this.OnDefinitionGroupIdChanged();
                this.OnPropertyChanged("DefinitionGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefinitionGroupId;
        partial void OnDefinitionGroupIdChanging(string value);
        partial void OnDefinitionGroupIdChanged();
        /// <summary>
        /// There are no comments for Property QueryTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryTitle")]
        public virtual string QueryTitle
        {
            get
            {
                return this._QueryTitle;
            }
            set
            {
                this.OnQueryTitleChanging(value);
                this._QueryTitle = value;
                this.OnQueryTitleChanged();
                this.OnPropertyChanged("QueryTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueryTitle;
        partial void OnQueryTitleChanging(string value);
        partial void OnQueryTitleChanged();
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
        /// There are no comments for Property IsQueryBased in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsQueryBased")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsQueryBased
        {
            get
            {
                return this._IsQueryBased;
            }
            set
            {
                this.OnIsQueryBasedChanging(value);
                this._IsQueryBased = value;
                this.OnIsQueryBasedChanged();
                this.OnPropertyChanged("IsQueryBased");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsQueryBased;
        partial void OnIsQueryBasedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsQueryBasedChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroupFieldRange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupFieldRange")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange> ConfiguratorDefinitionGroupFieldRange
        {
            get
            {
                return this._ConfiguratorDefinitionGroupFieldRange;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupFieldRangeChanging(value);
                this._ConfiguratorDefinitionGroupFieldRange = value;
                this.OnConfiguratorDefinitionGroupFieldRangeChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroupFieldRange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange> _ConfiguratorDefinitionGroupFieldRange = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorDefinitionGroupFieldRangeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupFieldRange> value);
        partial void OnConfiguratorDefinitionGroupFieldRangeChanged();
        /// <summary>
        /// There are no comments for Property Relations_BR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Relations_BR")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Relations_BR> Relations_BR
        {
            get
            {
                return this._Relations_BR;
            }
            set
            {
                this.OnRelations_BRChanging(value);
                this._Relations_BR = value;
                this.OnRelations_BRChanged();
                this.OnPropertyChanged("Relations_BR");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Relations_BR> _Relations_BR = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Relations_BR>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelations_BRChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Relations_BR> value);
        partial void OnRelations_BRChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroupField in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupField")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField> ConfiguratorDefinitionGroupField
        {
            get
            {
                return this._ConfiguratorDefinitionGroupField;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupFieldChanging(value);
                this._ConfiguratorDefinitionGroupField = value;
                this.OnConfiguratorDefinitionGroupFieldChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroupField");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField> _ConfiguratorDefinitionGroupField = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorDefinitionGroupFieldChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupField> value);
        partial void OnConfiguratorDefinitionGroupFieldChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroupTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupTable")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable> ConfiguratorDefinitionGroupTable
        {
            get
            {
                return this._ConfiguratorDefinitionGroupTable;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupTableChanging(value);
                this._ConfiguratorDefinitionGroupTable = value;
                this.OnConfiguratorDefinitionGroupTableChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroupTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable> _ConfiguratorDefinitionGroupTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorDefinitionGroupTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupTable> value);
        partial void OnConfiguratorDefinitionGroupTableChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroupSortOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupSortOrder")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder> ConfiguratorDefinitionGroupSortOrder
        {
            get
            {
                return this._ConfiguratorDefinitionGroupSortOrder;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupSortOrderChanging(value);
                this._ConfiguratorDefinitionGroupSortOrder = value;
                this.OnConfiguratorDefinitionGroupSortOrderChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroupSortOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder> _ConfiguratorDefinitionGroupSortOrder = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorDefinitionGroupSortOrderChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSortOrder> value);
        partial void OnConfiguratorDefinitionGroupSortOrderChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorLayoutGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorLayoutGroup")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup> ConfiguratorLayoutGroup
        {
            get
            {
                return this._ConfiguratorLayoutGroup;
            }
            set
            {
                this.OnConfiguratorLayoutGroupChanging(value);
                this._ConfiguratorLayoutGroup = value;
                this.OnConfiguratorLayoutGroupChanged();
                this.OnPropertyChanged("ConfiguratorLayoutGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup> _ConfiguratorLayoutGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorLayoutGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorLayoutGroup> value);
        partial void OnConfiguratorLayoutGroupChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroupSummation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupSummation")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation> ConfiguratorDefinitionGroupSummation
        {
            get
            {
                return this._ConfiguratorDefinitionGroupSummation;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupSummationChanging(value);
                this._ConfiguratorDefinitionGroupSummation = value;
                this.OnConfiguratorDefinitionGroupSummationChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroupSummation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation> _ConfiguratorDefinitionGroupSummation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnConfiguratorDefinitionGroupSummationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSummation> value);
        partial void OnConfiguratorDefinitionGroupSummationChanged();
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
