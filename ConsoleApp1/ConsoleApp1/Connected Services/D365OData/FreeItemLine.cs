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
    /// There are no comments for FreeItemLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FreeItemLineSingle")]
    public partial class FreeItemLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FreeItemLine>
    {
        /// <summary>
        /// Initialize a new FreeItemLineSingle object.
        /// </summary>
        public FreeItemLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FreeItemLineSingle object.
        /// </summary>
        public FreeItemLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FreeItemLineSingle object.
        /// </summary>
        public FreeItemLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FreeItemLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FreeItemLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FreeItemId
    /// FreeItemGroup
    /// ProductDisplayProductNumber
    /// UnitOfMeasure_Symbol
    /// InventSiteId
    /// InventLocationId
    /// VariantDisplayProductNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FreeItemId", "FreeItemGroup", "ProductDisplayProductNumber", "UnitOfMeasure_Symbol", "InventSiteId", "InventLocationId", "VariantDisplayProductNumber")]
    [global::Microsoft.OData.Client.EntitySet("FreeItemLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FreeItemLine")]
    public partial class FreeItemLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FreeItemLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="freeItemId">Initial value of FreeItemId.</param>
        /// <param name="freeItemGroup">Initial value of FreeItemGroup.</param>
        /// <param name="productDisplayProductNumber">Initial value of ProductDisplayProductNumber.</param>
        /// <param name="unitOfMeasure_Symbol">Initial value of UnitOfMeasure_Symbol.</param>
        /// <param name="inventSiteId">Initial value of InventSiteId.</param>
        /// <param name="inventLocationId">Initial value of InventLocationId.</param>
        /// <param name="variantDisplayProductNumber">Initial value of VariantDisplayProductNumber.</param>
        /// <param name="freeItemLineQtyFactor">Initial value of FreeItemLineQtyFactor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FreeItemLine CreateFreeItemLine(string dataAreaId, 
                    string freeItemId, 
                    int freeItemGroup, 
                    string productDisplayProductNumber, 
                    string unitOfMeasure_Symbol, 
                    string inventSiteId, 
                    string inventLocationId, 
                    string variantDisplayProductNumber, 
                    int freeItemLineQtyFactor)
        {
            FreeItemLine freeItemLine = new FreeItemLine();
            freeItemLine.DataAreaId = dataAreaId;
            freeItemLine.FreeItemId = freeItemId;
            freeItemLine.FreeItemGroup = freeItemGroup;
            freeItemLine.ProductDisplayProductNumber = productDisplayProductNumber;
            freeItemLine.UnitOfMeasure_Symbol = unitOfMeasure_Symbol;
            freeItemLine.InventSiteId = inventSiteId;
            freeItemLine.InventLocationId = inventLocationId;
            freeItemLine.VariantDisplayProductNumber = variantDisplayProductNumber;
            freeItemLine.FreeItemLineQtyFactor = freeItemLineQtyFactor;
            return freeItemLine;
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
        /// There are no comments for Property FreeItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FreeItemId is required.")]
        public virtual string FreeItemId
        {
            get
            {
                return this._FreeItemId;
            }
            set
            {
                this.OnFreeItemIdChanging(value);
                this._FreeItemId = value;
                this.OnFreeItemIdChanged();
                this.OnPropertyChanged("FreeItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FreeItemId;
        partial void OnFreeItemIdChanging(string value);
        partial void OnFreeItemIdChanged();
        /// <summary>
        /// There are no comments for Property FreeItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeItemGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FreeItemGroup is required.")]
        public virtual int FreeItemGroup
        {
            get
            {
                return this._FreeItemGroup;
            }
            set
            {
                this.OnFreeItemGroupChanging(value);
                this._FreeItemGroup = value;
                this.OnFreeItemGroupChanged();
                this.OnPropertyChanged("FreeItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FreeItemGroup;
        partial void OnFreeItemGroupChanging(int value);
        partial void OnFreeItemGroupChanged();
        /// <summary>
        /// There are no comments for Property ProductDisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductDisplayProductNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductDisplayProductNumber is required.")]
        public virtual string ProductDisplayProductNumber
        {
            get
            {
                return this._ProductDisplayProductNumber;
            }
            set
            {
                this.OnProductDisplayProductNumberChanging(value);
                this._ProductDisplayProductNumber = value;
                this.OnProductDisplayProductNumberChanged();
                this.OnPropertyChanged("ProductDisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductDisplayProductNumber;
        partial void OnProductDisplayProductNumberChanging(string value);
        partial void OnProductDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasure_Symbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasure_Symbol")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitOfMeasure_Symbol is required.")]
        public virtual string UnitOfMeasure_Symbol
        {
            get
            {
                return this._UnitOfMeasure_Symbol;
            }
            set
            {
                this.OnUnitOfMeasure_SymbolChanging(value);
                this._UnitOfMeasure_Symbol = value;
                this.OnUnitOfMeasure_SymbolChanged();
                this.OnPropertyChanged("UnitOfMeasure_Symbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasure_Symbol;
        partial void OnUnitOfMeasure_SymbolChanging(string value);
        partial void OnUnitOfMeasure_SymbolChanged();
        /// <summary>
        /// There are no comments for Property InventSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventSiteId is required.")]
        public virtual string InventSiteId
        {
            get
            {
                return this._InventSiteId;
            }
            set
            {
                this.OnInventSiteIdChanging(value);
                this._InventSiteId = value;
                this.OnInventSiteIdChanged();
                this.OnPropertyChanged("InventSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventSiteId;
        partial void OnInventSiteIdChanging(string value);
        partial void OnInventSiteIdChanged();
        /// <summary>
        /// There are no comments for Property InventLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventLocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventLocationId is required.")]
        public virtual string InventLocationId
        {
            get
            {
                return this._InventLocationId;
            }
            set
            {
                this.OnInventLocationIdChanging(value);
                this._InventLocationId = value;
                this.OnInventLocationIdChanged();
                this.OnPropertyChanged("InventLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventLocationId;
        partial void OnInventLocationIdChanging(string value);
        partial void OnInventLocationIdChanged();
        /// <summary>
        /// There are no comments for Property VariantDisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VariantDisplayProductNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VariantDisplayProductNumber is required.")]
        public virtual string VariantDisplayProductNumber
        {
            get
            {
                return this._VariantDisplayProductNumber;
            }
            set
            {
                this.OnVariantDisplayProductNumberChanging(value);
                this._VariantDisplayProductNumber = value;
                this.OnVariantDisplayProductNumberChanged();
                this.OnPropertyChanged("VariantDisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VariantDisplayProductNumber;
        partial void OnVariantDisplayProductNumberChanging(string value);
        partial void OnVariantDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property FreeItemLineQtyFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeItemLineQtyFactor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FreeItemLineQtyFactor is required.")]
        public virtual int FreeItemLineQtyFactor
        {
            get
            {
                return this._FreeItemLineQtyFactor;
            }
            set
            {
                this.OnFreeItemLineQtyFactorChanging(value);
                this._FreeItemLineQtyFactor = value;
                this.OnFreeItemLineQtyFactorChanged();
                this.OnPropertyChanged("FreeItemLineQtyFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FreeItemLineQtyFactor;
        partial void OnFreeItemLineQtyFactorChanging(int value);
        partial void OnFreeItemLineQtyFactorChanged();
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
