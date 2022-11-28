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
    /// There are no comments for TransactionChargeTaxMeasureSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionChargeTaxMeasureSingle")]
    public partial class TransactionChargeTaxMeasureSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionChargeTaxMeasure>
    {
        /// <summary>
        /// Initialize a new TransactionChargeTaxMeasureSingle object.
        /// </summary>
        public TransactionChargeTaxMeasureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransactionChargeTaxMeasureSingle object.
        /// </summary>
        public TransactionChargeTaxMeasureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransactionChargeTaxMeasureSingle object.
        /// </summary>
        public TransactionChargeTaxMeasureSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransactionChargeTaxMeasure> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransactionChargeTaxMeasure in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Terminal
    /// TransactionNumber
    /// SaleLineNum
    /// MarkupLineNum
    /// Path
    /// OperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Terminal", "TransactionNumber", "SaleLineNum", "MarkupLineNum", "Path", "OperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("TransactionChargeTaxMeasures")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionChargeTaxMeasure")]
    public partial class TransactionChargeTaxMeasure : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransactionChargeTaxMeasure object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="terminal">Initial value of Terminal.</param>
        /// <param name="transactionNumber">Initial value of TransactionNumber.</param>
        /// <param name="saleLineNum">Initial value of SaleLineNum.</param>
        /// <param name="markupLineNum">Initial value of MarkupLineNum.</param>
        /// <param name="path">Initial value of Path.</param>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransactionChargeTaxMeasure CreateTransactionChargeTaxMeasure(string dataAreaId, 
                    string terminal, 
                    string transactionNumber, 
                    decimal saleLineNum, 
                    decimal markupLineNum, 
                    string path, 
                    string operatingUnitNumber, 
                    decimal value)
        {
            TransactionChargeTaxMeasure transactionChargeTaxMeasure = new TransactionChargeTaxMeasure();
            transactionChargeTaxMeasure.DataAreaId = dataAreaId;
            transactionChargeTaxMeasure.Terminal = terminal;
            transactionChargeTaxMeasure.TransactionNumber = transactionNumber;
            transactionChargeTaxMeasure.SaleLineNum = saleLineNum;
            transactionChargeTaxMeasure.MarkupLineNum = markupLineNum;
            transactionChargeTaxMeasure.Path = path;
            transactionChargeTaxMeasure.OperatingUnitNumber = operatingUnitNumber;
            transactionChargeTaxMeasure.Value = value;
            return transactionChargeTaxMeasure;
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
        /// There are no comments for Property SaleLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SaleLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SaleLineNum is required.")]
        public virtual decimal SaleLineNum
        {
            get
            {
                return this._SaleLineNum;
            }
            set
            {
                this.OnSaleLineNumChanging(value);
                this._SaleLineNum = value;
                this.OnSaleLineNumChanged();
                this.OnPropertyChanged("SaleLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SaleLineNum;
        partial void OnSaleLineNumChanging(decimal value);
        partial void OnSaleLineNumChanged();
        /// <summary>
        /// There are no comments for Property MarkupLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MarkupLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MarkupLineNum is required.")]
        public virtual decimal MarkupLineNum
        {
            get
            {
                return this._MarkupLineNum;
            }
            set
            {
                this.OnMarkupLineNumChanging(value);
                this._MarkupLineNum = value;
                this.OnMarkupLineNumChanged();
                this.OnPropertyChanged("MarkupLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MarkupLineNum;
        partial void OnMarkupLineNumChanging(decimal value);
        partial void OnMarkupLineNumChanged();
        /// <summary>
        /// There are no comments for Property Path in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Path")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Path is required.")]
        public virtual string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                this.OnPathChanging(value);
                this._Path = value;
                this.OnPathChanged();
                this.OnPropertyChanged("Path");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Path;
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
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
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Value is required.")]
        public virtual decimal Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Value;
        partial void OnValueChanging(decimal value);
        partial void OnValueChanged();
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
