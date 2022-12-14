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
    /// There are no comments for ProductionPoolSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionPoolSingle")]
    public partial class ProductionPoolSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductionPool>
    {
        /// <summary>
        /// Initialize a new ProductionPoolSingle object.
        /// </summary>
        public ProductionPoolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductionPoolSingle object.
        /// </summary>
        public ProductionPoolSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductionPoolSingle object.
        /// </summary>
        public ProductionPoolSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductionPool> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductionOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader> ProductionOrderHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductionOrderHeaders == null))
                {
                    this._ProductionOrderHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader>(GetPath("ProductionOrderHeaders"));
                }
                return this._ProductionOrderHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader> _ProductionOrderHeaders;
        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
    /// <summary>
    /// There are no comments for ProductionPool in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PoolId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PoolId")]
    [global::Microsoft.OData.Client.EntitySet("ProductionPools")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionPool")]
    public partial class ProductionPool : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductionPool object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="poolId">Initial value of PoolId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductionPool CreateProductionPool(string dataAreaId, string poolId)
        {
            ProductionPool productionPool = new ProductionPool();
            productionPool.DataAreaId = dataAreaId;
            productionPool.PoolId = poolId;
            return productionPool;
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
        /// There are no comments for Property PoolId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PoolId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PoolId is required.")]
        public virtual string PoolId
        {
            get
            {
                return this._PoolId;
            }
            set
            {
                this.OnPoolIdChanging(value);
                this._PoolId = value;
                this.OnPoolIdChanged();
                this.OnPropertyChanged("PoolId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PoolId;
        partial void OnPoolIdChanging(string value);
        partial void OnPoolIdChanged();
        /// <summary>
        /// There are no comments for Property PoolName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PoolName")]
        public virtual string PoolName
        {
            get
            {
                return this._PoolName;
            }
            set
            {
                this.OnPoolNameChanging(value);
                this._PoolName = value;
                this.OnPoolNameChanged();
                this.OnPropertyChanged("PoolName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PoolName;
        partial void OnPoolNameChanging(string value);
        partial void OnPoolNameChanged();
        /// <summary>
        /// There are no comments for Property ProductionOrderHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionOrderHeaders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader> ProductionOrderHeaders
        {
            get
            {
                return this._ProductionOrderHeaders;
            }
            set
            {
                this.OnProductionOrderHeadersChanging(value);
                this._ProductionOrderHeaders = value;
                this.OnProductionOrderHeadersChanged();
                this.OnPropertyChanged("ProductionOrderHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader> _ProductionOrderHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductionOrderHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductionOrderHeader> value);
        partial void OnProductionOrderHeadersChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
