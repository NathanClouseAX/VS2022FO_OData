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
    /// There are no comments for BadDebtAccountsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BadDebtAccountsSingle")]
    public partial class BadDebtAccountsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BadDebtAccounts>
    {
        /// <summary>
        /// Initialize a new BadDebtAccountsSingle object.
        /// </summary>
        public BadDebtAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BadDebtAccountsSingle object.
        /// </summary>
        public BadDebtAccountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BadDebtAccountsSingle object.
        /// </summary>
        public BadDebtAccountsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BadDebtAccounts> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BadDebtAccounts in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Company
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Company")]
    [global::Microsoft.OData.Client.EntitySet("BadDebtAccounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BadDebtAccounts")]
    public partial class BadDebtAccounts : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BadDebtAccounts object.
        /// </summary>
        /// <param name="company">Initial value of Company.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BadDebtAccounts CreateBadDebtAccounts(string company)
        {
            BadDebtAccounts badDebtAccounts = new BadDebtAccounts();
            badDebtAccounts.Company = company;
            return badDebtAccounts;
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
        /// There are no comments for Property BadDebtMainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BadDebtMainAccountDisplayValue")]
        public virtual string BadDebtMainAccountDisplayValue
        {
            get
            {
                return this._BadDebtMainAccountDisplayValue;
            }
            set
            {
                this.OnBadDebtMainAccountDisplayValueChanging(value);
                this._BadDebtMainAccountDisplayValue = value;
                this.OnBadDebtMainAccountDisplayValueChanged();
                this.OnPropertyChanged("BadDebtMainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BadDebtMainAccountDisplayValue;
        partial void OnBadDebtMainAccountDisplayValueChanging(string value);
        partial void OnBadDebtMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CollectedBadDebtMainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CollectedBadDebtMainAccountDisplayValue")]
        public virtual string CollectedBadDebtMainAccountDisplayValue
        {
            get
            {
                return this._CollectedBadDebtMainAccountDisplayValue;
            }
            set
            {
                this.OnCollectedBadDebtMainAccountDisplayValueChanging(value);
                this._CollectedBadDebtMainAccountDisplayValue = value;
                this.OnCollectedBadDebtMainAccountDisplayValueChanged();
                this.OnPropertyChanged("CollectedBadDebtMainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CollectedBadDebtMainAccountDisplayValue;
        partial void OnCollectedBadDebtMainAccountDisplayValueChanging(string value);
        partial void OnCollectedBadDebtMainAccountDisplayValueChanged();
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