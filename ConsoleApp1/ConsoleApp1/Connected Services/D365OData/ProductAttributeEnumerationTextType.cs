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
    /// There are no comments for ProductAttributeEnumerationTextTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeEnumerationTextTypeSingle")]
    public partial class ProductAttributeEnumerationTextTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeEnumerationTextType>
    {
        /// <summary>
        /// Initialize a new ProductAttributeEnumerationTextTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationTextTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductAttributeEnumerationTextTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationTextTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductAttributeEnumerationTextTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationTextTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeEnumerationTextType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductAttributeEnumerationTextType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EnumerationName
    /// EnumerationNameUniqueID
    /// EnumerationValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EnumerationName", "EnumerationNameUniqueID", "EnumerationValue")]
    [global::Microsoft.OData.Client.EntitySet("ProductAttributeEnumerationTextTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeEnumerationTextType")]
    public partial class ProductAttributeEnumerationTextType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductAttributeEnumerationTextType object.
        /// </summary>
        /// <param name="enumerationName">Initial value of EnumerationName.</param>
        /// <param name="enumerationNameUniqueID">Initial value of EnumerationNameUniqueID.</param>
        /// <param name="enumerationValue">Initial value of EnumerationValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductAttributeEnumerationTextType CreateProductAttributeEnumerationTextType(string enumerationName, int enumerationNameUniqueID, string enumerationValue)
        {
            ProductAttributeEnumerationTextType productAttributeEnumerationTextType = new ProductAttributeEnumerationTextType();
            productAttributeEnumerationTextType.EnumerationName = enumerationName;
            productAttributeEnumerationTextType.EnumerationNameUniqueID = enumerationNameUniqueID;
            productAttributeEnumerationTextType.EnumerationValue = enumerationValue;
            return productAttributeEnumerationTextType;
        }
        /// <summary>
        /// There are no comments for Property EnumerationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnumerationName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnumerationName is required.")]
        public virtual string EnumerationName
        {
            get
            {
                return this._EnumerationName;
            }
            set
            {
                this.OnEnumerationNameChanging(value);
                this._EnumerationName = value;
                this.OnEnumerationNameChanged();
                this.OnPropertyChanged("EnumerationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnumerationName;
        partial void OnEnumerationNameChanging(string value);
        partial void OnEnumerationNameChanged();
        /// <summary>
        /// There are no comments for Property EnumerationNameUniqueID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnumerationNameUniqueID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnumerationNameUniqueID is required.")]
        public virtual int EnumerationNameUniqueID
        {
            get
            {
                return this._EnumerationNameUniqueID;
            }
            set
            {
                this.OnEnumerationNameUniqueIDChanging(value);
                this._EnumerationNameUniqueID = value;
                this.OnEnumerationNameUniqueIDChanged();
                this.OnPropertyChanged("EnumerationNameUniqueID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EnumerationNameUniqueID;
        partial void OnEnumerationNameUniqueIDChanging(int value);
        partial void OnEnumerationNameUniqueIDChanged();
        /// <summary>
        /// There are no comments for Property EnumerationValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnumerationValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnumerationValue is required.")]
        public virtual string EnumerationValue
        {
            get
            {
                return this._EnumerationValue;
            }
            set
            {
                this.OnEnumerationValueChanging(value);
                this._EnumerationValue = value;
                this.OnEnumerationValueChanged();
                this.OnPropertyChanged("EnumerationValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnumerationValue;
        partial void OnEnumerationValueChanging(string value);
        partial void OnEnumerationValueChanged();
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
