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
    /// There are no comments for PayrollTaxGroupCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollTaxGroupCodeSingle")]
    public partial class PayrollTaxGroupCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollTaxGroupCode>
    {
        /// <summary>
        /// Initialize a new PayrollTaxGroupCodeSingle object.
        /// </summary>
        public PayrollTaxGroupCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollTaxGroupCodeSingle object.
        /// </summary>
        public PayrollTaxGroupCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollTaxGroupCodeSingle object.
        /// </summary>
        public PayrollTaxGroupCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollTaxGroupCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle TaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroup == null))
                {
                    this._TaxGroup = new global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle(this.Context, GetPath("TaxGroup"));
                }
                return this._TaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupSingle _TaxGroup;
    }
    /// <summary>
    /// There are no comments for PayrollTaxGroupCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TaxGroupId
    /// TaxCodeId
    /// TaxCodeCountryRegionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TaxGroupId", "TaxCodeId", "TaxCodeCountryRegionId")]
    [global::Microsoft.OData.Client.EntitySet("PayrollTaxGroupCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollTaxGroupCode")]
    public partial class PayrollTaxGroupCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollTaxGroupCode object.
        /// </summary>
        /// <param name="taxGroupId">Initial value of TaxGroupId.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        /// <param name="taxCodeCountryRegionId">Initial value of TaxCodeCountryRegionId.</param>
        /// <param name="taxGroup">Initial value of TaxGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollTaxGroupCode CreatePayrollTaxGroupCode(string taxGroupId, string taxCodeId, string taxCodeCountryRegionId, global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup taxGroup)
        {
            PayrollTaxGroupCode payrollTaxGroupCode = new PayrollTaxGroupCode();
            payrollTaxGroupCode.TaxGroupId = taxGroupId;
            payrollTaxGroupCode.TaxCodeId = taxCodeId;
            payrollTaxGroupCode.TaxCodeCountryRegionId = taxCodeCountryRegionId;
            if ((taxGroup == null))
            {
                throw new global::System.ArgumentNullException("taxGroup");
            }
            payrollTaxGroupCode.TaxGroup = taxGroup;
            return payrollTaxGroupCode;
        }
        /// <summary>
        /// There are no comments for Property TaxGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxGroupId is required.")]
        public virtual string TaxGroupId
        {
            get
            {
                return this._TaxGroupId;
            }
            set
            {
                this.OnTaxGroupIdChanging(value);
                this._TaxGroupId = value;
                this.OnTaxGroupIdChanged();
                this.OnPropertyChanged("TaxGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxGroupId;
        partial void OnTaxGroupIdChanging(string value);
        partial void OnTaxGroupIdChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCodeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxCodeId is required.")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCodeCountryRegionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxCodeCountryRegionId is required.")]
        public virtual string TaxCodeCountryRegionId
        {
            get
            {
                return this._TaxCodeCountryRegionId;
            }
            set
            {
                this.OnTaxCodeCountryRegionIdChanging(value);
                this._TaxCodeCountryRegionId = value;
                this.OnTaxCodeCountryRegionIdChanged();
                this.OnPropertyChanged("TaxCodeCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeCountryRegionId;
        partial void OnTaxCodeCountryRegionIdChanging(string value);
        partial void OnTaxCodeCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup TaxGroup
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
        private global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup _TaxGroup;
        partial void OnTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.PayrollTaxGroup value);
        partial void OnTaxGroupChanged();
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