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
    /// There are no comments for TaxAllowedExemptCodesForIPIEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAllowedExemptCodesForIPIEntitySingle")]
    public partial class TaxAllowedExemptCodesForIPIEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxAllowedExemptCodesForIPIEntity>
    {
        /// <summary>
        /// Initialize a new TaxAllowedExemptCodesForIPIEntitySingle object.
        /// </summary>
        public TaxAllowedExemptCodesForIPIEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxAllowedExemptCodesForIPIEntitySingle object.
        /// </summary>
        public TaxAllowedExemptCodesForIPIEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxAllowedExemptCodesForIPIEntitySingle object.
        /// </summary>
        public TaxAllowedExemptCodesForIPIEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxAllowedExemptCodesForIPIEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxAllowedExemptCodesForIPIEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ExemptCode
    /// TaxationCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ExemptCode", "TaxationCode")]
    [global::Microsoft.OData.Client.EntitySet("TaxAllowedExemptCodesForIPIEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAllowedExemptCodesForIPIEntity")]
    public partial class TaxAllowedExemptCodesForIPIEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxAllowedExemptCodesForIPIEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="exemptCode">Initial value of ExemptCode.</param>
        /// <param name="taxationCode">Initial value of TaxationCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxAllowedExemptCodesForIPIEntity CreateTaxAllowedExemptCodesForIPIEntity(string dataAreaId, string exemptCode, string taxationCode)
        {
            TaxAllowedExemptCodesForIPIEntity taxAllowedExemptCodesForIPIEntity = new TaxAllowedExemptCodesForIPIEntity();
            taxAllowedExemptCodesForIPIEntity.DataAreaId = dataAreaId;
            taxAllowedExemptCodesForIPIEntity.ExemptCode = exemptCode;
            taxAllowedExemptCodesForIPIEntity.TaxationCode = taxationCode;
            return taxAllowedExemptCodesForIPIEntity;
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
        /// There are no comments for Property ExemptCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExemptCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExemptCode is required.")]
        public virtual string ExemptCode
        {
            get
            {
                return this._ExemptCode;
            }
            set
            {
                this.OnExemptCodeChanging(value);
                this._ExemptCode = value;
                this.OnExemptCodeChanged();
                this.OnPropertyChanged("ExemptCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExemptCode;
        partial void OnExemptCodeChanging(string value);
        partial void OnExemptCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxationCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxationCode is required.")]
        public virtual string TaxationCode
        {
            get
            {
                return this._TaxationCode;
            }
            set
            {
                this.OnTaxationCodeChanging(value);
                this._TaxationCode = value;
                this.OnTaxationCodeChanged();
                this.OnPropertyChanged("TaxationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxationCode;
        partial void OnTaxationCodeChanging(string value);
        partial void OnTaxationCodeChanged();
        /// <summary>
        /// There are no comments for Property FiscalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalValue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxFiscalValue_BR> FiscalValue
        {
            get
            {
                return this._FiscalValue;
            }
            set
            {
                this.OnFiscalValueChanging(value);
                this._FiscalValue = value;
                this.OnFiscalValueChanged();
                this.OnPropertyChanged("FiscalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxFiscalValue_BR> _FiscalValue;
        partial void OnFiscalValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxFiscalValue_BR> value);
        partial void OnFiscalValueChanged();
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
