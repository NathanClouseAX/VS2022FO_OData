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
    /// There are no comments for GUPFundDiscountSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GUPFundDiscountSingle")]
    public partial class GUPFundDiscountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<GUPFundDiscount>
    {
        /// <summary>
        /// Initialize a new GUPFundDiscountSingle object.
        /// </summary>
        public GUPFundDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GUPFundDiscountSingle object.
        /// </summary>
        public GUPFundDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GUPFundDiscountSingle object.
        /// </summary>
        public GUPFundDiscountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<GUPFundDiscount> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for GUPFundDiscount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FundID
    /// OfferId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FundID", "OfferId")]
    [global::Microsoft.OData.Client.EntitySet("GUPFundDiscounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("GUPFundDiscount")]
    public partial class GUPFundDiscount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new GUPFundDiscount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fundID">Initial value of FundID.</param>
        /// <param name="offerId">Initial value of OfferId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static GUPFundDiscount CreateGUPFundDiscount(string dataAreaId, string fundID, string offerId)
        {
            GUPFundDiscount gUPFundDiscount = new GUPFundDiscount();
            gUPFundDiscount.DataAreaId = dataAreaId;
            gUPFundDiscount.FundID = fundID;
            gUPFundDiscount.OfferId = offerId;
            return gUPFundDiscount;
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
        /// There are no comments for Property FundID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FundID is required.")]
        public virtual string FundID
        {
            get
            {
                return this._FundID;
            }
            set
            {
                this.OnFundIDChanging(value);
                this._FundID = value;
                this.OnFundIDChanged();
                this.OnPropertyChanged("FundID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FundID;
        partial void OnFundIDChanging(string value);
        partial void OnFundIDChanged();
        /// <summary>
        /// There are no comments for Property OfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OfferId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OfferId is required.")]
        public virtual string OfferId
        {
            get
            {
                return this._OfferId;
            }
            set
            {
                this.OnOfferIdChanging(value);
                this._OfferId = value;
                this.OnOfferIdChanged();
                this.OnPropertyChanged("OfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfferId;
        partial void OnOfferIdChanging(string value);
        partial void OnOfferIdChanged();
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
