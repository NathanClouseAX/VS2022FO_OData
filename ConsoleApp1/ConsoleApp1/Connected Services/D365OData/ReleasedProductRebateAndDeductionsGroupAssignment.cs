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
    /// There are no comments for ReleasedProductRebateAndDeductionsGroupAssignmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductRebateAndDeductionsGroupAssignmentSingle")]
    public partial class ReleasedProductRebateAndDeductionsGroupAssignmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductRebateAndDeductionsGroupAssignment>
    {
        /// <summary>
        /// Initialize a new ReleasedProductRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public ReleasedProductRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedProductRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public ReleasedProductRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedProductRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public ReleasedProductRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedProductRebateAndDeductionsGroupAssignment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductRebateAndDeductionsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductRebateAndDeductionsGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroupSingle ReleasedProductRebateAndDeductionsGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductRebateAndDeductionsGroup == null))
                {
                    this._ReleasedProductRebateAndDeductionsGroup = new global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroupSingle(this.Context, GetPath("ReleasedProductRebateAndDeductionsGroup"));
                }
                return this._ReleasedProductRebateAndDeductionsGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroupSingle _ReleasedProductRebateAndDeductionsGroup;
        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
    }
    /// <summary>
    /// There are no comments for ReleasedProductRebateAndDeductionsGroupAssignment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProductRebateAndDeductionsGroupId
    /// ItemNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductRebateAndDeductionsGroupId", "ItemNumber")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedProductRebateAndDeductionsGroupAssignments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductRebateAndDeductionsGroupAssignment")]
    public partial class ReleasedProductRebateAndDeductionsGroupAssignment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedProductRebateAndDeductionsGroupAssignment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="productRebateAndDeductionsGroupId">Initial value of ProductRebateAndDeductionsGroupId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="releasedProductRebateAndDeductionsGroup">Initial value of ReleasedProductRebateAndDeductionsGroup.</param>
        /// <param name="releasedProductV2">Initial value of ReleasedProductV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedProductRebateAndDeductionsGroupAssignment CreateReleasedProductRebateAndDeductionsGroupAssignment(string dataAreaId, string productRebateAndDeductionsGroupId, string itemNumber, global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroup releasedProductRebateAndDeductionsGroup, global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProductV2)
        {
            ReleasedProductRebateAndDeductionsGroupAssignment releasedProductRebateAndDeductionsGroupAssignment = new ReleasedProductRebateAndDeductionsGroupAssignment();
            releasedProductRebateAndDeductionsGroupAssignment.DataAreaId = dataAreaId;
            releasedProductRebateAndDeductionsGroupAssignment.ProductRebateAndDeductionsGroupId = productRebateAndDeductionsGroupId;
            releasedProductRebateAndDeductionsGroupAssignment.ItemNumber = itemNumber;
            if ((releasedProductRebateAndDeductionsGroup == null))
            {
                throw new global::System.ArgumentNullException("releasedProductRebateAndDeductionsGroup");
            }
            releasedProductRebateAndDeductionsGroupAssignment.ReleasedProductRebateAndDeductionsGroup = releasedProductRebateAndDeductionsGroup;
            if ((releasedProductV2 == null))
            {
                throw new global::System.ArgumentNullException("releasedProductV2");
            }
            releasedProductRebateAndDeductionsGroupAssignment.ReleasedProductV2 = releasedProductV2;
            return releasedProductRebateAndDeductionsGroupAssignment;
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
        /// There are no comments for Property ProductRebateAndDeductionsGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductRebateAndDeductionsGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductRebateAndDeductionsGroupId is required.")]
        public virtual string ProductRebateAndDeductionsGroupId
        {
            get
            {
                return this._ProductRebateAndDeductionsGroupId;
            }
            set
            {
                this.OnProductRebateAndDeductionsGroupIdChanging(value);
                this._ProductRebateAndDeductionsGroupId = value;
                this.OnProductRebateAndDeductionsGroupIdChanged();
                this.OnPropertyChanged("ProductRebateAndDeductionsGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductRebateAndDeductionsGroupId;
        partial void OnProductRebateAndDeductionsGroupIdChanging(string value);
        partial void OnProductRebateAndDeductionsGroupIdChanged();
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
        /// There are no comments for Property ReleasedProductRebateAndDeductionsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductRebateAndDeductionsGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductRebateAndDeductionsGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroup ReleasedProductRebateAndDeductionsGroup
        {
            get
            {
                return this._ReleasedProductRebateAndDeductionsGroup;
            }
            set
            {
                this.OnReleasedProductRebateAndDeductionsGroupChanging(value);
                this._ReleasedProductRebateAndDeductionsGroup = value;
                this.OnReleasedProductRebateAndDeductionsGroupChanged();
                this.OnPropertyChanged("ReleasedProductRebateAndDeductionsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroup _ReleasedProductRebateAndDeductionsGroup;
        partial void OnReleasedProductRebateAndDeductionsGroupChanging(global::Microsoft.Dynamics.DataEntities.ProductRebateAndDeductionsGroup value);
        partial void OnReleasedProductRebateAndDeductionsGroupChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReleasedProductV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
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
