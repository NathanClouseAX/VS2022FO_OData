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
    /// There are no comments for RebateAndDeductionsAgreementDateSetupCriterionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementDateSetupCriterionSingle")]
    public partial class RebateAndDeductionsAgreementDateSetupCriterionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDateSetupCriterion>
    {
        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RebateAndDeductionsAgreementDateSetupCriterionSingle object.
        /// </summary>
        public RebateAndDeductionsAgreementDateSetupCriterionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RebateAndDeductionsAgreementDateSetupCriterion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementHeaderDateSetupCriterionItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementHeaderDateSetupCriterionItems")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem> RebateAndDeductionsAgreementHeaderDateSetupCriterionItems
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsAgreementHeaderDateSetupCriterionItems == null))
                {
                    this._RebateAndDeductionsAgreementHeaderDateSetupCriterionItems = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem>(GetPath("RebateAndDeductionsAgreementHeaderDateSetupCriterionItems"));
                }
                return this._RebateAndDeductionsAgreementHeaderDateSetupCriterionItems;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem> _RebateAndDeductionsAgreementHeaderDateSetupCriterionItems;
    }
    /// <summary>
    /// There are no comments for RebateAndDeductionsAgreementDateSetupCriterion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AgreementNumber
    /// AgreementLineNumber
    /// RebateValidFromQuantityAmount
    /// RebateValidToQuantityAmount
    /// RebateAmount
    /// RebateCalculationMethod
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AgreementNumber", "AgreementLineNumber", "RebateValidFromQuantityAmount", "RebateValidToQuantityAmount", "RebateAmount", "RebateCalculationMethod")]
    [global::Microsoft.OData.Client.EntitySet("RebateAndDeductionsAgreementDateSetupCriteria")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementDateSetupCriterion")]
    public partial class RebateAndDeductionsAgreementDateSetupCriterion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RebateAndDeductionsAgreementDateSetupCriterion object.
        /// </summary>
        /// <param name="agreementNumber">Initial value of AgreementNumber.</param>
        /// <param name="agreementLineNumber">Initial value of AgreementLineNumber.</param>
        /// <param name="rebateValidFromQuantityAmount">Initial value of RebateValidFromQuantityAmount.</param>
        /// <param name="rebateValidToQuantityAmount">Initial value of RebateValidToQuantityAmount.</param>
        /// <param name="rebateAmount">Initial value of RebateAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RebateAndDeductionsAgreementDateSetupCriterion CreateRebateAndDeductionsAgreementDateSetupCriterion(string agreementNumber, decimal agreementLineNumber, decimal rebateValidFromQuantityAmount, decimal rebateValidToQuantityAmount, decimal rebateAmount)
        {
            RebateAndDeductionsAgreementDateSetupCriterion rebateAndDeductionsAgreementDateSetupCriterion = new RebateAndDeductionsAgreementDateSetupCriterion();
            rebateAndDeductionsAgreementDateSetupCriterion.AgreementNumber = agreementNumber;
            rebateAndDeductionsAgreementDateSetupCriterion.AgreementLineNumber = agreementLineNumber;
            rebateAndDeductionsAgreementDateSetupCriterion.RebateValidFromQuantityAmount = rebateValidFromQuantityAmount;
            rebateAndDeductionsAgreementDateSetupCriterion.RebateValidToQuantityAmount = rebateValidToQuantityAmount;
            rebateAndDeductionsAgreementDateSetupCriterion.RebateAmount = rebateAmount;
            return rebateAndDeductionsAgreementDateSetupCriterion;
        }
        /// <summary>
        /// There are no comments for Property AgreementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgreementNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AgreementNumber is required.")]
        public virtual string AgreementNumber
        {
            get
            {
                return this._AgreementNumber;
            }
            set
            {
                this.OnAgreementNumberChanging(value);
                this._AgreementNumber = value;
                this.OnAgreementNumberChanged();
                this.OnPropertyChanged("AgreementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AgreementNumber;
        partial void OnAgreementNumberChanging(string value);
        partial void OnAgreementNumberChanged();
        /// <summary>
        /// There are no comments for Property AgreementLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgreementLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AgreementLineNumber is required.")]
        public virtual decimal AgreementLineNumber
        {
            get
            {
                return this._AgreementLineNumber;
            }
            set
            {
                this.OnAgreementLineNumberChanging(value);
                this._AgreementLineNumber = value;
                this.OnAgreementLineNumberChanged();
                this.OnPropertyChanged("AgreementLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AgreementLineNumber;
        partial void OnAgreementLineNumberChanging(decimal value);
        partial void OnAgreementLineNumberChanged();
        /// <summary>
        /// There are no comments for Property RebateValidFromQuantityAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateValidFromQuantityAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RebateValidFromQuantityAmount is required.")]
        public virtual decimal RebateValidFromQuantityAmount
        {
            get
            {
                return this._RebateValidFromQuantityAmount;
            }
            set
            {
                this.OnRebateValidFromQuantityAmountChanging(value);
                this._RebateValidFromQuantityAmount = value;
                this.OnRebateValidFromQuantityAmountChanged();
                this.OnPropertyChanged("RebateValidFromQuantityAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateValidFromQuantityAmount;
        partial void OnRebateValidFromQuantityAmountChanging(decimal value);
        partial void OnRebateValidFromQuantityAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateValidToQuantityAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateValidToQuantityAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RebateValidToQuantityAmount is required.")]
        public virtual decimal RebateValidToQuantityAmount
        {
            get
            {
                return this._RebateValidToQuantityAmount;
            }
            set
            {
                this.OnRebateValidToQuantityAmountChanging(value);
                this._RebateValidToQuantityAmount = value;
                this.OnRebateValidToQuantityAmountChanged();
                this.OnPropertyChanged("RebateValidToQuantityAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateValidToQuantityAmount;
        partial void OnRebateValidToQuantityAmountChanging(decimal value);
        partial void OnRebateValidToQuantityAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RebateAmount is required.")]
        public virtual decimal RebateAmount
        {
            get
            {
                return this._RebateAmount;
            }
            set
            {
                this.OnRebateAmountChanging(value);
                this._RebateAmount = value;
                this.OnRebateAmountChanged();
                this.OnPropertyChanged("RebateAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RebateAmount;
        partial void OnRebateAmountChanging(decimal value);
        partial void OnRebateAmountChanged();
        /// <summary>
        /// There are no comments for Property RebateCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateCalculationMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> RebateCalculationMethod
        {
            get
            {
                return this._RebateCalculationMethod;
            }
            set
            {
                this.OnRebateCalculationMethodChanging(value);
                this._RebateCalculationMethod = value;
                this.OnRebateCalculationMethodChanged();
                this.OnPropertyChanged("RebateCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> _RebateCalculationMethod;
        partial void OnRebateCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMRebateMethod> value);
        partial void OnRebateCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property RebateAndDeductionsAgreementHeaderDateSetupCriterionItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RebateAndDeductionsAgreementHeaderDateSetupCriterionItems")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem> RebateAndDeductionsAgreementHeaderDateSetupCriterionItems
        {
            get
            {
                return this._RebateAndDeductionsAgreementHeaderDateSetupCriterionItems;
            }
            set
            {
                this.OnRebateAndDeductionsAgreementHeaderDateSetupCriterionItemsChanging(value);
                this._RebateAndDeductionsAgreementHeaderDateSetupCriterionItems = value;
                this.OnRebateAndDeductionsAgreementHeaderDateSetupCriterionItemsChanged();
                this.OnPropertyChanged("RebateAndDeductionsAgreementHeaderDateSetupCriterionItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem> _RebateAndDeductionsAgreementHeaderDateSetupCriterionItems = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateAndDeductionsAgreementHeaderDateSetupCriterionItemsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionsAgreementDateSetupCriterionItem> value);
        partial void OnRebateAndDeductionsAgreementHeaderDateSetupCriterionItemsChanged();
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
