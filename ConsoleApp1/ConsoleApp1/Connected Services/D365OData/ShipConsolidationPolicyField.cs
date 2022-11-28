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
    /// There are no comments for ShipConsolidationPolicyFieldSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyFieldSingle")]
    public partial class ShipConsolidationPolicyFieldSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShipConsolidationPolicyField>
    {
        /// <summary>
        /// Initialize a new ShipConsolidationPolicyFieldSingle object.
        /// </summary>
        public ShipConsolidationPolicyFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShipConsolidationPolicyFieldSingle object.
        /// </summary>
        public ShipConsolidationPolicyFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShipConsolidationPolicyFieldSingle object.
        /// </summary>
        public ShipConsolidationPolicyFieldSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShipConsolidationPolicyField> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShipConsolidationPolicyField in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShipConsolidationPolicyType
    /// ShipConsolidationPolicyName
    /// SourceTableName
    /// SourceFieldName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShipConsolidationPolicyType", "ShipConsolidationPolicyName", "SourceTableName", "SourceFieldName")]
    [global::Microsoft.OData.Client.EntitySet("ShipConsolidationPolicyFields")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyField")]
    public partial class ShipConsolidationPolicyField : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShipConsolidationPolicyField object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shipConsolidationPolicyName">Initial value of ShipConsolidationPolicyName.</param>
        /// <param name="sourceTableName">Initial value of SourceTableName.</param>
        /// <param name="sourceFieldName">Initial value of SourceFieldName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShipConsolidationPolicyField CreateShipConsolidationPolicyField(string dataAreaId, string shipConsolidationPolicyName, string sourceTableName, string sourceFieldName)
        {
            ShipConsolidationPolicyField shipConsolidationPolicyField = new ShipConsolidationPolicyField();
            shipConsolidationPolicyField.DataAreaId = dataAreaId;
            shipConsolidationPolicyField.ShipConsolidationPolicyName = shipConsolidationPolicyName;
            shipConsolidationPolicyField.SourceTableName = sourceTableName;
            shipConsolidationPolicyField.SourceFieldName = sourceFieldName;
            return shipConsolidationPolicyField;
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
        /// There are no comments for Property ShipConsolidationPolicyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> ShipConsolidationPolicyType
        {
            get
            {
                return this._ShipConsolidationPolicyType;
            }
            set
            {
                this.OnShipConsolidationPolicyTypeChanging(value);
                this._ShipConsolidationPolicyType = value;
                this.OnShipConsolidationPolicyTypeChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> _ShipConsolidationPolicyType;
        partial void OnShipConsolidationPolicyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSShipConsolidationPolicyType> value);
        partial void OnShipConsolidationPolicyTypeChanged();
        /// <summary>
        /// There are no comments for Property ShipConsolidationPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipConsolidationPolicyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipConsolidationPolicyName is required.")]
        public virtual string ShipConsolidationPolicyName
        {
            get
            {
                return this._ShipConsolidationPolicyName;
            }
            set
            {
                this.OnShipConsolidationPolicyNameChanging(value);
                this._ShipConsolidationPolicyName = value;
                this.OnShipConsolidationPolicyNameChanged();
                this.OnPropertyChanged("ShipConsolidationPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipConsolidationPolicyName;
        partial void OnShipConsolidationPolicyNameChanging(string value);
        partial void OnShipConsolidationPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property SourceTableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceTableName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SourceTableName is required.")]
        public virtual string SourceTableName
        {
            get
            {
                return this._SourceTableName;
            }
            set
            {
                this.OnSourceTableNameChanging(value);
                this._SourceTableName = value;
                this.OnSourceTableNameChanged();
                this.OnPropertyChanged("SourceTableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceTableName;
        partial void OnSourceTableNameChanging(string value);
        partial void OnSourceTableNameChanged();
        /// <summary>
        /// There are no comments for Property SourceFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceFieldName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SourceFieldName is required.")]
        public virtual string SourceFieldName
        {
            get
            {
                return this._SourceFieldName;
            }
            set
            {
                this.OnSourceFieldNameChanging(value);
                this._SourceFieldName = value;
                this.OnSourceFieldNameChanged();
                this.OnPropertyChanged("SourceFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceFieldName;
        partial void OnSourceFieldNameChanging(string value);
        partial void OnSourceFieldNameChanged();
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
