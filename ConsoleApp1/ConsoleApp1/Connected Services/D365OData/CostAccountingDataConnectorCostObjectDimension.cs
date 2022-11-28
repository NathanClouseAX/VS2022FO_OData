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
    /// There are no comments for CostAccountingDataConnectorCostObjectDimensionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorCostObjectDimensionSingle")]
    public partial class CostAccountingDataConnectorCostObjectDimensionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorCostObjectDimension>
    {
        /// <summary>
        /// Initialize a new CostAccountingDataConnectorCostObjectDimensionSingle object.
        /// </summary>
        public CostAccountingDataConnectorCostObjectDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorCostObjectDimensionSingle object.
        /// </summary>
        public CostAccountingDataConnectorCostObjectDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CostAccountingDataConnectorCostObjectDimensionSingle object.
        /// </summary>
        public CostAccountingDataConnectorCostObjectDimensionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CostAccountingDataConnectorCostObjectDimension> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DataConnectorSystemInstanceEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorSystemInstanceEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstanceSingle DataConnectorSystemInstanceEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DataConnectorSystemInstanceEntity == null))
                {
                    this._DataConnectorSystemInstanceEntity = new global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstanceSingle(this.Context, GetPath("DataConnectorSystemInstanceEntity"));
                }
                return this._DataConnectorSystemInstanceEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstanceSingle _DataConnectorSystemInstanceEntity;
    }
    /// <summary>
    /// There are no comments for CostAccountingDataConnectorCostObjectDimension in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataConnectorSystemInstanceSurrogateKey
    /// SurrogateKey
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataConnectorSystemInstanceSurrogateKey", "SurrogateKey")]
    [global::Microsoft.OData.Client.EntitySet("CostAccountingDataConnectorCostObjectDimensions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CostAccountingDataConnectorCostObjectDimension")]
    public partial class CostAccountingDataConnectorCostObjectDimension : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CostAccountingDataConnectorCostObjectDimension object.
        /// </summary>
        /// <param name="dataConnectorSystemInstanceSurrogateKey">Initial value of DataConnectorSystemInstanceSurrogateKey.</param>
        /// <param name="surrogateKey">Initial value of SurrogateKey.</param>
        /// <param name="dataConnectorSystemInstanceEntity">Initial value of DataConnectorSystemInstanceEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CostAccountingDataConnectorCostObjectDimension CreateCostAccountingDataConnectorCostObjectDimension(string dataConnectorSystemInstanceSurrogateKey, string surrogateKey, global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstance dataConnectorSystemInstanceEntity)
        {
            CostAccountingDataConnectorCostObjectDimension costAccountingDataConnectorCostObjectDimension = new CostAccountingDataConnectorCostObjectDimension();
            costAccountingDataConnectorCostObjectDimension.DataConnectorSystemInstanceSurrogateKey = dataConnectorSystemInstanceSurrogateKey;
            costAccountingDataConnectorCostObjectDimension.SurrogateKey = surrogateKey;
            if ((dataConnectorSystemInstanceEntity == null))
            {
                throw new global::System.ArgumentNullException("dataConnectorSystemInstanceEntity");
            }
            costAccountingDataConnectorCostObjectDimension.DataConnectorSystemInstanceEntity = dataConnectorSystemInstanceEntity;
            return costAccountingDataConnectorCostObjectDimension;
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
        /// There are no comments for Property SurrogateKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SurrogateKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SurrogateKey is required.")]
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
        /// There are no comments for Property MustTransferDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MustTransferDimension")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MustTransferDimension
        {
            get
            {
                return this._MustTransferDimension;
            }
            set
            {
                this.OnMustTransferDimensionChanging(value);
                this._MustTransferDimension = value;
                this.OnMustTransferDimensionChanged();
                this.OnPropertyChanged("MustTransferDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MustTransferDimension;
        partial void OnMustTransferDimensionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMustTransferDimensionChanged();
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
        /// There are no comments for Property MustTransferDimensionMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MustTransferDimensionMembers")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MustTransferDimensionMembers
        {
            get
            {
                return this._MustTransferDimensionMembers;
            }
            set
            {
                this.OnMustTransferDimensionMembersChanging(value);
                this._MustTransferDimensionMembers = value;
                this.OnMustTransferDimensionMembersChanged();
                this.OnPropertyChanged("MustTransferDimensionMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MustTransferDimensionMembers;
        partial void OnMustTransferDimensionMembersChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMustTransferDimensionMembersChanged();
        /// <summary>
        /// There are no comments for Property DataConnectorSystemInstanceEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataConnectorSystemInstanceEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DataConnectorSystemInstanceEntity is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstance DataConnectorSystemInstanceEntity
        {
            get
            {
                return this._DataConnectorSystemInstanceEntity;
            }
            set
            {
                this.OnDataConnectorSystemInstanceEntityChanging(value);
                this._DataConnectorSystemInstanceEntity = value;
                this.OnDataConnectorSystemInstanceEntityChanged();
                this.OnPropertyChanged("DataConnectorSystemInstanceEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstance _DataConnectorSystemInstanceEntity;
        partial void OnDataConnectorSystemInstanceEntityChanging(global::Microsoft.Dynamics.DataEntities.CostAccountingDataConnectorSystemInstance value);
        partial void OnDataConnectorSystemInstanceEntityChanged();
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