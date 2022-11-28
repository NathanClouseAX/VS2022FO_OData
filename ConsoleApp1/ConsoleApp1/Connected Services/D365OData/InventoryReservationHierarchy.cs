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
    /// There are no comments for InventoryReservationHierarchySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryReservationHierarchySingle")]
    public partial class InventoryReservationHierarchySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryReservationHierarchy>
    {
        /// <summary>
        /// Initialize a new InventoryReservationHierarchySingle object.
        /// </summary>
        public InventoryReservationHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventoryReservationHierarchySingle object.
        /// </summary>
        public InventoryReservationHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventoryReservationHierarchySingle object.
        /// </summary>
        public InventoryReservationHierarchySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryReservationHierarchy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
    /// <summary>
    /// There are no comments for InventoryReservationHierarchy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// HierarchyName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HierarchyName")]
    [global::Microsoft.OData.Client.EntitySet("InventoryReservationHierarchies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryReservationHierarchy")]
    public partial class InventoryReservationHierarchy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventoryReservationHierarchy object.
        /// </summary>
        /// <param name="hierarchyName">Initial value of HierarchyName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventoryReservationHierarchy CreateInventoryReservationHierarchy(string hierarchyName)
        {
            InventoryReservationHierarchy inventoryReservationHierarchy = new InventoryReservationHierarchy();
            inventoryReservationHierarchy.HierarchyName = hierarchyName;
            return inventoryReservationHierarchy;
        }
        /// <summary>
        /// There are no comments for Property HierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HierarchyName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "HierarchyName is required.")]
        public virtual string HierarchyName
        {
            get
            {
                return this._HierarchyName;
            }
            set
            {
                this.OnHierarchyNameChanging(value);
                this._HierarchyName = value;
                this.OnHierarchyNameChanged();
                this.OnPropertyChanged("HierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HierarchyName;
        partial void OnHierarchyNameChanging(string value);
        partial void OnHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property HierarchyDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HierarchyDescription")]
        public virtual string HierarchyDescription
        {
            get
            {
                return this._HierarchyDescription;
            }
            set
            {
                this.OnHierarchyDescriptionChanging(value);
                this._HierarchyDescription = value;
                this.OnHierarchyDescriptionChanged();
                this.OnPropertyChanged("HierarchyDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HierarchyDescription;
        partial void OnHierarchyDescriptionChanging(string value);
        partial void OnHierarchyDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReleasedProductsV2")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
