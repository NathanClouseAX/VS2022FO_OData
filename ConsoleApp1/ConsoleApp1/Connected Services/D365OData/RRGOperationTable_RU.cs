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
    /// There are no comments for RRGOperationTable_RUSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGOperationTable_RUSingle")]
    public partial class RRGOperationTable_RUSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RRGOperationTable_RU>
    {
        /// <summary>
        /// Initialize a new RRGOperationTable_RUSingle object.
        /// </summary>
        public RRGOperationTable_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RRGOperationTable_RUSingle object.
        /// </summary>
        public RRGOperationTable_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RRGOperationTable_RUSingle object.
        /// </summary>
        public RRGOperationTable_RUSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RRGOperationTable_RU> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RRGOperationTable_RU in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineId")]
    [global::Microsoft.OData.Client.EntitySet("RRGOperationTable_RU")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGOperationTable_RU")]
    public partial class RRGOperationTable_RU : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RRGOperationTable_RU object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineId">Initial value of LineId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="queryBaseDateField">Initial value of QueryBaseDateField.</param>
        /// <param name="rTax25FieldId">Initial value of RTax25FieldId.</param>
        /// <param name="querySelectedField">Initial value of QuerySelectedField.</param>
        /// <param name="constantValue">Initial value of ConstantValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RRGOperationTable_RU CreateRRGOperationTable_RU(string dataAreaId, 
                    global::System.Guid lineId, 
                    decimal lineNum, 
                    int queryBaseDateField, 
                    int rTax25FieldId, 
                    int querySelectedField, 
                    decimal constantValue)
        {
            RRGOperationTable_RU rRGOperationTable_RU = new RRGOperationTable_RU();
            rRGOperationTable_RU.DataAreaId = dataAreaId;
            rRGOperationTable_RU.LineId = lineId;
            rRGOperationTable_RU.LineNum = lineNum;
            rRGOperationTable_RU.QueryBaseDateField = queryBaseDateField;
            rRGOperationTable_RU.RTax25FieldId = rTax25FieldId;
            rRGOperationTable_RU.QuerySelectedField = querySelectedField;
            rRGOperationTable_RU.ConstantValue = constantValue;
            return rRGOperationTable_RU;
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
        /// There are no comments for Property LineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineId is required.")]
        public virtual global::System.Guid LineId
        {
            get
            {
                return this._LineId;
            }
            set
            {
                this.OnLineIdChanging(value);
                this._LineId = value;
                this.OnLineIdChanged();
                this.OnPropertyChanged("LineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _LineId;
        partial void OnLineIdChanging(global::System.Guid value);
        partial void OnLineIdChanged();
        /// <summary>
        /// There are no comments for Property RefLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefLineId")]
        public virtual string RefLineId
        {
            get
            {
                return this._RefLineId;
            }
            set
            {
                this.OnRefLineIdChanging(value);
                this._RefLineId = value;
                this.OnRefLineIdChanged();
                this.OnPropertyChanged("RefLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefLineId;
        partial void OnRefLineIdChanging(string value);
        partial void OnRefLineIdChanged();
        /// <summary>
        /// There are no comments for Property QueryFieldOperation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryFieldOperation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGFieldOperation> QueryFieldOperation
        {
            get
            {
                return this._QueryFieldOperation;
            }
            set
            {
                this.OnQueryFieldOperationChanging(value);
                this._QueryFieldOperation = value;
                this.OnQueryFieldOperationChanged();
                this.OnPropertyChanged("QueryFieldOperation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGFieldOperation> _QueryFieldOperation;
        partial void OnQueryFieldOperationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGFieldOperation> value);
        partial void OnQueryFieldOperationChanged();
        /// <summary>
        /// There are no comments for Property DataType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGDataType_RU> DataType
        {
            get
            {
                return this._DataType;
            }
            set
            {
                this.OnDataTypeChanging(value);
                this._DataType = value;
                this.OnDataTypeChanged();
                this.OnPropertyChanged("DataType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGDataType_RU> _DataType;
        partial void OnDataTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGDataType_RU> value);
        partial void OnDataTypeChanged();
        /// <summary>
        /// There are no comments for Property RTax25RegisterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RTax25RegisterId")]
        public virtual string RTax25RegisterId
        {
            get
            {
                return this._RTax25RegisterId;
            }
            set
            {
                this.OnRTax25RegisterIdChanging(value);
                this._RTax25RegisterId = value;
                this.OnRTax25RegisterIdChanged();
                this.OnPropertyChanged("RTax25RegisterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RTax25RegisterId;
        partial void OnRTax25RegisterIdChanging(string value);
        partial void OnRTax25RegisterIdChanged();
        /// <summary>
        /// There are no comments for Property AccountNumMask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountNumMask")]
        public virtual string AccountNumMask
        {
            get
            {
                return this._AccountNumMask;
            }
            set
            {
                this.OnAccountNumMaskChanging(value);
                this._AccountNumMask = value;
                this.OnAccountNumMaskChanged();
                this.OnPropertyChanged("AccountNumMask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumMask;
        partial void OnAccountNumMaskChanging(string value);
        partial void OnAccountNumMaskChanged();
        /// <summary>
        /// There are no comments for Property Operation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Operation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Operator> Operation
        {
            get
            {
                return this._Operation;
            }
            set
            {
                this.OnOperationChanging(value);
                this._Operation = value;
                this.OnOperationChanged();
                this.OnPropertyChanged("Operation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Operator> _Operation;
        partial void OnOperationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Operator> value);
        partial void OnOperationChanged();
        /// <summary>
        /// There are no comments for Property TypeByCorrect in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeByCorrect")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGTypeByCorrect_RU> TypeByCorrect
        {
            get
            {
                return this._TypeByCorrect;
            }
            set
            {
                this.OnTypeByCorrectChanging(value);
                this._TypeByCorrect = value;
                this.OnTypeByCorrectChanged();
                this.OnPropertyChanged("TypeByCorrect");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGTypeByCorrect_RU> _TypeByCorrect;
        partial void OnTypeByCorrectChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGTypeByCorrect_RU> value);
        partial void OnTypeByCorrectChanged();
        /// <summary>
        /// There are no comments for Property LedgerRRGEProperties_W_PropertyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerRRGEProperties_W_PropertyId")]
        public virtual string LedgerRRGEProperties_W_PropertyId
        {
            get
            {
                return this._LedgerRRGEProperties_W_PropertyId;
            }
            set
            {
                this.OnLedgerRRGEProperties_W_PropertyIdChanging(value);
                this._LedgerRRGEProperties_W_PropertyId = value;
                this.OnLedgerRRGEProperties_W_PropertyIdChanged();
                this.OnPropertyChanged("LedgerRRGEProperties_W_PropertyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerRRGEProperties_W_PropertyId;
        partial void OnLedgerRRGEProperties_W_PropertyIdChanging(string value);
        partial void OnLedgerRRGEProperties_W_PropertyIdChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountNumMask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OffsetAccountNumMask")]
        public virtual string OffsetAccountNumMask
        {
            get
            {
                return this._OffsetAccountNumMask;
            }
            set
            {
                this.OnOffsetAccountNumMaskChanging(value);
                this._OffsetAccountNumMask = value;
                this.OnOffsetAccountNumMaskChanged();
                this.OnPropertyChanged("OffsetAccountNumMask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetAccountNumMask;
        partial void OnOffsetAccountNumMaskChanging(string value);
        partial void OnOffsetAccountNumMaskChanged();
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
        /// There are no comments for Property ModelNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelNum")]
        public virtual string ModelNum
        {
            get
            {
                return this._ModelNum;
            }
            set
            {
                this.OnModelNumChanging(value);
                this._ModelNum = value;
                this.OnModelNumChanged();
                this.OnPropertyChanged("ModelNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelNum;
        partial void OnModelNumChanging(string value);
        partial void OnModelNumChanged();
        /// <summary>
        /// There are no comments for Property ConstantText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConstantText")]
        public virtual string ConstantText
        {
            get
            {
                return this._ConstantText;
            }
            set
            {
                this.OnConstantTextChanging(value);
                this._ConstantText = value;
                this.OnConstantTextChanged();
                this.OnPropertyChanged("ConstantText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConstantText;
        partial void OnConstantTextChanging(string value);
        partial void OnConstantTextChanged();
        /// <summary>
        /// There are no comments for Property QueryBaseDateField in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryBaseDateField")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QueryBaseDateField is required.")]
        public virtual int QueryBaseDateField
        {
            get
            {
                return this._QueryBaseDateField;
            }
            set
            {
                this.OnQueryBaseDateFieldChanging(value);
                this._QueryBaseDateField = value;
                this.OnQueryBaseDateFieldChanged();
                this.OnPropertyChanged("QueryBaseDateField");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QueryBaseDateField;
        partial void OnQueryBaseDateFieldChanging(int value);
        partial void OnQueryBaseDateFieldChanged();
        /// <summary>
        /// There are no comments for Property RTax25FieldId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RTax25FieldId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RTax25FieldId is required.")]
        public virtual int RTax25FieldId
        {
            get
            {
                return this._RTax25FieldId;
            }
            set
            {
                this.OnRTax25FieldIdChanging(value);
                this._RTax25FieldId = value;
                this.OnRTax25FieldIdChanged();
                this.OnPropertyChanged("RTax25FieldId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RTax25FieldId;
        partial void OnRTax25FieldIdChanging(int value);
        partial void OnRTax25FieldIdChanged();
        /// <summary>
        /// There are no comments for Property RefTableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefTableName")]
        public virtual string RefTableName
        {
            get
            {
                return this._RefTableName;
            }
            set
            {
                this.OnRefTableNameChanging(value);
                this._RefTableName = value;
                this.OnRefTableNameChanged();
                this.OnPropertyChanged("RefTableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefTableName;
        partial void OnRefTableNameChanging(string value);
        partial void OnRefTableNameChanged();
        /// <summary>
        /// There are no comments for Property QuerySelectedField in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuerySelectedField")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QuerySelectedField is required.")]
        public virtual int QuerySelectedField
        {
            get
            {
                return this._QuerySelectedField;
            }
            set
            {
                this.OnQuerySelectedFieldChanging(value);
                this._QuerySelectedField = value;
                this.OnQuerySelectedFieldChanged();
                this.OnPropertyChanged("QuerySelectedField");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QuerySelectedField;
        partial void OnQuerySelectedFieldChanging(int value);
        partial void OnQuerySelectedFieldChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountIntervalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OffsetAccountIntervalType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> OffsetAccountIntervalType
        {
            get
            {
                return this._OffsetAccountIntervalType;
            }
            set
            {
                this.OnOffsetAccountIntervalTypeChanging(value);
                this._OffsetAccountIntervalType = value;
                this.OnOffsetAccountIntervalTypeChanged();
                this.OnPropertyChanged("OffsetAccountIntervalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> _OffsetAccountIntervalType;
        partial void OnOffsetAccountIntervalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> value);
        partial void OnOffsetAccountIntervalTypeChanged();
        /// <summary>
        /// There are no comments for Property BalanceDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BalanceDetail")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalanceDetail_RU> BalanceDetail
        {
            get
            {
                return this._BalanceDetail;
            }
            set
            {
                this.OnBalanceDetailChanging(value);
                this._BalanceDetail = value;
                this.OnBalanceDetailChanged();
                this.OnPropertyChanged("BalanceDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalanceDetail_RU> _BalanceDetail;
        partial void OnBalanceDetailChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalanceDetail_RU> value);
        partial void OnBalanceDetailChanged();
        /// <summary>
        /// There are no comments for Property QuerySelectReportDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QuerySelectReportDate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> QuerySelectReportDate
        {
            get
            {
                return this._QuerySelectReportDate;
            }
            set
            {
                this.OnQuerySelectReportDateChanging(value);
                this._QuerySelectReportDate = value;
                this.OnQuerySelectReportDateChanged();
                this.OnPropertyChanged("QuerySelectReportDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _QuerySelectReportDate;
        partial void OnQuerySelectReportDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnQuerySelectReportDateChanged();
        /// <summary>
        /// There are no comments for Property LedgerPeriodCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerPeriodCode")]
        public virtual string LedgerPeriodCode
        {
            get
            {
                return this._LedgerPeriodCode;
            }
            set
            {
                this.OnLedgerPeriodCodeChanging(value);
                this._LedgerPeriodCode = value;
                this.OnLedgerPeriodCodeChanged();
                this.OnPropertyChanged("LedgerPeriodCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerPeriodCode;
        partial void OnLedgerPeriodCodeChanging(string value);
        partial void OnLedgerPeriodCodeChanged();
        /// <summary>
        /// There are no comments for Property BalanceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BalanceType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalancePeriodType_RU> BalanceType
        {
            get
            {
                return this._BalanceType;
            }
            set
            {
                this.OnBalanceTypeChanging(value);
                this._BalanceType = value;
                this.OnBalanceTypeChanged();
                this.OnPropertyChanged("BalanceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalancePeriodType_RU> _BalanceType;
        partial void OnBalanceTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGBalancePeriodType_RU> value);
        partial void OnBalanceTypeChanged();
        /// <summary>
        /// There are no comments for Property AccountIntervalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountIntervalType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> AccountIntervalType
        {
            get
            {
                return this._AccountIntervalType;
            }
            set
            {
                this.OnAccountIntervalTypeChanging(value);
                this._AccountIntervalType = value;
                this.OnAccountIntervalTypeChanged();
                this.OnPropertyChanged("AccountIntervalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> _AccountIntervalType;
        partial void OnAccountIntervalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGIntervalType_RU> value);
        partial void OnAccountIntervalTypeChanged();
        /// <summary>
        /// There are no comments for Property Query in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Query")]
        public virtual byte[] Query
        {
            get
            {
                return this._Query;
            }
            set
            {
                this.OnQueryChanging(value);
                this._Query = value;
                this.OnQueryChanged();
                this.OnPropertyChanged("Query");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Query;
        partial void OnQueryChanging(byte[] value);
        partial void OnQueryChanged();
        /// <summary>
        /// There are no comments for Property LedgerOperation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerOperation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGOperationType_RU> LedgerOperation
        {
            get
            {
                return this._LedgerOperation;
            }
            set
            {
                this.OnLedgerOperationChanging(value);
                this._LedgerOperation = value;
                this.OnLedgerOperationChanged();
                this.OnPropertyChanged("LedgerOperation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGOperationType_RU> _LedgerOperation;
        partial void OnLedgerOperationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerRRGOperationType_RU> value);
        partial void OnLedgerOperationChanged();
        /// <summary>
        /// There are no comments for Property ConstantValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConstantValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConstantValue is required.")]
        public virtual decimal ConstantValue
        {
            get
            {
                return this._ConstantValue;
            }
            set
            {
                this.OnConstantValueChanging(value);
                this._ConstantValue = value;
                this.OnConstantValueChanged();
                this.OnPropertyChanged("ConstantValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ConstantValue;
        partial void OnConstantValueChanging(decimal value);
        partial void OnConstantValueChanged();
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
