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
    /// There are no comments for CouponSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CouponSingle")]
    public partial class CouponSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Coupon>
    {
        /// <summary>
        /// Initialize a new CouponSingle object.
        /// </summary>
        public CouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CouponSingle object.
        /// </summary>
        public CouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CouponSingle object.
        /// </summary>
        public CouponSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Coupon> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Coupon in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CouponNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CouponNumber")]
    [global::Microsoft.OData.Client.EntitySet("Coupons")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Coupon")]
    public partial class Coupon : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Coupon object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="couponNumber">Initial value of CouponNumber.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="usageLimit">Initial value of UsageLimit.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Coupon CreateCoupon(string dataAreaId, string couponNumber, global::System.DateTimeOffset validTo, int usageLimit, global::System.DateTimeOffset validFrom)
        {
            Coupon coupon = new Coupon();
            coupon.DataAreaId = dataAreaId;
            coupon.CouponNumber = couponNumber;
            coupon.ValidTo = validTo;
            coupon.UsageLimit = usageLimit;
            coupon.ValidFrom = validFrom;
            return coupon;
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
        /// There are no comments for Property CouponNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CouponNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CouponNumber is required.")]
        public virtual string CouponNumber
        {
            get
            {
                return this._CouponNumber;
            }
            set
            {
                this.OnCouponNumberChanging(value);
                this._CouponNumber = value;
                this.OnCouponNumberChanged();
                this.OnPropertyChanged("CouponNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CouponNumber;
        partial void OnCouponNumberChanging(string value);
        partial void OnCouponNumberChanged();
        /// <summary>
        /// There are no comments for Property ApplyWithoutCouponCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApplyWithoutCouponCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ApplyWithoutCouponCode
        {
            get
            {
                return this._ApplyWithoutCouponCode;
            }
            set
            {
                this.OnApplyWithoutCouponCodeChanging(value);
                this._ApplyWithoutCouponCode = value;
                this.OnApplyWithoutCouponCodeChanged();
                this.OnPropertyChanged("ApplyWithoutCouponCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ApplyWithoutCouponCode;
        partial void OnApplyWithoutCouponCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnApplyWithoutCouponCodeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property IsExclusive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsExclusive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExclusive
        {
            get
            {
                return this._IsExclusive;
            }
            set
            {
                this.OnIsExclusiveChanging(value);
                this._IsExclusive = value;
                this.OnIsExclusiveChanged();
                this.OnPropertyChanged("IsExclusive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExclusive;
        partial void OnIsExclusiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExclusiveChanged();
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
        /// There are no comments for Property UsageLimitType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UsageLimitType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponUsageLimitType> UsageLimitType
        {
            get
            {
                return this._UsageLimitType;
            }
            set
            {
                this.OnUsageLimitTypeChanging(value);
                this._UsageLimitType = value;
                this.OnUsageLimitTypeChanged();
                this.OnPropertyChanged("UsageLimitType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponUsageLimitType> _UsageLimitType;
        partial void OnUsageLimitTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailCouponUsageLimitType> value);
        partial void OnUsageLimitTypeChanged();
        /// <summary>
        /// There are no comments for Property IsCustomerRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCustomerRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCustomerRequired
        {
            get
            {
                return this._IsCustomerRequired;
            }
            set
            {
                this.OnIsCustomerRequiredChanging(value);
                this._IsCustomerRequired = value;
                this.OnIsCustomerRequiredChanged();
                this.OnPropertyChanged("IsCustomerRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCustomerRequired;
        partial void OnIsCustomerRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCustomerRequiredChanged();
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
        /// There are no comments for Property UsageLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UsageLimit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UsageLimit is required.")]
        public virtual int UsageLimit
        {
            get
            {
                return this._UsageLimit;
            }
            set
            {
                this.OnUsageLimitChanging(value);
                this._UsageLimit = value;
                this.OnUsageLimitChanged();
                this.OnPropertyChanged("UsageLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UsageLimit;
        partial void OnUsageLimitChanging(int value);
        partial void OnUsageLimitChanged();
        /// <summary>
        /// There are no comments for Property DiscountOfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountOfferId")]
        public virtual string DiscountOfferId
        {
            get
            {
                return this._DiscountOfferId;
            }
            set
            {
                this.OnDiscountOfferIdChanging(value);
                this._DiscountOfferId = value;
                this.OnDiscountOfferIdChanged();
                this.OnPropertyChanged("DiscountOfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountOfferId;
        partial void OnDiscountOfferIdChanging(string value);
        partial void OnDiscountOfferIdChanged();
        /// <summary>
        /// There are no comments for Property ParentCouponNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentCouponNumber")]
        public virtual string ParentCouponNumber
        {
            get
            {
                return this._ParentCouponNumber;
            }
            set
            {
                this.OnParentCouponNumberChanging(value);
                this._ParentCouponNumber = value;
                this.OnParentCouponNumberChanged();
                this.OnPropertyChanged("ParentCouponNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentCouponNumber;
        partial void OnParentCouponNumberChanging(string value);
        partial void OnParentCouponNumberChanged();
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