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
    /// There are no comments for AssetMaintenanceChecklistVariableValueSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceChecklistVariableValueSingle")]
    public partial class AssetMaintenanceChecklistVariableValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceChecklistVariableValue>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceChecklistVariableValueSingle object.
        /// </summary>
        public AssetMaintenanceChecklistVariableValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceChecklistVariableValueSingle object.
        /// </summary>
        public AssetMaintenanceChecklistVariableValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceChecklistVariableValueSingle object.
        /// </summary>
        public AssetMaintenanceChecklistVariableValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceChecklistVariableValue> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceChecklistVariableValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ChecklistVariableId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ChecklistVariableId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceChecklistVariableValues")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceChecklistVariableValue")]
    public partial class AssetMaintenanceChecklistVariableValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceChecklistVariableValue object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="checklistVariableId">Initial value of ChecklistVariableId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceChecklistVariableValue CreateAssetMaintenanceChecklistVariableValue(string dataAreaId, string checklistVariableId, decimal lineNumber)
        {
            AssetMaintenanceChecklistVariableValue assetMaintenanceChecklistVariableValue = new AssetMaintenanceChecklistVariableValue();
            assetMaintenanceChecklistVariableValue.DataAreaId = dataAreaId;
            assetMaintenanceChecklistVariableValue.ChecklistVariableId = checklistVariableId;
            assetMaintenanceChecklistVariableValue.LineNumber = lineNumber;
            return assetMaintenanceChecklistVariableValue;
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
        /// There are no comments for Property ChecklistVariableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChecklistVariableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChecklistVariableId is required.")]
        public virtual string ChecklistVariableId
        {
            get
            {
                return this._ChecklistVariableId;
            }
            set
            {
                this.OnChecklistVariableIdChanging(value);
                this._ChecklistVariableId = value;
                this.OnChecklistVariableIdChanged();
                this.OnPropertyChanged("ChecklistVariableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChecklistVariableId;
        partial void OnChecklistVariableIdChanging(string value);
        partial void OnChecklistVariableIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        /// <summary>
        /// There are no comments for Property CheckStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> CheckStatus
        {
            get
            {
                return this._CheckStatus;
            }
            set
            {
                this.OnCheckStatusChanging(value);
                this._CheckStatus = value;
                this.OnCheckStatusChanged();
                this.OnPropertyChanged("CheckStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> _CheckStatus;
        partial void OnCheckStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> value);
        partial void OnCheckStatusChanged();
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
