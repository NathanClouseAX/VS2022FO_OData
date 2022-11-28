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
    /// There are no comments for ConfiguratorDefinitionGroupFieldSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupFieldSingle")]
    public partial class ConfiguratorDefinitionGroupFieldSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ConfiguratorDefinitionGroupField>
    {
        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupFieldSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupFieldSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ConfiguratorDefinitionGroupFieldSingle object.
        /// </summary>
        public ConfiguratorDefinitionGroupFieldSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ConfiguratorDefinitionGroupField> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ConfiguratorDefinitionGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSingle ConfiguratorDefinitionGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ConfiguratorDefinitionGroup == null))
                {
                    this._ConfiguratorDefinitionGroup = new global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSingle(this.Context, GetPath("ConfiguratorDefinitionGroup"));
                }
                return this._ConfiguratorDefinitionGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroupSingle _ConfiguratorDefinitionGroup;
    }
    /// <summary>
    /// There are no comments for ConfiguratorDefinitionGroupField in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DefinitionGroupId
    /// DataSourceNumber
    /// TableName
    /// SortOrder
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DefinitionGroupId", "DataSourceNumber", "TableName", "SortOrder")]
    [global::Microsoft.OData.Client.EntitySet("ConfiguratorDefinitionGroupFields")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroupField")]
    public partial class ConfiguratorDefinitionGroupField : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ConfiguratorDefinitionGroupField object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="definitionGroupId">Initial value of DefinitionGroupId.</param>
        /// <param name="dataSourceNumber">Initial value of DataSourceNumber.</param>
        /// <param name="tableName">Initial value of TableName.</param>
        /// <param name="sortOrder">Initial value of SortOrder.</param>
        /// <param name="configuratorDefinitionGroup">Initial value of ConfiguratorDefinitionGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ConfiguratorDefinitionGroupField CreateConfiguratorDefinitionGroupField(string dataAreaId, 
                    string definitionGroupId, 
                    int dataSourceNumber, 
                    string tableName, 
                    int sortOrder, 
                    global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroup configuratorDefinitionGroup)
        {
            ConfiguratorDefinitionGroupField configuratorDefinitionGroupField = new ConfiguratorDefinitionGroupField();
            configuratorDefinitionGroupField.DataAreaId = dataAreaId;
            configuratorDefinitionGroupField.DefinitionGroupId = definitionGroupId;
            configuratorDefinitionGroupField.DataSourceNumber = dataSourceNumber;
            configuratorDefinitionGroupField.TableName = tableName;
            configuratorDefinitionGroupField.SortOrder = sortOrder;
            if ((configuratorDefinitionGroup == null))
            {
                throw new global::System.ArgumentNullException("configuratorDefinitionGroup");
            }
            configuratorDefinitionGroupField.ConfiguratorDefinitionGroup = configuratorDefinitionGroup;
            return configuratorDefinitionGroupField;
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
        /// There are no comments for Property DataSourceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataSourceNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataSourceNumber is required.")]
        public virtual int DataSourceNumber
        {
            get
            {
                return this._DataSourceNumber;
            }
            set
            {
                this.OnDataSourceNumberChanging(value);
                this._DataSourceNumber = value;
                this.OnDataSourceNumberChanged();
                this.OnPropertyChanged("DataSourceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DataSourceNumber;
        partial void OnDataSourceNumberChanging(int value);
        partial void OnDataSourceNumberChanged();
        /// <summary>
        /// There are no comments for Property TableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableName is required.")]
        public virtual string TableName
        {
            get
            {
                return this._TableName;
            }
            set
            {
                this.OnTableNameChanging(value);
                this._TableName = value;
                this.OnTableNameChanged();
                this.OnPropertyChanged("TableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableName;
        partial void OnTableNameChanging(string value);
        partial void OnTableNameChanged();
        /// <summary>
        /// There are no comments for Property SortOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SortOrder")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SortOrder is required.")]
        public virtual int SortOrder
        {
            get
            {
                return this._SortOrder;
            }
            set
            {
                this.OnSortOrderChanging(value);
                this._SortOrder = value;
                this.OnSortOrderChanged();
                this.OnPropertyChanged("SortOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SortOrder;
        partial void OnSortOrderChanging(int value);
        partial void OnSortOrderChanged();
        /// <summary>
        /// There are no comments for Property FieldGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldGroup")]
        public virtual string FieldGroup
        {
            get
            {
                return this._FieldGroup;
            }
            set
            {
                this.OnFieldGroupChanging(value);
                this._FieldGroup = value;
                this.OnFieldGroupChanged();
                this.OnPropertyChanged("FieldGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldGroup;
        partial void OnFieldGroupChanging(string value);
        partial void OnFieldGroupChanged();
        /// <summary>
        /// There are no comments for Property FieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldName")]
        public virtual string FieldName
        {
            get
            {
                return this._FieldName;
            }
            set
            {
                this.OnFieldNameChanging(value);
                this._FieldName = value;
                this.OnFieldNameChanged();
                this.OnPropertyChanged("FieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FieldName;
        partial void OnFieldNameChanging(string value);
        partial void OnFieldNameChanged();
        /// <summary>
        /// There are no comments for Property ConfiguratorDefinitionGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfiguratorDefinitionGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConfiguratorDefinitionGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroup ConfiguratorDefinitionGroup
        {
            get
            {
                return this._ConfiguratorDefinitionGroup;
            }
            set
            {
                this.OnConfiguratorDefinitionGroupChanging(value);
                this._ConfiguratorDefinitionGroup = value;
                this.OnConfiguratorDefinitionGroupChanged();
                this.OnPropertyChanged("ConfiguratorDefinitionGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroup _ConfiguratorDefinitionGroup;
        partial void OnConfiguratorDefinitionGroupChanging(global::Microsoft.Dynamics.DataEntities.ConfiguratorDefinitionGroup value);
        partial void OnConfiguratorDefinitionGroupChanged();
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
