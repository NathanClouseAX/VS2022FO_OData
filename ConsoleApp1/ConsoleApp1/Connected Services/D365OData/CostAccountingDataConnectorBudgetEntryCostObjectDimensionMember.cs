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
    /// There are no comments for CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle")]
    public partial class CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember>
    {
        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetEntryCostObjectDimensionMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataConnectorSystemInstanceSurrogateKey
    /// BudgetEntrySourceIdentifier
    /// DataConnectorCostObjectDimensionName
    /// CostObjectDimensionMemberName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataConnectorSystemInstanceSurrogateKey", "BudgetEntrySourceIdentifier", "DataConnectorCostObjectDimensionName", "CostObjectDimensionMemberName")]
    [global::Microsoft.OData.Client.EntitySet("CostAccountingDataConnectorBudgetEntryCostObjectDimensionMembers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember")]
    public partial class CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember object.
        /// </summary>
        /// <param name="dataConnectorSystemInstanceSurrogateKey">Initial value of DataConnectorSystemInstanceSurrogateKey.</param>
        /// <param name="budgetEntrySourceIdentifier">Initial value of BudgetEntrySourceIdentifier.</param>
        /// <param name="dataConnectorCostObjectDimensionName">Initial value of DataConnectorCostObjectDimensionName.</param>
        /// <param name="costObjectDimensionMemberName">Initial value of CostObjectDimensionMemberName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember CreateCostAccountingDataConnectorBudgetEntryCostObjectDimensionMember(string dataConnectorSystemInstanceSurrogateKey, string budgetEntrySourceIdentifier, string dataConnectorCostObjectDimensionName, string costObjectDimensionMemberName)
        {
            CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember costAccountingDataConnectorBudgetEntryCostObjectDimensionMember = new CostAccountingDataConnectorBudgetEntryCostObjectDimensionMember();
            costAccountingDataConnectorBudgetEntryCostObjectDimensionMember.DataConnectorSystemInstanceSurrogateKey = dataConnectorSystemInstanceSurrogateKey;
            costAccountingDataConnectorBudgetEntryCostObjectDimensionMember.BudgetEntrySourceIdentifier = budgetEntrySourceIdentifier;
            costAccountingDataConnectorBudgetEntryCostObjectDimensionMember.DataConnectorCostObjectDimensionName = dataConnectorCostObjectDimensionName;
            costAccountingDataConnectorBudgetEntryCostObjectDimensionMember.CostObjectDimensionMemberName = costObjectDimensionMemberName;
            return costAccountingDataConnectorBudgetEntryCostObjectDimensionMember;
        }
        /// <summary>
        /// There are no comments for Property DataConnectorSystemInstanceSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorSystemInstanceSurrogateKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorSystemInstanceSurrogateKey is required.")]
        public virtual string DataConnectorSystemInstanceSurrogateKey
        {
            get
            {
                return this._DataConnectorSystemInstanceSurrogateKey;
            }
            set
            {
                this.OnDataConnectorSystemInstanceSurrogateKeyChanging(value);
                this._DataConnectorSystemInstanceSurrogateKey = value;
                this.OnDataConnectorSystemInstanceSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorSystemInstanceSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorSystemInstanceSurrogateKey;
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanging(string value);
        partial void OnDataConnectorSystemInstanceSurrogateKeyChanged();
        /// <summary>
        /// There are no comments for Property BudgetEntrySourceIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetEntrySourceIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetEntrySourceIdentifier is required.")]
        public virtual string BudgetEntrySourceIdentifier
        {
            get
            {
                return this._BudgetEntrySourceIdentifier;
            }
            set
            {
                this.OnBudgetEntrySourceIdentifierChanging(value);
                this._BudgetEntrySourceIdentifier = value;
                this.OnBudgetEntrySourceIdentifierChanged();
                this.OnPropertyChanged("BudgetEntrySourceIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetEntrySourceIdentifier;
        partial void OnBudgetEntrySourceIdentifierChanging(string value);
        partial void OnBudgetEntrySourceIdentifierChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorCostObjectDimensionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorCostObjectDimensionName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorCostObjectDimensionName is required.")]
        public virtual string DataConnectorCostObjectDimensionName
        {
            get
            {
                return this._DataConnectorCostObjectDimensionName;
            }
            set
            {
                this.OnDataConnectorCostObjectDimensionNameChanging(value);
                this._DataConnectorCostObjectDimensionName = value;
                this.OnDataConnectorCostObjectDimensionNameChanged();
                this.OnPropertyChanged("DataConnectorCostObjectDimensionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorCostObjectDimensionName;
        partial void OnDataConnectorCostObjectDimensionNameChanging(string value);
        partial void OnDataConnectorCostObjectDimensionNameChanged();
        /// <summary>
        /// There are no comments for Property CostObjectDimensionMemberName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostObjectDimensionMemberName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostObjectDimensionMemberName is required.")]
        public virtual string CostObjectDimensionMemberName
        {
            get
            {
                return this._CostObjectDimensionMemberName;
            }
            set
            {
                this.OnCostObjectDimensionMemberNameChanging(value);
                this._CostObjectDimensionMemberName = value;
                this.OnCostObjectDimensionMemberNameChanged();
                this.OnPropertyChanged("CostObjectDimensionMemberName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostObjectDimensionMemberName;
        partial void OnCostObjectDimensionMemberNameChanging(string value);
        partial void OnCostObjectDimensionMemberNameChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorDataTransferSurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorDataTransferSurrogateKey")]
        public virtual string DataConnectorDataTransferSurrogateKey
        {
            get
            {
                return this._DataConnectorDataTransferSurrogateKey;
            }
            set
            {
                this.OnDataConnectorDataTransferSurrogateKeyChanging(value);
                this._DataConnectorDataTransferSurrogateKey = value;
                this.OnDataConnectorDataTransferSurrogateKeyChanged();
                this.OnPropertyChanged("DataConnectorDataTransferSurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataConnectorDataTransferSurrogateKey;
        partial void OnDataConnectorDataTransferSurrogateKeyChanging(string value);
        partial void OnDataConnectorDataTransferSurrogateKeyChanged();
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
