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
    /// There are no comments for WarehouseReplenishmentTemplateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseReplenishmentTemplateSingle")]
    public partial class WarehouseReplenishmentTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseReplenishmentTemplate>
    {
        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseReplenishmentTemplateSingle object.
        /// </summary>
        public WarehouseReplenishmentTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseReplenishmentTemplate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WarehouseReplenishmentTemplateUnitOfMeasureRestrictions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseReplenishmentTemplateUnitOfMeasureRestrictions")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction> WarehouseReplenishmentTemplateUnitOfMeasureRestrictions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseReplenishmentTemplateUnitOfMeasureRestrictions == null))
                {
                    this._WarehouseReplenishmentTemplateUnitOfMeasureRestrictions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction>(GetPath("WarehouseReplenishmentTemplateUnitOfMeasureRestrictions"));
                }
                return this._WarehouseReplenishmentTemplateUnitOfMeasureRestrictions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction> _WarehouseReplenishmentTemplateUnitOfMeasureRestrictions;
    }
    /// <summary>
    /// There are no comments for WarehouseReplenishmentTemplate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TemplateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TemplateId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseReplenishmentTemplates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseReplenishmentTemplate")]
    public partial class WarehouseReplenishmentTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseReplenishmentTemplate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="templateId">Initial value of TemplateId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseReplenishmentTemplate CreateWarehouseReplenishmentTemplate(string dataAreaId, string templateId)
        {
            WarehouseReplenishmentTemplate warehouseReplenishmentTemplate = new WarehouseReplenishmentTemplate();
            warehouseReplenishmentTemplate.DataAreaId = dataAreaId;
            warehouseReplenishmentTemplate.TemplateId = templateId;
            return warehouseReplenishmentTemplate;
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
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TemplateId is required.")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property WillDemandCancellationCancelReplenishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillDemandCancellationCancelReplenishment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillDemandCancellationCancelReplenishment
        {
            get
            {
                return this._WillDemandCancellationCancelReplenishment;
            }
            set
            {
                this.OnWillDemandCancellationCancelReplenishmentChanging(value);
                this._WillDemandCancellationCancelReplenishment = value;
                this.OnWillDemandCancellationCancelReplenishmentChanged();
                this.OnPropertyChanged("WillDemandCancellationCancelReplenishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillDemandCancellationCancelReplenishment;
        partial void OnWillDemandCancellationCancelReplenishmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillDemandCancellationCancelReplenishmentChanged();
        /// <summary>
        /// There are no comments for Property UseExistingImmediateReplenishmentWorkCrossUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseExistingImmediateReplenishmentWorkCrossUnit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseExistingImmediateReplenishmentWorkCrossUnit
        {
            get
            {
                return this._UseExistingImmediateReplenishmentWorkCrossUnit;
            }
            set
            {
                this.OnUseExistingImmediateReplenishmentWorkCrossUnitChanging(value);
                this._UseExistingImmediateReplenishmentWorkCrossUnit = value;
                this.OnUseExistingImmediateReplenishmentWorkCrossUnitChanged();
                this.OnPropertyChanged("UseExistingImmediateReplenishmentWorkCrossUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseExistingImmediateReplenishmentWorkCrossUnit;
        partial void OnUseExistingImmediateReplenishmentWorkCrossUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseExistingImmediateReplenishmentWorkCrossUnitChanged();
        /// <summary>
        /// There are no comments for Property TemplateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSReplenishmentType> TemplateType
        {
            get
            {
                return this._TemplateType;
            }
            set
            {
                this.OnTemplateTypeChanging(value);
                this._TemplateType = value;
                this.OnTemplateTypeChanged();
                this.OnPropertyChanged("TemplateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSReplenishmentType> _TemplateType;
        partial void OnTemplateTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSReplenishmentType> value);
        partial void OnTemplateTypeChanged();
        /// <summary>
        /// There are no comments for Property TemplateDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TemplateDescription")]
        public virtual string TemplateDescription
        {
            get
            {
                return this._TemplateDescription;
            }
            set
            {
                this.OnTemplateDescriptionChanging(value);
                this._TemplateDescription = value;
                this.OnTemplateDescriptionChanged();
                this.OnPropertyChanged("TemplateDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateDescription;
        partial void OnTemplateDescriptionChanging(string value);
        partial void OnTemplateDescriptionChanged();
        /// <summary>
        /// There are no comments for Property WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities
        {
            get
            {
                return this._WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities;
            }
            set
            {
                this.OnWillCreatedReplenishmentWorkAllowUsingUnreservedQuantitiesChanging(value);
                this._WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities = value;
                this.OnWillCreatedReplenishmentWorkAllowUsingUnreservedQuantitiesChanged();
                this.OnPropertyChanged("WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities;
        partial void OnWillCreatedReplenishmentWorkAllowUsingUnreservedQuantitiesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCreatedReplenishmentWorkAllowUsingUnreservedQuantitiesChanged();
        /// <summary>
        /// There are no comments for Property WaveStepCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WaveStepCode")]
        public virtual string WaveStepCode
        {
            get
            {
                return this._WaveStepCode;
            }
            set
            {
                this.OnWaveStepCodeChanging(value);
                this._WaveStepCode = value;
                this.OnWaveStepCodeChanged();
                this.OnPropertyChanged("WaveStepCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WaveStepCode;
        partial void OnWaveStepCodeChanging(string value);
        partial void OnWaveStepCodeChanged();
        /// <summary>
        /// There are no comments for Property WarehouseReplenishmentTemplateUnitOfMeasureRestrictions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseReplenishmentTemplateUnitOfMeasureRestrictions")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction> WarehouseReplenishmentTemplateUnitOfMeasureRestrictions
        {
            get
            {
                return this._WarehouseReplenishmentTemplateUnitOfMeasureRestrictions;
            }
            set
            {
                this.OnWarehouseReplenishmentTemplateUnitOfMeasureRestrictionsChanging(value);
                this._WarehouseReplenishmentTemplateUnitOfMeasureRestrictions = value;
                this.OnWarehouseReplenishmentTemplateUnitOfMeasureRestrictionsChanged();
                this.OnPropertyChanged("WarehouseReplenishmentTemplateUnitOfMeasureRestrictions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction> _WarehouseReplenishmentTemplateUnitOfMeasureRestrictions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseReplenishmentTemplateUnitOfMeasureRestrictionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseReplenishmentTemplateUnitOfMeasureRestriction> value);
        partial void OnWarehouseReplenishmentTemplateUnitOfMeasureRestrictionsChanged();
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
