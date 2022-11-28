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
    /// There are no comments for AbsorptionCostJournalNameSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AbsorptionCostJournalNameSingle")]
    public partial class AbsorptionCostJournalNameSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AbsorptionCostJournalName>
    {
        /// <summary>
        /// Initialize a new AbsorptionCostJournalNameSingle object.
        /// </summary>
        public AbsorptionCostJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AbsorptionCostJournalNameSingle object.
        /// </summary>
        public AbsorptionCostJournalNameSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AbsorptionCostJournalNameSingle object.
        /// </summary>
        public AbsorptionCostJournalNameSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AbsorptionCostJournalName> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AbsorptionCostJournalName in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// JournalNameId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalNameId")]
    [global::Microsoft.OData.Client.EntitySet("AbsorptionCostJournalNames")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AbsorptionCostJournalName")]
    public partial class AbsorptionCostJournalName : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AbsorptionCostJournalName object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="journalNameId">Initial value of JournalNameId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AbsorptionCostJournalName CreateAbsorptionCostJournalName(string dataAreaId, string journalNameId)
        {
            AbsorptionCostJournalName absorptionCostJournalName = new AbsorptionCostJournalName();
            absorptionCostJournalName.DataAreaId = dataAreaId;
            absorptionCostJournalName.JournalNameId = journalNameId;
            return absorptionCostJournalName;
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
        /// There are no comments for Property JournalNameId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNameId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalNameId is required.")]
        public virtual string JournalNameId
        {
            get
            {
                return this._JournalNameId;
            }
            set
            {
                this.OnJournalNameIdChanging(value);
                this._JournalNameId = value;
                this.OnJournalNameIdChanged();
                this.OnPropertyChanged("JournalNameId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNameId;
        partial void OnJournalNameIdChanging(string value);
        partial void OnJournalNameIdChanged();
        /// <summary>
        /// There are no comments for Property PrivateForUserGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrivateForUserGroupId")]
        public virtual string PrivateForUserGroupId
        {
            get
            {
                return this._PrivateForUserGroupId;
            }
            set
            {
                this.OnPrivateForUserGroupIdChanging(value);
                this._PrivateForUserGroupId = value;
                this.OnPrivateForUserGroupIdChanged();
                this.OnPropertyChanged("PrivateForUserGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrivateForUserGroupId;
        partial void OnPrivateForUserGroupIdChanging(string value);
        partial void OnPrivateForUserGroupIdChanged();
        /// <summary>
        /// There are no comments for Property JournalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ACOJournalType_BR> JournalType
        {
            get
            {
                return this._JournalType;
            }
            set
            {
                this.OnJournalTypeChanging(value);
                this._JournalType = value;
                this.OnJournalTypeChanged();
                this.OnPropertyChanged("JournalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ACOJournalType_BR> _JournalType;
        partial void OnJournalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ACOJournalType_BR> value);
        partial void OnJournalTypeChanged();
        /// <summary>
        /// There are no comments for Property NumberSequenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberSequenceCode")]
        public virtual string NumberSequenceCode
        {
            get
            {
                return this._NumberSequenceCode;
            }
            set
            {
                this.OnNumberSequenceCodeChanging(value);
                this._NumberSequenceCode = value;
                this.OnNumberSequenceCodeChanged();
                this.OnPropertyChanged("NumberSequenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumberSequenceCode;
        partial void OnNumberSequenceCodeChanging(string value);
        partial void OnNumberSequenceCodeChanged();
        /// <summary>
        /// There are no comments for Property DetailLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DetailLevel")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> DetailLevel
        {
            get
            {
                return this._DetailLevel;
            }
            set
            {
                this.OnDetailLevelChanging(value);
                this._DetailLevel = value;
                this.OnDetailLevelChanged();
                this.OnPropertyChanged("DetailLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _DetailLevel;
        partial void OnDetailLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnDetailLevelChanged();
        /// <summary>
        /// There are no comments for Property SelectionBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SelectionBy")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> SelectionBy
        {
            get
            {
                return this._SelectionBy;
            }
            set
            {
                this.OnSelectionByChanging(value);
                this._SelectionBy = value;
                this.OnSelectionByChanged();
                this.OnPropertyChanged("SelectionBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> _SelectionBy;
        partial void OnSelectionByChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> value);
        partial void OnSelectionByChanged();
        /// <summary>
        /// There are no comments for Property IsDeleteLinesAfterPostingEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDeleteLinesAfterPostingEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDeleteLinesAfterPostingEnabled
        {
            get
            {
                return this._IsDeleteLinesAfterPostingEnabled;
            }
            set
            {
                this.OnIsDeleteLinesAfterPostingEnabledChanging(value);
                this._IsDeleteLinesAfterPostingEnabled = value;
                this.OnIsDeleteLinesAfterPostingEnabledChanged();
                this.OnPropertyChanged("IsDeleteLinesAfterPostingEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDeleteLinesAfterPostingEnabled;
        partial void OnIsDeleteLinesAfterPostingEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDeleteLinesAfterPostingEnabledChanged();
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
        /// There are no comments for Property VoucherChange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VoucherChange")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> VoucherChange
        {
            get
            {
                return this._VoucherChange;
            }
            set
            {
                this.OnVoucherChangeChanging(value);
                this._VoucherChange = value;
                this.OnVoucherChangeChanged();
                this.OnPropertyChanged("VoucherChange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> _VoucherChange;
        partial void OnVoucherChangeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ABC> value);
        partial void OnVoucherChangeChanged();
        /// <summary>
        /// There are no comments for Property CompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyId")]
        public virtual string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                this.OnCompanyIdChanging(value);
                this._CompanyId = value;
                this.OnCompanyIdChanged();
                this.OnPropertyChanged("CompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyId;
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
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
