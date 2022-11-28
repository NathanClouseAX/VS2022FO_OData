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
    /// There are no comments for TransactionCashManagementTransSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCashManagementTransSingle")]
    public partial class TransactionCashManagementTransSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionCashManagementTrans>
    {
        /// <summary>
        /// Initialize a new TransactionCashManagementTransSingle object.
        /// </summary>
        public TransactionCashManagementTransSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransactionCashManagementTransSingle object.
        /// </summary>
        public TransactionCashManagementTransSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransactionCashManagementTransSingle object.
        /// </summary>
        public TransactionCashManagementTransSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionCashManagementTrans> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransactionCashManagementTrans in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TransactionNumber
    /// OperatingUnitNumber
    /// Terminal
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TransactionNumber", "OperatingUnitNumber", "Terminal")]
    [global::Microsoft.OData.Client.EntitySet("TransactionCashManagementTrans")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionCashManagementTrans")]
    public partial class TransactionCashManagementTrans : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransactionCashManagementTrans object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="transactionNumber">Initial value of TransactionNumber.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransactionCashManagementTrans CreateTransactionCashManagementTrans(string dataAreaId, string transactionNumber, string operatingUnitNumber, string terminal)
        {
            TransactionCashManagementTrans transactionCashManagementTrans = new TransactionCashManagementTrans();
            transactionCashManagementTrans.DataAreaId = dataAreaId;
            transactionCashManagementTrans.TransactionNumber = transactionNumber;
            transactionCashManagementTrans.OperatingUnitNumber = operatingUnitNumber;
            transactionCashManagementTrans.Terminal = terminal;
            return transactionCashManagementTrans;
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
        /// There are no comments for Property TransactionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransactionNumber is required.")]
        public virtual string TransactionNumber
        {
            get
            {
                return this._TransactionNumber;
            }
            set
            {
                this.OnTransactionNumberChanging(value);
                this._TransactionNumber = value;
                this.OnTransactionNumberChanged();
                this.OnPropertyChanged("TransactionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionNumber;
        partial void OnTransactionNumberChanging(string value);
        partial void OnTransactionNumberChanged();
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
        /// There are no comments for Property FromSafe in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromSafe")]
        public virtual string FromSafe
        {
            get
            {
                return this._FromSafe;
            }
            set
            {
                this.OnFromSafeChanging(value);
                this._FromSafe = value;
                this.OnFromSafeChanged();
                this.OnPropertyChanged("FromSafe");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromSafe;
        partial void OnFromSafeChanging(string value);
        partial void OnFromSafeChanged();
        /// <summary>
        /// There are no comments for Property FromShiftTerminalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromShiftTerminalId")]
        public virtual string FromShiftTerminalId
        {
            get
            {
                return this._FromShiftTerminalId;
            }
            set
            {
                this.OnFromShiftTerminalIdChanging(value);
                this._FromShiftTerminalId = value;
                this.OnFromShiftTerminalIdChanged();
                this.OnPropertyChanged("FromShiftTerminalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromShiftTerminalId;
        partial void OnFromShiftTerminalIdChanging(string value);
        partial void OnFromShiftTerminalIdChanged();
        /// <summary>
        /// There are no comments for Property FromShiftId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromShiftId")]
        public virtual string FromShiftId
        {
            get
            {
                return this._FromShiftId;
            }
            set
            {
                this.OnFromShiftIdChanging(value);
                this._FromShiftId = value;
                this.OnFromShiftIdChanged();
                this.OnPropertyChanged("FromShiftId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromShiftId;
        partial void OnFromShiftIdChanging(string value);
        partial void OnFromShiftIdChanged();
        /// <summary>
        /// There are no comments for Property ToShiftId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToShiftId")]
        public virtual string ToShiftId
        {
            get
            {
                return this._ToShiftId;
            }
            set
            {
                this.OnToShiftIdChanging(value);
                this._ToShiftId = value;
                this.OnToShiftIdChanged();
                this.OnPropertyChanged("ToShiftId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToShiftId;
        partial void OnToShiftIdChanging(string value);
        partial void OnToShiftIdChanged();
        /// <summary>
        /// There are no comments for Property ToShiftTerminalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToShiftTerminalId")]
        public virtual string ToShiftTerminalId
        {
            get
            {
                return this._ToShiftTerminalId;
            }
            set
            {
                this.OnToShiftTerminalIdChanging(value);
                this._ToShiftTerminalId = value;
                this.OnToShiftTerminalIdChanged();
                this.OnPropertyChanged("ToShiftTerminalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToShiftTerminalId;
        partial void OnToShiftTerminalIdChanging(string value);
        partial void OnToShiftTerminalIdChanged();
        /// <summary>
        /// There are no comments for Property ToSafe in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToSafe")]
        public virtual string ToSafe
        {
            get
            {
                return this._ToSafe;
            }
            set
            {
                this.OnToSafeChanging(value);
                this._ToSafe = value;
                this.OnToSafeChanged();
                this.OnPropertyChanged("ToSafe");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToSafe;
        partial void OnToSafeChanging(string value);
        partial void OnToSafeChanged();
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
