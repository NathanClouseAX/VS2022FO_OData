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
    /// There are no comments for ProductNumberIdentifiedBarcodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductNumberIdentifiedBarcodeSingle")]
    public partial class ProductNumberIdentifiedBarcodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductNumberIdentifiedBarcode>
    {
        /// <summary>
        /// Initialize a new ProductNumberIdentifiedBarcodeSingle object.
        /// </summary>
        public ProductNumberIdentifiedBarcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductNumberIdentifiedBarcodeSingle object.
        /// </summary>
        public ProductNumberIdentifiedBarcodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductNumberIdentifiedBarcodeSingle object.
        /// </summary>
        public ProductNumberIdentifiedBarcodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductNumberIdentifiedBarcode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BarcodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetup")]
        public virtual global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle BarcodeSetup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BarcodeSetup == null))
                {
                    this._BarcodeSetup = new global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle(this.Context, GetPath("BarcodeSetup"));
                }
                return this._BarcodeSetup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BarcodeSetupSingle _BarcodeSetup;
    }
    /// <summary>
    /// There are no comments for ProductNumberIdentifiedBarcode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProductNumber
    /// ProductQuantityUnitSymbol
    /// BarcodeSetupId
    /// Barcode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductNumber", "ProductQuantityUnitSymbol", "BarcodeSetupId", "Barcode")]
    [global::Microsoft.OData.Client.EntitySet("ProductNumberIdentifiedBarcodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductNumberIdentifiedBarcode")]
    public partial class ProductNumberIdentifiedBarcode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductNumberIdentifiedBarcode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="productQuantityUnitSymbol">Initial value of ProductQuantityUnitSymbol.</param>
        /// <param name="barcodeSetupId">Initial value of BarcodeSetupId.</param>
        /// <param name="barcode">Initial value of Barcode.</param>
        /// <param name="productQuantity">Initial value of ProductQuantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductNumberIdentifiedBarcode CreateProductNumberIdentifiedBarcode(string dataAreaId, 
                    string productNumber, 
                    string productQuantityUnitSymbol, 
                    string barcodeSetupId, 
                    string barcode, 
                    decimal productQuantity)
        {
            ProductNumberIdentifiedBarcode productNumberIdentifiedBarcode = new ProductNumberIdentifiedBarcode();
            productNumberIdentifiedBarcode.DataAreaId = dataAreaId;
            productNumberIdentifiedBarcode.ProductNumber = productNumber;
            productNumberIdentifiedBarcode.ProductQuantityUnitSymbol = productQuantityUnitSymbol;
            productNumberIdentifiedBarcode.BarcodeSetupId = barcodeSetupId;
            productNumberIdentifiedBarcode.Barcode = barcode;
            productNumberIdentifiedBarcode.ProductQuantity = productQuantity;
            return productNumberIdentifiedBarcode;
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
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductNumber is required.")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductQuantityUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductQuantityUnitSymbol")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductQuantityUnitSymbol is required.")]
        public virtual string ProductQuantityUnitSymbol
        {
            get
            {
                return this._ProductQuantityUnitSymbol;
            }
            set
            {
                this.OnProductQuantityUnitSymbolChanging(value);
                this._ProductQuantityUnitSymbol = value;
                this.OnProductQuantityUnitSymbolChanged();
                this.OnPropertyChanged("ProductQuantityUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductQuantityUnitSymbol;
        partial void OnProductQuantityUnitSymbolChanging(string value);
        partial void OnProductQuantityUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property BarcodeSetupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BarcodeSetupId is required.")]
        public virtual string BarcodeSetupId
        {
            get
            {
                return this._BarcodeSetupId;
            }
            set
            {
                this.OnBarcodeSetupIdChanging(value);
                this._BarcodeSetupId = value;
                this.OnBarcodeSetupIdChanged();
                this.OnPropertyChanged("BarcodeSetupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BarcodeSetupId;
        partial void OnBarcodeSetupIdChanging(string value);
        partial void OnBarcodeSetupIdChanged();
        /// <summary>
        /// There are no comments for Property Barcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Barcode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Barcode is required.")]
        public virtual string Barcode
        {
            get
            {
                return this._Barcode;
            }
            set
            {
                this.OnBarcodeChanging(value);
                this._Barcode = value;
                this.OnBarcodeChanged();
                this.OnPropertyChanged("Barcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Barcode;
        partial void OnBarcodeChanging(string value);
        partial void OnBarcodeChanged();
        /// <summary>
        /// There are no comments for Property ProductDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductDescription")]
        public virtual string ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this.OnProductDescriptionChanging(value);
                this._ProductDescription = value;
                this.OnProductDescriptionChanged();
                this.OnPropertyChanged("ProductDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductDescription;
        partial void OnProductDescriptionChanging(string value);
        partial void OnProductDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultScannedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefaultScannedBarcode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultScannedBarcode
        {
            get
            {
                return this._IsDefaultScannedBarcode;
            }
            set
            {
                this.OnIsDefaultScannedBarcodeChanging(value);
                this._IsDefaultScannedBarcode = value;
                this.OnIsDefaultScannedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultScannedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultScannedBarcode;
        partial void OnIsDefaultScannedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultScannedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultDisplayedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefaultDisplayedBarcode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultDisplayedBarcode
        {
            get
            {
                return this._IsDefaultDisplayedBarcode;
            }
            set
            {
                this.OnIsDefaultDisplayedBarcodeChanging(value);
                this._IsDefaultDisplayedBarcode = value;
                this.OnIsDefaultDisplayedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultDisplayedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultDisplayedBarcode;
        partial void OnIsDefaultDisplayedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultDisplayedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultPrintedBarcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefaultPrintedBarcode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultPrintedBarcode
        {
            get
            {
                return this._IsDefaultPrintedBarcode;
            }
            set
            {
                this.OnIsDefaultPrintedBarcodeChanging(value);
                this._IsDefaultPrintedBarcode = value;
                this.OnIsDefaultPrintedBarcodeChanged();
                this.OnPropertyChanged("IsDefaultPrintedBarcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultPrintedBarcode;
        partial void OnIsDefaultPrintedBarcodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultPrintedBarcodeChanged();
        /// <summary>
        /// There are no comments for Property ProductQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductQuantity is required.")]
        public virtual decimal ProductQuantity
        {
            get
            {
                return this._ProductQuantity;
            }
            set
            {
                this.OnProductQuantityChanging(value);
                this._ProductQuantity = value;
                this.OnProductQuantityChanged();
                this.OnPropertyChanged("ProductQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProductQuantity;
        partial void OnProductQuantityChanging(decimal value);
        partial void OnProductQuantityChanged();
        /// <summary>
        /// There are no comments for Property BarcodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BarcodeSetup")]
        public virtual global::Microsoft.Dynamics.DataEntities.BarcodeSetup BarcodeSetup
        {
            get
            {
                return this._BarcodeSetup;
            }
            set
            {
                this.OnBarcodeSetupChanging(value);
                this._BarcodeSetup = value;
                this.OnBarcodeSetupChanged();
                this.OnPropertyChanged("BarcodeSetup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BarcodeSetup _BarcodeSetup;
        partial void OnBarcodeSetupChanging(global::Microsoft.Dynamics.DataEntities.BarcodeSetup value);
        partial void OnBarcodeSetupChanged();
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