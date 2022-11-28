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
    /// There are no comments for ContribCreditTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ContribCreditTypeSingle")]
    public partial class ContribCreditTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ContribCreditType>
    {
        /// <summary>
        /// Initialize a new ContribCreditTypeSingle object.
        /// </summary>
        public ContribCreditTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ContribCreditTypeSingle object.
        /// </summary>
        public ContribCreditTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ContribCreditTypeSingle object.
        /// </summary>
        public ContribCreditTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ContribCreditType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ContribCreditType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CreditType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CreditType")]
    [global::Microsoft.OData.Client.EntitySet("ContribCreditTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ContribCreditType")]
    public partial class ContribCreditType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ContribCreditType object.
        /// </summary>
        /// <param name="creditType">Initial value of CreditType.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ContribCreditType CreateContribCreditType(string creditType, global::System.DateTimeOffset validToDate, global::System.DateTimeOffset validFromDate)
        {
            ContribCreditType contribCreditType = new ContribCreditType();
            contribCreditType.CreditType = creditType;
            contribCreditType.ValidToDate = validToDate;
            contribCreditType.ValidFromDate = validFromDate;
            return contribCreditType;
        }
        /// <summary>
        /// There are no comments for Property CreditType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CreditType is required.")]
        public virtual string CreditType
        {
            get
            {
                return this._CreditType;
            }
            set
            {
                this.OnCreditTypeChanging(value);
                this._CreditType = value;
                this.OnCreditTypeChanged();
                this.OnPropertyChanged("CreditType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditType;
        partial void OnCreditTypeChanging(string value);
        partial void OnCreditTypeChanged();
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
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidToDate is required.")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFromDate is required.")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
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
