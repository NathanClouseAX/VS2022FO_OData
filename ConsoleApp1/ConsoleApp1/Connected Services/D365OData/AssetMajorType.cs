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
    /// There are no comments for AssetMajorTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMajorTypeSingle")]
    public partial class AssetMajorTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMajorType>
    {
        /// <summary>
        /// Initialize a new AssetMajorTypeSingle object.
        /// </summary>
        public AssetMajorTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMajorTypeSingle object.
        /// </summary>
        public AssetMajorTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMajorTypeSingle object.
        /// </summary>
        public AssetMajorTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMajorType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FixedAssetGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedAssetGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle FixedAssetGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAssetGroup == null))
                {
                    this._FixedAssetGroup = new global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle(this.Context, GetPath("FixedAssetGroup"));
                }
                return this._FixedAssetGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetGroupSingle _FixedAssetGroup;
    }
    /// <summary>
    /// There are no comments for AssetMajorType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// MajorTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MajorTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMajorTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMajorType")]
    public partial class AssetMajorType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMajorType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="majorTypeId">Initial value of MajorTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMajorType CreateAssetMajorType(string dataAreaId, string majorTypeId)
        {
            AssetMajorType assetMajorType = new AssetMajorType();
            assetMajorType.DataAreaId = dataAreaId;
            assetMajorType.MajorTypeId = majorTypeId;
            return assetMajorType;
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
        /// There are no comments for Property MajorTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MajorTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MajorTypeId is required.")]
        public virtual string MajorTypeId
        {
            get
            {
                return this._MajorTypeId;
            }
            set
            {
                this.OnMajorTypeIdChanging(value);
                this._MajorTypeId = value;
                this.OnMajorTypeIdChanged();
                this.OnPropertyChanged("MajorTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MajorTypeId;
        partial void OnMajorTypeIdChanging(string value);
        partial void OnMajorTypeIdChanged();
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
        /// There are no comments for Property AssetType_JP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetType_JP")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetType_JP> AssetType_JP
        {
            get
            {
                return this._AssetType_JP;
            }
            set
            {
                this.OnAssetType_JPChanging(value);
                this._AssetType_JP = value;
                this.OnAssetType_JPChanged();
                this.OnPropertyChanged("AssetType_JP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetType_JP> _AssetType_JP;
        partial void OnAssetType_JPChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetType_JP> value);
        partial void OnAssetType_JPChanged();
        /// <summary>
        /// There are no comments for Property FixedAssetGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedAssetGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetGroup FixedAssetGroup
        {
            get
            {
                return this._FixedAssetGroup;
            }
            set
            {
                this.OnFixedAssetGroupChanging(value);
                this._FixedAssetGroup = value;
                this.OnFixedAssetGroupChanged();
                this.OnPropertyChanged("FixedAssetGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetGroup _FixedAssetGroup;
        partial void OnFixedAssetGroupChanging(global::Microsoft.Dynamics.DataEntities.FixedAssetGroup value);
        partial void OnFixedAssetGroupChanged();
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
