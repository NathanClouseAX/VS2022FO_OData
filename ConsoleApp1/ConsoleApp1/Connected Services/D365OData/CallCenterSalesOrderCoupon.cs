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
    /// There are no comments for CallCenterSalesOrderCouponSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CallCenterSalesOrderCouponSingle")]
    public partial class CallCenterSalesOrderCouponSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterSalesOrderCoupon>
    {
        /// <summary>
        /// Initialize a new CallCenterSalesOrderCouponSingle object.
        /// </summary>
        public CallCenterSalesOrderCouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CallCenterSalesOrderCouponSingle object.
        /// </summary>
        public CallCenterSalesOrderCouponSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CallCenterSalesOrderCouponSingle object.
        /// </summary>
        public CallCenterSalesOrderCouponSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterSalesOrderCoupon> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CallCenterSalesOrderCoupon in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CouponId
    /// SalesId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CouponId", "SalesId")]
    [global::Microsoft.OData.Client.EntitySet("CallCenterSalesOrderCoupons")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CallCenterSalesOrderCoupon")]
    public partial class CallCenterSalesOrderCoupon : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CallCenterSalesOrderCoupon object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="couponId">Initial value of CouponId.</param>
        /// <param name="salesId">Initial value of SalesId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CallCenterSalesOrderCoupon CreateCallCenterSalesOrderCoupon(string dataAreaId, string couponId, string salesId)
        {
            CallCenterSalesOrderCoupon callCenterSalesOrderCoupon = new CallCenterSalesOrderCoupon();
            callCenterSalesOrderCoupon.DataAreaId = dataAreaId;
            callCenterSalesOrderCoupon.CouponId = couponId;
            callCenterSalesOrderCoupon.SalesId = salesId;
            return callCenterSalesOrderCoupon;
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
        /// There are no comments for Property CouponId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CouponId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CouponId is required.")]
        public virtual string CouponId
        {
            get
            {
                return this._CouponId;
            }
            set
            {
                this.OnCouponIdChanging(value);
                this._CouponId = value;
                this.OnCouponIdChanged();
                this.OnPropertyChanged("CouponId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CouponId;
        partial void OnCouponIdChanging(string value);
        partial void OnCouponIdChanged();
        /// <summary>
        /// There are no comments for Property SalesId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SalesId is required.")]
        public virtual string SalesId
        {
            get
            {
                return this._SalesId;
            }
            set
            {
                this.OnSalesIdChanging(value);
                this._SalesId = value;
                this.OnSalesIdChanged();
                this.OnPropertyChanged("SalesId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesId;
        partial void OnSalesIdChanging(string value);
        partial void OnSalesIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccount")]
        public virtual string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property IsLiabilityDeducted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsLiabilityDeducted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsLiabilityDeducted
        {
            get
            {
                return this._IsLiabilityDeducted;
            }
            set
            {
                this.OnIsLiabilityDeductedChanging(value);
                this._IsLiabilityDeducted = value;
                this.OnIsLiabilityDeductedChanged();
                this.OnPropertyChanged("IsLiabilityDeducted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsLiabilityDeducted;
        partial void OnIsLiabilityDeductedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsLiabilityDeductedChanged();
        /// <summary>
        /// There are no comments for Property IsReissue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsReissue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsReissue
        {
            get
            {
                return this._IsReissue;
            }
            set
            {
                this.OnIsReissueChanging(value);
                this._IsReissue = value;
                this.OnIsReissueChanged();
                this.OnPropertyChanged("IsReissue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsReissue;
        partial void OnIsReissueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReissueChanged();
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
