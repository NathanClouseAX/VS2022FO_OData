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
    /// There are no comments for TransactionPostingDefinitionReceivableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionPostingDefinitionReceivableSingle")]
    public partial class TransactionPostingDefinitionReceivableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionPostingDefinitionReceivable>
    {
        /// <summary>
        /// Initialize a new TransactionPostingDefinitionReceivableSingle object.
        /// </summary>
        public TransactionPostingDefinitionReceivableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransactionPostingDefinitionReceivableSingle object.
        /// </summary>
        public TransactionPostingDefinitionReceivableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransactionPostingDefinitionReceivableSingle object.
        /// </summary>
        public TransactionPostingDefinitionReceivableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionPostingDefinitionReceivable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransactionPostingDefinitionReceivable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AttributeTypeBillingClassificationBillingCodeAll
    /// CustomerTransactionType
    /// BillingClassification
    /// BillingCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AttributeTypeBillingClassificationBillingCodeAll", "CustomerTransactionType", "BillingClassification", "BillingCode")]
    [global::Microsoft.OData.Client.EntitySet("TransactionPostingDefinitionReceivables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionPostingDefinitionReceivable")]
    public partial class TransactionPostingDefinitionReceivable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransactionPostingDefinitionReceivable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="billingClassification">Initial value of BillingClassification.</param>
        /// <param name="billingCode">Initial value of BillingCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransactionPostingDefinitionReceivable CreateTransactionPostingDefinitionReceivable(string dataAreaId, string billingClassification, string billingCode)
        {
            TransactionPostingDefinitionReceivable transactionPostingDefinitionReceivable = new TransactionPostingDefinitionReceivable();
            transactionPostingDefinitionReceivable.DataAreaId = dataAreaId;
            transactionPostingDefinitionReceivable.BillingClassification = billingClassification;
            transactionPostingDefinitionReceivable.BillingCode = billingCode;
            return transactionPostingDefinitionReceivable;
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
        /// There are no comments for Property AttributeTypeBillingClassificationBillingCodeAll in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeTypeBillingClassificationBillingCodeAll")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BillingCodeBillingClassAll> AttributeTypeBillingClassificationBillingCodeAll
        {
            get
            {
                return this._AttributeTypeBillingClassificationBillingCodeAll;
            }
            set
            {
                this.OnAttributeTypeBillingClassificationBillingCodeAllChanging(value);
                this._AttributeTypeBillingClassificationBillingCodeAll = value;
                this.OnAttributeTypeBillingClassificationBillingCodeAllChanged();
                this.OnPropertyChanged("AttributeTypeBillingClassificationBillingCodeAll");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BillingCodeBillingClassAll> _AttributeTypeBillingClassificationBillingCodeAll;
        partial void OnAttributeTypeBillingClassificationBillingCodeAllChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BillingCodeBillingClassAll> value);
        partial void OnAttributeTypeBillingClassificationBillingCodeAllChanged();
        /// <summary>
        /// There are no comments for Property CustomerTransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerTransactionType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomerTransactionType> CustomerTransactionType
        {
            get
            {
                return this._CustomerTransactionType;
            }
            set
            {
                this.OnCustomerTransactionTypeChanging(value);
                this._CustomerTransactionType = value;
                this.OnCustomerTransactionTypeChanged();
                this.OnPropertyChanged("CustomerTransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomerTransactionType> _CustomerTransactionType;
        partial void OnCustomerTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustomerTransactionType> value);
        partial void OnCustomerTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property BillingClassification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingClassification")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingClassification is required.")]
        public virtual string BillingClassification
        {
            get
            {
                return this._BillingClassification;
            }
            set
            {
                this.OnBillingClassificationChanging(value);
                this._BillingClassification = value;
                this.OnBillingClassificationChanged();
                this.OnPropertyChanged("BillingClassification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingClassification;
        partial void OnBillingClassificationChanging(string value);
        partial void OnBillingClassificationChanged();
        /// <summary>
        /// There are no comments for Property BillingCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillingCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BillingCode is required.")]
        public virtual string BillingCode
        {
            get
            {
                return this._BillingCode;
            }
            set
            {
                this.OnBillingCodeChanging(value);
                this._BillingCode = value;
                this.OnBillingCodeChanged();
                this.OnPropertyChanged("BillingCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingCode;
        partial void OnBillingCodeChanging(string value);
        partial void OnBillingCodeChanged();
        /// <summary>
        /// There are no comments for Property PostingDefinition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingDefinition")]
        public virtual string PostingDefinition
        {
            get
            {
                return this._PostingDefinition;
            }
            set
            {
                this.OnPostingDefinitionChanging(value);
                this._PostingDefinition = value;
                this.OnPostingDefinitionChanged();
                this.OnPropertyChanged("PostingDefinition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingDefinition;
        partial void OnPostingDefinitionChanging(string value);
        partial void OnPostingDefinitionChanged();
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
