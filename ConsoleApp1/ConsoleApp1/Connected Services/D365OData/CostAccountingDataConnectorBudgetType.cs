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
    /// There are no comments for CostAccountingDataConnectorBudgetTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorBudgetTypeSingle")]
    public partial class CostAccountingDataConnectorBudgetTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorBudgetType>
    {
        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetTypeSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetTypeSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorBudgetTypeSingle object.
        /// </summary>
        public CostAccountingDataConnectorBudgetTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorBudgetType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CostAccountingDataConnectorBudgetType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataConnectorSystemInstanceSurrogateKey
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataConnectorSystemInstanceSurrogateKey", "Name")]
    [global::Microsoft.OData.Client.EntitySet("CostAccountingDataConnectorBudgetTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorBudgetType")]
    public partial class CostAccountingDataConnectorBudgetType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostAccountingDataConnectorBudgetType object.
        /// </summary>
        /// <param name="dataConnectorSystemInstanceSurrogateKey">Initial value of DataConnectorSystemInstanceSurrogateKey.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostAccountingDataConnectorBudgetType CreateCostAccountingDataConnectorBudgetType(string dataConnectorSystemInstanceSurrogateKey, string name)
        {
            CostAccountingDataConnectorBudgetType costAccountingDataConnectorBudgetType = new CostAccountingDataConnectorBudgetType();
            costAccountingDataConnectorBudgetType.DataConnectorSystemInstanceSurrogateKey = dataConnectorSystemInstanceSurrogateKey;
            costAccountingDataConnectorBudgetType.Name = name;
            return costAccountingDataConnectorBudgetType;
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property SurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SurrogateKey")]
        public virtual string SurrogateKey
        {
            get
            {
                return this._SurrogateKey;
            }
            set
            {
                this.OnSurrogateKeyChanging(value);
                this._SurrogateKey = value;
                this.OnSurrogateKeyChanged();
                this.OnPropertyChanged("SurrogateKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SurrogateKey;
        partial void OnSurrogateKeyChanging(string value);
        partial void OnSurrogateKeyChanged();
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
