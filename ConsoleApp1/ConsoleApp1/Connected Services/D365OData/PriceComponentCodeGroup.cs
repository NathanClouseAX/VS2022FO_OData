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
    /// There are no comments for PriceComponentCodeGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeGroupSingle")]
    public partial class PriceComponentCodeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCodeGroup>
    {
        /// <summary>
        /// Initialize a new PriceComponentCodeGroupSingle object.
        /// </summary>
        public PriceComponentCodeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeGroupSingle object.
        /// </summary>
        public PriceComponentCodeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeGroupSingle object.
        /// </summary>
        public PriceComponentCodeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCodeGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PriceComponentCodeGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PriceComponentCodeGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PriceComponentCodeGroup")]
    [global::Microsoft.OData.Client.EntitySet("PriceComponentCodeGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeGroup")]
    public partial class PriceComponentCodeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PriceComponentCodeGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="priceComponentCodeGroup1">Initial value of PriceComponentCodeGroup1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PriceComponentCodeGroup CreatePriceComponentCodeGroup(string dataAreaId, string priceComponentCodeGroup1)
        {
            PriceComponentCodeGroup priceComponentCodeGroup = new PriceComponentCodeGroup();
            priceComponentCodeGroup.DataAreaId = dataAreaId;
            priceComponentCodeGroup.PriceComponentCodeGroup1 = priceComponentCodeGroup1;
            return priceComponentCodeGroup;
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
        /// There are no comments for Property PriceComponentCodeGroup1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceComponentCodeGroup1 is required.")]
        public virtual string PriceComponentCodeGroup1
        {
            get
            {
                return this._PriceComponentCodeGroup1;
            }
            set
            {
                this.OnPriceComponentCodeGroup1Changing(value);
                this._PriceComponentCodeGroup1 = value;
                this.OnPriceComponentCodeGroup1Changed();
                this.OnPropertyChanged("PriceComponentCodeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceComponentCodeGroup1;
        partial void OnPriceComponentCodeGroup1Changing(string value);
        partial void OnPriceComponentCodeGroup1Changed();
        /// <summary>
        /// There are no comments for Property PriceComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponent")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> PriceComponent
        {
            get
            {
                return this._PriceComponent;
            }
            set
            {
                this.OnPriceComponentChanging(value);
                this._PriceComponent = value;
                this.OnPriceComponentChanged();
                this.OnPropertyChanged("PriceComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> _PriceComponent;
        partial void OnPriceComponentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> value);
        partial void OnPriceComponentChanged();
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
