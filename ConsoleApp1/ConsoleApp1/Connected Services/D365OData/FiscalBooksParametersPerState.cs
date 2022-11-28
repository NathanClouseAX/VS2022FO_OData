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
    /// There are no comments for FiscalBooksParametersPerStateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalBooksParametersPerStateSingle")]
    public partial class FiscalBooksParametersPerStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalBooksParametersPerState>
    {
        /// <summary>
        /// Initialize a new FiscalBooksParametersPerStateSingle object.
        /// </summary>
        public FiscalBooksParametersPerStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalBooksParametersPerStateSingle object.
        /// </summary>
        public FiscalBooksParametersPerStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalBooksParametersPerStateSingle object.
        /// </summary>
        public FiscalBooksParametersPerStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalBooksParametersPerState> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalBooksParametersPerState in the schema.
    /// </summary>
    /// <KeyProperties>
    /// State
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("State")]
    [global::Microsoft.OData.Client.EntitySet("FiscalBooksParametersPerStates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalBooksParametersPerState")]
    public partial class FiscalBooksParametersPerState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalBooksParametersPerState object.
        /// </summary>
        /// <param name="state">Initial value of State.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalBooksParametersPerState CreateFiscalBooksParametersPerState(string state)
        {
            FiscalBooksParametersPerState fiscalBooksParametersPerState = new FiscalBooksParametersPerState();
            fiscalBooksParametersPerState.State = state;
            return fiscalBooksParametersPerState;
        }
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property GeneralAdjustmentCodeFixedAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralAdjustmentCodeFixedAsset")]
        public virtual string GeneralAdjustmentCodeFixedAsset
        {
            get
            {
                return this._GeneralAdjustmentCodeFixedAsset;
            }
            set
            {
                this.OnGeneralAdjustmentCodeFixedAssetChanging(value);
                this._GeneralAdjustmentCodeFixedAsset = value;
                this.OnGeneralAdjustmentCodeFixedAssetChanged();
                this.OnPropertyChanged("GeneralAdjustmentCodeFixedAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GeneralAdjustmentCodeFixedAsset;
        partial void OnGeneralAdjustmentCodeFixedAssetChanging(string value);
        partial void OnGeneralAdjustmentCodeFixedAssetChanged();
        /// <summary>
        /// There are no comments for Property ByFiscalDocument in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ByFiscalDocument")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ByFiscalDocument
        {
            get
            {
                return this._ByFiscalDocument;
            }
            set
            {
                this.OnByFiscalDocumentChanging(value);
                this._ByFiscalDocument = value;
                this.OnByFiscalDocumentChanged();
                this.OnPropertyChanged("ByFiscalDocument");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ByFiscalDocument;
        partial void OnByFiscalDocumentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnByFiscalDocumentChanged();
        /// <summary>
        /// There are no comments for Property FiscalDocumentAdjustmentCodeFixedAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentAdjustmentCodeFixedAsset")]
        public virtual string FiscalDocumentAdjustmentCodeFixedAsset
        {
            get
            {
                return this._FiscalDocumentAdjustmentCodeFixedAsset;
            }
            set
            {
                this.OnFiscalDocumentAdjustmentCodeFixedAssetChanging(value);
                this._FiscalDocumentAdjustmentCodeFixedAsset = value;
                this.OnFiscalDocumentAdjustmentCodeFixedAssetChanged();
                this.OnPropertyChanged("FiscalDocumentAdjustmentCodeFixedAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalDocumentAdjustmentCodeFixedAsset;
        partial void OnFiscalDocumentAdjustmentCodeFixedAssetChanging(string value);
        partial void OnFiscalDocumentAdjustmentCodeFixedAssetChanged();
        /// <summary>
        /// There are no comments for Property GeneralAdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralAdjustmentCode")]
        public virtual string GeneralAdjustmentCode
        {
            get
            {
                return this._GeneralAdjustmentCode;
            }
            set
            {
                this.OnGeneralAdjustmentCodeChanging(value);
                this._GeneralAdjustmentCode = value;
                this.OnGeneralAdjustmentCodeChanged();
                this.OnPropertyChanged("GeneralAdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GeneralAdjustmentCode;
        partial void OnGeneralAdjustmentCodeChanging(string value);
        partial void OnGeneralAdjustmentCodeChanged();
        /// <summary>
        /// There are no comments for Property ObservationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObservationCode")]
        public virtual string ObservationCode
        {
            get
            {
                return this._ObservationCode;
            }
            set
            {
                this.OnObservationCodeChanging(value);
                this._ObservationCode = value;
                this.OnObservationCodeChanged();
                this.OnPropertyChanged("ObservationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObservationCode;
        partial void OnObservationCodeChanging(string value);
        partial void OnObservationCodeChanged();
        /// <summary>
        /// There are no comments for Property FiscalDocumentAdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentAdjustmentCode")]
        public virtual string FiscalDocumentAdjustmentCode
        {
            get
            {
                return this._FiscalDocumentAdjustmentCode;
            }
            set
            {
                this.OnFiscalDocumentAdjustmentCodeChanging(value);
                this._FiscalDocumentAdjustmentCode = value;
                this.OnFiscalDocumentAdjustmentCodeChanged();
                this.OnPropertyChanged("FiscalDocumentAdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalDocumentAdjustmentCode;
        partial void OnFiscalDocumentAdjustmentCodeChanging(string value);
        partial void OnFiscalDocumentAdjustmentCodeChanged();
        /// <summary>
        /// There are no comments for Property CIAPCalculateInstallmentForOutgoing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CIAPCalculateInstallmentForOutgoing")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CIAPCalculateInstallmentForOutgoing
        {
            get
            {
                return this._CIAPCalculateInstallmentForOutgoing;
            }
            set
            {
                this.OnCIAPCalculateInstallmentForOutgoingChanging(value);
                this._CIAPCalculateInstallmentForOutgoing = value;
                this.OnCIAPCalculateInstallmentForOutgoingChanged();
                this.OnPropertyChanged("CIAPCalculateInstallmentForOutgoing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CIAPCalculateInstallmentForOutgoing;
        partial void OnCIAPCalculateInstallmentForOutgoingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCIAPCalculateInstallmentForOutgoingChanged();
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