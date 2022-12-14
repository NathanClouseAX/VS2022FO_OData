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
    /// There are no comments for ExceptionCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExceptionCodeSingle")]
    public partial class ExceptionCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExceptionCode>
    {
        /// <summary>
        /// Initialize a new ExceptionCodeSingle object.
        /// </summary>
        public ExceptionCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExceptionCodeSingle object.
        /// </summary>
        public ExceptionCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExceptionCodeSingle object.
        /// </summary>
        public ExceptionCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExceptionCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ExceptionCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FiscalClassificationCode
    /// ExceptionCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FiscalClassificationCode", "ExceptionCode")]
    [global::Microsoft.OData.Client.EntitySet("ExceptionCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExceptionCode")]
    public partial class ExceptionCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExceptionCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fiscalClassificationCode">Initial value of FiscalClassificationCode.</param>
        /// <param name="exceptionCode1">Initial value of ExceptionCode1.</param>
        /// <param name="approximateTaxRateForImportedProducts">Initial value of ApproximateTaxRateForImportedProducts.</param>
        /// <param name="approximateTaxRateForNationalProducts">Initial value of ApproximateTaxRateForNationalProducts.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExceptionCode CreateExceptionCode(string dataAreaId, string fiscalClassificationCode, string exceptionCode1, decimal approximateTaxRateForImportedProducts, decimal approximateTaxRateForNationalProducts)
        {
            ExceptionCode exceptionCode = new ExceptionCode();
            exceptionCode.DataAreaId = dataAreaId;
            exceptionCode.FiscalClassificationCode = fiscalClassificationCode;
            exceptionCode.ExceptionCode1 = exceptionCode1;
            exceptionCode.ApproximateTaxRateForImportedProducts = approximateTaxRateForImportedProducts;
            exceptionCode.ApproximateTaxRateForNationalProducts = approximateTaxRateForNationalProducts;
            return exceptionCode;
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
        /// There are no comments for Property FiscalClassificationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalClassificationCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalClassificationCode is required.")]
        public virtual string FiscalClassificationCode
        {
            get
            {
                return this._FiscalClassificationCode;
            }
            set
            {
                this.OnFiscalClassificationCodeChanging(value);
                this._FiscalClassificationCode = value;
                this.OnFiscalClassificationCodeChanged();
                this.OnPropertyChanged("FiscalClassificationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalClassificationCode;
        partial void OnFiscalClassificationCodeChanging(string value);
        partial void OnFiscalClassificationCodeChanged();
        /// <summary>
        /// There are no comments for Property ExceptionCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExceptionCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExceptionCode1 is required.")]
        public virtual string ExceptionCode1
        {
            get
            {
                return this._ExceptionCode1;
            }
            set
            {
                this.OnExceptionCode1Changing(value);
                this._ExceptionCode1 = value;
                this.OnExceptionCode1Changed();
                this.OnPropertyChanged("ExceptionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExceptionCode1;
        partial void OnExceptionCode1Changing(string value);
        partial void OnExceptionCode1Changed();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ApproximateTaxRateForImportedProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproximateTaxRateForImportedProducts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ApproximateTaxRateForImportedProducts is required.")]
        public virtual decimal ApproximateTaxRateForImportedProducts
        {
            get
            {
                return this._ApproximateTaxRateForImportedProducts;
            }
            set
            {
                this.OnApproximateTaxRateForImportedProductsChanging(value);
                this._ApproximateTaxRateForImportedProducts = value;
                this.OnApproximateTaxRateForImportedProductsChanged();
                this.OnPropertyChanged("ApproximateTaxRateForImportedProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ApproximateTaxRateForImportedProducts;
        partial void OnApproximateTaxRateForImportedProductsChanging(decimal value);
        partial void OnApproximateTaxRateForImportedProductsChanged();
        /// <summary>
        /// There are no comments for Property ApproximateTaxRateForNationalProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproximateTaxRateForNationalProducts")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ApproximateTaxRateForNationalProducts is required.")]
        public virtual decimal ApproximateTaxRateForNationalProducts
        {
            get
            {
                return this._ApproximateTaxRateForNationalProducts;
            }
            set
            {
                this.OnApproximateTaxRateForNationalProductsChanging(value);
                this._ApproximateTaxRateForNationalProducts = value;
                this.OnApproximateTaxRateForNationalProductsChanged();
                this.OnPropertyChanged("ApproximateTaxRateForNationalProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ApproximateTaxRateForNationalProducts;
        partial void OnApproximateTaxRateForNationalProductsChanging(decimal value);
        partial void OnApproximateTaxRateForNationalProductsChanged();
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
