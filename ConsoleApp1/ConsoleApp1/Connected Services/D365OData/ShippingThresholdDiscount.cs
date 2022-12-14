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
    /// There are no comments for ShippingThresholdDiscountSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingThresholdDiscountSingle")]
    public partial class ShippingThresholdDiscountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingThresholdDiscount>
    {
        /// <summary>
        /// Initialize a new ShippingThresholdDiscountSingle object.
        /// </summary>
        public ShippingThresholdDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingThresholdDiscountSingle object.
        /// </summary>
        public ShippingThresholdDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingThresholdDiscountSingle object.
        /// </summary>
        public ShippingThresholdDiscountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingThresholdDiscount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for RetailDiscountLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDiscountLine")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine> RetailDiscountLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailDiscountLine == null))
                {
                    this._RetailDiscountLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine>(GetPath("RetailDiscountLine"));
                }
                return this._RetailDiscountLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine> _RetailDiscountLine;
    }
    /// <summary>
    /// There are no comments for ShippingThresholdDiscount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OfferId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OfferId")]
    [global::Microsoft.OData.Client.EntitySet("ShippingThresholdDiscounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingThresholdDiscount")]
    public partial class ShippingThresholdDiscount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingThresholdDiscount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="offerId">Initial value of OfferId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingThresholdDiscount CreateShippingThresholdDiscount(string dataAreaId, string offerId, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo)
        {
            ShippingThresholdDiscount shippingThresholdDiscount = new ShippingThresholdDiscount();
            shippingThresholdDiscount.DataAreaId = dataAreaId;
            shippingThresholdDiscount.OfferId = offerId;
            shippingThresholdDiscount.ValidFrom = validFrom;
            shippingThresholdDiscount.ValidTo = validTo;
            return shippingThresholdDiscount;
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
        /// There are no comments for Property OfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OfferId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OfferId is required.")]
        public virtual string OfferId
        {
            get
            {
                return this._OfferId;
            }
            set
            {
                this.OnOfferIdChanging(value);
                this._OfferId = value;
                this.OnOfferIdChanged();
                this.OnPropertyChanged("OfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfferId;
        partial void OnOfferIdChanging(string value);
        partial void OnOfferIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DiscountLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountLedgerDimensionDisplayValue")]
        public virtual string DiscountLedgerDimensionDisplayValue
        {
            get
            {
                return this._DiscountLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnDiscountLedgerDimensionDisplayValueChanging(value);
                this._DiscountLedgerDimensionDisplayValue = value;
                this.OnDiscountLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("DiscountLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountLedgerDimensionDisplayValue;
        partial void OnDiscountLedgerDimensionDisplayValueChanging(string value);
        partial void OnDiscountLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
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
        /// There are no comments for Property DiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountCode")]
        public virtual string DiscountCode
        {
            get
            {
                return this._DiscountCode;
            }
            set
            {
                this.OnDiscountCodeChanging(value);
                this._DiscountCode = value;
                this.OnDiscountCodeChanged();
                this.OnPropertyChanged("DiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountCode;
        partial void OnDiscountCodeChanging(string value);
        partial void OnDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property DateValidationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateValidationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> DateValidationType
        {
            get
            {
                return this._DateValidationType;
            }
            set
            {
                this.OnDateValidationTypeChanging(value);
                this._DateValidationType = value;
                this.OnDateValidationTypeChanged();
                this.OnPropertyChanged("DateValidationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> _DateValidationType;
        partial void OnDateValidationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> value);
        partial void OnDateValidationTypeChanged();
        /// <summary>
        /// There are no comments for Property DeliveryMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryMode")]
        public virtual string DeliveryMode
        {
            get
            {
                return this._DeliveryMode;
            }
            set
            {
                this.OnDeliveryModeChanging(value);
                this._DeliveryMode = value;
                this.OnDeliveryModeChanged();
                this.OnPropertyChanged("DeliveryMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryMode;
        partial void OnDeliveryModeChanging(string value);
        partial void OnDeliveryModeChanged();
        /// <summary>
        /// There are no comments for Property Disclaimer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Disclaimer")]
        public virtual string Disclaimer
        {
            get
            {
                return this._Disclaimer;
            }
            set
            {
                this.OnDisclaimerChanging(value);
                this._Disclaimer = value;
                this.OnDisclaimerChanged();
                this.OnPropertyChanged("Disclaimer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Disclaimer;
        partial void OnDisclaimerChanging(string value);
        partial void OnDisclaimerChanged();
        /// <summary>
        /// There are no comments for Property ValidationPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidationPeriodId")]
        public virtual string ValidationPeriodId
        {
            get
            {
                return this._ValidationPeriodId;
            }
            set
            {
                this.OnValidationPeriodIdChanging(value);
                this._ValidationPeriodId = value;
                this.OnValidationPeriodIdChanged();
                this.OnPropertyChanged("ValidationPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValidationPeriodId;
        partial void OnValidationPeriodIdChanging(string value);
        partial void OnValidationPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property IsDiscountCodeRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDiscountCodeRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDiscountCodeRequired
        {
            get
            {
                return this._IsDiscountCodeRequired;
            }
            set
            {
                this.OnIsDiscountCodeRequiredChanging(value);
                this._IsDiscountCodeRequired = value;
                this.OnIsDiscountCodeRequiredChanged();
                this.OnPropertyChanged("IsDiscountCodeRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDiscountCodeRequired;
        partial void OnIsDiscountCodeRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDiscountCodeRequiredChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property PrintDescriptionOnFiscalReceipt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintDescriptionOnFiscalReceipt")]
        public virtual string PrintDescriptionOnFiscalReceipt
        {
            get
            {
                return this._PrintDescriptionOnFiscalReceipt;
            }
            set
            {
                this.OnPrintDescriptionOnFiscalReceiptChanging(value);
                this._PrintDescriptionOnFiscalReceipt = value;
                this.OnPrintDescriptionOnFiscalReceiptChanged();
                this.OnPropertyChanged("PrintDescriptionOnFiscalReceipt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrintDescriptionOnFiscalReceipt;
        partial void OnPrintDescriptionOnFiscalReceiptChanging(string value);
        partial void OnPrintDescriptionOnFiscalReceiptChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property RetailDiscountLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDiscountLine")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine> RetailDiscountLine
        {
            get
            {
                return this._RetailDiscountLine;
            }
            set
            {
                this.OnRetailDiscountLineChanging(value);
                this._RetailDiscountLine = value;
                this.OnRetailDiscountLineChanged();
                this.OnPropertyChanged("RetailDiscountLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine> _RetailDiscountLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailDiscountLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailDiscountLine> value);
        partial void OnRetailDiscountLineChanged();
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
