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
    /// There are no comments for ItemSpecificBillOfMaterialsHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemSpecificBillOfMaterialsHeaderSingle")]
    public partial class ItemSpecificBillOfMaterialsHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemSpecificBillOfMaterialsHeader>
    {
        /// <summary>
        /// Initialize a new ItemSpecificBillOfMaterialsHeaderSingle object.
        /// </summary>
        public ItemSpecificBillOfMaterialsHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemSpecificBillOfMaterialsHeaderSingle object.
        /// </summary>
        public ItemSpecificBillOfMaterialsHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemSpecificBillOfMaterialsHeaderSingle object.
        /// </summary>
        public ItemSpecificBillOfMaterialsHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemSpecificBillOfMaterialsHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle ProductionSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductionSite == null))
                {
                    this._ProductionSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("ProductionSite"));
                }
                return this._ProductionSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _ProductionSite;
        /// <summary>
        /// There are no comments for ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovingWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApprovingWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovingWorker == null))
                {
                    this._ApprovingWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApprovingWorker"));
                }
                return this._ApprovingWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApprovingWorker;
    }
    /// <summary>
    /// There are no comments for ItemSpecificBillOfMaterialsHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// BOMId
    /// ManufacturedItemNumber
    /// ProductionSiteId
    /// ProductColorId
    /// ProductConfigurationId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "BOMId", "ManufacturedItemNumber", "ProductionSiteId", "ProductColorId", "ProductConfigurationId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("ItemSpecificBillOfMaterialsHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemSpecificBillOfMaterialsHeader")]
    public partial class ItemSpecificBillOfMaterialsHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemSpecificBillOfMaterialsHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="bOMId">Initial value of BOMId.</param>
        /// <param name="manufacturedItemNumber">Initial value of ManufacturedItemNumber.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemSpecificBillOfMaterialsHeader CreateItemSpecificBillOfMaterialsHeader(string dataAreaId, 
                    string bOMId, 
                    string manufacturedItemNumber, 
                    string productionSiteId, 
                    string productColorId, 
                    string productConfigurationId, 
                    string productSizeId, 
                    string productStyleId)
        {
            ItemSpecificBillOfMaterialsHeader itemSpecificBillOfMaterialsHeader = new ItemSpecificBillOfMaterialsHeader();
            itemSpecificBillOfMaterialsHeader.DataAreaId = dataAreaId;
            itemSpecificBillOfMaterialsHeader.BOMId = bOMId;
            itemSpecificBillOfMaterialsHeader.ManufacturedItemNumber = manufacturedItemNumber;
            itemSpecificBillOfMaterialsHeader.ProductionSiteId = productionSiteId;
            itemSpecificBillOfMaterialsHeader.ProductColorId = productColorId;
            itemSpecificBillOfMaterialsHeader.ProductConfigurationId = productConfigurationId;
            itemSpecificBillOfMaterialsHeader.ProductSizeId = productSizeId;
            itemSpecificBillOfMaterialsHeader.ProductStyleId = productStyleId;
            return itemSpecificBillOfMaterialsHeader;
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
        /// There are no comments for Property BOMId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BOMId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BOMId is required.")]
        public virtual string BOMId
        {
            get
            {
                return this._BOMId;
            }
            set
            {
                this.OnBOMIdChanging(value);
                this._BOMId = value;
                this.OnBOMIdChanged();
                this.OnPropertyChanged("BOMId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BOMId;
        partial void OnBOMIdChanging(string value);
        partial void OnBOMIdChanged();
        /// <summary>
        /// There are no comments for Property ManufacturedItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManufacturedItemNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ManufacturedItemNumber is required.")]
        public virtual string ManufacturedItemNumber
        {
            get
            {
                return this._ManufacturedItemNumber;
            }
            set
            {
                this.OnManufacturedItemNumberChanging(value);
                this._ManufacturedItemNumber = value;
                this.OnManufacturedItemNumberChanged();
                this.OnPropertyChanged("ManufacturedItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturedItemNumber;
        partial void OnManufacturedItemNumberChanging(string value);
        partial void OnManufacturedItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductionSiteId is required.")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductColorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductColorId is required.")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductConfigurationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductConfigurationId is required.")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSizeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductSizeId is required.")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductStyleId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductStyleId is required.")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property BOMName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BOMName")]
        public virtual string BOMName
        {
            get
            {
                return this._BOMName;
            }
            set
            {
                this.OnBOMNameChanging(value);
                this._BOMName = value;
                this.OnBOMNameChanged();
                this.OnPropertyChanged("BOMName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BOMName;
        partial void OnBOMNameChanging(string value);
        partial void OnBOMNameChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverPersonnelNumber")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsApproved")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property EngChgEngineeringBomReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngChgEngineeringBomReference")]
        public virtual string EngChgEngineeringBomReference
        {
            get
            {
                return this._EngChgEngineeringBomReference;
            }
            set
            {
                this.OnEngChgEngineeringBomReferenceChanging(value);
                this._EngChgEngineeringBomReference = value;
                this.OnEngChgEngineeringBomReferenceChanged();
                this.OnPropertyChanged("EngChgEngineeringBomReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngChgEngineeringBomReference;
        partial void OnEngChgEngineeringBomReferenceChanging(string value);
        partial void OnEngChgEngineeringBomReferenceChanged();
        /// <summary>
        /// There are no comments for Property EngChgEngineeringVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngChgEngineeringVersion")]
        public virtual string EngChgEngineeringVersion
        {
            get
            {
                return this._EngChgEngineeringVersion;
            }
            set
            {
                this.OnEngChgEngineeringVersionChanging(value);
                this._EngChgEngineeringVersion = value;
                this.OnEngChgEngineeringVersionChanged();
                this.OnPropertyChanged("EngChgEngineeringVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngChgEngineeringVersion;
        partial void OnEngChgEngineeringVersionChanging(string value);
        partial void OnEngChgEngineeringVersionChanged();
        /// <summary>
        /// There are no comments for Property ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSite")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite ProductionSite
        {
            get
            {
                return this._ProductionSite;
            }
            set
            {
                this.OnProductionSiteChanging(value);
                this._ProductionSite = value;
                this.OnProductionSiteChanged();
                this.OnPropertyChanged("ProductionSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _ProductionSite;
        partial void OnProductionSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnProductionSiteChanged();
        /// <summary>
        /// There are no comments for Property ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovingWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApprovingWorker
        {
            get
            {
                return this._ApprovingWorker;
            }
            set
            {
                this.OnApprovingWorkerChanging(value);
                this._ApprovingWorker = value;
                this.OnApprovingWorkerChanged();
                this.OnPropertyChanged("ApprovingWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApprovingWorker;
        partial void OnApprovingWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApprovingWorkerChanged();
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
