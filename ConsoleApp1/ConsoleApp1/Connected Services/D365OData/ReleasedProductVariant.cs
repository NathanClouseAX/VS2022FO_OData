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
    /// There are no comments for ReleasedProductVariantSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductVariantSingle")]
    public partial class ReleasedProductVariantSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductVariant>
    {
        /// <summary>
        /// Initialize a new ReleasedProductVariantSingle object.
        /// </summary>
        public ReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedProductVariantSingle object.
        /// </summary>
        public ReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedProductVariantSingle object.
        /// </summary>
        public ReleasedProductVariantSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductVariant> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductVariantExternalCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductVariantExternalCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode> ReleasedProductVariantExternalCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductVariantExternalCodes == null))
                {
                    this._ReleasedProductVariantExternalCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode>(GetPath("ReleasedProductVariantExternalCodes"));
                }
                return this._ReleasedProductVariantExternalCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode> _ReleasedProductVariantExternalCodes;
        /// <summary>
        /// There are no comments for ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductMaster")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle ReleasedProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMaster == null))
                {
                    this._ReleasedProductMaster = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle(this.Context, GetPath("ReleasedProductMaster"));
                }
                return this._ReleasedProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterSingle _ReleasedProductMaster;
        /// <summary>
        /// There are no comments for ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductMasterV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single ReleasedProductMasterV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductMasterV2 == null))
                {
                    this._ReleasedProductMasterV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single(this.Context, GetPath("ReleasedProductMasterV2"));
                }
                return this._ReleasedProductMasterV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2Single _ReleasedProductMasterV2;
        /// <summary>
        /// There are no comments for ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMaster")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMasterSingle ProductMaster
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMaster == null))
                {
                    this._ProductMaster = new global::Microsoft.Dynamics.DataEntities.ProductMasterSingle(this.Context, GetPath("ProductMaster"));
                }
                return this._ProductMaster;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMasterSingle _ProductMaster;
        /// <summary>
        /// There are no comments for ProductLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductLifecycleState")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle ProductLifecycleState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductLifecycleState == null))
                {
                    this._ProductLifecycleState = new global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle(this.Context, GetPath("ProductLifecycleState"));
                }
                return this._ProductLifecycleState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductLifecycleStateSingle _ProductLifecycleState;
        /// <summary>
        /// There are no comments for ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVariant")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariantSingle ProductVariant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVariant == null))
                {
                    this._ProductVariant = new global::Microsoft.Dynamics.DataEntities.ProductVariantSingle(this.Context, GetPath("ProductVariant"));
                }
                return this._ProductVariant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariantSingle _ProductVariant;
        /// <summary>
        /// There are no comments for ProductTranslation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductTranslation")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductTranslation> ProductTranslation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductTranslation == null))
                {
                    this._ProductTranslation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductTranslation>(GetPath("ProductTranslation"));
                }
                return this._ProductTranslation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductTranslation> _ProductTranslation;
    }
    /// <summary>
    /// There are no comments for ReleasedProductVariant in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProductMasterNumber
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductColorId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductMasterNumber", "ProductConfigurationId", "ProductSizeId", "ProductColorId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedProductVariants")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductVariant")]
    public partial class ReleasedProductVariant : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedProductVariant object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="releasedProductMaster">Initial value of ReleasedProductMaster.</param>
        /// <param name="releasedProductMasterV2">Initial value of ReleasedProductMasterV2.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        /// <param name="productVariant">Initial value of ProductVariant.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedProductVariant CreateReleasedProductVariant(string dataAreaId, 
                    string productMasterNumber, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productColorId, 
                    string productStyleId, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster releasedProductMaster, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 releasedProductMasterV2, 
                    global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster, 
                    global::Microsoft.Dynamics.DataEntities.ProductVariant productVariant)
        {
            ReleasedProductVariant releasedProductVariant = new ReleasedProductVariant();
            releasedProductVariant.DataAreaId = dataAreaId;
            releasedProductVariant.ProductMasterNumber = productMasterNumber;
            releasedProductVariant.ProductConfigurationId = productConfigurationId;
            releasedProductVariant.ProductSizeId = productSizeId;
            releasedProductVariant.ProductColorId = productColorId;
            releasedProductVariant.ProductStyleId = productStyleId;
            if ((releasedProductMaster == null))
            {
                throw new global::System.ArgumentNullException("releasedProductMaster");
            }
            releasedProductVariant.ReleasedProductMaster = releasedProductMaster;
            if ((releasedProductMasterV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductMasterV2");
            }
            releasedProductVariant.ReleasedProductMasterV2 = releasedProductMasterV2;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            releasedProductVariant.ProductMaster = productMaster;
            if ((productVariant == null))
            {
                throw new global::System.ArgumentNullException("productVariant");
            }
            releasedProductVariant.ProductVariant = productVariant;
            return releasedProductVariant;
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
        /// There are no comments for Property ProductMasterNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMasterNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductMasterNumber is required.")]
        public virtual string ProductMasterNumber
        {
            get
            {
                return this._ProductMasterNumber;
            }
            set
            {
                this.OnProductMasterNumberChanging(value);
                this._ProductMasterNumber = value;
                this.OnProductMasterNumberChanged();
                this.OnPropertyChanged("ProductMasterNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductMasterNumber;
        partial void OnProductMasterNumberChanging(string value);
        partial void OnProductMasterNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductConfigurationId is required.")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductSizeId is required.")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorId is required.")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleId is required.")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductLifecycleStateId")]
        public virtual string ProductLifecycleStateId
        {
            get
            {
                return this._ProductLifecycleStateId;
            }
            set
            {
                this.OnProductLifecycleStateIdChanging(value);
                this._ProductLifecycleStateId = value;
                this.OnProductLifecycleStateIdChanged();
                this.OnPropertyChanged("ProductLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductLifecycleStateId;
        partial void OnProductLifecycleStateIdChanging(string value);
        partial void OnProductLifecycleStateIdChanged();
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
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductName")]
        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property ProductVariantNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVariantNumber")]
        public virtual string ProductVariantNumber
        {
            get
            {
                return this._ProductVariantNumber;
            }
            set
            {
                this.OnProductVariantNumberChanging(value);
                this._ProductVariantNumber = value;
                this.OnProductVariantNumberChanged();
                this.OnPropertyChanged("ProductVariantNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVariantNumber;
        partial void OnProductVariantNumberChanging(string value);
        partial void OnProductVariantNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductSearchName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSearchName")]
        public virtual string ProductSearchName
        {
            get
            {
                return this._ProductSearchName;
            }
            set
            {
                this.OnProductSearchNameChanging(value);
                this._ProductSearchName = value;
                this.OnProductSearchNameChanged();
                this.OnPropertyChanged("ProductSearchName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSearchName;
        partial void OnProductSearchNameChanging(string value);
        partial void OnProductSearchNameChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductVariantExternalCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductVariantExternalCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode> ReleasedProductVariantExternalCodes
        {
            get
            {
                return this._ReleasedProductVariantExternalCodes;
            }
            set
            {
                this.OnReleasedProductVariantExternalCodesChanging(value);
                this._ReleasedProductVariantExternalCodes = value;
                this.OnReleasedProductVariantExternalCodesChanged();
                this.OnPropertyChanged("ReleasedProductVariantExternalCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode> _ReleasedProductVariantExternalCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductVariantExternalCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductVariantExternalCode> value);
        partial void OnReleasedProductVariantExternalCodesChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductMaster")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductMaster is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster ReleasedProductMaster
        {
            get
            {
                return this._ReleasedProductMaster;
            }
            set
            {
                this.OnReleasedProductMasterChanging(value);
                this._ReleasedProductMaster = value;
                this.OnReleasedProductMasterChanged();
                this.OnPropertyChanged("ReleasedProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster _ReleasedProductMaster;
        partial void OnReleasedProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductMaster value);
        partial void OnReleasedProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductMasterV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductMasterV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductMasterV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 ReleasedProductMasterV2
        {
            get
            {
                return this._ReleasedProductMasterV2;
            }
            set
            {
                this.OnReleasedProductMasterV2Changing(value);
                this._ReleasedProductMasterV2 = value;
                this.OnReleasedProductMasterV2Changed();
                this.OnPropertyChanged("ReleasedProductMasterV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 _ReleasedProductMasterV2;
        partial void OnReleasedProductMasterV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductMasterV2 value);
        partial void OnReleasedProductMasterV2Changed();
        /// <summary>
        /// There are no comments for Property ProductMaster in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMaster")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductMaster is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductMaster ProductMaster
        {
            get
            {
                return this._ProductMaster;
            }
            set
            {
                this.OnProductMasterChanging(value);
                this._ProductMaster = value;
                this.OnProductMasterChanged();
                this.OnPropertyChanged("ProductMaster");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductMaster _ProductMaster;
        partial void OnProductMasterChanging(global::Microsoft.Dynamics.DataEntities.ProductMaster value);
        partial void OnProductMasterChanged();
        /// <summary>
        /// There are no comments for Property ProductLifecycleState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductLifecycleState")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductLifecycleState ProductLifecycleState
        {
            get
            {
                return this._ProductLifecycleState;
            }
            set
            {
                this.OnProductLifecycleStateChanging(value);
                this._ProductLifecycleState = value;
                this.OnProductLifecycleStateChanged();
                this.OnPropertyChanged("ProductLifecycleState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductLifecycleState _ProductLifecycleState;
        partial void OnProductLifecycleStateChanging(global::Microsoft.Dynamics.DataEntities.ProductLifecycleState value);
        partial void OnProductLifecycleStateChanged();
        /// <summary>
        /// There are no comments for Property ProductVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVariant")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVariant is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVariant ProductVariant
        {
            get
            {
                return this._ProductVariant;
            }
            set
            {
                this.OnProductVariantChanging(value);
                this._ProductVariant = value;
                this.OnProductVariantChanged();
                this.OnPropertyChanged("ProductVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVariant _ProductVariant;
        partial void OnProductVariantChanging(global::Microsoft.Dynamics.DataEntities.ProductVariant value);
        partial void OnProductVariantChanged();
        /// <summary>
        /// There are no comments for Property ProductTranslation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductTranslation")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductTranslation> ProductTranslation
        {
            get
            {
                return this._ProductTranslation;
            }
            set
            {
                this.OnProductTranslationChanging(value);
                this._ProductTranslation = value;
                this.OnProductTranslationChanged();
                this.OnPropertyChanged("ProductTranslation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductTranslation> _ProductTranslation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductTranslationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductTranslation> value);
        partial void OnProductTranslationChanged();
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
