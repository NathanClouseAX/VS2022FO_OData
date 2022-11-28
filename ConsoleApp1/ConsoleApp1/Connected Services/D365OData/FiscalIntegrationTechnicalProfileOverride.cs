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
    /// There are no comments for FiscalIntegrationTechnicalProfileOverrideSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalIntegrationTechnicalProfileOverrideSingle")]
    public partial class FiscalIntegrationTechnicalProfileOverrideSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalIntegrationTechnicalProfileOverride>
    {
        /// <summary>
        /// Initialize a new FiscalIntegrationTechnicalProfileOverrideSingle object.
        /// </summary>
        public FiscalIntegrationTechnicalProfileOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalIntegrationTechnicalProfileOverrideSingle object.
        /// </summary>
        public FiscalIntegrationTechnicalProfileOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalIntegrationTechnicalProfileOverrideSingle object.
        /// </summary>
        public FiscalIntegrationTechnicalProfileOverrideSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalIntegrationTechnicalProfileOverride> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalIntegrationTechnicalProfileOverride in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TechnicalProfileId
    /// StoreId
    /// TerminalId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TechnicalProfileId", "StoreId", "TerminalId")]
    [global::Microsoft.OData.Client.EntitySet("FiscalIntegrationTechnicalProfileOverrides")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalIntegrationTechnicalProfileOverride")]
    public partial class FiscalIntegrationTechnicalProfileOverride : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalIntegrationTechnicalProfileOverride object.
        /// </summary>
        /// <param name="technicalProfileId">Initial value of TechnicalProfileId.</param>
        /// <param name="storeId">Initial value of StoreId.</param>
        /// <param name="terminalId">Initial value of TerminalId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalIntegrationTechnicalProfileOverride CreateFiscalIntegrationTechnicalProfileOverride(string technicalProfileId, string storeId, string terminalId)
        {
            FiscalIntegrationTechnicalProfileOverride fiscalIntegrationTechnicalProfileOverride = new FiscalIntegrationTechnicalProfileOverride();
            fiscalIntegrationTechnicalProfileOverride.TechnicalProfileId = technicalProfileId;
            fiscalIntegrationTechnicalProfileOverride.StoreId = storeId;
            fiscalIntegrationTechnicalProfileOverride.TerminalId = terminalId;
            return fiscalIntegrationTechnicalProfileOverride;
        }
        /// <summary>
        /// There are no comments for Property TechnicalProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalProfileId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TechnicalProfileId is required.")]
        public virtual string TechnicalProfileId
        {
            get
            {
                return this._TechnicalProfileId;
            }
            set
            {
                this.OnTechnicalProfileIdChanging(value);
                this._TechnicalProfileId = value;
                this.OnTechnicalProfileIdChanged();
                this.OnPropertyChanged("TechnicalProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalProfileId;
        partial void OnTechnicalProfileIdChanging(string value);
        partial void OnTechnicalProfileIdChanged();
        /// <summary>
        /// There are no comments for Property StoreId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StoreId is required.")]
        public virtual string StoreId
        {
            get
            {
                return this._StoreId;
            }
            set
            {
                this.OnStoreIdChanging(value);
                this._StoreId = value;
                this.OnStoreIdChanged();
                this.OnPropertyChanged("StoreId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreId;
        partial void OnStoreIdChanging(string value);
        partial void OnStoreIdChanged();
        /// <summary>
        /// There are no comments for Property TerminalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TerminalId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TerminalId is required.")]
        public virtual string TerminalId
        {
            get
            {
                return this._TerminalId;
            }
            set
            {
                this.OnTerminalIdChanging(value);
                this._TerminalId = value;
                this.OnTerminalIdChanged();
                this.OnPropertyChanged("TerminalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TerminalId;
        partial void OnTerminalIdChanging(string value);
        partial void OnTerminalIdChanged();
        /// <summary>
        /// There are no comments for Property TechnicalProfileProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TechnicalProfileProperties")]
        public virtual string TechnicalProfileProperties
        {
            get
            {
                return this._TechnicalProfileProperties;
            }
            set
            {
                this.OnTechnicalProfilePropertiesChanging(value);
                this._TechnicalProfileProperties = value;
                this.OnTechnicalProfilePropertiesChanged();
                this.OnPropertyChanged("TechnicalProfileProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TechnicalProfileProperties;
        partial void OnTechnicalProfilePropertiesChanging(string value);
        partial void OnTechnicalProfilePropertiesChanged();
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
