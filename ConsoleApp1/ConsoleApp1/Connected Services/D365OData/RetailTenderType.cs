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
    /// There are no comments for RetailTenderTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTenderTypeSingle")]
    public partial class RetailTenderTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderType>
    {
        /// <summary>
        /// Initialize a new RetailTenderTypeSingle object.
        /// </summary>
        public RetailTenderTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTenderTypeSingle object.
        /// </summary>
        public RetailTenderTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTenderTypeSingle object.
        /// </summary>
        public RetailTenderTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailTenderType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PaymentMethodNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PaymentMethodNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailTenderTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTenderType")]
    public partial class RetailTenderType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTenderType object.
        /// </summary>
        /// <param name="paymentMethodNumber">Initial value of PaymentMethodNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTenderType CreateRetailTenderType(string paymentMethodNumber)
        {
            RetailTenderType retailTenderType = new RetailTenderType();
            retailTenderType.PaymentMethodNumber = paymentMethodNumber;
            return retailTenderType;
        }
        /// <summary>
        /// There are no comments for Property PaymentMethodNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMethodNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentMethodNumber is required.")]
        public virtual string PaymentMethodNumber
        {
            get
            {
                return this._PaymentMethodNumber;
            }
            set
            {
                this.OnPaymentMethodNumberChanging(value);
                this._PaymentMethodNumber = value;
                this.OnPaymentMethodNumberChanged();
                this.OnPropertyChanged("PaymentMethodNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMethodNumber;
        partial void OnPaymentMethodNumberChanging(string value);
        partial void OnPaymentMethodNumberChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DefaultFunction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultFunction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTenderFunction> DefaultFunction
        {
            get
            {
                return this._DefaultFunction;
            }
            set
            {
                this.OnDefaultFunctionChanging(value);
                this._DefaultFunction = value;
                this.OnDefaultFunctionChanged();
                this.OnPropertyChanged("DefaultFunction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTenderFunction> _DefaultFunction;
        partial void OnDefaultFunctionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTenderFunction> value);
        partial void OnDefaultFunctionChanged();
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
