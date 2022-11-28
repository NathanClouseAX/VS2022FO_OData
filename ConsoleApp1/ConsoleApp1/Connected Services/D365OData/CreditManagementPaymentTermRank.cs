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
    /// There are no comments for CreditManagementPaymentTermRankSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditManagementPaymentTermRankSingle")]
    public partial class CreditManagementPaymentTermRankSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CreditManagementPaymentTermRank>
    {
        /// <summary>
        /// Initialize a new CreditManagementPaymentTermRankSingle object.
        /// </summary>
        public CreditManagementPaymentTermRankSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CreditManagementPaymentTermRankSingle object.
        /// </summary>
        public CreditManagementPaymentTermRankSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CreditManagementPaymentTermRankSingle object.
        /// </summary>
        public CreditManagementPaymentTermRankSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CreditManagementPaymentTermRank> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CreditManagementPaymentTermRank in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PaymentTerms
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PaymentTerms")]
    [global::Microsoft.OData.Client.EntitySet("CreditManagementPaymentTermRanks")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditManagementPaymentTermRank")]
    public partial class CreditManagementPaymentTermRank : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CreditManagementPaymentTermRank object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="paymentTerms">Initial value of PaymentTerms.</param>
        /// <param name="paymentTermsRanking">Initial value of PaymentTermsRanking.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CreditManagementPaymentTermRank CreateCreditManagementPaymentTermRank(string dataAreaId, string paymentTerms, int paymentTermsRanking)
        {
            CreditManagementPaymentTermRank creditManagementPaymentTermRank = new CreditManagementPaymentTermRank();
            creditManagementPaymentTermRank.DataAreaId = dataAreaId;
            creditManagementPaymentTermRank.PaymentTerms = paymentTerms;
            creditManagementPaymentTermRank.PaymentTermsRanking = paymentTermsRanking;
            return creditManagementPaymentTermRank;
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
        /// There are no comments for Property PaymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTerms")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentTerms is required.")]
        public virtual string PaymentTerms
        {
            get
            {
                return this._PaymentTerms;
            }
            set
            {
                this.OnPaymentTermsChanging(value);
                this._PaymentTerms = value;
                this.OnPaymentTermsChanged();
                this.OnPropertyChanged("PaymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentTerms;
        partial void OnPaymentTermsChanging(string value);
        partial void OnPaymentTermsChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermsRanking in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermsRanking")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentTermsRanking is required.")]
        public virtual int PaymentTermsRanking
        {
            get
            {
                return this._PaymentTermsRanking;
            }
            set
            {
                this.OnPaymentTermsRankingChanging(value);
                this._PaymentTermsRanking = value;
                this.OnPaymentTermsRankingChanged();
                this.OnPropertyChanged("PaymentTermsRanking");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PaymentTermsRanking;
        partial void OnPaymentTermsRankingChanging(int value);
        partial void OnPaymentTermsRankingChanged();
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