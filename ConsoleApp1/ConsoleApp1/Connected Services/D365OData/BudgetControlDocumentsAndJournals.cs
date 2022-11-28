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
    /// There are no comments for BudgetControlDocumentsAndJournalsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlDocumentsAndJournalsSingle")]
    public partial class BudgetControlDocumentsAndJournalsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlDocumentsAndJournals>
    {
        /// <summary>
        /// Initialize a new BudgetControlDocumentsAndJournalsSingle object.
        /// </summary>
        public BudgetControlDocumentsAndJournalsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlDocumentsAndJournalsSingle object.
        /// </summary>
        public BudgetControlDocumentsAndJournalsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlDocumentsAndJournalsSingle object.
        /// </summary>
        public BudgetControlDocumentsAndJournalsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlDocumentsAndJournals> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlConfigurations")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle BudgetControlConfigurations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlConfigurations == null))
                {
                    this._BudgetControlConfigurations = new global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle(this.Context, GetPath("BudgetControlConfigurations"));
                }
                return this._BudgetControlConfigurations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle _BudgetControlConfigurations;
    }
    /// <summary>
    /// There are no comments for BudgetControlDocumentsAndJournals in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LegalEntityId
    /// Status
    /// DocumentOrJournal
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "DocumentOrJournal")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlDocumentsAndJournals")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlDocumentsAndJournals")]
    public partial class BudgetControlDocumentsAndJournals : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlDocumentsAndJournals object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="budgetControlConfigurations">Initial value of BudgetControlConfigurations.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlDocumentsAndJournals CreateBudgetControlDocumentsAndJournals(string dataAreaId, string legalEntityId, global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration budgetControlConfigurations)
        {
            BudgetControlDocumentsAndJournals budgetControlDocumentsAndJournals = new BudgetControlDocumentsAndJournals();
            budgetControlDocumentsAndJournals.DataAreaId = dataAreaId;
            budgetControlDocumentsAndJournals.LegalEntityId = legalEntityId;
            if ((budgetControlConfigurations == null))
            {
                throw new global::System.ArgumentNullException("budgetControlConfigurations");
            }
            budgetControlDocumentsAndJournals.BudgetControlConfigurations = budgetControlConfigurations;
            return budgetControlDocumentsAndJournals;
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityId is required.")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DocumentOrJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentOrJournal")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlSourceIntegrator> DocumentOrJournal
        {
            get
            {
                return this._DocumentOrJournal;
            }
            set
            {
                this.OnDocumentOrJournalChanging(value);
                this._DocumentOrJournal = value;
                this.OnDocumentOrJournalChanged();
                this.OnPropertyChanged("DocumentOrJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlSourceIntegrator> _DocumentOrJournal;
        partial void OnDocumentOrJournalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlSourceIntegrator> value);
        partial void OnDocumentOrJournalChanged();
        /// <summary>
        /// There are no comments for Property DoBudgetCheckOnEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoBudgetCheckOnEntry")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoBudgetCheckOnEntry
        {
            get
            {
                return this._DoBudgetCheckOnEntry;
            }
            set
            {
                this.OnDoBudgetCheckOnEntryChanging(value);
                this._DoBudgetCheckOnEntry = value;
                this.OnDoBudgetCheckOnEntryChanged();
                this.OnPropertyChanged("DoBudgetCheckOnEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoBudgetCheckOnEntry;
        partial void OnDoBudgetCheckOnEntryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoBudgetCheckOnEntryChanged();
        /// <summary>
        /// There are no comments for Property IsEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsEnabled
        {
            get
            {
                return this._IsEnabled;
            }
            set
            {
                this.OnIsEnabledChanging(value);
                this._IsEnabled = value;
                this.OnIsEnabledChanged();
                this.OnPropertyChanged("IsEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsEnabled;
        partial void OnIsEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsEnabledChanged();
        /// <summary>
        /// There are no comments for Property InUseBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InUseBy")]
        public virtual string InUseBy
        {
            get
            {
                return this._InUseBy;
            }
            set
            {
                this.OnInUseByChanging(value);
                this._InUseBy = value;
                this.OnInUseByChanged();
                this.OnPropertyChanged("InUseBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InUseBy;
        partial void OnInUseByChanging(string value);
        partial void OnInUseByChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetControlConfigurations")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetControlConfigurations is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration BudgetControlConfigurations
        {
            get
            {
                return this._BudgetControlConfigurations;
            }
            set
            {
                this.OnBudgetControlConfigurationsChanging(value);
                this._BudgetControlConfigurations = value;
                this.OnBudgetControlConfigurationsChanged();
                this.OnPropertyChanged("BudgetControlConfigurations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration _BudgetControlConfigurations;
        partial void OnBudgetControlConfigurationsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration value);
        partial void OnBudgetControlConfigurationsChanged();
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