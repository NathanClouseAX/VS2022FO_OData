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
    /// There are no comments for LedgerJournalCostLinesVoyagesTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalCostLinesVoyagesTableSingle")]
    public partial class LedgerJournalCostLinesVoyagesTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalCostLinesVoyagesTable>
    {
        /// <summary>
        /// Initialize a new LedgerJournalCostLinesVoyagesTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesVoyagesTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerJournalCostLinesVoyagesTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesVoyagesTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerJournalCostLinesVoyagesTableSingle object.
        /// </summary>
        public LedgerJournalCostLinesVoyagesTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalCostLinesVoyagesTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LedgerJournalCostLinesVoyagesTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// JournalNum
    /// JournalLineNumber
    /// ShipId
    /// CostTransactionLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalNum", "JournalLineNumber", "ShipId", "CostTransactionLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("LedgerJournalCostLinesVoyagesTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerJournalCostLinesVoyagesTable")]
    public partial class LedgerJournalCostLinesVoyagesTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerJournalCostLinesVoyagesTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="journalNum">Initial value of JournalNum.</param>
        /// <param name="journalLineNumber">Initial value of JournalLineNumber.</param>
        /// <param name="shipId">Initial value of ShipId.</param>
        /// <param name="costTransactionLineNumber">Initial value of CostTransactionLineNumber.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerJournalCostLinesVoyagesTable CreateLedgerJournalCostLinesVoyagesTable(string dataAreaId, 
                    string journalNum, 
                    decimal journalLineNumber, 
                    string shipId, 
                    decimal costTransactionLineNumber, 
                    decimal amount)
        {
            LedgerJournalCostLinesVoyagesTable ledgerJournalCostLinesVoyagesTable = new LedgerJournalCostLinesVoyagesTable();
            ledgerJournalCostLinesVoyagesTable.DataAreaId = dataAreaId;
            ledgerJournalCostLinesVoyagesTable.JournalNum = journalNum;
            ledgerJournalCostLinesVoyagesTable.JournalLineNumber = journalLineNumber;
            ledgerJournalCostLinesVoyagesTable.ShipId = shipId;
            ledgerJournalCostLinesVoyagesTable.CostTransactionLineNumber = costTransactionLineNumber;
            ledgerJournalCostLinesVoyagesTable.Amount = amount;
            return ledgerJournalCostLinesVoyagesTable;
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
        /// There are no comments for Property JournalNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalNum is required.")]
        public virtual string JournalNum
        {
            get
            {
                return this._JournalNum;
            }
            set
            {
                this.OnJournalNumChanging(value);
                this._JournalNum = value;
                this.OnJournalNumChanged();
                this.OnPropertyChanged("JournalNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalNum;
        partial void OnJournalNumChanging(string value);
        partial void OnJournalNumChanged();
        /// <summary>
        /// There are no comments for Property JournalLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalLineNumber is required.")]
        public virtual decimal JournalLineNumber
        {
            get
            {
                return this._JournalLineNumber;
            }
            set
            {
                this.OnJournalLineNumberChanging(value);
                this._JournalLineNumber = value;
                this.OnJournalLineNumberChanged();
                this.OnPropertyChanged("JournalLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalLineNumber;
        partial void OnJournalLineNumberChanging(decimal value);
        partial void OnJournalLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ShipId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShipId is required.")]
        public virtual string ShipId
        {
            get
            {
                return this._ShipId;
            }
            set
            {
                this.OnShipIdChanging(value);
                this._ShipId = value;
                this.OnShipIdChanged();
                this.OnPropertyChanged("ShipId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipId;
        partial void OnShipIdChanging(string value);
        partial void OnShipIdChanged();
        /// <summary>
        /// There are no comments for Property CostTransactionLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostTransactionLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostTransactionLineNumber is required.")]
        public virtual decimal CostTransactionLineNumber
        {
            get
            {
                return this._CostTransactionLineNumber;
            }
            set
            {
                this.OnCostTransactionLineNumberChanging(value);
                this._CostTransactionLineNumber = value;
                this.OnCostTransactionLineNumberChanged();
                this.OnPropertyChanged("CostTransactionLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostTransactionLineNumber;
        partial void OnCostTransactionLineNumberChanging(decimal value);
        partial void OnCostTransactionLineNumberChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
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
