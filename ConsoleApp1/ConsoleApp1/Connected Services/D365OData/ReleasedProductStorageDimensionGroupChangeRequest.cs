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
    /// There are no comments for ReleasedProductStorageDimensionGroupChangeRequestSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductStorageDimensionGroupChangeRequestSingle")]
    public partial class ReleasedProductStorageDimensionGroupChangeRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductStorageDimensionGroupChangeRequest>
    {
        /// <summary>
        /// Initialize a new ReleasedProductStorageDimensionGroupChangeRequestSingle object.
        /// </summary>
        public ReleasedProductStorageDimensionGroupChangeRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedProductStorageDimensionGroupChangeRequestSingle object.
        /// </summary>
        public ReleasedProductStorageDimensionGroupChangeRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedProductStorageDimensionGroupChangeRequestSingle object.
        /// </summary>
        public ReleasedProductStorageDimensionGroupChangeRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductStorageDimensionGroupChangeRequest> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ReleasedProductStorageDimensionGroupChangeRequest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ItemNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ItemNumber")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedProductStorageDimensionGroupChangeRequests")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductStorageDimensionGroupChangeRequest")]
    public partial class ReleasedProductStorageDimensionGroupChangeRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedProductStorageDimensionGroupChangeRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedProductStorageDimensionGroupChangeRequest CreateReleasedProductStorageDimensionGroupChangeRequest(string dataAreaId, string itemNumber)
        {
            ReleasedProductStorageDimensionGroupChangeRequest releasedProductStorageDimensionGroupChangeRequest = new ReleasedProductStorageDimensionGroupChangeRequest();
            releasedProductStorageDimensionGroupChangeRequest.DataAreaId = dataAreaId;
            releasedProductStorageDimensionGroupChangeRequest.ItemNumber = itemNumber;
            return releasedProductStorageDimensionGroupChangeRequest;
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
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemNumber is required.")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property StorageDimensionGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StorageDimensionGroupName")]
        public virtual string StorageDimensionGroupName
        {
            get
            {
                return this._StorageDimensionGroupName;
            }
            set
            {
                this.OnStorageDimensionGroupNameChanging(value);
                this._StorageDimensionGroupName = value;
                this.OnStorageDimensionGroupNameChanged();
                this.OnPropertyChanged("StorageDimensionGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StorageDimensionGroupName;
        partial void OnStorageDimensionGroupNameChanging(string value);
        partial void OnStorageDimensionGroupNameChanged();
        /// <summary>
        /// There are no comments for Property InventoryReservationHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryReservationHierarchyName")]
        public virtual string InventoryReservationHierarchyName
        {
            get
            {
                return this._InventoryReservationHierarchyName;
            }
            set
            {
                this.OnInventoryReservationHierarchyNameChanging(value);
                this._InventoryReservationHierarchyName = value;
                this.OnInventoryReservationHierarchyNameChanged();
                this.OnPropertyChanged("InventoryReservationHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryReservationHierarchyName;
        partial void OnInventoryReservationHierarchyNameChanging(string value);
        partial void OnInventoryReservationHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property IsProductUpdated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsProductUpdated")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProductUpdated
        {
            get
            {
                return this._IsProductUpdated;
            }
            set
            {
                this.OnIsProductUpdatedChanging(value);
                this._IsProductUpdated = value;
                this.OnIsProductUpdatedChanged();
                this.OnPropertyChanged("IsProductUpdated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProductUpdated;
        partial void OnIsProductUpdatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProductUpdatedChanged();
        /// <summary>
        /// There are no comments for Property CatchWeightItemHandlingPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CatchWeightItemHandlingPolicyName")]
        public virtual string CatchWeightItemHandlingPolicyName
        {
            get
            {
                return this._CatchWeightItemHandlingPolicyName;
            }
            set
            {
                this.OnCatchWeightItemHandlingPolicyNameChanging(value);
                this._CatchWeightItemHandlingPolicyName = value;
                this.OnCatchWeightItemHandlingPolicyNameChanged();
                this.OnPropertyChanged("CatchWeightItemHandlingPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CatchWeightItemHandlingPolicyName;
        partial void OnCatchWeightItemHandlingPolicyNameChanging(string value);
        partial void OnCatchWeightItemHandlingPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasureConversionSequenceGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitOfMeasureConversionSequenceGroupId")]
        public virtual string UnitOfMeasureConversionSequenceGroupId
        {
            get
            {
                return this._UnitOfMeasureConversionSequenceGroupId;
            }
            set
            {
                this.OnUnitOfMeasureConversionSequenceGroupIdChanging(value);
                this._UnitOfMeasureConversionSequenceGroupId = value;
                this.OnUnitOfMeasureConversionSequenceGroupIdChanged();
                this.OnPropertyChanged("UnitOfMeasureConversionSequenceGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasureConversionSequenceGroupId;
        partial void OnUnitOfMeasureConversionSequenceGroupIdChanging(string value);
        partial void OnUnitOfMeasureConversionSequenceGroupIdChanged();
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