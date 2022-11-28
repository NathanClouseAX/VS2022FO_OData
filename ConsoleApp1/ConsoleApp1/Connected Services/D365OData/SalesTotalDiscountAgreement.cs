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
    /// There are no comments for SalesTotalDiscountAgreementSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTotalDiscountAgreementSingle")]
    public partial class SalesTotalDiscountAgreementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesTotalDiscountAgreement>
    {
        /// <summary>
        /// Initialize a new SalesTotalDiscountAgreementSingle object.
        /// </summary>
        public SalesTotalDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesTotalDiscountAgreementSingle object.
        /// </summary>
        public SalesTotalDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesTotalDiscountAgreementSingle object.
        /// </summary>
        public SalesTotalDiscountAgreementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesTotalDiscountAgreement> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SalesTotalDiscountAgreement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RecordId")]
    [global::Microsoft.OData.Client.EntitySet("SalesTotalDiscountAgreements")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTotalDiscountAgreement")]
    public partial class SalesTotalDiscountAgreement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesTotalDiscountAgreement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="discountAmount">Initial value of DiscountAmount.</param>
        /// <param name="discountApplicableFromDate">Initial value of DiscountApplicableFromDate.</param>
        /// <param name="discountPercentage2">Initial value of DiscountPercentage2.</param>
        /// <param name="discountPercentage1">Initial value of DiscountPercentage1.</param>
        /// <param name="discountApplicableToDate">Initial value of DiscountApplicableToDate.</param>
        /// <param name="toOrderSubtotalAmount">Initial value of ToOrderSubtotalAmount.</param>
        /// <param name="fromOrderSubtotalAmount">Initial value of FromOrderSubtotalAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesTotalDiscountAgreement CreateSalesTotalDiscountAgreement(string dataAreaId, 
                    long recordId, 
                    decimal discountAmount, 
                    global::System.DateTimeOffset discountApplicableFromDate, 
                    decimal discountPercentage2, 
                    decimal discountPercentage1, 
                    global::System.DateTimeOffset discountApplicableToDate, 
                    decimal toOrderSubtotalAmount, 
                    decimal fromOrderSubtotalAmount)
        {
            SalesTotalDiscountAgreement salesTotalDiscountAgreement = new SalesTotalDiscountAgreement();
            salesTotalDiscountAgreement.DataAreaId = dataAreaId;
            salesTotalDiscountAgreement.RecordId = recordId;
            salesTotalDiscountAgreement.DiscountAmount = discountAmount;
            salesTotalDiscountAgreement.DiscountApplicableFromDate = discountApplicableFromDate;
            salesTotalDiscountAgreement.DiscountPercentage2 = discountPercentage2;
            salesTotalDiscountAgreement.DiscountPercentage1 = discountPercentage1;
            salesTotalDiscountAgreement.DiscountApplicableToDate = discountApplicableToDate;
            salesTotalDiscountAgreement.ToOrderSubtotalAmount = toOrderSubtotalAmount;
            salesTotalDiscountAgreement.FromOrderSubtotalAmount = fromOrderSubtotalAmount;
            return salesTotalDiscountAgreement;
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
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property DiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountAmount is required.")]
        public virtual decimal DiscountAmount
        {
            get
            {
                return this._DiscountAmount;
            }
            set
            {
                this.OnDiscountAmountChanging(value);
                this._DiscountAmount = value;
                this.OnDiscountAmountChanged();
                this.OnPropertyChanged("DiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountAmount;
        partial void OnDiscountAmountChanging(decimal value);
        partial void OnDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property DiscountCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountCurrencyCode")]
        public virtual string DiscountCurrencyCode
        {
            get
            {
                return this._DiscountCurrencyCode;
            }
            set
            {
                this.OnDiscountCurrencyCodeChanging(value);
                this._DiscountCurrencyCode = value;
                this.OnDiscountCurrencyCodeChanged();
                this.OnPropertyChanged("DiscountCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountCurrencyCode;
        partial void OnDiscountCurrencyCodeChanging(string value);
        partial void OnDiscountCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property TotalDiscountCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalDiscountCustomerGroupCode")]
        public virtual string TotalDiscountCustomerGroupCode
        {
            get
            {
                return this._TotalDiscountCustomerGroupCode;
            }
            set
            {
                this.OnTotalDiscountCustomerGroupCodeChanging(value);
                this._TotalDiscountCustomerGroupCode = value;
                this.OnTotalDiscountCustomerGroupCodeChanged();
                this.OnPropertyChanged("TotalDiscountCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TotalDiscountCustomerGroupCode;
        partial void OnTotalDiscountCustomerGroupCodeChanging(string value);
        partial void OnTotalDiscountCustomerGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property DiscountApplicableFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountApplicableFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountApplicableFromDate is required.")]
        public virtual global::System.DateTimeOffset DiscountApplicableFromDate
        {
            get
            {
                return this._DiscountApplicableFromDate;
            }
            set
            {
                this.OnDiscountApplicableFromDateChanging(value);
                this._DiscountApplicableFromDate = value;
                this.OnDiscountApplicableFromDateChanged();
                this.OnPropertyChanged("DiscountApplicableFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DiscountApplicableFromDate;
        partial void OnDiscountApplicableFromDateChanging(global::System.DateTimeOffset value);
        partial void OnDiscountApplicableFromDateChanged();
        /// <summary>
        /// There are no comments for Property DiscountPercentage2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentage2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountPercentage2 is required.")]
        public virtual decimal DiscountPercentage2
        {
            get
            {
                return this._DiscountPercentage2;
            }
            set
            {
                this.OnDiscountPercentage2Changing(value);
                this._DiscountPercentage2 = value;
                this.OnDiscountPercentage2Changed();
                this.OnPropertyChanged("DiscountPercentage2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountPercentage2;
        partial void OnDiscountPercentage2Changing(decimal value);
        partial void OnDiscountPercentage2Changed();
        /// <summary>
        /// There are no comments for Property DiscountPercentage1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentage1")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountPercentage1 is required.")]
        public virtual decimal DiscountPercentage1
        {
            get
            {
                return this._DiscountPercentage1;
            }
            set
            {
                this.OnDiscountPercentage1Changing(value);
                this._DiscountPercentage1 = value;
                this.OnDiscountPercentage1Changed();
                this.OnPropertyChanged("DiscountPercentage1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountPercentage1;
        partial void OnDiscountPercentage1Changing(decimal value);
        partial void OnDiscountPercentage1Changed();
        /// <summary>
        /// There are no comments for Property DiscountApplicableToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountApplicableToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountApplicableToDate is required.")]
        public virtual global::System.DateTimeOffset DiscountApplicableToDate
        {
            get
            {
                return this._DiscountApplicableToDate;
            }
            set
            {
                this.OnDiscountApplicableToDateChanging(value);
                this._DiscountApplicableToDate = value;
                this.OnDiscountApplicableToDateChanged();
                this.OnPropertyChanged("DiscountApplicableToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DiscountApplicableToDate;
        partial void OnDiscountApplicableToDateChanging(global::System.DateTimeOffset value);
        partial void OnDiscountApplicableToDateChanged();
        /// <summary>
        /// There are no comments for Property ToOrderSubtotalAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToOrderSubtotalAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToOrderSubtotalAmount is required.")]
        public virtual decimal ToOrderSubtotalAmount
        {
            get
            {
                return this._ToOrderSubtotalAmount;
            }
            set
            {
                this.OnToOrderSubtotalAmountChanging(value);
                this._ToOrderSubtotalAmount = value;
                this.OnToOrderSubtotalAmountChanged();
                this.OnPropertyChanged("ToOrderSubtotalAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ToOrderSubtotalAmount;
        partial void OnToOrderSubtotalAmountChanging(decimal value);
        partial void OnToOrderSubtotalAmountChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccountNumber")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property WillSearchContinue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillSearchContinue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillSearchContinue
        {
            get
            {
                return this._WillSearchContinue;
            }
            set
            {
                this.OnWillSearchContinueChanging(value);
                this._WillSearchContinue = value;
                this.OnWillSearchContinueChanged();
                this.OnPropertyChanged("WillSearchContinue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillSearchContinue;
        partial void OnWillSearchContinueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillSearchContinueChanged();
        /// <summary>
        /// There are no comments for Property FromOrderSubtotalAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromOrderSubtotalAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromOrderSubtotalAmount is required.")]
        public virtual decimal FromOrderSubtotalAmount
        {
            get
            {
                return this._FromOrderSubtotalAmount;
            }
            set
            {
                this.OnFromOrderSubtotalAmountChanging(value);
                this._FromOrderSubtotalAmount = value;
                this.OnFromOrderSubtotalAmountChanged();
                this.OnPropertyChanged("FromOrderSubtotalAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FromOrderSubtotalAmount;
        partial void OnFromOrderSubtotalAmountChanging(decimal value);
        partial void OnFromOrderSubtotalAmountChanged();
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
