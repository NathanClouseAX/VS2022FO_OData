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
    /// There are no comments for ReturnPackageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReturnPackageSingle")]
    public partial class ReturnPackageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReturnPackage>
    {
        /// <summary>
        /// Initialize a new ReturnPackageSingle object.
        /// </summary>
        public ReturnPackageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReturnPackageSingle object.
        /// </summary>
        public ReturnPackageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReturnPackageSingle object.
        /// </summary>
        public ReturnPackageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReturnPackage> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ReturnPackage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PackagingCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PackagingCode")]
    [global::Microsoft.OData.Client.EntitySet("ReturnPackages")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReturnPackage")]
    public partial class ReturnPackage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReturnPackage object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="packagingCode">Initial value of PackagingCode.</param>
        /// <param name="deposit">Initial value of Deposit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReturnPackage CreateReturnPackage(string dataAreaId, string packagingCode, decimal deposit)
        {
            ReturnPackage returnPackage = new ReturnPackage();
            returnPackage.DataAreaId = dataAreaId;
            returnPackage.PackagingCode = packagingCode;
            returnPackage.Deposit = deposit;
            return returnPackage;
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
        /// There are no comments for Property PackagingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackagingCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PackagingCode is required.")]
        public virtual string PackagingCode
        {
            get
            {
                return this._PackagingCode;
            }
            set
            {
                this.OnPackagingCodeChanging(value);
                this._PackagingCode = value;
                this.OnPackagingCodeChanged();
                this.OnPropertyChanged("PackagingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackagingCode;
        partial void OnPackagingCodeChanging(string value);
        partial void OnPackagingCodeChanged();
        /// <summary>
        /// There are no comments for Property Deposit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Deposit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Deposit is required.")]
        public virtual decimal Deposit
        {
            get
            {
                return this._Deposit;
            }
            set
            {
                this.OnDepositChanging(value);
                this._Deposit = value;
                this.OnDepositChanged();
                this.OnPropertyChanged("Deposit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Deposit;
        partial void OnDepositChanging(decimal value);
        partial void OnDepositChanged();
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