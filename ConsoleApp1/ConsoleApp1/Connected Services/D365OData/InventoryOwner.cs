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
    /// There are no comments for InventoryOwnerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOwnerSingle")]
    public partial class InventoryOwnerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryOwner>
    {
        /// <summary>
        /// Initialize a new InventoryOwnerSingle object.
        /// </summary>
        public InventoryOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventoryOwnerSingle object.
        /// </summary>
        public InventoryOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventoryOwnerSingle object.
        /// </summary>
        public InventoryOwnerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryOwner> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InventoryCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryCountingJournalLines")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryCountingJournalLines == null))
                {
                    this._InventoryCountingJournalLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(GetPath("InventoryCountingJournalLines"));
                }
                return this._InventoryCountingJournalLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLines;
        /// <summary>
        /// There are no comments for InventoryTagCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryTagCountingJournalLines")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine> InventoryTagCountingJournalLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InventoryTagCountingJournalLines == null))
                {
                    this._InventoryTagCountingJournalLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine>(GetPath("InventoryTagCountingJournalLines"));
                }
                return this._InventoryTagCountingJournalLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine> _InventoryTagCountingJournalLines;
    }
    /// <summary>
    /// There are no comments for InventoryOwner in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InventoryOwnerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InventoryOwnerId")]
    [global::Microsoft.OData.Client.EntitySet("InventoryOwners")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOwner")]
    public partial class InventoryOwner : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventoryOwner object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="inventoryOwnerId">Initial value of InventoryOwnerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventoryOwner CreateInventoryOwner(string dataAreaId, string inventoryOwnerId)
        {
            InventoryOwner inventoryOwner = new InventoryOwner();
            inventoryOwner.DataAreaId = dataAreaId;
            inventoryOwner.InventoryOwnerId = inventoryOwnerId;
            return inventoryOwner;
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
        /// There are no comments for Property InventoryOwnerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOwnerId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InventoryOwnerId is required.")]
        public virtual string InventoryOwnerId
        {
            get
            {
                return this._InventoryOwnerId;
            }
            set
            {
                this.OnInventoryOwnerIdChanging(value);
                this._InventoryOwnerId = value;
                this.OnInventoryOwnerIdChanged();
                this.OnPropertyChanged("InventoryOwnerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryOwnerId;
        partial void OnInventoryOwnerIdChanging(string value);
        partial void OnInventoryOwnerIdChanged();
        /// <summary>
        /// There are no comments for Property InventoryOwnerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOwnerName")]
        public virtual string InventoryOwnerName
        {
            get
            {
                return this._InventoryOwnerName;
            }
            set
            {
                this.OnInventoryOwnerNameChanging(value);
                this._InventoryOwnerName = value;
                this.OnInventoryOwnerNameChanged();
                this.OnPropertyChanged("InventoryOwnerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryOwnerName;
        partial void OnInventoryOwnerNameChanging(string value);
        partial void OnInventoryOwnerNameChanged();
        /// <summary>
        /// There are no comments for Property InventoryCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryCountingJournalLines")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> InventoryCountingJournalLines
        {
            get
            {
                return this._InventoryCountingJournalLines;
            }
            set
            {
                this.OnInventoryCountingJournalLinesChanging(value);
                this._InventoryCountingJournalLines = value;
                this.OnInventoryCountingJournalLinesChanged();
                this.OnPropertyChanged("InventoryCountingJournalLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> _InventoryCountingJournalLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInventoryCountingJournalLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryCountingJournalLine> value);
        partial void OnInventoryCountingJournalLinesChanged();
        /// <summary>
        /// There are no comments for Property InventoryTagCountingJournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryTagCountingJournalLines")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine> InventoryTagCountingJournalLines
        {
            get
            {
                return this._InventoryTagCountingJournalLines;
            }
            set
            {
                this.OnInventoryTagCountingJournalLinesChanging(value);
                this._InventoryTagCountingJournalLines = value;
                this.OnInventoryTagCountingJournalLinesChanged();
                this.OnPropertyChanged("InventoryTagCountingJournalLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine> _InventoryTagCountingJournalLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnInventoryTagCountingJournalLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventoryTagCountingJournalLine> value);
        partial void OnInventoryTagCountingJournalLinesChanged();
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
