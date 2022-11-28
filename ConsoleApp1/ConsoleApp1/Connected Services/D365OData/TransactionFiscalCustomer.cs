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
    /// There are no comments for TransactionFiscalCustomerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionFiscalCustomerSingle")]
    public partial class TransactionFiscalCustomerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionFiscalCustomer>
    {
        /// <summary>
        /// Initialize a new TransactionFiscalCustomerSingle object.
        /// </summary>
        public TransactionFiscalCustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransactionFiscalCustomerSingle object.
        /// </summary>
        public TransactionFiscalCustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransactionFiscalCustomerSingle object.
        /// </summary>
        public TransactionFiscalCustomerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionFiscalCustomer> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransactionFiscalCustomer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Store
    /// Terminal
    /// TransactionId
    /// OperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Store", "Terminal", "TransactionId", "OperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("TransactionFiscalCustomers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionFiscalCustomer")]
    public partial class TransactionFiscalCustomer : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransactionFiscalCustomer object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="store">Initial value of Store.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        /// <param name="transactionId">Initial value of TransactionId.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="replicationCounterFromOrigin">Initial value of ReplicationCounterFromOrigin.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransactionFiscalCustomer CreateTransactionFiscalCustomer(string dataAreaId, 
                    string store, 
                    string terminal, 
                    string transactionId, 
                    string operatingUnitNumber, 
                    int replicationCounterFromOrigin)
        {
            TransactionFiscalCustomer transactionFiscalCustomer = new TransactionFiscalCustomer();
            transactionFiscalCustomer.DataAreaId = dataAreaId;
            transactionFiscalCustomer.Store = store;
            transactionFiscalCustomer.Terminal = terminal;
            transactionFiscalCustomer.TransactionId = transactionId;
            transactionFiscalCustomer.OperatingUnitNumber = operatingUnitNumber;
            transactionFiscalCustomer.ReplicationCounterFromOrigin = replicationCounterFromOrigin;
            return transactionFiscalCustomer;
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
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperatingUnitNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperatingUnitNumber is required.")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property SerializedData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SerializedData")]
        public virtual string SerializedData
        {
            get
            {
                return this._SerializedData;
            }
            set
            {
                this.OnSerializedDataChanging(value);
                this._SerializedData = value;
                this.OnSerializedDataChanged();
                this.OnPropertyChanged("SerializedData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SerializedData;
        partial void OnSerializedDataChanging(string value);
        partial void OnSerializedDataChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnit_PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OMOperatingUnit_PartyNumber")]
        public virtual string OMOperatingUnit_PartyNumber
        {
            get
            {
                return this._OMOperatingUnit_PartyNumber;
            }
            set
            {
                this.OnOMOperatingUnit_PartyNumberChanging(value);
                this._OMOperatingUnit_PartyNumber = value;
                this.OnOMOperatingUnit_PartyNumberChanged();
                this.OnPropertyChanged("OMOperatingUnit_PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OMOperatingUnit_PartyNumber;
        partial void OnOMOperatingUnit_PartyNumberChanging(string value);
        partial void OnOMOperatingUnit_PartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ReplicationCounterFromOrigin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReplicationCounterFromOrigin")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReplicationCounterFromOrigin is required.")]
        public virtual int ReplicationCounterFromOrigin
        {
            get
            {
                return this._ReplicationCounterFromOrigin;
            }
            set
            {
                this.OnReplicationCounterFromOriginChanging(value);
                this._ReplicationCounterFromOrigin = value;
                this.OnReplicationCounterFromOriginChanged();
                this.OnPropertyChanged("ReplicationCounterFromOrigin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReplicationCounterFromOrigin;
        partial void OnReplicationCounterFromOriginChanging(int value);
        partial void OnReplicationCounterFromOriginChanged();
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