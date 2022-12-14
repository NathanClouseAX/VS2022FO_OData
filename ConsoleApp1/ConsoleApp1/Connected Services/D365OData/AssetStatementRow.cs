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
    /// There are no comments for AssetStatementRowSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetStatementRowSingle")]
    public partial class AssetStatementRowSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetStatementRow>
    {
        /// <summary>
        /// Initialize a new AssetStatementRowSingle object.
        /// </summary>
        public AssetStatementRowSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetStatementRowSingle object.
        /// </summary>
        public AssetStatementRowSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetStatementRowSingle object.
        /// </summary>
        public AssetStatementRowSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetStatementRow> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FixedAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedAsset")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAssetSingle FixedAsset
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FixedAsset == null))
                {
                    this._FixedAsset = new global::Microsoft.Dynamics.DataEntities.FixedAssetSingle(this.Context, GetPath("FixedAsset"));
                }
                return this._FixedAsset;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAssetSingle _FixedAsset;
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
    /// There are no comments for AssetStatementRow in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineNumber
    /// FromFixedAssetNumber
    /// ToFixedAssetNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNumber", "FromFixedAssetNumber", "ToFixedAssetNumber")]
    [global::Microsoft.OData.Client.EntitySet("AssetStatementRows")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetStatementRow")]
    public partial class AssetStatementRow : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetStatementRow object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="fromFixedAssetNumber">Initial value of FromFixedAssetNumber.</param>
        /// <param name="toFixedAssetNumber">Initial value of ToFixedAssetNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetStatementRow CreateAssetStatementRow(string dataAreaId, decimal lineNumber, string fromFixedAssetNumber, string toFixedAssetNumber)
        {
            AssetStatementRow assetStatementRow = new AssetStatementRow();
            assetStatementRow.DataAreaId = dataAreaId;
            assetStatementRow.LineNumber = lineNumber;
            assetStatementRow.FromFixedAssetNumber = fromFixedAssetNumber;
            assetStatementRow.ToFixedAssetNumber = toFixedAssetNumber;
            return assetStatementRow;
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
        /// There are no comments for Property FromFixedAssetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromFixedAssetNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromFixedAssetNumber is required.")]
        public virtual string FromFixedAssetNumber
        {
            get
            {
                return this._FromFixedAssetNumber;
            }
            set
            {
                this.OnFromFixedAssetNumberChanging(value);
                this._FromFixedAssetNumber = value;
                this.OnFromFixedAssetNumberChanged();
                this.OnPropertyChanged("FromFixedAssetNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FromFixedAssetNumber;
        partial void OnFromFixedAssetNumberChanging(string value);
        partial void OnFromFixedAssetNumberChanged();
        /// <summary>
        /// There are no comments for Property ToFixedAssetNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToFixedAssetNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToFixedAssetNumber is required.")]
        public virtual string ToFixedAssetNumber
        {
            get
            {
                return this._ToFixedAssetNumber;
            }
            set
            {
                this.OnToFixedAssetNumberChanging(value);
                this._ToFixedAssetNumber = value;
                this.OnToFixedAssetNumberChanged();
                this.OnPropertyChanged("ToFixedAssetNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ToFixedAssetNumber;
        partial void OnToFixedAssetNumberChanging(string value);
        partial void OnToFixedAssetNumberChanged();
        /// <summary>
        /// There are no comments for Property RowName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RowName")]
        public virtual string RowName
        {
            get
            {
                return this._RowName;
            }
            set
            {
                this.OnRowNameChanging(value);
                this._RowName = value;
                this.OnRowNameChanged();
                this.OnPropertyChanged("RowName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RowName;
        partial void OnRowNameChanging(string value);
        partial void OnRowNameChanged();
        /// <summary>
        /// There are no comments for Property AssetIntervalRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetIntervalRelation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetIntervalRelation> AssetIntervalRelation
        {
            get
            {
                return this._AssetIntervalRelation;
            }
            set
            {
                this.OnAssetIntervalRelationChanging(value);
                this._AssetIntervalRelation = value;
                this.OnAssetIntervalRelationChanged();
                this.OnPropertyChanged("AssetIntervalRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetIntervalRelation> _AssetIntervalRelation;
        partial void OnAssetIntervalRelationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.AssetIntervalRelation> value);
        partial void OnAssetIntervalRelationChanged();
        /// <summary>
        /// There are no comments for Property RowType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RowType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RowType> RowType
        {
            get
            {
                return this._RowType;
            }
            set
            {
                this.OnRowTypeChanging(value);
                this._RowType = value;
                this.OnRowTypeChanged();
                this.OnPropertyChanged("RowType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RowType> _RowType;
        partial void OnRowTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RowType> value);
        partial void OnRowTypeChanged();
        /// <summary>
        /// There are no comments for Property FixedAsset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FixedAsset")]
        public virtual global::Microsoft.Dynamics.DataEntities.FixedAsset FixedAsset
        {
            get
            {
                return this._FixedAsset;
            }
            set
            {
                this.OnFixedAssetChanging(value);
                this._FixedAsset = value;
                this.OnFixedAssetChanged();
                this.OnPropertyChanged("FixedAsset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FixedAsset _FixedAsset;
        partial void OnFixedAssetChanging(global::Microsoft.Dynamics.DataEntities.FixedAsset value);
        partial void OnFixedAssetChanged();
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
