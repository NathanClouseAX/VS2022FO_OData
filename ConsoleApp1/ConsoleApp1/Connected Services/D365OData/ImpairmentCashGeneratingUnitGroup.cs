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
    /// There are no comments for ImpairmentCashGeneratingUnitGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ImpairmentCashGeneratingUnitGroupSingle")]
    public partial class ImpairmentCashGeneratingUnitGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ImpairmentCashGeneratingUnitGroup>
    {
        /// <summary>
        /// Initialize a new ImpairmentCashGeneratingUnitGroupSingle object.
        /// </summary>
        public ImpairmentCashGeneratingUnitGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ImpairmentCashGeneratingUnitGroupSingle object.
        /// </summary>
        public ImpairmentCashGeneratingUnitGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ImpairmentCashGeneratingUnitGroupSingle object.
        /// </summary>
        public ImpairmentCashGeneratingUnitGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ImpairmentCashGeneratingUnitGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CGUGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CGUGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit> CGUGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CGUGroups == null))
                {
                    this._CGUGroups = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit>(GetPath("CGUGroups"));
                }
                return this._CGUGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit> _CGUGroups;
        /// <summary>
        /// There are no comments for AssetImpairmentCashGeneratingUnitSharedAssetsAllocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetImpairmentCashGeneratingUnitSharedAssetsAllocation")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> AssetImpairmentCashGeneratingUnitSharedAssetsAllocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetImpairmentCashGeneratingUnitSharedAssetsAllocation == null))
                {
                    this._AssetImpairmentCashGeneratingUnitSharedAssetsAllocation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation>(GetPath("AssetImpairmentCashGeneratingUnitSharedAssetsAllocation"));
                }
                return this._AssetImpairmentCashGeneratingUnitSharedAssetsAllocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> _AssetImpairmentCashGeneratingUnitSharedAssetsAllocation;
    }
    /// <summary>
    /// There are no comments for ImpairmentCashGeneratingUnitGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CGUGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CGUGroup")]
    [global::Microsoft.OData.Client.EntitySet("ImpairmentCashGeneratingUnitGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ImpairmentCashGeneratingUnitGroup")]
    public partial class ImpairmentCashGeneratingUnitGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ImpairmentCashGeneratingUnitGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="cGUGroup">Initial value of CGUGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ImpairmentCashGeneratingUnitGroup CreateImpairmentCashGeneratingUnitGroup(string dataAreaId, string cGUGroup)
        {
            ImpairmentCashGeneratingUnitGroup impairmentCashGeneratingUnitGroup = new ImpairmentCashGeneratingUnitGroup();
            impairmentCashGeneratingUnitGroup.DataAreaId = dataAreaId;
            impairmentCashGeneratingUnitGroup.CGUGroup = cGUGroup;
            return impairmentCashGeneratingUnitGroup;
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
        /// There are no comments for Property CGUGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CGUGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CGUGroup is required.")]
        public virtual string CGUGroup
        {
            get
            {
                return this._CGUGroup;
            }
            set
            {
                this.OnCGUGroupChanging(value);
                this._CGUGroup = value;
                this.OnCGUGroupChanged();
                this.OnPropertyChanged("CGUGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CGUGroup;
        partial void OnCGUGroupChanging(string value);
        partial void OnCGUGroupChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCGUGroupStatus_JP> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCGUGroupStatus_JP> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCGUGroupStatus_JP> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ImpairmentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ImpairmentMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetsMethod_JP> ImpairmentMethod
        {
            get
            {
                return this._ImpairmentMethod;
            }
            set
            {
                this.OnImpairmentMethodChanging(value);
                this._ImpairmentMethod = value;
                this.OnImpairmentMethodChanged();
                this.OnPropertyChanged("ImpairmentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetsMethod_JP> _ImpairmentMethod;
        partial void OnImpairmentMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetsMethod_JP> value);
        partial void OnImpairmentMethodChanged();
        /// <summary>
        /// There are no comments for Property ProrationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProrationMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetAllocBasis_JP> ProrationMethod
        {
            get
            {
                return this._ProrationMethod;
            }
            set
            {
                this.OnProrationMethodChanging(value);
                this._ProrationMethod = value;
                this.OnProrationMethodChanged();
                this.OnPropertyChanged("ProrationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetAllocBasis_JP> _ProrationMethod;
        partial void OnProrationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetAllocBasis_JP> value);
        partial void OnProrationMethodChanged();
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
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingLayer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
        /// <summary>
        /// There are no comments for Property SharedAssetHasHigherPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SharedAssetHasHigherPriority")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetPriority_JP> SharedAssetHasHigherPriority
        {
            get
            {
                return this._SharedAssetHasHigherPriority;
            }
            set
            {
                this.OnSharedAssetHasHigherPriorityChanging(value);
                this._SharedAssetHasHigherPriority = value;
                this.OnSharedAssetHasHigherPriorityChanged();
                this.OnPropertyChanged("SharedAssetHasHigherPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetPriority_JP> _SharedAssetHasHigherPriority;
        partial void OnSharedAssetHasHigherPriorityChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetImpairmentSharedAssetPriority_JP> value);
        partial void OnSharedAssetHasHigherPriorityChanged();
        /// <summary>
        /// There are no comments for Property CGUGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CGUGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit> CGUGroups
        {
            get
            {
                return this._CGUGroups;
            }
            set
            {
                this.OnCGUGroupsChanging(value);
                this._CGUGroups = value;
                this.OnCGUGroupsChanged();
                this.OnPropertyChanged("CGUGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit> _CGUGroups = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCGUGroupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnit> value);
        partial void OnCGUGroupsChanged();
        /// <summary>
        /// There are no comments for Property AssetImpairmentCashGeneratingUnitSharedAssetsAllocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetImpairmentCashGeneratingUnitSharedAssetsAllocation")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> AssetImpairmentCashGeneratingUnitSharedAssetsAllocation
        {
            get
            {
                return this._AssetImpairmentCashGeneratingUnitSharedAssetsAllocation;
            }
            set
            {
                this.OnAssetImpairmentCashGeneratingUnitSharedAssetsAllocationChanging(value);
                this._AssetImpairmentCashGeneratingUnitSharedAssetsAllocation = value;
                this.OnAssetImpairmentCashGeneratingUnitSharedAssetsAllocationChanged();
                this.OnPropertyChanged("AssetImpairmentCashGeneratingUnitSharedAssetsAllocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> _AssetImpairmentCashGeneratingUnitSharedAssetsAllocation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetImpairmentCashGeneratingUnitSharedAssetsAllocationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> value);
        partial void OnAssetImpairmentCashGeneratingUnitSharedAssetsAllocationChanged();
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
