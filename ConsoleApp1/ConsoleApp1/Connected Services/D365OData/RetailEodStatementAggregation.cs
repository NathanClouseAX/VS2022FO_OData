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
    /// There are no comments for RetailEodStatementAggregationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailEodStatementAggregationSingle")]
    public partial class RetailEodStatementAggregationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailEodStatementAggregation>
    {
        /// <summary>
        /// Initialize a new RetailEodStatementAggregationSingle object.
        /// </summary>
        public RetailEodStatementAggregationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailEodStatementAggregationSingle object.
        /// </summary>
        public RetailEodStatementAggregationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailEodStatementAggregationSingle object.
        /// </summary>
        public RetailEodStatementAggregationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailEodStatementAggregation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailEodStatementAggregation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// StatementId
    /// Aggregation
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StatementId", "Aggregation")]
    [global::Microsoft.OData.Client.EntitySet("RetailEodStatementAggregations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailEodStatementAggregation")]
    public partial class RetailEodStatementAggregation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailEodStatementAggregation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="statementId">Initial value of StatementId.</param>
        /// <param name="aggregation">Initial value of Aggregation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailEodStatementAggregation CreateRetailEodStatementAggregation(string dataAreaId, string statementId, long aggregation)
        {
            RetailEodStatementAggregation retailEodStatementAggregation = new RetailEodStatementAggregation();
            retailEodStatementAggregation.DataAreaId = dataAreaId;
            retailEodStatementAggregation.StatementId = statementId;
            retailEodStatementAggregation.Aggregation = aggregation;
            return retailEodStatementAggregation;
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
        /// There are no comments for Property StatementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StatementId is required.")]
        public virtual string StatementId
        {
            get
            {
                return this._StatementId;
            }
            set
            {
                this.OnStatementIdChanging(value);
                this._StatementId = value;
                this.OnStatementIdChanged();
                this.OnPropertyChanged("StatementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatementId;
        partial void OnStatementIdChanging(string value);
        partial void OnStatementIdChanged();
        /// <summary>
        /// There are no comments for Property Aggregation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Aggregation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Aggregation is required.")]
        public virtual long Aggregation
        {
            get
            {
                return this._Aggregation;
            }
            set
            {
                this.OnAggregationChanging(value);
                this._Aggregation = value;
                this.OnAggregationChanged();
                this.OnPropertyChanged("Aggregation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Aggregation;
        partial void OnAggregationChanging(long value);
        partial void OnAggregationChanged();
        /// <summary>
        /// There are no comments for Property InvoiceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceId")]
        public virtual string InvoiceId
        {
            get
            {
                return this._InvoiceId;
            }
            set
            {
                this.OnInvoiceIdChanging(value);
                this._InvoiceId = value;
                this.OnInvoiceIdChanged();
                this.OnPropertyChanged("InvoiceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceId;
        partial void OnInvoiceIdChanging(string value);
        partial void OnInvoiceIdChanged();
        /// <summary>
        /// There are no comments for Property SalesId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesId")]
        public virtual string SalesId
        {
            get
            {
                return this._SalesId;
            }
            set
            {
                this.OnSalesIdChanging(value);
                this._SalesId = value;
                this.OnSalesIdChanged();
                this.OnPropertyChanged("SalesId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesId;
        partial void OnSalesIdChanging(string value);
        partial void OnSalesIdChanged();
        /// <summary>
        /// There are no comments for Property StatementStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatementStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionPostingStatus> StatementStatus
        {
            get
            {
                return this._StatementStatus;
            }
            set
            {
                this.OnStatementStatusChanging(value);
                this._StatementStatus = value;
                this.OnStatementStatusChanged();
                this.OnPropertyChanged("StatementStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionPostingStatus> _StatementStatus;
        partial void OnStatementStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionPostingStatus> value);
        partial void OnStatementStatusChanged();
        /// <summary>
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StoreNumber")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property ErrorMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ErrorMessage")]
        public virtual string ErrorMessage
        {
            get
            {
                return this._ErrorMessage;
            }
            set
            {
                this.OnErrorMessageChanging(value);
                this._ErrorMessage = value;
                this.OnErrorMessageChanged();
                this.OnPropertyChanged("ErrorMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ErrorMessage;
        partial void OnErrorMessageChanging(string value);
        partial void OnErrorMessageChanged();
        /// <summary>
        /// There are no comments for Property AggregationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AggregationStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionAggregationHeaderPostingStatus> AggregationStatus
        {
            get
            {
                return this._AggregationStatus;
            }
            set
            {
                this.OnAggregationStatusChanging(value);
                this._AggregationStatus = value;
                this.OnAggregationStatusChanged();
                this.OnPropertyChanged("AggregationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionAggregationHeaderPostingStatus> _AggregationStatus;
        partial void OnAggregationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailEodTransactionAggregationHeaderPostingStatus> value);
        partial void OnAggregationStatusChanged();
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