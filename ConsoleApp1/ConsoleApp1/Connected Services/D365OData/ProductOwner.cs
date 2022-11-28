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
    /// There are no comments for ProductOwnerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwnerSingle")]
    public partial class ProductOwnerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwner>
    {
        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductOwnerSingle object.
        /// </summary>
        public ProductOwnerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductOwner> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductsV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductsV3")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3> EngineeringChangeOrderProductsV3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductsV3 == null))
                {
                    this._EngineeringChangeOrderProductsV3 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3>(GetPath("EngineeringChangeOrderProductsV3"));
                }
                return this._EngineeringChangeOrderProductsV3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3> _EngineeringChangeOrderProductsV3;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2> EngineeringChangeOrderProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductsV2 == null))
                {
                    this._EngineeringChangeOrderProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2>(GetPath("EngineeringChangeOrderProductsV2"));
                }
                return this._EngineeringChangeOrderProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2> _EngineeringChangeOrderProductsV2;
        /// <summary>
        /// There are no comments for ProductOwnerWorkerAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwnerWorkerAssignments")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> ProductOwnerWorkerAssignments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductOwnerWorkerAssignments == null))
                {
                    this._ProductOwnerWorkerAssignments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker>(GetPath("ProductOwnerWorkerAssignments"));
                }
                return this._ProductOwnerWorkerAssignments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> _ProductOwnerWorkerAssignments;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProducts")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProducts == null))
                {
                    this._EngineeringChangeOrderProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(GetPath("EngineeringChangeOrderProducts"));
                }
                return this._EngineeringChangeOrderProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts;
    }
    /// <summary>
    /// There are no comments for ProductOwner in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductOwnerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductOwnerId")]
    [global::Microsoft.OData.Client.EntitySet("ProductOwners")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwner")]
    public partial class ProductOwner : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductOwner object.
        /// </summary>
        /// <param name="productOwnerId">Initial value of ProductOwnerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductOwner CreateProductOwner(string productOwnerId)
        {
            ProductOwner productOwner = new ProductOwner();
            productOwner.ProductOwnerId = productOwnerId;
            return productOwner;
        }
        /// <summary>
        /// There are no comments for Property ProductOwnerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwnerId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductOwnerId is required.")]
        public virtual string ProductOwnerId
        {
            get
            {
                return this._ProductOwnerId;
            }
            set
            {
                this.OnProductOwnerIdChanging(value);
                this._ProductOwnerId = value;
                this.OnProductOwnerIdChanged();
                this.OnPropertyChanged("ProductOwnerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductOwnerId;
        partial void OnProductOwnerIdChanging(string value);
        partial void OnProductOwnerIdChanged();
        /// <summary>
        /// There are no comments for Property ProductOwnerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwnerName")]
        public virtual string ProductOwnerName
        {
            get
            {
                return this._ProductOwnerName;
            }
            set
            {
                this.OnProductOwnerNameChanging(value);
                this._ProductOwnerName = value;
                this.OnProductOwnerNameChanged();
                this.OnPropertyChanged("ProductOwnerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductOwnerName;
        partial void OnProductOwnerNameChanging(string value);
        partial void OnProductOwnerNameChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductsV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductsV3")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3> EngineeringChangeOrderProductsV3
        {
            get
            {
                return this._EngineeringChangeOrderProductsV3;
            }
            set
            {
                this.OnEngineeringChangeOrderProductsV3Changing(value);
                this._EngineeringChangeOrderProductsV3 = value;
                this.OnEngineeringChangeOrderProductsV3Changed();
                this.OnPropertyChanged("EngineeringChangeOrderProductsV3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3> _EngineeringChangeOrderProductsV3 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductsV3Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV3> value);
        partial void OnEngineeringChangeOrderProductsV3Changed();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2> EngineeringChangeOrderProductsV2
        {
            get
            {
                return this._EngineeringChangeOrderProductsV2;
            }
            set
            {
                this.OnEngineeringChangeOrderProductsV2Changing(value);
                this._EngineeringChangeOrderProductsV2 = value;
                this.OnEngineeringChangeOrderProductsV2Changed();
                this.OnPropertyChanged("EngineeringChangeOrderProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2> _EngineeringChangeOrderProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductV2> value);
        partial void OnEngineeringChangeOrderProductsV2Changed();
        /// <summary>
        /// There are no comments for Property ProductOwnerWorkerAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductOwnerWorkerAssignments")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> ProductOwnerWorkerAssignments
        {
            get
            {
                return this._ProductOwnerWorkerAssignments;
            }
            set
            {
                this.OnProductOwnerWorkerAssignmentsChanging(value);
                this._ProductOwnerWorkerAssignments = value;
                this.OnProductOwnerWorkerAssignmentsChanged();
                this.OnPropertyChanged("ProductOwnerWorkerAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> _ProductOwnerWorkerAssignments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductOwnerWorkerAssignmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductOwnerWorker> value);
        partial void OnProductOwnerWorkerAssignmentsChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProducts")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> EngineeringChangeOrderProducts
        {
            get
            {
                return this._EngineeringChangeOrderProducts;
            }
            set
            {
                this.OnEngineeringChangeOrderProductsChanging(value);
                this._EngineeringChangeOrderProducts = value;
                this.OnEngineeringChangeOrderProductsChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> _EngineeringChangeOrderProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct> value);
        partial void OnEngineeringChangeOrderProductsChanged();
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
