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
    /// There are no comments for RetailVendorSalesPriceMarginSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVendorSalesPriceMarginSetupSingle")]
    public partial class RetailVendorSalesPriceMarginSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailVendorSalesPriceMarginSetup>
    {
        /// <summary>
        /// Initialize a new RetailVendorSalesPriceMarginSetupSingle object.
        /// </summary>
        public RetailVendorSalesPriceMarginSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailVendorSalesPriceMarginSetupSingle object.
        /// </summary>
        public RetailVendorSalesPriceMarginSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailVendorSalesPriceMarginSetupSingle object.
        /// </summary>
        public RetailVendorSalesPriceMarginSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailVendorSalesPriceMarginSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailVendorSalesPriceMarginSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CategoryName
    /// CategoryHierarchyName
    /// VendorAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CategoryName", "CategoryHierarchyName", "VendorAccount")]
    [global::Microsoft.OData.Client.EntitySet("RetailVendorSalesPriceMarginSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVendorSalesPriceMarginSetup")]
    public partial class RetailVendorSalesPriceMarginSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailVendorSalesPriceMarginSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="categoryHierarchyName">Initial value of CategoryHierarchyName.</param>
        /// <param name="vendorAccount">Initial value of VendorAccount.</param>
        /// <param name="suggestedContributionRatio">Initial value of SuggestedContributionRatio.</param>
        /// <param name="contributionRatio">Initial value of ContributionRatio.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailVendorSalesPriceMarginSetup CreateRetailVendorSalesPriceMarginSetup(string dataAreaId, 
                    string categoryName, 
                    string categoryHierarchyName, 
                    string vendorAccount, 
                    decimal suggestedContributionRatio, 
                    decimal contributionRatio)
        {
            RetailVendorSalesPriceMarginSetup retailVendorSalesPriceMarginSetup = new RetailVendorSalesPriceMarginSetup();
            retailVendorSalesPriceMarginSetup.DataAreaId = dataAreaId;
            retailVendorSalesPriceMarginSetup.CategoryName = categoryName;
            retailVendorSalesPriceMarginSetup.CategoryHierarchyName = categoryHierarchyName;
            retailVendorSalesPriceMarginSetup.VendorAccount = vendorAccount;
            retailVendorSalesPriceMarginSetup.SuggestedContributionRatio = suggestedContributionRatio;
            retailVendorSalesPriceMarginSetup.ContributionRatio = contributionRatio;
            return retailVendorSalesPriceMarginSetup;
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
        /// There are no comments for Property SuggestedContributionRatio in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("suggestedContributionRatio")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuggestedContributionRatio is required.")]
        public virtual decimal SuggestedContributionRatio
        {
            get
            {
                return this._SuggestedContributionRatio;
            }
            set
            {
                this.OnSuggestedContributionRatioChanging(value);
                this._SuggestedContributionRatio = value;
                this.OnSuggestedContributionRatioChanged();
                this.OnPropertyChanged("suggestedContributionRatio");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SuggestedContributionRatio;
        partial void OnSuggestedContributionRatioChanging(decimal value);
        partial void OnSuggestedContributionRatioChanged();
        /// <summary>
        /// There are no comments for Property ContributionRatio in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContributionRatio")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContributionRatio is required.")]
        public virtual decimal ContributionRatio
        {
            get
            {
                return this._ContributionRatio;
            }
            set
            {
                this.OnContributionRatioChanging(value);
                this._ContributionRatio = value;
                this.OnContributionRatioChanged();
                this.OnPropertyChanged("ContributionRatio");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ContributionRatio;
        partial void OnContributionRatioChanging(decimal value);
        partial void OnContributionRatioChanged();
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
