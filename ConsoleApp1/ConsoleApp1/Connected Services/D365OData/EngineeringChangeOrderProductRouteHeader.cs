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
    /// There are no comments for EngineeringChangeOrderProductRouteHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductRouteHeaderSingle")]
    public partial class EngineeringChangeOrderProductRouteHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteHeader>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductRouteHeaderSingle object.
        /// </summary>
        public EngineeringChangeOrderProductRouteHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRouteHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductRouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductRouteOperations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation> EngineeringChangeOrderProductRouteOperations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductRouteOperations == null))
                {
                    this._EngineeringChangeOrderProductRouteOperations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation>(GetPath("EngineeringChangeOrderProductRouteOperations"));
                }
                return this._EngineeringChangeOrderProductRouteOperations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation> _EngineeringChangeOrderProductRouteOperations;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProduct")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle EngineeringChangeOrderProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProduct == null))
                {
                    this._EngineeringChangeOrderProduct = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle(this.Context, GetPath("EngineeringChangeOrderProduct"));
                }
                return this._EngineeringChangeOrderProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle _EngineeringChangeOrderProduct;
        /// <summary>
        /// There are no comments for ApproverWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApproverWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApproverWorker == null))
                {
                    this._ApproverWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApproverWorker"));
                }
                return this._ApproverWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApproverWorker;
    }
    /// <summary>
    /// There are no comments for EngineeringChangeOrderProductRouteHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// ProductionSiteId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "ProductionSiteId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductRouteHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductRouteHeader")]
    public partial class EngineeringChangeOrderProductRouteHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRouteHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="productionSiteId">Initial value of ProductionSiteId.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRouteHeader CreateEngineeringChangeOrderProductRouteHeader(string dataAreaId, string engineeringChangeOrderNumber, decimal engineeringChangeOrderProductLineNumber, string productionSiteId, global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductRouteHeader engineeringChangeOrderProductRouteHeader = new EngineeringChangeOrderProductRouteHeader();
            engineeringChangeOrderProductRouteHeader.DataAreaId = dataAreaId;
            engineeringChangeOrderProductRouteHeader.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRouteHeader.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRouteHeader.ProductionSiteId = productionSiteId;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductRouteHeader.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductRouteHeader;
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
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderNumber is required.")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductLineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderProductLineNumber is required.")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionSiteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductionSiteId is required.")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductGroupId")]
        public virtual string ProductGroupId
        {
            get
            {
                return this._ProductGroupId;
            }
            set
            {
                this.OnProductGroupIdChanging(value);
                this._ProductGroupId = value;
                this.OnProductGroupIdChanged();
                this.OnPropertyChanged("ProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductGroupId;
        partial void OnProductGroupIdChanging(string value);
        partial void OnProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property RouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteId")]
        public virtual string RouteId
        {
            get
            {
                return this._RouteId;
            }
            set
            {
                this.OnRouteIdChanging(value);
                this._RouteId = value;
                this.OnRouteIdChanged();
                this.OnPropertyChanged("RouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteId;
        partial void OnRouteIdChanging(string value);
        partial void OnRouteIdChanged();
        /// <summary>
        /// There are no comments for Property RouteName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteName")]
        public virtual string RouteName
        {
            get
            {
                return this._RouteName;
            }
            set
            {
                this.OnRouteNameChanging(value);
                this._RouteName = value;
                this.OnRouteNameChanged();
                this.OnPropertyChanged("RouteName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RouteName;
        partial void OnRouteNameChanging(string value);
        partial void OnRouteNameChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverPersonnelNumber")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsApproved")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductRouteOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProductRouteOperations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation> EngineeringChangeOrderProductRouteOperations
        {
            get
            {
                return this._EngineeringChangeOrderProductRouteOperations;
            }
            set
            {
                this.OnEngineeringChangeOrderProductRouteOperationsChanging(value);
                this._EngineeringChangeOrderProductRouteOperations = value;
                this.OnEngineeringChangeOrderProductRouteOperationsChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductRouteOperations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation> _EngineeringChangeOrderProductRouteOperations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductRouteOperationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRouteOperation> value);
        partial void OnEngineeringChangeOrderProductRouteOperationsChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EngineeringChangeOrderProduct")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderProduct is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct EngineeringChangeOrderProduct
        {
            get
            {
                return this._EngineeringChangeOrderProduct;
            }
            set
            {
                this.OnEngineeringChangeOrderProductChanging(value);
                this._EngineeringChangeOrderProduct = value;
                this.OnEngineeringChangeOrderProductChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct _EngineeringChangeOrderProduct;
        partial void OnEngineeringChangeOrderProductChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct value);
        partial void OnEngineeringChangeOrderProductChanged();
        /// <summary>
        /// There are no comments for Property ApproverWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApproverWorker
        {
            get
            {
                return this._ApproverWorker;
            }
            set
            {
                this.OnApproverWorkerChanging(value);
                this._ApproverWorker = value;
                this.OnApproverWorkerChanged();
                this.OnPropertyChanged("ApproverWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApproverWorker;
        partial void OnApproverWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApproverWorkerChanged();
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
