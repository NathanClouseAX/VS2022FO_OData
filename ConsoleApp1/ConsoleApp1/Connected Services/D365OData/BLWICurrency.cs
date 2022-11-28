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
    /// There are no comments for BLWICurrencySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BLWICurrencySingle")]
    public partial class BLWICurrencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BLWICurrency>
    {
        /// <summary>
        /// Initialize a new BLWICurrencySingle object.
        /// </summary>
        public BLWICurrencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BLWICurrencySingle object.
        /// </summary>
        public BLWICurrencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BLWICurrencySingle object.
        /// </summary>
        public BLWICurrencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BLWICurrency> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BLWICurrency in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Currency
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Currency")]
    [global::Microsoft.OData.Client.EntitySet("BLWICurrencies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BLWICurrency")]
    public partial class BLWICurrency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BLWICurrency object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="currency">Initial value of Currency.</param>
        /// <param name="columnNumber">Initial value of ColumnNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BLWICurrency CreateBLWICurrency(string dataAreaId, string currency, int columnNumber)
        {
            BLWICurrency bLWICurrency = new BLWICurrency();
            bLWICurrency.DataAreaId = dataAreaId;
            bLWICurrency.Currency = currency;
            bLWICurrency.ColumnNumber = columnNumber;
            return bLWICurrency;
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
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Currency is required.")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property ColumnNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ColumnNumber is required.")]
        public virtual int ColumnNumber
        {
            get
            {
                return this._ColumnNumber;
            }
            set
            {
                this.OnColumnNumberChanging(value);
                this._ColumnNumber = value;
                this.OnColumnNumberChanged();
                this.OnPropertyChanged("ColumnNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ColumnNumber;
        partial void OnColumnNumberChanging(int value);
        partial void OnColumnNumberChanged();
        /// <summary>
        /// There are no comments for Property ReportInThisCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportInThisCurrency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ReportInThisCurrency
        {
            get
            {
                return this._ReportInThisCurrency;
            }
            set
            {
                this.OnReportInThisCurrencyChanging(value);
                this._ReportInThisCurrency = value;
                this.OnReportInThisCurrencyChanged();
                this.OnPropertyChanged("ReportInThisCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ReportInThisCurrency;
        partial void OnReportInThisCurrencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReportInThisCurrencyChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
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