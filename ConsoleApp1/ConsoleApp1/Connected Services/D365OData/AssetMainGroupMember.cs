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
    /// There are no comments for AssetMainGroupMemberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMainGroupMemberSingle")]
    public partial class AssetMainGroupMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMainGroupMember>
    {
        /// <summary>
        /// Initialize a new AssetMainGroupMemberSingle object.
        /// </summary>
        public AssetMainGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMainGroupMemberSingle object.
        /// </summary>
        public AssetMainGroupMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMainGroupMemberSingle object.
        /// </summary>
        public AssetMainGroupMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMainGroupMember> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AssetMainGroupMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FAGroup
    /// ValueModel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FAGroup", "ValueModel")]
    [global::Microsoft.OData.Client.EntitySet("AssetMainGroupMembers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetMainGroupMember")]
    public partial class AssetMainGroupMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMainGroupMember object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fAGroup">Initial value of FAGroup.</param>
        /// <param name="valueModel">Initial value of ValueModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMainGroupMember CreateAssetMainGroupMember(string dataAreaId, string fAGroup, string valueModel)
        {
            AssetMainGroupMember assetMainGroupMember = new AssetMainGroupMember();
            assetMainGroupMember.DataAreaId = dataAreaId;
            assetMainGroupMember.FAGroup = fAGroup;
            assetMainGroupMember.ValueModel = valueModel;
            return assetMainGroupMember;
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
        /// There are no comments for Property FAGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FAGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FAGroup is required.")]
        public virtual string FAGroup
        {
            get
            {
                return this._FAGroup;
            }
            set
            {
                this.OnFAGroupChanging(value);
                this._FAGroup = value;
                this.OnFAGroupChanged();
                this.OnPropertyChanged("FAGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FAGroup;
        partial void OnFAGroupChanging(string value);
        partial void OnFAGroupChanged();
        /// <summary>
        /// There are no comments for Property ValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValueModel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValueModel is required.")]
        public virtual string ValueModel
        {
            get
            {
                return this._ValueModel;
            }
            set
            {
                this.OnValueModelChanging(value);
                this._ValueModel = value;
                this.OnValueModelChanged();
                this.OnPropertyChanged("ValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueModel;
        partial void OnValueModelChanging(string value);
        partial void OnValueModelChanged();
        /// <summary>
        /// There are no comments for Property DepreciationGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationGroup")]
        public virtual string DepreciationGroup
        {
            get
            {
                return this._DepreciationGroup;
            }
            set
            {
                this.OnDepreciationGroupChanging(value);
                this._DepreciationGroup = value;
                this.OnDepreciationGroupChanged();
                this.OnPropertyChanged("DepreciationGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationGroup;
        partial void OnDepreciationGroupChanging(string value);
        partial void OnDepreciationGroupChanged();
        /// <summary>
        /// There are no comments for Property ServiceLifeByRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceLifeByRate")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ServiceLifeByRate
        {
            get
            {
                return this._ServiceLifeByRate;
            }
            set
            {
                this.OnServiceLifeByRateChanging(value);
                this._ServiceLifeByRate = value;
                this.OnServiceLifeByRateChanged();
                this.OnPropertyChanged("ServiceLifeByRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ServiceLifeByRate;
        partial void OnServiceLifeByRateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnServiceLifeByRateChanged();
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
