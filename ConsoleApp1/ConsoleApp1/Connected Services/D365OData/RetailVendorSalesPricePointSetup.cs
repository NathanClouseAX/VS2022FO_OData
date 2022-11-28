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
    /// There are no comments for RetailVendorSalesPricePointSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVendorSalesPricePointSetupSingle")]
    public partial class RetailVendorSalesPricePointSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailVendorSalesPricePointSetup>
    {
        /// <summary>
        /// Initialize a new RetailVendorSalesPricePointSetupSingle object.
        /// </summary>
        public RetailVendorSalesPricePointSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailVendorSalesPricePointSetupSingle object.
        /// </summary>
        public RetailVendorSalesPricePointSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailVendorSalesPricePointSetupSingle object.
        /// </summary>
        public RetailVendorSalesPricePointSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailVendorSalesPricePointSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailVendorSalesPricePointSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// VendorAccount
    /// SuggestedRetailPrice
    /// CategoryName
    /// CategoryHierarchyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VendorAccount", "suggestedRetailPrice", "CategoryName", "CategoryHierarchyName")]
    [global::Microsoft.OData.Client.EntitySet("RetailVendorSalesPricePointSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVendorSalesPricePointSetup")]
    public partial class RetailVendorSalesPricePointSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailVendorSalesPricePointSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="vendorAccount">Initial value of VendorAccount.</param>
        /// <param name="suggestedRetailPrice">Initial value of SuggestedRetailPrice.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="categoryHierarchyName">Initial value of CategoryHierarchyName.</param>
        /// <param name="salesPrice">Initial value of SalesPrice.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailVendorSalesPricePointSetup CreateRetailVendorSalesPricePointSetup(string dataAreaId, 
                    string vendorAccount, 
                    decimal suggestedRetailPrice, 
                    string categoryName, 
                    string categoryHierarchyName, 
                    decimal salesPrice)
        {
            RetailVendorSalesPricePointSetup retailVendorSalesPricePointSetup = new RetailVendorSalesPricePointSetup();
            retailVendorSalesPricePointSetup.DataAreaId = dataAreaId;
            retailVendorSalesPricePointSetup.VendorAccount = vendorAccount;
            retailVendorSalesPricePointSetup.SuggestedRetailPrice = suggestedRetailPrice;
            retailVendorSalesPricePointSetup.CategoryName = categoryName;
            retailVendorSalesPricePointSetup.CategoryHierarchyName = categoryHierarchyName;
            retailVendorSalesPricePointSetup.SalesPrice = salesPrice;
            return retailVendorSalesPricePointSetup;
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
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorAccount is required.")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property SuggestedRetailPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("suggestedRetailPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuggestedRetailPrice is required.")]
        public virtual decimal SuggestedRetailPrice
        {
            get
            {
                return this._SuggestedRetailPrice;
            }
            set
            {
                this.OnSuggestedRetailPriceChanging(value);
                this._SuggestedRetailPrice = value;
                this.OnSuggestedRetailPriceChanged();
                this.OnPropertyChanged("suggestedRetailPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SuggestedRetailPrice;
        partial void OnSuggestedRetailPriceChanging(decimal value);
        partial void OnSuggestedRetailPriceChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryName is required.")]
        public virtual string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryHierarchyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CategoryHierarchyName is required.")]
        public virtual string CategoryHierarchyName
        {
            get
            {
                return this._CategoryHierarchyName;
            }
            set
            {
                this.OnCategoryHierarchyNameChanging(value);
                this._CategoryHierarchyName = value;
                this.OnCategoryHierarchyNameChanged();
                this.OnPropertyChanged("CategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryHierarchyName;
        partial void OnCategoryHierarchyNameChanging(string value);
        partial void OnCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property SalesPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesPrice is required.")]
        public virtual decimal SalesPrice
        {
            get
            {
                return this._SalesPrice;
            }
            set
            {
                this.OnSalesPriceChanging(value);
                this._SalesPrice = value;
                this.OnSalesPriceChanged();
                this.OnPropertyChanged("SalesPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesPrice;
        partial void OnSalesPriceChanging(decimal value);
        partial void OnSalesPriceChanged();
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