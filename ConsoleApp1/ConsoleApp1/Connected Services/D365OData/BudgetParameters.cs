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
    /// There are no comments for BudgetParametersSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetParametersSingle")]
    public partial class BudgetParametersSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetParameters>
    {
        /// <summary>
        /// Initialize a new BudgetParametersSingle object.
        /// </summary>
        public BudgetParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetParametersSingle object.
        /// </summary>
        public BudgetParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetParametersSingle object.
        /// </summary>
        public BudgetParametersSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetParameters> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PeriodAllocationCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodAllocationCategory")]
        public virtual global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategorySingle PeriodAllocationCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PeriodAllocationCategory == null))
                {
                    this._PeriodAllocationCategory = new global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategorySingle(this.Context, GetPath("PeriodAllocationCategory"));
                }
                return this._PeriodAllocationCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategorySingle _PeriodAllocationCategory;
        /// <summary>
        /// There are no comments for BudgetParametersJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetParametersJournalName")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalNameSingle BudgetParametersJournalName
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetParametersJournalName == null))
                {
                    this._BudgetParametersJournalName = new global::Microsoft.Dynamics.DataEntities.JournalNameSingle(this.Context, GetPath("BudgetParametersJournalName"));
                }
                return this._BudgetParametersJournalName;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalNameSingle _BudgetParametersJournalName;
    }
    /// <summary>
    /// There are no comments for BudgetParameters in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetParameters")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetParameters")]
    public partial class BudgetParameters : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetParameters object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetParameters CreateBudgetParameters(string dataAreaId)
        {
            BudgetParameters budgetParameters = new BudgetParameters();
            budgetParameters.DataAreaId = dataAreaId;
            return budgetParameters;
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
        /// There are no comments for Property UseRulesForBudgetTransfers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseRulesForBudgetTransfers")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseRulesForBudgetTransfers
        {
            get
            {
                return this._UseRulesForBudgetTransfers;
            }
            set
            {
                this.OnUseRulesForBudgetTransfersChanging(value);
                this._UseRulesForBudgetTransfers = value;
                this.OnUseRulesForBudgetTransfersChanged();
                this.OnPropertyChanged("UseRulesForBudgetTransfers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseRulesForBudgetTransfers;
        partial void OnUseRulesForBudgetTransfersChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseRulesForBudgetTransfersChanged();
        /// <summary>
        /// There are no comments for Property DoCompleteRegisterEntriesOnTransferFromFixedAssets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoCompleteRegisterEntriesOnTransferFromFixedAssets")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoCompleteRegisterEntriesOnTransferFromFixedAssets
        {
            get
            {
                return this._DoCompleteRegisterEntriesOnTransferFromFixedAssets;
            }
            set
            {
                this.OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsChanging(value);
                this._DoCompleteRegisterEntriesOnTransferFromFixedAssets = value;
                this.OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsChanged();
                this.OnPropertyChanged("DoCompleteRegisterEntriesOnTransferFromFixedAssets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoCompleteRegisterEntriesOnTransferFromFixedAssets;
        partial void OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsChanged();
        /// <summary>
        /// There are no comments for Property TimePeriodForBudgetBalances in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimePeriodForBudgetBalances")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceInterval> TimePeriodForBudgetBalances
        {
            get
            {
                return this._TimePeriodForBudgetBalances;
            }
            set
            {
                this.OnTimePeriodForBudgetBalancesChanging(value);
                this._TimePeriodForBudgetBalances = value;
                this.OnTimePeriodForBudgetBalancesChanged();
                this.OnPropertyChanged("TimePeriodForBudgetBalances");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceInterval> _TimePeriodForBudgetBalances;
        partial void OnTimePeriodForBudgetBalancesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceInterval> value);
        partial void OnTimePeriodForBudgetBalancesChanged();
        /// <summary>
        /// There are no comments for Property DoCompleteRegisterEntriesOnTransferFromProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoCompleteRegisterEntriesOnTransferFromProject")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoCompleteRegisterEntriesOnTransferFromProject
        {
            get
            {
                return this._DoCompleteRegisterEntriesOnTransferFromProject;
            }
            set
            {
                this.OnDoCompleteRegisterEntriesOnTransferFromProjectChanging(value);
                this._DoCompleteRegisterEntriesOnTransferFromProject = value;
                this.OnDoCompleteRegisterEntriesOnTransferFromProjectChanged();
                this.OnPropertyChanged("DoCompleteRegisterEntriesOnTransferFromProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoCompleteRegisterEntriesOnTransferFromProject;
        partial void OnDoCompleteRegisterEntriesOnTransferFromProjectChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoCompleteRegisterEntriesOnTransferFromProjectChanged();
        /// <summary>
        /// There are no comments for Property DoCompleteRegisterEntriesOnTransferFromSupplyForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoCompleteRegisterEntriesOnTransferFromSupplyForecast")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoCompleteRegisterEntriesOnTransferFromSupplyForecast
        {
            get
            {
                return this._DoCompleteRegisterEntriesOnTransferFromSupplyForecast;
            }
            set
            {
                this.OnDoCompleteRegisterEntriesOnTransferFromSupplyForecastChanging(value);
                this._DoCompleteRegisterEntriesOnTransferFromSupplyForecast = value;
                this.OnDoCompleteRegisterEntriesOnTransferFromSupplyForecastChanged();
                this.OnPropertyChanged("DoCompleteRegisterEntriesOnTransferFromSupplyForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoCompleteRegisterEntriesOnTransferFromSupplyForecast;
        partial void OnDoCompleteRegisterEntriesOnTransferFromSupplyForecastChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoCompleteRegisterEntriesOnTransferFromSupplyForecastChanged();
        /// <summary>
        /// There are no comments for Property UseFrenchPublicSectorAccountingRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseFrenchPublicSectorAccountingRules")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseFrenchPublicSectorAccountingRules
        {
            get
            {
                return this._UseFrenchPublicSectorAccountingRules;
            }
            set
            {
                this.OnUseFrenchPublicSectorAccountingRulesChanging(value);
                this._UseFrenchPublicSectorAccountingRules = value;
                this.OnUseFrenchPublicSectorAccountingRulesChanged();
                this.OnPropertyChanged("UseFrenchPublicSectorAccountingRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseFrenchPublicSectorAccountingRules;
        partial void OnUseFrenchPublicSectorAccountingRulesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseFrenchPublicSectorAccountingRulesChanged();
        /// <summary>
        /// There are no comments for Property AllocationKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationKey")]
        public virtual string AllocationKey
        {
            get
            {
                return this._AllocationKey;
            }
            set
            {
                this.OnAllocationKeyChanging(value);
                this._AllocationKey = value;
                this.OnAllocationKeyChanged();
                this.OnPropertyChanged("AllocationKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllocationKey;
        partial void OnAllocationKeyChanging(string value);
        partial void OnAllocationKeyChanged();
        /// <summary>
        /// There are no comments for Property DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU
        {
            get
            {
                return this._DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU;
            }
            set
            {
                this.OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsRUChanging(value);
                this._DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU = value;
                this.OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsRUChanged();
                this.OnPropertyChanged("DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoCompleteRegisterEntriesOnTransferFromFixedAssetsRU;
        partial void OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsRUChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoCompleteRegisterEntriesOnTransferFromFixedAssetsRUChanged();
        /// <summary>
        /// There are no comments for Property DoCompleteRegisterEntriesOnTransferFromDemandForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DoCompleteRegisterEntriesOnTransferFromDemandForecast")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DoCompleteRegisterEntriesOnTransferFromDemandForecast
        {
            get
            {
                return this._DoCompleteRegisterEntriesOnTransferFromDemandForecast;
            }
            set
            {
                this.OnDoCompleteRegisterEntriesOnTransferFromDemandForecastChanging(value);
                this._DoCompleteRegisterEntriesOnTransferFromDemandForecast = value;
                this.OnDoCompleteRegisterEntriesOnTransferFromDemandForecastChanged();
                this.OnPropertyChanged("DoCompleteRegisterEntriesOnTransferFromDemandForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DoCompleteRegisterEntriesOnTransferFromDemandForecast;
        partial void OnDoCompleteRegisterEntriesOnTransferFromDemandForecastChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDoCompleteRegisterEntriesOnTransferFromDemandForecastChanged();
        /// <summary>
        /// There are no comments for Property UseGeneralBudgetReservationPublicSectorAccountingRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseGeneralBudgetReservationPublicSectorAccountingRules")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseGeneralBudgetReservationPublicSectorAccountingRules
        {
            get
            {
                return this._UseGeneralBudgetReservationPublicSectorAccountingRules;
            }
            set
            {
                this.OnUseGeneralBudgetReservationPublicSectorAccountingRulesChanging(value);
                this._UseGeneralBudgetReservationPublicSectorAccountingRules = value;
                this.OnUseGeneralBudgetReservationPublicSectorAccountingRulesChanged();
                this.OnPropertyChanged("UseGeneralBudgetReservationPublicSectorAccountingRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseGeneralBudgetReservationPublicSectorAccountingRules;
        partial void OnUseGeneralBudgetReservationPublicSectorAccountingRulesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseGeneralBudgetReservationPublicSectorAccountingRulesChanged();
        /// <summary>
        /// There are no comments for Property CheckRevenueBudgetForZeroBudgetBalances in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckRevenueBudgetForZeroBudgetBalances")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceOption> CheckRevenueBudgetForZeroBudgetBalances
        {
            get
            {
                return this._CheckRevenueBudgetForZeroBudgetBalances;
            }
            set
            {
                this.OnCheckRevenueBudgetForZeroBudgetBalancesChanging(value);
                this._CheckRevenueBudgetForZeroBudgetBalances = value;
                this.OnCheckRevenueBudgetForZeroBudgetBalancesChanged();
                this.OnPropertyChanged("CheckRevenueBudgetForZeroBudgetBalances");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceOption> _CheckRevenueBudgetForZeroBudgetBalances;
        partial void OnCheckRevenueBudgetForZeroBudgetBalancesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckRevenueBalanceOption> value);
        partial void OnCheckRevenueBudgetForZeroBudgetBalancesChanged();
        /// <summary>
        /// There are no comments for Property BudgetJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetJournal")]
        public virtual string BudgetJournal
        {
            get
            {
                return this._BudgetJournal;
            }
            set
            {
                this.OnBudgetJournalChanging(value);
                this._BudgetJournal = value;
                this.OnBudgetJournalChanged();
                this.OnPropertyChanged("BudgetJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetJournal;
        partial void OnBudgetJournalChanging(string value);
        partial void OnBudgetJournalChanged();
        /// <summary>
        /// There are no comments for Property PeriodAllocationCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodAllocationCategory")]
        public virtual global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategory PeriodAllocationCategory
        {
            get
            {
                return this._PeriodAllocationCategory;
            }
            set
            {
                this.OnPeriodAllocationCategoryChanging(value);
                this._PeriodAllocationCategory = value;
                this.OnPeriodAllocationCategoryChanged();
                this.OnPropertyChanged("PeriodAllocationCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategory _PeriodAllocationCategory;
        partial void OnPeriodAllocationCategoryChanging(global::Microsoft.Dynamics.DataEntities.PeriodAllocationCategory value);
        partial void OnPeriodAllocationCategoryChanged();
        /// <summary>
        /// There are no comments for Property BudgetParametersJournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetParametersJournalName")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalName BudgetParametersJournalName
        {
            get
            {
                return this._BudgetParametersJournalName;
            }
            set
            {
                this.OnBudgetParametersJournalNameChanging(value);
                this._BudgetParametersJournalName = value;
                this.OnBudgetParametersJournalNameChanged();
                this.OnPropertyChanged("BudgetParametersJournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalName _BudgetParametersJournalName;
        partial void OnBudgetParametersJournalNameChanging(global::Microsoft.Dynamics.DataEntities.JournalName value);
        partial void OnBudgetParametersJournalNameChanged();
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