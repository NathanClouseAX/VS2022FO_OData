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
    /// There are no comments for AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle")]
    public partial class AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetImpairmentCashGeneratingUnitSharedAssetsAllocation>
    {
        /// <summary>
        /// Initialize a new AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle object.
        /// </summary>
        public AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle object.
        /// </summary>
        public AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle object.
        /// </summary>
        public AssetImpairmentCashGeneratingUnitSharedAssetsAllocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetImpairmentCashGeneratingUnitSharedAssetsAllocation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ImpairmentCashGeneratingUnitGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ImpairmentCashGeneratingUnitGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroupSingle ImpairmentCashGeneratingUnitGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ImpairmentCashGeneratingUnitGroup == null))
                {
                    this._ImpairmentCashGeneratingUnitGroup = new global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroupSingle(this.Context, GetPath("ImpairmentCashGeneratingUnitGroup"));
                }
                return this._ImpairmentCashGeneratingUnitGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroupSingle _ImpairmentCashGeneratingUnitGroup;
    }
    /// <summary>
    /// There are no comments for AssetImpairmentCashGeneratingUnitSharedAssetsAllocation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CGUGroupName
    /// SharedAssetId
    /// SharedAssetBookId
    /// CashGeneratingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CGUGroupName", "SharedAssetId", "SharedAssetBookId", "CashGeneratingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetImpairmentCashGeneratingUnitSharedAssetsAllocations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetImpairmentCashGeneratingUnitSharedAssetsAllocation")]
    public partial class AssetImpairmentCashGeneratingUnitSharedAssetsAllocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetImpairmentCashGeneratingUnitSharedAssetsAllocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="cGUGroupName">Initial value of CGUGroupName.</param>
        /// <param name="sharedAssetId">Initial value of SharedAssetId.</param>
        /// <param name="sharedAssetBookId">Initial value of SharedAssetBookId.</param>
        /// <param name="cashGeneratingUnitNumber">Initial value of CashGeneratingUnitNumber.</param>
        /// <param name="proportion">Initial value of Proportion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetImpairmentCashGeneratingUnitSharedAssetsAllocation CreateAssetImpairmentCashGeneratingUnitSharedAssetsAllocation(string dataAreaId, 
                    string cGUGroupName, 
                    string sharedAssetId, 
                    string sharedAssetBookId, 
                    string cashGeneratingUnitNumber, 
                    decimal proportion)
        {
            AssetImpairmentCashGeneratingUnitSharedAssetsAllocation assetImpairmentCashGeneratingUnitSharedAssetsAllocation = new AssetImpairmentCashGeneratingUnitSharedAssetsAllocation();
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.DataAreaId = dataAreaId;
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.CGUGroupName = cGUGroupName;
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.SharedAssetId = sharedAssetId;
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.SharedAssetBookId = sharedAssetBookId;
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.CashGeneratingUnitNumber = cashGeneratingUnitNumber;
            assetImpairmentCashGeneratingUnitSharedAssetsAllocation.Proportion = proportion;
            return assetImpairmentCashGeneratingUnitSharedAssetsAllocation;
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
        /// There are no comments for Property CGUGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CGUGroupName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CGUGroupName is required.")]
        public virtual string CGUGroupName
        {
            get
            {
                return this._CGUGroupName;
            }
            set
            {
                this.OnCGUGroupNameChanging(value);
                this._CGUGroupName = value;
                this.OnCGUGroupNameChanged();
                this.OnPropertyChanged("CGUGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CGUGroupName;
        partial void OnCGUGroupNameChanging(string value);
        partial void OnCGUGroupNameChanged();
        /// <summary>
        /// There are no comments for Property SharedAssetId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SharedAssetId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SharedAssetId is required.")]
        public virtual string SharedAssetId
        {
            get
            {
                return this._SharedAssetId;
            }
            set
            {
                this.OnSharedAssetIdChanging(value);
                this._SharedAssetId = value;
                this.OnSharedAssetIdChanged();
                this.OnPropertyChanged("SharedAssetId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SharedAssetId;
        partial void OnSharedAssetIdChanging(string value);
        partial void OnSharedAssetIdChanged();
        /// <summary>
        /// There are no comments for Property SharedAssetBookId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SharedAssetBookId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SharedAssetBookId is required.")]
        public virtual string SharedAssetBookId
        {
            get
            {
                return this._SharedAssetBookId;
            }
            set
            {
                this.OnSharedAssetBookIdChanging(value);
                this._SharedAssetBookId = value;
                this.OnSharedAssetBookIdChanged();
                this.OnPropertyChanged("SharedAssetBookId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SharedAssetBookId;
        partial void OnSharedAssetBookIdChanging(string value);
        partial void OnSharedAssetBookIdChanged();
        /// <summary>
        /// There are no comments for Property CashGeneratingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CashGeneratingUnitNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CashGeneratingUnitNumber is required.")]
        public virtual string CashGeneratingUnitNumber
        {
            get
            {
                return this._CashGeneratingUnitNumber;
            }
            set
            {
                this.OnCashGeneratingUnitNumberChanging(value);
                this._CashGeneratingUnitNumber = value;
                this.OnCashGeneratingUnitNumberChanged();
                this.OnPropertyChanged("CashGeneratingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashGeneratingUnitNumber;
        partial void OnCashGeneratingUnitNumberChanging(string value);
        partial void OnCashGeneratingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property Proportion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Proportion")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Proportion is required.")]
        public virtual decimal Proportion
        {
            get
            {
                return this._Proportion;
            }
            set
            {
                this.OnProportionChanging(value);
                this._Proportion = value;
                this.OnProportionChanged();
                this.OnPropertyChanged("Proportion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Proportion;
        partial void OnProportionChanging(decimal value);
        partial void OnProportionChanged();
        /// <summary>
        /// There are no comments for Property ImpairmentCashGeneratingUnitGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ImpairmentCashGeneratingUnitGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroup ImpairmentCashGeneratingUnitGroup
        {
            get
            {
                return this._ImpairmentCashGeneratingUnitGroup;
            }
            set
            {
                this.OnImpairmentCashGeneratingUnitGroupChanging(value);
                this._ImpairmentCashGeneratingUnitGroup = value;
                this.OnImpairmentCashGeneratingUnitGroupChanged();
                this.OnPropertyChanged("ImpairmentCashGeneratingUnitGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroup _ImpairmentCashGeneratingUnitGroup;
        partial void OnImpairmentCashGeneratingUnitGroupChanging(global::Microsoft.Dynamics.DataEntities.ImpairmentCashGeneratingUnitGroup value);
        partial void OnImpairmentCashGeneratingUnitGroupChanged();
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
