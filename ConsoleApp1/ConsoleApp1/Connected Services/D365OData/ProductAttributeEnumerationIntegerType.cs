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
    /// There are no comments for ProductAttributeEnumerationIntegerTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeEnumerationIntegerTypeSingle")]
    public partial class ProductAttributeEnumerationIntegerTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeEnumerationIntegerType>
    {
        /// <summary>
        /// Initialize a new ProductAttributeEnumerationIntegerTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationIntegerTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductAttributeEnumerationIntegerTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationIntegerTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductAttributeEnumerationIntegerTypeSingle object.
        /// </summary>
        public ProductAttributeEnumerationIntegerTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeEnumerationIntegerType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductAttributeEnumerationIntegerType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EnumerationName
    /// EnumerationNameUniqueID
    /// EnumerationIntegerValue
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EnumerationName", "EnumerationNameUniqueID", "EnumerationIntegerValue")]
    [global::Microsoft.OData.Client.EntitySet("ProductAttributeEnumerationIntegerTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeEnumerationIntegerType")]
    public partial class ProductAttributeEnumerationIntegerType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductAttributeEnumerationIntegerType object.
        /// </summary>
        /// <param name="enumerationName">Initial value of EnumerationName.</param>
        /// <param name="enumerationNameUniqueID">Initial value of EnumerationNameUniqueID.</param>
        /// <param name="enumerationIntegerValue">Initial value of EnumerationIntegerValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductAttributeEnumerationIntegerType CreateProductAttributeEnumerationIntegerType(string enumerationName, int enumerationNameUniqueID, int enumerationIntegerValue)
        {
            ProductAttributeEnumerationIntegerType productAttributeEnumerationIntegerType = new ProductAttributeEnumerationIntegerType();
            productAttributeEnumerationIntegerType.EnumerationName = enumerationName;
            productAttributeEnumerationIntegerType.EnumerationNameUniqueID = enumerationNameUniqueID;
            productAttributeEnumerationIntegerType.EnumerationIntegerValue = enumerationIntegerValue;
            return productAttributeEnumerationIntegerType;
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
        /// There are no comments for Property EnumerationIntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnumerationIntegerValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnumerationIntegerValue is required.")]
        public virtual int EnumerationIntegerValue
        {
            get
            {
                return this._EnumerationIntegerValue;
            }
            set
            {
                this.OnEnumerationIntegerValueChanging(value);
                this._EnumerationIntegerValue = value;
                this.OnEnumerationIntegerValueChanged();
                this.OnPropertyChanged("EnumerationIntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _EnumerationIntegerValue;
        partial void OnEnumerationIntegerValueChanging(int value);
        partial void OnEnumerationIntegerValueChanged();
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