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
    /// There are no comments for AssetTransReportingCurrencyAmountsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetTransReportingCurrencyAmountsSingle")]
    public partial class AssetTransReportingCurrencyAmountsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetTransReportingCurrencyAmounts>
    {
        /// <summary>
        /// Initialize a new AssetTransReportingCurrencyAmountsSingle object.
        /// </summary>
        public AssetTransReportingCurrencyAmountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetTransReportingCurrencyAmountsSingle object.
        /// </summary>
        public AssetTransReportingCurrencyAmountsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetTransReportingCurrencyAmountsSingle object.
        /// </summary>
        public AssetTransReportingCurrencyAmountsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetTransReportingCurrencyAmounts> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetTransReportingCurrencyAmounts in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AssetTrans
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AssetTrans")]
    [global::Microsoft.OData.Client.EntitySet("AssetTransReportingCurrencyAmounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetTransReportingCurrencyAmounts")]
    public partial class AssetTransReportingCurrencyAmounts : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetTransReportingCurrencyAmounts object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="assetTrans">Initial value of AssetTrans.</param>
        /// <param name="amountCur">Initial value of AmountCur.</param>
        /// <param name="reportingCurrencyExchRate">Initial value of ReportingCurrencyExchRate.</param>
        /// <param name="amountMST">Initial value of AmountMST.</param>
        /// <param name="amountReportingCurrency">Initial value of AmountReportingCurrency.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetTransReportingCurrencyAmounts CreateAssetTransReportingCurrencyAmounts(string dataAreaId, 
                    long assetTrans, 
                    decimal amountCur, 
                    decimal reportingCurrencyExchRate, 
                    decimal amountMST, 
                    decimal amountReportingCurrency, 
                    global::System.DateTimeOffset transDate)
        {
            AssetTransReportingCurrencyAmounts assetTransReportingCurrencyAmounts = new AssetTransReportingCurrencyAmounts();
            assetTransReportingCurrencyAmounts.DataAreaId = dataAreaId;
            assetTransReportingCurrencyAmounts.AssetTrans = assetTrans;
            assetTransReportingCurrencyAmounts.AmountCur = amountCur;
            assetTransReportingCurrencyAmounts.ReportingCurrencyExchRate = reportingCurrencyExchRate;
            assetTransReportingCurrencyAmounts.AmountMST = amountMST;
            assetTransReportingCurrencyAmounts.AmountReportingCurrency = amountReportingCurrency;
            assetTransReportingCurrencyAmounts.TransDate = transDate;
            return assetTransReportingCurrencyAmounts;
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
        /// There are no comments for Property AssetTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetTrans")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssetTrans is required.")]
        public virtual long AssetTrans
        {
            get
            {
                return this._AssetTrans;
            }
            set
            {
                this.OnAssetTransChanging(value);
                this._AssetTrans = value;
                this.OnAssetTransChanged();
                this.OnPropertyChanged("AssetTrans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _AssetTrans;
        partial void OnAssetTransChanging(long value);
        partial void OnAssetTransChanged();
        /// <summary>
        /// There are no comments for Property AmountCur in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountCur")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountCur is required.")]
        public virtual decimal AmountCur
        {
            get
            {
                return this._AmountCur;
            }
            set
            {
                this.OnAmountCurChanging(value);
                this._AmountCur = value;
                this.OnAmountCurChanged();
                this.OnPropertyChanged("AmountCur");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountCur;
        partial void OnAmountCurChanging(decimal value);
        partial void OnAmountCurChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetId")]
        public virtual string AssetId
        {
            get
            {
                return this._AssetId;
            }
            set
            {
                this.OnAssetIdChanging(value);
                this._AssetId = value;
                this.OnAssetIdChanged();
                this.OnPropertyChanged("AssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssetId;
        partial void OnAssetIdChanging(string value);
        partial void OnAssetIdChanged();
        /// <summary>
        /// There are no comments for Property BookId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BookId")]
        public virtual string BookId
        {
            get
            {
                return this._BookId;
            }
            set
            {
                this.OnBookIdChanging(value);
                this._BookId = value;
                this.OnBookIdChanged();
                this.OnPropertyChanged("BookId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BookId;
        partial void OnBookIdChanging(string value);
        partial void OnBookIdChanged();
        /// <summary>
        /// There are no comments for Property ReportingCurrencyExchRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportingCurrencyExchRate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReportingCurrencyExchRate is required.")]
        public virtual decimal ReportingCurrencyExchRate
        {
            get
            {
                return this._ReportingCurrencyExchRate;
            }
            set
            {
                this.OnReportingCurrencyExchRateChanging(value);
                this._ReportingCurrencyExchRate = value;
                this.OnReportingCurrencyExchRateChanged();
                this.OnPropertyChanged("ReportingCurrencyExchRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ReportingCurrencyExchRate;
        partial void OnReportingCurrencyExchRateChanging(decimal value);
        partial void OnReportingCurrencyExchRateChanged();
        /// <summary>
        /// There are no comments for Property AmountMST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountMST")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountMST is required.")]
        public virtual decimal AmountMST
        {
            get
            {
                return this._AmountMST;
            }
            set
            {
                this.OnAmountMSTChanging(value);
                this._AmountMST = value;
                this.OnAmountMSTChanged();
                this.OnPropertyChanged("AmountMST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountMST;
        partial void OnAmountMSTChanging(decimal value);
        partial void OnAmountMSTChanged();
        /// <summary>
        /// There are no comments for Property TransType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> TransType
        {
            get
            {
                return this._TransType;
            }
            set
            {
                this.OnTransTypeChanging(value);
                this._TransType = value;
                this.OnTransTypeChanged();
                this.OnPropertyChanged("TransType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> _TransType;
        partial void OnTransTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetTransType> value);
        partial void OnTransTypeChanged();
        /// <summary>
        /// There are no comments for Property AmountReportingCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountReportingCurrency")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AmountReportingCurrency is required.")]
        public virtual decimal AmountReportingCurrency
        {
            get
            {
                return this._AmountReportingCurrency;
            }
            set
            {
                this.OnAmountReportingCurrencyChanging(value);
                this._AmountReportingCurrency = value;
                this.OnAmountReportingCurrencyChanged();
                this.OnPropertyChanged("AmountReportingCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountReportingCurrency;
        partial void OnAmountReportingCurrencyChanging(decimal value);
        partial void OnAmountReportingCurrencyChanged();
        /// <summary>
        /// There are no comments for Property TransDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransDate is required.")]
        public virtual global::System.DateTimeOffset TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                this.OnTransDateChanging(value);
                this._TransDate = value;
                this.OnTransDateChanged();
                this.OnPropertyChanged("TransDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransDate;
        partial void OnTransDateChanging(global::System.DateTimeOffset value);
        partial void OnTransDateChanged();
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