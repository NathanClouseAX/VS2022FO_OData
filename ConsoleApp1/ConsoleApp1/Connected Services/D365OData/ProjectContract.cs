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
    /// There are no comments for ProjectContractSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContractSingle")]
    public partial class ProjectContractSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectContract>
    {
        /// <summary>
        /// Initialize a new ProjectContractSingle object.
        /// </summary>
        public ProjectContractSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectContractSingle object.
        /// </summary>
        public ProjectContractSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectContractSingle object.
        /// </summary>
        public ProjectContractSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectContract> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FundingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FundingRule")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule> FundingRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FundingRule == null))
                {
                    this._FundingRule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule>(GetPath("FundingRule"));
                }
                return this._FundingRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule> _FundingRule;
    }
    /// <summary>
    /// There are no comments for ProjectContract in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjectContractID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjectContractID")]
    [global::Microsoft.OData.Client.EntitySet("ProjectContracts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContract")]
    public partial class ProjectContract : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectContract object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projectContractID">Initial value of ProjectContractID.</param>
        /// <param name="contractDate">Initial value of ContractDate.</param>
        /// <param name="retainagePercent">Initial value of RetainagePercent.</param>
        /// <param name="minimumTimeIncrement">Initial value of MinimumTimeIncrement.</param>
        /// <param name="progressInvoicing">Initial value of ProgressInvoicing.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectContract CreateProjectContract(string dataAreaId, 
                    string projectContractID, 
                    global::System.DateTimeOffset contractDate, 
                    decimal retainagePercent, 
                    decimal minimumTimeIncrement, 
                    bool progressInvoicing)
        {
            ProjectContract projectContract = new ProjectContract();
            projectContract.DataAreaId = dataAreaId;
            projectContract.ProjectContractID = projectContractID;
            projectContract.ContractDate = contractDate;
            projectContract.RetainagePercent = retainagePercent;
            projectContract.MinimumTimeIncrement = minimumTimeIncrement;
            projectContract.ProgressInvoicing = progressInvoicing;
            return projectContract;
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
        /// There are no comments for Property ProjectContractID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContractID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectContractID is required.")]
        public virtual string ProjectContractID
        {
            get
            {
                return this._ProjectContractID;
            }
            set
            {
                this.OnProjectContractIDChanging(value);
                this._ProjectContractID = value;
                this.OnProjectContractIDChanged();
                this.OnPropertyChanged("ProjectContractID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectContractID;
        partial void OnProjectContractIDChanging(string value);
        partial void OnProjectContractIDChanged();
        /// <summary>
        /// There are no comments for Property ContractDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContractDate is required.")]
        public virtual global::System.DateTimeOffset ContractDate
        {
            get
            {
                return this._ContractDate;
            }
            set
            {
                this.OnContractDateChanging(value);
                this._ContractDate = value;
                this.OnContractDateChanged();
                this.OnPropertyChanged("ContractDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ContractDate;
        partial void OnContractDateChanging(global::System.DateTimeOffset value);
        partial void OnContractDateChanged();
        /// <summary>
        /// There are no comments for Property LockContractSalesCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LockContractSalesCurrency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LockContractSalesCurrency
        {
            get
            {
                return this._LockContractSalesCurrency;
            }
            set
            {
                this.OnLockContractSalesCurrencyChanging(value);
                this._LockContractSalesCurrency = value;
                this.OnLockContractSalesCurrencyChanged();
                this.OnPropertyChanged("LockContractSalesCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LockContractSalesCurrency;
        partial void OnLockContractSalesCurrencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLockContractSalesCurrencyChanged();
        /// <summary>
        /// There are no comments for Property BankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BankAccount")]
        public virtual string BankAccount
        {
            get
            {
                return this._BankAccount;
            }
            set
            {
                this.OnBankAccountChanging(value);
                this._BankAccount = value;
                this.OnBankAccountChanged();
                this.OnPropertyChanged("BankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BankAccount;
        partial void OnBankAccountChanging(string value);
        partial void OnBankAccountChanged();
        /// <summary>
        /// There are no comments for Property CentralBankPurposeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CentralBankPurposeCode")]
        public virtual string CentralBankPurposeCode
        {
            get
            {
                return this._CentralBankPurposeCode;
            }
            set
            {
                this.OnCentralBankPurposeCodeChanging(value);
                this._CentralBankPurposeCode = value;
                this.OnCentralBankPurposeCodeChanged();
                this.OnPropertyChanged("CentralBankPurposeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CentralBankPurposeCode;
        partial void OnCentralBankPurposeCodeChanging(string value);
        partial void OnCentralBankPurposeCodeChanged();
        /// <summary>
        /// There are no comments for Property InvoicingName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoicingName")]
        public virtual string InvoicingName
        {
            get
            {
                return this._InvoicingName;
            }
            set
            {
                this.OnInvoicingNameChanging(value);
                this._InvoicingName = value;
                this.OnInvoicingNameChanged();
                this.OnPropertyChanged("InvoicingName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoicingName;
        partial void OnInvoicingNameChanging(string value);
        partial void OnInvoicingNameChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxGroup")]
        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property SalesResponsiblePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesResponsiblePersonnelNumber")]
        public virtual string SalesResponsiblePersonnelNumber
        {
            get
            {
                return this._SalesResponsiblePersonnelNumber;
            }
            set
            {
                this.OnSalesResponsiblePersonnelNumberChanging(value);
                this._SalesResponsiblePersonnelNumber = value;
                this.OnSalesResponsiblePersonnelNumberChanged();
                this.OnPropertyChanged("SalesResponsiblePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesResponsiblePersonnelNumber;
        partial void OnSalesResponsiblePersonnelNumberChanging(string value);
        partial void OnSalesResponsiblePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property PriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceGroup")]
        public virtual string PriceGroup
        {
            get
            {
                return this._PriceGroup;
            }
            set
            {
                this.OnPriceGroupChanging(value);
                this._PriceGroup = value;
                this.OnPriceGroupChanged();
                this.OnPropertyChanged("PriceGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceGroup;
        partial void OnPriceGroupChanging(string value);
        partial void OnPriceGroupChanged();
        /// <summary>
        /// There are no comments for Property NetPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NetPrice")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> NetPrice
        {
            get
            {
                return this._NetPrice;
            }
            set
            {
                this.OnNetPriceChanging(value);
                this._NetPrice = value;
                this.OnNetPriceChanged();
                this.OnPropertyChanged("NetPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _NetPrice;
        partial void OnNetPriceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNetPriceChanged();
        /// <summary>
        /// There are no comments for Property PurposeText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurposeText")]
        public virtual string PurposeText
        {
            get
            {
                return this._PurposeText;
            }
            set
            {
                this.OnPurposeTextChanging(value);
                this._PurposeText = value;
                this.OnPurposeTextChanged();
                this.OnPropertyChanged("PurposeText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurposeText;
        partial void OnPurposeTextChanging(string value);
        partial void OnPurposeTextChanged();
        /// <summary>
        /// There are no comments for Property InvoiceFrequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceFrequency")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastInvoiceFrequency> InvoiceFrequency
        {
            get
            {
                return this._InvoiceFrequency;
            }
            set
            {
                this.OnInvoiceFrequencyChanging(value);
                this._InvoiceFrequency = value;
                this.OnInvoiceFrequencyChanged();
                this.OnPropertyChanged("InvoiceFrequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastInvoiceFrequency> _InvoiceFrequency;
        partial void OnInvoiceFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjForecastInvoiceFrequency> value);
        partial void OnInvoiceFrequencyChanged();
        /// <summary>
        /// There are no comments for Property SalesCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesCurrency")]
        public virtual string SalesCurrency
        {
            get
            {
                return this._SalesCurrency;
            }
            set
            {
                this.OnSalesCurrencyChanging(value);
                this._SalesCurrency = value;
                this.OnSalesCurrencyChanged();
                this.OnPropertyChanged("SalesCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesCurrency;
        partial void OnSalesCurrencyChanging(string value);
        partial void OnSalesCurrencyChanged();
        /// <summary>
        /// There are no comments for Property DefaultPostingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPostingLevel")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> DefaultPostingLevel
        {
            get
            {
                return this._DefaultPostingLevel;
            }
            set
            {
                this.OnDefaultPostingLevelChanging(value);
                this._DefaultPostingLevel = value;
                this.OnDefaultPostingLevelChanged();
                this.OnPropertyChanged("DefaultPostingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _DefaultPostingLevel;
        partial void OnDefaultPostingLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnDefaultPostingLevelChanged();
        /// <summary>
        /// There are no comments for Property TransactionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCode")]
        public virtual string TransactionCode
        {
            get
            {
                return this._TransactionCode;
            }
            set
            {
                this.OnTransactionCodeChanging(value);
                this._TransactionCode = value;
                this.OnTransactionCodeChanged();
                this.OnPropertyChanged("TransactionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCode;
        partial void OnTransactionCodeChanging(string value);
        partial void OnTransactionCodeChanged();
        /// <summary>
        /// There are no comments for Property RetainagePercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetainagePercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetainagePercent is required.")]
        public virtual decimal RetainagePercent
        {
            get
            {
                return this._RetainagePercent;
            }
            set
            {
                this.OnRetainagePercentChanging(value);
                this._RetainagePercent = value;
                this.OnRetainagePercentChanged();
                this.OnPropertyChanged("RetainagePercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RetainagePercent;
        partial void OnRetainagePercentChanging(decimal value);
        partial void OnRetainagePercentChanged();
        /// <summary>
        /// There are no comments for Property ContractLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContractLines")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ContractLines
        {
            get
            {
                return this._ContractLines;
            }
            set
            {
                this.OnContractLinesChanging(value);
                this._ContractLines = value;
                this.OnContractLinesChanged();
                this.OnPropertyChanged("ContractLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ContractLines;
        partial void OnContractLinesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnContractLinesChanged();
        /// <summary>
        /// There are no comments for Property MinimumTimeIncrement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumTimeIncrement")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumTimeIncrement is required.")]
        public virtual decimal MinimumTimeIncrement
        {
            get
            {
                return this._MinimumTimeIncrement;
            }
            set
            {
                this.OnMinimumTimeIncrementChanging(value);
                this._MinimumTimeIncrement = value;
                this.OnMinimumTimeIncrementChanged();
                this.OnPropertyChanged("MinimumTimeIncrement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumTimeIncrement;
        partial void OnMinimumTimeIncrementChanging(decimal value);
        partial void OnMinimumTimeIncrementChanged();
        /// <summary>
        /// There are no comments for Property ServiceOnDeliveryAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceOnDeliveryAddress")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ServiceOnDeliveryAddress
        {
            get
            {
                return this._ServiceOnDeliveryAddress;
            }
            set
            {
                this.OnServiceOnDeliveryAddressChanging(value);
                this._ServiceOnDeliveryAddress = value;
                this.OnServiceOnDeliveryAddressChanged();
                this.OnPropertyChanged("ServiceOnDeliveryAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ServiceOnDeliveryAddress;
        partial void OnServiceOnDeliveryAddressChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnServiceOnDeliveryAddressChanged();
        /// <summary>
        /// There are no comments for Property CustomerRetentionTermId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRetentionTermId")]
        public virtual string CustomerRetentionTermId
        {
            get
            {
                return this._CustomerRetentionTermId;
            }
            set
            {
                this.OnCustomerRetentionTermIdChanging(value);
                this._CustomerRetentionTermId = value;
                this.OnCustomerRetentionTermIdChanged();
                this.OnPropertyChanged("CustomerRetentionTermId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerRetentionTermId;
        partial void OnCustomerRetentionTermIdChanging(string value);
        partial void OnCustomerRetentionTermIdChanged();
        /// <summary>
        /// There are no comments for Property ListCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ListCodeId")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Listcode> ListCodeId
        {
            get
            {
                return this._ListCodeId;
            }
            set
            {
                this.OnListCodeIdChanging(value);
                this._ListCodeId = value;
                this.OnListCodeIdChanged();
                this.OnPropertyChanged("ListCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Listcode> _ListCodeId;
        partial void OnListCodeIdChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Listcode> value);
        partial void OnListCodeIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ProgressInvoicing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProgressInvoicing")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProgressInvoicing is required.")]
        public virtual bool ProgressInvoicing
        {
            get
            {
                return this._ProgressInvoicing;
            }
            set
            {
                this.OnProgressInvoicingChanging(value);
                this._ProgressInvoicing = value;
                this.OnProgressInvoicingChanged();
                this.OnPropertyChanged("ProgressInvoicing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private bool _ProgressInvoicing;
        partial void OnProgressInvoicingChanging(bool value);
        partial void OnProgressInvoicingChanged();
        /// <summary>
        /// There are no comments for Property FundingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FundingRule")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule> FundingRule
        {
            get
            {
                return this._FundingRule;
            }
            set
            {
                this.OnFundingRuleChanging(value);
                this._FundingRule = value;
                this.OnFundingRuleChanged();
                this.OnPropertyChanged("FundingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule> _FundingRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFundingRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectFundingRule> value);
        partial void OnFundingRuleChanged();
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
