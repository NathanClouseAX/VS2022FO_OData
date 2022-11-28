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
    /// There are no comments for IntentLetterSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterSingle")]
    public partial class IntentLetterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IntentLetter>
    {
        /// <summary>
        /// Initialize a new IntentLetterSingle object.
        /// </summary>
        public IntentLetterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IntentLetterSingle object.
        /// </summary>
        public IntentLetterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IntentLetterSingle object.
        /// </summary>
        public IntentLetterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IntentLetter> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for IntentLetter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// IntentLetterId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "IntentLetterId")]
    [global::Microsoft.OData.Client.EntitySet("IntentLetters")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetter")]
    public partial class IntentLetter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IntentLetter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="intentLetterId">Initial value of IntentLetterId.</param>
        /// <param name="intentLetterYear">Initial value of IntentLetterYear.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="intentLetterAmountMST">Initial value of IntentLetterAmountMST.</param>
        /// <param name="intentLetterDate">Initial value of IntentLetterDate.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="closedDate">Initial value of ClosedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IntentLetter CreateIntentLetter(string dataAreaId, 
                    string intentLetterId, 
                    int intentLetterYear, 
                    global::System.DateTimeOffset toDate, 
                    decimal intentLetterAmountMST, 
                    global::System.DateTimeOffset intentLetterDate, 
                    global::System.DateTimeOffset fromDate, 
                    global::System.DateTimeOffset closedDate)
        {
            IntentLetter intentLetter = new IntentLetter();
            intentLetter.DataAreaId = dataAreaId;
            intentLetter.IntentLetterId = intentLetterId;
            intentLetter.IntentLetterYear = intentLetterYear;
            intentLetter.ToDate = toDate;
            intentLetter.IntentLetterAmountMST = intentLetterAmountMST;
            intentLetter.IntentLetterDate = intentLetterDate;
            intentLetter.FromDate = fromDate;
            intentLetter.ClosedDate = closedDate;
            return intentLetter;
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
        /// There are no comments for Property IntentLetterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntentLetterId is required.")]
        public virtual string IntentLetterId
        {
            get
            {
                return this._IntentLetterId;
            }
            set
            {
                this.OnIntentLetterIdChanging(value);
                this._IntentLetterId = value;
                this.OnIntentLetterIdChanged();
                this.OnPropertyChanged("IntentLetterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntentLetterId;
        partial void OnIntentLetterIdChanging(string value);
        partial void OnIntentLetterIdChanged();
        /// <summary>
        /// There are no comments for Property IntentLetterYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterYear")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntentLetterYear is required.")]
        public virtual int IntentLetterYear
        {
            get
            {
                return this._IntentLetterYear;
            }
            set
            {
                this.OnIntentLetterYearChanging(value);
                this._IntentLetterYear = value;
                this.OnIntentLetterYearChanged();
                this.OnPropertyChanged("IntentLetterYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntentLetterYear;
        partial void OnIntentLetterYearChanging(int value);
        partial void OnIntentLetterYearChanged();
        /// <summary>
        /// There are no comments for Property Protocol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Protocol")]
        public virtual string Protocol
        {
            get
            {
                return this._Protocol;
            }
            set
            {
                this.OnProtocolChanging(value);
                this._Protocol = value;
                this.OnProtocolChanged();
                this.OnPropertyChanged("Protocol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Protocol;
        partial void OnProtocolChanging(string value);
        partial void OnProtocolChanged();
        /// <summary>
        /// There are no comments for Property IntentLetterNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterNotes")]
        public virtual string IntentLetterNotes
        {
            get
            {
                return this._IntentLetterNotes;
            }
            set
            {
                this.OnIntentLetterNotesChanging(value);
                this._IntentLetterNotes = value;
                this.OnIntentLetterNotesChanged();
                this.OnPropertyChanged("IntentLetterNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntentLetterNotes;
        partial void OnIntentLetterNotesChanging(string value);
        partial void OnIntentLetterNotesChanged();
        /// <summary>
        /// There are no comments for Property ClosingNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClosingNotes")]
        public virtual string ClosingNotes
        {
            get
            {
                return this._ClosingNotes;
            }
            set
            {
                this.OnClosingNotesChanging(value);
                this._ClosingNotes = value;
                this.OnClosingNotesChanged();
                this.OnPropertyChanged("ClosingNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClosingNotes;
        partial void OnClosingNotesChanging(string value);
        partial void OnClosingNotesChanged();
        /// <summary>
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToDate is required.")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
        /// <summary>
        /// There are no comments for Property VendName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendName")]
        public virtual string VendName
        {
            get
            {
                return this._VendName;
            }
            set
            {
                this.OnVendNameChanging(value);
                this._VendName = value;
                this.OnVendNameChanged();
                this.OnPropertyChanged("VendName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendName;
        partial void OnVendNameChanging(string value);
        partial void OnVendNameChanged();
        /// <summary>
        /// There are no comments for Property IntentLetterAmountMST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterAmountMST")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntentLetterAmountMST is required.")]
        public virtual decimal IntentLetterAmountMST
        {
            get
            {
                return this._IntentLetterAmountMST;
            }
            set
            {
                this.OnIntentLetterAmountMSTChanging(value);
                this._IntentLetterAmountMST = value;
                this.OnIntentLetterAmountMSTChanged();
                this.OnPropertyChanged("IntentLetterAmountMST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _IntentLetterAmountMST;
        partial void OnIntentLetterAmountMSTChanging(decimal value);
        partial void OnIntentLetterAmountMSTChanged();
        /// <summary>
        /// There are no comments for Property IntentLetterDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntentLetterDate is required.")]
        public virtual global::System.DateTimeOffset IntentLetterDate
        {
            get
            {
                return this._IntentLetterDate;
            }
            set
            {
                this.OnIntentLetterDateChanging(value);
                this._IntentLetterDate = value;
                this.OnIntentLetterDateChanged();
                this.OnPropertyChanged("IntentLetterDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _IntentLetterDate;
        partial void OnIntentLetterDateChanging(global::System.DateTimeOffset value);
        partial void OnIntentLetterDateChanged();
        /// <summary>
        /// There are no comments for Property VendAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendAccount")]
        public virtual string VendAccount
        {
            get
            {
                return this._VendAccount;
            }
            set
            {
                this.OnVendAccountChanging(value);
                this._VendAccount = value;
                this.OnVendAccountChanged();
                this.OnPropertyChanged("VendAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendAccount;
        partial void OnVendAccountChanging(string value);
        partial void OnVendAccountChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromDate is required.")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property IntentLetterType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntentLetterType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterType_IT> IntentLetterType
        {
            get
            {
                return this._IntentLetterType;
            }
            set
            {
                this.OnIntentLetterTypeChanging(value);
                this._IntentLetterType = value;
                this.OnIntentLetterTypeChanged();
                this.OnPropertyChanged("IntentLetterType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterType_IT> _IntentLetterType;
        partial void OnIntentLetterTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterType_IT> value);
        partial void OnIntentLetterTypeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterStatus_IT> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterStatus_IT> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterStatus_IT> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ClosedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClosedDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ClosedDate is required.")]
        public virtual global::System.DateTimeOffset ClosedDate
        {
            get
            {
                return this._ClosedDate;
            }
            set
            {
                this.OnClosedDateChanging(value);
                this._ClosedDate = value;
                this.OnClosedDateChanged();
                this.OnPropertyChanged("ClosedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ClosedDate;
        partial void OnClosedDateChanging(global::System.DateTimeOffset value);
        partial void OnClosedDateChanged();
        /// <summary>
        /// There are no comments for Property PurchaseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterPurchaseType_IT> PurchaseType
        {
            get
            {
                return this._PurchaseType;
            }
            set
            {
                this.OnPurchaseTypeChanging(value);
                this._PurchaseType = value;
                this.OnPurchaseTypeChanged();
                this.OnPropertyChanged("PurchaseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterPurchaseType_IT> _PurchaseType;
        partial void OnPurchaseTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IntentLetterPurchaseType_IT> value);
        partial void OnPurchaseTypeChanged();
        /// <summary>
        /// There are no comments for Property ReportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportId")]
        public virtual string ReportId
        {
            get
            {
                return this._ReportId;
            }
            set
            {
                this.OnReportIdChanging(value);
                this._ReportId = value;
                this.OnReportIdChanged();
                this.OnPropertyChanged("ReportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportId;
        partial void OnReportIdChanging(string value);
        partial void OnReportIdChanged();
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