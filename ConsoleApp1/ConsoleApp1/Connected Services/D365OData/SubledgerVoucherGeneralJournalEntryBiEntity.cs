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
    /// There are no comments for SubledgerVoucherGeneralJournalEntryBiEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerVoucherGeneralJournalEntryBiEntitySingle")]
    public partial class SubledgerVoucherGeneralJournalEntryBiEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubledgerVoucherGeneralJournalEntryBiEntity>
    {
        /// <summary>
        /// Initialize a new SubledgerVoucherGeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public SubledgerVoucherGeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubledgerVoucherGeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public SubledgerVoucherGeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubledgerVoucherGeneralJournalEntryBiEntitySingle object.
        /// </summary>
        public SubledgerVoucherGeneralJournalEntryBiEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubledgerVoucherGeneralJournalEntryBiEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubledgerVoucherGeneralJournalEntryBiEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RecordId")]
    [global::Microsoft.OData.Client.EntitySet("SubledgerVoucherGeneralJournalEntryBiEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerVoucherGeneralJournalEntryBiEntity")]
    public partial class SubledgerVoucherGeneralJournalEntryBiEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubledgerVoucherGeneralJournalEntryBiEntity object.
        /// </summary>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="recordVersion">Initial value of RecordVersion.</param>
        /// <param name="generalJournalEntry">Initial value of GeneralJournalEntry.</param>
        /// <param name="transferId">Initial value of TransferId.</param>
        /// <param name="sysRowVersionNumber">Initial value of SysRowVersionNumber.</param>
        /// <param name="subledgerJournalEntry">Initial value of SubledgerJournalEntry.</param>
        /// <param name="partitionId">Initial value of PartitionId.</param>
        /// <param name="accountingDate">Initial value of AccountingDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubledgerVoucherGeneralJournalEntryBiEntity CreateSubledgerVoucherGeneralJournalEntryBiEntity(long recordId, 
                    int recordVersion, 
                    long generalJournalEntry, 
                    long transferId, 
                    long sysRowVersionNumber, 
                    long subledgerJournalEntry, 
                    long partitionId, 
                    global::System.DateTimeOffset accountingDate)
        {
            SubledgerVoucherGeneralJournalEntryBiEntity subledgerVoucherGeneralJournalEntryBiEntity = new SubledgerVoucherGeneralJournalEntryBiEntity();
            subledgerVoucherGeneralJournalEntryBiEntity.RecordId = recordId;
            subledgerVoucherGeneralJournalEntryBiEntity.RecordVersion = recordVersion;
            subledgerVoucherGeneralJournalEntryBiEntity.GeneralJournalEntry = generalJournalEntry;
            subledgerVoucherGeneralJournalEntryBiEntity.TransferId = transferId;
            subledgerVoucherGeneralJournalEntryBiEntity.SysRowVersionNumber = sysRowVersionNumber;
            subledgerVoucherGeneralJournalEntryBiEntity.SubledgerJournalEntry = subledgerJournalEntry;
            subledgerVoucherGeneralJournalEntryBiEntity.PartitionId = partitionId;
            subledgerVoucherGeneralJournalEntryBiEntity.AccountingDate = accountingDate;
            return subledgerVoucherGeneralJournalEntryBiEntity;
        }
        /// <summary>
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Voucher")]
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
        /// There are no comments for Property RecordVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordVersion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordVersion is required.")]
        public virtual int RecordVersion
        {
            get
            {
                return this._RecordVersion;
            }
            set
            {
                this.OnRecordVersionChanging(value);
                this._RecordVersion = value;
                this.OnRecordVersionChanged();
                this.OnPropertyChanged("RecordVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RecordVersion;
        partial void OnRecordVersionChanging(int value);
        partial void OnRecordVersionChanged();
        /// <summary>
        /// There are no comments for Property GeneralJournalEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GeneralJournalEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GeneralJournalEntry is required.")]
        public virtual long GeneralJournalEntry
        {
            get
            {
                return this._GeneralJournalEntry;
            }
            set
            {
                this.OnGeneralJournalEntryChanging(value);
                this._GeneralJournalEntry = value;
                this.OnGeneralJournalEntryChanged();
                this.OnPropertyChanged("GeneralJournalEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _GeneralJournalEntry;
        partial void OnGeneralJournalEntryChanging(long value);
        partial void OnGeneralJournalEntryChanged();
        /// <summary>
        /// There are no comments for Property TransferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransferId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransferId is required.")]
        public virtual long TransferId
        {
            get
            {
                return this._TransferId;
            }
            set
            {
                this.OnTransferIdChanging(value);
                this._TransferId = value;
                this.OnTransferIdChanged();
                this.OnPropertyChanged("TransferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _TransferId;
        partial void OnTransferIdChanging(long value);
        partial void OnTransferIdChanged();
        /// <summary>
        /// There are no comments for Property SysRowVersionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysRowVersionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SysRowVersionNumber is required.")]
        public virtual long SysRowVersionNumber
        {
            get
            {
                return this._SysRowVersionNumber;
            }
            set
            {
                this.OnSysRowVersionNumberChanging(value);
                this._SysRowVersionNumber = value;
                this.OnSysRowVersionNumberChanged();
                this.OnPropertyChanged("SysRowVersionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SysRowVersionNumber;
        partial void OnSysRowVersionNumberChanging(long value);
        partial void OnSysRowVersionNumberChanged();
        /// <summary>
        /// There are no comments for Property SubledgerJournalEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubledgerJournalEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SubledgerJournalEntry is required.")]
        public virtual long SubledgerJournalEntry
        {
            get
            {
                return this._SubledgerJournalEntry;
            }
            set
            {
                this.OnSubledgerJournalEntryChanging(value);
                this._SubledgerJournalEntry = value;
                this.OnSubledgerJournalEntryChanged();
                this.OnPropertyChanged("SubledgerJournalEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SubledgerJournalEntry;
        partial void OnSubledgerJournalEntryChanging(long value);
        partial void OnSubledgerJournalEntryChanged();
        /// <summary>
        /// There are no comments for Property VoucherDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VoucherDataAreaId")]
        public virtual string VoucherDataAreaId
        {
            get
            {
                return this._VoucherDataAreaId;
            }
            set
            {
                this.OnVoucherDataAreaIdChanging(value);
                this._VoucherDataAreaId = value;
                this.OnVoucherDataAreaIdChanged();
                this.OnPropertyChanged("VoucherDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherDataAreaId;
        partial void OnVoucherDataAreaIdChanging(string value);
        partial void OnVoucherDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property PartitionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartitionId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartitionId is required.")]
        public virtual long PartitionId
        {
            get
            {
                return this._PartitionId;
            }
            set
            {
                this.OnPartitionIdChanging(value);
                this._PartitionId = value;
                this.OnPartitionIdChanged();
                this.OnPropertyChanged("PartitionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PartitionId;
        partial void OnPartitionIdChanging(long value);
        partial void OnPartitionIdChanged();
        /// <summary>
        /// There are no comments for Property AccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountingDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountingDate is required.")]
        public virtual global::System.DateTimeOffset AccountingDate
        {
            get
            {
                return this._AccountingDate;
            }
            set
            {
                this.OnAccountingDateChanging(value);
                this._AccountingDate = value;
                this.OnAccountingDateChanged();
                this.OnPropertyChanged("AccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AccountingDate;
        partial void OnAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnAccountingDateChanged();
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
