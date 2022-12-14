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
    /// There are no comments for AssetMaintenanceWorkOrderLineChecklistSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLineChecklistSingle")]
    public partial class AssetMaintenanceWorkOrderLineChecklistSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLineChecklist>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineChecklistSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineChecklistSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineChecklistSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineChecklistSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLineChecklistSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLineChecklistSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLineChecklist> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceWorkOrderLineChecklist in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ExternalLineNum
    /// WorkOrderId
    /// WorkOrderLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ExternalLineNum", "WorkOrderId", "WorkOrderLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderLineChecklists")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceWorkOrderLineChecklist")]
    public partial class AssetMaintenanceWorkOrderLineChecklist : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderLineChecklist object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="externalLineNum">Initial value of ExternalLineNum.</param>
        /// <param name="workOrderId">Initial value of WorkOrderId.</param>
        /// <param name="workOrderLineNumber">Initial value of WorkOrderLineNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="measureMaxValue">Initial value of MeasureMaxValue.</param>
        /// <param name="checkedCounterDateTime">Initial value of CheckedCounterDateTime.</param>
        /// <param name="measureMinValue">Initial value of MeasureMinValue.</param>
        /// <param name="groupNumber">Initial value of GroupNumber.</param>
        /// <param name="measureValue">Initial value of MeasureValue.</param>
        /// <param name="dateChecked">Initial value of DateChecked.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderLineChecklist CreateAssetMaintenanceWorkOrderLineChecklist(string dataAreaId, 
                    decimal externalLineNum, 
                    string workOrderId, 
                    long workOrderLineNumber, 
                    decimal lineNumber, 
                    decimal measureMaxValue, 
                    global::System.DateTimeOffset checkedCounterDateTime, 
                    decimal measureMinValue, 
                    decimal groupNumber, 
                    decimal measureValue, 
                    global::System.DateTimeOffset dateChecked)
        {
            AssetMaintenanceWorkOrderLineChecklist assetMaintenanceWorkOrderLineChecklist = new AssetMaintenanceWorkOrderLineChecklist();
            assetMaintenanceWorkOrderLineChecklist.DataAreaId = dataAreaId;
            assetMaintenanceWorkOrderLineChecklist.ExternalLineNum = externalLineNum;
            assetMaintenanceWorkOrderLineChecklist.WorkOrderId = workOrderId;
            assetMaintenanceWorkOrderLineChecklist.WorkOrderLineNumber = workOrderLineNumber;
            assetMaintenanceWorkOrderLineChecklist.LineNumber = lineNumber;
            assetMaintenanceWorkOrderLineChecklist.MeasureMaxValue = measureMaxValue;
            assetMaintenanceWorkOrderLineChecklist.CheckedCounterDateTime = checkedCounterDateTime;
            assetMaintenanceWorkOrderLineChecklist.MeasureMinValue = measureMinValue;
            assetMaintenanceWorkOrderLineChecklist.GroupNumber = groupNumber;
            assetMaintenanceWorkOrderLineChecklist.MeasureValue = measureValue;
            assetMaintenanceWorkOrderLineChecklist.DateChecked = dateChecked;
            return assetMaintenanceWorkOrderLineChecklist;
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
        /// There are no comments for Property ExternalLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalLineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExternalLineNum is required.")]
        public virtual decimal ExternalLineNum
        {
            get
            {
                return this._ExternalLineNum;
            }
            set
            {
                this.OnExternalLineNumChanging(value);
                this._ExternalLineNum = value;
                this.OnExternalLineNumChanged();
                this.OnPropertyChanged("ExternalLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExternalLineNum;
        partial void OnExternalLineNumChanging(decimal value);
        partial void OnExternalLineNumChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkOrderId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkOrderId is required.")]
        public virtual string WorkOrderId
        {
            get
            {
                return this._WorkOrderId;
            }
            set
            {
                this.OnWorkOrderIdChanging(value);
                this._WorkOrderId = value;
                this.OnWorkOrderIdChanged();
                this.OnPropertyChanged("WorkOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderId;
        partial void OnWorkOrderIdChanging(string value);
        partial void OnWorkOrderIdChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkOrderLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WorkOrderLineNumber is required.")]
        public virtual long WorkOrderLineNumber
        {
            get
            {
                return this._WorkOrderLineNumber;
            }
            set
            {
                this.OnWorkOrderLineNumberChanging(value);
                this._WorkOrderLineNumber = value;
                this.OnWorkOrderLineNumberChanged();
                this.OnPropertyChanged("WorkOrderLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _WorkOrderLineNumber;
        partial void OnWorkOrderLineNumberChanging(long value);
        partial void OnWorkOrderLineNumberChanged();
        /// <summary>
        /// There are no comments for Property MeasureUpdate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasureUpdate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistCounterUpdate> MeasureUpdate
        {
            get
            {
                return this._MeasureUpdate;
            }
            set
            {
                this.OnMeasureUpdateChanging(value);
                this._MeasureUpdate = value;
                this.OnMeasureUpdateChanged();
                this.OnPropertyChanged("MeasureUpdate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistCounterUpdate> _MeasureUpdate;
        partial void OnMeasureUpdateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistCounterUpdate> value);
        partial void OnMeasureUpdateChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property MeasureMaxValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasureMaxValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MeasureMaxValue is required.")]
        public virtual decimal MeasureMaxValue
        {
            get
            {
                return this._MeasureMaxValue;
            }
            set
            {
                this.OnMeasureMaxValueChanging(value);
                this._MeasureMaxValue = value;
                this.OnMeasureMaxValueChanged();
                this.OnPropertyChanged("MeasureMaxValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MeasureMaxValue;
        partial void OnMeasureMaxValueChanging(decimal value);
        partial void OnMeasureMaxValueChanged();
        /// <summary>
        /// There are no comments for Property Instructions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Instructions")]
        public virtual string Instructions
        {
            get
            {
                return this._Instructions;
            }
            set
            {
                this.OnInstructionsChanging(value);
                this._Instructions = value;
                this.OnInstructionsChanged();
                this.OnPropertyChanged("Instructions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Instructions;
        partial void OnInstructionsChanging(string value);
        partial void OnInstructionsChanged();
        /// <summary>
        /// There are no comments for Property CheckedCounterReplaced in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedCounterReplaced")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CheckedCounterReplaced
        {
            get
            {
                return this._CheckedCounterReplaced;
            }
            set
            {
                this.OnCheckedCounterReplacedChanging(value);
                this._CheckedCounterReplaced = value;
                this.OnCheckedCounterReplacedChanged();
                this.OnPropertyChanged("CheckedCounterReplaced");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CheckedCounterReplaced;
        partial void OnCheckedCounterReplacedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCheckedCounterReplacedChanged();
        /// <summary>
        /// There are no comments for Property ChecklistVariableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChecklistVariableId")]
        public virtual string ChecklistVariableId
        {
            get
            {
                return this._ChecklistVariableId;
            }
            set
            {
                this.OnChecklistVariableIdChanging(value);
                this._ChecklistVariableId = value;
                this.OnChecklistVariableIdChanged();
                this.OnPropertyChanged("ChecklistVariableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChecklistVariableId;
        partial void OnChecklistVariableIdChanging(string value);
        partial void OnChecklistVariableIdChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistActionType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistActionType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistActionType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property CheckedByPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedByPersonnelNumber")]
        public virtual string CheckedByPersonnelNumber
        {
            get
            {
                return this._CheckedByPersonnelNumber;
            }
            set
            {
                this.OnCheckedByPersonnelNumberChanging(value);
                this._CheckedByPersonnelNumber = value;
                this.OnCheckedByPersonnelNumberChanged();
                this.OnPropertyChanged("CheckedByPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckedByPersonnelNumber;
        partial void OnCheckedByPersonnelNumberChanging(string value);
        partial void OnCheckedByPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property MeasureUnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasureUnitId")]
        public virtual string MeasureUnitId
        {
            get
            {
                return this._MeasureUnitId;
            }
            set
            {
                this.OnMeasureUnitIdChanging(value);
                this._MeasureUnitId = value;
                this.OnMeasureUnitIdChanged();
                this.OnPropertyChanged("MeasureUnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MeasureUnitId;
        partial void OnMeasureUnitIdChanging(string value);
        partial void OnMeasureUnitIdChanged();
        /// <summary>
        /// There are no comments for Property CheckedCounterDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedCounterDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CheckedCounterDateTime is required.")]
        public virtual global::System.DateTimeOffset CheckedCounterDateTime
        {
            get
            {
                return this._CheckedCounterDateTime;
            }
            set
            {
                this.OnCheckedCounterDateTimeChanging(value);
                this._CheckedCounterDateTime = value;
                this.OnCheckedCounterDateTimeChanged();
                this.OnPropertyChanged("CheckedCounterDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CheckedCounterDateTime;
        partial void OnCheckedCounterDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCheckedCounterDateTimeChanged();
        /// <summary>
        /// There are no comments for Property MeasureMinValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasureMinValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MeasureMinValue is required.")]
        public virtual decimal MeasureMinValue
        {
            get
            {
                return this._MeasureMinValue;
            }
            set
            {
                this.OnMeasureMinValueChanging(value);
                this._MeasureMinValue = value;
                this.OnMeasureMinValueChanged();
                this.OnPropertyChanged("MeasureMinValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MeasureMinValue;
        partial void OnMeasureMinValueChanging(decimal value);
        partial void OnMeasureMinValueChanged();
        /// <summary>
        /// There are no comments for Property GroupNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupNumber is required.")]
        public virtual decimal GroupNumber
        {
            get
            {
                return this._GroupNumber;
            }
            set
            {
                this.OnGroupNumberChanging(value);
                this._GroupNumber = value;
                this.OnGroupNumberChanged();
                this.OnPropertyChanged("GroupNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _GroupNumber;
        partial void OnGroupNumberChanging(decimal value);
        partial void OnGroupNumberChanged();
        /// <summary>
        /// There are no comments for Property CheckedCounterTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedCounterTypeId")]
        public virtual string CheckedCounterTypeId
        {
            get
            {
                return this._CheckedCounterTypeId;
            }
            set
            {
                this.OnCheckedCounterTypeIdChanging(value);
                this._CheckedCounterTypeId = value;
                this.OnCheckedCounterTypeIdChanged();
                this.OnPropertyChanged("CheckedCounterTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckedCounterTypeId;
        partial void OnCheckedCounterTypeIdChanging(string value);
        partial void OnCheckedCounterTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Mandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Mandatory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Mandatory
        {
            get
            {
                return this._Mandatory;
            }
            set
            {
                this.OnMandatoryChanging(value);
                this._Mandatory = value;
                this.OnMandatoryChanged();
                this.OnPropertyChanged("Mandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Mandatory;
        partial void OnMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMandatoryChanged();
        /// <summary>
        /// There are no comments for Property NotApplicable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NotApplicable")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> NotApplicable
        {
            get
            {
                return this._NotApplicable;
            }
            set
            {
                this.OnNotApplicableChanging(value);
                this._NotApplicable = value;
                this.OnNotApplicableChanged();
                this.OnPropertyChanged("NotApplicable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _NotApplicable;
        partial void OnNotApplicableChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNotApplicableChanged();
        /// <summary>
        /// There are no comments for Property LineStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> LineStatus
        {
            get
            {
                return this._LineStatus;
            }
            set
            {
                this.OnLineStatusChanging(value);
                this._LineStatus = value;
                this.OnLineStatusChanged();
                this.OnPropertyChanged("LineStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> _LineStatus;
        partial void OnLineStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistLineStatus> value);
        partial void OnLineStatusChanged();
        /// <summary>
        /// There are no comments for Property Checked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Checked")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Checked
        {
            get
            {
                return this._Checked;
            }
            set
            {
                this.OnCheckedChanging(value);
                this._Checked = value;
                this.OnCheckedChanged();
                this.OnPropertyChanged("Checked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Checked;
        partial void OnCheckedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCheckedChanged();
        /// <summary>
        /// There are no comments for Property CheckedMaintenanceAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedMaintenanceAssetId")]
        public virtual string CheckedMaintenanceAssetId
        {
            get
            {
                return this._CheckedMaintenanceAssetId;
            }
            set
            {
                this.OnCheckedMaintenanceAssetIdChanging(value);
                this._CheckedMaintenanceAssetId = value;
                this.OnCheckedMaintenanceAssetIdChanged();
                this.OnPropertyChanged("CheckedMaintenanceAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckedMaintenanceAssetId;
        partial void OnCheckedMaintenanceAssetIdChanging(string value);
        partial void OnCheckedMaintenanceAssetIdChanged();
        /// <summary>
        /// There are no comments for Property VariableValueId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VariableValueId")]
        public virtual string VariableValueId
        {
            get
            {
                return this._VariableValueId;
            }
            set
            {
                this.OnVariableValueIdChanging(value);
                this._VariableValueId = value;
                this.OnVariableValueIdChanged();
                this.OnPropertyChanged("VariableValueId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VariableValueId;
        partial void OnVariableValueIdChanging(string value);
        partial void OnVariableValueIdChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property ChecklistRefType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChecklistRefType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistRefType> ChecklistRefType
        {
            get
            {
                return this._ChecklistRefType;
            }
            set
            {
                this.OnChecklistRefTypeChanging(value);
                this._ChecklistRefType = value;
                this.OnChecklistRefTypeChanged();
                this.OnPropertyChanged("ChecklistRefType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistRefType> _ChecklistRefType;
        partial void OnChecklistRefTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetChecklistRefType> value);
        partial void OnChecklistRefTypeChanged();
        /// <summary>
        /// There are no comments for Property CheckedMaintenanceAssetCounterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckedMaintenanceAssetCounterId")]
        public virtual string CheckedMaintenanceAssetCounterId
        {
            get
            {
                return this._CheckedMaintenanceAssetCounterId;
            }
            set
            {
                this.OnCheckedMaintenanceAssetCounterIdChanging(value);
                this._CheckedMaintenanceAssetCounterId = value;
                this.OnCheckedMaintenanceAssetCounterIdChanged();
                this.OnPropertyChanged("CheckedMaintenanceAssetCounterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckedMaintenanceAssetCounterId;
        partial void OnCheckedMaintenanceAssetCounterIdChanging(string value);
        partial void OnCheckedMaintenanceAssetCounterIdChanged();
        /// <summary>
        /// There are no comments for Property MeasureValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MeasureValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MeasureValue is required.")]
        public virtual decimal MeasureValue
        {
            get
            {
                return this._MeasureValue;
            }
            set
            {
                this.OnMeasureValueChanging(value);
                this._MeasureValue = value;
                this.OnMeasureValueChanged();
                this.OnPropertyChanged("MeasureValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MeasureValue;
        partial void OnMeasureValueChanging(decimal value);
        partial void OnMeasureValueChanged();
        /// <summary>
        /// There are no comments for Property DateChecked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateChecked")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateChecked is required.")]
        public virtual global::System.DateTimeOffset DateChecked
        {
            get
            {
                return this._DateChecked;
            }
            set
            {
                this.OnDateCheckedChanging(value);
                this._DateChecked = value;
                this.OnDateCheckedChanged();
                this.OnPropertyChanged("DateChecked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateChecked;
        partial void OnDateCheckedChanging(global::System.DateTimeOffset value);
        partial void OnDateCheckedChanged();
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
