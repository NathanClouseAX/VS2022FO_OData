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
    /// There are no comments for RetailInternalOrganizationProductAttributeValue2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganizationProductAttributeValue2Single")]
    public partial class RetailInternalOrganizationProductAttributeValue2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInternalOrganizationProductAttributeValue2>
    {
        /// <summary>
        /// Initialize a new RetailInternalOrganizationProductAttributeValue2Single object.
        /// </summary>
        public RetailInternalOrganizationProductAttributeValue2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInternalOrganizationProductAttributeValue2Single object.
        /// </summary>
        public RetailInternalOrganizationProductAttributeValue2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInternalOrganizationProductAttributeValue2Single object.
        /// </summary>
        public RetailInternalOrganizationProductAttributeValue2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInternalOrganizationProductAttributeValue2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currency == null))
                {
                    this._Currency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currency"));
                }
                return this._Currency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currency;
        /// <summary>
        /// There are no comments for IntegerUnitOfMeasureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IntegerUnitOfMeasureEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle IntegerUnitOfMeasureEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._IntegerUnitOfMeasureEntity == null))
                {
                    this._IntegerUnitOfMeasureEntity = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("IntegerUnitOfMeasureEntity"));
                }
                return this._IntegerUnitOfMeasureEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _IntegerUnitOfMeasureEntity;
        /// <summary>
        /// There are no comments for RetailInternalOrganizationProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganizationProduct")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductSingle RetailInternalOrganizationProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInternalOrganizationProduct == null))
                {
                    this._RetailInternalOrganizationProduct = new global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductSingle(this.Context, GetPath("RetailInternalOrganizationProduct"));
                }
                return this._RetailInternalOrganizationProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductSingle _RetailInternalOrganizationProduct;
        /// <summary>
        /// There are no comments for RetailInternalOrganization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganization")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationSingle RetailInternalOrganization
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInternalOrganization == null))
                {
                    this._RetailInternalOrganization = new global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationSingle(this.Context, GetPath("RetailInternalOrganization"));
                }
                return this._RetailInternalOrganization;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationSingle _RetailInternalOrganization;
    }
    /// <summary>
    /// There are no comments for RetailInternalOrganizationProductAttributeValue2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// InternalOrganizationPartyNumber
    /// DisplayProductNumber
    /// AttributeTypeName
    /// AttributeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("InternalOrganizationPartyNumber", "DisplayProductNumber", "AttributeTypeName", "AttributeName")]
    [global::Microsoft.OData.Client.EntitySet("RetailInternalOrganizationProductAttributeValues2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganizationProductAttributeValue2")]
    public partial class RetailInternalOrganizationProductAttributeValue2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInternalOrganizationProductAttributeValue2 object.
        /// </summary>
        /// <param name="internalOrganizationPartyNumber">Initial value of InternalOrganizationPartyNumber.</param>
        /// <param name="displayProductNumber">Initial value of DisplayProductNumber.</param>
        /// <param name="attributeTypeName">Initial value of AttributeTypeName.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="integerValue">Initial value of IntegerValue.</param>
        /// <param name="dateTimeValue">Initial value of DateTimeValue.</param>
        /// <param name="decimalValue">Initial value of DecimalValue.</param>
        /// <param name="currencyValue">Initial value of CurrencyValue.</param>
        /// <param name="retailInternalOrganizationProduct">Initial value of RetailInternalOrganizationProduct.</param>
        /// <param name="retailInternalOrganization">Initial value of RetailInternalOrganization.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInternalOrganizationProductAttributeValue2 CreateRetailInternalOrganizationProductAttributeValue2(string internalOrganizationPartyNumber, 
                    string displayProductNumber, 
                    string attributeTypeName, 
                    string attributeName, 
                    int integerValue, 
                    global::System.DateTimeOffset dateTimeValue, 
                    decimal decimalValue, 
                    decimal currencyValue, 
                    global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProduct retailInternalOrganizationProduct, 
                    global::Microsoft.Dynamics.DataEntities.RetailInternalOrganization retailInternalOrganization)
        {
            RetailInternalOrganizationProductAttributeValue2 retailInternalOrganizationProductAttributeValue2 = new RetailInternalOrganizationProductAttributeValue2();
            retailInternalOrganizationProductAttributeValue2.InternalOrganizationPartyNumber = internalOrganizationPartyNumber;
            retailInternalOrganizationProductAttributeValue2.DisplayProductNumber = displayProductNumber;
            retailInternalOrganizationProductAttributeValue2.AttributeTypeName = attributeTypeName;
            retailInternalOrganizationProductAttributeValue2.AttributeName = attributeName;
            retailInternalOrganizationProductAttributeValue2.IntegerValue = integerValue;
            retailInternalOrganizationProductAttributeValue2.DateTimeValue = dateTimeValue;
            retailInternalOrganizationProductAttributeValue2.DecimalValue = decimalValue;
            retailInternalOrganizationProductAttributeValue2.CurrencyValue = currencyValue;
            if ((retailInternalOrganizationProduct == null))
            {
                throw new global::System.ArgumentNullException("retailInternalOrganizationProduct");
            }
            retailInternalOrganizationProductAttributeValue2.RetailInternalOrganizationProduct = retailInternalOrganizationProduct;
            if ((retailInternalOrganization == null))
            {
                throw new global::System.ArgumentNullException("retailInternalOrganization");
            }
            retailInternalOrganizationProductAttributeValue2.RetailInternalOrganization = retailInternalOrganization;
            return retailInternalOrganizationProductAttributeValue2;
        }
        /// <summary>
        /// There are no comments for Property InternalOrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternalOrganizationPartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InternalOrganizationPartyNumber is required.")]
        public virtual string InternalOrganizationPartyNumber
        {
            get
            {
                return this._InternalOrganizationPartyNumber;
            }
            set
            {
                this.OnInternalOrganizationPartyNumberChanging(value);
                this._InternalOrganizationPartyNumber = value;
                this.OnInternalOrganizationPartyNumberChanged();
                this.OnPropertyChanged("InternalOrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternalOrganizationPartyNumber;
        partial void OnInternalOrganizationPartyNumberChanging(string value);
        partial void OnInternalOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property DisplayProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplayProductNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DisplayProductNumber is required.")]
        public virtual string DisplayProductNumber
        {
            get
            {
                return this._DisplayProductNumber;
            }
            set
            {
                this.OnDisplayProductNumberChanging(value);
                this._DisplayProductNumber = value;
                this.OnDisplayProductNumberChanged();
                this.OnPropertyChanged("DisplayProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayProductNumber;
        partial void OnDisplayProductNumberChanging(string value);
        partial void OnDisplayProductNumberChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeTypeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeTypeName is required.")]
        public virtual string AttributeTypeName
        {
            get
            {
                return this._AttributeTypeName;
            }
            set
            {
                this.OnAttributeTypeNameChanging(value);
                this._AttributeTypeName = value;
                this.OnAttributeTypeNameChanged();
                this.OnPropertyChanged("AttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeName;
        partial void OnAttributeTypeNameChanging(string value);
        partial void OnAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeName is required.")]
        public virtual string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this.OnAttributeNameChanging(value);
                this._AttributeName = value;
                this.OnAttributeNameChanged();
                this.OnPropertyChanged("AttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeName;
        partial void OnAttributeNameChanging(string value);
        partial void OnAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property IntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntegerValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntegerValue is required.")]
        public virtual int IntegerValue
        {
            get
            {
                return this._IntegerValue;
            }
            set
            {
                this.OnIntegerValueChanging(value);
                this._IntegerValue = value;
                this.OnIntegerValueChanged();
                this.OnPropertyChanged("IntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntegerValue;
        partial void OnIntegerValueChanging(int value);
        partial void OnIntegerValueChanged();
        /// <summary>
        /// There are no comments for Property DecimalUnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DecimalUnitOfMeasureSymbol")]
        public virtual string DecimalUnitOfMeasureSymbol
        {
            get
            {
                return this._DecimalUnitOfMeasureSymbol;
            }
            set
            {
                this.OnDecimalUnitOfMeasureSymbolChanging(value);
                this._DecimalUnitOfMeasureSymbol = value;
                this.OnDecimalUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("DecimalUnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DecimalUnitOfMeasureSymbol;
        partial void OnDecimalUnitOfMeasureSymbolChanging(string value);
        partial void OnDecimalUnitOfMeasureSymbolChanged();
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
        /// There are no comments for Property DateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateTimeValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateTimeValue is required.")]
        public virtual global::System.DateTimeOffset DateTimeValue
        {
            get
            {
                return this._DateTimeValue;
            }
            set
            {
                this.OnDateTimeValueChanging(value);
                this._DateTimeValue = value;
                this.OnDateTimeValueChanged();
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateTimeValue;
        partial void OnDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeValueChanged();
        /// <summary>
        /// There are no comments for Property DecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DecimalValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DecimalValue is required.")]
        public virtual decimal DecimalValue
        {
            get
            {
                return this._DecimalValue;
            }
            set
            {
                this.OnDecimalValueChanging(value);
                this._DecimalValue = value;
                this.OnDecimalValueChanged();
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DecimalValue;
        partial void OnDecimalValueChanging(decimal value);
        partial void OnDecimalValueChanged();
        /// <summary>
        /// There are no comments for Property IntegerUnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntegerUnitOfMeasureSymbol")]
        public virtual string IntegerUnitOfMeasureSymbol
        {
            get
            {
                return this._IntegerUnitOfMeasureSymbol;
            }
            set
            {
                this.OnIntegerUnitOfMeasureSymbolChanging(value);
                this._IntegerUnitOfMeasureSymbol = value;
                this.OnIntegerUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("IntegerUnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntegerUnitOfMeasureSymbol;
        partial void OnIntegerUnitOfMeasureSymbolChanging(string value);
        partial void OnIntegerUnitOfMeasureSymbolChanged();
        /// <summary>
        /// There are no comments for Property BooleanValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BooleanValue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BooleanValue
        {
            get
            {
                return this._BooleanValue;
            }
            set
            {
                this.OnBooleanValueChanging(value);
                this._BooleanValue = value;
                this.OnBooleanValueChanged();
                this.OnPropertyChanged("BooleanValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BooleanValue;
        partial void OnBooleanValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBooleanValueChanged();
        /// <summary>
        /// There are no comments for Property CurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrencyValue is required.")]
        public virtual decimal CurrencyValue
        {
            get
            {
                return this._CurrencyValue;
            }
            set
            {
                this.OnCurrencyValueChanging(value);
                this._CurrencyValue = value;
                this.OnCurrencyValueChanged();
                this.OnPropertyChanged("CurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CurrencyValue;
        partial void OnCurrencyValueChanging(decimal value);
        partial void OnCurrencyValueChanged();
        /// <summary>
        /// There are no comments for Property TextValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TextValue")]
        public virtual string TextValue
        {
            get
            {
                return this._TextValue;
            }
            set
            {
                this.OnTextValueChanging(value);
                this._TextValue = value;
                this.OnTextValueChanged();
                this.OnPropertyChanged("TextValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TextValue;
        partial void OnTextValueChanging(string value);
        partial void OnTextValueChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currency;
        partial void OnCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property IntegerUnitOfMeasureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntegerUnitOfMeasureEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure IntegerUnitOfMeasureEntity
        {
            get
            {
                return this._IntegerUnitOfMeasureEntity;
            }
            set
            {
                this.OnIntegerUnitOfMeasureEntityChanging(value);
                this._IntegerUnitOfMeasureEntity = value;
                this.OnIntegerUnitOfMeasureEntityChanged();
                this.OnPropertyChanged("IntegerUnitOfMeasureEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _IntegerUnitOfMeasureEntity;
        partial void OnIntegerUnitOfMeasureEntityChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnIntegerUnitOfMeasureEntityChanged();
        /// <summary>
        /// There are no comments for Property RetailInternalOrganizationProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganizationProduct")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailInternalOrganizationProduct is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProduct RetailInternalOrganizationProduct
        {
            get
            {
                return this._RetailInternalOrganizationProduct;
            }
            set
            {
                this.OnRetailInternalOrganizationProductChanging(value);
                this._RetailInternalOrganizationProduct = value;
                this.OnRetailInternalOrganizationProductChanged();
                this.OnPropertyChanged("RetailInternalOrganizationProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProduct _RetailInternalOrganizationProduct;
        partial void OnRetailInternalOrganizationProductChanging(global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProduct value);
        partial void OnRetailInternalOrganizationProductChanged();
        /// <summary>
        /// There are no comments for Property RetailInternalOrganization in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailInternalOrganization")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailInternalOrganization is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailInternalOrganization RetailInternalOrganization
        {
            get
            {
                return this._RetailInternalOrganization;
            }
            set
            {
                this.OnRetailInternalOrganizationChanging(value);
                this._RetailInternalOrganization = value;
                this.OnRetailInternalOrganizationChanged();
                this.OnPropertyChanged("RetailInternalOrganization");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailInternalOrganization _RetailInternalOrganization;
        partial void OnRetailInternalOrganizationChanging(global::Microsoft.Dynamics.DataEntities.RetailInternalOrganization value);
        partial void OnRetailInternalOrganizationChanged();
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
