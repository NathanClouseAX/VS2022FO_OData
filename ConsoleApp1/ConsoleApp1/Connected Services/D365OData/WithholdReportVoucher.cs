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
    /// There are no comments for WithholdReportVoucherSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdReportVoucherSingle")]
    public partial class WithholdReportVoucherSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdReportVoucher>
    {
        /// <summary>
        /// Initialize a new WithholdReportVoucherSingle object.
        /// </summary>
        public WithholdReportVoucherSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdReportVoucherSingle object.
        /// </summary>
        public WithholdReportVoucherSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdReportVoucherSingle object.
        /// </summary>
        public WithholdReportVoucherSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdReportVoucher> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WithholdReportVoucher in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Voucher
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Voucher")]
    [global::Microsoft.OData.Client.EntitySet("WithholdReportVouchers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdReportVoucher")]
    public partial class WithholdReportVoucher : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdReportVoucher object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="voucher">Initial value of Voucher.</param>
        /// <param name="referenceFromDate">Initial value of ReferenceFromDate.</param>
        /// <param name="referenceToDate">Initial value of ReferenceToDate.</param>
        /// <param name="date">Initial value of Date.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdReportVoucher CreateWithholdReportVoucher(string dataAreaId, string voucher, global::System.DateTimeOffset referenceFromDate, global::System.DateTimeOffset referenceToDate, global::System.DateTimeOffset date)
        {
            WithholdReportVoucher withholdReportVoucher = new WithholdReportVoucher();
            withholdReportVoucher.DataAreaId = dataAreaId;
            withholdReportVoucher.Voucher = voucher;
            withholdReportVoucher.ReferenceFromDate = referenceFromDate;
            withholdReportVoucher.ReferenceToDate = referenceToDate;
            withholdReportVoucher.Date = date;
            return withholdReportVoucher;
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
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Voucher")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Voucher is required.")]
        public virtual string Voucher
        {
            get
            {
                return this._Voucher;
            }
            set
            {
                this.OnVoucherChanging(value);
                this._Voucher = value;
                this.OnVoucherChanged();
                this.OnPropertyChanged("Voucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Voucher;
        partial void OnVoucherChanging(string value);
        partial void OnVoucherChanged();
        /// <summary>
        /// There are no comments for Property ReferenceFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceFromDate is required.")]
        public virtual global::System.DateTimeOffset ReferenceFromDate
        {
            get
            {
                return this._ReferenceFromDate;
            }
            set
            {
                this.OnReferenceFromDateChanging(value);
                this._ReferenceFromDate = value;
                this.OnReferenceFromDateChanged();
                this.OnPropertyChanged("ReferenceFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReferenceFromDate;
        partial void OnReferenceFromDateChanging(global::System.DateTimeOffset value);
        partial void OnReferenceFromDateChanged();
        /// <summary>
        /// There are no comments for Property ReferenceToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReferenceToDate is required.")]
        public virtual global::System.DateTimeOffset ReferenceToDate
        {
            get
            {
                return this._ReferenceToDate;
            }
            set
            {
                this.OnReferenceToDateChanging(value);
                this._ReferenceToDate = value;
                this.OnReferenceToDateChanged();
                this.OnPropertyChanged("ReferenceToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReferenceToDate;
        partial void OnReferenceToDateChanging(global::System.DateTimeOffset value);
        partial void OnReferenceToDateChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxPaymentVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdingTaxPaymentVersion")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRepVersion> WithholdingTaxPaymentVersion
        {
            get
            {
                return this._WithholdingTaxPaymentVersion;
            }
            set
            {
                this.OnWithholdingTaxPaymentVersionChanging(value);
                this._WithholdingTaxPaymentVersion = value;
                this.OnWithholdingTaxPaymentVersionChanged();
                this.OnPropertyChanged("WithholdingTaxPaymentVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRepVersion> _WithholdingTaxPaymentVersion;
        partial void OnWithholdingTaxPaymentVersionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxRepVersion> value);
        partial void OnWithholdingTaxPaymentVersionChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Date is required.")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property PostedWithholdingTaxCorrections in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostedWithholdingTaxCorrections")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PostedWithholdingTaxCorrections
        {
            get
            {
                return this._PostedWithholdingTaxCorrections;
            }
            set
            {
                this.OnPostedWithholdingTaxCorrectionsChanging(value);
                this._PostedWithholdingTaxCorrections = value;
                this.OnPostedWithholdingTaxCorrectionsChanged();
                this.OnPropertyChanged("PostedWithholdingTaxCorrections");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PostedWithholdingTaxCorrections;
        partial void OnPostedWithholdingTaxCorrectionsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPostedWithholdingTaxCorrectionsChanged();
        /// <summary>
        /// There are no comments for Property ReferenceSattlementPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceSattlementPeriod")]
        public virtual string ReferenceSattlementPeriod
        {
            get
            {
                return this._ReferenceSattlementPeriod;
            }
            set
            {
                this.OnReferenceSattlementPeriodChanging(value);
                this._ReferenceSattlementPeriod = value;
                this.OnReferenceSattlementPeriodChanged();
                this.OnPropertyChanged("ReferenceSattlementPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceSattlementPeriod;
        partial void OnReferenceSattlementPeriodChanging(string value);
        partial void OnReferenceSattlementPeriodChanged();
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
