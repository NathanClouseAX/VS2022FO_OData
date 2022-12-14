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
    /// There are no comments for RetailInfocodeCategorySpecificSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInfocodeCategorySpecificSingle")]
    public partial class RetailInfocodeCategorySpecificSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInfocodeCategorySpecific>
    {
        /// <summary>
        /// Initialize a new RetailInfocodeCategorySpecificSingle object.
        /// </summary>
        public RetailInfocodeCategorySpecificSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInfocodeCategorySpecificSingle object.
        /// </summary>
        public RetailInfocodeCategorySpecificSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInfocodeCategorySpecificSingle object.
        /// </summary>
        public RetailInfocodeCategorySpecificSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInfocodeCategorySpecific> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailInfocodeCategorySpecific in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProductCategoryHierarchyName
    /// CategoryName
    /// InfoCodeNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductCategoryHierarchyName", "CategoryName", "InfoCodeNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailInfocodeCategorySpecifics")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInfocodeCategorySpecific")]
    public partial class RetailInfocodeCategorySpecific : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInfocodeCategorySpecific object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="productCategoryHierarchyName">Initial value of ProductCategoryHierarchyName.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        /// <param name="infoCodeNumber">Initial value of InfoCodeNumber.</param>
        /// <param name="sequence">Initial value of Sequence.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInfocodeCategorySpecific CreateRetailInfocodeCategorySpecific(string dataAreaId, string productCategoryHierarchyName, string categoryName, string infoCodeNumber, int sequence)
        {
            RetailInfocodeCategorySpecific retailInfocodeCategorySpecific = new RetailInfocodeCategorySpecific();
            retailInfocodeCategorySpecific.DataAreaId = dataAreaId;
            retailInfocodeCategorySpecific.ProductCategoryHierarchyName = productCategoryHierarchyName;
            retailInfocodeCategorySpecific.CategoryName = categoryName;
            retailInfocodeCategorySpecific.InfoCodeNumber = infoCodeNumber;
            retailInfocodeCategorySpecific.Sequence = sequence;
            return retailInfocodeCategorySpecific;
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
        /// There are no comments for Property ProductCategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductCategoryHierarchyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductCategoryHierarchyName is required.")]
        public virtual string ProductCategoryHierarchyName
        {
            get
            {
                return this._ProductCategoryHierarchyName;
            }
            set
            {
                this.OnProductCategoryHierarchyNameChanging(value);
                this._ProductCategoryHierarchyName = value;
                this.OnProductCategoryHierarchyNameChanged();
                this.OnPropertyChanged("ProductCategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductCategoryHierarchyName;
        partial void OnProductCategoryHierarchyNameChanging(string value);
        partial void OnProductCategoryHierarchyNameChanged();
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
        /// There are no comments for Property InfoCodeNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InfoCodeNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InfoCodeNumber is required.")]
        public virtual string InfoCodeNumber
        {
            get
            {
                return this._InfoCodeNumber;
            }
            set
            {
                this.OnInfoCodeNumberChanging(value);
                this._InfoCodeNumber = value;
                this.OnInfoCodeNumberChanged();
                this.OnPropertyChanged("InfoCodeNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InfoCodeNumber;
        partial void OnInfoCodeNumberChanging(string value);
        partial void OnInfoCodeNumberChanged();
        /// <summary>
        /// There are no comments for Property InputRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InputRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InputRequired
        {
            get
            {
                return this._InputRequired;
            }
            set
            {
                this.OnInputRequiredChanging(value);
                this._InputRequired = value;
                this.OnInputRequiredChanged();
                this.OnPropertyChanged("InputRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InputRequired;
        partial void OnInputRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInputRequiredChanged();
        /// <summary>
        /// There are no comments for Property WhenRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WhenRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailNoneAlwaysPositiveNegative> WhenRequired
        {
            get
            {
                return this._WhenRequired;
            }
            set
            {
                this.OnWhenRequiredChanging(value);
                this._WhenRequired = value;
                this.OnWhenRequiredChanged();
                this.OnPropertyChanged("WhenRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailNoneAlwaysPositiveNegative> _WhenRequired;
        partial void OnWhenRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailNoneAlwaysPositiveNegative> value);
        partial void OnWhenRequiredChanged();
        /// <summary>
        /// There are no comments for Property Sequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Sequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Sequence is required.")]
        public virtual int Sequence
        {
            get
            {
                return this._Sequence;
            }
            set
            {
                this.OnSequenceChanging(value);
                this._Sequence = value;
                this.OnSequenceChanged();
                this.OnPropertyChanged("Sequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Sequence;
        partial void OnSequenceChanging(int value);
        partial void OnSequenceChanged();
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
