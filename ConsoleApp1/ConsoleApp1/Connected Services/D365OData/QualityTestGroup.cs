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
    /// There are no comments for QualityTestGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("QualityTestGroupSingle")]
    public partial class QualityTestGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<QualityTestGroup>
    {
        /// <summary>
        /// Initialize a new QualityTestGroupSingle object.
        /// </summary>
        public QualityTestGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new QualityTestGroupSingle object.
        /// </summary>
        public QualityTestGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new QualityTestGroupSingle object.
        /// </summary>
        public QualityTestGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<QualityTestGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for QualityTestGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// QualityTestGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "QualityTestGroupId")]
    [global::Microsoft.OData.Client.EntitySet("QualityTestGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("QualityTestGroup")]
    public partial class QualityTestGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new QualityTestGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="qualityTestGroupId">Initial value of QualityTestGroupId.</param>
        /// <param name="acceptableQualityLevelPercentage">Initial value of AcceptableQualityLevelPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static QualityTestGroup CreateQualityTestGroup(string dataAreaId, string qualityTestGroupId, decimal acceptableQualityLevelPercentage)
        {
            QualityTestGroup qualityTestGroup = new QualityTestGroup();
            qualityTestGroup.DataAreaId = dataAreaId;
            qualityTestGroup.QualityTestGroupId = qualityTestGroupId;
            qualityTestGroup.AcceptableQualityLevelPercentage = acceptableQualityLevelPercentage;
            return qualityTestGroup;
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
        /// There are no comments for Property QualityTestGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QualityTestGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QualityTestGroupId is required.")]
        public virtual string QualityTestGroupId
        {
            get
            {
                return this._QualityTestGroupId;
            }
            set
            {
                this.OnQualityTestGroupIdChanging(value);
                this._QualityTestGroupId = value;
                this.OnQualityTestGroupIdChanged();
                this.OnPropertyChanged("QualityTestGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualityTestGroupId;
        partial void OnQualityTestGroupIdChanging(string value);
        partial void OnQualityTestGroupIdChanged();
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
        /// There are no comments for Property IsBatchAttributeValueDefaultedWithTestMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsBatchAttributeValueDefaultedWithTestMeasurement")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBatchAttributeValueDefaultedWithTestMeasurement
        {
            get
            {
                return this._IsBatchAttributeValueDefaultedWithTestMeasurement;
            }
            set
            {
                this.OnIsBatchAttributeValueDefaultedWithTestMeasurementChanging(value);
                this._IsBatchAttributeValueDefaultedWithTestMeasurement = value;
                this.OnIsBatchAttributeValueDefaultedWithTestMeasurementChanged();
                this.OnPropertyChanged("IsBatchAttributeValueDefaultedWithTestMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBatchAttributeValueDefaultedWithTestMeasurement;
        partial void OnIsBatchAttributeValueDefaultedWithTestMeasurementChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBatchAttributeValueDefaultedWithTestMeasurementChanged();
        /// <summary>
        /// There are no comments for Property AcceptableQualityLevelPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AcceptableQualityLevelPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AcceptableQualityLevelPercentage is required.")]
        public virtual decimal AcceptableQualityLevelPercentage
        {
            get
            {
                return this._AcceptableQualityLevelPercentage;
            }
            set
            {
                this.OnAcceptableQualityLevelPercentageChanging(value);
                this._AcceptableQualityLevelPercentage = value;
                this.OnAcceptableQualityLevelPercentageChanged();
                this.OnPropertyChanged("AcceptableQualityLevelPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AcceptableQualityLevelPercentage;
        partial void OnAcceptableQualityLevelPercentageChanging(decimal value);
        partial void OnAcceptableQualityLevelPercentageChanged();
        /// <summary>
        /// There are no comments for Property PassedQualityOrderInventoryStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PassedQualityOrderInventoryStatusId")]
        public virtual string PassedQualityOrderInventoryStatusId
        {
            get
            {
                return this._PassedQualityOrderInventoryStatusId;
            }
            set
            {
                this.OnPassedQualityOrderInventoryStatusIdChanging(value);
                this._PassedQualityOrderInventoryStatusId = value;
                this.OnPassedQualityOrderInventoryStatusIdChanged();
                this.OnPropertyChanged("PassedQualityOrderInventoryStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PassedQualityOrderInventoryStatusId;
        partial void OnPassedQualityOrderInventoryStatusIdChanging(string value);
        partial void OnPassedQualityOrderInventoryStatusIdChanged();
        /// <summary>
        /// There are no comments for Property FailedQualityOrderInventoryStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FailedQualityOrderInventoryStatusId")]
        public virtual string FailedQualityOrderInventoryStatusId
        {
            get
            {
                return this._FailedQualityOrderInventoryStatusId;
            }
            set
            {
                this.OnFailedQualityOrderInventoryStatusIdChanging(value);
                this._FailedQualityOrderInventoryStatusId = value;
                this.OnFailedQualityOrderInventoryStatusIdChanged();
                this.OnPropertyChanged("FailedQualityOrderInventoryStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FailedQualityOrderInventoryStatusId;
        partial void OnFailedQualityOrderInventoryStatusIdChanging(string value);
        partial void OnFailedQualityOrderInventoryStatusIdChanged();
        /// <summary>
        /// There are no comments for Property FailedQualityOrderBatchDispositionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FailedQualityOrderBatchDispositionCode")]
        public virtual string FailedQualityOrderBatchDispositionCode
        {
            get
            {
                return this._FailedQualityOrderBatchDispositionCode;
            }
            set
            {
                this.OnFailedQualityOrderBatchDispositionCodeChanging(value);
                this._FailedQualityOrderBatchDispositionCode = value;
                this.OnFailedQualityOrderBatchDispositionCodeChanged();
                this.OnPropertyChanged("FailedQualityOrderBatchDispositionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FailedQualityOrderBatchDispositionCode;
        partial void OnFailedQualityOrderBatchDispositionCodeChanging(string value);
        partial void OnFailedQualityOrderBatchDispositionCodeChanged();
        /// <summary>
        /// There are no comments for Property IsInventoryStatusDefaultedWithTestMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsInventoryStatusDefaultedWithTestMeasurement")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInventoryStatusDefaultedWithTestMeasurement
        {
            get
            {
                return this._IsInventoryStatusDefaultedWithTestMeasurement;
            }
            set
            {
                this.OnIsInventoryStatusDefaultedWithTestMeasurementChanging(value);
                this._IsInventoryStatusDefaultedWithTestMeasurement = value;
                this.OnIsInventoryStatusDefaultedWithTestMeasurementChanged();
                this.OnPropertyChanged("IsInventoryStatusDefaultedWithTestMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInventoryStatusDefaultedWithTestMeasurement;
        partial void OnIsInventoryStatusDefaultedWithTestMeasurementChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInventoryStatusDefaultedWithTestMeasurementChanged();
        /// <summary>
        /// There are no comments for Property ItemSamplingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemSamplingId")]
        public virtual string ItemSamplingId
        {
            get
            {
                return this._ItemSamplingId;
            }
            set
            {
                this.OnItemSamplingIdChanging(value);
                this._ItemSamplingId = value;
                this.OnItemSamplingIdChanged();
                this.OnPropertyChanged("ItemSamplingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSamplingId;
        partial void OnItemSamplingIdChanging(string value);
        partial void OnItemSamplingIdChanged();
        /// <summary>
        /// There are no comments for Property IsDestructiveTest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDestructiveTest")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDestructiveTest
        {
            get
            {
                return this._IsDestructiveTest;
            }
            set
            {
                this.OnIsDestructiveTestChanging(value);
                this._IsDestructiveTest = value;
                this.OnIsDestructiveTestChanged();
                this.OnPropertyChanged("IsDestructiveTest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDestructiveTest;
        partial void OnIsDestructiveTestChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDestructiveTestChanged();
        /// <summary>
        /// There are no comments for Property IsBatchDispositionStatusDefaultedWithTestMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsBatchDispositionStatusDefaultedWithTestMeasurement")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsBatchDispositionStatusDefaultedWithTestMeasurement
        {
            get
            {
                return this._IsBatchDispositionStatusDefaultedWithTestMeasurement;
            }
            set
            {
                this.OnIsBatchDispositionStatusDefaultedWithTestMeasurementChanging(value);
                this._IsBatchDispositionStatusDefaultedWithTestMeasurement = value;
                this.OnIsBatchDispositionStatusDefaultedWithTestMeasurementChanged();
                this.OnPropertyChanged("IsBatchDispositionStatusDefaultedWithTestMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsBatchDispositionStatusDefaultedWithTestMeasurement;
        partial void OnIsBatchDispositionStatusDefaultedWithTestMeasurementChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsBatchDispositionStatusDefaultedWithTestMeasurementChanged();
        /// <summary>
        /// There are no comments for Property PassedQualityOrderBatchDispositionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PassedQualityOrderBatchDispositionCode")]
        public virtual string PassedQualityOrderBatchDispositionCode
        {
            get
            {
                return this._PassedQualityOrderBatchDispositionCode;
            }
            set
            {
                this.OnPassedQualityOrderBatchDispositionCodeChanging(value);
                this._PassedQualityOrderBatchDispositionCode = value;
                this.OnPassedQualityOrderBatchDispositionCodeChanged();
                this.OnPropertyChanged("PassedQualityOrderBatchDispositionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PassedQualityOrderBatchDispositionCode;
        partial void OnPassedQualityOrderBatchDispositionCodeChanging(string value);
        partial void OnPassedQualityOrderBatchDispositionCodeChanged();
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