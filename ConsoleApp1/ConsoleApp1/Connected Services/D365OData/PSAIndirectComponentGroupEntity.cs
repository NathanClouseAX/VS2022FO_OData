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
    /// There are no comments for PSAIndirectComponentGroupEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PSAIndirectComponentGroupEntitySingle")]
    public partial class PSAIndirectComponentGroupEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PSAIndirectComponentGroupEntity>
    {
        /// <summary>
        /// Initialize a new PSAIndirectComponentGroupEntitySingle object.
        /// </summary>
        public PSAIndirectComponentGroupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PSAIndirectComponentGroupEntitySingle object.
        /// </summary>
        public PSAIndirectComponentGroupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PSAIndirectComponentGroupEntitySingle object.
        /// </summary>
        public PSAIndirectComponentGroupEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PSAIndirectComponentGroupEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PSAIndirectComponentGroupEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// IndirectCostComponentGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "IndirectCostComponentGroup")]
    [global::Microsoft.OData.Client.EntitySet("PSAIndirectComponentGroupEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PSAIndirectComponentGroupEntity")]
    public partial class PSAIndirectComponentGroupEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PSAIndirectComponentGroupEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="indirectCostComponentGroup">Initial value of IndirectCostComponentGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PSAIndirectComponentGroupEntity CreatePSAIndirectComponentGroupEntity(string dataAreaId, string indirectCostComponentGroup)
        {
            PSAIndirectComponentGroupEntity pSAIndirectComponentGroupEntity = new PSAIndirectComponentGroupEntity();
            pSAIndirectComponentGroupEntity.DataAreaId = dataAreaId;
            pSAIndirectComponentGroupEntity.IndirectCostComponentGroup = indirectCostComponentGroup;
            return pSAIndirectComponentGroupEntity;
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
        /// There are no comments for Property IndirectCostComponentGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IndirectCostComponentGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IndirectCostComponentGroup is required.")]
        public virtual string IndirectCostComponentGroup
        {
            get
            {
                return this._IndirectCostComponentGroup;
            }
            set
            {
                this.OnIndirectCostComponentGroupChanging(value);
                this._IndirectCostComponentGroup = value;
                this.OnIndirectCostComponentGroupChanged();
                this.OnPropertyChanged("IndirectCostComponentGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IndirectCostComponentGroup;
        partial void OnIndirectCostComponentGroupChanging(string value);
        partial void OnIndirectCostComponentGroupChanged();
        /// <summary>
        /// There are no comments for Property IndirectComponentGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IndirectComponentGroupName")]
        public virtual string IndirectComponentGroupName
        {
            get
            {
                return this._IndirectComponentGroupName;
            }
            set
            {
                this.OnIndirectComponentGroupNameChanging(value);
                this._IndirectComponentGroupName = value;
                this.OnIndirectComponentGroupNameChanged();
                this.OnPropertyChanged("IndirectComponentGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IndirectComponentGroupName;
        partial void OnIndirectComponentGroupNameChanging(string value);
        partial void OnIndirectComponentGroupNameChanged();
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