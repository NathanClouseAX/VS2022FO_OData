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
    /// There are no comments for AdvancedRuleStructureActivationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdvancedRuleStructureActivationSingle")]
    public partial class AdvancedRuleStructureActivationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdvancedRuleStructureActivation>
    {
        /// <summary>
        /// Initialize a new AdvancedRuleStructureActivationSingle object.
        /// </summary>
        public AdvancedRuleStructureActivationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdvancedRuleStructureActivationSingle object.
        /// </summary>
        public AdvancedRuleStructureActivationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdvancedRuleStructureActivationSingle object.
        /// </summary>
        public AdvancedRuleStructureActivationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdvancedRuleStructureActivation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructureSingle LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity == null))
                {
                    this._LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity = new global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructureSingle(this.Context, GetPath("LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity"));
                }
                return this._LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructureSingle _LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity;
    }
    /// <summary>
    /// There are no comments for AdvancedRuleStructureActivation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AdvancedRuleStructure
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AdvancedRuleStructure")]
    [global::Microsoft.OData.Client.EntitySet("AdvancedRuleStructureActivations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdvancedRuleStructureActivation")]
    public partial class AdvancedRuleStructureActivation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdvancedRuleStructureActivation object.
        /// </summary>
        /// <param name="advancedRuleStructure">Initial value of AdvancedRuleStructure.</param>
        /// <param name="ledgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity">Initial value of LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdvancedRuleStructureActivation CreateAdvancedRuleStructureActivation(string advancedRuleStructure, global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructure ledgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity)
        {
            AdvancedRuleStructureActivation advancedRuleStructureActivation = new AdvancedRuleStructureActivation();
            advancedRuleStructureActivation.AdvancedRuleStructure = advancedRuleStructure;
            if ((ledgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity == null))
            {
                throw new global::System.ArgumentNullException("ledgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity");
            }
            advancedRuleStructureActivation.LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity = ledgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity;
            return advancedRuleStructureActivation;
        }
        /// <summary>
        /// There are no comments for Property AdvancedRuleStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdvancedRuleStructure")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdvancedRuleStructure is required.")]
        public virtual string AdvancedRuleStructure
        {
            get
            {
                return this._AdvancedRuleStructure;
            }
            set
            {
                this.OnAdvancedRuleStructureChanging(value);
                this._AdvancedRuleStructure = value;
                this.OnAdvancedRuleStructureChanged();
                this.OnPropertyChanged("AdvancedRuleStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvancedRuleStructure;
        partial void OnAdvancedRuleStructureChanging(string value);
        partial void OnAdvancedRuleStructureChanged();
        /// <summary>
        /// There are no comments for Property DoActivate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoActivate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoActivate
        {
            get
            {
                return this._DoActivate;
            }
            set
            {
                this.OnDoActivateChanging(value);
                this._DoActivate = value;
                this.OnDoActivateChanged();
                this.OnPropertyChanged("DoActivate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoActivate;
        partial void OnDoActivateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoActivateChanged();
        /// <summary>
        /// There are no comments for Property LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructure LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity
        {
            get
            {
                return this._LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity;
            }
            set
            {
                this.OnLedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntityChanging(value);
                this._LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity = value;
                this.OnLedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntityChanged();
                this.OnPropertyChanged("LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructure _LedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntity;
        partial void OnLedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntityChanging(global::Microsoft.Dynamics.DataEntities.LedgerAdvancedRuleStructure value);
        partial void OnLedgerAdvancedRuleStructureActivationEntity_RelatedRole_LedgerAdvancedRuleStructureEntityChanged();
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
