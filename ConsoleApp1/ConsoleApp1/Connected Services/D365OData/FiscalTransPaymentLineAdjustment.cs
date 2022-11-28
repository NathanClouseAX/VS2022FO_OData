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
    /// There are no comments for FiscalTransPaymentLineAdjustmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalTransPaymentLineAdjustmentSingle")]
    public partial class FiscalTransPaymentLineAdjustmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalTransPaymentLineAdjustment>
    {
        /// <summary>
        /// Initialize a new FiscalTransPaymentLineAdjustmentSingle object.
        /// </summary>
        public FiscalTransPaymentLineAdjustmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalTransPaymentLineAdjustmentSingle object.
        /// </summary>
        public FiscalTransPaymentLineAdjustmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalTransPaymentLineAdjustmentSingle object.
        /// </summary>
        public FiscalTransPaymentLineAdjustmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalTransPaymentLineAdjustment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalTransPaymentLineAdjustment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Store
    /// Terminal
    /// TransactionId
    /// FiscalTransactionLineNumber
    /// FiscalTransactionRecordGuid
    /// PaymentTransactionLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Store", "Terminal", "TransactionId", "FiscalTransactionLineNumber", "FiscalTransactionRecordGuid", "PaymentTransactionLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("FiscalTransPaymentLineAdjustments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalTransPaymentLineAdjustment")]
    public partial class FiscalTransPaymentLineAdjustment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalTransPaymentLineAdjustment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="store">Initial value of Store.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="fiscalTransactionLineNumber">Initial value of FiscalTransactionLineNumber.</param>
        /// <param name="fiscalTransactionRecordGuid">Initial value of FiscalTransactionRecordGuid.</param>
        /// <param name="paymentTransactionLineNumber">Initial value of PaymentTransactionLineNumber.</param>
        /// <param name="adjustmentAmount">Initial value of AdjustmentAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalTransPaymentLineAdjustment CreateFiscalTransPaymentLineAdjustment(string dataAreaId, 
                    string store, 
                    string terminal, 
                    string transactionId, 
                    decimal fiscalTransactionLineNumber, 
                    global::System.Guid fiscalTransactionRecordGuid, 
                    decimal paymentTransactionLineNumber, 
                    decimal adjustmentAmount)
        {
            FiscalTransPaymentLineAdjustment fiscalTransPaymentLineAdjustment = new FiscalTransPaymentLineAdjustment();
            fiscalTransPaymentLineAdjustment.DataAreaId = dataAreaId;
            fiscalTransPaymentLineAdjustment.Store = store;
            fiscalTransPaymentLineAdjustment.Terminal = terminal;
            fiscalTransPaymentLineAdjustment.TransactionId = transactionId;
            fiscalTransPaymentLineAdjustment.FiscalTransactionLineNumber = fiscalTransactionLineNumber;
            fiscalTransPaymentLineAdjustment.FiscalTransactionRecordGuid = fiscalTransactionRecordGuid;
            fiscalTransPaymentLineAdjustment.PaymentTransactionLineNumber = paymentTransactionLineNumber;
            fiscalTransPaymentLineAdjustment.AdjustmentAmount = adjustmentAmount;
            return fiscalTransPaymentLineAdjustment;
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
        /// There are no comments for Property Store in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Store")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Store is required.")]
        public virtual string Store
        {
            get
            {
                return this._Store;
            }
            set
            {
                this.OnStoreChanging(value);
                this._Store = value;
                this.OnStoreChanged();
                this.OnPropertyChanged("Store");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Store;
        partial void OnStoreChanging(string value);
        partial void OnStoreChanged();
        /// <summary>
        /// There are no comments for Property Terminal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Terminal")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Terminal is required.")]
        public virtual string Terminal
        {
            get
            {
                return this._Terminal;
            }
            set
            {
                this.OnTerminalChanging(value);
                this._Terminal = value;
                this.OnTerminalChanged();
                this.OnPropertyChanged("Terminal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Terminal;
        partial void OnTerminalChanging(string value);
        partial void OnTerminalChanged();
        /// <summary>
        /// There are no comments for Property TransactionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionId is required.")]
        public virtual string TransactionId
        {
            get
            {
                return this._TransactionId;
            }
            set
            {
                this.OnTransactionIdChanging(value);
                this._TransactionId = value;
                this.OnTransactionIdChanged();
                this.OnPropertyChanged("TransactionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionId;
        partial void OnTransactionIdChanging(string value);
        partial void OnTransactionIdChanged();
        /// <summary>
        /// There are no comments for Property FiscalTransactionLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalTransactionLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalTransactionLineNumber is required.")]
        public virtual decimal FiscalTransactionLineNumber
        {
            get
            {
                return this._FiscalTransactionLineNumber;
            }
            set
            {
                this.OnFiscalTransactionLineNumberChanging(value);
                this._FiscalTransactionLineNumber = value;
                this.OnFiscalTransactionLineNumberChanged();
                this.OnPropertyChanged("FiscalTransactionLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FiscalTransactionLineNumber;
        partial void OnFiscalTransactionLineNumberChanging(decimal value);
        partial void OnFiscalTransactionLineNumberChanged();
        /// <summary>
        /// There are no comments for Property FiscalTransactionRecordGuid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalTransactionRecordGuid")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalTransactionRecordGuid is required.")]
        public virtual global::System.Guid FiscalTransactionRecordGuid
        {
            get
            {
                return this._FiscalTransactionRecordGuid;
            }
            set
            {
                this.OnFiscalTransactionRecordGuidChanging(value);
                this._FiscalTransactionRecordGuid = value;
                this.OnFiscalTransactionRecordGuidChanged();
                this.OnPropertyChanged("FiscalTransactionRecordGuid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _FiscalTransactionRecordGuid;
        partial void OnFiscalTransactionRecordGuidChanging(global::System.Guid value);
        partial void OnFiscalTransactionRecordGuidChanged();
        /// <summary>
        /// There are no comments for Property PaymentTransactionLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTransactionLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PaymentTransactionLineNumber is required.")]
        public virtual decimal PaymentTransactionLineNumber
        {
            get
            {
                return this._PaymentTransactionLineNumber;
            }
            set
            {
                this.OnPaymentTransactionLineNumberChanging(value);
                this._PaymentTransactionLineNumber = value;
                this.OnPaymentTransactionLineNumberChanged();
                this.OnPropertyChanged("PaymentTransactionLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaymentTransactionLineNumber;
        partial void OnPaymentTransactionLineNumberChanging(decimal value);
        partial void OnPaymentTransactionLineNumberChanged();
        /// <summary>
        /// There are no comments for Property AdjustmentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustmentAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdjustmentAmount is required.")]
        public virtual decimal AdjustmentAmount
        {
            get
            {
                return this._AdjustmentAmount;
            }
            set
            {
                this.OnAdjustmentAmountChanging(value);
                this._AdjustmentAmount = value;
                this.OnAdjustmentAmountChanged();
                this.OnPropertyChanged("AdjustmentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AdjustmentAmount;
        partial void OnAdjustmentAmountChanging(decimal value);
        partial void OnAdjustmentAmountChanged();
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
