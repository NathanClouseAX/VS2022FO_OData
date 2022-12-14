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
    /// There are no comments for RetailItemLabelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailItemLabelSingle")]
    public partial class RetailItemLabelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailItemLabel>
    {
        /// <summary>
        /// Initialize a new RetailItemLabelSingle object.
        /// </summary>
        public RetailItemLabelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailItemLabelSingle object.
        /// </summary>
        public RetailItemLabelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailItemLabelSingle object.
        /// </summary>
        public RetailItemLabelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailItemLabel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
    }
    /// <summary>
    /// There are no comments for RetailItemLabel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemId
    /// StoreNumber
    /// UnitOfMeasureSymbol
    /// ValidOnDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemId", "StoreNumber", "UnitOfMeasureSymbol", "ValidOnDate")]
    [global::Microsoft.OData.Client.EntitySet("RetailItemLabels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailItemLabel")]
    public partial class RetailItemLabel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailItemLabel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemId">Initial value of ItemId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="unitOfMeasureSymbol">Initial value of UnitOfMeasureSymbol.</param>
        /// <param name="validOnDate">Initial value of ValidOnDate.</param>
        /// <param name="comparisonPriceOnShelfLabel">Initial value of ComparisonPriceOnShelfLabel.</param>
        /// <param name="price">Initial value of Price.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="releasedProductV2">Initial value of ReleasedProductV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailItemLabel CreateRetailItemLabel(string dataAreaId, 
                    string itemId, 
                    string storeNumber, 
                    string unitOfMeasureSymbol, 
                    global::System.DateTimeOffset validOnDate, 
                    decimal comparisonPriceOnShelfLabel, 
                    decimal price, 
                    decimal quantity, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProductV2)
        {
            RetailItemLabel retailItemLabel = new RetailItemLabel();
            retailItemLabel.DataAreaId = dataAreaId;
            retailItemLabel.ItemId = itemId;
            retailItemLabel.StoreNumber = storeNumber;
            retailItemLabel.UnitOfMeasureSymbol = unitOfMeasureSymbol;
            retailItemLabel.ValidOnDate = validOnDate;
            retailItemLabel.ComparisonPriceOnShelfLabel = comparisonPriceOnShelfLabel;
            retailItemLabel.Price = price;
            retailItemLabel.Quantity = quantity;
            if ((releasedProductV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductV2");
            }
            retailItemLabel.ReleasedProductV2 = releasedProductV2;
            return retailItemLabel;
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
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemId is required.")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreNumber is required.")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasureSymbol")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitOfMeasureSymbol is required.")]
        public virtual string UnitOfMeasureSymbol
        {
            get
            {
                return this._UnitOfMeasureSymbol;
            }
            set
            {
                this.OnUnitOfMeasureSymbolChanging(value);
                this._UnitOfMeasureSymbol = value;
                this.OnUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("UnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasureSymbol;
        partial void OnUnitOfMeasureSymbolChanging(string value);
        partial void OnUnitOfMeasureSymbolChanged();
        /// <summary>
        /// There are no comments for Property ValidOnDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidOnDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidOnDate is required.")]
        public virtual global::System.DateTimeOffset ValidOnDate
        {
            get
            {
                return this._ValidOnDate;
            }
            set
            {
                this.OnValidOnDateChanging(value);
                this._ValidOnDate = value;
                this.OnValidOnDateChanged();
                this.OnPropertyChanged("ValidOnDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidOnDate;
        partial void OnValidOnDateChanging(global::System.DateTimeOffset value);
        partial void OnValidOnDateChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Size")]
        public virtual string Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Size;
        partial void OnSizeChanging(string value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property Color in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Color")]
        public virtual string Color
        {
            get
            {
                return this._Color;
            }
            set
            {
                this.OnColorChanging(value);
                this._Color = value;
                this.OnColorChanged();
                this.OnPropertyChanged("Color");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Color;
        partial void OnColorChanging(string value);
        partial void OnColorChanged();
        /// <summary>
        /// There are no comments for Property ItemBarCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemBarCode")]
        public virtual string ItemBarCode
        {
            get
            {
                return this._ItemBarCode;
            }
            set
            {
                this.OnItemBarCodeChanging(value);
                this._ItemBarCode = value;
                this.OnItemBarCodeChanged();
                this.OnPropertyChanged("ItemBarCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemBarCode;
        partial void OnItemBarCodeChanging(string value);
        partial void OnItemBarCodeChanged();
        /// <summary>
        /// There are no comments for Property ConfigId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfigId")]
        public virtual string ConfigId
        {
            get
            {
                return this._ConfigId;
            }
            set
            {
                this.OnConfigIdChanging(value);
                this._ConfigId = value;
                this.OnConfigIdChanged();
                this.OnPropertyChanged("ConfigId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfigId;
        partial void OnConfigIdChanging(string value);
        partial void OnConfigIdChanged();
        /// <summary>
        /// There are no comments for Property ComparisonPriceOnShelfLabel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ComparisonPriceOnShelfLabel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ComparisonPriceOnShelfLabel is required.")]
        public virtual decimal ComparisonPriceOnShelfLabel
        {
            get
            {
                return this._ComparisonPriceOnShelfLabel;
            }
            set
            {
                this.OnComparisonPriceOnShelfLabelChanging(value);
                this._ComparisonPriceOnShelfLabel = value;
                this.OnComparisonPriceOnShelfLabelChanged();
                this.OnPropertyChanged("ComparisonPriceOnShelfLabel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ComparisonPriceOnShelfLabel;
        partial void OnComparisonPriceOnShelfLabelChanging(decimal value);
        partial void OnComparisonPriceOnShelfLabelChanged();
        /// <summary>
        /// There are no comments for Property ReportName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportName")]
        public virtual string ReportName
        {
            get
            {
                return this._ReportName;
            }
            set
            {
                this.OnReportNameChanging(value);
                this._ReportName = value;
                this.OnReportNameChanged();
                this.OnPropertyChanged("ReportName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportName;
        partial void OnReportNameChanging(string value);
        partial void OnReportNameChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Price")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Price is required.")]
        public virtual decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelFutureLabelBase> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelFutureLabelBase> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelFutureLabelBase> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property Printed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Printed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Printed
        {
            get
            {
                return this._Printed;
            }
            set
            {
                this.OnPrintedChanging(value);
                this._Printed = value;
                this.OnPrintedChanged();
                this.OnPropertyChanged("Printed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Printed;
        partial void OnPrintedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPrintedChanged();
        /// <summary>
        /// There are no comments for Property Text1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text1")]
        public virtual string Text1
        {
            get
            {
                return this._Text1;
            }
            set
            {
                this.OnText1Changing(value);
                this._Text1 = value;
                this.OnText1Changed();
                this.OnPropertyChanged("Text1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text1;
        partial void OnText1Changing(string value);
        partial void OnText1Changed();
        /// <summary>
        /// There are no comments for Property Text2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text2")]
        public virtual string Text2
        {
            get
            {
                return this._Text2;
            }
            set
            {
                this.OnText2Changing(value);
                this._Text2 = value;
                this.OnText2Changed();
                this.OnPropertyChanged("Text2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text2;
        partial void OnText2Changing(string value);
        partial void OnText2Changed();
        /// <summary>
        /// There are no comments for Property Style in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Style")]
        public virtual string Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this.OnStyleChanging(value);
                this._Style = value;
                this.OnStyleChanged();
                this.OnPropertyChanged("Style");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Style;
        partial void OnStyleChanging(string value);
        partial void OnStyleChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property PrimaryKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryKey")]
        public virtual string PrimaryKey
        {
            get
            {
                return this._PrimaryKey;
            }
            set
            {
                this.OnPrimaryKeyChanging(value);
                this._PrimaryKey = value;
                this.OnPrimaryKeyChanged();
                this.OnPropertyChanged("PrimaryKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrimaryKey;
        partial void OnPrimaryKeyChanging(string value);
        partial void OnPrimaryKeyChanged();
        /// <summary>
        /// There are no comments for Property LabelType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LabelType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> LabelType
        {
            get
            {
                return this._LabelType;
            }
            set
            {
                this.OnLabelTypeChanging(value);
                this._LabelType = value;
                this.OnLabelTypeChanged();
                this.OnPropertyChanged("LabelType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> _LabelType;
        partial void OnLabelTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailLabelTypeBase> value);
        partial void OnLabelTypeChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
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
