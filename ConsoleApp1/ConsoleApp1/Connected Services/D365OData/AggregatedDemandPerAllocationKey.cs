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
    /// There are no comments for AggregatedDemandPerAllocationKeySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AggregatedDemandPerAllocationKeySingle")]
    public partial class AggregatedDemandPerAllocationKeySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AggregatedDemandPerAllocationKey>
    {
        /// <summary>
        /// Initialize a new AggregatedDemandPerAllocationKeySingle object.
        /// </summary>
        public AggregatedDemandPerAllocationKeySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AggregatedDemandPerAllocationKeySingle object.
        /// </summary>
        public AggregatedDemandPerAllocationKeySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AggregatedDemandPerAllocationKeySingle object.
        /// </summary>
        public AggregatedDemandPerAllocationKeySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AggregatedDemandPerAllocationKey> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AggregatedDemandPerAllocationKey in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DemandCategory
    /// DeliveringSiteId
    /// ProductAllocationKeyId
    /// DemandDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DemandCategory", "DeliveringSiteId", "ProductAllocationKeyId", "DemandDate")]
    [global::Microsoft.OData.Client.EntitySet("AggregatedDemandsPerAllocationKey")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AggregatedDemandPerAllocationKey")]
    public partial class AggregatedDemandPerAllocationKey : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AggregatedDemandPerAllocationKey object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="deliveringSiteId">Initial value of DeliveringSiteId.</param>
        /// <param name="productAllocationKeyId">Initial value of ProductAllocationKeyId.</param>
        /// <param name="demandDate">Initial value of DemandDate.</param>
        /// <param name="demandQuantityConfidenceIntervalUpperBound">Initial value of DemandQuantityConfidenceIntervalUpperBound.</param>
        /// <param name="demandQuantity">Initial value of DemandQuantity.</param>
        /// <param name="demandQuantityConfidenceIntervalLowerBound">Initial value of DemandQuantityConfidenceIntervalLowerBound.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AggregatedDemandPerAllocationKey CreateAggregatedDemandPerAllocationKey(string dataAreaId, 
                    string deliveringSiteId, 
                    string productAllocationKeyId, 
                    global::System.DateTimeOffset demandDate, 
                    decimal demandQuantityConfidenceIntervalUpperBound, 
                    decimal demandQuantity, 
                    decimal demandQuantityConfidenceIntervalLowerBound)
        {
            AggregatedDemandPerAllocationKey aggregatedDemandPerAllocationKey = new AggregatedDemandPerAllocationKey();
            aggregatedDemandPerAllocationKey.DataAreaId = dataAreaId;
            aggregatedDemandPerAllocationKey.DeliveringSiteId = deliveringSiteId;
            aggregatedDemandPerAllocationKey.ProductAllocationKeyId = productAllocationKeyId;
            aggregatedDemandPerAllocationKey.DemandDate = demandDate;
            aggregatedDemandPerAllocationKey.DemandQuantityConfidenceIntervalUpperBound = demandQuantityConfidenceIntervalUpperBound;
            aggregatedDemandPerAllocationKey.DemandQuantity = demandQuantity;
            aggregatedDemandPerAllocationKey.DemandQuantityConfidenceIntervalLowerBound = demandQuantityConfidenceIntervalLowerBound;
            return aggregatedDemandPerAllocationKey;
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
        /// There are no comments for Property DemandCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DemandCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ReqDemPlanDemandCategory> DemandCategory
        {
            get
            {
                return this._DemandCategory;
            }
            set
            {
                this.OnDemandCategoryChanging(value);
                this._DemandCategory = value;
                this.OnDemandCategoryChanged();
                this.OnPropertyChanged("DemandCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ReqDemPlanDemandCategory> _DemandCategory;
        partial void OnDemandCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ReqDemPlanDemandCategory> value);
        partial void OnDemandCategoryChanged();
        /// <summary>
        /// There are no comments for Property DeliveringSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveringSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeliveringSiteId is required.")]
        public virtual string DeliveringSiteId
        {
            get
            {
                return this._DeliveringSiteId;
            }
            set
            {
                this.OnDeliveringSiteIdChanging(value);
                this._DeliveringSiteId = value;
                this.OnDeliveringSiteIdChanged();
                this.OnPropertyChanged("DeliveringSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveringSiteId;
        partial void OnDeliveringSiteIdChanging(string value);
        partial void OnDeliveringSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductAllocationKeyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductAllocationKeyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductAllocationKeyId is required.")]
        public virtual string ProductAllocationKeyId
        {
            get
            {
                return this._ProductAllocationKeyId;
            }
            set
            {
                this.OnProductAllocationKeyIdChanging(value);
                this._ProductAllocationKeyId = value;
                this.OnProductAllocationKeyIdChanged();
                this.OnPropertyChanged("ProductAllocationKeyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductAllocationKeyId;
        partial void OnProductAllocationKeyIdChanging(string value);
        partial void OnProductAllocationKeyIdChanged();
        /// <summary>
        /// There are no comments for Property DemandDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DemandDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DemandDate is required.")]
        public virtual global::System.DateTimeOffset DemandDate
        {
            get
            {
                return this._DemandDate;
            }
            set
            {
                this.OnDemandDateChanging(value);
                this._DemandDate = value;
                this.OnDemandDateChanged();
                this.OnPropertyChanged("DemandDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DemandDate;
        partial void OnDemandDateChanging(global::System.DateTimeOffset value);
        partial void OnDemandDateChanged();
        /// <summary>
        /// There are no comments for Property DemandQuantityConfidenceIntervalUpperBound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DemandQuantityConfidenceIntervalUpperBound")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DemandQuantityConfidenceIntervalUpperBound is required.")]
        public virtual decimal DemandQuantityConfidenceIntervalUpperBound
        {
            get
            {
                return this._DemandQuantityConfidenceIntervalUpperBound;
            }
            set
            {
                this.OnDemandQuantityConfidenceIntervalUpperBoundChanging(value);
                this._DemandQuantityConfidenceIntervalUpperBound = value;
                this.OnDemandQuantityConfidenceIntervalUpperBoundChanged();
                this.OnPropertyChanged("DemandQuantityConfidenceIntervalUpperBound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DemandQuantityConfidenceIntervalUpperBound;
        partial void OnDemandQuantityConfidenceIntervalUpperBoundChanging(decimal value);
        partial void OnDemandQuantityConfidenceIntervalUpperBoundChanged();
        /// <summary>
        /// There are no comments for Property DemandQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DemandQuantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DemandQuantity is required.")]
        public virtual decimal DemandQuantity
        {
            get
            {
                return this._DemandQuantity;
            }
            set
            {
                this.OnDemandQuantityChanging(value);
                this._DemandQuantity = value;
                this.OnDemandQuantityChanged();
                this.OnPropertyChanged("DemandQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DemandQuantity;
        partial void OnDemandQuantityChanging(decimal value);
        partial void OnDemandQuantityChanged();
        /// <summary>
        /// There are no comments for Property DemandQuantityConfidenceIntervalLowerBound in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DemandQuantityConfidenceIntervalLowerBound")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DemandQuantityConfidenceIntervalLowerBound is required.")]
        public virtual decimal DemandQuantityConfidenceIntervalLowerBound
        {
            get
            {
                return this._DemandQuantityConfidenceIntervalLowerBound;
            }
            set
            {
                this.OnDemandQuantityConfidenceIntervalLowerBoundChanging(value);
                this._DemandQuantityConfidenceIntervalLowerBound = value;
                this.OnDemandQuantityConfidenceIntervalLowerBoundChanged();
                this.OnPropertyChanged("DemandQuantityConfidenceIntervalLowerBound");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DemandQuantityConfidenceIntervalLowerBound;
        partial void OnDemandQuantityConfidenceIntervalLowerBoundChanging(decimal value);
        partial void OnDemandQuantityConfidenceIntervalLowerBoundChanged();
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
