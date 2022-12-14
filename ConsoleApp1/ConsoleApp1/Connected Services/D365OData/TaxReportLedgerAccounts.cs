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
    /// There are no comments for TaxReportLedgerAccountsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxReportLedgerAccountsSingle")]
    public partial class TaxReportLedgerAccountsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReportLedgerAccounts>
    {
        /// <summary>
        /// Initialize a new TaxReportLedgerAccountsSingle object.
        /// </summary>
        public TaxReportLedgerAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxReportLedgerAccountsSingle object.
        /// </summary>
        public TaxReportLedgerAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxReportLedgerAccountsSingle object.
        /// </summary>
        public TaxReportLedgerAccountsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReportLedgerAccounts> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxReportLedgerAccounts in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Company
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Company")]
    [global::Microsoft.OData.Client.EntitySet("TaxReportLedgerAccounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxReportLedgerAccounts")]
    public partial class TaxReportLedgerAccounts : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxReportLedgerAccounts object.
        /// </summary>
        /// <param name="company">Initial value of Company.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxReportLedgerAccounts CreateTaxReportLedgerAccounts(string company)
        {
            TaxReportLedgerAccounts taxReportLedgerAccounts = new TaxReportLedgerAccounts();
            taxReportLedgerAccounts.Company = company;
            return taxReportLedgerAccounts;
        }
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Company is required.")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property LedgerAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAccountDisplayValue")]
        public virtual string LedgerAccountDisplayValue
        {
            get
            {
                return this._LedgerAccountDisplayValue;
            }
            set
            {
                this.OnLedgerAccountDisplayValueChanging(value);
                this._LedgerAccountDisplayValue = value;
                this.OnLedgerAccountDisplayValueChanged();
                this.OnPropertyChanged("LedgerAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerAccountDisplayValue;
        partial void OnLedgerAccountDisplayValueChanging(string value);
        partial void OnLedgerAccountDisplayValueChanged();
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
