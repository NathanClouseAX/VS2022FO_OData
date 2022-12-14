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
    /// There are no comments for RetailPackageLinesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackageLinesSingle")]
    public partial class RetailPackageLinesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailPackageLines>
    {
        /// <summary>
        /// Initialize a new RetailPackageLinesSingle object.
        /// </summary>
        public RetailPackageLinesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailPackageLinesSingle object.
        /// </summary>
        public RetailPackageLinesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailPackageLinesSingle object.
        /// </summary>
        public RetailPackageLinesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailPackageLines> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
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
    /// There are no comments for RetailPackageLines in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PackageId
    /// ItemId
    /// PurchaseUnit
    /// Color
    /// Size
    /// Style
    /// ConfigId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PackageId", "ItemId", "PurchaseUnit", "Color", "Size", "Style", "ConfigId")]
    [global::Microsoft.OData.Client.EntitySet("RetailPackageLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailPackageLines")]
    public partial class RetailPackageLines : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailPackageLines object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="packageId">Initial value of PackageId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="purchaseUnit">Initial value of PurchaseUnit.</param>
        /// <param name="color">Initial value of Color.</param>
        /// <param name="size">Initial value of Size.</param>
        /// <param name="style">Initial value of Style.</param>
        /// <param name="configId">Initial value of ConfigId.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="releasedProductV2">Initial value of ReleasedProductV2.</param>
        /// <param name="retailPackage">Initial value of RetailPackage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailPackageLines CreateRetailPackageLines(string dataAreaId, 
                    string packageId, 
                    string itemId, 
                    string purchaseUnit, 
                    string color, 
                    string size, 
                    string style, 
                    string configId, 
                    decimal quantity, 
                    decimal lineNumber, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProductV2, 
                    global::Microsoft.Dynamics.DataEntities.RetailPackage retailPackage)
        {
            RetailPackageLines retailPackageLines = new RetailPackageLines();
            retailPackageLines.DataAreaId = dataAreaId;
            retailPackageLines.PackageId = packageId;
            retailPackageLines.ItemId = itemId;
            retailPackageLines.PurchaseUnit = purchaseUnit;
            retailPackageLines.Color = color;
            retailPackageLines.Size = size;
            retailPackageLines.Style = style;
            retailPackageLines.ConfigId = configId;
            retailPackageLines.Quantity = quantity;
            retailPackageLines.LineNumber = lineNumber;
            if ((releasedProductV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductV2");
            }
            retailPackageLines.ReleasedProductV2 = releasedProductV2;
            if ((retailPackage == null))
            {
                throw new global::System.ArgumentNullException("retailPackage");
            }
            retailPackageLines.RetailPackage = retailPackage;
            return retailPackageLines;
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
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property PurchaseUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseUnit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseUnit is required.")]
        public virtual string PurchaseUnit
        {
            get
            {
                return this._PurchaseUnit;
            }
            set
            {
                this.OnPurchaseUnitChanging(value);
                this._PurchaseUnit = value;
                this.OnPurchaseUnitChanged();
                this.OnPropertyChanged("PurchaseUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseUnit;
        partial void OnPurchaseUnitChanging(string value);
        partial void OnPurchaseUnitChanged();
        /// <summary>
        /// There are no comments for Property Color in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Color")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Color is required.")]
        public virtual string Color
        {
            get
            {
                return this._Color;
            }
            set
            {
                this.OnColorChanging(value);
                this._Color = value;
                this.OnColorChanged();
                this.OnPropertyChanged("Color");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Color;
        partial void OnColorChanging(string value);
        partial void OnColorChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Size")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Size is required.")]
        public virtual string Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Size;
        partial void OnSizeChanging(string value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property Style in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Style")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Style is required.")]
        public virtual string Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this.OnStyleChanging(value);
                this._Style = value;
                this.OnStyleChanged();
                this.OnPropertyChanged("Style");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Style;
        partial void OnStyleChanging(string value);
        partial void OnStyleChanged();
        /// <summary>
        /// There are no comments for Property ConfigId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfigId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConfigId is required.")]
        public virtual string ConfigId
        {
            get
            {
                return this._ConfigId;
            }
            set
            {
                this.OnConfigIdChanging(value);
                this._ConfigId = value;
                this.OnConfigIdChanged();
                this.OnPropertyChanged("ConfigId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfigId;
        partial void OnConfigIdChanging(string value);
        partial void OnConfigIdChanged();
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
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
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
