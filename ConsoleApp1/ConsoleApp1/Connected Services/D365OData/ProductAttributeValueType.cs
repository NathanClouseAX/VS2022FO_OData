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
    /// There are no comments for ProductAttributeValueTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeValueTypeSingle")]
    public partial class ProductAttributeValueTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeValueType>
    {
        /// <summary>
        /// Initialize a new ProductAttributeValueTypeSingle object.
        /// </summary>
        public ProductAttributeValueTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductAttributeValueTypeSingle object.
        /// </summary>
        public ProductAttributeValueTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductAttributeValueTypeSingle object.
        /// </summary>
        public ProductAttributeValueTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductAttributeValueType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProductAttributeValueType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductAttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductAttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("ProductAttributeValueTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeValueType")]
    public partial class ProductAttributeValueType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductAttributeValueType object.
        /// </summary>
        /// <param name="productAttributeTypeName">Initial value of ProductAttributeTypeName.</param>
        /// <param name="upperDateTimeValue">Initial value of UpperDateTimeValue.</param>
        /// <param name="upperDecimalValue">Initial value of UpperDecimalValue.</param>
        /// <param name="lowerCurrencyValue">Initial value of LowerCurrencyValue.</param>
        /// <param name="lowerDecimalValue">Initial value of LowerDecimalValue.</param>
        /// <param name="lowerIntegerValue">Initial value of LowerIntegerValue.</param>
        /// <param name="upperIntegerValue">Initial value of UpperIntegerValue.</param>
        /// <param name="lowerDateTimeValue">Initial value of LowerDateTimeValue.</param>
        /// <param name="upperCurrencyValue">Initial value of UpperCurrencyValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductAttributeValueType CreateProductAttributeValueType(string productAttributeTypeName, 
                    global::System.DateTimeOffset upperDateTimeValue, 
                    decimal upperDecimalValue, 
                    decimal lowerCurrencyValue, 
                    decimal lowerDecimalValue, 
                    int lowerIntegerValue, 
                    int upperIntegerValue, 
                    global::System.DateTimeOffset lowerDateTimeValue, 
                    decimal upperCurrencyValue)
        {
            ProductAttributeValueType productAttributeValueType = new ProductAttributeValueType();
            productAttributeValueType.ProductAttributeTypeName = productAttributeTypeName;
            productAttributeValueType.UpperDateTimeValue = upperDateTimeValue;
            productAttributeValueType.UpperDecimalValue = upperDecimalValue;
            productAttributeValueType.LowerCurrencyValue = lowerCurrencyValue;
            productAttributeValueType.LowerDecimalValue = lowerDecimalValue;
            productAttributeValueType.LowerIntegerValue = lowerIntegerValue;
            productAttributeValueType.UpperIntegerValue = upperIntegerValue;
            productAttributeValueType.LowerDateTimeValue = lowerDateTimeValue;
            productAttributeValueType.UpperCurrencyValue = upperCurrencyValue;
            return productAttributeValueType;
        }
        /// <summary>
        /// There are no comments for Property ProductAttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAttributeTypeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductAttributeTypeName is required.")]
        public virtual string ProductAttributeTypeName
        {
            get
            {
                return this._ProductAttributeTypeName;
            }
            set
            {
                this.OnProductAttributeTypeNameChanging(value);
                this._ProductAttributeTypeName = value;
                this.OnProductAttributeTypeNameChanged();
                this.OnPropertyChanged("ProductAttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductAttributeTypeName;
        partial void OnProductAttributeTypeNameChanging(string value);
        partial void OnProductAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property ValueType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValueType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AttributeDataType> ValueType
        {
            get
            {
                return this._ValueType;
            }
            set
            {
                this.OnValueTypeChanging(value);
                this._ValueType = value;
                this.OnValueTypeChanged();
                this.OnPropertyChanged("ValueType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AttributeDataType> _ValueType;
        partial void OnValueTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AttributeDataType> value);
        partial void OnValueTypeChanged();
        /// <summary>
        /// There are no comments for Property UpperDateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpperDateTimeValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UpperDateTimeValue is required.")]
        public virtual global::System.DateTimeOffset UpperDateTimeValue
        {
            get
            {
                return this._UpperDateTimeValue;
            }
            set
            {
                this.OnUpperDateTimeValueChanging(value);
                this._UpperDateTimeValue = value;
                this.OnUpperDateTimeValueChanged();
                this.OnPropertyChanged("UpperDateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _UpperDateTimeValue;
        partial void OnUpperDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnUpperDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property UpperDecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpperDecimalValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UpperDecimalValue is required.")]
        public virtual decimal UpperDecimalValue
        {
            get
            {
                return this._UpperDecimalValue;
            }
            set
            {
                this.OnUpperDecimalValueChanging(value);
                this._UpperDecimalValue = value;
                this.OnUpperDecimalValueChanged();
                this.OnPropertyChanged("UpperDecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UpperDecimalValue;
        partial void OnUpperDecimalValueChanging(decimal value);
        partial void OnUpperDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property LowerCurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LowerCurrencyValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LowerCurrencyValue is required.")]
        public virtual decimal LowerCurrencyValue
        {
            get
            {
                return this._LowerCurrencyValue;
            }
            set
            {
                this.OnLowerCurrencyValueChanging(value);
                this._LowerCurrencyValue = value;
                this.OnLowerCurrencyValueChanged();
                this.OnPropertyChanged("LowerCurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LowerCurrencyValue;
        partial void OnLowerCurrencyValueChanging(decimal value);
        partial void OnLowerCurrencyValueChanged();
        /// <summary>
        /// There are no comments for Property UnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitSymbol")]
        public virtual string UnitSymbol
        {
            get
            {
                return this._UnitSymbol;
            }
            set
            {
                this.OnUnitSymbolChanging(value);
                this._UnitSymbol = value;
                this.OnUnitSymbolChanged();
                this.OnPropertyChanged("UnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitSymbol;
        partial void OnUnitSymbolChanging(string value);
        partial void OnUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property LowerDecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LowerDecimalValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LowerDecimalValue is required.")]
        public virtual decimal LowerDecimalValue
        {
            get
            {
                return this._LowerDecimalValue;
            }
            set
            {
                this.OnLowerDecimalValueChanging(value);
                this._LowerDecimalValue = value;
                this.OnLowerDecimalValueChanged();
                this.OnPropertyChanged("LowerDecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LowerDecimalValue;
        partial void OnLowerDecimalValueChanging(decimal value);
        partial void OnLowerDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property LowerIntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LowerIntegerValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LowerIntegerValue is required.")]
        public virtual int LowerIntegerValue
        {
            get
            {
                return this._LowerIntegerValue;
            }
            set
            {
                this.OnLowerIntegerValueChanging(value);
                this._LowerIntegerValue = value;
                this.OnLowerIntegerValueChanged();
                this.OnPropertyChanged("LowerIntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LowerIntegerValue;
        partial void OnLowerIntegerValueChanging(int value);
        partial void OnLowerIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property UpperIntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpperIntegerValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UpperIntegerValue is required.")]
        public virtual int UpperIntegerValue
        {
            get
            {
                return this._UpperIntegerValue;
            }
            set
            {
                this.OnUpperIntegerValueChanging(value);
                this._UpperIntegerValue = value;
                this.OnUpperIntegerValueChanged();
                this.OnPropertyChanged("UpperIntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UpperIntegerValue;
        partial void OnUpperIntegerValueChanging(int value);
        partial void OnUpperIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property LowerDateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LowerDateTimeValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LowerDateTimeValue is required.")]
        public virtual global::System.DateTimeOffset LowerDateTimeValue
        {
            get
            {
                return this._LowerDateTimeValue;
            }
            set
            {
                this.OnLowerDateTimeValueChanging(value);
                this._LowerDateTimeValue = value;
                this.OnLowerDateTimeValueChanged();
                this.OnPropertyChanged("LowerDateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LowerDateTimeValue;
        partial void OnLowerDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnLowerDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property UpperCurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpperCurrencyValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UpperCurrencyValue is required.")]
        public virtual decimal UpperCurrencyValue
        {
            get
            {
                return this._UpperCurrencyValue;
            }
            set
            {
                this.OnUpperCurrencyValueChanging(value);
                this._UpperCurrencyValue = value;
                this.OnUpperCurrencyValueChanged();
                this.OnPropertyChanged("UpperCurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _UpperCurrencyValue;
        partial void OnUpperCurrencyValueChanging(decimal value);
        partial void OnUpperCurrencyValueChanged();
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
