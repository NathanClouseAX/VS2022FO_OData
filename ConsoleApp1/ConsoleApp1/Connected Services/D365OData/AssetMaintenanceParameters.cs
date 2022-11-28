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
    /// There are no comments for AssetMaintenanceParametersSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceParametersSingle")]
    public partial class AssetMaintenanceParametersSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceParameters>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceParametersSingle object.
        /// </summary>
        public AssetMaintenanceParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceParametersSingle object.
        /// </summary>
        public AssetMaintenanceParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceParametersSingle object.
        /// </summary>
        public AssetMaintenanceParametersSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceParameters> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMaintenanceParameters in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceParameters")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMaintenanceParameters")]
    public partial class AssetMaintenanceParameters : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceParameters object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="functionalLocationLevel">Initial value of FunctionalLocationLevel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceParameters CreateAssetMaintenanceParameters(string dataAreaId, int functionalLocationLevel)
        {
            AssetMaintenanceParameters assetMaintenanceParameters = new AssetMaintenanceParameters();
            assetMaintenanceParameters.DataAreaId = dataAreaId;
            assetMaintenanceParameters.FunctionalLocationLevel = functionalLocationLevel;
            return assetMaintenanceParameters;
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
        /// There are no comments for Property WorkOrderReportLanguage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkOrderReportLanguage")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetProductReportLanguage> WorkOrderReportLanguage
        {
            get
            {
                return this._WorkOrderReportLanguage;
            }
            set
            {
                this.OnWorkOrderReportLanguageChanging(value);
                this._WorkOrderReportLanguage = value;
                this.OnWorkOrderReportLanguageChanged();
                this.OnPropertyChanged("WorkOrderReportLanguage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetProductReportLanguage> _WorkOrderReportLanguage;
        partial void OnWorkOrderReportLanguageChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetProductReportLanguage> value);
        partial void OnWorkOrderReportLanguageChanged();
        /// <summary>
        /// There are no comments for Property DefaultRequestTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultRequestTypeId")]
        public virtual string DefaultRequestTypeId
        {
            get
            {
                return this._DefaultRequestTypeId;
            }
            set
            {
                this.OnDefaultRequestTypeIdChanging(value);
                this._DefaultRequestTypeId = value;
                this.OnDefaultRequestTypeIdChanged();
                this.OnPropertyChanged("DefaultRequestTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultRequestTypeId;
        partial void OnDefaultRequestTypeIdChanging(string value);
        partial void OnDefaultRequestTypeIdChanged();
        /// <summary>
        /// There are no comments for Property BingKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BingKey")]
        public virtual string BingKey
        {
            get
            {
                return this._BingKey;
            }
            set
            {
                this.OnBingKeyChanging(value);
                this._BingKey = value;
                this.OnBingKeyChanged();
                this.OnPropertyChanged("BingKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BingKey;
        partial void OnBingKeyChanging(string value);
        partial void OnBingKeyChanged();
        /// <summary>
        /// There are no comments for Property CostCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostCategory")]
        public virtual string CostCategory
        {
            get
            {
                return this._CostCategory;
            }
            set
            {
                this.OnCostCategoryChanging(value);
                this._CostCategory = value;
                this.OnCostCategoryChanged();
                this.OnPropertyChanged("CostCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostCategory;
        partial void OnCostCategoryChanging(string value);
        partial void OnCostCategoryChanged();
        /// <summary>
        /// There are no comments for Property EmplCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmplCategory")]
        public virtual string EmplCategory
        {
            get
            {
                return this._EmplCategory;
            }
            set
            {
                this.OnEmplCategoryChanging(value);
                this._EmplCategory = value;
                this.OnEmplCategoryChanged();
                this.OnPropertyChanged("EmplCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmplCategory;
        partial void OnEmplCategoryChanging(string value);
        partial void OnEmplCategoryChanged();
        /// <summary>
        /// There are no comments for Property JournalExpense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalExpense")]
        public virtual string JournalExpense
        {
            get
            {
                return this._JournalExpense;
            }
            set
            {
                this.OnJournalExpenseChanging(value);
                this._JournalExpense = value;
                this.OnJournalExpenseChanged();
                this.OnPropertyChanged("JournalExpense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalExpense;
        partial void OnJournalExpenseChanging(string value);
        partial void OnJournalExpenseChanged();
        /// <summary>
        /// There are no comments for Property JournalHour in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalHour")]
        public virtual string JournalHour
        {
            get
            {
                return this._JournalHour;
            }
            set
            {
                this.OnJournalHourChanging(value);
                this._JournalHour = value;
                this.OnJournalHourChanged();
                this.OnPropertyChanged("JournalHour");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalHour;
        partial void OnJournalHourChanging(string value);
        partial void OnJournalHourChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderRelatedFormat in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkOrderRelatedFormat")]
        public virtual string WorkOrderRelatedFormat
        {
            get
            {
                return this._WorkOrderRelatedFormat;
            }
            set
            {
                this.OnWorkOrderRelatedFormatChanging(value);
                this._WorkOrderRelatedFormat = value;
                this.OnWorkOrderRelatedFormatChanged();
                this.OnPropertyChanged("WorkOrderRelatedFormat");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderRelatedFormat;
        partial void OnWorkOrderRelatedFormatChanging(string value);
        partial void OnWorkOrderRelatedFormatChanged();
        /// <summary>
        /// There are no comments for Property ItemCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCategory")]
        public virtual string ItemCategory
        {
            get
            {
                return this._ItemCategory;
            }
            set
            {
                this.OnItemCategoryChanging(value);
                this._ItemCategory = value;
                this.OnItemCategoryChanged();
                this.OnPropertyChanged("ItemCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemCategory;
        partial void OnItemCategoryChanging(string value);
        partial void OnItemCategoryChanged();
        /// <summary>
        /// There are no comments for Property StandardCalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StandardCalendarId")]
        public virtual string StandardCalendarId
        {
            get
            {
                return this._StandardCalendarId;
            }
            set
            {
                this.OnStandardCalendarIdChanging(value);
                this._StandardCalendarId = value;
                this.OnStandardCalendarIdChanged();
                this.OnPropertyChanged("StandardCalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StandardCalendarId;
        partial void OnStandardCalendarIdChanging(string value);
        partial void OnStandardCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderCopyFault2Request in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WorkOrderCopyFault2Request")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WorkOrderCopyFault2Request
        {
            get
            {
                return this._WorkOrderCopyFault2Request;
            }
            set
            {
                this.OnWorkOrderCopyFault2RequestChanging(value);
                this._WorkOrderCopyFault2Request = value;
                this.OnWorkOrderCopyFault2RequestChanged();
                this.OnPropertyChanged("WorkOrderCopyFault2Request");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WorkOrderCopyFault2Request;
        partial void OnWorkOrderCopyFault2RequestChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWorkOrderCopyFault2RequestChanged();
        /// <summary>
        /// There are no comments for Property JournalItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalItem")]
        public virtual string JournalItem
        {
            get
            {
                return this._JournalItem;
            }
            set
            {
                this.OnJournalItemChanging(value);
                this._JournalItem = value;
                this.OnJournalItemChanged();
                this.OnPropertyChanged("JournalItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalItem;
        partial void OnJournalItemChanging(string value);
        partial void OnJournalItemChanged();
        /// <summary>
        /// There are no comments for Property FunctionalLocationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FunctionalLocationLevel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FunctionalLocationLevel is required.")]
        public virtual int FunctionalLocationLevel
        {
            get
            {
                return this._FunctionalLocationLevel;
            }
            set
            {
                this.OnFunctionalLocationLevelChanging(value);
                this._FunctionalLocationLevel = value;
                this.OnFunctionalLocationLevelChanged();
                this.OnPropertyChanged("FunctionalLocationLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FunctionalLocationLevel;
        partial void OnFunctionalLocationLevelChanging(int value);
        partial void OnFunctionalLocationLevelChanged();
        /// <summary>
        /// There are no comments for Property ForecastModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForecastModelId")]
        public virtual string ForecastModelId
        {
            get
            {
                return this._ForecastModelId;
            }
            set
            {
                this.OnForecastModelIdChanging(value);
                this._ForecastModelId = value;
                this.OnForecastModelIdChanged();
                this.OnPropertyChanged("ForecastModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForecastModelId;
        partial void OnForecastModelIdChanging(string value);
        partial void OnForecastModelIdChanged();
        /// <summary>
        /// There are no comments for Property PreventiveWorkOrderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PreventiveWorkOrderTypeId")]
        public virtual string PreventiveWorkOrderTypeId
        {
            get
            {
                return this._PreventiveWorkOrderTypeId;
            }
            set
            {
                this.OnPreventiveWorkOrderTypeIdChanging(value);
                this._PreventiveWorkOrderTypeId = value;
                this.OnPreventiveWorkOrderTypeIdChanged();
                this.OnPropertyChanged("PreventiveWorkOrderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PreventiveWorkOrderTypeId;
        partial void OnPreventiveWorkOrderTypeIdChanging(string value);
        partial void OnPreventiveWorkOrderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property StandardMaintenanceAssetViewType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StandardMaintenanceAssetViewType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectViewType> StandardMaintenanceAssetViewType
        {
            get
            {
                return this._StandardMaintenanceAssetViewType;
            }
            set
            {
                this.OnStandardMaintenanceAssetViewTypeChanging(value);
                this._StandardMaintenanceAssetViewType = value;
                this.OnStandardMaintenanceAssetViewTypeChanged();
                this.OnPropertyChanged("StandardMaintenanceAssetViewType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectViewType> _StandardMaintenanceAssetViewType;
        partial void OnStandardMaintenanceAssetViewTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetObjectViewType> value);
        partial void OnStandardMaintenanceAssetViewTypeChanged();
        /// <summary>
        /// There are no comments for Property FunctionalLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FunctionalLocationId")]
        public virtual string FunctionalLocationId
        {
            get
            {
                return this._FunctionalLocationId;
            }
            set
            {
                this.OnFunctionalLocationIdChanging(value);
                this._FunctionalLocationId = value;
                this.OnFunctionalLocationIdChanged();
                this.OnPropertyChanged("FunctionalLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationId;
        partial void OnFunctionalLocationIdChanging(string value);
        partial void OnFunctionalLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ProjIdForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjIdForecast")]
        public virtual string ProjIdForecast
        {
            get
            {
                return this._ProjIdForecast;
            }
            set
            {
                this.OnProjIdForecastChanging(value);
                this._ProjIdForecast = value;
                this.OnProjIdForecastChanged();
                this.OnPropertyChanged("ProjIdForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjIdForecast;
        partial void OnProjIdForecastChanging(string value);
        partial void OnProjIdForecastChanged();
        /// <summary>
        /// There are no comments for Property DefaultWorkOrderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultWorkOrderTypeId")]
        public virtual string DefaultWorkOrderTypeId
        {
            get
            {
                return this._DefaultWorkOrderTypeId;
            }
            set
            {
                this.OnDefaultWorkOrderTypeIdChanging(value);
                this._DefaultWorkOrderTypeId = value;
                this.OnDefaultWorkOrderTypeIdChanged();
                this.OnPropertyChanged("DefaultWorkOrderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultWorkOrderTypeId;
        partial void OnDefaultWorkOrderTypeIdChanging(string value);
        partial void OnDefaultWorkOrderTypeIdChanged();
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