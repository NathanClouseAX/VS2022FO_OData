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
    /// There are no comments for ReservationLineAgreementLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReservationLineAgreementLineSingle")]
    public partial class ReservationLineAgreementLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReservationLineAgreementLine>
    {
        /// <summary>
        /// Initialize a new ReservationLineAgreementLineSingle object.
        /// </summary>
        public ReservationLineAgreementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReservationLineAgreementLineSingle object.
        /// </summary>
        public ReservationLineAgreementLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReservationLineAgreementLineSingle object.
        /// </summary>
        public ReservationLineAgreementLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReservationLineAgreementLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ReservationLineAgreementLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PurchaseNumberSequence
    /// AgreementLineNumber
    /// BudgetReservationDocumentNumber
    /// BudgetReservationLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseNumberSequence", "AgreementLineNumber", "BudgetReservationDocumentNumber", "BudgetReservationLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("ReservationLineAgreementLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReservationLineAgreementLine")]
    public partial class ReservationLineAgreementLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReservationLineAgreementLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="purchaseNumberSequence">Initial value of PurchaseNumberSequence.</param>
        /// <param name="agreementLineNumber">Initial value of AgreementLineNumber.</param>
        /// <param name="budgetReservationDocumentNumber">Initial value of BudgetReservationDocumentNumber.</param>
        /// <param name="budgetReservationLineNumber">Initial value of BudgetReservationLineNumber.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReservationLineAgreementLine CreateReservationLineAgreementLine(string dataAreaId, 
                    string purchaseNumberSequence, 
                    decimal agreementLineNumber, 
                    string budgetReservationDocumentNumber, 
                    int budgetReservationLineNumber, 
                    global::System.DateTimeOffset expirationDate, 
                    global::System.DateTimeOffset effectiveDate)
        {
            ReservationLineAgreementLine reservationLineAgreementLine = new ReservationLineAgreementLine();
            reservationLineAgreementLine.DataAreaId = dataAreaId;
            reservationLineAgreementLine.PurchaseNumberSequence = purchaseNumberSequence;
            reservationLineAgreementLine.AgreementLineNumber = agreementLineNumber;
            reservationLineAgreementLine.BudgetReservationDocumentNumber = budgetReservationDocumentNumber;
            reservationLineAgreementLine.BudgetReservationLineNumber = budgetReservationLineNumber;
            reservationLineAgreementLine.ExpirationDate = expirationDate;
            reservationLineAgreementLine.EffectiveDate = effectiveDate;
            return reservationLineAgreementLine;
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
        /// There are no comments for Property PurchaseNumberSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseNumberSequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseNumberSequence is required.")]
        public virtual string PurchaseNumberSequence
        {
            get
            {
                return this._PurchaseNumberSequence;
            }
            set
            {
                this.OnPurchaseNumberSequenceChanging(value);
                this._PurchaseNumberSequence = value;
                this.OnPurchaseNumberSequenceChanged();
                this.OnPropertyChanged("PurchaseNumberSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseNumberSequence;
        partial void OnPurchaseNumberSequenceChanging(string value);
        partial void OnPurchaseNumberSequenceChanged();
        /// <summary>
        /// There are no comments for Property AgreementLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgreementLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AgreementLineNumber is required.")]
        public virtual decimal AgreementLineNumber
        {
            get
            {
                return this._AgreementLineNumber;
            }
            set
            {
                this.OnAgreementLineNumberChanging(value);
                this._AgreementLineNumber = value;
                this.OnAgreementLineNumberChanged();
                this.OnPropertyChanged("AgreementLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AgreementLineNumber;
        partial void OnAgreementLineNumberChanging(decimal value);
        partial void OnAgreementLineNumberChanged();
        /// <summary>
        /// There are no comments for Property BudgetReservationDocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetReservationDocumentNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetReservationDocumentNumber is required.")]
        public virtual string BudgetReservationDocumentNumber
        {
            get
            {
                return this._BudgetReservationDocumentNumber;
            }
            set
            {
                this.OnBudgetReservationDocumentNumberChanging(value);
                this._BudgetReservationDocumentNumber = value;
                this.OnBudgetReservationDocumentNumberChanged();
                this.OnPropertyChanged("BudgetReservationDocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetReservationDocumentNumber;
        partial void OnBudgetReservationDocumentNumberChanging(string value);
        partial void OnBudgetReservationDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property BudgetReservationLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetReservationLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BudgetReservationLineNumber is required.")]
        public virtual int BudgetReservationLineNumber
        {
            get
            {
                return this._BudgetReservationLineNumber;
            }
            set
            {
                this.OnBudgetReservationLineNumberChanging(value);
                this._BudgetReservationLineNumber = value;
                this.OnBudgetReservationLineNumberChanged();
                this.OnPropertyChanged("BudgetReservationLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _BudgetReservationLineNumber;
        partial void OnBudgetReservationLineNumberChanging(int value);
        partial void OnBudgetReservationLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpirationDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpirationDate is required.")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property BuyingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BuyingLegalEntityId")]
        public virtual string BuyingLegalEntityId
        {
            get
            {
                return this._BuyingLegalEntityId;
            }
            set
            {
                this.OnBuyingLegalEntityIdChanging(value);
                this._BuyingLegalEntityId = value;
                this.OnBuyingLegalEntityIdChanged();
                this.OnPropertyChanged("BuyingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BuyingLegalEntityId;
        partial void OnBuyingLegalEntityIdChanging(string value);
        partial void OnBuyingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveDate is required.")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
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
