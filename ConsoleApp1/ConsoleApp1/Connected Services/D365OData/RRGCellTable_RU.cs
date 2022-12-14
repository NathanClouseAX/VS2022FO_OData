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
    /// There are no comments for RRGCellTable_RUSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGCellTable_RUSingle")]
    public partial class RRGCellTable_RUSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RRGCellTable_RU>
    {
        /// <summary>
        /// Initialize a new RRGCellTable_RUSingle object.
        /// </summary>
        public RRGCellTable_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RRGCellTable_RUSingle object.
        /// </summary>
        public RRGCellTable_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RRGCellTable_RUSingle object.
        /// </summary>
        public RRGCellTable_RUSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RRGCellTable_RU> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RRGCellTable_RU in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineId")]
    [global::Microsoft.OData.Client.EntitySet("RRGCellTable_RU")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGCellTable_RU")]
    public partial class RRGCellTable_RU : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RRGCellTable_RU object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineId">Initial value of LineId.</param>
        /// <param name="length">Initial value of Length.</param>
        /// <param name="pointSignNum">Initial value of PointSignNum.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RRGCellTable_RU CreateRRGCellTable_RU(string dataAreaId, global::System.Guid lineId, int length, int pointSignNum)
        {
            RRGCellTable_RU rRGCellTable_RU = new RRGCellTable_RU();
            rRGCellTable_RU.DataAreaId = dataAreaId;
            rRGCellTable_RU.LineId = lineId;
            rRGCellTable_RU.Length = length;
            rRGCellTable_RU.PointSignNum = pointSignNum;
            return rRGCellTable_RU;
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
        /// There are no comments for Property CellCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CellCode")]
        public virtual string CellCode
        {
            get
            {
                return this._CellCode;
            }
            set
            {
                this.OnCellCodeChanging(value);
                this._CellCode = value;
                this.OnCellCodeChanged();
                this.OnPropertyChanged("CellCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CellCode;
        partial void OnCellCodeChanging(string value);
        partial void OnCellCodeChanged();
        /// <summary>
        /// There are no comments for Property IsStatic in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsStatic")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsStatic
        {
            get
            {
                return this._IsStatic;
            }
            set
            {
                this.OnIsStaticChanging(value);
                this._IsStatic = value;
                this.OnIsStaticChanged();
                this.OnPropertyChanged("IsStatic");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsStatic;
        partial void OnIsStaticChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsStaticChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
        /// There are no comments for Property Length in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Length")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Length is required.")]
        public virtual int Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this.OnLengthChanging(value);
                this._Length = value;
                this.OnLengthChanged();
                this.OnPropertyChanged("Length");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Length;
        partial void OnLengthChanging(int value);
        partial void OnLengthChanged();
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
        /// There are no comments for Property RepCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RepCode")]
        public virtual string RepCode
        {
            get
            {
                return this._RepCode;
            }
            set
            {
                this.OnRepCodeChanging(value);
                this._RepCode = value;
                this.OnRepCodeChanged();
                this.OnPropertyChanged("RepCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RepCode;
        partial void OnRepCodeChanging(string value);
        partial void OnRepCodeChanged();
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
        /// There are no comments for Property Alignment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Alignment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysAlignment> Alignment
        {
            get
            {
                return this._Alignment;
            }
            set
            {
                this.OnAlignmentChanging(value);
                this._Alignment = value;
                this.OnAlignmentChanged();
                this.OnPropertyChanged("Alignment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysAlignment> _Alignment;
        partial void OnAlignmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysAlignment> value);
        partial void OnAlignmentChanged();
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
        /// There are no comments for Property EmptyChar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmptyChar")]
        public virtual string EmptyChar
        {
            get
            {
                return this._EmptyChar;
            }
            set
            {
                this.OnEmptyCharChanging(value);
                this._EmptyChar = value;
                this.OnEmptyCharChanged();
                this.OnPropertyChanged("EmptyChar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmptyChar;
        partial void OnEmptyCharChanging(string value);
        partial void OnEmptyCharChanged();
        /// <summary>
        /// There are no comments for Property PointSignNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PointSignNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PointSignNum is required.")]
        public virtual int PointSignNum
        {
            get
            {
                return this._PointSignNum;
            }
            set
            {
                this.OnPointSignNumChanging(value);
                this._PointSignNum = value;
                this.OnPointSignNumChanged();
                this.OnPropertyChanged("PointSignNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PointSignNum;
        partial void OnPointSignNumChanging(int value);
        partial void OnPointSignNumChanged();
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
