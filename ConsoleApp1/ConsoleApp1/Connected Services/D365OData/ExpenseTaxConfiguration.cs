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
    /// There are no comments for ExpenseTaxConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseTaxConfigurationSingle")]
    public partial class ExpenseTaxConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseTaxConfiguration>
    {
        /// <summary>
        /// Initialize a new ExpenseTaxConfigurationSingle object.
        /// </summary>
        public ExpenseTaxConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExpenseTaxConfigurationSingle object.
        /// </summary>
        public ExpenseTaxConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExpenseTaxConfigurationSingle object.
        /// </summary>
        public ExpenseTaxConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseTaxConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ExpenseTaxConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CountryRegionId
    /// TaxGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CountryRegionId", "TaxGroup")]
    [global::Microsoft.OData.Client.EntitySet("ExpenseTaxConfigurations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseTaxConfiguration")]
    public partial class ExpenseTaxConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExpenseTaxConfiguration object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="taxGroup">Initial value of TaxGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExpenseTaxConfiguration CreateExpenseTaxConfiguration(string dataAreaId, string countryRegionId, string taxGroup)
        {
            ExpenseTaxConfiguration expenseTaxConfiguration = new ExpenseTaxConfiguration();
            expenseTaxConfiguration.DataAreaId = dataAreaId;
            expenseTaxConfiguration.CountryRegionId = countryRegionId;
            expenseTaxConfiguration.TaxGroup = taxGroup;
            return expenseTaxConfiguration;
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
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryRegionId is required.")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxGroup is required.")]
        public virtual string TaxGroup
        {
            get
            {
                return this._TaxGroup;
            }
            set
            {
                this.OnTaxGroupChanging(value);
                this._TaxGroup = value;
                this.OnTaxGroupChanged();
                this.OnPropertyChanged("TaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroup;
        partial void OnTaxGroupChanging(string value);
        partial void OnTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property Instructions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Instructions")]
        public virtual string Instructions
        {
            get
            {
                return this._Instructions;
            }
            set
            {
                this.OnInstructionsChanging(value);
                this._Instructions = value;
                this.OnInstructionsChanged();
                this.OnPropertyChanged("Instructions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Instructions;
        partial void OnInstructionsChanging(string value);
        partial void OnInstructionsChanged();
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