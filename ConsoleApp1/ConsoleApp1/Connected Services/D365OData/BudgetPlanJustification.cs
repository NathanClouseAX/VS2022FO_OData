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
    /// There are no comments for BudgetPlanJustificationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetPlanJustificationSingle")]
    public partial class BudgetPlanJustificationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetPlanJustification>
    {
        /// <summary>
        /// Initialize a new BudgetPlanJustificationSingle object.
        /// </summary>
        public BudgetPlanJustificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetPlanJustificationSingle object.
        /// </summary>
        public BudgetPlanJustificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetPlanJustificationSingle object.
        /// </summary>
        public BudgetPlanJustificationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetPlanJustification> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BudgetPlanJustification in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EffectiveDate
    /// DocumentNumber
    /// ScenarioName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EffectiveDate", "DocumentNumber", "ScenarioName")]
    [global::Microsoft.OData.Client.EntitySet("BudgetPlanJustifications")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetPlanJustification")]
    public partial class BudgetPlanJustification : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetPlanJustification object.
        /// </summary>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        /// <param name="documentNumber">Initial value of DocumentNumber.</param>
        /// <param name="scenarioName">Initial value of ScenarioName.</param>
        /// <param name="accountingCurrencyRevenueAmount">Initial value of AccountingCurrencyRevenueAmount.</param>
        /// <param name="transactionCurrencyRevenueAmount">Initial value of TransactionCurrencyRevenueAmount.</param>
        /// <param name="accountingCurrencyExpenseAmount">Initial value of AccountingCurrencyExpenseAmount.</param>
        /// <param name="transactionCurrencyExpenseAmount">Initial value of TransactionCurrencyExpenseAmount.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetPlanJustification CreateBudgetPlanJustification(global::System.DateTimeOffset effectiveDate, 
                    string documentNumber, 
                    string scenarioName, 
                    decimal accountingCurrencyRevenueAmount, 
                    decimal transactionCurrencyRevenueAmount, 
                    decimal accountingCurrencyExpenseAmount, 
                    decimal transactionCurrencyExpenseAmount, 
                    decimal quantity)
        {
            BudgetPlanJustification budgetPlanJustification = new BudgetPlanJustification();
            budgetPlanJustification.EffectiveDate = effectiveDate;
            budgetPlanJustification.DocumentNumber = documentNumber;
            budgetPlanJustification.ScenarioName = scenarioName;
            budgetPlanJustification.AccountingCurrencyRevenueAmount = accountingCurrencyRevenueAmount;
            budgetPlanJustification.TransactionCurrencyRevenueAmount = transactionCurrencyRevenueAmount;
            budgetPlanJustification.AccountingCurrencyExpenseAmount = accountingCurrencyExpenseAmount;
            budgetPlanJustification.TransactionCurrencyExpenseAmount = transactionCurrencyExpenseAmount;
            budgetPlanJustification.Quantity = quantity;
            return budgetPlanJustification;
        }
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentNumber is required.")]
        public virtual string DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentNumber;
        partial void OnDocumentNumberChanging(string value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property ScenarioName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScenarioName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScenarioName is required.")]
        public virtual string ScenarioName
        {
            get
            {
                return this._ScenarioName;
            }
            set
            {
                this.OnScenarioNameChanging(value);
                this._ScenarioName = value;
                this.OnScenarioNameChanged();
                this.OnPropertyChanged("ScenarioName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScenarioName;
        partial void OnScenarioNameChanging(string value);
        partial void OnScenarioNameChanged();
        /// <summary>
        /// There are no comments for Property BudgetPlanName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetPlanName")]
        public virtual string BudgetPlanName
        {
            get
            {
                return this._BudgetPlanName;
            }
            set
            {
                this.OnBudgetPlanNameChanging(value);
                this._BudgetPlanName = value;
                this.OnBudgetPlanNameChanged();
                this.OnPropertyChanged("BudgetPlanName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetPlanName;
        partial void OnBudgetPlanNameChanging(string value);
        partial void OnBudgetPlanNameChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyRevenueAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingCurrencyRevenueAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingCurrencyRevenueAmount is required.")]
        public virtual decimal AccountingCurrencyRevenueAmount
        {
            get
            {
                return this._AccountingCurrencyRevenueAmount;
            }
            set
            {
                this.OnAccountingCurrencyRevenueAmountChanging(value);
                this._AccountingCurrencyRevenueAmount = value;
                this.OnAccountingCurrencyRevenueAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyRevenueAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyRevenueAmount;
        partial void OnAccountingCurrencyRevenueAmountChanging(decimal value);
        partial void OnAccountingCurrencyRevenueAmountChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyRevenueAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCurrencyRevenueAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionCurrencyRevenueAmount is required.")]
        public virtual decimal TransactionCurrencyRevenueAmount
        {
            get
            {
                return this._TransactionCurrencyRevenueAmount;
            }
            set
            {
                this.OnTransactionCurrencyRevenueAmountChanging(value);
                this._TransactionCurrencyRevenueAmount = value;
                this.OnTransactionCurrencyRevenueAmountChanged();
                this.OnPropertyChanged("TransactionCurrencyRevenueAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TransactionCurrencyRevenueAmount;
        partial void OnTransactionCurrencyRevenueAmountChanging(decimal value);
        partial void OnTransactionCurrencyRevenueAmountChanged();
        /// <summary>
        /// There are no comments for Property AccountingCurrencyExpenseAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingCurrencyExpenseAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingCurrencyExpenseAmount is required.")]
        public virtual decimal AccountingCurrencyExpenseAmount
        {
            get
            {
                return this._AccountingCurrencyExpenseAmount;
            }
            set
            {
                this.OnAccountingCurrencyExpenseAmountChanging(value);
                this._AccountingCurrencyExpenseAmount = value;
                this.OnAccountingCurrencyExpenseAmountChanged();
                this.OnPropertyChanged("AccountingCurrencyExpenseAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccountingCurrencyExpenseAmount;
        partial void OnAccountingCurrencyExpenseAmountChanging(decimal value);
        partial void OnAccountingCurrencyExpenseAmountChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property ResponsibilityCenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResponsibilityCenter")]
        public virtual string ResponsibilityCenter
        {
            get
            {
                return this._ResponsibilityCenter;
            }
            set
            {
                this.OnResponsibilityCenterChanging(value);
                this._ResponsibilityCenter = value;
                this.OnResponsibilityCenterChanged();
                this.OnPropertyChanged("ResponsibilityCenter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponsibilityCenter;
        partial void OnResponsibilityCenterChanging(string value);
        partial void OnResponsibilityCenterChanged();
        /// <summary>
        /// There are no comments for Property TransactionCurrencyExpenseAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCurrencyExpenseAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionCurrencyExpenseAmount is required.")]
        public virtual decimal TransactionCurrencyExpenseAmount
        {
            get
            {
                return this._TransactionCurrencyExpenseAmount;
            }
            set
            {
                this.OnTransactionCurrencyExpenseAmountChanging(value);
                this._TransactionCurrencyExpenseAmount = value;
                this.OnTransactionCurrencyExpenseAmountChanged();
                this.OnPropertyChanged("TransactionCurrencyExpenseAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TransactionCurrencyExpenseAmount;
        partial void OnTransactionCurrencyExpenseAmountChanging(decimal value);
        partial void OnTransactionCurrencyExpenseAmountChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountDisplayValue")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property BudgetPlanPreparer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetPlanPreparer")]
        public virtual string BudgetPlanPreparer
        {
            get
            {
                return this._BudgetPlanPreparer;
            }
            set
            {
                this.OnBudgetPlanPreparerChanging(value);
                this._BudgetPlanPreparer = value;
                this.OnBudgetPlanPreparerChanged();
                this.OnPropertyChanged("BudgetPlanPreparer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetPlanPreparer;
        partial void OnBudgetPlanPreparerChanging(string value);
        partial void OnBudgetPlanPreparerChanged();
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