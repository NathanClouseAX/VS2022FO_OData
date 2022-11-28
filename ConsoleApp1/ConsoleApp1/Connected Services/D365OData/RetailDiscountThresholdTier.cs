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
    /// There are no comments for RetailDiscountThresholdTierSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDiscountThresholdTierSingle")]
    public partial class RetailDiscountThresholdTierSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDiscountThresholdTier>
    {
        /// <summary>
        /// Initialize a new RetailDiscountThresholdTierSingle object.
        /// </summary>
        public RetailDiscountThresholdTierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailDiscountThresholdTierSingle object.
        /// </summary>
        public RetailDiscountThresholdTierSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailDiscountThresholdTierSingle object.
        /// </summary>
        public RetailDiscountThresholdTierSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDiscountThresholdTier> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailDiscountThresholdTier in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OfferId
    /// AmountThreshold
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OfferId", "AmountThreshold")]
    [global::Microsoft.OData.Client.EntitySet("RetailDiscountThresholdTiers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDiscountThresholdTier")]
    public partial class RetailDiscountThresholdTier : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailDiscountThresholdTier object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="offerId">Initial value of OfferId.</param>
        /// <param name="amountThreshold">Initial value of AmountThreshold.</param>
        /// <param name="discountValue">Initial value of DiscountValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailDiscountThresholdTier CreateRetailDiscountThresholdTier(string dataAreaId, string offerId, decimal amountThreshold, decimal discountValue)
        {
            RetailDiscountThresholdTier retailDiscountThresholdTier = new RetailDiscountThresholdTier();
            retailDiscountThresholdTier.DataAreaId = dataAreaId;
            retailDiscountThresholdTier.OfferId = offerId;
            retailDiscountThresholdTier.AmountThreshold = amountThreshold;
            retailDiscountThresholdTier.DiscountValue = discountValue;
            return retailDiscountThresholdTier;
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
        /// There are no comments for Property AmountThreshold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountThreshold")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountThreshold is required.")]
        public virtual decimal AmountThreshold
        {
            get
            {
                return this._AmountThreshold;
            }
            set
            {
                this.OnAmountThresholdChanging(value);
                this._AmountThreshold = value;
                this.OnAmountThresholdChanged();
                this.OnPropertyChanged("AmountThreshold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountThreshold;
        partial void OnAmountThresholdChanging(decimal value);
        partial void OnAmountThresholdChanged();
        /// <summary>
        /// There are no comments for Property DiscountValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountValue is required.")]
        public virtual decimal DiscountValue
        {
            get
            {
                return this._DiscountValue;
            }
            set
            {
                this.OnDiscountValueChanging(value);
                this._DiscountValue = value;
                this.OnDiscountValueChanged();
                this.OnPropertyChanged("DiscountValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountValue;
        partial void OnDiscountValueChanging(decimal value);
        partial void OnDiscountValueChanged();
        /// <summary>
        /// There are no comments for Property DiscountMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailThresholdDiscountMethod> DiscountMethod
        {
            get
            {
                return this._DiscountMethod;
            }
            set
            {
                this.OnDiscountMethodChanging(value);
                this._DiscountMethod = value;
                this.OnDiscountMethodChanged();
                this.OnPropertyChanged("DiscountMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailThresholdDiscountMethod> _DiscountMethod;
        partial void OnDiscountMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailThresholdDiscountMethod> value);
        partial void OnDiscountMethodChanged();
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
