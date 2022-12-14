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
    /// There are no comments for CurrencyISOCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyISOCodeSingle")]
    public partial class CurrencyISOCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyISOCode>
    {
        /// <summary>
        /// Initialize a new CurrencyISOCodeSingle object.
        /// </summary>
        public CurrencyISOCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CurrencyISOCodeSingle object.
        /// </summary>
        public CurrencyISOCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CurrencyISOCodeSingle object.
        /// </summary>
        public CurrencyISOCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CurrencyISOCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CurrencyISOCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ISOCurrencyCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ISOCurrencyCode")]
    [global::Microsoft.OData.Client.EntitySet("CurrencyISOCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyISOCode")]
    public partial class CurrencyISOCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CurrencyISOCode object.
        /// </summary>
        /// <param name="iSOCurrencyCode">Initial value of ISOCurrencyCode.</param>
        /// <param name="iSOCurrencyCodeNum">Initial value of ISOCurrencyCodeNum.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CurrencyISOCode CreateCurrencyISOCode(string iSOCurrencyCode, int iSOCurrencyCodeNum)
        {
            CurrencyISOCode currencyISOCode = new CurrencyISOCode();
            currencyISOCode.ISOCurrencyCode = iSOCurrencyCode;
            currencyISOCode.ISOCurrencyCodeNum = iSOCurrencyCodeNum;
            return currencyISOCode;
        }
        /// <summary>
        /// There are no comments for Property ISOCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ISOCurrencyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ISOCurrencyCode is required.")]
        public virtual string ISOCurrencyCode
        {
            get
            {
                return this._ISOCurrencyCode;
            }
            set
            {
                this.OnISOCurrencyCodeChanging(value);
                this._ISOCurrencyCode = value;
                this.OnISOCurrencyCodeChanged();
                this.OnPropertyChanged("ISOCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ISOCurrencyCode;
        partial void OnISOCurrencyCodeChanging(string value);
        partial void OnISOCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property ISOCurrencyCodeNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ISOCurrencyCodeNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ISOCurrencyCodeNum is required.")]
        public virtual int ISOCurrencyCodeNum
        {
            get
            {
                return this._ISOCurrencyCodeNum;
            }
            set
            {
                this.OnISOCurrencyCodeNumChanging(value);
                this._ISOCurrencyCodeNum = value;
                this.OnISOCurrencyCodeNumChanged();
                this.OnPropertyChanged("ISOCurrencyCodeNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ISOCurrencyCodeNum;
        partial void OnISOCurrencyCodeNumChanging(int value);
        partial void OnISOCurrencyCodeNumChanged();
        /// <summary>
        /// There are no comments for Property ISOCurrencyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ISOCurrencyName")]
        public virtual string ISOCurrencyName
        {
            get
            {
                return this._ISOCurrencyName;
            }
            set
            {
                this.OnISOCurrencyNameChanging(value);
                this._ISOCurrencyName = value;
                this.OnISOCurrencyNameChanged();
                this.OnPropertyChanged("ISOCurrencyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ISOCurrencyName;
        partial void OnISOCurrencyNameChanging(string value);
        partial void OnISOCurrencyNameChanged();
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
