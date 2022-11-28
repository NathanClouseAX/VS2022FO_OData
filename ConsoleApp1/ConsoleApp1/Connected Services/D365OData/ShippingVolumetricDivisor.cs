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
    /// There are no comments for ShippingVolumetricDivisorSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingVolumetricDivisorSingle")]
    public partial class ShippingVolumetricDivisorSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingVolumetricDivisor>
    {
        /// <summary>
        /// Initialize a new ShippingVolumetricDivisorSingle object.
        /// </summary>
        public ShippingVolumetricDivisorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingVolumetricDivisorSingle object.
        /// </summary>
        public ShippingVolumetricDivisorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingVolumetricDivisorSingle object.
        /// </summary>
        public ShippingVolumetricDivisorSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingVolumetricDivisor> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShippingVolumetricDivisor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShippingVendorAccountNumber
    /// LandedCostTypeCode
    /// FromShippingPortCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShippingVendorAccountNumber", "LandedCostTypeCode", "FromShippingPortCode")]
    [global::Microsoft.OData.Client.EntitySet("ShippingVolumetricDivisors")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingVolumetricDivisor")]
    public partial class ShippingVolumetricDivisor : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingVolumetricDivisor object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shippingVendorAccountNumber">Initial value of ShippingVendorAccountNumber.</param>
        /// <param name="landedCostTypeCode">Initial value of LandedCostTypeCode.</param>
        /// <param name="fromShippingPortCode">Initial value of FromShippingPortCode.</param>
        /// <param name="volumetricDivisor">Initial value of VolumetricDivisor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingVolumetricDivisor CreateShippingVolumetricDivisor(string dataAreaId, string shippingVendorAccountNumber, string landedCostTypeCode, string fromShippingPortCode, decimal volumetricDivisor)
        {
            ShippingVolumetricDivisor shippingVolumetricDivisor = new ShippingVolumetricDivisor();
            shippingVolumetricDivisor.DataAreaId = dataAreaId;
            shippingVolumetricDivisor.ShippingVendorAccountNumber = shippingVendorAccountNumber;
            shippingVolumetricDivisor.LandedCostTypeCode = landedCostTypeCode;
            shippingVolumetricDivisor.FromShippingPortCode = fromShippingPortCode;
            shippingVolumetricDivisor.VolumetricDivisor = volumetricDivisor;
            return shippingVolumetricDivisor;
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
        /// There are no comments for Property ShippingVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingVendorAccountNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShippingVendorAccountNumber is required.")]
        public virtual string ShippingVendorAccountNumber
        {
            get
            {
                return this._ShippingVendorAccountNumber;
            }
            set
            {
                this.OnShippingVendorAccountNumberChanging(value);
                this._ShippingVendorAccountNumber = value;
                this.OnShippingVendorAccountNumberChanged();
                this.OnPropertyChanged("ShippingVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingVendorAccountNumber;
        partial void OnShippingVendorAccountNumberChanging(string value);
        partial void OnShippingVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property LandedCostTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LandedCostTypeCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LandedCostTypeCode is required.")]
        public virtual string LandedCostTypeCode
        {
            get
            {
                return this._LandedCostTypeCode;
            }
            set
            {
                this.OnLandedCostTypeCodeChanging(value);
                this._LandedCostTypeCode = value;
                this.OnLandedCostTypeCodeChanged();
                this.OnPropertyChanged("LandedCostTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LandedCostTypeCode;
        partial void OnLandedCostTypeCodeChanging(string value);
        partial void OnLandedCostTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property FromShippingPortCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromShippingPortCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromShippingPortCode is required.")]
        public virtual string FromShippingPortCode
        {
            get
            {
                return this._FromShippingPortCode;
            }
            set
            {
                this.OnFromShippingPortCodeChanging(value);
                this._FromShippingPortCode = value;
                this.OnFromShippingPortCodeChanged();
                this.OnPropertyChanged("FromShippingPortCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromShippingPortCode;
        partial void OnFromShippingPortCodeChanging(string value);
        partial void OnFromShippingPortCodeChanged();
        /// <summary>
        /// There are no comments for Property VolumetricDivisor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VolumetricDivisor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VolumetricDivisor is required.")]
        public virtual decimal VolumetricDivisor
        {
            get
            {
                return this._VolumetricDivisor;
            }
            set
            {
                this.OnVolumetricDivisorChanging(value);
                this._VolumetricDivisor = value;
                this.OnVolumetricDivisorChanged();
                this.OnPropertyChanged("VolumetricDivisor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VolumetricDivisor;
        partial void OnVolumetricDivisorChanging(decimal value);
        partial void OnVolumetricDivisorChanged();
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
