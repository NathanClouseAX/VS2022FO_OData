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
    /// There are no comments for RetailPackagePurchaseSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackagePurchaseSingle")]
    public partial class RetailPackagePurchaseSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailPackagePurchase>
    {
        /// <summary>
        /// Initialize a new RetailPackagePurchaseSingle object.
        /// </summary>
        public RetailPackagePurchaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailPackagePurchaseSingle object.
        /// </summary>
        public RetailPackagePurchaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailPackagePurchaseSingle object.
        /// </summary>
        public RetailPackagePurchaseSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailPackagePurchase> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailPackage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackage")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailPackageSingle RetailPackage
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailPackage == null))
                {
                    this._RetailPackage = new global::Microsoft.Dynamics.DataEntities.RetailPackageSingle(this.Context, GetPath("RetailPackage"));
                }
                return this._RetailPackage;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailPackageSingle _RetailPackage;
    }
    /// <summary>
    /// There are no comments for RetailPackagePurchase in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PurchaseId
    /// PackageId
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseId", "PackageId", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailPackagePurchases")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackagePurchase")]
    public partial class RetailPackagePurchase : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailPackagePurchase object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="purchaseId">Initial value of PurchaseId.</param>
        /// <param name="packageId">Initial value of PackageId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="quantityReceived">Initial value of QuantityReceived.</param>
        /// <param name="allocatedCrossDockQty">Initial value of AllocatedCrossDockQty.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="retailPackage">Initial value of RetailPackage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailPackagePurchase CreateRetailPackagePurchase(string dataAreaId, 
                    string purchaseId, 
                    string packageId, 
                    decimal lineNumber, 
                    decimal quantityReceived, 
                    int allocatedCrossDockQty, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.RetailPackage retailPackage)
        {
            RetailPackagePurchase retailPackagePurchase = new RetailPackagePurchase();
            retailPackagePurchase.DataAreaId = dataAreaId;
            retailPackagePurchase.PurchaseId = purchaseId;
            retailPackagePurchase.PackageId = packageId;
            retailPackagePurchase.LineNumber = lineNumber;
            retailPackagePurchase.QuantityReceived = quantityReceived;
            retailPackagePurchase.AllocatedCrossDockQty = allocatedCrossDockQty;
            retailPackagePurchase.Quantity = quantity;
            if ((retailPackage == null))
            {
                throw new global::System.ArgumentNullException("retailPackage");
            }
            retailPackagePurchase.RetailPackage = retailPackage;
            return retailPackagePurchase;
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
        /// There are no comments for Property PurchaseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseId is required.")]
        public virtual string PurchaseId
        {
            get
            {
                return this._PurchaseId;
            }
            set
            {
                this.OnPurchaseIdChanging(value);
                this._PurchaseId = value;
                this.OnPurchaseIdChanged();
                this.OnPropertyChanged("PurchaseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseId;
        partial void OnPurchaseIdChanging(string value);
        partial void OnPurchaseIdChanged();
        /// <summary>
        /// There are no comments for Property PackageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PackageId is required.")]
        public virtual string PackageId
        {
            get
            {
                return this._PackageId;
            }
            set
            {
                this.OnPackageIdChanging(value);
                this._PackageId = value;
                this.OnPackageIdChanged();
                this.OnPropertyChanged("PackageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackageId;
        partial void OnPackageIdChanging(string value);
        partial void OnPackageIdChanged();
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
        /// There are no comments for Property QuantityReceived in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuantityReceived")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuantityReceived is required.")]
        public virtual decimal QuantityReceived
        {
            get
            {
                return this._QuantityReceived;
            }
            set
            {
                this.OnQuantityReceivedChanging(value);
                this._QuantityReceived = value;
                this.OnQuantityReceivedChanged();
                this.OnPropertyChanged("QuantityReceived");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _QuantityReceived;
        partial void OnQuantityReceivedChanging(decimal value);
        partial void OnQuantityReceivedChanged();
        /// <summary>
        /// There are no comments for Property AllocatedCrossDockQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocatedCrossDockQty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AllocatedCrossDockQty is required.")]
        public virtual int AllocatedCrossDockQty
        {
            get
            {
                return this._AllocatedCrossDockQty;
            }
            set
            {
                this.OnAllocatedCrossDockQtyChanging(value);
                this._AllocatedCrossDockQty = value;
                this.OnAllocatedCrossDockQtyChanged();
                this.OnPropertyChanged("AllocatedCrossDockQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AllocatedCrossDockQty;
        partial void OnAllocatedCrossDockQtyChanging(int value);
        partial void OnAllocatedCrossDockQtyChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property RetailPackage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailPackage is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailPackage RetailPackage
        {
            get
            {
                return this._RetailPackage;
            }
            set
            {
                this.OnRetailPackageChanging(value);
                this._RetailPackage = value;
                this.OnRetailPackageChanged();
                this.OnPropertyChanged("RetailPackage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailPackage _RetailPackage;
        partial void OnRetailPackageChanging(global::Microsoft.Dynamics.DataEntities.RetailPackage value);
        partial void OnRetailPackageChanged();
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
