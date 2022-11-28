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
    /// There are no comments for ProductCommonDataServiceCategoryAssignmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductCommonDataServiceCategoryAssignmentSingle")]
    public partial class ProductCommonDataServiceCategoryAssignmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductCommonDataServiceCategoryAssignment>
    {
        /// <summary>
        /// Initialize a new ProductCommonDataServiceCategoryAssignmentSingle object.
        /// </summary>
        public ProductCommonDataServiceCategoryAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductCommonDataServiceCategoryAssignmentSingle object.
        /// </summary>
        public ProductCommonDataServiceCategoryAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductCommonDataServiceCategoryAssignmentSingle object.
        /// </summary>
        public ProductCommonDataServiceCategoryAssignmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductCommonDataServiceCategoryAssignment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductCommonDataServiceCategoryAssignment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// Category
    /// CategoryHierarchy
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber", "Category", "CategoryHierarchy")]
    [global::Microsoft.OData.Client.EntitySet("ProductCommonDataServiceCategoryAssignments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductCommonDataServiceCategoryAssignment")]
    public partial class ProductCommonDataServiceCategoryAssignment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductCommonDataServiceCategoryAssignment object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="categoryHierarchy">Initial value of CategoryHierarchy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductCommonDataServiceCategoryAssignment CreateProductCommonDataServiceCategoryAssignment(string productNumber, long category, long categoryHierarchy)
        {
            ProductCommonDataServiceCategoryAssignment productCommonDataServiceCategoryAssignment = new ProductCommonDataServiceCategoryAssignment();
            productCommonDataServiceCategoryAssignment.ProductNumber = productNumber;
            productCommonDataServiceCategoryAssignment.Category = category;
            productCommonDataServiceCategoryAssignment.CategoryHierarchy = categoryHierarchy;
            return productCommonDataServiceCategoryAssignment;
        }
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
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Category is required.")]
        public virtual long Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Category;
        partial void OnCategoryChanging(long value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryHierarchy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryHierarchy is required.")]
        public virtual long CategoryHierarchy
        {
            get
            {
                return this._CategoryHierarchy;
            }
            set
            {
                this.OnCategoryHierarchyChanging(value);
                this._CategoryHierarchy = value;
                this.OnCategoryHierarchyChanged();
                this.OnPropertyChanged("CategoryHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CategoryHierarchy;
        partial void OnCategoryHierarchyChanging(long value);
        partial void OnCategoryHierarchyChanged();
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