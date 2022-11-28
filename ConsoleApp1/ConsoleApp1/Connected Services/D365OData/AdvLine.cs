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
    /// There are no comments for AdvLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdvLineSingle")]
    public partial class AdvLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdvLine>
    {
        /// <summary>
        /// Initialize a new AdvLineSingle object.
        /// </summary>
        public AdvLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdvLineSingle object.
        /// </summary>
        public AdvLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdvLineSingle object.
        /// </summary>
        public AdvLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdvLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AdvLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AdvanceId
    /// LineNum
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AdvanceId", "LineNum")]
    [global::Microsoft.OData.Client.EntitySet("AdvLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AdvLine")]
    public partial class AdvLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdvLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="advanceId">Initial value of AdvanceId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="confirmedAmountOfAdvanceReport">Initial value of ConfirmedAmountOfAdvanceReport.</param>
        /// <param name="disbursementDate">Initial value of DisbursementDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdvLine CreateAdvLine(string dataAreaId, 
                    string advanceId, 
                    decimal lineNum, 
                    decimal confirmedAmountOfAdvanceReport, 
                    global::System.DateTimeOffset disbursementDate, 
                    decimal amount)
        {
            AdvLine advLine = new AdvLine();
            advLine.DataAreaId = dataAreaId;
            advLine.AdvanceId = advanceId;
            advLine.LineNum = lineNum;
            advLine.ConfirmedAmountOfAdvanceReport = confirmedAmountOfAdvanceReport;
            advLine.DisbursementDate = disbursementDate;
            advLine.Amount = amount;
            return advLine;
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
        /// There are no comments for Property AdvanceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdvanceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdvanceId is required.")]
        public virtual string AdvanceId
        {
            get
            {
                return this._AdvanceId;
            }
            set
            {
                this.OnAdvanceIdChanging(value);
                this._AdvanceId = value;
                this.OnAdvanceIdChanged();
                this.OnPropertyChanged("AdvanceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdvanceId;
        partial void OnAdvanceIdChanging(string value);
        partial void OnAdvanceIdChanged();
        /// <summary>
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property ConfirmedAmountOfAdvanceReport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfirmedAmountOfAdvanceReport")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConfirmedAmountOfAdvanceReport is required.")]
        public virtual decimal ConfirmedAmountOfAdvanceReport
        {
            get
            {
                return this._ConfirmedAmountOfAdvanceReport;
            }
            set
            {
                this.OnConfirmedAmountOfAdvanceReportChanging(value);
                this._ConfirmedAmountOfAdvanceReport = value;
                this.OnConfirmedAmountOfAdvanceReportChanged();
                this.OnPropertyChanged("ConfirmedAmountOfAdvanceReport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ConfirmedAmountOfAdvanceReport;
        partial void OnConfirmedAmountOfAdvanceReportChanging(decimal value);
        partial void OnConfirmedAmountOfAdvanceReportChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property MainAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccount")]
        public virtual string MainAccount
        {
            get
            {
                return this._MainAccount;
            }
            set
            {
                this.OnMainAccountChanging(value);
                this._MainAccount = value;
                this.OnMainAccountChanged();
                this.OnPropertyChanged("MainAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccount;
        partial void OnMainAccountChanging(string value);
        partial void OnMainAccountChanged();
        /// <summary>
        /// There are no comments for Property DisbursementDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisbursementDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DisbursementDate is required.")]
        public virtual global::System.DateTimeOffset DisbursementDate
        {
            get
            {
                return this._DisbursementDate;
            }
            set
            {
                this.OnDisbursementDateChanging(value);
                this._DisbursementDate = value;
                this.OnDisbursementDateChanged();
                this.OnPropertyChanged("DisbursementDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DisbursementDate;
        partial void OnDisbursementDateChanging(global::System.DateTimeOffset value);
        partial void OnDisbursementDateChanged();
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
        /// There are no comments for Property OverRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverRate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OverRate
        {
            get
            {
                return this._OverRate;
            }
            set
            {
                this.OnOverRateChanging(value);
                this._OverRate = value;
                this.OnOverRateChanged();
                this.OnPropertyChanged("OverRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OverRate;
        partial void OnOverRateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOverRateChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
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
        /// There are no comments for Property DocumentName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentName")]
        public virtual string DocumentName
        {
            get
            {
                return this._DocumentName;
            }
            set
            {
                this.OnDocumentNameChanging(value);
                this._DocumentName = value;
                this.OnDocumentNameChanged();
                this.OnPropertyChanged("DocumentName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentName;
        partial void OnDocumentNameChanging(string value);
        partial void OnDocumentNameChanged();
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