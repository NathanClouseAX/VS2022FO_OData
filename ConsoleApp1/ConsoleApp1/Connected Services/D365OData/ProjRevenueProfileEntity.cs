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
    /// There are no comments for ProjRevenueProfileEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjRevenueProfileEntitySingle")]
    public partial class ProjRevenueProfileEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjRevenueProfileEntity>
    {
        /// <summary>
        /// Initialize a new ProjRevenueProfileEntitySingle object.
        /// </summary>
        public ProjRevenueProfileEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjRevenueProfileEntitySingle object.
        /// </summary>
        public ProjRevenueProfileEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjRevenueProfileEntitySingle object.
        /// </summary>
        public ProjRevenueProfileEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjRevenueProfileEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjRevenueProfileEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProfileId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProfileId")]
    [global::Microsoft.OData.Client.EntitySet("ProjRevenueProfiles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjRevenueProfileEntity")]
    public partial class ProjRevenueProfileEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjRevenueProfileEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="profileId">Initial value of ProfileId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjRevenueProfileEntity CreateProjRevenueProfileEntity(string dataAreaId, string profileId)
        {
            ProjRevenueProfileEntity projRevenueProfileEntity = new ProjRevenueProfileEntity();
            projRevenueProfileEntity.DataAreaId = dataAreaId;
            projRevenueProfileEntity.ProfileId = profileId;
            return projRevenueProfileEntity;
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
        /// There are no comments for Property ProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfileId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileId is required.")]
        public virtual string ProfileId
        {
            get
            {
                return this._ProfileId;
            }
            set
            {
                this.OnProfileIdChanging(value);
                this._ProfileId = value;
                this.OnProfileIdChanged();
                this.OnPropertyChanged("ProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProfileId;
        partial void OnProfileIdChanging(string value);
        partial void OnProfileIdChanged();
        /// <summary>
        /// There are no comments for Property IsRevenueHourAccrued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRevenueHourAccrued")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRevenueHourAccrued
        {
            get
            {
                return this._IsRevenueHourAccrued;
            }
            set
            {
                this.OnIsRevenueHourAccruedChanging(value);
                this._IsRevenueHourAccrued = value;
                this.OnIsRevenueHourAccruedChanged();
                this.OnPropertyChanged("IsRevenueHourAccrued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRevenueHourAccrued;
        partial void OnIsRevenueHourAccruedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRevenueHourAccruedChanged();
        /// <summary>
        /// There are no comments for Property ProductionProjectCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionProjectCategoryId")]
        public virtual string ProductionProjectCategoryId
        {
            get
            {
                return this._ProductionProjectCategoryId;
            }
            set
            {
                this.OnProductionProjectCategoryIdChanging(value);
                this._ProductionProjectCategoryId = value;
                this.OnProductionProjectCategoryIdChanged();
                this.OnPropertyChanged("ProductionProjectCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionProjectCategoryId;
        partial void OnProductionProjectCategoryIdChanging(string value);
        partial void OnProductionProjectCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ProfitProjectCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfitProjectCategoryId")]
        public virtual string ProfitProjectCategoryId
        {
            get
            {
                return this._ProfitProjectCategoryId;
            }
            set
            {
                this.OnProfitProjectCategoryIdChanging(value);
                this._ProfitProjectCategoryId = value;
                this.OnProfitProjectCategoryIdChanged();
                this.OnPropertyChanged("ProfitProjectCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProfitProjectCategoryId;
        partial void OnProfitProjectCategoryIdChanging(string value);
        partial void OnProfitProjectCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectContractBillingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContractBillingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjContractBillingMethod> ProjectContractBillingMethod
        {
            get
            {
                return this._ProjectContractBillingMethod;
            }
            set
            {
                this.OnProjectContractBillingMethodChanging(value);
                this._ProjectContractBillingMethod = value;
                this.OnProjectContractBillingMethodChanged();
                this.OnPropertyChanged("ProjectContractBillingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjContractBillingMethod> _ProjectContractBillingMethod;
        partial void OnProjectContractBillingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjContractBillingMethod> value);
        partial void OnProjectContractBillingMethodChanged();
        /// <summary>
        /// There are no comments for Property RevenueRecognitionAccountingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueRecognitionAccountingRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCompletePrincip> RevenueRecognitionAccountingRule
        {
            get
            {
                return this._RevenueRecognitionAccountingRule;
            }
            set
            {
                this.OnRevenueRecognitionAccountingRuleChanging(value);
                this._RevenueRecognitionAccountingRule = value;
                this.OnRevenueRecognitionAccountingRuleChanged();
                this.OnPropertyChanged("RevenueRecognitionAccountingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCompletePrincip> _RevenueRecognitionAccountingRule;
        partial void OnRevenueRecognitionAccountingRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjCompletePrincip> value);
        partial void OnRevenueRecognitionAccountingRuleChanged();
        /// <summary>
        /// There are no comments for Property IsRevenueExpenseAccrued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRevenueExpenseAccrued")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRevenueExpenseAccrued
        {
            get
            {
                return this._IsRevenueExpenseAccrued;
            }
            set
            {
                this.OnIsRevenueExpenseAccruedChanging(value);
                this._IsRevenueExpenseAccrued = value;
                this.OnIsRevenueExpenseAccruedChanged();
                this.OnPropertyChanged("IsRevenueExpenseAccrued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRevenueExpenseAccrued;
        partial void OnIsRevenueExpenseAccruedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRevenueExpenseAccruedChanged();
        /// <summary>
        /// There are no comments for Property CostTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostTemplateId")]
        public virtual string CostTemplateId
        {
            get
            {
                return this._CostTemplateId;
            }
            set
            {
                this.OnCostTemplateIdChanging(value);
                this._CostTemplateId = value;
                this.OnCostTemplateIdChanged();
                this.OnPropertyChanged("CostTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostTemplateId;
        partial void OnCostTemplateIdChanging(string value);
        partial void OnCostTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property OnAccountInvoicingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OnAccountInvoicingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusOnAcc> OnAccountInvoicingMethod
        {
            get
            {
                return this._OnAccountInvoicingMethod;
            }
            set
            {
                this.OnOnAccountInvoicingMethodChanging(value);
                this._OnAccountInvoicingMethod = value;
                this.OnOnAccountInvoicingMethodChanged();
                this.OnPropertyChanged("OnAccountInvoicingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusOnAcc> _OnAccountInvoicingMethod;
        partial void OnOnAccountInvoicingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusOnAcc> value);
        partial void OnOnAccountInvoicingMethodChanged();
        /// <summary>
        /// There are no comments for Property AreLossesForeseeable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AreLossesForeseeable")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreLossesForeseeable
        {
            get
            {
                return this._AreLossesForeseeable;
            }
            set
            {
                this.OnAreLossesForeseeableChanging(value);
                this._AreLossesForeseeable = value;
                this.OnAreLossesForeseeableChanged();
                this.OnPropertyChanged("AreLossesForeseeable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreLossesForeseeable;
        partial void OnAreLossesForeseeableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreLossesForeseeableChanged();
        /// <summary>
        /// There are no comments for Property AccruedLossCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccruedLossCategoryId")]
        public virtual string AccruedLossCategoryId
        {
            get
            {
                return this._AccruedLossCategoryId;
            }
            set
            {
                this.OnAccruedLossCategoryIdChanging(value);
                this._AccruedLossCategoryId = value;
                this.OnAccruedLossCategoryIdChanged();
                this.OnPropertyChanged("AccruedLossCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccruedLossCategoryId;
        partial void OnAccruedLossCategoryIdChanging(string value);
        partial void OnAccruedLossCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ProjectPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectPeriodId")]
        public virtual string ProjectPeriodId
        {
            get
            {
                return this._ProjectPeriodId;
            }
            set
            {
                this.OnProjectPeriodIdChanging(value);
                this._ProjectPeriodId = value;
                this.OnProjectPeriodIdChanged();
                this.OnPropertyChanged("ProjectPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectPeriodId;
        partial void OnProjectPeriodIdChanging(string value);
        partial void OnProjectPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property ExpenseCostPostingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseCostPostingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusCost> ExpenseCostPostingMethod
        {
            get
            {
                return this._ExpenseCostPostingMethod;
            }
            set
            {
                this.OnExpenseCostPostingMethodChanging(value);
                this._ExpenseCostPostingMethod = value;
                this.OnExpenseCostPostingMethodChanged();
                this.OnPropertyChanged("ExpenseCostPostingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusCost> _ExpenseCostPostingMethod;
        partial void OnExpenseCostPostingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusCost> value);
        partial void OnExpenseCostPostingMethodChanged();
        /// <summary>
        /// There are no comments for Property RevenueRecognitionCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueRecognitionCalculationMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjSalesPriceMatchingPrincip> RevenueRecognitionCalculationMethod
        {
            get
            {
                return this._RevenueRecognitionCalculationMethod;
            }
            set
            {
                this.OnRevenueRecognitionCalculationMethodChanging(value);
                this._RevenueRecognitionCalculationMethod = value;
                this.OnRevenueRecognitionCalculationMethodChanged();
                this.OnPropertyChanged("RevenueRecognitionCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjSalesPriceMatchingPrincip> _RevenueRecognitionCalculationMethod;
        partial void OnRevenueRecognitionCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjSalesPriceMatchingPrincip> value);
        partial void OnRevenueRecognitionCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property ProfileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfileName")]
        public virtual string ProfileName
        {
            get
            {
                return this._ProfileName;
            }
            set
            {
                this.OnProfileNameChanging(value);
                this._ProfileName = value;
                this.OnProfileNameChanged();
                this.OnPropertyChanged("ProfileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProfileName;
        partial void OnProfileNameChanging(string value);
        partial void OnProfileNameChanged();
        /// <summary>
        /// There are no comments for Property ItemCostPostingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCostPostingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusItem> ItemCostPostingMethod
        {
            get
            {
                return this._ItemCostPostingMethod;
            }
            set
            {
                this.OnItemCostPostingMethodChanging(value);
                this._ItemCostPostingMethod = value;
                this.OnItemCostPostingMethodChanged();
                this.OnPropertyChanged("ItemCostPostingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusItem> _ItemCostPostingMethod;
        partial void OnItemCostPostingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatusItem> value);
        partial void OnItemCostPostingMethodChanged();
        /// <summary>
        /// There are no comments for Property IsRevenueFeeAccrued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRevenueFeeAccrued")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRevenueFeeAccrued
        {
            get
            {
                return this._IsRevenueFeeAccrued;
            }
            set
            {
                this.OnIsRevenueFeeAccruedChanging(value);
                this._IsRevenueFeeAccrued = value;
                this.OnIsRevenueFeeAccruedChanged();
                this.OnPropertyChanged("IsRevenueFeeAccrued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRevenueFeeAccrued;
        partial void OnIsRevenueFeeAccruedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRevenueFeeAccruedChanged();
        /// <summary>
        /// There are no comments for Property HourCostPostingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HourCostPostingMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatus> HourCostPostingMethod
        {
            get
            {
                return this._HourCostPostingMethod;
            }
            set
            {
                this.OnHourCostPostingMethodChanging(value);
                this._HourCostPostingMethod = value;
                this.OnHourCostPostingMethodChanged();
                this.OnPropertyChanged("HourCostPostingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatus> _HourCostPostingMethod;
        partial void OnHourCostPostingMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjLedgerStatus> value);
        partial void OnHourCostPostingMethodChanged();
        /// <summary>
        /// There are no comments for Property RevenueRecognitionMatchingPrinciple in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueRecognitionMatchingPrinciple")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjMatchingPrincip> RevenueRecognitionMatchingPrinciple
        {
            get
            {
                return this._RevenueRecognitionMatchingPrinciple;
            }
            set
            {
                this.OnRevenueRecognitionMatchingPrincipleChanging(value);
                this._RevenueRecognitionMatchingPrinciple = value;
                this.OnRevenueRecognitionMatchingPrincipleChanged();
                this.OnPropertyChanged("RevenueRecognitionMatchingPrinciple");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjMatchingPrincip> _RevenueRecognitionMatchingPrinciple;
        partial void OnRevenueRecognitionMatchingPrincipleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjMatchingPrincip> value);
        partial void OnRevenueRecognitionMatchingPrincipleChanged();
        /// <summary>
        /// There are no comments for Property SalesValueProjectCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesValueProjectCategoryId")]
        public virtual string SalesValueProjectCategoryId
        {
            get
            {
                return this._SalesValueProjectCategoryId;
            }
            set
            {
                this.OnSalesValueProjectCategoryIdChanging(value);
                this._SalesValueProjectCategoryId = value;
                this.OnSalesValueProjectCategoryIdChanged();
                this.OnPropertyChanged("SalesValueProjectCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesValueProjectCategoryId;
        partial void OnSalesValueProjectCategoryIdChanging(string value);
        partial void OnSalesValueProjectCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property IsRevenueItemAccrued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRevenueItemAccrued")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRevenueItemAccrued
        {
            get
            {
                return this._IsRevenueItemAccrued;
            }
            set
            {
                this.OnIsRevenueItemAccruedChanging(value);
                this._IsRevenueItemAccrued = value;
                this.OnIsRevenueItemAccruedChanged();
                this.OnPropertyChanged("IsRevenueItemAccrued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRevenueItemAccrued;
        partial void OnIsRevenueItemAccruedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRevenueItemAccruedChanged();
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
