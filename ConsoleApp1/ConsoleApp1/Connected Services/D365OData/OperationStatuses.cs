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
    /// There are no comments for OperationStatusesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OperationStatusesSingle")]
    public partial class OperationStatusesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OperationStatuses>
    {
        /// <summary>
        /// Initialize a new OperationStatusesSingle object.
        /// </summary>
        public OperationStatusesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OperationStatusesSingle object.
        /// </summary>
        public OperationStatusesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OperationStatusesSingle object.
        /// </summary>
        public OperationStatusesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OperationStatuses> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for OperationStatuses in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OperationStatus
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperationStatus")]
    [global::Microsoft.OData.Client.EntitySet("OperationStatuses")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OperationStatuses")]
    public partial class OperationStatuses : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OperationStatuses object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="operationStatus">Initial value of OperationStatus.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OperationStatuses CreateOperationStatuses(string dataAreaId, string operationStatus)
        {
            OperationStatuses operationStatuses = new OperationStatuses();
            operationStatuses.DataAreaId = dataAreaId;
            operationStatuses.OperationStatus = operationStatus;
            return operationStatuses;
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
        /// There are no comments for Property OperationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationStatus")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperationStatus is required.")]
        public virtual string OperationStatus
        {
            get
            {
                return this._OperationStatus;
            }
            set
            {
                this.OnOperationStatusChanging(value);
                this._OperationStatus = value;
                this.OnOperationStatusChanged();
                this.OnPropertyChanged("OperationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationStatus;
        partial void OnOperationStatusChanging(string value);
        partial void OnOperationStatusChanged();
        /// <summary>
        /// There are no comments for Property FiasOperationType_RU in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiasOperationType_RU")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiasOperationType_RU> FiasOperationType_RU
        {
            get
            {
                return this._FiasOperationType_RU;
            }
            set
            {
                this.OnFiasOperationType_RUChanging(value);
                this._FiasOperationType_RU = value;
                this.OnFiasOperationType_RUChanged();
                this.OnPropertyChanged("FiasOperationType_RU");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiasOperationType_RU> _FiasOperationType_RU;
        partial void OnFiasOperationType_RUChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FiasOperationType_RU> value);
        partial void OnFiasOperationType_RUChanged();
        /// <summary>
        /// There are no comments for Property OperationDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationDescription")]
        public virtual string OperationDescription
        {
            get
            {
                return this._OperationDescription;
            }
            set
            {
                this.OnOperationDescriptionChanging(value);
                this._OperationDescription = value;
                this.OnOperationDescriptionChanged();
                this.OnPropertyChanged("OperationDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationDescription;
        partial void OnOperationDescriptionChanging(string value);
        partial void OnOperationDescriptionChanged();
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
