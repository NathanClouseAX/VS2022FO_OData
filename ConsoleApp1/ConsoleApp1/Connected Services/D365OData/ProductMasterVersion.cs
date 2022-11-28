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
    /// There are no comments for ProductMasterVersionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMasterVersionSingle")]
    public partial class ProductMasterVersionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterVersion>
    {
        /// <summary>
        /// Initialize a new ProductMasterVersionSingle object.
        /// </summary>
        public ProductMasterVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductMasterVersionSingle object.
        /// </summary>
        public ProductMasterVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductMasterVersionSingle object.
        /// </summary>
        public ProductMasterVersionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductMasterVersion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersion")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersionSingle ProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductVersion == null))
                {
                    this._ProductVersion = new global::Microsoft.Dynamics.DataEntities.ProductVersionSingle(this.Context, GetPath("ProductVersion"));
                }
                return this._ProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersionSingle _ProductVersion;
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
        /// There are no comments for ProductMasterVersionTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMasterVersionTranslations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation> ProductMasterVersionTranslations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductMasterVersionTranslations == null))
                {
                    this._ProductMasterVersionTranslations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation>(GetPath("ProductMasterVersionTranslations"));
                }
                return this._ProductMasterVersionTranslations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation> _ProductMasterVersionTranslations;
    }
    /// <summary>
    /// There are no comments for ProductMasterVersion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductMasterNumber
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductMasterNumber", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("ProductMasterVersions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMasterVersion")]
    public partial class ProductMasterVersion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductMasterVersion object.
        /// </summary>
        /// <param name="productMasterNumber">Initial value of ProductMasterNumber.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="displaySequenceNumber">Initial value of DisplaySequenceNumber.</param>
        /// <param name="replenishmentWeight">Initial value of ReplenishmentWeight.</param>
        /// <param name="productVersion">Initial value of ProductVersion.</param>
        /// <param name="productMaster">Initial value of ProductMaster.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductMasterVersion CreateProductMasterVersion(string productMasterNumber, 
                    string productVersionId, 
                    decimal displaySequenceNumber, 
                    int replenishmentWeight, 
                    global::Microsoft.Dynamics.DataEntities.ProductVersion productVersion, 
                    global::Microsoft.Dynamics.DataEntities.ProductMaster productMaster)
        {
            ProductMasterVersion productMasterVersion = new ProductMasterVersion();
            productMasterVersion.ProductMasterNumber = productMasterNumber;
            productMasterVersion.ProductVersionId = productVersionId;
            productMasterVersion.DisplaySequenceNumber = displaySequenceNumber;
            productMasterVersion.ReplenishmentWeight = replenishmentWeight;
            if ((productVersion == null))
            {
                throw new global::System.ArgumentNullException("productVersion");
            }
            productMasterVersion.ProductVersion = productVersion;
            if ((productMaster == null))
            {
                throw new global::System.ArgumentNullException("productMaster");
            }
            productMasterVersion.ProductMaster = productMaster;
            return productMasterVersion;
        }
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersionId is required.")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property DisplaySequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplaySequenceNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DisplaySequenceNumber is required.")]
        public virtual decimal DisplaySequenceNumber
        {
            get
            {
                return this._DisplaySequenceNumber;
            }
            set
            {
                this.OnDisplaySequenceNumberChanging(value);
                this._DisplaySequenceNumber = value;
                this.OnDisplaySequenceNumberChanged();
                this.OnPropertyChanged("DisplaySequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DisplaySequenceNumber;
        partial void OnDisplaySequenceNumberChanging(decimal value);
        partial void OnDisplaySequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property ReplenishmentWeight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReplenishmentWeight")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReplenishmentWeight is required.")]
        public virtual int ReplenishmentWeight
        {
            get
            {
                return this._ReplenishmentWeight;
            }
            set
            {
                this.OnReplenishmentWeightChanging(value);
                this._ReplenishmentWeight = value;
                this.OnReplenishmentWeightChanged();
                this.OnPropertyChanged("ReplenishmentWeight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplenishmentWeight;
        partial void OnReplenishmentWeightChanging(int value);
        partial void OnReplenishmentWeightChanged();
        /// <summary>
        /// There are no comments for Property ProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductVersion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersion is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductVersion ProductVersion
        {
            get
            {
                return this._ProductVersion;
            }
            set
            {
                this.OnProductVersionChanging(value);
                this._ProductVersion = value;
                this.OnProductVersionChanged();
                this.OnPropertyChanged("ProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductVersion _ProductVersion;
        partial void OnProductVersionChanging(global::Microsoft.Dynamics.DataEntities.ProductVersion value);
        partial void OnProductVersionChanged();
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
        /// There are no comments for Property ProductMasterVersionTranslations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductMasterVersionTranslations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation> ProductMasterVersionTranslations
        {
            get
            {
                return this._ProductMasterVersionTranslations;
            }
            set
            {
                this.OnProductMasterVersionTranslationsChanging(value);
                this._ProductMasterVersionTranslations = value;
                this.OnProductMasterVersionTranslationsChanged();
                this.OnPropertyChanged("ProductMasterVersionTranslations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation> _ProductMasterVersionTranslations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductMasterVersionTranslationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductMasterVersionTranslation> value);
        partial void OnProductMasterVersionTranslationsChanged();
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
