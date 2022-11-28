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
    /// There are no comments for RetailTenderTypeCardNumberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTenderTypeCardNumberSingle")]
    public partial class RetailTenderTypeCardNumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderTypeCardNumber>
    {
        /// <summary>
        /// Initialize a new RetailTenderTypeCardNumberSingle object.
        /// </summary>
        public RetailTenderTypeCardNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTenderTypeCardNumberSingle object.
        /// </summary>
        public RetailTenderTypeCardNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTenderTypeCardNumberSingle object.
        /// </summary>
        public RetailTenderTypeCardNumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderTypeCardNumber> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTenderTypeCardNumber in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CardTypeId
    /// CardNumberFrom
    /// CardNumberTo
    /// CardNumberLength
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CardTypeId", "CardNumberFrom", "CardNumberTo", "CardNumberLength")]
    [global::Microsoft.OData.Client.EntitySet("RetailTenderTypeCardNumbers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTenderTypeCardNumber")]
    public partial class RetailTenderTypeCardNumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTenderTypeCardNumber object.
        /// </summary>
        /// <param name="cardTypeId">Initial value of CardTypeId.</param>
        /// <param name="cardNumberFrom">Initial value of CardNumberFrom.</param>
        /// <param name="cardNumberTo">Initial value of CardNumberTo.</param>
        /// <param name="cardNumberLength">Initial value of CardNumberLength.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTenderTypeCardNumber CreateRetailTenderTypeCardNumber(string cardTypeId, string cardNumberFrom, string cardNumberTo, int cardNumberLength)
        {
            RetailTenderTypeCardNumber retailTenderTypeCardNumber = new RetailTenderTypeCardNumber();
            retailTenderTypeCardNumber.CardTypeId = cardTypeId;
            retailTenderTypeCardNumber.CardNumberFrom = cardNumberFrom;
            retailTenderTypeCardNumber.CardNumberTo = cardNumberTo;
            retailTenderTypeCardNumber.CardNumberLength = cardNumberLength;
            return retailTenderTypeCardNumber;
        }
        /// <summary>
        /// There are no comments for Property CardTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CardTypeId is required.")]
        public virtual string CardTypeId
        {
            get
            {
                return this._CardTypeId;
            }
            set
            {
                this.OnCardTypeIdChanging(value);
                this._CardTypeId = value;
                this.OnCardTypeIdChanged();
                this.OnPropertyChanged("CardTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardTypeId;
        partial void OnCardTypeIdChanging(string value);
        partial void OnCardTypeIdChanged();
        /// <summary>
        /// There are no comments for Property CardNumberFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardNumberFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CardNumberFrom is required.")]
        public virtual string CardNumberFrom
        {
            get
            {
                return this._CardNumberFrom;
            }
            set
            {
                this.OnCardNumberFromChanging(value);
                this._CardNumberFrom = value;
                this.OnCardNumberFromChanged();
                this.OnPropertyChanged("CardNumberFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardNumberFrom;
        partial void OnCardNumberFromChanging(string value);
        partial void OnCardNumberFromChanged();
        /// <summary>
        /// There are no comments for Property CardNumberTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardNumberTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CardNumberTo is required.")]
        public virtual string CardNumberTo
        {
            get
            {
                return this._CardNumberTo;
            }
            set
            {
                this.OnCardNumberToChanging(value);
                this._CardNumberTo = value;
                this.OnCardNumberToChanged();
                this.OnPropertyChanged("CardNumberTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardNumberTo;
        partial void OnCardNumberToChanging(string value);
        partial void OnCardNumberToChanged();
        /// <summary>
        /// There are no comments for Property CardNumberLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardNumberLength")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CardNumberLength is required.")]
        public virtual int CardNumberLength
        {
            get
            {
                return this._CardNumberLength;
            }
            set
            {
                this.OnCardNumberLengthChanging(value);
                this._CardNumberLength = value;
                this.OnCardNumberLengthChanged();
                this.OnPropertyChanged("CardNumberLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CardNumberLength;
        partial void OnCardNumberLengthChanging(int value);
        partial void OnCardNumberLengthChanged();
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
