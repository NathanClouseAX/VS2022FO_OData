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
    /// There are no comments for PublishedRequestForQuotationDeliveryPaymentTermSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublishedRequestForQuotationDeliveryPaymentTermSingle")]
    public partial class PublishedRequestForQuotationDeliveryPaymentTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationDeliveryPaymentTerm>
    {
        /// <summary>
        /// Initialize a new PublishedRequestForQuotationDeliveryPaymentTermSingle object.
        /// </summary>
        public PublishedRequestForQuotationDeliveryPaymentTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationDeliveryPaymentTermSingle object.
        /// </summary>
        public PublishedRequestForQuotationDeliveryPaymentTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationDeliveryPaymentTermSingle object.
        /// </summary>
        public PublishedRequestForQuotationDeliveryPaymentTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationDeliveryPaymentTerm> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PublishedRequestForQuotationDeliveryPaymentTerm in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RFQCaseNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RFQCaseNumber")]
    [global::Microsoft.OData.Client.EntitySet("PublishedRequestForQuotationDeliveryPaymentTerms")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PublishedRequestForQuotationDeliveryPaymentTerm")]
    public partial class PublishedRequestForQuotationDeliveryPaymentTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PublishedRequestForQuotationDeliveryPaymentTerm object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rFQCaseNumber">Initial value of RFQCaseNumber.</param>
        /// <param name="requestedDeliveryDate">Initial value of RequestedDeliveryDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PublishedRequestForQuotationDeliveryPaymentTerm CreatePublishedRequestForQuotationDeliveryPaymentTerm(string dataAreaId, string rFQCaseNumber, global::System.DateTimeOffset requestedDeliveryDate)
        {
            PublishedRequestForQuotationDeliveryPaymentTerm publishedRequestForQuotationDeliveryPaymentTerm = new PublishedRequestForQuotationDeliveryPaymentTerm();
            publishedRequestForQuotationDeliveryPaymentTerm.DataAreaId = dataAreaId;
            publishedRequestForQuotationDeliveryPaymentTerm.RFQCaseNumber = rFQCaseNumber;
            publishedRequestForQuotationDeliveryPaymentTerm.RequestedDeliveryDate = requestedDeliveryDate;
            return publishedRequestForQuotationDeliveryPaymentTerm;
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
        /// There are no comments for Property RFQCaseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFQCaseNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RFQCaseNumber is required.")]
        public virtual string RFQCaseNumber
        {
            get
            {
                return this._RFQCaseNumber;
            }
            set
            {
                this.OnRFQCaseNumberChanging(value);
                this._RFQCaseNumber = value;
                this.OnRFQCaseNumberChanged();
                this.OnPropertyChanged("RFQCaseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseNumber;
        partial void OnRFQCaseNumberChanging(string value);
        partial void OnRFQCaseNumberChanged();
        /// <summary>
        /// There are no comments for Property RequestedDeliveryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestedDeliveryDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RequestedDeliveryDate is required.")]
        public virtual global::System.DateTimeOffset RequestedDeliveryDate
        {
            get
            {
                return this._RequestedDeliveryDate;
            }
            set
            {
                this.OnRequestedDeliveryDateChanging(value);
                this._RequestedDeliveryDate = value;
                this.OnRequestedDeliveryDateChanged();
                this.OnPropertyChanged("RequestedDeliveryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequestedDeliveryDate;
        partial void OnRequestedDeliveryDateChanging(global::System.DateTimeOffset value);
        partial void OnRequestedDeliveryDateChanged();
        /// <summary>
        /// There are no comments for Property RFQCaseTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RFQCaseTitle")]
        public virtual string RFQCaseTitle
        {
            get
            {
                return this._RFQCaseTitle;
            }
            set
            {
                this.OnRFQCaseTitleChanging(value);
                this._RFQCaseTitle = value;
                this.OnRFQCaseTitleChanged();
                this.OnPropertyChanged("RFQCaseTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseTitle;
        partial void OnRFQCaseTitleChanging(string value);
        partial void OnRFQCaseTitleChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentMethodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentMethodName")]
        public virtual string VendorPaymentMethodName
        {
            get
            {
                return this._VendorPaymentMethodName;
            }
            set
            {
                this.OnVendorPaymentMethodNameChanging(value);
                this._VendorPaymentMethodName = value;
                this.OnVendorPaymentMethodNameChanged();
                this.OnPropertyChanged("VendorPaymentMethodName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorPaymentMethodName;
        partial void OnVendorPaymentMethodNameChanging(string value);
        partial void OnVendorPaymentMethodNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryTermsId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryTermsId")]
        public virtual string DeliveryTermsId
        {
            get
            {
                return this._DeliveryTermsId;
            }
            set
            {
                this.OnDeliveryTermsIdChanging(value);
                this._DeliveryTermsId = value;
                this.OnDeliveryTermsIdChanged();
                this.OnPropertyChanged("DeliveryTermsId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryTermsId;
        partial void OnDeliveryTermsIdChanging(string value);
        partial void OnDeliveryTermsIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryModeId")]
        public virtual string DeliveryModeId
        {
            get
            {
                return this._DeliveryModeId;
            }
            set
            {
                this.OnDeliveryModeIdChanging(value);
                this._DeliveryModeId = value;
                this.OnDeliveryModeIdChanged();
                this.OnPropertyChanged("DeliveryModeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryModeId;
        partial void OnDeliveryModeIdChanging(string value);
        partial void OnDeliveryModeIdChanged();
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
