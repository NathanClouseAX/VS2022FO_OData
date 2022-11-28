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
    /// There are no comments for RetailCatalogInternalOrganizationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganizationSingle")]
    public partial class RetailCatalogInternalOrganizationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogInternalOrganization>
    {
        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailCatalogInternalOrganizationSingle object.
        /// </summary>
        public RetailCatalogInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailCatalogInternalOrganization> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalog")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle RetailCatalog
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalog == null))
                {
                    this._RetailCatalog = new global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle(this.Context, GetPath("RetailCatalog"));
                }
                return this._RetailCatalog;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalogSingle _RetailCatalog;
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganizationProductAttributeValue")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> RetailCatalogInternalOrganizationProductAttributeValue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganizationProductAttributeValue == null))
                {
                    this._RetailCatalogInternalOrganizationProductAttributeValue = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue>(GetPath("RetailCatalogInternalOrganizationProductAttributeValue"));
                }
                return this._RetailCatalogInternalOrganizationProductAttributeValue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> _RetailCatalogInternalOrganizationProductAttributeValue;
        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganizationProductAttributeValue2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganizationProductAttributeValue2 == null))
                {
                    this._RetailCatalogInternalOrganizationProductAttributeValue2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(GetPath("RetailCatalogInternalOrganizationProductAttributeValue2"));
                }
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2;
    }
    /// <summary>
    /// There are no comments for RetailCatalogInternalOrganization in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CatalogNumber
    /// PartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CatalogNumber", "PartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailCatalogInternalOrganizations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganization")]
    public partial class RetailCatalogInternalOrganization : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailCatalogInternalOrganization object.
        /// </summary>
        /// <param name="catalogNumber">Initial value of CatalogNumber.</param>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailCatalogInternalOrganization CreateRetailCatalogInternalOrganization(string catalogNumber, string partyNumber)
        {
            RetailCatalogInternalOrganization retailCatalogInternalOrganization = new RetailCatalogInternalOrganization();
            retailCatalogInternalOrganization.CatalogNumber = catalogNumber;
            retailCatalogInternalOrganization.PartyNumber = partyNumber;
            return retailCatalogInternalOrganization;
        }
        /// <summary>
        /// There are no comments for Property CatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatalogNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CatalogNumber is required.")]
        public virtual string CatalogNumber
        {
            get
            {
                return this._CatalogNumber;
            }
            set
            {
                this.OnCatalogNumberChanging(value);
                this._CatalogNumber = value;
                this.OnCatalogNumberChanged();
                this.OnPropertyChanged("CatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatalogNumber;
        partial void OnCatalogNumberChanging(string value);
        partial void OnCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyNumber is required.")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalog")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailCatalog RetailCatalog
        {
            get
            {
                return this._RetailCatalog;
            }
            set
            {
                this.OnRetailCatalogChanging(value);
                this._RetailCatalog = value;
                this.OnRetailCatalogChanged();
                this.OnPropertyChanged("RetailCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailCatalog _RetailCatalog;
        partial void OnRetailCatalogChanging(global::Microsoft.Dynamics.DataEntities.RetailCatalog value);
        partial void OnRetailCatalogChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganizationProductAttributeValue")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> RetailCatalogInternalOrganizationProductAttributeValue
        {
            get
            {
                return this._RetailCatalogInternalOrganizationProductAttributeValue;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationProductAttributeValueChanging(value);
                this._RetailCatalogInternalOrganizationProductAttributeValue = value;
                this.OnRetailCatalogInternalOrganizationProductAttributeValueChanged();
                this.OnPropertyChanged("RetailCatalogInternalOrganizationProductAttributeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> _RetailCatalogInternalOrganizationProductAttributeValue = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValueChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue> value);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValueChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailCatalogInternalOrganizationProductAttributeValue2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(value);
                this._RetailCatalogInternalOrganizationProductAttributeValue2 = value;
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
                this.OnPropertyChanged("RetailCatalogInternalOrganizationProductAttributeValue2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> value);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
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
