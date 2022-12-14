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
    /// There are no comments for SubBillAllocItemStandaloneSellingPriceV2Single in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocItemStandaloneSellingPriceV2Single")]
    public partial class SubBillAllocItemStandaloneSellingPriceV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillAllocItemStandaloneSellingPriceV2>
    {
        /// <summary>
        /// Initialize a new SubBillAllocItemStandaloneSellingPriceV2Single object.
        /// </summary>
        public SubBillAllocItemStandaloneSellingPriceV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillAllocItemStandaloneSellingPriceV2Single object.
        /// </summary>
        public SubBillAllocItemStandaloneSellingPriceV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillAllocItemStandaloneSellingPriceV2Single object.
        /// </summary>
        public SubBillAllocItemStandaloneSellingPriceV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillAllocItemStandaloneSellingPriceV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillAllocItemStandaloneSellingPriceV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LineNum
    /// ItemCode
    /// ItemRelation
    /// RevenueSplit
    /// ParentItem
    /// RetailVariantId
    /// ParentVariant
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNum", "ItemCode", "ItemRelation", "RevenueSplit", "ParentItem", "RetailVariantId", "ParentVariant")]
    [global::Microsoft.OData.Client.EntitySet("SubBillAllocItemStandaloneSellingPricesV2")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocItemStandaloneSellingPriceV2")]
    public partial class SubBillAllocItemStandaloneSellingPriceV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillAllocItemStandaloneSellingPriceV2 object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="itemRelation">Initial value of ItemRelation.</param>
        /// <param name="parentItem">Initial value of ParentItem.</param>
        /// <param name="retailVariantId">Initial value of RetailVariantId.</param>
        /// <param name="parentVariant">Initial value of ParentVariant.</param>
        /// <param name="percent">Initial value of Percent.</param>
        /// <param name="standaloneSellingPrice">Initial value of StandaloneSellingPrice.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillAllocItemStandaloneSellingPriceV2 CreateSubBillAllocItemStandaloneSellingPriceV2(string dataAreaId, 
                    decimal lineNum, 
                    string itemRelation, 
                    string parentItem, 
                    string retailVariantId, 
                    string parentVariant, 
                    decimal percent, 
                    decimal standaloneSellingPrice)
        {
            SubBillAllocItemStandaloneSellingPriceV2 subBillAllocItemStandaloneSellingPriceV2 = new SubBillAllocItemStandaloneSellingPriceV2();
            subBillAllocItemStandaloneSellingPriceV2.DataAreaId = dataAreaId;
            subBillAllocItemStandaloneSellingPriceV2.LineNum = lineNum;
            subBillAllocItemStandaloneSellingPriceV2.ItemRelation = itemRelation;
            subBillAllocItemStandaloneSellingPriceV2.ParentItem = parentItem;
            subBillAllocItemStandaloneSellingPriceV2.RetailVariantId = retailVariantId;
            subBillAllocItemStandaloneSellingPriceV2.ParentVariant = parentVariant;
            subBillAllocItemStandaloneSellingPriceV2.Percent = percent;
            subBillAllocItemStandaloneSellingPriceV2.StandaloneSellingPrice = standaloneSellingPrice;
            return subBillAllocItemStandaloneSellingPriceV2;
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
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> _ItemCode;
        partial void OnItemCodeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventPostingItemCode> value);
        partial void OnItemCodeChanged();
        /// <summary>
        /// There are no comments for Property ItemRelation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemRelation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemRelation is required.")]
        public virtual string ItemRelation
        {
            get
            {
                return this._ItemRelation;
            }
            set
            {
                this.OnItemRelationChanging(value);
                this._ItemRelation = value;
                this.OnItemRelationChanged();
                this.OnPropertyChanged("ItemRelation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemRelation;
        partial void OnItemRelationChanging(string value);
        partial void OnItemRelationChanged();
        /// <summary>
        /// There are no comments for Property RevenueSplit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevenueSplit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RevenueSplit
        {
            get
            {
                return this._RevenueSplit;
            }
            set
            {
                this.OnRevenueSplitChanging(value);
                this._RevenueSplit = value;
                this.OnRevenueSplitChanged();
                this.OnPropertyChanged("RevenueSplit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RevenueSplit;
        partial void OnRevenueSplitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRevenueSplitChanged();
        /// <summary>
        /// There are no comments for Property ParentItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentItem")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentItem is required.")]
        public virtual string ParentItem
        {
            get
            {
                return this._ParentItem;
            }
            set
            {
                this.OnParentItemChanging(value);
                this._ParentItem = value;
                this.OnParentItemChanged();
                this.OnPropertyChanged("ParentItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentItem;
        partial void OnParentItemChanging(string value);
        partial void OnParentItemChanged();
        /// <summary>
        /// There are no comments for Property RetailVariantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailVariantId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailVariantId is required.")]
        public virtual string RetailVariantId
        {
            get
            {
                return this._RetailVariantId;
            }
            set
            {
                this.OnRetailVariantIdChanging(value);
                this._RetailVariantId = value;
                this.OnRetailVariantIdChanged();
                this.OnPropertyChanged("RetailVariantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailVariantId;
        partial void OnRetailVariantIdChanging(string value);
        partial void OnRetailVariantIdChanged();
        /// <summary>
        /// There are no comments for Property ParentVariant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentVariant")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentVariant is required.")]
        public virtual string ParentVariant
        {
            get
            {
                return this._ParentVariant;
            }
            set
            {
                this.OnParentVariantChanging(value);
                this._ParentVariant = value;
                this.OnParentVariantChanged();
                this.OnPropertyChanged("ParentVariant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentVariant;
        partial void OnParentVariantChanging(string value);
        partial void OnParentVariantChanged();
        /// <summary>
        /// There are no comments for Property StandaloneSellingPriceOrigin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StandaloneSellingPriceOrigin")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> StandaloneSellingPriceOrigin
        {
            get
            {
                return this._StandaloneSellingPriceOrigin;
            }
            set
            {
                this.OnStandaloneSellingPriceOriginChanging(value);
                this._StandaloneSellingPriceOrigin = value;
                this.OnStandaloneSellingPriceOriginChanged();
                this.OnPropertyChanged("StandaloneSellingPriceOrigin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> _StandaloneSellingPriceOrigin;
        partial void OnStandaloneSellingPriceOriginChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> value);
        partial void OnStandaloneSellingPriceOriginChanged();
        /// <summary>
        /// There are no comments for Property Percent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Percent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Percent is required.")]
        public virtual decimal Percent
        {
            get
            {
                return this._Percent;
            }
            set
            {
                this.OnPercentChanging(value);
                this._Percent = value;
                this.OnPercentChanged();
                this.OnPropertyChanged("Percent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Percent;
        partial void OnPercentChanging(decimal value);
        partial void OnPercentChanged();
        /// <summary>
        /// There are no comments for Property StandaloneSellingPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StandaloneSellingPrice")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StandaloneSellingPrice is required.")]
        public virtual decimal StandaloneSellingPrice
        {
            get
            {
                return this._StandaloneSellingPrice;
            }
            set
            {
                this.OnStandaloneSellingPriceChanging(value);
                this._StandaloneSellingPrice = value;
                this.OnStandaloneSellingPriceChanged();
                this.OnPropertyChanged("StandaloneSellingPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _StandaloneSellingPrice;
        partial void OnStandaloneSellingPriceChanging(decimal value);
        partial void OnStandaloneSellingPriceChanged();
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
