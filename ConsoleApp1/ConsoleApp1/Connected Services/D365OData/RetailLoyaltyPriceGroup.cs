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
    /// There are no comments for RetailLoyaltyPriceGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailLoyaltyPriceGroupSingle")]
    public partial class RetailLoyaltyPriceGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailLoyaltyPriceGroup>
    {
        /// <summary>
        /// Initialize a new RetailLoyaltyPriceGroupSingle object.
        /// </summary>
        public RetailLoyaltyPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailLoyaltyPriceGroupSingle object.
        /// </summary>
        public RetailLoyaltyPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailLoyaltyPriceGroupSingle object.
        /// </summary>
        public RetailLoyaltyPriceGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailLoyaltyPriceGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PriceCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceCustomerGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle PriceCustomerGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PriceCustomerGroup == null))
                {
                    this._PriceCustomerGroup = new global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle(this.Context, GetPath("PriceCustomerGroup"));
                }
                return this._PriceCustomerGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle _PriceCustomerGroup;
        /// <summary>
        /// There are no comments for RetailLoyalty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailLoyalty")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailLoyaltySingle RetailLoyalty
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailLoyalty == null))
                {
                    this._RetailLoyalty = new global::Microsoft.Dynamics.DataEntities.RetailLoyaltySingle(this.Context, GetPath("RetailLoyalty"));
                }
                return this._RetailLoyalty;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailLoyaltySingle _RetailLoyalty;
    }
    /// <summary>
    /// There are no comments for RetailLoyaltyPriceGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LoyaltyName
    /// PriceCustomerGroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LoyaltyName", "PriceCustomerGroupCode")]
    [global::Microsoft.OData.Client.EntitySet("RetailLoyaltyPriceGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailLoyaltyPriceGroup")]
    public partial class RetailLoyaltyPriceGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailLoyaltyPriceGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="loyaltyName">Initial value of LoyaltyName.</param>
        /// <param name="priceCustomerGroupCode">Initial value of PriceCustomerGroupCode.</param>
        /// <param name="priceCustomerGroup">Initial value of PriceCustomerGroup.</param>
        /// <param name="retailLoyalty">Initial value of RetailLoyalty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailLoyaltyPriceGroup CreateRetailLoyaltyPriceGroup(string dataAreaId, string loyaltyName, string priceCustomerGroupCode, global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup priceCustomerGroup, global::Microsoft.Dynamics.DataEntities.RetailLoyalty retailLoyalty)
        {
            RetailLoyaltyPriceGroup retailLoyaltyPriceGroup = new RetailLoyaltyPriceGroup();
            retailLoyaltyPriceGroup.DataAreaId = dataAreaId;
            retailLoyaltyPriceGroup.LoyaltyName = loyaltyName;
            retailLoyaltyPriceGroup.PriceCustomerGroupCode = priceCustomerGroupCode;
            if ((priceCustomerGroup == null))
            {
                throw new global::System.ArgumentNullException("priceCustomerGroup");
            }
            retailLoyaltyPriceGroup.PriceCustomerGroup = priceCustomerGroup;
            if ((retailLoyalty == null))
            {
                throw new global::System.ArgumentNullException("retailLoyalty");
            }
            retailLoyaltyPriceGroup.RetailLoyalty = retailLoyalty;
            return retailLoyaltyPriceGroup;
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
        /// There are no comments for Property LoyaltyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoyaltyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoyaltyName is required.")]
        public virtual string LoyaltyName
        {
            get
            {
                return this._LoyaltyName;
            }
            set
            {
                this.OnLoyaltyNameChanging(value);
                this._LoyaltyName = value;
                this.OnLoyaltyNameChanged();
                this.OnPropertyChanged("LoyaltyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoyaltyName;
        partial void OnLoyaltyNameChanging(string value);
        partial void OnLoyaltyNameChanged();
        /// <summary>
        /// There are no comments for Property PriceCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceCustomerGroupCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceCustomerGroupCode is required.")]
        public virtual string PriceCustomerGroupCode
        {
            get
            {
                return this._PriceCustomerGroupCode;
            }
            set
            {
                this.OnPriceCustomerGroupCodeChanging(value);
                this._PriceCustomerGroupCode = value;
                this.OnPriceCustomerGroupCodeChanged();
                this.OnPropertyChanged("PriceCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceCustomerGroupCode;
        partial void OnPriceCustomerGroupCodeChanging(string value);
        partial void OnPriceCustomerGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property PriceCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceCustomerGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceCustomerGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup PriceCustomerGroup
        {
            get
            {
                return this._PriceCustomerGroup;
            }
            set
            {
                this.OnPriceCustomerGroupChanging(value);
                this._PriceCustomerGroup = value;
                this.OnPriceCustomerGroupChanged();
                this.OnPropertyChanged("PriceCustomerGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup _PriceCustomerGroup;
        partial void OnPriceCustomerGroupChanging(global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup value);
        partial void OnPriceCustomerGroupChanged();
        /// <summary>
        /// There are no comments for Property RetailLoyalty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailLoyalty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailLoyalty is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailLoyalty RetailLoyalty
        {
            get
            {
                return this._RetailLoyalty;
            }
            set
            {
                this.OnRetailLoyaltyChanging(value);
                this._RetailLoyalty = value;
                this.OnRetailLoyaltyChanged();
                this.OnPropertyChanged("RetailLoyalty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailLoyalty _RetailLoyalty;
        partial void OnRetailLoyaltyChanging(global::Microsoft.Dynamics.DataEntities.RetailLoyalty value);
        partial void OnRetailLoyaltyChanged();
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