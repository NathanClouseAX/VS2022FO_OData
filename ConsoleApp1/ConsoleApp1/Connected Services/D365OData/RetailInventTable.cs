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
    /// There are no comments for RetailInventTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInventTableSingle")]
    public partial class RetailInventTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInventTable>
    {
        /// <summary>
        /// Initialize a new RetailInventTableSingle object.
        /// </summary>
        public RetailInventTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInventTableSingle object.
        /// </summary>
        public RetailInventTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInventTableSingle object.
        /// </summary>
        public RetailInventTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInventTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailInventTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemId")]
    [global::Microsoft.OData.Client.EntitySet("RetailInventTable")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInventTable")]
    public partial class RetailInventTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInventTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="product">Initial value of Product.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInventTable CreateRetailInventTable(string dataAreaId, string itemId, long product)
        {
            RetailInventTable retailInventTable = new RetailInventTable();
            retailInventTable.DataAreaId = dataAreaId;
            retailInventTable.ItemId = itemId;
            retailInventTable.Product = product;
            return retailInventTable;
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
        /// There are no comments for Property Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Product")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Product is required.")]
        public virtual long Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this.OnProductChanging(value);
                this._Product = value;
                this.OnProductChanged();
                this.OnPropertyChanged("Product");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Product;
        partial void OnProductChanging(long value);
        partial void OnProductChanged();
        /// <summary>
        /// There are no comments for Property EcoResProduct_DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EcoResProduct_DisplayProductNumber")]
        public virtual string EcoResProduct_DisplayProductNumber
        {
            get
            {
                return this._EcoResProduct_DisplayProductNumber;
            }
            set
            {
                this.OnEcoResProduct_DisplayProductNumberChanging(value);
                this._EcoResProduct_DisplayProductNumber = value;
                this.OnEcoResProduct_DisplayProductNumberChanged();
                this.OnPropertyChanged("EcoResProduct_DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EcoResProduct_DisplayProductNumber;
        partial void OnEcoResProduct_DisplayProductNumberChanging(string value);
        partial void OnEcoResProduct_DisplayProductNumberChanged();
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
