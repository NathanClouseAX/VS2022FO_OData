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
    /// There are no comments for ShippingContainerAutoCostHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerAutoCostHeaderSingle")]
    public partial class ShippingContainerAutoCostHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerAutoCostHeader>
    {
        /// <summary>
        /// Initialize a new ShippingContainerAutoCostHeaderSingle object.
        /// </summary>
        public ShippingContainerAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ShippingContainerAutoCostHeaderSingle object.
        /// </summary>
        public ShippingContainerAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ShippingContainerAutoCostHeaderSingle object.
        /// </summary>
        public ShippingContainerAutoCostHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ShippingContainerAutoCostHeader> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ShippingContainerAutoCostHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShippingContainerCostAutoNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShippingContainerCostAutoNumber")]
    [global::Microsoft.OData.Client.EntitySet("ShippingContainerAutoCostHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerAutoCostHeader")]
    public partial class ShippingContainerAutoCostHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ShippingContainerAutoCostHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shippingContainerCostAutoNumber">Initial value of ShippingContainerCostAutoNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ShippingContainerAutoCostHeader CreateShippingContainerAutoCostHeader(string dataAreaId, string shippingContainerCostAutoNumber)
        {
            ShippingContainerAutoCostHeader shippingContainerAutoCostHeader = new ShippingContainerAutoCostHeader();
            shippingContainerAutoCostHeader.DataAreaId = dataAreaId;
            shippingContainerAutoCostHeader.ShippingContainerCostAutoNumber = shippingContainerCostAutoNumber;
            return shippingContainerAutoCostHeader;
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
        /// There are no comments for Property ShippingContainerCostAutoNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerCostAutoNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShippingContainerCostAutoNumber is required.")]
        public virtual string ShippingContainerCostAutoNumber
        {
            get
            {
                return this._ShippingContainerCostAutoNumber;
            }
            set
            {
                this.OnShippingContainerCostAutoNumberChanging(value);
                this._ShippingContainerCostAutoNumber = value;
                this.OnShippingContainerCostAutoNumberChanged();
                this.OnPropertyChanged("ShippingContainerCostAutoNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingContainerCostAutoNumber;
        partial void OnShippingContainerCostAutoNumberChanging(string value);
        partial void OnShippingContainerCostAutoNumberChanged();
        /// <summary>
        /// There are no comments for Property ShippingVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingVendorAccountNumber")]
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
        /// There are no comments for Property FromShippingPortId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromShippingPortId")]
        public virtual string FromShippingPortId
        {
            get
            {
                return this._FromShippingPortId;
            }
            set
            {
                this.OnFromShippingPortIdChanging(value);
                this._FromShippingPortId = value;
                this.OnFromShippingPortIdChanged();
                this.OnPropertyChanged("FromShippingPortId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromShippingPortId;
        partial void OnFromShippingPortIdChanging(string value);
        partial void OnFromShippingPortIdChanged();
        /// <summary>
        /// There are no comments for Property ShippingContainerTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingContainerTypeId")]
        public virtual string ShippingContainerTypeId
        {
            get
            {
                return this._ShippingContainerTypeId;
            }
            set
            {
                this.OnShippingContainerTypeIdChanging(value);
                this._ShippingContainerTypeId = value;
                this.OnShippingContainerTypeIdChanged();
                this.OnPropertyChanged("ShippingContainerTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingContainerTypeId;
        partial void OnShippingContainerTypeIdChanging(string value);
        partial void OnShippingContainerTypeIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryModeCode")]
        public virtual string DeliveryModeCode
        {
            get
            {
                return this._DeliveryModeCode;
            }
            set
            {
                this.OnDeliveryModeCodeChanging(value);
                this._DeliveryModeCode = value;
                this.OnDeliveryModeCodeChanged();
                this.OnPropertyChanged("DeliveryModeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeCode;
        partial void OnDeliveryModeCodeChanging(string value);
        partial void OnDeliveryModeCodeChanged();
        /// <summary>
        /// There are no comments for Property ToShippingPortId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToShippingPortId")]
        public virtual string ToShippingPortId
        {
            get
            {
                return this._ToShippingPortId;
            }
            set
            {
                this.OnToShippingPortIdChanging(value);
                this._ToShippingPortId = value;
                this.OnToShippingPortIdChanged();
                this.OnPropertyChanged("ToShippingPortId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToShippingPortId;
        partial void OnToShippingPortIdChanging(string value);
        partial void OnToShippingPortIdChanged();
        /// <summary>
        /// There are no comments for Property VendorLandedCostTypeGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorLandedCostTypeGroupId")]
        public virtual string VendorLandedCostTypeGroupId
        {
            get
            {
                return this._VendorLandedCostTypeGroupId;
            }
            set
            {
                this.OnVendorLandedCostTypeGroupIdChanging(value);
                this._VendorLandedCostTypeGroupId = value;
                this.OnVendorLandedCostTypeGroupIdChanged();
                this.OnPropertyChanged("VendorLandedCostTypeGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorLandedCostTypeGroupId;
        partial void OnVendorLandedCostTypeGroupIdChanging(string value);
        partial void OnVendorLandedCostTypeGroupIdChanged();
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